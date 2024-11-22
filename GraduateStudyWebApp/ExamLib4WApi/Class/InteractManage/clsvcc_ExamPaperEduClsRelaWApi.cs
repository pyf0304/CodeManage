
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_ExamPaperEduClsRelaWApi
 表名:vcc_ExamPaperEduClsRela(01120234)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:47:06
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
public static class clsvcc_ExamPaperEduClsRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetId_ExamPaperEduClsRela(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, long lngId_ExamPaperEduClsRela, string strComparisonOp="")
	{
objvcc_ExamPaperEduClsRelaEN.Id_ExamPaperEduClsRela = lngId_ExamPaperEduClsRela; //作业教学班关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.Id_ExamPaperEduClsRela) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.Id_ExamPaperEduClsRela, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.Id_ExamPaperEduClsRela] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetCourseExamPaperId(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, convcc_ExamPaperEduClsRela.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, convcc_ExamPaperEduClsRela.CourseExamPaperId);
objvcc_ExamPaperEduClsRelaEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.CourseExamPaperId) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.CourseExamPaperId, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.CourseExamPaperId] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetCourseId(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_ExamPaperEduClsRela.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_ExamPaperEduClsRela.CourseId);
objvcc_ExamPaperEduClsRelaEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.CourseId) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.CourseId, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.CourseId] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetCourseName(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_ExamPaperEduClsRela.CourseName);
objvcc_ExamPaperEduClsRelaEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.CourseName) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.CourseName, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.CourseName] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetExamPaperName(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, string strExamPaperName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamPaperName, 500, convcc_ExamPaperEduClsRela.ExamPaperName);
objvcc_ExamPaperEduClsRelaEN.ExamPaperName = strExamPaperName; //考卷名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.ExamPaperName) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.ExamPaperName, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.ExamPaperName] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetPaperIndex(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, int intPaperIndex, string strComparisonOp="")
	{
objvcc_ExamPaperEduClsRelaEN.PaperIndex = intPaperIndex; //试卷序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.PaperIndex) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.PaperIndex, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.PaperIndex] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetExamPaperTypeId(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, string strExamPaperTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strExamPaperTypeId, convcc_ExamPaperEduClsRela.ExamPaperTypeId);
clsCheckSql.CheckFieldLen(strExamPaperTypeId, 2, convcc_ExamPaperEduClsRela.ExamPaperTypeId);
clsCheckSql.CheckFieldForeignKey(strExamPaperTypeId, 2, convcc_ExamPaperEduClsRela.ExamPaperTypeId);
objvcc_ExamPaperEduClsRelaEN.ExamPaperTypeId = strExamPaperTypeId; //试卷类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.ExamPaperTypeId) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.ExamPaperTypeId, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.ExamPaperTypeId] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetExamPaperTypeName(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, string strExamPaperTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strExamPaperTypeName, convcc_ExamPaperEduClsRela.ExamPaperTypeName);
clsCheckSql.CheckFieldLen(strExamPaperTypeName, 30, convcc_ExamPaperEduClsRela.ExamPaperTypeName);
objvcc_ExamPaperEduClsRelaEN.ExamPaperTypeName = strExamPaperTypeName; //试卷类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.ExamPaperTypeName) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.ExamPaperTypeName, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.ExamPaperTypeName] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetIsShow(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, bool bolIsShow, string strComparisonOp="")
	{
objvcc_ExamPaperEduClsRelaEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.IsShow) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.IsShow, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.IsShow] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetTotalScore(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, double dblTotalScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dblTotalScore, convcc_ExamPaperEduClsRela.TotalScore);
objvcc_ExamPaperEduClsRelaEN.TotalScore = dblTotalScore; //总得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.TotalScore) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.TotalScore, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.TotalScore] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetViewCount(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, int intViewCount, string strComparisonOp="")
	{
objvcc_ExamPaperEduClsRelaEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.ViewCount) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.ViewCount, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.ViewCount] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetDoneNumber(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, int intDoneNumber, string strComparisonOp="")
	{
objvcc_ExamPaperEduClsRelaEN.DoneNumber = intDoneNumber; //已做人数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.DoneNumber) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.DoneNumber, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.DoneNumber] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetPaperTime(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, int intPaperTime, string strComparisonOp="")
	{
objvcc_ExamPaperEduClsRelaEN.PaperTime = intPaperTime; //考试时间（分钟）
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.PaperTime) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.PaperTime, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.PaperTime] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetPaperDispModeName(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, string strPaperDispModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperDispModeName, 30, convcc_ExamPaperEduClsRela.PaperDispModeName);
objvcc_ExamPaperEduClsRelaEN.PaperDispModeName = strPaperDispModeName; //试卷显示模式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.PaperDispModeName) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.PaperDispModeName, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.PaperDispModeName] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetExamCreateTime(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, string strExamCreateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamCreateTime, 14, convcc_ExamPaperEduClsRela.ExamCreateTime);
objvcc_ExamPaperEduClsRelaEN.ExamCreateTime = strExamCreateTime; //考卷建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.ExamCreateTime) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.ExamCreateTime, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.ExamCreateTime] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetUserName(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convcc_ExamPaperEduClsRela.UserName);
objvcc_ExamPaperEduClsRelaEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.UserName) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.UserName, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.UserName] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetCourseChapterId(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_ExamPaperEduClsRela.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_ExamPaperEduClsRela.CourseChapterId);
objvcc_ExamPaperEduClsRelaEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.CourseChapterId) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.CourseChapterId, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.CourseChapterId] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetCourseChapterName(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_ExamPaperEduClsRela.CourseChapterName);
objvcc_ExamPaperEduClsRelaEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.CourseChapterName) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.CourseChapterName, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.CourseChapterName] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetChapterId(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, string strChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterId, 8, convcc_ExamPaperEduClsRela.ChapterId);
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convcc_ExamPaperEduClsRela.ChapterId);
objvcc_ExamPaperEduClsRelaEN.ChapterId = strChapterId; //章Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.ChapterId) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.ChapterId, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.ChapterId] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetSectionId(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, string strSectionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionId, 8, convcc_ExamPaperEduClsRela.SectionId);
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convcc_ExamPaperEduClsRela.SectionId);
objvcc_ExamPaperEduClsRelaEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.SectionId) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.SectionId, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.SectionId] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetChapterName(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_ExamPaperEduClsRela.ChapterName);
objvcc_ExamPaperEduClsRelaEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.ChapterName) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.ChapterName, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.ChapterName] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetSectionName(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, string strSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_ExamPaperEduClsRela.SectionName);
objvcc_ExamPaperEduClsRelaEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.SectionName) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.SectionName, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.SectionName] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetChapterName_Sim(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convcc_ExamPaperEduClsRela.ChapterName_Sim);
objvcc_ExamPaperEduClsRelaEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.ChapterName_Sim) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.ChapterName_Sim, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.ChapterName_Sim] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetSectionName_Sim(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, convcc_ExamPaperEduClsRela.SectionName_Sim);
objvcc_ExamPaperEduClsRelaEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.SectionName_Sim) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.SectionName_Sim, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.SectionName_Sim] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetIsAutoGeneQuestion(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, bool bolIsAutoGeneQuestion, string strComparisonOp="")
	{
objvcc_ExamPaperEduClsRelaEN.IsAutoGeneQuestion = bolIsAutoGeneQuestion; //是否自动生成题目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.IsAutoGeneQuestion) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.IsAutoGeneQuestion, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.IsAutoGeneQuestion] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetIsCanMultiDo(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, bool bolIsCanMultiDo, string strComparisonOp="")
	{
objvcc_ExamPaperEduClsRelaEN.IsCanMultiDo = bolIsCanMultiDo; //是否可以做多次
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.IsCanMultiDo) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.IsCanMultiDo, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.IsCanMultiDo] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetQuestionNum(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, int intQuestionNum, string strComparisonOp="")
	{
objvcc_ExamPaperEduClsRelaEN.QuestionNum = intQuestionNum; //题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.QuestionNum) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.QuestionNum, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.QuestionNum] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN Setid_CurrEduCls(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CurrEduCls, convcc_ExamPaperEduClsRela.id_CurrEduCls);
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convcc_ExamPaperEduClsRela.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convcc_ExamPaperEduClsRela.id_CurrEduCls);
objvcc_ExamPaperEduClsRelaEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.id_CurrEduCls) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.id_CurrEduCls, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.id_CurrEduCls] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetCurrEduClsId(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, string strCurrEduClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, convcc_ExamPaperEduClsRela.CurrEduClsId);
objvcc_ExamPaperEduClsRelaEN.CurrEduClsId = strCurrEduClsId; //当前教学班Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.CurrEduClsId) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.CurrEduClsId, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.CurrEduClsId] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetEduClsName(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduClsName, convcc_ExamPaperEduClsRela.EduClsName);
clsCheckSql.CheckFieldLen(strEduClsName, 100, convcc_ExamPaperEduClsRela.EduClsName);
objvcc_ExamPaperEduClsRelaEN.EduClsName = strEduClsName; //教学班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.EduClsName) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.EduClsName, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.EduClsName] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetScores(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, double dblScores, string strComparisonOp="")
	{
objvcc_ExamPaperEduClsRelaEN.Scores = dblScores; //分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.Scores) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.Scores, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.Scores] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetTeacherID(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, string strTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherID, convcc_ExamPaperEduClsRela.TeacherID);
clsCheckSql.CheckFieldLen(strTeacherID, 12, convcc_ExamPaperEduClsRela.TeacherID);
objvcc_ExamPaperEduClsRelaEN.TeacherID = strTeacherID; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.TeacherID) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.TeacherID, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.TeacherID] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetIsPublish(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, bool bolIsPublish, string strComparisonOp="")
	{
objvcc_ExamPaperEduClsRelaEN.IsPublish = bolIsPublish; //是否发布
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.IsPublish) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.IsPublish, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.IsPublish] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetPubDate(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, string strPubDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubDate, convcc_ExamPaperEduClsRela.PubDate);
clsCheckSql.CheckFieldLen(strPubDate, 14, convcc_ExamPaperEduClsRela.PubDate);
objvcc_ExamPaperEduClsRelaEN.PubDate = strPubDate; //发布日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.PubDate) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.PubDate, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.PubDate] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN Setpublisher(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, string strpublisher, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strpublisher, 20, convcc_ExamPaperEduClsRela.publisher);
objvcc_ExamPaperEduClsRelaEN.publisher = strpublisher; //发布者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.publisher) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.publisher, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.publisher] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetSpecifyCompletionDate(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, string strSpecifyCompletionDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSpecifyCompletionDate, convcc_ExamPaperEduClsRela.SpecifyCompletionDate);
clsCheckSql.CheckFieldLen(strSpecifyCompletionDate, 14, convcc_ExamPaperEduClsRela.SpecifyCompletionDate);
objvcc_ExamPaperEduClsRelaEN.SpecifyCompletionDate = strSpecifyCompletionDate; //指定完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.SpecifyCompletionDate) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.SpecifyCompletionDate, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.SpecifyCompletionDate] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetIsCurrEduCls(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, bool bolIsCurrEduCls, string strComparisonOp="")
	{
objvcc_ExamPaperEduClsRelaEN.IsCurrEduCls = bolIsCurrEduCls; //是否为教学班作业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.IsCurrEduCls) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.IsCurrEduCls, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.IsCurrEduCls] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetIsGroupWork(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, bool bolIsGroupWork, string strComparisonOp="")
	{
objvcc_ExamPaperEduClsRelaEN.IsGroupWork = bolIsGroupWork; //是否为小组作业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.IsGroupWork) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.IsGroupWork, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.IsGroupWork] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetCourseStudentGroupId(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, long lngCourseStudentGroupId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngCourseStudentGroupId, convcc_ExamPaperEduClsRela.CourseStudentGroupId);
objvcc_ExamPaperEduClsRelaEN.CourseStudentGroupId = lngCourseStudentGroupId; //学生分组表流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.CourseStudentGroupId) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.CourseStudentGroupId, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.CourseStudentGroupId] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetWorkTypeId(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, string strWorkTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkTypeId, convcc_ExamPaperEduClsRela.WorkTypeId);
clsCheckSql.CheckFieldLen(strWorkTypeId, 2, convcc_ExamPaperEduClsRela.WorkTypeId);
clsCheckSql.CheckFieldForeignKey(strWorkTypeId, 2, convcc_ExamPaperEduClsRela.WorkTypeId);
objvcc_ExamPaperEduClsRelaEN.WorkTypeId = strWorkTypeId; //作业类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.WorkTypeId) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.WorkTypeId, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.WorkTypeId] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetWorkTypeName(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, string strWorkTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkTypeName, convcc_ExamPaperEduClsRela.WorkTypeName);
clsCheckSql.CheckFieldLen(strWorkTypeName, 30, convcc_ExamPaperEduClsRela.WorkTypeName);
objvcc_ExamPaperEduClsRelaEN.WorkTypeName = strWorkTypeName; //作业类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.WorkTypeName) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.WorkTypeName, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.WorkTypeName] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetUpdDate(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_ExamPaperEduClsRela.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_ExamPaperEduClsRela.UpdDate);
objvcc_ExamPaperEduClsRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.UpdDate) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.UpdDate, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.UpdDate] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetUpdUserId(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_ExamPaperEduClsRela.UpdUserId);
objvcc_ExamPaperEduClsRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.UpdUserId) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.UpdUserId, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.UpdUserId] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetMemo(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_ExamPaperEduClsRela.Memo);
objvcc_ExamPaperEduClsRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.Memo) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.Memo, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.Memo] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetStuNum(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, int intStuNum, string strComparisonOp="")
	{
objvcc_ExamPaperEduClsRelaEN.StuNum = intStuNum; //学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.StuNum) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.StuNum, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.StuNum] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperEduClsRelaEN SetEduClsStuNum(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN, int intEduClsStuNum, string strComparisonOp="")
	{
objvcc_ExamPaperEduClsRelaEN.EduClsStuNum = intEduClsStuNum; //教学班学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperEduClsRela.EduClsStuNum) == false)
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperEduClsRela.EduClsStuNum, strComparisonOp);
}
else
{
objvcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[convcc_ExamPaperEduClsRela.EduClsStuNum] = strComparisonOp;
}
}
return objvcc_ExamPaperEduClsRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRela_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.Id_ExamPaperEduClsRela) == true)
{
string strComparisonOp_Id_ExamPaperEduClsRela = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.Id_ExamPaperEduClsRela];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperEduClsRela.Id_ExamPaperEduClsRela, objvcc_ExamPaperEduClsRela_Cond.Id_ExamPaperEduClsRela, strComparisonOp_Id_ExamPaperEduClsRela);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.CourseExamPaperId) == true)
{
string strComparisonOp_CourseExamPaperId = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela.CourseExamPaperId, objvcc_ExamPaperEduClsRela_Cond.CourseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela.CourseId, objvcc_ExamPaperEduClsRela_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela.CourseName, objvcc_ExamPaperEduClsRela_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.ExamPaperName) == true)
{
string strComparisonOp_ExamPaperName = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.ExamPaperName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela.ExamPaperName, objvcc_ExamPaperEduClsRela_Cond.ExamPaperName, strComparisonOp_ExamPaperName);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.PaperIndex) == true)
{
string strComparisonOp_PaperIndex = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.PaperIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperEduClsRela.PaperIndex, objvcc_ExamPaperEduClsRela_Cond.PaperIndex, strComparisonOp_PaperIndex);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.ExamPaperTypeId) == true)
{
string strComparisonOp_ExamPaperTypeId = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.ExamPaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela.ExamPaperTypeId, objvcc_ExamPaperEduClsRela_Cond.ExamPaperTypeId, strComparisonOp_ExamPaperTypeId);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.ExamPaperTypeName) == true)
{
string strComparisonOp_ExamPaperTypeName = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.ExamPaperTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela.ExamPaperTypeName, objvcc_ExamPaperEduClsRela_Cond.ExamPaperTypeName, strComparisonOp_ExamPaperTypeName);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.IsShow) == true)
{
if (objvcc_ExamPaperEduClsRela_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperEduClsRela.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperEduClsRela.IsShow);
}
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.TotalScore) == true)
{
string strComparisonOp_TotalScore = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.TotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperEduClsRela.TotalScore, objvcc_ExamPaperEduClsRela_Cond.TotalScore, strComparisonOp_TotalScore);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperEduClsRela.ViewCount, objvcc_ExamPaperEduClsRela_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.DoneNumber) == true)
{
string strComparisonOp_DoneNumber = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.DoneNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperEduClsRela.DoneNumber, objvcc_ExamPaperEduClsRela_Cond.DoneNumber, strComparisonOp_DoneNumber);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.PaperTime) == true)
{
string strComparisonOp_PaperTime = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.PaperTime];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperEduClsRela.PaperTime, objvcc_ExamPaperEduClsRela_Cond.PaperTime, strComparisonOp_PaperTime);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.PaperDispModeName) == true)
{
string strComparisonOp_PaperDispModeName = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.PaperDispModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela.PaperDispModeName, objvcc_ExamPaperEduClsRela_Cond.PaperDispModeName, strComparisonOp_PaperDispModeName);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.ExamCreateTime) == true)
{
string strComparisonOp_ExamCreateTime = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.ExamCreateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela.ExamCreateTime, objvcc_ExamPaperEduClsRela_Cond.ExamCreateTime, strComparisonOp_ExamCreateTime);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.UserName) == true)
{
string strComparisonOp_UserName = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela.UserName, objvcc_ExamPaperEduClsRela_Cond.UserName, strComparisonOp_UserName);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela.CourseChapterId, objvcc_ExamPaperEduClsRela_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela.CourseChapterName, objvcc_ExamPaperEduClsRela_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.ChapterId) == true)
{
string strComparisonOp_ChapterId = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela.ChapterId, objvcc_ExamPaperEduClsRela_Cond.ChapterId, strComparisonOp_ChapterId);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.SectionId) == true)
{
string strComparisonOp_SectionId = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela.SectionId, objvcc_ExamPaperEduClsRela_Cond.SectionId, strComparisonOp_SectionId);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela.ChapterName, objvcc_ExamPaperEduClsRela_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.SectionName) == true)
{
string strComparisonOp_SectionName = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela.SectionName, objvcc_ExamPaperEduClsRela_Cond.SectionName, strComparisonOp_SectionName);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela.ChapterName_Sim, objvcc_ExamPaperEduClsRela_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela.SectionName_Sim, objvcc_ExamPaperEduClsRela_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.IsAutoGeneQuestion) == true)
{
if (objvcc_ExamPaperEduClsRela_Cond.IsAutoGeneQuestion == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperEduClsRela.IsAutoGeneQuestion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperEduClsRela.IsAutoGeneQuestion);
}
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.IsCanMultiDo) == true)
{
if (objvcc_ExamPaperEduClsRela_Cond.IsCanMultiDo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperEduClsRela.IsCanMultiDo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperEduClsRela.IsCanMultiDo);
}
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.QuestionNum) == true)
{
string strComparisonOp_QuestionNum = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.QuestionNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperEduClsRela.QuestionNum, objvcc_ExamPaperEduClsRela_Cond.QuestionNum, strComparisonOp_QuestionNum);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela.id_CurrEduCls, objvcc_ExamPaperEduClsRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.CurrEduClsId) == true)
{
string strComparisonOp_CurrEduClsId = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela.CurrEduClsId, objvcc_ExamPaperEduClsRela_Cond.CurrEduClsId, strComparisonOp_CurrEduClsId);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.EduClsName) == true)
{
string strComparisonOp_EduClsName = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela.EduClsName, objvcc_ExamPaperEduClsRela_Cond.EduClsName, strComparisonOp_EduClsName);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.Scores) == true)
{
string strComparisonOp_Scores = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.Scores];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperEduClsRela.Scores, objvcc_ExamPaperEduClsRela_Cond.Scores, strComparisonOp_Scores);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.TeacherID) == true)
{
string strComparisonOp_TeacherID = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela.TeacherID, objvcc_ExamPaperEduClsRela_Cond.TeacherID, strComparisonOp_TeacherID);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.IsPublish) == true)
{
if (objvcc_ExamPaperEduClsRela_Cond.IsPublish == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperEduClsRela.IsPublish);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperEduClsRela.IsPublish);
}
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.PubDate) == true)
{
string strComparisonOp_PubDate = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.PubDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela.PubDate, objvcc_ExamPaperEduClsRela_Cond.PubDate, strComparisonOp_PubDate);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.publisher) == true)
{
string strComparisonOp_publisher = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.publisher];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela.publisher, objvcc_ExamPaperEduClsRela_Cond.publisher, strComparisonOp_publisher);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.SpecifyCompletionDate) == true)
{
string strComparisonOp_SpecifyCompletionDate = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.SpecifyCompletionDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela.SpecifyCompletionDate, objvcc_ExamPaperEduClsRela_Cond.SpecifyCompletionDate, strComparisonOp_SpecifyCompletionDate);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.IsCurrEduCls) == true)
{
if (objvcc_ExamPaperEduClsRela_Cond.IsCurrEduCls == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperEduClsRela.IsCurrEduCls);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperEduClsRela.IsCurrEduCls);
}
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.IsGroupWork) == true)
{
if (objvcc_ExamPaperEduClsRela_Cond.IsGroupWork == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperEduClsRela.IsGroupWork);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperEduClsRela.IsGroupWork);
}
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.CourseStudentGroupId) == true)
{
string strComparisonOp_CourseStudentGroupId = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.CourseStudentGroupId];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperEduClsRela.CourseStudentGroupId, objvcc_ExamPaperEduClsRela_Cond.CourseStudentGroupId, strComparisonOp_CourseStudentGroupId);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.WorkTypeId) == true)
{
string strComparisonOp_WorkTypeId = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.WorkTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela.WorkTypeId, objvcc_ExamPaperEduClsRela_Cond.WorkTypeId, strComparisonOp_WorkTypeId);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.WorkTypeName) == true)
{
string strComparisonOp_WorkTypeName = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.WorkTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela.WorkTypeName, objvcc_ExamPaperEduClsRela_Cond.WorkTypeName, strComparisonOp_WorkTypeName);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela.UpdDate, objvcc_ExamPaperEduClsRela_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela.UpdUserId, objvcc_ExamPaperEduClsRela_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.Memo) == true)
{
string strComparisonOp_Memo = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperEduClsRela.Memo, objvcc_ExamPaperEduClsRela_Cond.Memo, strComparisonOp_Memo);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.StuNum) == true)
{
string strComparisonOp_StuNum = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.StuNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperEduClsRela.StuNum, objvcc_ExamPaperEduClsRela_Cond.StuNum, strComparisonOp_StuNum);
}
if (objvcc_ExamPaperEduClsRela_Cond.IsUpdated(convcc_ExamPaperEduClsRela.EduClsStuNum) == true)
{
string strComparisonOp_EduClsStuNum = objvcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[convcc_ExamPaperEduClsRela.EduClsStuNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperEduClsRela.EduClsStuNum, objvcc_ExamPaperEduClsRela_Cond.EduClsStuNum, strComparisonOp_EduClsStuNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v考卷教学班关系(vcc_ExamPaperEduClsRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_ExamPaperEduClsRelaWApi
{
private static readonly string mstrApiControllerName = "vcc_ExamPaperEduClsRelaApi";

 public clsvcc_ExamPaperEduClsRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_ExamPaperEduClsRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_ExamPaperEduClsRelaEN GetObjById_ExamPaperEduClsRela(long lngId_ExamPaperEduClsRela)
{
string strAction = "GetObjById_ExamPaperEduClsRela";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN = null;
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
objvcc_ExamPaperEduClsRelaEN = JsonConvert.DeserializeObject<clsvcc_ExamPaperEduClsRelaEN>((string)jobjReturn["ReturnObj"]);
return objvcc_ExamPaperEduClsRelaEN;
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
public static clsvcc_ExamPaperEduClsRelaEN GetObjById_ExamPaperEduClsRela_WA_Cache(long lngId_ExamPaperEduClsRela)
{
string strAction = "GetObjById_ExamPaperEduClsRela_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN = null;
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
objvcc_ExamPaperEduClsRelaEN = JsonConvert.DeserializeObject<clsvcc_ExamPaperEduClsRelaEN>((string)jobjReturn["ReturnObj"]);
return objvcc_ExamPaperEduClsRelaEN;
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
public static clsvcc_ExamPaperEduClsRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaEN = null;
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
objvcc_ExamPaperEduClsRelaEN = JsonConvert.DeserializeObject<clsvcc_ExamPaperEduClsRelaEN>((string)jobjReturn["ReturnObj"]);
return objvcc_ExamPaperEduClsRelaEN;
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
public static clsvcc_ExamPaperEduClsRelaEN GetObjById_ExamPaperEduClsRela_Cache(long lngId_ExamPaperEduClsRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_ExamPaperEduClsRelaEN._CurrTabName_S);
List<clsvcc_ExamPaperEduClsRelaEN> arrvcc_ExamPaperEduClsRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_ExamPaperEduClsRelaEN> arrvcc_ExamPaperEduClsRelaObjLst_Sel =
from objvcc_ExamPaperEduClsRelaEN in arrvcc_ExamPaperEduClsRelaObjLst_Cache
where objvcc_ExamPaperEduClsRelaEN.Id_ExamPaperEduClsRela == lngId_ExamPaperEduClsRela
select objvcc_ExamPaperEduClsRelaEN;
if (arrvcc_ExamPaperEduClsRelaObjLst_Sel.Count() == 0)
{
   clsvcc_ExamPaperEduClsRelaEN obj = clsvcc_ExamPaperEduClsRelaWApi.GetObjById_ExamPaperEduClsRela(lngId_ExamPaperEduClsRela);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_ExamPaperEduClsRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_ExamPaperEduClsRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_ExamPaperEduClsRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperEduClsRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperEduClsRelaEN> GetObjLstById_ExamPaperEduClsRelaLst(List<long> arrId_ExamPaperEduClsRela)
{
 List<clsvcc_ExamPaperEduClsRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperEduClsRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvcc_ExamPaperEduClsRelaEN> GetObjLstById_ExamPaperEduClsRelaLst_Cache(List<long> arrId_ExamPaperEduClsRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_ExamPaperEduClsRelaEN._CurrTabName_S);
List<clsvcc_ExamPaperEduClsRelaEN> arrvcc_ExamPaperEduClsRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_ExamPaperEduClsRelaEN> arrvcc_ExamPaperEduClsRelaObjLst_Sel =
from objvcc_ExamPaperEduClsRelaEN in arrvcc_ExamPaperEduClsRelaObjLst_Cache
where arrId_ExamPaperEduClsRela.Contains(objvcc_ExamPaperEduClsRelaEN.Id_ExamPaperEduClsRela)
select objvcc_ExamPaperEduClsRelaEN;
return arrvcc_ExamPaperEduClsRelaObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_ExamPaperEduClsRelaEN> GetObjLstById_ExamPaperEduClsRelaLst_WA_Cache(List<long> arrId_ExamPaperEduClsRela)
{
 List<clsvcc_ExamPaperEduClsRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperEduClsRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperEduClsRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_ExamPaperEduClsRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperEduClsRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperEduClsRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_ExamPaperEduClsRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperEduClsRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperEduClsRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_ExamPaperEduClsRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperEduClsRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperEduClsRelaEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_ExamPaperEduClsRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperEduClsRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvcc_ExamPaperEduClsRelaENS">源对象</param>
 /// <param name = "objvcc_ExamPaperEduClsRelaENT">目标对象</param>
 public static void CopyTo(clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaENS, clsvcc_ExamPaperEduClsRelaEN objvcc_ExamPaperEduClsRelaENT)
{
try
{
objvcc_ExamPaperEduClsRelaENT.Id_ExamPaperEduClsRela = objvcc_ExamPaperEduClsRelaENS.Id_ExamPaperEduClsRela; //作业教学班关系流水号
objvcc_ExamPaperEduClsRelaENT.CourseExamPaperId = objvcc_ExamPaperEduClsRelaENS.CourseExamPaperId; //考卷流水号
objvcc_ExamPaperEduClsRelaENT.CourseId = objvcc_ExamPaperEduClsRelaENS.CourseId; //课程Id
objvcc_ExamPaperEduClsRelaENT.CourseName = objvcc_ExamPaperEduClsRelaENS.CourseName; //课程名称
objvcc_ExamPaperEduClsRelaENT.ExamPaperName = objvcc_ExamPaperEduClsRelaENS.ExamPaperName; //考卷名称
objvcc_ExamPaperEduClsRelaENT.PaperIndex = objvcc_ExamPaperEduClsRelaENS.PaperIndex; //试卷序号
objvcc_ExamPaperEduClsRelaENT.ExamPaperTypeId = objvcc_ExamPaperEduClsRelaENS.ExamPaperTypeId; //试卷类型Id
objvcc_ExamPaperEduClsRelaENT.ExamPaperTypeName = objvcc_ExamPaperEduClsRelaENS.ExamPaperTypeName; //试卷类型名称
objvcc_ExamPaperEduClsRelaENT.IsShow = objvcc_ExamPaperEduClsRelaENS.IsShow; //是否启用
objvcc_ExamPaperEduClsRelaENT.TotalScore = objvcc_ExamPaperEduClsRelaENS.TotalScore; //总得分
objvcc_ExamPaperEduClsRelaENT.ViewCount = objvcc_ExamPaperEduClsRelaENS.ViewCount; //浏览量
objvcc_ExamPaperEduClsRelaENT.DoneNumber = objvcc_ExamPaperEduClsRelaENS.DoneNumber; //已做人数
objvcc_ExamPaperEduClsRelaENT.PaperTime = objvcc_ExamPaperEduClsRelaENS.PaperTime; //考试时间（分钟）
objvcc_ExamPaperEduClsRelaENT.PaperDispModeName = objvcc_ExamPaperEduClsRelaENS.PaperDispModeName; //试卷显示模式名称
objvcc_ExamPaperEduClsRelaENT.ExamCreateTime = objvcc_ExamPaperEduClsRelaENS.ExamCreateTime; //考卷建立时间
objvcc_ExamPaperEduClsRelaENT.UserName = objvcc_ExamPaperEduClsRelaENS.UserName; //用户名
objvcc_ExamPaperEduClsRelaENT.CourseChapterId = objvcc_ExamPaperEduClsRelaENS.CourseChapterId; //课程章节ID
objvcc_ExamPaperEduClsRelaENT.CourseChapterName = objvcc_ExamPaperEduClsRelaENS.CourseChapterName; //课程章节名称
objvcc_ExamPaperEduClsRelaENT.ChapterId = objvcc_ExamPaperEduClsRelaENS.ChapterId; //章Id
objvcc_ExamPaperEduClsRelaENT.SectionId = objvcc_ExamPaperEduClsRelaENS.SectionId; //节Id
objvcc_ExamPaperEduClsRelaENT.ChapterName = objvcc_ExamPaperEduClsRelaENS.ChapterName; //章名
objvcc_ExamPaperEduClsRelaENT.SectionName = objvcc_ExamPaperEduClsRelaENS.SectionName; //节名
objvcc_ExamPaperEduClsRelaENT.ChapterName_Sim = objvcc_ExamPaperEduClsRelaENS.ChapterName_Sim; //章名简称
objvcc_ExamPaperEduClsRelaENT.SectionName_Sim = objvcc_ExamPaperEduClsRelaENS.SectionName_Sim; //节名简称
objvcc_ExamPaperEduClsRelaENT.IsAutoGeneQuestion = objvcc_ExamPaperEduClsRelaENS.IsAutoGeneQuestion; //是否自动生成题目
objvcc_ExamPaperEduClsRelaENT.IsCanMultiDo = objvcc_ExamPaperEduClsRelaENS.IsCanMultiDo; //是否可以做多次
objvcc_ExamPaperEduClsRelaENT.QuestionNum = objvcc_ExamPaperEduClsRelaENS.QuestionNum; //题目数
objvcc_ExamPaperEduClsRelaENT.id_CurrEduCls = objvcc_ExamPaperEduClsRelaENS.id_CurrEduCls; //当前教学班流水号
objvcc_ExamPaperEduClsRelaENT.CurrEduClsId = objvcc_ExamPaperEduClsRelaENS.CurrEduClsId; //当前教学班Id
objvcc_ExamPaperEduClsRelaENT.EduClsName = objvcc_ExamPaperEduClsRelaENS.EduClsName; //教学班名称
objvcc_ExamPaperEduClsRelaENT.Scores = objvcc_ExamPaperEduClsRelaENS.Scores; //分值
objvcc_ExamPaperEduClsRelaENT.TeacherID = objvcc_ExamPaperEduClsRelaENS.TeacherID; //教师工号
objvcc_ExamPaperEduClsRelaENT.IsPublish = objvcc_ExamPaperEduClsRelaENS.IsPublish; //是否发布
objvcc_ExamPaperEduClsRelaENT.PubDate = objvcc_ExamPaperEduClsRelaENS.PubDate; //发布日期
objvcc_ExamPaperEduClsRelaENT.publisher = objvcc_ExamPaperEduClsRelaENS.publisher; //发布者Id
objvcc_ExamPaperEduClsRelaENT.SpecifyCompletionDate = objvcc_ExamPaperEduClsRelaENS.SpecifyCompletionDate; //指定完成日期
objvcc_ExamPaperEduClsRelaENT.IsCurrEduCls = objvcc_ExamPaperEduClsRelaENS.IsCurrEduCls; //是否为教学班作业
objvcc_ExamPaperEduClsRelaENT.IsGroupWork = objvcc_ExamPaperEduClsRelaENS.IsGroupWork; //是否为小组作业
objvcc_ExamPaperEduClsRelaENT.CourseStudentGroupId = objvcc_ExamPaperEduClsRelaENS.CourseStudentGroupId; //学生分组表流水号
objvcc_ExamPaperEduClsRelaENT.WorkTypeId = objvcc_ExamPaperEduClsRelaENS.WorkTypeId; //作业类型Id
objvcc_ExamPaperEduClsRelaENT.WorkTypeName = objvcc_ExamPaperEduClsRelaENS.WorkTypeName; //作业类型名称
objvcc_ExamPaperEduClsRelaENT.UpdDate = objvcc_ExamPaperEduClsRelaENS.UpdDate; //修改日期
objvcc_ExamPaperEduClsRelaENT.UpdUserId = objvcc_ExamPaperEduClsRelaENS.UpdUserId; //修改用户Id
objvcc_ExamPaperEduClsRelaENT.Memo = objvcc_ExamPaperEduClsRelaENS.Memo; //备注
objvcc_ExamPaperEduClsRelaENT.StuNum = objvcc_ExamPaperEduClsRelaENS.StuNum; //学生数
objvcc_ExamPaperEduClsRelaENT.EduClsStuNum = objvcc_ExamPaperEduClsRelaENS.EduClsStuNum; //教学班学生数
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
public static DataTable ToDataTable(List<clsvcc_ExamPaperEduClsRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_ExamPaperEduClsRelaEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_ExamPaperEduClsRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_ExamPaperEduClsRelaEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_ExamPaperEduClsRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_ExamPaperEduClsRelaEN.AttributeName)
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
//if (arrvcc_ExamPaperEduClsRelaObjLst_Cache == null)
//{
//arrvcc_ExamPaperEduClsRelaObjLst_Cache = await clsvcc_ExamPaperEduClsRelaWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvcc_ExamPaperEduClsRelaEN._CurrTabName_S);
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
public static List<clsvcc_ExamPaperEduClsRelaEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvcc_ExamPaperEduClsRelaEN._CurrTabName_S);
List<clsvcc_ExamPaperEduClsRelaEN> arrvcc_ExamPaperEduClsRelaObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_ExamPaperEduClsRelaObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_ExamPaperEduClsRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_ExamPaperEduClsRela.Id_ExamPaperEduClsRela, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.CourseExamPaperId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.ExamPaperName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.PaperIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.ExamPaperTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.ExamPaperTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.TotalScore, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.DoneNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.PaperTime, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.PaperDispModeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.ExamCreateTime, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.ChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.SectionId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.SectionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.IsAutoGeneQuestion, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.IsCanMultiDo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.QuestionNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.CurrEduClsId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.EduClsName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.Scores, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.TeacherID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.IsPublish, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.PubDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.publisher, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.SpecifyCompletionDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.IsCurrEduCls, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.IsGroupWork, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.CourseStudentGroupId, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.WorkTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.WorkTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.StuNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperEduClsRela.EduClsStuNum, Type.GetType("System.Int32"));
foreach (clsvcc_ExamPaperEduClsRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_ExamPaperEduClsRela.Id_ExamPaperEduClsRela] = objInFor[convcc_ExamPaperEduClsRela.Id_ExamPaperEduClsRela];
objDR[convcc_ExamPaperEduClsRela.CourseExamPaperId] = objInFor[convcc_ExamPaperEduClsRela.CourseExamPaperId];
objDR[convcc_ExamPaperEduClsRela.CourseId] = objInFor[convcc_ExamPaperEduClsRela.CourseId];
objDR[convcc_ExamPaperEduClsRela.CourseName] = objInFor[convcc_ExamPaperEduClsRela.CourseName];
objDR[convcc_ExamPaperEduClsRela.ExamPaperName] = objInFor[convcc_ExamPaperEduClsRela.ExamPaperName];
objDR[convcc_ExamPaperEduClsRela.PaperIndex] = objInFor[convcc_ExamPaperEduClsRela.PaperIndex];
objDR[convcc_ExamPaperEduClsRela.ExamPaperTypeId] = objInFor[convcc_ExamPaperEduClsRela.ExamPaperTypeId];
objDR[convcc_ExamPaperEduClsRela.ExamPaperTypeName] = objInFor[convcc_ExamPaperEduClsRela.ExamPaperTypeName];
objDR[convcc_ExamPaperEduClsRela.IsShow] = objInFor[convcc_ExamPaperEduClsRela.IsShow];
objDR[convcc_ExamPaperEduClsRela.TotalScore] = objInFor[convcc_ExamPaperEduClsRela.TotalScore];
objDR[convcc_ExamPaperEduClsRela.ViewCount] = objInFor[convcc_ExamPaperEduClsRela.ViewCount];
objDR[convcc_ExamPaperEduClsRela.DoneNumber] = objInFor[convcc_ExamPaperEduClsRela.DoneNumber];
objDR[convcc_ExamPaperEduClsRela.PaperTime] = objInFor[convcc_ExamPaperEduClsRela.PaperTime];
objDR[convcc_ExamPaperEduClsRela.PaperDispModeName] = objInFor[convcc_ExamPaperEduClsRela.PaperDispModeName];
objDR[convcc_ExamPaperEduClsRela.ExamCreateTime] = objInFor[convcc_ExamPaperEduClsRela.ExamCreateTime];
objDR[convcc_ExamPaperEduClsRela.UserName] = objInFor[convcc_ExamPaperEduClsRela.UserName];
objDR[convcc_ExamPaperEduClsRela.CourseChapterId] = objInFor[convcc_ExamPaperEduClsRela.CourseChapterId];
objDR[convcc_ExamPaperEduClsRela.CourseChapterName] = objInFor[convcc_ExamPaperEduClsRela.CourseChapterName];
objDR[convcc_ExamPaperEduClsRela.ChapterId] = objInFor[convcc_ExamPaperEduClsRela.ChapterId];
objDR[convcc_ExamPaperEduClsRela.SectionId] = objInFor[convcc_ExamPaperEduClsRela.SectionId];
objDR[convcc_ExamPaperEduClsRela.ChapterName] = objInFor[convcc_ExamPaperEduClsRela.ChapterName];
objDR[convcc_ExamPaperEduClsRela.SectionName] = objInFor[convcc_ExamPaperEduClsRela.SectionName];
objDR[convcc_ExamPaperEduClsRela.ChapterName_Sim] = objInFor[convcc_ExamPaperEduClsRela.ChapterName_Sim];
objDR[convcc_ExamPaperEduClsRela.SectionName_Sim] = objInFor[convcc_ExamPaperEduClsRela.SectionName_Sim];
objDR[convcc_ExamPaperEduClsRela.IsAutoGeneQuestion] = objInFor[convcc_ExamPaperEduClsRela.IsAutoGeneQuestion];
objDR[convcc_ExamPaperEduClsRela.IsCanMultiDo] = objInFor[convcc_ExamPaperEduClsRela.IsCanMultiDo];
objDR[convcc_ExamPaperEduClsRela.QuestionNum] = objInFor[convcc_ExamPaperEduClsRela.QuestionNum];
objDR[convcc_ExamPaperEduClsRela.id_CurrEduCls] = objInFor[convcc_ExamPaperEduClsRela.id_CurrEduCls];
objDR[convcc_ExamPaperEduClsRela.CurrEduClsId] = objInFor[convcc_ExamPaperEduClsRela.CurrEduClsId];
objDR[convcc_ExamPaperEduClsRela.EduClsName] = objInFor[convcc_ExamPaperEduClsRela.EduClsName];
objDR[convcc_ExamPaperEduClsRela.Scores] = objInFor[convcc_ExamPaperEduClsRela.Scores];
objDR[convcc_ExamPaperEduClsRela.TeacherID] = objInFor[convcc_ExamPaperEduClsRela.TeacherID];
objDR[convcc_ExamPaperEduClsRela.IsPublish] = objInFor[convcc_ExamPaperEduClsRela.IsPublish];
objDR[convcc_ExamPaperEduClsRela.PubDate] = objInFor[convcc_ExamPaperEduClsRela.PubDate];
objDR[convcc_ExamPaperEduClsRela.publisher] = objInFor[convcc_ExamPaperEduClsRela.publisher];
objDR[convcc_ExamPaperEduClsRela.SpecifyCompletionDate] = objInFor[convcc_ExamPaperEduClsRela.SpecifyCompletionDate];
objDR[convcc_ExamPaperEduClsRela.IsCurrEduCls] = objInFor[convcc_ExamPaperEduClsRela.IsCurrEduCls];
objDR[convcc_ExamPaperEduClsRela.IsGroupWork] = objInFor[convcc_ExamPaperEduClsRela.IsGroupWork];
objDR[convcc_ExamPaperEduClsRela.CourseStudentGroupId] = objInFor[convcc_ExamPaperEduClsRela.CourseStudentGroupId];
objDR[convcc_ExamPaperEduClsRela.WorkTypeId] = objInFor[convcc_ExamPaperEduClsRela.WorkTypeId];
objDR[convcc_ExamPaperEduClsRela.WorkTypeName] = objInFor[convcc_ExamPaperEduClsRela.WorkTypeName];
objDR[convcc_ExamPaperEduClsRela.UpdDate] = objInFor[convcc_ExamPaperEduClsRela.UpdDate];
objDR[convcc_ExamPaperEduClsRela.UpdUserId] = objInFor[convcc_ExamPaperEduClsRela.UpdUserId];
objDR[convcc_ExamPaperEduClsRela.Memo] = objInFor[convcc_ExamPaperEduClsRela.Memo];
objDR[convcc_ExamPaperEduClsRela.StuNum] = objInFor[convcc_ExamPaperEduClsRela.StuNum];
objDR[convcc_ExamPaperEduClsRela.EduClsStuNum] = objInFor[convcc_ExamPaperEduClsRela.EduClsStuNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}