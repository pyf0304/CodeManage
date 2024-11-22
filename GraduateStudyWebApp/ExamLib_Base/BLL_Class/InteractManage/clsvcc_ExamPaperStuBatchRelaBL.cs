
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_ExamPaperStuBatchRelaBL
 表名:vcc_ExamPaperStuBatchRela(01120242)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:02
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
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
public static class  clsvcc_ExamPaperStuBatchRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdPaperStuBatch">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_ExamPaperStuBatchRelaEN GetObj(this K_IdPaperStuBatch_vcc_ExamPaperStuBatchRela myKey)
{
clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN = clsvcc_ExamPaperStuBatchRelaBL.vcc_ExamPaperStuBatchRelaDA.GetObjByIdPaperStuBatch(myKey.Value);
return objvcc_ExamPaperStuBatchRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetIdPaperStuBatch(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strIdPaperStuBatch, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPaperStuBatch, 10, convcc_ExamPaperStuBatchRela.IdPaperStuBatch);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPaperStuBatch, 10, convcc_ExamPaperStuBatchRela.IdPaperStuBatch);
}
objvcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = strIdPaperStuBatch; //学生试卷批次流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.IdPaperStuBatch) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.IdPaperStuBatch, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.IdPaperStuBatch] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetCourseExamPaperId(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strCourseExamPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, convcc_ExamPaperStuBatchRela.CourseExamPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, convcc_ExamPaperStuBatchRela.CourseExamPaperId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetCourseId(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_ExamPaperStuBatchRela.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_ExamPaperStuBatchRela.CourseId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetCourseName(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_ExamPaperStuBatchRela.CourseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetExamPaperName(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strExamPaperName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamPaperName, 500, convcc_ExamPaperStuBatchRela.ExamPaperName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetPaperIndex(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, int? intPaperIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetExamPaperTypeId(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strExamPaperTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strExamPaperTypeId, convcc_ExamPaperStuBatchRela.ExamPaperTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamPaperTypeId, 2, convcc_ExamPaperStuBatchRela.ExamPaperTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strExamPaperTypeId, 2, convcc_ExamPaperStuBatchRela.ExamPaperTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetExamPaperTypeName(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strExamPaperTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strExamPaperTypeName, convcc_ExamPaperStuBatchRela.ExamPaperTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamPaperTypeName, 30, convcc_ExamPaperStuBatchRela.ExamPaperTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetViewCount(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, int? intViewCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetDoneNumber(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, int? intDoneNumber, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetPaperTime(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, int? intPaperTime, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetPaperDispModeName(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strPaperDispModeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperDispModeName, 30, convcc_ExamPaperStuBatchRela.PaperDispModeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetExamCreateTime(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strExamCreateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamCreateTime, 14, convcc_ExamPaperStuBatchRela.ExamCreateTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetUserName(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convcc_ExamPaperStuBatchRela.UserName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetCourseChapterId(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, convcc_ExamPaperStuBatchRela.CourseChapterId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_ExamPaperStuBatchRela.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_ExamPaperStuBatchRela.CourseChapterId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetCourseChapterName(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterName, convcc_ExamPaperStuBatchRela.CourseChapterName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_ExamPaperStuBatchRela.CourseChapterName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetChapterId(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterId, 8, convcc_ExamPaperStuBatchRela.ChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convcc_ExamPaperStuBatchRela.ChapterId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetSectionId(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strSectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionId, 8, convcc_ExamPaperStuBatchRela.SectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convcc_ExamPaperStuBatchRela.SectionId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetChapterName(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_ExamPaperStuBatchRela.ChapterName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetSectionName(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_ExamPaperStuBatchRela.SectionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetChapterNameSim(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strChapterNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterNameSim, 10, convcc_ExamPaperStuBatchRela.ChapterNameSim);
}
objvcc_ExamPaperStuBatchRelaEN.ChapterNameSim = strChapterNameSim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.ChapterNameSim) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.ChapterNameSim, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.ChapterNameSim] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetSectionNameSim(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strSectionNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionNameSim, 10, convcc_ExamPaperStuBatchRela.SectionNameSim);
}
objvcc_ExamPaperStuBatchRelaEN.SectionNameSim = strSectionNameSim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.SectionNameSim) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.SectionNameSim, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.SectionNameSim] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetQuestionNum(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, int? intQuestionNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetIdStudentInfo(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strIdStudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdStudentInfo, convcc_ExamPaperStuBatchRela.IdStudentInfo);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudentInfo, 8, convcc_ExamPaperStuBatchRela.IdStudentInfo);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudentInfo, 8, convcc_ExamPaperStuBatchRela.IdStudentInfo);
}
objvcc_ExamPaperStuBatchRelaEN.IdStudentInfo = strIdStudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.IdStudentInfo) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.IdStudentInfo, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.IdStudentInfo] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetStuID(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strStuID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuID, 20, convcc_ExamPaperStuBatchRela.StuID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetStuName(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strStuName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuName, 50, convcc_ExamPaperStuBatchRela.StuName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetSexDesc(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strSexDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convcc_ExamPaperStuBatchRela.SexDesc);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetIdXzCollege(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convcc_ExamPaperStuBatchRela.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convcc_ExamPaperStuBatchRela.IdXzCollege);
}
objvcc_ExamPaperStuBatchRelaEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.IdXzCollege) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.IdXzCollege, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.IdXzCollege] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetCollegeName(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convcc_ExamPaperStuBatchRela.CollegeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetCollegeNameA(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convcc_ExamPaperStuBatchRela.CollegeNameA);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetIdXzMajor(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convcc_ExamPaperStuBatchRela.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convcc_ExamPaperStuBatchRela.IdXzMajor);
}
objvcc_ExamPaperStuBatchRelaEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.IdXzMajor) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.IdXzMajor, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.IdXzMajor] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetMajorID(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strMajorID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorID, 4, convcc_ExamPaperStuBatchRela.MajorID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convcc_ExamPaperStuBatchRela.MajorID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetMajorName(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convcc_ExamPaperStuBatchRela.MajorName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetIdGradeBase(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strIdGradeBase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, convcc_ExamPaperStuBatchRela.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, convcc_ExamPaperStuBatchRela.IdGradeBase);
}
objvcc_ExamPaperStuBatchRelaEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.IdGradeBase) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.IdGradeBase, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.IdGradeBase] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetGradeBaseName(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strGradeBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convcc_ExamPaperStuBatchRela.GradeBaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetBatchTime(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strBatchTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBatchTime, 14, convcc_ExamPaperStuBatchRela.BatchTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetIdCurrEduCls(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strIdCurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCurrEduCls, convcc_ExamPaperStuBatchRela.IdCurrEduCls);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convcc_ExamPaperStuBatchRela.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convcc_ExamPaperStuBatchRela.IdCurrEduCls);
}
objvcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuBatchRela.IdCurrEduCls) == false)
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(convcc_ExamPaperStuBatchRela.IdCurrEduCls, strComparisonOp);
}
else
{
objvcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.IdCurrEduCls] = strComparisonOp;
}
}
return objvcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetCurrEduClsId(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strCurrEduClsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, convcc_ExamPaperStuBatchRela.CurrEduClsId);
}
objvcc_ExamPaperStuBatchRelaEN.CurrEduClsId = strCurrEduClsId; //教学班Id
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetEduClsName(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduClsName, convcc_ExamPaperStuBatchRela.EduClsName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convcc_ExamPaperStuBatchRela.EduClsName);
}
objvcc_ExamPaperStuBatchRelaEN.EduClsName = strEduClsName; //教学班名
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetScores(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, double? dblScores, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetRealFinishDate(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strRealFinishDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRealFinishDate, 14, convcc_ExamPaperStuBatchRela.RealFinishDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetOperateTime(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strOperateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperateTime, 14, convcc_ExamPaperStuBatchRela.OperateTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetMarkerId(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strMarkerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMarkerId, 20, convcc_ExamPaperStuBatchRela.MarkerId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetMarkDate(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strMarkDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMarkDate, 14, convcc_ExamPaperStuBatchRela.MarkDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetAnswerIP(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strAnswerIP, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerIP, 30, convcc_ExamPaperStuBatchRela.AnswerIP);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetAnswerDate(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strAnswerDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerDate, 8, convcc_ExamPaperStuBatchRela.AnswerDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetAnswerTime(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strAnswerTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTime, 10, convcc_ExamPaperStuBatchRela.AnswerTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetUpdDate(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_ExamPaperStuBatchRela.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_ExamPaperStuBatchRela.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetUpdUserId(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_ExamPaperStuBatchRela.UpdUserId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetMemo(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_ExamPaperStuBatchRela.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetNoSubmitQuesNum(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, int? intNoSubmitQuesNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuBatchRelaEN SetSubmitQuesNum(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN, int? intSubmitQuesNum, string strComparisonOp="")
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaENS">源对象</param>
 /// <param name = "objvcc_ExamPaperStuBatchRelaENT">目标对象</param>
 public static void CopyTo(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaENS, clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaENT)
{
try
{
objvcc_ExamPaperStuBatchRelaENT.IdPaperStuBatch = objvcc_ExamPaperStuBatchRelaENS.IdPaperStuBatch; //学生试卷批次流水号
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
objvcc_ExamPaperStuBatchRelaENT.ChapterNameSim = objvcc_ExamPaperStuBatchRelaENS.ChapterNameSim; //章名简称
objvcc_ExamPaperStuBatchRelaENT.SectionNameSim = objvcc_ExamPaperStuBatchRelaENS.SectionNameSim; //节名简称
objvcc_ExamPaperStuBatchRelaENT.IsAutoGeneQuestion = objvcc_ExamPaperStuBatchRelaENS.IsAutoGeneQuestion; //是否自动生成题目
objvcc_ExamPaperStuBatchRelaENT.IsCanMultiDo = objvcc_ExamPaperStuBatchRelaENS.IsCanMultiDo; //是否可以做多次
objvcc_ExamPaperStuBatchRelaENT.QuestionNum = objvcc_ExamPaperStuBatchRelaENS.QuestionNum; //题目数
objvcc_ExamPaperStuBatchRelaENT.IdStudentInfo = objvcc_ExamPaperStuBatchRelaENS.IdStudentInfo; //学生流水号
objvcc_ExamPaperStuBatchRelaENT.StuID = objvcc_ExamPaperStuBatchRelaENS.StuID; //学号
objvcc_ExamPaperStuBatchRelaENT.StuName = objvcc_ExamPaperStuBatchRelaENS.StuName; //姓名
objvcc_ExamPaperStuBatchRelaENT.SexDesc = objvcc_ExamPaperStuBatchRelaENS.SexDesc; //性别名称
objvcc_ExamPaperStuBatchRelaENT.IdXzCollege = objvcc_ExamPaperStuBatchRelaENS.IdXzCollege; //学院流水号
objvcc_ExamPaperStuBatchRelaENT.CollegeName = objvcc_ExamPaperStuBatchRelaENS.CollegeName; //学院名称
objvcc_ExamPaperStuBatchRelaENT.CollegeNameA = objvcc_ExamPaperStuBatchRelaENS.CollegeNameA; //学院名称简写
objvcc_ExamPaperStuBatchRelaENT.IdXzMajor = objvcc_ExamPaperStuBatchRelaENS.IdXzMajor; //专业流水号
objvcc_ExamPaperStuBatchRelaENT.MajorID = objvcc_ExamPaperStuBatchRelaENS.MajorID; //专业ID
objvcc_ExamPaperStuBatchRelaENT.MajorName = objvcc_ExamPaperStuBatchRelaENS.MajorName; //专业名称
objvcc_ExamPaperStuBatchRelaENT.IdGradeBase = objvcc_ExamPaperStuBatchRelaENS.IdGradeBase; //年级流水号
objvcc_ExamPaperStuBatchRelaENT.GradeBaseName = objvcc_ExamPaperStuBatchRelaENS.GradeBaseName; //年级名称
objvcc_ExamPaperStuBatchRelaENT.BatchTime = objvcc_ExamPaperStuBatchRelaENS.BatchTime; //批次
objvcc_ExamPaperStuBatchRelaENT.IdCurrEduCls = objvcc_ExamPaperStuBatchRelaENS.IdCurrEduCls; //教学班流水号
objvcc_ExamPaperStuBatchRelaENT.CurrEduClsId = objvcc_ExamPaperStuBatchRelaENS.CurrEduClsId; //教学班Id
objvcc_ExamPaperStuBatchRelaENT.EduClsName = objvcc_ExamPaperStuBatchRelaENS.EduClsName; //教学班名
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
 /// <param name = "objvcc_ExamPaperStuBatchRelaENS">源对象</param>
 /// <returns>目标对象=>clsvcc_ExamPaperStuBatchRelaEN:objvcc_ExamPaperStuBatchRelaENT</returns>
 public static clsvcc_ExamPaperStuBatchRelaEN CopyTo(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaENS)
{
try
{
 clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaENT = new clsvcc_ExamPaperStuBatchRelaEN()
{
IdPaperStuBatch = objvcc_ExamPaperStuBatchRelaENS.IdPaperStuBatch, //学生试卷批次流水号
CourseExamPaperId = objvcc_ExamPaperStuBatchRelaENS.CourseExamPaperId, //考卷流水号
CourseId = objvcc_ExamPaperStuBatchRelaENS.CourseId, //课程Id
CourseName = objvcc_ExamPaperStuBatchRelaENS.CourseName, //课程名称
ExamPaperName = objvcc_ExamPaperStuBatchRelaENS.ExamPaperName, //考卷名称
PaperIndex = objvcc_ExamPaperStuBatchRelaENS.PaperIndex, //试卷序号
ExamPaperTypeId = objvcc_ExamPaperStuBatchRelaENS.ExamPaperTypeId, //试卷类型Id
ExamPaperTypeName = objvcc_ExamPaperStuBatchRelaENS.ExamPaperTypeName, //试卷类型名称
IsShow = objvcc_ExamPaperStuBatchRelaENS.IsShow, //是否启用
TotalScore = objvcc_ExamPaperStuBatchRelaENS.TotalScore, //总得分
ViewCount = objvcc_ExamPaperStuBatchRelaENS.ViewCount, //浏览量
DoneNumber = objvcc_ExamPaperStuBatchRelaENS.DoneNumber, //已做人数
PaperTime = objvcc_ExamPaperStuBatchRelaENS.PaperTime, //考试时间（分钟）
PaperDispModeName = objvcc_ExamPaperStuBatchRelaENS.PaperDispModeName, //试卷显示模式名称
ExamCreateTime = objvcc_ExamPaperStuBatchRelaENS.ExamCreateTime, //考卷建立时间
UserName = objvcc_ExamPaperStuBatchRelaENS.UserName, //用户名
CourseChapterId = objvcc_ExamPaperStuBatchRelaENS.CourseChapterId, //课程章节ID
CourseChapterName = objvcc_ExamPaperStuBatchRelaENS.CourseChapterName, //课程章节名称
ChapterId = objvcc_ExamPaperStuBatchRelaENS.ChapterId, //章Id
SectionId = objvcc_ExamPaperStuBatchRelaENS.SectionId, //节Id
ChapterName = objvcc_ExamPaperStuBatchRelaENS.ChapterName, //章名
SectionName = objvcc_ExamPaperStuBatchRelaENS.SectionName, //节名
ChapterNameSim = objvcc_ExamPaperStuBatchRelaENS.ChapterNameSim, //章名简称
SectionNameSim = objvcc_ExamPaperStuBatchRelaENS.SectionNameSim, //节名简称
IsAutoGeneQuestion = objvcc_ExamPaperStuBatchRelaENS.IsAutoGeneQuestion, //是否自动生成题目
IsCanMultiDo = objvcc_ExamPaperStuBatchRelaENS.IsCanMultiDo, //是否可以做多次
QuestionNum = objvcc_ExamPaperStuBatchRelaENS.QuestionNum, //题目数
IdStudentInfo = objvcc_ExamPaperStuBatchRelaENS.IdStudentInfo, //学生流水号
StuID = objvcc_ExamPaperStuBatchRelaENS.StuID, //学号
StuName = objvcc_ExamPaperStuBatchRelaENS.StuName, //姓名
SexDesc = objvcc_ExamPaperStuBatchRelaENS.SexDesc, //性别名称
IdXzCollege = objvcc_ExamPaperStuBatchRelaENS.IdXzCollege, //学院流水号
CollegeName = objvcc_ExamPaperStuBatchRelaENS.CollegeName, //学院名称
CollegeNameA = objvcc_ExamPaperStuBatchRelaENS.CollegeNameA, //学院名称简写
IdXzMajor = objvcc_ExamPaperStuBatchRelaENS.IdXzMajor, //专业流水号
MajorID = objvcc_ExamPaperStuBatchRelaENS.MajorID, //专业ID
MajorName = objvcc_ExamPaperStuBatchRelaENS.MajorName, //专业名称
IdGradeBase = objvcc_ExamPaperStuBatchRelaENS.IdGradeBase, //年级流水号
GradeBaseName = objvcc_ExamPaperStuBatchRelaENS.GradeBaseName, //年级名称
BatchTime = objvcc_ExamPaperStuBatchRelaENS.BatchTime, //批次
IdCurrEduCls = objvcc_ExamPaperStuBatchRelaENS.IdCurrEduCls, //教学班流水号
CurrEduClsId = objvcc_ExamPaperStuBatchRelaENS.CurrEduClsId, //教学班Id
EduClsName = objvcc_ExamPaperStuBatchRelaENS.EduClsName, //教学班名
Scores = objvcc_ExamPaperStuBatchRelaENS.Scores, //分值
IsSave = objvcc_ExamPaperStuBatchRelaENS.IsSave, //是否保存
IsSubmit = objvcc_ExamPaperStuBatchRelaENS.IsSubmit, //是否提交
RealFinishDate = objvcc_ExamPaperStuBatchRelaENS.RealFinishDate, //实际完成日期
OperateTime = objvcc_ExamPaperStuBatchRelaENS.OperateTime, //操作时间
IsMarking = objvcc_ExamPaperStuBatchRelaENS.IsMarking, //是否批阅
MarkerId = objvcc_ExamPaperStuBatchRelaENS.MarkerId, //打分者
MarkDate = objvcc_ExamPaperStuBatchRelaENS.MarkDate, //打分日期
AnswerIP = objvcc_ExamPaperStuBatchRelaENS.AnswerIP, //回答IP
AnswerDate = objvcc_ExamPaperStuBatchRelaENS.AnswerDate, //回答日期
AnswerTime = objvcc_ExamPaperStuBatchRelaENS.AnswerTime, //回答时间
TotalGetScore = objvcc_ExamPaperStuBatchRelaENS.TotalGetScore, //考生获取总分
UpdDate = objvcc_ExamPaperStuBatchRelaENS.UpdDate, //修改日期
UpdUserId = objvcc_ExamPaperStuBatchRelaENS.UpdUserId, //修改用户Id
Memo = objvcc_ExamPaperStuBatchRelaENS.Memo, //备注
NoSubmitQuesNum = objvcc_ExamPaperStuBatchRelaENS.NoSubmitQuesNum, //未提交题数
SubmitQuesNum = objvcc_ExamPaperStuBatchRelaENS.SubmitQuesNum, //提交题数
};
 return objvcc_ExamPaperStuBatchRelaENT;
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
public static void CheckProperty4Condition(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN)
{
 clsvcc_ExamPaperStuBatchRelaBL.vcc_ExamPaperStuBatchRelaDA.CheckProperty4Condition(objvcc_ExamPaperStuBatchRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.IdPaperStuBatch) == true)
{
string strComparisonOpIdPaperStuBatch = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.IdPaperStuBatch];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.IdPaperStuBatch, objvcc_ExamPaperStuBatchRelaCond.IdPaperStuBatch, strComparisonOpIdPaperStuBatch);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.CourseExamPaperId) == true)
{
string strComparisonOpCourseExamPaperId = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.CourseExamPaperId, objvcc_ExamPaperStuBatchRelaCond.CourseExamPaperId, strComparisonOpCourseExamPaperId);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.CourseId) == true)
{
string strComparisonOpCourseId = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.CourseId, objvcc_ExamPaperStuBatchRelaCond.CourseId, strComparisonOpCourseId);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.CourseName) == true)
{
string strComparisonOpCourseName = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.CourseName, objvcc_ExamPaperStuBatchRelaCond.CourseName, strComparisonOpCourseName);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.ExamPaperName) == true)
{
string strComparisonOpExamPaperName = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.ExamPaperName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.ExamPaperName, objvcc_ExamPaperStuBatchRelaCond.ExamPaperName, strComparisonOpExamPaperName);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.PaperIndex) == true)
{
string strComparisonOpPaperIndex = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.PaperIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuBatchRela.PaperIndex, objvcc_ExamPaperStuBatchRelaCond.PaperIndex, strComparisonOpPaperIndex);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.ExamPaperTypeId) == true)
{
string strComparisonOpExamPaperTypeId = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.ExamPaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.ExamPaperTypeId, objvcc_ExamPaperStuBatchRelaCond.ExamPaperTypeId, strComparisonOpExamPaperTypeId);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.ExamPaperTypeName) == true)
{
string strComparisonOpExamPaperTypeName = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.ExamPaperTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.ExamPaperTypeName, objvcc_ExamPaperStuBatchRelaCond.ExamPaperTypeName, strComparisonOpExamPaperTypeName);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.IsShow) == true)
{
if (objvcc_ExamPaperStuBatchRelaCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuBatchRela.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuBatchRela.IsShow);
}
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.TotalScore) == true)
{
string strComparisonOpTotalScore = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.TotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuBatchRela.TotalScore, objvcc_ExamPaperStuBatchRelaCond.TotalScore, strComparisonOpTotalScore);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.ViewCount) == true)
{
string strComparisonOpViewCount = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuBatchRela.ViewCount, objvcc_ExamPaperStuBatchRelaCond.ViewCount, strComparisonOpViewCount);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.DoneNumber) == true)
{
string strComparisonOpDoneNumber = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.DoneNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuBatchRela.DoneNumber, objvcc_ExamPaperStuBatchRelaCond.DoneNumber, strComparisonOpDoneNumber);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.PaperTime) == true)
{
string strComparisonOpPaperTime = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.PaperTime];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuBatchRela.PaperTime, objvcc_ExamPaperStuBatchRelaCond.PaperTime, strComparisonOpPaperTime);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.PaperDispModeName) == true)
{
string strComparisonOpPaperDispModeName = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.PaperDispModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.PaperDispModeName, objvcc_ExamPaperStuBatchRelaCond.PaperDispModeName, strComparisonOpPaperDispModeName);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.ExamCreateTime) == true)
{
string strComparisonOpExamCreateTime = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.ExamCreateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.ExamCreateTime, objvcc_ExamPaperStuBatchRelaCond.ExamCreateTime, strComparisonOpExamCreateTime);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.UserName) == true)
{
string strComparisonOpUserName = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.UserName, objvcc_ExamPaperStuBatchRelaCond.UserName, strComparisonOpUserName);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.CourseChapterId, objvcc_ExamPaperStuBatchRelaCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.CourseChapterName) == true)
{
string strComparisonOpCourseChapterName = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.CourseChapterName, objvcc_ExamPaperStuBatchRelaCond.CourseChapterName, strComparisonOpCourseChapterName);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.ChapterId) == true)
{
string strComparisonOpChapterId = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.ChapterId, objvcc_ExamPaperStuBatchRelaCond.ChapterId, strComparisonOpChapterId);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.SectionId) == true)
{
string strComparisonOpSectionId = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.SectionId, objvcc_ExamPaperStuBatchRelaCond.SectionId, strComparisonOpSectionId);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.ChapterName) == true)
{
string strComparisonOpChapterName = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.ChapterName, objvcc_ExamPaperStuBatchRelaCond.ChapterName, strComparisonOpChapterName);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.SectionName) == true)
{
string strComparisonOpSectionName = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.SectionName, objvcc_ExamPaperStuBatchRelaCond.SectionName, strComparisonOpSectionName);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.ChapterNameSim) == true)
{
string strComparisonOpChapterNameSim = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.ChapterNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.ChapterNameSim, objvcc_ExamPaperStuBatchRelaCond.ChapterNameSim, strComparisonOpChapterNameSim);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.SectionNameSim) == true)
{
string strComparisonOpSectionNameSim = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.SectionNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.SectionNameSim, objvcc_ExamPaperStuBatchRelaCond.SectionNameSim, strComparisonOpSectionNameSim);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.IsAutoGeneQuestion) == true)
{
if (objvcc_ExamPaperStuBatchRelaCond.IsAutoGeneQuestion == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuBatchRela.IsAutoGeneQuestion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuBatchRela.IsAutoGeneQuestion);
}
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.IsCanMultiDo) == true)
{
if (objvcc_ExamPaperStuBatchRelaCond.IsCanMultiDo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuBatchRela.IsCanMultiDo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuBatchRela.IsCanMultiDo);
}
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.QuestionNum) == true)
{
string strComparisonOpQuestionNum = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.QuestionNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuBatchRela.QuestionNum, objvcc_ExamPaperStuBatchRelaCond.QuestionNum, strComparisonOpQuestionNum);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.IdStudentInfo) == true)
{
string strComparisonOpIdStudentInfo = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.IdStudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.IdStudentInfo, objvcc_ExamPaperStuBatchRelaCond.IdStudentInfo, strComparisonOpIdStudentInfo);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.StuID) == true)
{
string strComparisonOpStuID = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.StuID, objvcc_ExamPaperStuBatchRelaCond.StuID, strComparisonOpStuID);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.StuName) == true)
{
string strComparisonOpStuName = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.StuName, objvcc_ExamPaperStuBatchRelaCond.StuName, strComparisonOpStuName);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.SexDesc) == true)
{
string strComparisonOpSexDesc = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.SexDesc, objvcc_ExamPaperStuBatchRelaCond.SexDesc, strComparisonOpSexDesc);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.IdXzCollege, objvcc_ExamPaperStuBatchRelaCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.CollegeName) == true)
{
string strComparisonOpCollegeName = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.CollegeName, objvcc_ExamPaperStuBatchRelaCond.CollegeName, strComparisonOpCollegeName);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.CollegeNameA, objvcc_ExamPaperStuBatchRelaCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.IdXzMajor, objvcc_ExamPaperStuBatchRelaCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.MajorID) == true)
{
string strComparisonOpMajorID = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.MajorID, objvcc_ExamPaperStuBatchRelaCond.MajorID, strComparisonOpMajorID);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.MajorName) == true)
{
string strComparisonOpMajorName = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.MajorName, objvcc_ExamPaperStuBatchRelaCond.MajorName, strComparisonOpMajorName);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.IdGradeBase, objvcc_ExamPaperStuBatchRelaCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.GradeBaseName) == true)
{
string strComparisonOpGradeBaseName = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.GradeBaseName, objvcc_ExamPaperStuBatchRelaCond.GradeBaseName, strComparisonOpGradeBaseName);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.BatchTime) == true)
{
string strComparisonOpBatchTime = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.BatchTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.BatchTime, objvcc_ExamPaperStuBatchRelaCond.BatchTime, strComparisonOpBatchTime);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.IdCurrEduCls, objvcc_ExamPaperStuBatchRelaCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.CurrEduClsId) == true)
{
string strComparisonOpCurrEduClsId = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.CurrEduClsId, objvcc_ExamPaperStuBatchRelaCond.CurrEduClsId, strComparisonOpCurrEduClsId);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.EduClsName) == true)
{
string strComparisonOpEduClsName = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.EduClsName, objvcc_ExamPaperStuBatchRelaCond.EduClsName, strComparisonOpEduClsName);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.Scores) == true)
{
string strComparisonOpScores = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.Scores];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuBatchRela.Scores, objvcc_ExamPaperStuBatchRelaCond.Scores, strComparisonOpScores);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.IsSave) == true)
{
if (objvcc_ExamPaperStuBatchRelaCond.IsSave == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuBatchRela.IsSave);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuBatchRela.IsSave);
}
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.IsSubmit) == true)
{
if (objvcc_ExamPaperStuBatchRelaCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuBatchRela.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuBatchRela.IsSubmit);
}
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.RealFinishDate) == true)
{
string strComparisonOpRealFinishDate = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.RealFinishDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.RealFinishDate, objvcc_ExamPaperStuBatchRelaCond.RealFinishDate, strComparisonOpRealFinishDate);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.OperateTime) == true)
{
string strComparisonOpOperateTime = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.OperateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.OperateTime, objvcc_ExamPaperStuBatchRelaCond.OperateTime, strComparisonOpOperateTime);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.IsMarking) == true)
{
if (objvcc_ExamPaperStuBatchRelaCond.IsMarking == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuBatchRela.IsMarking);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuBatchRela.IsMarking);
}
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.MarkerId) == true)
{
string strComparisonOpMarkerId = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.MarkerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.MarkerId, objvcc_ExamPaperStuBatchRelaCond.MarkerId, strComparisonOpMarkerId);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.MarkDate) == true)
{
string strComparisonOpMarkDate = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.MarkDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.MarkDate, objvcc_ExamPaperStuBatchRelaCond.MarkDate, strComparisonOpMarkDate);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.AnswerIP) == true)
{
string strComparisonOpAnswerIP = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.AnswerIP];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.AnswerIP, objvcc_ExamPaperStuBatchRelaCond.AnswerIP, strComparisonOpAnswerIP);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.AnswerDate) == true)
{
string strComparisonOpAnswerDate = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.AnswerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.AnswerDate, objvcc_ExamPaperStuBatchRelaCond.AnswerDate, strComparisonOpAnswerDate);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.AnswerTime) == true)
{
string strComparisonOpAnswerTime = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.AnswerTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.AnswerTime, objvcc_ExamPaperStuBatchRelaCond.AnswerTime, strComparisonOpAnswerTime);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.TotalGetScore) == true)
{
string strComparisonOpTotalGetScore = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.TotalGetScore];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuBatchRela.TotalGetScore, objvcc_ExamPaperStuBatchRelaCond.TotalGetScore, strComparisonOpTotalGetScore);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.UpdDate, objvcc_ExamPaperStuBatchRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.UpdUserId, objvcc_ExamPaperStuBatchRelaCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.Memo) == true)
{
string strComparisonOpMemo = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuBatchRela.Memo, objvcc_ExamPaperStuBatchRelaCond.Memo, strComparisonOpMemo);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.NoSubmitQuesNum) == true)
{
string strComparisonOpNoSubmitQuesNum = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.NoSubmitQuesNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuBatchRela.NoSubmitQuesNum, objvcc_ExamPaperStuBatchRelaCond.NoSubmitQuesNum, strComparisonOpNoSubmitQuesNum);
}
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(convcc_ExamPaperStuBatchRela.SubmitQuesNum) == true)
{
string strComparisonOpSubmitQuesNum = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[convcc_ExamPaperStuBatchRela.SubmitQuesNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuBatchRela.SubmitQuesNum, objvcc_ExamPaperStuBatchRelaCond.SubmitQuesNum, strComparisonOpSubmitQuesNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcc_ExamPaperStuBatchRela
{
public virtual bool UpdRelaTabDate(string strIdPaperStuBatch, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v考卷与学生批次关系(vcc_ExamPaperStuBatchRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcc_ExamPaperStuBatchRelaBL
{
public static RelatedActions_vcc_ExamPaperStuBatchRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcc_ExamPaperStuBatchRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcc_ExamPaperStuBatchRelaDA vcc_ExamPaperStuBatchRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcc_ExamPaperStuBatchRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcc_ExamPaperStuBatchRelaBL()
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
if (string.IsNullOrEmpty(clsvcc_ExamPaperStuBatchRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_ExamPaperStuBatchRelaEN._ConnectString);
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
public static DataTable GetDataTable_vcc_ExamPaperStuBatchRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcc_ExamPaperStuBatchRelaDA.GetDataTable_vcc_ExamPaperStuBatchRela(strWhereCond);
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
objDT = vcc_ExamPaperStuBatchRelaDA.GetDataTable(strWhereCond);
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
objDT = vcc_ExamPaperStuBatchRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcc_ExamPaperStuBatchRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcc_ExamPaperStuBatchRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcc_ExamPaperStuBatchRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vcc_ExamPaperStuBatchRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcc_ExamPaperStuBatchRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcc_ExamPaperStuBatchRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdPaperStuBatchLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvcc_ExamPaperStuBatchRelaEN> GetObjLstByIdPaperStuBatchLst(List<string> arrIdPaperStuBatchLst)
{
List<clsvcc_ExamPaperStuBatchRelaEN> arrObjLst = new List<clsvcc_ExamPaperStuBatchRelaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdPaperStuBatchLst, true);
 string strWhereCond = string.Format("IdPaperStuBatch in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN = new clsvcc_ExamPaperStuBatchRelaEN();
try
{
objvcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = objRow[convcc_ExamPaperStuBatchRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objvcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = objRow[convcc_ExamPaperStuBatchRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_ExamPaperStuBatchRelaEN.CourseId = objRow[convcc_ExamPaperStuBatchRela.CourseId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CourseId].ToString().Trim(); //课程Id
objvcc_ExamPaperStuBatchRelaEN.CourseName = objRow[convcc_ExamPaperStuBatchRela.CourseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CourseName].ToString().Trim(); //课程名称
objvcc_ExamPaperStuBatchRelaEN.ExamPaperName = objRow[convcc_ExamPaperStuBatchRela.ExamPaperName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_ExamPaperStuBatchRelaEN.PaperIndex = objRow[convcc_ExamPaperStuBatchRela.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.PaperIndex].ToString().Trim()); //试卷序号
objvcc_ExamPaperStuBatchRelaEN.ExamPaperTypeId = objRow[convcc_ExamPaperStuBatchRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_ExamPaperStuBatchRelaEN.ExamPaperTypeName = objRow[convcc_ExamPaperStuBatchRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_ExamPaperStuBatchRelaEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsShow].ToString().Trim()); //是否启用
objvcc_ExamPaperStuBatchRelaEN.TotalScore = Double.Parse(objRow[convcc_ExamPaperStuBatchRela.TotalScore].ToString().Trim()); //总得分
objvcc_ExamPaperStuBatchRelaEN.ViewCount = objRow[convcc_ExamPaperStuBatchRela.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.ViewCount].ToString().Trim()); //浏览量
objvcc_ExamPaperStuBatchRelaEN.DoneNumber = objRow[convcc_ExamPaperStuBatchRela.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.DoneNumber].ToString().Trim()); //已做人数
objvcc_ExamPaperStuBatchRelaEN.PaperTime = objRow[convcc_ExamPaperStuBatchRela.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.PaperTime].ToString().Trim()); //考试时间（分钟）
objvcc_ExamPaperStuBatchRelaEN.PaperDispModeName = objRow[convcc_ExamPaperStuBatchRela.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.PaperDispModeName].ToString().Trim(); //试卷显示模式名称
objvcc_ExamPaperStuBatchRelaEN.ExamCreateTime = objRow[convcc_ExamPaperStuBatchRela.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_ExamPaperStuBatchRelaEN.UserName = objRow[convcc_ExamPaperStuBatchRela.UserName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.UserName].ToString().Trim(); //用户名
objvcc_ExamPaperStuBatchRelaEN.CourseChapterId = objRow[convcc_ExamPaperStuBatchRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_ExamPaperStuBatchRelaEN.CourseChapterName = objRow[convcc_ExamPaperStuBatchRela.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_ExamPaperStuBatchRelaEN.ChapterId = objRow[convcc_ExamPaperStuBatchRela.ChapterId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ChapterId].ToString().Trim(); //章Id
objvcc_ExamPaperStuBatchRelaEN.SectionId = objRow[convcc_ExamPaperStuBatchRela.SectionId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SectionId].ToString().Trim(); //节Id
objvcc_ExamPaperStuBatchRelaEN.ChapterName = objRow[convcc_ExamPaperStuBatchRela.ChapterName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ChapterName].ToString().Trim(); //章名
objvcc_ExamPaperStuBatchRelaEN.SectionName = objRow[convcc_ExamPaperStuBatchRela.SectionName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SectionName].ToString().Trim(); //节名
objvcc_ExamPaperStuBatchRelaEN.ChapterNameSim = objRow[convcc_ExamPaperStuBatchRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_ExamPaperStuBatchRelaEN.SectionNameSim = objRow[convcc_ExamPaperStuBatchRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_ExamPaperStuBatchRelaEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_ExamPaperStuBatchRelaEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_ExamPaperStuBatchRelaEN.QuestionNum = objRow[convcc_ExamPaperStuBatchRela.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.QuestionNum].ToString().Trim()); //题目数
objvcc_ExamPaperStuBatchRelaEN.IdStudentInfo = objRow[convcc_ExamPaperStuBatchRela.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_ExamPaperStuBatchRelaEN.StuID = objRow[convcc_ExamPaperStuBatchRela.StuID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.StuID].ToString().Trim(); //学号
objvcc_ExamPaperStuBatchRelaEN.StuName = objRow[convcc_ExamPaperStuBatchRela.StuName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.StuName].ToString().Trim(); //姓名
objvcc_ExamPaperStuBatchRelaEN.SexDesc = objRow[convcc_ExamPaperStuBatchRela.SexDesc] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SexDesc].ToString().Trim(); //性别名称
objvcc_ExamPaperStuBatchRelaEN.IdXzCollege = objRow[convcc_ExamPaperStuBatchRela.IdXzCollege] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_ExamPaperStuBatchRelaEN.CollegeName = objRow[convcc_ExamPaperStuBatchRela.CollegeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CollegeName].ToString().Trim(); //学院名称
objvcc_ExamPaperStuBatchRelaEN.CollegeNameA = objRow[convcc_ExamPaperStuBatchRela.CollegeNameA] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_ExamPaperStuBatchRelaEN.IdXzMajor = objRow[convcc_ExamPaperStuBatchRela.IdXzMajor] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_ExamPaperStuBatchRelaEN.MajorID = objRow[convcc_ExamPaperStuBatchRela.MajorID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MajorID].ToString().Trim(); //专业ID
objvcc_ExamPaperStuBatchRelaEN.MajorName = objRow[convcc_ExamPaperStuBatchRela.MajorName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MajorName].ToString().Trim(); //专业名称
objvcc_ExamPaperStuBatchRelaEN.IdGradeBase = objRow[convcc_ExamPaperStuBatchRela.IdGradeBase] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_ExamPaperStuBatchRelaEN.GradeBaseName = objRow[convcc_ExamPaperStuBatchRela.GradeBaseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.GradeBaseName].ToString().Trim(); //年级名称
objvcc_ExamPaperStuBatchRelaEN.BatchTime = objRow[convcc_ExamPaperStuBatchRela.BatchTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.BatchTime].ToString().Trim(); //批次
objvcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = objRow[convcc_ExamPaperStuBatchRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_ExamPaperStuBatchRelaEN.CurrEduClsId = objRow[convcc_ExamPaperStuBatchRela.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_ExamPaperStuBatchRelaEN.EduClsName = objRow[convcc_ExamPaperStuBatchRela.EduClsName].ToString().Trim(); //教学班名
objvcc_ExamPaperStuBatchRelaEN.Scores = objRow[convcc_ExamPaperStuBatchRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperStuBatchRela.Scores].ToString().Trim()); //分值
objvcc_ExamPaperStuBatchRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsSave].ToString().Trim()); //是否保存
objvcc_ExamPaperStuBatchRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsSubmit].ToString().Trim()); //是否提交
objvcc_ExamPaperStuBatchRelaEN.RealFinishDate = objRow[convcc_ExamPaperStuBatchRela.RealFinishDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_ExamPaperStuBatchRelaEN.OperateTime = objRow[convcc_ExamPaperStuBatchRela.OperateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.OperateTime].ToString().Trim(); //操作时间
objvcc_ExamPaperStuBatchRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsMarking].ToString().Trim()); //是否批阅
objvcc_ExamPaperStuBatchRelaEN.MarkerId = objRow[convcc_ExamPaperStuBatchRela.MarkerId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MarkerId].ToString().Trim(); //打分者
objvcc_ExamPaperStuBatchRelaEN.MarkDate = objRow[convcc_ExamPaperStuBatchRela.MarkDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MarkDate].ToString().Trim(); //打分日期
objvcc_ExamPaperStuBatchRelaEN.AnswerIP = objRow[convcc_ExamPaperStuBatchRela.AnswerIP] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.AnswerIP].ToString().Trim(); //回答IP
objvcc_ExamPaperStuBatchRelaEN.AnswerDate = objRow[convcc_ExamPaperStuBatchRela.AnswerDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.AnswerDate].ToString().Trim(); //回答日期
objvcc_ExamPaperStuBatchRelaEN.AnswerTime = objRow[convcc_ExamPaperStuBatchRela.AnswerTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.AnswerTime].ToString().Trim(); //回答时间
objvcc_ExamPaperStuBatchRelaEN.TotalGetScore = Double.Parse(objRow[convcc_ExamPaperStuBatchRela.TotalGetScore].ToString().Trim()); //考生获取总分
objvcc_ExamPaperStuBatchRelaEN.UpdDate = objRow[convcc_ExamPaperStuBatchRela.UpdDate].ToString().Trim(); //修改日期
objvcc_ExamPaperStuBatchRelaEN.UpdUserId = objRow[convcc_ExamPaperStuBatchRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExamPaperStuBatchRelaEN.Memo = objRow[convcc_ExamPaperStuBatchRela.Memo] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.Memo].ToString().Trim(); //备注
objvcc_ExamPaperStuBatchRelaEN.NoSubmitQuesNum = objRow[convcc_ExamPaperStuBatchRela.NoSubmitQuesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.NoSubmitQuesNum].ToString().Trim()); //未提交题数
objvcc_ExamPaperStuBatchRelaEN.SubmitQuesNum = objRow[convcc_ExamPaperStuBatchRela.SubmitQuesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.SubmitQuesNum].ToString().Trim()); //提交题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_ExamPaperStuBatchRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdPaperStuBatchLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcc_ExamPaperStuBatchRelaEN> GetObjLstByIdPaperStuBatchLstCache(List<string> arrIdPaperStuBatchLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvcc_ExamPaperStuBatchRelaEN._CurrTabName, strIdCurrEduCls);
List<clsvcc_ExamPaperStuBatchRelaEN> arrvcc_ExamPaperStuBatchRelaObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvcc_ExamPaperStuBatchRelaEN> arrvcc_ExamPaperStuBatchRelaObjLst_Sel =
arrvcc_ExamPaperStuBatchRelaObjLstCache
.Where(x => arrIdPaperStuBatchLst.Contains(x.IdPaperStuBatch));
return arrvcc_ExamPaperStuBatchRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_ExamPaperStuBatchRelaEN> GetObjLst(string strWhereCond)
{
List<clsvcc_ExamPaperStuBatchRelaEN> arrObjLst = new List<clsvcc_ExamPaperStuBatchRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN = new clsvcc_ExamPaperStuBatchRelaEN();
try
{
objvcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = objRow[convcc_ExamPaperStuBatchRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objvcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = objRow[convcc_ExamPaperStuBatchRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_ExamPaperStuBatchRelaEN.CourseId = objRow[convcc_ExamPaperStuBatchRela.CourseId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CourseId].ToString().Trim(); //课程Id
objvcc_ExamPaperStuBatchRelaEN.CourseName = objRow[convcc_ExamPaperStuBatchRela.CourseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CourseName].ToString().Trim(); //课程名称
objvcc_ExamPaperStuBatchRelaEN.ExamPaperName = objRow[convcc_ExamPaperStuBatchRela.ExamPaperName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_ExamPaperStuBatchRelaEN.PaperIndex = objRow[convcc_ExamPaperStuBatchRela.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.PaperIndex].ToString().Trim()); //试卷序号
objvcc_ExamPaperStuBatchRelaEN.ExamPaperTypeId = objRow[convcc_ExamPaperStuBatchRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_ExamPaperStuBatchRelaEN.ExamPaperTypeName = objRow[convcc_ExamPaperStuBatchRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_ExamPaperStuBatchRelaEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsShow].ToString().Trim()); //是否启用
objvcc_ExamPaperStuBatchRelaEN.TotalScore = Double.Parse(objRow[convcc_ExamPaperStuBatchRela.TotalScore].ToString().Trim()); //总得分
objvcc_ExamPaperStuBatchRelaEN.ViewCount = objRow[convcc_ExamPaperStuBatchRela.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.ViewCount].ToString().Trim()); //浏览量
objvcc_ExamPaperStuBatchRelaEN.DoneNumber = objRow[convcc_ExamPaperStuBatchRela.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.DoneNumber].ToString().Trim()); //已做人数
objvcc_ExamPaperStuBatchRelaEN.PaperTime = objRow[convcc_ExamPaperStuBatchRela.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.PaperTime].ToString().Trim()); //考试时间（分钟）
objvcc_ExamPaperStuBatchRelaEN.PaperDispModeName = objRow[convcc_ExamPaperStuBatchRela.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.PaperDispModeName].ToString().Trim(); //试卷显示模式名称
objvcc_ExamPaperStuBatchRelaEN.ExamCreateTime = objRow[convcc_ExamPaperStuBatchRela.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_ExamPaperStuBatchRelaEN.UserName = objRow[convcc_ExamPaperStuBatchRela.UserName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.UserName].ToString().Trim(); //用户名
objvcc_ExamPaperStuBatchRelaEN.CourseChapterId = objRow[convcc_ExamPaperStuBatchRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_ExamPaperStuBatchRelaEN.CourseChapterName = objRow[convcc_ExamPaperStuBatchRela.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_ExamPaperStuBatchRelaEN.ChapterId = objRow[convcc_ExamPaperStuBatchRela.ChapterId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ChapterId].ToString().Trim(); //章Id
objvcc_ExamPaperStuBatchRelaEN.SectionId = objRow[convcc_ExamPaperStuBatchRela.SectionId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SectionId].ToString().Trim(); //节Id
objvcc_ExamPaperStuBatchRelaEN.ChapterName = objRow[convcc_ExamPaperStuBatchRela.ChapterName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ChapterName].ToString().Trim(); //章名
objvcc_ExamPaperStuBatchRelaEN.SectionName = objRow[convcc_ExamPaperStuBatchRela.SectionName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SectionName].ToString().Trim(); //节名
objvcc_ExamPaperStuBatchRelaEN.ChapterNameSim = objRow[convcc_ExamPaperStuBatchRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_ExamPaperStuBatchRelaEN.SectionNameSim = objRow[convcc_ExamPaperStuBatchRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_ExamPaperStuBatchRelaEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_ExamPaperStuBatchRelaEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_ExamPaperStuBatchRelaEN.QuestionNum = objRow[convcc_ExamPaperStuBatchRela.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.QuestionNum].ToString().Trim()); //题目数
objvcc_ExamPaperStuBatchRelaEN.IdStudentInfo = objRow[convcc_ExamPaperStuBatchRela.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_ExamPaperStuBatchRelaEN.StuID = objRow[convcc_ExamPaperStuBatchRela.StuID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.StuID].ToString().Trim(); //学号
objvcc_ExamPaperStuBatchRelaEN.StuName = objRow[convcc_ExamPaperStuBatchRela.StuName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.StuName].ToString().Trim(); //姓名
objvcc_ExamPaperStuBatchRelaEN.SexDesc = objRow[convcc_ExamPaperStuBatchRela.SexDesc] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SexDesc].ToString().Trim(); //性别名称
objvcc_ExamPaperStuBatchRelaEN.IdXzCollege = objRow[convcc_ExamPaperStuBatchRela.IdXzCollege] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_ExamPaperStuBatchRelaEN.CollegeName = objRow[convcc_ExamPaperStuBatchRela.CollegeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CollegeName].ToString().Trim(); //学院名称
objvcc_ExamPaperStuBatchRelaEN.CollegeNameA = objRow[convcc_ExamPaperStuBatchRela.CollegeNameA] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_ExamPaperStuBatchRelaEN.IdXzMajor = objRow[convcc_ExamPaperStuBatchRela.IdXzMajor] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_ExamPaperStuBatchRelaEN.MajorID = objRow[convcc_ExamPaperStuBatchRela.MajorID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MajorID].ToString().Trim(); //专业ID
objvcc_ExamPaperStuBatchRelaEN.MajorName = objRow[convcc_ExamPaperStuBatchRela.MajorName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MajorName].ToString().Trim(); //专业名称
objvcc_ExamPaperStuBatchRelaEN.IdGradeBase = objRow[convcc_ExamPaperStuBatchRela.IdGradeBase] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_ExamPaperStuBatchRelaEN.GradeBaseName = objRow[convcc_ExamPaperStuBatchRela.GradeBaseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.GradeBaseName].ToString().Trim(); //年级名称
objvcc_ExamPaperStuBatchRelaEN.BatchTime = objRow[convcc_ExamPaperStuBatchRela.BatchTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.BatchTime].ToString().Trim(); //批次
objvcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = objRow[convcc_ExamPaperStuBatchRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_ExamPaperStuBatchRelaEN.CurrEduClsId = objRow[convcc_ExamPaperStuBatchRela.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_ExamPaperStuBatchRelaEN.EduClsName = objRow[convcc_ExamPaperStuBatchRela.EduClsName].ToString().Trim(); //教学班名
objvcc_ExamPaperStuBatchRelaEN.Scores = objRow[convcc_ExamPaperStuBatchRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperStuBatchRela.Scores].ToString().Trim()); //分值
objvcc_ExamPaperStuBatchRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsSave].ToString().Trim()); //是否保存
objvcc_ExamPaperStuBatchRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsSubmit].ToString().Trim()); //是否提交
objvcc_ExamPaperStuBatchRelaEN.RealFinishDate = objRow[convcc_ExamPaperStuBatchRela.RealFinishDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_ExamPaperStuBatchRelaEN.OperateTime = objRow[convcc_ExamPaperStuBatchRela.OperateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.OperateTime].ToString().Trim(); //操作时间
objvcc_ExamPaperStuBatchRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsMarking].ToString().Trim()); //是否批阅
objvcc_ExamPaperStuBatchRelaEN.MarkerId = objRow[convcc_ExamPaperStuBatchRela.MarkerId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MarkerId].ToString().Trim(); //打分者
objvcc_ExamPaperStuBatchRelaEN.MarkDate = objRow[convcc_ExamPaperStuBatchRela.MarkDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MarkDate].ToString().Trim(); //打分日期
objvcc_ExamPaperStuBatchRelaEN.AnswerIP = objRow[convcc_ExamPaperStuBatchRela.AnswerIP] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.AnswerIP].ToString().Trim(); //回答IP
objvcc_ExamPaperStuBatchRelaEN.AnswerDate = objRow[convcc_ExamPaperStuBatchRela.AnswerDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.AnswerDate].ToString().Trim(); //回答日期
objvcc_ExamPaperStuBatchRelaEN.AnswerTime = objRow[convcc_ExamPaperStuBatchRela.AnswerTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.AnswerTime].ToString().Trim(); //回答时间
objvcc_ExamPaperStuBatchRelaEN.TotalGetScore = Double.Parse(objRow[convcc_ExamPaperStuBatchRela.TotalGetScore].ToString().Trim()); //考生获取总分
objvcc_ExamPaperStuBatchRelaEN.UpdDate = objRow[convcc_ExamPaperStuBatchRela.UpdDate].ToString().Trim(); //修改日期
objvcc_ExamPaperStuBatchRelaEN.UpdUserId = objRow[convcc_ExamPaperStuBatchRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExamPaperStuBatchRelaEN.Memo = objRow[convcc_ExamPaperStuBatchRela.Memo] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.Memo].ToString().Trim(); //备注
objvcc_ExamPaperStuBatchRelaEN.NoSubmitQuesNum = objRow[convcc_ExamPaperStuBatchRela.NoSubmitQuesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.NoSubmitQuesNum].ToString().Trim()); //未提交题数
objvcc_ExamPaperStuBatchRelaEN.SubmitQuesNum = objRow[convcc_ExamPaperStuBatchRela.SubmitQuesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.SubmitQuesNum].ToString().Trim()); //提交题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_ExamPaperStuBatchRelaEN);
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
public static List<clsvcc_ExamPaperStuBatchRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcc_ExamPaperStuBatchRelaEN> arrObjLst = new List<clsvcc_ExamPaperStuBatchRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN = new clsvcc_ExamPaperStuBatchRelaEN();
try
{
objvcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = objRow[convcc_ExamPaperStuBatchRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objvcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = objRow[convcc_ExamPaperStuBatchRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_ExamPaperStuBatchRelaEN.CourseId = objRow[convcc_ExamPaperStuBatchRela.CourseId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CourseId].ToString().Trim(); //课程Id
objvcc_ExamPaperStuBatchRelaEN.CourseName = objRow[convcc_ExamPaperStuBatchRela.CourseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CourseName].ToString().Trim(); //课程名称
objvcc_ExamPaperStuBatchRelaEN.ExamPaperName = objRow[convcc_ExamPaperStuBatchRela.ExamPaperName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_ExamPaperStuBatchRelaEN.PaperIndex = objRow[convcc_ExamPaperStuBatchRela.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.PaperIndex].ToString().Trim()); //试卷序号
objvcc_ExamPaperStuBatchRelaEN.ExamPaperTypeId = objRow[convcc_ExamPaperStuBatchRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_ExamPaperStuBatchRelaEN.ExamPaperTypeName = objRow[convcc_ExamPaperStuBatchRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_ExamPaperStuBatchRelaEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsShow].ToString().Trim()); //是否启用
objvcc_ExamPaperStuBatchRelaEN.TotalScore = Double.Parse(objRow[convcc_ExamPaperStuBatchRela.TotalScore].ToString().Trim()); //总得分
objvcc_ExamPaperStuBatchRelaEN.ViewCount = objRow[convcc_ExamPaperStuBatchRela.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.ViewCount].ToString().Trim()); //浏览量
objvcc_ExamPaperStuBatchRelaEN.DoneNumber = objRow[convcc_ExamPaperStuBatchRela.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.DoneNumber].ToString().Trim()); //已做人数
objvcc_ExamPaperStuBatchRelaEN.PaperTime = objRow[convcc_ExamPaperStuBatchRela.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.PaperTime].ToString().Trim()); //考试时间（分钟）
objvcc_ExamPaperStuBatchRelaEN.PaperDispModeName = objRow[convcc_ExamPaperStuBatchRela.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.PaperDispModeName].ToString().Trim(); //试卷显示模式名称
objvcc_ExamPaperStuBatchRelaEN.ExamCreateTime = objRow[convcc_ExamPaperStuBatchRela.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_ExamPaperStuBatchRelaEN.UserName = objRow[convcc_ExamPaperStuBatchRela.UserName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.UserName].ToString().Trim(); //用户名
objvcc_ExamPaperStuBatchRelaEN.CourseChapterId = objRow[convcc_ExamPaperStuBatchRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_ExamPaperStuBatchRelaEN.CourseChapterName = objRow[convcc_ExamPaperStuBatchRela.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_ExamPaperStuBatchRelaEN.ChapterId = objRow[convcc_ExamPaperStuBatchRela.ChapterId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ChapterId].ToString().Trim(); //章Id
objvcc_ExamPaperStuBatchRelaEN.SectionId = objRow[convcc_ExamPaperStuBatchRela.SectionId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SectionId].ToString().Trim(); //节Id
objvcc_ExamPaperStuBatchRelaEN.ChapterName = objRow[convcc_ExamPaperStuBatchRela.ChapterName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ChapterName].ToString().Trim(); //章名
objvcc_ExamPaperStuBatchRelaEN.SectionName = objRow[convcc_ExamPaperStuBatchRela.SectionName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SectionName].ToString().Trim(); //节名
objvcc_ExamPaperStuBatchRelaEN.ChapterNameSim = objRow[convcc_ExamPaperStuBatchRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_ExamPaperStuBatchRelaEN.SectionNameSim = objRow[convcc_ExamPaperStuBatchRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_ExamPaperStuBatchRelaEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_ExamPaperStuBatchRelaEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_ExamPaperStuBatchRelaEN.QuestionNum = objRow[convcc_ExamPaperStuBatchRela.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.QuestionNum].ToString().Trim()); //题目数
objvcc_ExamPaperStuBatchRelaEN.IdStudentInfo = objRow[convcc_ExamPaperStuBatchRela.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_ExamPaperStuBatchRelaEN.StuID = objRow[convcc_ExamPaperStuBatchRela.StuID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.StuID].ToString().Trim(); //学号
objvcc_ExamPaperStuBatchRelaEN.StuName = objRow[convcc_ExamPaperStuBatchRela.StuName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.StuName].ToString().Trim(); //姓名
objvcc_ExamPaperStuBatchRelaEN.SexDesc = objRow[convcc_ExamPaperStuBatchRela.SexDesc] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SexDesc].ToString().Trim(); //性别名称
objvcc_ExamPaperStuBatchRelaEN.IdXzCollege = objRow[convcc_ExamPaperStuBatchRela.IdXzCollege] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_ExamPaperStuBatchRelaEN.CollegeName = objRow[convcc_ExamPaperStuBatchRela.CollegeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CollegeName].ToString().Trim(); //学院名称
objvcc_ExamPaperStuBatchRelaEN.CollegeNameA = objRow[convcc_ExamPaperStuBatchRela.CollegeNameA] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_ExamPaperStuBatchRelaEN.IdXzMajor = objRow[convcc_ExamPaperStuBatchRela.IdXzMajor] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_ExamPaperStuBatchRelaEN.MajorID = objRow[convcc_ExamPaperStuBatchRela.MajorID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MajorID].ToString().Trim(); //专业ID
objvcc_ExamPaperStuBatchRelaEN.MajorName = objRow[convcc_ExamPaperStuBatchRela.MajorName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MajorName].ToString().Trim(); //专业名称
objvcc_ExamPaperStuBatchRelaEN.IdGradeBase = objRow[convcc_ExamPaperStuBatchRela.IdGradeBase] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_ExamPaperStuBatchRelaEN.GradeBaseName = objRow[convcc_ExamPaperStuBatchRela.GradeBaseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.GradeBaseName].ToString().Trim(); //年级名称
objvcc_ExamPaperStuBatchRelaEN.BatchTime = objRow[convcc_ExamPaperStuBatchRela.BatchTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.BatchTime].ToString().Trim(); //批次
objvcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = objRow[convcc_ExamPaperStuBatchRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_ExamPaperStuBatchRelaEN.CurrEduClsId = objRow[convcc_ExamPaperStuBatchRela.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_ExamPaperStuBatchRelaEN.EduClsName = objRow[convcc_ExamPaperStuBatchRela.EduClsName].ToString().Trim(); //教学班名
objvcc_ExamPaperStuBatchRelaEN.Scores = objRow[convcc_ExamPaperStuBatchRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperStuBatchRela.Scores].ToString().Trim()); //分值
objvcc_ExamPaperStuBatchRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsSave].ToString().Trim()); //是否保存
objvcc_ExamPaperStuBatchRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsSubmit].ToString().Trim()); //是否提交
objvcc_ExamPaperStuBatchRelaEN.RealFinishDate = objRow[convcc_ExamPaperStuBatchRela.RealFinishDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_ExamPaperStuBatchRelaEN.OperateTime = objRow[convcc_ExamPaperStuBatchRela.OperateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.OperateTime].ToString().Trim(); //操作时间
objvcc_ExamPaperStuBatchRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsMarking].ToString().Trim()); //是否批阅
objvcc_ExamPaperStuBatchRelaEN.MarkerId = objRow[convcc_ExamPaperStuBatchRela.MarkerId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MarkerId].ToString().Trim(); //打分者
objvcc_ExamPaperStuBatchRelaEN.MarkDate = objRow[convcc_ExamPaperStuBatchRela.MarkDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MarkDate].ToString().Trim(); //打分日期
objvcc_ExamPaperStuBatchRelaEN.AnswerIP = objRow[convcc_ExamPaperStuBatchRela.AnswerIP] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.AnswerIP].ToString().Trim(); //回答IP
objvcc_ExamPaperStuBatchRelaEN.AnswerDate = objRow[convcc_ExamPaperStuBatchRela.AnswerDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.AnswerDate].ToString().Trim(); //回答日期
objvcc_ExamPaperStuBatchRelaEN.AnswerTime = objRow[convcc_ExamPaperStuBatchRela.AnswerTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.AnswerTime].ToString().Trim(); //回答时间
objvcc_ExamPaperStuBatchRelaEN.TotalGetScore = Double.Parse(objRow[convcc_ExamPaperStuBatchRela.TotalGetScore].ToString().Trim()); //考生获取总分
objvcc_ExamPaperStuBatchRelaEN.UpdDate = objRow[convcc_ExamPaperStuBatchRela.UpdDate].ToString().Trim(); //修改日期
objvcc_ExamPaperStuBatchRelaEN.UpdUserId = objRow[convcc_ExamPaperStuBatchRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExamPaperStuBatchRelaEN.Memo = objRow[convcc_ExamPaperStuBatchRela.Memo] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.Memo].ToString().Trim(); //备注
objvcc_ExamPaperStuBatchRelaEN.NoSubmitQuesNum = objRow[convcc_ExamPaperStuBatchRela.NoSubmitQuesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.NoSubmitQuesNum].ToString().Trim()); //未提交题数
objvcc_ExamPaperStuBatchRelaEN.SubmitQuesNum = objRow[convcc_ExamPaperStuBatchRela.SubmitQuesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.SubmitQuesNum].ToString().Trim()); //提交题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_ExamPaperStuBatchRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcc_ExamPaperStuBatchRelaEN> GetSubObjLstCache(clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaCond)
{
 string strIdCurrEduCls = objvcc_ExamPaperStuBatchRelaCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvcc_ExamPaperStuBatchRelaBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvcc_ExamPaperStuBatchRelaEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvcc_ExamPaperStuBatchRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_ExamPaperStuBatchRela.AttributeName)
{
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(strFldName) == false) continue;
if (objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_ExamPaperStuBatchRelaCond[strFldName].ToString());
}
else
{
if (objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_ExamPaperStuBatchRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_ExamPaperStuBatchRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_ExamPaperStuBatchRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_ExamPaperStuBatchRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_ExamPaperStuBatchRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_ExamPaperStuBatchRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_ExamPaperStuBatchRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_ExamPaperStuBatchRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_ExamPaperStuBatchRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_ExamPaperStuBatchRelaCond[strFldName]));
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
public static List<clsvcc_ExamPaperStuBatchRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcc_ExamPaperStuBatchRelaEN> arrObjLst = new List<clsvcc_ExamPaperStuBatchRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN = new clsvcc_ExamPaperStuBatchRelaEN();
try
{
objvcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = objRow[convcc_ExamPaperStuBatchRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objvcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = objRow[convcc_ExamPaperStuBatchRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_ExamPaperStuBatchRelaEN.CourseId = objRow[convcc_ExamPaperStuBatchRela.CourseId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CourseId].ToString().Trim(); //课程Id
objvcc_ExamPaperStuBatchRelaEN.CourseName = objRow[convcc_ExamPaperStuBatchRela.CourseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CourseName].ToString().Trim(); //课程名称
objvcc_ExamPaperStuBatchRelaEN.ExamPaperName = objRow[convcc_ExamPaperStuBatchRela.ExamPaperName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_ExamPaperStuBatchRelaEN.PaperIndex = objRow[convcc_ExamPaperStuBatchRela.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.PaperIndex].ToString().Trim()); //试卷序号
objvcc_ExamPaperStuBatchRelaEN.ExamPaperTypeId = objRow[convcc_ExamPaperStuBatchRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_ExamPaperStuBatchRelaEN.ExamPaperTypeName = objRow[convcc_ExamPaperStuBatchRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_ExamPaperStuBatchRelaEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsShow].ToString().Trim()); //是否启用
objvcc_ExamPaperStuBatchRelaEN.TotalScore = Double.Parse(objRow[convcc_ExamPaperStuBatchRela.TotalScore].ToString().Trim()); //总得分
objvcc_ExamPaperStuBatchRelaEN.ViewCount = objRow[convcc_ExamPaperStuBatchRela.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.ViewCount].ToString().Trim()); //浏览量
objvcc_ExamPaperStuBatchRelaEN.DoneNumber = objRow[convcc_ExamPaperStuBatchRela.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.DoneNumber].ToString().Trim()); //已做人数
objvcc_ExamPaperStuBatchRelaEN.PaperTime = objRow[convcc_ExamPaperStuBatchRela.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.PaperTime].ToString().Trim()); //考试时间（分钟）
objvcc_ExamPaperStuBatchRelaEN.PaperDispModeName = objRow[convcc_ExamPaperStuBatchRela.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.PaperDispModeName].ToString().Trim(); //试卷显示模式名称
objvcc_ExamPaperStuBatchRelaEN.ExamCreateTime = objRow[convcc_ExamPaperStuBatchRela.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_ExamPaperStuBatchRelaEN.UserName = objRow[convcc_ExamPaperStuBatchRela.UserName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.UserName].ToString().Trim(); //用户名
objvcc_ExamPaperStuBatchRelaEN.CourseChapterId = objRow[convcc_ExamPaperStuBatchRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_ExamPaperStuBatchRelaEN.CourseChapterName = objRow[convcc_ExamPaperStuBatchRela.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_ExamPaperStuBatchRelaEN.ChapterId = objRow[convcc_ExamPaperStuBatchRela.ChapterId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ChapterId].ToString().Trim(); //章Id
objvcc_ExamPaperStuBatchRelaEN.SectionId = objRow[convcc_ExamPaperStuBatchRela.SectionId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SectionId].ToString().Trim(); //节Id
objvcc_ExamPaperStuBatchRelaEN.ChapterName = objRow[convcc_ExamPaperStuBatchRela.ChapterName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ChapterName].ToString().Trim(); //章名
objvcc_ExamPaperStuBatchRelaEN.SectionName = objRow[convcc_ExamPaperStuBatchRela.SectionName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SectionName].ToString().Trim(); //节名
objvcc_ExamPaperStuBatchRelaEN.ChapterNameSim = objRow[convcc_ExamPaperStuBatchRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_ExamPaperStuBatchRelaEN.SectionNameSim = objRow[convcc_ExamPaperStuBatchRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_ExamPaperStuBatchRelaEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_ExamPaperStuBatchRelaEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_ExamPaperStuBatchRelaEN.QuestionNum = objRow[convcc_ExamPaperStuBatchRela.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.QuestionNum].ToString().Trim()); //题目数
objvcc_ExamPaperStuBatchRelaEN.IdStudentInfo = objRow[convcc_ExamPaperStuBatchRela.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_ExamPaperStuBatchRelaEN.StuID = objRow[convcc_ExamPaperStuBatchRela.StuID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.StuID].ToString().Trim(); //学号
objvcc_ExamPaperStuBatchRelaEN.StuName = objRow[convcc_ExamPaperStuBatchRela.StuName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.StuName].ToString().Trim(); //姓名
objvcc_ExamPaperStuBatchRelaEN.SexDesc = objRow[convcc_ExamPaperStuBatchRela.SexDesc] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SexDesc].ToString().Trim(); //性别名称
objvcc_ExamPaperStuBatchRelaEN.IdXzCollege = objRow[convcc_ExamPaperStuBatchRela.IdXzCollege] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_ExamPaperStuBatchRelaEN.CollegeName = objRow[convcc_ExamPaperStuBatchRela.CollegeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CollegeName].ToString().Trim(); //学院名称
objvcc_ExamPaperStuBatchRelaEN.CollegeNameA = objRow[convcc_ExamPaperStuBatchRela.CollegeNameA] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_ExamPaperStuBatchRelaEN.IdXzMajor = objRow[convcc_ExamPaperStuBatchRela.IdXzMajor] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_ExamPaperStuBatchRelaEN.MajorID = objRow[convcc_ExamPaperStuBatchRela.MajorID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MajorID].ToString().Trim(); //专业ID
objvcc_ExamPaperStuBatchRelaEN.MajorName = objRow[convcc_ExamPaperStuBatchRela.MajorName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MajorName].ToString().Trim(); //专业名称
objvcc_ExamPaperStuBatchRelaEN.IdGradeBase = objRow[convcc_ExamPaperStuBatchRela.IdGradeBase] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_ExamPaperStuBatchRelaEN.GradeBaseName = objRow[convcc_ExamPaperStuBatchRela.GradeBaseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.GradeBaseName].ToString().Trim(); //年级名称
objvcc_ExamPaperStuBatchRelaEN.BatchTime = objRow[convcc_ExamPaperStuBatchRela.BatchTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.BatchTime].ToString().Trim(); //批次
objvcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = objRow[convcc_ExamPaperStuBatchRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_ExamPaperStuBatchRelaEN.CurrEduClsId = objRow[convcc_ExamPaperStuBatchRela.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_ExamPaperStuBatchRelaEN.EduClsName = objRow[convcc_ExamPaperStuBatchRela.EduClsName].ToString().Trim(); //教学班名
objvcc_ExamPaperStuBatchRelaEN.Scores = objRow[convcc_ExamPaperStuBatchRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperStuBatchRela.Scores].ToString().Trim()); //分值
objvcc_ExamPaperStuBatchRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsSave].ToString().Trim()); //是否保存
objvcc_ExamPaperStuBatchRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsSubmit].ToString().Trim()); //是否提交
objvcc_ExamPaperStuBatchRelaEN.RealFinishDate = objRow[convcc_ExamPaperStuBatchRela.RealFinishDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_ExamPaperStuBatchRelaEN.OperateTime = objRow[convcc_ExamPaperStuBatchRela.OperateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.OperateTime].ToString().Trim(); //操作时间
objvcc_ExamPaperStuBatchRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsMarking].ToString().Trim()); //是否批阅
objvcc_ExamPaperStuBatchRelaEN.MarkerId = objRow[convcc_ExamPaperStuBatchRela.MarkerId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MarkerId].ToString().Trim(); //打分者
objvcc_ExamPaperStuBatchRelaEN.MarkDate = objRow[convcc_ExamPaperStuBatchRela.MarkDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MarkDate].ToString().Trim(); //打分日期
objvcc_ExamPaperStuBatchRelaEN.AnswerIP = objRow[convcc_ExamPaperStuBatchRela.AnswerIP] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.AnswerIP].ToString().Trim(); //回答IP
objvcc_ExamPaperStuBatchRelaEN.AnswerDate = objRow[convcc_ExamPaperStuBatchRela.AnswerDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.AnswerDate].ToString().Trim(); //回答日期
objvcc_ExamPaperStuBatchRelaEN.AnswerTime = objRow[convcc_ExamPaperStuBatchRela.AnswerTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.AnswerTime].ToString().Trim(); //回答时间
objvcc_ExamPaperStuBatchRelaEN.TotalGetScore = Double.Parse(objRow[convcc_ExamPaperStuBatchRela.TotalGetScore].ToString().Trim()); //考生获取总分
objvcc_ExamPaperStuBatchRelaEN.UpdDate = objRow[convcc_ExamPaperStuBatchRela.UpdDate].ToString().Trim(); //修改日期
objvcc_ExamPaperStuBatchRelaEN.UpdUserId = objRow[convcc_ExamPaperStuBatchRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExamPaperStuBatchRelaEN.Memo = objRow[convcc_ExamPaperStuBatchRela.Memo] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.Memo].ToString().Trim(); //备注
objvcc_ExamPaperStuBatchRelaEN.NoSubmitQuesNum = objRow[convcc_ExamPaperStuBatchRela.NoSubmitQuesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.NoSubmitQuesNum].ToString().Trim()); //未提交题数
objvcc_ExamPaperStuBatchRelaEN.SubmitQuesNum = objRow[convcc_ExamPaperStuBatchRela.SubmitQuesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.SubmitQuesNum].ToString().Trim()); //提交题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_ExamPaperStuBatchRelaEN);
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
public static List<clsvcc_ExamPaperStuBatchRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcc_ExamPaperStuBatchRelaEN> arrObjLst = new List<clsvcc_ExamPaperStuBatchRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN = new clsvcc_ExamPaperStuBatchRelaEN();
try
{
objvcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = objRow[convcc_ExamPaperStuBatchRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objvcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = objRow[convcc_ExamPaperStuBatchRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_ExamPaperStuBatchRelaEN.CourseId = objRow[convcc_ExamPaperStuBatchRela.CourseId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CourseId].ToString().Trim(); //课程Id
objvcc_ExamPaperStuBatchRelaEN.CourseName = objRow[convcc_ExamPaperStuBatchRela.CourseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CourseName].ToString().Trim(); //课程名称
objvcc_ExamPaperStuBatchRelaEN.ExamPaperName = objRow[convcc_ExamPaperStuBatchRela.ExamPaperName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_ExamPaperStuBatchRelaEN.PaperIndex = objRow[convcc_ExamPaperStuBatchRela.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.PaperIndex].ToString().Trim()); //试卷序号
objvcc_ExamPaperStuBatchRelaEN.ExamPaperTypeId = objRow[convcc_ExamPaperStuBatchRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_ExamPaperStuBatchRelaEN.ExamPaperTypeName = objRow[convcc_ExamPaperStuBatchRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_ExamPaperStuBatchRelaEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsShow].ToString().Trim()); //是否启用
objvcc_ExamPaperStuBatchRelaEN.TotalScore = Double.Parse(objRow[convcc_ExamPaperStuBatchRela.TotalScore].ToString().Trim()); //总得分
objvcc_ExamPaperStuBatchRelaEN.ViewCount = objRow[convcc_ExamPaperStuBatchRela.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.ViewCount].ToString().Trim()); //浏览量
objvcc_ExamPaperStuBatchRelaEN.DoneNumber = objRow[convcc_ExamPaperStuBatchRela.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.DoneNumber].ToString().Trim()); //已做人数
objvcc_ExamPaperStuBatchRelaEN.PaperTime = objRow[convcc_ExamPaperStuBatchRela.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.PaperTime].ToString().Trim()); //考试时间（分钟）
objvcc_ExamPaperStuBatchRelaEN.PaperDispModeName = objRow[convcc_ExamPaperStuBatchRela.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.PaperDispModeName].ToString().Trim(); //试卷显示模式名称
objvcc_ExamPaperStuBatchRelaEN.ExamCreateTime = objRow[convcc_ExamPaperStuBatchRela.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_ExamPaperStuBatchRelaEN.UserName = objRow[convcc_ExamPaperStuBatchRela.UserName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.UserName].ToString().Trim(); //用户名
objvcc_ExamPaperStuBatchRelaEN.CourseChapterId = objRow[convcc_ExamPaperStuBatchRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_ExamPaperStuBatchRelaEN.CourseChapterName = objRow[convcc_ExamPaperStuBatchRela.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_ExamPaperStuBatchRelaEN.ChapterId = objRow[convcc_ExamPaperStuBatchRela.ChapterId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ChapterId].ToString().Trim(); //章Id
objvcc_ExamPaperStuBatchRelaEN.SectionId = objRow[convcc_ExamPaperStuBatchRela.SectionId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SectionId].ToString().Trim(); //节Id
objvcc_ExamPaperStuBatchRelaEN.ChapterName = objRow[convcc_ExamPaperStuBatchRela.ChapterName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ChapterName].ToString().Trim(); //章名
objvcc_ExamPaperStuBatchRelaEN.SectionName = objRow[convcc_ExamPaperStuBatchRela.SectionName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SectionName].ToString().Trim(); //节名
objvcc_ExamPaperStuBatchRelaEN.ChapterNameSim = objRow[convcc_ExamPaperStuBatchRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_ExamPaperStuBatchRelaEN.SectionNameSim = objRow[convcc_ExamPaperStuBatchRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_ExamPaperStuBatchRelaEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_ExamPaperStuBatchRelaEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_ExamPaperStuBatchRelaEN.QuestionNum = objRow[convcc_ExamPaperStuBatchRela.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.QuestionNum].ToString().Trim()); //题目数
objvcc_ExamPaperStuBatchRelaEN.IdStudentInfo = objRow[convcc_ExamPaperStuBatchRela.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_ExamPaperStuBatchRelaEN.StuID = objRow[convcc_ExamPaperStuBatchRela.StuID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.StuID].ToString().Trim(); //学号
objvcc_ExamPaperStuBatchRelaEN.StuName = objRow[convcc_ExamPaperStuBatchRela.StuName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.StuName].ToString().Trim(); //姓名
objvcc_ExamPaperStuBatchRelaEN.SexDesc = objRow[convcc_ExamPaperStuBatchRela.SexDesc] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SexDesc].ToString().Trim(); //性别名称
objvcc_ExamPaperStuBatchRelaEN.IdXzCollege = objRow[convcc_ExamPaperStuBatchRela.IdXzCollege] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_ExamPaperStuBatchRelaEN.CollegeName = objRow[convcc_ExamPaperStuBatchRela.CollegeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CollegeName].ToString().Trim(); //学院名称
objvcc_ExamPaperStuBatchRelaEN.CollegeNameA = objRow[convcc_ExamPaperStuBatchRela.CollegeNameA] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_ExamPaperStuBatchRelaEN.IdXzMajor = objRow[convcc_ExamPaperStuBatchRela.IdXzMajor] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_ExamPaperStuBatchRelaEN.MajorID = objRow[convcc_ExamPaperStuBatchRela.MajorID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MajorID].ToString().Trim(); //专业ID
objvcc_ExamPaperStuBatchRelaEN.MajorName = objRow[convcc_ExamPaperStuBatchRela.MajorName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MajorName].ToString().Trim(); //专业名称
objvcc_ExamPaperStuBatchRelaEN.IdGradeBase = objRow[convcc_ExamPaperStuBatchRela.IdGradeBase] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_ExamPaperStuBatchRelaEN.GradeBaseName = objRow[convcc_ExamPaperStuBatchRela.GradeBaseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.GradeBaseName].ToString().Trim(); //年级名称
objvcc_ExamPaperStuBatchRelaEN.BatchTime = objRow[convcc_ExamPaperStuBatchRela.BatchTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.BatchTime].ToString().Trim(); //批次
objvcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = objRow[convcc_ExamPaperStuBatchRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_ExamPaperStuBatchRelaEN.CurrEduClsId = objRow[convcc_ExamPaperStuBatchRela.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_ExamPaperStuBatchRelaEN.EduClsName = objRow[convcc_ExamPaperStuBatchRela.EduClsName].ToString().Trim(); //教学班名
objvcc_ExamPaperStuBatchRelaEN.Scores = objRow[convcc_ExamPaperStuBatchRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperStuBatchRela.Scores].ToString().Trim()); //分值
objvcc_ExamPaperStuBatchRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsSave].ToString().Trim()); //是否保存
objvcc_ExamPaperStuBatchRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsSubmit].ToString().Trim()); //是否提交
objvcc_ExamPaperStuBatchRelaEN.RealFinishDate = objRow[convcc_ExamPaperStuBatchRela.RealFinishDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_ExamPaperStuBatchRelaEN.OperateTime = objRow[convcc_ExamPaperStuBatchRela.OperateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.OperateTime].ToString().Trim(); //操作时间
objvcc_ExamPaperStuBatchRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsMarking].ToString().Trim()); //是否批阅
objvcc_ExamPaperStuBatchRelaEN.MarkerId = objRow[convcc_ExamPaperStuBatchRela.MarkerId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MarkerId].ToString().Trim(); //打分者
objvcc_ExamPaperStuBatchRelaEN.MarkDate = objRow[convcc_ExamPaperStuBatchRela.MarkDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MarkDate].ToString().Trim(); //打分日期
objvcc_ExamPaperStuBatchRelaEN.AnswerIP = objRow[convcc_ExamPaperStuBatchRela.AnswerIP] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.AnswerIP].ToString().Trim(); //回答IP
objvcc_ExamPaperStuBatchRelaEN.AnswerDate = objRow[convcc_ExamPaperStuBatchRela.AnswerDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.AnswerDate].ToString().Trim(); //回答日期
objvcc_ExamPaperStuBatchRelaEN.AnswerTime = objRow[convcc_ExamPaperStuBatchRela.AnswerTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.AnswerTime].ToString().Trim(); //回答时间
objvcc_ExamPaperStuBatchRelaEN.TotalGetScore = Double.Parse(objRow[convcc_ExamPaperStuBatchRela.TotalGetScore].ToString().Trim()); //考生获取总分
objvcc_ExamPaperStuBatchRelaEN.UpdDate = objRow[convcc_ExamPaperStuBatchRela.UpdDate].ToString().Trim(); //修改日期
objvcc_ExamPaperStuBatchRelaEN.UpdUserId = objRow[convcc_ExamPaperStuBatchRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExamPaperStuBatchRelaEN.Memo = objRow[convcc_ExamPaperStuBatchRela.Memo] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.Memo].ToString().Trim(); //备注
objvcc_ExamPaperStuBatchRelaEN.NoSubmitQuesNum = objRow[convcc_ExamPaperStuBatchRela.NoSubmitQuesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.NoSubmitQuesNum].ToString().Trim()); //未提交题数
objvcc_ExamPaperStuBatchRelaEN.SubmitQuesNum = objRow[convcc_ExamPaperStuBatchRela.SubmitQuesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.SubmitQuesNum].ToString().Trim()); //提交题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_ExamPaperStuBatchRelaEN);
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
List<clsvcc_ExamPaperStuBatchRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcc_ExamPaperStuBatchRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_ExamPaperStuBatchRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcc_ExamPaperStuBatchRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_ExamPaperStuBatchRelaEN> arrObjLst = new List<clsvcc_ExamPaperStuBatchRelaEN>(); 
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
	clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN = new clsvcc_ExamPaperStuBatchRelaEN();
try
{
objvcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = objRow[convcc_ExamPaperStuBatchRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objvcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = objRow[convcc_ExamPaperStuBatchRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_ExamPaperStuBatchRelaEN.CourseId = objRow[convcc_ExamPaperStuBatchRela.CourseId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CourseId].ToString().Trim(); //课程Id
objvcc_ExamPaperStuBatchRelaEN.CourseName = objRow[convcc_ExamPaperStuBatchRela.CourseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CourseName].ToString().Trim(); //课程名称
objvcc_ExamPaperStuBatchRelaEN.ExamPaperName = objRow[convcc_ExamPaperStuBatchRela.ExamPaperName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_ExamPaperStuBatchRelaEN.PaperIndex = objRow[convcc_ExamPaperStuBatchRela.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.PaperIndex].ToString().Trim()); //试卷序号
objvcc_ExamPaperStuBatchRelaEN.ExamPaperTypeId = objRow[convcc_ExamPaperStuBatchRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_ExamPaperStuBatchRelaEN.ExamPaperTypeName = objRow[convcc_ExamPaperStuBatchRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_ExamPaperStuBatchRelaEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsShow].ToString().Trim()); //是否启用
objvcc_ExamPaperStuBatchRelaEN.TotalScore = Double.Parse(objRow[convcc_ExamPaperStuBatchRela.TotalScore].ToString().Trim()); //总得分
objvcc_ExamPaperStuBatchRelaEN.ViewCount = objRow[convcc_ExamPaperStuBatchRela.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.ViewCount].ToString().Trim()); //浏览量
objvcc_ExamPaperStuBatchRelaEN.DoneNumber = objRow[convcc_ExamPaperStuBatchRela.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.DoneNumber].ToString().Trim()); //已做人数
objvcc_ExamPaperStuBatchRelaEN.PaperTime = objRow[convcc_ExamPaperStuBatchRela.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.PaperTime].ToString().Trim()); //考试时间（分钟）
objvcc_ExamPaperStuBatchRelaEN.PaperDispModeName = objRow[convcc_ExamPaperStuBatchRela.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.PaperDispModeName].ToString().Trim(); //试卷显示模式名称
objvcc_ExamPaperStuBatchRelaEN.ExamCreateTime = objRow[convcc_ExamPaperStuBatchRela.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_ExamPaperStuBatchRelaEN.UserName = objRow[convcc_ExamPaperStuBatchRela.UserName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.UserName].ToString().Trim(); //用户名
objvcc_ExamPaperStuBatchRelaEN.CourseChapterId = objRow[convcc_ExamPaperStuBatchRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_ExamPaperStuBatchRelaEN.CourseChapterName = objRow[convcc_ExamPaperStuBatchRela.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_ExamPaperStuBatchRelaEN.ChapterId = objRow[convcc_ExamPaperStuBatchRela.ChapterId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ChapterId].ToString().Trim(); //章Id
objvcc_ExamPaperStuBatchRelaEN.SectionId = objRow[convcc_ExamPaperStuBatchRela.SectionId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SectionId].ToString().Trim(); //节Id
objvcc_ExamPaperStuBatchRelaEN.ChapterName = objRow[convcc_ExamPaperStuBatchRela.ChapterName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ChapterName].ToString().Trim(); //章名
objvcc_ExamPaperStuBatchRelaEN.SectionName = objRow[convcc_ExamPaperStuBatchRela.SectionName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SectionName].ToString().Trim(); //节名
objvcc_ExamPaperStuBatchRelaEN.ChapterNameSim = objRow[convcc_ExamPaperStuBatchRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_ExamPaperStuBatchRelaEN.SectionNameSim = objRow[convcc_ExamPaperStuBatchRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_ExamPaperStuBatchRelaEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_ExamPaperStuBatchRelaEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_ExamPaperStuBatchRelaEN.QuestionNum = objRow[convcc_ExamPaperStuBatchRela.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.QuestionNum].ToString().Trim()); //题目数
objvcc_ExamPaperStuBatchRelaEN.IdStudentInfo = objRow[convcc_ExamPaperStuBatchRela.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_ExamPaperStuBatchRelaEN.StuID = objRow[convcc_ExamPaperStuBatchRela.StuID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.StuID].ToString().Trim(); //学号
objvcc_ExamPaperStuBatchRelaEN.StuName = objRow[convcc_ExamPaperStuBatchRela.StuName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.StuName].ToString().Trim(); //姓名
objvcc_ExamPaperStuBatchRelaEN.SexDesc = objRow[convcc_ExamPaperStuBatchRela.SexDesc] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SexDesc].ToString().Trim(); //性别名称
objvcc_ExamPaperStuBatchRelaEN.IdXzCollege = objRow[convcc_ExamPaperStuBatchRela.IdXzCollege] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_ExamPaperStuBatchRelaEN.CollegeName = objRow[convcc_ExamPaperStuBatchRela.CollegeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CollegeName].ToString().Trim(); //学院名称
objvcc_ExamPaperStuBatchRelaEN.CollegeNameA = objRow[convcc_ExamPaperStuBatchRela.CollegeNameA] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_ExamPaperStuBatchRelaEN.IdXzMajor = objRow[convcc_ExamPaperStuBatchRela.IdXzMajor] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_ExamPaperStuBatchRelaEN.MajorID = objRow[convcc_ExamPaperStuBatchRela.MajorID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MajorID].ToString().Trim(); //专业ID
objvcc_ExamPaperStuBatchRelaEN.MajorName = objRow[convcc_ExamPaperStuBatchRela.MajorName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MajorName].ToString().Trim(); //专业名称
objvcc_ExamPaperStuBatchRelaEN.IdGradeBase = objRow[convcc_ExamPaperStuBatchRela.IdGradeBase] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_ExamPaperStuBatchRelaEN.GradeBaseName = objRow[convcc_ExamPaperStuBatchRela.GradeBaseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.GradeBaseName].ToString().Trim(); //年级名称
objvcc_ExamPaperStuBatchRelaEN.BatchTime = objRow[convcc_ExamPaperStuBatchRela.BatchTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.BatchTime].ToString().Trim(); //批次
objvcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = objRow[convcc_ExamPaperStuBatchRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_ExamPaperStuBatchRelaEN.CurrEduClsId = objRow[convcc_ExamPaperStuBatchRela.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_ExamPaperStuBatchRelaEN.EduClsName = objRow[convcc_ExamPaperStuBatchRela.EduClsName].ToString().Trim(); //教学班名
objvcc_ExamPaperStuBatchRelaEN.Scores = objRow[convcc_ExamPaperStuBatchRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperStuBatchRela.Scores].ToString().Trim()); //分值
objvcc_ExamPaperStuBatchRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsSave].ToString().Trim()); //是否保存
objvcc_ExamPaperStuBatchRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsSubmit].ToString().Trim()); //是否提交
objvcc_ExamPaperStuBatchRelaEN.RealFinishDate = objRow[convcc_ExamPaperStuBatchRela.RealFinishDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_ExamPaperStuBatchRelaEN.OperateTime = objRow[convcc_ExamPaperStuBatchRela.OperateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.OperateTime].ToString().Trim(); //操作时间
objvcc_ExamPaperStuBatchRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsMarking].ToString().Trim()); //是否批阅
objvcc_ExamPaperStuBatchRelaEN.MarkerId = objRow[convcc_ExamPaperStuBatchRela.MarkerId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MarkerId].ToString().Trim(); //打分者
objvcc_ExamPaperStuBatchRelaEN.MarkDate = objRow[convcc_ExamPaperStuBatchRela.MarkDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MarkDate].ToString().Trim(); //打分日期
objvcc_ExamPaperStuBatchRelaEN.AnswerIP = objRow[convcc_ExamPaperStuBatchRela.AnswerIP] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.AnswerIP].ToString().Trim(); //回答IP
objvcc_ExamPaperStuBatchRelaEN.AnswerDate = objRow[convcc_ExamPaperStuBatchRela.AnswerDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.AnswerDate].ToString().Trim(); //回答日期
objvcc_ExamPaperStuBatchRelaEN.AnswerTime = objRow[convcc_ExamPaperStuBatchRela.AnswerTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.AnswerTime].ToString().Trim(); //回答时间
objvcc_ExamPaperStuBatchRelaEN.TotalGetScore = Double.Parse(objRow[convcc_ExamPaperStuBatchRela.TotalGetScore].ToString().Trim()); //考生获取总分
objvcc_ExamPaperStuBatchRelaEN.UpdDate = objRow[convcc_ExamPaperStuBatchRela.UpdDate].ToString().Trim(); //修改日期
objvcc_ExamPaperStuBatchRelaEN.UpdUserId = objRow[convcc_ExamPaperStuBatchRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExamPaperStuBatchRelaEN.Memo = objRow[convcc_ExamPaperStuBatchRela.Memo] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.Memo].ToString().Trim(); //备注
objvcc_ExamPaperStuBatchRelaEN.NoSubmitQuesNum = objRow[convcc_ExamPaperStuBatchRela.NoSubmitQuesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.NoSubmitQuesNum].ToString().Trim()); //未提交题数
objvcc_ExamPaperStuBatchRelaEN.SubmitQuesNum = objRow[convcc_ExamPaperStuBatchRela.SubmitQuesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.SubmitQuesNum].ToString().Trim()); //提交题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_ExamPaperStuBatchRelaEN);
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
public static List<clsvcc_ExamPaperStuBatchRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcc_ExamPaperStuBatchRelaEN> arrObjLst = new List<clsvcc_ExamPaperStuBatchRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN = new clsvcc_ExamPaperStuBatchRelaEN();
try
{
objvcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = objRow[convcc_ExamPaperStuBatchRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objvcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = objRow[convcc_ExamPaperStuBatchRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_ExamPaperStuBatchRelaEN.CourseId = objRow[convcc_ExamPaperStuBatchRela.CourseId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CourseId].ToString().Trim(); //课程Id
objvcc_ExamPaperStuBatchRelaEN.CourseName = objRow[convcc_ExamPaperStuBatchRela.CourseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CourseName].ToString().Trim(); //课程名称
objvcc_ExamPaperStuBatchRelaEN.ExamPaperName = objRow[convcc_ExamPaperStuBatchRela.ExamPaperName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_ExamPaperStuBatchRelaEN.PaperIndex = objRow[convcc_ExamPaperStuBatchRela.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.PaperIndex].ToString().Trim()); //试卷序号
objvcc_ExamPaperStuBatchRelaEN.ExamPaperTypeId = objRow[convcc_ExamPaperStuBatchRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_ExamPaperStuBatchRelaEN.ExamPaperTypeName = objRow[convcc_ExamPaperStuBatchRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_ExamPaperStuBatchRelaEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsShow].ToString().Trim()); //是否启用
objvcc_ExamPaperStuBatchRelaEN.TotalScore = Double.Parse(objRow[convcc_ExamPaperStuBatchRela.TotalScore].ToString().Trim()); //总得分
objvcc_ExamPaperStuBatchRelaEN.ViewCount = objRow[convcc_ExamPaperStuBatchRela.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.ViewCount].ToString().Trim()); //浏览量
objvcc_ExamPaperStuBatchRelaEN.DoneNumber = objRow[convcc_ExamPaperStuBatchRela.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.DoneNumber].ToString().Trim()); //已做人数
objvcc_ExamPaperStuBatchRelaEN.PaperTime = objRow[convcc_ExamPaperStuBatchRela.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.PaperTime].ToString().Trim()); //考试时间（分钟）
objvcc_ExamPaperStuBatchRelaEN.PaperDispModeName = objRow[convcc_ExamPaperStuBatchRela.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.PaperDispModeName].ToString().Trim(); //试卷显示模式名称
objvcc_ExamPaperStuBatchRelaEN.ExamCreateTime = objRow[convcc_ExamPaperStuBatchRela.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_ExamPaperStuBatchRelaEN.UserName = objRow[convcc_ExamPaperStuBatchRela.UserName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.UserName].ToString().Trim(); //用户名
objvcc_ExamPaperStuBatchRelaEN.CourseChapterId = objRow[convcc_ExamPaperStuBatchRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_ExamPaperStuBatchRelaEN.CourseChapterName = objRow[convcc_ExamPaperStuBatchRela.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_ExamPaperStuBatchRelaEN.ChapterId = objRow[convcc_ExamPaperStuBatchRela.ChapterId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ChapterId].ToString().Trim(); //章Id
objvcc_ExamPaperStuBatchRelaEN.SectionId = objRow[convcc_ExamPaperStuBatchRela.SectionId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SectionId].ToString().Trim(); //节Id
objvcc_ExamPaperStuBatchRelaEN.ChapterName = objRow[convcc_ExamPaperStuBatchRela.ChapterName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ChapterName].ToString().Trim(); //章名
objvcc_ExamPaperStuBatchRelaEN.SectionName = objRow[convcc_ExamPaperStuBatchRela.SectionName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SectionName].ToString().Trim(); //节名
objvcc_ExamPaperStuBatchRelaEN.ChapterNameSim = objRow[convcc_ExamPaperStuBatchRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_ExamPaperStuBatchRelaEN.SectionNameSim = objRow[convcc_ExamPaperStuBatchRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_ExamPaperStuBatchRelaEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_ExamPaperStuBatchRelaEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_ExamPaperStuBatchRelaEN.QuestionNum = objRow[convcc_ExamPaperStuBatchRela.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.QuestionNum].ToString().Trim()); //题目数
objvcc_ExamPaperStuBatchRelaEN.IdStudentInfo = objRow[convcc_ExamPaperStuBatchRela.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_ExamPaperStuBatchRelaEN.StuID = objRow[convcc_ExamPaperStuBatchRela.StuID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.StuID].ToString().Trim(); //学号
objvcc_ExamPaperStuBatchRelaEN.StuName = objRow[convcc_ExamPaperStuBatchRela.StuName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.StuName].ToString().Trim(); //姓名
objvcc_ExamPaperStuBatchRelaEN.SexDesc = objRow[convcc_ExamPaperStuBatchRela.SexDesc] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SexDesc].ToString().Trim(); //性别名称
objvcc_ExamPaperStuBatchRelaEN.IdXzCollege = objRow[convcc_ExamPaperStuBatchRela.IdXzCollege] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_ExamPaperStuBatchRelaEN.CollegeName = objRow[convcc_ExamPaperStuBatchRela.CollegeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CollegeName].ToString().Trim(); //学院名称
objvcc_ExamPaperStuBatchRelaEN.CollegeNameA = objRow[convcc_ExamPaperStuBatchRela.CollegeNameA] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_ExamPaperStuBatchRelaEN.IdXzMajor = objRow[convcc_ExamPaperStuBatchRela.IdXzMajor] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_ExamPaperStuBatchRelaEN.MajorID = objRow[convcc_ExamPaperStuBatchRela.MajorID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MajorID].ToString().Trim(); //专业ID
objvcc_ExamPaperStuBatchRelaEN.MajorName = objRow[convcc_ExamPaperStuBatchRela.MajorName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MajorName].ToString().Trim(); //专业名称
objvcc_ExamPaperStuBatchRelaEN.IdGradeBase = objRow[convcc_ExamPaperStuBatchRela.IdGradeBase] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_ExamPaperStuBatchRelaEN.GradeBaseName = objRow[convcc_ExamPaperStuBatchRela.GradeBaseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.GradeBaseName].ToString().Trim(); //年级名称
objvcc_ExamPaperStuBatchRelaEN.BatchTime = objRow[convcc_ExamPaperStuBatchRela.BatchTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.BatchTime].ToString().Trim(); //批次
objvcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = objRow[convcc_ExamPaperStuBatchRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_ExamPaperStuBatchRelaEN.CurrEduClsId = objRow[convcc_ExamPaperStuBatchRela.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_ExamPaperStuBatchRelaEN.EduClsName = objRow[convcc_ExamPaperStuBatchRela.EduClsName].ToString().Trim(); //教学班名
objvcc_ExamPaperStuBatchRelaEN.Scores = objRow[convcc_ExamPaperStuBatchRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperStuBatchRela.Scores].ToString().Trim()); //分值
objvcc_ExamPaperStuBatchRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsSave].ToString().Trim()); //是否保存
objvcc_ExamPaperStuBatchRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsSubmit].ToString().Trim()); //是否提交
objvcc_ExamPaperStuBatchRelaEN.RealFinishDate = objRow[convcc_ExamPaperStuBatchRela.RealFinishDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_ExamPaperStuBatchRelaEN.OperateTime = objRow[convcc_ExamPaperStuBatchRela.OperateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.OperateTime].ToString().Trim(); //操作时间
objvcc_ExamPaperStuBatchRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsMarking].ToString().Trim()); //是否批阅
objvcc_ExamPaperStuBatchRelaEN.MarkerId = objRow[convcc_ExamPaperStuBatchRela.MarkerId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MarkerId].ToString().Trim(); //打分者
objvcc_ExamPaperStuBatchRelaEN.MarkDate = objRow[convcc_ExamPaperStuBatchRela.MarkDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MarkDate].ToString().Trim(); //打分日期
objvcc_ExamPaperStuBatchRelaEN.AnswerIP = objRow[convcc_ExamPaperStuBatchRela.AnswerIP] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.AnswerIP].ToString().Trim(); //回答IP
objvcc_ExamPaperStuBatchRelaEN.AnswerDate = objRow[convcc_ExamPaperStuBatchRela.AnswerDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.AnswerDate].ToString().Trim(); //回答日期
objvcc_ExamPaperStuBatchRelaEN.AnswerTime = objRow[convcc_ExamPaperStuBatchRela.AnswerTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.AnswerTime].ToString().Trim(); //回答时间
objvcc_ExamPaperStuBatchRelaEN.TotalGetScore = Double.Parse(objRow[convcc_ExamPaperStuBatchRela.TotalGetScore].ToString().Trim()); //考生获取总分
objvcc_ExamPaperStuBatchRelaEN.UpdDate = objRow[convcc_ExamPaperStuBatchRela.UpdDate].ToString().Trim(); //修改日期
objvcc_ExamPaperStuBatchRelaEN.UpdUserId = objRow[convcc_ExamPaperStuBatchRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExamPaperStuBatchRelaEN.Memo = objRow[convcc_ExamPaperStuBatchRela.Memo] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.Memo].ToString().Trim(); //备注
objvcc_ExamPaperStuBatchRelaEN.NoSubmitQuesNum = objRow[convcc_ExamPaperStuBatchRela.NoSubmitQuesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.NoSubmitQuesNum].ToString().Trim()); //未提交题数
objvcc_ExamPaperStuBatchRelaEN.SubmitQuesNum = objRow[convcc_ExamPaperStuBatchRela.SubmitQuesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.SubmitQuesNum].ToString().Trim()); //提交题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_ExamPaperStuBatchRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcc_ExamPaperStuBatchRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcc_ExamPaperStuBatchRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_ExamPaperStuBatchRelaEN> arrObjLst = new List<clsvcc_ExamPaperStuBatchRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN = new clsvcc_ExamPaperStuBatchRelaEN();
try
{
objvcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = objRow[convcc_ExamPaperStuBatchRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objvcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = objRow[convcc_ExamPaperStuBatchRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_ExamPaperStuBatchRelaEN.CourseId = objRow[convcc_ExamPaperStuBatchRela.CourseId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CourseId].ToString().Trim(); //课程Id
objvcc_ExamPaperStuBatchRelaEN.CourseName = objRow[convcc_ExamPaperStuBatchRela.CourseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CourseName].ToString().Trim(); //课程名称
objvcc_ExamPaperStuBatchRelaEN.ExamPaperName = objRow[convcc_ExamPaperStuBatchRela.ExamPaperName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_ExamPaperStuBatchRelaEN.PaperIndex = objRow[convcc_ExamPaperStuBatchRela.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.PaperIndex].ToString().Trim()); //试卷序号
objvcc_ExamPaperStuBatchRelaEN.ExamPaperTypeId = objRow[convcc_ExamPaperStuBatchRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_ExamPaperStuBatchRelaEN.ExamPaperTypeName = objRow[convcc_ExamPaperStuBatchRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_ExamPaperStuBatchRelaEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsShow].ToString().Trim()); //是否启用
objvcc_ExamPaperStuBatchRelaEN.TotalScore = Double.Parse(objRow[convcc_ExamPaperStuBatchRela.TotalScore].ToString().Trim()); //总得分
objvcc_ExamPaperStuBatchRelaEN.ViewCount = objRow[convcc_ExamPaperStuBatchRela.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.ViewCount].ToString().Trim()); //浏览量
objvcc_ExamPaperStuBatchRelaEN.DoneNumber = objRow[convcc_ExamPaperStuBatchRela.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.DoneNumber].ToString().Trim()); //已做人数
objvcc_ExamPaperStuBatchRelaEN.PaperTime = objRow[convcc_ExamPaperStuBatchRela.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.PaperTime].ToString().Trim()); //考试时间（分钟）
objvcc_ExamPaperStuBatchRelaEN.PaperDispModeName = objRow[convcc_ExamPaperStuBatchRela.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.PaperDispModeName].ToString().Trim(); //试卷显示模式名称
objvcc_ExamPaperStuBatchRelaEN.ExamCreateTime = objRow[convcc_ExamPaperStuBatchRela.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_ExamPaperStuBatchRelaEN.UserName = objRow[convcc_ExamPaperStuBatchRela.UserName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.UserName].ToString().Trim(); //用户名
objvcc_ExamPaperStuBatchRelaEN.CourseChapterId = objRow[convcc_ExamPaperStuBatchRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_ExamPaperStuBatchRelaEN.CourseChapterName = objRow[convcc_ExamPaperStuBatchRela.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_ExamPaperStuBatchRelaEN.ChapterId = objRow[convcc_ExamPaperStuBatchRela.ChapterId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ChapterId].ToString().Trim(); //章Id
objvcc_ExamPaperStuBatchRelaEN.SectionId = objRow[convcc_ExamPaperStuBatchRela.SectionId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SectionId].ToString().Trim(); //节Id
objvcc_ExamPaperStuBatchRelaEN.ChapterName = objRow[convcc_ExamPaperStuBatchRela.ChapterName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ChapterName].ToString().Trim(); //章名
objvcc_ExamPaperStuBatchRelaEN.SectionName = objRow[convcc_ExamPaperStuBatchRela.SectionName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SectionName].ToString().Trim(); //节名
objvcc_ExamPaperStuBatchRelaEN.ChapterNameSim = objRow[convcc_ExamPaperStuBatchRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_ExamPaperStuBatchRelaEN.SectionNameSim = objRow[convcc_ExamPaperStuBatchRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_ExamPaperStuBatchRelaEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_ExamPaperStuBatchRelaEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_ExamPaperStuBatchRelaEN.QuestionNum = objRow[convcc_ExamPaperStuBatchRela.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.QuestionNum].ToString().Trim()); //题目数
objvcc_ExamPaperStuBatchRelaEN.IdStudentInfo = objRow[convcc_ExamPaperStuBatchRela.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_ExamPaperStuBatchRelaEN.StuID = objRow[convcc_ExamPaperStuBatchRela.StuID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.StuID].ToString().Trim(); //学号
objvcc_ExamPaperStuBatchRelaEN.StuName = objRow[convcc_ExamPaperStuBatchRela.StuName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.StuName].ToString().Trim(); //姓名
objvcc_ExamPaperStuBatchRelaEN.SexDesc = objRow[convcc_ExamPaperStuBatchRela.SexDesc] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SexDesc].ToString().Trim(); //性别名称
objvcc_ExamPaperStuBatchRelaEN.IdXzCollege = objRow[convcc_ExamPaperStuBatchRela.IdXzCollege] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_ExamPaperStuBatchRelaEN.CollegeName = objRow[convcc_ExamPaperStuBatchRela.CollegeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CollegeName].ToString().Trim(); //学院名称
objvcc_ExamPaperStuBatchRelaEN.CollegeNameA = objRow[convcc_ExamPaperStuBatchRela.CollegeNameA] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_ExamPaperStuBatchRelaEN.IdXzMajor = objRow[convcc_ExamPaperStuBatchRela.IdXzMajor] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_ExamPaperStuBatchRelaEN.MajorID = objRow[convcc_ExamPaperStuBatchRela.MajorID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MajorID].ToString().Trim(); //专业ID
objvcc_ExamPaperStuBatchRelaEN.MajorName = objRow[convcc_ExamPaperStuBatchRela.MajorName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MajorName].ToString().Trim(); //专业名称
objvcc_ExamPaperStuBatchRelaEN.IdGradeBase = objRow[convcc_ExamPaperStuBatchRela.IdGradeBase] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_ExamPaperStuBatchRelaEN.GradeBaseName = objRow[convcc_ExamPaperStuBatchRela.GradeBaseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.GradeBaseName].ToString().Trim(); //年级名称
objvcc_ExamPaperStuBatchRelaEN.BatchTime = objRow[convcc_ExamPaperStuBatchRela.BatchTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.BatchTime].ToString().Trim(); //批次
objvcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = objRow[convcc_ExamPaperStuBatchRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_ExamPaperStuBatchRelaEN.CurrEduClsId = objRow[convcc_ExamPaperStuBatchRela.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_ExamPaperStuBatchRelaEN.EduClsName = objRow[convcc_ExamPaperStuBatchRela.EduClsName].ToString().Trim(); //教学班名
objvcc_ExamPaperStuBatchRelaEN.Scores = objRow[convcc_ExamPaperStuBatchRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperStuBatchRela.Scores].ToString().Trim()); //分值
objvcc_ExamPaperStuBatchRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsSave].ToString().Trim()); //是否保存
objvcc_ExamPaperStuBatchRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsSubmit].ToString().Trim()); //是否提交
objvcc_ExamPaperStuBatchRelaEN.RealFinishDate = objRow[convcc_ExamPaperStuBatchRela.RealFinishDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_ExamPaperStuBatchRelaEN.OperateTime = objRow[convcc_ExamPaperStuBatchRela.OperateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.OperateTime].ToString().Trim(); //操作时间
objvcc_ExamPaperStuBatchRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsMarking].ToString().Trim()); //是否批阅
objvcc_ExamPaperStuBatchRelaEN.MarkerId = objRow[convcc_ExamPaperStuBatchRela.MarkerId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MarkerId].ToString().Trim(); //打分者
objvcc_ExamPaperStuBatchRelaEN.MarkDate = objRow[convcc_ExamPaperStuBatchRela.MarkDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MarkDate].ToString().Trim(); //打分日期
objvcc_ExamPaperStuBatchRelaEN.AnswerIP = objRow[convcc_ExamPaperStuBatchRela.AnswerIP] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.AnswerIP].ToString().Trim(); //回答IP
objvcc_ExamPaperStuBatchRelaEN.AnswerDate = objRow[convcc_ExamPaperStuBatchRela.AnswerDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.AnswerDate].ToString().Trim(); //回答日期
objvcc_ExamPaperStuBatchRelaEN.AnswerTime = objRow[convcc_ExamPaperStuBatchRela.AnswerTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.AnswerTime].ToString().Trim(); //回答时间
objvcc_ExamPaperStuBatchRelaEN.TotalGetScore = Double.Parse(objRow[convcc_ExamPaperStuBatchRela.TotalGetScore].ToString().Trim()); //考生获取总分
objvcc_ExamPaperStuBatchRelaEN.UpdDate = objRow[convcc_ExamPaperStuBatchRela.UpdDate].ToString().Trim(); //修改日期
objvcc_ExamPaperStuBatchRelaEN.UpdUserId = objRow[convcc_ExamPaperStuBatchRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExamPaperStuBatchRelaEN.Memo = objRow[convcc_ExamPaperStuBatchRela.Memo] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.Memo].ToString().Trim(); //备注
objvcc_ExamPaperStuBatchRelaEN.NoSubmitQuesNum = objRow[convcc_ExamPaperStuBatchRela.NoSubmitQuesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.NoSubmitQuesNum].ToString().Trim()); //未提交题数
objvcc_ExamPaperStuBatchRelaEN.SubmitQuesNum = objRow[convcc_ExamPaperStuBatchRela.SubmitQuesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.SubmitQuesNum].ToString().Trim()); //提交题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_ExamPaperStuBatchRelaEN);
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
public static List<clsvcc_ExamPaperStuBatchRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcc_ExamPaperStuBatchRelaEN> arrObjLst = new List<clsvcc_ExamPaperStuBatchRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN = new clsvcc_ExamPaperStuBatchRelaEN();
try
{
objvcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = objRow[convcc_ExamPaperStuBatchRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objvcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = objRow[convcc_ExamPaperStuBatchRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_ExamPaperStuBatchRelaEN.CourseId = objRow[convcc_ExamPaperStuBatchRela.CourseId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CourseId].ToString().Trim(); //课程Id
objvcc_ExamPaperStuBatchRelaEN.CourseName = objRow[convcc_ExamPaperStuBatchRela.CourseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CourseName].ToString().Trim(); //课程名称
objvcc_ExamPaperStuBatchRelaEN.ExamPaperName = objRow[convcc_ExamPaperStuBatchRela.ExamPaperName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_ExamPaperStuBatchRelaEN.PaperIndex = objRow[convcc_ExamPaperStuBatchRela.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.PaperIndex].ToString().Trim()); //试卷序号
objvcc_ExamPaperStuBatchRelaEN.ExamPaperTypeId = objRow[convcc_ExamPaperStuBatchRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_ExamPaperStuBatchRelaEN.ExamPaperTypeName = objRow[convcc_ExamPaperStuBatchRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_ExamPaperStuBatchRelaEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsShow].ToString().Trim()); //是否启用
objvcc_ExamPaperStuBatchRelaEN.TotalScore = Double.Parse(objRow[convcc_ExamPaperStuBatchRela.TotalScore].ToString().Trim()); //总得分
objvcc_ExamPaperStuBatchRelaEN.ViewCount = objRow[convcc_ExamPaperStuBatchRela.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.ViewCount].ToString().Trim()); //浏览量
objvcc_ExamPaperStuBatchRelaEN.DoneNumber = objRow[convcc_ExamPaperStuBatchRela.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.DoneNumber].ToString().Trim()); //已做人数
objvcc_ExamPaperStuBatchRelaEN.PaperTime = objRow[convcc_ExamPaperStuBatchRela.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.PaperTime].ToString().Trim()); //考试时间（分钟）
objvcc_ExamPaperStuBatchRelaEN.PaperDispModeName = objRow[convcc_ExamPaperStuBatchRela.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.PaperDispModeName].ToString().Trim(); //试卷显示模式名称
objvcc_ExamPaperStuBatchRelaEN.ExamCreateTime = objRow[convcc_ExamPaperStuBatchRela.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_ExamPaperStuBatchRelaEN.UserName = objRow[convcc_ExamPaperStuBatchRela.UserName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.UserName].ToString().Trim(); //用户名
objvcc_ExamPaperStuBatchRelaEN.CourseChapterId = objRow[convcc_ExamPaperStuBatchRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_ExamPaperStuBatchRelaEN.CourseChapterName = objRow[convcc_ExamPaperStuBatchRela.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_ExamPaperStuBatchRelaEN.ChapterId = objRow[convcc_ExamPaperStuBatchRela.ChapterId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ChapterId].ToString().Trim(); //章Id
objvcc_ExamPaperStuBatchRelaEN.SectionId = objRow[convcc_ExamPaperStuBatchRela.SectionId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SectionId].ToString().Trim(); //节Id
objvcc_ExamPaperStuBatchRelaEN.ChapterName = objRow[convcc_ExamPaperStuBatchRela.ChapterName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ChapterName].ToString().Trim(); //章名
objvcc_ExamPaperStuBatchRelaEN.SectionName = objRow[convcc_ExamPaperStuBatchRela.SectionName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SectionName].ToString().Trim(); //节名
objvcc_ExamPaperStuBatchRelaEN.ChapterNameSim = objRow[convcc_ExamPaperStuBatchRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_ExamPaperStuBatchRelaEN.SectionNameSim = objRow[convcc_ExamPaperStuBatchRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_ExamPaperStuBatchRelaEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_ExamPaperStuBatchRelaEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_ExamPaperStuBatchRelaEN.QuestionNum = objRow[convcc_ExamPaperStuBatchRela.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.QuestionNum].ToString().Trim()); //题目数
objvcc_ExamPaperStuBatchRelaEN.IdStudentInfo = objRow[convcc_ExamPaperStuBatchRela.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_ExamPaperStuBatchRelaEN.StuID = objRow[convcc_ExamPaperStuBatchRela.StuID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.StuID].ToString().Trim(); //学号
objvcc_ExamPaperStuBatchRelaEN.StuName = objRow[convcc_ExamPaperStuBatchRela.StuName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.StuName].ToString().Trim(); //姓名
objvcc_ExamPaperStuBatchRelaEN.SexDesc = objRow[convcc_ExamPaperStuBatchRela.SexDesc] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SexDesc].ToString().Trim(); //性别名称
objvcc_ExamPaperStuBatchRelaEN.IdXzCollege = objRow[convcc_ExamPaperStuBatchRela.IdXzCollege] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_ExamPaperStuBatchRelaEN.CollegeName = objRow[convcc_ExamPaperStuBatchRela.CollegeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CollegeName].ToString().Trim(); //学院名称
objvcc_ExamPaperStuBatchRelaEN.CollegeNameA = objRow[convcc_ExamPaperStuBatchRela.CollegeNameA] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_ExamPaperStuBatchRelaEN.IdXzMajor = objRow[convcc_ExamPaperStuBatchRela.IdXzMajor] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_ExamPaperStuBatchRelaEN.MajorID = objRow[convcc_ExamPaperStuBatchRela.MajorID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MajorID].ToString().Trim(); //专业ID
objvcc_ExamPaperStuBatchRelaEN.MajorName = objRow[convcc_ExamPaperStuBatchRela.MajorName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MajorName].ToString().Trim(); //专业名称
objvcc_ExamPaperStuBatchRelaEN.IdGradeBase = objRow[convcc_ExamPaperStuBatchRela.IdGradeBase] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_ExamPaperStuBatchRelaEN.GradeBaseName = objRow[convcc_ExamPaperStuBatchRela.GradeBaseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.GradeBaseName].ToString().Trim(); //年级名称
objvcc_ExamPaperStuBatchRelaEN.BatchTime = objRow[convcc_ExamPaperStuBatchRela.BatchTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.BatchTime].ToString().Trim(); //批次
objvcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = objRow[convcc_ExamPaperStuBatchRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_ExamPaperStuBatchRelaEN.CurrEduClsId = objRow[convcc_ExamPaperStuBatchRela.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_ExamPaperStuBatchRelaEN.EduClsName = objRow[convcc_ExamPaperStuBatchRela.EduClsName].ToString().Trim(); //教学班名
objvcc_ExamPaperStuBatchRelaEN.Scores = objRow[convcc_ExamPaperStuBatchRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperStuBatchRela.Scores].ToString().Trim()); //分值
objvcc_ExamPaperStuBatchRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsSave].ToString().Trim()); //是否保存
objvcc_ExamPaperStuBatchRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsSubmit].ToString().Trim()); //是否提交
objvcc_ExamPaperStuBatchRelaEN.RealFinishDate = objRow[convcc_ExamPaperStuBatchRela.RealFinishDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_ExamPaperStuBatchRelaEN.OperateTime = objRow[convcc_ExamPaperStuBatchRela.OperateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.OperateTime].ToString().Trim(); //操作时间
objvcc_ExamPaperStuBatchRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsMarking].ToString().Trim()); //是否批阅
objvcc_ExamPaperStuBatchRelaEN.MarkerId = objRow[convcc_ExamPaperStuBatchRela.MarkerId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MarkerId].ToString().Trim(); //打分者
objvcc_ExamPaperStuBatchRelaEN.MarkDate = objRow[convcc_ExamPaperStuBatchRela.MarkDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MarkDate].ToString().Trim(); //打分日期
objvcc_ExamPaperStuBatchRelaEN.AnswerIP = objRow[convcc_ExamPaperStuBatchRela.AnswerIP] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.AnswerIP].ToString().Trim(); //回答IP
objvcc_ExamPaperStuBatchRelaEN.AnswerDate = objRow[convcc_ExamPaperStuBatchRela.AnswerDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.AnswerDate].ToString().Trim(); //回答日期
objvcc_ExamPaperStuBatchRelaEN.AnswerTime = objRow[convcc_ExamPaperStuBatchRela.AnswerTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.AnswerTime].ToString().Trim(); //回答时间
objvcc_ExamPaperStuBatchRelaEN.TotalGetScore = Double.Parse(objRow[convcc_ExamPaperStuBatchRela.TotalGetScore].ToString().Trim()); //考生获取总分
objvcc_ExamPaperStuBatchRelaEN.UpdDate = objRow[convcc_ExamPaperStuBatchRela.UpdDate].ToString().Trim(); //修改日期
objvcc_ExamPaperStuBatchRelaEN.UpdUserId = objRow[convcc_ExamPaperStuBatchRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExamPaperStuBatchRelaEN.Memo = objRow[convcc_ExamPaperStuBatchRela.Memo] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.Memo].ToString().Trim(); //备注
objvcc_ExamPaperStuBatchRelaEN.NoSubmitQuesNum = objRow[convcc_ExamPaperStuBatchRela.NoSubmitQuesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.NoSubmitQuesNum].ToString().Trim()); //未提交题数
objvcc_ExamPaperStuBatchRelaEN.SubmitQuesNum = objRow[convcc_ExamPaperStuBatchRela.SubmitQuesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.SubmitQuesNum].ToString().Trim()); //提交题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_ExamPaperStuBatchRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_ExamPaperStuBatchRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcc_ExamPaperStuBatchRelaEN> arrObjLst = new List<clsvcc_ExamPaperStuBatchRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN = new clsvcc_ExamPaperStuBatchRelaEN();
try
{
objvcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = objRow[convcc_ExamPaperStuBatchRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objvcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = objRow[convcc_ExamPaperStuBatchRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_ExamPaperStuBatchRelaEN.CourseId = objRow[convcc_ExamPaperStuBatchRela.CourseId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CourseId].ToString().Trim(); //课程Id
objvcc_ExamPaperStuBatchRelaEN.CourseName = objRow[convcc_ExamPaperStuBatchRela.CourseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CourseName].ToString().Trim(); //课程名称
objvcc_ExamPaperStuBatchRelaEN.ExamPaperName = objRow[convcc_ExamPaperStuBatchRela.ExamPaperName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_ExamPaperStuBatchRelaEN.PaperIndex = objRow[convcc_ExamPaperStuBatchRela.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.PaperIndex].ToString().Trim()); //试卷序号
objvcc_ExamPaperStuBatchRelaEN.ExamPaperTypeId = objRow[convcc_ExamPaperStuBatchRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_ExamPaperStuBatchRelaEN.ExamPaperTypeName = objRow[convcc_ExamPaperStuBatchRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_ExamPaperStuBatchRelaEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsShow].ToString().Trim()); //是否启用
objvcc_ExamPaperStuBatchRelaEN.TotalScore = Double.Parse(objRow[convcc_ExamPaperStuBatchRela.TotalScore].ToString().Trim()); //总得分
objvcc_ExamPaperStuBatchRelaEN.ViewCount = objRow[convcc_ExamPaperStuBatchRela.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.ViewCount].ToString().Trim()); //浏览量
objvcc_ExamPaperStuBatchRelaEN.DoneNumber = objRow[convcc_ExamPaperStuBatchRela.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.DoneNumber].ToString().Trim()); //已做人数
objvcc_ExamPaperStuBatchRelaEN.PaperTime = objRow[convcc_ExamPaperStuBatchRela.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.PaperTime].ToString().Trim()); //考试时间（分钟）
objvcc_ExamPaperStuBatchRelaEN.PaperDispModeName = objRow[convcc_ExamPaperStuBatchRela.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.PaperDispModeName].ToString().Trim(); //试卷显示模式名称
objvcc_ExamPaperStuBatchRelaEN.ExamCreateTime = objRow[convcc_ExamPaperStuBatchRela.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_ExamPaperStuBatchRelaEN.UserName = objRow[convcc_ExamPaperStuBatchRela.UserName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.UserName].ToString().Trim(); //用户名
objvcc_ExamPaperStuBatchRelaEN.CourseChapterId = objRow[convcc_ExamPaperStuBatchRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_ExamPaperStuBatchRelaEN.CourseChapterName = objRow[convcc_ExamPaperStuBatchRela.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_ExamPaperStuBatchRelaEN.ChapterId = objRow[convcc_ExamPaperStuBatchRela.ChapterId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ChapterId].ToString().Trim(); //章Id
objvcc_ExamPaperStuBatchRelaEN.SectionId = objRow[convcc_ExamPaperStuBatchRela.SectionId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SectionId].ToString().Trim(); //节Id
objvcc_ExamPaperStuBatchRelaEN.ChapterName = objRow[convcc_ExamPaperStuBatchRela.ChapterName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ChapterName].ToString().Trim(); //章名
objvcc_ExamPaperStuBatchRelaEN.SectionName = objRow[convcc_ExamPaperStuBatchRela.SectionName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SectionName].ToString().Trim(); //节名
objvcc_ExamPaperStuBatchRelaEN.ChapterNameSim = objRow[convcc_ExamPaperStuBatchRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_ExamPaperStuBatchRelaEN.SectionNameSim = objRow[convcc_ExamPaperStuBatchRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_ExamPaperStuBatchRelaEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_ExamPaperStuBatchRelaEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_ExamPaperStuBatchRelaEN.QuestionNum = objRow[convcc_ExamPaperStuBatchRela.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.QuestionNum].ToString().Trim()); //题目数
objvcc_ExamPaperStuBatchRelaEN.IdStudentInfo = objRow[convcc_ExamPaperStuBatchRela.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_ExamPaperStuBatchRelaEN.StuID = objRow[convcc_ExamPaperStuBatchRela.StuID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.StuID].ToString().Trim(); //学号
objvcc_ExamPaperStuBatchRelaEN.StuName = objRow[convcc_ExamPaperStuBatchRela.StuName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.StuName].ToString().Trim(); //姓名
objvcc_ExamPaperStuBatchRelaEN.SexDesc = objRow[convcc_ExamPaperStuBatchRela.SexDesc] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.SexDesc].ToString().Trim(); //性别名称
objvcc_ExamPaperStuBatchRelaEN.IdXzCollege = objRow[convcc_ExamPaperStuBatchRela.IdXzCollege] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_ExamPaperStuBatchRelaEN.CollegeName = objRow[convcc_ExamPaperStuBatchRela.CollegeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CollegeName].ToString().Trim(); //学院名称
objvcc_ExamPaperStuBatchRelaEN.CollegeNameA = objRow[convcc_ExamPaperStuBatchRela.CollegeNameA] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_ExamPaperStuBatchRelaEN.IdXzMajor = objRow[convcc_ExamPaperStuBatchRela.IdXzMajor] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_ExamPaperStuBatchRelaEN.MajorID = objRow[convcc_ExamPaperStuBatchRela.MajorID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MajorID].ToString().Trim(); //专业ID
objvcc_ExamPaperStuBatchRelaEN.MajorName = objRow[convcc_ExamPaperStuBatchRela.MajorName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MajorName].ToString().Trim(); //专业名称
objvcc_ExamPaperStuBatchRelaEN.IdGradeBase = objRow[convcc_ExamPaperStuBatchRela.IdGradeBase] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_ExamPaperStuBatchRelaEN.GradeBaseName = objRow[convcc_ExamPaperStuBatchRela.GradeBaseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.GradeBaseName].ToString().Trim(); //年级名称
objvcc_ExamPaperStuBatchRelaEN.BatchTime = objRow[convcc_ExamPaperStuBatchRela.BatchTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.BatchTime].ToString().Trim(); //批次
objvcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = objRow[convcc_ExamPaperStuBatchRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_ExamPaperStuBatchRelaEN.CurrEduClsId = objRow[convcc_ExamPaperStuBatchRela.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_ExamPaperStuBatchRelaEN.EduClsName = objRow[convcc_ExamPaperStuBatchRela.EduClsName].ToString().Trim(); //教学班名
objvcc_ExamPaperStuBatchRelaEN.Scores = objRow[convcc_ExamPaperStuBatchRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperStuBatchRela.Scores].ToString().Trim()); //分值
objvcc_ExamPaperStuBatchRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsSave].ToString().Trim()); //是否保存
objvcc_ExamPaperStuBatchRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsSubmit].ToString().Trim()); //是否提交
objvcc_ExamPaperStuBatchRelaEN.RealFinishDate = objRow[convcc_ExamPaperStuBatchRela.RealFinishDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_ExamPaperStuBatchRelaEN.OperateTime = objRow[convcc_ExamPaperStuBatchRela.OperateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.OperateTime].ToString().Trim(); //操作时间
objvcc_ExamPaperStuBatchRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuBatchRela.IsMarking].ToString().Trim()); //是否批阅
objvcc_ExamPaperStuBatchRelaEN.MarkerId = objRow[convcc_ExamPaperStuBatchRela.MarkerId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MarkerId].ToString().Trim(); //打分者
objvcc_ExamPaperStuBatchRelaEN.MarkDate = objRow[convcc_ExamPaperStuBatchRela.MarkDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.MarkDate].ToString().Trim(); //打分日期
objvcc_ExamPaperStuBatchRelaEN.AnswerIP = objRow[convcc_ExamPaperStuBatchRela.AnswerIP] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.AnswerIP].ToString().Trim(); //回答IP
objvcc_ExamPaperStuBatchRelaEN.AnswerDate = objRow[convcc_ExamPaperStuBatchRela.AnswerDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.AnswerDate].ToString().Trim(); //回答日期
objvcc_ExamPaperStuBatchRelaEN.AnswerTime = objRow[convcc_ExamPaperStuBatchRela.AnswerTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.AnswerTime].ToString().Trim(); //回答时间
objvcc_ExamPaperStuBatchRelaEN.TotalGetScore = Double.Parse(objRow[convcc_ExamPaperStuBatchRela.TotalGetScore].ToString().Trim()); //考生获取总分
objvcc_ExamPaperStuBatchRelaEN.UpdDate = objRow[convcc_ExamPaperStuBatchRela.UpdDate].ToString().Trim(); //修改日期
objvcc_ExamPaperStuBatchRelaEN.UpdUserId = objRow[convcc_ExamPaperStuBatchRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExamPaperStuBatchRelaEN.Memo = objRow[convcc_ExamPaperStuBatchRela.Memo] == DBNull.Value ? null : objRow[convcc_ExamPaperStuBatchRela.Memo].ToString().Trim(); //备注
objvcc_ExamPaperStuBatchRelaEN.NoSubmitQuesNum = objRow[convcc_ExamPaperStuBatchRela.NoSubmitQuesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.NoSubmitQuesNum].ToString().Trim()); //未提交题数
objvcc_ExamPaperStuBatchRelaEN.SubmitQuesNum = objRow[convcc_ExamPaperStuBatchRela.SubmitQuesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuBatchRela.SubmitQuesNum].ToString().Trim()); //提交题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_ExamPaperStuBatchRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcc_ExamPaperStuBatchRela(ref clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN)
{
bool bolResult = vcc_ExamPaperStuBatchRelaDA.Getvcc_ExamPaperStuBatchRela(ref objvcc_ExamPaperStuBatchRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdPaperStuBatch">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_ExamPaperStuBatchRelaEN GetObjByIdPaperStuBatch(string strIdPaperStuBatch)
{
if (strIdPaperStuBatch.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdPaperStuBatch]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdPaperStuBatch) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdPaperStuBatch]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN = vcc_ExamPaperStuBatchRelaDA.GetObjByIdPaperStuBatch(strIdPaperStuBatch);
return objvcc_ExamPaperStuBatchRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcc_ExamPaperStuBatchRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN = vcc_ExamPaperStuBatchRelaDA.GetFirstObj(strWhereCond);
 return objvcc_ExamPaperStuBatchRelaEN;
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
public static clsvcc_ExamPaperStuBatchRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN = vcc_ExamPaperStuBatchRelaDA.GetObjByDataRow(objRow);
 return objvcc_ExamPaperStuBatchRelaEN;
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
public static clsvcc_ExamPaperStuBatchRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN = vcc_ExamPaperStuBatchRelaDA.GetObjByDataRow(objRow);
 return objvcc_ExamPaperStuBatchRelaEN;
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
 /// <param name = "strIdPaperStuBatch">所给的关键字</param>
 /// <param name = "lstvcc_ExamPaperStuBatchRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_ExamPaperStuBatchRelaEN GetObjByIdPaperStuBatchFromList(string strIdPaperStuBatch, List<clsvcc_ExamPaperStuBatchRelaEN> lstvcc_ExamPaperStuBatchRelaObjLst)
{
foreach (clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN in lstvcc_ExamPaperStuBatchRelaObjLst)
{
if (objvcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch == strIdPaperStuBatch)
{
return objvcc_ExamPaperStuBatchRelaEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxIdPaperStuBatch;
 try
 {
 strMaxIdPaperStuBatch = clsvcc_ExamPaperStuBatchRelaDA.GetMaxStrId();
 return strMaxIdPaperStuBatch;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strIdPaperStuBatch;
 try
 {
 strIdPaperStuBatch = new clsvcc_ExamPaperStuBatchRelaDA().GetFirstID(strWhereCond);
 return strIdPaperStuBatch;
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
 arrList = vcc_ExamPaperStuBatchRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vcc_ExamPaperStuBatchRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdPaperStuBatch">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdPaperStuBatch)
{
if (string.IsNullOrEmpty(strIdPaperStuBatch) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdPaperStuBatch]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vcc_ExamPaperStuBatchRelaDA.IsExist(strIdPaperStuBatch);
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
 bolIsExist = clsvcc_ExamPaperStuBatchRelaDA.IsExistTable();
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
 bolIsExist = vcc_ExamPaperStuBatchRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvcc_ExamPaperStuBatchRelaENS">源对象</param>
 /// <param name = "objvcc_ExamPaperStuBatchRelaENT">目标对象</param>
 public static void CopyTo(clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaENS, clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaENT)
{
try
{
objvcc_ExamPaperStuBatchRelaENT.IdPaperStuBatch = objvcc_ExamPaperStuBatchRelaENS.IdPaperStuBatch; //学生试卷批次流水号
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
objvcc_ExamPaperStuBatchRelaENT.ChapterNameSim = objvcc_ExamPaperStuBatchRelaENS.ChapterNameSim; //章名简称
objvcc_ExamPaperStuBatchRelaENT.SectionNameSim = objvcc_ExamPaperStuBatchRelaENS.SectionNameSim; //节名简称
objvcc_ExamPaperStuBatchRelaENT.IsAutoGeneQuestion = objvcc_ExamPaperStuBatchRelaENS.IsAutoGeneQuestion; //是否自动生成题目
objvcc_ExamPaperStuBatchRelaENT.IsCanMultiDo = objvcc_ExamPaperStuBatchRelaENS.IsCanMultiDo; //是否可以做多次
objvcc_ExamPaperStuBatchRelaENT.QuestionNum = objvcc_ExamPaperStuBatchRelaENS.QuestionNum; //题目数
objvcc_ExamPaperStuBatchRelaENT.IdStudentInfo = objvcc_ExamPaperStuBatchRelaENS.IdStudentInfo; //学生流水号
objvcc_ExamPaperStuBatchRelaENT.StuID = objvcc_ExamPaperStuBatchRelaENS.StuID; //学号
objvcc_ExamPaperStuBatchRelaENT.StuName = objvcc_ExamPaperStuBatchRelaENS.StuName; //姓名
objvcc_ExamPaperStuBatchRelaENT.SexDesc = objvcc_ExamPaperStuBatchRelaENS.SexDesc; //性别名称
objvcc_ExamPaperStuBatchRelaENT.IdXzCollege = objvcc_ExamPaperStuBatchRelaENS.IdXzCollege; //学院流水号
objvcc_ExamPaperStuBatchRelaENT.CollegeName = objvcc_ExamPaperStuBatchRelaENS.CollegeName; //学院名称
objvcc_ExamPaperStuBatchRelaENT.CollegeNameA = objvcc_ExamPaperStuBatchRelaENS.CollegeNameA; //学院名称简写
objvcc_ExamPaperStuBatchRelaENT.IdXzMajor = objvcc_ExamPaperStuBatchRelaENS.IdXzMajor; //专业流水号
objvcc_ExamPaperStuBatchRelaENT.MajorID = objvcc_ExamPaperStuBatchRelaENS.MajorID; //专业ID
objvcc_ExamPaperStuBatchRelaENT.MajorName = objvcc_ExamPaperStuBatchRelaENS.MajorName; //专业名称
objvcc_ExamPaperStuBatchRelaENT.IdGradeBase = objvcc_ExamPaperStuBatchRelaENS.IdGradeBase; //年级流水号
objvcc_ExamPaperStuBatchRelaENT.GradeBaseName = objvcc_ExamPaperStuBatchRelaENS.GradeBaseName; //年级名称
objvcc_ExamPaperStuBatchRelaENT.BatchTime = objvcc_ExamPaperStuBatchRelaENS.BatchTime; //批次
objvcc_ExamPaperStuBatchRelaENT.IdCurrEduCls = objvcc_ExamPaperStuBatchRelaENS.IdCurrEduCls; //教学班流水号
objvcc_ExamPaperStuBatchRelaENT.CurrEduClsId = objvcc_ExamPaperStuBatchRelaENS.CurrEduClsId; //教学班Id
objvcc_ExamPaperStuBatchRelaENT.EduClsName = objvcc_ExamPaperStuBatchRelaENS.EduClsName; //教学班名
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
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN)
{
try
{
objvcc_ExamPaperStuBatchRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcc_ExamPaperStuBatchRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.IdPaperStuBatch, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = objvcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch; //学生试卷批次流水号
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.CourseExamPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = objvcc_ExamPaperStuBatchRelaEN.CourseExamPaperId == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.CourseExamPaperId; //考卷流水号
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.CourseId = objvcc_ExamPaperStuBatchRelaEN.CourseId == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.CourseName = objvcc_ExamPaperStuBatchRelaEN.CourseName == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.ExamPaperName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.ExamPaperName = objvcc_ExamPaperStuBatchRelaEN.ExamPaperName == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.ExamPaperName; //考卷名称
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.PaperIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.PaperIndex = objvcc_ExamPaperStuBatchRelaEN.PaperIndex; //试卷序号
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.ExamPaperTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.ExamPaperTypeId = objvcc_ExamPaperStuBatchRelaEN.ExamPaperTypeId; //试卷类型Id
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.ExamPaperTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.ExamPaperTypeName = objvcc_ExamPaperStuBatchRelaEN.ExamPaperTypeName; //试卷类型名称
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.IsShow = objvcc_ExamPaperStuBatchRelaEN.IsShow; //是否启用
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.TotalScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.TotalScore = objvcc_ExamPaperStuBatchRelaEN.TotalScore; //总得分
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.ViewCount = objvcc_ExamPaperStuBatchRelaEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.DoneNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.DoneNumber = objvcc_ExamPaperStuBatchRelaEN.DoneNumber; //已做人数
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.PaperTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.PaperTime = objvcc_ExamPaperStuBatchRelaEN.PaperTime; //考试时间（分钟）
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.PaperDispModeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.PaperDispModeName = objvcc_ExamPaperStuBatchRelaEN.PaperDispModeName == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.PaperDispModeName; //试卷显示模式名称
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.ExamCreateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.ExamCreateTime = objvcc_ExamPaperStuBatchRelaEN.ExamCreateTime == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.ExamCreateTime; //考卷建立时间
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.UserName = objvcc_ExamPaperStuBatchRelaEN.UserName == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.UserName; //用户名
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.CourseChapterId = objvcc_ExamPaperStuBatchRelaEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.CourseChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.CourseChapterName = objvcc_ExamPaperStuBatchRelaEN.CourseChapterName; //课程章节名称
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.ChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.ChapterId = objvcc_ExamPaperStuBatchRelaEN.ChapterId == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.ChapterId; //章Id
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.SectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.SectionId = objvcc_ExamPaperStuBatchRelaEN.SectionId == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.SectionId; //节Id
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.ChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.ChapterName = objvcc_ExamPaperStuBatchRelaEN.ChapterName == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.ChapterName; //章名
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.SectionName = objvcc_ExamPaperStuBatchRelaEN.SectionName == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.SectionName; //节名
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.ChapterNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.ChapterNameSim = objvcc_ExamPaperStuBatchRelaEN.ChapterNameSim == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.ChapterNameSim; //章名简称
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.SectionNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.SectionNameSim = objvcc_ExamPaperStuBatchRelaEN.SectionNameSim == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.SectionNameSim; //节名简称
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.IsAutoGeneQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.IsAutoGeneQuestion = objvcc_ExamPaperStuBatchRelaEN.IsAutoGeneQuestion; //是否自动生成题目
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.IsCanMultiDo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.IsCanMultiDo = objvcc_ExamPaperStuBatchRelaEN.IsCanMultiDo; //是否可以做多次
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.QuestionNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.QuestionNum = objvcc_ExamPaperStuBatchRelaEN.QuestionNum; //题目数
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.IdStudentInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.IdStudentInfo = objvcc_ExamPaperStuBatchRelaEN.IdStudentInfo; //学生流水号
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.StuID, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.StuID = objvcc_ExamPaperStuBatchRelaEN.StuID == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.StuID; //学号
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.StuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.StuName = objvcc_ExamPaperStuBatchRelaEN.StuName == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.StuName; //姓名
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.SexDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.SexDesc = objvcc_ExamPaperStuBatchRelaEN.SexDesc == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.SexDesc; //性别名称
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.IdXzCollege = objvcc_ExamPaperStuBatchRelaEN.IdXzCollege == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.CollegeName = objvcc_ExamPaperStuBatchRelaEN.CollegeName == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.CollegeNameA = objvcc_ExamPaperStuBatchRelaEN.CollegeNameA == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.IdXzMajor = objvcc_ExamPaperStuBatchRelaEN.IdXzMajor == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.MajorID, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.MajorID = objvcc_ExamPaperStuBatchRelaEN.MajorID == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.MajorID; //专业ID
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.MajorName = objvcc_ExamPaperStuBatchRelaEN.MajorName == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.IdGradeBase = objvcc_ExamPaperStuBatchRelaEN.IdGradeBase == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.GradeBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.GradeBaseName = objvcc_ExamPaperStuBatchRelaEN.GradeBaseName == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.GradeBaseName; //年级名称
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.BatchTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.BatchTime = objvcc_ExamPaperStuBatchRelaEN.BatchTime == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.BatchTime; //批次
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = objvcc_ExamPaperStuBatchRelaEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.CurrEduClsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.CurrEduClsId = objvcc_ExamPaperStuBatchRelaEN.CurrEduClsId == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.CurrEduClsId; //教学班Id
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.EduClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.EduClsName = objvcc_ExamPaperStuBatchRelaEN.EduClsName; //教学班名
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.Scores, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.Scores = objvcc_ExamPaperStuBatchRelaEN.Scores; //分值
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.IsSave, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.IsSave = objvcc_ExamPaperStuBatchRelaEN.IsSave; //是否保存
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.IsSubmit = objvcc_ExamPaperStuBatchRelaEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.RealFinishDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.RealFinishDate = objvcc_ExamPaperStuBatchRelaEN.RealFinishDate == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.RealFinishDate; //实际完成日期
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.OperateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.OperateTime = objvcc_ExamPaperStuBatchRelaEN.OperateTime == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.OperateTime; //操作时间
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.IsMarking, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.IsMarking = objvcc_ExamPaperStuBatchRelaEN.IsMarking; //是否批阅
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.MarkerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.MarkerId = objvcc_ExamPaperStuBatchRelaEN.MarkerId == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.MarkerId; //打分者
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.MarkDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.MarkDate = objvcc_ExamPaperStuBatchRelaEN.MarkDate == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.MarkDate; //打分日期
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.AnswerIP, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.AnswerIP = objvcc_ExamPaperStuBatchRelaEN.AnswerIP == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.AnswerIP; //回答IP
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.AnswerDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.AnswerDate = objvcc_ExamPaperStuBatchRelaEN.AnswerDate == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.AnswerDate; //回答日期
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.AnswerTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.AnswerTime = objvcc_ExamPaperStuBatchRelaEN.AnswerTime == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.AnswerTime; //回答时间
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.TotalGetScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.TotalGetScore = objvcc_ExamPaperStuBatchRelaEN.TotalGetScore; //考生获取总分
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.UpdDate = objvcc_ExamPaperStuBatchRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.UpdUserId = objvcc_ExamPaperStuBatchRelaEN.UpdUserId == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.Memo = objvcc_ExamPaperStuBatchRelaEN.Memo == "[null]" ? null :  objvcc_ExamPaperStuBatchRelaEN.Memo; //备注
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.NoSubmitQuesNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.NoSubmitQuesNum = objvcc_ExamPaperStuBatchRelaEN.NoSubmitQuesNum; //未提交题数
}
if (arrFldSet.Contains(convcc_ExamPaperStuBatchRela.SubmitQuesNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuBatchRelaEN.SubmitQuesNum = objvcc_ExamPaperStuBatchRelaEN.SubmitQuesNum; //提交题数
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
 /// <param name = "objvcc_ExamPaperStuBatchRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN)
{
try
{
if (objvcc_ExamPaperStuBatchRelaEN.CourseExamPaperId == "[null]") objvcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = null; //考卷流水号
if (objvcc_ExamPaperStuBatchRelaEN.CourseId == "[null]") objvcc_ExamPaperStuBatchRelaEN.CourseId = null; //课程Id
if (objvcc_ExamPaperStuBatchRelaEN.CourseName == "[null]") objvcc_ExamPaperStuBatchRelaEN.CourseName = null; //课程名称
if (objvcc_ExamPaperStuBatchRelaEN.ExamPaperName == "[null]") objvcc_ExamPaperStuBatchRelaEN.ExamPaperName = null; //考卷名称
if (objvcc_ExamPaperStuBatchRelaEN.PaperDispModeName == "[null]") objvcc_ExamPaperStuBatchRelaEN.PaperDispModeName = null; //试卷显示模式名称
if (objvcc_ExamPaperStuBatchRelaEN.ExamCreateTime == "[null]") objvcc_ExamPaperStuBatchRelaEN.ExamCreateTime = null; //考卷建立时间
if (objvcc_ExamPaperStuBatchRelaEN.UserName == "[null]") objvcc_ExamPaperStuBatchRelaEN.UserName = null; //用户名
if (objvcc_ExamPaperStuBatchRelaEN.ChapterId == "[null]") objvcc_ExamPaperStuBatchRelaEN.ChapterId = null; //章Id
if (objvcc_ExamPaperStuBatchRelaEN.SectionId == "[null]") objvcc_ExamPaperStuBatchRelaEN.SectionId = null; //节Id
if (objvcc_ExamPaperStuBatchRelaEN.ChapterName == "[null]") objvcc_ExamPaperStuBatchRelaEN.ChapterName = null; //章名
if (objvcc_ExamPaperStuBatchRelaEN.SectionName == "[null]") objvcc_ExamPaperStuBatchRelaEN.SectionName = null; //节名
if (objvcc_ExamPaperStuBatchRelaEN.ChapterNameSim == "[null]") objvcc_ExamPaperStuBatchRelaEN.ChapterNameSim = null; //章名简称
if (objvcc_ExamPaperStuBatchRelaEN.SectionNameSim == "[null]") objvcc_ExamPaperStuBatchRelaEN.SectionNameSim = null; //节名简称
if (objvcc_ExamPaperStuBatchRelaEN.StuID == "[null]") objvcc_ExamPaperStuBatchRelaEN.StuID = null; //学号
if (objvcc_ExamPaperStuBatchRelaEN.StuName == "[null]") objvcc_ExamPaperStuBatchRelaEN.StuName = null; //姓名
if (objvcc_ExamPaperStuBatchRelaEN.SexDesc == "[null]") objvcc_ExamPaperStuBatchRelaEN.SexDesc = null; //性别名称
if (objvcc_ExamPaperStuBatchRelaEN.IdXzCollege == "[null]") objvcc_ExamPaperStuBatchRelaEN.IdXzCollege = null; //学院流水号
if (objvcc_ExamPaperStuBatchRelaEN.CollegeName == "[null]") objvcc_ExamPaperStuBatchRelaEN.CollegeName = null; //学院名称
if (objvcc_ExamPaperStuBatchRelaEN.CollegeNameA == "[null]") objvcc_ExamPaperStuBatchRelaEN.CollegeNameA = null; //学院名称简写
if (objvcc_ExamPaperStuBatchRelaEN.IdXzMajor == "[null]") objvcc_ExamPaperStuBatchRelaEN.IdXzMajor = null; //专业流水号
if (objvcc_ExamPaperStuBatchRelaEN.MajorID == "[null]") objvcc_ExamPaperStuBatchRelaEN.MajorID = null; //专业ID
if (objvcc_ExamPaperStuBatchRelaEN.MajorName == "[null]") objvcc_ExamPaperStuBatchRelaEN.MajorName = null; //专业名称
if (objvcc_ExamPaperStuBatchRelaEN.IdGradeBase == "[null]") objvcc_ExamPaperStuBatchRelaEN.IdGradeBase = null; //年级流水号
if (objvcc_ExamPaperStuBatchRelaEN.GradeBaseName == "[null]") objvcc_ExamPaperStuBatchRelaEN.GradeBaseName = null; //年级名称
if (objvcc_ExamPaperStuBatchRelaEN.BatchTime == "[null]") objvcc_ExamPaperStuBatchRelaEN.BatchTime = null; //批次
if (objvcc_ExamPaperStuBatchRelaEN.CurrEduClsId == "[null]") objvcc_ExamPaperStuBatchRelaEN.CurrEduClsId = null; //教学班Id
if (objvcc_ExamPaperStuBatchRelaEN.RealFinishDate == "[null]") objvcc_ExamPaperStuBatchRelaEN.RealFinishDate = null; //实际完成日期
if (objvcc_ExamPaperStuBatchRelaEN.OperateTime == "[null]") objvcc_ExamPaperStuBatchRelaEN.OperateTime = null; //操作时间
if (objvcc_ExamPaperStuBatchRelaEN.MarkerId == "[null]") objvcc_ExamPaperStuBatchRelaEN.MarkerId = null; //打分者
if (objvcc_ExamPaperStuBatchRelaEN.MarkDate == "[null]") objvcc_ExamPaperStuBatchRelaEN.MarkDate = null; //打分日期
if (objvcc_ExamPaperStuBatchRelaEN.AnswerIP == "[null]") objvcc_ExamPaperStuBatchRelaEN.AnswerIP = null; //回答IP
if (objvcc_ExamPaperStuBatchRelaEN.AnswerDate == "[null]") objvcc_ExamPaperStuBatchRelaEN.AnswerDate = null; //回答日期
if (objvcc_ExamPaperStuBatchRelaEN.AnswerTime == "[null]") objvcc_ExamPaperStuBatchRelaEN.AnswerTime = null; //回答时间
if (objvcc_ExamPaperStuBatchRelaEN.UpdUserId == "[null]") objvcc_ExamPaperStuBatchRelaEN.UpdUserId = null; //修改用户Id
if (objvcc_ExamPaperStuBatchRelaEN.Memo == "[null]") objvcc_ExamPaperStuBatchRelaEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaEN)
{
 vcc_ExamPaperStuBatchRelaDA.CheckProperty4Condition(objvcc_ExamPaperStuBatchRelaEN);
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
if (clsCurrEduClsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsBL没有刷新缓存机制(clsCurrEduClsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExamPaperStuBatchRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamPaperStuBatchRelaBL没有刷新缓存机制(clscc_ExamPaperStuBatchRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorBL没有刷新缓存机制(clsXzMajorBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseExamPaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseExamPaperBL没有刷新缓存机制(clscc_CourseExamPaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_PaperDispModeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_PaperDispModeBL没有刷新缓存机制(clscc_PaperDispModeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExamPaperTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamPaperTypeBL没有刷新缓存机制(clscc_ExamPaperTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzUniZoneBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneBL没有刷新缓存机制(clsXzUniZoneBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexBL没有刷新缓存机制(clsSexBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicBL没有刷新缓存机制(clsRsEthnicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsBL没有刷新缓存机制(clsRsPoliticsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseBL没有刷新缓存机制(clsXzGradeBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudentInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfoBL没有刷新缓存机制(clsStudentInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStuTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStuTypeBL没有刷新缓存机制(clsRsStuTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterBL没有刷新缓存机制(clscc_CourseChapterBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsBL没有刷新缓存机制(clsXzAdminClsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsTypeBL没有刷新缓存机制(clsXzAdminClsTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_ThemesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesBL没有刷新缓存机制(clscc_ThemesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelBL没有刷新缓存机制(clsStudyLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeBL没有刷新缓存机制(clscc_CourseIsLikeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdPaperStuBatch");
//if (arrvcc_ExamPaperStuBatchRelaObjLstCache == null)
//{
//arrvcc_ExamPaperStuBatchRelaObjLstCache = vcc_ExamPaperStuBatchRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdPaperStuBatch">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_ExamPaperStuBatchRelaEN GetObjByIdPaperStuBatchCache(string strIdPaperStuBatch, string strIdCurrEduCls)
{

if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
  var strMsg = string.Format("参数:[strIdCurrEduCls]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strIdCurrEduCls.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strIdCurrEduCls]的长度:[{0}]不正确!(In {1})", strIdCurrEduCls.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvcc_ExamPaperStuBatchRelaEN._CurrTabName, strIdCurrEduCls);
List<clsvcc_ExamPaperStuBatchRelaEN> arrvcc_ExamPaperStuBatchRelaObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvcc_ExamPaperStuBatchRelaEN> arrvcc_ExamPaperStuBatchRelaObjLst_Sel =
arrvcc_ExamPaperStuBatchRelaObjLstCache
.Where(x=> x.IdPaperStuBatch == strIdPaperStuBatch 
);
if (arrvcc_ExamPaperStuBatchRelaObjLst_Sel.Count() == 0)
{
   clsvcc_ExamPaperStuBatchRelaEN obj = clsvcc_ExamPaperStuBatchRelaBL.GetObjByIdPaperStuBatch(strIdPaperStuBatch);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strIdPaperStuBatch, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvcc_ExamPaperStuBatchRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_ExamPaperStuBatchRelaEN> GetAllvcc_ExamPaperStuBatchRelaObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvcc_ExamPaperStuBatchRelaEN> arrvcc_ExamPaperStuBatchRelaObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvcc_ExamPaperStuBatchRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_ExamPaperStuBatchRelaEN> GetObjLstCache(string strIdCurrEduCls)
{

if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
  var strMsg = string.Format("参数:[strIdCurrEduCls]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strIdCurrEduCls.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strIdCurrEduCls]的长度:[{0}]不正确!(In {1})", strIdCurrEduCls.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvcc_ExamPaperStuBatchRelaEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvcc_ExamPaperStuBatchRelaEN> arrvcc_ExamPaperStuBatchRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvcc_ExamPaperStuBatchRelaObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strIdCurrEduCls = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvcc_ExamPaperStuBatchRelaEN._CurrTabName, strIdCurrEduCls);
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-08-24
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strIdPaperStuBatch, string strIdCurrEduCls)
{
if (strInFldName != convcc_ExamPaperStuBatchRela.IdPaperStuBatch)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcc_ExamPaperStuBatchRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcc_ExamPaperStuBatchRela.AttributeName));
throw new Exception(strMsg);
}
var objvcc_ExamPaperStuBatchRela = clsvcc_ExamPaperStuBatchRelaBL.GetObjByIdPaperStuBatchCache(strIdPaperStuBatch, strIdCurrEduCls);
if (objvcc_ExamPaperStuBatchRela == null) return "";
return objvcc_ExamPaperStuBatchRela[strOutFldName].ToString();
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
int intRecCount = clsvcc_ExamPaperStuBatchRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvcc_ExamPaperStuBatchRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcc_ExamPaperStuBatchRelaDA.GetRecCount();
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
int intRecCount = clsvcc_ExamPaperStuBatchRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuBatchRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcc_ExamPaperStuBatchRelaEN objvcc_ExamPaperStuBatchRelaCond)
{
 string strIdCurrEduCls = objvcc_ExamPaperStuBatchRelaCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvcc_ExamPaperStuBatchRelaBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvcc_ExamPaperStuBatchRelaEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvcc_ExamPaperStuBatchRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_ExamPaperStuBatchRela.AttributeName)
{
if (objvcc_ExamPaperStuBatchRelaCond.IsUpdated(strFldName) == false) continue;
if (objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_ExamPaperStuBatchRelaCond[strFldName].ToString());
}
else
{
if (objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_ExamPaperStuBatchRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_ExamPaperStuBatchRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_ExamPaperStuBatchRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_ExamPaperStuBatchRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_ExamPaperStuBatchRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_ExamPaperStuBatchRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_ExamPaperStuBatchRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_ExamPaperStuBatchRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_ExamPaperStuBatchRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_ExamPaperStuBatchRelaCond[strFldName]));
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
 List<string> arrList = clsvcc_ExamPaperStuBatchRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcc_ExamPaperStuBatchRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcc_ExamPaperStuBatchRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}