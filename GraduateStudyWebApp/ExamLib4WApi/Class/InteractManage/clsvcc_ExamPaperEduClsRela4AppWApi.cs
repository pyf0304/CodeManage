
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_ExamPaperEduClsRela4AppWApi
 表名:vcc_ExamPaperEduClsRela4App(01120254)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:44:35
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
public static class clsvcc_ExamPaperEduClsRela4AppWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetId_ExamPaperEduClsRela(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, long lngId_ExamPaperEduClsRela, string strComparisonOp="")
	{
objvcc_ExamPaperEduClsRela4AppEN.Id_ExamPaperEduClsRela = lngId_ExamPaperEduClsRela; //作业教学班关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.Id_ExamPaperEduClsRela) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.Id_ExamPaperEduClsRela, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.Id_ExamPaperEduClsRela] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetCourseExamPaperId(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseExamPaperId, convcc_ExamPaperEduClsRela4App.CourseExamPaperId);
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, convcc_ExamPaperEduClsRela4App.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, convcc_ExamPaperEduClsRela4App.CourseExamPaperId);
objvcc_ExamPaperEduClsRela4AppEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.CourseExamPaperId) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.CourseExamPaperId, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.CourseExamPaperId] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetCourseId(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_ExamPaperEduClsRela4App.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_ExamPaperEduClsRela4App.CourseId);
objvcc_ExamPaperEduClsRela4AppEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.CourseId) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.CourseId, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.CourseId] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetCourseName(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_ExamPaperEduClsRela4App.CourseName);
objvcc_ExamPaperEduClsRela4AppEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.CourseName) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.CourseName, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.CourseName] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetExamPaperName(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, string strExamPaperName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamPaperName, 500, convcc_ExamPaperEduClsRela4App.ExamPaperName);
objvcc_ExamPaperEduClsRela4AppEN.ExamPaperName = strExamPaperName; //考卷名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.ExamPaperName) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.ExamPaperName, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.ExamPaperName] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetPaperIndex(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, int intPaperIndex, string strComparisonOp="")
	{
objvcc_ExamPaperEduClsRela4AppEN.PaperIndex = intPaperIndex; //试卷序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.PaperIndex) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.PaperIndex, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.PaperIndex] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetExamPaperTypeId(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, string strExamPaperTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamPaperTypeId, 2, convcc_ExamPaperEduClsRela4App.ExamPaperTypeId);
clsCheckSql.CheckFieldForeignKey(strExamPaperTypeId, 2, convcc_ExamPaperEduClsRela4App.ExamPaperTypeId);
objvcc_ExamPaperEduClsRela4AppEN.ExamPaperTypeId = strExamPaperTypeId; //试卷类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.ExamPaperTypeId) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.ExamPaperTypeId, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.ExamPaperTypeId] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetExamPaperTypeName(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, string strExamPaperTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamPaperTypeName, 30, convcc_ExamPaperEduClsRela4App.ExamPaperTypeName);
objvcc_ExamPaperEduClsRela4AppEN.ExamPaperTypeName = strExamPaperTypeName; //试卷类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.ExamPaperTypeName) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.ExamPaperTypeName, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.ExamPaperTypeName] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetIsShow(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, bool bolIsShow, string strComparisonOp="")
	{
objvcc_ExamPaperEduClsRela4AppEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.IsShow) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.IsShow, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.IsShow] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetTotalScore(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, double dblTotalScore, string strComparisonOp="")
	{
objvcc_ExamPaperEduClsRela4AppEN.TotalScore = dblTotalScore; //总得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.TotalScore) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.TotalScore, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.TotalScore] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetDoneNumber(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, int intDoneNumber, string strComparisonOp="")
	{
objvcc_ExamPaperEduClsRela4AppEN.DoneNumber = intDoneNumber; //已做人数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.DoneNumber) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.DoneNumber, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.DoneNumber] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetUserName(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convcc_ExamPaperEduClsRela4App.UserName);
objvcc_ExamPaperEduClsRela4AppEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.UserName) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.UserName, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.UserName] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetChapterId(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, string strChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterId, 8, convcc_ExamPaperEduClsRela4App.ChapterId);
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convcc_ExamPaperEduClsRela4App.ChapterId);
objvcc_ExamPaperEduClsRela4AppEN.ChapterId = strChapterId; //章Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.ChapterId) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.ChapterId, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.ChapterId] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetSectionId(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, string strSectionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionId, 8, convcc_ExamPaperEduClsRela4App.SectionId);
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convcc_ExamPaperEduClsRela4App.SectionId);
objvcc_ExamPaperEduClsRela4AppEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.SectionId) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.SectionId, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.SectionId] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetChapterName(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_ExamPaperEduClsRela4App.ChapterName);
objvcc_ExamPaperEduClsRela4AppEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.ChapterName) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.ChapterName, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.ChapterName] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetSectionName(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, string strSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_ExamPaperEduClsRela4App.SectionName);
objvcc_ExamPaperEduClsRela4AppEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.SectionName) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.SectionName, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.SectionName] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetChapterName_Sim(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convcc_ExamPaperEduClsRela4App.ChapterName_Sim);
objvcc_ExamPaperEduClsRela4AppEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.ChapterName_Sim) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.ChapterName_Sim, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.ChapterName_Sim] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetSectionName_Sim(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, convcc_ExamPaperEduClsRela4App.SectionName_Sim);
objvcc_ExamPaperEduClsRela4AppEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.SectionName_Sim) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.SectionName_Sim, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.SectionName_Sim] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetIsAutoGeneQuestion(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, bool bolIsAutoGeneQuestion, string strComparisonOp="")
	{
objvcc_ExamPaperEduClsRela4AppEN.IsAutoGeneQuestion = bolIsAutoGeneQuestion; //是否自动生成题目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.IsAutoGeneQuestion) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.IsAutoGeneQuestion, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.IsAutoGeneQuestion] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetQuestionNum(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, int intQuestionNum, string strComparisonOp="")
	{
objvcc_ExamPaperEduClsRela4AppEN.QuestionNum = intQuestionNum; //题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.QuestionNum) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.QuestionNum, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.QuestionNum] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN Setid_CurrEduCls(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CurrEduCls, convcc_ExamPaperEduClsRela4App.id_CurrEduCls);
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convcc_ExamPaperEduClsRela4App.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convcc_ExamPaperEduClsRela4App.id_CurrEduCls);
objvcc_ExamPaperEduClsRela4AppEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.id_CurrEduCls) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.id_CurrEduCls, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.id_CurrEduCls] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetEduClsName(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convcc_ExamPaperEduClsRela4App.EduClsName);
objvcc_ExamPaperEduClsRela4AppEN.EduClsName = strEduClsName; //教学班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.EduClsName) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.EduClsName, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.EduClsName] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetScores(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, double dblScores, string strComparisonOp="")
	{
objvcc_ExamPaperEduClsRela4AppEN.Scores = dblScores; //分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.Scores) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.Scores, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.Scores] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetTeacherID(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, string strTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherID, convcc_ExamPaperEduClsRela4App.TeacherID);
clsCheckSql.CheckFieldLen(strTeacherID, 12, convcc_ExamPaperEduClsRela4App.TeacherID);
objvcc_ExamPaperEduClsRela4AppEN.TeacherID = strTeacherID; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.TeacherID) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.TeacherID, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.TeacherID] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetIsPublish(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, bool bolIsPublish, string strComparisonOp="")
	{
objvcc_ExamPaperEduClsRela4AppEN.IsPublish = bolIsPublish; //是否发布
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.IsPublish) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.IsPublish, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.IsPublish] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetPubDate(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, string strPubDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubDate, 14, convcc_ExamPaperEduClsRela4App.PubDate);
objvcc_ExamPaperEduClsRela4AppEN.PubDate = strPubDate; //发布日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.PubDate) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.PubDate, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.PubDate] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN Setpublisher(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, string strpublisher, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strpublisher, 20, convcc_ExamPaperEduClsRela4App.publisher);
objvcc_ExamPaperEduClsRela4AppEN.publisher = strpublisher; //发布者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.publisher) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.publisher, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.publisher] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetCourseStudentGroupId(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, long lngCourseStudentGroupId, string strComparisonOp="")
	{
objvcc_ExamPaperEduClsRela4AppEN.CourseStudentGroupId = lngCourseStudentGroupId; //学生分组表流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.CourseStudentGroupId) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.CourseStudentGroupId, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.CourseStudentGroupId] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetWorkTypeId(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, string strWorkTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkTypeId, convcc_ExamPaperEduClsRela4App.WorkTypeId);
clsCheckSql.CheckFieldLen(strWorkTypeId, 2, convcc_ExamPaperEduClsRela4App.WorkTypeId);
clsCheckSql.CheckFieldForeignKey(strWorkTypeId, 2, convcc_ExamPaperEduClsRela4App.WorkTypeId);
objvcc_ExamPaperEduClsRela4AppEN.WorkTypeId = strWorkTypeId; //作业类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.WorkTypeId) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.WorkTypeId, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.WorkTypeId] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetWorkTypeName(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, string strWorkTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWorkTypeName, 30, convcc_ExamPaperEduClsRela4App.WorkTypeName);
objvcc_ExamPaperEduClsRela4AppEN.WorkTypeName = strWorkTypeName; //作业类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.WorkTypeName) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.WorkTypeName, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.WorkTypeName] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetUpdDate(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_ExamPaperEduClsRela4App.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_ExamPaperEduClsRela4App.UpdDate);
objvcc_ExamPaperEduClsRela4AppEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.UpdDate) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.UpdDate, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.UpdDate] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetUpdUserId(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_ExamPaperEduClsRela4App.UpdUserId);
objvcc_ExamPaperEduClsRela4AppEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.UpdUserId) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.UpdUserId, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.UpdUserId] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetMemo(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_ExamPaperEduClsRela4App.Memo);
objvcc_ExamPaperEduClsRela4AppEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.Memo) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.Memo, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.Memo] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetStuNum(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, int intStuNum, string strComparisonOp="")
	{
objvcc_ExamPaperEduClsRela4AppEN.StuNum = intStuNum; //学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.StuNum) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.StuNum, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.StuNum] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN SetEduClsStuNum(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN, int intEduClsStuNum, string strComparisonOp="")
	{
objvcc_ExamPaperEduClsRela4AppEN.EduClsStuNum = intEduClsStuNum; //教学班学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela4App.EduClsStuNum) == false)
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela4App.EduClsStuNum, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRela4AppEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.EduClsStuNum] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRela4AppEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4App_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.Id_ExamPaperEduClsRela) == true)
{
string strComparisonOp_Id_ExamPaperEduClsRela = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.Id_ExamPaperEduClsRela];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperEduClsRela4App.Id_ExamPaperEduClsRela, objvcc_ExamPaperEduClsRela4App_Cond.Id_ExamPaperEduClsRela, strComparisonOp_Id_ExamPaperEduClsRela);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.CourseExamPaperId) == true)
{
string strComparisonOp_CourseExamPaperId = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela4App.CourseExamPaperId, objvcc_ExamPaperEduClsRela4App_Cond.CourseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela4App.CourseId, objvcc_ExamPaperEduClsRela4App_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela4App.CourseName, objvcc_ExamPaperEduClsRela4App_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.ExamPaperName) == true)
{
string strComparisonOp_ExamPaperName = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.ExamPaperName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela4App.ExamPaperName, objvcc_ExamPaperEduClsRela4App_Cond.ExamPaperName, strComparisonOp_ExamPaperName);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.PaperIndex) == true)
{
string strComparisonOp_PaperIndex = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.PaperIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperEduClsRela4App.PaperIndex, objvcc_ExamPaperEduClsRela4App_Cond.PaperIndex, strComparisonOp_PaperIndex);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.ExamPaperTypeId) == true)
{
string strComparisonOp_ExamPaperTypeId = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.ExamPaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela4App.ExamPaperTypeId, objvcc_ExamPaperEduClsRela4App_Cond.ExamPaperTypeId, strComparisonOp_ExamPaperTypeId);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.ExamPaperTypeName) == true)
{
string strComparisonOp_ExamPaperTypeName = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.ExamPaperTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela4App.ExamPaperTypeName, objvcc_ExamPaperEduClsRela4App_Cond.ExamPaperTypeName, strComparisonOp_ExamPaperTypeName);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.IsShow) == true)
{
if (objvcc_ExamPaperEduClsRela4App_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperEduClsRela4App.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperEduClsRela4App.IsShow);
}
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.TotalScore) == true)
{
string strComparisonOp_TotalScore = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.TotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperEduClsRela4App.TotalScore, objvcc_ExamPaperEduClsRela4App_Cond.TotalScore, strComparisonOp_TotalScore);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.DoneNumber) == true)
{
string strComparisonOp_DoneNumber = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.DoneNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperEduClsRela4App.DoneNumber, objvcc_ExamPaperEduClsRela4App_Cond.DoneNumber, strComparisonOp_DoneNumber);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.UserName) == true)
{
string strComparisonOp_UserName = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela4App.UserName, objvcc_ExamPaperEduClsRela4App_Cond.UserName, strComparisonOp_UserName);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.ChapterId) == true)
{
string strComparisonOp_ChapterId = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela4App.ChapterId, objvcc_ExamPaperEduClsRela4App_Cond.ChapterId, strComparisonOp_ChapterId);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.SectionId) == true)
{
string strComparisonOp_SectionId = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela4App.SectionId, objvcc_ExamPaperEduClsRela4App_Cond.SectionId, strComparisonOp_SectionId);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela4App.ChapterName, objvcc_ExamPaperEduClsRela4App_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.SectionName) == true)
{
string strComparisonOp_SectionName = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela4App.SectionName, objvcc_ExamPaperEduClsRela4App_Cond.SectionName, strComparisonOp_SectionName);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela4App.ChapterName_Sim, objvcc_ExamPaperEduClsRela4App_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela4App.SectionName_Sim, objvcc_ExamPaperEduClsRela4App_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.IsAutoGeneQuestion) == true)
{
if (objvcc_ExamPaperEduClsRela4App_Cond.IsAutoGeneQuestion == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperEduClsRela4App.IsAutoGeneQuestion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperEduClsRela4App.IsAutoGeneQuestion);
}
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.QuestionNum) == true)
{
string strComparisonOp_QuestionNum = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.QuestionNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperEduClsRela4App.QuestionNum, objvcc_ExamPaperEduClsRela4App_Cond.QuestionNum, strComparisonOp_QuestionNum);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela4App.id_CurrEduCls, objvcc_ExamPaperEduClsRela4App_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.EduClsName) == true)
{
string strComparisonOp_EduClsName = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela4App.EduClsName, objvcc_ExamPaperEduClsRela4App_Cond.EduClsName, strComparisonOp_EduClsName);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.Scores) == true)
{
string strComparisonOp_Scores = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.Scores];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperEduClsRela4App.Scores, objvcc_ExamPaperEduClsRela4App_Cond.Scores, strComparisonOp_Scores);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.TeacherID) == true)
{
string strComparisonOp_TeacherID = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela4App.TeacherID, objvcc_ExamPaperEduClsRela4App_Cond.TeacherID, strComparisonOp_TeacherID);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.IsPublish) == true)
{
if (objvcc_ExamPaperEduClsRela4App_Cond.IsPublish == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperEduClsRela4App.IsPublish);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperEduClsRela4App.IsPublish);
}
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.PubDate) == true)
{
string strComparisonOp_PubDate = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.PubDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela4App.PubDate, objvcc_ExamPaperEduClsRela4App_Cond.PubDate, strComparisonOp_PubDate);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.publisher) == true)
{
string strComparisonOp_publisher = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.publisher];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela4App.publisher, objvcc_ExamPaperEduClsRela4App_Cond.publisher, strComparisonOp_publisher);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.CourseStudentGroupId) == true)
{
string strComparisonOp_CourseStudentGroupId = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.CourseStudentGroupId];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperEduClsRela4App.CourseStudentGroupId, objvcc_ExamPaperEduClsRela4App_Cond.CourseStudentGroupId, strComparisonOp_CourseStudentGroupId);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.WorkTypeId) == true)
{
string strComparisonOp_WorkTypeId = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.WorkTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela4App.WorkTypeId, objvcc_ExamPaperEduClsRela4App_Cond.WorkTypeId, strComparisonOp_WorkTypeId);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.WorkTypeName) == true)
{
string strComparisonOp_WorkTypeName = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.WorkTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela4App.WorkTypeName, objvcc_ExamPaperEduClsRela4App_Cond.WorkTypeName, strComparisonOp_WorkTypeName);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela4App.UpdDate, objvcc_ExamPaperEduClsRela4App_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela4App.UpdUserId, objvcc_ExamPaperEduClsRela4App_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.Memo) == true)
{
string strComparisonOp_Memo = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela4App.Memo, objvcc_ExamPaperEduClsRela4App_Cond.Memo, strComparisonOp_Memo);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.StuNum) == true)
{
string strComparisonOp_StuNum = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.StuNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperEduClsRela4App.StuNum, objvcc_ExamPaperEduClsRela4App_Cond.StuNum, strComparisonOp_StuNum);
}
if (objvcc_ExamPaperEduClsRela4App_Cond.IsUpdated(convcc_ExamPaperEduClsRela4App.EduClsStuNum) == true)
{
string strComparisonOp_EduClsStuNum = objvcc_ExamPaperEduClsRela4App_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela4App.EduClsStuNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperEduClsRela4App.EduClsStuNum, objvcc_ExamPaperEduClsRela4App_Cond.EduClsStuNum, strComparisonOp_EduClsStuNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v考卷教学班关系表4App(vcc_ExamPaperEduClsRela4App)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_ExamPaperEduClsRela4AppWApi
{
private static readonly string mstrApiControllerName = "vcc_ExamPaperEduClsRela4AppApi";

 public clsvcc_ExamPaperEduClsRela4AppWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_ExamPaperEduClsRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN GetObjById_ExamPaperEduClsRela(long lngId_ExamPaperEduClsRela)
{
string strAction = "GetObjById_ExamPaperEduClsRela";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_ExamPaperEduClsRela"] = lngId_ExamPaperEduClsRela.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_ExamPaperEduClsRela4AppEN = JsonConvert.DeserializeObject<clsvcc_ExamPaperEduClsRela4AppEN>((string)jobjReturn["ReturnObj"]);
return objvcc_ExamPaperEduClsRela4AppEN;
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
 /// <param name = "lngId_ExamPaperEduClsRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN GetObjById_ExamPaperEduClsRela_WA_Cache(long lngId_ExamPaperEduClsRela)
{
string strAction = "GetObjById_ExamPaperEduClsRela_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_ExamPaperEduClsRela"] = lngId_ExamPaperEduClsRela.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_ExamPaperEduClsRela4AppEN = JsonConvert.DeserializeObject<clsvcc_ExamPaperEduClsRela4AppEN>((string)jobjReturn["ReturnObj"]);
return objvcc_ExamPaperEduClsRela4AppEN;
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
public static clsvcc_ExamPaperEduClsRela4AppEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppEN = null;
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
objvcc_ExamPaperEduClsRela4AppEN = JsonConvert.DeserializeObject<clsvcc_ExamPaperEduClsRela4AppEN>((string)jobjReturn["ReturnObj"]);
return objvcc_ExamPaperEduClsRela4AppEN;
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
 /// <param name = "lngId_ExamPaperEduClsRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_ExamPaperEduClsRela4AppEN GetObjById_ExamPaperEduClsRela_Cache(long lngId_ExamPaperEduClsRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_ExamPaperEduClsRela4AppEN._CurrTabName_S);
List<clsvcc_ExamPaperEduClsRela4AppEN> arrvcc_ExamPaperEduClsRela4AppObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_ExamPaperEduClsRela4AppEN> arrvcc_ExamPaperEduClsRela4AppObjLst_Sel =
from objvcc_ExamPaperEduClsRela4AppEN in arrvcc_ExamPaperEduClsRela4AppObjLst_Cache
where objvcc_ExamPaperEduClsRela4AppEN.Id_ExamPaperEduClsRela == lngId_ExamPaperEduClsRela
select objvcc_ExamPaperEduClsRela4AppEN;
if (arrvcc_ExamPaperEduClsRela4AppObjLst_Sel.Count() == 0)
{
   clsvcc_ExamPaperEduClsRela4AppEN obj = clsvcc_ExamPaperEduClsRela4AppWApi.GetObjById_ExamPaperEduClsRela(lngId_ExamPaperEduClsRela);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_ExamPaperEduClsRela4AppObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_ExamPaperEduClsRela4AppEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_ExamPaperEduClsRela4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperEduClsRela4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperEduClsRela4AppEN> GetObjLstById_ExamPaperEduClsRelaLst(List<long> arrId_ExamPaperEduClsRela)
{
 List<clsvcc_ExamPaperEduClsRela4AppEN> arrObjLst = null; 
string strAction = "GetObjLstById_ExamPaperEduClsRelaLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_ExamPaperEduClsRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperEduClsRela4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngId_ExamPaperEduClsRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvcc_ExamPaperEduClsRela4AppEN> GetObjLstById_ExamPaperEduClsRelaLst_Cache(List<long> arrId_ExamPaperEduClsRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_ExamPaperEduClsRela4AppEN._CurrTabName_S);
List<clsvcc_ExamPaperEduClsRela4AppEN> arrvcc_ExamPaperEduClsRela4AppObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_ExamPaperEduClsRela4AppEN> arrvcc_ExamPaperEduClsRela4AppObjLst_Sel =
from objvcc_ExamPaperEduClsRela4AppEN in arrvcc_ExamPaperEduClsRela4AppObjLst_Cache
where arrId_ExamPaperEduClsRela.Contains(objvcc_ExamPaperEduClsRela4AppEN.Id_ExamPaperEduClsRela)
select objvcc_ExamPaperEduClsRela4AppEN;
return arrvcc_ExamPaperEduClsRela4AppObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_ExamPaperEduClsRela4AppEN> GetObjLstById_ExamPaperEduClsRelaLst_WA_Cache(List<long> arrId_ExamPaperEduClsRela)
{
 List<clsvcc_ExamPaperEduClsRela4AppEN> arrObjLst = null; 
string strAction = "GetObjLstById_ExamPaperEduClsRelaLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_ExamPaperEduClsRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperEduClsRela4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperEduClsRela4AppEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_ExamPaperEduClsRela4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperEduClsRela4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperEduClsRela4AppEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_ExamPaperEduClsRela4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperEduClsRela4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperEduClsRela4AppEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_ExamPaperEduClsRela4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperEduClsRela4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperEduClsRela4AppEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_ExamPaperEduClsRela4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperEduClsRela4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngId_ExamPaperEduClsRela)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_ExamPaperEduClsRela"] = lngId_ExamPaperEduClsRela.ToString()
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
 /// <param name = "objvcc_ExamPaperEduClsRela4AppENS">源对象</param>
 /// <param name = "objvcc_ExamPaperEduClsRela4AppENT">目标对象</param>
 public static void CopyTo(clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppENS, clsvcc_ExamPaperEduClsRela4AppEN objvcc_ExamPaperEduClsRela4AppENT)
{
try
{
objvcc_ExamPaperEduClsRela4AppENT.Id_ExamPaperEduClsRela = objvcc_ExamPaperEduClsRela4AppENS.Id_ExamPaperEduClsRela; //作业教学班关系流水号
objvcc_ExamPaperEduClsRela4AppENT.CourseExamPaperId = objvcc_ExamPaperEduClsRela4AppENS.CourseExamPaperId; //考卷流水号
objvcc_ExamPaperEduClsRela4AppENT.CourseId = objvcc_ExamPaperEduClsRela4AppENS.CourseId; //课程Id
objvcc_ExamPaperEduClsRela4AppENT.CourseName = objvcc_ExamPaperEduClsRela4AppENS.CourseName; //课程名称
objvcc_ExamPaperEduClsRela4AppENT.ExamPaperName = objvcc_ExamPaperEduClsRela4AppENS.ExamPaperName; //考卷名称
objvcc_ExamPaperEduClsRela4AppENT.PaperIndex = objvcc_ExamPaperEduClsRela4AppENS.PaperIndex; //试卷序号
objvcc_ExamPaperEduClsRela4AppENT.ExamPaperTypeId = objvcc_ExamPaperEduClsRela4AppENS.ExamPaperTypeId; //试卷类型Id
objvcc_ExamPaperEduClsRela4AppENT.ExamPaperTypeName = objvcc_ExamPaperEduClsRela4AppENS.ExamPaperTypeName; //试卷类型名称
objvcc_ExamPaperEduClsRela4AppENT.IsShow = objvcc_ExamPaperEduClsRela4AppENS.IsShow; //是否启用
objvcc_ExamPaperEduClsRela4AppENT.TotalScore = objvcc_ExamPaperEduClsRela4AppENS.TotalScore; //总得分
objvcc_ExamPaperEduClsRela4AppENT.DoneNumber = objvcc_ExamPaperEduClsRela4AppENS.DoneNumber; //已做人数
objvcc_ExamPaperEduClsRela4AppENT.UserName = objvcc_ExamPaperEduClsRela4AppENS.UserName; //用户名
objvcc_ExamPaperEduClsRela4AppENT.ChapterId = objvcc_ExamPaperEduClsRela4AppENS.ChapterId; //章Id
objvcc_ExamPaperEduClsRela4AppENT.SectionId = objvcc_ExamPaperEduClsRela4AppENS.SectionId; //节Id
objvcc_ExamPaperEduClsRela4AppENT.ChapterName = objvcc_ExamPaperEduClsRela4AppENS.ChapterName; //章名
objvcc_ExamPaperEduClsRela4AppENT.SectionName = objvcc_ExamPaperEduClsRela4AppENS.SectionName; //节名
objvcc_ExamPaperEduClsRela4AppENT.ChapterName_Sim = objvcc_ExamPaperEduClsRela4AppENS.ChapterName_Sim; //章名简称
objvcc_ExamPaperEduClsRela4AppENT.SectionName_Sim = objvcc_ExamPaperEduClsRela4AppENS.SectionName_Sim; //节名简称
objvcc_ExamPaperEduClsRela4AppENT.IsAutoGeneQuestion = objvcc_ExamPaperEduClsRela4AppENS.IsAutoGeneQuestion; //是否自动生成题目
objvcc_ExamPaperEduClsRela4AppENT.QuestionNum = objvcc_ExamPaperEduClsRela4AppENS.QuestionNum; //题目数
objvcc_ExamPaperEduClsRela4AppENT.id_CurrEduCls = objvcc_ExamPaperEduClsRela4AppENS.id_CurrEduCls; //当前教学班流水号
objvcc_ExamPaperEduClsRela4AppENT.EduClsName = objvcc_ExamPaperEduClsRela4AppENS.EduClsName; //教学班名称
objvcc_ExamPaperEduClsRela4AppENT.Scores = objvcc_ExamPaperEduClsRela4AppENS.Scores; //分值
objvcc_ExamPaperEduClsRela4AppENT.TeacherID = objvcc_ExamPaperEduClsRela4AppENS.TeacherID; //教师工号
objvcc_ExamPaperEduClsRela4AppENT.IsPublish = objvcc_ExamPaperEduClsRela4AppENS.IsPublish; //是否发布
objvcc_ExamPaperEduClsRela4AppENT.PubDate = objvcc_ExamPaperEduClsRela4AppENS.PubDate; //发布日期
objvcc_ExamPaperEduClsRela4AppENT.publisher = objvcc_ExamPaperEduClsRela4AppENS.publisher; //发布者Id
objvcc_ExamPaperEduClsRela4AppENT.CourseStudentGroupId = objvcc_ExamPaperEduClsRela4AppENS.CourseStudentGroupId; //学生分组表流水号
objvcc_ExamPaperEduClsRela4AppENT.WorkTypeId = objvcc_ExamPaperEduClsRela4AppENS.WorkTypeId; //作业类型Id
objvcc_ExamPaperEduClsRela4AppENT.WorkTypeName = objvcc_ExamPaperEduClsRela4AppENS.WorkTypeName; //作业类型名称
objvcc_ExamPaperEduClsRela4AppENT.UpdDate = objvcc_ExamPaperEduClsRela4AppENS.UpdDate; //修改日期
objvcc_ExamPaperEduClsRela4AppENT.UpdUserId = objvcc_ExamPaperEduClsRela4AppENS.UpdUserId; //修改用户Id
objvcc_ExamPaperEduClsRela4AppENT.Memo = objvcc_ExamPaperEduClsRela4AppENS.Memo; //备注
objvcc_ExamPaperEduClsRela4AppENT.StuNum = objvcc_ExamPaperEduClsRela4AppENS.StuNum; //学生数
objvcc_ExamPaperEduClsRela4AppENT.EduClsStuNum = objvcc_ExamPaperEduClsRela4AppENS.EduClsStuNum; //教学班学生数
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
public static DataTable ToDataTable(List<clsvcc_ExamPaperEduClsRela4AppEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_ExamPaperEduClsRela4AppEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_ExamPaperEduClsRela4AppEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_ExamPaperEduClsRela4AppEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_ExamPaperEduClsRela4AppEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_ExamPaperEduClsRela4AppEN.AttributeName)
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
//string strWhereCond = string.Format("1 = 1 order by Id_ExamPaperEduClsRela");
//if (arrvcc_ExamPaperEduClsRela4AppObjLst_Cache == null)
//{
//arrvcc_ExamPaperEduClsRela4AppObjLst_Cache = await clsvcc_ExamPaperEduClsRela4AppWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvcc_ExamPaperEduClsRela4AppEN._CurrTabName_S);
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
public static List<clsvcc_ExamPaperEduClsRela4AppEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvcc_ExamPaperEduClsRela4AppEN._CurrTabName_S);
List<clsvcc_ExamPaperEduClsRela4AppEN> arrvcc_ExamPaperEduClsRela4AppObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_ExamPaperEduClsRela4AppObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_ExamPaperEduClsRela4AppEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.Id_ExamPaperEduClsRela, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.CourseExamPaperId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.ExamPaperName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.PaperIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.ExamPaperTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.ExamPaperTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.TotalScore, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.DoneNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.ChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.SectionId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.SectionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.IsAutoGeneQuestion, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.QuestionNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.EduClsName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.Scores, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.TeacherID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.IsPublish, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.PubDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.publisher, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.CourseStudentGroupId, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.WorkTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.WorkTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.StuNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela4App.EduClsStuNum, Type.GetType("System.Int32"));
foreach (clsvcc_ExamPaperEduClsRela4AppEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_ExamPaperEduClsRela4App.Id_ExamPaperEduClsRela] = objInFor[convcc_ExamPaperEduClsRela4App.Id_ExamPaperEduClsRela];
objDR[convcc_ExamPaperEduClsRela4App.CourseExamPaperId] = objInFor[convcc_ExamPaperEduClsRela4App.CourseExamPaperId];
objDR[convcc_ExamPaperEduClsRela4App.CourseId] = objInFor[convcc_ExamPaperEduClsRela4App.CourseId];
objDR[convcc_ExamPaperEduClsRela4App.CourseName] = objInFor[convcc_ExamPaperEduClsRela4App.CourseName];
objDR[convcc_ExamPaperEduClsRela4App.ExamPaperName] = objInFor[convcc_ExamPaperEduClsRela4App.ExamPaperName];
objDR[convcc_ExamPaperEduClsRela4App.PaperIndex] = objInFor[convcc_ExamPaperEduClsRela4App.PaperIndex];
objDR[convcc_ExamPaperEduClsRela4App.ExamPaperTypeId] = objInFor[convcc_ExamPaperEduClsRela4App.ExamPaperTypeId];
objDR[convcc_ExamPaperEduClsRela4App.ExamPaperTypeName] = objInFor[convcc_ExamPaperEduClsRela4App.ExamPaperTypeName];
objDR[convcc_ExamPaperEduClsRela4App.IsShow] = objInFor[convcc_ExamPaperEduClsRela4App.IsShow];
objDR[convcc_ExamPaperEduClsRela4App.TotalScore] = objInFor[convcc_ExamPaperEduClsRela4App.TotalScore];
objDR[convcc_ExamPaperEduClsRela4App.DoneNumber] = objInFor[convcc_ExamPaperEduClsRela4App.DoneNumber];
objDR[convcc_ExamPaperEduClsRela4App.UserName] = objInFor[convcc_ExamPaperEduClsRela4App.UserName];
objDR[convcc_ExamPaperEduClsRela4App.ChapterId] = objInFor[convcc_ExamPaperEduClsRela4App.ChapterId];
objDR[convcc_ExamPaperEduClsRela4App.SectionId] = objInFor[convcc_ExamPaperEduClsRela4App.SectionId];
objDR[convcc_ExamPaperEduClsRela4App.ChapterName] = objInFor[convcc_ExamPaperEduClsRela4App.ChapterName];
objDR[convcc_ExamPaperEduClsRela4App.SectionName] = objInFor[convcc_ExamPaperEduClsRela4App.SectionName];
objDR[convcc_ExamPaperEduClsRela4App.ChapterName_Sim] = objInFor[convcc_ExamPaperEduClsRela4App.ChapterName_Sim];
objDR[convcc_ExamPaperEduClsRela4App.SectionName_Sim] = objInFor[convcc_ExamPaperEduClsRela4App.SectionName_Sim];
objDR[convcc_ExamPaperEduClsRela4App.IsAutoGeneQuestion] = objInFor[convcc_ExamPaperEduClsRela4App.IsAutoGeneQuestion];
objDR[convcc_ExamPaperEduClsRela4App.QuestionNum] = objInFor[convcc_ExamPaperEduClsRela4App.QuestionNum];
objDR[convcc_ExamPaperEduClsRela4App.id_CurrEduCls] = objInFor[convcc_ExamPaperEduClsRela4App.id_CurrEduCls];
objDR[convcc_ExamPaperEduClsRela4App.EduClsName] = objInFor[convcc_ExamPaperEduClsRela4App.EduClsName];
objDR[convcc_ExamPaperEduClsRela4App.Scores] = objInFor[convcc_ExamPaperEduClsRela4App.Scores];
objDR[convcc_ExamPaperEduClsRela4App.TeacherID] = objInFor[convcc_ExamPaperEduClsRela4App.TeacherID];
objDR[convcc_ExamPaperEduClsRela4App.IsPublish] = objInFor[convcc_ExamPaperEduClsRela4App.IsPublish];
objDR[convcc_ExamPaperEduClsRela4App.PubDate] = objInFor[convcc_ExamPaperEduClsRela4App.PubDate];
objDR[convcc_ExamPaperEduClsRela4App.publisher] = objInFor[convcc_ExamPaperEduClsRela4App.publisher];
objDR[convcc_ExamPaperEduClsRela4App.CourseStudentGroupId] = objInFor[convcc_ExamPaperEduClsRela4App.CourseStudentGroupId];
objDR[convcc_ExamPaperEduClsRela4App.WorkTypeId] = objInFor[convcc_ExamPaperEduClsRela4App.WorkTypeId];
objDR[convcc_ExamPaperEduClsRela4App.WorkTypeName] = objInFor[convcc_ExamPaperEduClsRela4App.WorkTypeName];
objDR[convcc_ExamPaperEduClsRela4App.UpdDate] = objInFor[convcc_ExamPaperEduClsRela4App.UpdDate];
objDR[convcc_ExamPaperEduClsRela4App.UpdUserId] = objInFor[convcc_ExamPaperEduClsRela4App.UpdUserId];
objDR[convcc_ExamPaperEduClsRela4App.Memo] = objInFor[convcc_ExamPaperEduClsRela4App.Memo];
objDR[convcc_ExamPaperEduClsRela4App.StuNum] = objInFor[convcc_ExamPaperEduClsRela4App.StuNum];
objDR[convcc_ExamPaperEduClsRela4App.EduClsStuNum] = objInFor[convcc_ExamPaperEduClsRela4App.EduClsStuNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}