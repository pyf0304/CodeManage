
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_PaperStuBatchQuesRela_JTWApi
 表名:vcc_PaperStuBatchQuesRela_JT(01120248)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:48:33
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
public static class clsvcc_PaperStuBatchQuesRela_JTWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetId_PaperStuBatchQuesRela(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, long lngId_PaperStuBatchQuesRela, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_JTEN.Id_PaperStuBatchQuesRela = lngId_PaperStuBatchQuesRela; //学生批次题目关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.Id_PaperStuBatchQuesRela) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.Id_PaperStuBatchQuesRela, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.Id_PaperStuBatchQuesRela] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetId_PaperStuBatch(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strId_PaperStuBatch, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strId_PaperStuBatch, convcc_PaperStuBatchQuesRela_JT.Id_PaperStuBatch);
clsCheckSql.CheckFieldLen(strId_PaperStuBatch, 10, convcc_PaperStuBatchQuesRela_JT.Id_PaperStuBatch);
clsCheckSql.CheckFieldForeignKey(strId_PaperStuBatch, 10, convcc_PaperStuBatchQuesRela_JT.Id_PaperStuBatch);
objvcc_PaperStuBatchQuesRela_JTEN.Id_PaperStuBatch = strId_PaperStuBatch; //学生试卷批次流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.Id_PaperStuBatch) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.Id_PaperStuBatch, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.Id_PaperStuBatch] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetCourseExamPaperId(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, convcc_PaperStuBatchQuesRela_JT.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, convcc_PaperStuBatchQuesRela_JT.CourseExamPaperId);
objvcc_PaperStuBatchQuesRela_JTEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.CourseExamPaperId) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.CourseExamPaperId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.CourseExamPaperId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetExamPaperName(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strExamPaperName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamPaperName, 500, convcc_PaperStuBatchQuesRela_JT.ExamPaperName);
objvcc_PaperStuBatchQuesRela_JTEN.ExamPaperName = strExamPaperName; //考卷名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.ExamPaperName) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.ExamPaperName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.ExamPaperName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetExamPaperTypeId(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strExamPaperTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamPaperTypeId, 2, convcc_PaperStuBatchQuesRela_JT.ExamPaperTypeId);
clsCheckSql.CheckFieldForeignKey(strExamPaperTypeId, 2, convcc_PaperStuBatchQuesRela_JT.ExamPaperTypeId);
objvcc_PaperStuBatchQuesRela_JTEN.ExamPaperTypeId = strExamPaperTypeId; //试卷类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.ExamPaperTypeId) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.ExamPaperTypeId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.ExamPaperTypeId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN Setid_StudentInfo(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, convcc_PaperStuBatchQuesRela_JT.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, convcc_PaperStuBatchQuesRela_JT.id_StudentInfo);
objvcc_PaperStuBatchQuesRela_JTEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.id_StudentInfo) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.id_StudentInfo, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.id_StudentInfo] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetSiteName(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strSiteName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSiteName, 100, convcc_PaperStuBatchQuesRela_JT.SiteName);
objvcc_PaperStuBatchQuesRela_JTEN.SiteName = strSiteName; //工地名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.SiteName) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.SiteName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.SiteName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetStuID(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convcc_PaperStuBatchQuesRela_JT.StuID);
objvcc_PaperStuBatchQuesRela_JTEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.StuID) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.StuID, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.StuID] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetStuName(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convcc_PaperStuBatchQuesRela_JT.StuName);
objvcc_PaperStuBatchQuesRela_JTEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.StuName) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.StuName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.StuName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetManagedDepartmentId(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strManagedDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strManagedDepartmentId, 4, convcc_PaperStuBatchQuesRela_JT.ManagedDepartmentId);
clsCheckSql.CheckFieldForeignKey(strManagedDepartmentId, 4, convcc_PaperStuBatchQuesRela_JT.ManagedDepartmentId);
objvcc_PaperStuBatchQuesRela_JTEN.ManagedDepartmentId = strManagedDepartmentId; //管理的部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.ManagedDepartmentId) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.ManagedDepartmentId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.ManagedDepartmentId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetManagedDepartmentName(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strManagedDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strManagedDepartmentName, 50, convcc_PaperStuBatchQuesRela_JT.ManagedDepartmentName);
objvcc_PaperStuBatchQuesRela_JTEN.ManagedDepartmentName = strManagedDepartmentName; //管理的部门名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.ManagedDepartmentName) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.ManagedDepartmentName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.ManagedDepartmentName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetJobCategoryId(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strJobCategoryId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strJobCategoryId, 2, convcc_PaperStuBatchQuesRela_JT.JobCategoryId);
clsCheckSql.CheckFieldForeignKey(strJobCategoryId, 2, convcc_PaperStuBatchQuesRela_JT.JobCategoryId);
objvcc_PaperStuBatchQuesRela_JTEN.JobCategoryId = strJobCategoryId; //岗位类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.JobCategoryId) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.JobCategoryId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.JobCategoryId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetJobCategoryName(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strJobCategoryName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strJobCategoryName, 50, convcc_PaperStuBatchQuesRela_JT.JobCategoryName);
objvcc_PaperStuBatchQuesRela_JTEN.JobCategoryName = strJobCategoryName; //岗位类别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.JobCategoryName) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.JobCategoryName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.JobCategoryName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN Setid_XzCollege(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convcc_PaperStuBatchQuesRela_JT.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convcc_PaperStuBatchQuesRela_JT.id_XzCollege);
objvcc_PaperStuBatchQuesRela_JTEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.id_XzCollege) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.id_XzCollege, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.id_XzCollege] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetCollegeName(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convcc_PaperStuBatchQuesRela_JT.CollegeName);
objvcc_PaperStuBatchQuesRela_JTEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.CollegeName) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.CollegeName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.CollegeName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetCollegeNameA(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convcc_PaperStuBatchQuesRela_JT.CollegeNameA);
objvcc_PaperStuBatchQuesRela_JTEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.CollegeNameA) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.CollegeNameA, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.CollegeNameA] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetBatchTime(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strBatchTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBatchTime, 14, convcc_PaperStuBatchQuesRela_JT.BatchTime);
objvcc_PaperStuBatchQuesRela_JTEN.BatchTime = strBatchTime; //批次
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.BatchTime) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.BatchTime, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.BatchTime] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN Setid_CurrEduCls(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convcc_PaperStuBatchQuesRela_JT.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convcc_PaperStuBatchQuesRela_JT.id_CurrEduCls);
objvcc_PaperStuBatchQuesRela_JTEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.id_CurrEduCls) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.id_CurrEduCls, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.id_CurrEduCls] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetEduClsName(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convcc_PaperStuBatchQuesRela_JT.EduClsName);
objvcc_PaperStuBatchQuesRela_JTEN.EduClsName = strEduClsName; //教学班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.EduClsName) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.EduClsName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.EduClsName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetQuestionID(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionID, 8, convcc_PaperStuBatchQuesRela_JT.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convcc_PaperStuBatchQuesRela_JT.QuestionID);
objvcc_PaperStuBatchQuesRela_JTEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.QuestionID) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.QuestionID, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.QuestionID] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetQuestionIndex(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, int intQuestionIndex, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_JTEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.QuestionIndex) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.QuestionIndex, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.QuestionIndex] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetQuestionName(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strQuestionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionName, 1000, convcc_PaperStuBatchQuesRela_JT.QuestionName);
objvcc_PaperStuBatchQuesRela_JTEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.QuestionName) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.QuestionName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.QuestionName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetQuestionContent(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strQuestionContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionContent, 4000, convcc_PaperStuBatchQuesRela_JT.QuestionContent);
objvcc_PaperStuBatchQuesRela_JTEN.QuestionContent = strQuestionContent; //题目内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.QuestionContent) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.QuestionContent, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.QuestionContent] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetCourseId(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_PaperStuBatchQuesRela_JT.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_PaperStuBatchQuesRela_JT.CourseId);
objvcc_PaperStuBatchQuesRela_JTEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.CourseId) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.CourseId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.CourseId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetCourseName(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_PaperStuBatchQuesRela_JT.CourseName);
objvcc_PaperStuBatchQuesRela_JTEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.CourseName) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.CourseName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.CourseName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetCourseChapterId(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_PaperStuBatchQuesRela_JT.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_PaperStuBatchQuesRela_JT.CourseChapterId);
objvcc_PaperStuBatchQuesRela_JTEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.CourseChapterId) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.CourseChapterId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.CourseChapterId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetCourseChapterName(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_PaperStuBatchQuesRela_JT.CourseChapterName);
objvcc_PaperStuBatchQuesRela_JTEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.CourseChapterName) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.CourseChapterName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.CourseChapterName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetChapterName(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_PaperStuBatchQuesRela_JT.ChapterName);
objvcc_PaperStuBatchQuesRela_JTEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.ChapterName) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.ChapterName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.ChapterName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetSectionName(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_PaperStuBatchQuesRela_JT.SectionName);
objvcc_PaperStuBatchQuesRela_JTEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.SectionName) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.SectionName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.SectionName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetChapterName_Sim(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convcc_PaperStuBatchQuesRela_JT.ChapterName_Sim);
objvcc_PaperStuBatchQuesRela_JTEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.ChapterName_Sim) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.ChapterName_Sim, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.ChapterName_Sim] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetSectionName_Sim(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, convcc_PaperStuBatchQuesRela_JT.SectionName_Sim);
objvcc_PaperStuBatchQuesRela_JTEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.SectionName_Sim) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.SectionName_Sim, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.SectionName_Sim] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetParentNodeID(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convcc_PaperStuBatchQuesRela_JT.ParentNodeID);
objvcc_PaperStuBatchQuesRela_JTEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.ParentNodeID) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.ParentNodeID, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.ParentNodeID] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetCourseChapterReferred(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strCourseChapterReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convcc_PaperStuBatchQuesRela_JT.CourseChapterReferred);
objvcc_PaperStuBatchQuesRela_JTEN.CourseChapterReferred = strCourseChapterReferred; //节简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.CourseChapterReferred) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.CourseChapterReferred, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.CourseChapterReferred] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetParentNodeName(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strParentNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convcc_PaperStuBatchQuesRela_JT.ParentNodeName);
objvcc_PaperStuBatchQuesRela_JTEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.ParentNodeName) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.ParentNodeName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.ParentNodeName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetParentNodeReferred(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strParentNodeReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convcc_PaperStuBatchQuesRela_JT.ParentNodeReferred);
objvcc_PaperStuBatchQuesRela_JTEN.ParentNodeReferred = strParentNodeReferred; //章简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.ParentNodeReferred) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.ParentNodeReferred, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.ParentNodeReferred] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetQuestionTypeId(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convcc_PaperStuBatchQuesRela_JT.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convcc_PaperStuBatchQuesRela_JT.QuestionTypeId);
objvcc_PaperStuBatchQuesRela_JTEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.QuestionTypeId) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.QuestionTypeId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.QuestionTypeId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetQuestionTypeName(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strQuestionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convcc_PaperStuBatchQuesRela_JT.QuestionTypeName);
objvcc_PaperStuBatchQuesRela_JTEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.QuestionTypeName) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.QuestionTypeName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.QuestionTypeName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetAnswerTypeId(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strAnswerTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convcc_PaperStuBatchQuesRela_JT.AnswerTypeId);
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convcc_PaperStuBatchQuesRela_JT.AnswerTypeId);
objvcc_PaperStuBatchQuesRela_JTEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.AnswerTypeId) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.AnswerTypeId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.AnswerTypeId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetDefaultValue(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strDefaultValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convcc_PaperStuBatchQuesRela_JT.DefaultValue);
objvcc_PaperStuBatchQuesRela_JTEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.DefaultValue) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.DefaultValue, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.DefaultValue] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetTextDirectId(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strTextDirectId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTextDirectId, 4, convcc_PaperStuBatchQuesRela_JT.TextDirectId);
clsCheckSql.CheckFieldForeignKey(strTextDirectId, 4, convcc_PaperStuBatchQuesRela_JT.TextDirectId);
objvcc_PaperStuBatchQuesRela_JTEN.TextDirectId = strTextDirectId; //文本方向ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.TextDirectId) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.TextDirectId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.TextDirectId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetRelaEvent(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strRelaEvent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaEvent, 4000, convcc_PaperStuBatchQuesRela_JT.RelaEvent);
objvcc_PaperStuBatchQuesRela_JTEN.RelaEvent = strRelaEvent; //相关事件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.RelaEvent) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.RelaEvent, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.RelaEvent] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetCheckBoxLimitCount(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, int intCheckBoxLimitCount, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_JTEN.CheckBoxLimitCount = intCheckBoxLimitCount; //复选框限制数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.CheckBoxLimitCount) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.CheckBoxLimitCount, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.CheckBoxLimitCount] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetAnswerAttLimitSize(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, long lngAnswerAttLimitSize, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_JTEN.AnswerAttLimitSize = lngAnswerAttLimitSize; //回答附件限制大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.AnswerAttLimitSize) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.AnswerAttLimitSize, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.AnswerAttLimitSize] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetLimitedResourceType(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strLimitedResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLimitedResourceType, 100, convcc_PaperStuBatchQuesRela_JT.LimitedResourceType);
objvcc_PaperStuBatchQuesRela_JTEN.LimitedResourceType = strLimitedResourceType; //限制资源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.LimitedResourceType) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.LimitedResourceType, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.LimitedResourceType] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetQuestionIndex4Batch(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, int intQuestionIndex4Batch, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_JTEN.QuestionIndex4Batch = intQuestionIndex4Batch; //题序号4批次
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.QuestionIndex4Batch) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.QuestionIndex4Batch, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.QuestionIndex4Batch] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetScores(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, double dblScores, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_JTEN.Scores = dblScores; //分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.Scores) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.Scores, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.Scores] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetScore(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, double dblScore, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_JTEN.Score = dblScore; //得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.Score) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.Score, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.Score] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetStuAnswerText(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strStuAnswerText, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_JTEN.StuAnswerText = strStuAnswerText; //学生回答文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.StuAnswerText) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.StuAnswerText, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.StuAnswerText] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetAnswerDate(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strAnswerDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerDate, 8, convcc_PaperStuBatchQuesRela_JT.AnswerDate);
objvcc_PaperStuBatchQuesRela_JTEN.AnswerDate = strAnswerDate; //回答日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.AnswerDate) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.AnswerDate, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.AnswerDate] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetAnswerIP(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strAnswerIP, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerIP, 30, convcc_PaperStuBatchQuesRela_JT.AnswerIP);
objvcc_PaperStuBatchQuesRela_JTEN.AnswerIP = strAnswerIP; //回答IP
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.AnswerIP) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.AnswerIP, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.AnswerIP] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetAnswerModeId(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strAnswerModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, convcc_PaperStuBatchQuesRela_JT.AnswerModeId);
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, convcc_PaperStuBatchQuesRela_JT.AnswerModeId);
objvcc_PaperStuBatchQuesRela_JTEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.AnswerModeId) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.AnswerModeId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.AnswerModeId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetAnswerMultiOptions(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strAnswerMultiOptions, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerMultiOptions, 300, convcc_PaperStuBatchQuesRela_JT.AnswerMultiOptions);
objvcc_PaperStuBatchQuesRela_JTEN.AnswerMultiOptions = strAnswerMultiOptions; //多选项答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.AnswerMultiOptions) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.AnswerMultiOptions, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.AnswerMultiOptions] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetAnswerOptionId(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strAnswerOptionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerOptionId, 8, convcc_PaperStuBatchQuesRela_JT.AnswerOptionId);
clsCheckSql.CheckFieldForeignKey(strAnswerOptionId, 8, convcc_PaperStuBatchQuesRela_JT.AnswerOptionId);
objvcc_PaperStuBatchQuesRela_JTEN.AnswerOptionId = strAnswerOptionId; //回答选项Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.AnswerOptionId) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.AnswerOptionId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.AnswerOptionId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetAnswerTime(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strAnswerTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTime, 10, convcc_PaperStuBatchQuesRela_JT.AnswerTime);
objvcc_PaperStuBatchQuesRela_JTEN.AnswerTime = strAnswerTime; //回答时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.AnswerTime) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.AnswerTime, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.AnswerTime] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetApplySendBackDate(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strApplySendBackDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplySendBackDate, 14, convcc_PaperStuBatchQuesRela_JT.ApplySendBackDate);
objvcc_PaperStuBatchQuesRela_JTEN.ApplySendBackDate = strApplySendBackDate; //申请退回日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.ApplySendBackDate) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.ApplySendBackDate, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.ApplySendBackDate] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetComment(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strComment, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_JTEN.Comment = strComment; //批注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.Comment) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.Comment, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.Comment] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetIsAccessKnowledge(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, bool bolIsAccessKnowledge, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_JTEN.IsAccessKnowledge = bolIsAccessKnowledge; //是否处理知识点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.IsAccessKnowledge) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.IsAccessKnowledge, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.IsAccessKnowledge] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetIsApplySendBack(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, bool bolIsApplySendBack, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_JTEN.IsApplySendBack = bolIsApplySendBack; //是否申请退回
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.IsApplySendBack) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.IsApplySendBack, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.IsApplySendBack] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetIsInErrorQuestion(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, bool bolIsInErrorQuestion, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_JTEN.IsInErrorQuestion = bolIsInErrorQuestion; //是否进入错题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.IsInErrorQuestion) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.IsInErrorQuestion, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.IsInErrorQuestion] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetIsLook(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, bool bolIsLook, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_JTEN.IsLook = bolIsLook; //是否查看
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.IsLook) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.IsLook, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.IsLook] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetIsMarking(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, bool bolIsMarking, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_JTEN.IsMarking = bolIsMarking; //是否批阅
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.IsMarking) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.IsMarking, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.IsMarking] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetIsNotProcessTimeout(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, bool bolIsNotProcessTimeout, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_JTEN.IsNotProcessTimeout = bolIsNotProcessTimeout; //是否不处理超时
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.IsNotProcessTimeout) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.IsNotProcessTimeout, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.IsNotProcessTimeout] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetIsPublish(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, bool bolIsPublish, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_JTEN.IsPublish = bolIsPublish; //是否发布
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.IsPublish) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.IsPublish, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.IsPublish] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetIsRight(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, bool bolIsRight, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_JTEN.IsRight = bolIsRight; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.IsRight) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.IsRight, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.IsRight] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetIsSave(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, bool bolIsSave, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_JTEN.IsSave = bolIsSave; //是否保存
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.IsSave) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.IsSave, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.IsSave] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetIsSendBack(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, bool bolIsSendBack, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_JTEN.IsSendBack = bolIsSendBack; //是否退回
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.IsSendBack) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.IsSendBack, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.IsSendBack] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetIsSubmit(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_JTEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.IsSubmit) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.IsSubmit, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.IsSubmit] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetMarkDate(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strMarkDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkDate, 14, convcc_PaperStuBatchQuesRela_JT.MarkDate);
objvcc_PaperStuBatchQuesRela_JTEN.MarkDate = strMarkDate; //打分日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.MarkDate) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.MarkDate, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.MarkDate] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetMarkerId(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strMarkerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkerId, 20, convcc_PaperStuBatchQuesRela_JT.MarkerId);
objvcc_PaperStuBatchQuesRela_JTEN.MarkerId = strMarkerId; //打分者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.MarkerId) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.MarkerId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.MarkerId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetOperateTime(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strOperateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOperateTime, 14, convcc_PaperStuBatchQuesRela_JT.OperateTime);
objvcc_PaperStuBatchQuesRela_JTEN.OperateTime = strOperateTime; //操作时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.OperateTime) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.OperateTime, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.OperateTime] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetRealFinishDate(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strRealFinishDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRealFinishDate, 14, convcc_PaperStuBatchQuesRela_JT.RealFinishDate);
objvcc_PaperStuBatchQuesRela_JTEN.RealFinishDate = strRealFinishDate; //实际完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.RealFinishDate) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.RealFinishDate, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.RealFinishDate] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetSchoolYear(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strSchoolYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, convcc_PaperStuBatchQuesRela_JT.SchoolYear);
objvcc_PaperStuBatchQuesRela_JTEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.SchoolYear) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.SchoolYear, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.SchoolYear] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetSchoolTerm(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, convcc_PaperStuBatchQuesRela_JT.SchoolTerm);
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, convcc_PaperStuBatchQuesRela_JT.SchoolTerm);
objvcc_PaperStuBatchQuesRela_JTEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.SchoolTerm) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.SchoolTerm, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.SchoolTerm] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetErrMsg(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrMsg, 200, convcc_PaperStuBatchQuesRela_JT.ErrMsg);
objvcc_PaperStuBatchQuesRela_JTEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.ErrMsg) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.ErrMsg, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.ErrMsg] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetUpdDate(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_PaperStuBatchQuesRela_JT.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_PaperStuBatchQuesRela_JT.UpdDate);
objvcc_PaperStuBatchQuesRela_JTEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.UpdDate) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.UpdDate, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.UpdDate] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetUpdUserId(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_PaperStuBatchQuesRela_JT.UpdUserId);
objvcc_PaperStuBatchQuesRela_JTEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.UpdUserId) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.UpdUserId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.UpdUserId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetMemo(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_PaperStuBatchQuesRela_JT.Memo);
objvcc_PaperStuBatchQuesRela_JTEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.Memo) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.Memo, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.Memo] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN SetIsMarkingName(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN, string strIsMarkingName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIsMarkingName, convcc_PaperStuBatchQuesRela_JT.IsMarkingName);
clsCheckSql.CheckFieldLen(strIsMarkingName, 2, convcc_PaperStuBatchQuesRela_JT.IsMarkingName);
objvcc_PaperStuBatchQuesRela_JTEN.IsMarkingName = strIsMarkingName; //IsMarkingName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_JT.IsMarkingName) == false)
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_JT.IsMarkingName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_JTEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.IsMarkingName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_JTEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JT_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.Id_PaperStuBatchQuesRela) == true)
{
string strComparisonOp_Id_PaperStuBatchQuesRela = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.Id_PaperStuBatchQuesRela];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela_JT.Id_PaperStuBatchQuesRela, objvcc_PaperStuBatchQuesRela_JT_Cond.Id_PaperStuBatchQuesRela, strComparisonOp_Id_PaperStuBatchQuesRela);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.Id_PaperStuBatch) == true)
{
string strComparisonOp_Id_PaperStuBatch = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.Id_PaperStuBatch];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.Id_PaperStuBatch, objvcc_PaperStuBatchQuesRela_JT_Cond.Id_PaperStuBatch, strComparisonOp_Id_PaperStuBatch);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.CourseExamPaperId) == true)
{
string strComparisonOp_CourseExamPaperId = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.CourseExamPaperId, objvcc_PaperStuBatchQuesRela_JT_Cond.CourseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.ExamPaperName) == true)
{
string strComparisonOp_ExamPaperName = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.ExamPaperName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.ExamPaperName, objvcc_PaperStuBatchQuesRela_JT_Cond.ExamPaperName, strComparisonOp_ExamPaperName);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.ExamPaperTypeId) == true)
{
string strComparisonOp_ExamPaperTypeId = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.ExamPaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.ExamPaperTypeId, objvcc_PaperStuBatchQuesRela_JT_Cond.ExamPaperTypeId, strComparisonOp_ExamPaperTypeId);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.id_StudentInfo, objvcc_PaperStuBatchQuesRela_JT_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.SiteName) == true)
{
string strComparisonOp_SiteName = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.SiteName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.SiteName, objvcc_PaperStuBatchQuesRela_JT_Cond.SiteName, strComparisonOp_SiteName);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.StuID) == true)
{
string strComparisonOp_StuID = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.StuID, objvcc_PaperStuBatchQuesRela_JT_Cond.StuID, strComparisonOp_StuID);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.StuName) == true)
{
string strComparisonOp_StuName = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.StuName, objvcc_PaperStuBatchQuesRela_JT_Cond.StuName, strComparisonOp_StuName);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.ManagedDepartmentId) == true)
{
string strComparisonOp_ManagedDepartmentId = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.ManagedDepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.ManagedDepartmentId, objvcc_PaperStuBatchQuesRela_JT_Cond.ManagedDepartmentId, strComparisonOp_ManagedDepartmentId);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.ManagedDepartmentName) == true)
{
string strComparisonOp_ManagedDepartmentName = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.ManagedDepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.ManagedDepartmentName, objvcc_PaperStuBatchQuesRela_JT_Cond.ManagedDepartmentName, strComparisonOp_ManagedDepartmentName);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.JobCategoryId) == true)
{
string strComparisonOp_JobCategoryId = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.JobCategoryId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.JobCategoryId, objvcc_PaperStuBatchQuesRela_JT_Cond.JobCategoryId, strComparisonOp_JobCategoryId);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.JobCategoryName) == true)
{
string strComparisonOp_JobCategoryName = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.JobCategoryName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.JobCategoryName, objvcc_PaperStuBatchQuesRela_JT_Cond.JobCategoryName, strComparisonOp_JobCategoryName);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.id_XzCollege, objvcc_PaperStuBatchQuesRela_JT_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.CollegeName, objvcc_PaperStuBatchQuesRela_JT_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.CollegeNameA, objvcc_PaperStuBatchQuesRela_JT_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.BatchTime) == true)
{
string strComparisonOp_BatchTime = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.BatchTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.BatchTime, objvcc_PaperStuBatchQuesRela_JT_Cond.BatchTime, strComparisonOp_BatchTime);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.id_CurrEduCls, objvcc_PaperStuBatchQuesRela_JT_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.EduClsName) == true)
{
string strComparisonOp_EduClsName = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.EduClsName, objvcc_PaperStuBatchQuesRela_JT_Cond.EduClsName, strComparisonOp_EduClsName);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.QuestionID) == true)
{
string strComparisonOp_QuestionID = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.QuestionID, objvcc_PaperStuBatchQuesRela_JT_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.QuestionIndex) == true)
{
string strComparisonOp_QuestionIndex = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela_JT.QuestionIndex, objvcc_PaperStuBatchQuesRela_JT_Cond.QuestionIndex, strComparisonOp_QuestionIndex);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.QuestionName) == true)
{
string strComparisonOp_QuestionName = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.QuestionName, objvcc_PaperStuBatchQuesRela_JT_Cond.QuestionName, strComparisonOp_QuestionName);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.QuestionContent) == true)
{
string strComparisonOp_QuestionContent = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.QuestionContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.QuestionContent, objvcc_PaperStuBatchQuesRela_JT_Cond.QuestionContent, strComparisonOp_QuestionContent);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.CourseId, objvcc_PaperStuBatchQuesRela_JT_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.CourseName, objvcc_PaperStuBatchQuesRela_JT_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.CourseChapterId, objvcc_PaperStuBatchQuesRela_JT_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.CourseChapterName, objvcc_PaperStuBatchQuesRela_JT_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.ChapterName, objvcc_PaperStuBatchQuesRela_JT_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.SectionName) == true)
{
string strComparisonOp_SectionName = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.SectionName, objvcc_PaperStuBatchQuesRela_JT_Cond.SectionName, strComparisonOp_SectionName);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.ChapterName_Sim, objvcc_PaperStuBatchQuesRela_JT_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.SectionName_Sim, objvcc_PaperStuBatchQuesRela_JT_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.ParentNodeID, objvcc_PaperStuBatchQuesRela_JT_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.CourseChapterReferred) == true)
{
string strComparisonOp_CourseChapterReferred = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.CourseChapterReferred, objvcc_PaperStuBatchQuesRela_JT_Cond.CourseChapterReferred, strComparisonOp_CourseChapterReferred);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.ParentNodeName) == true)
{
string strComparisonOp_ParentNodeName = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.ParentNodeName, objvcc_PaperStuBatchQuesRela_JT_Cond.ParentNodeName, strComparisonOp_ParentNodeName);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.ParentNodeReferred) == true)
{
string strComparisonOp_ParentNodeReferred = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.ParentNodeReferred, objvcc_PaperStuBatchQuesRela_JT_Cond.ParentNodeReferred, strComparisonOp_ParentNodeReferred);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.QuestionTypeId, objvcc_PaperStuBatchQuesRela_JT_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.QuestionTypeName) == true)
{
string strComparisonOp_QuestionTypeName = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.QuestionTypeName, objvcc_PaperStuBatchQuesRela_JT_Cond.QuestionTypeName, strComparisonOp_QuestionTypeName);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.AnswerTypeId) == true)
{
string strComparisonOp_AnswerTypeId = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.AnswerTypeId, objvcc_PaperStuBatchQuesRela_JT_Cond.AnswerTypeId, strComparisonOp_AnswerTypeId);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.DefaultValue) == true)
{
string strComparisonOp_DefaultValue = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.DefaultValue, objvcc_PaperStuBatchQuesRela_JT_Cond.DefaultValue, strComparisonOp_DefaultValue);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.TextDirectId) == true)
{
string strComparisonOp_TextDirectId = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.TextDirectId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.TextDirectId, objvcc_PaperStuBatchQuesRela_JT_Cond.TextDirectId, strComparisonOp_TextDirectId);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.RelaEvent) == true)
{
string strComparisonOp_RelaEvent = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.RelaEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.RelaEvent, objvcc_PaperStuBatchQuesRela_JT_Cond.RelaEvent, strComparisonOp_RelaEvent);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.CheckBoxLimitCount) == true)
{
string strComparisonOp_CheckBoxLimitCount = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.CheckBoxLimitCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela_JT.CheckBoxLimitCount, objvcc_PaperStuBatchQuesRela_JT_Cond.CheckBoxLimitCount, strComparisonOp_CheckBoxLimitCount);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.AnswerAttLimitSize) == true)
{
string strComparisonOp_AnswerAttLimitSize = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.AnswerAttLimitSize];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela_JT.AnswerAttLimitSize, objvcc_PaperStuBatchQuesRela_JT_Cond.AnswerAttLimitSize, strComparisonOp_AnswerAttLimitSize);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.LimitedResourceType) == true)
{
string strComparisonOp_LimitedResourceType = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.LimitedResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.LimitedResourceType, objvcc_PaperStuBatchQuesRela_JT_Cond.LimitedResourceType, strComparisonOp_LimitedResourceType);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.QuestionIndex4Batch) == true)
{
string strComparisonOp_QuestionIndex4Batch = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.QuestionIndex4Batch];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela_JT.QuestionIndex4Batch, objvcc_PaperStuBatchQuesRela_JT_Cond.QuestionIndex4Batch, strComparisonOp_QuestionIndex4Batch);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.Scores) == true)
{
string strComparisonOp_Scores = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.Scores];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela_JT.Scores, objvcc_PaperStuBatchQuesRela_JT_Cond.Scores, strComparisonOp_Scores);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.Score) == true)
{
string strComparisonOp_Score = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela_JT.Score, objvcc_PaperStuBatchQuesRela_JT_Cond.Score, strComparisonOp_Score);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.AnswerDate) == true)
{
string strComparisonOp_AnswerDate = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.AnswerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.AnswerDate, objvcc_PaperStuBatchQuesRela_JT_Cond.AnswerDate, strComparisonOp_AnswerDate);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.AnswerIP) == true)
{
string strComparisonOp_AnswerIP = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.AnswerIP];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.AnswerIP, objvcc_PaperStuBatchQuesRela_JT_Cond.AnswerIP, strComparisonOp_AnswerIP);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.AnswerModeId) == true)
{
string strComparisonOp_AnswerModeId = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.AnswerModeId, objvcc_PaperStuBatchQuesRela_JT_Cond.AnswerModeId, strComparisonOp_AnswerModeId);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.AnswerMultiOptions) == true)
{
string strComparisonOp_AnswerMultiOptions = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.AnswerMultiOptions];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.AnswerMultiOptions, objvcc_PaperStuBatchQuesRela_JT_Cond.AnswerMultiOptions, strComparisonOp_AnswerMultiOptions);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.AnswerOptionId) == true)
{
string strComparisonOp_AnswerOptionId = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.AnswerOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.AnswerOptionId, objvcc_PaperStuBatchQuesRela_JT_Cond.AnswerOptionId, strComparisonOp_AnswerOptionId);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.AnswerTime) == true)
{
string strComparisonOp_AnswerTime = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.AnswerTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.AnswerTime, objvcc_PaperStuBatchQuesRela_JT_Cond.AnswerTime, strComparisonOp_AnswerTime);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.ApplySendBackDate) == true)
{
string strComparisonOp_ApplySendBackDate = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.ApplySendBackDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.ApplySendBackDate, objvcc_PaperStuBatchQuesRela_JT_Cond.ApplySendBackDate, strComparisonOp_ApplySendBackDate);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.IsAccessKnowledge) == true)
{
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsAccessKnowledge == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_PaperStuBatchQuesRela_JT.IsAccessKnowledge);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_PaperStuBatchQuesRela_JT.IsAccessKnowledge);
}
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.IsApplySendBack) == true)
{
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsApplySendBack == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_PaperStuBatchQuesRela_JT.IsApplySendBack);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_PaperStuBatchQuesRela_JT.IsApplySendBack);
}
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.IsInErrorQuestion) == true)
{
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsInErrorQuestion == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_PaperStuBatchQuesRela_JT.IsInErrorQuestion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_PaperStuBatchQuesRela_JT.IsInErrorQuestion);
}
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.IsLook) == true)
{
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsLook == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_PaperStuBatchQuesRela_JT.IsLook);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_PaperStuBatchQuesRela_JT.IsLook);
}
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.IsMarking) == true)
{
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsMarking == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_PaperStuBatchQuesRela_JT.IsMarking);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_PaperStuBatchQuesRela_JT.IsMarking);
}
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.IsNotProcessTimeout) == true)
{
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsNotProcessTimeout == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_PaperStuBatchQuesRela_JT.IsNotProcessTimeout);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_PaperStuBatchQuesRela_JT.IsNotProcessTimeout);
}
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.IsPublish) == true)
{
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsPublish == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_PaperStuBatchQuesRela_JT.IsPublish);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_PaperStuBatchQuesRela_JT.IsPublish);
}
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.IsRight) == true)
{
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_PaperStuBatchQuesRela_JT.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_PaperStuBatchQuesRela_JT.IsRight);
}
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.IsSave) == true)
{
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsSave == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_PaperStuBatchQuesRela_JT.IsSave);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_PaperStuBatchQuesRela_JT.IsSave);
}
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.IsSendBack) == true)
{
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsSendBack == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_PaperStuBatchQuesRela_JT.IsSendBack);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_PaperStuBatchQuesRela_JT.IsSendBack);
}
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.IsSubmit) == true)
{
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_PaperStuBatchQuesRela_JT.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_PaperStuBatchQuesRela_JT.IsSubmit);
}
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.MarkDate) == true)
{
string strComparisonOp_MarkDate = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.MarkDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.MarkDate, objvcc_PaperStuBatchQuesRela_JT_Cond.MarkDate, strComparisonOp_MarkDate);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.MarkerId) == true)
{
string strComparisonOp_MarkerId = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.MarkerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.MarkerId, objvcc_PaperStuBatchQuesRela_JT_Cond.MarkerId, strComparisonOp_MarkerId);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.OperateTime) == true)
{
string strComparisonOp_OperateTime = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.OperateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.OperateTime, objvcc_PaperStuBatchQuesRela_JT_Cond.OperateTime, strComparisonOp_OperateTime);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.RealFinishDate) == true)
{
string strComparisonOp_RealFinishDate = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.RealFinishDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.RealFinishDate, objvcc_PaperStuBatchQuesRela_JT_Cond.RealFinishDate, strComparisonOp_RealFinishDate);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.SchoolYear) == true)
{
string strComparisonOp_SchoolYear = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.SchoolYear, objvcc_PaperStuBatchQuesRela_JT_Cond.SchoolYear, strComparisonOp_SchoolYear);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.SchoolTerm) == true)
{
string strComparisonOp_SchoolTerm = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.SchoolTerm, objvcc_PaperStuBatchQuesRela_JT_Cond.SchoolTerm, strComparisonOp_SchoolTerm);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.ErrMsg) == true)
{
string strComparisonOp_ErrMsg = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.ErrMsg, objvcc_PaperStuBatchQuesRela_JT_Cond.ErrMsg, strComparisonOp_ErrMsg);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.UpdDate, objvcc_PaperStuBatchQuesRela_JT_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.UpdUserId, objvcc_PaperStuBatchQuesRela_JT_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.Memo) == true)
{
string strComparisonOp_Memo = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.Memo, objvcc_PaperStuBatchQuesRela_JT_Cond.Memo, strComparisonOp_Memo);
}
if (objvcc_PaperStuBatchQuesRela_JT_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_JT.IsMarkingName) == true)
{
string strComparisonOp_IsMarkingName = objvcc_PaperStuBatchQuesRela_JT_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_JT.IsMarkingName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_JT.IsMarkingName, objvcc_PaperStuBatchQuesRela_JT_Cond.IsMarkingName, strComparisonOp_IsMarkingName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v学生批次题目关系_JT(vcc_PaperStuBatchQuesRela_JT)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_PaperStuBatchQuesRela_JTWApi
{
private static readonly string mstrApiControllerName = "vcc_PaperStuBatchQuesRela_JTApi";

 public clsvcc_PaperStuBatchQuesRela_JTWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_PaperStuBatchQuesRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN GetObjById_PaperStuBatchQuesRela(long lngId_PaperStuBatchQuesRela)
{
string strAction = "GetObjById_PaperStuBatchQuesRela";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_PaperStuBatchQuesRela"] = lngId_PaperStuBatchQuesRela.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_PaperStuBatchQuesRela_JTEN = JsonConvert.DeserializeObject<clsvcc_PaperStuBatchQuesRela_JTEN>((string)jobjReturn["ReturnObj"]);
return objvcc_PaperStuBatchQuesRela_JTEN;
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
 /// <param name = "lngId_PaperStuBatchQuesRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN GetObjById_PaperStuBatchQuesRela_WA_Cache(long lngId_PaperStuBatchQuesRela)
{
string strAction = "GetObjById_PaperStuBatchQuesRela_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_PaperStuBatchQuesRela"] = lngId_PaperStuBatchQuesRela.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_PaperStuBatchQuesRela_JTEN = JsonConvert.DeserializeObject<clsvcc_PaperStuBatchQuesRela_JTEN>((string)jobjReturn["ReturnObj"]);
return objvcc_PaperStuBatchQuesRela_JTEN;
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
public static clsvcc_PaperStuBatchQuesRela_JTEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTEN = null;
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
objvcc_PaperStuBatchQuesRela_JTEN = JsonConvert.DeserializeObject<clsvcc_PaperStuBatchQuesRela_JTEN>((string)jobjReturn["ReturnObj"]);
return objvcc_PaperStuBatchQuesRela_JTEN;
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
 /// <param name = "lngId_PaperStuBatchQuesRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_PaperStuBatchQuesRela_JTEN GetObjById_PaperStuBatchQuesRela_Cache(long lngId_PaperStuBatchQuesRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_PaperStuBatchQuesRela_JTEN._CurrTabName_S);
List<clsvcc_PaperStuBatchQuesRela_JTEN> arrvcc_PaperStuBatchQuesRela_JTObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_PaperStuBatchQuesRela_JTEN> arrvcc_PaperStuBatchQuesRela_JTObjLst_Sel =
from objvcc_PaperStuBatchQuesRela_JTEN in arrvcc_PaperStuBatchQuesRela_JTObjLst_Cache
where objvcc_PaperStuBatchQuesRela_JTEN.Id_PaperStuBatchQuesRela == lngId_PaperStuBatchQuesRela
select objvcc_PaperStuBatchQuesRela_JTEN;
if (arrvcc_PaperStuBatchQuesRela_JTObjLst_Sel.Count() == 0)
{
   clsvcc_PaperStuBatchQuesRela_JTEN obj = clsvcc_PaperStuBatchQuesRela_JTWApi.GetObjById_PaperStuBatchQuesRela(lngId_PaperStuBatchQuesRela);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_PaperStuBatchQuesRela_JTObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_PaperStuBatchQuesRela_JTEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_PaperStuBatchQuesRela_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PaperStuBatchQuesRela_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_PaperStuBatchQuesRela_JTEN> GetObjLstById_PaperStuBatchQuesRelaLst(List<long> arrId_PaperStuBatchQuesRela)
{
 List<clsvcc_PaperStuBatchQuesRela_JTEN> arrObjLst = null; 
string strAction = "GetObjLstById_PaperStuBatchQuesRelaLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PaperStuBatchQuesRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PaperStuBatchQuesRela_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngId_PaperStuBatchQuesRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvcc_PaperStuBatchQuesRela_JTEN> GetObjLstById_PaperStuBatchQuesRelaLst_Cache(List<long> arrId_PaperStuBatchQuesRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_PaperStuBatchQuesRela_JTEN._CurrTabName_S);
List<clsvcc_PaperStuBatchQuesRela_JTEN> arrvcc_PaperStuBatchQuesRela_JTObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_PaperStuBatchQuesRela_JTEN> arrvcc_PaperStuBatchQuesRela_JTObjLst_Sel =
from objvcc_PaperStuBatchQuesRela_JTEN in arrvcc_PaperStuBatchQuesRela_JTObjLst_Cache
where arrId_PaperStuBatchQuesRela.Contains(objvcc_PaperStuBatchQuesRela_JTEN.Id_PaperStuBatchQuesRela)
select objvcc_PaperStuBatchQuesRela_JTEN;
return arrvcc_PaperStuBatchQuesRela_JTObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_PaperStuBatchQuesRela_JTEN> GetObjLstById_PaperStuBatchQuesRelaLst_WA_Cache(List<long> arrId_PaperStuBatchQuesRela)
{
 List<clsvcc_PaperStuBatchQuesRela_JTEN> arrObjLst = null; 
string strAction = "GetObjLstById_PaperStuBatchQuesRelaLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PaperStuBatchQuesRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PaperStuBatchQuesRela_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_PaperStuBatchQuesRela_JTEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_PaperStuBatchQuesRela_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PaperStuBatchQuesRela_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_PaperStuBatchQuesRela_JTEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_PaperStuBatchQuesRela_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PaperStuBatchQuesRela_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_PaperStuBatchQuesRela_JTEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_PaperStuBatchQuesRela_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PaperStuBatchQuesRela_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_PaperStuBatchQuesRela_JTEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_PaperStuBatchQuesRela_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PaperStuBatchQuesRela_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngId_PaperStuBatchQuesRela)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_PaperStuBatchQuesRela"] = lngId_PaperStuBatchQuesRela.ToString()
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
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTENS">源对象</param>
 /// <param name = "objvcc_PaperStuBatchQuesRela_JTENT">目标对象</param>
 public static void CopyTo(clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTENS, clsvcc_PaperStuBatchQuesRela_JTEN objvcc_PaperStuBatchQuesRela_JTENT)
{
try
{
objvcc_PaperStuBatchQuesRela_JTENT.Id_PaperStuBatchQuesRela = objvcc_PaperStuBatchQuesRela_JTENS.Id_PaperStuBatchQuesRela; //学生批次题目关系流水号
objvcc_PaperStuBatchQuesRela_JTENT.Id_PaperStuBatch = objvcc_PaperStuBatchQuesRela_JTENS.Id_PaperStuBatch; //学生试卷批次流水号
objvcc_PaperStuBatchQuesRela_JTENT.CourseExamPaperId = objvcc_PaperStuBatchQuesRela_JTENS.CourseExamPaperId; //考卷流水号
objvcc_PaperStuBatchQuesRela_JTENT.ExamPaperName = objvcc_PaperStuBatchQuesRela_JTENS.ExamPaperName; //考卷名称
objvcc_PaperStuBatchQuesRela_JTENT.ExamPaperTypeId = objvcc_PaperStuBatchQuesRela_JTENS.ExamPaperTypeId; //试卷类型Id
objvcc_PaperStuBatchQuesRela_JTENT.id_StudentInfo = objvcc_PaperStuBatchQuesRela_JTENS.id_StudentInfo; //学生流水号
objvcc_PaperStuBatchQuesRela_JTENT.SiteName = objvcc_PaperStuBatchQuesRela_JTENS.SiteName; //工地名称
objvcc_PaperStuBatchQuesRela_JTENT.StuID = objvcc_PaperStuBatchQuesRela_JTENS.StuID; //学号
objvcc_PaperStuBatchQuesRela_JTENT.StuName = objvcc_PaperStuBatchQuesRela_JTENS.StuName; //姓名
objvcc_PaperStuBatchQuesRela_JTENT.ManagedDepartmentId = objvcc_PaperStuBatchQuesRela_JTENS.ManagedDepartmentId; //管理的部门Id
objvcc_PaperStuBatchQuesRela_JTENT.ManagedDepartmentName = objvcc_PaperStuBatchQuesRela_JTENS.ManagedDepartmentName; //管理的部门名
objvcc_PaperStuBatchQuesRela_JTENT.JobCategoryId = objvcc_PaperStuBatchQuesRela_JTENS.JobCategoryId; //岗位类别Id
objvcc_PaperStuBatchQuesRela_JTENT.JobCategoryName = objvcc_PaperStuBatchQuesRela_JTENS.JobCategoryName; //岗位类别名
objvcc_PaperStuBatchQuesRela_JTENT.id_XzCollege = objvcc_PaperStuBatchQuesRela_JTENS.id_XzCollege; //学院流水号
objvcc_PaperStuBatchQuesRela_JTENT.CollegeName = objvcc_PaperStuBatchQuesRela_JTENS.CollegeName; //学院名称
objvcc_PaperStuBatchQuesRela_JTENT.CollegeNameA = objvcc_PaperStuBatchQuesRela_JTENS.CollegeNameA; //学院名称简写
objvcc_PaperStuBatchQuesRela_JTENT.BatchTime = objvcc_PaperStuBatchQuesRela_JTENS.BatchTime; //批次
objvcc_PaperStuBatchQuesRela_JTENT.id_CurrEduCls = objvcc_PaperStuBatchQuesRela_JTENS.id_CurrEduCls; //当前教学班流水号
objvcc_PaperStuBatchQuesRela_JTENT.EduClsName = objvcc_PaperStuBatchQuesRela_JTENS.EduClsName; //教学班名称
objvcc_PaperStuBatchQuesRela_JTENT.QuestionID = objvcc_PaperStuBatchQuesRela_JTENS.QuestionID; //题目ID
objvcc_PaperStuBatchQuesRela_JTENT.QuestionIndex = objvcc_PaperStuBatchQuesRela_JTENS.QuestionIndex; //题目序号
objvcc_PaperStuBatchQuesRela_JTENT.QuestionName = objvcc_PaperStuBatchQuesRela_JTENS.QuestionName; //题目名称
objvcc_PaperStuBatchQuesRela_JTENT.QuestionContent = objvcc_PaperStuBatchQuesRela_JTENS.QuestionContent; //题目内容
objvcc_PaperStuBatchQuesRela_JTENT.CourseId = objvcc_PaperStuBatchQuesRela_JTENS.CourseId; //课程Id
objvcc_PaperStuBatchQuesRela_JTENT.CourseName = objvcc_PaperStuBatchQuesRela_JTENS.CourseName; //课程名称
objvcc_PaperStuBatchQuesRela_JTENT.CourseChapterId = objvcc_PaperStuBatchQuesRela_JTENS.CourseChapterId; //课程章节ID
objvcc_PaperStuBatchQuesRela_JTENT.CourseChapterName = objvcc_PaperStuBatchQuesRela_JTENS.CourseChapterName; //课程章节名称
objvcc_PaperStuBatchQuesRela_JTENT.ChapterName = objvcc_PaperStuBatchQuesRela_JTENS.ChapterName; //章名
objvcc_PaperStuBatchQuesRela_JTENT.SectionName = objvcc_PaperStuBatchQuesRela_JTENS.SectionName; //节名
objvcc_PaperStuBatchQuesRela_JTENT.ChapterName_Sim = objvcc_PaperStuBatchQuesRela_JTENS.ChapterName_Sim; //章名简称
objvcc_PaperStuBatchQuesRela_JTENT.SectionName_Sim = objvcc_PaperStuBatchQuesRela_JTENS.SectionName_Sim; //节名简称
objvcc_PaperStuBatchQuesRela_JTENT.ParentNodeID = objvcc_PaperStuBatchQuesRela_JTENS.ParentNodeID; //父节点编号
objvcc_PaperStuBatchQuesRela_JTENT.CourseChapterReferred = objvcc_PaperStuBatchQuesRela_JTENS.CourseChapterReferred; //节简称
objvcc_PaperStuBatchQuesRela_JTENT.ParentNodeName = objvcc_PaperStuBatchQuesRela_JTENS.ParentNodeName; //父节点名称
objvcc_PaperStuBatchQuesRela_JTENT.ParentNodeReferred = objvcc_PaperStuBatchQuesRela_JTENS.ParentNodeReferred; //章简称
objvcc_PaperStuBatchQuesRela_JTENT.QuestionTypeId = objvcc_PaperStuBatchQuesRela_JTENS.QuestionTypeId; //题目类型Id
objvcc_PaperStuBatchQuesRela_JTENT.QuestionTypeName = objvcc_PaperStuBatchQuesRela_JTENS.QuestionTypeName; //题目类型名
objvcc_PaperStuBatchQuesRela_JTENT.AnswerTypeId = objvcc_PaperStuBatchQuesRela_JTENS.AnswerTypeId; //答案类型ID
objvcc_PaperStuBatchQuesRela_JTENT.DefaultValue = objvcc_PaperStuBatchQuesRela_JTENS.DefaultValue; //缺省值
objvcc_PaperStuBatchQuesRela_JTENT.TextDirectId = objvcc_PaperStuBatchQuesRela_JTENS.TextDirectId; //文本方向ID
objvcc_PaperStuBatchQuesRela_JTENT.RelaEvent = objvcc_PaperStuBatchQuesRela_JTENS.RelaEvent; //相关事件
objvcc_PaperStuBatchQuesRela_JTENT.CheckBoxLimitCount = objvcc_PaperStuBatchQuesRela_JTENS.CheckBoxLimitCount; //复选框限制数
objvcc_PaperStuBatchQuesRela_JTENT.AnswerAttLimitSize = objvcc_PaperStuBatchQuesRela_JTENS.AnswerAttLimitSize; //回答附件限制大小
objvcc_PaperStuBatchQuesRela_JTENT.LimitedResourceType = objvcc_PaperStuBatchQuesRela_JTENS.LimitedResourceType; //限制资源类型
objvcc_PaperStuBatchQuesRela_JTENT.QuestionIndex4Batch = objvcc_PaperStuBatchQuesRela_JTENS.QuestionIndex4Batch; //题序号4批次
objvcc_PaperStuBatchQuesRela_JTENT.Scores = objvcc_PaperStuBatchQuesRela_JTENS.Scores; //分值
objvcc_PaperStuBatchQuesRela_JTENT.Score = objvcc_PaperStuBatchQuesRela_JTENS.Score; //得分
objvcc_PaperStuBatchQuesRela_JTENT.StuAnswerText = objvcc_PaperStuBatchQuesRela_JTENS.StuAnswerText; //学生回答文本
objvcc_PaperStuBatchQuesRela_JTENT.AnswerDate = objvcc_PaperStuBatchQuesRela_JTENS.AnswerDate; //回答日期
objvcc_PaperStuBatchQuesRela_JTENT.AnswerIP = objvcc_PaperStuBatchQuesRela_JTENS.AnswerIP; //回答IP
objvcc_PaperStuBatchQuesRela_JTENT.AnswerModeId = objvcc_PaperStuBatchQuesRela_JTENS.AnswerModeId; //答案模式Id
objvcc_PaperStuBatchQuesRela_JTENT.AnswerMultiOptions = objvcc_PaperStuBatchQuesRela_JTENS.AnswerMultiOptions; //多选项答案
objvcc_PaperStuBatchQuesRela_JTENT.AnswerOptionId = objvcc_PaperStuBatchQuesRela_JTENS.AnswerOptionId; //回答选项Id
objvcc_PaperStuBatchQuesRela_JTENT.AnswerTime = objvcc_PaperStuBatchQuesRela_JTENS.AnswerTime; //回答时间
objvcc_PaperStuBatchQuesRela_JTENT.ApplySendBackDate = objvcc_PaperStuBatchQuesRela_JTENS.ApplySendBackDate; //申请退回日期
objvcc_PaperStuBatchQuesRela_JTENT.Comment = objvcc_PaperStuBatchQuesRela_JTENS.Comment; //批注
objvcc_PaperStuBatchQuesRela_JTENT.IsAccessKnowledge = objvcc_PaperStuBatchQuesRela_JTENS.IsAccessKnowledge; //是否处理知识点
objvcc_PaperStuBatchQuesRela_JTENT.IsApplySendBack = objvcc_PaperStuBatchQuesRela_JTENS.IsApplySendBack; //是否申请退回
objvcc_PaperStuBatchQuesRela_JTENT.IsInErrorQuestion = objvcc_PaperStuBatchQuesRela_JTENS.IsInErrorQuestion; //是否进入错题
objvcc_PaperStuBatchQuesRela_JTENT.IsLook = objvcc_PaperStuBatchQuesRela_JTENS.IsLook; //是否查看
objvcc_PaperStuBatchQuesRela_JTENT.IsMarking = objvcc_PaperStuBatchQuesRela_JTENS.IsMarking; //是否批阅
objvcc_PaperStuBatchQuesRela_JTENT.IsNotProcessTimeout = objvcc_PaperStuBatchQuesRela_JTENS.IsNotProcessTimeout; //是否不处理超时
objvcc_PaperStuBatchQuesRela_JTENT.IsPublish = objvcc_PaperStuBatchQuesRela_JTENS.IsPublish; //是否发布
objvcc_PaperStuBatchQuesRela_JTENT.IsRight = objvcc_PaperStuBatchQuesRela_JTENS.IsRight; //是否正确
objvcc_PaperStuBatchQuesRela_JTENT.IsSave = objvcc_PaperStuBatchQuesRela_JTENS.IsSave; //是否保存
objvcc_PaperStuBatchQuesRela_JTENT.IsSendBack = objvcc_PaperStuBatchQuesRela_JTENS.IsSendBack; //是否退回
objvcc_PaperStuBatchQuesRela_JTENT.IsSubmit = objvcc_PaperStuBatchQuesRela_JTENS.IsSubmit; //是否提交
objvcc_PaperStuBatchQuesRela_JTENT.MarkDate = objvcc_PaperStuBatchQuesRela_JTENS.MarkDate; //打分日期
objvcc_PaperStuBatchQuesRela_JTENT.MarkerId = objvcc_PaperStuBatchQuesRela_JTENS.MarkerId; //打分者
objvcc_PaperStuBatchQuesRela_JTENT.OperateTime = objvcc_PaperStuBatchQuesRela_JTENS.OperateTime; //操作时间
objvcc_PaperStuBatchQuesRela_JTENT.RealFinishDate = objvcc_PaperStuBatchQuesRela_JTENS.RealFinishDate; //实际完成日期
objvcc_PaperStuBatchQuesRela_JTENT.SchoolYear = objvcc_PaperStuBatchQuesRela_JTENS.SchoolYear; //学年
objvcc_PaperStuBatchQuesRela_JTENT.SchoolTerm = objvcc_PaperStuBatchQuesRela_JTENS.SchoolTerm; //学期
objvcc_PaperStuBatchQuesRela_JTENT.ErrMsg = objvcc_PaperStuBatchQuesRela_JTENS.ErrMsg; //错误信息
objvcc_PaperStuBatchQuesRela_JTENT.UpdDate = objvcc_PaperStuBatchQuesRela_JTENS.UpdDate; //修改日期
objvcc_PaperStuBatchQuesRela_JTENT.UpdUserId = objvcc_PaperStuBatchQuesRela_JTENS.UpdUserId; //修改用户Id
objvcc_PaperStuBatchQuesRela_JTENT.Memo = objvcc_PaperStuBatchQuesRela_JTENS.Memo; //备注
objvcc_PaperStuBatchQuesRela_JTENT.IsMarkingName = objvcc_PaperStuBatchQuesRela_JTENS.IsMarkingName; //IsMarkingName
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
public static DataTable ToDataTable(List<clsvcc_PaperStuBatchQuesRela_JTEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_PaperStuBatchQuesRela_JTEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_PaperStuBatchQuesRela_JTEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_PaperStuBatchQuesRela_JTEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_PaperStuBatchQuesRela_JTEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_PaperStuBatchQuesRela_JTEN.AttributeName)
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
if (clscc_PaperStuBatchQuesRelaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_PaperStuBatchQuesRelaWApi没有刷新缓存机制(clscc_PaperStuBatchQuesRelaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseChapterWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterWApi没有刷新缓存机制(clscc_CourseChapterWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelWApi没有刷新缓存机制(clsStudyLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_PaperStuBatchQuesRela");
//if (arrvcc_PaperStuBatchQuesRela_JTObjLst_Cache == null)
//{
//arrvcc_PaperStuBatchQuesRela_JTObjLst_Cache = await clsvcc_PaperStuBatchQuesRela_JTWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvcc_PaperStuBatchQuesRela_JTEN._CurrTabName_S);
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
public static List<clsvcc_PaperStuBatchQuesRela_JTEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvcc_PaperStuBatchQuesRela_JTEN._CurrTabName_S);
List<clsvcc_PaperStuBatchQuesRela_JTEN> arrvcc_PaperStuBatchQuesRela_JTObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_PaperStuBatchQuesRela_JTObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_PaperStuBatchQuesRela_JTEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.Id_PaperStuBatchQuesRela, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.Id_PaperStuBatch, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.CourseExamPaperId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.ExamPaperName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.ExamPaperTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.SiteName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.ManagedDepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.ManagedDepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.JobCategoryId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.JobCategoryName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.BatchTime, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.EduClsName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.QuestionIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.QuestionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.QuestionContent, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.SectionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.CourseChapterReferred, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.ParentNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.ParentNodeReferred, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.QuestionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.AnswerTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.DefaultValue, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.TextDirectId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.RelaEvent, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.CheckBoxLimitCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.AnswerAttLimitSize, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.LimitedResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.QuestionIndex4Batch, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.Scores, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.Score, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.StuAnswerText, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.AnswerDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.AnswerIP, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.AnswerModeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.AnswerMultiOptions, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.AnswerOptionId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.AnswerTime, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.ApplySendBackDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.Comment, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.IsAccessKnowledge, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.IsApplySendBack, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.IsInErrorQuestion, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.IsLook, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.IsMarking, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.IsNotProcessTimeout, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.IsPublish, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.IsRight, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.IsSave, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.IsSendBack, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.IsSubmit, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.MarkDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.MarkerId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.OperateTime, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.RealFinishDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.SchoolYear, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.SchoolTerm, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.ErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_JT.IsMarkingName, Type.GetType("System.String"));
foreach (clsvcc_PaperStuBatchQuesRela_JTEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_PaperStuBatchQuesRela_JT.Id_PaperStuBatchQuesRela] = objInFor[convcc_PaperStuBatchQuesRela_JT.Id_PaperStuBatchQuesRela];
objDR[convcc_PaperStuBatchQuesRela_JT.Id_PaperStuBatch] = objInFor[convcc_PaperStuBatchQuesRela_JT.Id_PaperStuBatch];
objDR[convcc_PaperStuBatchQuesRela_JT.CourseExamPaperId] = objInFor[convcc_PaperStuBatchQuesRela_JT.CourseExamPaperId];
objDR[convcc_PaperStuBatchQuesRela_JT.ExamPaperName] = objInFor[convcc_PaperStuBatchQuesRela_JT.ExamPaperName];
objDR[convcc_PaperStuBatchQuesRela_JT.ExamPaperTypeId] = objInFor[convcc_PaperStuBatchQuesRela_JT.ExamPaperTypeId];
objDR[convcc_PaperStuBatchQuesRela_JT.id_StudentInfo] = objInFor[convcc_PaperStuBatchQuesRela_JT.id_StudentInfo];
objDR[convcc_PaperStuBatchQuesRela_JT.SiteName] = objInFor[convcc_PaperStuBatchQuesRela_JT.SiteName];
objDR[convcc_PaperStuBatchQuesRela_JT.StuID] = objInFor[convcc_PaperStuBatchQuesRela_JT.StuID];
objDR[convcc_PaperStuBatchQuesRela_JT.StuName] = objInFor[convcc_PaperStuBatchQuesRela_JT.StuName];
objDR[convcc_PaperStuBatchQuesRela_JT.ManagedDepartmentId] = objInFor[convcc_PaperStuBatchQuesRela_JT.ManagedDepartmentId];
objDR[convcc_PaperStuBatchQuesRela_JT.ManagedDepartmentName] = objInFor[convcc_PaperStuBatchQuesRela_JT.ManagedDepartmentName];
objDR[convcc_PaperStuBatchQuesRela_JT.JobCategoryId] = objInFor[convcc_PaperStuBatchQuesRela_JT.JobCategoryId];
objDR[convcc_PaperStuBatchQuesRela_JT.JobCategoryName] = objInFor[convcc_PaperStuBatchQuesRela_JT.JobCategoryName];
objDR[convcc_PaperStuBatchQuesRela_JT.id_XzCollege] = objInFor[convcc_PaperStuBatchQuesRela_JT.id_XzCollege];
objDR[convcc_PaperStuBatchQuesRela_JT.CollegeName] = objInFor[convcc_PaperStuBatchQuesRela_JT.CollegeName];
objDR[convcc_PaperStuBatchQuesRela_JT.CollegeNameA] = objInFor[convcc_PaperStuBatchQuesRela_JT.CollegeNameA];
objDR[convcc_PaperStuBatchQuesRela_JT.BatchTime] = objInFor[convcc_PaperStuBatchQuesRela_JT.BatchTime];
objDR[convcc_PaperStuBatchQuesRela_JT.id_CurrEduCls] = objInFor[convcc_PaperStuBatchQuesRela_JT.id_CurrEduCls];
objDR[convcc_PaperStuBatchQuesRela_JT.EduClsName] = objInFor[convcc_PaperStuBatchQuesRela_JT.EduClsName];
objDR[convcc_PaperStuBatchQuesRela_JT.QuestionID] = objInFor[convcc_PaperStuBatchQuesRela_JT.QuestionID];
objDR[convcc_PaperStuBatchQuesRela_JT.QuestionIndex] = objInFor[convcc_PaperStuBatchQuesRela_JT.QuestionIndex];
objDR[convcc_PaperStuBatchQuesRela_JT.QuestionName] = objInFor[convcc_PaperStuBatchQuesRela_JT.QuestionName];
objDR[convcc_PaperStuBatchQuesRela_JT.QuestionContent] = objInFor[convcc_PaperStuBatchQuesRela_JT.QuestionContent];
objDR[convcc_PaperStuBatchQuesRela_JT.CourseId] = objInFor[convcc_PaperStuBatchQuesRela_JT.CourseId];
objDR[convcc_PaperStuBatchQuesRela_JT.CourseName] = objInFor[convcc_PaperStuBatchQuesRela_JT.CourseName];
objDR[convcc_PaperStuBatchQuesRela_JT.CourseChapterId] = objInFor[convcc_PaperStuBatchQuesRela_JT.CourseChapterId];
objDR[convcc_PaperStuBatchQuesRela_JT.CourseChapterName] = objInFor[convcc_PaperStuBatchQuesRela_JT.CourseChapterName];
objDR[convcc_PaperStuBatchQuesRela_JT.ChapterName] = objInFor[convcc_PaperStuBatchQuesRela_JT.ChapterName];
objDR[convcc_PaperStuBatchQuesRela_JT.SectionName] = objInFor[convcc_PaperStuBatchQuesRela_JT.SectionName];
objDR[convcc_PaperStuBatchQuesRela_JT.ChapterName_Sim] = objInFor[convcc_PaperStuBatchQuesRela_JT.ChapterName_Sim];
objDR[convcc_PaperStuBatchQuesRela_JT.SectionName_Sim] = objInFor[convcc_PaperStuBatchQuesRela_JT.SectionName_Sim];
objDR[convcc_PaperStuBatchQuesRela_JT.ParentNodeID] = objInFor[convcc_PaperStuBatchQuesRela_JT.ParentNodeID];
objDR[convcc_PaperStuBatchQuesRela_JT.CourseChapterReferred] = objInFor[convcc_PaperStuBatchQuesRela_JT.CourseChapterReferred];
objDR[convcc_PaperStuBatchQuesRela_JT.ParentNodeName] = objInFor[convcc_PaperStuBatchQuesRela_JT.ParentNodeName];
objDR[convcc_PaperStuBatchQuesRela_JT.ParentNodeReferred] = objInFor[convcc_PaperStuBatchQuesRela_JT.ParentNodeReferred];
objDR[convcc_PaperStuBatchQuesRela_JT.QuestionTypeId] = objInFor[convcc_PaperStuBatchQuesRela_JT.QuestionTypeId];
objDR[convcc_PaperStuBatchQuesRela_JT.QuestionTypeName] = objInFor[convcc_PaperStuBatchQuesRela_JT.QuestionTypeName];
objDR[convcc_PaperStuBatchQuesRela_JT.AnswerTypeId] = objInFor[convcc_PaperStuBatchQuesRela_JT.AnswerTypeId];
objDR[convcc_PaperStuBatchQuesRela_JT.DefaultValue] = objInFor[convcc_PaperStuBatchQuesRela_JT.DefaultValue];
objDR[convcc_PaperStuBatchQuesRela_JT.TextDirectId] = objInFor[convcc_PaperStuBatchQuesRela_JT.TextDirectId];
objDR[convcc_PaperStuBatchQuesRela_JT.RelaEvent] = objInFor[convcc_PaperStuBatchQuesRela_JT.RelaEvent];
objDR[convcc_PaperStuBatchQuesRela_JT.CheckBoxLimitCount] = objInFor[convcc_PaperStuBatchQuesRela_JT.CheckBoxLimitCount];
objDR[convcc_PaperStuBatchQuesRela_JT.AnswerAttLimitSize] = objInFor[convcc_PaperStuBatchQuesRela_JT.AnswerAttLimitSize];
objDR[convcc_PaperStuBatchQuesRela_JT.LimitedResourceType] = objInFor[convcc_PaperStuBatchQuesRela_JT.LimitedResourceType];
objDR[convcc_PaperStuBatchQuesRela_JT.QuestionIndex4Batch] = objInFor[convcc_PaperStuBatchQuesRela_JT.QuestionIndex4Batch];
objDR[convcc_PaperStuBatchQuesRela_JT.Scores] = objInFor[convcc_PaperStuBatchQuesRela_JT.Scores];
objDR[convcc_PaperStuBatchQuesRela_JT.Score] = objInFor[convcc_PaperStuBatchQuesRela_JT.Score];
objDR[convcc_PaperStuBatchQuesRela_JT.StuAnswerText] = objInFor[convcc_PaperStuBatchQuesRela_JT.StuAnswerText];
objDR[convcc_PaperStuBatchQuesRela_JT.AnswerDate] = objInFor[convcc_PaperStuBatchQuesRela_JT.AnswerDate];
objDR[convcc_PaperStuBatchQuesRela_JT.AnswerIP] = objInFor[convcc_PaperStuBatchQuesRela_JT.AnswerIP];
objDR[convcc_PaperStuBatchQuesRela_JT.AnswerModeId] = objInFor[convcc_PaperStuBatchQuesRela_JT.AnswerModeId];
objDR[convcc_PaperStuBatchQuesRela_JT.AnswerMultiOptions] = objInFor[convcc_PaperStuBatchQuesRela_JT.AnswerMultiOptions];
objDR[convcc_PaperStuBatchQuesRela_JT.AnswerOptionId] = objInFor[convcc_PaperStuBatchQuesRela_JT.AnswerOptionId];
objDR[convcc_PaperStuBatchQuesRela_JT.AnswerTime] = objInFor[convcc_PaperStuBatchQuesRela_JT.AnswerTime];
objDR[convcc_PaperStuBatchQuesRela_JT.ApplySendBackDate] = objInFor[convcc_PaperStuBatchQuesRela_JT.ApplySendBackDate];
objDR[convcc_PaperStuBatchQuesRela_JT.Comment] = objInFor[convcc_PaperStuBatchQuesRela_JT.Comment];
objDR[convcc_PaperStuBatchQuesRela_JT.IsAccessKnowledge] = objInFor[convcc_PaperStuBatchQuesRela_JT.IsAccessKnowledge];
objDR[convcc_PaperStuBatchQuesRela_JT.IsApplySendBack] = objInFor[convcc_PaperStuBatchQuesRela_JT.IsApplySendBack];
objDR[convcc_PaperStuBatchQuesRela_JT.IsInErrorQuestion] = objInFor[convcc_PaperStuBatchQuesRela_JT.IsInErrorQuestion];
objDR[convcc_PaperStuBatchQuesRela_JT.IsLook] = objInFor[convcc_PaperStuBatchQuesRela_JT.IsLook];
objDR[convcc_PaperStuBatchQuesRela_JT.IsMarking] = objInFor[convcc_PaperStuBatchQuesRela_JT.IsMarking];
objDR[convcc_PaperStuBatchQuesRela_JT.IsNotProcessTimeout] = objInFor[convcc_PaperStuBatchQuesRela_JT.IsNotProcessTimeout];
objDR[convcc_PaperStuBatchQuesRela_JT.IsPublish] = objInFor[convcc_PaperStuBatchQuesRela_JT.IsPublish];
objDR[convcc_PaperStuBatchQuesRela_JT.IsRight] = objInFor[convcc_PaperStuBatchQuesRela_JT.IsRight];
objDR[convcc_PaperStuBatchQuesRela_JT.IsSave] = objInFor[convcc_PaperStuBatchQuesRela_JT.IsSave];
objDR[convcc_PaperStuBatchQuesRela_JT.IsSendBack] = objInFor[convcc_PaperStuBatchQuesRela_JT.IsSendBack];
objDR[convcc_PaperStuBatchQuesRela_JT.IsSubmit] = objInFor[convcc_PaperStuBatchQuesRela_JT.IsSubmit];
objDR[convcc_PaperStuBatchQuesRela_JT.MarkDate] = objInFor[convcc_PaperStuBatchQuesRela_JT.MarkDate];
objDR[convcc_PaperStuBatchQuesRela_JT.MarkerId] = objInFor[convcc_PaperStuBatchQuesRela_JT.MarkerId];
objDR[convcc_PaperStuBatchQuesRela_JT.OperateTime] = objInFor[convcc_PaperStuBatchQuesRela_JT.OperateTime];
objDR[convcc_PaperStuBatchQuesRela_JT.RealFinishDate] = objInFor[convcc_PaperStuBatchQuesRela_JT.RealFinishDate];
objDR[convcc_PaperStuBatchQuesRela_JT.SchoolYear] = objInFor[convcc_PaperStuBatchQuesRela_JT.SchoolYear];
objDR[convcc_PaperStuBatchQuesRela_JT.SchoolTerm] = objInFor[convcc_PaperStuBatchQuesRela_JT.SchoolTerm];
objDR[convcc_PaperStuBatchQuesRela_JT.ErrMsg] = objInFor[convcc_PaperStuBatchQuesRela_JT.ErrMsg];
objDR[convcc_PaperStuBatchQuesRela_JT.UpdDate] = objInFor[convcc_PaperStuBatchQuesRela_JT.UpdDate];
objDR[convcc_PaperStuBatchQuesRela_JT.UpdUserId] = objInFor[convcc_PaperStuBatchQuesRela_JT.UpdUserId];
objDR[convcc_PaperStuBatchQuesRela_JT.Memo] = objInFor[convcc_PaperStuBatchQuesRela_JT.Memo];
objDR[convcc_PaperStuBatchQuesRela_JT.IsMarkingName] = objInFor[convcc_PaperStuBatchQuesRela_JT.IsMarkingName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}