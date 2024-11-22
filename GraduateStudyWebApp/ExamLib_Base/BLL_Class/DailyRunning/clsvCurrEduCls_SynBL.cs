
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCurrEduCls_SynBL
 表名:vCurrEduCls_Syn(01120928)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:23:27
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日常运行(DailyRunning)
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
public static class  clsvCurrEduCls_SynBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCurrEduCls">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCurrEduCls_SynEN GetObj(this K_IdCurrEduCls_vCurrEduCls_Syn myKey)
{
clsvCurrEduCls_SynEN objvCurrEduCls_SynEN = clsvCurrEduCls_SynBL.vCurrEduCls_SynDA.GetObjByIdCurrEduCls(myKey.Value);
return objvCurrEduCls_SynEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetIdCurrEduCls(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convCurrEduCls_Syn.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convCurrEduCls_Syn.IdCurrEduCls);
}
objvCurrEduCls_SynEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.IdCurrEduCls) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.IdCurrEduCls, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.IdCurrEduCls] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetEduClsTypeName(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strEduClsTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsTypeName, 100, convCurrEduCls_Syn.EduClsTypeName);
}
objvCurrEduCls_SynEN.EduClsTypeName = strEduClsTypeName; //教学班类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.EduClsTypeName) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.EduClsTypeName, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.EduClsTypeName] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetCourseCode(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCurrEduCls_Syn.CourseCode);
}
objvCurrEduCls_SynEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.CourseCode) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.CourseCode, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.CourseCode] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetCourseDescription(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strCourseDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseDescription, 8000, convCurrEduCls_Syn.CourseDescription);
}
objvCurrEduCls_SynEN.CourseDescription = strCourseDescription; //课程描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.CourseDescription) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.CourseDescription, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.CourseDescription] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetCourseName(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCurrEduCls_Syn.CourseName);
}
objvCurrEduCls_SynEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.CourseName) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.CourseName, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.CourseName] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetViewCount(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, int? intViewCount, string strComparisonOp="")
	{
objvCurrEduCls_SynEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.ViewCount) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.ViewCount, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.ViewCount] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetExampleImgPath(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strExampleImgPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExampleImgPath, 300, convCurrEduCls_Syn.ExampleImgPath);
}
objvCurrEduCls_SynEN.ExampleImgPath = strExampleImgPath; //示例图路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.ExampleImgPath) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.ExampleImgPath, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.ExampleImgPath] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetTeachingSolutionName(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strTeachingSolutionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingSolutionName, convCurrEduCls_Syn.TeachingSolutionName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingSolutionName, 100, convCurrEduCls_Syn.TeachingSolutionName);
}
objvCurrEduCls_SynEN.TeachingSolutionName = strTeachingSolutionName; //教学方案名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.TeachingSolutionName) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.TeachingSolutionName, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.TeachingSolutionName] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetIdTeacher(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strIdTeacher, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeacher, convCurrEduCls_Syn.IdTeacher);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeacher, 8, convCurrEduCls_Syn.IdTeacher);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeacher, 8, convCurrEduCls_Syn.IdTeacher);
}
objvCurrEduCls_SynEN.IdTeacher = strIdTeacher; //教师流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.IdTeacher) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.IdTeacher, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.IdTeacher] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetTeacherId(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strTeacherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherId, convCurrEduCls_Syn.TeacherId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeacherId, 12, convCurrEduCls_Syn.TeacherId);
}
objvCurrEduCls_SynEN.TeacherId = strTeacherId; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.TeacherId) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.TeacherId, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.TeacherId] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetTeacherName(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strTeacherName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherName, convCurrEduCls_Syn.TeacherName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeacherName, 50, convCurrEduCls_Syn.TeacherName);
}
objvCurrEduCls_SynEN.TeacherName = strTeacherName; //教师姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.TeacherName) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.TeacherName, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.TeacherName] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetCollegeId(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strCollegeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeId, convCurrEduCls_Syn.CollegeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeId, 4, convCurrEduCls_Syn.CollegeId);
}
objvCurrEduCls_SynEN.CollegeId = strCollegeId; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.CollegeId) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.CollegeId, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.CollegeId] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetCollegeName(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convCurrEduCls_Syn.CollegeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCurrEduCls_Syn.CollegeName);
}
objvCurrEduCls_SynEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.CollegeName) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.CollegeName, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.CollegeName] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetIdXzMajor(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strIdXzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzMajor, convCurrEduCls_Syn.IdXzMajor);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convCurrEduCls_Syn.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convCurrEduCls_Syn.IdXzMajor);
}
objvCurrEduCls_SynEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.IdXzMajor) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.IdXzMajor, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.IdXzMajor] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetMajorName(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorName, convCurrEduCls_Syn.MajorName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convCurrEduCls_Syn.MajorName);
}
objvCurrEduCls_SynEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.MajorName) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.MajorName, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.MajorName] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetGradeBaseId(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strGradeBaseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseId, 4, convCurrEduCls_Syn.GradeBaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGradeBaseId, 4, convCurrEduCls_Syn.GradeBaseId);
}
objvCurrEduCls_SynEN.GradeBaseId = strGradeBaseId; //年级代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.GradeBaseId) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.GradeBaseId, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.GradeBaseId] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetGradeBaseName(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGradeBaseName, convCurrEduCls_Syn.GradeBaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convCurrEduCls_Syn.GradeBaseName);
}
objvCurrEduCls_SynEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.GradeBaseName) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.GradeBaseName, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.GradeBaseName] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetGradeBaseNameA(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strGradeBaseNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGradeBaseNameA, convCurrEduCls_Syn.GradeBaseNameA);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseNameA, 10, convCurrEduCls_Syn.GradeBaseNameA);
}
objvCurrEduCls_SynEN.GradeBaseNameA = strGradeBaseNameA; //年级名称缩写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.GradeBaseNameA) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.GradeBaseNameA, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.GradeBaseNameA] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetCourseTypeId(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strCourseTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseTypeId, convCurrEduCls_Syn.CourseTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseTypeId, 4, convCurrEduCls_Syn.CourseTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseTypeId, 4, convCurrEduCls_Syn.CourseTypeId);
}
objvCurrEduCls_SynEN.CourseTypeId = strCourseTypeId; //课程类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.CourseTypeId) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.CourseTypeId, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.CourseTypeId] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetCourseTypeName(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strCourseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseTypeName, convCurrEduCls_Syn.CourseTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseTypeName, 30, convCurrEduCls_Syn.CourseTypeName);
}
objvCurrEduCls_SynEN.CourseTypeName = strCourseTypeName; //课程类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.CourseTypeName) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.CourseTypeName, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.CourseTypeName] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetCurrStuNumValid(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, int? intCurrStuNumValid, string strComparisonOp="")
	{
objvCurrEduCls_SynEN.CurrStuNumValid = intCurrStuNumValid; //CurrStuNum_Valid
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.CurrStuNumValid) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.CurrStuNumValid, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.CurrStuNumValid] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetCurrStuNum(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, int? intCurrStuNum, string strComparisonOp="")
	{
objvCurrEduCls_SynEN.CurrStuNum = intCurrStuNum; //当前学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.CurrStuNum) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.CurrStuNum, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.CurrStuNum] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetCurrEduClsId(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strCurrEduClsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, convCurrEduCls_Syn.CurrEduClsId);
}
objvCurrEduCls_SynEN.CurrEduClsId = strCurrEduClsId; //教学班Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.CurrEduClsId) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.CurrEduClsId, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.CurrEduClsId] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetEduClsName(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduClsName, convCurrEduCls_Syn.EduClsName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convCurrEduCls_Syn.EduClsName);
}
objvCurrEduCls_SynEN.EduClsName = strEduClsName; //教学班名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.EduClsName) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.EduClsName, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.EduClsName] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetEduClsTypeId(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strEduClsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduClsTypeId, convCurrEduCls_Syn.EduClsTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsTypeId, 4, convCurrEduCls_Syn.EduClsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEduClsTypeId, 4, convCurrEduCls_Syn.EduClsTypeId);
}
objvCurrEduCls_SynEN.EduClsTypeId = strEduClsTypeId; //教学班类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.EduClsTypeId) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.EduClsTypeId, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.EduClsTypeId] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetCourseId(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCurrEduCls_Syn.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCurrEduCls_Syn.CourseId);
}
objvCurrEduCls_SynEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.CourseId) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.CourseId, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.CourseId] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetTeachingSolutionId(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strTeachingSolutionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingSolutionId, convCurrEduCls_Syn.TeachingSolutionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingSolutionId, 8, convCurrEduCls_Syn.TeachingSolutionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingSolutionId, 8, convCurrEduCls_Syn.TeachingSolutionId);
}
objvCurrEduCls_SynEN.TeachingSolutionId = strTeachingSolutionId; //教学方案Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.TeachingSolutionId) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.TeachingSolutionId, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.TeachingSolutionId] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetIdXzCollege(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convCurrEduCls_Syn.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convCurrEduCls_Syn.IdXzCollege);
}
objvCurrEduCls_SynEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.IdXzCollege) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.IdXzCollege, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.IdXzCollege] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetIdEduWay(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strIdEduWay, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdEduWay, convCurrEduCls_Syn.IdEduWay);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdEduWay, 4, convCurrEduCls_Syn.IdEduWay);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdEduWay, 4, convCurrEduCls_Syn.IdEduWay);
}
objvCurrEduCls_SynEN.IdEduWay = strIdEduWay; //教学方式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.IdEduWay) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.IdEduWay, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.IdEduWay] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetIdClassRoomType(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strIdClassRoomType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdClassRoomType, convCurrEduCls_Syn.IdClassRoomType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdClassRoomType, 4, convCurrEduCls_Syn.IdClassRoomType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdClassRoomType, 4, convCurrEduCls_Syn.IdClassRoomType);
}
objvCurrEduCls_SynEN.IdClassRoomType = strIdClassRoomType; //教室类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.IdClassRoomType) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.IdClassRoomType, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.IdClassRoomType] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetTotalLessonQty(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, int intTotalLessonQty, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intTotalLessonQty, convCurrEduCls_Syn.TotalLessonQty);
objvCurrEduCls_SynEN.TotalLessonQty = intTotalLessonQty; //总课时数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.TotalLessonQty) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.TotalLessonQty, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.TotalLessonQty] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetMaxStuQty(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, int? intMaxStuQty, string strComparisonOp="")
	{
objvCurrEduCls_SynEN.MaxStuQty = intMaxStuQty; //最大学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.MaxStuQty) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.MaxStuQty, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.MaxStuQty] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetWeekQty(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, int? intWeekQty, string strComparisonOp="")
	{
objvCurrEduCls_SynEN.WeekQty = intWeekQty; //总周数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.WeekQty) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.WeekQty, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.WeekQty] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetScheUnitPW(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, short? shtScheUnitPW, string strComparisonOp="")
	{
objvCurrEduCls_SynEN.ScheUnitPW = shtScheUnitPW; //周排课次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.ScheUnitPW) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.ScheUnitPW, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.ScheUnitPW] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetWeekStatusId(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strWeekStatusId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWeekStatusId, 2, convCurrEduCls_Syn.WeekStatusId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWeekStatusId, 2, convCurrEduCls_Syn.WeekStatusId);
}
objvCurrEduCls_SynEN.WeekStatusId = strWeekStatusId; //周状态编号(单,双,全周)
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.WeekStatusId) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.WeekStatusId, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.WeekStatusId] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetCustomerWeek(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strCustomerWeek, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCustomerWeek, 50, convCurrEduCls_Syn.CustomerWeek);
}
objvCurrEduCls_SynEN.CustomerWeek = strCustomerWeek; //自定义上课周
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.CustomerWeek) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.CustomerWeek, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.CustomerWeek] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetIsCompleteScore(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, bool bolIsCompleteScore, string strComparisonOp="")
	{
objvCurrEduCls_SynEN.IsCompleteScore = bolIsCompleteScore; //是否成绩齐全
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.IsCompleteScore) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.IsCompleteScore, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.IsCompleteScore] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetIdExecPlan(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strIdExecPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdExecPlan, convCurrEduCls_Syn.IdExecPlan);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdExecPlan, 8, convCurrEduCls_Syn.IdExecPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdExecPlan, 8, convCurrEduCls_Syn.IdExecPlan);
}
objvCurrEduCls_SynEN.IdExecPlan = strIdExecPlan; //执行计划流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.IdExecPlan) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.IdExecPlan, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.IdExecPlan] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetLessonQtyPerWeek(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, short shtLessonQtyPerWeek, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(shtLessonQtyPerWeek, convCurrEduCls_Syn.LessonQtyPerWeek);
objvCurrEduCls_SynEN.LessonQtyPerWeek = shtLessonQtyPerWeek; //周课时数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.LessonQtyPerWeek) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.LessonQtyPerWeek, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.LessonQtyPerWeek] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetMark(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, double? dblMark, string strComparisonOp="")
	{
objvCurrEduCls_SynEN.Mark = dblMark; //获得学分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.Mark) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.Mark, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.Mark] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetCheckClassRoom(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strCheckClassRoom, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckClassRoom, 2000, convCurrEduCls_Syn.CheckClassRoom);
}
objvCurrEduCls_SynEN.CheckClassRoom = strCheckClassRoom; //检查教室结果
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.CheckClassRoom) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.CheckClassRoom, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.CheckClassRoom] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetCheckAdminCls(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strCheckAdminCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckAdminCls, 2000, convCurrEduCls_Syn.CheckAdminCls);
}
objvCurrEduCls_SynEN.CheckAdminCls = strCheckAdminCls; //检查行政班结果
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.CheckAdminCls) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.CheckAdminCls, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.CheckAdminCls] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetCheckTeacher(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strCheckTeacher, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckTeacher, 2000, convCurrEduCls_Syn.CheckTeacher);
}
objvCurrEduCls_SynEN.CheckTeacher = strCheckTeacher; //检查教师结果
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.CheckTeacher) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.CheckTeacher, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.CheckTeacher] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetEditLocked(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, bool bolEditLocked, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolEditLocked, convCurrEduCls_Syn.EditLocked);
objvCurrEduCls_SynEN.EditLocked = bolEditLocked; //编辑锁定
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.EditLocked) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.EditLocked, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.EditLocked] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetSched(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, bool bolSched, string strComparisonOp="")
	{
objvCurrEduCls_SynEN.Sched = bolSched; //是否排课
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.Sched) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.Sched, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.Sched] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetIdUniZone(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strIdUniZone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdUniZone, convCurrEduCls_Syn.IdUniZone);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdUniZone, 4, convCurrEduCls_Syn.IdUniZone);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdUniZone, 4, convCurrEduCls_Syn.IdUniZone);
}
objvCurrEduCls_SynEN.IdUniZone = strIdUniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.IdUniZone) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.IdUniZone, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.IdUniZone] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetLocked(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, bool bolLocked, string strComparisonOp="")
	{
objvCurrEduCls_SynEN.Locked = bolLocked; //锁定状态
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.Locked) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.Locked, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.Locked] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetIdGradeBase(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strIdGradeBase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, convCurrEduCls_Syn.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, convCurrEduCls_Syn.IdGradeBase);
}
objvCurrEduCls_SynEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.IdGradeBase) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.IdGradeBase, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.IdGradeBase] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetIsEffective(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, bool bolIsEffective, string strComparisonOp="")
	{
objvCurrEduCls_SynEN.IsEffective = bolIsEffective; //是否有效
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.IsEffective) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.IsEffective, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.IsEffective] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetIsForPaperReading(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, bool bolIsForPaperReading, string strComparisonOp="")
	{
objvCurrEduCls_SynEN.IsForPaperReading = bolIsForPaperReading; //是否参与论文阅读
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.IsForPaperReading) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.IsForPaperReading, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.IsForPaperReading] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetIsUnDeterminedClsRm(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, bool bolIsUnDeterminedClsRm, string strComparisonOp="")
	{
objvCurrEduCls_SynEN.IsUnDeterminedClsRm = bolIsUnDeterminedClsRm; //是否待定教室
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.IsUnDeterminedClsRm) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.IsUnDeterminedClsRm, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.IsUnDeterminedClsRm] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetSchoolYear(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strSchoolYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, convCurrEduCls_Syn.SchoolYear);
}
objvCurrEduCls_SynEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.SchoolYear) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.SchoolYear, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.SchoolYear] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetSchoolTerm(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strSchoolTerm, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, convCurrEduCls_Syn.SchoolTerm);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, convCurrEduCls_Syn.SchoolTerm);
}
objvCurrEduCls_SynEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.SchoolTerm) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.SchoolTerm, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.SchoolTerm] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetArrangeCourseMemo(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strArrangeCourseMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strArrangeCourseMemo, 50, convCurrEduCls_Syn.ArrangeCourseMemo);
}
objvCurrEduCls_SynEN.ArrangeCourseMemo = strArrangeCourseMemo; //排课备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.ArrangeCourseMemo) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.ArrangeCourseMemo, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.ArrangeCourseMemo] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetIdCourseType(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strIdCourseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCourseType, convCurrEduCls_Syn.IdCourseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCourseType, 4, convCurrEduCls_Syn.IdCourseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCourseType, 4, convCurrEduCls_Syn.IdCourseType);
}
objvCurrEduCls_SynEN.IdCourseType = strIdCourseType; //课程类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.IdCourseType) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.IdCourseType, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.IdCourseType] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetIsDegree(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, bool bolIsDegree, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDegree, convCurrEduCls_Syn.IsDegree);
objvCurrEduCls_SynEN.IsDegree = bolIsDegree; //是否学位课
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.IsDegree) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.IsDegree, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.IsDegree] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetIdScoreType(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strIdScoreType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdScoreType, convCurrEduCls_Syn.IdScoreType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdScoreType, 4, convCurrEduCls_Syn.IdScoreType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdScoreType, 4, convCurrEduCls_Syn.IdScoreType);
}
objvCurrEduCls_SynEN.IdScoreType = strIdScoreType; //成绩类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.IdScoreType) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.IdScoreType, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.IdScoreType] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetGetScoreWayId(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strGetScoreWayId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGetScoreWayId, 2, convCurrEduCls_Syn.GetScoreWayId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGetScoreWayId, 2, convCurrEduCls_Syn.GetScoreWayId);
}
objvCurrEduCls_SynEN.GetScoreWayId = strGetScoreWayId; //获得成绩方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.GetScoreWayId) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.GetScoreWayId, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.GetScoreWayId] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetIsProportionalCtrl(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, bool bolIsProportionalCtrl, string strComparisonOp="")
	{
objvCurrEduCls_SynEN.IsProportionalCtrl = bolIsProportionalCtrl; //是否比例控制
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.IsProportionalCtrl) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.IsProportionalCtrl, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.IsProportionalCtrl] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetIdExamType(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strIdExamType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdExamType, convCurrEduCls_Syn.IdExamType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdExamType, 4, convCurrEduCls_Syn.IdExamType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdExamType, 4, convCurrEduCls_Syn.IdExamType);
}
objvCurrEduCls_SynEN.IdExamType = strIdExamType; //考试方式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.IdExamType) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.IdExamType, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.IdExamType] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetExamPortion(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, short shtExamPortion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(shtExamPortion, convCurrEduCls_Syn.ExamPortion);
objvCurrEduCls_SynEN.ExamPortion = shtExamPortion; //平时成绩所占比例
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.ExamPortion) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.ExamPortion, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.ExamPortion] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetMidExamScorePortion(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, short? shtMidExamScorePortion, string strComparisonOp="")
	{
objvCurrEduCls_SynEN.MidExamScorePortion = shtMidExamScorePortion; //期末成绩所占比例
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.MidExamScorePortion) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.MidExamScorePortion, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.MidExamScorePortion] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetIsClearScore(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, bool bolIsClearScore, string strComparisonOp="")
	{
objvCurrEduCls_SynEN.IsClearScore = bolIsClearScore; //是否重录成绩
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.IsClearScore) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.IsClearScore, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.IsClearScore] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetIsGeneratePwd(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, bool bolIsGeneratePwd, string strComparisonOp="")
	{
objvCurrEduCls_SynEN.IsGeneratePwd = bolIsGeneratePwd; //是否生成口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.IsGeneratePwd) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.IsGeneratePwd, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.IsGeneratePwd] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetGeneratePwdDate(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strGeneratePwdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGeneratePwdDate, 20, convCurrEduCls_Syn.GeneratePwdDate);
}
objvCurrEduCls_SynEN.GeneratePwdDate = strGeneratePwdDate; //生成口令时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.GeneratePwdDate) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.GeneratePwdDate, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.GeneratePwdDate] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetPkWeekTime(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strPkWeekTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPkWeekTime, 2000, convCurrEduCls_Syn.PkWeekTime);
}
objvCurrEduCls_SynEN.PkWeekTime = strPkWeekTime; //排课时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.PkWeekTime) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.PkWeekTime, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.PkWeekTime] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetPkClassRooms(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strPkClassRooms, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPkClassRooms, 150, convCurrEduCls_Syn.PkClassRooms);
}
objvCurrEduCls_SynEN.PkClassRooms = strPkClassRooms; //排课教室
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.PkClassRooms) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.PkClassRooms, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.PkClassRooms] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetBeginWeek(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, short? shtBeginWeek, string strComparisonOp="")
	{
objvCurrEduCls_SynEN.BeginWeek = shtBeginWeek; //开始周
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.BeginWeek) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.BeginWeek, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.BeginWeek] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetTeacherNames(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strTeacherNames, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeacherNames, 100, convCurrEduCls_Syn.TeacherNames);
}
objvCurrEduCls_SynEN.TeacherNames = strTeacherNames; //教师姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.TeacherNames) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.TeacherNames, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.TeacherNames] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetIsSynch(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, bool bolIsSynch, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsSynch, convCurrEduCls_Syn.IsSynch);
objvCurrEduCls_SynEN.IsSynch = bolIsSynch; //是否同步
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.IsSynch) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.IsSynch, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.IsSynch] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetSynchDate(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strSynchDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSynchDate, convCurrEduCls_Syn.SynchDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynchDate, 30, convCurrEduCls_Syn.SynchDate);
}
objvCurrEduCls_SynEN.SynchDate = strSynchDate; //同步日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.SynchDate) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.SynchDate, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.SynchDate] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetModifyDate(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strModifyDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyDate, 20, convCurrEduCls_Syn.ModifyDate);
}
objvCurrEduCls_SynEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.ModifyDate) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.ModifyDate, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.ModifyDate] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetModifyUserId(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strModifyUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyUserId, 18, convCurrEduCls_Syn.ModifyUserId);
}
objvCurrEduCls_SynEN.ModifyUserId = strModifyUserId; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.ModifyUserId) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.ModifyUserId, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.ModifyUserId] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetMemo(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCurrEduCls_Syn.Memo);
}
objvCurrEduCls_SynEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.Memo) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.Memo, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.Memo] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetSignInDate(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strSignInDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSignInDate, 20, convCurrEduCls_Syn.SignInDate);
}
objvCurrEduCls_SynEN.SignInDate = strSignInDate; //签入时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.SignInDate) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.SignInDate, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.SignInDate] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetSignInStateID(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strSignInStateID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSignInStateID, 2, convCurrEduCls_Syn.SignInStateID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSignInStateID, 2, convCurrEduCls_Syn.SignInStateID);
}
objvCurrEduCls_SynEN.SignInStateID = strSignInStateID; //签入状态表流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.SignInStateID) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.SignInStateID, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.SignInStateID] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetSignInUser(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strSignInUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSignInUser, 18, convCurrEduCls_Syn.SignInUser);
}
objvCurrEduCls_SynEN.SignInUser = strSignInUser; //签入人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.SignInUser) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.SignInUser, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.SignInUser] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetSynchToWebUser(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strSynchToWebUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynchToWebUser, 18, convCurrEduCls_Syn.SynchToWebUser);
}
objvCurrEduCls_SynEN.SynchToWebUser = strSynchToWebUser; //同步Web用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.SynchToWebUser) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.SynchToWebUser, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.SynchToWebUser] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetIsSynchToWeb(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, bool bolIsSynchToWeb, string strComparisonOp="")
	{
objvCurrEduCls_SynEN.IsSynchToWeb = bolIsSynchToWeb; //是否同步Web
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.IsSynchToWeb) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.IsSynchToWeb, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.IsSynchToWeb] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetSynchToWebDate(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strSynchToWebDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynchToWebDate, 20, convCurrEduCls_Syn.SynchToWebDate);
}
objvCurrEduCls_SynEN.SynchToWebDate = strSynchToWebDate; //同步Web日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.SynchToWebDate) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.SynchToWebDate, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.SynchToWebDate] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynENS">源对象</param>
 /// <param name = "objvCurrEduCls_SynENT">目标对象</param>
 public static void CopyTo(this clsvCurrEduCls_SynEN objvCurrEduCls_SynENS, clsvCurrEduCls_SynEN objvCurrEduCls_SynENT)
{
try
{
objvCurrEduCls_SynENT.IdCurrEduCls = objvCurrEduCls_SynENS.IdCurrEduCls; //教学班流水号
objvCurrEduCls_SynENT.EduClsTypeName = objvCurrEduCls_SynENS.EduClsTypeName; //教学班类型名称
objvCurrEduCls_SynENT.CourseCode = objvCurrEduCls_SynENS.CourseCode; //课程代码
objvCurrEduCls_SynENT.CourseDescription = objvCurrEduCls_SynENS.CourseDescription; //课程描述
objvCurrEduCls_SynENT.CourseName = objvCurrEduCls_SynENS.CourseName; //课程名称
objvCurrEduCls_SynENT.ViewCount = objvCurrEduCls_SynENS.ViewCount; //浏览量
objvCurrEduCls_SynENT.ExampleImgPath = objvCurrEduCls_SynENS.ExampleImgPath; //示例图路径
objvCurrEduCls_SynENT.TeachingSolutionName = objvCurrEduCls_SynENS.TeachingSolutionName; //教学方案名称
objvCurrEduCls_SynENT.IdTeacher = objvCurrEduCls_SynENS.IdTeacher; //教师流水号
objvCurrEduCls_SynENT.TeacherId = objvCurrEduCls_SynENS.TeacherId; //教师工号
objvCurrEduCls_SynENT.TeacherName = objvCurrEduCls_SynENS.TeacherName; //教师姓名
objvCurrEduCls_SynENT.CollegeId = objvCurrEduCls_SynENS.CollegeId; //学院ID
objvCurrEduCls_SynENT.CollegeName = objvCurrEduCls_SynENS.CollegeName; //学院名称
objvCurrEduCls_SynENT.IdXzMajor = objvCurrEduCls_SynENS.IdXzMajor; //专业流水号
objvCurrEduCls_SynENT.MajorName = objvCurrEduCls_SynENS.MajorName; //专业名称
objvCurrEduCls_SynENT.GradeBaseId = objvCurrEduCls_SynENS.GradeBaseId; //年级代号
objvCurrEduCls_SynENT.GradeBaseName = objvCurrEduCls_SynENS.GradeBaseName; //年级名称
objvCurrEduCls_SynENT.GradeBaseNameA = objvCurrEduCls_SynENS.GradeBaseNameA; //年级名称缩写
objvCurrEduCls_SynENT.CourseTypeId = objvCurrEduCls_SynENS.CourseTypeId; //课程类型ID
objvCurrEduCls_SynENT.CourseTypeName = objvCurrEduCls_SynENS.CourseTypeName; //课程类型名称
objvCurrEduCls_SynENT.CurrStuNumValid = objvCurrEduCls_SynENS.CurrStuNumValid; //CurrStuNum_Valid
objvCurrEduCls_SynENT.CurrStuNum = objvCurrEduCls_SynENS.CurrStuNum; //当前学生数
objvCurrEduCls_SynENT.CurrEduClsId = objvCurrEduCls_SynENS.CurrEduClsId; //教学班Id
objvCurrEduCls_SynENT.EduClsName = objvCurrEduCls_SynENS.EduClsName; //教学班名
objvCurrEduCls_SynENT.EduClsTypeId = objvCurrEduCls_SynENS.EduClsTypeId; //教学班类型Id
objvCurrEduCls_SynENT.CourseId = objvCurrEduCls_SynENS.CourseId; //课程Id
objvCurrEduCls_SynENT.TeachingSolutionId = objvCurrEduCls_SynENS.TeachingSolutionId; //教学方案Id
objvCurrEduCls_SynENT.IdXzCollege = objvCurrEduCls_SynENS.IdXzCollege; //学院流水号
objvCurrEduCls_SynENT.IdEduWay = objvCurrEduCls_SynENS.IdEduWay; //教学方式流水号
objvCurrEduCls_SynENT.IdClassRoomType = objvCurrEduCls_SynENS.IdClassRoomType; //教室类型流水号
objvCurrEduCls_SynENT.TotalLessonQty = objvCurrEduCls_SynENS.TotalLessonQty; //总课时数
objvCurrEduCls_SynENT.MaxStuQty = objvCurrEduCls_SynENS.MaxStuQty; //最大学生数
objvCurrEduCls_SynENT.WeekQty = objvCurrEduCls_SynENS.WeekQty; //总周数
objvCurrEduCls_SynENT.ScheUnitPW = objvCurrEduCls_SynENS.ScheUnitPW; //周排课次数
objvCurrEduCls_SynENT.WeekStatusId = objvCurrEduCls_SynENS.WeekStatusId; //周状态编号(单,双,全周)
objvCurrEduCls_SynENT.CustomerWeek = objvCurrEduCls_SynENS.CustomerWeek; //自定义上课周
objvCurrEduCls_SynENT.IsCompleteScore = objvCurrEduCls_SynENS.IsCompleteScore; //是否成绩齐全
objvCurrEduCls_SynENT.IdExecPlan = objvCurrEduCls_SynENS.IdExecPlan; //执行计划流水号
objvCurrEduCls_SynENT.LessonQtyPerWeek = objvCurrEduCls_SynENS.LessonQtyPerWeek; //周课时数
objvCurrEduCls_SynENT.Mark = objvCurrEduCls_SynENS.Mark; //获得学分
objvCurrEduCls_SynENT.CheckClassRoom = objvCurrEduCls_SynENS.CheckClassRoom; //检查教室结果
objvCurrEduCls_SynENT.CheckAdminCls = objvCurrEduCls_SynENS.CheckAdminCls; //检查行政班结果
objvCurrEduCls_SynENT.CheckTeacher = objvCurrEduCls_SynENS.CheckTeacher; //检查教师结果
objvCurrEduCls_SynENT.EditLocked = objvCurrEduCls_SynENS.EditLocked; //编辑锁定
objvCurrEduCls_SynENT.Sched = objvCurrEduCls_SynENS.Sched; //是否排课
objvCurrEduCls_SynENT.IdUniZone = objvCurrEduCls_SynENS.IdUniZone; //校区流水号
objvCurrEduCls_SynENT.Locked = objvCurrEduCls_SynENS.Locked; //锁定状态
objvCurrEduCls_SynENT.IdGradeBase = objvCurrEduCls_SynENS.IdGradeBase; //年级流水号
objvCurrEduCls_SynENT.IsEffective = objvCurrEduCls_SynENS.IsEffective; //是否有效
objvCurrEduCls_SynENT.IsForPaperReading = objvCurrEduCls_SynENS.IsForPaperReading; //是否参与论文阅读
objvCurrEduCls_SynENT.IsUnDeterminedClsRm = objvCurrEduCls_SynENS.IsUnDeterminedClsRm; //是否待定教室
objvCurrEduCls_SynENT.SchoolYear = objvCurrEduCls_SynENS.SchoolYear; //学年
objvCurrEduCls_SynENT.SchoolTerm = objvCurrEduCls_SynENS.SchoolTerm; //学期
objvCurrEduCls_SynENT.ArrangeCourseMemo = objvCurrEduCls_SynENS.ArrangeCourseMemo; //排课备注
objvCurrEduCls_SynENT.IdCourseType = objvCurrEduCls_SynENS.IdCourseType; //课程类型流水号
objvCurrEduCls_SynENT.IsDegree = objvCurrEduCls_SynENS.IsDegree; //是否学位课
objvCurrEduCls_SynENT.IdScoreType = objvCurrEduCls_SynENS.IdScoreType; //成绩类型流水号
objvCurrEduCls_SynENT.GetScoreWayId = objvCurrEduCls_SynENS.GetScoreWayId; //获得成绩方式Id
objvCurrEduCls_SynENT.IsProportionalCtrl = objvCurrEduCls_SynENS.IsProportionalCtrl; //是否比例控制
objvCurrEduCls_SynENT.IdExamType = objvCurrEduCls_SynENS.IdExamType; //考试方式流水号
objvCurrEduCls_SynENT.ExamPortion = objvCurrEduCls_SynENS.ExamPortion; //平时成绩所占比例
objvCurrEduCls_SynENT.MidExamScorePortion = objvCurrEduCls_SynENS.MidExamScorePortion; //期末成绩所占比例
objvCurrEduCls_SynENT.IsClearScore = objvCurrEduCls_SynENS.IsClearScore; //是否重录成绩
objvCurrEduCls_SynENT.IsGeneratePwd = objvCurrEduCls_SynENS.IsGeneratePwd; //是否生成口令
objvCurrEduCls_SynENT.GeneratePwdDate = objvCurrEduCls_SynENS.GeneratePwdDate; //生成口令时间
objvCurrEduCls_SynENT.PkWeekTime = objvCurrEduCls_SynENS.PkWeekTime; //排课时间
objvCurrEduCls_SynENT.PkClassRooms = objvCurrEduCls_SynENS.PkClassRooms; //排课教室
objvCurrEduCls_SynENT.BeginWeek = objvCurrEduCls_SynENS.BeginWeek; //开始周
objvCurrEduCls_SynENT.TeacherNames = objvCurrEduCls_SynENS.TeacherNames; //教师姓名
objvCurrEduCls_SynENT.IsSynch = objvCurrEduCls_SynENS.IsSynch; //是否同步
objvCurrEduCls_SynENT.SynchDate = objvCurrEduCls_SynENS.SynchDate; //同步日期
objvCurrEduCls_SynENT.ModifyDate = objvCurrEduCls_SynENS.ModifyDate; //修改日期
objvCurrEduCls_SynENT.ModifyUserId = objvCurrEduCls_SynENS.ModifyUserId; //修改人
objvCurrEduCls_SynENT.Memo = objvCurrEduCls_SynENS.Memo; //备注
objvCurrEduCls_SynENT.SignInDate = objvCurrEduCls_SynENS.SignInDate; //签入时间
objvCurrEduCls_SynENT.SignInStateID = objvCurrEduCls_SynENS.SignInStateID; //签入状态表流水号
objvCurrEduCls_SynENT.SignInUser = objvCurrEduCls_SynENS.SignInUser; //签入人
objvCurrEduCls_SynENT.SynchToWebUser = objvCurrEduCls_SynENS.SynchToWebUser; //同步Web用户
objvCurrEduCls_SynENT.IsSynchToWeb = objvCurrEduCls_SynENS.IsSynchToWeb; //是否同步Web
objvCurrEduCls_SynENT.SynchToWebDate = objvCurrEduCls_SynENS.SynchToWebDate; //同步Web日期
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
 /// <param name = "objvCurrEduCls_SynENS">源对象</param>
 /// <returns>目标对象=>clsvCurrEduCls_SynEN:objvCurrEduCls_SynENT</returns>
 public static clsvCurrEduCls_SynEN CopyTo(this clsvCurrEduCls_SynEN objvCurrEduCls_SynENS)
{
try
{
 clsvCurrEduCls_SynEN objvCurrEduCls_SynENT = new clsvCurrEduCls_SynEN()
{
IdCurrEduCls = objvCurrEduCls_SynENS.IdCurrEduCls, //教学班流水号
EduClsTypeName = objvCurrEduCls_SynENS.EduClsTypeName, //教学班类型名称
CourseCode = objvCurrEduCls_SynENS.CourseCode, //课程代码
CourseDescription = objvCurrEduCls_SynENS.CourseDescription, //课程描述
CourseName = objvCurrEduCls_SynENS.CourseName, //课程名称
ViewCount = objvCurrEduCls_SynENS.ViewCount, //浏览量
ExampleImgPath = objvCurrEduCls_SynENS.ExampleImgPath, //示例图路径
TeachingSolutionName = objvCurrEduCls_SynENS.TeachingSolutionName, //教学方案名称
IdTeacher = objvCurrEduCls_SynENS.IdTeacher, //教师流水号
TeacherId = objvCurrEduCls_SynENS.TeacherId, //教师工号
TeacherName = objvCurrEduCls_SynENS.TeacherName, //教师姓名
CollegeId = objvCurrEduCls_SynENS.CollegeId, //学院ID
CollegeName = objvCurrEduCls_SynENS.CollegeName, //学院名称
IdXzMajor = objvCurrEduCls_SynENS.IdXzMajor, //专业流水号
MajorName = objvCurrEduCls_SynENS.MajorName, //专业名称
GradeBaseId = objvCurrEduCls_SynENS.GradeBaseId, //年级代号
GradeBaseName = objvCurrEduCls_SynENS.GradeBaseName, //年级名称
GradeBaseNameA = objvCurrEduCls_SynENS.GradeBaseNameA, //年级名称缩写
CourseTypeId = objvCurrEduCls_SynENS.CourseTypeId, //课程类型ID
CourseTypeName = objvCurrEduCls_SynENS.CourseTypeName, //课程类型名称
CurrStuNumValid = objvCurrEduCls_SynENS.CurrStuNumValid, //CurrStuNum_Valid
CurrStuNum = objvCurrEduCls_SynENS.CurrStuNum, //当前学生数
CurrEduClsId = objvCurrEduCls_SynENS.CurrEduClsId, //教学班Id
EduClsName = objvCurrEduCls_SynENS.EduClsName, //教学班名
EduClsTypeId = objvCurrEduCls_SynENS.EduClsTypeId, //教学班类型Id
CourseId = objvCurrEduCls_SynENS.CourseId, //课程Id
TeachingSolutionId = objvCurrEduCls_SynENS.TeachingSolutionId, //教学方案Id
IdXzCollege = objvCurrEduCls_SynENS.IdXzCollege, //学院流水号
IdEduWay = objvCurrEduCls_SynENS.IdEduWay, //教学方式流水号
IdClassRoomType = objvCurrEduCls_SynENS.IdClassRoomType, //教室类型流水号
TotalLessonQty = objvCurrEduCls_SynENS.TotalLessonQty, //总课时数
MaxStuQty = objvCurrEduCls_SynENS.MaxStuQty, //最大学生数
WeekQty = objvCurrEduCls_SynENS.WeekQty, //总周数
ScheUnitPW = objvCurrEduCls_SynENS.ScheUnitPW, //周排课次数
WeekStatusId = objvCurrEduCls_SynENS.WeekStatusId, //周状态编号(单,双,全周)
CustomerWeek = objvCurrEduCls_SynENS.CustomerWeek, //自定义上课周
IsCompleteScore = objvCurrEduCls_SynENS.IsCompleteScore, //是否成绩齐全
IdExecPlan = objvCurrEduCls_SynENS.IdExecPlan, //执行计划流水号
LessonQtyPerWeek = objvCurrEduCls_SynENS.LessonQtyPerWeek, //周课时数
Mark = objvCurrEduCls_SynENS.Mark, //获得学分
CheckClassRoom = objvCurrEduCls_SynENS.CheckClassRoom, //检查教室结果
CheckAdminCls = objvCurrEduCls_SynENS.CheckAdminCls, //检查行政班结果
CheckTeacher = objvCurrEduCls_SynENS.CheckTeacher, //检查教师结果
EditLocked = objvCurrEduCls_SynENS.EditLocked, //编辑锁定
Sched = objvCurrEduCls_SynENS.Sched, //是否排课
IdUniZone = objvCurrEduCls_SynENS.IdUniZone, //校区流水号
Locked = objvCurrEduCls_SynENS.Locked, //锁定状态
IdGradeBase = objvCurrEduCls_SynENS.IdGradeBase, //年级流水号
IsEffective = objvCurrEduCls_SynENS.IsEffective, //是否有效
IsForPaperReading = objvCurrEduCls_SynENS.IsForPaperReading, //是否参与论文阅读
IsUnDeterminedClsRm = objvCurrEduCls_SynENS.IsUnDeterminedClsRm, //是否待定教室
SchoolYear = objvCurrEduCls_SynENS.SchoolYear, //学年
SchoolTerm = objvCurrEduCls_SynENS.SchoolTerm, //学期
ArrangeCourseMemo = objvCurrEduCls_SynENS.ArrangeCourseMemo, //排课备注
IdCourseType = objvCurrEduCls_SynENS.IdCourseType, //课程类型流水号
IsDegree = objvCurrEduCls_SynENS.IsDegree, //是否学位课
IdScoreType = objvCurrEduCls_SynENS.IdScoreType, //成绩类型流水号
GetScoreWayId = objvCurrEduCls_SynENS.GetScoreWayId, //获得成绩方式Id
IsProportionalCtrl = objvCurrEduCls_SynENS.IsProportionalCtrl, //是否比例控制
IdExamType = objvCurrEduCls_SynENS.IdExamType, //考试方式流水号
ExamPortion = objvCurrEduCls_SynENS.ExamPortion, //平时成绩所占比例
MidExamScorePortion = objvCurrEduCls_SynENS.MidExamScorePortion, //期末成绩所占比例
IsClearScore = objvCurrEduCls_SynENS.IsClearScore, //是否重录成绩
IsGeneratePwd = objvCurrEduCls_SynENS.IsGeneratePwd, //是否生成口令
GeneratePwdDate = objvCurrEduCls_SynENS.GeneratePwdDate, //生成口令时间
PkWeekTime = objvCurrEduCls_SynENS.PkWeekTime, //排课时间
PkClassRooms = objvCurrEduCls_SynENS.PkClassRooms, //排课教室
BeginWeek = objvCurrEduCls_SynENS.BeginWeek, //开始周
TeacherNames = objvCurrEduCls_SynENS.TeacherNames, //教师姓名
IsSynch = objvCurrEduCls_SynENS.IsSynch, //是否同步
SynchDate = objvCurrEduCls_SynENS.SynchDate, //同步日期
ModifyDate = objvCurrEduCls_SynENS.ModifyDate, //修改日期
ModifyUserId = objvCurrEduCls_SynENS.ModifyUserId, //修改人
Memo = objvCurrEduCls_SynENS.Memo, //备注
SignInDate = objvCurrEduCls_SynENS.SignInDate, //签入时间
SignInStateID = objvCurrEduCls_SynENS.SignInStateID, //签入状态表流水号
SignInUser = objvCurrEduCls_SynENS.SignInUser, //签入人
SynchToWebUser = objvCurrEduCls_SynENS.SynchToWebUser, //同步Web用户
IsSynchToWeb = objvCurrEduCls_SynENS.IsSynchToWeb, //是否同步Web
SynchToWebDate = objvCurrEduCls_SynENS.SynchToWebDate, //同步Web日期
};
 return objvCurrEduCls_SynENT;
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
public static void CheckProperty4Condition(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN)
{
 clsvCurrEduCls_SynBL.vCurrEduCls_SynDA.CheckProperty4Condition(objvCurrEduCls_SynEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCurrEduCls_SynEN objvCurrEduCls_SynCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.IdCurrEduCls, objvCurrEduCls_SynCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.EduClsTypeName) == true)
{
string strComparisonOpEduClsTypeName = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.EduClsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.EduClsTypeName, objvCurrEduCls_SynCond.EduClsTypeName, strComparisonOpEduClsTypeName);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.CourseCode) == true)
{
string strComparisonOpCourseCode = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.CourseCode, objvCurrEduCls_SynCond.CourseCode, strComparisonOpCourseCode);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.CourseDescription) == true)
{
string strComparisonOpCourseDescription = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.CourseDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.CourseDescription, objvCurrEduCls_SynCond.CourseDescription, strComparisonOpCourseDescription);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.CourseName) == true)
{
string strComparisonOpCourseName = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.CourseName, objvCurrEduCls_SynCond.CourseName, strComparisonOpCourseName);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.ViewCount) == true)
{
string strComparisonOpViewCount = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls_Syn.ViewCount, objvCurrEduCls_SynCond.ViewCount, strComparisonOpViewCount);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.ExampleImgPath) == true)
{
string strComparisonOpExampleImgPath = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.ExampleImgPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.ExampleImgPath, objvCurrEduCls_SynCond.ExampleImgPath, strComparisonOpExampleImgPath);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.TeachingSolutionName) == true)
{
string strComparisonOpTeachingSolutionName = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.TeachingSolutionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.TeachingSolutionName, objvCurrEduCls_SynCond.TeachingSolutionName, strComparisonOpTeachingSolutionName);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.IdTeacher) == true)
{
string strComparisonOpIdTeacher = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.IdTeacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.IdTeacher, objvCurrEduCls_SynCond.IdTeacher, strComparisonOpIdTeacher);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.TeacherId) == true)
{
string strComparisonOpTeacherId = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.TeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.TeacherId, objvCurrEduCls_SynCond.TeacherId, strComparisonOpTeacherId);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.TeacherName) == true)
{
string strComparisonOpTeacherName = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.TeacherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.TeacherName, objvCurrEduCls_SynCond.TeacherName, strComparisonOpTeacherName);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.CollegeId) == true)
{
string strComparisonOpCollegeId = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.CollegeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.CollegeId, objvCurrEduCls_SynCond.CollegeId, strComparisonOpCollegeId);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.CollegeName) == true)
{
string strComparisonOpCollegeName = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.CollegeName, objvCurrEduCls_SynCond.CollegeName, strComparisonOpCollegeName);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.IdXzMajor, objvCurrEduCls_SynCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.MajorName) == true)
{
string strComparisonOpMajorName = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.MajorName, objvCurrEduCls_SynCond.MajorName, strComparisonOpMajorName);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.GradeBaseId) == true)
{
string strComparisonOpGradeBaseId = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.GradeBaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.GradeBaseId, objvCurrEduCls_SynCond.GradeBaseId, strComparisonOpGradeBaseId);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.GradeBaseName) == true)
{
string strComparisonOpGradeBaseName = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.GradeBaseName, objvCurrEduCls_SynCond.GradeBaseName, strComparisonOpGradeBaseName);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.GradeBaseNameA) == true)
{
string strComparisonOpGradeBaseNameA = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.GradeBaseNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.GradeBaseNameA, objvCurrEduCls_SynCond.GradeBaseNameA, strComparisonOpGradeBaseNameA);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.CourseTypeId) == true)
{
string strComparisonOpCourseTypeId = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.CourseTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.CourseTypeId, objvCurrEduCls_SynCond.CourseTypeId, strComparisonOpCourseTypeId);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.CourseTypeName) == true)
{
string strComparisonOpCourseTypeName = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.CourseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.CourseTypeName, objvCurrEduCls_SynCond.CourseTypeName, strComparisonOpCourseTypeName);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.CurrStuNumValid) == true)
{
string strComparisonOpCurrStuNumValid = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.CurrStuNumValid];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls_Syn.CurrStuNumValid, objvCurrEduCls_SynCond.CurrStuNumValid, strComparisonOpCurrStuNumValid);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.CurrStuNum) == true)
{
string strComparisonOpCurrStuNum = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.CurrStuNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls_Syn.CurrStuNum, objvCurrEduCls_SynCond.CurrStuNum, strComparisonOpCurrStuNum);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.CurrEduClsId) == true)
{
string strComparisonOpCurrEduClsId = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.CurrEduClsId, objvCurrEduCls_SynCond.CurrEduClsId, strComparisonOpCurrEduClsId);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.EduClsName) == true)
{
string strComparisonOpEduClsName = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.EduClsName, objvCurrEduCls_SynCond.EduClsName, strComparisonOpEduClsName);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.EduClsTypeId) == true)
{
string strComparisonOpEduClsTypeId = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.EduClsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.EduClsTypeId, objvCurrEduCls_SynCond.EduClsTypeId, strComparisonOpEduClsTypeId);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.CourseId) == true)
{
string strComparisonOpCourseId = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.CourseId, objvCurrEduCls_SynCond.CourseId, strComparisonOpCourseId);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.TeachingSolutionId) == true)
{
string strComparisonOpTeachingSolutionId = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.TeachingSolutionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.TeachingSolutionId, objvCurrEduCls_SynCond.TeachingSolutionId, strComparisonOpTeachingSolutionId);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.IdXzCollege, objvCurrEduCls_SynCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.IdEduWay) == true)
{
string strComparisonOpIdEduWay = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.IdEduWay];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.IdEduWay, objvCurrEduCls_SynCond.IdEduWay, strComparisonOpIdEduWay);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.IdClassRoomType) == true)
{
string strComparisonOpIdClassRoomType = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.IdClassRoomType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.IdClassRoomType, objvCurrEduCls_SynCond.IdClassRoomType, strComparisonOpIdClassRoomType);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.TotalLessonQty) == true)
{
string strComparisonOpTotalLessonQty = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.TotalLessonQty];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls_Syn.TotalLessonQty, objvCurrEduCls_SynCond.TotalLessonQty, strComparisonOpTotalLessonQty);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.MaxStuQty) == true)
{
string strComparisonOpMaxStuQty = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.MaxStuQty];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls_Syn.MaxStuQty, objvCurrEduCls_SynCond.MaxStuQty, strComparisonOpMaxStuQty);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.WeekQty) == true)
{
string strComparisonOpWeekQty = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.WeekQty];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls_Syn.WeekQty, objvCurrEduCls_SynCond.WeekQty, strComparisonOpWeekQty);
}
//数据类型short(smallint)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.WeekStatusId) == true)
{
string strComparisonOpWeekStatusId = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.WeekStatusId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.WeekStatusId, objvCurrEduCls_SynCond.WeekStatusId, strComparisonOpWeekStatusId);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.CustomerWeek) == true)
{
string strComparisonOpCustomerWeek = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.CustomerWeek];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.CustomerWeek, objvCurrEduCls_SynCond.CustomerWeek, strComparisonOpCustomerWeek);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.IsCompleteScore) == true)
{
if (objvCurrEduCls_SynCond.IsCompleteScore == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls_Syn.IsCompleteScore);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls_Syn.IsCompleteScore);
}
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.IdExecPlan) == true)
{
string strComparisonOpIdExecPlan = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.IdExecPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.IdExecPlan, objvCurrEduCls_SynCond.IdExecPlan, strComparisonOpIdExecPlan);
}
//数据类型short(smallint)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.Mark) == true)
{
string strComparisonOpMark = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.Mark];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls_Syn.Mark, objvCurrEduCls_SynCond.Mark, strComparisonOpMark);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.CheckClassRoom) == true)
{
string strComparisonOpCheckClassRoom = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.CheckClassRoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.CheckClassRoom, objvCurrEduCls_SynCond.CheckClassRoom, strComparisonOpCheckClassRoom);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.CheckAdminCls) == true)
{
string strComparisonOpCheckAdminCls = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.CheckAdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.CheckAdminCls, objvCurrEduCls_SynCond.CheckAdminCls, strComparisonOpCheckAdminCls);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.CheckTeacher) == true)
{
string strComparisonOpCheckTeacher = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.CheckTeacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.CheckTeacher, objvCurrEduCls_SynCond.CheckTeacher, strComparisonOpCheckTeacher);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.EditLocked) == true)
{
if (objvCurrEduCls_SynCond.EditLocked == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls_Syn.EditLocked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls_Syn.EditLocked);
}
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.Sched) == true)
{
if (objvCurrEduCls_SynCond.Sched == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls_Syn.Sched);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls_Syn.Sched);
}
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.IdUniZone) == true)
{
string strComparisonOpIdUniZone = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.IdUniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.IdUniZone, objvCurrEduCls_SynCond.IdUniZone, strComparisonOpIdUniZone);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.Locked) == true)
{
if (objvCurrEduCls_SynCond.Locked == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls_Syn.Locked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls_Syn.Locked);
}
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.IdGradeBase, objvCurrEduCls_SynCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.IsEffective) == true)
{
if (objvCurrEduCls_SynCond.IsEffective == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls_Syn.IsEffective);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls_Syn.IsEffective);
}
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.IsForPaperReading) == true)
{
if (objvCurrEduCls_SynCond.IsForPaperReading == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls_Syn.IsForPaperReading);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls_Syn.IsForPaperReading);
}
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.IsUnDeterminedClsRm) == true)
{
if (objvCurrEduCls_SynCond.IsUnDeterminedClsRm == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls_Syn.IsUnDeterminedClsRm);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls_Syn.IsUnDeterminedClsRm);
}
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.SchoolYear) == true)
{
string strComparisonOpSchoolYear = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.SchoolYear, objvCurrEduCls_SynCond.SchoolYear, strComparisonOpSchoolYear);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.SchoolTerm) == true)
{
string strComparisonOpSchoolTerm = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.SchoolTerm, objvCurrEduCls_SynCond.SchoolTerm, strComparisonOpSchoolTerm);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.ArrangeCourseMemo) == true)
{
string strComparisonOpArrangeCourseMemo = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.ArrangeCourseMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.ArrangeCourseMemo, objvCurrEduCls_SynCond.ArrangeCourseMemo, strComparisonOpArrangeCourseMemo);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.IdCourseType) == true)
{
string strComparisonOpIdCourseType = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.IdCourseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.IdCourseType, objvCurrEduCls_SynCond.IdCourseType, strComparisonOpIdCourseType);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.IsDegree) == true)
{
if (objvCurrEduCls_SynCond.IsDegree == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls_Syn.IsDegree);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls_Syn.IsDegree);
}
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.IdScoreType) == true)
{
string strComparisonOpIdScoreType = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.IdScoreType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.IdScoreType, objvCurrEduCls_SynCond.IdScoreType, strComparisonOpIdScoreType);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.GetScoreWayId) == true)
{
string strComparisonOpGetScoreWayId = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.GetScoreWayId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.GetScoreWayId, objvCurrEduCls_SynCond.GetScoreWayId, strComparisonOpGetScoreWayId);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.IsProportionalCtrl) == true)
{
if (objvCurrEduCls_SynCond.IsProportionalCtrl == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls_Syn.IsProportionalCtrl);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls_Syn.IsProportionalCtrl);
}
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.IdExamType) == true)
{
string strComparisonOpIdExamType = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.IdExamType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.IdExamType, objvCurrEduCls_SynCond.IdExamType, strComparisonOpIdExamType);
}
//数据类型short(smallint)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
//数据类型short(smallint)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.IsClearScore) == true)
{
if (objvCurrEduCls_SynCond.IsClearScore == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls_Syn.IsClearScore);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls_Syn.IsClearScore);
}
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.IsGeneratePwd) == true)
{
if (objvCurrEduCls_SynCond.IsGeneratePwd == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls_Syn.IsGeneratePwd);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls_Syn.IsGeneratePwd);
}
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.GeneratePwdDate) == true)
{
string strComparisonOpGeneratePwdDate = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.GeneratePwdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.GeneratePwdDate, objvCurrEduCls_SynCond.GeneratePwdDate, strComparisonOpGeneratePwdDate);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.PkWeekTime) == true)
{
string strComparisonOpPkWeekTime = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.PkWeekTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.PkWeekTime, objvCurrEduCls_SynCond.PkWeekTime, strComparisonOpPkWeekTime);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.PkClassRooms) == true)
{
string strComparisonOpPkClassRooms = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.PkClassRooms];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.PkClassRooms, objvCurrEduCls_SynCond.PkClassRooms, strComparisonOpPkClassRooms);
}
//数据类型short(smallint)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.TeacherNames) == true)
{
string strComparisonOpTeacherNames = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.TeacherNames];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.TeacherNames, objvCurrEduCls_SynCond.TeacherNames, strComparisonOpTeacherNames);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.IsSynch) == true)
{
if (objvCurrEduCls_SynCond.IsSynch == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls_Syn.IsSynch);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls_Syn.IsSynch);
}
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.SynchDate) == true)
{
string strComparisonOpSynchDate = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.SynchDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.SynchDate, objvCurrEduCls_SynCond.SynchDate, strComparisonOpSynchDate);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.ModifyDate) == true)
{
string strComparisonOpModifyDate = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.ModifyDate, objvCurrEduCls_SynCond.ModifyDate, strComparisonOpModifyDate);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.ModifyUserId) == true)
{
string strComparisonOpModifyUserId = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.ModifyUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.ModifyUserId, objvCurrEduCls_SynCond.ModifyUserId, strComparisonOpModifyUserId);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.Memo) == true)
{
string strComparisonOpMemo = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.Memo, objvCurrEduCls_SynCond.Memo, strComparisonOpMemo);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.SignInDate) == true)
{
string strComparisonOpSignInDate = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.SignInDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.SignInDate, objvCurrEduCls_SynCond.SignInDate, strComparisonOpSignInDate);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.SignInStateID) == true)
{
string strComparisonOpSignInStateID = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.SignInStateID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.SignInStateID, objvCurrEduCls_SynCond.SignInStateID, strComparisonOpSignInStateID);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.SignInUser) == true)
{
string strComparisonOpSignInUser = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.SignInUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.SignInUser, objvCurrEduCls_SynCond.SignInUser, strComparisonOpSignInUser);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.SynchToWebUser) == true)
{
string strComparisonOpSynchToWebUser = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.SynchToWebUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.SynchToWebUser, objvCurrEduCls_SynCond.SynchToWebUser, strComparisonOpSynchToWebUser);
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.IsSynchToWeb) == true)
{
if (objvCurrEduCls_SynCond.IsSynchToWeb == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls_Syn.IsSynchToWeb);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls_Syn.IsSynchToWeb);
}
}
if (objvCurrEduCls_SynCond.IsUpdated(convCurrEduCls_Syn.SynchToWebDate) == true)
{
string strComparisonOpSynchToWebDate = objvCurrEduCls_SynCond.dicFldComparisonOp[convCurrEduCls_Syn.SynchToWebDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.SynchToWebDate, objvCurrEduCls_SynCond.SynchToWebDate, strComparisonOpSynchToWebDate);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCurrEduCls_Syn
{
public virtual bool UpdRelaTabDate(string strIdCurrEduCls, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vCurrEduCls_Syn(vCurrEduCls_Syn)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCurrEduCls_SynBL
{
public static RelatedActions_vCurrEduCls_Syn relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCurrEduCls_SynDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCurrEduCls_SynDA vCurrEduCls_SynDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCurrEduCls_SynDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCurrEduCls_SynBL()
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
if (string.IsNullOrEmpty(clsvCurrEduCls_SynEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCurrEduCls_SynEN._ConnectString);
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
public static DataTable GetDataTable_vCurrEduCls_Syn(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCurrEduCls_SynDA.GetDataTable_vCurrEduCls_Syn(strWhereCond);
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
objDT = vCurrEduCls_SynDA.GetDataTable(strWhereCond);
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
objDT = vCurrEduCls_SynDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCurrEduCls_SynDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCurrEduCls_SynDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCurrEduCls_SynDA.GetDataTable_Top(objTopPara);
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
objDT = vCurrEduCls_SynDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCurrEduCls_SynDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCurrEduCls_SynDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdCurrEduClsLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCurrEduCls_SynEN> GetObjLstByIdCurrEduClsLst(List<string> arrIdCurrEduClsLst)
{
List<clsvCurrEduCls_SynEN> arrObjLst = new List<clsvCurrEduCls_SynEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdCurrEduClsLst, true);
 string strWhereCond = string.Format("IdCurrEduCls in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduCls_SynEN objvCurrEduCls_SynEN = new clsvCurrEduCls_SynEN();
try
{
objvCurrEduCls_SynEN.IdCurrEduCls = objRow[convCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduCls_SynEN.EduClsTypeName = objRow[convCurrEduCls_Syn.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduCls_SynEN.CourseCode = objRow[convCurrEduCls_Syn.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseCode].ToString().Trim(); //课程代码
objvCurrEduCls_SynEN.CourseDescription = objRow[convCurrEduCls_Syn.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseDescription].ToString().Trim(); //课程描述
objvCurrEduCls_SynEN.CourseName = objRow[convCurrEduCls_Syn.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseName].ToString().Trim(); //课程名称
objvCurrEduCls_SynEN.ViewCount = objRow[convCurrEduCls_Syn.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.ViewCount].ToString().Trim()); //浏览量
objvCurrEduCls_SynEN.ExampleImgPath = objRow[convCurrEduCls_Syn.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduCls_SynEN.TeachingSolutionName = objRow[convCurrEduCls_Syn.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduCls_SynEN.IdTeacher = objRow[convCurrEduCls_Syn.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduCls_SynEN.TeacherId = objRow[convCurrEduCls_Syn.TeacherId].ToString().Trim(); //教师工号
objvCurrEduCls_SynEN.TeacherName = objRow[convCurrEduCls_Syn.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduCls_SynEN.CollegeId = objRow[convCurrEduCls_Syn.CollegeId].ToString().Trim(); //学院ID
objvCurrEduCls_SynEN.CollegeName = objRow[convCurrEduCls_Syn.CollegeName].ToString().Trim(); //学院名称
objvCurrEduCls_SynEN.IdXzMajor = objRow[convCurrEduCls_Syn.IdXzMajor].ToString().Trim(); //专业流水号
objvCurrEduCls_SynEN.MajorName = objRow[convCurrEduCls_Syn.MajorName].ToString().Trim(); //专业名称
objvCurrEduCls_SynEN.GradeBaseId = objRow[convCurrEduCls_Syn.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduCls_SynEN.GradeBaseName = objRow[convCurrEduCls_Syn.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduCls_SynEN.GradeBaseNameA = objRow[convCurrEduCls_Syn.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvCurrEduCls_SynEN.CourseTypeId = objRow[convCurrEduCls_Syn.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduCls_SynEN.CourseTypeName = objRow[convCurrEduCls_Syn.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduCls_SynEN.CurrStuNumValid = objRow[convCurrEduCls_Syn.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduCls_SynEN.CurrStuNum = objRow[convCurrEduCls_Syn.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduCls_SynEN.CurrEduClsId = objRow[convCurrEduCls_Syn.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduCls_SynEN.EduClsName = objRow[convCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名
objvCurrEduCls_SynEN.EduClsTypeId = objRow[convCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduCls_SynEN.CourseId = objRow[convCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id
objvCurrEduCls_SynEN.TeachingSolutionId = objRow[convCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduCls_SynEN.IdXzCollege = objRow[convCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduCls_SynEN.IdEduWay = objRow[convCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduCls_SynEN.IdClassRoomType = objRow[convCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号
objvCurrEduCls_SynEN.TotalLessonQty = Int32.Parse(objRow[convCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduCls_SynEN.MaxStuQty = objRow[convCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduCls_SynEN.WeekQty = objRow[convCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数
objvCurrEduCls_SynEN.ScheUnitPW = objRow[convCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduCls_SynEN.WeekStatusId = objRow[convCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduCls_SynEN.CustomerWeek = objRow[convCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduCls_SynEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objvCurrEduCls_SynEN.IdExecPlan = objRow[convCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号
objvCurrEduCls_SynEN.LessonQtyPerWeek = short.Parse(objRow[convCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduCls_SynEN.Mark = objRow[convCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分
objvCurrEduCls_SynEN.CheckClassRoom = objRow[convCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果
objvCurrEduCls_SynEN.CheckAdminCls = objRow[convCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果
objvCurrEduCls_SynEN.CheckTeacher = objRow[convCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果
objvCurrEduCls_SynEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定
objvCurrEduCls_SynEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课
objvCurrEduCls_SynEN.IdUniZone = objRow[convCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduCls_SynEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态
objvCurrEduCls_SynEN.IdGradeBase = objRow[convCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduCls_SynEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效
objvCurrEduCls_SynEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objvCurrEduCls_SynEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objvCurrEduCls_SynEN.SchoolYear = objRow[convCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年
objvCurrEduCls_SynEN.SchoolTerm = objRow[convCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期
objvCurrEduCls_SynEN.ArrangeCourseMemo = objRow[convCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注
objvCurrEduCls_SynEN.IdCourseType = objRow[convCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduCls_SynEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduCls_SynEN.IdScoreType = objRow[convCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduCls_SynEN.GetScoreWayId = objRow[convCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objvCurrEduCls_SynEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduCls_SynEN.IdExamType = objRow[convCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduCls_SynEN.ExamPortion = short.Parse(objRow[convCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例
objvCurrEduCls_SynEN.MidExamScorePortion = objRow[convCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objvCurrEduCls_SynEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩
objvCurrEduCls_SynEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令
objvCurrEduCls_SynEN.GeneratePwdDate = objRow[convCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间
objvCurrEduCls_SynEN.PkWeekTime = objRow[convCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间
objvCurrEduCls_SynEN.PkClassRooms = objRow[convCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室
objvCurrEduCls_SynEN.BeginWeek = objRow[convCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周
objvCurrEduCls_SynEN.TeacherNames = objRow[convCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名
objvCurrEduCls_SynEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步
objvCurrEduCls_SynEN.SynchDate = objRow[convCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期
objvCurrEduCls_SynEN.ModifyDate = objRow[convCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduCls_SynEN.ModifyUserId = objRow[convCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduCls_SynEN.Memo = objRow[convCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.Memo].ToString().Trim(); //备注
objvCurrEduCls_SynEN.SignInDate = objRow[convCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间
objvCurrEduCls_SynEN.SignInStateID = objRow[convCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号
objvCurrEduCls_SynEN.SignInUser = objRow[convCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人
objvCurrEduCls_SynEN.SynchToWebUser = objRow[convCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户
objvCurrEduCls_SynEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web
objvCurrEduCls_SynEN.SynchToWebDate = objRow[convCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduCls_SynEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduCls_SynEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdCurrEduClsLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCurrEduCls_SynEN> GetObjLstByIdCurrEduClsLstCache(List<string> arrIdCurrEduClsLst)
{
string strKey = string.Format("{0}", clsvCurrEduCls_SynEN._CurrTabName);
List<clsvCurrEduCls_SynEN> arrvCurrEduCls_SynObjLstCache = GetObjLstCache();
IEnumerable <clsvCurrEduCls_SynEN> arrvCurrEduCls_SynObjLst_Sel =
arrvCurrEduCls_SynObjLstCache
.Where(x => arrIdCurrEduClsLst.Contains(x.IdCurrEduCls));
return arrvCurrEduCls_SynObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduCls_SynEN> GetObjLst(string strWhereCond)
{
List<clsvCurrEduCls_SynEN> arrObjLst = new List<clsvCurrEduCls_SynEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduCls_SynEN objvCurrEduCls_SynEN = new clsvCurrEduCls_SynEN();
try
{
objvCurrEduCls_SynEN.IdCurrEduCls = objRow[convCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduCls_SynEN.EduClsTypeName = objRow[convCurrEduCls_Syn.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduCls_SynEN.CourseCode = objRow[convCurrEduCls_Syn.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseCode].ToString().Trim(); //课程代码
objvCurrEduCls_SynEN.CourseDescription = objRow[convCurrEduCls_Syn.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseDescription].ToString().Trim(); //课程描述
objvCurrEduCls_SynEN.CourseName = objRow[convCurrEduCls_Syn.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseName].ToString().Trim(); //课程名称
objvCurrEduCls_SynEN.ViewCount = objRow[convCurrEduCls_Syn.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.ViewCount].ToString().Trim()); //浏览量
objvCurrEduCls_SynEN.ExampleImgPath = objRow[convCurrEduCls_Syn.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduCls_SynEN.TeachingSolutionName = objRow[convCurrEduCls_Syn.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduCls_SynEN.IdTeacher = objRow[convCurrEduCls_Syn.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduCls_SynEN.TeacherId = objRow[convCurrEduCls_Syn.TeacherId].ToString().Trim(); //教师工号
objvCurrEduCls_SynEN.TeacherName = objRow[convCurrEduCls_Syn.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduCls_SynEN.CollegeId = objRow[convCurrEduCls_Syn.CollegeId].ToString().Trim(); //学院ID
objvCurrEduCls_SynEN.CollegeName = objRow[convCurrEduCls_Syn.CollegeName].ToString().Trim(); //学院名称
objvCurrEduCls_SynEN.IdXzMajor = objRow[convCurrEduCls_Syn.IdXzMajor].ToString().Trim(); //专业流水号
objvCurrEduCls_SynEN.MajorName = objRow[convCurrEduCls_Syn.MajorName].ToString().Trim(); //专业名称
objvCurrEduCls_SynEN.GradeBaseId = objRow[convCurrEduCls_Syn.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduCls_SynEN.GradeBaseName = objRow[convCurrEduCls_Syn.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduCls_SynEN.GradeBaseNameA = objRow[convCurrEduCls_Syn.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvCurrEduCls_SynEN.CourseTypeId = objRow[convCurrEduCls_Syn.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduCls_SynEN.CourseTypeName = objRow[convCurrEduCls_Syn.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduCls_SynEN.CurrStuNumValid = objRow[convCurrEduCls_Syn.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduCls_SynEN.CurrStuNum = objRow[convCurrEduCls_Syn.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduCls_SynEN.CurrEduClsId = objRow[convCurrEduCls_Syn.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduCls_SynEN.EduClsName = objRow[convCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名
objvCurrEduCls_SynEN.EduClsTypeId = objRow[convCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduCls_SynEN.CourseId = objRow[convCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id
objvCurrEduCls_SynEN.TeachingSolutionId = objRow[convCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduCls_SynEN.IdXzCollege = objRow[convCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduCls_SynEN.IdEduWay = objRow[convCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduCls_SynEN.IdClassRoomType = objRow[convCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号
objvCurrEduCls_SynEN.TotalLessonQty = Int32.Parse(objRow[convCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduCls_SynEN.MaxStuQty = objRow[convCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduCls_SynEN.WeekQty = objRow[convCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数
objvCurrEduCls_SynEN.ScheUnitPW = objRow[convCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduCls_SynEN.WeekStatusId = objRow[convCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduCls_SynEN.CustomerWeek = objRow[convCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduCls_SynEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objvCurrEduCls_SynEN.IdExecPlan = objRow[convCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号
objvCurrEduCls_SynEN.LessonQtyPerWeek = short.Parse(objRow[convCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduCls_SynEN.Mark = objRow[convCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分
objvCurrEduCls_SynEN.CheckClassRoom = objRow[convCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果
objvCurrEduCls_SynEN.CheckAdminCls = objRow[convCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果
objvCurrEduCls_SynEN.CheckTeacher = objRow[convCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果
objvCurrEduCls_SynEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定
objvCurrEduCls_SynEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课
objvCurrEduCls_SynEN.IdUniZone = objRow[convCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduCls_SynEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态
objvCurrEduCls_SynEN.IdGradeBase = objRow[convCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduCls_SynEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效
objvCurrEduCls_SynEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objvCurrEduCls_SynEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objvCurrEduCls_SynEN.SchoolYear = objRow[convCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年
objvCurrEduCls_SynEN.SchoolTerm = objRow[convCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期
objvCurrEduCls_SynEN.ArrangeCourseMemo = objRow[convCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注
objvCurrEduCls_SynEN.IdCourseType = objRow[convCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduCls_SynEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduCls_SynEN.IdScoreType = objRow[convCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduCls_SynEN.GetScoreWayId = objRow[convCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objvCurrEduCls_SynEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduCls_SynEN.IdExamType = objRow[convCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduCls_SynEN.ExamPortion = short.Parse(objRow[convCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例
objvCurrEduCls_SynEN.MidExamScorePortion = objRow[convCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objvCurrEduCls_SynEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩
objvCurrEduCls_SynEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令
objvCurrEduCls_SynEN.GeneratePwdDate = objRow[convCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间
objvCurrEduCls_SynEN.PkWeekTime = objRow[convCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间
objvCurrEduCls_SynEN.PkClassRooms = objRow[convCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室
objvCurrEduCls_SynEN.BeginWeek = objRow[convCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周
objvCurrEduCls_SynEN.TeacherNames = objRow[convCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名
objvCurrEduCls_SynEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步
objvCurrEduCls_SynEN.SynchDate = objRow[convCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期
objvCurrEduCls_SynEN.ModifyDate = objRow[convCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduCls_SynEN.ModifyUserId = objRow[convCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduCls_SynEN.Memo = objRow[convCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.Memo].ToString().Trim(); //备注
objvCurrEduCls_SynEN.SignInDate = objRow[convCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间
objvCurrEduCls_SynEN.SignInStateID = objRow[convCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号
objvCurrEduCls_SynEN.SignInUser = objRow[convCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人
objvCurrEduCls_SynEN.SynchToWebUser = objRow[convCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户
objvCurrEduCls_SynEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web
objvCurrEduCls_SynEN.SynchToWebDate = objRow[convCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduCls_SynEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduCls_SynEN);
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
public static List<clsvCurrEduCls_SynEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCurrEduCls_SynEN> arrObjLst = new List<clsvCurrEduCls_SynEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduCls_SynEN objvCurrEduCls_SynEN = new clsvCurrEduCls_SynEN();
try
{
objvCurrEduCls_SynEN.IdCurrEduCls = objRow[convCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduCls_SynEN.EduClsTypeName = objRow[convCurrEduCls_Syn.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduCls_SynEN.CourseCode = objRow[convCurrEduCls_Syn.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseCode].ToString().Trim(); //课程代码
objvCurrEduCls_SynEN.CourseDescription = objRow[convCurrEduCls_Syn.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseDescription].ToString().Trim(); //课程描述
objvCurrEduCls_SynEN.CourseName = objRow[convCurrEduCls_Syn.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseName].ToString().Trim(); //课程名称
objvCurrEduCls_SynEN.ViewCount = objRow[convCurrEduCls_Syn.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.ViewCount].ToString().Trim()); //浏览量
objvCurrEduCls_SynEN.ExampleImgPath = objRow[convCurrEduCls_Syn.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduCls_SynEN.TeachingSolutionName = objRow[convCurrEduCls_Syn.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduCls_SynEN.IdTeacher = objRow[convCurrEduCls_Syn.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduCls_SynEN.TeacherId = objRow[convCurrEduCls_Syn.TeacherId].ToString().Trim(); //教师工号
objvCurrEduCls_SynEN.TeacherName = objRow[convCurrEduCls_Syn.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduCls_SynEN.CollegeId = objRow[convCurrEduCls_Syn.CollegeId].ToString().Trim(); //学院ID
objvCurrEduCls_SynEN.CollegeName = objRow[convCurrEduCls_Syn.CollegeName].ToString().Trim(); //学院名称
objvCurrEduCls_SynEN.IdXzMajor = objRow[convCurrEduCls_Syn.IdXzMajor].ToString().Trim(); //专业流水号
objvCurrEduCls_SynEN.MajorName = objRow[convCurrEduCls_Syn.MajorName].ToString().Trim(); //专业名称
objvCurrEduCls_SynEN.GradeBaseId = objRow[convCurrEduCls_Syn.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduCls_SynEN.GradeBaseName = objRow[convCurrEduCls_Syn.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduCls_SynEN.GradeBaseNameA = objRow[convCurrEduCls_Syn.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvCurrEduCls_SynEN.CourseTypeId = objRow[convCurrEduCls_Syn.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduCls_SynEN.CourseTypeName = objRow[convCurrEduCls_Syn.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduCls_SynEN.CurrStuNumValid = objRow[convCurrEduCls_Syn.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduCls_SynEN.CurrStuNum = objRow[convCurrEduCls_Syn.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduCls_SynEN.CurrEduClsId = objRow[convCurrEduCls_Syn.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduCls_SynEN.EduClsName = objRow[convCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名
objvCurrEduCls_SynEN.EduClsTypeId = objRow[convCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduCls_SynEN.CourseId = objRow[convCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id
objvCurrEduCls_SynEN.TeachingSolutionId = objRow[convCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduCls_SynEN.IdXzCollege = objRow[convCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduCls_SynEN.IdEduWay = objRow[convCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduCls_SynEN.IdClassRoomType = objRow[convCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号
objvCurrEduCls_SynEN.TotalLessonQty = Int32.Parse(objRow[convCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduCls_SynEN.MaxStuQty = objRow[convCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduCls_SynEN.WeekQty = objRow[convCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数
objvCurrEduCls_SynEN.ScheUnitPW = objRow[convCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduCls_SynEN.WeekStatusId = objRow[convCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduCls_SynEN.CustomerWeek = objRow[convCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduCls_SynEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objvCurrEduCls_SynEN.IdExecPlan = objRow[convCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号
objvCurrEduCls_SynEN.LessonQtyPerWeek = short.Parse(objRow[convCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduCls_SynEN.Mark = objRow[convCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分
objvCurrEduCls_SynEN.CheckClassRoom = objRow[convCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果
objvCurrEduCls_SynEN.CheckAdminCls = objRow[convCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果
objvCurrEduCls_SynEN.CheckTeacher = objRow[convCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果
objvCurrEduCls_SynEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定
objvCurrEduCls_SynEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课
objvCurrEduCls_SynEN.IdUniZone = objRow[convCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduCls_SynEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态
objvCurrEduCls_SynEN.IdGradeBase = objRow[convCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduCls_SynEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效
objvCurrEduCls_SynEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objvCurrEduCls_SynEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objvCurrEduCls_SynEN.SchoolYear = objRow[convCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年
objvCurrEduCls_SynEN.SchoolTerm = objRow[convCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期
objvCurrEduCls_SynEN.ArrangeCourseMemo = objRow[convCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注
objvCurrEduCls_SynEN.IdCourseType = objRow[convCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduCls_SynEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduCls_SynEN.IdScoreType = objRow[convCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduCls_SynEN.GetScoreWayId = objRow[convCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objvCurrEduCls_SynEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduCls_SynEN.IdExamType = objRow[convCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduCls_SynEN.ExamPortion = short.Parse(objRow[convCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例
objvCurrEduCls_SynEN.MidExamScorePortion = objRow[convCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objvCurrEduCls_SynEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩
objvCurrEduCls_SynEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令
objvCurrEduCls_SynEN.GeneratePwdDate = objRow[convCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间
objvCurrEduCls_SynEN.PkWeekTime = objRow[convCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间
objvCurrEduCls_SynEN.PkClassRooms = objRow[convCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室
objvCurrEduCls_SynEN.BeginWeek = objRow[convCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周
objvCurrEduCls_SynEN.TeacherNames = objRow[convCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名
objvCurrEduCls_SynEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步
objvCurrEduCls_SynEN.SynchDate = objRow[convCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期
objvCurrEduCls_SynEN.ModifyDate = objRow[convCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduCls_SynEN.ModifyUserId = objRow[convCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduCls_SynEN.Memo = objRow[convCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.Memo].ToString().Trim(); //备注
objvCurrEduCls_SynEN.SignInDate = objRow[convCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间
objvCurrEduCls_SynEN.SignInStateID = objRow[convCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号
objvCurrEduCls_SynEN.SignInUser = objRow[convCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人
objvCurrEduCls_SynEN.SynchToWebUser = objRow[convCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户
objvCurrEduCls_SynEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web
objvCurrEduCls_SynEN.SynchToWebDate = objRow[convCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduCls_SynEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduCls_SynEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCurrEduCls_SynEN> GetSubObjLstCache(clsvCurrEduCls_SynEN objvCurrEduCls_SynCond)
{
List<clsvCurrEduCls_SynEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCurrEduCls_SynEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCurrEduCls_Syn.AttributeName)
{
if (objvCurrEduCls_SynCond.IsUpdated(strFldName) == false) continue;
if (objvCurrEduCls_SynCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCurrEduCls_SynCond[strFldName].ToString());
}
else
{
if (objvCurrEduCls_SynCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCurrEduCls_SynCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCurrEduCls_SynCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCurrEduCls_SynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCurrEduCls_SynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCurrEduCls_SynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCurrEduCls_SynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCurrEduCls_SynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCurrEduCls_SynCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCurrEduCls_SynCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCurrEduCls_SynCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCurrEduCls_SynCond[strFldName]));
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
public static List<clsvCurrEduCls_SynEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCurrEduCls_SynEN> arrObjLst = new List<clsvCurrEduCls_SynEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduCls_SynEN objvCurrEduCls_SynEN = new clsvCurrEduCls_SynEN();
try
{
objvCurrEduCls_SynEN.IdCurrEduCls = objRow[convCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduCls_SynEN.EduClsTypeName = objRow[convCurrEduCls_Syn.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduCls_SynEN.CourseCode = objRow[convCurrEduCls_Syn.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseCode].ToString().Trim(); //课程代码
objvCurrEduCls_SynEN.CourseDescription = objRow[convCurrEduCls_Syn.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseDescription].ToString().Trim(); //课程描述
objvCurrEduCls_SynEN.CourseName = objRow[convCurrEduCls_Syn.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseName].ToString().Trim(); //课程名称
objvCurrEduCls_SynEN.ViewCount = objRow[convCurrEduCls_Syn.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.ViewCount].ToString().Trim()); //浏览量
objvCurrEduCls_SynEN.ExampleImgPath = objRow[convCurrEduCls_Syn.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduCls_SynEN.TeachingSolutionName = objRow[convCurrEduCls_Syn.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduCls_SynEN.IdTeacher = objRow[convCurrEduCls_Syn.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduCls_SynEN.TeacherId = objRow[convCurrEduCls_Syn.TeacherId].ToString().Trim(); //教师工号
objvCurrEduCls_SynEN.TeacherName = objRow[convCurrEduCls_Syn.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduCls_SynEN.CollegeId = objRow[convCurrEduCls_Syn.CollegeId].ToString().Trim(); //学院ID
objvCurrEduCls_SynEN.CollegeName = objRow[convCurrEduCls_Syn.CollegeName].ToString().Trim(); //学院名称
objvCurrEduCls_SynEN.IdXzMajor = objRow[convCurrEduCls_Syn.IdXzMajor].ToString().Trim(); //专业流水号
objvCurrEduCls_SynEN.MajorName = objRow[convCurrEduCls_Syn.MajorName].ToString().Trim(); //专业名称
objvCurrEduCls_SynEN.GradeBaseId = objRow[convCurrEduCls_Syn.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduCls_SynEN.GradeBaseName = objRow[convCurrEduCls_Syn.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduCls_SynEN.GradeBaseNameA = objRow[convCurrEduCls_Syn.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvCurrEduCls_SynEN.CourseTypeId = objRow[convCurrEduCls_Syn.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduCls_SynEN.CourseTypeName = objRow[convCurrEduCls_Syn.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduCls_SynEN.CurrStuNumValid = objRow[convCurrEduCls_Syn.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduCls_SynEN.CurrStuNum = objRow[convCurrEduCls_Syn.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduCls_SynEN.CurrEduClsId = objRow[convCurrEduCls_Syn.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduCls_SynEN.EduClsName = objRow[convCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名
objvCurrEduCls_SynEN.EduClsTypeId = objRow[convCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduCls_SynEN.CourseId = objRow[convCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id
objvCurrEduCls_SynEN.TeachingSolutionId = objRow[convCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduCls_SynEN.IdXzCollege = objRow[convCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduCls_SynEN.IdEduWay = objRow[convCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduCls_SynEN.IdClassRoomType = objRow[convCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号
objvCurrEduCls_SynEN.TotalLessonQty = Int32.Parse(objRow[convCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduCls_SynEN.MaxStuQty = objRow[convCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduCls_SynEN.WeekQty = objRow[convCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数
objvCurrEduCls_SynEN.ScheUnitPW = objRow[convCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduCls_SynEN.WeekStatusId = objRow[convCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduCls_SynEN.CustomerWeek = objRow[convCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduCls_SynEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objvCurrEduCls_SynEN.IdExecPlan = objRow[convCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号
objvCurrEduCls_SynEN.LessonQtyPerWeek = short.Parse(objRow[convCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduCls_SynEN.Mark = objRow[convCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分
objvCurrEduCls_SynEN.CheckClassRoom = objRow[convCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果
objvCurrEduCls_SynEN.CheckAdminCls = objRow[convCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果
objvCurrEduCls_SynEN.CheckTeacher = objRow[convCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果
objvCurrEduCls_SynEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定
objvCurrEduCls_SynEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课
objvCurrEduCls_SynEN.IdUniZone = objRow[convCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduCls_SynEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态
objvCurrEduCls_SynEN.IdGradeBase = objRow[convCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduCls_SynEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效
objvCurrEduCls_SynEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objvCurrEduCls_SynEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objvCurrEduCls_SynEN.SchoolYear = objRow[convCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年
objvCurrEduCls_SynEN.SchoolTerm = objRow[convCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期
objvCurrEduCls_SynEN.ArrangeCourseMemo = objRow[convCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注
objvCurrEduCls_SynEN.IdCourseType = objRow[convCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduCls_SynEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduCls_SynEN.IdScoreType = objRow[convCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduCls_SynEN.GetScoreWayId = objRow[convCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objvCurrEduCls_SynEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduCls_SynEN.IdExamType = objRow[convCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduCls_SynEN.ExamPortion = short.Parse(objRow[convCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例
objvCurrEduCls_SynEN.MidExamScorePortion = objRow[convCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objvCurrEduCls_SynEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩
objvCurrEduCls_SynEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令
objvCurrEduCls_SynEN.GeneratePwdDate = objRow[convCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间
objvCurrEduCls_SynEN.PkWeekTime = objRow[convCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间
objvCurrEduCls_SynEN.PkClassRooms = objRow[convCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室
objvCurrEduCls_SynEN.BeginWeek = objRow[convCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周
objvCurrEduCls_SynEN.TeacherNames = objRow[convCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名
objvCurrEduCls_SynEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步
objvCurrEduCls_SynEN.SynchDate = objRow[convCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期
objvCurrEduCls_SynEN.ModifyDate = objRow[convCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduCls_SynEN.ModifyUserId = objRow[convCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduCls_SynEN.Memo = objRow[convCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.Memo].ToString().Trim(); //备注
objvCurrEduCls_SynEN.SignInDate = objRow[convCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间
objvCurrEduCls_SynEN.SignInStateID = objRow[convCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号
objvCurrEduCls_SynEN.SignInUser = objRow[convCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人
objvCurrEduCls_SynEN.SynchToWebUser = objRow[convCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户
objvCurrEduCls_SynEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web
objvCurrEduCls_SynEN.SynchToWebDate = objRow[convCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduCls_SynEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduCls_SynEN);
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
public static List<clsvCurrEduCls_SynEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCurrEduCls_SynEN> arrObjLst = new List<clsvCurrEduCls_SynEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduCls_SynEN objvCurrEduCls_SynEN = new clsvCurrEduCls_SynEN();
try
{
objvCurrEduCls_SynEN.IdCurrEduCls = objRow[convCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduCls_SynEN.EduClsTypeName = objRow[convCurrEduCls_Syn.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduCls_SynEN.CourseCode = objRow[convCurrEduCls_Syn.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseCode].ToString().Trim(); //课程代码
objvCurrEduCls_SynEN.CourseDescription = objRow[convCurrEduCls_Syn.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseDescription].ToString().Trim(); //课程描述
objvCurrEduCls_SynEN.CourseName = objRow[convCurrEduCls_Syn.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseName].ToString().Trim(); //课程名称
objvCurrEduCls_SynEN.ViewCount = objRow[convCurrEduCls_Syn.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.ViewCount].ToString().Trim()); //浏览量
objvCurrEduCls_SynEN.ExampleImgPath = objRow[convCurrEduCls_Syn.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduCls_SynEN.TeachingSolutionName = objRow[convCurrEduCls_Syn.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduCls_SynEN.IdTeacher = objRow[convCurrEduCls_Syn.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduCls_SynEN.TeacherId = objRow[convCurrEduCls_Syn.TeacherId].ToString().Trim(); //教师工号
objvCurrEduCls_SynEN.TeacherName = objRow[convCurrEduCls_Syn.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduCls_SynEN.CollegeId = objRow[convCurrEduCls_Syn.CollegeId].ToString().Trim(); //学院ID
objvCurrEduCls_SynEN.CollegeName = objRow[convCurrEduCls_Syn.CollegeName].ToString().Trim(); //学院名称
objvCurrEduCls_SynEN.IdXzMajor = objRow[convCurrEduCls_Syn.IdXzMajor].ToString().Trim(); //专业流水号
objvCurrEduCls_SynEN.MajorName = objRow[convCurrEduCls_Syn.MajorName].ToString().Trim(); //专业名称
objvCurrEduCls_SynEN.GradeBaseId = objRow[convCurrEduCls_Syn.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduCls_SynEN.GradeBaseName = objRow[convCurrEduCls_Syn.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduCls_SynEN.GradeBaseNameA = objRow[convCurrEduCls_Syn.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvCurrEduCls_SynEN.CourseTypeId = objRow[convCurrEduCls_Syn.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduCls_SynEN.CourseTypeName = objRow[convCurrEduCls_Syn.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduCls_SynEN.CurrStuNumValid = objRow[convCurrEduCls_Syn.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduCls_SynEN.CurrStuNum = objRow[convCurrEduCls_Syn.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduCls_SynEN.CurrEduClsId = objRow[convCurrEduCls_Syn.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduCls_SynEN.EduClsName = objRow[convCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名
objvCurrEduCls_SynEN.EduClsTypeId = objRow[convCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduCls_SynEN.CourseId = objRow[convCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id
objvCurrEduCls_SynEN.TeachingSolutionId = objRow[convCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduCls_SynEN.IdXzCollege = objRow[convCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduCls_SynEN.IdEduWay = objRow[convCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduCls_SynEN.IdClassRoomType = objRow[convCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号
objvCurrEduCls_SynEN.TotalLessonQty = Int32.Parse(objRow[convCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduCls_SynEN.MaxStuQty = objRow[convCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduCls_SynEN.WeekQty = objRow[convCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数
objvCurrEduCls_SynEN.ScheUnitPW = objRow[convCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduCls_SynEN.WeekStatusId = objRow[convCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduCls_SynEN.CustomerWeek = objRow[convCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduCls_SynEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objvCurrEduCls_SynEN.IdExecPlan = objRow[convCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号
objvCurrEduCls_SynEN.LessonQtyPerWeek = short.Parse(objRow[convCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduCls_SynEN.Mark = objRow[convCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分
objvCurrEduCls_SynEN.CheckClassRoom = objRow[convCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果
objvCurrEduCls_SynEN.CheckAdminCls = objRow[convCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果
objvCurrEduCls_SynEN.CheckTeacher = objRow[convCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果
objvCurrEduCls_SynEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定
objvCurrEduCls_SynEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课
objvCurrEduCls_SynEN.IdUniZone = objRow[convCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduCls_SynEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态
objvCurrEduCls_SynEN.IdGradeBase = objRow[convCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduCls_SynEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效
objvCurrEduCls_SynEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objvCurrEduCls_SynEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objvCurrEduCls_SynEN.SchoolYear = objRow[convCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年
objvCurrEduCls_SynEN.SchoolTerm = objRow[convCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期
objvCurrEduCls_SynEN.ArrangeCourseMemo = objRow[convCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注
objvCurrEduCls_SynEN.IdCourseType = objRow[convCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduCls_SynEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduCls_SynEN.IdScoreType = objRow[convCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduCls_SynEN.GetScoreWayId = objRow[convCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objvCurrEduCls_SynEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduCls_SynEN.IdExamType = objRow[convCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduCls_SynEN.ExamPortion = short.Parse(objRow[convCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例
objvCurrEduCls_SynEN.MidExamScorePortion = objRow[convCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objvCurrEduCls_SynEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩
objvCurrEduCls_SynEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令
objvCurrEduCls_SynEN.GeneratePwdDate = objRow[convCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间
objvCurrEduCls_SynEN.PkWeekTime = objRow[convCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间
objvCurrEduCls_SynEN.PkClassRooms = objRow[convCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室
objvCurrEduCls_SynEN.BeginWeek = objRow[convCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周
objvCurrEduCls_SynEN.TeacherNames = objRow[convCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名
objvCurrEduCls_SynEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步
objvCurrEduCls_SynEN.SynchDate = objRow[convCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期
objvCurrEduCls_SynEN.ModifyDate = objRow[convCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduCls_SynEN.ModifyUserId = objRow[convCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduCls_SynEN.Memo = objRow[convCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.Memo].ToString().Trim(); //备注
objvCurrEduCls_SynEN.SignInDate = objRow[convCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间
objvCurrEduCls_SynEN.SignInStateID = objRow[convCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号
objvCurrEduCls_SynEN.SignInUser = objRow[convCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人
objvCurrEduCls_SynEN.SynchToWebUser = objRow[convCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户
objvCurrEduCls_SynEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web
objvCurrEduCls_SynEN.SynchToWebDate = objRow[convCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduCls_SynEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduCls_SynEN);
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
List<clsvCurrEduCls_SynEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCurrEduCls_SynEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduCls_SynEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCurrEduCls_SynEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCurrEduCls_SynEN> arrObjLst = new List<clsvCurrEduCls_SynEN>(); 
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
	clsvCurrEduCls_SynEN objvCurrEduCls_SynEN = new clsvCurrEduCls_SynEN();
try
{
objvCurrEduCls_SynEN.IdCurrEduCls = objRow[convCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduCls_SynEN.EduClsTypeName = objRow[convCurrEduCls_Syn.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduCls_SynEN.CourseCode = objRow[convCurrEduCls_Syn.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseCode].ToString().Trim(); //课程代码
objvCurrEduCls_SynEN.CourseDescription = objRow[convCurrEduCls_Syn.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseDescription].ToString().Trim(); //课程描述
objvCurrEduCls_SynEN.CourseName = objRow[convCurrEduCls_Syn.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseName].ToString().Trim(); //课程名称
objvCurrEduCls_SynEN.ViewCount = objRow[convCurrEduCls_Syn.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.ViewCount].ToString().Trim()); //浏览量
objvCurrEduCls_SynEN.ExampleImgPath = objRow[convCurrEduCls_Syn.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduCls_SynEN.TeachingSolutionName = objRow[convCurrEduCls_Syn.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduCls_SynEN.IdTeacher = objRow[convCurrEduCls_Syn.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduCls_SynEN.TeacherId = objRow[convCurrEduCls_Syn.TeacherId].ToString().Trim(); //教师工号
objvCurrEduCls_SynEN.TeacherName = objRow[convCurrEduCls_Syn.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduCls_SynEN.CollegeId = objRow[convCurrEduCls_Syn.CollegeId].ToString().Trim(); //学院ID
objvCurrEduCls_SynEN.CollegeName = objRow[convCurrEduCls_Syn.CollegeName].ToString().Trim(); //学院名称
objvCurrEduCls_SynEN.IdXzMajor = objRow[convCurrEduCls_Syn.IdXzMajor].ToString().Trim(); //专业流水号
objvCurrEduCls_SynEN.MajorName = objRow[convCurrEduCls_Syn.MajorName].ToString().Trim(); //专业名称
objvCurrEduCls_SynEN.GradeBaseId = objRow[convCurrEduCls_Syn.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduCls_SynEN.GradeBaseName = objRow[convCurrEduCls_Syn.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduCls_SynEN.GradeBaseNameA = objRow[convCurrEduCls_Syn.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvCurrEduCls_SynEN.CourseTypeId = objRow[convCurrEduCls_Syn.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduCls_SynEN.CourseTypeName = objRow[convCurrEduCls_Syn.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduCls_SynEN.CurrStuNumValid = objRow[convCurrEduCls_Syn.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduCls_SynEN.CurrStuNum = objRow[convCurrEduCls_Syn.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduCls_SynEN.CurrEduClsId = objRow[convCurrEduCls_Syn.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduCls_SynEN.EduClsName = objRow[convCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名
objvCurrEduCls_SynEN.EduClsTypeId = objRow[convCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduCls_SynEN.CourseId = objRow[convCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id
objvCurrEduCls_SynEN.TeachingSolutionId = objRow[convCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduCls_SynEN.IdXzCollege = objRow[convCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduCls_SynEN.IdEduWay = objRow[convCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduCls_SynEN.IdClassRoomType = objRow[convCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号
objvCurrEduCls_SynEN.TotalLessonQty = Int32.Parse(objRow[convCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduCls_SynEN.MaxStuQty = objRow[convCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduCls_SynEN.WeekQty = objRow[convCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数
objvCurrEduCls_SynEN.ScheUnitPW = objRow[convCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduCls_SynEN.WeekStatusId = objRow[convCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduCls_SynEN.CustomerWeek = objRow[convCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduCls_SynEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objvCurrEduCls_SynEN.IdExecPlan = objRow[convCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号
objvCurrEduCls_SynEN.LessonQtyPerWeek = short.Parse(objRow[convCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduCls_SynEN.Mark = objRow[convCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分
objvCurrEduCls_SynEN.CheckClassRoom = objRow[convCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果
objvCurrEduCls_SynEN.CheckAdminCls = objRow[convCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果
objvCurrEduCls_SynEN.CheckTeacher = objRow[convCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果
objvCurrEduCls_SynEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定
objvCurrEduCls_SynEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课
objvCurrEduCls_SynEN.IdUniZone = objRow[convCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduCls_SynEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态
objvCurrEduCls_SynEN.IdGradeBase = objRow[convCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduCls_SynEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效
objvCurrEduCls_SynEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objvCurrEduCls_SynEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objvCurrEduCls_SynEN.SchoolYear = objRow[convCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年
objvCurrEduCls_SynEN.SchoolTerm = objRow[convCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期
objvCurrEduCls_SynEN.ArrangeCourseMemo = objRow[convCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注
objvCurrEduCls_SynEN.IdCourseType = objRow[convCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduCls_SynEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduCls_SynEN.IdScoreType = objRow[convCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduCls_SynEN.GetScoreWayId = objRow[convCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objvCurrEduCls_SynEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduCls_SynEN.IdExamType = objRow[convCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduCls_SynEN.ExamPortion = short.Parse(objRow[convCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例
objvCurrEduCls_SynEN.MidExamScorePortion = objRow[convCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objvCurrEduCls_SynEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩
objvCurrEduCls_SynEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令
objvCurrEduCls_SynEN.GeneratePwdDate = objRow[convCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间
objvCurrEduCls_SynEN.PkWeekTime = objRow[convCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间
objvCurrEduCls_SynEN.PkClassRooms = objRow[convCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室
objvCurrEduCls_SynEN.BeginWeek = objRow[convCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周
objvCurrEduCls_SynEN.TeacherNames = objRow[convCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名
objvCurrEduCls_SynEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步
objvCurrEduCls_SynEN.SynchDate = objRow[convCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期
objvCurrEduCls_SynEN.ModifyDate = objRow[convCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduCls_SynEN.ModifyUserId = objRow[convCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduCls_SynEN.Memo = objRow[convCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.Memo].ToString().Trim(); //备注
objvCurrEduCls_SynEN.SignInDate = objRow[convCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间
objvCurrEduCls_SynEN.SignInStateID = objRow[convCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号
objvCurrEduCls_SynEN.SignInUser = objRow[convCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人
objvCurrEduCls_SynEN.SynchToWebUser = objRow[convCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户
objvCurrEduCls_SynEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web
objvCurrEduCls_SynEN.SynchToWebDate = objRow[convCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduCls_SynEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduCls_SynEN);
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
public static List<clsvCurrEduCls_SynEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCurrEduCls_SynEN> arrObjLst = new List<clsvCurrEduCls_SynEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduCls_SynEN objvCurrEduCls_SynEN = new clsvCurrEduCls_SynEN();
try
{
objvCurrEduCls_SynEN.IdCurrEduCls = objRow[convCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduCls_SynEN.EduClsTypeName = objRow[convCurrEduCls_Syn.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduCls_SynEN.CourseCode = objRow[convCurrEduCls_Syn.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseCode].ToString().Trim(); //课程代码
objvCurrEduCls_SynEN.CourseDescription = objRow[convCurrEduCls_Syn.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseDescription].ToString().Trim(); //课程描述
objvCurrEduCls_SynEN.CourseName = objRow[convCurrEduCls_Syn.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseName].ToString().Trim(); //课程名称
objvCurrEduCls_SynEN.ViewCount = objRow[convCurrEduCls_Syn.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.ViewCount].ToString().Trim()); //浏览量
objvCurrEduCls_SynEN.ExampleImgPath = objRow[convCurrEduCls_Syn.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduCls_SynEN.TeachingSolutionName = objRow[convCurrEduCls_Syn.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduCls_SynEN.IdTeacher = objRow[convCurrEduCls_Syn.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduCls_SynEN.TeacherId = objRow[convCurrEduCls_Syn.TeacherId].ToString().Trim(); //教师工号
objvCurrEduCls_SynEN.TeacherName = objRow[convCurrEduCls_Syn.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduCls_SynEN.CollegeId = objRow[convCurrEduCls_Syn.CollegeId].ToString().Trim(); //学院ID
objvCurrEduCls_SynEN.CollegeName = objRow[convCurrEduCls_Syn.CollegeName].ToString().Trim(); //学院名称
objvCurrEduCls_SynEN.IdXzMajor = objRow[convCurrEduCls_Syn.IdXzMajor].ToString().Trim(); //专业流水号
objvCurrEduCls_SynEN.MajorName = objRow[convCurrEduCls_Syn.MajorName].ToString().Trim(); //专业名称
objvCurrEduCls_SynEN.GradeBaseId = objRow[convCurrEduCls_Syn.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduCls_SynEN.GradeBaseName = objRow[convCurrEduCls_Syn.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduCls_SynEN.GradeBaseNameA = objRow[convCurrEduCls_Syn.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvCurrEduCls_SynEN.CourseTypeId = objRow[convCurrEduCls_Syn.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduCls_SynEN.CourseTypeName = objRow[convCurrEduCls_Syn.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduCls_SynEN.CurrStuNumValid = objRow[convCurrEduCls_Syn.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduCls_SynEN.CurrStuNum = objRow[convCurrEduCls_Syn.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduCls_SynEN.CurrEduClsId = objRow[convCurrEduCls_Syn.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduCls_SynEN.EduClsName = objRow[convCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名
objvCurrEduCls_SynEN.EduClsTypeId = objRow[convCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduCls_SynEN.CourseId = objRow[convCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id
objvCurrEduCls_SynEN.TeachingSolutionId = objRow[convCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduCls_SynEN.IdXzCollege = objRow[convCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduCls_SynEN.IdEduWay = objRow[convCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduCls_SynEN.IdClassRoomType = objRow[convCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号
objvCurrEduCls_SynEN.TotalLessonQty = Int32.Parse(objRow[convCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduCls_SynEN.MaxStuQty = objRow[convCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduCls_SynEN.WeekQty = objRow[convCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数
objvCurrEduCls_SynEN.ScheUnitPW = objRow[convCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduCls_SynEN.WeekStatusId = objRow[convCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduCls_SynEN.CustomerWeek = objRow[convCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduCls_SynEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objvCurrEduCls_SynEN.IdExecPlan = objRow[convCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号
objvCurrEduCls_SynEN.LessonQtyPerWeek = short.Parse(objRow[convCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduCls_SynEN.Mark = objRow[convCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分
objvCurrEduCls_SynEN.CheckClassRoom = objRow[convCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果
objvCurrEduCls_SynEN.CheckAdminCls = objRow[convCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果
objvCurrEduCls_SynEN.CheckTeacher = objRow[convCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果
objvCurrEduCls_SynEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定
objvCurrEduCls_SynEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课
objvCurrEduCls_SynEN.IdUniZone = objRow[convCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduCls_SynEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态
objvCurrEduCls_SynEN.IdGradeBase = objRow[convCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduCls_SynEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效
objvCurrEduCls_SynEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objvCurrEduCls_SynEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objvCurrEduCls_SynEN.SchoolYear = objRow[convCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年
objvCurrEduCls_SynEN.SchoolTerm = objRow[convCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期
objvCurrEduCls_SynEN.ArrangeCourseMemo = objRow[convCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注
objvCurrEduCls_SynEN.IdCourseType = objRow[convCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduCls_SynEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduCls_SynEN.IdScoreType = objRow[convCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduCls_SynEN.GetScoreWayId = objRow[convCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objvCurrEduCls_SynEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduCls_SynEN.IdExamType = objRow[convCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduCls_SynEN.ExamPortion = short.Parse(objRow[convCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例
objvCurrEduCls_SynEN.MidExamScorePortion = objRow[convCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objvCurrEduCls_SynEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩
objvCurrEduCls_SynEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令
objvCurrEduCls_SynEN.GeneratePwdDate = objRow[convCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间
objvCurrEduCls_SynEN.PkWeekTime = objRow[convCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间
objvCurrEduCls_SynEN.PkClassRooms = objRow[convCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室
objvCurrEduCls_SynEN.BeginWeek = objRow[convCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周
objvCurrEduCls_SynEN.TeacherNames = objRow[convCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名
objvCurrEduCls_SynEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步
objvCurrEduCls_SynEN.SynchDate = objRow[convCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期
objvCurrEduCls_SynEN.ModifyDate = objRow[convCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduCls_SynEN.ModifyUserId = objRow[convCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduCls_SynEN.Memo = objRow[convCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.Memo].ToString().Trim(); //备注
objvCurrEduCls_SynEN.SignInDate = objRow[convCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间
objvCurrEduCls_SynEN.SignInStateID = objRow[convCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号
objvCurrEduCls_SynEN.SignInUser = objRow[convCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人
objvCurrEduCls_SynEN.SynchToWebUser = objRow[convCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户
objvCurrEduCls_SynEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web
objvCurrEduCls_SynEN.SynchToWebDate = objRow[convCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduCls_SynEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduCls_SynEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCurrEduCls_SynEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCurrEduCls_SynEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCurrEduCls_SynEN> arrObjLst = new List<clsvCurrEduCls_SynEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduCls_SynEN objvCurrEduCls_SynEN = new clsvCurrEduCls_SynEN();
try
{
objvCurrEduCls_SynEN.IdCurrEduCls = objRow[convCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduCls_SynEN.EduClsTypeName = objRow[convCurrEduCls_Syn.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduCls_SynEN.CourseCode = objRow[convCurrEduCls_Syn.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseCode].ToString().Trim(); //课程代码
objvCurrEduCls_SynEN.CourseDescription = objRow[convCurrEduCls_Syn.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseDescription].ToString().Trim(); //课程描述
objvCurrEduCls_SynEN.CourseName = objRow[convCurrEduCls_Syn.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseName].ToString().Trim(); //课程名称
objvCurrEduCls_SynEN.ViewCount = objRow[convCurrEduCls_Syn.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.ViewCount].ToString().Trim()); //浏览量
objvCurrEduCls_SynEN.ExampleImgPath = objRow[convCurrEduCls_Syn.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduCls_SynEN.TeachingSolutionName = objRow[convCurrEduCls_Syn.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduCls_SynEN.IdTeacher = objRow[convCurrEduCls_Syn.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduCls_SynEN.TeacherId = objRow[convCurrEduCls_Syn.TeacherId].ToString().Trim(); //教师工号
objvCurrEduCls_SynEN.TeacherName = objRow[convCurrEduCls_Syn.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduCls_SynEN.CollegeId = objRow[convCurrEduCls_Syn.CollegeId].ToString().Trim(); //学院ID
objvCurrEduCls_SynEN.CollegeName = objRow[convCurrEduCls_Syn.CollegeName].ToString().Trim(); //学院名称
objvCurrEduCls_SynEN.IdXzMajor = objRow[convCurrEduCls_Syn.IdXzMajor].ToString().Trim(); //专业流水号
objvCurrEduCls_SynEN.MajorName = objRow[convCurrEduCls_Syn.MajorName].ToString().Trim(); //专业名称
objvCurrEduCls_SynEN.GradeBaseId = objRow[convCurrEduCls_Syn.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduCls_SynEN.GradeBaseName = objRow[convCurrEduCls_Syn.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduCls_SynEN.GradeBaseNameA = objRow[convCurrEduCls_Syn.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvCurrEduCls_SynEN.CourseTypeId = objRow[convCurrEduCls_Syn.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduCls_SynEN.CourseTypeName = objRow[convCurrEduCls_Syn.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduCls_SynEN.CurrStuNumValid = objRow[convCurrEduCls_Syn.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduCls_SynEN.CurrStuNum = objRow[convCurrEduCls_Syn.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduCls_SynEN.CurrEduClsId = objRow[convCurrEduCls_Syn.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduCls_SynEN.EduClsName = objRow[convCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名
objvCurrEduCls_SynEN.EduClsTypeId = objRow[convCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduCls_SynEN.CourseId = objRow[convCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id
objvCurrEduCls_SynEN.TeachingSolutionId = objRow[convCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduCls_SynEN.IdXzCollege = objRow[convCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduCls_SynEN.IdEduWay = objRow[convCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduCls_SynEN.IdClassRoomType = objRow[convCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号
objvCurrEduCls_SynEN.TotalLessonQty = Int32.Parse(objRow[convCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduCls_SynEN.MaxStuQty = objRow[convCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduCls_SynEN.WeekQty = objRow[convCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数
objvCurrEduCls_SynEN.ScheUnitPW = objRow[convCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduCls_SynEN.WeekStatusId = objRow[convCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduCls_SynEN.CustomerWeek = objRow[convCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduCls_SynEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objvCurrEduCls_SynEN.IdExecPlan = objRow[convCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号
objvCurrEduCls_SynEN.LessonQtyPerWeek = short.Parse(objRow[convCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduCls_SynEN.Mark = objRow[convCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分
objvCurrEduCls_SynEN.CheckClassRoom = objRow[convCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果
objvCurrEduCls_SynEN.CheckAdminCls = objRow[convCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果
objvCurrEduCls_SynEN.CheckTeacher = objRow[convCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果
objvCurrEduCls_SynEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定
objvCurrEduCls_SynEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课
objvCurrEduCls_SynEN.IdUniZone = objRow[convCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduCls_SynEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态
objvCurrEduCls_SynEN.IdGradeBase = objRow[convCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduCls_SynEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效
objvCurrEduCls_SynEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objvCurrEduCls_SynEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objvCurrEduCls_SynEN.SchoolYear = objRow[convCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年
objvCurrEduCls_SynEN.SchoolTerm = objRow[convCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期
objvCurrEduCls_SynEN.ArrangeCourseMemo = objRow[convCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注
objvCurrEduCls_SynEN.IdCourseType = objRow[convCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduCls_SynEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduCls_SynEN.IdScoreType = objRow[convCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduCls_SynEN.GetScoreWayId = objRow[convCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objvCurrEduCls_SynEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduCls_SynEN.IdExamType = objRow[convCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduCls_SynEN.ExamPortion = short.Parse(objRow[convCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例
objvCurrEduCls_SynEN.MidExamScorePortion = objRow[convCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objvCurrEduCls_SynEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩
objvCurrEduCls_SynEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令
objvCurrEduCls_SynEN.GeneratePwdDate = objRow[convCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间
objvCurrEduCls_SynEN.PkWeekTime = objRow[convCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间
objvCurrEduCls_SynEN.PkClassRooms = objRow[convCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室
objvCurrEduCls_SynEN.BeginWeek = objRow[convCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周
objvCurrEduCls_SynEN.TeacherNames = objRow[convCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名
objvCurrEduCls_SynEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步
objvCurrEduCls_SynEN.SynchDate = objRow[convCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期
objvCurrEduCls_SynEN.ModifyDate = objRow[convCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduCls_SynEN.ModifyUserId = objRow[convCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduCls_SynEN.Memo = objRow[convCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.Memo].ToString().Trim(); //备注
objvCurrEduCls_SynEN.SignInDate = objRow[convCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间
objvCurrEduCls_SynEN.SignInStateID = objRow[convCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号
objvCurrEduCls_SynEN.SignInUser = objRow[convCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人
objvCurrEduCls_SynEN.SynchToWebUser = objRow[convCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户
objvCurrEduCls_SynEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web
objvCurrEduCls_SynEN.SynchToWebDate = objRow[convCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduCls_SynEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduCls_SynEN);
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
public static List<clsvCurrEduCls_SynEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCurrEduCls_SynEN> arrObjLst = new List<clsvCurrEduCls_SynEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduCls_SynEN objvCurrEduCls_SynEN = new clsvCurrEduCls_SynEN();
try
{
objvCurrEduCls_SynEN.IdCurrEduCls = objRow[convCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduCls_SynEN.EduClsTypeName = objRow[convCurrEduCls_Syn.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduCls_SynEN.CourseCode = objRow[convCurrEduCls_Syn.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseCode].ToString().Trim(); //课程代码
objvCurrEduCls_SynEN.CourseDescription = objRow[convCurrEduCls_Syn.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseDescription].ToString().Trim(); //课程描述
objvCurrEduCls_SynEN.CourseName = objRow[convCurrEduCls_Syn.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseName].ToString().Trim(); //课程名称
objvCurrEduCls_SynEN.ViewCount = objRow[convCurrEduCls_Syn.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.ViewCount].ToString().Trim()); //浏览量
objvCurrEduCls_SynEN.ExampleImgPath = objRow[convCurrEduCls_Syn.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduCls_SynEN.TeachingSolutionName = objRow[convCurrEduCls_Syn.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduCls_SynEN.IdTeacher = objRow[convCurrEduCls_Syn.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduCls_SynEN.TeacherId = objRow[convCurrEduCls_Syn.TeacherId].ToString().Trim(); //教师工号
objvCurrEduCls_SynEN.TeacherName = objRow[convCurrEduCls_Syn.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduCls_SynEN.CollegeId = objRow[convCurrEduCls_Syn.CollegeId].ToString().Trim(); //学院ID
objvCurrEduCls_SynEN.CollegeName = objRow[convCurrEduCls_Syn.CollegeName].ToString().Trim(); //学院名称
objvCurrEduCls_SynEN.IdXzMajor = objRow[convCurrEduCls_Syn.IdXzMajor].ToString().Trim(); //专业流水号
objvCurrEduCls_SynEN.MajorName = objRow[convCurrEduCls_Syn.MajorName].ToString().Trim(); //专业名称
objvCurrEduCls_SynEN.GradeBaseId = objRow[convCurrEduCls_Syn.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduCls_SynEN.GradeBaseName = objRow[convCurrEduCls_Syn.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduCls_SynEN.GradeBaseNameA = objRow[convCurrEduCls_Syn.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvCurrEduCls_SynEN.CourseTypeId = objRow[convCurrEduCls_Syn.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduCls_SynEN.CourseTypeName = objRow[convCurrEduCls_Syn.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduCls_SynEN.CurrStuNumValid = objRow[convCurrEduCls_Syn.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduCls_SynEN.CurrStuNum = objRow[convCurrEduCls_Syn.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduCls_SynEN.CurrEduClsId = objRow[convCurrEduCls_Syn.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduCls_SynEN.EduClsName = objRow[convCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名
objvCurrEduCls_SynEN.EduClsTypeId = objRow[convCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduCls_SynEN.CourseId = objRow[convCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id
objvCurrEduCls_SynEN.TeachingSolutionId = objRow[convCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduCls_SynEN.IdXzCollege = objRow[convCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduCls_SynEN.IdEduWay = objRow[convCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduCls_SynEN.IdClassRoomType = objRow[convCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号
objvCurrEduCls_SynEN.TotalLessonQty = Int32.Parse(objRow[convCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduCls_SynEN.MaxStuQty = objRow[convCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduCls_SynEN.WeekQty = objRow[convCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数
objvCurrEduCls_SynEN.ScheUnitPW = objRow[convCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduCls_SynEN.WeekStatusId = objRow[convCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduCls_SynEN.CustomerWeek = objRow[convCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduCls_SynEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objvCurrEduCls_SynEN.IdExecPlan = objRow[convCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号
objvCurrEduCls_SynEN.LessonQtyPerWeek = short.Parse(objRow[convCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduCls_SynEN.Mark = objRow[convCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分
objvCurrEduCls_SynEN.CheckClassRoom = objRow[convCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果
objvCurrEduCls_SynEN.CheckAdminCls = objRow[convCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果
objvCurrEduCls_SynEN.CheckTeacher = objRow[convCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果
objvCurrEduCls_SynEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定
objvCurrEduCls_SynEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课
objvCurrEduCls_SynEN.IdUniZone = objRow[convCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduCls_SynEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态
objvCurrEduCls_SynEN.IdGradeBase = objRow[convCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduCls_SynEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效
objvCurrEduCls_SynEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objvCurrEduCls_SynEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objvCurrEduCls_SynEN.SchoolYear = objRow[convCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年
objvCurrEduCls_SynEN.SchoolTerm = objRow[convCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期
objvCurrEduCls_SynEN.ArrangeCourseMemo = objRow[convCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注
objvCurrEduCls_SynEN.IdCourseType = objRow[convCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduCls_SynEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduCls_SynEN.IdScoreType = objRow[convCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduCls_SynEN.GetScoreWayId = objRow[convCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objvCurrEduCls_SynEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduCls_SynEN.IdExamType = objRow[convCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduCls_SynEN.ExamPortion = short.Parse(objRow[convCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例
objvCurrEduCls_SynEN.MidExamScorePortion = objRow[convCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objvCurrEduCls_SynEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩
objvCurrEduCls_SynEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令
objvCurrEduCls_SynEN.GeneratePwdDate = objRow[convCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间
objvCurrEduCls_SynEN.PkWeekTime = objRow[convCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间
objvCurrEduCls_SynEN.PkClassRooms = objRow[convCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室
objvCurrEduCls_SynEN.BeginWeek = objRow[convCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周
objvCurrEduCls_SynEN.TeacherNames = objRow[convCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名
objvCurrEduCls_SynEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步
objvCurrEduCls_SynEN.SynchDate = objRow[convCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期
objvCurrEduCls_SynEN.ModifyDate = objRow[convCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduCls_SynEN.ModifyUserId = objRow[convCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduCls_SynEN.Memo = objRow[convCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.Memo].ToString().Trim(); //备注
objvCurrEduCls_SynEN.SignInDate = objRow[convCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间
objvCurrEduCls_SynEN.SignInStateID = objRow[convCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号
objvCurrEduCls_SynEN.SignInUser = objRow[convCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人
objvCurrEduCls_SynEN.SynchToWebUser = objRow[convCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户
objvCurrEduCls_SynEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web
objvCurrEduCls_SynEN.SynchToWebDate = objRow[convCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduCls_SynEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduCls_SynEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduCls_SynEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCurrEduCls_SynEN> arrObjLst = new List<clsvCurrEduCls_SynEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduCls_SynEN objvCurrEduCls_SynEN = new clsvCurrEduCls_SynEN();
try
{
objvCurrEduCls_SynEN.IdCurrEduCls = objRow[convCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduCls_SynEN.EduClsTypeName = objRow[convCurrEduCls_Syn.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduCls_SynEN.CourseCode = objRow[convCurrEduCls_Syn.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseCode].ToString().Trim(); //课程代码
objvCurrEduCls_SynEN.CourseDescription = objRow[convCurrEduCls_Syn.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseDescription].ToString().Trim(); //课程描述
objvCurrEduCls_SynEN.CourseName = objRow[convCurrEduCls_Syn.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseName].ToString().Trim(); //课程名称
objvCurrEduCls_SynEN.ViewCount = objRow[convCurrEduCls_Syn.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.ViewCount].ToString().Trim()); //浏览量
objvCurrEduCls_SynEN.ExampleImgPath = objRow[convCurrEduCls_Syn.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduCls_SynEN.TeachingSolutionName = objRow[convCurrEduCls_Syn.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduCls_SynEN.IdTeacher = objRow[convCurrEduCls_Syn.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduCls_SynEN.TeacherId = objRow[convCurrEduCls_Syn.TeacherId].ToString().Trim(); //教师工号
objvCurrEduCls_SynEN.TeacherName = objRow[convCurrEduCls_Syn.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduCls_SynEN.CollegeId = objRow[convCurrEduCls_Syn.CollegeId].ToString().Trim(); //学院ID
objvCurrEduCls_SynEN.CollegeName = objRow[convCurrEduCls_Syn.CollegeName].ToString().Trim(); //学院名称
objvCurrEduCls_SynEN.IdXzMajor = objRow[convCurrEduCls_Syn.IdXzMajor].ToString().Trim(); //专业流水号
objvCurrEduCls_SynEN.MajorName = objRow[convCurrEduCls_Syn.MajorName].ToString().Trim(); //专业名称
objvCurrEduCls_SynEN.GradeBaseId = objRow[convCurrEduCls_Syn.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduCls_SynEN.GradeBaseName = objRow[convCurrEduCls_Syn.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduCls_SynEN.GradeBaseNameA = objRow[convCurrEduCls_Syn.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvCurrEduCls_SynEN.CourseTypeId = objRow[convCurrEduCls_Syn.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduCls_SynEN.CourseTypeName = objRow[convCurrEduCls_Syn.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduCls_SynEN.CurrStuNumValid = objRow[convCurrEduCls_Syn.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduCls_SynEN.CurrStuNum = objRow[convCurrEduCls_Syn.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduCls_SynEN.CurrEduClsId = objRow[convCurrEduCls_Syn.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduCls_SynEN.EduClsName = objRow[convCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名
objvCurrEduCls_SynEN.EduClsTypeId = objRow[convCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduCls_SynEN.CourseId = objRow[convCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id
objvCurrEduCls_SynEN.TeachingSolutionId = objRow[convCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduCls_SynEN.IdXzCollege = objRow[convCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduCls_SynEN.IdEduWay = objRow[convCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduCls_SynEN.IdClassRoomType = objRow[convCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号
objvCurrEduCls_SynEN.TotalLessonQty = Int32.Parse(objRow[convCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduCls_SynEN.MaxStuQty = objRow[convCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduCls_SynEN.WeekQty = objRow[convCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数
objvCurrEduCls_SynEN.ScheUnitPW = objRow[convCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduCls_SynEN.WeekStatusId = objRow[convCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduCls_SynEN.CustomerWeek = objRow[convCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduCls_SynEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objvCurrEduCls_SynEN.IdExecPlan = objRow[convCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号
objvCurrEduCls_SynEN.LessonQtyPerWeek = short.Parse(objRow[convCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduCls_SynEN.Mark = objRow[convCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分
objvCurrEduCls_SynEN.CheckClassRoom = objRow[convCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果
objvCurrEduCls_SynEN.CheckAdminCls = objRow[convCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果
objvCurrEduCls_SynEN.CheckTeacher = objRow[convCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果
objvCurrEduCls_SynEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定
objvCurrEduCls_SynEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课
objvCurrEduCls_SynEN.IdUniZone = objRow[convCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduCls_SynEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态
objvCurrEduCls_SynEN.IdGradeBase = objRow[convCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduCls_SynEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效
objvCurrEduCls_SynEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objvCurrEduCls_SynEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objvCurrEduCls_SynEN.SchoolYear = objRow[convCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年
objvCurrEduCls_SynEN.SchoolTerm = objRow[convCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期
objvCurrEduCls_SynEN.ArrangeCourseMemo = objRow[convCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注
objvCurrEduCls_SynEN.IdCourseType = objRow[convCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduCls_SynEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduCls_SynEN.IdScoreType = objRow[convCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduCls_SynEN.GetScoreWayId = objRow[convCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objvCurrEduCls_SynEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduCls_SynEN.IdExamType = objRow[convCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduCls_SynEN.ExamPortion = short.Parse(objRow[convCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例
objvCurrEduCls_SynEN.MidExamScorePortion = objRow[convCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objvCurrEduCls_SynEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩
objvCurrEduCls_SynEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令
objvCurrEduCls_SynEN.GeneratePwdDate = objRow[convCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间
objvCurrEduCls_SynEN.PkWeekTime = objRow[convCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间
objvCurrEduCls_SynEN.PkClassRooms = objRow[convCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室
objvCurrEduCls_SynEN.BeginWeek = objRow[convCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周
objvCurrEduCls_SynEN.TeacherNames = objRow[convCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名
objvCurrEduCls_SynEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步
objvCurrEduCls_SynEN.SynchDate = objRow[convCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期
objvCurrEduCls_SynEN.ModifyDate = objRow[convCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduCls_SynEN.ModifyUserId = objRow[convCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduCls_SynEN.Memo = objRow[convCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.Memo].ToString().Trim(); //备注
objvCurrEduCls_SynEN.SignInDate = objRow[convCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间
objvCurrEduCls_SynEN.SignInStateID = objRow[convCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号
objvCurrEduCls_SynEN.SignInUser = objRow[convCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人
objvCurrEduCls_SynEN.SynchToWebUser = objRow[convCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户
objvCurrEduCls_SynEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web
objvCurrEduCls_SynEN.SynchToWebDate = objRow[convCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduCls_SynEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduCls_SynEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCurrEduCls_Syn(ref clsvCurrEduCls_SynEN objvCurrEduCls_SynEN)
{
bool bolResult = vCurrEduCls_SynDA.GetvCurrEduCls_Syn(ref objvCurrEduCls_SynEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCurrEduCls">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCurrEduCls_SynEN GetObjByIdCurrEduCls(string strIdCurrEduCls)
{
if (strIdCurrEduCls.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdCurrEduCls]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdCurrEduCls]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvCurrEduCls_SynEN objvCurrEduCls_SynEN = vCurrEduCls_SynDA.GetObjByIdCurrEduCls(strIdCurrEduCls);
return objvCurrEduCls_SynEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCurrEduCls_SynEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCurrEduCls_SynEN objvCurrEduCls_SynEN = vCurrEduCls_SynDA.GetFirstObj(strWhereCond);
 return objvCurrEduCls_SynEN;
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
public static clsvCurrEduCls_SynEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCurrEduCls_SynEN objvCurrEduCls_SynEN = vCurrEduCls_SynDA.GetObjByDataRow(objRow);
 return objvCurrEduCls_SynEN;
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
public static clsvCurrEduCls_SynEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCurrEduCls_SynEN objvCurrEduCls_SynEN = vCurrEduCls_SynDA.GetObjByDataRow(objRow);
 return objvCurrEduCls_SynEN;
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
 /// <param name = "strIdCurrEduCls">所给的关键字</param>
 /// <param name = "lstvCurrEduCls_SynObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCurrEduCls_SynEN GetObjByIdCurrEduClsFromList(string strIdCurrEduCls, List<clsvCurrEduCls_SynEN> lstvCurrEduCls_SynObjLst)
{
foreach (clsvCurrEduCls_SynEN objvCurrEduCls_SynEN in lstvCurrEduCls_SynObjLst)
{
if (objvCurrEduCls_SynEN.IdCurrEduCls == strIdCurrEduCls)
{
return objvCurrEduCls_SynEN;
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
 string strMaxIdCurrEduCls;
 try
 {
 strMaxIdCurrEduCls = clsvCurrEduCls_SynDA.GetMaxStrId();
 return strMaxIdCurrEduCls;
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
 string strIdCurrEduCls;
 try
 {
 strIdCurrEduCls = new clsvCurrEduCls_SynDA().GetFirstID(strWhereCond);
 return strIdCurrEduCls;
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
 arrList = vCurrEduCls_SynDA.GetID(strWhereCond);
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
bool bolIsExist = vCurrEduCls_SynDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdCurrEduCls]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vCurrEduCls_SynDA.IsExist(strIdCurrEduCls);
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
 bolIsExist = clsvCurrEduCls_SynDA.IsExistTable();
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
 bolIsExist = vCurrEduCls_SynDA.IsExistTable(strTabName);
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
 /// <param name = "objvCurrEduCls_SynENS">源对象</param>
 /// <param name = "objvCurrEduCls_SynENT">目标对象</param>
 public static void CopyTo(clsvCurrEduCls_SynEN objvCurrEduCls_SynENS, clsvCurrEduCls_SynEN objvCurrEduCls_SynENT)
{
try
{
objvCurrEduCls_SynENT.IdCurrEduCls = objvCurrEduCls_SynENS.IdCurrEduCls; //教学班流水号
objvCurrEduCls_SynENT.EduClsTypeName = objvCurrEduCls_SynENS.EduClsTypeName; //教学班类型名称
objvCurrEduCls_SynENT.CourseCode = objvCurrEduCls_SynENS.CourseCode; //课程代码
objvCurrEduCls_SynENT.CourseDescription = objvCurrEduCls_SynENS.CourseDescription; //课程描述
objvCurrEduCls_SynENT.CourseName = objvCurrEduCls_SynENS.CourseName; //课程名称
objvCurrEduCls_SynENT.ViewCount = objvCurrEduCls_SynENS.ViewCount; //浏览量
objvCurrEduCls_SynENT.ExampleImgPath = objvCurrEduCls_SynENS.ExampleImgPath; //示例图路径
objvCurrEduCls_SynENT.TeachingSolutionName = objvCurrEduCls_SynENS.TeachingSolutionName; //教学方案名称
objvCurrEduCls_SynENT.IdTeacher = objvCurrEduCls_SynENS.IdTeacher; //教师流水号
objvCurrEduCls_SynENT.TeacherId = objvCurrEduCls_SynENS.TeacherId; //教师工号
objvCurrEduCls_SynENT.TeacherName = objvCurrEduCls_SynENS.TeacherName; //教师姓名
objvCurrEduCls_SynENT.CollegeId = objvCurrEduCls_SynENS.CollegeId; //学院ID
objvCurrEduCls_SynENT.CollegeName = objvCurrEduCls_SynENS.CollegeName; //学院名称
objvCurrEduCls_SynENT.IdXzMajor = objvCurrEduCls_SynENS.IdXzMajor; //专业流水号
objvCurrEduCls_SynENT.MajorName = objvCurrEduCls_SynENS.MajorName; //专业名称
objvCurrEduCls_SynENT.GradeBaseId = objvCurrEduCls_SynENS.GradeBaseId; //年级代号
objvCurrEduCls_SynENT.GradeBaseName = objvCurrEduCls_SynENS.GradeBaseName; //年级名称
objvCurrEduCls_SynENT.GradeBaseNameA = objvCurrEduCls_SynENS.GradeBaseNameA; //年级名称缩写
objvCurrEduCls_SynENT.CourseTypeId = objvCurrEduCls_SynENS.CourseTypeId; //课程类型ID
objvCurrEduCls_SynENT.CourseTypeName = objvCurrEduCls_SynENS.CourseTypeName; //课程类型名称
objvCurrEduCls_SynENT.CurrStuNumValid = objvCurrEduCls_SynENS.CurrStuNumValid; //CurrStuNum_Valid
objvCurrEduCls_SynENT.CurrStuNum = objvCurrEduCls_SynENS.CurrStuNum; //当前学生数
objvCurrEduCls_SynENT.CurrEduClsId = objvCurrEduCls_SynENS.CurrEduClsId; //教学班Id
objvCurrEduCls_SynENT.EduClsName = objvCurrEduCls_SynENS.EduClsName; //教学班名
objvCurrEduCls_SynENT.EduClsTypeId = objvCurrEduCls_SynENS.EduClsTypeId; //教学班类型Id
objvCurrEduCls_SynENT.CourseId = objvCurrEduCls_SynENS.CourseId; //课程Id
objvCurrEduCls_SynENT.TeachingSolutionId = objvCurrEduCls_SynENS.TeachingSolutionId; //教学方案Id
objvCurrEduCls_SynENT.IdXzCollege = objvCurrEduCls_SynENS.IdXzCollege; //学院流水号
objvCurrEduCls_SynENT.IdEduWay = objvCurrEduCls_SynENS.IdEduWay; //教学方式流水号
objvCurrEduCls_SynENT.IdClassRoomType = objvCurrEduCls_SynENS.IdClassRoomType; //教室类型流水号
objvCurrEduCls_SynENT.TotalLessonQty = objvCurrEduCls_SynENS.TotalLessonQty; //总课时数
objvCurrEduCls_SynENT.MaxStuQty = objvCurrEduCls_SynENS.MaxStuQty; //最大学生数
objvCurrEduCls_SynENT.WeekQty = objvCurrEduCls_SynENS.WeekQty; //总周数
objvCurrEduCls_SynENT.ScheUnitPW = objvCurrEduCls_SynENS.ScheUnitPW; //周排课次数
objvCurrEduCls_SynENT.WeekStatusId = objvCurrEduCls_SynENS.WeekStatusId; //周状态编号(单,双,全周)
objvCurrEduCls_SynENT.CustomerWeek = objvCurrEduCls_SynENS.CustomerWeek; //自定义上课周
objvCurrEduCls_SynENT.IsCompleteScore = objvCurrEduCls_SynENS.IsCompleteScore; //是否成绩齐全
objvCurrEduCls_SynENT.IdExecPlan = objvCurrEduCls_SynENS.IdExecPlan; //执行计划流水号
objvCurrEduCls_SynENT.LessonQtyPerWeek = objvCurrEduCls_SynENS.LessonQtyPerWeek; //周课时数
objvCurrEduCls_SynENT.Mark = objvCurrEduCls_SynENS.Mark; //获得学分
objvCurrEduCls_SynENT.CheckClassRoom = objvCurrEduCls_SynENS.CheckClassRoom; //检查教室结果
objvCurrEduCls_SynENT.CheckAdminCls = objvCurrEduCls_SynENS.CheckAdminCls; //检查行政班结果
objvCurrEduCls_SynENT.CheckTeacher = objvCurrEduCls_SynENS.CheckTeacher; //检查教师结果
objvCurrEduCls_SynENT.EditLocked = objvCurrEduCls_SynENS.EditLocked; //编辑锁定
objvCurrEduCls_SynENT.Sched = objvCurrEduCls_SynENS.Sched; //是否排课
objvCurrEduCls_SynENT.IdUniZone = objvCurrEduCls_SynENS.IdUniZone; //校区流水号
objvCurrEduCls_SynENT.Locked = objvCurrEduCls_SynENS.Locked; //锁定状态
objvCurrEduCls_SynENT.IdGradeBase = objvCurrEduCls_SynENS.IdGradeBase; //年级流水号
objvCurrEduCls_SynENT.IsEffective = objvCurrEduCls_SynENS.IsEffective; //是否有效
objvCurrEduCls_SynENT.IsForPaperReading = objvCurrEduCls_SynENS.IsForPaperReading; //是否参与论文阅读
objvCurrEduCls_SynENT.IsUnDeterminedClsRm = objvCurrEduCls_SynENS.IsUnDeterminedClsRm; //是否待定教室
objvCurrEduCls_SynENT.SchoolYear = objvCurrEduCls_SynENS.SchoolYear; //学年
objvCurrEduCls_SynENT.SchoolTerm = objvCurrEduCls_SynENS.SchoolTerm; //学期
objvCurrEduCls_SynENT.ArrangeCourseMemo = objvCurrEduCls_SynENS.ArrangeCourseMemo; //排课备注
objvCurrEduCls_SynENT.IdCourseType = objvCurrEduCls_SynENS.IdCourseType; //课程类型流水号
objvCurrEduCls_SynENT.IsDegree = objvCurrEduCls_SynENS.IsDegree; //是否学位课
objvCurrEduCls_SynENT.IdScoreType = objvCurrEduCls_SynENS.IdScoreType; //成绩类型流水号
objvCurrEduCls_SynENT.GetScoreWayId = objvCurrEduCls_SynENS.GetScoreWayId; //获得成绩方式Id
objvCurrEduCls_SynENT.IsProportionalCtrl = objvCurrEduCls_SynENS.IsProportionalCtrl; //是否比例控制
objvCurrEduCls_SynENT.IdExamType = objvCurrEduCls_SynENS.IdExamType; //考试方式流水号
objvCurrEduCls_SynENT.ExamPortion = objvCurrEduCls_SynENS.ExamPortion; //平时成绩所占比例
objvCurrEduCls_SynENT.MidExamScorePortion = objvCurrEduCls_SynENS.MidExamScorePortion; //期末成绩所占比例
objvCurrEduCls_SynENT.IsClearScore = objvCurrEduCls_SynENS.IsClearScore; //是否重录成绩
objvCurrEduCls_SynENT.IsGeneratePwd = objvCurrEduCls_SynENS.IsGeneratePwd; //是否生成口令
objvCurrEduCls_SynENT.GeneratePwdDate = objvCurrEduCls_SynENS.GeneratePwdDate; //生成口令时间
objvCurrEduCls_SynENT.PkWeekTime = objvCurrEduCls_SynENS.PkWeekTime; //排课时间
objvCurrEduCls_SynENT.PkClassRooms = objvCurrEduCls_SynENS.PkClassRooms; //排课教室
objvCurrEduCls_SynENT.BeginWeek = objvCurrEduCls_SynENS.BeginWeek; //开始周
objvCurrEduCls_SynENT.TeacherNames = objvCurrEduCls_SynENS.TeacherNames; //教师姓名
objvCurrEduCls_SynENT.IsSynch = objvCurrEduCls_SynENS.IsSynch; //是否同步
objvCurrEduCls_SynENT.SynchDate = objvCurrEduCls_SynENS.SynchDate; //同步日期
objvCurrEduCls_SynENT.ModifyDate = objvCurrEduCls_SynENS.ModifyDate; //修改日期
objvCurrEduCls_SynENT.ModifyUserId = objvCurrEduCls_SynENS.ModifyUserId; //修改人
objvCurrEduCls_SynENT.Memo = objvCurrEduCls_SynENS.Memo; //备注
objvCurrEduCls_SynENT.SignInDate = objvCurrEduCls_SynENS.SignInDate; //签入时间
objvCurrEduCls_SynENT.SignInStateID = objvCurrEduCls_SynENS.SignInStateID; //签入状态表流水号
objvCurrEduCls_SynENT.SignInUser = objvCurrEduCls_SynENS.SignInUser; //签入人
objvCurrEduCls_SynENT.SynchToWebUser = objvCurrEduCls_SynENS.SynchToWebUser; //同步Web用户
objvCurrEduCls_SynENT.IsSynchToWeb = objvCurrEduCls_SynENS.IsSynchToWeb; //是否同步Web
objvCurrEduCls_SynENT.SynchToWebDate = objvCurrEduCls_SynENS.SynchToWebDate; //同步Web日期
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
 /// <param name = "objvCurrEduCls_SynEN">源简化对象</param>
 public static void SetUpdFlag(clsvCurrEduCls_SynEN objvCurrEduCls_SynEN)
{
try
{
objvCurrEduCls_SynEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCurrEduCls_SynEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCurrEduCls_Syn.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.IdCurrEduCls = objvCurrEduCls_SynEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convCurrEduCls_Syn.EduClsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.EduClsTypeName = objvCurrEduCls_SynEN.EduClsTypeName == "[null]" ? null :  objvCurrEduCls_SynEN.EduClsTypeName; //教学班类型名称
}
if (arrFldSet.Contains(convCurrEduCls_Syn.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.CourseCode = objvCurrEduCls_SynEN.CourseCode == "[null]" ? null :  objvCurrEduCls_SynEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convCurrEduCls_Syn.CourseDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.CourseDescription = objvCurrEduCls_SynEN.CourseDescription == "[null]" ? null :  objvCurrEduCls_SynEN.CourseDescription; //课程描述
}
if (arrFldSet.Contains(convCurrEduCls_Syn.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.CourseName = objvCurrEduCls_SynEN.CourseName == "[null]" ? null :  objvCurrEduCls_SynEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convCurrEduCls_Syn.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.ViewCount = objvCurrEduCls_SynEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(convCurrEduCls_Syn.ExampleImgPath, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.ExampleImgPath = objvCurrEduCls_SynEN.ExampleImgPath == "[null]" ? null :  objvCurrEduCls_SynEN.ExampleImgPath; //示例图路径
}
if (arrFldSet.Contains(convCurrEduCls_Syn.TeachingSolutionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.TeachingSolutionName = objvCurrEduCls_SynEN.TeachingSolutionName; //教学方案名称
}
if (arrFldSet.Contains(convCurrEduCls_Syn.IdTeacher, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.IdTeacher = objvCurrEduCls_SynEN.IdTeacher; //教师流水号
}
if (arrFldSet.Contains(convCurrEduCls_Syn.TeacherId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.TeacherId = objvCurrEduCls_SynEN.TeacherId; //教师工号
}
if (arrFldSet.Contains(convCurrEduCls_Syn.TeacherName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.TeacherName = objvCurrEduCls_SynEN.TeacherName; //教师姓名
}
if (arrFldSet.Contains(convCurrEduCls_Syn.CollegeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.CollegeId = objvCurrEduCls_SynEN.CollegeId; //学院ID
}
if (arrFldSet.Contains(convCurrEduCls_Syn.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.CollegeName = objvCurrEduCls_SynEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convCurrEduCls_Syn.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.IdXzMajor = objvCurrEduCls_SynEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convCurrEduCls_Syn.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.MajorName = objvCurrEduCls_SynEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convCurrEduCls_Syn.GradeBaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.GradeBaseId = objvCurrEduCls_SynEN.GradeBaseId == "[null]" ? null :  objvCurrEduCls_SynEN.GradeBaseId; //年级代号
}
if (arrFldSet.Contains(convCurrEduCls_Syn.GradeBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.GradeBaseName = objvCurrEduCls_SynEN.GradeBaseName; //年级名称
}
if (arrFldSet.Contains(convCurrEduCls_Syn.GradeBaseNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.GradeBaseNameA = objvCurrEduCls_SynEN.GradeBaseNameA; //年级名称缩写
}
if (arrFldSet.Contains(convCurrEduCls_Syn.CourseTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.CourseTypeId = objvCurrEduCls_SynEN.CourseTypeId; //课程类型ID
}
if (arrFldSet.Contains(convCurrEduCls_Syn.CourseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.CourseTypeName = objvCurrEduCls_SynEN.CourseTypeName; //课程类型名称
}
if (arrFldSet.Contains(convCurrEduCls_Syn.CurrStuNumValid, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.CurrStuNumValid = objvCurrEduCls_SynEN.CurrStuNumValid; //CurrStuNum_Valid
}
if (arrFldSet.Contains(convCurrEduCls_Syn.CurrStuNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.CurrStuNum = objvCurrEduCls_SynEN.CurrStuNum; //当前学生数
}
if (arrFldSet.Contains(convCurrEduCls_Syn.CurrEduClsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.CurrEduClsId = objvCurrEduCls_SynEN.CurrEduClsId == "[null]" ? null :  objvCurrEduCls_SynEN.CurrEduClsId; //教学班Id
}
if (arrFldSet.Contains(convCurrEduCls_Syn.EduClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.EduClsName = objvCurrEduCls_SynEN.EduClsName; //教学班名
}
if (arrFldSet.Contains(convCurrEduCls_Syn.EduClsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.EduClsTypeId = objvCurrEduCls_SynEN.EduClsTypeId; //教学班类型Id
}
if (arrFldSet.Contains(convCurrEduCls_Syn.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.CourseId = objvCurrEduCls_SynEN.CourseId == "[null]" ? null :  objvCurrEduCls_SynEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convCurrEduCls_Syn.TeachingSolutionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.TeachingSolutionId = objvCurrEduCls_SynEN.TeachingSolutionId; //教学方案Id
}
if (arrFldSet.Contains(convCurrEduCls_Syn.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.IdXzCollege = objvCurrEduCls_SynEN.IdXzCollege == "[null]" ? null :  objvCurrEduCls_SynEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convCurrEduCls_Syn.IdEduWay, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.IdEduWay = objvCurrEduCls_SynEN.IdEduWay; //教学方式流水号
}
if (arrFldSet.Contains(convCurrEduCls_Syn.IdClassRoomType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.IdClassRoomType = objvCurrEduCls_SynEN.IdClassRoomType; //教室类型流水号
}
if (arrFldSet.Contains(convCurrEduCls_Syn.TotalLessonQty, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.TotalLessonQty = objvCurrEduCls_SynEN.TotalLessonQty; //总课时数
}
if (arrFldSet.Contains(convCurrEduCls_Syn.MaxStuQty, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.MaxStuQty = objvCurrEduCls_SynEN.MaxStuQty; //最大学生数
}
if (arrFldSet.Contains(convCurrEduCls_Syn.WeekQty, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.WeekQty = objvCurrEduCls_SynEN.WeekQty; //总周数
}
if (arrFldSet.Contains(convCurrEduCls_Syn.ScheUnitPW, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.ScheUnitPW = objvCurrEduCls_SynEN.ScheUnitPW; //周排课次数
}
if (arrFldSet.Contains(convCurrEduCls_Syn.WeekStatusId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.WeekStatusId = objvCurrEduCls_SynEN.WeekStatusId == "[null]" ? null :  objvCurrEduCls_SynEN.WeekStatusId; //周状态编号(单,双,全周)
}
if (arrFldSet.Contains(convCurrEduCls_Syn.CustomerWeek, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.CustomerWeek = objvCurrEduCls_SynEN.CustomerWeek == "[null]" ? null :  objvCurrEduCls_SynEN.CustomerWeek; //自定义上课周
}
if (arrFldSet.Contains(convCurrEduCls_Syn.IsCompleteScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.IsCompleteScore = objvCurrEduCls_SynEN.IsCompleteScore; //是否成绩齐全
}
if (arrFldSet.Contains(convCurrEduCls_Syn.IdExecPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.IdExecPlan = objvCurrEduCls_SynEN.IdExecPlan; //执行计划流水号
}
if (arrFldSet.Contains(convCurrEduCls_Syn.LessonQtyPerWeek, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.LessonQtyPerWeek = objvCurrEduCls_SynEN.LessonQtyPerWeek; //周课时数
}
if (arrFldSet.Contains(convCurrEduCls_Syn.Mark, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.Mark = objvCurrEduCls_SynEN.Mark; //获得学分
}
if (arrFldSet.Contains(convCurrEduCls_Syn.CheckClassRoom, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.CheckClassRoom = objvCurrEduCls_SynEN.CheckClassRoom == "[null]" ? null :  objvCurrEduCls_SynEN.CheckClassRoom; //检查教室结果
}
if (arrFldSet.Contains(convCurrEduCls_Syn.CheckAdminCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.CheckAdminCls = objvCurrEduCls_SynEN.CheckAdminCls == "[null]" ? null :  objvCurrEduCls_SynEN.CheckAdminCls; //检查行政班结果
}
if (arrFldSet.Contains(convCurrEduCls_Syn.CheckTeacher, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.CheckTeacher = objvCurrEduCls_SynEN.CheckTeacher == "[null]" ? null :  objvCurrEduCls_SynEN.CheckTeacher; //检查教师结果
}
if (arrFldSet.Contains(convCurrEduCls_Syn.EditLocked, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.EditLocked = objvCurrEduCls_SynEN.EditLocked; //编辑锁定
}
if (arrFldSet.Contains(convCurrEduCls_Syn.Sched, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.Sched = objvCurrEduCls_SynEN.Sched; //是否排课
}
if (arrFldSet.Contains(convCurrEduCls_Syn.IdUniZone, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.IdUniZone = objvCurrEduCls_SynEN.IdUniZone; //校区流水号
}
if (arrFldSet.Contains(convCurrEduCls_Syn.Locked, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.Locked = objvCurrEduCls_SynEN.Locked; //锁定状态
}
if (arrFldSet.Contains(convCurrEduCls_Syn.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.IdGradeBase = objvCurrEduCls_SynEN.IdGradeBase == "[null]" ? null :  objvCurrEduCls_SynEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(convCurrEduCls_Syn.IsEffective, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.IsEffective = objvCurrEduCls_SynEN.IsEffective; //是否有效
}
if (arrFldSet.Contains(convCurrEduCls_Syn.IsForPaperReading, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.IsForPaperReading = objvCurrEduCls_SynEN.IsForPaperReading; //是否参与论文阅读
}
if (arrFldSet.Contains(convCurrEduCls_Syn.IsUnDeterminedClsRm, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.IsUnDeterminedClsRm = objvCurrEduCls_SynEN.IsUnDeterminedClsRm; //是否待定教室
}
if (arrFldSet.Contains(convCurrEduCls_Syn.SchoolYear, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.SchoolYear = objvCurrEduCls_SynEN.SchoolYear == "[null]" ? null :  objvCurrEduCls_SynEN.SchoolYear; //学年
}
if (arrFldSet.Contains(convCurrEduCls_Syn.SchoolTerm, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.SchoolTerm = objvCurrEduCls_SynEN.SchoolTerm == "[null]" ? null :  objvCurrEduCls_SynEN.SchoolTerm; //学期
}
if (arrFldSet.Contains(convCurrEduCls_Syn.ArrangeCourseMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.ArrangeCourseMemo = objvCurrEduCls_SynEN.ArrangeCourseMemo == "[null]" ? null :  objvCurrEduCls_SynEN.ArrangeCourseMemo; //排课备注
}
if (arrFldSet.Contains(convCurrEduCls_Syn.IdCourseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.IdCourseType = objvCurrEduCls_SynEN.IdCourseType; //课程类型流水号
}
if (arrFldSet.Contains(convCurrEduCls_Syn.IsDegree, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.IsDegree = objvCurrEduCls_SynEN.IsDegree; //是否学位课
}
if (arrFldSet.Contains(convCurrEduCls_Syn.IdScoreType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.IdScoreType = objvCurrEduCls_SynEN.IdScoreType; //成绩类型流水号
}
if (arrFldSet.Contains(convCurrEduCls_Syn.GetScoreWayId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.GetScoreWayId = objvCurrEduCls_SynEN.GetScoreWayId == "[null]" ? null :  objvCurrEduCls_SynEN.GetScoreWayId; //获得成绩方式Id
}
if (arrFldSet.Contains(convCurrEduCls_Syn.IsProportionalCtrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.IsProportionalCtrl = objvCurrEduCls_SynEN.IsProportionalCtrl; //是否比例控制
}
if (arrFldSet.Contains(convCurrEduCls_Syn.IdExamType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.IdExamType = objvCurrEduCls_SynEN.IdExamType; //考试方式流水号
}
if (arrFldSet.Contains(convCurrEduCls_Syn.ExamPortion, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.ExamPortion = objvCurrEduCls_SynEN.ExamPortion; //平时成绩所占比例
}
if (arrFldSet.Contains(convCurrEduCls_Syn.MidExamScorePortion, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.MidExamScorePortion = objvCurrEduCls_SynEN.MidExamScorePortion; //期末成绩所占比例
}
if (arrFldSet.Contains(convCurrEduCls_Syn.IsClearScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.IsClearScore = objvCurrEduCls_SynEN.IsClearScore; //是否重录成绩
}
if (arrFldSet.Contains(convCurrEduCls_Syn.IsGeneratePwd, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.IsGeneratePwd = objvCurrEduCls_SynEN.IsGeneratePwd; //是否生成口令
}
if (arrFldSet.Contains(convCurrEduCls_Syn.GeneratePwdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.GeneratePwdDate = objvCurrEduCls_SynEN.GeneratePwdDate == "[null]" ? null :  objvCurrEduCls_SynEN.GeneratePwdDate; //生成口令时间
}
if (arrFldSet.Contains(convCurrEduCls_Syn.PkWeekTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.PkWeekTime = objvCurrEduCls_SynEN.PkWeekTime == "[null]" ? null :  objvCurrEduCls_SynEN.PkWeekTime; //排课时间
}
if (arrFldSet.Contains(convCurrEduCls_Syn.PkClassRooms, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.PkClassRooms = objvCurrEduCls_SynEN.PkClassRooms == "[null]" ? null :  objvCurrEduCls_SynEN.PkClassRooms; //排课教室
}
if (arrFldSet.Contains(convCurrEduCls_Syn.BeginWeek, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.BeginWeek = objvCurrEduCls_SynEN.BeginWeek; //开始周
}
if (arrFldSet.Contains(convCurrEduCls_Syn.TeacherNames, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.TeacherNames = objvCurrEduCls_SynEN.TeacherNames == "[null]" ? null :  objvCurrEduCls_SynEN.TeacherNames; //教师姓名
}
if (arrFldSet.Contains(convCurrEduCls_Syn.IsSynch, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.IsSynch = objvCurrEduCls_SynEN.IsSynch; //是否同步
}
if (arrFldSet.Contains(convCurrEduCls_Syn.SynchDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.SynchDate = objvCurrEduCls_SynEN.SynchDate; //同步日期
}
if (arrFldSet.Contains(convCurrEduCls_Syn.ModifyDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.ModifyDate = objvCurrEduCls_SynEN.ModifyDate == "[null]" ? null :  objvCurrEduCls_SynEN.ModifyDate; //修改日期
}
if (arrFldSet.Contains(convCurrEduCls_Syn.ModifyUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.ModifyUserId = objvCurrEduCls_SynEN.ModifyUserId == "[null]" ? null :  objvCurrEduCls_SynEN.ModifyUserId; //修改人
}
if (arrFldSet.Contains(convCurrEduCls_Syn.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.Memo = objvCurrEduCls_SynEN.Memo == "[null]" ? null :  objvCurrEduCls_SynEN.Memo; //备注
}
if (arrFldSet.Contains(convCurrEduCls_Syn.SignInDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.SignInDate = objvCurrEduCls_SynEN.SignInDate == "[null]" ? null :  objvCurrEduCls_SynEN.SignInDate; //签入时间
}
if (arrFldSet.Contains(convCurrEduCls_Syn.SignInStateID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.SignInStateID = objvCurrEduCls_SynEN.SignInStateID == "[null]" ? null :  objvCurrEduCls_SynEN.SignInStateID; //签入状态表流水号
}
if (arrFldSet.Contains(convCurrEduCls_Syn.SignInUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.SignInUser = objvCurrEduCls_SynEN.SignInUser == "[null]" ? null :  objvCurrEduCls_SynEN.SignInUser; //签入人
}
if (arrFldSet.Contains(convCurrEduCls_Syn.SynchToWebUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.SynchToWebUser = objvCurrEduCls_SynEN.SynchToWebUser == "[null]" ? null :  objvCurrEduCls_SynEN.SynchToWebUser; //同步Web用户
}
if (arrFldSet.Contains(convCurrEduCls_Syn.IsSynchToWeb, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.IsSynchToWeb = objvCurrEduCls_SynEN.IsSynchToWeb; //是否同步Web
}
if (arrFldSet.Contains(convCurrEduCls_Syn.SynchToWebDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SynEN.SynchToWebDate = objvCurrEduCls_SynEN.SynchToWebDate == "[null]" ? null :  objvCurrEduCls_SynEN.SynchToWebDate; //同步Web日期
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
 /// <param name = "objvCurrEduCls_SynEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCurrEduCls_SynEN objvCurrEduCls_SynEN)
{
try
{
if (objvCurrEduCls_SynEN.EduClsTypeName == "[null]") objvCurrEduCls_SynEN.EduClsTypeName = null; //教学班类型名称
if (objvCurrEduCls_SynEN.CourseCode == "[null]") objvCurrEduCls_SynEN.CourseCode = null; //课程代码
if (objvCurrEduCls_SynEN.CourseDescription == "[null]") objvCurrEduCls_SynEN.CourseDescription = null; //课程描述
if (objvCurrEduCls_SynEN.CourseName == "[null]") objvCurrEduCls_SynEN.CourseName = null; //课程名称
if (objvCurrEduCls_SynEN.ExampleImgPath == "[null]") objvCurrEduCls_SynEN.ExampleImgPath = null; //示例图路径
if (objvCurrEduCls_SynEN.GradeBaseId == "[null]") objvCurrEduCls_SynEN.GradeBaseId = null; //年级代号
if (objvCurrEduCls_SynEN.CurrEduClsId == "[null]") objvCurrEduCls_SynEN.CurrEduClsId = null; //教学班Id
if (objvCurrEduCls_SynEN.CourseId == "[null]") objvCurrEduCls_SynEN.CourseId = null; //课程Id
if (objvCurrEduCls_SynEN.IdXzCollege == "[null]") objvCurrEduCls_SynEN.IdXzCollege = null; //学院流水号
if (objvCurrEduCls_SynEN.WeekStatusId == "[null]") objvCurrEduCls_SynEN.WeekStatusId = null; //周状态编号(单,双,全周)
if (objvCurrEduCls_SynEN.CustomerWeek == "[null]") objvCurrEduCls_SynEN.CustomerWeek = null; //自定义上课周
if (objvCurrEduCls_SynEN.CheckClassRoom == "[null]") objvCurrEduCls_SynEN.CheckClassRoom = null; //检查教室结果
if (objvCurrEduCls_SynEN.CheckAdminCls == "[null]") objvCurrEduCls_SynEN.CheckAdminCls = null; //检查行政班结果
if (objvCurrEduCls_SynEN.CheckTeacher == "[null]") objvCurrEduCls_SynEN.CheckTeacher = null; //检查教师结果
if (objvCurrEduCls_SynEN.IdGradeBase == "[null]") objvCurrEduCls_SynEN.IdGradeBase = null; //年级流水号
if (objvCurrEduCls_SynEN.SchoolYear == "[null]") objvCurrEduCls_SynEN.SchoolYear = null; //学年
if (objvCurrEduCls_SynEN.SchoolTerm == "[null]") objvCurrEduCls_SynEN.SchoolTerm = null; //学期
if (objvCurrEduCls_SynEN.ArrangeCourseMemo == "[null]") objvCurrEduCls_SynEN.ArrangeCourseMemo = null; //排课备注
if (objvCurrEduCls_SynEN.GetScoreWayId == "[null]") objvCurrEduCls_SynEN.GetScoreWayId = null; //获得成绩方式Id
if (objvCurrEduCls_SynEN.GeneratePwdDate == "[null]") objvCurrEduCls_SynEN.GeneratePwdDate = null; //生成口令时间
if (objvCurrEduCls_SynEN.PkWeekTime == "[null]") objvCurrEduCls_SynEN.PkWeekTime = null; //排课时间
if (objvCurrEduCls_SynEN.PkClassRooms == "[null]") objvCurrEduCls_SynEN.PkClassRooms = null; //排课教室
if (objvCurrEduCls_SynEN.TeacherNames == "[null]") objvCurrEduCls_SynEN.TeacherNames = null; //教师姓名
if (objvCurrEduCls_SynEN.ModifyDate == "[null]") objvCurrEduCls_SynEN.ModifyDate = null; //修改日期
if (objvCurrEduCls_SynEN.ModifyUserId == "[null]") objvCurrEduCls_SynEN.ModifyUserId = null; //修改人
if (objvCurrEduCls_SynEN.Memo == "[null]") objvCurrEduCls_SynEN.Memo = null; //备注
if (objvCurrEduCls_SynEN.SignInDate == "[null]") objvCurrEduCls_SynEN.SignInDate = null; //签入时间
if (objvCurrEduCls_SynEN.SignInStateID == "[null]") objvCurrEduCls_SynEN.SignInStateID = null; //签入状态表流水号
if (objvCurrEduCls_SynEN.SignInUser == "[null]") objvCurrEduCls_SynEN.SignInUser = null; //签入人
if (objvCurrEduCls_SynEN.SynchToWebUser == "[null]") objvCurrEduCls_SynEN.SynchToWebUser = null; //同步Web用户
if (objvCurrEduCls_SynEN.SynchToWebDate == "[null]") objvCurrEduCls_SynEN.SynchToWebDate = null; //同步Web日期
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
public static void CheckProperty4Condition(clsvCurrEduCls_SynEN objvCurrEduCls_SynEN)
{
 vCurrEduCls_SynDA.CheckProperty4Condition(objvCurrEduCls_SynEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdCurrEduCls(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convCurrEduCls_Syn.IdCurrEduCls); 
List<clsvCurrEduCls_SynEN> arrObjLst = clsvCurrEduCls_SynBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvCurrEduCls_SynEN objvCurrEduCls_SynEN = new clsvCurrEduCls_SynEN()
{
IdCurrEduCls = "0",
CourseName = "选[vCurrEduCls_Syn]..."
};
arrObjLst.Insert(0, objvCurrEduCls_SynEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convCurrEduCls_Syn.IdCurrEduCls;
objComboBox.DisplayMember = convCurrEduCls_Syn.CourseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdCurrEduCls(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vCurrEduCls_Syn]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convCurrEduCls_Syn.IdCurrEduCls); 
IEnumerable<clsvCurrEduCls_SynEN> arrObjLst = clsvCurrEduCls_SynBL.GetObjLst(strCondition);
objDDL.DataValueField = convCurrEduCls_Syn.IdCurrEduCls;
objDDL.DataTextField = convCurrEduCls_Syn.CourseName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdCurrEduClsCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vCurrEduCls_Syn]...","0");
List<clsvCurrEduCls_SynEN> arrvCurrEduCls_SynObjLst = GetAllvCurrEduCls_SynObjLstCache(); 
objDDL.DataValueField = convCurrEduCls_Syn.IdCurrEduCls;
objDDL.DataTextField = convCurrEduCls_Syn.CourseName;
objDDL.DataSource = arrvCurrEduCls_SynObjLst;
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
if (clsCurrEduCls_SynBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduCls_SynBL没有刷新缓存机制(clsCurrEduCls_SynBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeBL没有刷新缓存机制(clscc_CourseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorBL没有刷新缓存机制(clsXzMajorBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCurrEduClsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsBL没有刷新缓存机制(clsCurrEduClsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseBL没有刷新缓存机制(clsXzGradeBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_EduClsTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_EduClsTypeBL没有刷新缓存机制(clsgs_EduClsTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsTeachingSolutionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingSolutionBL没有刷新缓存机制(clsTeachingSolutionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeBL没有刷新缓存机制(clscc_CourseIsLikeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by IdCurrEduCls");
//if (arrvCurrEduCls_SynObjLstCache == null)
//{
//arrvCurrEduCls_SynObjLstCache = vCurrEduCls_SynDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdCurrEduCls">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCurrEduCls_SynEN GetObjByIdCurrEduClsCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvCurrEduCls_SynEN._CurrTabName);
List<clsvCurrEduCls_SynEN> arrvCurrEduCls_SynObjLstCache = GetObjLstCache();
IEnumerable <clsvCurrEduCls_SynEN> arrvCurrEduCls_SynObjLst_Sel =
arrvCurrEduCls_SynObjLstCache
.Where(x=> x.IdCurrEduCls == strIdCurrEduCls 
);
if (arrvCurrEduCls_SynObjLst_Sel.Count() == 0)
{
   clsvCurrEduCls_SynEN obj = clsvCurrEduCls_SynBL.GetObjByIdCurrEduCls(strIdCurrEduCls);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvCurrEduCls_SynObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdCurrEduCls">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCourseNameByIdCurrEduClsCache(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true) return "";
//获取缓存中的对象列表
clsvCurrEduCls_SynEN objvCurrEduCls_Syn = GetObjByIdCurrEduClsCache(strIdCurrEduCls);
if (objvCurrEduCls_Syn == null) return "";
return objvCurrEduCls_Syn.CourseName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdCurrEduCls">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdCurrEduClsCache(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true) return "";
//获取缓存中的对象列表
clsvCurrEduCls_SynEN objvCurrEduCls_Syn = GetObjByIdCurrEduClsCache(strIdCurrEduCls);
if (objvCurrEduCls_Syn == null) return "";
return objvCurrEduCls_Syn.CourseName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCurrEduCls_SynEN> GetAllvCurrEduCls_SynObjLstCache()
{
//获取缓存中的对象列表
List<clsvCurrEduCls_SynEN> arrvCurrEduCls_SynObjLstCache = GetObjLstCache(); 
return arrvCurrEduCls_SynObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCurrEduCls_SynEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvCurrEduCls_SynEN._CurrTabName);
List<clsvCurrEduCls_SynEN> arrvCurrEduCls_SynObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCurrEduCls_SynObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvCurrEduCls_SynEN._CurrTabName);
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strIdCurrEduCls)
{
if (strInFldName != convCurrEduCls_Syn.IdCurrEduCls)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCurrEduCls_Syn.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCurrEduCls_Syn.AttributeName));
throw new Exception(strMsg);
}
var objvCurrEduCls_Syn = clsvCurrEduCls_SynBL.GetObjByIdCurrEduClsCache(strIdCurrEduCls);
if (objvCurrEduCls_Syn == null) return "";
return objvCurrEduCls_Syn[strOutFldName].ToString();
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
int intRecCount = clsvCurrEduCls_SynDA.GetRecCount(strTabName);
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
int intRecCount = clsvCurrEduCls_SynDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCurrEduCls_SynDA.GetRecCount();
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
int intRecCount = clsvCurrEduCls_SynDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCurrEduCls_SynEN objvCurrEduCls_SynCond)
{
List<clsvCurrEduCls_SynEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCurrEduCls_SynEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCurrEduCls_Syn.AttributeName)
{
if (objvCurrEduCls_SynCond.IsUpdated(strFldName) == false) continue;
if (objvCurrEduCls_SynCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCurrEduCls_SynCond[strFldName].ToString());
}
else
{
if (objvCurrEduCls_SynCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCurrEduCls_SynCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCurrEduCls_SynCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCurrEduCls_SynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCurrEduCls_SynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCurrEduCls_SynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCurrEduCls_SynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCurrEduCls_SynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCurrEduCls_SynCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCurrEduCls_SynCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCurrEduCls_SynCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCurrEduCls_SynCond[strFldName]));
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
 List<string> arrList = clsvCurrEduCls_SynDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCurrEduCls_SynDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCurrEduCls_SynDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}