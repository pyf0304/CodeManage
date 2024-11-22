
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_PaperStuBatchQuesRela_TotalWApi
 表名:vcc_PaperStuBatchQuesRela_Total(01120244)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:45:13
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
public static class clsvcc_PaperStuBatchQuesRela_TotalWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetId_PaperStuBatchQuesRela_Total(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, long lngId_PaperStuBatchQuesRela_Total, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_TotalEN.Id_PaperStuBatchQuesRela_Total = lngId_PaperStuBatchQuesRela_Total; //学生试卷完成汇总流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.Id_PaperStuBatchQuesRela_Total) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.Id_PaperStuBatchQuesRela_Total, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.Id_PaperStuBatchQuesRela_Total] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN Setid_CurrEduCls(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CurrEduCls, convcc_PaperStuBatchQuesRela_Total.id_CurrEduCls);
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convcc_PaperStuBatchQuesRela_Total.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convcc_PaperStuBatchQuesRela_Total.id_CurrEduCls);
objvcc_PaperStuBatchQuesRela_TotalEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.id_CurrEduCls) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.id_CurrEduCls, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.id_CurrEduCls] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetCurrEduClsId(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, string strCurrEduClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, convcc_PaperStuBatchQuesRela_Total.CurrEduClsId);
objvcc_PaperStuBatchQuesRela_TotalEN.CurrEduClsId = strCurrEduClsId; //当前教学班Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.CurrEduClsId) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.CurrEduClsId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.CurrEduClsId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetEduClsName(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduClsName, convcc_PaperStuBatchQuesRela_Total.EduClsName);
clsCheckSql.CheckFieldLen(strEduClsName, 100, convcc_PaperStuBatchQuesRela_Total.EduClsName);
objvcc_PaperStuBatchQuesRela_TotalEN.EduClsName = strEduClsName; //教学班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.EduClsName) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.EduClsName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.EduClsName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetCourseId(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_PaperStuBatchQuesRela_Total.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_PaperStuBatchQuesRela_Total.CourseId);
objvcc_PaperStuBatchQuesRela_TotalEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.CourseId) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.CourseId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.CourseId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetCourseName(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_PaperStuBatchQuesRela_Total.CourseName);
objvcc_PaperStuBatchQuesRela_TotalEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.CourseName) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.CourseName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.CourseName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetCourseExamPaperId(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, convcc_PaperStuBatchQuesRela_Total.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, convcc_PaperStuBatchQuesRela_Total.CourseExamPaperId);
objvcc_PaperStuBatchQuesRela_TotalEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.CourseExamPaperId) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.CourseExamPaperId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.CourseExamPaperId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetId_PaperStuBatch(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, string strId_PaperStuBatch, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_PaperStuBatch, 10, convcc_PaperStuBatchQuesRela_Total.Id_PaperStuBatch);
clsCheckSql.CheckFieldForeignKey(strId_PaperStuBatch, 10, convcc_PaperStuBatchQuesRela_Total.Id_PaperStuBatch);
objvcc_PaperStuBatchQuesRela_TotalEN.Id_PaperStuBatch = strId_PaperStuBatch; //学生试卷批次流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.Id_PaperStuBatch) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.Id_PaperStuBatch, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.Id_PaperStuBatch] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN Setid_StudentInfo(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudentInfo, convcc_PaperStuBatchQuesRela_Total.id_StudentInfo);
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, convcc_PaperStuBatchQuesRela_Total.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, convcc_PaperStuBatchQuesRela_Total.id_StudentInfo);
objvcc_PaperStuBatchQuesRela_TotalEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.id_StudentInfo) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.id_StudentInfo, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.id_StudentInfo] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetStuID(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convcc_PaperStuBatchQuesRela_Total.StuID);
objvcc_PaperStuBatchQuesRela_TotalEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.StuID) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.StuID, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.StuID] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetStuName(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convcc_PaperStuBatchQuesRela_Total.StuName);
objvcc_PaperStuBatchQuesRela_TotalEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.StuName) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.StuName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.StuName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetSexDesc(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, string strSexDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convcc_PaperStuBatchQuesRela_Total.SexDesc);
objvcc_PaperStuBatchQuesRela_TotalEN.SexDesc = strSexDesc; //性别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.SexDesc) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.SexDesc, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.SexDesc] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN Setid_XzCollege(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convcc_PaperStuBatchQuesRela_Total.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convcc_PaperStuBatchQuesRela_Total.id_XzCollege);
objvcc_PaperStuBatchQuesRela_TotalEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.id_XzCollege) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.id_XzCollege, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.id_XzCollege] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetCollegeName(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convcc_PaperStuBatchQuesRela_Total.CollegeName);
clsCheckSql.CheckFieldLen(strCollegeName, 100, convcc_PaperStuBatchQuesRela_Total.CollegeName);
objvcc_PaperStuBatchQuesRela_TotalEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.CollegeName) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.CollegeName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.CollegeName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetCollegeNameA(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convcc_PaperStuBatchQuesRela_Total.CollegeNameA);
objvcc_PaperStuBatchQuesRela_TotalEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.CollegeNameA) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.CollegeNameA, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.CollegeNameA] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN Setid_XzMajor(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzMajor, convcc_PaperStuBatchQuesRela_Total.id_XzMajor);
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convcc_PaperStuBatchQuesRela_Total.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convcc_PaperStuBatchQuesRela_Total.id_XzMajor);
objvcc_PaperStuBatchQuesRela_TotalEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.id_XzMajor) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.id_XzMajor, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.id_XzMajor] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetMajorID(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorID, convcc_PaperStuBatchQuesRela_Total.MajorID);
clsCheckSql.CheckFieldLen(strMajorID, 4, convcc_PaperStuBatchQuesRela_Total.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convcc_PaperStuBatchQuesRela_Total.MajorID);
objvcc_PaperStuBatchQuesRela_TotalEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.MajorID) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.MajorID, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.MajorID] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetMajorName(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorName, convcc_PaperStuBatchQuesRela_Total.MajorName);
clsCheckSql.CheckFieldLen(strMajorName, 100, convcc_PaperStuBatchQuesRela_Total.MajorName);
objvcc_PaperStuBatchQuesRela_TotalEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.MajorName) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.MajorName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.MajorName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN Setid_GradeBase(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convcc_PaperStuBatchQuesRela_Total.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convcc_PaperStuBatchQuesRela_Total.id_GradeBase);
objvcc_PaperStuBatchQuesRela_TotalEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.id_GradeBase) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.id_GradeBase, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.id_GradeBase] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetGradeBaseName(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGradeBaseName, convcc_PaperStuBatchQuesRela_Total.GradeBaseName);
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convcc_PaperStuBatchQuesRela_Total.GradeBaseName);
objvcc_PaperStuBatchQuesRela_TotalEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.GradeBaseName) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.GradeBaseName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.GradeBaseName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetAdminClsName(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, string strAdminClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, convcc_PaperStuBatchQuesRela_Total.AdminClsName);
objvcc_PaperStuBatchQuesRela_TotalEN.AdminClsName = strAdminClsName; //行政班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.AdminClsName) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.AdminClsName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.AdminClsName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetAdminClsId(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, string strAdminClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, convcc_PaperStuBatchQuesRela_Total.AdminClsId);
objvcc_PaperStuBatchQuesRela_TotalEN.AdminClsId = strAdminClsId; //行政班代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.AdminClsId) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.AdminClsId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.AdminClsId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetBatchTime(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, string strBatchTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBatchTime, 14, convcc_PaperStuBatchQuesRela_Total.BatchTime);
objvcc_PaperStuBatchQuesRela_TotalEN.BatchTime = strBatchTime; //批次
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.BatchTime) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.BatchTime, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.BatchTime] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetQuesNum(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, int intQuesNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intQuesNum, convcc_PaperStuBatchQuesRela_Total.QuesNum);
objvcc_PaperStuBatchQuesRela_TotalEN.QuesNum = intQuesNum; //题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.QuesNum) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.QuesNum, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.QuesNum] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetQuesNum_Look(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, int intQuesNum_Look, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_TotalEN.QuesNum_Look = intQuesNum_Look; //查看题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.QuesNum_Look) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.QuesNum_Look, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.QuesNum_Look] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetQuesNum_Mark(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, int intQuesNum_Mark, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_TotalEN.QuesNum_Mark = intQuesNum_Mark; //打分题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.QuesNum_Mark) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.QuesNum_Mark, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.QuesNum_Mark] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetQuesNum_NoFinish(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, int intQuesNum_NoFinish, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_TotalEN.QuesNum_NoFinish = intQuesNum_NoFinish; //未完成题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.QuesNum_NoFinish) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.QuesNum_NoFinish, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.QuesNum_NoFinish] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetQuesNum_Overdue(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, int intQuesNum_Overdue, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_TotalEN.QuesNum_Overdue = intQuesNum_Overdue; //逾期题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.QuesNum_Overdue) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.QuesNum_Overdue, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.QuesNum_Overdue] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetQuesNum_Save(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, int intQuesNum_Save, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_TotalEN.QuesNum_Save = intQuesNum_Save; //保存题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.QuesNum_Save) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.QuesNum_Save, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.QuesNum_Save] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetQuesNum_SendBack(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, int intQuesNum_SendBack, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_TotalEN.QuesNum_SendBack = intQuesNum_SendBack; //退回题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.QuesNum_SendBack) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.QuesNum_SendBack, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.QuesNum_SendBack] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetQuesNum_Submit(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, int intQuesNum_Submit, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_TotalEN.QuesNum_Submit = intQuesNum_Submit; //提交题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.QuesNum_Submit) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.QuesNum_Submit, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.QuesNum_Submit] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetTotalScore(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, double dblTotalScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dblTotalScore, convcc_PaperStuBatchQuesRela_Total.TotalScore);
objvcc_PaperStuBatchQuesRela_TotalEN.TotalScore = dblTotalScore; //总得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.TotalScore) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.TotalScore, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.TotalScore] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetTotalScores(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, double dblTotalScores, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRela_TotalEN.TotalScores = dblTotalScores; //总分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.TotalScores) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.TotalScores, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.TotalScores] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetSchoolYear(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, string strSchoolYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, convcc_PaperStuBatchQuesRela_Total.SchoolYear);
objvcc_PaperStuBatchQuesRela_TotalEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.SchoolYear) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.SchoolYear, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.SchoolYear] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetSchoolTerm(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, convcc_PaperStuBatchQuesRela_Total.SchoolTerm);
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, convcc_PaperStuBatchQuesRela_Total.SchoolTerm);
objvcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.SchoolTerm) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.SchoolTerm, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.SchoolTerm] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetUpdDate(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_PaperStuBatchQuesRela_Total.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_PaperStuBatchQuesRela_Total.UpdDate);
objvcc_PaperStuBatchQuesRela_TotalEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.UpdDate) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.UpdDate, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.UpdDate] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetUpdUserId(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_PaperStuBatchQuesRela_Total.UpdUserId);
objvcc_PaperStuBatchQuesRela_TotalEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.UpdUserId) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.UpdUserId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.UpdUserId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN SetMemo(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_PaperStuBatchQuesRela_Total.Memo);
objvcc_PaperStuBatchQuesRela_TotalEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela_Total.Memo) == false)
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela_Total.Memo, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.Memo] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRela_TotalEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_Total_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.Id_PaperStuBatchQuesRela_Total) == true)
{
string strComparisonOp_Id_PaperStuBatchQuesRela_Total = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.Id_PaperStuBatchQuesRela_Total];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela_Total.Id_PaperStuBatchQuesRela_Total, objvcc_PaperStuBatchQuesRela_Total_Cond.Id_PaperStuBatchQuesRela_Total, strComparisonOp_Id_PaperStuBatchQuesRela_Total);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total.id_CurrEduCls, objvcc_PaperStuBatchQuesRela_Total_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.CurrEduClsId) == true)
{
string strComparisonOp_CurrEduClsId = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total.CurrEduClsId, objvcc_PaperStuBatchQuesRela_Total_Cond.CurrEduClsId, strComparisonOp_CurrEduClsId);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.EduClsName) == true)
{
string strComparisonOp_EduClsName = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total.EduClsName, objvcc_PaperStuBatchQuesRela_Total_Cond.EduClsName, strComparisonOp_EduClsName);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total.CourseId, objvcc_PaperStuBatchQuesRela_Total_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total.CourseName, objvcc_PaperStuBatchQuesRela_Total_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.CourseExamPaperId) == true)
{
string strComparisonOp_CourseExamPaperId = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total.CourseExamPaperId, objvcc_PaperStuBatchQuesRela_Total_Cond.CourseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.Id_PaperStuBatch) == true)
{
string strComparisonOp_Id_PaperStuBatch = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.Id_PaperStuBatch];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total.Id_PaperStuBatch, objvcc_PaperStuBatchQuesRela_Total_Cond.Id_PaperStuBatch, strComparisonOp_Id_PaperStuBatch);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total.id_StudentInfo, objvcc_PaperStuBatchQuesRela_Total_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.StuID) == true)
{
string strComparisonOp_StuID = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total.StuID, objvcc_PaperStuBatchQuesRela_Total_Cond.StuID, strComparisonOp_StuID);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.StuName) == true)
{
string strComparisonOp_StuName = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total.StuName, objvcc_PaperStuBatchQuesRela_Total_Cond.StuName, strComparisonOp_StuName);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.SexDesc) == true)
{
string strComparisonOp_SexDesc = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total.SexDesc, objvcc_PaperStuBatchQuesRela_Total_Cond.SexDesc, strComparisonOp_SexDesc);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total.id_XzCollege, objvcc_PaperStuBatchQuesRela_Total_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total.CollegeName, objvcc_PaperStuBatchQuesRela_Total_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total.CollegeNameA, objvcc_PaperStuBatchQuesRela_Total_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total.id_XzMajor, objvcc_PaperStuBatchQuesRela_Total_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.MajorID) == true)
{
string strComparisonOp_MajorID = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total.MajorID, objvcc_PaperStuBatchQuesRela_Total_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.MajorName) == true)
{
string strComparisonOp_MajorName = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total.MajorName, objvcc_PaperStuBatchQuesRela_Total_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total.id_GradeBase, objvcc_PaperStuBatchQuesRela_Total_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total.GradeBaseName, objvcc_PaperStuBatchQuesRela_Total_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.AdminClsName) == true)
{
string strComparisonOp_AdminClsName = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total.AdminClsName, objvcc_PaperStuBatchQuesRela_Total_Cond.AdminClsName, strComparisonOp_AdminClsName);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.AdminClsId) == true)
{
string strComparisonOp_AdminClsId = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total.AdminClsId, objvcc_PaperStuBatchQuesRela_Total_Cond.AdminClsId, strComparisonOp_AdminClsId);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.BatchTime) == true)
{
string strComparisonOp_BatchTime = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.BatchTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total.BatchTime, objvcc_PaperStuBatchQuesRela_Total_Cond.BatchTime, strComparisonOp_BatchTime);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.QuesNum) == true)
{
string strComparisonOp_QuesNum = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.QuesNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela_Total.QuesNum, objvcc_PaperStuBatchQuesRela_Total_Cond.QuesNum, strComparisonOp_QuesNum);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.QuesNum_Look) == true)
{
string strComparisonOp_QuesNum_Look = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.QuesNum_Look];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela_Total.QuesNum_Look, objvcc_PaperStuBatchQuesRela_Total_Cond.QuesNum_Look, strComparisonOp_QuesNum_Look);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.QuesNum_Mark) == true)
{
string strComparisonOp_QuesNum_Mark = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.QuesNum_Mark];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela_Total.QuesNum_Mark, objvcc_PaperStuBatchQuesRela_Total_Cond.QuesNum_Mark, strComparisonOp_QuesNum_Mark);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.QuesNum_NoFinish) == true)
{
string strComparisonOp_QuesNum_NoFinish = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.QuesNum_NoFinish];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela_Total.QuesNum_NoFinish, objvcc_PaperStuBatchQuesRela_Total_Cond.QuesNum_NoFinish, strComparisonOp_QuesNum_NoFinish);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.QuesNum_Overdue) == true)
{
string strComparisonOp_QuesNum_Overdue = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.QuesNum_Overdue];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela_Total.QuesNum_Overdue, objvcc_PaperStuBatchQuesRela_Total_Cond.QuesNum_Overdue, strComparisonOp_QuesNum_Overdue);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.QuesNum_Save) == true)
{
string strComparisonOp_QuesNum_Save = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.QuesNum_Save];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela_Total.QuesNum_Save, objvcc_PaperStuBatchQuesRela_Total_Cond.QuesNum_Save, strComparisonOp_QuesNum_Save);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.QuesNum_SendBack) == true)
{
string strComparisonOp_QuesNum_SendBack = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.QuesNum_SendBack];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela_Total.QuesNum_SendBack, objvcc_PaperStuBatchQuesRela_Total_Cond.QuesNum_SendBack, strComparisonOp_QuesNum_SendBack);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.QuesNum_Submit) == true)
{
string strComparisonOp_QuesNum_Submit = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.QuesNum_Submit];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela_Total.QuesNum_Submit, objvcc_PaperStuBatchQuesRela_Total_Cond.QuesNum_Submit, strComparisonOp_QuesNum_Submit);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.TotalScore) == true)
{
string strComparisonOp_TotalScore = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.TotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela_Total.TotalScore, objvcc_PaperStuBatchQuesRela_Total_Cond.TotalScore, strComparisonOp_TotalScore);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.TotalScores) == true)
{
string strComparisonOp_TotalScores = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.TotalScores];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela_Total.TotalScores, objvcc_PaperStuBatchQuesRela_Total_Cond.TotalScores, strComparisonOp_TotalScores);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.SchoolYear) == true)
{
string strComparisonOp_SchoolYear = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total.SchoolYear, objvcc_PaperStuBatchQuesRela_Total_Cond.SchoolYear, strComparisonOp_SchoolYear);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.SchoolTerm) == true)
{
string strComparisonOp_SchoolTerm = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total.SchoolTerm, objvcc_PaperStuBatchQuesRela_Total_Cond.SchoolTerm, strComparisonOp_SchoolTerm);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total.UpdDate, objvcc_PaperStuBatchQuesRela_Total_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total.UpdUserId, objvcc_PaperStuBatchQuesRela_Total_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvcc_PaperStuBatchQuesRela_Total_Cond.IsUpdated(convcc_PaperStuBatchQuesRela_Total.Memo) == true)
{
string strComparisonOp_Memo = objvcc_PaperStuBatchQuesRela_Total_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela_Total.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela_Total.Memo, objvcc_PaperStuBatchQuesRela_Total_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v学生试卷完成汇总(vcc_PaperStuBatchQuesRela_Total)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_PaperStuBatchQuesRela_TotalWApi
{
private static readonly string mstrApiControllerName = "vcc_PaperStuBatchQuesRela_TotalApi";

 public clsvcc_PaperStuBatchQuesRela_TotalWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_PaperStuBatchQuesRela_Total">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_PaperStuBatchQuesRela_TotalEN GetObjById_PaperStuBatchQuesRela_Total(long lngId_PaperStuBatchQuesRela_Total)
{
string strAction = "GetObjById_PaperStuBatchQuesRela_Total";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN = null;
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
objvcc_PaperStuBatchQuesRela_TotalEN = JsonConvert.DeserializeObject<clsvcc_PaperStuBatchQuesRela_TotalEN>((string)jobjReturn["ReturnObj"]);
return objvcc_PaperStuBatchQuesRela_TotalEN;
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
public static clsvcc_PaperStuBatchQuesRela_TotalEN GetObjById_PaperStuBatchQuesRela_Total_WA_Cache(long lngId_PaperStuBatchQuesRela_Total)
{
string strAction = "GetObjById_PaperStuBatchQuesRela_Total_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN = null;
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
objvcc_PaperStuBatchQuesRela_TotalEN = JsonConvert.DeserializeObject<clsvcc_PaperStuBatchQuesRela_TotalEN>((string)jobjReturn["ReturnObj"]);
return objvcc_PaperStuBatchQuesRela_TotalEN;
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
public static clsvcc_PaperStuBatchQuesRela_TotalEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalEN = null;
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
objvcc_PaperStuBatchQuesRela_TotalEN = JsonConvert.DeserializeObject<clsvcc_PaperStuBatchQuesRela_TotalEN>((string)jobjReturn["ReturnObj"]);
return objvcc_PaperStuBatchQuesRela_TotalEN;
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
public static clsvcc_PaperStuBatchQuesRela_TotalEN GetObjById_PaperStuBatchQuesRela_Total_Cache(long lngId_PaperStuBatchQuesRela_Total)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_PaperStuBatchQuesRela_TotalEN._CurrTabName_S);
List<clsvcc_PaperStuBatchQuesRela_TotalEN> arrvcc_PaperStuBatchQuesRela_TotalObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_PaperStuBatchQuesRela_TotalEN> arrvcc_PaperStuBatchQuesRela_TotalObjLst_Sel =
from objvcc_PaperStuBatchQuesRela_TotalEN in arrvcc_PaperStuBatchQuesRela_TotalObjLst_Cache
where objvcc_PaperStuBatchQuesRela_TotalEN.Id_PaperStuBatchQuesRela_Total == lngId_PaperStuBatchQuesRela_Total
select objvcc_PaperStuBatchQuesRela_TotalEN;
if (arrvcc_PaperStuBatchQuesRela_TotalObjLst_Sel.Count() == 0)
{
   clsvcc_PaperStuBatchQuesRela_TotalEN obj = clsvcc_PaperStuBatchQuesRela_TotalWApi.GetObjById_PaperStuBatchQuesRela_Total(lngId_PaperStuBatchQuesRela_Total);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_PaperStuBatchQuesRela_TotalObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_PaperStuBatchQuesRela_TotalEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_PaperStuBatchQuesRela_TotalEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PaperStuBatchQuesRela_TotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_PaperStuBatchQuesRela_TotalEN> GetObjLstById_PaperStuBatchQuesRela_TotalLst(List<long> arrId_PaperStuBatchQuesRela_Total)
{
 List<clsvcc_PaperStuBatchQuesRela_TotalEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PaperStuBatchQuesRela_TotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvcc_PaperStuBatchQuesRela_TotalEN> GetObjLstById_PaperStuBatchQuesRela_TotalLst_Cache(List<long> arrId_PaperStuBatchQuesRela_Total)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_PaperStuBatchQuesRela_TotalEN._CurrTabName_S);
List<clsvcc_PaperStuBatchQuesRela_TotalEN> arrvcc_PaperStuBatchQuesRela_TotalObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_PaperStuBatchQuesRela_TotalEN> arrvcc_PaperStuBatchQuesRela_TotalObjLst_Sel =
from objvcc_PaperStuBatchQuesRela_TotalEN in arrvcc_PaperStuBatchQuesRela_TotalObjLst_Cache
where arrId_PaperStuBatchQuesRela_Total.Contains(objvcc_PaperStuBatchQuesRela_TotalEN.Id_PaperStuBatchQuesRela_Total)
select objvcc_PaperStuBatchQuesRela_TotalEN;
return arrvcc_PaperStuBatchQuesRela_TotalObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_PaperStuBatchQuesRela_TotalEN> GetObjLstById_PaperStuBatchQuesRela_TotalLst_WA_Cache(List<long> arrId_PaperStuBatchQuesRela_Total)
{
 List<clsvcc_PaperStuBatchQuesRela_TotalEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PaperStuBatchQuesRela_TotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_PaperStuBatchQuesRela_TotalEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_PaperStuBatchQuesRela_TotalEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PaperStuBatchQuesRela_TotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_PaperStuBatchQuesRela_TotalEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_PaperStuBatchQuesRela_TotalEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PaperStuBatchQuesRela_TotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_PaperStuBatchQuesRela_TotalEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_PaperStuBatchQuesRela_TotalEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PaperStuBatchQuesRela_TotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_PaperStuBatchQuesRela_TotalEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_PaperStuBatchQuesRela_TotalEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PaperStuBatchQuesRela_TotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalENS">源对象</param>
 /// <param name = "objvcc_PaperStuBatchQuesRela_TotalENT">目标对象</param>
 public static void CopyTo(clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalENS, clsvcc_PaperStuBatchQuesRela_TotalEN objvcc_PaperStuBatchQuesRela_TotalENT)
{
try
{
objvcc_PaperStuBatchQuesRela_TotalENT.Id_PaperStuBatchQuesRela_Total = objvcc_PaperStuBatchQuesRela_TotalENS.Id_PaperStuBatchQuesRela_Total; //学生试卷完成汇总流水号
objvcc_PaperStuBatchQuesRela_TotalENT.id_CurrEduCls = objvcc_PaperStuBatchQuesRela_TotalENS.id_CurrEduCls; //当前教学班流水号
objvcc_PaperStuBatchQuesRela_TotalENT.CurrEduClsId = objvcc_PaperStuBatchQuesRela_TotalENS.CurrEduClsId; //当前教学班Id
objvcc_PaperStuBatchQuesRela_TotalENT.EduClsName = objvcc_PaperStuBatchQuesRela_TotalENS.EduClsName; //教学班名称
objvcc_PaperStuBatchQuesRela_TotalENT.CourseId = objvcc_PaperStuBatchQuesRela_TotalENS.CourseId; //课程Id
objvcc_PaperStuBatchQuesRela_TotalENT.CourseName = objvcc_PaperStuBatchQuesRela_TotalENS.CourseName; //课程名称
objvcc_PaperStuBatchQuesRela_TotalENT.CourseExamPaperId = objvcc_PaperStuBatchQuesRela_TotalENS.CourseExamPaperId; //考卷流水号
objvcc_PaperStuBatchQuesRela_TotalENT.Id_PaperStuBatch = objvcc_PaperStuBatchQuesRela_TotalENS.Id_PaperStuBatch; //学生试卷批次流水号
objvcc_PaperStuBatchQuesRela_TotalENT.id_StudentInfo = objvcc_PaperStuBatchQuesRela_TotalENS.id_StudentInfo; //学生流水号
objvcc_PaperStuBatchQuesRela_TotalENT.StuID = objvcc_PaperStuBatchQuesRela_TotalENS.StuID; //学号
objvcc_PaperStuBatchQuesRela_TotalENT.StuName = objvcc_PaperStuBatchQuesRela_TotalENS.StuName; //姓名
objvcc_PaperStuBatchQuesRela_TotalENT.SexDesc = objvcc_PaperStuBatchQuesRela_TotalENS.SexDesc; //性别名称
objvcc_PaperStuBatchQuesRela_TotalENT.id_XzCollege = objvcc_PaperStuBatchQuesRela_TotalENS.id_XzCollege; //学院流水号
objvcc_PaperStuBatchQuesRela_TotalENT.CollegeName = objvcc_PaperStuBatchQuesRela_TotalENS.CollegeName; //学院名称
objvcc_PaperStuBatchQuesRela_TotalENT.CollegeNameA = objvcc_PaperStuBatchQuesRela_TotalENS.CollegeNameA; //学院名称简写
objvcc_PaperStuBatchQuesRela_TotalENT.id_XzMajor = objvcc_PaperStuBatchQuesRela_TotalENS.id_XzMajor; //专业流水号
objvcc_PaperStuBatchQuesRela_TotalENT.MajorID = objvcc_PaperStuBatchQuesRela_TotalENS.MajorID; //专业ID
objvcc_PaperStuBatchQuesRela_TotalENT.MajorName = objvcc_PaperStuBatchQuesRela_TotalENS.MajorName; //专业名称
objvcc_PaperStuBatchQuesRela_TotalENT.id_GradeBase = objvcc_PaperStuBatchQuesRela_TotalENS.id_GradeBase; //年级流水号
objvcc_PaperStuBatchQuesRela_TotalENT.GradeBaseName = objvcc_PaperStuBatchQuesRela_TotalENS.GradeBaseName; //年级名称
objvcc_PaperStuBatchQuesRela_TotalENT.AdminClsName = objvcc_PaperStuBatchQuesRela_TotalENS.AdminClsName; //行政班名称
objvcc_PaperStuBatchQuesRela_TotalENT.AdminClsId = objvcc_PaperStuBatchQuesRela_TotalENS.AdminClsId; //行政班代号
objvcc_PaperStuBatchQuesRela_TotalENT.BatchTime = objvcc_PaperStuBatchQuesRela_TotalENS.BatchTime; //批次
objvcc_PaperStuBatchQuesRela_TotalENT.QuesNum = objvcc_PaperStuBatchQuesRela_TotalENS.QuesNum; //题目数
objvcc_PaperStuBatchQuesRela_TotalENT.QuesNum_Look = objvcc_PaperStuBatchQuesRela_TotalENS.QuesNum_Look; //查看题目数
objvcc_PaperStuBatchQuesRela_TotalENT.QuesNum_Mark = objvcc_PaperStuBatchQuesRela_TotalENS.QuesNum_Mark; //打分题目数
objvcc_PaperStuBatchQuesRela_TotalENT.QuesNum_NoFinish = objvcc_PaperStuBatchQuesRela_TotalENS.QuesNum_NoFinish; //未完成题目数
objvcc_PaperStuBatchQuesRela_TotalENT.QuesNum_Overdue = objvcc_PaperStuBatchQuesRela_TotalENS.QuesNum_Overdue; //逾期题目数
objvcc_PaperStuBatchQuesRela_TotalENT.QuesNum_Save = objvcc_PaperStuBatchQuesRela_TotalENS.QuesNum_Save; //保存题目数
objvcc_PaperStuBatchQuesRela_TotalENT.QuesNum_SendBack = objvcc_PaperStuBatchQuesRela_TotalENS.QuesNum_SendBack; //退回题目数
objvcc_PaperStuBatchQuesRela_TotalENT.QuesNum_Submit = objvcc_PaperStuBatchQuesRela_TotalENS.QuesNum_Submit; //提交题目数
objvcc_PaperStuBatchQuesRela_TotalENT.TotalScore = objvcc_PaperStuBatchQuesRela_TotalENS.TotalScore; //总得分
objvcc_PaperStuBatchQuesRela_TotalENT.TotalScores = objvcc_PaperStuBatchQuesRela_TotalENS.TotalScores; //总分值
objvcc_PaperStuBatchQuesRela_TotalENT.SchoolYear = objvcc_PaperStuBatchQuesRela_TotalENS.SchoolYear; //学年
objvcc_PaperStuBatchQuesRela_TotalENT.SchoolTerm = objvcc_PaperStuBatchQuesRela_TotalENS.SchoolTerm; //学期
objvcc_PaperStuBatchQuesRela_TotalENT.UpdDate = objvcc_PaperStuBatchQuesRela_TotalENS.UpdDate; //修改日期
objvcc_PaperStuBatchQuesRela_TotalENT.UpdUserId = objvcc_PaperStuBatchQuesRela_TotalENS.UpdUserId; //修改用户Id
objvcc_PaperStuBatchQuesRela_TotalENT.Memo = objvcc_PaperStuBatchQuesRela_TotalENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvcc_PaperStuBatchQuesRela_TotalEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_PaperStuBatchQuesRela_TotalEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_PaperStuBatchQuesRela_TotalEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_PaperStuBatchQuesRela_TotalEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_PaperStuBatchQuesRela_TotalEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_PaperStuBatchQuesRela_TotalEN.AttributeName)
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
//if (arrvcc_PaperStuBatchQuesRela_TotalObjLst_Cache == null)
//{
//arrvcc_PaperStuBatchQuesRela_TotalObjLst_Cache = await clsvcc_PaperStuBatchQuesRela_TotalWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvcc_PaperStuBatchQuesRela_TotalEN._CurrTabName_S);
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
public static List<clsvcc_PaperStuBatchQuesRela_TotalEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvcc_PaperStuBatchQuesRela_TotalEN._CurrTabName_S);
List<clsvcc_PaperStuBatchQuesRela_TotalEN> arrvcc_PaperStuBatchQuesRela_TotalObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_PaperStuBatchQuesRela_TotalObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_PaperStuBatchQuesRela_TotalEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.Id_PaperStuBatchQuesRela_Total, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.CurrEduClsId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.EduClsName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.CourseExamPaperId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.Id_PaperStuBatch, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.SexDesc, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.AdminClsName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.AdminClsId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.BatchTime, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.QuesNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.QuesNum_Look, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.QuesNum_Mark, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.QuesNum_NoFinish, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.QuesNum_Overdue, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.QuesNum_Save, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.QuesNum_SendBack, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.QuesNum_Submit, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.TotalScore, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.TotalScores, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.SchoolYear, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.SchoolTerm, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela_Total.Memo, Type.GetType("System.String"));
foreach (clsvcc_PaperStuBatchQuesRela_TotalEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_PaperStuBatchQuesRela_Total.Id_PaperStuBatchQuesRela_Total] = objInFor[convcc_PaperStuBatchQuesRela_Total.Id_PaperStuBatchQuesRela_Total];
objDR[convcc_PaperStuBatchQuesRela_Total.id_CurrEduCls] = objInFor[convcc_PaperStuBatchQuesRela_Total.id_CurrEduCls];
objDR[convcc_PaperStuBatchQuesRela_Total.CurrEduClsId] = objInFor[convcc_PaperStuBatchQuesRela_Total.CurrEduClsId];
objDR[convcc_PaperStuBatchQuesRela_Total.EduClsName] = objInFor[convcc_PaperStuBatchQuesRela_Total.EduClsName];
objDR[convcc_PaperStuBatchQuesRela_Total.CourseId] = objInFor[convcc_PaperStuBatchQuesRela_Total.CourseId];
objDR[convcc_PaperStuBatchQuesRela_Total.CourseName] = objInFor[convcc_PaperStuBatchQuesRela_Total.CourseName];
objDR[convcc_PaperStuBatchQuesRela_Total.CourseExamPaperId] = objInFor[convcc_PaperStuBatchQuesRela_Total.CourseExamPaperId];
objDR[convcc_PaperStuBatchQuesRela_Total.Id_PaperStuBatch] = objInFor[convcc_PaperStuBatchQuesRela_Total.Id_PaperStuBatch];
objDR[convcc_PaperStuBatchQuesRela_Total.id_StudentInfo] = objInFor[convcc_PaperStuBatchQuesRela_Total.id_StudentInfo];
objDR[convcc_PaperStuBatchQuesRela_Total.StuID] = objInFor[convcc_PaperStuBatchQuesRela_Total.StuID];
objDR[convcc_PaperStuBatchQuesRela_Total.StuName] = objInFor[convcc_PaperStuBatchQuesRela_Total.StuName];
objDR[convcc_PaperStuBatchQuesRela_Total.SexDesc] = objInFor[convcc_PaperStuBatchQuesRela_Total.SexDesc];
objDR[convcc_PaperStuBatchQuesRela_Total.id_XzCollege] = objInFor[convcc_PaperStuBatchQuesRela_Total.id_XzCollege];
objDR[convcc_PaperStuBatchQuesRela_Total.CollegeName] = objInFor[convcc_PaperStuBatchQuesRela_Total.CollegeName];
objDR[convcc_PaperStuBatchQuesRela_Total.CollegeNameA] = objInFor[convcc_PaperStuBatchQuesRela_Total.CollegeNameA];
objDR[convcc_PaperStuBatchQuesRela_Total.id_XzMajor] = objInFor[convcc_PaperStuBatchQuesRela_Total.id_XzMajor];
objDR[convcc_PaperStuBatchQuesRela_Total.MajorID] = objInFor[convcc_PaperStuBatchQuesRela_Total.MajorID];
objDR[convcc_PaperStuBatchQuesRela_Total.MajorName] = objInFor[convcc_PaperStuBatchQuesRela_Total.MajorName];
objDR[convcc_PaperStuBatchQuesRela_Total.id_GradeBase] = objInFor[convcc_PaperStuBatchQuesRela_Total.id_GradeBase];
objDR[convcc_PaperStuBatchQuesRela_Total.GradeBaseName] = objInFor[convcc_PaperStuBatchQuesRela_Total.GradeBaseName];
objDR[convcc_PaperStuBatchQuesRela_Total.AdminClsName] = objInFor[convcc_PaperStuBatchQuesRela_Total.AdminClsName];
objDR[convcc_PaperStuBatchQuesRela_Total.AdminClsId] = objInFor[convcc_PaperStuBatchQuesRela_Total.AdminClsId];
objDR[convcc_PaperStuBatchQuesRela_Total.BatchTime] = objInFor[convcc_PaperStuBatchQuesRela_Total.BatchTime];
objDR[convcc_PaperStuBatchQuesRela_Total.QuesNum] = objInFor[convcc_PaperStuBatchQuesRela_Total.QuesNum];
objDR[convcc_PaperStuBatchQuesRela_Total.QuesNum_Look] = objInFor[convcc_PaperStuBatchQuesRela_Total.QuesNum_Look];
objDR[convcc_PaperStuBatchQuesRela_Total.QuesNum_Mark] = objInFor[convcc_PaperStuBatchQuesRela_Total.QuesNum_Mark];
objDR[convcc_PaperStuBatchQuesRela_Total.QuesNum_NoFinish] = objInFor[convcc_PaperStuBatchQuesRela_Total.QuesNum_NoFinish];
objDR[convcc_PaperStuBatchQuesRela_Total.QuesNum_Overdue] = objInFor[convcc_PaperStuBatchQuesRela_Total.QuesNum_Overdue];
objDR[convcc_PaperStuBatchQuesRela_Total.QuesNum_Save] = objInFor[convcc_PaperStuBatchQuesRela_Total.QuesNum_Save];
objDR[convcc_PaperStuBatchQuesRela_Total.QuesNum_SendBack] = objInFor[convcc_PaperStuBatchQuesRela_Total.QuesNum_SendBack];
objDR[convcc_PaperStuBatchQuesRela_Total.QuesNum_Submit] = objInFor[convcc_PaperStuBatchQuesRela_Total.QuesNum_Submit];
objDR[convcc_PaperStuBatchQuesRela_Total.TotalScore] = objInFor[convcc_PaperStuBatchQuesRela_Total.TotalScore];
objDR[convcc_PaperStuBatchQuesRela_Total.TotalScores] = objInFor[convcc_PaperStuBatchQuesRela_Total.TotalScores];
objDR[convcc_PaperStuBatchQuesRela_Total.SchoolYear] = objInFor[convcc_PaperStuBatchQuesRela_Total.SchoolYear];
objDR[convcc_PaperStuBatchQuesRela_Total.SchoolTerm] = objInFor[convcc_PaperStuBatchQuesRela_Total.SchoolTerm];
objDR[convcc_PaperStuBatchQuesRela_Total.UpdDate] = objInFor[convcc_PaperStuBatchQuesRela_Total.UpdDate];
objDR[convcc_PaperStuBatchQuesRela_Total.UpdUserId] = objInFor[convcc_PaperStuBatchQuesRela_Total.UpdUserId];
objDR[convcc_PaperStuBatchQuesRela_Total.Memo] = objInFor[convcc_PaperStuBatchQuesRela_Total.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}