
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_ExamPaperQuestionTypeRelaWApi
 表名:vcc_ExamPaperQuestionTypeRela(01120238)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:50:20
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
public static class clsvcc_ExamPaperQuestionTypeRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetId_ExamPaperQuestionTypeRela(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, long lngId_ExamPaperQuestionTypeRela, string strComparisonOp="")
	{
objvcc_ExamPaperQuestionTypeRelaEN.Id_ExamPaperQuestionTypeRela = lngId_ExamPaperQuestionTypeRela; //Id_ExamPaperQuestionTypeRela
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.Id_ExamPaperQuestionTypeRela) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.Id_ExamPaperQuestionTypeRela, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.Id_ExamPaperQuestionTypeRela] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetCourseExamPaperId(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, convcc_ExamPaperQuestionTypeRela.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, convcc_ExamPaperQuestionTypeRela.CourseExamPaperId);
objvcc_ExamPaperQuestionTypeRelaEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.CourseExamPaperId) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.CourseExamPaperId, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.CourseExamPaperId] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetCourseId(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_ExamPaperQuestionTypeRela.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_ExamPaperQuestionTypeRela.CourseId);
objvcc_ExamPaperQuestionTypeRelaEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.CourseId) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.CourseId, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.CourseId] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetCourseName(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_ExamPaperQuestionTypeRela.CourseName);
objvcc_ExamPaperQuestionTypeRelaEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.CourseName) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.CourseName, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.CourseName] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetExamPaperName(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, string strExamPaperName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamPaperName, 500, convcc_ExamPaperQuestionTypeRela.ExamPaperName);
objvcc_ExamPaperQuestionTypeRelaEN.ExamPaperName = strExamPaperName; //考卷名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.ExamPaperName) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.ExamPaperName, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.ExamPaperName] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetExamPaperTypeId(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, string strExamPaperTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strExamPaperTypeId, convcc_ExamPaperQuestionTypeRela.ExamPaperTypeId);
clsCheckSql.CheckFieldLen(strExamPaperTypeId, 2, convcc_ExamPaperQuestionTypeRela.ExamPaperTypeId);
clsCheckSql.CheckFieldForeignKey(strExamPaperTypeId, 2, convcc_ExamPaperQuestionTypeRela.ExamPaperTypeId);
objvcc_ExamPaperQuestionTypeRelaEN.ExamPaperTypeId = strExamPaperTypeId; //试卷类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.ExamPaperTypeId) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.ExamPaperTypeId, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.ExamPaperTypeId] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetExamPaperTypeName(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, string strExamPaperTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strExamPaperTypeName, convcc_ExamPaperQuestionTypeRela.ExamPaperTypeName);
clsCheckSql.CheckFieldLen(strExamPaperTypeName, 30, convcc_ExamPaperQuestionTypeRela.ExamPaperTypeName);
objvcc_ExamPaperQuestionTypeRelaEN.ExamPaperTypeName = strExamPaperTypeName; //试卷类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.ExamPaperTypeName) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.ExamPaperTypeName, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.ExamPaperTypeName] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetIsShow(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, bool bolIsShow, string strComparisonOp="")
	{
objvcc_ExamPaperQuestionTypeRelaEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.IsShow) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.IsShow, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.IsShow] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetTotalScore(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, double dblTotalScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dblTotalScore, convcc_ExamPaperQuestionTypeRela.TotalScore);
objvcc_ExamPaperQuestionTypeRelaEN.TotalScore = dblTotalScore; //总得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.TotalScore) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.TotalScore, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.TotalScore] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetViewCount(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, int intViewCount, string strComparisonOp="")
	{
objvcc_ExamPaperQuestionTypeRelaEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.ViewCount) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.ViewCount, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.ViewCount] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetDoneNumber(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, int intDoneNumber, string strComparisonOp="")
	{
objvcc_ExamPaperQuestionTypeRelaEN.DoneNumber = intDoneNumber; //已做人数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.DoneNumber) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.DoneNumber, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.DoneNumber] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetPaperTime(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, int intPaperTime, string strComparisonOp="")
	{
objvcc_ExamPaperQuestionTypeRelaEN.PaperTime = intPaperTime; //考试时间（分钟）
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.PaperTime) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.PaperTime, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.PaperTime] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetPaperDispModeName(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, string strPaperDispModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperDispModeName, 30, convcc_ExamPaperQuestionTypeRela.PaperDispModeName);
objvcc_ExamPaperQuestionTypeRelaEN.PaperDispModeName = strPaperDispModeName; //试卷显示模式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.PaperDispModeName) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.PaperDispModeName, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.PaperDispModeName] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetExamCreateTime(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, string strExamCreateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamCreateTime, 14, convcc_ExamPaperQuestionTypeRela.ExamCreateTime);
objvcc_ExamPaperQuestionTypeRelaEN.ExamCreateTime = strExamCreateTime; //考卷建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.ExamCreateTime) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.ExamCreateTime, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.ExamCreateTime] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetUserName(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convcc_ExamPaperQuestionTypeRela.UserName);
objvcc_ExamPaperQuestionTypeRelaEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.UserName) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.UserName, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.UserName] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetCourseChapterId(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, convcc_ExamPaperQuestionTypeRela.CourseChapterId);
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_ExamPaperQuestionTypeRela.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_ExamPaperQuestionTypeRela.CourseChapterId);
objvcc_ExamPaperQuestionTypeRelaEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.CourseChapterId) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.CourseChapterId, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.CourseChapterId] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetSectionId(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, string strSectionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionId, 8, convcc_ExamPaperQuestionTypeRela.SectionId);
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convcc_ExamPaperQuestionTypeRela.SectionId);
objvcc_ExamPaperQuestionTypeRelaEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.SectionId) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.SectionId, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.SectionId] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetChapterName(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_ExamPaperQuestionTypeRela.ChapterName);
objvcc_ExamPaperQuestionTypeRelaEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.ChapterName) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.ChapterName, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.ChapterName] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetSectionName(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, string strSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_ExamPaperQuestionTypeRela.SectionName);
objvcc_ExamPaperQuestionTypeRelaEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.SectionName) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.SectionName, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.SectionName] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetChapterName_Sim(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convcc_ExamPaperQuestionTypeRela.ChapterName_Sim);
objvcc_ExamPaperQuestionTypeRelaEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.ChapterName_Sim) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.ChapterName_Sim, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.ChapterName_Sim] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetSectionName_Sim(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, convcc_ExamPaperQuestionTypeRela.SectionName_Sim);
objvcc_ExamPaperQuestionTypeRelaEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.SectionName_Sim) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.SectionName_Sim, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.SectionName_Sim] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetQuestionNum(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, int intQuestionNum, string strComparisonOp="")
	{
objvcc_ExamPaperQuestionTypeRelaEN.QuestionNum = intQuestionNum; //题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.QuestionNum) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.QuestionNum, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.QuestionNum] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetScores(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, double dblScores, string strComparisonOp="")
	{
objvcc_ExamPaperQuestionTypeRelaEN.Scores = dblScores; //分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.Scores) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.Scores, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.Scores] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetQuestionTypeId(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convcc_ExamPaperQuestionTypeRela.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convcc_ExamPaperQuestionTypeRela.QuestionTypeId);
objvcc_ExamPaperQuestionTypeRelaEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.QuestionTypeId) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.QuestionTypeId, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.QuestionTypeId] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetQuestionTypeName(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, string strQuestionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convcc_ExamPaperQuestionTypeRela.QuestionTypeName);
objvcc_ExamPaperQuestionTypeRelaEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.QuestionTypeName) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.QuestionTypeName, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.QuestionTypeName] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetQuestionTypeENName(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, string strQuestionTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeENName, 50, convcc_ExamPaperQuestionTypeRela.QuestionTypeENName);
objvcc_ExamPaperQuestionTypeRelaEN.QuestionTypeENName = strQuestionTypeENName; //题目类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.QuestionTypeENName) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.QuestionTypeENName, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.QuestionTypeENName] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetDefaAnswerModeId(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, string strDefaAnswerModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaAnswerModeId, 4, convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId);
clsCheckSql.CheckFieldForeignKey(strDefaAnswerModeId, 4, convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId);
objvcc_ExamPaperQuestionTypeRelaEN.DefaAnswerModeId = strDefaAnswerModeId; //默认答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetDefaAnswerTypeId(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, string strDefaAnswerTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaAnswerTypeId, 2, convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId);
clsCheckSql.CheckFieldForeignKey(strDefaAnswerTypeId, 2, convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId);
objvcc_ExamPaperQuestionTypeRelaEN.DefaAnswerTypeId = strDefaAnswerTypeId; //默认答案类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetIsUse(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, bool bolIsUse, string strComparisonOp="")
	{
objvcc_ExamPaperQuestionTypeRelaEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.IsUse) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.IsUse, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.IsUse] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetChapterId(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, string strChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterId, 8, convcc_ExamPaperQuestionTypeRela.ChapterId);
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convcc_ExamPaperQuestionTypeRela.ChapterId);
objvcc_ExamPaperQuestionTypeRelaEN.ChapterId = strChapterId; //章Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.ChapterId) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.ChapterId, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.ChapterId] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetNeedQuestionNum(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, int intNeedQuestionNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intNeedQuestionNum, convcc_ExamPaperQuestionTypeRela.NeedQuestionNum);
objvcc_ExamPaperQuestionTypeRelaEN.NeedQuestionNum = intNeedQuestionNum; //需要题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.NeedQuestionNum) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.NeedQuestionNum, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.NeedQuestionNum] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetPerScore(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, double dblPerScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dblPerScore, convcc_ExamPaperQuestionTypeRela.PerScore);
objvcc_ExamPaperQuestionTypeRelaEN.PerScore = dblPerScore; //每题分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.PerScore) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.PerScore, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.PerScore] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetOrderNum(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, int intOrderNum, string strComparisonOp="")
	{
objvcc_ExamPaperQuestionTypeRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.OrderNum) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.OrderNum, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.OrderNum] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetUpdDate(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_ExamPaperQuestionTypeRela.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_ExamPaperQuestionTypeRela.UpdDate);
objvcc_ExamPaperQuestionTypeRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.UpdDate) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.UpdDate, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.UpdDate] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetUpdUserId(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_ExamPaperQuestionTypeRela.UpdUserId);
objvcc_ExamPaperQuestionTypeRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.UpdUserId) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.UpdUserId, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.UpdUserId] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetMemo(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_ExamPaperQuestionTypeRela.Memo);
objvcc_ExamPaperQuestionTypeRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.Memo) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.Memo, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.Memo] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetChapterId4QT(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, string strChapterId4QT, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterId4QT, 8, convcc_ExamPaperQuestionTypeRela.ChapterId4QT);
clsCheckSql.CheckFieldForeignKey(strChapterId4QT, 8, convcc_ExamPaperQuestionTypeRela.ChapterId4QT);
objvcc_ExamPaperQuestionTypeRelaEN.ChapterId4QT = strChapterId4QT; //ChapterId4QT
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.ChapterId4QT) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.ChapterId4QT, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.ChapterId4QT] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetChapterName_Sim4QT(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, string strChapterName_Sim4QT, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim4QT, 10, convcc_ExamPaperQuestionTypeRela.ChapterName_Sim4QT);
objvcc_ExamPaperQuestionTypeRelaEN.ChapterName_Sim4QT = strChapterName_Sim4QT; //ChapterName_Sim4QT
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.ChapterName_Sim4QT) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.ChapterName_Sim4QT, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.ChapterName_Sim4QT] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN SetChapterName4QT(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN, string strChapterName4QT, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName4QT, 100, convcc_ExamPaperQuestionTypeRela.ChapterName4QT);
objvcc_ExamPaperQuestionTypeRelaEN.ChapterName4QT = strChapterName4QT; //ChapterName4QT
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperQuestionTypeRela.ChapterName4QT) == false)
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperQuestionTypeRela.ChapterName4QT, strComparisonOp);
}
else
{
objvcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.ChapterName4QT] = strComparisonOp;
}
}
return objvcc_ExamPaperQuestionTypeRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRela_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.Id_ExamPaperQuestionTypeRela) == true)
{
string strComparisonOp_Id_ExamPaperQuestionTypeRela = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.Id_ExamPaperQuestionTypeRela];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperQuestionTypeRela.Id_ExamPaperQuestionTypeRela, objvcc_ExamPaperQuestionTypeRela_Cond.Id_ExamPaperQuestionTypeRela, strComparisonOp_Id_ExamPaperQuestionTypeRela);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.CourseExamPaperId) == true)
{
string strComparisonOp_CourseExamPaperId = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperQuestionTypeRela.CourseExamPaperId, objvcc_ExamPaperQuestionTypeRela_Cond.CourseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperQuestionTypeRela.CourseId, objvcc_ExamPaperQuestionTypeRela_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperQuestionTypeRela.CourseName, objvcc_ExamPaperQuestionTypeRela_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.ExamPaperName) == true)
{
string strComparisonOp_ExamPaperName = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.ExamPaperName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperQuestionTypeRela.ExamPaperName, objvcc_ExamPaperQuestionTypeRela_Cond.ExamPaperName, strComparisonOp_ExamPaperName);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.ExamPaperTypeId) == true)
{
string strComparisonOp_ExamPaperTypeId = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.ExamPaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperQuestionTypeRela.ExamPaperTypeId, objvcc_ExamPaperQuestionTypeRela_Cond.ExamPaperTypeId, strComparisonOp_ExamPaperTypeId);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.ExamPaperTypeName) == true)
{
string strComparisonOp_ExamPaperTypeName = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.ExamPaperTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperQuestionTypeRela.ExamPaperTypeName, objvcc_ExamPaperQuestionTypeRela_Cond.ExamPaperTypeName, strComparisonOp_ExamPaperTypeName);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.IsShow) == true)
{
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperQuestionTypeRela.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperQuestionTypeRela.IsShow);
}
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.TotalScore) == true)
{
string strComparisonOp_TotalScore = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.TotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperQuestionTypeRela.TotalScore, objvcc_ExamPaperQuestionTypeRela_Cond.TotalScore, strComparisonOp_TotalScore);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperQuestionTypeRela.ViewCount, objvcc_ExamPaperQuestionTypeRela_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.DoneNumber) == true)
{
string strComparisonOp_DoneNumber = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.DoneNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperQuestionTypeRela.DoneNumber, objvcc_ExamPaperQuestionTypeRela_Cond.DoneNumber, strComparisonOp_DoneNumber);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.PaperTime) == true)
{
string strComparisonOp_PaperTime = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.PaperTime];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperQuestionTypeRela.PaperTime, objvcc_ExamPaperQuestionTypeRela_Cond.PaperTime, strComparisonOp_PaperTime);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.PaperDispModeName) == true)
{
string strComparisonOp_PaperDispModeName = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.PaperDispModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperQuestionTypeRela.PaperDispModeName, objvcc_ExamPaperQuestionTypeRela_Cond.PaperDispModeName, strComparisonOp_PaperDispModeName);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.ExamCreateTime) == true)
{
string strComparisonOp_ExamCreateTime = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.ExamCreateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperQuestionTypeRela.ExamCreateTime, objvcc_ExamPaperQuestionTypeRela_Cond.ExamCreateTime, strComparisonOp_ExamCreateTime);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.UserName) == true)
{
string strComparisonOp_UserName = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperQuestionTypeRela.UserName, objvcc_ExamPaperQuestionTypeRela_Cond.UserName, strComparisonOp_UserName);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperQuestionTypeRela.CourseChapterId, objvcc_ExamPaperQuestionTypeRela_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.SectionId) == true)
{
string strComparisonOp_SectionId = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperQuestionTypeRela.SectionId, objvcc_ExamPaperQuestionTypeRela_Cond.SectionId, strComparisonOp_SectionId);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperQuestionTypeRela.ChapterName, objvcc_ExamPaperQuestionTypeRela_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.SectionName) == true)
{
string strComparisonOp_SectionName = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperQuestionTypeRela.SectionName, objvcc_ExamPaperQuestionTypeRela_Cond.SectionName, strComparisonOp_SectionName);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperQuestionTypeRela.ChapterName_Sim, objvcc_ExamPaperQuestionTypeRela_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperQuestionTypeRela.SectionName_Sim, objvcc_ExamPaperQuestionTypeRela_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.QuestionNum) == true)
{
string strComparisonOp_QuestionNum = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.QuestionNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperQuestionTypeRela.QuestionNum, objvcc_ExamPaperQuestionTypeRela_Cond.QuestionNum, strComparisonOp_QuestionNum);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.Scores) == true)
{
string strComparisonOp_Scores = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.Scores];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperQuestionTypeRela.Scores, objvcc_ExamPaperQuestionTypeRela_Cond.Scores, strComparisonOp_Scores);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperQuestionTypeRela.QuestionTypeId, objvcc_ExamPaperQuestionTypeRela_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.QuestionTypeName) == true)
{
string strComparisonOp_QuestionTypeName = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperQuestionTypeRela.QuestionTypeName, objvcc_ExamPaperQuestionTypeRela_Cond.QuestionTypeName, strComparisonOp_QuestionTypeName);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.QuestionTypeENName) == true)
{
string strComparisonOp_QuestionTypeENName = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.QuestionTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperQuestionTypeRela.QuestionTypeENName, objvcc_ExamPaperQuestionTypeRela_Cond.QuestionTypeENName, strComparisonOp_QuestionTypeENName);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId) == true)
{
string strComparisonOp_DefaAnswerModeId = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId, objvcc_ExamPaperQuestionTypeRela_Cond.DefaAnswerModeId, strComparisonOp_DefaAnswerModeId);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId) == true)
{
string strComparisonOp_DefaAnswerTypeId = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId, objvcc_ExamPaperQuestionTypeRela_Cond.DefaAnswerTypeId, strComparisonOp_DefaAnswerTypeId);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.IsUse) == true)
{
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperQuestionTypeRela.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperQuestionTypeRela.IsUse);
}
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.ChapterId) == true)
{
string strComparisonOp_ChapterId = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperQuestionTypeRela.ChapterId, objvcc_ExamPaperQuestionTypeRela_Cond.ChapterId, strComparisonOp_ChapterId);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.NeedQuestionNum) == true)
{
string strComparisonOp_NeedQuestionNum = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.NeedQuestionNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperQuestionTypeRela.NeedQuestionNum, objvcc_ExamPaperQuestionTypeRela_Cond.NeedQuestionNum, strComparisonOp_NeedQuestionNum);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.PerScore) == true)
{
string strComparisonOp_PerScore = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.PerScore];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperQuestionTypeRela.PerScore, objvcc_ExamPaperQuestionTypeRela_Cond.PerScore, strComparisonOp_PerScore);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperQuestionTypeRela.OrderNum, objvcc_ExamPaperQuestionTypeRela_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperQuestionTypeRela.UpdDate, objvcc_ExamPaperQuestionTypeRela_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperQuestionTypeRela.UpdUserId, objvcc_ExamPaperQuestionTypeRela_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.Memo) == true)
{
string strComparisonOp_Memo = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperQuestionTypeRela.Memo, objvcc_ExamPaperQuestionTypeRela_Cond.Memo, strComparisonOp_Memo);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.ChapterId4QT) == true)
{
string strComparisonOp_ChapterId4QT = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.ChapterId4QT];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperQuestionTypeRela.ChapterId4QT, objvcc_ExamPaperQuestionTypeRela_Cond.ChapterId4QT, strComparisonOp_ChapterId4QT);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.ChapterName_Sim4QT) == true)
{
string strComparisonOp_ChapterName_Sim4QT = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.ChapterName_Sim4QT];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperQuestionTypeRela.ChapterName_Sim4QT, objvcc_ExamPaperQuestionTypeRela_Cond.ChapterName_Sim4QT, strComparisonOp_ChapterName_Sim4QT);
}
if (objvcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(convcc_ExamPaperQuestionTypeRela.ChapterName4QT) == true)
{
string strComparisonOp_ChapterName4QT = objvcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[convcc_ExamPaperQuestionTypeRela.ChapterName4QT];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperQuestionTypeRela.ChapterName4QT, objvcc_ExamPaperQuestionTypeRela_Cond.ChapterName4QT, strComparisonOp_ChapterName4QT);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v考卷题型关系(vcc_ExamPaperQuestionTypeRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_ExamPaperQuestionTypeRelaWApi
{
private static readonly string mstrApiControllerName = "vcc_ExamPaperQuestionTypeRelaApi";

 public clsvcc_ExamPaperQuestionTypeRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_ExamPaperQuestionTypeRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN GetObjById_ExamPaperQuestionTypeRela(long lngId_ExamPaperQuestionTypeRela)
{
string strAction = "GetObjById_ExamPaperQuestionTypeRela";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_ExamPaperQuestionTypeRela"] = lngId_ExamPaperQuestionTypeRela.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_ExamPaperQuestionTypeRelaEN = JsonConvert.DeserializeObject<clsvcc_ExamPaperQuestionTypeRelaEN>((string)jobjReturn["ReturnObj"]);
return objvcc_ExamPaperQuestionTypeRelaEN;
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
 /// <param name = "lngId_ExamPaperQuestionTypeRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN GetObjById_ExamPaperQuestionTypeRela_WA_Cache(long lngId_ExamPaperQuestionTypeRela, string strCourseId)
{
string strAction = "GetObjById_ExamPaperQuestionTypeRela_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_ExamPaperQuestionTypeRela"] = lngId_ExamPaperQuestionTypeRela.ToString(),
["CourseId"] = strCourseId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_ExamPaperQuestionTypeRelaEN = JsonConvert.DeserializeObject<clsvcc_ExamPaperQuestionTypeRelaEN>((string)jobjReturn["ReturnObj"]);
return objvcc_ExamPaperQuestionTypeRelaEN;
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
public static clsvcc_ExamPaperQuestionTypeRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN = null;
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
objvcc_ExamPaperQuestionTypeRelaEN = JsonConvert.DeserializeObject<clsvcc_ExamPaperQuestionTypeRelaEN>((string)jobjReturn["ReturnObj"]);
return objvcc_ExamPaperQuestionTypeRelaEN;
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
 /// <param name = "lngId_ExamPaperQuestionTypeRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_ExamPaperQuestionTypeRelaEN GetObjById_ExamPaperQuestionTypeRela_Cache(long lngId_ExamPaperQuestionTypeRela, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_ExamPaperQuestionTypeRelaEN._CurrTabName_S, strCourseId);
List<clsvcc_ExamPaperQuestionTypeRelaEN> arrvcc_ExamPaperQuestionTypeRelaObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvcc_ExamPaperQuestionTypeRelaEN> arrvcc_ExamPaperQuestionTypeRelaObjLst_Sel =
from objvcc_ExamPaperQuestionTypeRelaEN in arrvcc_ExamPaperQuestionTypeRelaObjLst_Cache
where objvcc_ExamPaperQuestionTypeRelaEN.Id_ExamPaperQuestionTypeRela == lngId_ExamPaperQuestionTypeRela
select objvcc_ExamPaperQuestionTypeRelaEN;
if (arrvcc_ExamPaperQuestionTypeRelaObjLst_Sel.Count() == 0)
{
   clsvcc_ExamPaperQuestionTypeRelaEN obj = clsvcc_ExamPaperQuestionTypeRelaWApi.GetObjById_ExamPaperQuestionTypeRela(lngId_ExamPaperQuestionTypeRela);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_ExamPaperQuestionTypeRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_ExamPaperQuestionTypeRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_ExamPaperQuestionTypeRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperQuestionTypeRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperQuestionTypeRelaEN> GetObjLstById_ExamPaperQuestionTypeRelaLst(List<long> arrId_ExamPaperQuestionTypeRela)
{
 List<clsvcc_ExamPaperQuestionTypeRelaEN> arrObjLst = null; 
string strAction = "GetObjLstById_ExamPaperQuestionTypeRelaLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_ExamPaperQuestionTypeRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperQuestionTypeRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngId_ExamPaperQuestionTypeRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvcc_ExamPaperQuestionTypeRelaEN> GetObjLstById_ExamPaperQuestionTypeRelaLst_Cache(List<long> arrId_ExamPaperQuestionTypeRela, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_ExamPaperQuestionTypeRelaEN._CurrTabName_S, strCourseId);
List<clsvcc_ExamPaperQuestionTypeRelaEN> arrvcc_ExamPaperQuestionTypeRelaObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvcc_ExamPaperQuestionTypeRelaEN> arrvcc_ExamPaperQuestionTypeRelaObjLst_Sel =
from objvcc_ExamPaperQuestionTypeRelaEN in arrvcc_ExamPaperQuestionTypeRelaObjLst_Cache
where arrId_ExamPaperQuestionTypeRela.Contains(objvcc_ExamPaperQuestionTypeRelaEN.Id_ExamPaperQuestionTypeRela)
select objvcc_ExamPaperQuestionTypeRelaEN;
return arrvcc_ExamPaperQuestionTypeRelaObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_ExamPaperQuestionTypeRelaEN> GetObjLstById_ExamPaperQuestionTypeRelaLst_WA_Cache(List<long> arrId_ExamPaperQuestionTypeRela, string strCourseId)
{
 List<clsvcc_ExamPaperQuestionTypeRelaEN> arrObjLst = null; 
string strAction = "GetObjLstById_ExamPaperQuestionTypeRelaLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_ExamPaperQuestionTypeRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperQuestionTypeRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperQuestionTypeRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_ExamPaperQuestionTypeRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperQuestionTypeRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperQuestionTypeRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_ExamPaperQuestionTypeRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperQuestionTypeRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperQuestionTypeRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_ExamPaperQuestionTypeRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperQuestionTypeRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperQuestionTypeRelaEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_ExamPaperQuestionTypeRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperQuestionTypeRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngId_ExamPaperQuestionTypeRela)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_ExamPaperQuestionTypeRela"] = lngId_ExamPaperQuestionTypeRela.ToString()
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
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaENS">源对象</param>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaENT">目标对象</param>
 public static void CopyTo(clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaENS, clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaENT)
{
try
{
objvcc_ExamPaperQuestionTypeRelaENT.Id_ExamPaperQuestionTypeRela = objvcc_ExamPaperQuestionTypeRelaENS.Id_ExamPaperQuestionTypeRela; //Id_ExamPaperQuestionTypeRela
objvcc_ExamPaperQuestionTypeRelaENT.CourseExamPaperId = objvcc_ExamPaperQuestionTypeRelaENS.CourseExamPaperId; //考卷流水号
objvcc_ExamPaperQuestionTypeRelaENT.CourseId = objvcc_ExamPaperQuestionTypeRelaENS.CourseId; //课程Id
objvcc_ExamPaperQuestionTypeRelaENT.CourseName = objvcc_ExamPaperQuestionTypeRelaENS.CourseName; //课程名称
objvcc_ExamPaperQuestionTypeRelaENT.ExamPaperName = objvcc_ExamPaperQuestionTypeRelaENS.ExamPaperName; //考卷名称
objvcc_ExamPaperQuestionTypeRelaENT.ExamPaperTypeId = objvcc_ExamPaperQuestionTypeRelaENS.ExamPaperTypeId; //试卷类型Id
objvcc_ExamPaperQuestionTypeRelaENT.ExamPaperTypeName = objvcc_ExamPaperQuestionTypeRelaENS.ExamPaperTypeName; //试卷类型名称
objvcc_ExamPaperQuestionTypeRelaENT.IsShow = objvcc_ExamPaperQuestionTypeRelaENS.IsShow; //是否启用
objvcc_ExamPaperQuestionTypeRelaENT.TotalScore = objvcc_ExamPaperQuestionTypeRelaENS.TotalScore; //总得分
objvcc_ExamPaperQuestionTypeRelaENT.ViewCount = objvcc_ExamPaperQuestionTypeRelaENS.ViewCount; //浏览量
objvcc_ExamPaperQuestionTypeRelaENT.DoneNumber = objvcc_ExamPaperQuestionTypeRelaENS.DoneNumber; //已做人数
objvcc_ExamPaperQuestionTypeRelaENT.PaperTime = objvcc_ExamPaperQuestionTypeRelaENS.PaperTime; //考试时间（分钟）
objvcc_ExamPaperQuestionTypeRelaENT.PaperDispModeName = objvcc_ExamPaperQuestionTypeRelaENS.PaperDispModeName; //试卷显示模式名称
objvcc_ExamPaperQuestionTypeRelaENT.ExamCreateTime = objvcc_ExamPaperQuestionTypeRelaENS.ExamCreateTime; //考卷建立时间
objvcc_ExamPaperQuestionTypeRelaENT.UserName = objvcc_ExamPaperQuestionTypeRelaENS.UserName; //用户名
objvcc_ExamPaperQuestionTypeRelaENT.CourseChapterId = objvcc_ExamPaperQuestionTypeRelaENS.CourseChapterId; //课程章节ID
objvcc_ExamPaperQuestionTypeRelaENT.SectionId = objvcc_ExamPaperQuestionTypeRelaENS.SectionId; //节Id
objvcc_ExamPaperQuestionTypeRelaENT.ChapterName = objvcc_ExamPaperQuestionTypeRelaENS.ChapterName; //章名
objvcc_ExamPaperQuestionTypeRelaENT.SectionName = objvcc_ExamPaperQuestionTypeRelaENS.SectionName; //节名
objvcc_ExamPaperQuestionTypeRelaENT.ChapterName_Sim = objvcc_ExamPaperQuestionTypeRelaENS.ChapterName_Sim; //章名简称
objvcc_ExamPaperQuestionTypeRelaENT.SectionName_Sim = objvcc_ExamPaperQuestionTypeRelaENS.SectionName_Sim; //节名简称
objvcc_ExamPaperQuestionTypeRelaENT.QuestionNum = objvcc_ExamPaperQuestionTypeRelaENS.QuestionNum; //题目数
objvcc_ExamPaperQuestionTypeRelaENT.Scores = objvcc_ExamPaperQuestionTypeRelaENS.Scores; //分值
objvcc_ExamPaperQuestionTypeRelaENT.QuestionTypeId = objvcc_ExamPaperQuestionTypeRelaENS.QuestionTypeId; //题目类型Id
objvcc_ExamPaperQuestionTypeRelaENT.QuestionTypeName = objvcc_ExamPaperQuestionTypeRelaENS.QuestionTypeName; //题目类型名
objvcc_ExamPaperQuestionTypeRelaENT.QuestionTypeENName = objvcc_ExamPaperQuestionTypeRelaENS.QuestionTypeENName; //题目类型英文名
objvcc_ExamPaperQuestionTypeRelaENT.DefaAnswerModeId = objvcc_ExamPaperQuestionTypeRelaENS.DefaAnswerModeId; //默认答案模式Id
objvcc_ExamPaperQuestionTypeRelaENT.DefaAnswerTypeId = objvcc_ExamPaperQuestionTypeRelaENS.DefaAnswerTypeId; //默认答案类型Id
objvcc_ExamPaperQuestionTypeRelaENT.IsUse = objvcc_ExamPaperQuestionTypeRelaENS.IsUse; //是否使用
objvcc_ExamPaperQuestionTypeRelaENT.ChapterId = objvcc_ExamPaperQuestionTypeRelaENS.ChapterId; //章Id
objvcc_ExamPaperQuestionTypeRelaENT.NeedQuestionNum = objvcc_ExamPaperQuestionTypeRelaENS.NeedQuestionNum; //需要题目数
objvcc_ExamPaperQuestionTypeRelaENT.PerScore = objvcc_ExamPaperQuestionTypeRelaENS.PerScore; //每题分值
objvcc_ExamPaperQuestionTypeRelaENT.OrderNum = objvcc_ExamPaperQuestionTypeRelaENS.OrderNum; //序号
objvcc_ExamPaperQuestionTypeRelaENT.UpdDate = objvcc_ExamPaperQuestionTypeRelaENS.UpdDate; //修改日期
objvcc_ExamPaperQuestionTypeRelaENT.UpdUserId = objvcc_ExamPaperQuestionTypeRelaENS.UpdUserId; //修改用户Id
objvcc_ExamPaperQuestionTypeRelaENT.Memo = objvcc_ExamPaperQuestionTypeRelaENS.Memo; //备注
objvcc_ExamPaperQuestionTypeRelaENT.ChapterId4QT = objvcc_ExamPaperQuestionTypeRelaENS.ChapterId4QT; //ChapterId4QT
objvcc_ExamPaperQuestionTypeRelaENT.ChapterName_Sim4QT = objvcc_ExamPaperQuestionTypeRelaENS.ChapterName_Sim4QT; //ChapterName_Sim4QT
objvcc_ExamPaperQuestionTypeRelaENT.ChapterName4QT = objvcc_ExamPaperQuestionTypeRelaENS.ChapterName4QT; //ChapterName4QT
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
public static DataTable ToDataTable(List<clsvcc_ExamPaperQuestionTypeRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_ExamPaperQuestionTypeRelaEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_ExamPaperQuestionTypeRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_ExamPaperQuestionTypeRelaEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_ExamPaperQuestionTypeRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_ExamPaperQuestionTypeRelaEN.AttributeName)
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
if (clsQuestionTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeWApi没有刷新缓存机制(clsQuestionTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterWApi没有刷新缓存机制(clscc_CourseChapterWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExamPaperQuestionTypeRelaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamPaperQuestionTypeRelaWApi没有刷新缓存机制(clscc_ExamPaperQuestionTypeRelaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by Id_ExamPaperQuestionTypeRela");
//if (arrvcc_ExamPaperQuestionTypeRelaObjLst_Cache == null)
//{
//arrvcc_ExamPaperQuestionTypeRelaObjLst_Cache = await clsvcc_ExamPaperQuestionTypeRelaWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsvcc_ExamPaperQuestionTypeRelaEN._CurrTabName_S, strCourseId);
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
public static List<clsvcc_ExamPaperQuestionTypeRelaEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvcc_ExamPaperQuestionTypeRelaEN._CurrTabName_S, strCourseId);
List<clsvcc_ExamPaperQuestionTypeRelaEN> arrvcc_ExamPaperQuestionTypeRelaObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrvcc_ExamPaperQuestionTypeRelaObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_ExamPaperQuestionTypeRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.Id_ExamPaperQuestionTypeRela, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.CourseExamPaperId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.ExamPaperName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.ExamPaperTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.ExamPaperTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.TotalScore, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.DoneNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.PaperTime, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.PaperDispModeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.ExamCreateTime, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.SectionId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.SectionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.QuestionNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.Scores, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.QuestionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.QuestionTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.IsUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.ChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.NeedQuestionNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.PerScore, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.ChapterId4QT, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.ChapterName_Sim4QT, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperQuestionTypeRela.ChapterName4QT, Type.GetType("System.String"));
foreach (clsvcc_ExamPaperQuestionTypeRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_ExamPaperQuestionTypeRela.Id_ExamPaperQuestionTypeRela] = objInFor[convcc_ExamPaperQuestionTypeRela.Id_ExamPaperQuestionTypeRela];
objDR[convcc_ExamPaperQuestionTypeRela.CourseExamPaperId] = objInFor[convcc_ExamPaperQuestionTypeRela.CourseExamPaperId];
objDR[convcc_ExamPaperQuestionTypeRela.CourseId] = objInFor[convcc_ExamPaperQuestionTypeRela.CourseId];
objDR[convcc_ExamPaperQuestionTypeRela.CourseName] = objInFor[convcc_ExamPaperQuestionTypeRela.CourseName];
objDR[convcc_ExamPaperQuestionTypeRela.ExamPaperName] = objInFor[convcc_ExamPaperQuestionTypeRela.ExamPaperName];
objDR[convcc_ExamPaperQuestionTypeRela.ExamPaperTypeId] = objInFor[convcc_ExamPaperQuestionTypeRela.ExamPaperTypeId];
objDR[convcc_ExamPaperQuestionTypeRela.ExamPaperTypeName] = objInFor[convcc_ExamPaperQuestionTypeRela.ExamPaperTypeName];
objDR[convcc_ExamPaperQuestionTypeRela.IsShow] = objInFor[convcc_ExamPaperQuestionTypeRela.IsShow];
objDR[convcc_ExamPaperQuestionTypeRela.TotalScore] = objInFor[convcc_ExamPaperQuestionTypeRela.TotalScore];
objDR[convcc_ExamPaperQuestionTypeRela.ViewCount] = objInFor[convcc_ExamPaperQuestionTypeRela.ViewCount];
objDR[convcc_ExamPaperQuestionTypeRela.DoneNumber] = objInFor[convcc_ExamPaperQuestionTypeRela.DoneNumber];
objDR[convcc_ExamPaperQuestionTypeRela.PaperTime] = objInFor[convcc_ExamPaperQuestionTypeRela.PaperTime];
objDR[convcc_ExamPaperQuestionTypeRela.PaperDispModeName] = objInFor[convcc_ExamPaperQuestionTypeRela.PaperDispModeName];
objDR[convcc_ExamPaperQuestionTypeRela.ExamCreateTime] = objInFor[convcc_ExamPaperQuestionTypeRela.ExamCreateTime];
objDR[convcc_ExamPaperQuestionTypeRela.UserName] = objInFor[convcc_ExamPaperQuestionTypeRela.UserName];
objDR[convcc_ExamPaperQuestionTypeRela.CourseChapterId] = objInFor[convcc_ExamPaperQuestionTypeRela.CourseChapterId];
objDR[convcc_ExamPaperQuestionTypeRela.SectionId] = objInFor[convcc_ExamPaperQuestionTypeRela.SectionId];
objDR[convcc_ExamPaperQuestionTypeRela.ChapterName] = objInFor[convcc_ExamPaperQuestionTypeRela.ChapterName];
objDR[convcc_ExamPaperQuestionTypeRela.SectionName] = objInFor[convcc_ExamPaperQuestionTypeRela.SectionName];
objDR[convcc_ExamPaperQuestionTypeRela.ChapterName_Sim] = objInFor[convcc_ExamPaperQuestionTypeRela.ChapterName_Sim];
objDR[convcc_ExamPaperQuestionTypeRela.SectionName_Sim] = objInFor[convcc_ExamPaperQuestionTypeRela.SectionName_Sim];
objDR[convcc_ExamPaperQuestionTypeRela.QuestionNum] = objInFor[convcc_ExamPaperQuestionTypeRela.QuestionNum];
objDR[convcc_ExamPaperQuestionTypeRela.Scores] = objInFor[convcc_ExamPaperQuestionTypeRela.Scores];
objDR[convcc_ExamPaperQuestionTypeRela.QuestionTypeId] = objInFor[convcc_ExamPaperQuestionTypeRela.QuestionTypeId];
objDR[convcc_ExamPaperQuestionTypeRela.QuestionTypeName] = objInFor[convcc_ExamPaperQuestionTypeRela.QuestionTypeName];
objDR[convcc_ExamPaperQuestionTypeRela.QuestionTypeENName] = objInFor[convcc_ExamPaperQuestionTypeRela.QuestionTypeENName];
objDR[convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId] = objInFor[convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId];
objDR[convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId] = objInFor[convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId];
objDR[convcc_ExamPaperQuestionTypeRela.IsUse] = objInFor[convcc_ExamPaperQuestionTypeRela.IsUse];
objDR[convcc_ExamPaperQuestionTypeRela.ChapterId] = objInFor[convcc_ExamPaperQuestionTypeRela.ChapterId];
objDR[convcc_ExamPaperQuestionTypeRela.NeedQuestionNum] = objInFor[convcc_ExamPaperQuestionTypeRela.NeedQuestionNum];
objDR[convcc_ExamPaperQuestionTypeRela.PerScore] = objInFor[convcc_ExamPaperQuestionTypeRela.PerScore];
objDR[convcc_ExamPaperQuestionTypeRela.OrderNum] = objInFor[convcc_ExamPaperQuestionTypeRela.OrderNum];
objDR[convcc_ExamPaperQuestionTypeRela.UpdDate] = objInFor[convcc_ExamPaperQuestionTypeRela.UpdDate];
objDR[convcc_ExamPaperQuestionTypeRela.UpdUserId] = objInFor[convcc_ExamPaperQuestionTypeRela.UpdUserId];
objDR[convcc_ExamPaperQuestionTypeRela.Memo] = objInFor[convcc_ExamPaperQuestionTypeRela.Memo];
objDR[convcc_ExamPaperQuestionTypeRela.ChapterId4QT] = objInFor[convcc_ExamPaperQuestionTypeRela.ChapterId4QT];
objDR[convcc_ExamPaperQuestionTypeRela.ChapterName_Sim4QT] = objInFor[convcc_ExamPaperQuestionTypeRela.ChapterName_Sim4QT];
objDR[convcc_ExamPaperQuestionTypeRela.ChapterName4QT] = objInFor[convcc_ExamPaperQuestionTypeRela.ChapterName4QT];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}