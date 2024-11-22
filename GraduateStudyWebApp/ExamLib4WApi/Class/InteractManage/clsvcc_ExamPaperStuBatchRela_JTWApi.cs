
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_ExamPaperStuBatchRela_JTWApi
 表名:vcc_ExamPaperStuBatchRela_JT(01120247)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:44:09
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
public static class clsvcc_ExamPaperStuBatchRela_JTWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetId_PaperStuBatch(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strId_PaperStuBatch, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_PaperStuBatch, 10, convcc_ExamPaperStuBatchRela_JT.Id_PaperStuBatch);
clsCheckSql.CheckFieldForeignKey(strId_PaperStuBatch, 10, convcc_ExamPaperStuBatchRela_JT.Id_PaperStuBatch);
objvcc_ExamPaperStuBatchRela_JTEN.Id_PaperStuBatch = strId_PaperStuBatch; //学生试卷批次流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.Id_PaperStuBatch) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.Id_PaperStuBatch, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.Id_PaperStuBatch] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetCourseExamPaperId(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, convcc_ExamPaperStuBatchRela_JT.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, convcc_ExamPaperStuBatchRela_JT.CourseExamPaperId);
objvcc_ExamPaperStuBatchRela_JTEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.CourseExamPaperId) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.CourseExamPaperId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.CourseExamPaperId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetCourseId(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_ExamPaperStuBatchRela_JT.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_ExamPaperStuBatchRela_JT.CourseId);
objvcc_ExamPaperStuBatchRela_JTEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.CourseId) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.CourseId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.CourseId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetCourseName(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_ExamPaperStuBatchRela_JT.CourseName);
objvcc_ExamPaperStuBatchRela_JTEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.CourseName) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.CourseName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.CourseName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetExamPaperName(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strExamPaperName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamPaperName, 500, convcc_ExamPaperStuBatchRela_JT.ExamPaperName);
objvcc_ExamPaperStuBatchRela_JTEN.ExamPaperName = strExamPaperName; //考卷名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.ExamPaperName) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.ExamPaperName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.ExamPaperName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetPaperIndex(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, int intPaperIndex, string strComparisonOp="")
	{
objvcc_ExamPaperStuBatchRela_JTEN.PaperIndex = intPaperIndex; //试卷序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.PaperIndex) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.PaperIndex, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.PaperIndex] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetExamPaperTypeId(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strExamPaperTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamPaperTypeId, 2, convcc_ExamPaperStuBatchRela_JT.ExamPaperTypeId);
clsCheckSql.CheckFieldForeignKey(strExamPaperTypeId, 2, convcc_ExamPaperStuBatchRela_JT.ExamPaperTypeId);
objvcc_ExamPaperStuBatchRela_JTEN.ExamPaperTypeId = strExamPaperTypeId; //试卷类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.ExamPaperTypeId) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.ExamPaperTypeId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.ExamPaperTypeId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetExamPaperTypeName(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strExamPaperTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamPaperTypeName, 30, convcc_ExamPaperStuBatchRela_JT.ExamPaperTypeName);
objvcc_ExamPaperStuBatchRela_JTEN.ExamPaperTypeName = strExamPaperTypeName; //试卷类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.ExamPaperTypeName) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.ExamPaperTypeName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.ExamPaperTypeName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetIsShow(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, bool bolIsShow, string strComparisonOp="")
	{
objvcc_ExamPaperStuBatchRela_JTEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.IsShow) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.IsShow, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.IsShow] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetTotalScore(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, double dblTotalScore, string strComparisonOp="")
	{
objvcc_ExamPaperStuBatchRela_JTEN.TotalScore = dblTotalScore; //总得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.TotalScore) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.TotalScore, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.TotalScore] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetViewCount(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, int intViewCount, string strComparisonOp="")
	{
objvcc_ExamPaperStuBatchRela_JTEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.ViewCount) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.ViewCount, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.ViewCount] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetDoneNumber(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, int intDoneNumber, string strComparisonOp="")
	{
objvcc_ExamPaperStuBatchRela_JTEN.DoneNumber = intDoneNumber; //已做人数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.DoneNumber) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.DoneNumber, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.DoneNumber] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetPaperTime(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, int intPaperTime, string strComparisonOp="")
	{
objvcc_ExamPaperStuBatchRela_JTEN.PaperTime = intPaperTime; //考试时间（分钟）
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.PaperTime) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.PaperTime, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.PaperTime] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetPaperDispModeName(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strPaperDispModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperDispModeName, 30, convcc_ExamPaperStuBatchRela_JT.PaperDispModeName);
objvcc_ExamPaperStuBatchRela_JTEN.PaperDispModeName = strPaperDispModeName; //试卷显示模式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.PaperDispModeName) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.PaperDispModeName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.PaperDispModeName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetExamCreateTime(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strExamCreateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamCreateTime, 14, convcc_ExamPaperStuBatchRela_JT.ExamCreateTime);
objvcc_ExamPaperStuBatchRela_JTEN.ExamCreateTime = strExamCreateTime; //考卷建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.ExamCreateTime) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.ExamCreateTime, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.ExamCreateTime] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetUserName(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convcc_ExamPaperStuBatchRela_JT.UserName);
objvcc_ExamPaperStuBatchRela_JTEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.UserName) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.UserName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.UserName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetCourseChapterId(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_ExamPaperStuBatchRela_JT.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_ExamPaperStuBatchRela_JT.CourseChapterId);
objvcc_ExamPaperStuBatchRela_JTEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.CourseChapterId) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.CourseChapterId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.CourseChapterId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetCourseChapterName(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_ExamPaperStuBatchRela_JT.CourseChapterName);
objvcc_ExamPaperStuBatchRela_JTEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.CourseChapterName) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.CourseChapterName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.CourseChapterName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetChapterId(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterId, 8, convcc_ExamPaperStuBatchRela_JT.ChapterId);
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convcc_ExamPaperStuBatchRela_JT.ChapterId);
objvcc_ExamPaperStuBatchRela_JTEN.ChapterId = strChapterId; //章Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.ChapterId) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.ChapterId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.ChapterId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetSectionId(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strSectionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionId, 8, convcc_ExamPaperStuBatchRela_JT.SectionId);
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convcc_ExamPaperStuBatchRela_JT.SectionId);
objvcc_ExamPaperStuBatchRela_JTEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.SectionId) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.SectionId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.SectionId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetChapterName(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_ExamPaperStuBatchRela_JT.ChapterName);
objvcc_ExamPaperStuBatchRela_JTEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.ChapterName) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.ChapterName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.ChapterName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetSectionName(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_ExamPaperStuBatchRela_JT.SectionName);
objvcc_ExamPaperStuBatchRela_JTEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.SectionName) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.SectionName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.SectionName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetChapterName_Sim(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convcc_ExamPaperStuBatchRela_JT.ChapterName_Sim);
objvcc_ExamPaperStuBatchRela_JTEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.ChapterName_Sim) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.ChapterName_Sim, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.ChapterName_Sim] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetSectionName_Sim(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, convcc_ExamPaperStuBatchRela_JT.SectionName_Sim);
objvcc_ExamPaperStuBatchRela_JTEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.SectionName_Sim) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.SectionName_Sim, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.SectionName_Sim] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetIsAutoGeneQuestion(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, bool bolIsAutoGeneQuestion, string strComparisonOp="")
	{
objvcc_ExamPaperStuBatchRela_JTEN.IsAutoGeneQuestion = bolIsAutoGeneQuestion; //是否自动生成题目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.IsAutoGeneQuestion) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.IsAutoGeneQuestion, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.IsAutoGeneQuestion] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetIsCanMultiDo(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, bool bolIsCanMultiDo, string strComparisonOp="")
	{
objvcc_ExamPaperStuBatchRela_JTEN.IsCanMultiDo = bolIsCanMultiDo; //是否可以做多次
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.IsCanMultiDo) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.IsCanMultiDo, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.IsCanMultiDo] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetQuestionNum(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, int intQuestionNum, string strComparisonOp="")
	{
objvcc_ExamPaperStuBatchRela_JTEN.QuestionNum = intQuestionNum; //题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.QuestionNum) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.QuestionNum, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.QuestionNum] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN Setid_StudentInfo(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudentInfo, convcc_ExamPaperStuBatchRela_JT.id_StudentInfo);
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, convcc_ExamPaperStuBatchRela_JT.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, convcc_ExamPaperStuBatchRela_JT.id_StudentInfo);
objvcc_ExamPaperStuBatchRela_JTEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.id_StudentInfo) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.id_StudentInfo, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.id_StudentInfo] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetSiteName(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strSiteName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSiteName, 100, convcc_ExamPaperStuBatchRela_JT.SiteName);
objvcc_ExamPaperStuBatchRela_JTEN.SiteName = strSiteName; //工地名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.SiteName) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.SiteName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.SiteName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetStuID(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convcc_ExamPaperStuBatchRela_JT.StuID);
objvcc_ExamPaperStuBatchRela_JTEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.StuID) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.StuID, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.StuID] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetStuName(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convcc_ExamPaperStuBatchRela_JT.StuName);
objvcc_ExamPaperStuBatchRela_JTEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.StuName) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.StuName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.StuName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetManagedDepartmentId(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strManagedDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strManagedDepartmentId, 4, convcc_ExamPaperStuBatchRela_JT.ManagedDepartmentId);
clsCheckSql.CheckFieldForeignKey(strManagedDepartmentId, 4, convcc_ExamPaperStuBatchRela_JT.ManagedDepartmentId);
objvcc_ExamPaperStuBatchRela_JTEN.ManagedDepartmentId = strManagedDepartmentId; //管理的部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.ManagedDepartmentId) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.ManagedDepartmentId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.ManagedDepartmentId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetManagedDepartmentName(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strManagedDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strManagedDepartmentName, 50, convcc_ExamPaperStuBatchRela_JT.ManagedDepartmentName);
objvcc_ExamPaperStuBatchRela_JTEN.ManagedDepartmentName = strManagedDepartmentName; //管理的部门名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.ManagedDepartmentName) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.ManagedDepartmentName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.ManagedDepartmentName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetJobCategoryId(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strJobCategoryId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strJobCategoryId, 2, convcc_ExamPaperStuBatchRela_JT.JobCategoryId);
clsCheckSql.CheckFieldForeignKey(strJobCategoryId, 2, convcc_ExamPaperStuBatchRela_JT.JobCategoryId);
objvcc_ExamPaperStuBatchRela_JTEN.JobCategoryId = strJobCategoryId; //岗位类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.JobCategoryId) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.JobCategoryId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.JobCategoryId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetJobCategoryName(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strJobCategoryName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strJobCategoryName, 50, convcc_ExamPaperStuBatchRela_JT.JobCategoryName);
objvcc_ExamPaperStuBatchRela_JTEN.JobCategoryName = strJobCategoryName; //岗位类别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.JobCategoryName) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.JobCategoryName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.JobCategoryName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetSexDesc(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strSexDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convcc_ExamPaperStuBatchRela_JT.SexDesc);
objvcc_ExamPaperStuBatchRela_JTEN.SexDesc = strSexDesc; //性别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.SexDesc) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.SexDesc, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.SexDesc] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN Setid_XzCollege(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convcc_ExamPaperStuBatchRela_JT.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convcc_ExamPaperStuBatchRela_JT.id_XzCollege);
objvcc_ExamPaperStuBatchRela_JTEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.id_XzCollege) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.id_XzCollege, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.id_XzCollege] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetCollegeName(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convcc_ExamPaperStuBatchRela_JT.CollegeName);
objvcc_ExamPaperStuBatchRela_JTEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.CollegeName) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.CollegeName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.CollegeName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetCollegeNameA(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convcc_ExamPaperStuBatchRela_JT.CollegeNameA);
objvcc_ExamPaperStuBatchRela_JTEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.CollegeNameA) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.CollegeNameA, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.CollegeNameA] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetBatchTime(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strBatchTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBatchTime, 14, convcc_ExamPaperStuBatchRela_JT.BatchTime);
objvcc_ExamPaperStuBatchRela_JTEN.BatchTime = strBatchTime; //批次
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.BatchTime) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.BatchTime, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.BatchTime] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN Setid_CurrEduCls(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CurrEduCls, convcc_ExamPaperStuBatchRela_JT.id_CurrEduCls);
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convcc_ExamPaperStuBatchRela_JT.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convcc_ExamPaperStuBatchRela_JT.id_CurrEduCls);
objvcc_ExamPaperStuBatchRela_JTEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.id_CurrEduCls) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.id_CurrEduCls, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.id_CurrEduCls] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetCurrEduClsId(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strCurrEduClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, convcc_ExamPaperStuBatchRela_JT.CurrEduClsId);
objvcc_ExamPaperStuBatchRela_JTEN.CurrEduClsId = strCurrEduClsId; //当前教学班Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.CurrEduClsId) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.CurrEduClsId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.CurrEduClsId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetEduClsName(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convcc_ExamPaperStuBatchRela_JT.EduClsName);
objvcc_ExamPaperStuBatchRela_JTEN.EduClsName = strEduClsName; //教学班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.EduClsName) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.EduClsName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.EduClsName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetScores(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, double dblScores, string strComparisonOp="")
	{
objvcc_ExamPaperStuBatchRela_JTEN.Scores = dblScores; //分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.Scores) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.Scores, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.Scores] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetIsSave(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, bool bolIsSave, string strComparisonOp="")
	{
objvcc_ExamPaperStuBatchRela_JTEN.IsSave = bolIsSave; //是否保存
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.IsSave) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.IsSave, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.IsSave] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetIsSubmit(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvcc_ExamPaperStuBatchRela_JTEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.IsSubmit) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.IsSubmit, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.IsSubmit] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetRealFinishDate(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strRealFinishDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRealFinishDate, 14, convcc_ExamPaperStuBatchRela_JT.RealFinishDate);
objvcc_ExamPaperStuBatchRela_JTEN.RealFinishDate = strRealFinishDate; //实际完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.RealFinishDate) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.RealFinishDate, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.RealFinishDate] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetOperateTime(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strOperateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOperateTime, 14, convcc_ExamPaperStuBatchRela_JT.OperateTime);
objvcc_ExamPaperStuBatchRela_JTEN.OperateTime = strOperateTime; //操作时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.OperateTime) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.OperateTime, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.OperateTime] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetIsMarking(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, bool bolIsMarking, string strComparisonOp="")
	{
objvcc_ExamPaperStuBatchRela_JTEN.IsMarking = bolIsMarking; //是否批阅
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.IsMarking) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.IsMarking, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.IsMarking] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetMarkerId(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strMarkerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkerId, 20, convcc_ExamPaperStuBatchRela_JT.MarkerId);
objvcc_ExamPaperStuBatchRela_JTEN.MarkerId = strMarkerId; //打分者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.MarkerId) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.MarkerId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.MarkerId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetMarkDate(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strMarkDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkDate, 14, convcc_ExamPaperStuBatchRela_JT.MarkDate);
objvcc_ExamPaperStuBatchRela_JTEN.MarkDate = strMarkDate; //打分日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.MarkDate) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.MarkDate, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.MarkDate] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetAnswerIP(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strAnswerIP, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerIP, 30, convcc_ExamPaperStuBatchRela_JT.AnswerIP);
objvcc_ExamPaperStuBatchRela_JTEN.AnswerIP = strAnswerIP; //回答IP
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.AnswerIP) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.AnswerIP, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.AnswerIP] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetAnswerDate(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strAnswerDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerDate, 8, convcc_ExamPaperStuBatchRela_JT.AnswerDate);
objvcc_ExamPaperStuBatchRela_JTEN.AnswerDate = strAnswerDate; //回答日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.AnswerDate) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.AnswerDate, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.AnswerDate] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetAnswerTime(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strAnswerTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTime, 10, convcc_ExamPaperStuBatchRela_JT.AnswerTime);
objvcc_ExamPaperStuBatchRela_JTEN.AnswerTime = strAnswerTime; //回答时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.AnswerTime) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.AnswerTime, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.AnswerTime] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetTotalGetScore(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, double dblTotalGetScore, string strComparisonOp="")
	{
objvcc_ExamPaperStuBatchRela_JTEN.TotalGetScore = dblTotalGetScore; //考生获取总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.TotalGetScore) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.TotalGetScore, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.TotalGetScore] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetUpdDate(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_ExamPaperStuBatchRela_JT.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_ExamPaperStuBatchRela_JT.UpdDate);
objvcc_ExamPaperStuBatchRela_JTEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.UpdDate) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.UpdDate, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.UpdDate] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetUpdUserId(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_ExamPaperStuBatchRela_JT.UpdUserId);
objvcc_ExamPaperStuBatchRela_JTEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.UpdUserId) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.UpdUserId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.UpdUserId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetMemo(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_ExamPaperStuBatchRela_JT.Memo);
objvcc_ExamPaperStuBatchRela_JTEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.Memo) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.Memo, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.Memo] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetNoSubmitQuesNum(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, int intNoSubmitQuesNum, string strComparisonOp="")
	{
objvcc_ExamPaperStuBatchRela_JTEN.NoSubmitQuesNum = intNoSubmitQuesNum; //未提交题数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.NoSubmitQuesNum) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.NoSubmitQuesNum, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.NoSubmitQuesNum] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN SetSubmitQuesNum(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN, int intSubmitQuesNum, string strComparisonOp="")
	{
objvcc_ExamPaperStuBatchRela_JTEN.SubmitQuesNum = intSubmitQuesNum; //提交题数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela_JT.SubmitQuesNum) == false)
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela_JT.SubmitQuesNum, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRela_JTEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.SubmitQuesNum] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRela_JTEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JT_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.Id_PaperStuBatch) == true)
{
string strComparisonOp_Id_PaperStuBatch = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.Id_PaperStuBatch];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.Id_PaperStuBatch, objvcc_ExamPaperStuBatchRela_JT_Cond.Id_PaperStuBatch, strComparisonOp_Id_PaperStuBatch);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.CourseExamPaperId) == true)
{
string strComparisonOp_CourseExamPaperId = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.CourseExamPaperId, objvcc_ExamPaperStuBatchRela_JT_Cond.CourseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.CourseId, objvcc_ExamPaperStuBatchRela_JT_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.CourseName, objvcc_ExamPaperStuBatchRela_JT_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.ExamPaperName) == true)
{
string strComparisonOp_ExamPaperName = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.ExamPaperName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.ExamPaperName, objvcc_ExamPaperStuBatchRela_JT_Cond.ExamPaperName, strComparisonOp_ExamPaperName);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.PaperIndex) == true)
{
string strComparisonOp_PaperIndex = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.PaperIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuBatchRela_JT.PaperIndex, objvcc_ExamPaperStuBatchRela_JT_Cond.PaperIndex, strComparisonOp_PaperIndex);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.ExamPaperTypeId) == true)
{
string strComparisonOp_ExamPaperTypeId = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.ExamPaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.ExamPaperTypeId, objvcc_ExamPaperStuBatchRela_JT_Cond.ExamPaperTypeId, strComparisonOp_ExamPaperTypeId);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.ExamPaperTypeName) == true)
{
string strComparisonOp_ExamPaperTypeName = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.ExamPaperTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.ExamPaperTypeName, objvcc_ExamPaperStuBatchRela_JT_Cond.ExamPaperTypeName, strComparisonOp_ExamPaperTypeName);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.IsShow) == true)
{
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuBatchRela_JT.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuBatchRela_JT.IsShow);
}
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.TotalScore) == true)
{
string strComparisonOp_TotalScore = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.TotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuBatchRela_JT.TotalScore, objvcc_ExamPaperStuBatchRela_JT_Cond.TotalScore, strComparisonOp_TotalScore);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuBatchRela_JT.ViewCount, objvcc_ExamPaperStuBatchRela_JT_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.DoneNumber) == true)
{
string strComparisonOp_DoneNumber = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.DoneNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuBatchRela_JT.DoneNumber, objvcc_ExamPaperStuBatchRela_JT_Cond.DoneNumber, strComparisonOp_DoneNumber);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.PaperTime) == true)
{
string strComparisonOp_PaperTime = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.PaperTime];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuBatchRela_JT.PaperTime, objvcc_ExamPaperStuBatchRela_JT_Cond.PaperTime, strComparisonOp_PaperTime);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.PaperDispModeName) == true)
{
string strComparisonOp_PaperDispModeName = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.PaperDispModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.PaperDispModeName, objvcc_ExamPaperStuBatchRela_JT_Cond.PaperDispModeName, strComparisonOp_PaperDispModeName);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.ExamCreateTime) == true)
{
string strComparisonOp_ExamCreateTime = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.ExamCreateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.ExamCreateTime, objvcc_ExamPaperStuBatchRela_JT_Cond.ExamCreateTime, strComparisonOp_ExamCreateTime);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.UserName) == true)
{
string strComparisonOp_UserName = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.UserName, objvcc_ExamPaperStuBatchRela_JT_Cond.UserName, strComparisonOp_UserName);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.CourseChapterId, objvcc_ExamPaperStuBatchRela_JT_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.CourseChapterName, objvcc_ExamPaperStuBatchRela_JT_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.ChapterId) == true)
{
string strComparisonOp_ChapterId = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.ChapterId, objvcc_ExamPaperStuBatchRela_JT_Cond.ChapterId, strComparisonOp_ChapterId);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.SectionId) == true)
{
string strComparisonOp_SectionId = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.SectionId, objvcc_ExamPaperStuBatchRela_JT_Cond.SectionId, strComparisonOp_SectionId);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.ChapterName, objvcc_ExamPaperStuBatchRela_JT_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.SectionName) == true)
{
string strComparisonOp_SectionName = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.SectionName, objvcc_ExamPaperStuBatchRela_JT_Cond.SectionName, strComparisonOp_SectionName);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.ChapterName_Sim, objvcc_ExamPaperStuBatchRela_JT_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.SectionName_Sim, objvcc_ExamPaperStuBatchRela_JT_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.IsAutoGeneQuestion) == true)
{
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsAutoGeneQuestion == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuBatchRela_JT.IsAutoGeneQuestion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuBatchRela_JT.IsAutoGeneQuestion);
}
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.IsCanMultiDo) == true)
{
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsCanMultiDo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuBatchRela_JT.IsCanMultiDo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuBatchRela_JT.IsCanMultiDo);
}
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.QuestionNum) == true)
{
string strComparisonOp_QuestionNum = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.QuestionNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuBatchRela_JT.QuestionNum, objvcc_ExamPaperStuBatchRela_JT_Cond.QuestionNum, strComparisonOp_QuestionNum);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.id_StudentInfo, objvcc_ExamPaperStuBatchRela_JT_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.SiteName) == true)
{
string strComparisonOp_SiteName = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.SiteName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.SiteName, objvcc_ExamPaperStuBatchRela_JT_Cond.SiteName, strComparisonOp_SiteName);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.StuID) == true)
{
string strComparisonOp_StuID = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.StuID, objvcc_ExamPaperStuBatchRela_JT_Cond.StuID, strComparisonOp_StuID);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.StuName) == true)
{
string strComparisonOp_StuName = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.StuName, objvcc_ExamPaperStuBatchRela_JT_Cond.StuName, strComparisonOp_StuName);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.ManagedDepartmentId) == true)
{
string strComparisonOp_ManagedDepartmentId = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.ManagedDepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.ManagedDepartmentId, objvcc_ExamPaperStuBatchRela_JT_Cond.ManagedDepartmentId, strComparisonOp_ManagedDepartmentId);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.ManagedDepartmentName) == true)
{
string strComparisonOp_ManagedDepartmentName = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.ManagedDepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.ManagedDepartmentName, objvcc_ExamPaperStuBatchRela_JT_Cond.ManagedDepartmentName, strComparisonOp_ManagedDepartmentName);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.JobCategoryId) == true)
{
string strComparisonOp_JobCategoryId = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.JobCategoryId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.JobCategoryId, objvcc_ExamPaperStuBatchRela_JT_Cond.JobCategoryId, strComparisonOp_JobCategoryId);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.JobCategoryName) == true)
{
string strComparisonOp_JobCategoryName = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.JobCategoryName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.JobCategoryName, objvcc_ExamPaperStuBatchRela_JT_Cond.JobCategoryName, strComparisonOp_JobCategoryName);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.SexDesc) == true)
{
string strComparisonOp_SexDesc = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.SexDesc, objvcc_ExamPaperStuBatchRela_JT_Cond.SexDesc, strComparisonOp_SexDesc);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.id_XzCollege, objvcc_ExamPaperStuBatchRela_JT_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.CollegeName, objvcc_ExamPaperStuBatchRela_JT_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.CollegeNameA, objvcc_ExamPaperStuBatchRela_JT_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.BatchTime) == true)
{
string strComparisonOp_BatchTime = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.BatchTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.BatchTime, objvcc_ExamPaperStuBatchRela_JT_Cond.BatchTime, strComparisonOp_BatchTime);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.id_CurrEduCls, objvcc_ExamPaperStuBatchRela_JT_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.CurrEduClsId) == true)
{
string strComparisonOp_CurrEduClsId = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.CurrEduClsId, objvcc_ExamPaperStuBatchRela_JT_Cond.CurrEduClsId, strComparisonOp_CurrEduClsId);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.EduClsName) == true)
{
string strComparisonOp_EduClsName = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.EduClsName, objvcc_ExamPaperStuBatchRela_JT_Cond.EduClsName, strComparisonOp_EduClsName);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.Scores) == true)
{
string strComparisonOp_Scores = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.Scores];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuBatchRela_JT.Scores, objvcc_ExamPaperStuBatchRela_JT_Cond.Scores, strComparisonOp_Scores);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.IsSave) == true)
{
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsSave == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuBatchRela_JT.IsSave);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuBatchRela_JT.IsSave);
}
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.IsSubmit) == true)
{
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuBatchRela_JT.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuBatchRela_JT.IsSubmit);
}
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.RealFinishDate) == true)
{
string strComparisonOp_RealFinishDate = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.RealFinishDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.RealFinishDate, objvcc_ExamPaperStuBatchRela_JT_Cond.RealFinishDate, strComparisonOp_RealFinishDate);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.OperateTime) == true)
{
string strComparisonOp_OperateTime = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.OperateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.OperateTime, objvcc_ExamPaperStuBatchRela_JT_Cond.OperateTime, strComparisonOp_OperateTime);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.IsMarking) == true)
{
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsMarking == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuBatchRela_JT.IsMarking);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuBatchRela_JT.IsMarking);
}
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.MarkerId) == true)
{
string strComparisonOp_MarkerId = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.MarkerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.MarkerId, objvcc_ExamPaperStuBatchRela_JT_Cond.MarkerId, strComparisonOp_MarkerId);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.MarkDate) == true)
{
string strComparisonOp_MarkDate = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.MarkDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.MarkDate, objvcc_ExamPaperStuBatchRela_JT_Cond.MarkDate, strComparisonOp_MarkDate);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.AnswerIP) == true)
{
string strComparisonOp_AnswerIP = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.AnswerIP];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.AnswerIP, objvcc_ExamPaperStuBatchRela_JT_Cond.AnswerIP, strComparisonOp_AnswerIP);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.AnswerDate) == true)
{
string strComparisonOp_AnswerDate = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.AnswerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.AnswerDate, objvcc_ExamPaperStuBatchRela_JT_Cond.AnswerDate, strComparisonOp_AnswerDate);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.AnswerTime) == true)
{
string strComparisonOp_AnswerTime = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.AnswerTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.AnswerTime, objvcc_ExamPaperStuBatchRela_JT_Cond.AnswerTime, strComparisonOp_AnswerTime);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.TotalGetScore) == true)
{
string strComparisonOp_TotalGetScore = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.TotalGetScore];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuBatchRela_JT.TotalGetScore, objvcc_ExamPaperStuBatchRela_JT_Cond.TotalGetScore, strComparisonOp_TotalGetScore);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.UpdDate, objvcc_ExamPaperStuBatchRela_JT_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.UpdUserId, objvcc_ExamPaperStuBatchRela_JT_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.Memo) == true)
{
string strComparisonOp_Memo = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela_JT.Memo, objvcc_ExamPaperStuBatchRela_JT_Cond.Memo, strComparisonOp_Memo);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.NoSubmitQuesNum) == true)
{
string strComparisonOp_NoSubmitQuesNum = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.NoSubmitQuesNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuBatchRela_JT.NoSubmitQuesNum, objvcc_ExamPaperStuBatchRela_JT_Cond.NoSubmitQuesNum, strComparisonOp_NoSubmitQuesNum);
}
if (objvcc_ExamPaperStuBatchRela_JT_Cond.IsUpdated(convcc_ExamPaperStuBatchRela_JT.SubmitQuesNum) == true)
{
string strComparisonOp_SubmitQuesNum = objvcc_ExamPaperStuBatchRela_JT_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela_JT.SubmitQuesNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuBatchRela_JT.SubmitQuesNum, objvcc_ExamPaperStuBatchRela_JT_Cond.SubmitQuesNum, strComparisonOp_SubmitQuesNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v考卷与学生批次关系_JT(vcc_ExamPaperStuBatchRela_JT)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_ExamPaperStuBatchRela_JTWApi
{
private static readonly string mstrApiControllerName = "vcc_ExamPaperStuBatchRela_JTApi";

 public clsvcc_ExamPaperStuBatchRela_JTWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_PaperStuBatch">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN GetObjById_PaperStuBatch(string strId_PaperStuBatch)
{
string strAction = "GetObjById_PaperStuBatch";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_PaperStuBatch"] = strId_PaperStuBatch
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_ExamPaperStuBatchRela_JTEN = JsonConvert.DeserializeObject<clsvcc_ExamPaperStuBatchRela_JTEN>((string)jobjReturn["ReturnObj"]);
return objvcc_ExamPaperStuBatchRela_JTEN;
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
 /// <param name = "strId_PaperStuBatch">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN GetObjById_PaperStuBatch_WA_Cache(string strId_PaperStuBatch, string strid_CurrEduCls)
{
string strAction = "GetObjById_PaperStuBatch_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_PaperStuBatch"] = strId_PaperStuBatch,
["id_CurrEduCls"] = strid_CurrEduCls
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_ExamPaperStuBatchRela_JTEN = JsonConvert.DeserializeObject<clsvcc_ExamPaperStuBatchRela_JTEN>((string)jobjReturn["ReturnObj"]);
return objvcc_ExamPaperStuBatchRela_JTEN;
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
public static clsvcc_ExamPaperStuBatchRela_JTEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTEN = null;
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
objvcc_ExamPaperStuBatchRela_JTEN = JsonConvert.DeserializeObject<clsvcc_ExamPaperStuBatchRela_JTEN>((string)jobjReturn["ReturnObj"]);
return objvcc_ExamPaperStuBatchRela_JTEN;
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
 /// <param name = "strId_PaperStuBatch">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_ExamPaperStuBatchRela_JTEN GetObjById_PaperStuBatch_Cache(string strId_PaperStuBatch, string strid_CurrEduCls)
{
if (string.IsNullOrEmpty(strId_PaperStuBatch) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_ExamPaperStuBatchRela_JTEN._CurrTabName_S, strid_CurrEduCls);
List<clsvcc_ExamPaperStuBatchRela_JTEN> arrvcc_ExamPaperStuBatchRela_JTObjLst_Cache = GetObjLst_Cache(strid_CurrEduCls);
IEnumerable <clsvcc_ExamPaperStuBatchRela_JTEN> arrvcc_ExamPaperStuBatchRela_JTObjLst_Sel =
from objvcc_ExamPaperStuBatchRela_JTEN in arrvcc_ExamPaperStuBatchRela_JTObjLst_Cache
where objvcc_ExamPaperStuBatchRela_JTEN.Id_PaperStuBatch == strId_PaperStuBatch
select objvcc_ExamPaperStuBatchRela_JTEN;
if (arrvcc_ExamPaperStuBatchRela_JTObjLst_Sel.Count() == 0)
{
   clsvcc_ExamPaperStuBatchRela_JTEN obj = clsvcc_ExamPaperStuBatchRela_JTWApi.GetObjById_PaperStuBatch(strId_PaperStuBatch);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_ExamPaperStuBatchRela_JTObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_ExamPaperStuBatchRela_JTEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_ExamPaperStuBatchRela_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperStuBatchRela_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperStuBatchRela_JTEN> GetObjLstById_PaperStuBatchLst(List<string> arrId_PaperStuBatch)
{
 List<clsvcc_ExamPaperStuBatchRela_JTEN> arrObjLst = null; 
string strAction = "GetObjLstById_PaperStuBatchLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PaperStuBatch);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperStuBatchRela_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strId_PaperStuBatch">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvcc_ExamPaperStuBatchRela_JTEN> GetObjLstById_PaperStuBatchLst_Cache(List<string> arrId_PaperStuBatch, string strid_CurrEduCls)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_ExamPaperStuBatchRela_JTEN._CurrTabName_S, strid_CurrEduCls);
List<clsvcc_ExamPaperStuBatchRela_JTEN> arrvcc_ExamPaperStuBatchRela_JTObjLst_Cache = GetObjLst_Cache(strid_CurrEduCls);
IEnumerable <clsvcc_ExamPaperStuBatchRela_JTEN> arrvcc_ExamPaperStuBatchRela_JTObjLst_Sel =
from objvcc_ExamPaperStuBatchRela_JTEN in arrvcc_ExamPaperStuBatchRela_JTObjLst_Cache
where arrId_PaperStuBatch.Contains(objvcc_ExamPaperStuBatchRela_JTEN.Id_PaperStuBatch)
select objvcc_ExamPaperStuBatchRela_JTEN;
return arrvcc_ExamPaperStuBatchRela_JTObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_ExamPaperStuBatchRela_JTEN> GetObjLstById_PaperStuBatchLst_WA_Cache(List<string> arrId_PaperStuBatch, string strid_CurrEduCls)
{
 List<clsvcc_ExamPaperStuBatchRela_JTEN> arrObjLst = null; 
string strAction = "GetObjLstById_PaperStuBatchLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CurrEduCls"] = strid_CurrEduCls
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PaperStuBatch);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperStuBatchRela_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperStuBatchRela_JTEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_ExamPaperStuBatchRela_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperStuBatchRela_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperStuBatchRela_JTEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_ExamPaperStuBatchRela_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperStuBatchRela_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperStuBatchRela_JTEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_ExamPaperStuBatchRela_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperStuBatchRela_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperStuBatchRela_JTEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_ExamPaperStuBatchRela_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperStuBatchRela_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strId_PaperStuBatch)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_PaperStuBatch"] = strId_PaperStuBatch
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
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTENS">源对象</param>
 /// <param name = "objvcc_ExamPaperStuBatchRela_JTENT">目标对象</param>
 public static void CopyTo(clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTENS, clsvcc_ExamPaperStuBatchRela_JTEN objvcc_ExamPaperStuBatchRela_JTENT)
{
try
{
objvcc_ExamPaperStuBatchRela_JTENT.Id_PaperStuBatch = objvcc_ExamPaperStuBatchRela_JTENS.Id_PaperStuBatch; //学生试卷批次流水号
objvcc_ExamPaperStuBatchRela_JTENT.CourseExamPaperId = objvcc_ExamPaperStuBatchRela_JTENS.CourseExamPaperId; //考卷流水号
objvcc_ExamPaperStuBatchRela_JTENT.CourseId = objvcc_ExamPaperStuBatchRela_JTENS.CourseId; //课程Id
objvcc_ExamPaperStuBatchRela_JTENT.CourseName = objvcc_ExamPaperStuBatchRela_JTENS.CourseName; //课程名称
objvcc_ExamPaperStuBatchRela_JTENT.ExamPaperName = objvcc_ExamPaperStuBatchRela_JTENS.ExamPaperName; //考卷名称
objvcc_ExamPaperStuBatchRela_JTENT.PaperIndex = objvcc_ExamPaperStuBatchRela_JTENS.PaperIndex; //试卷序号
objvcc_ExamPaperStuBatchRela_JTENT.ExamPaperTypeId = objvcc_ExamPaperStuBatchRela_JTENS.ExamPaperTypeId; //试卷类型Id
objvcc_ExamPaperStuBatchRela_JTENT.ExamPaperTypeName = objvcc_ExamPaperStuBatchRela_JTENS.ExamPaperTypeName; //试卷类型名称
objvcc_ExamPaperStuBatchRela_JTENT.IsShow = objvcc_ExamPaperStuBatchRela_JTENS.IsShow; //是否启用
objvcc_ExamPaperStuBatchRela_JTENT.TotalScore = objvcc_ExamPaperStuBatchRela_JTENS.TotalScore; //总得分
objvcc_ExamPaperStuBatchRela_JTENT.ViewCount = objvcc_ExamPaperStuBatchRela_JTENS.ViewCount; //浏览量
objvcc_ExamPaperStuBatchRela_JTENT.DoneNumber = objvcc_ExamPaperStuBatchRela_JTENS.DoneNumber; //已做人数
objvcc_ExamPaperStuBatchRela_JTENT.PaperTime = objvcc_ExamPaperStuBatchRela_JTENS.PaperTime; //考试时间（分钟）
objvcc_ExamPaperStuBatchRela_JTENT.PaperDispModeName = objvcc_ExamPaperStuBatchRela_JTENS.PaperDispModeName; //试卷显示模式名称
objvcc_ExamPaperStuBatchRela_JTENT.ExamCreateTime = objvcc_ExamPaperStuBatchRela_JTENS.ExamCreateTime; //考卷建立时间
objvcc_ExamPaperStuBatchRela_JTENT.UserName = objvcc_ExamPaperStuBatchRela_JTENS.UserName; //用户名
objvcc_ExamPaperStuBatchRela_JTENT.CourseChapterId = objvcc_ExamPaperStuBatchRela_JTENS.CourseChapterId; //课程章节ID
objvcc_ExamPaperStuBatchRela_JTENT.CourseChapterName = objvcc_ExamPaperStuBatchRela_JTENS.CourseChapterName; //课程章节名称
objvcc_ExamPaperStuBatchRela_JTENT.ChapterId = objvcc_ExamPaperStuBatchRela_JTENS.ChapterId; //章Id
objvcc_ExamPaperStuBatchRela_JTENT.SectionId = objvcc_ExamPaperStuBatchRela_JTENS.SectionId; //节Id
objvcc_ExamPaperStuBatchRela_JTENT.ChapterName = objvcc_ExamPaperStuBatchRela_JTENS.ChapterName; //章名
objvcc_ExamPaperStuBatchRela_JTENT.SectionName = objvcc_ExamPaperStuBatchRela_JTENS.SectionName; //节名
objvcc_ExamPaperStuBatchRela_JTENT.ChapterName_Sim = objvcc_ExamPaperStuBatchRela_JTENS.ChapterName_Sim; //章名简称
objvcc_ExamPaperStuBatchRela_JTENT.SectionName_Sim = objvcc_ExamPaperStuBatchRela_JTENS.SectionName_Sim; //节名简称
objvcc_ExamPaperStuBatchRela_JTENT.IsAutoGeneQuestion = objvcc_ExamPaperStuBatchRela_JTENS.IsAutoGeneQuestion; //是否自动生成题目
objvcc_ExamPaperStuBatchRela_JTENT.IsCanMultiDo = objvcc_ExamPaperStuBatchRela_JTENS.IsCanMultiDo; //是否可以做多次
objvcc_ExamPaperStuBatchRela_JTENT.QuestionNum = objvcc_ExamPaperStuBatchRela_JTENS.QuestionNum; //题目数
objvcc_ExamPaperStuBatchRela_JTENT.id_StudentInfo = objvcc_ExamPaperStuBatchRela_JTENS.id_StudentInfo; //学生流水号
objvcc_ExamPaperStuBatchRela_JTENT.SiteName = objvcc_ExamPaperStuBatchRela_JTENS.SiteName; //工地名称
objvcc_ExamPaperStuBatchRela_JTENT.StuID = objvcc_ExamPaperStuBatchRela_JTENS.StuID; //学号
objvcc_ExamPaperStuBatchRela_JTENT.StuName = objvcc_ExamPaperStuBatchRela_JTENS.StuName; //姓名
objvcc_ExamPaperStuBatchRela_JTENT.ManagedDepartmentId = objvcc_ExamPaperStuBatchRela_JTENS.ManagedDepartmentId; //管理的部门Id
objvcc_ExamPaperStuBatchRela_JTENT.ManagedDepartmentName = objvcc_ExamPaperStuBatchRela_JTENS.ManagedDepartmentName; //管理的部门名
objvcc_ExamPaperStuBatchRela_JTENT.JobCategoryId = objvcc_ExamPaperStuBatchRela_JTENS.JobCategoryId; //岗位类别Id
objvcc_ExamPaperStuBatchRela_JTENT.JobCategoryName = objvcc_ExamPaperStuBatchRela_JTENS.JobCategoryName; //岗位类别名
objvcc_ExamPaperStuBatchRela_JTENT.SexDesc = objvcc_ExamPaperStuBatchRela_JTENS.SexDesc; //性别名称
objvcc_ExamPaperStuBatchRela_JTENT.id_XzCollege = objvcc_ExamPaperStuBatchRela_JTENS.id_XzCollege; //学院流水号
objvcc_ExamPaperStuBatchRela_JTENT.CollegeName = objvcc_ExamPaperStuBatchRela_JTENS.CollegeName; //学院名称
objvcc_ExamPaperStuBatchRela_JTENT.CollegeNameA = objvcc_ExamPaperStuBatchRela_JTENS.CollegeNameA; //学院名称简写
objvcc_ExamPaperStuBatchRela_JTENT.BatchTime = objvcc_ExamPaperStuBatchRela_JTENS.BatchTime; //批次
objvcc_ExamPaperStuBatchRela_JTENT.id_CurrEduCls = objvcc_ExamPaperStuBatchRela_JTENS.id_CurrEduCls; //当前教学班流水号
objvcc_ExamPaperStuBatchRela_JTENT.CurrEduClsId = objvcc_ExamPaperStuBatchRela_JTENS.CurrEduClsId; //当前教学班Id
objvcc_ExamPaperStuBatchRela_JTENT.EduClsName = objvcc_ExamPaperStuBatchRela_JTENS.EduClsName; //教学班名称
objvcc_ExamPaperStuBatchRela_JTENT.Scores = objvcc_ExamPaperStuBatchRela_JTENS.Scores; //分值
objvcc_ExamPaperStuBatchRela_JTENT.IsSave = objvcc_ExamPaperStuBatchRela_JTENS.IsSave; //是否保存
objvcc_ExamPaperStuBatchRela_JTENT.IsSubmit = objvcc_ExamPaperStuBatchRela_JTENS.IsSubmit; //是否提交
objvcc_ExamPaperStuBatchRela_JTENT.RealFinishDate = objvcc_ExamPaperStuBatchRela_JTENS.RealFinishDate; //实际完成日期
objvcc_ExamPaperStuBatchRela_JTENT.OperateTime = objvcc_ExamPaperStuBatchRela_JTENS.OperateTime; //操作时间
objvcc_ExamPaperStuBatchRela_JTENT.IsMarking = objvcc_ExamPaperStuBatchRela_JTENS.IsMarking; //是否批阅
objvcc_ExamPaperStuBatchRela_JTENT.MarkerId = objvcc_ExamPaperStuBatchRela_JTENS.MarkerId; //打分者
objvcc_ExamPaperStuBatchRela_JTENT.MarkDate = objvcc_ExamPaperStuBatchRela_JTENS.MarkDate; //打分日期
objvcc_ExamPaperStuBatchRela_JTENT.AnswerIP = objvcc_ExamPaperStuBatchRela_JTENS.AnswerIP; //回答IP
objvcc_ExamPaperStuBatchRela_JTENT.AnswerDate = objvcc_ExamPaperStuBatchRela_JTENS.AnswerDate; //回答日期
objvcc_ExamPaperStuBatchRela_JTENT.AnswerTime = objvcc_ExamPaperStuBatchRela_JTENS.AnswerTime; //回答时间
objvcc_ExamPaperStuBatchRela_JTENT.TotalGetScore = objvcc_ExamPaperStuBatchRela_JTENS.TotalGetScore; //考生获取总分
objvcc_ExamPaperStuBatchRela_JTENT.UpdDate = objvcc_ExamPaperStuBatchRela_JTENS.UpdDate; //修改日期
objvcc_ExamPaperStuBatchRela_JTENT.UpdUserId = objvcc_ExamPaperStuBatchRela_JTENS.UpdUserId; //修改用户Id
objvcc_ExamPaperStuBatchRela_JTENT.Memo = objvcc_ExamPaperStuBatchRela_JTENS.Memo; //备注
objvcc_ExamPaperStuBatchRela_JTENT.NoSubmitQuesNum = objvcc_ExamPaperStuBatchRela_JTENS.NoSubmitQuesNum; //未提交题数
objvcc_ExamPaperStuBatchRela_JTENT.SubmitQuesNum = objvcc_ExamPaperStuBatchRela_JTENS.SubmitQuesNum; //提交题数
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
public static DataTable ToDataTable(List<clsvcc_ExamPaperStuBatchRela_JTEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_ExamPaperStuBatchRela_JTEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_ExamPaperStuBatchRela_JTEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_ExamPaperStuBatchRela_JTEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_ExamPaperStuBatchRela_JTEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_ExamPaperStuBatchRela_JTEN.AttributeName)
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
if (clsCurrEduClsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsWApi没有刷新缓存机制(clsCurrEduClsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExamPaperStuBatchRelaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamPaperStuBatchRelaWApi没有刷新缓存机制(clscc_ExamPaperStuBatchRelaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzMajorWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorWApi没有刷新缓存机制(clsXzMajorWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsManagedDepartmentWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsManagedDepartmentWApi没有刷新缓存机制(clsManagedDepartmentWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsJobCategoryWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsJobCategoryWApi没有刷新缓存机制(clsJobCategoryWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudentInfo_JTWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfo_JTWApi没有刷新缓存机制(clsStudentInfo_JTWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterWApi没有刷新缓存机制(clscc_CourseChapterWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsStudyLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelWApi没有刷新缓存机制(clsStudyLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_PaperStuBatch");
//if (arrvcc_ExamPaperStuBatchRela_JTObjLst_Cache == null)
//{
//arrvcc_ExamPaperStuBatchRela_JTObjLst_Cache = await clsvcc_ExamPaperStuBatchRela_JTWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsvcc_ExamPaperStuBatchRela_JTEN._CurrTabName_S, strid_CurrEduCls);
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
public static List<clsvcc_ExamPaperStuBatchRela_JTEN> GetObjLst_Cache(string strid_CurrEduCls)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvcc_ExamPaperStuBatchRela_JTEN._CurrTabName_S, strid_CurrEduCls);
List<clsvcc_ExamPaperStuBatchRela_JTEN> arrvcc_ExamPaperStuBatchRela_JTObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("id_CurrEduCls='{0}'", strid_CurrEduCls)); });
return arrvcc_ExamPaperStuBatchRela_JTObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_ExamPaperStuBatchRela_JTEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.Id_PaperStuBatch, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.CourseExamPaperId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.ExamPaperName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.PaperIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.ExamPaperTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.ExamPaperTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.TotalScore, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.DoneNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.PaperTime, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.PaperDispModeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.ExamCreateTime, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.ChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.SectionId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.SectionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.IsAutoGeneQuestion, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.IsCanMultiDo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.QuestionNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.SiteName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.ManagedDepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.ManagedDepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.JobCategoryId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.JobCategoryName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.SexDesc, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.BatchTime, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.CurrEduClsId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.EduClsName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.Scores, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.IsSave, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.IsSubmit, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.RealFinishDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.OperateTime, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.IsMarking, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.MarkerId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.MarkDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.AnswerIP, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.AnswerDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.AnswerTime, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.TotalGetScore, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.NoSubmitQuesNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela_JT.SubmitQuesNum, Type.GetType("System.Int32"));
foreach (clsvcc_ExamPaperStuBatchRela_JTEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_ExamPaperStuBatchRela_JT.Id_PaperStuBatch] = objInFor[convcc_ExamPaperStuBatchRela_JT.Id_PaperStuBatch];
objDR[convcc_ExamPaperStuBatchRela_JT.CourseExamPaperId] = objInFor[convcc_ExamPaperStuBatchRela_JT.CourseExamPaperId];
objDR[convcc_ExamPaperStuBatchRela_JT.CourseId] = objInFor[convcc_ExamPaperStuBatchRela_JT.CourseId];
objDR[convcc_ExamPaperStuBatchRela_JT.CourseName] = objInFor[convcc_ExamPaperStuBatchRela_JT.CourseName];
objDR[convcc_ExamPaperStuBatchRela_JT.ExamPaperName] = objInFor[convcc_ExamPaperStuBatchRela_JT.ExamPaperName];
objDR[convcc_ExamPaperStuBatchRela_JT.PaperIndex] = objInFor[convcc_ExamPaperStuBatchRela_JT.PaperIndex];
objDR[convcc_ExamPaperStuBatchRela_JT.ExamPaperTypeId] = objInFor[convcc_ExamPaperStuBatchRela_JT.ExamPaperTypeId];
objDR[convcc_ExamPaperStuBatchRela_JT.ExamPaperTypeName] = objInFor[convcc_ExamPaperStuBatchRela_JT.ExamPaperTypeName];
objDR[convcc_ExamPaperStuBatchRela_JT.IsShow] = objInFor[convcc_ExamPaperStuBatchRela_JT.IsShow];
objDR[convcc_ExamPaperStuBatchRela_JT.TotalScore] = objInFor[convcc_ExamPaperStuBatchRela_JT.TotalScore];
objDR[convcc_ExamPaperStuBatchRela_JT.ViewCount] = objInFor[convcc_ExamPaperStuBatchRela_JT.ViewCount];
objDR[convcc_ExamPaperStuBatchRela_JT.DoneNumber] = objInFor[convcc_ExamPaperStuBatchRela_JT.DoneNumber];
objDR[convcc_ExamPaperStuBatchRela_JT.PaperTime] = objInFor[convcc_ExamPaperStuBatchRela_JT.PaperTime];
objDR[convcc_ExamPaperStuBatchRela_JT.PaperDispModeName] = objInFor[convcc_ExamPaperStuBatchRela_JT.PaperDispModeName];
objDR[convcc_ExamPaperStuBatchRela_JT.ExamCreateTime] = objInFor[convcc_ExamPaperStuBatchRela_JT.ExamCreateTime];
objDR[convcc_ExamPaperStuBatchRela_JT.UserName] = objInFor[convcc_ExamPaperStuBatchRela_JT.UserName];
objDR[convcc_ExamPaperStuBatchRela_JT.CourseChapterId] = objInFor[convcc_ExamPaperStuBatchRela_JT.CourseChapterId];
objDR[convcc_ExamPaperStuBatchRela_JT.CourseChapterName] = objInFor[convcc_ExamPaperStuBatchRela_JT.CourseChapterName];
objDR[convcc_ExamPaperStuBatchRela_JT.ChapterId] = objInFor[convcc_ExamPaperStuBatchRela_JT.ChapterId];
objDR[convcc_ExamPaperStuBatchRela_JT.SectionId] = objInFor[convcc_ExamPaperStuBatchRela_JT.SectionId];
objDR[convcc_ExamPaperStuBatchRela_JT.ChapterName] = objInFor[convcc_ExamPaperStuBatchRela_JT.ChapterName];
objDR[convcc_ExamPaperStuBatchRela_JT.SectionName] = objInFor[convcc_ExamPaperStuBatchRela_JT.SectionName];
objDR[convcc_ExamPaperStuBatchRela_JT.ChapterName_Sim] = objInFor[convcc_ExamPaperStuBatchRela_JT.ChapterName_Sim];
objDR[convcc_ExamPaperStuBatchRela_JT.SectionName_Sim] = objInFor[convcc_ExamPaperStuBatchRela_JT.SectionName_Sim];
objDR[convcc_ExamPaperStuBatchRela_JT.IsAutoGeneQuestion] = objInFor[convcc_ExamPaperStuBatchRela_JT.IsAutoGeneQuestion];
objDR[convcc_ExamPaperStuBatchRela_JT.IsCanMultiDo] = objInFor[convcc_ExamPaperStuBatchRela_JT.IsCanMultiDo];
objDR[convcc_ExamPaperStuBatchRela_JT.QuestionNum] = objInFor[convcc_ExamPaperStuBatchRela_JT.QuestionNum];
objDR[convcc_ExamPaperStuBatchRela_JT.id_StudentInfo] = objInFor[convcc_ExamPaperStuBatchRela_JT.id_StudentInfo];
objDR[convcc_ExamPaperStuBatchRela_JT.SiteName] = objInFor[convcc_ExamPaperStuBatchRela_JT.SiteName];
objDR[convcc_ExamPaperStuBatchRela_JT.StuID] = objInFor[convcc_ExamPaperStuBatchRela_JT.StuID];
objDR[convcc_ExamPaperStuBatchRela_JT.StuName] = objInFor[convcc_ExamPaperStuBatchRela_JT.StuName];
objDR[convcc_ExamPaperStuBatchRela_JT.ManagedDepartmentId] = objInFor[convcc_ExamPaperStuBatchRela_JT.ManagedDepartmentId];
objDR[convcc_ExamPaperStuBatchRela_JT.ManagedDepartmentName] = objInFor[convcc_ExamPaperStuBatchRela_JT.ManagedDepartmentName];
objDR[convcc_ExamPaperStuBatchRela_JT.JobCategoryId] = objInFor[convcc_ExamPaperStuBatchRela_JT.JobCategoryId];
objDR[convcc_ExamPaperStuBatchRela_JT.JobCategoryName] = objInFor[convcc_ExamPaperStuBatchRela_JT.JobCategoryName];
objDR[convcc_ExamPaperStuBatchRela_JT.SexDesc] = objInFor[convcc_ExamPaperStuBatchRela_JT.SexDesc];
objDR[convcc_ExamPaperStuBatchRela_JT.id_XzCollege] = objInFor[convcc_ExamPaperStuBatchRela_JT.id_XzCollege];
objDR[convcc_ExamPaperStuBatchRela_JT.CollegeName] = objInFor[convcc_ExamPaperStuBatchRela_JT.CollegeName];
objDR[convcc_ExamPaperStuBatchRela_JT.CollegeNameA] = objInFor[convcc_ExamPaperStuBatchRela_JT.CollegeNameA];
objDR[convcc_ExamPaperStuBatchRela_JT.BatchTime] = objInFor[convcc_ExamPaperStuBatchRela_JT.BatchTime];
objDR[convcc_ExamPaperStuBatchRela_JT.id_CurrEduCls] = objInFor[convcc_ExamPaperStuBatchRela_JT.id_CurrEduCls];
objDR[convcc_ExamPaperStuBatchRela_JT.CurrEduClsId] = objInFor[convcc_ExamPaperStuBatchRela_JT.CurrEduClsId];
objDR[convcc_ExamPaperStuBatchRela_JT.EduClsName] = objInFor[convcc_ExamPaperStuBatchRela_JT.EduClsName];
objDR[convcc_ExamPaperStuBatchRela_JT.Scores] = objInFor[convcc_ExamPaperStuBatchRela_JT.Scores];
objDR[convcc_ExamPaperStuBatchRela_JT.IsSave] = objInFor[convcc_ExamPaperStuBatchRela_JT.IsSave];
objDR[convcc_ExamPaperStuBatchRela_JT.IsSubmit] = objInFor[convcc_ExamPaperStuBatchRela_JT.IsSubmit];
objDR[convcc_ExamPaperStuBatchRela_JT.RealFinishDate] = objInFor[convcc_ExamPaperStuBatchRela_JT.RealFinishDate];
objDR[convcc_ExamPaperStuBatchRela_JT.OperateTime] = objInFor[convcc_ExamPaperStuBatchRela_JT.OperateTime];
objDR[convcc_ExamPaperStuBatchRela_JT.IsMarking] = objInFor[convcc_ExamPaperStuBatchRela_JT.IsMarking];
objDR[convcc_ExamPaperStuBatchRela_JT.MarkerId] = objInFor[convcc_ExamPaperStuBatchRela_JT.MarkerId];
objDR[convcc_ExamPaperStuBatchRela_JT.MarkDate] = objInFor[convcc_ExamPaperStuBatchRela_JT.MarkDate];
objDR[convcc_ExamPaperStuBatchRela_JT.AnswerIP] = objInFor[convcc_ExamPaperStuBatchRela_JT.AnswerIP];
objDR[convcc_ExamPaperStuBatchRela_JT.AnswerDate] = objInFor[convcc_ExamPaperStuBatchRela_JT.AnswerDate];
objDR[convcc_ExamPaperStuBatchRela_JT.AnswerTime] = objInFor[convcc_ExamPaperStuBatchRela_JT.AnswerTime];
objDR[convcc_ExamPaperStuBatchRela_JT.TotalGetScore] = objInFor[convcc_ExamPaperStuBatchRela_JT.TotalGetScore];
objDR[convcc_ExamPaperStuBatchRela_JT.UpdDate] = objInFor[convcc_ExamPaperStuBatchRela_JT.UpdDate];
objDR[convcc_ExamPaperStuBatchRela_JT.UpdUserId] = objInFor[convcc_ExamPaperStuBatchRela_JT.UpdUserId];
objDR[convcc_ExamPaperStuBatchRela_JT.Memo] = objInFor[convcc_ExamPaperStuBatchRela_JT.Memo];
objDR[convcc_ExamPaperStuBatchRela_JT.NoSubmitQuesNum] = objInFor[convcc_ExamPaperStuBatchRela_JT.NoSubmitQuesNum];
objDR[convcc_ExamPaperStuBatchRela_JT.SubmitQuesNum] = objInFor[convcc_ExamPaperStuBatchRela_JT.SubmitQuesNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}