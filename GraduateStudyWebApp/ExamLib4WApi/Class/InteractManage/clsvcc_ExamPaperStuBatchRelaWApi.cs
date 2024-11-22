
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_ExamPaperStuBatchRelaWApi
 表名:vcc_ExamPaperStuBatchRela(01120242)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:46:39
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
public static class clsvcc_ExamPaperStuBatchRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetId_PaperStuBatch(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strId_PaperStuBatch, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_PaperStuBatch, 10, convcc_ExamPaperStuBatchRela.Id_PaperStuBatch);
clsCheckSql.CheckFieldForeignKey(strId_PaperStuBatch, 10, convcc_ExamPaperStuBatchRela.Id_PaperStuBatch);
objvcc_ExamPaperStuBatchRelaEN.Id_PaperStuBatch = strId_PaperStuBatch; //学生试卷批次流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.Id_PaperStuBatch) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.Id_PaperStuBatch, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.Id_PaperStuBatch] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetCourseExamPaperId(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, convcc_ExamPaperStuBatchRela.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, convcc_ExamPaperStuBatchRela.CourseExamPaperId);
objvcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.CourseExamPaperId) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.CourseExamPaperId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.CourseExamPaperId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetCourseId(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_ExamPaperStuBatchRela.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_ExamPaperStuBatchRela.CourseId);
objvcc_ExamPaperStuBatchRelaEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.CourseId) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.CourseId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.CourseId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetCourseName(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_ExamPaperStuBatchRela.CourseName);
objvcc_ExamPaperStuBatchRelaEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.CourseName) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.CourseName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.CourseName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetExamPaperName(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strExamPaperName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamPaperName, 500, convcc_ExamPaperStuBatchRela.ExamPaperName);
objvcc_ExamPaperStuBatchRelaEN.ExamPaperName = strExamPaperName; //考卷名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.ExamPaperName) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.ExamPaperName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.ExamPaperName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetPaperIndex(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, int intPaperIndex, string strComparisonOp="")
	{
objvcc_ExamPaperStuBatchRelaEN.PaperIndex = intPaperIndex; //试卷序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.PaperIndex) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.PaperIndex, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.PaperIndex] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetExamPaperTypeId(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strExamPaperTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strExamPaperTypeId, convcc_ExamPaperStuBatchRela.ExamPaperTypeId);
clsCheckSql.CheckFieldLen(strExamPaperTypeId, 2, convcc_ExamPaperStuBatchRela.ExamPaperTypeId);
clsCheckSql.CheckFieldForeignKey(strExamPaperTypeId, 2, convcc_ExamPaperStuBatchRela.ExamPaperTypeId);
objvcc_ExamPaperStuBatchRelaEN.ExamPaperTypeId = strExamPaperTypeId; //试卷类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.ExamPaperTypeId) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.ExamPaperTypeId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.ExamPaperTypeId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetExamPaperTypeName(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strExamPaperTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strExamPaperTypeName, convcc_ExamPaperStuBatchRela.ExamPaperTypeName);
clsCheckSql.CheckFieldLen(strExamPaperTypeName, 30, convcc_ExamPaperStuBatchRela.ExamPaperTypeName);
objvcc_ExamPaperStuBatchRelaEN.ExamPaperTypeName = strExamPaperTypeName; //试卷类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.ExamPaperTypeName) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.ExamPaperTypeName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.ExamPaperTypeName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetIsShow(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, bool bolIsShow, string strComparisonOp="")
	{
objvcc_ExamPaperStuBatchRelaEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.IsShow) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.IsShow, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.IsShow] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetTotalScore(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, double dblTotalScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dblTotalScore, convcc_ExamPaperStuBatchRela.TotalScore);
objvcc_ExamPaperStuBatchRelaEN.TotalScore = dblTotalScore; //总得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.TotalScore) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.TotalScore, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.TotalScore] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetViewCount(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, int intViewCount, string strComparisonOp="")
	{
objvcc_ExamPaperStuBatchRelaEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.ViewCount) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.ViewCount, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.ViewCount] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetDoneNumber(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, int intDoneNumber, string strComparisonOp="")
	{
objvcc_ExamPaperStuBatchRelaEN.DoneNumber = intDoneNumber; //已做人数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.DoneNumber) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.DoneNumber, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.DoneNumber] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetPaperTime(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, int intPaperTime, string strComparisonOp="")
	{
objvcc_ExamPaperStuBatchRelaEN.PaperTime = intPaperTime; //考试时间（分钟）
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.PaperTime) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.PaperTime, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.PaperTime] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetPaperDispModeName(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strPaperDispModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperDispModeName, 30, convcc_ExamPaperStuBatchRela.PaperDispModeName);
objvcc_ExamPaperStuBatchRelaEN.PaperDispModeName = strPaperDispModeName; //试卷显示模式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.PaperDispModeName) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.PaperDispModeName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.PaperDispModeName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetExamCreateTime(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strExamCreateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamCreateTime, 14, convcc_ExamPaperStuBatchRela.ExamCreateTime);
objvcc_ExamPaperStuBatchRelaEN.ExamCreateTime = strExamCreateTime; //考卷建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.ExamCreateTime) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.ExamCreateTime, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.ExamCreateTime] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetUserName(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convcc_ExamPaperStuBatchRela.UserName);
objvcc_ExamPaperStuBatchRelaEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.UserName) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.UserName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.UserName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetCourseChapterId(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, convcc_ExamPaperStuBatchRela.CourseChapterId);
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_ExamPaperStuBatchRela.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_ExamPaperStuBatchRela.CourseChapterId);
objvcc_ExamPaperStuBatchRelaEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.CourseChapterId) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.CourseChapterId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.CourseChapterId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetCourseChapterName(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterName, convcc_ExamPaperStuBatchRela.CourseChapterName);
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_ExamPaperStuBatchRela.CourseChapterName);
objvcc_ExamPaperStuBatchRelaEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.CourseChapterName) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.CourseChapterName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.CourseChapterName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetChapterId(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterId, 8, convcc_ExamPaperStuBatchRela.ChapterId);
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convcc_ExamPaperStuBatchRela.ChapterId);
objvcc_ExamPaperStuBatchRelaEN.ChapterId = strChapterId; //章Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.ChapterId) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.ChapterId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.ChapterId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetSectionId(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strSectionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionId, 8, convcc_ExamPaperStuBatchRela.SectionId);
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convcc_ExamPaperStuBatchRela.SectionId);
objvcc_ExamPaperStuBatchRelaEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.SectionId) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.SectionId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.SectionId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetChapterName(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_ExamPaperStuBatchRela.ChapterName);
objvcc_ExamPaperStuBatchRelaEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.ChapterName) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.ChapterName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.ChapterName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetSectionName(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_ExamPaperStuBatchRela.SectionName);
objvcc_ExamPaperStuBatchRelaEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.SectionName) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.SectionName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.SectionName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetChapterName_Sim(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convcc_ExamPaperStuBatchRela.ChapterName_Sim);
objvcc_ExamPaperStuBatchRelaEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.ChapterName_Sim) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.ChapterName_Sim, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.ChapterName_Sim] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetSectionName_Sim(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, convcc_ExamPaperStuBatchRela.SectionName_Sim);
objvcc_ExamPaperStuBatchRelaEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.SectionName_Sim) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.SectionName_Sim, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.SectionName_Sim] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetIsAutoGeneQuestion(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, bool bolIsAutoGeneQuestion, string strComparisonOp="")
	{
objvcc_ExamPaperStuBatchRelaEN.IsAutoGeneQuestion = bolIsAutoGeneQuestion; //是否自动生成题目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.IsAutoGeneQuestion) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.IsAutoGeneQuestion, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.IsAutoGeneQuestion] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetIsCanMultiDo(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, bool bolIsCanMultiDo, string strComparisonOp="")
	{
objvcc_ExamPaperStuBatchRelaEN.IsCanMultiDo = bolIsCanMultiDo; //是否可以做多次
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.IsCanMultiDo) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.IsCanMultiDo, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.IsCanMultiDo] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetQuestionNum(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, int intQuestionNum, string strComparisonOp="")
	{
objvcc_ExamPaperStuBatchRelaEN.QuestionNum = intQuestionNum; //题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.QuestionNum) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.QuestionNum, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.QuestionNum] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN Setid_StudentInfo(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudentInfo, convcc_ExamPaperStuBatchRela.id_StudentInfo);
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, convcc_ExamPaperStuBatchRela.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, convcc_ExamPaperStuBatchRela.id_StudentInfo);
objvcc_ExamPaperStuBatchRelaEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.id_StudentInfo) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.id_StudentInfo, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.id_StudentInfo] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetStuID(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convcc_ExamPaperStuBatchRela.StuID);
objvcc_ExamPaperStuBatchRelaEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.StuID) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.StuID, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.StuID] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetStuName(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convcc_ExamPaperStuBatchRela.StuName);
objvcc_ExamPaperStuBatchRelaEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.StuName) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.StuName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.StuName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetSexDesc(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strSexDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convcc_ExamPaperStuBatchRela.SexDesc);
objvcc_ExamPaperStuBatchRelaEN.SexDesc = strSexDesc; //性别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.SexDesc) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.SexDesc, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.SexDesc] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN Setid_XzCollege(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convcc_ExamPaperStuBatchRela.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convcc_ExamPaperStuBatchRela.id_XzCollege);
objvcc_ExamPaperStuBatchRelaEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.id_XzCollege) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.id_XzCollege, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.id_XzCollege] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetCollegeName(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convcc_ExamPaperStuBatchRela.CollegeName);
objvcc_ExamPaperStuBatchRelaEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.CollegeName) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.CollegeName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.CollegeName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetCollegeNameA(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convcc_ExamPaperStuBatchRela.CollegeNameA);
objvcc_ExamPaperStuBatchRelaEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.CollegeNameA) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.CollegeNameA, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.CollegeNameA] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN Setid_XzMajor(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convcc_ExamPaperStuBatchRela.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convcc_ExamPaperStuBatchRela.id_XzMajor);
objvcc_ExamPaperStuBatchRelaEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.id_XzMajor) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.id_XzMajor, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.id_XzMajor] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetMajorID(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convcc_ExamPaperStuBatchRela.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convcc_ExamPaperStuBatchRela.MajorID);
objvcc_ExamPaperStuBatchRelaEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.MajorID) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.MajorID, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.MajorID] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetMajorName(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convcc_ExamPaperStuBatchRela.MajorName);
objvcc_ExamPaperStuBatchRelaEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.MajorName) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.MajorName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.MajorName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN Setid_GradeBase(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convcc_ExamPaperStuBatchRela.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convcc_ExamPaperStuBatchRela.id_GradeBase);
objvcc_ExamPaperStuBatchRelaEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.id_GradeBase) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.id_GradeBase, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.id_GradeBase] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetGradeBaseName(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convcc_ExamPaperStuBatchRela.GradeBaseName);
objvcc_ExamPaperStuBatchRelaEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.GradeBaseName) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.GradeBaseName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.GradeBaseName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetAdminClsName(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strAdminClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, convcc_ExamPaperStuBatchRela.AdminClsName);
objvcc_ExamPaperStuBatchRelaEN.AdminClsName = strAdminClsName; //行政班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.AdminClsName) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.AdminClsName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.AdminClsName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetAdminClsId(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strAdminClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, convcc_ExamPaperStuBatchRela.AdminClsId);
objvcc_ExamPaperStuBatchRelaEN.AdminClsId = strAdminClsId; //行政班代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.AdminClsId) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.AdminClsId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.AdminClsId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetBatchTime(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strBatchTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBatchTime, 14, convcc_ExamPaperStuBatchRela.BatchTime);
objvcc_ExamPaperStuBatchRelaEN.BatchTime = strBatchTime; //批次
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.BatchTime) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.BatchTime, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.BatchTime] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN Setid_CurrEduCls(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CurrEduCls, convcc_ExamPaperStuBatchRela.id_CurrEduCls);
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convcc_ExamPaperStuBatchRela.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convcc_ExamPaperStuBatchRela.id_CurrEduCls);
objvcc_ExamPaperStuBatchRelaEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.id_CurrEduCls) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.id_CurrEduCls, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.id_CurrEduCls] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetCurrEduClsId(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strCurrEduClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, convcc_ExamPaperStuBatchRela.CurrEduClsId);
objvcc_ExamPaperStuBatchRelaEN.CurrEduClsId = strCurrEduClsId; //当前教学班Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.CurrEduClsId) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.CurrEduClsId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.CurrEduClsId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetEduClsName(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduClsName, convcc_ExamPaperStuBatchRela.EduClsName);
clsCheckSql.CheckFieldLen(strEduClsName, 100, convcc_ExamPaperStuBatchRela.EduClsName);
objvcc_ExamPaperStuBatchRelaEN.EduClsName = strEduClsName; //教学班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.EduClsName) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.EduClsName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.EduClsName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetScores(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, double dblScores, string strComparisonOp="")
	{
objvcc_ExamPaperStuBatchRelaEN.Scores = dblScores; //分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.Scores) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.Scores, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.Scores] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetIsSave(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, bool bolIsSave, string strComparisonOp="")
	{
objvcc_ExamPaperStuBatchRelaEN.IsSave = bolIsSave; //是否保存
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.IsSave) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.IsSave, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.IsSave] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetIsSubmit(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvcc_ExamPaperStuBatchRelaEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.IsSubmit) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.IsSubmit, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.IsSubmit] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetRealFinishDate(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strRealFinishDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRealFinishDate, 14, convcc_ExamPaperStuBatchRela.RealFinishDate);
objvcc_ExamPaperStuBatchRelaEN.RealFinishDate = strRealFinishDate; //实际完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.RealFinishDate) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.RealFinishDate, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.RealFinishDate] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetOperateTime(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strOperateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOperateTime, 14, convcc_ExamPaperStuBatchRela.OperateTime);
objvcc_ExamPaperStuBatchRelaEN.OperateTime = strOperateTime; //操作时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.OperateTime) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.OperateTime, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.OperateTime] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetIsMarking(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, bool bolIsMarking, string strComparisonOp="")
	{
objvcc_ExamPaperStuBatchRelaEN.IsMarking = bolIsMarking; //是否批阅
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.IsMarking) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.IsMarking, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.IsMarking] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetMarkerId(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strMarkerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkerId, 20, convcc_ExamPaperStuBatchRela.MarkerId);
objvcc_ExamPaperStuBatchRelaEN.MarkerId = strMarkerId; //打分者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.MarkerId) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.MarkerId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.MarkerId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetMarkDate(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strMarkDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkDate, 14, convcc_ExamPaperStuBatchRela.MarkDate);
objvcc_ExamPaperStuBatchRelaEN.MarkDate = strMarkDate; //打分日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.MarkDate) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.MarkDate, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.MarkDate] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetAnswerIP(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strAnswerIP, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerIP, 30, convcc_ExamPaperStuBatchRela.AnswerIP);
objvcc_ExamPaperStuBatchRelaEN.AnswerIP = strAnswerIP; //回答IP
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.AnswerIP) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.AnswerIP, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.AnswerIP] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetAnswerDate(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strAnswerDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerDate, 8, convcc_ExamPaperStuBatchRela.AnswerDate);
objvcc_ExamPaperStuBatchRelaEN.AnswerDate = strAnswerDate; //回答日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.AnswerDate) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.AnswerDate, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.AnswerDate] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetAnswerTime(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strAnswerTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTime, 10, convcc_ExamPaperStuBatchRela.AnswerTime);
objvcc_ExamPaperStuBatchRelaEN.AnswerTime = strAnswerTime; //回答时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.AnswerTime) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.AnswerTime, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.AnswerTime] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetTotalGetScore(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, double dblTotalGetScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dblTotalGetScore, convcc_ExamPaperStuBatchRela.TotalGetScore);
objvcc_ExamPaperStuBatchRelaEN.TotalGetScore = dblTotalGetScore; //考生获取总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.TotalGetScore) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.TotalGetScore, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.TotalGetScore] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetUpdDate(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_ExamPaperStuBatchRela.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_ExamPaperStuBatchRela.UpdDate);
objvcc_ExamPaperStuBatchRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.UpdDate) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.UpdDate, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.UpdDate] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetUpdUserId(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_ExamPaperStuBatchRela.UpdUserId);
objvcc_ExamPaperStuBatchRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.UpdUserId) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.UpdUserId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.UpdUserId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetMemo(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_ExamPaperStuBatchRela.Memo);
objvcc_ExamPaperStuBatchRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.Memo) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.Memo, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.Memo] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetNoSubmitQuesNum(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, int intNoSubmitQuesNum, string strComparisonOp="")
	{
objvcc_ExamPaperStuBatchRelaEN.NoSubmitQuesNum = intNoSubmitQuesNum; //未提交题数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.NoSubmitQuesNum) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.NoSubmitQuesNum, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.NoSubmitQuesNum] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetSubmitQuesNum(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, int intSubmitQuesNum, string strComparisonOp="")
	{
objvcc_ExamPaperStuBatchRelaEN.SubmitQuesNum = intSubmitQuesNum; //提交题数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.SubmitQuesNum) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.SubmitQuesNum, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.SubmitQuesNum] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRela_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.Id_PaperStuBatch) == true)
{
string strComparisonOp_Id_PaperStuBatch = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.Id_PaperStuBatch];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.Id_PaperStuBatch, objvcc_ExamPaperStuBatchRela_Cond.Id_PaperStuBatch, strComparisonOp_Id_PaperStuBatch);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.CourseExamPaperId) == true)
{
string strComparisonOp_CourseExamPaperId = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.CourseExamPaperId, objvcc_ExamPaperStuBatchRela_Cond.CourseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.CourseId, objvcc_ExamPaperStuBatchRela_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.CourseName, objvcc_ExamPaperStuBatchRela_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.ExamPaperName) == true)
{
string strComparisonOp_ExamPaperName = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.ExamPaperName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.ExamPaperName, objvcc_ExamPaperStuBatchRela_Cond.ExamPaperName, strComparisonOp_ExamPaperName);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.PaperIndex) == true)
{
string strComparisonOp_PaperIndex = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.PaperIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuBatchRela.PaperIndex, objvcc_ExamPaperStuBatchRela_Cond.PaperIndex, strComparisonOp_PaperIndex);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.ExamPaperTypeId) == true)
{
string strComparisonOp_ExamPaperTypeId = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.ExamPaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.ExamPaperTypeId, objvcc_ExamPaperStuBatchRela_Cond.ExamPaperTypeId, strComparisonOp_ExamPaperTypeId);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.ExamPaperTypeName) == true)
{
string strComparisonOp_ExamPaperTypeName = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.ExamPaperTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.ExamPaperTypeName, objvcc_ExamPaperStuBatchRela_Cond.ExamPaperTypeName, strComparisonOp_ExamPaperTypeName);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.IsShow) == true)
{
if (objvcc_ExamPaperStuBatchRela_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuBatchRela.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuBatchRela.IsShow);
}
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.TotalScore) == true)
{
string strComparisonOp_TotalScore = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.TotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuBatchRela.TotalScore, objvcc_ExamPaperStuBatchRela_Cond.TotalScore, strComparisonOp_TotalScore);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuBatchRela.ViewCount, objvcc_ExamPaperStuBatchRela_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.DoneNumber) == true)
{
string strComparisonOp_DoneNumber = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.DoneNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuBatchRela.DoneNumber, objvcc_ExamPaperStuBatchRela_Cond.DoneNumber, strComparisonOp_DoneNumber);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.PaperTime) == true)
{
string strComparisonOp_PaperTime = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.PaperTime];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuBatchRela.PaperTime, objvcc_ExamPaperStuBatchRela_Cond.PaperTime, strComparisonOp_PaperTime);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.PaperDispModeName) == true)
{
string strComparisonOp_PaperDispModeName = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.PaperDispModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.PaperDispModeName, objvcc_ExamPaperStuBatchRela_Cond.PaperDispModeName, strComparisonOp_PaperDispModeName);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.ExamCreateTime) == true)
{
string strComparisonOp_ExamCreateTime = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.ExamCreateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.ExamCreateTime, objvcc_ExamPaperStuBatchRela_Cond.ExamCreateTime, strComparisonOp_ExamCreateTime);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.UserName) == true)
{
string strComparisonOp_UserName = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.UserName, objvcc_ExamPaperStuBatchRela_Cond.UserName, strComparisonOp_UserName);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.CourseChapterId, objvcc_ExamPaperStuBatchRela_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.CourseChapterName, objvcc_ExamPaperStuBatchRela_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.ChapterId) == true)
{
string strComparisonOp_ChapterId = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.ChapterId, objvcc_ExamPaperStuBatchRela_Cond.ChapterId, strComparisonOp_ChapterId);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.SectionId) == true)
{
string strComparisonOp_SectionId = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.SectionId, objvcc_ExamPaperStuBatchRela_Cond.SectionId, strComparisonOp_SectionId);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.ChapterName, objvcc_ExamPaperStuBatchRela_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.SectionName) == true)
{
string strComparisonOp_SectionName = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.SectionName, objvcc_ExamPaperStuBatchRela_Cond.SectionName, strComparisonOp_SectionName);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.ChapterName_Sim, objvcc_ExamPaperStuBatchRela_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.SectionName_Sim, objvcc_ExamPaperStuBatchRela_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.IsAutoGeneQuestion) == true)
{
if (objvcc_ExamPaperStuBatchRela_Cond.IsAutoGeneQuestion == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuBatchRela.IsAutoGeneQuestion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuBatchRela.IsAutoGeneQuestion);
}
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.IsCanMultiDo) == true)
{
if (objvcc_ExamPaperStuBatchRela_Cond.IsCanMultiDo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuBatchRela.IsCanMultiDo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuBatchRela.IsCanMultiDo);
}
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.QuestionNum) == true)
{
string strComparisonOp_QuestionNum = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.QuestionNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuBatchRela.QuestionNum, objvcc_ExamPaperStuBatchRela_Cond.QuestionNum, strComparisonOp_QuestionNum);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.id_StudentInfo, objvcc_ExamPaperStuBatchRela_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.StuID) == true)
{
string strComparisonOp_StuID = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.StuID, objvcc_ExamPaperStuBatchRela_Cond.StuID, strComparisonOp_StuID);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.StuName) == true)
{
string strComparisonOp_StuName = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.StuName, objvcc_ExamPaperStuBatchRela_Cond.StuName, strComparisonOp_StuName);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.SexDesc) == true)
{
string strComparisonOp_SexDesc = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.SexDesc, objvcc_ExamPaperStuBatchRela_Cond.SexDesc, strComparisonOp_SexDesc);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.id_XzCollege, objvcc_ExamPaperStuBatchRela_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.CollegeName, objvcc_ExamPaperStuBatchRela_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.CollegeNameA, objvcc_ExamPaperStuBatchRela_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.id_XzMajor, objvcc_ExamPaperStuBatchRela_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.MajorID) == true)
{
string strComparisonOp_MajorID = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.MajorID, objvcc_ExamPaperStuBatchRela_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.MajorName) == true)
{
string strComparisonOp_MajorName = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.MajorName, objvcc_ExamPaperStuBatchRela_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.id_GradeBase, objvcc_ExamPaperStuBatchRela_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.GradeBaseName, objvcc_ExamPaperStuBatchRela_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.AdminClsName) == true)
{
string strComparisonOp_AdminClsName = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.AdminClsName, objvcc_ExamPaperStuBatchRela_Cond.AdminClsName, strComparisonOp_AdminClsName);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.AdminClsId) == true)
{
string strComparisonOp_AdminClsId = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.AdminClsId, objvcc_ExamPaperStuBatchRela_Cond.AdminClsId, strComparisonOp_AdminClsId);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.BatchTime) == true)
{
string strComparisonOp_BatchTime = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.BatchTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.BatchTime, objvcc_ExamPaperStuBatchRela_Cond.BatchTime, strComparisonOp_BatchTime);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.id_CurrEduCls, objvcc_ExamPaperStuBatchRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.CurrEduClsId) == true)
{
string strComparisonOp_CurrEduClsId = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.CurrEduClsId, objvcc_ExamPaperStuBatchRela_Cond.CurrEduClsId, strComparisonOp_CurrEduClsId);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.EduClsName) == true)
{
string strComparisonOp_EduClsName = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.EduClsName, objvcc_ExamPaperStuBatchRela_Cond.EduClsName, strComparisonOp_EduClsName);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.Scores) == true)
{
string strComparisonOp_Scores = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.Scores];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuBatchRela.Scores, objvcc_ExamPaperStuBatchRela_Cond.Scores, strComparisonOp_Scores);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.IsSave) == true)
{
if (objvcc_ExamPaperStuBatchRela_Cond.IsSave == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuBatchRela.IsSave);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuBatchRela.IsSave);
}
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.IsSubmit) == true)
{
if (objvcc_ExamPaperStuBatchRela_Cond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuBatchRela.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuBatchRela.IsSubmit);
}
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.RealFinishDate) == true)
{
string strComparisonOp_RealFinishDate = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.RealFinishDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.RealFinishDate, objvcc_ExamPaperStuBatchRela_Cond.RealFinishDate, strComparisonOp_RealFinishDate);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.OperateTime) == true)
{
string strComparisonOp_OperateTime = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.OperateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.OperateTime, objvcc_ExamPaperStuBatchRela_Cond.OperateTime, strComparisonOp_OperateTime);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.IsMarking) == true)
{
if (objvcc_ExamPaperStuBatchRela_Cond.IsMarking == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuBatchRela.IsMarking);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuBatchRela.IsMarking);
}
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.MarkerId) == true)
{
string strComparisonOp_MarkerId = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.MarkerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.MarkerId, objvcc_ExamPaperStuBatchRela_Cond.MarkerId, strComparisonOp_MarkerId);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.MarkDate) == true)
{
string strComparisonOp_MarkDate = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.MarkDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.MarkDate, objvcc_ExamPaperStuBatchRela_Cond.MarkDate, strComparisonOp_MarkDate);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.AnswerIP) == true)
{
string strComparisonOp_AnswerIP = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.AnswerIP];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.AnswerIP, objvcc_ExamPaperStuBatchRela_Cond.AnswerIP, strComparisonOp_AnswerIP);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.AnswerDate) == true)
{
string strComparisonOp_AnswerDate = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.AnswerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.AnswerDate, objvcc_ExamPaperStuBatchRela_Cond.AnswerDate, strComparisonOp_AnswerDate);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.AnswerTime) == true)
{
string strComparisonOp_AnswerTime = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.AnswerTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.AnswerTime, objvcc_ExamPaperStuBatchRela_Cond.AnswerTime, strComparisonOp_AnswerTime);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.TotalGetScore) == true)
{
string strComparisonOp_TotalGetScore = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.TotalGetScore];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuBatchRela.TotalGetScore, objvcc_ExamPaperStuBatchRela_Cond.TotalGetScore, strComparisonOp_TotalGetScore);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.UpdDate, objvcc_ExamPaperStuBatchRela_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.UpdUserId, objvcc_ExamPaperStuBatchRela_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.Memo) == true)
{
string strComparisonOp_Memo = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.Memo, objvcc_ExamPaperStuBatchRela_Cond.Memo, strComparisonOp_Memo);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.NoSubmitQuesNum) == true)
{
string strComparisonOp_NoSubmitQuesNum = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.NoSubmitQuesNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuBatchRela.NoSubmitQuesNum, objvcc_ExamPaperStuBatchRela_Cond.NoSubmitQuesNum, strComparisonOp_NoSubmitQuesNum);
}
if (objvcc_ExamPaperStuBatchRela_Cond.IsUpdated(convcc_ExamPaperStuBatchRela.SubmitQuesNum) == true)
{
string strComparisonOp_SubmitQuesNum = objvcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.SubmitQuesNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuBatchRela.SubmitQuesNum, objvcc_ExamPaperStuBatchRela_Cond.SubmitQuesNum, strComparisonOp_SubmitQuesNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v考卷与学生批次关系(vcc_ExamPaperStuBatchRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_ExamPaperStuBatchRelaWApi
{
private static readonly string mstrApiControllerName = "vcc_ExamPaperStuBatchRelaApi";

 public clsvcc_ExamPaperStuBatchRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_PaperStuBatch">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_ExamPaperStuBatchRelaEN GetObjById_PaperStuBatch(string strId_PaperStuBatch)
{
string strAction = "GetObjById_PaperStuBatch";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN = null;
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
objvcc_ExamPaperStuBatchRelaEN = JsonConvert.DeserializeObject<clsvcc_ExamPaperStuBatchRelaEN>((string)jobjReturn["ReturnObj"]);
return objvcc_ExamPaperStuBatchRelaEN;
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
public static clsvcc_ExamPaperStuBatchRelaEN GetObjById_PaperStuBatch_WA_Cache(string strId_PaperStuBatch, string strid_CurrEduCls)
{
string strAction = "GetObjById_PaperStuBatch_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN = null;
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
objvcc_ExamPaperStuBatchRelaEN = JsonConvert.DeserializeObject<clsvcc_ExamPaperStuBatchRelaEN>((string)jobjReturn["ReturnObj"]);
return objvcc_ExamPaperStuBatchRelaEN;
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
public static clsvcc_ExamPaperStuBatchRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN = null;
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
objvcc_ExamPaperStuBatchRelaEN = JsonConvert.DeserializeObject<clsvcc_ExamPaperStuBatchRelaEN>((string)jobjReturn["ReturnObj"]);
return objvcc_ExamPaperStuBatchRelaEN;
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
public static clsvcc_ExamPaperStuBatchRelaEN GetObjById_PaperStuBatch_Cache(string strId_PaperStuBatch, string strid_CurrEduCls)
{
if (string.IsNullOrEmpty(strId_PaperStuBatch) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_ExamPaperStuBatchRelaEN._CurrTabName_S, strid_CurrEduCls);
List<clsvcc_ExamPaperStuBatchRelaEN> arrvcc_ExamPaperStuBatchRelaObjLst_Cache = GetObjLst_Cache(strid_CurrEduCls);
IEnumerable <clsvcc_ExamPaperStuBatchRelaEN> arrvcc_ExamPaperStuBatchRelaObjLst_Sel =
from objvcc_ExamPaperStuBatchRelaEN in arrvcc_ExamPaperStuBatchRelaObjLst_Cache
where objvcc_ExamPaperStuBatchRelaEN.Id_PaperStuBatch == strId_PaperStuBatch
select objvcc_ExamPaperStuBatchRelaEN;
if (arrvcc_ExamPaperStuBatchRelaObjLst_Sel.Count() == 0)
{
   clsvcc_ExamPaperStuBatchRelaEN obj = clsvcc_ExamPaperStuBatchRelaWApi.GetObjById_PaperStuBatch(strId_PaperStuBatch);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_ExamPaperStuBatchRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_ExamPaperStuBatchRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_ExamPaperStuBatchRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperStuBatchRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperStuBatchRelaEN> GetObjLstById_PaperStuBatchLst(List<string> arrId_PaperStuBatch)
{
 List<clsvcc_ExamPaperStuBatchRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperStuBatchRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvcc_ExamPaperStuBatchRelaEN> GetObjLstById_PaperStuBatchLst_Cache(List<string> arrId_PaperStuBatch, string strid_CurrEduCls)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_ExamPaperStuBatchRelaEN._CurrTabName_S, strid_CurrEduCls);
List<clsvcc_ExamPaperStuBatchRelaEN> arrvcc_ExamPaperStuBatchRelaObjLst_Cache = GetObjLst_Cache(strid_CurrEduCls);
IEnumerable <clsvcc_ExamPaperStuBatchRelaEN> arrvcc_ExamPaperStuBatchRelaObjLst_Sel =
from objvcc_ExamPaperStuBatchRelaEN in arrvcc_ExamPaperStuBatchRelaObjLst_Cache
where arrId_PaperStuBatch.Contains(objvcc_ExamPaperStuBatchRelaEN.Id_PaperStuBatch)
select objvcc_ExamPaperStuBatchRelaEN;
return arrvcc_ExamPaperStuBatchRelaObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_ExamPaperStuBatchRelaEN> GetObjLstById_PaperStuBatchLst_WA_Cache(List<string> arrId_PaperStuBatch, string strid_CurrEduCls)
{
 List<clsvcc_ExamPaperStuBatchRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperStuBatchRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperStuBatchRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_ExamPaperStuBatchRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperStuBatchRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperStuBatchRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_ExamPaperStuBatchRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperStuBatchRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperStuBatchRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_ExamPaperStuBatchRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperStuBatchRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperStuBatchRelaEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_ExamPaperStuBatchRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperStuBatchRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvcc_ExamPaperStuBatchRelaENS">源对象</param>
 /// <param name = "objvcc_ExamPaperStuBatchRelaENT">目标对象</param>
 public static void CopyTo(clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaENS, clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaENT)
{
try
{
objvcc_ExamPaperStuBatchRelaENT.Id_PaperStuBatch = objvcc_ExamPaperStuBatchRelaENS.Id_PaperStuBatch; //学生试卷批次流水号
objvcc_ExamPaperStuBatchRelaENT.CourseExamPaperId = objvcc_ExamPaperStuBatchRelaENS.CourseExamPaperId; //考卷流水号
objvcc_ExamPaperStuBatchRelaENT.CourseId = objvcc_ExamPaperStuBatchRelaENS.CourseId; //课程Id
objvcc_ExamPaperStuBatchRelaENT.CourseName = objvcc_ExamPaperStuBatchRelaENS.CourseName; //课程名称
objvcc_ExamPaperStuBatchRelaENT.ExamPaperName = objvcc_ExamPaperStuBatchRelaENS.ExamPaperName; //考卷名称
objvcc_ExamPaperStuBatchRelaENT.PaperIndex = objvcc_ExamPaperStuBatchRelaENS.PaperIndex; //试卷序号
objvcc_ExamPaperStuBatchRelaENT.ExamPaperTypeId = objvcc_ExamPaperStuBatchRelaENS.ExamPaperTypeId; //试卷类型Id
objvcc_ExamPaperStuBatchRelaENT.ExamPaperTypeName = objvcc_ExamPaperStuBatchRelaENS.ExamPaperTypeName; //试卷类型名称
objvcc_ExamPaperStuBatchRelaENT.IsShow = objvcc_ExamPaperStuBatchRelaENS.IsShow; //是否启用
objvcc_ExamPaperStuBatchRelaENT.TotalScore = objvcc_ExamPaperStuBatchRelaENS.TotalScore; //总得分
objvcc_ExamPaperStuBatchRelaENT.ViewCount = objvcc_ExamPaperStuBatchRelaENS.ViewCount; //浏览量
objvcc_ExamPaperStuBatchRelaENT.DoneNumber = objvcc_ExamPaperStuBatchRelaENS.DoneNumber; //已做人数
objvcc_ExamPaperStuBatchRelaENT.PaperTime = objvcc_ExamPaperStuBatchRelaENS.PaperTime; //考试时间（分钟）
objvcc_ExamPaperStuBatchRelaENT.PaperDispModeName = objvcc_ExamPaperStuBatchRelaENS.PaperDispModeName; //试卷显示模式名称
objvcc_ExamPaperStuBatchRelaENT.ExamCreateTime = objvcc_ExamPaperStuBatchRelaENS.ExamCreateTime; //考卷建立时间
objvcc_ExamPaperStuBatchRelaENT.UserName = objvcc_ExamPaperStuBatchRelaENS.UserName; //用户名
objvcc_ExamPaperStuBatchRelaENT.CourseChapterId = objvcc_ExamPaperStuBatchRelaENS.CourseChapterId; //课程章节ID
objvcc_ExamPaperStuBatchRelaENT.CourseChapterName = objvcc_ExamPaperStuBatchRelaENS.CourseChapterName; //课程章节名称
objvcc_ExamPaperStuBatchRelaENT.ChapterId = objvcc_ExamPaperStuBatchRelaENS.ChapterId; //章Id
objvcc_ExamPaperStuBatchRelaENT.SectionId = objvcc_ExamPaperStuBatchRelaENS.SectionId; //节Id
objvcc_ExamPaperStuBatchRelaENT.ChapterName = objvcc_ExamPaperStuBatchRelaENS.ChapterName; //章名
objvcc_ExamPaperStuBatchRelaENT.SectionName = objvcc_ExamPaperStuBatchRelaENS.SectionName; //节名
objvcc_ExamPaperStuBatchRelaENT.ChapterName_Sim = objvcc_ExamPaperStuBatchRelaENS.ChapterName_Sim; //章名简称
objvcc_ExamPaperStuBatchRelaENT.SectionName_Sim = objvcc_ExamPaperStuBatchRelaENS.SectionName_Sim; //节名简称
objvcc_ExamPaperStuBatchRelaENT.IsAutoGeneQuestion = objvcc_ExamPaperStuBatchRelaENS.IsAutoGeneQuestion; //是否自动生成题目
objvcc_ExamPaperStuBatchRelaENT.IsCanMultiDo = objvcc_ExamPaperStuBatchRelaENS.IsCanMultiDo; //是否可以做多次
objvcc_ExamPaperStuBatchRelaENT.QuestionNum = objvcc_ExamPaperStuBatchRelaENS.QuestionNum; //题目数
objvcc_ExamPaperStuBatchRelaENT.id_StudentInfo = objvcc_ExamPaperStuBatchRelaENS.id_StudentInfo; //学生流水号
objvcc_ExamPaperStuBatchRelaENT.StuID = objvcc_ExamPaperStuBatchRelaENS.StuID; //学号
objvcc_ExamPaperStuBatchRelaENT.StuName = objvcc_ExamPaperStuBatchRelaENS.StuName; //姓名
objvcc_ExamPaperStuBatchRelaENT.SexDesc = objvcc_ExamPaperStuBatchRelaENS.SexDesc; //性别名称
objvcc_ExamPaperStuBatchRelaENT.id_XzCollege = objvcc_ExamPaperStuBatchRelaENS.id_XzCollege; //学院流水号
objvcc_ExamPaperStuBatchRelaENT.CollegeName = objvcc_ExamPaperStuBatchRelaENS.CollegeName; //学院名称
objvcc_ExamPaperStuBatchRelaENT.CollegeNameA = objvcc_ExamPaperStuBatchRelaENS.CollegeNameA; //学院名称简写
objvcc_ExamPaperStuBatchRelaENT.id_XzMajor = objvcc_ExamPaperStuBatchRelaENS.id_XzMajor; //专业流水号
objvcc_ExamPaperStuBatchRelaENT.MajorID = objvcc_ExamPaperStuBatchRelaENS.MajorID; //专业ID
objvcc_ExamPaperStuBatchRelaENT.MajorName = objvcc_ExamPaperStuBatchRelaENS.MajorName; //专业名称
objvcc_ExamPaperStuBatchRelaENT.id_GradeBase = objvcc_ExamPaperStuBatchRelaENS.id_GradeBase; //年级流水号
objvcc_ExamPaperStuBatchRelaENT.GradeBaseName = objvcc_ExamPaperStuBatchRelaENS.GradeBaseName; //年级名称
objvcc_ExamPaperStuBatchRelaENT.AdminClsName = objvcc_ExamPaperStuBatchRelaENS.AdminClsName; //行政班名称
objvcc_ExamPaperStuBatchRelaENT.AdminClsId = objvcc_ExamPaperStuBatchRelaENS.AdminClsId; //行政班代号
objvcc_ExamPaperStuBatchRelaENT.BatchTime = objvcc_ExamPaperStuBatchRelaENS.BatchTime; //批次
objvcc_ExamPaperStuBatchRelaENT.id_CurrEduCls = objvcc_ExamPaperStuBatchRelaENS.id_CurrEduCls; //当前教学班流水号
objvcc_ExamPaperStuBatchRelaENT.CurrEduClsId = objvcc_ExamPaperStuBatchRelaENS.CurrEduClsId; //当前教学班Id
objvcc_ExamPaperStuBatchRelaENT.EduClsName = objvcc_ExamPaperStuBatchRelaENS.EduClsName; //教学班名称
objvcc_ExamPaperStuBatchRelaENT.Scores = objvcc_ExamPaperStuBatchRelaENS.Scores; //分值
objvcc_ExamPaperStuBatchRelaENT.IsSave = objvcc_ExamPaperStuBatchRelaENS.IsSave; //是否保存
objvcc_ExamPaperStuBatchRelaENT.IsSubmit = objvcc_ExamPaperStuBatchRelaENS.IsSubmit; //是否提交
objvcc_ExamPaperStuBatchRelaENT.RealFinishDate = objvcc_ExamPaperStuBatchRelaENS.RealFinishDate; //实际完成日期
objvcc_ExamPaperStuBatchRelaENT.OperateTime = objvcc_ExamPaperStuBatchRelaENS.OperateTime; //操作时间
objvcc_ExamPaperStuBatchRelaENT.IsMarking = objvcc_ExamPaperStuBatchRelaENS.IsMarking; //是否批阅
objvcc_ExamPaperStuBatchRelaENT.MarkerId = objvcc_ExamPaperStuBatchRelaENS.MarkerId; //打分者
objvcc_ExamPaperStuBatchRelaENT.MarkDate = objvcc_ExamPaperStuBatchRelaENS.MarkDate; //打分日期
objvcc_ExamPaperStuBatchRelaENT.AnswerIP = objvcc_ExamPaperStuBatchRelaENS.AnswerIP; //回答IP
objvcc_ExamPaperStuBatchRelaENT.AnswerDate = objvcc_ExamPaperStuBatchRelaENS.AnswerDate; //回答日期
objvcc_ExamPaperStuBatchRelaENT.AnswerTime = objvcc_ExamPaperStuBatchRelaENS.AnswerTime; //回答时间
objvcc_ExamPaperStuBatchRelaENT.TotalGetScore = objvcc_ExamPaperStuBatchRelaENS.TotalGetScore; //考生获取总分
objvcc_ExamPaperStuBatchRelaENT.UpdDate = objvcc_ExamPaperStuBatchRelaENS.UpdDate; //修改日期
objvcc_ExamPaperStuBatchRelaENT.UpdUserId = objvcc_ExamPaperStuBatchRelaENS.UpdUserId; //修改用户Id
objvcc_ExamPaperStuBatchRelaENT.Memo = objvcc_ExamPaperStuBatchRelaENS.Memo; //备注
objvcc_ExamPaperStuBatchRelaENT.NoSubmitQuesNum = objvcc_ExamPaperStuBatchRelaENS.NoSubmitQuesNum; //未提交题数
objvcc_ExamPaperStuBatchRelaENT.SubmitQuesNum = objvcc_ExamPaperStuBatchRelaENS.SubmitQuesNum; //提交题数
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
public static DataTable ToDataTable(List<clsvcc_ExamPaperStuBatchRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_ExamPaperStuBatchRelaEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_ExamPaperStuBatchRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_ExamPaperStuBatchRelaEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_ExamPaperStuBatchRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_ExamPaperStuBatchRelaEN.AttributeName)
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
//if (arrvcc_ExamPaperStuBatchRelaObjLst_Cache == null)
//{
//arrvcc_ExamPaperStuBatchRelaObjLst_Cache = await clsvcc_ExamPaperStuBatchRelaWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsvcc_ExamPaperStuBatchRelaEN._CurrTabName_S, strid_CurrEduCls);
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
public static List<clsvcc_ExamPaperStuBatchRelaEN> GetObjLst_Cache(string strid_CurrEduCls)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvcc_ExamPaperStuBatchRelaEN._CurrTabName_S, strid_CurrEduCls);
List<clsvcc_ExamPaperStuBatchRelaEN> arrvcc_ExamPaperStuBatchRelaObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("id_CurrEduCls='{0}'", strid_CurrEduCls)); });
return arrvcc_ExamPaperStuBatchRelaObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_ExamPaperStuBatchRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.Id_PaperStuBatch, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.CourseExamPaperId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.ExamPaperName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.PaperIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.ExamPaperTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.ExamPaperTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.TotalScore, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.DoneNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.PaperTime, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.PaperDispModeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.ExamCreateTime, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.ChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.SectionId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.SectionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.IsAutoGeneQuestion, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.IsCanMultiDo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.QuestionNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.SexDesc, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.AdminClsName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.AdminClsId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.BatchTime, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.CurrEduClsId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.EduClsName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.Scores, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.IsSave, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.IsSubmit, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.RealFinishDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.OperateTime, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.IsMarking, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.MarkerId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.MarkDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.AnswerIP, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.AnswerDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.AnswerTime, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.TotalGetScore, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.NoSubmitQuesNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperStuBatchRela.SubmitQuesNum, Type.GetType("System.Int32"));
foreach (clsvcc_ExamPaperStuBatchRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_ExamPaperStuBatchRela.Id_PaperStuBatch] = objInFor[convcc_ExamPaperStuBatchRela.Id_PaperStuBatch];
objDR[convcc_ExamPaperStuBatchRela.CourseExamPaperId] = objInFor[convcc_ExamPaperStuBatchRela.CourseExamPaperId];
objDR[convcc_ExamPaperStuBatchRela.CourseId] = objInFor[convcc_ExamPaperStuBatchRela.CourseId];
objDR[convcc_ExamPaperStuBatchRela.CourseName] = objInFor[convcc_ExamPaperStuBatchRela.CourseName];
objDR[convcc_ExamPaperStuBatchRela.ExamPaperName] = objInFor[convcc_ExamPaperStuBatchRela.ExamPaperName];
objDR[convcc_ExamPaperStuBatchRela.PaperIndex] = objInFor[convcc_ExamPaperStuBatchRela.PaperIndex];
objDR[convcc_ExamPaperStuBatchRela.ExamPaperTypeId] = objInFor[convcc_ExamPaperStuBatchRela.ExamPaperTypeId];
objDR[convcc_ExamPaperStuBatchRela.ExamPaperTypeName] = objInFor[convcc_ExamPaperStuBatchRela.ExamPaperTypeName];
objDR[convcc_ExamPaperStuBatchRela.IsShow] = objInFor[convcc_ExamPaperStuBatchRela.IsShow];
objDR[convcc_ExamPaperStuBatchRela.TotalScore] = objInFor[convcc_ExamPaperStuBatchRela.TotalScore];
objDR[convcc_ExamPaperStuBatchRela.ViewCount] = objInFor[convcc_ExamPaperStuBatchRela.ViewCount];
objDR[convcc_ExamPaperStuBatchRela.DoneNumber] = objInFor[convcc_ExamPaperStuBatchRela.DoneNumber];
objDR[convcc_ExamPaperStuBatchRela.PaperTime] = objInFor[convcc_ExamPaperStuBatchRela.PaperTime];
objDR[convcc_ExamPaperStuBatchRela.PaperDispModeName] = objInFor[convcc_ExamPaperStuBatchRela.PaperDispModeName];
objDR[convcc_ExamPaperStuBatchRela.ExamCreateTime] = objInFor[convcc_ExamPaperStuBatchRela.ExamCreateTime];
objDR[convcc_ExamPaperStuBatchRela.UserName] = objInFor[convcc_ExamPaperStuBatchRela.UserName];
objDR[convcc_ExamPaperStuBatchRela.CourseChapterId] = objInFor[convcc_ExamPaperStuBatchRela.CourseChapterId];
objDR[convcc_ExamPaperStuBatchRela.CourseChapterName] = objInFor[convcc_ExamPaperStuBatchRela.CourseChapterName];
objDR[convcc_ExamPaperStuBatchRela.ChapterId] = objInFor[convcc_ExamPaperStuBatchRela.ChapterId];
objDR[convcc_ExamPaperStuBatchRela.SectionId] = objInFor[convcc_ExamPaperStuBatchRela.SectionId];
objDR[convcc_ExamPaperStuBatchRela.ChapterName] = objInFor[convcc_ExamPaperStuBatchRela.ChapterName];
objDR[convcc_ExamPaperStuBatchRela.SectionName] = objInFor[convcc_ExamPaperStuBatchRela.SectionName];
objDR[convcc_ExamPaperStuBatchRela.ChapterName_Sim] = objInFor[convcc_ExamPaperStuBatchRela.ChapterName_Sim];
objDR[convcc_ExamPaperStuBatchRela.SectionName_Sim] = objInFor[convcc_ExamPaperStuBatchRela.SectionName_Sim];
objDR[convcc_ExamPaperStuBatchRela.IsAutoGeneQuestion] = objInFor[convcc_ExamPaperStuBatchRela.IsAutoGeneQuestion];
objDR[convcc_ExamPaperStuBatchRela.IsCanMultiDo] = objInFor[convcc_ExamPaperStuBatchRela.IsCanMultiDo];
objDR[convcc_ExamPaperStuBatchRela.QuestionNum] = objInFor[convcc_ExamPaperStuBatchRela.QuestionNum];
objDR[convcc_ExamPaperStuBatchRela.id_StudentInfo] = objInFor[convcc_ExamPaperStuBatchRela.id_StudentInfo];
objDR[convcc_ExamPaperStuBatchRela.StuID] = objInFor[convcc_ExamPaperStuBatchRela.StuID];
objDR[convcc_ExamPaperStuBatchRela.StuName] = objInFor[convcc_ExamPaperStuBatchRela.StuName];
objDR[convcc_ExamPaperStuBatchRela.SexDesc] = objInFor[convcc_ExamPaperStuBatchRela.SexDesc];
objDR[convcc_ExamPaperStuBatchRela.id_XzCollege] = objInFor[convcc_ExamPaperStuBatchRela.id_XzCollege];
objDR[convcc_ExamPaperStuBatchRela.CollegeName] = objInFor[convcc_ExamPaperStuBatchRela.CollegeName];
objDR[convcc_ExamPaperStuBatchRela.CollegeNameA] = objInFor[convcc_ExamPaperStuBatchRela.CollegeNameA];
objDR[convcc_ExamPaperStuBatchRela.id_XzMajor] = objInFor[convcc_ExamPaperStuBatchRela.id_XzMajor];
objDR[convcc_ExamPaperStuBatchRela.MajorID] = objInFor[convcc_ExamPaperStuBatchRela.MajorID];
objDR[convcc_ExamPaperStuBatchRela.MajorName] = objInFor[convcc_ExamPaperStuBatchRela.MajorName];
objDR[convcc_ExamPaperStuBatchRela.id_GradeBase] = objInFor[convcc_ExamPaperStuBatchRela.id_GradeBase];
objDR[convcc_ExamPaperStuBatchRela.GradeBaseName] = objInFor[convcc_ExamPaperStuBatchRela.GradeBaseName];
objDR[convcc_ExamPaperStuBatchRela.AdminClsName] = objInFor[convcc_ExamPaperStuBatchRela.AdminClsName];
objDR[convcc_ExamPaperStuBatchRela.AdminClsId] = objInFor[convcc_ExamPaperStuBatchRela.AdminClsId];
objDR[convcc_ExamPaperStuBatchRela.BatchTime] = objInFor[convcc_ExamPaperStuBatchRela.BatchTime];
objDR[convcc_ExamPaperStuBatchRela.id_CurrEduCls] = objInFor[convcc_ExamPaperStuBatchRela.id_CurrEduCls];
objDR[convcc_ExamPaperStuBatchRela.CurrEduClsId] = objInFor[convcc_ExamPaperStuBatchRela.CurrEduClsId];
objDR[convcc_ExamPaperStuBatchRela.EduClsName] = objInFor[convcc_ExamPaperStuBatchRela.EduClsName];
objDR[convcc_ExamPaperStuBatchRela.Scores] = objInFor[convcc_ExamPaperStuBatchRela.Scores];
objDR[convcc_ExamPaperStuBatchRela.IsSave] = objInFor[convcc_ExamPaperStuBatchRela.IsSave];
objDR[convcc_ExamPaperStuBatchRela.IsSubmit] = objInFor[convcc_ExamPaperStuBatchRela.IsSubmit];
objDR[convcc_ExamPaperStuBatchRela.RealFinishDate] = objInFor[convcc_ExamPaperStuBatchRela.RealFinishDate];
objDR[convcc_ExamPaperStuBatchRela.OperateTime] = objInFor[convcc_ExamPaperStuBatchRela.OperateTime];
objDR[convcc_ExamPaperStuBatchRela.IsMarking] = objInFor[convcc_ExamPaperStuBatchRela.IsMarking];
objDR[convcc_ExamPaperStuBatchRela.MarkerId] = objInFor[convcc_ExamPaperStuBatchRela.MarkerId];
objDR[convcc_ExamPaperStuBatchRela.MarkDate] = objInFor[convcc_ExamPaperStuBatchRela.MarkDate];
objDR[convcc_ExamPaperStuBatchRela.AnswerIP] = objInFor[convcc_ExamPaperStuBatchRela.AnswerIP];
objDR[convcc_ExamPaperStuBatchRela.AnswerDate] = objInFor[convcc_ExamPaperStuBatchRela.AnswerDate];
objDR[convcc_ExamPaperStuBatchRela.AnswerTime] = objInFor[convcc_ExamPaperStuBatchRela.AnswerTime];
objDR[convcc_ExamPaperStuBatchRela.TotalGetScore] = objInFor[convcc_ExamPaperStuBatchRela.TotalGetScore];
objDR[convcc_ExamPaperStuBatchRela.UpdDate] = objInFor[convcc_ExamPaperStuBatchRela.UpdDate];
objDR[convcc_ExamPaperStuBatchRela.UpdUserId] = objInFor[convcc_ExamPaperStuBatchRela.UpdUserId];
objDR[convcc_ExamPaperStuBatchRela.Memo] = objInFor[convcc_ExamPaperStuBatchRela.Memo];
objDR[convcc_ExamPaperStuBatchRela.NoSubmitQuesNum] = objInFor[convcc_ExamPaperStuBatchRela.NoSubmitQuesNum];
objDR[convcc_ExamPaperStuBatchRela.SubmitQuesNum] = objInFor[convcc_ExamPaperStuBatchRela.SubmitQuesNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}