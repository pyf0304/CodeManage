
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseExamPaperRelationship4AppBL
 表名:vcc_CourseExamPaperRelationship4App(01120256)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:30:48
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
 框架-层名:业务逻辑层(CS)(BusinessLogic,0003)
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
public static class  clsvcc_CourseExamPaperRelationship4AppBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN GetObj(this K_mId_vcc_CourseExamPaperRelationship4App myKey)
{
clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN = clsvcc_CourseExamPaperRelationship4AppBL.vcc_CourseExamPaperRelationship4AppDA.GetObjBymId(myKey.Value);
return objvcc_CourseExamPaperRelationship4AppEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetmId(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, long lngmId, string strComparisonOp="")
	{
objvcc_CourseExamPaperRelationship4AppEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship4App.mId) == false)
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship4App.mId, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.mId] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationship4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetCourseExamPaperId(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseExamPaperId, convcc_CourseExamPaperRelationship4App.CourseExamPaperId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, convcc_CourseExamPaperRelationship4App.CourseExamPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, convcc_CourseExamPaperRelationship4App.CourseExamPaperId);
}
objvcc_CourseExamPaperRelationship4AppEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship4App.CourseExamPaperId) == false)
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship4App.CourseExamPaperId, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.CourseExamPaperId] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationship4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetExamPaperName(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strExamPaperName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamPaperName, 500, convcc_CourseExamPaperRelationship4App.ExamPaperName);
}
objvcc_CourseExamPaperRelationship4AppEN.ExamPaperName = strExamPaperName; //考卷名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship4App.ExamPaperName) == false)
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship4App.ExamPaperName, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.ExamPaperName] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationship4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetCourseId(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convcc_CourseExamPaperRelationship4App.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_CourseExamPaperRelationship4App.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_CourseExamPaperRelationship4App.CourseId);
}
objvcc_CourseExamPaperRelationship4AppEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship4App.CourseId) == false)
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship4App.CourseId, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.CourseId] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationship4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetCourseName(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_CourseExamPaperRelationship4App.CourseName);
}
objvcc_CourseExamPaperRelationship4AppEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship4App.CourseName) == false)
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship4App.CourseName, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.CourseName] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationship4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetQuestionId(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, long lngQuestionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngQuestionId, convcc_CourseExamPaperRelationship4App.QuestionId);
objvcc_CourseExamPaperRelationship4AppEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship4App.QuestionId) == false)
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship4App.QuestionId, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.QuestionId] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationship4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetQuestionIndex(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, int? intQuestionIndex, string strComparisonOp="")
	{
objvcc_CourseExamPaperRelationship4AppEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship4App.QuestionIndex) == false)
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship4App.QuestionIndex, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.QuestionIndex] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationship4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetQuestionName(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strQuestionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionName, 500, convcc_CourseExamPaperRelationship4App.QuestionName);
}
objvcc_CourseExamPaperRelationship4AppEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship4App.QuestionName) == false)
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship4App.QuestionName, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.QuestionName] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationship4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetQuestionTypeId(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strQuestionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convcc_CourseExamPaperRelationship4App.QuestionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convcc_CourseExamPaperRelationship4App.QuestionTypeId);
}
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship4App.QuestionTypeId) == false)
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship4App.QuestionTypeId, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.QuestionTypeId] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationship4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetQuestionTypeName(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strQuestionTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convcc_CourseExamPaperRelationship4App.QuestionTypeName);
}
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship4App.QuestionTypeName) == false)
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship4App.QuestionTypeName, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.QuestionTypeName] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationship4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetExamGradeId(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strExamGradeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamGradeId, 2, convcc_CourseExamPaperRelationship4App.ExamGradeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strExamGradeId, 2, convcc_CourseExamPaperRelationship4App.ExamGradeId);
}
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeId = strExamGradeId; //题库等级ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship4App.ExamGradeId) == false)
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship4App.ExamGradeId, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.ExamGradeId] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationship4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetExamGradeName(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strExamGradeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamGradeName, 50, convcc_CourseExamPaperRelationship4App.ExamGradeName);
}
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeName = strExamGradeName; //题库等级名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship4App.ExamGradeName) == false)
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship4App.ExamGradeName, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.ExamGradeName] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationship4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetQuestionScore(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, float? fltQuestionScore, string strComparisonOp="")
	{
objvcc_CourseExamPaperRelationship4AppEN.QuestionScore = fltQuestionScore; //题目得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship4App.QuestionScore) == false)
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship4App.QuestionScore, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.QuestionScore] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationship4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetIsEffective(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, bool bolIsEffective, string strComparisonOp="")
	{
objvcc_CourseExamPaperRelationship4AppEN.IsEffective = bolIsEffective; //是否有效
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship4App.IsEffective) == false)
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship4App.IsEffective, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.IsEffective] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationship4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetUserId(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convcc_CourseExamPaperRelationship4App.UserId);
}
objvcc_CourseExamPaperRelationship4AppEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship4App.UserId) == false)
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship4App.UserId, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.UserId] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationship4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetStartTime(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, double? dblStartTime, string strComparisonOp="")
	{
objvcc_CourseExamPaperRelationship4AppEN.StartTime = dblStartTime; //开始时间(s)
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship4App.StartTime) == false)
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship4App.StartTime, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.StartTime] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationship4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetPapersBigTopicId(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strPapersBigTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPapersBigTopicId, 8, convcc_CourseExamPaperRelationship4App.PapersBigTopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPapersBigTopicId, 8, convcc_CourseExamPaperRelationship4App.PapersBigTopicId);
}
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicId = strPapersBigTopicId; //试卷大题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship4App.PapersBigTopicId) == false)
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship4App.PapersBigTopicId, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.PapersBigTopicId] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationship4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetPapersBigTopicName(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strPapersBigTopicName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPapersBigTopicName, 50, convcc_CourseExamPaperRelationship4App.PapersBigTopicName);
}
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicName = strPapersBigTopicName; //试卷大题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship4App.PapersBigTopicName) == false)
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship4App.PapersBigTopicName, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.PapersBigTopicName] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationship4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetTopicDescription(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strTopicDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicDescription, 100, convcc_CourseExamPaperRelationship4App.TopicDescription);
}
objvcc_CourseExamPaperRelationship4AppEN.TopicDescription = strTopicDescription; //标题描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship4App.TopicDescription) == false)
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship4App.TopicDescription, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.TopicDescription] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationship4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetTopicScores(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, int? intTopicScores, string strComparisonOp="")
	{
objvcc_CourseExamPaperRelationship4AppEN.TopicScores = intTopicScores; //大题得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship4App.TopicScores) == false)
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship4App.TopicScores, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.TopicScores] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationship4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetTopicOrderNum(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, int? intTopicOrderNum, string strComparisonOp="")
	{
objvcc_CourseExamPaperRelationship4AppEN.TopicOrderNum = intTopicOrderNum; //TopicOrderNum
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship4App.TopicOrderNum) == false)
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship4App.TopicOrderNum, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.TopicOrderNum] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationship4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetOrderNum(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convcc_CourseExamPaperRelationship4App.OrderNum);
objvcc_CourseExamPaperRelationship4AppEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship4App.OrderNum) == false)
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship4App.OrderNum, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.OrderNum] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationship4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetUpdDate(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_CourseExamPaperRelationship4App.UpdDate);
}
objvcc_CourseExamPaperRelationship4AppEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship4App.UpdDate) == false)
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship4App.UpdDate, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.UpdDate] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationship4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetUpdUser(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convcc_CourseExamPaperRelationship4App.UpdUser);
}
objvcc_CourseExamPaperRelationship4AppEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship4App.UpdUser) == false)
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship4App.UpdUser, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.UpdUser] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationship4AppEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppENS">源对象</param>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppENT">目标对象</param>
 public static void CopyTo(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppENS, clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppENT)
{
try
{
objvcc_CourseExamPaperRelationship4AppENT.mId = objvcc_CourseExamPaperRelationship4AppENS.mId; //mId
objvcc_CourseExamPaperRelationship4AppENT.CourseExamPaperId = objvcc_CourseExamPaperRelationship4AppENS.CourseExamPaperId; //考卷流水号
objvcc_CourseExamPaperRelationship4AppENT.ExamPaperName = objvcc_CourseExamPaperRelationship4AppENS.ExamPaperName; //考卷名称
objvcc_CourseExamPaperRelationship4AppENT.CourseId = objvcc_CourseExamPaperRelationship4AppENS.CourseId; //课程Id
objvcc_CourseExamPaperRelationship4AppENT.CourseName = objvcc_CourseExamPaperRelationship4AppENS.CourseName; //课程名称
objvcc_CourseExamPaperRelationship4AppENT.QuestionId = objvcc_CourseExamPaperRelationship4AppENS.QuestionId; //题目Id
objvcc_CourseExamPaperRelationship4AppENT.QuestionIndex = objvcc_CourseExamPaperRelationship4AppENS.QuestionIndex; //题目序号
objvcc_CourseExamPaperRelationship4AppENT.QuestionName = objvcc_CourseExamPaperRelationship4AppENS.QuestionName; //题目名称
objvcc_CourseExamPaperRelationship4AppENT.QuestionTypeId = objvcc_CourseExamPaperRelationship4AppENS.QuestionTypeId; //题目类型Id
objvcc_CourseExamPaperRelationship4AppENT.QuestionTypeName = objvcc_CourseExamPaperRelationship4AppENS.QuestionTypeName; //题目类型名
objvcc_CourseExamPaperRelationship4AppENT.ExamGradeId = objvcc_CourseExamPaperRelationship4AppENS.ExamGradeId; //题库等级ID
objvcc_CourseExamPaperRelationship4AppENT.ExamGradeName = objvcc_CourseExamPaperRelationship4AppENS.ExamGradeName; //题库等级名
objvcc_CourseExamPaperRelationship4AppENT.QuestionScore = objvcc_CourseExamPaperRelationship4AppENS.QuestionScore; //题目得分
objvcc_CourseExamPaperRelationship4AppENT.IsEffective = objvcc_CourseExamPaperRelationship4AppENS.IsEffective; //是否有效
objvcc_CourseExamPaperRelationship4AppENT.UserId = objvcc_CourseExamPaperRelationship4AppENS.UserId; //用户ID
objvcc_CourseExamPaperRelationship4AppENT.StartTime = objvcc_CourseExamPaperRelationship4AppENS.StartTime; //开始时间(s)
objvcc_CourseExamPaperRelationship4AppENT.PapersBigTopicId = objvcc_CourseExamPaperRelationship4AppENS.PapersBigTopicId; //试卷大题目Id
objvcc_CourseExamPaperRelationship4AppENT.PapersBigTopicName = objvcc_CourseExamPaperRelationship4AppENS.PapersBigTopicName; //试卷大题目名称
objvcc_CourseExamPaperRelationship4AppENT.TopicDescription = objvcc_CourseExamPaperRelationship4AppENS.TopicDescription; //标题描述
objvcc_CourseExamPaperRelationship4AppENT.TopicScores = objvcc_CourseExamPaperRelationship4AppENS.TopicScores; //大题得分
objvcc_CourseExamPaperRelationship4AppENT.TopicOrderNum = objvcc_CourseExamPaperRelationship4AppENS.TopicOrderNum; //TopicOrderNum
objvcc_CourseExamPaperRelationship4AppENT.OrderNum = objvcc_CourseExamPaperRelationship4AppENS.OrderNum; //序号
objvcc_CourseExamPaperRelationship4AppENT.UpdDate = objvcc_CourseExamPaperRelationship4AppENS.UpdDate; //修改日期
objvcc_CourseExamPaperRelationship4AppENT.UpdUser = objvcc_CourseExamPaperRelationship4AppENS.UpdUser; //修改人
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
 /// <param name = "objvcc_CourseExamPaperRelationship4AppENS">源对象</param>
 /// <returns>目标对象=>clsvcc_CourseExamPaperRelationship4AppEN:objvcc_CourseExamPaperRelationship4AppENT</returns>
 public static clsvcc_CourseExamPaperRelationship4AppEN CopyTo(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppENS)
{
try
{
 clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppENT = new clsvcc_CourseExamPaperRelationship4AppEN()
{
mId = objvcc_CourseExamPaperRelationship4AppENS.mId, //mId
CourseExamPaperId = objvcc_CourseExamPaperRelationship4AppENS.CourseExamPaperId, //考卷流水号
ExamPaperName = objvcc_CourseExamPaperRelationship4AppENS.ExamPaperName, //考卷名称
CourseId = objvcc_CourseExamPaperRelationship4AppENS.CourseId, //课程Id
CourseName = objvcc_CourseExamPaperRelationship4AppENS.CourseName, //课程名称
QuestionId = objvcc_CourseExamPaperRelationship4AppENS.QuestionId, //题目Id
QuestionIndex = objvcc_CourseExamPaperRelationship4AppENS.QuestionIndex, //题目序号
QuestionName = objvcc_CourseExamPaperRelationship4AppENS.QuestionName, //题目名称
QuestionTypeId = objvcc_CourseExamPaperRelationship4AppENS.QuestionTypeId, //题目类型Id
QuestionTypeName = objvcc_CourseExamPaperRelationship4AppENS.QuestionTypeName, //题目类型名
ExamGradeId = objvcc_CourseExamPaperRelationship4AppENS.ExamGradeId, //题库等级ID
ExamGradeName = objvcc_CourseExamPaperRelationship4AppENS.ExamGradeName, //题库等级名
QuestionScore = objvcc_CourseExamPaperRelationship4AppENS.QuestionScore, //题目得分
IsEffective = objvcc_CourseExamPaperRelationship4AppENS.IsEffective, //是否有效
UserId = objvcc_CourseExamPaperRelationship4AppENS.UserId, //用户ID
StartTime = objvcc_CourseExamPaperRelationship4AppENS.StartTime, //开始时间(s)
PapersBigTopicId = objvcc_CourseExamPaperRelationship4AppENS.PapersBigTopicId, //试卷大题目Id
PapersBigTopicName = objvcc_CourseExamPaperRelationship4AppENS.PapersBigTopicName, //试卷大题目名称
TopicDescription = objvcc_CourseExamPaperRelationship4AppENS.TopicDescription, //标题描述
TopicScores = objvcc_CourseExamPaperRelationship4AppENS.TopicScores, //大题得分
TopicOrderNum = objvcc_CourseExamPaperRelationship4AppENS.TopicOrderNum, //TopicOrderNum
OrderNum = objvcc_CourseExamPaperRelationship4AppENS.OrderNum, //序号
UpdDate = objvcc_CourseExamPaperRelationship4AppENS.UpdDate, //修改日期
UpdUser = objvcc_CourseExamPaperRelationship4AppENS.UpdUser, //修改人
};
 return objvcc_CourseExamPaperRelationship4AppENT;
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
public static void CheckProperty4Condition(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN)
{
 clsvcc_CourseExamPaperRelationship4AppBL.vcc_CourseExamPaperRelationship4AppDA.CheckProperty4Condition(objvcc_CourseExamPaperRelationship4AppEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_CourseExamPaperRelationship4AppCond.IsUpdated(convcc_CourseExamPaperRelationship4App.mId) == true)
{
string strComparisonOpmId = objvcc_CourseExamPaperRelationship4AppCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship4App.mId, objvcc_CourseExamPaperRelationship4AppCond.mId, strComparisonOpmId);
}
if (objvcc_CourseExamPaperRelationship4AppCond.IsUpdated(convcc_CourseExamPaperRelationship4App.CourseExamPaperId) == true)
{
string strComparisonOpCourseExamPaperId = objvcc_CourseExamPaperRelationship4AppCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.CourseExamPaperId, objvcc_CourseExamPaperRelationship4AppCond.CourseExamPaperId, strComparisonOpCourseExamPaperId);
}
if (objvcc_CourseExamPaperRelationship4AppCond.IsUpdated(convcc_CourseExamPaperRelationship4App.ExamPaperName) == true)
{
string strComparisonOpExamPaperName = objvcc_CourseExamPaperRelationship4AppCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.ExamPaperName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.ExamPaperName, objvcc_CourseExamPaperRelationship4AppCond.ExamPaperName, strComparisonOpExamPaperName);
}
if (objvcc_CourseExamPaperRelationship4AppCond.IsUpdated(convcc_CourseExamPaperRelationship4App.CourseId) == true)
{
string strComparisonOpCourseId = objvcc_CourseExamPaperRelationship4AppCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.CourseId, objvcc_CourseExamPaperRelationship4AppCond.CourseId, strComparisonOpCourseId);
}
if (objvcc_CourseExamPaperRelationship4AppCond.IsUpdated(convcc_CourseExamPaperRelationship4App.CourseName) == true)
{
string strComparisonOpCourseName = objvcc_CourseExamPaperRelationship4AppCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.CourseName, objvcc_CourseExamPaperRelationship4AppCond.CourseName, strComparisonOpCourseName);
}
if (objvcc_CourseExamPaperRelationship4AppCond.IsUpdated(convcc_CourseExamPaperRelationship4App.QuestionId) == true)
{
string strComparisonOpQuestionId = objvcc_CourseExamPaperRelationship4AppCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship4App.QuestionId, objvcc_CourseExamPaperRelationship4AppCond.QuestionId, strComparisonOpQuestionId);
}
if (objvcc_CourseExamPaperRelationship4AppCond.IsUpdated(convcc_CourseExamPaperRelationship4App.QuestionIndex) == true)
{
string strComparisonOpQuestionIndex = objvcc_CourseExamPaperRelationship4AppCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship4App.QuestionIndex, objvcc_CourseExamPaperRelationship4AppCond.QuestionIndex, strComparisonOpQuestionIndex);
}
if (objvcc_CourseExamPaperRelationship4AppCond.IsUpdated(convcc_CourseExamPaperRelationship4App.QuestionName) == true)
{
string strComparisonOpQuestionName = objvcc_CourseExamPaperRelationship4AppCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.QuestionName, objvcc_CourseExamPaperRelationship4AppCond.QuestionName, strComparisonOpQuestionName);
}
if (objvcc_CourseExamPaperRelationship4AppCond.IsUpdated(convcc_CourseExamPaperRelationship4App.QuestionTypeId) == true)
{
string strComparisonOpQuestionTypeId = objvcc_CourseExamPaperRelationship4AppCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.QuestionTypeId, objvcc_CourseExamPaperRelationship4AppCond.QuestionTypeId, strComparisonOpQuestionTypeId);
}
if (objvcc_CourseExamPaperRelationship4AppCond.IsUpdated(convcc_CourseExamPaperRelationship4App.QuestionTypeName) == true)
{
string strComparisonOpQuestionTypeName = objvcc_CourseExamPaperRelationship4AppCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.QuestionTypeName, objvcc_CourseExamPaperRelationship4AppCond.QuestionTypeName, strComparisonOpQuestionTypeName);
}
if (objvcc_CourseExamPaperRelationship4AppCond.IsUpdated(convcc_CourseExamPaperRelationship4App.ExamGradeId) == true)
{
string strComparisonOpExamGradeId = objvcc_CourseExamPaperRelationship4AppCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.ExamGradeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.ExamGradeId, objvcc_CourseExamPaperRelationship4AppCond.ExamGradeId, strComparisonOpExamGradeId);
}
if (objvcc_CourseExamPaperRelationship4AppCond.IsUpdated(convcc_CourseExamPaperRelationship4App.ExamGradeName) == true)
{
string strComparisonOpExamGradeName = objvcc_CourseExamPaperRelationship4AppCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.ExamGradeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.ExamGradeName, objvcc_CourseExamPaperRelationship4AppCond.ExamGradeName, strComparisonOpExamGradeName);
}
if (objvcc_CourseExamPaperRelationship4AppCond.IsUpdated(convcc_CourseExamPaperRelationship4App.QuestionScore) == true)
{
string strComparisonOpQuestionScore = objvcc_CourseExamPaperRelationship4AppCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.QuestionScore];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship4App.QuestionScore, objvcc_CourseExamPaperRelationship4AppCond.QuestionScore, strComparisonOpQuestionScore);
}
if (objvcc_CourseExamPaperRelationship4AppCond.IsUpdated(convcc_CourseExamPaperRelationship4App.IsEffective) == true)
{
if (objvcc_CourseExamPaperRelationship4AppCond.IsEffective == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseExamPaperRelationship4App.IsEffective);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseExamPaperRelationship4App.IsEffective);
}
}
if (objvcc_CourseExamPaperRelationship4AppCond.IsUpdated(convcc_CourseExamPaperRelationship4App.UserId) == true)
{
string strComparisonOpUserId = objvcc_CourseExamPaperRelationship4AppCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.UserId, objvcc_CourseExamPaperRelationship4AppCond.UserId, strComparisonOpUserId);
}
if (objvcc_CourseExamPaperRelationship4AppCond.IsUpdated(convcc_CourseExamPaperRelationship4App.StartTime) == true)
{
string strComparisonOpStartTime = objvcc_CourseExamPaperRelationship4AppCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.StartTime];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship4App.StartTime, objvcc_CourseExamPaperRelationship4AppCond.StartTime, strComparisonOpStartTime);
}
if (objvcc_CourseExamPaperRelationship4AppCond.IsUpdated(convcc_CourseExamPaperRelationship4App.PapersBigTopicId) == true)
{
string strComparisonOpPapersBigTopicId = objvcc_CourseExamPaperRelationship4AppCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.PapersBigTopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.PapersBigTopicId, objvcc_CourseExamPaperRelationship4AppCond.PapersBigTopicId, strComparisonOpPapersBigTopicId);
}
if (objvcc_CourseExamPaperRelationship4AppCond.IsUpdated(convcc_CourseExamPaperRelationship4App.PapersBigTopicName) == true)
{
string strComparisonOpPapersBigTopicName = objvcc_CourseExamPaperRelationship4AppCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.PapersBigTopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.PapersBigTopicName, objvcc_CourseExamPaperRelationship4AppCond.PapersBigTopicName, strComparisonOpPapersBigTopicName);
}
if (objvcc_CourseExamPaperRelationship4AppCond.IsUpdated(convcc_CourseExamPaperRelationship4App.TopicDescription) == true)
{
string strComparisonOpTopicDescription = objvcc_CourseExamPaperRelationship4AppCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.TopicDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.TopicDescription, objvcc_CourseExamPaperRelationship4AppCond.TopicDescription, strComparisonOpTopicDescription);
}
if (objvcc_CourseExamPaperRelationship4AppCond.IsUpdated(convcc_CourseExamPaperRelationship4App.TopicScores) == true)
{
string strComparisonOpTopicScores = objvcc_CourseExamPaperRelationship4AppCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.TopicScores];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship4App.TopicScores, objvcc_CourseExamPaperRelationship4AppCond.TopicScores, strComparisonOpTopicScores);
}
if (objvcc_CourseExamPaperRelationship4AppCond.IsUpdated(convcc_CourseExamPaperRelationship4App.TopicOrderNum) == true)
{
string strComparisonOpTopicOrderNum = objvcc_CourseExamPaperRelationship4AppCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.TopicOrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship4App.TopicOrderNum, objvcc_CourseExamPaperRelationship4AppCond.TopicOrderNum, strComparisonOpTopicOrderNum);
}
if (objvcc_CourseExamPaperRelationship4AppCond.IsUpdated(convcc_CourseExamPaperRelationship4App.OrderNum) == true)
{
string strComparisonOpOrderNum = objvcc_CourseExamPaperRelationship4AppCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship4App.OrderNum, objvcc_CourseExamPaperRelationship4AppCond.OrderNum, strComparisonOpOrderNum);
}
if (objvcc_CourseExamPaperRelationship4AppCond.IsUpdated(convcc_CourseExamPaperRelationship4App.UpdDate) == true)
{
string strComparisonOpUpdDate = objvcc_CourseExamPaperRelationship4AppCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.UpdDate, objvcc_CourseExamPaperRelationship4AppCond.UpdDate, strComparisonOpUpdDate);
}
if (objvcc_CourseExamPaperRelationship4AppCond.IsUpdated(convcc_CourseExamPaperRelationship4App.UpdUser) == true)
{
string strComparisonOpUpdUser = objvcc_CourseExamPaperRelationship4AppCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.UpdUser, objvcc_CourseExamPaperRelationship4AppCond.UpdUser, strComparisonOpUpdUser);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcc_CourseExamPaperRelationship4App
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v题目与试卷关系4App(vcc_CourseExamPaperRelationship4App)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcc_CourseExamPaperRelationship4AppBL
{
public static RelatedActions_vcc_CourseExamPaperRelationship4App relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcc_CourseExamPaperRelationship4AppDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcc_CourseExamPaperRelationship4AppDA vcc_CourseExamPaperRelationship4AppDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcc_CourseExamPaperRelationship4AppDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcc_CourseExamPaperRelationship4AppBL()
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
if (string.IsNullOrEmpty(clsvcc_CourseExamPaperRelationship4AppEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_CourseExamPaperRelationship4AppEN._ConnectString);
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
public static DataTable GetDataTable_vcc_CourseExamPaperRelationship4App(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcc_CourseExamPaperRelationship4AppDA.GetDataTable_vcc_CourseExamPaperRelationship4App(strWhereCond);
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
objDT = vcc_CourseExamPaperRelationship4AppDA.GetDataTable(strWhereCond);
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
objDT = vcc_CourseExamPaperRelationship4AppDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcc_CourseExamPaperRelationship4AppDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcc_CourseExamPaperRelationship4AppDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcc_CourseExamPaperRelationship4AppDA.GetDataTable_Top(objTopPara);
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
objDT = vcc_CourseExamPaperRelationship4AppDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcc_CourseExamPaperRelationship4AppDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcc_CourseExamPaperRelationship4AppDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvcc_CourseExamPaperRelationship4AppEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvcc_CourseExamPaperRelationship4AppEN> arrObjLst = new List<clsvcc_CourseExamPaperRelationship4AppEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN = new clsvcc_CourseExamPaperRelationship4AppEN();
try
{
objvcc_CourseExamPaperRelationship4AppEN.mId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.mId].ToString().Trim()); //mId
objvcc_CourseExamPaperRelationship4AppEN.CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship4App.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperRelationship4AppEN.ExamPaperName = objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperRelationship4AppEN.CourseId = objRow[convcc_CourseExamPaperRelationship4App.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperRelationship4AppEN.CourseName = objRow[convcc_CourseExamPaperRelationship4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperRelationship4AppEN.QuestionId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.QuestionId].ToString().Trim()); //题目Id
objvcc_CourseExamPaperRelationship4AppEN.QuestionIndex = objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex].ToString().Trim()); //题目序号
objvcc_CourseExamPaperRelationship4AppEN.QuestionName = objRow[convcc_CourseExamPaperRelationship4App.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionName].ToString().Trim(); //题目名称
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeId = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeName = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeId = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeName = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_CourseExamPaperRelationship4AppEN.QuestionScore = objRow[convcc_CourseExamPaperRelationship4App.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convcc_CourseExamPaperRelationship4App.QuestionScore].ToString().Trim()); //题目得分
objvcc_CourseExamPaperRelationship4AppEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship4App.IsEffective].ToString().Trim()); //是否有效
objvcc_CourseExamPaperRelationship4AppEN.UserId = objRow[convcc_CourseExamPaperRelationship4App.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UserId].ToString().Trim(); //用户ID
objvcc_CourseExamPaperRelationship4AppEN.StartTime = objRow[convcc_CourseExamPaperRelationship4App.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaperRelationship4App.StartTime].ToString().Trim()); //开始时间(s)
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_CourseExamPaperRelationship4AppEN.TopicDescription = objRow[convcc_CourseExamPaperRelationship4App.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.TopicDescription].ToString().Trim(); //标题描述
objvcc_CourseExamPaperRelationship4AppEN.TopicScores = objRow[convcc_CourseExamPaperRelationship4App.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.TopicScores].ToString().Trim()); //大题得分
objvcc_CourseExamPaperRelationship4AppEN.TopicOrderNum = objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum].ToString().Trim()); //TopicOrderNum
objvcc_CourseExamPaperRelationship4AppEN.OrderNum = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.OrderNum].ToString().Trim()); //序号
objvcc_CourseExamPaperRelationship4AppEN.UpdDate = objRow[convcc_CourseExamPaperRelationship4App.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperRelationship4AppEN.UpdUser = objRow[convcc_CourseExamPaperRelationship4App.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseExamPaperRelationship4AppEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseExamPaperRelationship4AppEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcc_CourseExamPaperRelationship4AppEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsvcc_CourseExamPaperRelationship4AppEN._CurrTabName, strCourseId);
List<clsvcc_CourseExamPaperRelationship4AppEN> arrvcc_CourseExamPaperRelationship4AppObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseExamPaperRelationship4AppEN> arrvcc_CourseExamPaperRelationship4AppObjLst_Sel =
arrvcc_CourseExamPaperRelationship4AppObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvcc_CourseExamPaperRelationship4AppObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseExamPaperRelationship4AppEN> GetObjLst(string strWhereCond)
{
List<clsvcc_CourseExamPaperRelationship4AppEN> arrObjLst = new List<clsvcc_CourseExamPaperRelationship4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN = new clsvcc_CourseExamPaperRelationship4AppEN();
try
{
objvcc_CourseExamPaperRelationship4AppEN.mId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.mId].ToString().Trim()); //mId
objvcc_CourseExamPaperRelationship4AppEN.CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship4App.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperRelationship4AppEN.ExamPaperName = objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperRelationship4AppEN.CourseId = objRow[convcc_CourseExamPaperRelationship4App.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperRelationship4AppEN.CourseName = objRow[convcc_CourseExamPaperRelationship4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperRelationship4AppEN.QuestionId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.QuestionId].ToString().Trim()); //题目Id
objvcc_CourseExamPaperRelationship4AppEN.QuestionIndex = objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex].ToString().Trim()); //题目序号
objvcc_CourseExamPaperRelationship4AppEN.QuestionName = objRow[convcc_CourseExamPaperRelationship4App.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionName].ToString().Trim(); //题目名称
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeId = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeName = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeId = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeName = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_CourseExamPaperRelationship4AppEN.QuestionScore = objRow[convcc_CourseExamPaperRelationship4App.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convcc_CourseExamPaperRelationship4App.QuestionScore].ToString().Trim()); //题目得分
objvcc_CourseExamPaperRelationship4AppEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship4App.IsEffective].ToString().Trim()); //是否有效
objvcc_CourseExamPaperRelationship4AppEN.UserId = objRow[convcc_CourseExamPaperRelationship4App.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UserId].ToString().Trim(); //用户ID
objvcc_CourseExamPaperRelationship4AppEN.StartTime = objRow[convcc_CourseExamPaperRelationship4App.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaperRelationship4App.StartTime].ToString().Trim()); //开始时间(s)
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_CourseExamPaperRelationship4AppEN.TopicDescription = objRow[convcc_CourseExamPaperRelationship4App.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.TopicDescription].ToString().Trim(); //标题描述
objvcc_CourseExamPaperRelationship4AppEN.TopicScores = objRow[convcc_CourseExamPaperRelationship4App.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.TopicScores].ToString().Trim()); //大题得分
objvcc_CourseExamPaperRelationship4AppEN.TopicOrderNum = objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum].ToString().Trim()); //TopicOrderNum
objvcc_CourseExamPaperRelationship4AppEN.OrderNum = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.OrderNum].ToString().Trim()); //序号
objvcc_CourseExamPaperRelationship4AppEN.UpdDate = objRow[convcc_CourseExamPaperRelationship4App.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperRelationship4AppEN.UpdUser = objRow[convcc_CourseExamPaperRelationship4App.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseExamPaperRelationship4AppEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseExamPaperRelationship4AppEN);
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
public static List<clsvcc_CourseExamPaperRelationship4AppEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcc_CourseExamPaperRelationship4AppEN> arrObjLst = new List<clsvcc_CourseExamPaperRelationship4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN = new clsvcc_CourseExamPaperRelationship4AppEN();
try
{
objvcc_CourseExamPaperRelationship4AppEN.mId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.mId].ToString().Trim()); //mId
objvcc_CourseExamPaperRelationship4AppEN.CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship4App.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperRelationship4AppEN.ExamPaperName = objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperRelationship4AppEN.CourseId = objRow[convcc_CourseExamPaperRelationship4App.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperRelationship4AppEN.CourseName = objRow[convcc_CourseExamPaperRelationship4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperRelationship4AppEN.QuestionId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.QuestionId].ToString().Trim()); //题目Id
objvcc_CourseExamPaperRelationship4AppEN.QuestionIndex = objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex].ToString().Trim()); //题目序号
objvcc_CourseExamPaperRelationship4AppEN.QuestionName = objRow[convcc_CourseExamPaperRelationship4App.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionName].ToString().Trim(); //题目名称
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeId = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeName = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeId = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeName = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_CourseExamPaperRelationship4AppEN.QuestionScore = objRow[convcc_CourseExamPaperRelationship4App.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convcc_CourseExamPaperRelationship4App.QuestionScore].ToString().Trim()); //题目得分
objvcc_CourseExamPaperRelationship4AppEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship4App.IsEffective].ToString().Trim()); //是否有效
objvcc_CourseExamPaperRelationship4AppEN.UserId = objRow[convcc_CourseExamPaperRelationship4App.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UserId].ToString().Trim(); //用户ID
objvcc_CourseExamPaperRelationship4AppEN.StartTime = objRow[convcc_CourseExamPaperRelationship4App.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaperRelationship4App.StartTime].ToString().Trim()); //开始时间(s)
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_CourseExamPaperRelationship4AppEN.TopicDescription = objRow[convcc_CourseExamPaperRelationship4App.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.TopicDescription].ToString().Trim(); //标题描述
objvcc_CourseExamPaperRelationship4AppEN.TopicScores = objRow[convcc_CourseExamPaperRelationship4App.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.TopicScores].ToString().Trim()); //大题得分
objvcc_CourseExamPaperRelationship4AppEN.TopicOrderNum = objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum].ToString().Trim()); //TopicOrderNum
objvcc_CourseExamPaperRelationship4AppEN.OrderNum = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.OrderNum].ToString().Trim()); //序号
objvcc_CourseExamPaperRelationship4AppEN.UpdDate = objRow[convcc_CourseExamPaperRelationship4App.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperRelationship4AppEN.UpdUser = objRow[convcc_CourseExamPaperRelationship4App.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseExamPaperRelationship4AppEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseExamPaperRelationship4AppEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcc_CourseExamPaperRelationship4AppEN> GetSubObjLstCache(clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppCond)
{
 string strCourseId = objvcc_CourseExamPaperRelationship4AppCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvcc_CourseExamPaperRelationship4AppBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvcc_CourseExamPaperRelationship4AppEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseExamPaperRelationship4AppEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_CourseExamPaperRelationship4App.AttributeName)
{
if (objvcc_CourseExamPaperRelationship4AppCond.IsUpdated(strFldName) == false) continue;
if (objvcc_CourseExamPaperRelationship4AppCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseExamPaperRelationship4AppCond[strFldName].ToString());
}
else
{
if (objvcc_CourseExamPaperRelationship4AppCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_CourseExamPaperRelationship4AppCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseExamPaperRelationship4AppCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_CourseExamPaperRelationship4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_CourseExamPaperRelationship4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_CourseExamPaperRelationship4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_CourseExamPaperRelationship4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_CourseExamPaperRelationship4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_CourseExamPaperRelationship4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_CourseExamPaperRelationship4AppCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_CourseExamPaperRelationship4AppCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_CourseExamPaperRelationship4AppCond[strFldName]));
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
public static List<clsvcc_CourseExamPaperRelationship4AppEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcc_CourseExamPaperRelationship4AppEN> arrObjLst = new List<clsvcc_CourseExamPaperRelationship4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN = new clsvcc_CourseExamPaperRelationship4AppEN();
try
{
objvcc_CourseExamPaperRelationship4AppEN.mId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.mId].ToString().Trim()); //mId
objvcc_CourseExamPaperRelationship4AppEN.CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship4App.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperRelationship4AppEN.ExamPaperName = objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperRelationship4AppEN.CourseId = objRow[convcc_CourseExamPaperRelationship4App.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperRelationship4AppEN.CourseName = objRow[convcc_CourseExamPaperRelationship4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperRelationship4AppEN.QuestionId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.QuestionId].ToString().Trim()); //题目Id
objvcc_CourseExamPaperRelationship4AppEN.QuestionIndex = objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex].ToString().Trim()); //题目序号
objvcc_CourseExamPaperRelationship4AppEN.QuestionName = objRow[convcc_CourseExamPaperRelationship4App.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionName].ToString().Trim(); //题目名称
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeId = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeName = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeId = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeName = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_CourseExamPaperRelationship4AppEN.QuestionScore = objRow[convcc_CourseExamPaperRelationship4App.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convcc_CourseExamPaperRelationship4App.QuestionScore].ToString().Trim()); //题目得分
objvcc_CourseExamPaperRelationship4AppEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship4App.IsEffective].ToString().Trim()); //是否有效
objvcc_CourseExamPaperRelationship4AppEN.UserId = objRow[convcc_CourseExamPaperRelationship4App.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UserId].ToString().Trim(); //用户ID
objvcc_CourseExamPaperRelationship4AppEN.StartTime = objRow[convcc_CourseExamPaperRelationship4App.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaperRelationship4App.StartTime].ToString().Trim()); //开始时间(s)
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_CourseExamPaperRelationship4AppEN.TopicDescription = objRow[convcc_CourseExamPaperRelationship4App.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.TopicDescription].ToString().Trim(); //标题描述
objvcc_CourseExamPaperRelationship4AppEN.TopicScores = objRow[convcc_CourseExamPaperRelationship4App.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.TopicScores].ToString().Trim()); //大题得分
objvcc_CourseExamPaperRelationship4AppEN.TopicOrderNum = objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum].ToString().Trim()); //TopicOrderNum
objvcc_CourseExamPaperRelationship4AppEN.OrderNum = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.OrderNum].ToString().Trim()); //序号
objvcc_CourseExamPaperRelationship4AppEN.UpdDate = objRow[convcc_CourseExamPaperRelationship4App.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperRelationship4AppEN.UpdUser = objRow[convcc_CourseExamPaperRelationship4App.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseExamPaperRelationship4AppEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseExamPaperRelationship4AppEN);
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
public static List<clsvcc_CourseExamPaperRelationship4AppEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcc_CourseExamPaperRelationship4AppEN> arrObjLst = new List<clsvcc_CourseExamPaperRelationship4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN = new clsvcc_CourseExamPaperRelationship4AppEN();
try
{
objvcc_CourseExamPaperRelationship4AppEN.mId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.mId].ToString().Trim()); //mId
objvcc_CourseExamPaperRelationship4AppEN.CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship4App.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperRelationship4AppEN.ExamPaperName = objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperRelationship4AppEN.CourseId = objRow[convcc_CourseExamPaperRelationship4App.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperRelationship4AppEN.CourseName = objRow[convcc_CourseExamPaperRelationship4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperRelationship4AppEN.QuestionId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.QuestionId].ToString().Trim()); //题目Id
objvcc_CourseExamPaperRelationship4AppEN.QuestionIndex = objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex].ToString().Trim()); //题目序号
objvcc_CourseExamPaperRelationship4AppEN.QuestionName = objRow[convcc_CourseExamPaperRelationship4App.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionName].ToString().Trim(); //题目名称
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeId = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeName = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeId = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeName = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_CourseExamPaperRelationship4AppEN.QuestionScore = objRow[convcc_CourseExamPaperRelationship4App.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convcc_CourseExamPaperRelationship4App.QuestionScore].ToString().Trim()); //题目得分
objvcc_CourseExamPaperRelationship4AppEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship4App.IsEffective].ToString().Trim()); //是否有效
objvcc_CourseExamPaperRelationship4AppEN.UserId = objRow[convcc_CourseExamPaperRelationship4App.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UserId].ToString().Trim(); //用户ID
objvcc_CourseExamPaperRelationship4AppEN.StartTime = objRow[convcc_CourseExamPaperRelationship4App.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaperRelationship4App.StartTime].ToString().Trim()); //开始时间(s)
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_CourseExamPaperRelationship4AppEN.TopicDescription = objRow[convcc_CourseExamPaperRelationship4App.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.TopicDescription].ToString().Trim(); //标题描述
objvcc_CourseExamPaperRelationship4AppEN.TopicScores = objRow[convcc_CourseExamPaperRelationship4App.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.TopicScores].ToString().Trim()); //大题得分
objvcc_CourseExamPaperRelationship4AppEN.TopicOrderNum = objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum].ToString().Trim()); //TopicOrderNum
objvcc_CourseExamPaperRelationship4AppEN.OrderNum = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.OrderNum].ToString().Trim()); //序号
objvcc_CourseExamPaperRelationship4AppEN.UpdDate = objRow[convcc_CourseExamPaperRelationship4App.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperRelationship4AppEN.UpdUser = objRow[convcc_CourseExamPaperRelationship4App.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseExamPaperRelationship4AppEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseExamPaperRelationship4AppEN);
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
List<clsvcc_CourseExamPaperRelationship4AppEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcc_CourseExamPaperRelationship4AppEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseExamPaperRelationship4AppEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcc_CourseExamPaperRelationship4AppEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_CourseExamPaperRelationship4AppEN> arrObjLst = new List<clsvcc_CourseExamPaperRelationship4AppEN>(); 
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
	clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN = new clsvcc_CourseExamPaperRelationship4AppEN();
try
{
objvcc_CourseExamPaperRelationship4AppEN.mId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.mId].ToString().Trim()); //mId
objvcc_CourseExamPaperRelationship4AppEN.CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship4App.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperRelationship4AppEN.ExamPaperName = objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperRelationship4AppEN.CourseId = objRow[convcc_CourseExamPaperRelationship4App.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperRelationship4AppEN.CourseName = objRow[convcc_CourseExamPaperRelationship4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperRelationship4AppEN.QuestionId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.QuestionId].ToString().Trim()); //题目Id
objvcc_CourseExamPaperRelationship4AppEN.QuestionIndex = objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex].ToString().Trim()); //题目序号
objvcc_CourseExamPaperRelationship4AppEN.QuestionName = objRow[convcc_CourseExamPaperRelationship4App.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionName].ToString().Trim(); //题目名称
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeId = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeName = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeId = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeName = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_CourseExamPaperRelationship4AppEN.QuestionScore = objRow[convcc_CourseExamPaperRelationship4App.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convcc_CourseExamPaperRelationship4App.QuestionScore].ToString().Trim()); //题目得分
objvcc_CourseExamPaperRelationship4AppEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship4App.IsEffective].ToString().Trim()); //是否有效
objvcc_CourseExamPaperRelationship4AppEN.UserId = objRow[convcc_CourseExamPaperRelationship4App.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UserId].ToString().Trim(); //用户ID
objvcc_CourseExamPaperRelationship4AppEN.StartTime = objRow[convcc_CourseExamPaperRelationship4App.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaperRelationship4App.StartTime].ToString().Trim()); //开始时间(s)
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_CourseExamPaperRelationship4AppEN.TopicDescription = objRow[convcc_CourseExamPaperRelationship4App.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.TopicDescription].ToString().Trim(); //标题描述
objvcc_CourseExamPaperRelationship4AppEN.TopicScores = objRow[convcc_CourseExamPaperRelationship4App.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.TopicScores].ToString().Trim()); //大题得分
objvcc_CourseExamPaperRelationship4AppEN.TopicOrderNum = objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum].ToString().Trim()); //TopicOrderNum
objvcc_CourseExamPaperRelationship4AppEN.OrderNum = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.OrderNum].ToString().Trim()); //序号
objvcc_CourseExamPaperRelationship4AppEN.UpdDate = objRow[convcc_CourseExamPaperRelationship4App.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperRelationship4AppEN.UpdUser = objRow[convcc_CourseExamPaperRelationship4App.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseExamPaperRelationship4AppEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseExamPaperRelationship4AppEN);
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
public static List<clsvcc_CourseExamPaperRelationship4AppEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcc_CourseExamPaperRelationship4AppEN> arrObjLst = new List<clsvcc_CourseExamPaperRelationship4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN = new clsvcc_CourseExamPaperRelationship4AppEN();
try
{
objvcc_CourseExamPaperRelationship4AppEN.mId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.mId].ToString().Trim()); //mId
objvcc_CourseExamPaperRelationship4AppEN.CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship4App.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperRelationship4AppEN.ExamPaperName = objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperRelationship4AppEN.CourseId = objRow[convcc_CourseExamPaperRelationship4App.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperRelationship4AppEN.CourseName = objRow[convcc_CourseExamPaperRelationship4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperRelationship4AppEN.QuestionId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.QuestionId].ToString().Trim()); //题目Id
objvcc_CourseExamPaperRelationship4AppEN.QuestionIndex = objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex].ToString().Trim()); //题目序号
objvcc_CourseExamPaperRelationship4AppEN.QuestionName = objRow[convcc_CourseExamPaperRelationship4App.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionName].ToString().Trim(); //题目名称
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeId = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeName = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeId = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeName = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_CourseExamPaperRelationship4AppEN.QuestionScore = objRow[convcc_CourseExamPaperRelationship4App.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convcc_CourseExamPaperRelationship4App.QuestionScore].ToString().Trim()); //题目得分
objvcc_CourseExamPaperRelationship4AppEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship4App.IsEffective].ToString().Trim()); //是否有效
objvcc_CourseExamPaperRelationship4AppEN.UserId = objRow[convcc_CourseExamPaperRelationship4App.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UserId].ToString().Trim(); //用户ID
objvcc_CourseExamPaperRelationship4AppEN.StartTime = objRow[convcc_CourseExamPaperRelationship4App.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaperRelationship4App.StartTime].ToString().Trim()); //开始时间(s)
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_CourseExamPaperRelationship4AppEN.TopicDescription = objRow[convcc_CourseExamPaperRelationship4App.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.TopicDescription].ToString().Trim(); //标题描述
objvcc_CourseExamPaperRelationship4AppEN.TopicScores = objRow[convcc_CourseExamPaperRelationship4App.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.TopicScores].ToString().Trim()); //大题得分
objvcc_CourseExamPaperRelationship4AppEN.TopicOrderNum = objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum].ToString().Trim()); //TopicOrderNum
objvcc_CourseExamPaperRelationship4AppEN.OrderNum = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.OrderNum].ToString().Trim()); //序号
objvcc_CourseExamPaperRelationship4AppEN.UpdDate = objRow[convcc_CourseExamPaperRelationship4App.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperRelationship4AppEN.UpdUser = objRow[convcc_CourseExamPaperRelationship4App.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseExamPaperRelationship4AppEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseExamPaperRelationship4AppEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcc_CourseExamPaperRelationship4AppEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcc_CourseExamPaperRelationship4AppEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_CourseExamPaperRelationship4AppEN> arrObjLst = new List<clsvcc_CourseExamPaperRelationship4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN = new clsvcc_CourseExamPaperRelationship4AppEN();
try
{
objvcc_CourseExamPaperRelationship4AppEN.mId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.mId].ToString().Trim()); //mId
objvcc_CourseExamPaperRelationship4AppEN.CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship4App.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperRelationship4AppEN.ExamPaperName = objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperRelationship4AppEN.CourseId = objRow[convcc_CourseExamPaperRelationship4App.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperRelationship4AppEN.CourseName = objRow[convcc_CourseExamPaperRelationship4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperRelationship4AppEN.QuestionId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.QuestionId].ToString().Trim()); //题目Id
objvcc_CourseExamPaperRelationship4AppEN.QuestionIndex = objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex].ToString().Trim()); //题目序号
objvcc_CourseExamPaperRelationship4AppEN.QuestionName = objRow[convcc_CourseExamPaperRelationship4App.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionName].ToString().Trim(); //题目名称
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeId = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeName = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeId = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeName = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_CourseExamPaperRelationship4AppEN.QuestionScore = objRow[convcc_CourseExamPaperRelationship4App.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convcc_CourseExamPaperRelationship4App.QuestionScore].ToString().Trim()); //题目得分
objvcc_CourseExamPaperRelationship4AppEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship4App.IsEffective].ToString().Trim()); //是否有效
objvcc_CourseExamPaperRelationship4AppEN.UserId = objRow[convcc_CourseExamPaperRelationship4App.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UserId].ToString().Trim(); //用户ID
objvcc_CourseExamPaperRelationship4AppEN.StartTime = objRow[convcc_CourseExamPaperRelationship4App.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaperRelationship4App.StartTime].ToString().Trim()); //开始时间(s)
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_CourseExamPaperRelationship4AppEN.TopicDescription = objRow[convcc_CourseExamPaperRelationship4App.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.TopicDescription].ToString().Trim(); //标题描述
objvcc_CourseExamPaperRelationship4AppEN.TopicScores = objRow[convcc_CourseExamPaperRelationship4App.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.TopicScores].ToString().Trim()); //大题得分
objvcc_CourseExamPaperRelationship4AppEN.TopicOrderNum = objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum].ToString().Trim()); //TopicOrderNum
objvcc_CourseExamPaperRelationship4AppEN.OrderNum = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.OrderNum].ToString().Trim()); //序号
objvcc_CourseExamPaperRelationship4AppEN.UpdDate = objRow[convcc_CourseExamPaperRelationship4App.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperRelationship4AppEN.UpdUser = objRow[convcc_CourseExamPaperRelationship4App.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseExamPaperRelationship4AppEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseExamPaperRelationship4AppEN);
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
public static List<clsvcc_CourseExamPaperRelationship4AppEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcc_CourseExamPaperRelationship4AppEN> arrObjLst = new List<clsvcc_CourseExamPaperRelationship4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN = new clsvcc_CourseExamPaperRelationship4AppEN();
try
{
objvcc_CourseExamPaperRelationship4AppEN.mId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.mId].ToString().Trim()); //mId
objvcc_CourseExamPaperRelationship4AppEN.CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship4App.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperRelationship4AppEN.ExamPaperName = objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperRelationship4AppEN.CourseId = objRow[convcc_CourseExamPaperRelationship4App.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperRelationship4AppEN.CourseName = objRow[convcc_CourseExamPaperRelationship4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperRelationship4AppEN.QuestionId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.QuestionId].ToString().Trim()); //题目Id
objvcc_CourseExamPaperRelationship4AppEN.QuestionIndex = objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex].ToString().Trim()); //题目序号
objvcc_CourseExamPaperRelationship4AppEN.QuestionName = objRow[convcc_CourseExamPaperRelationship4App.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionName].ToString().Trim(); //题目名称
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeId = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeName = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeId = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeName = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_CourseExamPaperRelationship4AppEN.QuestionScore = objRow[convcc_CourseExamPaperRelationship4App.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convcc_CourseExamPaperRelationship4App.QuestionScore].ToString().Trim()); //题目得分
objvcc_CourseExamPaperRelationship4AppEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship4App.IsEffective].ToString().Trim()); //是否有效
objvcc_CourseExamPaperRelationship4AppEN.UserId = objRow[convcc_CourseExamPaperRelationship4App.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UserId].ToString().Trim(); //用户ID
objvcc_CourseExamPaperRelationship4AppEN.StartTime = objRow[convcc_CourseExamPaperRelationship4App.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaperRelationship4App.StartTime].ToString().Trim()); //开始时间(s)
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_CourseExamPaperRelationship4AppEN.TopicDescription = objRow[convcc_CourseExamPaperRelationship4App.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.TopicDescription].ToString().Trim(); //标题描述
objvcc_CourseExamPaperRelationship4AppEN.TopicScores = objRow[convcc_CourseExamPaperRelationship4App.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.TopicScores].ToString().Trim()); //大题得分
objvcc_CourseExamPaperRelationship4AppEN.TopicOrderNum = objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum].ToString().Trim()); //TopicOrderNum
objvcc_CourseExamPaperRelationship4AppEN.OrderNum = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.OrderNum].ToString().Trim()); //序号
objvcc_CourseExamPaperRelationship4AppEN.UpdDate = objRow[convcc_CourseExamPaperRelationship4App.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperRelationship4AppEN.UpdUser = objRow[convcc_CourseExamPaperRelationship4App.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseExamPaperRelationship4AppEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseExamPaperRelationship4AppEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseExamPaperRelationship4AppEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcc_CourseExamPaperRelationship4AppEN> arrObjLst = new List<clsvcc_CourseExamPaperRelationship4AppEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN = new clsvcc_CourseExamPaperRelationship4AppEN();
try
{
objvcc_CourseExamPaperRelationship4AppEN.mId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.mId].ToString().Trim()); //mId
objvcc_CourseExamPaperRelationship4AppEN.CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship4App.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperRelationship4AppEN.ExamPaperName = objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperRelationship4AppEN.CourseId = objRow[convcc_CourseExamPaperRelationship4App.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperRelationship4AppEN.CourseName = objRow[convcc_CourseExamPaperRelationship4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperRelationship4AppEN.QuestionId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.QuestionId].ToString().Trim()); //题目Id
objvcc_CourseExamPaperRelationship4AppEN.QuestionIndex = objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex].ToString().Trim()); //题目序号
objvcc_CourseExamPaperRelationship4AppEN.QuestionName = objRow[convcc_CourseExamPaperRelationship4App.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionName].ToString().Trim(); //题目名称
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeId = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeName = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeId = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeName = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_CourseExamPaperRelationship4AppEN.QuestionScore = objRow[convcc_CourseExamPaperRelationship4App.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convcc_CourseExamPaperRelationship4App.QuestionScore].ToString().Trim()); //题目得分
objvcc_CourseExamPaperRelationship4AppEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship4App.IsEffective].ToString().Trim()); //是否有效
objvcc_CourseExamPaperRelationship4AppEN.UserId = objRow[convcc_CourseExamPaperRelationship4App.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UserId].ToString().Trim(); //用户ID
objvcc_CourseExamPaperRelationship4AppEN.StartTime = objRow[convcc_CourseExamPaperRelationship4App.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaperRelationship4App.StartTime].ToString().Trim()); //开始时间(s)
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_CourseExamPaperRelationship4AppEN.TopicDescription = objRow[convcc_CourseExamPaperRelationship4App.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.TopicDescription].ToString().Trim(); //标题描述
objvcc_CourseExamPaperRelationship4AppEN.TopicScores = objRow[convcc_CourseExamPaperRelationship4App.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.TopicScores].ToString().Trim()); //大题得分
objvcc_CourseExamPaperRelationship4AppEN.TopicOrderNum = objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum].ToString().Trim()); //TopicOrderNum
objvcc_CourseExamPaperRelationship4AppEN.OrderNum = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.OrderNum].ToString().Trim()); //序号
objvcc_CourseExamPaperRelationship4AppEN.UpdDate = objRow[convcc_CourseExamPaperRelationship4App.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperRelationship4AppEN.UpdUser = objRow[convcc_CourseExamPaperRelationship4App.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseExamPaperRelationship4AppEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseExamPaperRelationship4AppEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcc_CourseExamPaperRelationship4App(ref clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN)
{
bool bolResult = vcc_CourseExamPaperRelationship4AppDA.Getvcc_CourseExamPaperRelationship4App(ref objvcc_CourseExamPaperRelationship4AppEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN GetObjBymId(long lngmId)
{
clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN = vcc_CourseExamPaperRelationship4AppDA.GetObjBymId(lngmId);
return objvcc_CourseExamPaperRelationship4AppEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN = vcc_CourseExamPaperRelationship4AppDA.GetFirstObj(strWhereCond);
 return objvcc_CourseExamPaperRelationship4AppEN;
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
public static clsvcc_CourseExamPaperRelationship4AppEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN = vcc_CourseExamPaperRelationship4AppDA.GetObjByDataRow(objRow);
 return objvcc_CourseExamPaperRelationship4AppEN;
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
public static clsvcc_CourseExamPaperRelationship4AppEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN = vcc_CourseExamPaperRelationship4AppDA.GetObjByDataRow(objRow);
 return objvcc_CourseExamPaperRelationship4AppEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvcc_CourseExamPaperRelationship4AppObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN GetObjBymIdFromList(long lngmId, List<clsvcc_CourseExamPaperRelationship4AppEN> lstvcc_CourseExamPaperRelationship4AppObjLst)
{
foreach (clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN in lstvcc_CourseExamPaperRelationship4AppObjLst)
{
if (objvcc_CourseExamPaperRelationship4AppEN.mId == lngmId)
{
return objvcc_CourseExamPaperRelationship4AppEN;
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
 long lngmId;
 try
 {
 lngmId = new clsvcc_CourseExamPaperRelationship4AppDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = vcc_CourseExamPaperRelationship4AppDA.GetID(strWhereCond);
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
bool bolIsExist = vcc_CourseExamPaperRelationship4AppDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vcc_CourseExamPaperRelationship4AppDA.IsExist(lngmId);
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
 bolIsExist = clsvcc_CourseExamPaperRelationship4AppDA.IsExistTable();
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
 bolIsExist = vcc_CourseExamPaperRelationship4AppDA.IsExistTable(strTabName);
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
 /// <param name = "objvcc_CourseExamPaperRelationship4AppENS">源对象</param>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppENT">目标对象</param>
 public static void CopyTo(clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppENS, clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppENT)
{
try
{
objvcc_CourseExamPaperRelationship4AppENT.mId = objvcc_CourseExamPaperRelationship4AppENS.mId; //mId
objvcc_CourseExamPaperRelationship4AppENT.CourseExamPaperId = objvcc_CourseExamPaperRelationship4AppENS.CourseExamPaperId; //考卷流水号
objvcc_CourseExamPaperRelationship4AppENT.ExamPaperName = objvcc_CourseExamPaperRelationship4AppENS.ExamPaperName; //考卷名称
objvcc_CourseExamPaperRelationship4AppENT.CourseId = objvcc_CourseExamPaperRelationship4AppENS.CourseId; //课程Id
objvcc_CourseExamPaperRelationship4AppENT.CourseName = objvcc_CourseExamPaperRelationship4AppENS.CourseName; //课程名称
objvcc_CourseExamPaperRelationship4AppENT.QuestionId = objvcc_CourseExamPaperRelationship4AppENS.QuestionId; //题目Id
objvcc_CourseExamPaperRelationship4AppENT.QuestionIndex = objvcc_CourseExamPaperRelationship4AppENS.QuestionIndex; //题目序号
objvcc_CourseExamPaperRelationship4AppENT.QuestionName = objvcc_CourseExamPaperRelationship4AppENS.QuestionName; //题目名称
objvcc_CourseExamPaperRelationship4AppENT.QuestionTypeId = objvcc_CourseExamPaperRelationship4AppENS.QuestionTypeId; //题目类型Id
objvcc_CourseExamPaperRelationship4AppENT.QuestionTypeName = objvcc_CourseExamPaperRelationship4AppENS.QuestionTypeName; //题目类型名
objvcc_CourseExamPaperRelationship4AppENT.ExamGradeId = objvcc_CourseExamPaperRelationship4AppENS.ExamGradeId; //题库等级ID
objvcc_CourseExamPaperRelationship4AppENT.ExamGradeName = objvcc_CourseExamPaperRelationship4AppENS.ExamGradeName; //题库等级名
objvcc_CourseExamPaperRelationship4AppENT.QuestionScore = objvcc_CourseExamPaperRelationship4AppENS.QuestionScore; //题目得分
objvcc_CourseExamPaperRelationship4AppENT.IsEffective = objvcc_CourseExamPaperRelationship4AppENS.IsEffective; //是否有效
objvcc_CourseExamPaperRelationship4AppENT.UserId = objvcc_CourseExamPaperRelationship4AppENS.UserId; //用户ID
objvcc_CourseExamPaperRelationship4AppENT.StartTime = objvcc_CourseExamPaperRelationship4AppENS.StartTime; //开始时间(s)
objvcc_CourseExamPaperRelationship4AppENT.PapersBigTopicId = objvcc_CourseExamPaperRelationship4AppENS.PapersBigTopicId; //试卷大题目Id
objvcc_CourseExamPaperRelationship4AppENT.PapersBigTopicName = objvcc_CourseExamPaperRelationship4AppENS.PapersBigTopicName; //试卷大题目名称
objvcc_CourseExamPaperRelationship4AppENT.TopicDescription = objvcc_CourseExamPaperRelationship4AppENS.TopicDescription; //标题描述
objvcc_CourseExamPaperRelationship4AppENT.TopicScores = objvcc_CourseExamPaperRelationship4AppENS.TopicScores; //大题得分
objvcc_CourseExamPaperRelationship4AppENT.TopicOrderNum = objvcc_CourseExamPaperRelationship4AppENS.TopicOrderNum; //TopicOrderNum
objvcc_CourseExamPaperRelationship4AppENT.OrderNum = objvcc_CourseExamPaperRelationship4AppENS.OrderNum; //序号
objvcc_CourseExamPaperRelationship4AppENT.UpdDate = objvcc_CourseExamPaperRelationship4AppENS.UpdDate; //修改日期
objvcc_CourseExamPaperRelationship4AppENT.UpdUser = objvcc_CourseExamPaperRelationship4AppENS.UpdUser; //修改人
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
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">源简化对象</param>
 public static void SetUpdFlag(clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN)
{
try
{
objvcc_CourseExamPaperRelationship4AppEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcc_CourseExamPaperRelationship4AppEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship4App.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationship4AppEN.mId = objvcc_CourseExamPaperRelationship4AppEN.mId; //mId
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship4App.CourseExamPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationship4AppEN.CourseExamPaperId = objvcc_CourseExamPaperRelationship4AppEN.CourseExamPaperId; //考卷流水号
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship4App.ExamPaperName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationship4AppEN.ExamPaperName = objvcc_CourseExamPaperRelationship4AppEN.ExamPaperName == "[null]" ? null :  objvcc_CourseExamPaperRelationship4AppEN.ExamPaperName; //考卷名称
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship4App.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationship4AppEN.CourseId = objvcc_CourseExamPaperRelationship4AppEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship4App.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationship4AppEN.CourseName = objvcc_CourseExamPaperRelationship4AppEN.CourseName == "[null]" ? null :  objvcc_CourseExamPaperRelationship4AppEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship4App.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationship4AppEN.QuestionId = objvcc_CourseExamPaperRelationship4AppEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship4App.QuestionIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationship4AppEN.QuestionIndex = objvcc_CourseExamPaperRelationship4AppEN.QuestionIndex; //题目序号
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship4App.QuestionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationship4AppEN.QuestionName = objvcc_CourseExamPaperRelationship4AppEN.QuestionName == "[null]" ? null :  objvcc_CourseExamPaperRelationship4AppEN.QuestionName; //题目名称
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship4App.QuestionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeId = objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeId == "[null]" ? null :  objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeId; //题目类型Id
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship4App.QuestionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeName = objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeName == "[null]" ? null :  objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeName; //题目类型名
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship4App.ExamGradeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeId = objvcc_CourseExamPaperRelationship4AppEN.ExamGradeId == "[null]" ? null :  objvcc_CourseExamPaperRelationship4AppEN.ExamGradeId; //题库等级ID
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship4App.ExamGradeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeName = objvcc_CourseExamPaperRelationship4AppEN.ExamGradeName == "[null]" ? null :  objvcc_CourseExamPaperRelationship4AppEN.ExamGradeName; //题库等级名
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship4App.QuestionScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationship4AppEN.QuestionScore = objvcc_CourseExamPaperRelationship4AppEN.QuestionScore; //题目得分
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship4App.IsEffective, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationship4AppEN.IsEffective = objvcc_CourseExamPaperRelationship4AppEN.IsEffective; //是否有效
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship4App.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationship4AppEN.UserId = objvcc_CourseExamPaperRelationship4AppEN.UserId == "[null]" ? null :  objvcc_CourseExamPaperRelationship4AppEN.UserId; //用户ID
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship4App.StartTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationship4AppEN.StartTime = objvcc_CourseExamPaperRelationship4AppEN.StartTime; //开始时间(s)
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship4App.PapersBigTopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicId = objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicId == "[null]" ? null :  objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicId; //试卷大题目Id
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship4App.PapersBigTopicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicName = objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicName == "[null]" ? null :  objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicName; //试卷大题目名称
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship4App.TopicDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationship4AppEN.TopicDescription = objvcc_CourseExamPaperRelationship4AppEN.TopicDescription == "[null]" ? null :  objvcc_CourseExamPaperRelationship4AppEN.TopicDescription; //标题描述
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship4App.TopicScores, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationship4AppEN.TopicScores = objvcc_CourseExamPaperRelationship4AppEN.TopicScores; //大题得分
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship4App.TopicOrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationship4AppEN.TopicOrderNum = objvcc_CourseExamPaperRelationship4AppEN.TopicOrderNum; //TopicOrderNum
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship4App.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationship4AppEN.OrderNum = objvcc_CourseExamPaperRelationship4AppEN.OrderNum; //序号
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship4App.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationship4AppEN.UpdDate = objvcc_CourseExamPaperRelationship4AppEN.UpdDate == "[null]" ? null :  objvcc_CourseExamPaperRelationship4AppEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship4App.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationship4AppEN.UpdUser = objvcc_CourseExamPaperRelationship4AppEN.UpdUser == "[null]" ? null :  objvcc_CourseExamPaperRelationship4AppEN.UpdUser; //修改人
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
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN)
{
try
{
if (objvcc_CourseExamPaperRelationship4AppEN.ExamPaperName == "[null]") objvcc_CourseExamPaperRelationship4AppEN.ExamPaperName = null; //考卷名称
if (objvcc_CourseExamPaperRelationship4AppEN.CourseName == "[null]") objvcc_CourseExamPaperRelationship4AppEN.CourseName = null; //课程名称
if (objvcc_CourseExamPaperRelationship4AppEN.QuestionName == "[null]") objvcc_CourseExamPaperRelationship4AppEN.QuestionName = null; //题目名称
if (objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeId == "[null]") objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeId = null; //题目类型Id
if (objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeName == "[null]") objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeName = null; //题目类型名
if (objvcc_CourseExamPaperRelationship4AppEN.ExamGradeId == "[null]") objvcc_CourseExamPaperRelationship4AppEN.ExamGradeId = null; //题库等级ID
if (objvcc_CourseExamPaperRelationship4AppEN.ExamGradeName == "[null]") objvcc_CourseExamPaperRelationship4AppEN.ExamGradeName = null; //题库等级名
if (objvcc_CourseExamPaperRelationship4AppEN.UserId == "[null]") objvcc_CourseExamPaperRelationship4AppEN.UserId = null; //用户ID
if (objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicId == "[null]") objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicId = null; //试卷大题目Id
if (objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicName == "[null]") objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicName = null; //试卷大题目名称
if (objvcc_CourseExamPaperRelationship4AppEN.TopicDescription == "[null]") objvcc_CourseExamPaperRelationship4AppEN.TopicDescription = null; //标题描述
if (objvcc_CourseExamPaperRelationship4AppEN.UpdDate == "[null]") objvcc_CourseExamPaperRelationship4AppEN.UpdDate = null; //修改日期
if (objvcc_CourseExamPaperRelationship4AppEN.UpdUser == "[null]") objvcc_CourseExamPaperRelationship4AppEN.UpdUser = null; //修改人
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
public static void CheckProperty4Condition(clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN)
{
 vcc_CourseExamPaperRelationship4AppDA.CheckProperty4Condition(objvcc_CourseExamPaperRelationship4AppEN);
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
if (clscc_CourseExamPaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseExamPaperBL没有刷新缓存机制(clscc_CourseExamPaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseExamPaperRelationshipBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseExamPaperRelationshipBL没有刷新缓存机制(clscc_CourseExamPaperRelationshipBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_PapersBigTopicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_PapersBigTopicBL没有刷新缓存机制(clscc_PapersBigTopicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionnaireBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireBL没有刷新缓存机制(clsQuestionnaireBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerModeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerModeBL没有刷新缓存机制(clsAnswerModeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerTypeBL没有刷新缓存机制(clsAnswerTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeBL没有刷新缓存机制(clsQuestionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExamGradeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamGradeBL没有刷新缓存机制(clscc_ExamGradeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionType4CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionType4CourseBL没有刷新缓存机制(clsQuestionType4CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvcc_CourseExamPaperRelationship4AppObjLstCache == null)
//{
//arrvcc_CourseExamPaperRelationship4AppObjLstCache = vcc_CourseExamPaperRelationship4AppDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN GetObjBymIdCache(long lngmId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvcc_CourseExamPaperRelationship4AppEN._CurrTabName, strCourseId);
List<clsvcc_CourseExamPaperRelationship4AppEN> arrvcc_CourseExamPaperRelationship4AppObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseExamPaperRelationship4AppEN> arrvcc_CourseExamPaperRelationship4AppObjLst_Sel =
arrvcc_CourseExamPaperRelationship4AppObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvcc_CourseExamPaperRelationship4AppObjLst_Sel.Count() == 0)
{
   clsvcc_CourseExamPaperRelationship4AppEN obj = clsvcc_CourseExamPaperRelationship4AppBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvcc_CourseExamPaperRelationship4AppObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_CourseExamPaperRelationship4AppEN> GetAllvcc_CourseExamPaperRelationship4AppObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsvcc_CourseExamPaperRelationship4AppEN> arrvcc_CourseExamPaperRelationship4AppObjLstCache = GetObjLstCache(strCourseId); 
return arrvcc_CourseExamPaperRelationship4AppObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_CourseExamPaperRelationship4AppEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvcc_CourseExamPaperRelationship4AppEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsvcc_CourseExamPaperRelationship4AppEN> arrvcc_CourseExamPaperRelationship4AppObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvcc_CourseExamPaperRelationship4AppObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvcc_CourseExamPaperRelationship4AppEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsvcc_CourseExamPaperRelationship4AppEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
/// 获取最新的缓存刷新时间
/// </summary>
/// <returns>最新的缓存刷新时间，字符串型</returns>
public static string GetLastRefreshTime()
{
if (clsvcc_CourseExamPaperRelationship4AppEN._RefreshTimeLst.Count == 0) return "";
return clsvcc_CourseExamPaperRelationship4AppEN._RefreshTimeLst[clsvcc_CourseExamPaperRelationship4AppEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-11-09
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strCourseId)
{
if (strInFldName != convcc_CourseExamPaperRelationship4App.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcc_CourseExamPaperRelationship4App.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcc_CourseExamPaperRelationship4App.AttributeName));
throw new Exception(strMsg);
}
var objvcc_CourseExamPaperRelationship4App = clsvcc_CourseExamPaperRelationship4AppBL.GetObjBymIdCache(lngmId, strCourseId);
if (objvcc_CourseExamPaperRelationship4App == null) return "";
return objvcc_CourseExamPaperRelationship4App[strOutFldName].ToString();
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
int intRecCount = clsvcc_CourseExamPaperRelationship4AppDA.GetRecCount(strTabName);
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
int intRecCount = clsvcc_CourseExamPaperRelationship4AppDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcc_CourseExamPaperRelationship4AppDA.GetRecCount();
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
int intRecCount = clsvcc_CourseExamPaperRelationship4AppDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppCond)
{
 string strCourseId = objvcc_CourseExamPaperRelationship4AppCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvcc_CourseExamPaperRelationship4AppBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvcc_CourseExamPaperRelationship4AppEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseExamPaperRelationship4AppEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_CourseExamPaperRelationship4App.AttributeName)
{
if (objvcc_CourseExamPaperRelationship4AppCond.IsUpdated(strFldName) == false) continue;
if (objvcc_CourseExamPaperRelationship4AppCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseExamPaperRelationship4AppCond[strFldName].ToString());
}
else
{
if (objvcc_CourseExamPaperRelationship4AppCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_CourseExamPaperRelationship4AppCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseExamPaperRelationship4AppCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_CourseExamPaperRelationship4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_CourseExamPaperRelationship4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_CourseExamPaperRelationship4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_CourseExamPaperRelationship4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_CourseExamPaperRelationship4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_CourseExamPaperRelationship4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_CourseExamPaperRelationship4AppCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_CourseExamPaperRelationship4AppCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_CourseExamPaperRelationship4AppCond[strFldName]));
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
 List<string> arrList = clsvcc_CourseExamPaperRelationship4AppDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcc_CourseExamPaperRelationship4AppDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcc_CourseExamPaperRelationship4AppDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}