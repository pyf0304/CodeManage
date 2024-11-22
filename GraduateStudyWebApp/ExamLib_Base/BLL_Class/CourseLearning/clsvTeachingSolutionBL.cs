
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachingSolutionBL
 表名:vTeachingSolution(01120138)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:25:37
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
public static class  clsvTeachingSolutionBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTeachingSolutionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachingSolutionEN GetObj(this K_TeachingSolutionId_vTeachingSolution myKey)
{
clsvTeachingSolutionEN objvTeachingSolutionEN = clsvTeachingSolutionBL.vTeachingSolutionDA.GetObjByTeachingSolutionId(myKey.Value);
return objvTeachingSolutionEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingSolutionEN SetTeachingSolutionId(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strTeachingSolutionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingSolutionId, 8, convTeachingSolution.TeachingSolutionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingSolutionId, 8, convTeachingSolution.TeachingSolutionId);
}
objvTeachingSolutionEN.TeachingSolutionId = strTeachingSolutionId; //教学方案Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingSolutionEN.dicFldComparisonOp.ContainsKey(convTeachingSolution.TeachingSolutionId) == false)
{
objvTeachingSolutionEN.dicFldComparisonOp.Add(convTeachingSolution.TeachingSolutionId, strComparisonOp);
}
else
{
objvTeachingSolutionEN.dicFldComparisonOp[convTeachingSolution.TeachingSolutionId] = strComparisonOp;
}
}
return objvTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingSolutionEN SetTeachingSolutionName(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strTeachingSolutionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingSolutionName, convTeachingSolution.TeachingSolutionName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingSolutionName, 100, convTeachingSolution.TeachingSolutionName);
}
objvTeachingSolutionEN.TeachingSolutionName = strTeachingSolutionName; //教学方案名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingSolutionEN.dicFldComparisonOp.ContainsKey(convTeachingSolution.TeachingSolutionName) == false)
{
objvTeachingSolutionEN.dicFldComparisonOp.Add(convTeachingSolution.TeachingSolutionName, strComparisonOp);
}
else
{
objvTeachingSolutionEN.dicFldComparisonOp[convTeachingSolution.TeachingSolutionName] = strComparisonOp;
}
}
return objvTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingSolutionEN SetCourseId(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convTeachingSolution.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convTeachingSolution.CourseId);
}
objvTeachingSolutionEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingSolutionEN.dicFldComparisonOp.ContainsKey(convTeachingSolution.CourseId) == false)
{
objvTeachingSolutionEN.dicFldComparisonOp.Add(convTeachingSolution.CourseId, strComparisonOp);
}
else
{
objvTeachingSolutionEN.dicFldComparisonOp[convTeachingSolution.CourseId] = strComparisonOp;
}
}
return objvTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingSolutionEN SetCourseCode(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convTeachingSolution.CourseCode);
}
objvTeachingSolutionEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingSolutionEN.dicFldComparisonOp.ContainsKey(convTeachingSolution.CourseCode) == false)
{
objvTeachingSolutionEN.dicFldComparisonOp.Add(convTeachingSolution.CourseCode, strComparisonOp);
}
else
{
objvTeachingSolutionEN.dicFldComparisonOp[convTeachingSolution.CourseCode] = strComparisonOp;
}
}
return objvTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingSolutionEN SetCourseDescription(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strCourseDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseDescription, 8000, convTeachingSolution.CourseDescription);
}
objvTeachingSolutionEN.CourseDescription = strCourseDescription; //课程描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingSolutionEN.dicFldComparisonOp.ContainsKey(convTeachingSolution.CourseDescription) == false)
{
objvTeachingSolutionEN.dicFldComparisonOp.Add(convTeachingSolution.CourseDescription, strComparisonOp);
}
else
{
objvTeachingSolutionEN.dicFldComparisonOp[convTeachingSolution.CourseDescription] = strComparisonOp;
}
}
return objvTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingSolutionEN SetIdTeacher(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strIdTeacher, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeacher, convTeachingSolution.IdTeacher);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeacher, 8, convTeachingSolution.IdTeacher);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeacher, 8, convTeachingSolution.IdTeacher);
}
objvTeachingSolutionEN.IdTeacher = strIdTeacher; //教师流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingSolutionEN.dicFldComparisonOp.ContainsKey(convTeachingSolution.IdTeacher) == false)
{
objvTeachingSolutionEN.dicFldComparisonOp.Add(convTeachingSolution.IdTeacher, strComparisonOp);
}
else
{
objvTeachingSolutionEN.dicFldComparisonOp[convTeachingSolution.IdTeacher] = strComparisonOp;
}
}
return objvTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingSolutionEN SetTeacherId(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strTeacherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherId, convTeachingSolution.TeacherId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeacherId, 12, convTeachingSolution.TeacherId);
}
objvTeachingSolutionEN.TeacherId = strTeacherId; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingSolutionEN.dicFldComparisonOp.ContainsKey(convTeachingSolution.TeacherId) == false)
{
objvTeachingSolutionEN.dicFldComparisonOp.Add(convTeachingSolution.TeacherId, strComparisonOp);
}
else
{
objvTeachingSolutionEN.dicFldComparisonOp[convTeachingSolution.TeacherId] = strComparisonOp;
}
}
return objvTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingSolutionEN SetTeacherName(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strTeacherName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherName, convTeachingSolution.TeacherName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeacherName, 50, convTeachingSolution.TeacherName);
}
objvTeachingSolutionEN.TeacherName = strTeacherName; //教师姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingSolutionEN.dicFldComparisonOp.ContainsKey(convTeachingSolution.TeacherName) == false)
{
objvTeachingSolutionEN.dicFldComparisonOp.Add(convTeachingSolution.TeacherName, strComparisonOp);
}
else
{
objvTeachingSolutionEN.dicFldComparisonOp[convTeachingSolution.TeacherName] = strComparisonOp;
}
}
return objvTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingSolutionEN SetIdSex(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strIdSex, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdSex, convTeachingSolution.IdSex);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSex, 4, convTeachingSolution.IdSex);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSex, 4, convTeachingSolution.IdSex);
}
objvTeachingSolutionEN.IdSex = strIdSex; //性别流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingSolutionEN.dicFldComparisonOp.ContainsKey(convTeachingSolution.IdSex) == false)
{
objvTeachingSolutionEN.dicFldComparisonOp.Add(convTeachingSolution.IdSex, strComparisonOp);
}
else
{
objvTeachingSolutionEN.dicFldComparisonOp[convTeachingSolution.IdSex] = strComparisonOp;
}
}
return objvTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingSolutionEN SetSexDesc(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strSexDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convTeachingSolution.SexDesc);
}
objvTeachingSolutionEN.SexDesc = strSexDesc; //性别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingSolutionEN.dicFldComparisonOp.ContainsKey(convTeachingSolution.SexDesc) == false)
{
objvTeachingSolutionEN.dicFldComparisonOp.Add(convTeachingSolution.SexDesc, strComparisonOp);
}
else
{
objvTeachingSolutionEN.dicFldComparisonOp[convTeachingSolution.SexDesc] = strComparisonOp;
}
}
return objvTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingSolutionEN SetCollegeName(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convTeachingSolution.CollegeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convTeachingSolution.CollegeName);
}
objvTeachingSolutionEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingSolutionEN.dicFldComparisonOp.ContainsKey(convTeachingSolution.CollegeName) == false)
{
objvTeachingSolutionEN.dicFldComparisonOp.Add(convTeachingSolution.CollegeName, strComparisonOp);
}
else
{
objvTeachingSolutionEN.dicFldComparisonOp[convTeachingSolution.CollegeName] = strComparisonOp;
}
}
return objvTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingSolutionEN SetIdProfGrade(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strIdProfGrade, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdProfGrade, convTeachingSolution.IdProfGrade);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdProfGrade, 4, convTeachingSolution.IdProfGrade);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdProfGrade, 4, convTeachingSolution.IdProfGrade);
}
objvTeachingSolutionEN.IdProfGrade = strIdProfGrade; //专业职称流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingSolutionEN.dicFldComparisonOp.ContainsKey(convTeachingSolution.IdProfGrade) == false)
{
objvTeachingSolutionEN.dicFldComparisonOp.Add(convTeachingSolution.IdProfGrade, strComparisonOp);
}
else
{
objvTeachingSolutionEN.dicFldComparisonOp[convTeachingSolution.IdProfGrade] = strComparisonOp;
}
}
return objvTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingSolutionEN SetProfenssionalGradeName(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strProfenssionalGradeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProfenssionalGradeName, convTeachingSolution.ProfenssionalGradeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProfenssionalGradeName, 30, convTeachingSolution.ProfenssionalGradeName);
}
objvTeachingSolutionEN.ProfenssionalGradeName = strProfenssionalGradeName; //专业职称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingSolutionEN.dicFldComparisonOp.ContainsKey(convTeachingSolution.ProfenssionalGradeName) == false)
{
objvTeachingSolutionEN.dicFldComparisonOp.Add(convTeachingSolution.ProfenssionalGradeName, strComparisonOp);
}
else
{
objvTeachingSolutionEN.dicFldComparisonOp[convTeachingSolution.ProfenssionalGradeName] = strComparisonOp;
}
}
return objvTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingSolutionEN SetCollegeId(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strCollegeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeId, convTeachingSolution.CollegeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeId, 4, convTeachingSolution.CollegeId);
}
objvTeachingSolutionEN.CollegeId = strCollegeId; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingSolutionEN.dicFldComparisonOp.ContainsKey(convTeachingSolution.CollegeId) == false)
{
objvTeachingSolutionEN.dicFldComparisonOp.Add(convTeachingSolution.CollegeId, strComparisonOp);
}
else
{
objvTeachingSolutionEN.dicFldComparisonOp[convTeachingSolution.CollegeId] = strComparisonOp;
}
}
return objvTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingSolutionEN SetIdXzCollege(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convTeachingSolution.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convTeachingSolution.IdXzCollege);
}
objvTeachingSolutionEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingSolutionEN.dicFldComparisonOp.ContainsKey(convTeachingSolution.IdXzCollege) == false)
{
objvTeachingSolutionEN.dicFldComparisonOp.Add(convTeachingSolution.IdXzCollege, strComparisonOp);
}
else
{
objvTeachingSolutionEN.dicFldComparisonOp[convTeachingSolution.IdXzCollege] = strComparisonOp;
}
}
return objvTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingSolutionEN SetIdXzMajor(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strIdXzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzMajor, convTeachingSolution.IdXzMajor);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convTeachingSolution.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convTeachingSolution.IdXzMajor);
}
objvTeachingSolutionEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingSolutionEN.dicFldComparisonOp.ContainsKey(convTeachingSolution.IdXzMajor) == false)
{
objvTeachingSolutionEN.dicFldComparisonOp.Add(convTeachingSolution.IdXzMajor, strComparisonOp);
}
else
{
objvTeachingSolutionEN.dicFldComparisonOp[convTeachingSolution.IdXzMajor] = strComparisonOp;
}
}
return objvTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingSolutionEN SetBriefIntroduction(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strBriefIntroduction, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBriefIntroduction, 8000, convTeachingSolution.BriefIntroduction);
}
objvTeachingSolutionEN.BriefIntroduction = strBriefIntroduction; //简介
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingSolutionEN.dicFldComparisonOp.ContainsKey(convTeachingSolution.BriefIntroduction) == false)
{
objvTeachingSolutionEN.dicFldComparisonOp.Add(convTeachingSolution.BriefIntroduction, strComparisonOp);
}
else
{
objvTeachingSolutionEN.dicFldComparisonOp[convTeachingSolution.BriefIntroduction] = strComparisonOp;
}
}
return objvTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingSolutionEN SetUpdDate(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convTeachingSolution.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convTeachingSolution.UpdDate);
}
objvTeachingSolutionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingSolutionEN.dicFldComparisonOp.ContainsKey(convTeachingSolution.UpdDate) == false)
{
objvTeachingSolutionEN.dicFldComparisonOp.Add(convTeachingSolution.UpdDate, strComparisonOp);
}
else
{
objvTeachingSolutionEN.dicFldComparisonOp[convTeachingSolution.UpdDate] = strComparisonOp;
}
}
return objvTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingSolutionEN SetUpdUser(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convTeachingSolution.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convTeachingSolution.UpdUser);
}
objvTeachingSolutionEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingSolutionEN.dicFldComparisonOp.ContainsKey(convTeachingSolution.UpdUser) == false)
{
objvTeachingSolutionEN.dicFldComparisonOp.Add(convTeachingSolution.UpdUser, strComparisonOp);
}
else
{
objvTeachingSolutionEN.dicFldComparisonOp[convTeachingSolution.UpdUser] = strComparisonOp;
}
}
return objvTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingSolutionEN SetMemo(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTeachingSolution.Memo);
}
objvTeachingSolutionEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingSolutionEN.dicFldComparisonOp.ContainsKey(convTeachingSolution.Memo) == false)
{
objvTeachingSolutionEN.dicFldComparisonOp.Add(convTeachingSolution.Memo, strComparisonOp);
}
else
{
objvTeachingSolutionEN.dicFldComparisonOp[convTeachingSolution.Memo] = strComparisonOp;
}
}
return objvTeachingSolutionEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvTeachingSolutionENS">源对象</param>
 /// <param name = "objvTeachingSolutionENT">目标对象</param>
 public static void CopyTo(this clsvTeachingSolutionEN objvTeachingSolutionENS, clsvTeachingSolutionEN objvTeachingSolutionENT)
{
try
{
objvTeachingSolutionENT.TeachingSolutionId = objvTeachingSolutionENS.TeachingSolutionId; //教学方案Id
objvTeachingSolutionENT.TeachingSolutionName = objvTeachingSolutionENS.TeachingSolutionName; //教学方案名称
objvTeachingSolutionENT.CourseId = objvTeachingSolutionENS.CourseId; //课程Id
objvTeachingSolutionENT.CourseCode = objvTeachingSolutionENS.CourseCode; //课程代码
objvTeachingSolutionENT.CourseDescription = objvTeachingSolutionENS.CourseDescription; //课程描述
objvTeachingSolutionENT.IdTeacher = objvTeachingSolutionENS.IdTeacher; //教师流水号
objvTeachingSolutionENT.TeacherId = objvTeachingSolutionENS.TeacherId; //教师工号
objvTeachingSolutionENT.TeacherName = objvTeachingSolutionENS.TeacherName; //教师姓名
objvTeachingSolutionENT.IdSex = objvTeachingSolutionENS.IdSex; //性别流水号
objvTeachingSolutionENT.SexDesc = objvTeachingSolutionENS.SexDesc; //性别名称
objvTeachingSolutionENT.CollegeName = objvTeachingSolutionENS.CollegeName; //学院名称
objvTeachingSolutionENT.IdProfGrade = objvTeachingSolutionENS.IdProfGrade; //专业职称流水号
objvTeachingSolutionENT.ProfenssionalGradeName = objvTeachingSolutionENS.ProfenssionalGradeName; //专业职称
objvTeachingSolutionENT.CollegeId = objvTeachingSolutionENS.CollegeId; //学院ID
objvTeachingSolutionENT.IdXzCollege = objvTeachingSolutionENS.IdXzCollege; //学院流水号
objvTeachingSolutionENT.IdXzMajor = objvTeachingSolutionENS.IdXzMajor; //专业流水号
objvTeachingSolutionENT.BriefIntroduction = objvTeachingSolutionENS.BriefIntroduction; //简介
objvTeachingSolutionENT.UpdDate = objvTeachingSolutionENS.UpdDate; //修改日期
objvTeachingSolutionENT.UpdUser = objvTeachingSolutionENS.UpdUser; //修改人
objvTeachingSolutionENT.Memo = objvTeachingSolutionENS.Memo; //备注
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
 /// <param name = "objvTeachingSolutionENS">源对象</param>
 /// <returns>目标对象=>clsvTeachingSolutionEN:objvTeachingSolutionENT</returns>
 public static clsvTeachingSolutionEN CopyTo(this clsvTeachingSolutionEN objvTeachingSolutionENS)
{
try
{
 clsvTeachingSolutionEN objvTeachingSolutionENT = new clsvTeachingSolutionEN()
{
TeachingSolutionId = objvTeachingSolutionENS.TeachingSolutionId, //教学方案Id
TeachingSolutionName = objvTeachingSolutionENS.TeachingSolutionName, //教学方案名称
CourseId = objvTeachingSolutionENS.CourseId, //课程Id
CourseCode = objvTeachingSolutionENS.CourseCode, //课程代码
CourseDescription = objvTeachingSolutionENS.CourseDescription, //课程描述
IdTeacher = objvTeachingSolutionENS.IdTeacher, //教师流水号
TeacherId = objvTeachingSolutionENS.TeacherId, //教师工号
TeacherName = objvTeachingSolutionENS.TeacherName, //教师姓名
IdSex = objvTeachingSolutionENS.IdSex, //性别流水号
SexDesc = objvTeachingSolutionENS.SexDesc, //性别名称
CollegeName = objvTeachingSolutionENS.CollegeName, //学院名称
IdProfGrade = objvTeachingSolutionENS.IdProfGrade, //专业职称流水号
ProfenssionalGradeName = objvTeachingSolutionENS.ProfenssionalGradeName, //专业职称
CollegeId = objvTeachingSolutionENS.CollegeId, //学院ID
IdXzCollege = objvTeachingSolutionENS.IdXzCollege, //学院流水号
IdXzMajor = objvTeachingSolutionENS.IdXzMajor, //专业流水号
BriefIntroduction = objvTeachingSolutionENS.BriefIntroduction, //简介
UpdDate = objvTeachingSolutionENS.UpdDate, //修改日期
UpdUser = objvTeachingSolutionENS.UpdUser, //修改人
Memo = objvTeachingSolutionENS.Memo, //备注
};
 return objvTeachingSolutionENT;
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
public static void CheckProperty4Condition(this clsvTeachingSolutionEN objvTeachingSolutionEN)
{
 clsvTeachingSolutionBL.vTeachingSolutionDA.CheckProperty4Condition(objvTeachingSolutionEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTeachingSolutionEN objvTeachingSolutionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTeachingSolutionCond.IsUpdated(convTeachingSolution.TeachingSolutionId) == true)
{
string strComparisonOpTeachingSolutionId = objvTeachingSolutionCond.dicFldComparisonOp[convTeachingSolution.TeachingSolutionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.TeachingSolutionId, objvTeachingSolutionCond.TeachingSolutionId, strComparisonOpTeachingSolutionId);
}
if (objvTeachingSolutionCond.IsUpdated(convTeachingSolution.TeachingSolutionName) == true)
{
string strComparisonOpTeachingSolutionName = objvTeachingSolutionCond.dicFldComparisonOp[convTeachingSolution.TeachingSolutionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.TeachingSolutionName, objvTeachingSolutionCond.TeachingSolutionName, strComparisonOpTeachingSolutionName);
}
if (objvTeachingSolutionCond.IsUpdated(convTeachingSolution.CourseId) == true)
{
string strComparisonOpCourseId = objvTeachingSolutionCond.dicFldComparisonOp[convTeachingSolution.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.CourseId, objvTeachingSolutionCond.CourseId, strComparisonOpCourseId);
}
if (objvTeachingSolutionCond.IsUpdated(convTeachingSolution.CourseCode) == true)
{
string strComparisonOpCourseCode = objvTeachingSolutionCond.dicFldComparisonOp[convTeachingSolution.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.CourseCode, objvTeachingSolutionCond.CourseCode, strComparisonOpCourseCode);
}
if (objvTeachingSolutionCond.IsUpdated(convTeachingSolution.CourseDescription) == true)
{
string strComparisonOpCourseDescription = objvTeachingSolutionCond.dicFldComparisonOp[convTeachingSolution.CourseDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.CourseDescription, objvTeachingSolutionCond.CourseDescription, strComparisonOpCourseDescription);
}
if (objvTeachingSolutionCond.IsUpdated(convTeachingSolution.IdTeacher) == true)
{
string strComparisonOpIdTeacher = objvTeachingSolutionCond.dicFldComparisonOp[convTeachingSolution.IdTeacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.IdTeacher, objvTeachingSolutionCond.IdTeacher, strComparisonOpIdTeacher);
}
if (objvTeachingSolutionCond.IsUpdated(convTeachingSolution.TeacherId) == true)
{
string strComparisonOpTeacherId = objvTeachingSolutionCond.dicFldComparisonOp[convTeachingSolution.TeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.TeacherId, objvTeachingSolutionCond.TeacherId, strComparisonOpTeacherId);
}
if (objvTeachingSolutionCond.IsUpdated(convTeachingSolution.TeacherName) == true)
{
string strComparisonOpTeacherName = objvTeachingSolutionCond.dicFldComparisonOp[convTeachingSolution.TeacherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.TeacherName, objvTeachingSolutionCond.TeacherName, strComparisonOpTeacherName);
}
if (objvTeachingSolutionCond.IsUpdated(convTeachingSolution.IdSex) == true)
{
string strComparisonOpIdSex = objvTeachingSolutionCond.dicFldComparisonOp[convTeachingSolution.IdSex];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.IdSex, objvTeachingSolutionCond.IdSex, strComparisonOpIdSex);
}
if (objvTeachingSolutionCond.IsUpdated(convTeachingSolution.SexDesc) == true)
{
string strComparisonOpSexDesc = objvTeachingSolutionCond.dicFldComparisonOp[convTeachingSolution.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.SexDesc, objvTeachingSolutionCond.SexDesc, strComparisonOpSexDesc);
}
if (objvTeachingSolutionCond.IsUpdated(convTeachingSolution.CollegeName) == true)
{
string strComparisonOpCollegeName = objvTeachingSolutionCond.dicFldComparisonOp[convTeachingSolution.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.CollegeName, objvTeachingSolutionCond.CollegeName, strComparisonOpCollegeName);
}
if (objvTeachingSolutionCond.IsUpdated(convTeachingSolution.IdProfGrade) == true)
{
string strComparisonOpIdProfGrade = objvTeachingSolutionCond.dicFldComparisonOp[convTeachingSolution.IdProfGrade];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.IdProfGrade, objvTeachingSolutionCond.IdProfGrade, strComparisonOpIdProfGrade);
}
if (objvTeachingSolutionCond.IsUpdated(convTeachingSolution.ProfenssionalGradeName) == true)
{
string strComparisonOpProfenssionalGradeName = objvTeachingSolutionCond.dicFldComparisonOp[convTeachingSolution.ProfenssionalGradeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.ProfenssionalGradeName, objvTeachingSolutionCond.ProfenssionalGradeName, strComparisonOpProfenssionalGradeName);
}
if (objvTeachingSolutionCond.IsUpdated(convTeachingSolution.CollegeId) == true)
{
string strComparisonOpCollegeId = objvTeachingSolutionCond.dicFldComparisonOp[convTeachingSolution.CollegeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.CollegeId, objvTeachingSolutionCond.CollegeId, strComparisonOpCollegeId);
}
if (objvTeachingSolutionCond.IsUpdated(convTeachingSolution.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvTeachingSolutionCond.dicFldComparisonOp[convTeachingSolution.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.IdXzCollege, objvTeachingSolutionCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvTeachingSolutionCond.IsUpdated(convTeachingSolution.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvTeachingSolutionCond.dicFldComparisonOp[convTeachingSolution.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.IdXzMajor, objvTeachingSolutionCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvTeachingSolutionCond.IsUpdated(convTeachingSolution.BriefIntroduction) == true)
{
string strComparisonOpBriefIntroduction = objvTeachingSolutionCond.dicFldComparisonOp[convTeachingSolution.BriefIntroduction];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.BriefIntroduction, objvTeachingSolutionCond.BriefIntroduction, strComparisonOpBriefIntroduction);
}
if (objvTeachingSolutionCond.IsUpdated(convTeachingSolution.UpdDate) == true)
{
string strComparisonOpUpdDate = objvTeachingSolutionCond.dicFldComparisonOp[convTeachingSolution.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.UpdDate, objvTeachingSolutionCond.UpdDate, strComparisonOpUpdDate);
}
if (objvTeachingSolutionCond.IsUpdated(convTeachingSolution.UpdUser) == true)
{
string strComparisonOpUpdUser = objvTeachingSolutionCond.dicFldComparisonOp[convTeachingSolution.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.UpdUser, objvTeachingSolutionCond.UpdUser, strComparisonOpUpdUser);
}
if (objvTeachingSolutionCond.IsUpdated(convTeachingSolution.Memo) == true)
{
string strComparisonOpMemo = objvTeachingSolutionCond.dicFldComparisonOp[convTeachingSolution.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.Memo, objvTeachingSolutionCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vTeachingSolution
{
public virtual bool UpdRelaTabDate(string strTeachingSolutionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v教学方案(vTeachingSolution)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvTeachingSolutionBL
{
public static RelatedActions_vTeachingSolution relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvTeachingSolutionDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvTeachingSolutionDA vTeachingSolutionDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvTeachingSolutionDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvTeachingSolutionBL()
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
if (string.IsNullOrEmpty(clsvTeachingSolutionEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTeachingSolutionEN._ConnectString);
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
public static DataTable GetDataTable_vTeachingSolution(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vTeachingSolutionDA.GetDataTable_vTeachingSolution(strWhereCond);
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
objDT = vTeachingSolutionDA.GetDataTable(strWhereCond);
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
objDT = vTeachingSolutionDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vTeachingSolutionDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vTeachingSolutionDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vTeachingSolutionDA.GetDataTable_Top(objTopPara);
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
objDT = vTeachingSolutionDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vTeachingSolutionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vTeachingSolutionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTeachingSolutionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvTeachingSolutionEN> GetObjLstByTeachingSolutionIdLst(List<string> arrTeachingSolutionIdLst)
{
List<clsvTeachingSolutionEN> arrObjLst = new List<clsvTeachingSolutionEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTeachingSolutionIdLst, true);
 string strWhereCond = string.Format("TeachingSolutionId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingSolutionEN objvTeachingSolutionEN = new clsvTeachingSolutionEN();
try
{
objvTeachingSolutionEN.TeachingSolutionId = objRow[convTeachingSolution.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvTeachingSolutionEN.TeachingSolutionName = objRow[convTeachingSolution.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvTeachingSolutionEN.CourseId = objRow[convTeachingSolution.CourseId] == DBNull.Value ? null : objRow[convTeachingSolution.CourseId].ToString().Trim(); //课程Id
objvTeachingSolutionEN.CourseCode = objRow[convTeachingSolution.CourseCode] == DBNull.Value ? null : objRow[convTeachingSolution.CourseCode].ToString().Trim(); //课程代码
objvTeachingSolutionEN.CourseDescription = objRow[convTeachingSolution.CourseDescription] == DBNull.Value ? null : objRow[convTeachingSolution.CourseDescription].ToString().Trim(); //课程描述
objvTeachingSolutionEN.IdTeacher = objRow[convTeachingSolution.IdTeacher].ToString().Trim(); //教师流水号
objvTeachingSolutionEN.TeacherId = objRow[convTeachingSolution.TeacherId].ToString().Trim(); //教师工号
objvTeachingSolutionEN.TeacherName = objRow[convTeachingSolution.TeacherName].ToString().Trim(); //教师姓名
objvTeachingSolutionEN.IdSex = objRow[convTeachingSolution.IdSex].ToString().Trim(); //性别流水号
objvTeachingSolutionEN.SexDesc = objRow[convTeachingSolution.SexDesc] == DBNull.Value ? null : objRow[convTeachingSolution.SexDesc].ToString().Trim(); //性别名称
objvTeachingSolutionEN.CollegeName = objRow[convTeachingSolution.CollegeName].ToString().Trim(); //学院名称
objvTeachingSolutionEN.IdProfGrade = objRow[convTeachingSolution.IdProfGrade].ToString().Trim(); //专业职称流水号
objvTeachingSolutionEN.ProfenssionalGradeName = objRow[convTeachingSolution.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvTeachingSolutionEN.CollegeId = objRow[convTeachingSolution.CollegeId].ToString().Trim(); //学院ID
objvTeachingSolutionEN.IdXzCollege = objRow[convTeachingSolution.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingSolution.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingSolutionEN.IdXzMajor = objRow[convTeachingSolution.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingSolutionEN.BriefIntroduction = objRow[convTeachingSolution.BriefIntroduction] == DBNull.Value ? null : objRow[convTeachingSolution.BriefIntroduction].ToString().Trim(); //简介
objvTeachingSolutionEN.UpdDate = objRow[convTeachingSolution.UpdDate].ToString().Trim(); //修改日期
objvTeachingSolutionEN.UpdUser = objRow[convTeachingSolution.UpdUser].ToString().Trim(); //修改人
objvTeachingSolutionEN.Memo = objRow[convTeachingSolution.Memo] == DBNull.Value ? null : objRow[convTeachingSolution.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingSolutionEN.TeachingSolutionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingSolutionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTeachingSolutionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvTeachingSolutionEN> GetObjLstByTeachingSolutionIdLstCache(List<string> arrTeachingSolutionIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsvTeachingSolutionEN._CurrTabName, strCourseId);
List<clsvTeachingSolutionEN> arrvTeachingSolutionObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvTeachingSolutionEN> arrvTeachingSolutionObjLst_Sel =
arrvTeachingSolutionObjLstCache
.Where(x => arrTeachingSolutionIdLst.Contains(x.TeachingSolutionId));
return arrvTeachingSolutionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingSolutionEN> GetObjLst(string strWhereCond)
{
List<clsvTeachingSolutionEN> arrObjLst = new List<clsvTeachingSolutionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingSolutionEN objvTeachingSolutionEN = new clsvTeachingSolutionEN();
try
{
objvTeachingSolutionEN.TeachingSolutionId = objRow[convTeachingSolution.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvTeachingSolutionEN.TeachingSolutionName = objRow[convTeachingSolution.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvTeachingSolutionEN.CourseId = objRow[convTeachingSolution.CourseId] == DBNull.Value ? null : objRow[convTeachingSolution.CourseId].ToString().Trim(); //课程Id
objvTeachingSolutionEN.CourseCode = objRow[convTeachingSolution.CourseCode] == DBNull.Value ? null : objRow[convTeachingSolution.CourseCode].ToString().Trim(); //课程代码
objvTeachingSolutionEN.CourseDescription = objRow[convTeachingSolution.CourseDescription] == DBNull.Value ? null : objRow[convTeachingSolution.CourseDescription].ToString().Trim(); //课程描述
objvTeachingSolutionEN.IdTeacher = objRow[convTeachingSolution.IdTeacher].ToString().Trim(); //教师流水号
objvTeachingSolutionEN.TeacherId = objRow[convTeachingSolution.TeacherId].ToString().Trim(); //教师工号
objvTeachingSolutionEN.TeacherName = objRow[convTeachingSolution.TeacherName].ToString().Trim(); //教师姓名
objvTeachingSolutionEN.IdSex = objRow[convTeachingSolution.IdSex].ToString().Trim(); //性别流水号
objvTeachingSolutionEN.SexDesc = objRow[convTeachingSolution.SexDesc] == DBNull.Value ? null : objRow[convTeachingSolution.SexDesc].ToString().Trim(); //性别名称
objvTeachingSolutionEN.CollegeName = objRow[convTeachingSolution.CollegeName].ToString().Trim(); //学院名称
objvTeachingSolutionEN.IdProfGrade = objRow[convTeachingSolution.IdProfGrade].ToString().Trim(); //专业职称流水号
objvTeachingSolutionEN.ProfenssionalGradeName = objRow[convTeachingSolution.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvTeachingSolutionEN.CollegeId = objRow[convTeachingSolution.CollegeId].ToString().Trim(); //学院ID
objvTeachingSolutionEN.IdXzCollege = objRow[convTeachingSolution.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingSolution.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingSolutionEN.IdXzMajor = objRow[convTeachingSolution.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingSolutionEN.BriefIntroduction = objRow[convTeachingSolution.BriefIntroduction] == DBNull.Value ? null : objRow[convTeachingSolution.BriefIntroduction].ToString().Trim(); //简介
objvTeachingSolutionEN.UpdDate = objRow[convTeachingSolution.UpdDate].ToString().Trim(); //修改日期
objvTeachingSolutionEN.UpdUser = objRow[convTeachingSolution.UpdUser].ToString().Trim(); //修改人
objvTeachingSolutionEN.Memo = objRow[convTeachingSolution.Memo] == DBNull.Value ? null : objRow[convTeachingSolution.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingSolutionEN.TeachingSolutionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingSolutionEN);
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
public static List<clsvTeachingSolutionEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvTeachingSolutionEN> arrObjLst = new List<clsvTeachingSolutionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingSolutionEN objvTeachingSolutionEN = new clsvTeachingSolutionEN();
try
{
objvTeachingSolutionEN.TeachingSolutionId = objRow[convTeachingSolution.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvTeachingSolutionEN.TeachingSolutionName = objRow[convTeachingSolution.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvTeachingSolutionEN.CourseId = objRow[convTeachingSolution.CourseId] == DBNull.Value ? null : objRow[convTeachingSolution.CourseId].ToString().Trim(); //课程Id
objvTeachingSolutionEN.CourseCode = objRow[convTeachingSolution.CourseCode] == DBNull.Value ? null : objRow[convTeachingSolution.CourseCode].ToString().Trim(); //课程代码
objvTeachingSolutionEN.CourseDescription = objRow[convTeachingSolution.CourseDescription] == DBNull.Value ? null : objRow[convTeachingSolution.CourseDescription].ToString().Trim(); //课程描述
objvTeachingSolutionEN.IdTeacher = objRow[convTeachingSolution.IdTeacher].ToString().Trim(); //教师流水号
objvTeachingSolutionEN.TeacherId = objRow[convTeachingSolution.TeacherId].ToString().Trim(); //教师工号
objvTeachingSolutionEN.TeacherName = objRow[convTeachingSolution.TeacherName].ToString().Trim(); //教师姓名
objvTeachingSolutionEN.IdSex = objRow[convTeachingSolution.IdSex].ToString().Trim(); //性别流水号
objvTeachingSolutionEN.SexDesc = objRow[convTeachingSolution.SexDesc] == DBNull.Value ? null : objRow[convTeachingSolution.SexDesc].ToString().Trim(); //性别名称
objvTeachingSolutionEN.CollegeName = objRow[convTeachingSolution.CollegeName].ToString().Trim(); //学院名称
objvTeachingSolutionEN.IdProfGrade = objRow[convTeachingSolution.IdProfGrade].ToString().Trim(); //专业职称流水号
objvTeachingSolutionEN.ProfenssionalGradeName = objRow[convTeachingSolution.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvTeachingSolutionEN.CollegeId = objRow[convTeachingSolution.CollegeId].ToString().Trim(); //学院ID
objvTeachingSolutionEN.IdXzCollege = objRow[convTeachingSolution.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingSolution.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingSolutionEN.IdXzMajor = objRow[convTeachingSolution.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingSolutionEN.BriefIntroduction = objRow[convTeachingSolution.BriefIntroduction] == DBNull.Value ? null : objRow[convTeachingSolution.BriefIntroduction].ToString().Trim(); //简介
objvTeachingSolutionEN.UpdDate = objRow[convTeachingSolution.UpdDate].ToString().Trim(); //修改日期
objvTeachingSolutionEN.UpdUser = objRow[convTeachingSolution.UpdUser].ToString().Trim(); //修改人
objvTeachingSolutionEN.Memo = objRow[convTeachingSolution.Memo] == DBNull.Value ? null : objRow[convTeachingSolution.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingSolutionEN.TeachingSolutionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingSolutionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvTeachingSolutionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvTeachingSolutionEN> GetSubObjLstCache(clsvTeachingSolutionEN objvTeachingSolutionCond)
{
 string strCourseId = objvTeachingSolutionCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvTeachingSolutionBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvTeachingSolutionEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvTeachingSolutionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTeachingSolution.AttributeName)
{
if (objvTeachingSolutionCond.IsUpdated(strFldName) == false) continue;
if (objvTeachingSolutionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachingSolutionCond[strFldName].ToString());
}
else
{
if (objvTeachingSolutionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTeachingSolutionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachingSolutionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTeachingSolutionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTeachingSolutionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTeachingSolutionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTeachingSolutionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTeachingSolutionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTeachingSolutionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTeachingSolutionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTeachingSolutionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTeachingSolutionCond[strFldName]));
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
public static List<clsvTeachingSolutionEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvTeachingSolutionEN> arrObjLst = new List<clsvTeachingSolutionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingSolutionEN objvTeachingSolutionEN = new clsvTeachingSolutionEN();
try
{
objvTeachingSolutionEN.TeachingSolutionId = objRow[convTeachingSolution.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvTeachingSolutionEN.TeachingSolutionName = objRow[convTeachingSolution.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvTeachingSolutionEN.CourseId = objRow[convTeachingSolution.CourseId] == DBNull.Value ? null : objRow[convTeachingSolution.CourseId].ToString().Trim(); //课程Id
objvTeachingSolutionEN.CourseCode = objRow[convTeachingSolution.CourseCode] == DBNull.Value ? null : objRow[convTeachingSolution.CourseCode].ToString().Trim(); //课程代码
objvTeachingSolutionEN.CourseDescription = objRow[convTeachingSolution.CourseDescription] == DBNull.Value ? null : objRow[convTeachingSolution.CourseDescription].ToString().Trim(); //课程描述
objvTeachingSolutionEN.IdTeacher = objRow[convTeachingSolution.IdTeacher].ToString().Trim(); //教师流水号
objvTeachingSolutionEN.TeacherId = objRow[convTeachingSolution.TeacherId].ToString().Trim(); //教师工号
objvTeachingSolutionEN.TeacherName = objRow[convTeachingSolution.TeacherName].ToString().Trim(); //教师姓名
objvTeachingSolutionEN.IdSex = objRow[convTeachingSolution.IdSex].ToString().Trim(); //性别流水号
objvTeachingSolutionEN.SexDesc = objRow[convTeachingSolution.SexDesc] == DBNull.Value ? null : objRow[convTeachingSolution.SexDesc].ToString().Trim(); //性别名称
objvTeachingSolutionEN.CollegeName = objRow[convTeachingSolution.CollegeName].ToString().Trim(); //学院名称
objvTeachingSolutionEN.IdProfGrade = objRow[convTeachingSolution.IdProfGrade].ToString().Trim(); //专业职称流水号
objvTeachingSolutionEN.ProfenssionalGradeName = objRow[convTeachingSolution.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvTeachingSolutionEN.CollegeId = objRow[convTeachingSolution.CollegeId].ToString().Trim(); //学院ID
objvTeachingSolutionEN.IdXzCollege = objRow[convTeachingSolution.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingSolution.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingSolutionEN.IdXzMajor = objRow[convTeachingSolution.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingSolutionEN.BriefIntroduction = objRow[convTeachingSolution.BriefIntroduction] == DBNull.Value ? null : objRow[convTeachingSolution.BriefIntroduction].ToString().Trim(); //简介
objvTeachingSolutionEN.UpdDate = objRow[convTeachingSolution.UpdDate].ToString().Trim(); //修改日期
objvTeachingSolutionEN.UpdUser = objRow[convTeachingSolution.UpdUser].ToString().Trim(); //修改人
objvTeachingSolutionEN.Memo = objRow[convTeachingSolution.Memo] == DBNull.Value ? null : objRow[convTeachingSolution.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingSolutionEN.TeachingSolutionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingSolutionEN);
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
public static List<clsvTeachingSolutionEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvTeachingSolutionEN> arrObjLst = new List<clsvTeachingSolutionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingSolutionEN objvTeachingSolutionEN = new clsvTeachingSolutionEN();
try
{
objvTeachingSolutionEN.TeachingSolutionId = objRow[convTeachingSolution.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvTeachingSolutionEN.TeachingSolutionName = objRow[convTeachingSolution.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvTeachingSolutionEN.CourseId = objRow[convTeachingSolution.CourseId] == DBNull.Value ? null : objRow[convTeachingSolution.CourseId].ToString().Trim(); //课程Id
objvTeachingSolutionEN.CourseCode = objRow[convTeachingSolution.CourseCode] == DBNull.Value ? null : objRow[convTeachingSolution.CourseCode].ToString().Trim(); //课程代码
objvTeachingSolutionEN.CourseDescription = objRow[convTeachingSolution.CourseDescription] == DBNull.Value ? null : objRow[convTeachingSolution.CourseDescription].ToString().Trim(); //课程描述
objvTeachingSolutionEN.IdTeacher = objRow[convTeachingSolution.IdTeacher].ToString().Trim(); //教师流水号
objvTeachingSolutionEN.TeacherId = objRow[convTeachingSolution.TeacherId].ToString().Trim(); //教师工号
objvTeachingSolutionEN.TeacherName = objRow[convTeachingSolution.TeacherName].ToString().Trim(); //教师姓名
objvTeachingSolutionEN.IdSex = objRow[convTeachingSolution.IdSex].ToString().Trim(); //性别流水号
objvTeachingSolutionEN.SexDesc = objRow[convTeachingSolution.SexDesc] == DBNull.Value ? null : objRow[convTeachingSolution.SexDesc].ToString().Trim(); //性别名称
objvTeachingSolutionEN.CollegeName = objRow[convTeachingSolution.CollegeName].ToString().Trim(); //学院名称
objvTeachingSolutionEN.IdProfGrade = objRow[convTeachingSolution.IdProfGrade].ToString().Trim(); //专业职称流水号
objvTeachingSolutionEN.ProfenssionalGradeName = objRow[convTeachingSolution.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvTeachingSolutionEN.CollegeId = objRow[convTeachingSolution.CollegeId].ToString().Trim(); //学院ID
objvTeachingSolutionEN.IdXzCollege = objRow[convTeachingSolution.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingSolution.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingSolutionEN.IdXzMajor = objRow[convTeachingSolution.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingSolutionEN.BriefIntroduction = objRow[convTeachingSolution.BriefIntroduction] == DBNull.Value ? null : objRow[convTeachingSolution.BriefIntroduction].ToString().Trim(); //简介
objvTeachingSolutionEN.UpdDate = objRow[convTeachingSolution.UpdDate].ToString().Trim(); //修改日期
objvTeachingSolutionEN.UpdUser = objRow[convTeachingSolution.UpdUser].ToString().Trim(); //修改人
objvTeachingSolutionEN.Memo = objRow[convTeachingSolution.Memo] == DBNull.Value ? null : objRow[convTeachingSolution.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingSolutionEN.TeachingSolutionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingSolutionEN);
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
List<clsvTeachingSolutionEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvTeachingSolutionEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingSolutionEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvTeachingSolutionEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvTeachingSolutionEN> arrObjLst = new List<clsvTeachingSolutionEN>(); 
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
	clsvTeachingSolutionEN objvTeachingSolutionEN = new clsvTeachingSolutionEN();
try
{
objvTeachingSolutionEN.TeachingSolutionId = objRow[convTeachingSolution.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvTeachingSolutionEN.TeachingSolutionName = objRow[convTeachingSolution.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvTeachingSolutionEN.CourseId = objRow[convTeachingSolution.CourseId] == DBNull.Value ? null : objRow[convTeachingSolution.CourseId].ToString().Trim(); //课程Id
objvTeachingSolutionEN.CourseCode = objRow[convTeachingSolution.CourseCode] == DBNull.Value ? null : objRow[convTeachingSolution.CourseCode].ToString().Trim(); //课程代码
objvTeachingSolutionEN.CourseDescription = objRow[convTeachingSolution.CourseDescription] == DBNull.Value ? null : objRow[convTeachingSolution.CourseDescription].ToString().Trim(); //课程描述
objvTeachingSolutionEN.IdTeacher = objRow[convTeachingSolution.IdTeacher].ToString().Trim(); //教师流水号
objvTeachingSolutionEN.TeacherId = objRow[convTeachingSolution.TeacherId].ToString().Trim(); //教师工号
objvTeachingSolutionEN.TeacherName = objRow[convTeachingSolution.TeacherName].ToString().Trim(); //教师姓名
objvTeachingSolutionEN.IdSex = objRow[convTeachingSolution.IdSex].ToString().Trim(); //性别流水号
objvTeachingSolutionEN.SexDesc = objRow[convTeachingSolution.SexDesc] == DBNull.Value ? null : objRow[convTeachingSolution.SexDesc].ToString().Trim(); //性别名称
objvTeachingSolutionEN.CollegeName = objRow[convTeachingSolution.CollegeName].ToString().Trim(); //学院名称
objvTeachingSolutionEN.IdProfGrade = objRow[convTeachingSolution.IdProfGrade].ToString().Trim(); //专业职称流水号
objvTeachingSolutionEN.ProfenssionalGradeName = objRow[convTeachingSolution.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvTeachingSolutionEN.CollegeId = objRow[convTeachingSolution.CollegeId].ToString().Trim(); //学院ID
objvTeachingSolutionEN.IdXzCollege = objRow[convTeachingSolution.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingSolution.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingSolutionEN.IdXzMajor = objRow[convTeachingSolution.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingSolutionEN.BriefIntroduction = objRow[convTeachingSolution.BriefIntroduction] == DBNull.Value ? null : objRow[convTeachingSolution.BriefIntroduction].ToString().Trim(); //简介
objvTeachingSolutionEN.UpdDate = objRow[convTeachingSolution.UpdDate].ToString().Trim(); //修改日期
objvTeachingSolutionEN.UpdUser = objRow[convTeachingSolution.UpdUser].ToString().Trim(); //修改人
objvTeachingSolutionEN.Memo = objRow[convTeachingSolution.Memo] == DBNull.Value ? null : objRow[convTeachingSolution.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingSolutionEN.TeachingSolutionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingSolutionEN);
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
public static List<clsvTeachingSolutionEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvTeachingSolutionEN> arrObjLst = new List<clsvTeachingSolutionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingSolutionEN objvTeachingSolutionEN = new clsvTeachingSolutionEN();
try
{
objvTeachingSolutionEN.TeachingSolutionId = objRow[convTeachingSolution.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvTeachingSolutionEN.TeachingSolutionName = objRow[convTeachingSolution.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvTeachingSolutionEN.CourseId = objRow[convTeachingSolution.CourseId] == DBNull.Value ? null : objRow[convTeachingSolution.CourseId].ToString().Trim(); //课程Id
objvTeachingSolutionEN.CourseCode = objRow[convTeachingSolution.CourseCode] == DBNull.Value ? null : objRow[convTeachingSolution.CourseCode].ToString().Trim(); //课程代码
objvTeachingSolutionEN.CourseDescription = objRow[convTeachingSolution.CourseDescription] == DBNull.Value ? null : objRow[convTeachingSolution.CourseDescription].ToString().Trim(); //课程描述
objvTeachingSolutionEN.IdTeacher = objRow[convTeachingSolution.IdTeacher].ToString().Trim(); //教师流水号
objvTeachingSolutionEN.TeacherId = objRow[convTeachingSolution.TeacherId].ToString().Trim(); //教师工号
objvTeachingSolutionEN.TeacherName = objRow[convTeachingSolution.TeacherName].ToString().Trim(); //教师姓名
objvTeachingSolutionEN.IdSex = objRow[convTeachingSolution.IdSex].ToString().Trim(); //性别流水号
objvTeachingSolutionEN.SexDesc = objRow[convTeachingSolution.SexDesc] == DBNull.Value ? null : objRow[convTeachingSolution.SexDesc].ToString().Trim(); //性别名称
objvTeachingSolutionEN.CollegeName = objRow[convTeachingSolution.CollegeName].ToString().Trim(); //学院名称
objvTeachingSolutionEN.IdProfGrade = objRow[convTeachingSolution.IdProfGrade].ToString().Trim(); //专业职称流水号
objvTeachingSolutionEN.ProfenssionalGradeName = objRow[convTeachingSolution.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvTeachingSolutionEN.CollegeId = objRow[convTeachingSolution.CollegeId].ToString().Trim(); //学院ID
objvTeachingSolutionEN.IdXzCollege = objRow[convTeachingSolution.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingSolution.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingSolutionEN.IdXzMajor = objRow[convTeachingSolution.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingSolutionEN.BriefIntroduction = objRow[convTeachingSolution.BriefIntroduction] == DBNull.Value ? null : objRow[convTeachingSolution.BriefIntroduction].ToString().Trim(); //简介
objvTeachingSolutionEN.UpdDate = objRow[convTeachingSolution.UpdDate].ToString().Trim(); //修改日期
objvTeachingSolutionEN.UpdUser = objRow[convTeachingSolution.UpdUser].ToString().Trim(); //修改人
objvTeachingSolutionEN.Memo = objRow[convTeachingSolution.Memo] == DBNull.Value ? null : objRow[convTeachingSolution.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingSolutionEN.TeachingSolutionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingSolutionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvTeachingSolutionEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvTeachingSolutionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvTeachingSolutionEN> arrObjLst = new List<clsvTeachingSolutionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingSolutionEN objvTeachingSolutionEN = new clsvTeachingSolutionEN();
try
{
objvTeachingSolutionEN.TeachingSolutionId = objRow[convTeachingSolution.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvTeachingSolutionEN.TeachingSolutionName = objRow[convTeachingSolution.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvTeachingSolutionEN.CourseId = objRow[convTeachingSolution.CourseId] == DBNull.Value ? null : objRow[convTeachingSolution.CourseId].ToString().Trim(); //课程Id
objvTeachingSolutionEN.CourseCode = objRow[convTeachingSolution.CourseCode] == DBNull.Value ? null : objRow[convTeachingSolution.CourseCode].ToString().Trim(); //课程代码
objvTeachingSolutionEN.CourseDescription = objRow[convTeachingSolution.CourseDescription] == DBNull.Value ? null : objRow[convTeachingSolution.CourseDescription].ToString().Trim(); //课程描述
objvTeachingSolutionEN.IdTeacher = objRow[convTeachingSolution.IdTeacher].ToString().Trim(); //教师流水号
objvTeachingSolutionEN.TeacherId = objRow[convTeachingSolution.TeacherId].ToString().Trim(); //教师工号
objvTeachingSolutionEN.TeacherName = objRow[convTeachingSolution.TeacherName].ToString().Trim(); //教师姓名
objvTeachingSolutionEN.IdSex = objRow[convTeachingSolution.IdSex].ToString().Trim(); //性别流水号
objvTeachingSolutionEN.SexDesc = objRow[convTeachingSolution.SexDesc] == DBNull.Value ? null : objRow[convTeachingSolution.SexDesc].ToString().Trim(); //性别名称
objvTeachingSolutionEN.CollegeName = objRow[convTeachingSolution.CollegeName].ToString().Trim(); //学院名称
objvTeachingSolutionEN.IdProfGrade = objRow[convTeachingSolution.IdProfGrade].ToString().Trim(); //专业职称流水号
objvTeachingSolutionEN.ProfenssionalGradeName = objRow[convTeachingSolution.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvTeachingSolutionEN.CollegeId = objRow[convTeachingSolution.CollegeId].ToString().Trim(); //学院ID
objvTeachingSolutionEN.IdXzCollege = objRow[convTeachingSolution.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingSolution.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingSolutionEN.IdXzMajor = objRow[convTeachingSolution.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingSolutionEN.BriefIntroduction = objRow[convTeachingSolution.BriefIntroduction] == DBNull.Value ? null : objRow[convTeachingSolution.BriefIntroduction].ToString().Trim(); //简介
objvTeachingSolutionEN.UpdDate = objRow[convTeachingSolution.UpdDate].ToString().Trim(); //修改日期
objvTeachingSolutionEN.UpdUser = objRow[convTeachingSolution.UpdUser].ToString().Trim(); //修改人
objvTeachingSolutionEN.Memo = objRow[convTeachingSolution.Memo] == DBNull.Value ? null : objRow[convTeachingSolution.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingSolutionEN.TeachingSolutionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingSolutionEN);
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
public static List<clsvTeachingSolutionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvTeachingSolutionEN> arrObjLst = new List<clsvTeachingSolutionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingSolutionEN objvTeachingSolutionEN = new clsvTeachingSolutionEN();
try
{
objvTeachingSolutionEN.TeachingSolutionId = objRow[convTeachingSolution.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvTeachingSolutionEN.TeachingSolutionName = objRow[convTeachingSolution.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvTeachingSolutionEN.CourseId = objRow[convTeachingSolution.CourseId] == DBNull.Value ? null : objRow[convTeachingSolution.CourseId].ToString().Trim(); //课程Id
objvTeachingSolutionEN.CourseCode = objRow[convTeachingSolution.CourseCode] == DBNull.Value ? null : objRow[convTeachingSolution.CourseCode].ToString().Trim(); //课程代码
objvTeachingSolutionEN.CourseDescription = objRow[convTeachingSolution.CourseDescription] == DBNull.Value ? null : objRow[convTeachingSolution.CourseDescription].ToString().Trim(); //课程描述
objvTeachingSolutionEN.IdTeacher = objRow[convTeachingSolution.IdTeacher].ToString().Trim(); //教师流水号
objvTeachingSolutionEN.TeacherId = objRow[convTeachingSolution.TeacherId].ToString().Trim(); //教师工号
objvTeachingSolutionEN.TeacherName = objRow[convTeachingSolution.TeacherName].ToString().Trim(); //教师姓名
objvTeachingSolutionEN.IdSex = objRow[convTeachingSolution.IdSex].ToString().Trim(); //性别流水号
objvTeachingSolutionEN.SexDesc = objRow[convTeachingSolution.SexDesc] == DBNull.Value ? null : objRow[convTeachingSolution.SexDesc].ToString().Trim(); //性别名称
objvTeachingSolutionEN.CollegeName = objRow[convTeachingSolution.CollegeName].ToString().Trim(); //学院名称
objvTeachingSolutionEN.IdProfGrade = objRow[convTeachingSolution.IdProfGrade].ToString().Trim(); //专业职称流水号
objvTeachingSolutionEN.ProfenssionalGradeName = objRow[convTeachingSolution.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvTeachingSolutionEN.CollegeId = objRow[convTeachingSolution.CollegeId].ToString().Trim(); //学院ID
objvTeachingSolutionEN.IdXzCollege = objRow[convTeachingSolution.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingSolution.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingSolutionEN.IdXzMajor = objRow[convTeachingSolution.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingSolutionEN.BriefIntroduction = objRow[convTeachingSolution.BriefIntroduction] == DBNull.Value ? null : objRow[convTeachingSolution.BriefIntroduction].ToString().Trim(); //简介
objvTeachingSolutionEN.UpdDate = objRow[convTeachingSolution.UpdDate].ToString().Trim(); //修改日期
objvTeachingSolutionEN.UpdUser = objRow[convTeachingSolution.UpdUser].ToString().Trim(); //修改人
objvTeachingSolutionEN.Memo = objRow[convTeachingSolution.Memo] == DBNull.Value ? null : objRow[convTeachingSolution.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingSolutionEN.TeachingSolutionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingSolutionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingSolutionEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvTeachingSolutionEN> arrObjLst = new List<clsvTeachingSolutionEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingSolutionEN objvTeachingSolutionEN = new clsvTeachingSolutionEN();
try
{
objvTeachingSolutionEN.TeachingSolutionId = objRow[convTeachingSolution.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvTeachingSolutionEN.TeachingSolutionName = objRow[convTeachingSolution.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvTeachingSolutionEN.CourseId = objRow[convTeachingSolution.CourseId] == DBNull.Value ? null : objRow[convTeachingSolution.CourseId].ToString().Trim(); //课程Id
objvTeachingSolutionEN.CourseCode = objRow[convTeachingSolution.CourseCode] == DBNull.Value ? null : objRow[convTeachingSolution.CourseCode].ToString().Trim(); //课程代码
objvTeachingSolutionEN.CourseDescription = objRow[convTeachingSolution.CourseDescription] == DBNull.Value ? null : objRow[convTeachingSolution.CourseDescription].ToString().Trim(); //课程描述
objvTeachingSolutionEN.IdTeacher = objRow[convTeachingSolution.IdTeacher].ToString().Trim(); //教师流水号
objvTeachingSolutionEN.TeacherId = objRow[convTeachingSolution.TeacherId].ToString().Trim(); //教师工号
objvTeachingSolutionEN.TeacherName = objRow[convTeachingSolution.TeacherName].ToString().Trim(); //教师姓名
objvTeachingSolutionEN.IdSex = objRow[convTeachingSolution.IdSex].ToString().Trim(); //性别流水号
objvTeachingSolutionEN.SexDesc = objRow[convTeachingSolution.SexDesc] == DBNull.Value ? null : objRow[convTeachingSolution.SexDesc].ToString().Trim(); //性别名称
objvTeachingSolutionEN.CollegeName = objRow[convTeachingSolution.CollegeName].ToString().Trim(); //学院名称
objvTeachingSolutionEN.IdProfGrade = objRow[convTeachingSolution.IdProfGrade].ToString().Trim(); //专业职称流水号
objvTeachingSolutionEN.ProfenssionalGradeName = objRow[convTeachingSolution.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvTeachingSolutionEN.CollegeId = objRow[convTeachingSolution.CollegeId].ToString().Trim(); //学院ID
objvTeachingSolutionEN.IdXzCollege = objRow[convTeachingSolution.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingSolution.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingSolutionEN.IdXzMajor = objRow[convTeachingSolution.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingSolutionEN.BriefIntroduction = objRow[convTeachingSolution.BriefIntroduction] == DBNull.Value ? null : objRow[convTeachingSolution.BriefIntroduction].ToString().Trim(); //简介
objvTeachingSolutionEN.UpdDate = objRow[convTeachingSolution.UpdDate].ToString().Trim(); //修改日期
objvTeachingSolutionEN.UpdUser = objRow[convTeachingSolution.UpdUser].ToString().Trim(); //修改人
objvTeachingSolutionEN.Memo = objRow[convTeachingSolution.Memo] == DBNull.Value ? null : objRow[convTeachingSolution.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingSolutionEN.TeachingSolutionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingSolutionEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvTeachingSolution(ref clsvTeachingSolutionEN objvTeachingSolutionEN)
{
bool bolResult = vTeachingSolutionDA.GetvTeachingSolution(ref objvTeachingSolutionEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTeachingSolutionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachingSolutionEN GetObjByTeachingSolutionId(string strTeachingSolutionId)
{
if (strTeachingSolutionId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTeachingSolutionId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTeachingSolutionId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTeachingSolutionId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvTeachingSolutionEN objvTeachingSolutionEN = vTeachingSolutionDA.GetObjByTeachingSolutionId(strTeachingSolutionId);
return objvTeachingSolutionEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvTeachingSolutionEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvTeachingSolutionEN objvTeachingSolutionEN = vTeachingSolutionDA.GetFirstObj(strWhereCond);
 return objvTeachingSolutionEN;
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
public static clsvTeachingSolutionEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvTeachingSolutionEN objvTeachingSolutionEN = vTeachingSolutionDA.GetObjByDataRow(objRow);
 return objvTeachingSolutionEN;
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
public static clsvTeachingSolutionEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvTeachingSolutionEN objvTeachingSolutionEN = vTeachingSolutionDA.GetObjByDataRow(objRow);
 return objvTeachingSolutionEN;
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
 /// <param name = "strTeachingSolutionId">所给的关键字</param>
 /// <param name = "lstvTeachingSolutionObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachingSolutionEN GetObjByTeachingSolutionIdFromList(string strTeachingSolutionId, List<clsvTeachingSolutionEN> lstvTeachingSolutionObjLst)
{
foreach (clsvTeachingSolutionEN objvTeachingSolutionEN in lstvTeachingSolutionObjLst)
{
if (objvTeachingSolutionEN.TeachingSolutionId == strTeachingSolutionId)
{
return objvTeachingSolutionEN;
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
 string strMaxTeachingSolutionId;
 try
 {
 strMaxTeachingSolutionId = clsvTeachingSolutionDA.GetMaxStrId();
 return strMaxTeachingSolutionId;
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
 string strTeachingSolutionId;
 try
 {
 strTeachingSolutionId = new clsvTeachingSolutionDA().GetFirstID(strWhereCond);
 return strTeachingSolutionId;
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
 arrList = vTeachingSolutionDA.GetID(strWhereCond);
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
bool bolIsExist = vTeachingSolutionDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTeachingSolutionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTeachingSolutionId)
{
if (string.IsNullOrEmpty(strTeachingSolutionId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTeachingSolutionId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vTeachingSolutionDA.IsExist(strTeachingSolutionId);
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
 bolIsExist = clsvTeachingSolutionDA.IsExistTable();
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
 bolIsExist = vTeachingSolutionDA.IsExistTable(strTabName);
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
 /// <param name = "objvTeachingSolutionENS">源对象</param>
 /// <param name = "objvTeachingSolutionENT">目标对象</param>
 public static void CopyTo(clsvTeachingSolutionEN objvTeachingSolutionENS, clsvTeachingSolutionEN objvTeachingSolutionENT)
{
try
{
objvTeachingSolutionENT.TeachingSolutionId = objvTeachingSolutionENS.TeachingSolutionId; //教学方案Id
objvTeachingSolutionENT.TeachingSolutionName = objvTeachingSolutionENS.TeachingSolutionName; //教学方案名称
objvTeachingSolutionENT.CourseId = objvTeachingSolutionENS.CourseId; //课程Id
objvTeachingSolutionENT.CourseCode = objvTeachingSolutionENS.CourseCode; //课程代码
objvTeachingSolutionENT.CourseDescription = objvTeachingSolutionENS.CourseDescription; //课程描述
objvTeachingSolutionENT.IdTeacher = objvTeachingSolutionENS.IdTeacher; //教师流水号
objvTeachingSolutionENT.TeacherId = objvTeachingSolutionENS.TeacherId; //教师工号
objvTeachingSolutionENT.TeacherName = objvTeachingSolutionENS.TeacherName; //教师姓名
objvTeachingSolutionENT.IdSex = objvTeachingSolutionENS.IdSex; //性别流水号
objvTeachingSolutionENT.SexDesc = objvTeachingSolutionENS.SexDesc; //性别名称
objvTeachingSolutionENT.CollegeName = objvTeachingSolutionENS.CollegeName; //学院名称
objvTeachingSolutionENT.IdProfGrade = objvTeachingSolutionENS.IdProfGrade; //专业职称流水号
objvTeachingSolutionENT.ProfenssionalGradeName = objvTeachingSolutionENS.ProfenssionalGradeName; //专业职称
objvTeachingSolutionENT.CollegeId = objvTeachingSolutionENS.CollegeId; //学院ID
objvTeachingSolutionENT.IdXzCollege = objvTeachingSolutionENS.IdXzCollege; //学院流水号
objvTeachingSolutionENT.IdXzMajor = objvTeachingSolutionENS.IdXzMajor; //专业流水号
objvTeachingSolutionENT.BriefIntroduction = objvTeachingSolutionENS.BriefIntroduction; //简介
objvTeachingSolutionENT.UpdDate = objvTeachingSolutionENS.UpdDate; //修改日期
objvTeachingSolutionENT.UpdUser = objvTeachingSolutionENS.UpdUser; //修改人
objvTeachingSolutionENT.Memo = objvTeachingSolutionENS.Memo; //备注
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
 /// <param name = "objvTeachingSolutionEN">源简化对象</param>
 public static void SetUpdFlag(clsvTeachingSolutionEN objvTeachingSolutionEN)
{
try
{
objvTeachingSolutionEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvTeachingSolutionEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convTeachingSolution.TeachingSolutionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingSolutionEN.TeachingSolutionId = objvTeachingSolutionEN.TeachingSolutionId; //教学方案Id
}
if (arrFldSet.Contains(convTeachingSolution.TeachingSolutionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingSolutionEN.TeachingSolutionName = objvTeachingSolutionEN.TeachingSolutionName; //教学方案名称
}
if (arrFldSet.Contains(convTeachingSolution.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingSolutionEN.CourseId = objvTeachingSolutionEN.CourseId == "[null]" ? null :  objvTeachingSolutionEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convTeachingSolution.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingSolutionEN.CourseCode = objvTeachingSolutionEN.CourseCode == "[null]" ? null :  objvTeachingSolutionEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convTeachingSolution.CourseDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingSolutionEN.CourseDescription = objvTeachingSolutionEN.CourseDescription == "[null]" ? null :  objvTeachingSolutionEN.CourseDescription; //课程描述
}
if (arrFldSet.Contains(convTeachingSolution.IdTeacher, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingSolutionEN.IdTeacher = objvTeachingSolutionEN.IdTeacher; //教师流水号
}
if (arrFldSet.Contains(convTeachingSolution.TeacherId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingSolutionEN.TeacherId = objvTeachingSolutionEN.TeacherId; //教师工号
}
if (arrFldSet.Contains(convTeachingSolution.TeacherName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingSolutionEN.TeacherName = objvTeachingSolutionEN.TeacherName; //教师姓名
}
if (arrFldSet.Contains(convTeachingSolution.IdSex, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingSolutionEN.IdSex = objvTeachingSolutionEN.IdSex; //性别流水号
}
if (arrFldSet.Contains(convTeachingSolution.SexDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingSolutionEN.SexDesc = objvTeachingSolutionEN.SexDesc == "[null]" ? null :  objvTeachingSolutionEN.SexDesc; //性别名称
}
if (arrFldSet.Contains(convTeachingSolution.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingSolutionEN.CollegeName = objvTeachingSolutionEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convTeachingSolution.IdProfGrade, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingSolutionEN.IdProfGrade = objvTeachingSolutionEN.IdProfGrade; //专业职称流水号
}
if (arrFldSet.Contains(convTeachingSolution.ProfenssionalGradeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingSolutionEN.ProfenssionalGradeName = objvTeachingSolutionEN.ProfenssionalGradeName; //专业职称
}
if (arrFldSet.Contains(convTeachingSolution.CollegeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingSolutionEN.CollegeId = objvTeachingSolutionEN.CollegeId; //学院ID
}
if (arrFldSet.Contains(convTeachingSolution.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingSolutionEN.IdXzCollege = objvTeachingSolutionEN.IdXzCollege == "[null]" ? null :  objvTeachingSolutionEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convTeachingSolution.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingSolutionEN.IdXzMajor = objvTeachingSolutionEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convTeachingSolution.BriefIntroduction, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingSolutionEN.BriefIntroduction = objvTeachingSolutionEN.BriefIntroduction == "[null]" ? null :  objvTeachingSolutionEN.BriefIntroduction; //简介
}
if (arrFldSet.Contains(convTeachingSolution.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingSolutionEN.UpdDate = objvTeachingSolutionEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convTeachingSolution.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingSolutionEN.UpdUser = objvTeachingSolutionEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convTeachingSolution.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingSolutionEN.Memo = objvTeachingSolutionEN.Memo == "[null]" ? null :  objvTeachingSolutionEN.Memo; //备注
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
 /// <param name = "objvTeachingSolutionEN">源简化对象</param>
 public static void AccessFldValueNull(clsvTeachingSolutionEN objvTeachingSolutionEN)
{
try
{
if (objvTeachingSolutionEN.CourseId == "[null]") objvTeachingSolutionEN.CourseId = null; //课程Id
if (objvTeachingSolutionEN.CourseCode == "[null]") objvTeachingSolutionEN.CourseCode = null; //课程代码
if (objvTeachingSolutionEN.CourseDescription == "[null]") objvTeachingSolutionEN.CourseDescription = null; //课程描述
if (objvTeachingSolutionEN.SexDesc == "[null]") objvTeachingSolutionEN.SexDesc = null; //性别名称
if (objvTeachingSolutionEN.IdXzCollege == "[null]") objvTeachingSolutionEN.IdXzCollege = null; //学院流水号
if (objvTeachingSolutionEN.BriefIntroduction == "[null]") objvTeachingSolutionEN.BriefIntroduction = null; //简介
if (objvTeachingSolutionEN.Memo == "[null]") objvTeachingSolutionEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvTeachingSolutionEN objvTeachingSolutionEN)
{
 vTeachingSolutionDA.CheckProperty4Condition(objvTeachingSolutionEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strCourseId"></param>
public static void BindCbo_TeachingSolutionId(System.Windows.Forms.ComboBox objComboBox , string strCourseId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convTeachingSolution.TeachingSolutionId); 
List<clsvTeachingSolutionEN> arrObjLst = clsvTeachingSolutionBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CourseId == strCourseId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvTeachingSolutionEN objvTeachingSolutionEN = new clsvTeachingSolutionEN()
{
TeachingSolutionId = "0",
TeachingSolutionName = "选[v教学方案]..."
};
arrObjLstSel.Insert(0, objvTeachingSolutionEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convTeachingSolution.TeachingSolutionId;
objComboBox.DisplayMember = convTeachingSolution.TeachingSolutionName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strCourseId"></param>
public static void BindDdl_TeachingSolutionId(System.Web.UI.WebControls.DropDownList objDDL , string strCourseId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v教学方案]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convTeachingSolution.TeachingSolutionId); 
IEnumerable<clsvTeachingSolutionEN> arrObjLst = clsvTeachingSolutionBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CourseId == strCourseId).ToList();
objDDL.DataValueField = convTeachingSolution.TeachingSolutionId;
objDDL.DataTextField = convTeachingSolution.TeachingSolutionName;
objDDL.DataSource = arrObjLstSel;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_TeachingSolutionIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strCourseId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v教学方案]...","0");
List<clsvTeachingSolutionEN> arrvTeachingSolutionObjLst = GetAllvTeachingSolutionObjLstCache(strCourseId); 
objDDL.DataValueField = convTeachingSolution.TeachingSolutionId;
objDDL.DataTextField = convTeachingSolution.TeachingSolutionName;
objDDL.DataSource = arrvTeachingSolutionObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingSolutionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingSolutionBL没有刷新缓存机制(clsTeachingSolutionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeacherInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeacherInfoBL没有刷新缓存机制(clsTeacherInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzUniZoneBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneBL没有刷新缓存机制(clsXzUniZoneBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStaffTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStaffTypeBL没有刷新缓存机制(clsRsStaffTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexBL没有刷新缓存机制(clsSexBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsProfGradeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsProfGradeBL没有刷新缓存机制(clsRsProfGradeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicBL没有刷新缓存机制(clsRsEthnicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsDegreeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsDegreeBL没有刷新缓存机制(clsRsDegreeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsProvinceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsProvinceBL没有刷新缓存机制(clsRsProvinceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsReligionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsReligionBL没有刷新缓存机制(clsRsReligionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsQualifBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsQualifBL没有刷新缓存机制(clsRsQualifBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsBL没有刷新缓存机制(clsRsPoliticsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsAdminGradeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsAdminGradeBL没有刷新缓存机制(clsRsAdminGradeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TeachingSolutionId");
//if (arrvTeachingSolutionObjLstCache == null)
//{
//arrvTeachingSolutionObjLstCache = vTeachingSolutionDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTeachingSolutionId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachingSolutionEN GetObjByTeachingSolutionIdCache(string strTeachingSolutionId, string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvTeachingSolutionEN._CurrTabName, strCourseId);
List<clsvTeachingSolutionEN> arrvTeachingSolutionObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvTeachingSolutionEN> arrvTeachingSolutionObjLst_Sel =
arrvTeachingSolutionObjLstCache
.Where(x=> x.TeachingSolutionId == strTeachingSolutionId 
);
if (arrvTeachingSolutionObjLst_Sel.Count() == 0)
{
   clsvTeachingSolutionEN obj = clsvTeachingSolutionBL.GetObjByTeachingSolutionId(strTeachingSolutionId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strTeachingSolutionId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvTeachingSolutionObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTeachingSolutionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTeachingSolutionNameByTeachingSolutionIdCache(string strTeachingSolutionId, string strCourseId)
{
if (string.IsNullOrEmpty(strTeachingSolutionId) == true) return "";
//获取缓存中的对象列表
clsvTeachingSolutionEN objvTeachingSolution = GetObjByTeachingSolutionIdCache(strTeachingSolutionId, strCourseId);
if (objvTeachingSolution == null) return "";
return objvTeachingSolution.TeachingSolutionName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTeachingSolutionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByTeachingSolutionIdCache(string strTeachingSolutionId, string strCourseId)
{
if (string.IsNullOrEmpty(strTeachingSolutionId) == true) return "";
//获取缓存中的对象列表
clsvTeachingSolutionEN objvTeachingSolution = GetObjByTeachingSolutionIdCache(strTeachingSolutionId, strCourseId);
if (objvTeachingSolution == null) return "";
return objvTeachingSolution.TeachingSolutionName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTeachingSolutionEN> GetAllvTeachingSolutionObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsvTeachingSolutionEN> arrvTeachingSolutionObjLstCache = GetObjLstCache(strCourseId); 
return arrvTeachingSolutionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTeachingSolutionEN> GetObjLstCache(string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvTeachingSolutionEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsvTeachingSolutionEN> arrvTeachingSolutionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvTeachingSolutionObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvTeachingSolutionEN._CurrTabName, strCourseId);
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
 /// 日期:2024-02-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strTeachingSolutionId, string strCourseId)
{
if (strInFldName != convTeachingSolution.TeachingSolutionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convTeachingSolution.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convTeachingSolution.AttributeName));
throw new Exception(strMsg);
}
var objvTeachingSolution = clsvTeachingSolutionBL.GetObjByTeachingSolutionIdCache(strTeachingSolutionId, strCourseId);
if (objvTeachingSolution == null) return "";
return objvTeachingSolution[strOutFldName].ToString();
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
int intRecCount = clsvTeachingSolutionDA.GetRecCount(strTabName);
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
int intRecCount = clsvTeachingSolutionDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvTeachingSolutionDA.GetRecCount();
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
int intRecCount = clsvTeachingSolutionDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvTeachingSolutionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvTeachingSolutionEN objvTeachingSolutionCond)
{
 string strCourseId = objvTeachingSolutionCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvTeachingSolutionBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvTeachingSolutionEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvTeachingSolutionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTeachingSolution.AttributeName)
{
if (objvTeachingSolutionCond.IsUpdated(strFldName) == false) continue;
if (objvTeachingSolutionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachingSolutionCond[strFldName].ToString());
}
else
{
if (objvTeachingSolutionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTeachingSolutionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachingSolutionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTeachingSolutionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTeachingSolutionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTeachingSolutionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTeachingSolutionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTeachingSolutionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTeachingSolutionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTeachingSolutionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTeachingSolutionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTeachingSolutionCond[strFldName]));
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
 List<string> arrList = clsvTeachingSolutionDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vTeachingSolutionDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vTeachingSolutionDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}