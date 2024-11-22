
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseExamPaperRelationship4AppWApi
 表名:vcc_CourseExamPaperRelationship4App(01120256)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:48:41
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关
 模块英文名:Knowledges
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
public static class clsvcc_CourseExamPaperRelationship4AppWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetCourseExamPaperId(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseExamPaperId, convcc_CourseExamPaperRelationship4App.CourseExamPaperId);
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, convcc_CourseExamPaperRelationship4App.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, convcc_CourseExamPaperRelationship4App.CourseExamPaperId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetExamPaperName(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strExamPaperName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamPaperName, 500, convcc_CourseExamPaperRelationship4App.ExamPaperName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetCourseId(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convcc_CourseExamPaperRelationship4App.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_CourseExamPaperRelationship4App.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_CourseExamPaperRelationship4App.CourseId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetCourseName(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_CourseExamPaperRelationship4App.CourseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetQuestionID(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionID, convcc_CourseExamPaperRelationship4App.QuestionID);
clsCheckSql.CheckFieldLen(strQuestionID, 8, convcc_CourseExamPaperRelationship4App.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convcc_CourseExamPaperRelationship4App.QuestionID);
objvcc_CourseExamPaperRelationship4AppEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship4App.QuestionID) == false)
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship4App.QuestionID, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationship4AppEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.QuestionID] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationship4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetQuestionIndex(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, int intQuestionIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetQuestionName(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strQuestionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionName, 1000, convcc_CourseExamPaperRelationship4App.QuestionName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetQuestionTypeId(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convcc_CourseExamPaperRelationship4App.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convcc_CourseExamPaperRelationship4App.QuestionTypeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetQuestionTypeName(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strQuestionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convcc_CourseExamPaperRelationship4App.QuestionTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetExamGradeId(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strExamGradeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamGradeId, 2, convcc_CourseExamPaperRelationship4App.ExamGradeId);
clsCheckSql.CheckFieldForeignKey(strExamGradeId, 2, convcc_CourseExamPaperRelationship4App.ExamGradeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetExamGradeName(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strExamGradeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamGradeName, 50, convcc_CourseExamPaperRelationship4App.ExamGradeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetQuestionScore(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, float fltQuestionScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetUserId(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, convcc_CourseExamPaperRelationship4App.UserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetStartTime(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, double dblStartTime, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetPapersBigTopicId(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strPapersBigTopicId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPapersBigTopicId, 8, convcc_CourseExamPaperRelationship4App.PapersBigTopicId);
clsCheckSql.CheckFieldForeignKey(strPapersBigTopicId, 8, convcc_CourseExamPaperRelationship4App.PapersBigTopicId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetPapersBigTopicName(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strPapersBigTopicName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPapersBigTopicName, 50, convcc_CourseExamPaperRelationship4App.PapersBigTopicName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetTopicDescription(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strTopicDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTopicDescription, 100, convcc_CourseExamPaperRelationship4App.TopicDescription);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetTopicScores(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, int intTopicScores, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetTopicOrderNum(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, int intTopicOrderNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetUpdDate(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_CourseExamPaperRelationship4App.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN SetUpdUser(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convcc_CourseExamPaperRelationship4App.UpdUser);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4App_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_CourseExamPaperRelationship4App_Cond.IsUpdated(convcc_CourseExamPaperRelationship4App.mId) == true)
{
string strComparisonOp_mId = objvcc_CourseExamPaperRelationship4App_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship4App.mId, objvcc_CourseExamPaperRelationship4App_Cond.mId, strComparisonOp_mId);
}
if (objvcc_CourseExamPaperRelationship4App_Cond.IsUpdated(convcc_CourseExamPaperRelationship4App.CourseExamPaperId) == true)
{
string strComparisonOp_CourseExamPaperId = objvcc_CourseExamPaperRelationship4App_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.CourseExamPaperId, objvcc_CourseExamPaperRelationship4App_Cond.CourseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (objvcc_CourseExamPaperRelationship4App_Cond.IsUpdated(convcc_CourseExamPaperRelationship4App.ExamPaperName) == true)
{
string strComparisonOp_ExamPaperName = objvcc_CourseExamPaperRelationship4App_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.ExamPaperName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.ExamPaperName, objvcc_CourseExamPaperRelationship4App_Cond.ExamPaperName, strComparisonOp_ExamPaperName);
}
if (objvcc_CourseExamPaperRelationship4App_Cond.IsUpdated(convcc_CourseExamPaperRelationship4App.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_CourseExamPaperRelationship4App_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.CourseId, objvcc_CourseExamPaperRelationship4App_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_CourseExamPaperRelationship4App_Cond.IsUpdated(convcc_CourseExamPaperRelationship4App.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_CourseExamPaperRelationship4App_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.CourseName, objvcc_CourseExamPaperRelationship4App_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_CourseExamPaperRelationship4App_Cond.IsUpdated(convcc_CourseExamPaperRelationship4App.QuestionID) == true)
{
string strComparisonOp_QuestionID = objvcc_CourseExamPaperRelationship4App_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.QuestionID, objvcc_CourseExamPaperRelationship4App_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objvcc_CourseExamPaperRelationship4App_Cond.IsUpdated(convcc_CourseExamPaperRelationship4App.QuestionIndex) == true)
{
string strComparisonOp_QuestionIndex = objvcc_CourseExamPaperRelationship4App_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship4App.QuestionIndex, objvcc_CourseExamPaperRelationship4App_Cond.QuestionIndex, strComparisonOp_QuestionIndex);
}
if (objvcc_CourseExamPaperRelationship4App_Cond.IsUpdated(convcc_CourseExamPaperRelationship4App.QuestionName) == true)
{
string strComparisonOp_QuestionName = objvcc_CourseExamPaperRelationship4App_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.QuestionName, objvcc_CourseExamPaperRelationship4App_Cond.QuestionName, strComparisonOp_QuestionName);
}
if (objvcc_CourseExamPaperRelationship4App_Cond.IsUpdated(convcc_CourseExamPaperRelationship4App.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objvcc_CourseExamPaperRelationship4App_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.QuestionTypeId, objvcc_CourseExamPaperRelationship4App_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objvcc_CourseExamPaperRelationship4App_Cond.IsUpdated(convcc_CourseExamPaperRelationship4App.QuestionTypeName) == true)
{
string strComparisonOp_QuestionTypeName = objvcc_CourseExamPaperRelationship4App_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.QuestionTypeName, objvcc_CourseExamPaperRelationship4App_Cond.QuestionTypeName, strComparisonOp_QuestionTypeName);
}
if (objvcc_CourseExamPaperRelationship4App_Cond.IsUpdated(convcc_CourseExamPaperRelationship4App.ExamGradeId) == true)
{
string strComparisonOp_ExamGradeId = objvcc_CourseExamPaperRelationship4App_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.ExamGradeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.ExamGradeId, objvcc_CourseExamPaperRelationship4App_Cond.ExamGradeId, strComparisonOp_ExamGradeId);
}
if (objvcc_CourseExamPaperRelationship4App_Cond.IsUpdated(convcc_CourseExamPaperRelationship4App.ExamGradeName) == true)
{
string strComparisonOp_ExamGradeName = objvcc_CourseExamPaperRelationship4App_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.ExamGradeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.ExamGradeName, objvcc_CourseExamPaperRelationship4App_Cond.ExamGradeName, strComparisonOp_ExamGradeName);
}
if (objvcc_CourseExamPaperRelationship4App_Cond.IsUpdated(convcc_CourseExamPaperRelationship4App.QuestionScore) == true)
{
string strComparisonOp_QuestionScore = objvcc_CourseExamPaperRelationship4App_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.QuestionScore];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship4App.QuestionScore, objvcc_CourseExamPaperRelationship4App_Cond.QuestionScore, strComparisonOp_QuestionScore);
}
if (objvcc_CourseExamPaperRelationship4App_Cond.IsUpdated(convcc_CourseExamPaperRelationship4App.IsEffective) == true)
{
if (objvcc_CourseExamPaperRelationship4App_Cond.IsEffective == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseExamPaperRelationship4App.IsEffective);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseExamPaperRelationship4App.IsEffective);
}
}
if (objvcc_CourseExamPaperRelationship4App_Cond.IsUpdated(convcc_CourseExamPaperRelationship4App.UserId) == true)
{
string strComparisonOp_UserId = objvcc_CourseExamPaperRelationship4App_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.UserId, objvcc_CourseExamPaperRelationship4App_Cond.UserId, strComparisonOp_UserId);
}
if (objvcc_CourseExamPaperRelationship4App_Cond.IsUpdated(convcc_CourseExamPaperRelationship4App.StartTime) == true)
{
string strComparisonOp_StartTime = objvcc_CourseExamPaperRelationship4App_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.StartTime];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship4App.StartTime, objvcc_CourseExamPaperRelationship4App_Cond.StartTime, strComparisonOp_StartTime);
}
if (objvcc_CourseExamPaperRelationship4App_Cond.IsUpdated(convcc_CourseExamPaperRelationship4App.PapersBigTopicId) == true)
{
string strComparisonOp_PapersBigTopicId = objvcc_CourseExamPaperRelationship4App_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.PapersBigTopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.PapersBigTopicId, objvcc_CourseExamPaperRelationship4App_Cond.PapersBigTopicId, strComparisonOp_PapersBigTopicId);
}
if (objvcc_CourseExamPaperRelationship4App_Cond.IsUpdated(convcc_CourseExamPaperRelationship4App.PapersBigTopicName) == true)
{
string strComparisonOp_PapersBigTopicName = objvcc_CourseExamPaperRelationship4App_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.PapersBigTopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.PapersBigTopicName, objvcc_CourseExamPaperRelationship4App_Cond.PapersBigTopicName, strComparisonOp_PapersBigTopicName);
}
if (objvcc_CourseExamPaperRelationship4App_Cond.IsUpdated(convcc_CourseExamPaperRelationship4App.TopicDescription) == true)
{
string strComparisonOp_TopicDescription = objvcc_CourseExamPaperRelationship4App_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.TopicDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.TopicDescription, objvcc_CourseExamPaperRelationship4App_Cond.TopicDescription, strComparisonOp_TopicDescription);
}
if (objvcc_CourseExamPaperRelationship4App_Cond.IsUpdated(convcc_CourseExamPaperRelationship4App.TopicScores) == true)
{
string strComparisonOp_TopicScores = objvcc_CourseExamPaperRelationship4App_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.TopicScores];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship4App.TopicScores, objvcc_CourseExamPaperRelationship4App_Cond.TopicScores, strComparisonOp_TopicScores);
}
if (objvcc_CourseExamPaperRelationship4App_Cond.IsUpdated(convcc_CourseExamPaperRelationship4App.TopicOrderNum) == true)
{
string strComparisonOp_TopicOrderNum = objvcc_CourseExamPaperRelationship4App_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.TopicOrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship4App.TopicOrderNum, objvcc_CourseExamPaperRelationship4App_Cond.TopicOrderNum, strComparisonOp_TopicOrderNum);
}
if (objvcc_CourseExamPaperRelationship4App_Cond.IsUpdated(convcc_CourseExamPaperRelationship4App.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvcc_CourseExamPaperRelationship4App_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship4App.OrderNum, objvcc_CourseExamPaperRelationship4App_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvcc_CourseExamPaperRelationship4App_Cond.IsUpdated(convcc_CourseExamPaperRelationship4App.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_CourseExamPaperRelationship4App_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.UpdDate, objvcc_CourseExamPaperRelationship4App_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_CourseExamPaperRelationship4App_Cond.IsUpdated(convcc_CourseExamPaperRelationship4App.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvcc_CourseExamPaperRelationship4App_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship4App.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship4App.UpdUser, objvcc_CourseExamPaperRelationship4App_Cond.UpdUser, strComparisonOp_UpdUser);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v题目与试卷关系4App(vcc_CourseExamPaperRelationship4App)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_CourseExamPaperRelationship4AppWApi
{
private static readonly string mstrApiControllerName = "vcc_CourseExamPaperRelationship4AppApi";

 public clsvcc_CourseExamPaperRelationship4AppWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_CourseExamPaperRelationship4AppEN = JsonConvert.DeserializeObject<clsvcc_CourseExamPaperRelationship4AppEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseExamPaperRelationship4AppEN;
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
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN GetObjBymId_WA_Cache(long lngmId, string strCourseId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString(),
["CourseId"] = strCourseId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_CourseExamPaperRelationship4AppEN = JsonConvert.DeserializeObject<clsvcc_CourseExamPaperRelationship4AppEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseExamPaperRelationship4AppEN;
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
public static clsvcc_CourseExamPaperRelationship4AppEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN = null;
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
objvcc_CourseExamPaperRelationship4AppEN = JsonConvert.DeserializeObject<clsvcc_CourseExamPaperRelationship4AppEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseExamPaperRelationship4AppEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseExamPaperRelationship4AppEN GetObjBymId_Cache(long lngmId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_CourseExamPaperRelationship4AppEN._CurrTabName_S, strCourseId);
List<clsvcc_CourseExamPaperRelationship4AppEN> arrvcc_CourseExamPaperRelationship4AppObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvcc_CourseExamPaperRelationship4AppEN> arrvcc_CourseExamPaperRelationship4AppObjLst_Sel =
from objvcc_CourseExamPaperRelationship4AppEN in arrvcc_CourseExamPaperRelationship4AppObjLst_Cache
where objvcc_CourseExamPaperRelationship4AppEN.mId == lngmId
select objvcc_CourseExamPaperRelationship4AppEN;
if (arrvcc_CourseExamPaperRelationship4AppObjLst_Sel.Count() == 0)
{
   clsvcc_CourseExamPaperRelationship4AppEN obj = clsvcc_CourseExamPaperRelationship4AppWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_CourseExamPaperRelationship4AppObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseExamPaperRelationship4AppEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_CourseExamPaperRelationship4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseExamPaperRelationship4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseExamPaperRelationship4AppEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvcc_CourseExamPaperRelationship4AppEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseExamPaperRelationship4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvcc_CourseExamPaperRelationship4AppEN> GetObjLstByMIdLst_Cache(List<long> arrMId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_CourseExamPaperRelationship4AppEN._CurrTabName_S, strCourseId);
List<clsvcc_CourseExamPaperRelationship4AppEN> arrvcc_CourseExamPaperRelationship4AppObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvcc_CourseExamPaperRelationship4AppEN> arrvcc_CourseExamPaperRelationship4AppObjLst_Sel =
from objvcc_CourseExamPaperRelationship4AppEN in arrvcc_CourseExamPaperRelationship4AppObjLst_Cache
where arrMId.Contains(objvcc_CourseExamPaperRelationship4AppEN.mId)
select objvcc_CourseExamPaperRelationship4AppEN;
return arrvcc_CourseExamPaperRelationship4AppObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseExamPaperRelationship4AppEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId, string strCourseId)
{
 List<clsvcc_CourseExamPaperRelationship4AppEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseExamPaperRelationship4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseExamPaperRelationship4AppEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_CourseExamPaperRelationship4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseExamPaperRelationship4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseExamPaperRelationship4AppEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_CourseExamPaperRelationship4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseExamPaperRelationship4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseExamPaperRelationship4AppEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_CourseExamPaperRelationship4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseExamPaperRelationship4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseExamPaperRelationship4AppEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_CourseExamPaperRelationship4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseExamPaperRelationship4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
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
objvcc_CourseExamPaperRelationship4AppENT.QuestionID = objvcc_CourseExamPaperRelationship4AppENS.QuestionID; //题目ID
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
public static DataTable ToDataTable(List<clsvcc_CourseExamPaperRelationship4AppEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_CourseExamPaperRelationship4AppEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_CourseExamPaperRelationship4AppEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_CourseExamPaperRelationship4AppEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_CourseExamPaperRelationship4AppEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_CourseExamPaperRelationship4AppEN.AttributeName)
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
if (clscc_CourseExamPaperWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseExamPaperWApi没有刷新缓存机制(clscc_CourseExamPaperWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseExamPaperRelationshipWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseExamPaperRelationshipWApi没有刷新缓存机制(clscc_CourseExamPaperRelationshipWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_PapersBigTopicWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_PapersBigTopicWApi没有刷新缓存机制(clscc_PapersBigTopicWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionnaireWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireWApi没有刷新缓存机制(clsQuestionnaireWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerModeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerModeWApi没有刷新缓存机制(clsAnswerModeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerTypeWApi没有刷新缓存机制(clsAnswerTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeWApi没有刷新缓存机制(clsQuestionTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExamGradeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamGradeWApi没有刷新缓存机制(clscc_ExamGradeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionType4CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionType4CourseWApi没有刷新缓存机制(clsQuestionType4CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvcc_CourseExamPaperRelationship4AppObjLst_Cache == null)
//{
//arrvcc_CourseExamPaperRelationship4AppObjLst_Cache = await clsvcc_CourseExamPaperRelationship4AppWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsvcc_CourseExamPaperRelationship4AppEN._CurrTabName_S, strCourseId);
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
public static List<clsvcc_CourseExamPaperRelationship4AppEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvcc_CourseExamPaperRelationship4AppEN._CurrTabName_S, strCourseId);
List<clsvcc_CourseExamPaperRelationship4AppEN> arrvcc_CourseExamPaperRelationship4AppObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrvcc_CourseExamPaperRelationship4AppObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_CourseExamPaperRelationship4AppEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_CourseExamPaperRelationship4App.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship4App.CourseExamPaperId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship4App.ExamPaperName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship4App.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship4App.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship4App.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship4App.QuestionIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship4App.QuestionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship4App.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship4App.QuestionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship4App.ExamGradeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship4App.ExamGradeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship4App.QuestionScore, Type.GetType("System.Single"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship4App.IsEffective, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship4App.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship4App.StartTime, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship4App.PapersBigTopicId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship4App.PapersBigTopicName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship4App.TopicDescription, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship4App.TopicScores, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship4App.TopicOrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship4App.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship4App.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship4App.UpdUser, Type.GetType("System.String"));
foreach (clsvcc_CourseExamPaperRelationship4AppEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_CourseExamPaperRelationship4App.mId] = objInFor[convcc_CourseExamPaperRelationship4App.mId];
objDR[convcc_CourseExamPaperRelationship4App.CourseExamPaperId] = objInFor[convcc_CourseExamPaperRelationship4App.CourseExamPaperId];
objDR[convcc_CourseExamPaperRelationship4App.ExamPaperName] = objInFor[convcc_CourseExamPaperRelationship4App.ExamPaperName];
objDR[convcc_CourseExamPaperRelationship4App.CourseId] = objInFor[convcc_CourseExamPaperRelationship4App.CourseId];
objDR[convcc_CourseExamPaperRelationship4App.CourseName] = objInFor[convcc_CourseExamPaperRelationship4App.CourseName];
objDR[convcc_CourseExamPaperRelationship4App.QuestionID] = objInFor[convcc_CourseExamPaperRelationship4App.QuestionID];
objDR[convcc_CourseExamPaperRelationship4App.QuestionIndex] = objInFor[convcc_CourseExamPaperRelationship4App.QuestionIndex];
objDR[convcc_CourseExamPaperRelationship4App.QuestionName] = objInFor[convcc_CourseExamPaperRelationship4App.QuestionName];
objDR[convcc_CourseExamPaperRelationship4App.QuestionTypeId] = objInFor[convcc_CourseExamPaperRelationship4App.QuestionTypeId];
objDR[convcc_CourseExamPaperRelationship4App.QuestionTypeName] = objInFor[convcc_CourseExamPaperRelationship4App.QuestionTypeName];
objDR[convcc_CourseExamPaperRelationship4App.ExamGradeId] = objInFor[convcc_CourseExamPaperRelationship4App.ExamGradeId];
objDR[convcc_CourseExamPaperRelationship4App.ExamGradeName] = objInFor[convcc_CourseExamPaperRelationship4App.ExamGradeName];
objDR[convcc_CourseExamPaperRelationship4App.QuestionScore] = objInFor[convcc_CourseExamPaperRelationship4App.QuestionScore];
objDR[convcc_CourseExamPaperRelationship4App.IsEffective] = objInFor[convcc_CourseExamPaperRelationship4App.IsEffective];
objDR[convcc_CourseExamPaperRelationship4App.UserId] = objInFor[convcc_CourseExamPaperRelationship4App.UserId];
objDR[convcc_CourseExamPaperRelationship4App.StartTime] = objInFor[convcc_CourseExamPaperRelationship4App.StartTime];
objDR[convcc_CourseExamPaperRelationship4App.PapersBigTopicId] = objInFor[convcc_CourseExamPaperRelationship4App.PapersBigTopicId];
objDR[convcc_CourseExamPaperRelationship4App.PapersBigTopicName] = objInFor[convcc_CourseExamPaperRelationship4App.PapersBigTopicName];
objDR[convcc_CourseExamPaperRelationship4App.TopicDescription] = objInFor[convcc_CourseExamPaperRelationship4App.TopicDescription];
objDR[convcc_CourseExamPaperRelationship4App.TopicScores] = objInFor[convcc_CourseExamPaperRelationship4App.TopicScores];
objDR[convcc_CourseExamPaperRelationship4App.TopicOrderNum] = objInFor[convcc_CourseExamPaperRelationship4App.TopicOrderNum];
objDR[convcc_CourseExamPaperRelationship4App.OrderNum] = objInFor[convcc_CourseExamPaperRelationship4App.OrderNum];
objDR[convcc_CourseExamPaperRelationship4App.UpdDate] = objInFor[convcc_CourseExamPaperRelationship4App.UpdDate];
objDR[convcc_CourseExamPaperRelationship4App.UpdUser] = objInFor[convcc_CourseExamPaperRelationship4App.UpdUser];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}