
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_PaperStuBatchQuesRela_Total_JTWApi
 表名:vcc_PaperStuBatchQuesRela_Total_JT(01120249)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:49:04
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
public static class clsvcc_PaperStuBatchQuesRela_Total_JTWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetId_PaperStuBatchQuesRela_Total(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, long lngId_PaperStuBatchQuesRela_Total, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_Total_JTEN.Id_PaperStuBatchQuesRela_Total = lngId_PaperStuBatchQuesRela_Total; //学生试卷完成汇总流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.Id_PaperStuBatchQuesRela_Total) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.Id_PaperStuBatchQuesRela_Total, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.Id_PaperStuBatchQuesRela_Total] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetId_PaperStuBatch(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, string strId_PaperStuBatch, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_PaperStuBatch, 10, convcc_PaperStuBatchQuesRela_Total_JT.Id_PaperStuBatch);
clsCheckSql.CheckFieldForeignKey(strId_PaperStuBatch, 10, convcc_PaperStuBatchQuesRela_Total_JT.Id_PaperStuBatch);
objvcc_PaperStuBatchQuesRela_Total_JTEN.Id_PaperStuBatch = strId_PaperStuBatch; //学生试卷批次流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.Id_PaperStuBatch) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.Id_PaperStuBatch, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.Id_PaperStuBatch] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetCourseExamPaperId(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, convcc_PaperStuBatchQuesRela_Total_JT.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, convcc_PaperStuBatchQuesRela_Total_JT.CourseExamPaperId);
objvcc_PaperStuBatchQuesRela_Total_JTEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.CourseExamPaperId) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.CourseExamPaperId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.CourseExamPaperId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetCourseId(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_PaperStuBatchQuesRela_Total_JT.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_PaperStuBatchQuesRela_Total_JT.CourseId);
objvcc_PaperStuBatchQuesRela_Total_JTEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.CourseId) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.CourseId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.CourseId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetCourseName(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_PaperStuBatchQuesRela_Total_JT.CourseName);
objvcc_PaperStuBatchQuesRela_Total_JTEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.CourseName) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.CourseName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.CourseName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetExamPaperName(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, string strExamPaperName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamPaperName, 500, convcc_PaperStuBatchQuesRela_Total_JT.ExamPaperName);
objvcc_PaperStuBatchQuesRela_Total_JTEN.ExamPaperName = strExamPaperName; //考卷名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.ExamPaperName) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.ExamPaperName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.ExamPaperName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN Setid_StudentInfo(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, convcc_PaperStuBatchQuesRela_Total_JT.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, convcc_PaperStuBatchQuesRela_Total_JT.id_StudentInfo);
objvcc_PaperStuBatchQuesRela_Total_JTEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.id_StudentInfo) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.id_StudentInfo, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.id_StudentInfo] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetSiteName(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, string strSiteName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSiteName, 100, convcc_PaperStuBatchQuesRela_Total_JT.SiteName);
objvcc_PaperStuBatchQuesRela_Total_JTEN.SiteName = strSiteName; //工地名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.SiteName) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.SiteName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.SiteName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetStuID(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convcc_PaperStuBatchQuesRela_Total_JT.StuID);
objvcc_PaperStuBatchQuesRela_Total_JTEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.StuID) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.StuID, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.StuID] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetStuName(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convcc_PaperStuBatchQuesRela_Total_JT.StuName);
objvcc_PaperStuBatchQuesRela_Total_JTEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.StuName) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.StuName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.StuName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetManagedDepartmentId(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, string strManagedDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strManagedDepartmentId, 4, convcc_PaperStuBatchQuesRela_Total_JT.ManagedDepartmentId);
clsCheckSql.CheckFieldForeignKey(strManagedDepartmentId, 4, convcc_PaperStuBatchQuesRela_Total_JT.ManagedDepartmentId);
objvcc_PaperStuBatchQuesRela_Total_JTEN.ManagedDepartmentId = strManagedDepartmentId; //管理的部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.ManagedDepartmentId) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.ManagedDepartmentId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.ManagedDepartmentId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetManagedDepartmentName(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, string strManagedDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strManagedDepartmentName, 50, convcc_PaperStuBatchQuesRela_Total_JT.ManagedDepartmentName);
objvcc_PaperStuBatchQuesRela_Total_JTEN.ManagedDepartmentName = strManagedDepartmentName; //管理的部门名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.ManagedDepartmentName) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.ManagedDepartmentName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.ManagedDepartmentName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetJobCategoryId(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, string strJobCategoryId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strJobCategoryId, 2, convcc_PaperStuBatchQuesRela_Total_JT.JobCategoryId);
clsCheckSql.CheckFieldForeignKey(strJobCategoryId, 2, convcc_PaperStuBatchQuesRela_Total_JT.JobCategoryId);
objvcc_PaperStuBatchQuesRela_Total_JTEN.JobCategoryId = strJobCategoryId; //岗位类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.JobCategoryId) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.JobCategoryId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.JobCategoryId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetJobCategoryName(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, string strJobCategoryName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strJobCategoryName, 50, convcc_PaperStuBatchQuesRela_Total_JT.JobCategoryName);
objvcc_PaperStuBatchQuesRela_Total_JTEN.JobCategoryName = strJobCategoryName; //岗位类别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.JobCategoryName) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.JobCategoryName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.JobCategoryName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetSexDesc(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, string strSexDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convcc_PaperStuBatchQuesRela_Total_JT.SexDesc);
objvcc_PaperStuBatchQuesRela_Total_JTEN.SexDesc = strSexDesc; //性别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.SexDesc) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.SexDesc, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.SexDesc] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN Setid_XzCollege(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convcc_PaperStuBatchQuesRela_Total_JT.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convcc_PaperStuBatchQuesRela_Total_JT.id_XzCollege);
objvcc_PaperStuBatchQuesRela_Total_JTEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.id_XzCollege) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.id_XzCollege, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.id_XzCollege] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetCollegeName(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convcc_PaperStuBatchQuesRela_Total_JT.CollegeName);
objvcc_PaperStuBatchQuesRela_Total_JTEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.CollegeName) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.CollegeName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.CollegeName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetCollegeNameA(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convcc_PaperStuBatchQuesRela_Total_JT.CollegeNameA);
objvcc_PaperStuBatchQuesRela_Total_JTEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.CollegeNameA) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.CollegeNameA, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.CollegeNameA] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetBatchTime(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, string strBatchTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBatchTime, 14, convcc_PaperStuBatchQuesRela_Total_JT.BatchTime);
objvcc_PaperStuBatchQuesRela_Total_JTEN.BatchTime = strBatchTime; //批次
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.BatchTime) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.BatchTime, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.BatchTime] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN Setid_CurrEduCls(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convcc_PaperStuBatchQuesRela_Total_JT.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convcc_PaperStuBatchQuesRela_Total_JT.id_CurrEduCls);
objvcc_PaperStuBatchQuesRela_Total_JTEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.id_CurrEduCls) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.id_CurrEduCls, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.id_CurrEduCls] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetCurrEduClsId(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, string strCurrEduClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, convcc_PaperStuBatchQuesRela_Total_JT.CurrEduClsId);
objvcc_PaperStuBatchQuesRela_Total_JTEN.CurrEduClsId = strCurrEduClsId; //当前教学班Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.CurrEduClsId) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.CurrEduClsId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.CurrEduClsId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetEduClsName(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convcc_PaperStuBatchQuesRela_Total_JT.EduClsName);
objvcc_PaperStuBatchQuesRela_Total_JTEN.EduClsName = strEduClsName; //教学班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.EduClsName) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.EduClsName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.EduClsName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetQuesNum(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, int intQuesNum, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_Total_JTEN.QuesNum = intQuesNum; //题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetQuesNum_Look(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, int intQuesNum_Look, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_Total_JTEN.QuesNum_Look = intQuesNum_Look; //查看题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Look) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Look, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Look] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetQuesNum_Mark(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, int intQuesNum_Mark, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_Total_JTEN.QuesNum_Mark = intQuesNum_Mark; //打分题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Mark) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Mark, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Mark] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetQuesNum_NoFinish(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, int intQuesNum_NoFinish, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_Total_JTEN.QuesNum_NoFinish = intQuesNum_NoFinish; //未完成题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_NoFinish) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_NoFinish, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_NoFinish] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetQuesNum_Overdue(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, int intQuesNum_Overdue, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_Total_JTEN.QuesNum_Overdue = intQuesNum_Overdue; //逾期题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Overdue) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Overdue, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Overdue] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetQuesNum_Save(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, int intQuesNum_Save, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_Total_JTEN.QuesNum_Save = intQuesNum_Save; //保存题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Save) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Save, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Save] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetQuesNum_SendBack(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, int intQuesNum_SendBack, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_Total_JTEN.QuesNum_SendBack = intQuesNum_SendBack; //退回题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_SendBack) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_SendBack, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_SendBack] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetQuesNum_Submit(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, int intQuesNum_Submit, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_Total_JTEN.QuesNum_Submit = intQuesNum_Submit; //提交题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Submit) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Submit, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Submit] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetTotalScore(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, double dblTotalScore, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_Total_JTEN.TotalScore = dblTotalScore; //总得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.TotalScore) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.TotalScore, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.TotalScore] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetTotalScores(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, double dblTotalScores, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_Total_JTEN.TotalScores = dblTotalScores; //总分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.TotalScores) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.TotalScores, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.TotalScores] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetSchoolYear(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, string strSchoolYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, convcc_PaperStuBatchQuesRela_Total_JT.SchoolYear);
objvcc_PaperStuBatchQuesRela_Total_JTEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.SchoolYear) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.SchoolYear, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.SchoolYear] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetSchoolTerm(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, convcc_PaperStuBatchQuesRela_Total_JT.SchoolTerm);
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, convcc_PaperStuBatchQuesRela_Total_JT.SchoolTerm);
objvcc_PaperStuBatchQuesRela_Total_JTEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.SchoolTerm) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.SchoolTerm, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.SchoolTerm] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetUpdDate(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_PaperStuBatchQuesRela_Total_JT.UpdDate);
objvcc_PaperStuBatchQuesRela_Total_JTEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.UpdDate) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.UpdDate, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.UpdDate] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetUpdUserId(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_PaperStuBatchQuesRela_Total_JT.UpdUserId);
objvcc_PaperStuBatchQuesRela_Total_JTEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.UpdUserId) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.UpdUserId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.UpdUserId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN SetMemo(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_PaperStuBatchQuesRela_Total_JT.Memo);
objvcc_PaperStuBatchQuesRela_Total_JTEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total_JT.Memo) == false)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total_JT.Memo, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_Total_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.Memo] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JT_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.Id_PaperStuBatchQuesRela_Total) == true)
{
string strComparisonOp_Id_PaperStuBatchQuesRela_Total = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.Id_PaperStuBatchQuesRela_Total];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela_Total_JT.Id_PaperStuBatchQuesRela_Total, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.Id_PaperStuBatchQuesRela_Total, strComparisonOp_Id_PaperStuBatchQuesRela_Total);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.Id_PaperStuBatch) == true)
{
string strComparisonOp_Id_PaperStuBatch = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.Id_PaperStuBatch];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total_JT.Id_PaperStuBatch, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.Id_PaperStuBatch, strComparisonOp_Id_PaperStuBatch);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.CourseExamPaperId) == true)
{
string strComparisonOp_CourseExamPaperId = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total_JT.CourseExamPaperId, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.CourseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total_JT.CourseId, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total_JT.CourseName, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.ExamPaperName) == true)
{
string strComparisonOp_ExamPaperName = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.ExamPaperName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total_JT.ExamPaperName, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.ExamPaperName, strComparisonOp_ExamPaperName);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total_JT.id_StudentInfo, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.SiteName) == true)
{
string strComparisonOp_SiteName = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.SiteName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total_JT.SiteName, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.SiteName, strComparisonOp_SiteName);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.StuID) == true)
{
string strComparisonOp_StuID = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total_JT.StuID, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.StuID, strComparisonOp_StuID);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.StuName) == true)
{
string strComparisonOp_StuName = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total_JT.StuName, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.StuName, strComparisonOp_StuName);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.ManagedDepartmentId) == true)
{
string strComparisonOp_ManagedDepartmentId = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.ManagedDepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total_JT.ManagedDepartmentId, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.ManagedDepartmentId, strComparisonOp_ManagedDepartmentId);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.ManagedDepartmentName) == true)
{
string strComparisonOp_ManagedDepartmentName = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.ManagedDepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total_JT.ManagedDepartmentName, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.ManagedDepartmentName, strComparisonOp_ManagedDepartmentName);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.JobCategoryId) == true)
{
string strComparisonOp_JobCategoryId = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.JobCategoryId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total_JT.JobCategoryId, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.JobCategoryId, strComparisonOp_JobCategoryId);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.JobCategoryName) == true)
{
string strComparisonOp_JobCategoryName = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.JobCategoryName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total_JT.JobCategoryName, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.JobCategoryName, strComparisonOp_JobCategoryName);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.SexDesc) == true)
{
string strComparisonOp_SexDesc = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total_JT.SexDesc, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.SexDesc, strComparisonOp_SexDesc);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total_JT.id_XzCollege, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total_JT.CollegeName, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total_JT.CollegeNameA, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.BatchTime) == true)
{
string strComparisonOp_BatchTime = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.BatchTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total_JT.BatchTime, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.BatchTime, strComparisonOp_BatchTime);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total_JT.id_CurrEduCls, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.CurrEduClsId) == true)
{
string strComparisonOp_CurrEduClsId = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total_JT.CurrEduClsId, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.CurrEduClsId, strComparisonOp_CurrEduClsId);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.EduClsName) == true)
{
string strComparisonOp_EduClsName = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total_JT.EduClsName, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.EduClsName, strComparisonOp_EduClsName);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum) == true)
{
string strComparisonOp_QuesNum = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela_Total_JT.QuesNum, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.QuesNum, strComparisonOp_QuesNum);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Look) == true)
{
string strComparisonOp_QuesNum_Look = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Look];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Look, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.QuesNum_Look, strComparisonOp_QuesNum_Look);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Mark) == true)
{
string strComparisonOp_QuesNum_Mark = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Mark];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Mark, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.QuesNum_Mark, strComparisonOp_QuesNum_Mark);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_NoFinish) == true)
{
string strComparisonOp_QuesNum_NoFinish = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_NoFinish];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_NoFinish, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.QuesNum_NoFinish, strComparisonOp_QuesNum_NoFinish);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Overdue) == true)
{
string strComparisonOp_QuesNum_Overdue = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Overdue];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Overdue, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.QuesNum_Overdue, strComparisonOp_QuesNum_Overdue);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Save) == true)
{
string strComparisonOp_QuesNum_Save = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Save];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Save, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.QuesNum_Save, strComparisonOp_QuesNum_Save);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_SendBack) == true)
{
string strComparisonOp_QuesNum_SendBack = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_SendBack];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_SendBack, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.QuesNum_SendBack, strComparisonOp_QuesNum_SendBack);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Submit) == true)
{
string strComparisonOp_QuesNum_Submit = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Submit];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Submit, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.QuesNum_Submit, strComparisonOp_QuesNum_Submit);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.TotalScore) == true)
{
string strComparisonOp_TotalScore = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.TotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela_Total_JT.TotalScore, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.TotalScore, strComparisonOp_TotalScore);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.TotalScores) == true)
{
string strComparisonOp_TotalScores = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.TotalScores];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela_Total_JT.TotalScores, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.TotalScores, strComparisonOp_TotalScores);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.SchoolYear) == true)
{
string strComparisonOp_SchoolYear = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total_JT.SchoolYear, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.SchoolYear, strComparisonOp_SchoolYear);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.SchoolTerm) == true)
{
string strComparisonOp_SchoolTerm = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total_JT.SchoolTerm, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.SchoolTerm, strComparisonOp_SchoolTerm);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total_JT.UpdDate, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total_JT.UpdUserId, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvcc_PaperStuBatchQuesRela_Total_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total_JT.Memo) == true)
{
string strComparisonOp_Memo = objvcc_PaperStuBatchQuesRela_Total_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total_JT.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total_JT.Memo, objvcc_PaperStuBatchQuesRela_Total_JT_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v学生试卷完成汇总_JT(vcc_PaperStuBatchQuesRela_Total_JT)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_PaperStuBatchQuesRela_Total_JTWApi
{
private static readonly string mstrApiControllerName = "vcc_PaperStuBatchQuesRela_Total_JTApi";

 public clsvcc_PaperStuBatchQuesRela_Total_JTWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_PaperStuBatchQuesRela_Total">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN GetObjById_PaperStuBatchQuesRela_Total(long lngId_PaperStuBatchQuesRela_Total)
{
string strAction = "GetObjById_PaperStuBatchQuesRela_Total";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_PaperStuBatchQuesRela_Total"] = lngId_PaperStuBatchQuesRela_Total.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN = JsonConvert.DeserializeObject<clsvcc_PaperStuBatchQuesRela_Total_JTEN>((string)jobjReturn["ReturnObj"]);
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
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
 /// <param name = "lngId_PaperStuBatchQuesRela_Total">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN GetObjById_PaperStuBatchQuesRela_Total_WA_Cache(long lngId_PaperStuBatchQuesRela_Total)
{
string strAction = "GetObjById_PaperStuBatchQuesRela_Total_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_PaperStuBatchQuesRela_Total"] = lngId_PaperStuBatchQuesRela_Total.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_PaperStuBatchQuesRela_Total_JTEN = JsonConvert.DeserializeObject<clsvcc_PaperStuBatchQuesRela_Total_JTEN>((string)jobjReturn["ReturnObj"]);
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
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
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTEN = null;
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
objvcc_PaperStuBatchQuesRela_Total_JTEN = JsonConvert.DeserializeObject<clsvcc_PaperStuBatchQuesRela_Total_JTEN>((string)jobjReturn["ReturnObj"]);
return objvcc_PaperStuBatchQuesRela_Total_JTEN;
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
 /// <param name = "lngId_PaperStuBatchQuesRela_Total">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_PaperStuBatchQuesRela_Total_JTEN GetObjById_PaperStuBatchQuesRela_Total_Cache(long lngId_PaperStuBatchQuesRela_Total)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_PaperStuBatchQuesRela_Total_JTEN._CurrTabName_S);
List<clsvcc_PaperStuBatchQuesRela_Total_JTEN> arrvcc_PaperStuBatchQuesRela_Total_JTObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_PaperStuBatchQuesRela_Total_JTEN> arrvcc_PaperStuBatchQuesRela_Total_JTObjLst_Sel =
from objvcc_PaperStuBatchQuesRela_Total_JTEN in arrvcc_PaperStuBatchQuesRela_Total_JTObjLst_Cache
where objvcc_PaperStuBatchQuesRela_Total_JTEN.Id_PaperStuBatchQuesRela_Total == lngId_PaperStuBatchQuesRela_Total
select objvcc_PaperStuBatchQuesRela_Total_JTEN;
if (arrvcc_PaperStuBatchQuesRela_Total_JTObjLst_Sel.Count() == 0)
{
   clsvcc_PaperStuBatchQuesRela_Total_JTEN obj = clsvcc_PaperStuBatchQuesRela_Total_JTWApi.GetObjById_PaperStuBatchQuesRela_Total(lngId_PaperStuBatchQuesRela_Total);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_PaperStuBatchQuesRela_Total_JTObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_PaperStuBatchQuesRela_Total_JTEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_PaperStuBatchQuesRela_Total_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PaperStuBatchQuesRela_Total_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_PaperStuBatchQuesRela_Total_JTEN> GetObjLstById_PaperStuBatchQuesRela_TotalLst(List<long> arrId_PaperStuBatchQuesRela_Total)
{
 List<clsvcc_PaperStuBatchQuesRela_Total_JTEN> arrObjLst = null; 
string strAction = "GetObjLstById_PaperStuBatchQuesRela_TotalLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PaperStuBatchQuesRela_Total);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PaperStuBatchQuesRela_Total_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngId_PaperStuBatchQuesRela_Total">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvcc_PaperStuBatchQuesRela_Total_JTEN> GetObjLstById_PaperStuBatchQuesRela_TotalLst_Cache(List<long> arrId_PaperStuBatchQuesRela_Total)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_PaperStuBatchQuesRela_Total_JTEN._CurrTabName_S);
List<clsvcc_PaperStuBatchQuesRela_Total_JTEN> arrvcc_PaperStuBatchQuesRela_Total_JTObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_PaperStuBatchQuesRela_Total_JTEN> arrvcc_PaperStuBatchQuesRela_Total_JTObjLst_Sel =
from objvcc_PaperStuBatchQuesRela_Total_JTEN in arrvcc_PaperStuBatchQuesRela_Total_JTObjLst_Cache
where arrId_PaperStuBatchQuesRela_Total.Contains(objvcc_PaperStuBatchQuesRela_Total_JTEN.Id_PaperStuBatchQuesRela_Total)
select objvcc_PaperStuBatchQuesRela_Total_JTEN;
return arrvcc_PaperStuBatchQuesRela_Total_JTObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_PaperStuBatchQuesRela_Total_JTEN> GetObjLstById_PaperStuBatchQuesRela_TotalLst_WA_Cache(List<long> arrId_PaperStuBatchQuesRela_Total)
{
 List<clsvcc_PaperStuBatchQuesRela_Total_JTEN> arrObjLst = null; 
string strAction = "GetObjLstById_PaperStuBatchQuesRela_TotalLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PaperStuBatchQuesRela_Total);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PaperStuBatchQuesRela_Total_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_PaperStuBatchQuesRela_Total_JTEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_PaperStuBatchQuesRela_Total_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PaperStuBatchQuesRela_Total_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_PaperStuBatchQuesRela_Total_JTEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_PaperStuBatchQuesRela_Total_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PaperStuBatchQuesRela_Total_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_PaperStuBatchQuesRela_Total_JTEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_PaperStuBatchQuesRela_Total_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PaperStuBatchQuesRela_Total_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_PaperStuBatchQuesRela_Total_JTEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_PaperStuBatchQuesRela_Total_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PaperStuBatchQuesRela_Total_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngId_PaperStuBatchQuesRela_Total)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_PaperStuBatchQuesRela_Total"] = lngId_PaperStuBatchQuesRela_Total.ToString()
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
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTENS">源对象</param>
 /// <param name = "objvcc_PaperStuBatchQuesRela_Total_JTENT">目标对象</param>
 public static void CopyTo(clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTENS, clsvcc_PaperStuBatchQuesRela_Total_JTEN objvcc_PaperStuBatchQuesRela_Total_JTENT)
{
try
{
objvcc_PaperStuBatchQuesRela_Total_JTENT.Id_PaperStuBatchQuesRela_Total = objvcc_PaperStuBatchQuesRela_Total_JTENS.Id_PaperStuBatchQuesRela_Total; //学生试卷完成汇总流水号
objvcc_PaperStuBatchQuesRela_Total_JTENT.Id_PaperStuBatch = objvcc_PaperStuBatchQuesRela_Total_JTENS.Id_PaperStuBatch; //学生试卷批次流水号
objvcc_PaperStuBatchQuesRela_Total_JTENT.CourseExamPaperId = objvcc_PaperStuBatchQuesRela_Total_JTENS.CourseExamPaperId; //考卷流水号
objvcc_PaperStuBatchQuesRela_Total_JTENT.CourseId = objvcc_PaperStuBatchQuesRela_Total_JTENS.CourseId; //课程Id
objvcc_PaperStuBatchQuesRela_Total_JTENT.CourseName = objvcc_PaperStuBatchQuesRela_Total_JTENS.CourseName; //课程名称
objvcc_PaperStuBatchQuesRela_Total_JTENT.ExamPaperName = objvcc_PaperStuBatchQuesRela_Total_JTENS.ExamPaperName; //考卷名称
objvcc_PaperStuBatchQuesRela_Total_JTENT.id_StudentInfo = objvcc_PaperStuBatchQuesRela_Total_JTENS.id_StudentInfo; //学生流水号
objvcc_PaperStuBatchQuesRela_Total_JTENT.SiteName = objvcc_PaperStuBatchQuesRela_Total_JTENS.SiteName; //工地名称
objvcc_PaperStuBatchQuesRela_Total_JTENT.StuID = objvcc_PaperStuBatchQuesRela_Total_JTENS.StuID; //学号
objvcc_PaperStuBatchQuesRela_Total_JTENT.StuName = objvcc_PaperStuBatchQuesRela_Total_JTENS.StuName; //姓名
objvcc_PaperStuBatchQuesRela_Total_JTENT.ManagedDepartmentId = objvcc_PaperStuBatchQuesRela_Total_JTENS.ManagedDepartmentId; //管理的部门Id
objvcc_PaperStuBatchQuesRela_Total_JTENT.ManagedDepartmentName = objvcc_PaperStuBatchQuesRela_Total_JTENS.ManagedDepartmentName; //管理的部门名
objvcc_PaperStuBatchQuesRela_Total_JTENT.JobCategoryId = objvcc_PaperStuBatchQuesRela_Total_JTENS.JobCategoryId; //岗位类别Id
objvcc_PaperStuBatchQuesRela_Total_JTENT.JobCategoryName = objvcc_PaperStuBatchQuesRela_Total_JTENS.JobCategoryName; //岗位类别名
objvcc_PaperStuBatchQuesRela_Total_JTENT.SexDesc = objvcc_PaperStuBatchQuesRela_Total_JTENS.SexDesc; //性别名称
objvcc_PaperStuBatchQuesRela_Total_JTENT.id_XzCollege = objvcc_PaperStuBatchQuesRela_Total_JTENS.id_XzCollege; //学院流水号
objvcc_PaperStuBatchQuesRela_Total_JTENT.CollegeName = objvcc_PaperStuBatchQuesRela_Total_JTENS.CollegeName; //学院名称
objvcc_PaperStuBatchQuesRela_Total_JTENT.CollegeNameA = objvcc_PaperStuBatchQuesRela_Total_JTENS.CollegeNameA; //学院名称简写
objvcc_PaperStuBatchQuesRela_Total_JTENT.BatchTime = objvcc_PaperStuBatchQuesRela_Total_JTENS.BatchTime; //批次
objvcc_PaperStuBatchQuesRela_Total_JTENT.id_CurrEduCls = objvcc_PaperStuBatchQuesRela_Total_JTENS.id_CurrEduCls; //当前教学班流水号
objvcc_PaperStuBatchQuesRela_Total_JTENT.CurrEduClsId = objvcc_PaperStuBatchQuesRela_Total_JTENS.CurrEduClsId; //当前教学班Id
objvcc_PaperStuBatchQuesRela_Total_JTENT.EduClsName = objvcc_PaperStuBatchQuesRela_Total_JTENS.EduClsName; //教学班名称
objvcc_PaperStuBatchQuesRela_Total_JTENT.QuesNum = objvcc_PaperStuBatchQuesRela_Total_JTENS.QuesNum; //题目数
objvcc_PaperStuBatchQuesRela_Total_JTENT.QuesNum_Look = objvcc_PaperStuBatchQuesRela_Total_JTENS.QuesNum_Look; //查看题目数
objvcc_PaperStuBatchQuesRela_Total_JTENT.QuesNum_Mark = objvcc_PaperStuBatchQuesRela_Total_JTENS.QuesNum_Mark; //打分题目数
objvcc_PaperStuBatchQuesRela_Total_JTENT.QuesNum_NoFinish = objvcc_PaperStuBatchQuesRela_Total_JTENS.QuesNum_NoFinish; //未完成题目数
objvcc_PaperStuBatchQuesRela_Total_JTENT.QuesNum_Overdue = objvcc_PaperStuBatchQuesRela_Total_JTENS.QuesNum_Overdue; //逾期题目数
objvcc_PaperStuBatchQuesRela_Total_JTENT.QuesNum_Save = objvcc_PaperStuBatchQuesRela_Total_JTENS.QuesNum_Save; //保存题目数
objvcc_PaperStuBatchQuesRela_Total_JTENT.QuesNum_SendBack = objvcc_PaperStuBatchQuesRela_Total_JTENS.QuesNum_SendBack; //退回题目数
objvcc_PaperStuBatchQuesRela_Total_JTENT.QuesNum_Submit = objvcc_PaperStuBatchQuesRela_Total_JTENS.QuesNum_Submit; //提交题目数
objvcc_PaperStuBatchQuesRela_Total_JTENT.TotalScore = objvcc_PaperStuBatchQuesRela_Total_JTENS.TotalScore; //总得分
objvcc_PaperStuBatchQuesRela_Total_JTENT.TotalScores = objvcc_PaperStuBatchQuesRela_Total_JTENS.TotalScores; //总分值
objvcc_PaperStuBatchQuesRela_Total_JTENT.SchoolYear = objvcc_PaperStuBatchQuesRela_Total_JTENS.SchoolYear; //学年
objvcc_PaperStuBatchQuesRela_Total_JTENT.SchoolTerm = objvcc_PaperStuBatchQuesRela_Total_JTENS.SchoolTerm; //学期
objvcc_PaperStuBatchQuesRela_Total_JTENT.UpdDate = objvcc_PaperStuBatchQuesRela_Total_JTENS.UpdDate; //修改日期
objvcc_PaperStuBatchQuesRela_Total_JTENT.UpdUserId = objvcc_PaperStuBatchQuesRela_Total_JTENS.UpdUserId; //修改用户Id
objvcc_PaperStuBatchQuesRela_Total_JTENT.Memo = objvcc_PaperStuBatchQuesRela_Total_JTENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvcc_PaperStuBatchQuesRela_Total_JTEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_PaperStuBatchQuesRela_Total_JTEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_PaperStuBatchQuesRela_Total_JTEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_PaperStuBatchQuesRela_Total_JTEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_PaperStuBatchQuesRela_Total_JTEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_PaperStuBatchQuesRela_Total_JTEN.AttributeName)
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
if (clscc_PaperStuBatchQuesRela_TotalWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_PaperStuBatchQuesRela_TotalWApi没有刷新缓存机制(clscc_PaperStuBatchQuesRela_TotalWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
//string strWhereCond = string.Format("1 = 1 order by Id_PaperStuBatchQuesRela_Total");
//if (arrvcc_PaperStuBatchQuesRela_Total_JTObjLst_Cache == null)
//{
//arrvcc_PaperStuBatchQuesRela_Total_JTObjLst_Cache = await clsvcc_PaperStuBatchQuesRela_Total_JTWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvcc_PaperStuBatchQuesRela_Total_JTEN._CurrTabName_S);
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
public static List<clsvcc_PaperStuBatchQuesRela_Total_JTEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvcc_PaperStuBatchQuesRela_Total_JTEN._CurrTabName_S);
List<clsvcc_PaperStuBatchQuesRela_Total_JTEN> arrvcc_PaperStuBatchQuesRela_Total_JTObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_PaperStuBatchQuesRela_Total_JTObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_PaperStuBatchQuesRela_Total_JTEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.Id_PaperStuBatchQuesRela_Total, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.Id_PaperStuBatch, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.CourseExamPaperId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.ExamPaperName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.SiteName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.ManagedDepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.ManagedDepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.JobCategoryId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.JobCategoryName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.SexDesc, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.BatchTime, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.CurrEduClsId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.EduClsName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Look, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Mark, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_NoFinish, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Overdue, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Save, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_SendBack, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Submit, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.TotalScore, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.TotalScores, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.SchoolYear, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.SchoolTerm, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total_JT.Memo, Type.GetType("System.String"));
foreach (clsvcc_PaperStuBatchQuesRela_Total_JTEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_PaperStuBatchQuesRela_Total_JT.Id_PaperStuBatchQuesRela_Total] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.Id_PaperStuBatchQuesRela_Total];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.Id_PaperStuBatch] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.Id_PaperStuBatch];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.CourseExamPaperId] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.CourseExamPaperId];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.CourseId] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.CourseId];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.CourseName] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.CourseName];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.ExamPaperName] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.ExamPaperName];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.id_StudentInfo] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.id_StudentInfo];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.SiteName] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.SiteName];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.StuID] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.StuID];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.StuName] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.StuName];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.ManagedDepartmentId] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.ManagedDepartmentId];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.ManagedDepartmentName] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.ManagedDepartmentName];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.JobCategoryId] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.JobCategoryId];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.JobCategoryName] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.JobCategoryName];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.SexDesc] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.SexDesc];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.id_XzCollege] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.id_XzCollege];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.CollegeName] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.CollegeName];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.CollegeNameA] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.CollegeNameA];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.BatchTime] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.BatchTime];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.id_CurrEduCls] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.id_CurrEduCls];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.CurrEduClsId] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.CurrEduClsId];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.EduClsName] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.EduClsName];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Look] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Look];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Mark] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Mark];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_NoFinish] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_NoFinish];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Overdue] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Overdue];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Save] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Save];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_SendBack] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_SendBack];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Submit] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.QuesNum_Submit];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.TotalScore] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.TotalScore];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.TotalScores] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.TotalScores];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.SchoolYear] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.SchoolYear];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.SchoolTerm] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.SchoolTerm];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.UpdDate] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.UpdDate];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.UpdUserId] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.UpdUserId];
objDR[convcc_PaperStuBatchQuesRela_Total_JT.Memo] = objInFor[convcc_PaperStuBatchQuesRela_Total_JT.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}