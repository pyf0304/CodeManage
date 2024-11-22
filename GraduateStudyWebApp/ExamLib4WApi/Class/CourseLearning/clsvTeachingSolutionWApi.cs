
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachingSolutionWApi
 表名:vTeachingSolution(01120138)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:43:06
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习
 模块英文名:CourseLearning
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
public static class clsvTeachingSolutionWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingSolutionEN SetTeachingSolutionId(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strTeachingSolutionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingSolutionId, 8, convTeachingSolution.TeachingSolutionId);
clsCheckSql.CheckFieldForeignKey(strTeachingSolutionId, 8, convTeachingSolution.TeachingSolutionId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingSolutionEN SetTeachingSolutionName(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strTeachingSolutionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingSolutionName, convTeachingSolution.TeachingSolutionName);
clsCheckSql.CheckFieldLen(strTeachingSolutionName, 100, convTeachingSolution.TeachingSolutionName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingSolutionEN SetCourseId(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convTeachingSolution.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convTeachingSolution.CourseId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingSolutionEN SetCourseCode(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convTeachingSolution.CourseCode);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingSolutionEN SetCourseDescription(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strCourseDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseDescription, 8000, convTeachingSolution.CourseDescription);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingSolutionEN Setid_Teacher(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strid_Teacher, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Teacher, convTeachingSolution.id_Teacher);
clsCheckSql.CheckFieldLen(strid_Teacher, 8, convTeachingSolution.id_Teacher);
clsCheckSql.CheckFieldForeignKey(strid_Teacher, 8, convTeachingSolution.id_Teacher);
objvTeachingSolutionEN.id_Teacher = strid_Teacher; //教师流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingSolutionEN.dicFldComparisonOp.ContainsKey(convTeachingSolution.id_Teacher) == false)
{
objvTeachingSolutionEN.dicFldComparisonOp.Add(convTeachingSolution.id_Teacher, strComparisonOp);
}
else
{
objvTeachingSolutionEN.dicFldComparisonOp[convTeachingSolution.id_Teacher] = strComparisonOp;
}
}
return objvTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingSolutionEN SetTeacherID(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherID, convTeachingSolution.TeacherID);
clsCheckSql.CheckFieldLen(strTeacherID, 12, convTeachingSolution.TeacherID);
objvTeachingSolutionEN.TeacherID = strTeacherID; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingSolutionEN.dicFldComparisonOp.ContainsKey(convTeachingSolution.TeacherID) == false)
{
objvTeachingSolutionEN.dicFldComparisonOp.Add(convTeachingSolution.TeacherID, strComparisonOp);
}
else
{
objvTeachingSolutionEN.dicFldComparisonOp[convTeachingSolution.TeacherID] = strComparisonOp;
}
}
return objvTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingSolutionEN SetTeacherName(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strTeacherName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherName, convTeachingSolution.TeacherName);
clsCheckSql.CheckFieldLen(strTeacherName, 50, convTeachingSolution.TeacherName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingSolutionEN Setid_Sex(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strid_Sex, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Sex, convTeachingSolution.id_Sex);
clsCheckSql.CheckFieldLen(strid_Sex, 4, convTeachingSolution.id_Sex);
clsCheckSql.CheckFieldForeignKey(strid_Sex, 4, convTeachingSolution.id_Sex);
objvTeachingSolutionEN.id_Sex = strid_Sex; //性别流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingSolutionEN.dicFldComparisonOp.ContainsKey(convTeachingSolution.id_Sex) == false)
{
objvTeachingSolutionEN.dicFldComparisonOp.Add(convTeachingSolution.id_Sex, strComparisonOp);
}
else
{
objvTeachingSolutionEN.dicFldComparisonOp[convTeachingSolution.id_Sex] = strComparisonOp;
}
}
return objvTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingSolutionEN SetSexDesc(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strSexDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convTeachingSolution.SexDesc);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingSolutionEN SetCollegeName(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convTeachingSolution.CollegeName);
clsCheckSql.CheckFieldLen(strCollegeName, 100, convTeachingSolution.CollegeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingSolutionEN Setid_ProfGrade(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strid_ProfGrade, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ProfGrade, convTeachingSolution.id_ProfGrade);
clsCheckSql.CheckFieldLen(strid_ProfGrade, 4, convTeachingSolution.id_ProfGrade);
clsCheckSql.CheckFieldForeignKey(strid_ProfGrade, 4, convTeachingSolution.id_ProfGrade);
objvTeachingSolutionEN.id_ProfGrade = strid_ProfGrade; //专业职称流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingSolutionEN.dicFldComparisonOp.ContainsKey(convTeachingSolution.id_ProfGrade) == false)
{
objvTeachingSolutionEN.dicFldComparisonOp.Add(convTeachingSolution.id_ProfGrade, strComparisonOp);
}
else
{
objvTeachingSolutionEN.dicFldComparisonOp[convTeachingSolution.id_ProfGrade] = strComparisonOp;
}
}
return objvTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingSolutionEN SetProfenssionalGradeName(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strProfenssionalGradeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProfenssionalGradeName, convTeachingSolution.ProfenssionalGradeName);
clsCheckSql.CheckFieldLen(strProfenssionalGradeName, 30, convTeachingSolution.ProfenssionalGradeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingSolutionEN SetCollegeID(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeID, convTeachingSolution.CollegeID);
clsCheckSql.CheckFieldLen(strCollegeID, 4, convTeachingSolution.CollegeID);
objvTeachingSolutionEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingSolutionEN.dicFldComparisonOp.ContainsKey(convTeachingSolution.CollegeID) == false)
{
objvTeachingSolutionEN.dicFldComparisonOp.Add(convTeachingSolution.CollegeID, strComparisonOp);
}
else
{
objvTeachingSolutionEN.dicFldComparisonOp[convTeachingSolution.CollegeID] = strComparisonOp;
}
}
return objvTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingSolutionEN Setid_XzCollege(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convTeachingSolution.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convTeachingSolution.id_XzCollege);
objvTeachingSolutionEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingSolutionEN.dicFldComparisonOp.ContainsKey(convTeachingSolution.id_XzCollege) == false)
{
objvTeachingSolutionEN.dicFldComparisonOp.Add(convTeachingSolution.id_XzCollege, strComparisonOp);
}
else
{
objvTeachingSolutionEN.dicFldComparisonOp[convTeachingSolution.id_XzCollege] = strComparisonOp;
}
}
return objvTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingSolutionEN Setid_XzMajor(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzMajor, convTeachingSolution.id_XzMajor);
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convTeachingSolution.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convTeachingSolution.id_XzMajor);
objvTeachingSolutionEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingSolutionEN.dicFldComparisonOp.ContainsKey(convTeachingSolution.id_XzMajor) == false)
{
objvTeachingSolutionEN.dicFldComparisonOp.Add(convTeachingSolution.id_XzMajor, strComparisonOp);
}
else
{
objvTeachingSolutionEN.dicFldComparisonOp[convTeachingSolution.id_XzMajor] = strComparisonOp;
}
}
return objvTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingSolutionEN SetBriefIntroduction(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strBriefIntroduction, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBriefIntroduction, 8000, convTeachingSolution.BriefIntroduction);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingSolutionEN SetUpdDate(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convTeachingSolution.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convTeachingSolution.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingSolutionEN SetUpdUser(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convTeachingSolution.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convTeachingSolution.UpdUser);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingSolutionEN SetMemo(this clsvTeachingSolutionEN objvTeachingSolutionEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTeachingSolution.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTeachingSolutionEN objvTeachingSolution_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTeachingSolution_Cond.IsUpdated(convTeachingSolution.TeachingSolutionId) == true)
{
string strComparisonOp_TeachingSolutionId = objvTeachingSolution_Cond.dicFldComparisonOp[convTeachingSolution.TeachingSolutionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.TeachingSolutionId, objvTeachingSolution_Cond.TeachingSolutionId, strComparisonOp_TeachingSolutionId);
}
if (objvTeachingSolution_Cond.IsUpdated(convTeachingSolution.TeachingSolutionName) == true)
{
string strComparisonOp_TeachingSolutionName = objvTeachingSolution_Cond.dicFldComparisonOp[convTeachingSolution.TeachingSolutionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.TeachingSolutionName, objvTeachingSolution_Cond.TeachingSolutionName, strComparisonOp_TeachingSolutionName);
}
if (objvTeachingSolution_Cond.IsUpdated(convTeachingSolution.CourseId) == true)
{
string strComparisonOp_CourseId = objvTeachingSolution_Cond.dicFldComparisonOp[convTeachingSolution.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.CourseId, objvTeachingSolution_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvTeachingSolution_Cond.IsUpdated(convTeachingSolution.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvTeachingSolution_Cond.dicFldComparisonOp[convTeachingSolution.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.CourseCode, objvTeachingSolution_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvTeachingSolution_Cond.IsUpdated(convTeachingSolution.CourseDescription) == true)
{
string strComparisonOp_CourseDescription = objvTeachingSolution_Cond.dicFldComparisonOp[convTeachingSolution.CourseDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.CourseDescription, objvTeachingSolution_Cond.CourseDescription, strComparisonOp_CourseDescription);
}
if (objvTeachingSolution_Cond.IsUpdated(convTeachingSolution.id_Teacher) == true)
{
string strComparisonOp_id_Teacher = objvTeachingSolution_Cond.dicFldComparisonOp[convTeachingSolution.id_Teacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.id_Teacher, objvTeachingSolution_Cond.id_Teacher, strComparisonOp_id_Teacher);
}
if (objvTeachingSolution_Cond.IsUpdated(convTeachingSolution.TeacherID) == true)
{
string strComparisonOp_TeacherID = objvTeachingSolution_Cond.dicFldComparisonOp[convTeachingSolution.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.TeacherID, objvTeachingSolution_Cond.TeacherID, strComparisonOp_TeacherID);
}
if (objvTeachingSolution_Cond.IsUpdated(convTeachingSolution.TeacherName) == true)
{
string strComparisonOp_TeacherName = objvTeachingSolution_Cond.dicFldComparisonOp[convTeachingSolution.TeacherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.TeacherName, objvTeachingSolution_Cond.TeacherName, strComparisonOp_TeacherName);
}
if (objvTeachingSolution_Cond.IsUpdated(convTeachingSolution.id_Sex) == true)
{
string strComparisonOp_id_Sex = objvTeachingSolution_Cond.dicFldComparisonOp[convTeachingSolution.id_Sex];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.id_Sex, objvTeachingSolution_Cond.id_Sex, strComparisonOp_id_Sex);
}
if (objvTeachingSolution_Cond.IsUpdated(convTeachingSolution.SexDesc) == true)
{
string strComparisonOp_SexDesc = objvTeachingSolution_Cond.dicFldComparisonOp[convTeachingSolution.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.SexDesc, objvTeachingSolution_Cond.SexDesc, strComparisonOp_SexDesc);
}
if (objvTeachingSolution_Cond.IsUpdated(convTeachingSolution.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvTeachingSolution_Cond.dicFldComparisonOp[convTeachingSolution.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.CollegeName, objvTeachingSolution_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvTeachingSolution_Cond.IsUpdated(convTeachingSolution.id_ProfGrade) == true)
{
string strComparisonOp_id_ProfGrade = objvTeachingSolution_Cond.dicFldComparisonOp[convTeachingSolution.id_ProfGrade];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.id_ProfGrade, objvTeachingSolution_Cond.id_ProfGrade, strComparisonOp_id_ProfGrade);
}
if (objvTeachingSolution_Cond.IsUpdated(convTeachingSolution.ProfenssionalGradeName) == true)
{
string strComparisonOp_ProfenssionalGradeName = objvTeachingSolution_Cond.dicFldComparisonOp[convTeachingSolution.ProfenssionalGradeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.ProfenssionalGradeName, objvTeachingSolution_Cond.ProfenssionalGradeName, strComparisonOp_ProfenssionalGradeName);
}
if (objvTeachingSolution_Cond.IsUpdated(convTeachingSolution.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvTeachingSolution_Cond.dicFldComparisonOp[convTeachingSolution.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.CollegeID, objvTeachingSolution_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvTeachingSolution_Cond.IsUpdated(convTeachingSolution.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvTeachingSolution_Cond.dicFldComparisonOp[convTeachingSolution.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.id_XzCollege, objvTeachingSolution_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvTeachingSolution_Cond.IsUpdated(convTeachingSolution.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvTeachingSolution_Cond.dicFldComparisonOp[convTeachingSolution.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.id_XzMajor, objvTeachingSolution_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvTeachingSolution_Cond.IsUpdated(convTeachingSolution.BriefIntroduction) == true)
{
string strComparisonOp_BriefIntroduction = objvTeachingSolution_Cond.dicFldComparisonOp[convTeachingSolution.BriefIntroduction];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.BriefIntroduction, objvTeachingSolution_Cond.BriefIntroduction, strComparisonOp_BriefIntroduction);
}
if (objvTeachingSolution_Cond.IsUpdated(convTeachingSolution.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvTeachingSolution_Cond.dicFldComparisonOp[convTeachingSolution.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.UpdDate, objvTeachingSolution_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvTeachingSolution_Cond.IsUpdated(convTeachingSolution.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvTeachingSolution_Cond.dicFldComparisonOp[convTeachingSolution.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.UpdUser, objvTeachingSolution_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvTeachingSolution_Cond.IsUpdated(convTeachingSolution.Memo) == true)
{
string strComparisonOp_Memo = objvTeachingSolution_Cond.dicFldComparisonOp[convTeachingSolution.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingSolution.Memo, objvTeachingSolution_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v教学方案(vTeachingSolution)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvTeachingSolutionWApi
{
private static readonly string mstrApiControllerName = "vTeachingSolutionApi";

 public clsvTeachingSolutionWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_TeachingSolutionId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v教学方案]...","0");
List<clsvTeachingSolutionEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="TeachingSolutionId";
objDDL.DataTextField="TeachingSolutionName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_TeachingSolutionId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convTeachingSolution.TeachingSolutionId); 
List<clsvTeachingSolutionEN> arrObjLst = clsvTeachingSolutionWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvTeachingSolutionEN objvTeachingSolutionEN = new clsvTeachingSolutionEN()
{
TeachingSolutionId = "0",
TeachingSolutionName = "选[v教学方案]..."
};
arrObjLst.Insert(0, objvTeachingSolutionEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convTeachingSolution.TeachingSolutionId;
objComboBox.DisplayMember = convTeachingSolution.TeachingSolutionName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTeachingSolutionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachingSolutionEN GetObjByTeachingSolutionId(string strTeachingSolutionId)
{
string strAction = "GetObjByTeachingSolutionId";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachingSolutionEN objvTeachingSolutionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["TeachingSolutionId"] = strTeachingSolutionId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvTeachingSolutionEN = JsonConvert.DeserializeObject<clsvTeachingSolutionEN>((string)jobjReturn["ReturnObj"]);
return objvTeachingSolutionEN;
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
 /// <param name = "strTeachingSolutionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachingSolutionEN GetObjByTeachingSolutionId_WA_Cache(string strTeachingSolutionId, string strCourseId)
{
string strAction = "GetObjByTeachingSolutionId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachingSolutionEN objvTeachingSolutionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["TeachingSolutionId"] = strTeachingSolutionId,
["CourseId"] = strCourseId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvTeachingSolutionEN = JsonConvert.DeserializeObject<clsvTeachingSolutionEN>((string)jobjReturn["ReturnObj"]);
return objvTeachingSolutionEN;
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
public static clsvTeachingSolutionEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachingSolutionEN objvTeachingSolutionEN = null;
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
objvTeachingSolutionEN = JsonConvert.DeserializeObject<clsvTeachingSolutionEN>((string)jobjReturn["ReturnObj"]);
return objvTeachingSolutionEN;
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
 /// <param name = "strTeachingSolutionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachingSolutionEN GetObjByTeachingSolutionId_Cache(string strTeachingSolutionId, string strCourseId)
{
if (string.IsNullOrEmpty(strTeachingSolutionId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvTeachingSolutionEN._CurrTabName_S, strCourseId);
List<clsvTeachingSolutionEN> arrvTeachingSolutionObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvTeachingSolutionEN> arrvTeachingSolutionObjLst_Sel =
from objvTeachingSolutionEN in arrvTeachingSolutionObjLst_Cache
where objvTeachingSolutionEN.TeachingSolutionId == strTeachingSolutionId
select objvTeachingSolutionEN;
if (arrvTeachingSolutionObjLst_Sel.Count() == 0)
{
   clsvTeachingSolutionEN obj = clsvTeachingSolutionWApi.GetObjByTeachingSolutionId(strTeachingSolutionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvTeachingSolutionObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strTeachingSolutionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTeachingSolutionNameByTeachingSolutionId_Cache(string strTeachingSolutionId, string strCourseId)
{
if (string.IsNullOrEmpty(strTeachingSolutionId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvTeachingSolutionEN._CurrTabName_S, strCourseId);
List<clsvTeachingSolutionEN> arrvTeachingSolutionObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvTeachingSolutionEN> arrvTeachingSolutionObjLst_Sel1 =
from objvTeachingSolutionEN in arrvTeachingSolutionObjLst_Cache
where objvTeachingSolutionEN.TeachingSolutionId == strTeachingSolutionId
select objvTeachingSolutionEN;
List <clsvTeachingSolutionEN> arrvTeachingSolutionObjLst_Sel = new List<clsvTeachingSolutionEN>();
foreach (clsvTeachingSolutionEN obj in arrvTeachingSolutionObjLst_Sel1)
{
arrvTeachingSolutionObjLst_Sel.Add(obj);
}
if (arrvTeachingSolutionObjLst_Sel.Count > 0)
{
return arrvTeachingSolutionObjLst_Sel[0].TeachingSolutionName;
}
string strErrMsgForGetObjById = string.Format("在vTeachingSolution对象缓存列表中,找不到记录[TeachingSolutionId = {0}](函数:{1})", strTeachingSolutionId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvTeachingSolutionBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strTeachingSolutionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByTeachingSolutionId_Cache(string strTeachingSolutionId, string strCourseId)
{
if (string.IsNullOrEmpty(strTeachingSolutionId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvTeachingSolutionEN._CurrTabName_S, strCourseId);
List<clsvTeachingSolutionEN> arrvTeachingSolutionObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvTeachingSolutionEN> arrvTeachingSolutionObjLst_Sel1 =
from objvTeachingSolutionEN in arrvTeachingSolutionObjLst_Cache
where objvTeachingSolutionEN.TeachingSolutionId == strTeachingSolutionId
select objvTeachingSolutionEN;
List <clsvTeachingSolutionEN> arrvTeachingSolutionObjLst_Sel = new List<clsvTeachingSolutionEN>();
foreach (clsvTeachingSolutionEN obj in arrvTeachingSolutionObjLst_Sel1)
{
arrvTeachingSolutionObjLst_Sel.Add(obj);
}
if (arrvTeachingSolutionObjLst_Sel.Count > 0)
{
return arrvTeachingSolutionObjLst_Sel[0].TeachingSolutionName;
}
string strErrMsgForGetObjById = string.Format("在vTeachingSolution对象缓存列表中,找不到记录的相关名称[TeachingSolutionId = {0}](函数:{1})", strTeachingSolutionId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvTeachingSolutionBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingSolutionEN> GetObjLst(string strWhereCond)
{
 List<clsvTeachingSolutionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingSolutionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingSolutionEN> GetObjLstByTeachingSolutionIdLst(List<string> arrTeachingSolutionId)
{
 List<clsvTeachingSolutionEN> arrObjLst = null; 
string strAction = "GetObjLstByTeachingSolutionIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrTeachingSolutionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingSolutionEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strTeachingSolutionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvTeachingSolutionEN> GetObjLstByTeachingSolutionIdLst_Cache(List<string> arrTeachingSolutionId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvTeachingSolutionEN._CurrTabName_S, strCourseId);
List<clsvTeachingSolutionEN> arrvTeachingSolutionObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvTeachingSolutionEN> arrvTeachingSolutionObjLst_Sel =
from objvTeachingSolutionEN in arrvTeachingSolutionObjLst_Cache
where arrTeachingSolutionId.Contains(objvTeachingSolutionEN.TeachingSolutionId)
select objvTeachingSolutionEN;
return arrvTeachingSolutionObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingSolutionEN> GetObjLstByTeachingSolutionIdLst_WA_Cache(List<string> arrTeachingSolutionId, string strCourseId)
{
 List<clsvTeachingSolutionEN> arrObjLst = null; 
string strAction = "GetObjLstByTeachingSolutionIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrTeachingSolutionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingSolutionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingSolutionEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvTeachingSolutionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingSolutionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingSolutionEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvTeachingSolutionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingSolutionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingSolutionEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvTeachingSolutionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingSolutionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingSolutionEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvTeachingSolutionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingSolutionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strTeachingSolutionId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["TeachingSolutionId"] = strTeachingSolutionId
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
objvTeachingSolutionENT.id_Teacher = objvTeachingSolutionENS.id_Teacher; //教师流水号
objvTeachingSolutionENT.TeacherID = objvTeachingSolutionENS.TeacherID; //教师工号
objvTeachingSolutionENT.TeacherName = objvTeachingSolutionENS.TeacherName; //教师姓名
objvTeachingSolutionENT.id_Sex = objvTeachingSolutionENS.id_Sex; //性别流水号
objvTeachingSolutionENT.SexDesc = objvTeachingSolutionENS.SexDesc; //性别名称
objvTeachingSolutionENT.CollegeName = objvTeachingSolutionENS.CollegeName; //学院名称
objvTeachingSolutionENT.id_ProfGrade = objvTeachingSolutionENS.id_ProfGrade; //专业职称流水号
objvTeachingSolutionENT.ProfenssionalGradeName = objvTeachingSolutionENS.ProfenssionalGradeName; //专业职称
objvTeachingSolutionENT.CollegeID = objvTeachingSolutionENS.CollegeID; //学院ID
objvTeachingSolutionENT.id_XzCollege = objvTeachingSolutionENS.id_XzCollege; //学院流水号
objvTeachingSolutionENT.id_XzMajor = objvTeachingSolutionENS.id_XzMajor; //专业流水号
objvTeachingSolutionENT.BriefIntroduction = objvTeachingSolutionENS.BriefIntroduction; //简介
objvTeachingSolutionENT.UpdDate = objvTeachingSolutionENS.UpdDate; //修改日期
objvTeachingSolutionENT.UpdUser = objvTeachingSolutionENS.UpdUser; //修改人
objvTeachingSolutionENT.Memo = objvTeachingSolutionENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvTeachingSolutionEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvTeachingSolutionEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvTeachingSolutionEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvTeachingSolutionEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvTeachingSolutionEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvTeachingSolutionEN.AttributeName)
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
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingSolutionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingSolutionWApi没有刷新缓存机制(clsTeachingSolutionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeacherInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeacherInfoWApi没有刷新缓存机制(clsTeacherInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzUniZoneWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneWApi没有刷新缓存机制(clsXzUniZoneWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDiscipline_psWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDiscipline_psWApi没有刷新缓存机制(clsDiscipline_psWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStaffTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStaffTypeWApi没有刷新缓存机制(clsRsStaffTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzSchool_PsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchool_PsWApi没有刷新缓存机制(clsXzSchool_PsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexWApi没有刷新缓存机制(clsSexWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsProfGradeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsProfGradeWApi没有刷新缓存机制(clsRsProfGradeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicWApi没有刷新缓存机制(clsRsEthnicWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsDegreeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsDegreeWApi没有刷新缓存机制(clsRsDegreeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsProvinceWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsProvinceWApi没有刷新缓存机制(clsRsProvinceWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsReligionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsReligionWApi没有刷新缓存机制(clsRsReligionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsQualifWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsQualifWApi没有刷新缓存机制(clsRsQualifWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsWApi没有刷新缓存机制(clsRsPoliticsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsAdminGradeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsAdminGradeWApi没有刷新缓存机制(clsRsAdminGradeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TeachingSolutionId");
//if (arrvTeachingSolutionObjLst_Cache == null)
//{
//arrvTeachingSolutionObjLst_Cache = await clsvTeachingSolutionWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsvTeachingSolutionEN._CurrTabName_S, strCourseId);
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
public static List<clsvTeachingSolutionEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvTeachingSolutionEN._CurrTabName_S, strCourseId);
List<clsvTeachingSolutionEN> arrvTeachingSolutionObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrvTeachingSolutionObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvTeachingSolutionEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convTeachingSolution.TeachingSolutionId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingSolution.TeachingSolutionName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingSolution.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingSolution.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingSolution.CourseDescription, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingSolution.id_Teacher, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingSolution.TeacherID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingSolution.TeacherName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingSolution.id_Sex, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingSolution.SexDesc, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingSolution.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingSolution.id_ProfGrade, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingSolution.ProfenssionalGradeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingSolution.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingSolution.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingSolution.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingSolution.BriefIntroduction, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingSolution.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingSolution.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingSolution.Memo, Type.GetType("System.String"));
foreach (clsvTeachingSolutionEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convTeachingSolution.TeachingSolutionId] = objInFor[convTeachingSolution.TeachingSolutionId];
objDR[convTeachingSolution.TeachingSolutionName] = objInFor[convTeachingSolution.TeachingSolutionName];
objDR[convTeachingSolution.CourseId] = objInFor[convTeachingSolution.CourseId];
objDR[convTeachingSolution.CourseCode] = objInFor[convTeachingSolution.CourseCode];
objDR[convTeachingSolution.CourseDescription] = objInFor[convTeachingSolution.CourseDescription];
objDR[convTeachingSolution.id_Teacher] = objInFor[convTeachingSolution.id_Teacher];
objDR[convTeachingSolution.TeacherID] = objInFor[convTeachingSolution.TeacherID];
objDR[convTeachingSolution.TeacherName] = objInFor[convTeachingSolution.TeacherName];
objDR[convTeachingSolution.id_Sex] = objInFor[convTeachingSolution.id_Sex];
objDR[convTeachingSolution.SexDesc] = objInFor[convTeachingSolution.SexDesc];
objDR[convTeachingSolution.CollegeName] = objInFor[convTeachingSolution.CollegeName];
objDR[convTeachingSolution.id_ProfGrade] = objInFor[convTeachingSolution.id_ProfGrade];
objDR[convTeachingSolution.ProfenssionalGradeName] = objInFor[convTeachingSolution.ProfenssionalGradeName];
objDR[convTeachingSolution.CollegeID] = objInFor[convTeachingSolution.CollegeID];
objDR[convTeachingSolution.id_XzCollege] = objInFor[convTeachingSolution.id_XzCollege];
objDR[convTeachingSolution.id_XzMajor] = objInFor[convTeachingSolution.id_XzMajor];
objDR[convTeachingSolution.BriefIntroduction] = objInFor[convTeachingSolution.BriefIntroduction];
objDR[convTeachingSolution.UpdDate] = objInFor[convTeachingSolution.UpdDate];
objDR[convTeachingSolution.UpdUser] = objInFor[convTeachingSolution.UpdUser];
objDR[convTeachingSolution.Memo] = objInFor[convTeachingSolution.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}