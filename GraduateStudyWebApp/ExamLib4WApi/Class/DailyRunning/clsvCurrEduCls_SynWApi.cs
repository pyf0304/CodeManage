
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCurrEduCls_SynWApi
 表名:vCurrEduCls_Syn(01120928)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:42:12
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日常运行
 模块英文名:DailyRunning
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
public static class clsvCurrEduCls_SynWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN Setid_CurrEduCls(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convCurrEduCls_Syn.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convCurrEduCls_Syn.id_CurrEduCls);
objvCurrEduCls_SynEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.id_CurrEduCls) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.id_CurrEduCls, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.id_CurrEduCls] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetEduClsTypeName(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strEduClsTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduClsTypeName, 100, convCurrEduCls_Syn.EduClsTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetCourseCode(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCurrEduCls_Syn.CourseCode);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetCourseDescription(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strCourseDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseDescription, 8000, convCurrEduCls_Syn.CourseDescription);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetCourseName(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCurrEduCls_Syn.CourseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetViewCount(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, int intViewCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetExampleImgPath(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strExampleImgPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExampleImgPath, 300, convCurrEduCls_Syn.ExampleImgPath);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetTeachingSolutionName(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strTeachingSolutionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingSolutionName, convCurrEduCls_Syn.TeachingSolutionName);
clsCheckSql.CheckFieldLen(strTeachingSolutionName, 100, convCurrEduCls_Syn.TeachingSolutionName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN Setid_Teacher(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strid_Teacher, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Teacher, convCurrEduCls_Syn.id_Teacher);
clsCheckSql.CheckFieldLen(strid_Teacher, 8, convCurrEduCls_Syn.id_Teacher);
clsCheckSql.CheckFieldForeignKey(strid_Teacher, 8, convCurrEduCls_Syn.id_Teacher);
objvCurrEduCls_SynEN.id_Teacher = strid_Teacher; //教师流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.id_Teacher) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.id_Teacher, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.id_Teacher] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetTeacherID(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherID, convCurrEduCls_Syn.TeacherID);
clsCheckSql.CheckFieldLen(strTeacherID, 12, convCurrEduCls_Syn.TeacherID);
objvCurrEduCls_SynEN.TeacherID = strTeacherID; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.TeacherID) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.TeacherID, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.TeacherID] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetTeacherName(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strTeacherName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherName, convCurrEduCls_Syn.TeacherName);
clsCheckSql.CheckFieldLen(strTeacherName, 50, convCurrEduCls_Syn.TeacherName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetCollegeID(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeID, convCurrEduCls_Syn.CollegeID);
clsCheckSql.CheckFieldLen(strCollegeID, 4, convCurrEduCls_Syn.CollegeID);
objvCurrEduCls_SynEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.CollegeID) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.CollegeID, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.CollegeID] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetCollegeName(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convCurrEduCls_Syn.CollegeName);
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCurrEduCls_Syn.CollegeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN Setid_XzMajor(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzMajor, convCurrEduCls_Syn.id_XzMajor);
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convCurrEduCls_Syn.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convCurrEduCls_Syn.id_XzMajor);
objvCurrEduCls_SynEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.id_XzMajor) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.id_XzMajor, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.id_XzMajor] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetMajorName(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorName, convCurrEduCls_Syn.MajorName);
clsCheckSql.CheckFieldLen(strMajorName, 100, convCurrEduCls_Syn.MajorName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetGradeBaseID(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strGradeBaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseID, 4, convCurrEduCls_Syn.GradeBaseID);
clsCheckSql.CheckFieldForeignKey(strGradeBaseID, 4, convCurrEduCls_Syn.GradeBaseID);
objvCurrEduCls_SynEN.GradeBaseID = strGradeBaseID; //年级代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.GradeBaseID) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.GradeBaseID, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.GradeBaseID] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetGradeBaseName(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGradeBaseName, convCurrEduCls_Syn.GradeBaseName);
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convCurrEduCls_Syn.GradeBaseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetGradeBaseNameA(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strGradeBaseNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGradeBaseNameA, convCurrEduCls_Syn.GradeBaseNameA);
clsCheckSql.CheckFieldLen(strGradeBaseNameA, 10, convCurrEduCls_Syn.GradeBaseNameA);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetCourseTypeID(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strCourseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseTypeID, convCurrEduCls_Syn.CourseTypeID);
clsCheckSql.CheckFieldLen(strCourseTypeID, 4, convCurrEduCls_Syn.CourseTypeID);
clsCheckSql.CheckFieldForeignKey(strCourseTypeID, 4, convCurrEduCls_Syn.CourseTypeID);
objvCurrEduCls_SynEN.CourseTypeID = strCourseTypeID; //课程类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.CourseTypeID) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.CourseTypeID, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.CourseTypeID] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetCourseTypeName(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strCourseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseTypeName, convCurrEduCls_Syn.CourseTypeName);
clsCheckSql.CheckFieldLen(strCourseTypeName, 30, convCurrEduCls_Syn.CourseTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetCurrStuNum_Valid(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, int intCurrStuNum_Valid, string strComparisonOp="")
	{
objvCurrEduCls_SynEN.CurrStuNum_Valid = intCurrStuNum_Valid; //CurrStuNum_Valid
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.CurrStuNum_Valid) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.CurrStuNum_Valid, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.CurrStuNum_Valid] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetCurrStuNum(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, int intCurrStuNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetCurrEduClsId(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strCurrEduClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, convCurrEduCls_Syn.CurrEduClsId);
objvCurrEduCls_SynEN.CurrEduClsId = strCurrEduClsId; //当前教学班Id
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetEduClsName(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduClsName, convCurrEduCls_Syn.EduClsName);
clsCheckSql.CheckFieldLen(strEduClsName, 100, convCurrEduCls_Syn.EduClsName);
objvCurrEduCls_SynEN.EduClsName = strEduClsName; //教学班名称
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetEduClsTypeId(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strEduClsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduClsTypeId, convCurrEduCls_Syn.EduClsTypeId);
clsCheckSql.CheckFieldLen(strEduClsTypeId, 4, convCurrEduCls_Syn.EduClsTypeId);
clsCheckSql.CheckFieldForeignKey(strEduClsTypeId, 4, convCurrEduCls_Syn.EduClsTypeId);
objvCurrEduCls_SynEN.EduClsTypeId = strEduClsTypeId; //教学班类型代号
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetCourseId(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCurrEduCls_Syn.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCurrEduCls_Syn.CourseId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetTeachingSolutionId(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strTeachingSolutionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingSolutionId, convCurrEduCls_Syn.TeachingSolutionId);
clsCheckSql.CheckFieldLen(strTeachingSolutionId, 8, convCurrEduCls_Syn.TeachingSolutionId);
clsCheckSql.CheckFieldForeignKey(strTeachingSolutionId, 8, convCurrEduCls_Syn.TeachingSolutionId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN Setid_XzCollege(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convCurrEduCls_Syn.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convCurrEduCls_Syn.id_XzCollege);
objvCurrEduCls_SynEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.id_XzCollege) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.id_XzCollege, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.id_XzCollege] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN Setid_EduWay(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strid_EduWay, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_EduWay, convCurrEduCls_Syn.id_EduWay);
clsCheckSql.CheckFieldLen(strid_EduWay, 4, convCurrEduCls_Syn.id_EduWay);
clsCheckSql.CheckFieldForeignKey(strid_EduWay, 4, convCurrEduCls_Syn.id_EduWay);
objvCurrEduCls_SynEN.id_EduWay = strid_EduWay; //教学方式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.id_EduWay) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.id_EduWay, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.id_EduWay] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN Setid_ClassRoomType(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strid_ClassRoomType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ClassRoomType, convCurrEduCls_Syn.id_ClassRoomType);
clsCheckSql.CheckFieldLen(strid_ClassRoomType, 4, convCurrEduCls_Syn.id_ClassRoomType);
clsCheckSql.CheckFieldForeignKey(strid_ClassRoomType, 4, convCurrEduCls_Syn.id_ClassRoomType);
objvCurrEduCls_SynEN.id_ClassRoomType = strid_ClassRoomType; //教室类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.id_ClassRoomType) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.id_ClassRoomType, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.id_ClassRoomType] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetMaxStuQty(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, int intMaxStuQty, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetWeekQty(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, int intWeekQty, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetScheUnitPW(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, short shtScheUnitPW, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetWeekStatusID(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strWeekStatusID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWeekStatusID, 2, convCurrEduCls_Syn.WeekStatusID);
clsCheckSql.CheckFieldForeignKey(strWeekStatusID, 2, convCurrEduCls_Syn.WeekStatusID);
objvCurrEduCls_SynEN.WeekStatusID = strWeekStatusID; //周状态编号(单,双,全周)
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.WeekStatusID) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.WeekStatusID, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.WeekStatusID] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetCustomerWeek(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strCustomerWeek, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCustomerWeek, 50, convCurrEduCls_Syn.CustomerWeek);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN Setid_ExecPlan(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strid_ExecPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ExecPlan, convCurrEduCls_Syn.id_ExecPlan);
clsCheckSql.CheckFieldLen(strid_ExecPlan, 8, convCurrEduCls_Syn.id_ExecPlan);
clsCheckSql.CheckFieldForeignKey(strid_ExecPlan, 8, convCurrEduCls_Syn.id_ExecPlan);
objvCurrEduCls_SynEN.id_ExecPlan = strid_ExecPlan; //执行计划流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.id_ExecPlan) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.id_ExecPlan, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.id_ExecPlan] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetMark(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, double dblMark, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetCheckClassRoom(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strCheckClassRoom, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckClassRoom, 2000, convCurrEduCls_Syn.CheckClassRoom);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetCheckAdminCls(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strCheckAdminCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckAdminCls, 2000, convCurrEduCls_Syn.CheckAdminCls);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetCheckTeacher(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strCheckTeacher, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckTeacher, 2000, convCurrEduCls_Syn.CheckTeacher);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN Setid_UniZone(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strid_UniZone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_UniZone, convCurrEduCls_Syn.id_UniZone);
clsCheckSql.CheckFieldLen(strid_UniZone, 4, convCurrEduCls_Syn.id_UniZone);
clsCheckSql.CheckFieldForeignKey(strid_UniZone, 4, convCurrEduCls_Syn.id_UniZone);
objvCurrEduCls_SynEN.id_UniZone = strid_UniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.id_UniZone) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.id_UniZone, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.id_UniZone] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN Setid_GradeBase(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convCurrEduCls_Syn.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convCurrEduCls_Syn.id_GradeBase);
objvCurrEduCls_SynEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.id_GradeBase) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.id_GradeBase, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.id_GradeBase] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetSchoolYear(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strSchoolYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, convCurrEduCls_Syn.SchoolYear);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetSchoolTerm(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, convCurrEduCls_Syn.SchoolTerm);
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, convCurrEduCls_Syn.SchoolTerm);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetArrangeCourseMemo(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strArrangeCourseMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strArrangeCourseMemo, 50, convCurrEduCls_Syn.ArrangeCourseMemo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN Setid_CourseType(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strid_CourseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CourseType, convCurrEduCls_Syn.id_CourseType);
clsCheckSql.CheckFieldLen(strid_CourseType, 4, convCurrEduCls_Syn.id_CourseType);
clsCheckSql.CheckFieldForeignKey(strid_CourseType, 4, convCurrEduCls_Syn.id_CourseType);
objvCurrEduCls_SynEN.id_CourseType = strid_CourseType; //课程类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.id_CourseType) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.id_CourseType, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.id_CourseType] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN Setid_ScoreType(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strid_ScoreType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ScoreType, convCurrEduCls_Syn.id_ScoreType);
clsCheckSql.CheckFieldLen(strid_ScoreType, 4, convCurrEduCls_Syn.id_ScoreType);
clsCheckSql.CheckFieldForeignKey(strid_ScoreType, 4, convCurrEduCls_Syn.id_ScoreType);
objvCurrEduCls_SynEN.id_ScoreType = strid_ScoreType; //成绩类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.id_ScoreType) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.id_ScoreType, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.id_ScoreType] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetGetScoreWayId(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strGetScoreWayId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGetScoreWayId, 2, convCurrEduCls_Syn.GetScoreWayId);
clsCheckSql.CheckFieldForeignKey(strGetScoreWayId, 2, convCurrEduCls_Syn.GetScoreWayId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN Setid_ExamType(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strid_ExamType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ExamType, convCurrEduCls_Syn.id_ExamType);
clsCheckSql.CheckFieldLen(strid_ExamType, 4, convCurrEduCls_Syn.id_ExamType);
clsCheckSql.CheckFieldForeignKey(strid_ExamType, 4, convCurrEduCls_Syn.id_ExamType);
objvCurrEduCls_SynEN.id_ExamType = strid_ExamType; //考试方式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.id_ExamType) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.id_ExamType, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.id_ExamType] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetMidExamScorePortion(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, short shtMidExamScorePortion, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetGeneratePwdDate(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strGeneratePwdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGeneratePwdDate, 20, convCurrEduCls_Syn.GeneratePwdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetPkWeekTime(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strPkWeekTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPkWeekTime, 2000, convCurrEduCls_Syn.PkWeekTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetPkClassRooms(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strPkClassRooms, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPkClassRooms, 150, convCurrEduCls_Syn.PkClassRooms);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetBeginWeek(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, short shtBeginWeek, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetTeacherNames(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strTeacherNames, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeacherNames, 100, convCurrEduCls_Syn.TeacherNames);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetSynchDate(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strSynchDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSynchDate, convCurrEduCls_Syn.SynchDate);
clsCheckSql.CheckFieldLen(strSynchDate, 30, convCurrEduCls_Syn.SynchDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetModifyDate(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strModifyDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyDate, 20, convCurrEduCls_Syn.ModifyDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetModifyUserID(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strModifyUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyUserID, 18, convCurrEduCls_Syn.ModifyUserID);
objvCurrEduCls_SynEN.ModifyUserID = strModifyUserID; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Syn.ModifyUserID) == false)
{
objvCurrEduCls_SynEN.dicFldComparisonOp.Add(convCurrEduCls_Syn.ModifyUserID, strComparisonOp);
}
else
{
objvCurrEduCls_SynEN.dicFldComparisonOp[convCurrEduCls_Syn.ModifyUserID] = strComparisonOp;
}
}
return objvCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetMemo(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCurrEduCls_Syn.Memo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetSignInDate(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strSignInDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSignInDate, 20, convCurrEduCls_Syn.SignInDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetSignInStateID(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strSignInStateID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSignInStateID, 2, convCurrEduCls_Syn.SignInStateID);
clsCheckSql.CheckFieldForeignKey(strSignInStateID, 2, convCurrEduCls_Syn.SignInStateID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetSignInUser(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strSignInUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSignInUser, 18, convCurrEduCls_Syn.SignInUser);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetSynchToWebUser(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strSynchToWebUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchToWebUser, 18, convCurrEduCls_Syn.SynchToWebUser);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls_SynEN SetSynchToWebDate(this clsvCurrEduCls_SynEN objvCurrEduCls_SynEN, string strSynchToWebDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchToWebDate, 20, convCurrEduCls_Syn.SynchToWebDate);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCurrEduCls_SynEN objvCurrEduCls_Syn_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.id_CurrEduCls, objvCurrEduCls_Syn_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.EduClsTypeName) == true)
{
string strComparisonOp_EduClsTypeName = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.EduClsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.EduClsTypeName, objvCurrEduCls_Syn_Cond.EduClsTypeName, strComparisonOp_EduClsTypeName);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.CourseCode, objvCurrEduCls_Syn_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.CourseDescription) == true)
{
string strComparisonOp_CourseDescription = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.CourseDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.CourseDescription, objvCurrEduCls_Syn_Cond.CourseDescription, strComparisonOp_CourseDescription);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.CourseName) == true)
{
string strComparisonOp_CourseName = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.CourseName, objvCurrEduCls_Syn_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls_Syn.ViewCount, objvCurrEduCls_Syn_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.ExampleImgPath) == true)
{
string strComparisonOp_ExampleImgPath = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.ExampleImgPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.ExampleImgPath, objvCurrEduCls_Syn_Cond.ExampleImgPath, strComparisonOp_ExampleImgPath);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.TeachingSolutionName) == true)
{
string strComparisonOp_TeachingSolutionName = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.TeachingSolutionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.TeachingSolutionName, objvCurrEduCls_Syn_Cond.TeachingSolutionName, strComparisonOp_TeachingSolutionName);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.id_Teacher) == true)
{
string strComparisonOp_id_Teacher = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.id_Teacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.id_Teacher, objvCurrEduCls_Syn_Cond.id_Teacher, strComparisonOp_id_Teacher);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.TeacherID) == true)
{
string strComparisonOp_TeacherID = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.TeacherID, objvCurrEduCls_Syn_Cond.TeacherID, strComparisonOp_TeacherID);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.TeacherName) == true)
{
string strComparisonOp_TeacherName = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.TeacherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.TeacherName, objvCurrEduCls_Syn_Cond.TeacherName, strComparisonOp_TeacherName);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.CollegeID, objvCurrEduCls_Syn_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.CollegeName, objvCurrEduCls_Syn_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.id_XzMajor, objvCurrEduCls_Syn_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.MajorName) == true)
{
string strComparisonOp_MajorName = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.MajorName, objvCurrEduCls_Syn_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.GradeBaseID) == true)
{
string strComparisonOp_GradeBaseID = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.GradeBaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.GradeBaseID, objvCurrEduCls_Syn_Cond.GradeBaseID, strComparisonOp_GradeBaseID);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.GradeBaseName, objvCurrEduCls_Syn_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.GradeBaseNameA) == true)
{
string strComparisonOp_GradeBaseNameA = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.GradeBaseNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.GradeBaseNameA, objvCurrEduCls_Syn_Cond.GradeBaseNameA, strComparisonOp_GradeBaseNameA);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.CourseTypeID) == true)
{
string strComparisonOp_CourseTypeID = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.CourseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.CourseTypeID, objvCurrEduCls_Syn_Cond.CourseTypeID, strComparisonOp_CourseTypeID);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.CourseTypeName) == true)
{
string strComparisonOp_CourseTypeName = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.CourseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.CourseTypeName, objvCurrEduCls_Syn_Cond.CourseTypeName, strComparisonOp_CourseTypeName);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.CurrStuNum_Valid) == true)
{
string strComparisonOp_CurrStuNum_Valid = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.CurrStuNum_Valid];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls_Syn.CurrStuNum_Valid, objvCurrEduCls_Syn_Cond.CurrStuNum_Valid, strComparisonOp_CurrStuNum_Valid);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.CurrStuNum) == true)
{
string strComparisonOp_CurrStuNum = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.CurrStuNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls_Syn.CurrStuNum, objvCurrEduCls_Syn_Cond.CurrStuNum, strComparisonOp_CurrStuNum);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.CurrEduClsId) == true)
{
string strComparisonOp_CurrEduClsId = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.CurrEduClsId, objvCurrEduCls_Syn_Cond.CurrEduClsId, strComparisonOp_CurrEduClsId);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.EduClsName) == true)
{
string strComparisonOp_EduClsName = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.EduClsName, objvCurrEduCls_Syn_Cond.EduClsName, strComparisonOp_EduClsName);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.EduClsTypeId) == true)
{
string strComparisonOp_EduClsTypeId = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.EduClsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.EduClsTypeId, objvCurrEduCls_Syn_Cond.EduClsTypeId, strComparisonOp_EduClsTypeId);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.CourseId) == true)
{
string strComparisonOp_CourseId = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.CourseId, objvCurrEduCls_Syn_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.TeachingSolutionId) == true)
{
string strComparisonOp_TeachingSolutionId = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.TeachingSolutionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.TeachingSolutionId, objvCurrEduCls_Syn_Cond.TeachingSolutionId, strComparisonOp_TeachingSolutionId);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.id_XzCollege, objvCurrEduCls_Syn_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.id_EduWay) == true)
{
string strComparisonOp_id_EduWay = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.id_EduWay];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.id_EduWay, objvCurrEduCls_Syn_Cond.id_EduWay, strComparisonOp_id_EduWay);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.id_ClassRoomType) == true)
{
string strComparisonOp_id_ClassRoomType = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.id_ClassRoomType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.id_ClassRoomType, objvCurrEduCls_Syn_Cond.id_ClassRoomType, strComparisonOp_id_ClassRoomType);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.TotalLessonQty) == true)
{
string strComparisonOp_TotalLessonQty = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.TotalLessonQty];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls_Syn.TotalLessonQty, objvCurrEduCls_Syn_Cond.TotalLessonQty, strComparisonOp_TotalLessonQty);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.MaxStuQty) == true)
{
string strComparisonOp_MaxStuQty = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.MaxStuQty];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls_Syn.MaxStuQty, objvCurrEduCls_Syn_Cond.MaxStuQty, strComparisonOp_MaxStuQty);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.WeekQty) == true)
{
string strComparisonOp_WeekQty = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.WeekQty];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls_Syn.WeekQty, objvCurrEduCls_Syn_Cond.WeekQty, strComparisonOp_WeekQty);
}
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.WeekStatusID) == true)
{
string strComparisonOp_WeekStatusID = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.WeekStatusID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.WeekStatusID, objvCurrEduCls_Syn_Cond.WeekStatusID, strComparisonOp_WeekStatusID);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.CustomerWeek) == true)
{
string strComparisonOp_CustomerWeek = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.CustomerWeek];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.CustomerWeek, objvCurrEduCls_Syn_Cond.CustomerWeek, strComparisonOp_CustomerWeek);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.IsCompleteScore) == true)
{
if (objvCurrEduCls_Syn_Cond.IsCompleteScore == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls_Syn.IsCompleteScore);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls_Syn.IsCompleteScore);
}
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.id_ExecPlan) == true)
{
string strComparisonOp_id_ExecPlan = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.id_ExecPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.id_ExecPlan, objvCurrEduCls_Syn_Cond.id_ExecPlan, strComparisonOp_id_ExecPlan);
}
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.Mark) == true)
{
string strComparisonOp_Mark = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.Mark];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls_Syn.Mark, objvCurrEduCls_Syn_Cond.Mark, strComparisonOp_Mark);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.CheckClassRoom) == true)
{
string strComparisonOp_CheckClassRoom = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.CheckClassRoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.CheckClassRoom, objvCurrEduCls_Syn_Cond.CheckClassRoom, strComparisonOp_CheckClassRoom);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.CheckAdminCls) == true)
{
string strComparisonOp_CheckAdminCls = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.CheckAdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.CheckAdminCls, objvCurrEduCls_Syn_Cond.CheckAdminCls, strComparisonOp_CheckAdminCls);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.CheckTeacher) == true)
{
string strComparisonOp_CheckTeacher = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.CheckTeacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.CheckTeacher, objvCurrEduCls_Syn_Cond.CheckTeacher, strComparisonOp_CheckTeacher);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.EditLocked) == true)
{
if (objvCurrEduCls_Syn_Cond.EditLocked == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls_Syn.EditLocked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls_Syn.EditLocked);
}
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.Sched) == true)
{
if (objvCurrEduCls_Syn_Cond.Sched == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls_Syn.Sched);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls_Syn.Sched);
}
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.id_UniZone) == true)
{
string strComparisonOp_id_UniZone = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.id_UniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.id_UniZone, objvCurrEduCls_Syn_Cond.id_UniZone, strComparisonOp_id_UniZone);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.Locked) == true)
{
if (objvCurrEduCls_Syn_Cond.Locked == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls_Syn.Locked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls_Syn.Locked);
}
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.id_GradeBase, objvCurrEduCls_Syn_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.IsEffective) == true)
{
if (objvCurrEduCls_Syn_Cond.IsEffective == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls_Syn.IsEffective);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls_Syn.IsEffective);
}
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.IsForPaperReading) == true)
{
if (objvCurrEduCls_Syn_Cond.IsForPaperReading == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls_Syn.IsForPaperReading);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls_Syn.IsForPaperReading);
}
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.IsUnDeterminedClsRm) == true)
{
if (objvCurrEduCls_Syn_Cond.IsUnDeterminedClsRm == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls_Syn.IsUnDeterminedClsRm);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls_Syn.IsUnDeterminedClsRm);
}
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.SchoolYear) == true)
{
string strComparisonOp_SchoolYear = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.SchoolYear, objvCurrEduCls_Syn_Cond.SchoolYear, strComparisonOp_SchoolYear);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.SchoolTerm) == true)
{
string strComparisonOp_SchoolTerm = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.SchoolTerm, objvCurrEduCls_Syn_Cond.SchoolTerm, strComparisonOp_SchoolTerm);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.ArrangeCourseMemo) == true)
{
string strComparisonOp_ArrangeCourseMemo = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.ArrangeCourseMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.ArrangeCourseMemo, objvCurrEduCls_Syn_Cond.ArrangeCourseMemo, strComparisonOp_ArrangeCourseMemo);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.id_CourseType) == true)
{
string strComparisonOp_id_CourseType = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.id_CourseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.id_CourseType, objvCurrEduCls_Syn_Cond.id_CourseType, strComparisonOp_id_CourseType);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.IsDegree) == true)
{
if (objvCurrEduCls_Syn_Cond.IsDegree == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls_Syn.IsDegree);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls_Syn.IsDegree);
}
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.id_ScoreType) == true)
{
string strComparisonOp_id_ScoreType = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.id_ScoreType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.id_ScoreType, objvCurrEduCls_Syn_Cond.id_ScoreType, strComparisonOp_id_ScoreType);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.GetScoreWayId) == true)
{
string strComparisonOp_GetScoreWayId = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.GetScoreWayId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.GetScoreWayId, objvCurrEduCls_Syn_Cond.GetScoreWayId, strComparisonOp_GetScoreWayId);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.IsProportionalCtrl) == true)
{
if (objvCurrEduCls_Syn_Cond.IsProportionalCtrl == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls_Syn.IsProportionalCtrl);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls_Syn.IsProportionalCtrl);
}
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.id_ExamType) == true)
{
string strComparisonOp_id_ExamType = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.id_ExamType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.id_ExamType, objvCurrEduCls_Syn_Cond.id_ExamType, strComparisonOp_id_ExamType);
}
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.IsClearScore) == true)
{
if (objvCurrEduCls_Syn_Cond.IsClearScore == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls_Syn.IsClearScore);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls_Syn.IsClearScore);
}
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.IsGeneratePwd) == true)
{
if (objvCurrEduCls_Syn_Cond.IsGeneratePwd == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls_Syn.IsGeneratePwd);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls_Syn.IsGeneratePwd);
}
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.GeneratePwdDate) == true)
{
string strComparisonOp_GeneratePwdDate = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.GeneratePwdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.GeneratePwdDate, objvCurrEduCls_Syn_Cond.GeneratePwdDate, strComparisonOp_GeneratePwdDate);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.PkWeekTime) == true)
{
string strComparisonOp_PkWeekTime = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.PkWeekTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.PkWeekTime, objvCurrEduCls_Syn_Cond.PkWeekTime, strComparisonOp_PkWeekTime);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.PkClassRooms) == true)
{
string strComparisonOp_PkClassRooms = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.PkClassRooms];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.PkClassRooms, objvCurrEduCls_Syn_Cond.PkClassRooms, strComparisonOp_PkClassRooms);
}
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.TeacherNames) == true)
{
string strComparisonOp_TeacherNames = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.TeacherNames];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.TeacherNames, objvCurrEduCls_Syn_Cond.TeacherNames, strComparisonOp_TeacherNames);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.IsSynch) == true)
{
if (objvCurrEduCls_Syn_Cond.IsSynch == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls_Syn.IsSynch);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls_Syn.IsSynch);
}
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.SynchDate) == true)
{
string strComparisonOp_SynchDate = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.SynchDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.SynchDate, objvCurrEduCls_Syn_Cond.SynchDate, strComparisonOp_SynchDate);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.ModifyDate) == true)
{
string strComparisonOp_ModifyDate = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.ModifyDate, objvCurrEduCls_Syn_Cond.ModifyDate, strComparisonOp_ModifyDate);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.ModifyUserID) == true)
{
string strComparisonOp_ModifyUserID = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.ModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.ModifyUserID, objvCurrEduCls_Syn_Cond.ModifyUserID, strComparisonOp_ModifyUserID);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.Memo) == true)
{
string strComparisonOp_Memo = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.Memo, objvCurrEduCls_Syn_Cond.Memo, strComparisonOp_Memo);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.SignInDate) == true)
{
string strComparisonOp_SignInDate = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.SignInDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.SignInDate, objvCurrEduCls_Syn_Cond.SignInDate, strComparisonOp_SignInDate);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.SignInStateID) == true)
{
string strComparisonOp_SignInStateID = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.SignInStateID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.SignInStateID, objvCurrEduCls_Syn_Cond.SignInStateID, strComparisonOp_SignInStateID);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.SignInUser) == true)
{
string strComparisonOp_SignInUser = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.SignInUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.SignInUser, objvCurrEduCls_Syn_Cond.SignInUser, strComparisonOp_SignInUser);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.SynchToWebUser) == true)
{
string strComparisonOp_SynchToWebUser = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.SynchToWebUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.SynchToWebUser, objvCurrEduCls_Syn_Cond.SynchToWebUser, strComparisonOp_SynchToWebUser);
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.IsSynchToWeb) == true)
{
if (objvCurrEduCls_Syn_Cond.IsSynchToWeb == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls_Syn.IsSynchToWeb);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls_Syn.IsSynchToWeb);
}
}
if (objvCurrEduCls_Syn_Cond.IsUpdated(convCurrEduCls_Syn.SynchToWebDate) == true)
{
string strComparisonOp_SynchToWebDate = objvCurrEduCls_Syn_Cond.dicFldComparisonOp[convCurrEduCls_Syn.SynchToWebDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Syn.SynchToWebDate, objvCurrEduCls_Syn_Cond.SynchToWebDate, strComparisonOp_SynchToWebDate);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vCurrEduCls_Syn(vCurrEduCls_Syn)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCurrEduCls_SynWApi
{
private static readonly string mstrApiControllerName = "vCurrEduCls_SynApi";

 public clsvCurrEduCls_SynWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_CurrEduCls(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vCurrEduCls_Syn]...","0");
List<clsvCurrEduCls_SynEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_CurrEduCls";
objDDL.DataTextField="CourseName";
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
public static void BindCbo_id_CurrEduCls(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convCurrEduCls_Syn.id_CurrEduCls); 
List<clsvCurrEduCls_SynEN> arrObjLst = clsvCurrEduCls_SynWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvCurrEduCls_SynEN objvCurrEduCls_SynEN = new clsvCurrEduCls_SynEN()
{
id_CurrEduCls = "0",
CourseName = "选[vCurrEduCls_Syn]..."
};
arrObjLst.Insert(0, objvCurrEduCls_SynEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convCurrEduCls_Syn.id_CurrEduCls;
objComboBox.DisplayMember = convCurrEduCls_Syn.CourseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_CurrEduCls">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCurrEduCls_SynEN GetObjByid_CurrEduCls(string strid_CurrEduCls)
{
string strAction = "GetObjByid_CurrEduCls";
string strErrMsg = string.Empty;
string strResult = "";
clsvCurrEduCls_SynEN objvCurrEduCls_SynEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CurrEduCls"] = strid_CurrEduCls
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCurrEduCls_SynEN = JsonConvert.DeserializeObject<clsvCurrEduCls_SynEN>((string)jobjReturn["ReturnObj"]);
return objvCurrEduCls_SynEN;
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
 /// <param name = "strid_CurrEduCls">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCurrEduCls_SynEN GetObjByid_CurrEduCls_WA_Cache(string strid_CurrEduCls)
{
string strAction = "GetObjByid_CurrEduCls_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCurrEduCls_SynEN objvCurrEduCls_SynEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CurrEduCls"] = strid_CurrEduCls
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCurrEduCls_SynEN = JsonConvert.DeserializeObject<clsvCurrEduCls_SynEN>((string)jobjReturn["ReturnObj"]);
return objvCurrEduCls_SynEN;
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
public static clsvCurrEduCls_SynEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCurrEduCls_SynEN objvCurrEduCls_SynEN = null;
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
objvCurrEduCls_SynEN = JsonConvert.DeserializeObject<clsvCurrEduCls_SynEN>((string)jobjReturn["ReturnObj"]);
return objvCurrEduCls_SynEN;
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
 /// <param name = "strid_CurrEduCls">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCurrEduCls_SynEN GetObjByid_CurrEduCls_Cache(string strid_CurrEduCls)
{
if (string.IsNullOrEmpty(strid_CurrEduCls) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvCurrEduCls_SynEN._CurrTabName_S);
List<clsvCurrEduCls_SynEN> arrvCurrEduCls_SynObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCurrEduCls_SynEN> arrvCurrEduCls_SynObjLst_Sel =
from objvCurrEduCls_SynEN in arrvCurrEduCls_SynObjLst_Cache
where objvCurrEduCls_SynEN.id_CurrEduCls == strid_CurrEduCls
select objvCurrEduCls_SynEN;
if (arrvCurrEduCls_SynObjLst_Sel.Count() == 0)
{
   clsvCurrEduCls_SynEN obj = clsvCurrEduCls_SynWApi.GetObjByid_CurrEduCls(strid_CurrEduCls);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCurrEduCls_SynObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_CurrEduCls">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCourseNameByid_CurrEduCls_Cache(string strid_CurrEduCls)
{
if (string.IsNullOrEmpty(strid_CurrEduCls) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvCurrEduCls_SynEN._CurrTabName_S);
List<clsvCurrEduCls_SynEN> arrvCurrEduCls_SynObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCurrEduCls_SynEN> arrvCurrEduCls_SynObjLst_Sel1 =
from objvCurrEduCls_SynEN in arrvCurrEduCls_SynObjLst_Cache
where objvCurrEduCls_SynEN.id_CurrEduCls == strid_CurrEduCls
select objvCurrEduCls_SynEN;
List <clsvCurrEduCls_SynEN> arrvCurrEduCls_SynObjLst_Sel = new List<clsvCurrEduCls_SynEN>();
foreach (clsvCurrEduCls_SynEN obj in arrvCurrEduCls_SynObjLst_Sel1)
{
arrvCurrEduCls_SynObjLst_Sel.Add(obj);
}
if (arrvCurrEduCls_SynObjLst_Sel.Count > 0)
{
return arrvCurrEduCls_SynObjLst_Sel[0].CourseName;
}
string strErrMsgForGetObjById = string.Format("在vCurrEduCls_Syn对象缓存列表中,找不到记录[id_CurrEduCls = {0}](函数:{1})", strid_CurrEduCls, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvCurrEduCls_SynBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_CurrEduCls">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_CurrEduCls_Cache(string strid_CurrEduCls)
{
if (string.IsNullOrEmpty(strid_CurrEduCls) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvCurrEduCls_SynEN._CurrTabName_S);
List<clsvCurrEduCls_SynEN> arrvCurrEduCls_SynObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCurrEduCls_SynEN> arrvCurrEduCls_SynObjLst_Sel1 =
from objvCurrEduCls_SynEN in arrvCurrEduCls_SynObjLst_Cache
where objvCurrEduCls_SynEN.id_CurrEduCls == strid_CurrEduCls
select objvCurrEduCls_SynEN;
List <clsvCurrEduCls_SynEN> arrvCurrEduCls_SynObjLst_Sel = new List<clsvCurrEduCls_SynEN>();
foreach (clsvCurrEduCls_SynEN obj in arrvCurrEduCls_SynObjLst_Sel1)
{
arrvCurrEduCls_SynObjLst_Sel.Add(obj);
}
if (arrvCurrEduCls_SynObjLst_Sel.Count > 0)
{
return arrvCurrEduCls_SynObjLst_Sel[0].CourseName;
}
string strErrMsgForGetObjById = string.Format("在vCurrEduCls_Syn对象缓存列表中,找不到记录的相关名称[id_CurrEduCls = {0}](函数:{1})", strid_CurrEduCls, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvCurrEduCls_SynBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduCls_SynEN> GetObjLst(string strWhereCond)
{
 List<clsvCurrEduCls_SynEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduCls_SynEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduCls_SynEN> GetObjLstById_CurrEduClsLst(List<string> arrId_CurrEduCls)
{
 List<clsvCurrEduCls_SynEN> arrObjLst = null; 
string strAction = "GetObjLstById_CurrEduClsLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CurrEduCls);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduCls_SynEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_CurrEduCls">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvCurrEduCls_SynEN> GetObjLstById_CurrEduClsLst_Cache(List<string> arrId_CurrEduCls)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCurrEduCls_SynEN._CurrTabName_S);
List<clsvCurrEduCls_SynEN> arrvCurrEduCls_SynObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCurrEduCls_SynEN> arrvCurrEduCls_SynObjLst_Sel =
from objvCurrEduCls_SynEN in arrvCurrEduCls_SynObjLst_Cache
where arrId_CurrEduCls.Contains(objvCurrEduCls_SynEN.id_CurrEduCls)
select objvCurrEduCls_SynEN;
return arrvCurrEduCls_SynObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduCls_SynEN> GetObjLstById_CurrEduClsLst_WA_Cache(List<string> arrId_CurrEduCls)
{
 List<clsvCurrEduCls_SynEN> arrObjLst = null; 
string strAction = "GetObjLstById_CurrEduClsLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CurrEduCls);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduCls_SynEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduCls_SynEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCurrEduCls_SynEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduCls_SynEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduCls_SynEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCurrEduCls_SynEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduCls_SynEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduCls_SynEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCurrEduCls_SynEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduCls_SynEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduCls_SynEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCurrEduCls_SynEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduCls_SynEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strid_CurrEduCls)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CurrEduCls"] = strid_CurrEduCls
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
 /// <param name = "objvCurrEduCls_SynENS">源对象</param>
 /// <param name = "objvCurrEduCls_SynENT">目标对象</param>
 public static void CopyTo(clsvCurrEduCls_SynEN objvCurrEduCls_SynENS, clsvCurrEduCls_SynEN objvCurrEduCls_SynENT)
{
try
{
objvCurrEduCls_SynENT.id_CurrEduCls = objvCurrEduCls_SynENS.id_CurrEduCls; //当前教学班流水号
objvCurrEduCls_SynENT.EduClsTypeName = objvCurrEduCls_SynENS.EduClsTypeName; //教学班类型名称
objvCurrEduCls_SynENT.CourseCode = objvCurrEduCls_SynENS.CourseCode; //课程代码
objvCurrEduCls_SynENT.CourseDescription = objvCurrEduCls_SynENS.CourseDescription; //课程描述
objvCurrEduCls_SynENT.CourseName = objvCurrEduCls_SynENS.CourseName; //课程名称
objvCurrEduCls_SynENT.ViewCount = objvCurrEduCls_SynENS.ViewCount; //浏览量
objvCurrEduCls_SynENT.ExampleImgPath = objvCurrEduCls_SynENS.ExampleImgPath; //示例图路径
objvCurrEduCls_SynENT.TeachingSolutionName = objvCurrEduCls_SynENS.TeachingSolutionName; //教学方案名称
objvCurrEduCls_SynENT.id_Teacher = objvCurrEduCls_SynENS.id_Teacher; //教师流水号
objvCurrEduCls_SynENT.TeacherID = objvCurrEduCls_SynENS.TeacherID; //教师工号
objvCurrEduCls_SynENT.TeacherName = objvCurrEduCls_SynENS.TeacherName; //教师姓名
objvCurrEduCls_SynENT.CollegeID = objvCurrEduCls_SynENS.CollegeID; //学院ID
objvCurrEduCls_SynENT.CollegeName = objvCurrEduCls_SynENS.CollegeName; //学院名称
objvCurrEduCls_SynENT.id_XzMajor = objvCurrEduCls_SynENS.id_XzMajor; //专业流水号
objvCurrEduCls_SynENT.MajorName = objvCurrEduCls_SynENS.MajorName; //专业名称
objvCurrEduCls_SynENT.GradeBaseID = objvCurrEduCls_SynENS.GradeBaseID; //年级代号
objvCurrEduCls_SynENT.GradeBaseName = objvCurrEduCls_SynENS.GradeBaseName; //年级名称
objvCurrEduCls_SynENT.GradeBaseNameA = objvCurrEduCls_SynENS.GradeBaseNameA; //年级名称缩写
objvCurrEduCls_SynENT.CourseTypeID = objvCurrEduCls_SynENS.CourseTypeID; //课程类型ID
objvCurrEduCls_SynENT.CourseTypeName = objvCurrEduCls_SynENS.CourseTypeName; //课程类型名称
objvCurrEduCls_SynENT.CurrStuNum_Valid = objvCurrEduCls_SynENS.CurrStuNum_Valid; //CurrStuNum_Valid
objvCurrEduCls_SynENT.CurrStuNum = objvCurrEduCls_SynENS.CurrStuNum; //当前学生数
objvCurrEduCls_SynENT.CurrEduClsId = objvCurrEduCls_SynENS.CurrEduClsId; //当前教学班Id
objvCurrEduCls_SynENT.EduClsName = objvCurrEduCls_SynENS.EduClsName; //教学班名称
objvCurrEduCls_SynENT.EduClsTypeId = objvCurrEduCls_SynENS.EduClsTypeId; //教学班类型代号
objvCurrEduCls_SynENT.CourseId = objvCurrEduCls_SynENS.CourseId; //课程Id
objvCurrEduCls_SynENT.TeachingSolutionId = objvCurrEduCls_SynENS.TeachingSolutionId; //教学方案Id
objvCurrEduCls_SynENT.id_XzCollege = objvCurrEduCls_SynENS.id_XzCollege; //学院流水号
objvCurrEduCls_SynENT.id_EduWay = objvCurrEduCls_SynENS.id_EduWay; //教学方式流水号
objvCurrEduCls_SynENT.id_ClassRoomType = objvCurrEduCls_SynENS.id_ClassRoomType; //教室类型流水号
objvCurrEduCls_SynENT.TotalLessonQty = objvCurrEduCls_SynENS.TotalLessonQty; //总课时数
objvCurrEduCls_SynENT.MaxStuQty = objvCurrEduCls_SynENS.MaxStuQty; //最大学生数
objvCurrEduCls_SynENT.WeekQty = objvCurrEduCls_SynENS.WeekQty; //总周数
objvCurrEduCls_SynENT.ScheUnitPW = objvCurrEduCls_SynENS.ScheUnitPW; //周排课次数
objvCurrEduCls_SynENT.WeekStatusID = objvCurrEduCls_SynENS.WeekStatusID; //周状态编号(单,双,全周)
objvCurrEduCls_SynENT.CustomerWeek = objvCurrEduCls_SynENS.CustomerWeek; //自定义上课周
objvCurrEduCls_SynENT.IsCompleteScore = objvCurrEduCls_SynENS.IsCompleteScore; //是否成绩齐全
objvCurrEduCls_SynENT.id_ExecPlan = objvCurrEduCls_SynENS.id_ExecPlan; //执行计划流水号
objvCurrEduCls_SynENT.LessonQtyPerWeek = objvCurrEduCls_SynENS.LessonQtyPerWeek; //周课时数
objvCurrEduCls_SynENT.Mark = objvCurrEduCls_SynENS.Mark; //获得学分
objvCurrEduCls_SynENT.CheckClassRoom = objvCurrEduCls_SynENS.CheckClassRoom; //检查教室结果
objvCurrEduCls_SynENT.CheckAdminCls = objvCurrEduCls_SynENS.CheckAdminCls; //检查行政班结果
objvCurrEduCls_SynENT.CheckTeacher = objvCurrEduCls_SynENS.CheckTeacher; //检查教师结果
objvCurrEduCls_SynENT.EditLocked = objvCurrEduCls_SynENS.EditLocked; //编辑锁定
objvCurrEduCls_SynENT.Sched = objvCurrEduCls_SynENS.Sched; //是否排课
objvCurrEduCls_SynENT.id_UniZone = objvCurrEduCls_SynENS.id_UniZone; //校区流水号
objvCurrEduCls_SynENT.Locked = objvCurrEduCls_SynENS.Locked; //锁定状态
objvCurrEduCls_SynENT.id_GradeBase = objvCurrEduCls_SynENS.id_GradeBase; //年级流水号
objvCurrEduCls_SynENT.IsEffective = objvCurrEduCls_SynENS.IsEffective; //是否有效
objvCurrEduCls_SynENT.IsForPaperReading = objvCurrEduCls_SynENS.IsForPaperReading; //是否参与论文阅读
objvCurrEduCls_SynENT.IsUnDeterminedClsRm = objvCurrEduCls_SynENS.IsUnDeterminedClsRm; //是否待定教室
objvCurrEduCls_SynENT.SchoolYear = objvCurrEduCls_SynENS.SchoolYear; //学年
objvCurrEduCls_SynENT.SchoolTerm = objvCurrEduCls_SynENS.SchoolTerm; //学期
objvCurrEduCls_SynENT.ArrangeCourseMemo = objvCurrEduCls_SynENS.ArrangeCourseMemo; //排课备注
objvCurrEduCls_SynENT.id_CourseType = objvCurrEduCls_SynENS.id_CourseType; //课程类型流水号
objvCurrEduCls_SynENT.IsDegree = objvCurrEduCls_SynENS.IsDegree; //是否学位课
objvCurrEduCls_SynENT.id_ScoreType = objvCurrEduCls_SynENS.id_ScoreType; //成绩类型流水号
objvCurrEduCls_SynENT.GetScoreWayId = objvCurrEduCls_SynENS.GetScoreWayId; //获得成绩方式Id
objvCurrEduCls_SynENT.IsProportionalCtrl = objvCurrEduCls_SynENS.IsProportionalCtrl; //是否比例控制
objvCurrEduCls_SynENT.id_ExamType = objvCurrEduCls_SynENS.id_ExamType; //考试方式流水号
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
objvCurrEduCls_SynENT.ModifyUserID = objvCurrEduCls_SynENS.ModifyUserID; //修改人
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
public static DataTable ToDataTable(List<clsvCurrEduCls_SynEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCurrEduCls_SynEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCurrEduCls_SynEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCurrEduCls_SynEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCurrEduCls_SynEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCurrEduCls_SynEN.AttributeName)
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
if (clsCurrEduCls_SynWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduCls_SynWApi没有刷新缓存机制(clsCurrEduCls_SynWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeWApi没有刷新缓存机制(clscc_CourseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorWApi没有刷新缓存机制(clsXzMajorWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCurrEduClsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsWApi没有刷新缓存机制(clsCurrEduClsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseWApi没有刷新缓存机制(clsXzGradeBaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_EduClsTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_EduClsTypeWApi没有刷新缓存机制(clsgs_EduClsTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsTeachingSolutionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingSolutionWApi没有刷新缓存机制(clsTeachingSolutionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by id_CurrEduCls");
//if (arrvCurrEduCls_SynObjLst_Cache == null)
//{
//arrvCurrEduCls_SynObjLst_Cache = await clsvCurrEduCls_SynWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCurrEduCls_SynEN._CurrTabName_S);
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
public static List<clsvCurrEduCls_SynEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCurrEduCls_SynEN._CurrTabName_S);
List<clsvCurrEduCls_SynEN> arrvCurrEduCls_SynObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCurrEduCls_SynObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCurrEduCls_SynEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCurrEduCls_Syn.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.EduClsTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.CourseDescription, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduCls_Syn.ExampleImgPath, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.TeachingSolutionName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.id_Teacher, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.TeacherID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.TeacherName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.GradeBaseID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.GradeBaseNameA, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.CourseTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.CourseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.CurrStuNum_Valid, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduCls_Syn.CurrStuNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduCls_Syn.CurrEduClsId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.EduClsName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.EduClsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.TeachingSolutionId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.id_EduWay, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.id_ClassRoomType, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.TotalLessonQty, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduCls_Syn.MaxStuQty, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduCls_Syn.WeekQty, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduCls_Syn.ScheUnitPW, Type.GetType("System.Int16"));
objDT.Columns.Add(convCurrEduCls_Syn.WeekStatusID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.CustomerWeek, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.IsCompleteScore, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduCls_Syn.id_ExecPlan, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.LessonQtyPerWeek, Type.GetType("System.Int16"));
objDT.Columns.Add(convCurrEduCls_Syn.Mark, Type.GetType("System.Decimal"));
objDT.Columns.Add(convCurrEduCls_Syn.CheckClassRoom, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.CheckAdminCls, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.CheckTeacher, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.EditLocked, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduCls_Syn.Sched, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduCls_Syn.id_UniZone, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.Locked, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduCls_Syn.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.IsEffective, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduCls_Syn.IsForPaperReading, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduCls_Syn.IsUnDeterminedClsRm, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduCls_Syn.SchoolYear, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.SchoolTerm, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.ArrangeCourseMemo, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.id_CourseType, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.IsDegree, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduCls_Syn.id_ScoreType, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.GetScoreWayId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.IsProportionalCtrl, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduCls_Syn.id_ExamType, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.ExamPortion, Type.GetType("System.Int16"));
objDT.Columns.Add(convCurrEduCls_Syn.MidExamScorePortion, Type.GetType("System.Int16"));
objDT.Columns.Add(convCurrEduCls_Syn.IsClearScore, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduCls_Syn.IsGeneratePwd, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduCls_Syn.GeneratePwdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.PkWeekTime, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.PkClassRooms, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.BeginWeek, Type.GetType("System.Int16"));
objDT.Columns.Add(convCurrEduCls_Syn.TeacherNames, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.IsSynch, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduCls_Syn.SynchDate, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.ModifyDate, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.ModifyUserID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.SignInDate, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.SignInStateID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.SignInUser, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.SynchToWebUser, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls_Syn.IsSynchToWeb, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduCls_Syn.SynchToWebDate, Type.GetType("System.String"));
foreach (clsvCurrEduCls_SynEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCurrEduCls_Syn.id_CurrEduCls] = objInFor[convCurrEduCls_Syn.id_CurrEduCls];
objDR[convCurrEduCls_Syn.EduClsTypeName] = objInFor[convCurrEduCls_Syn.EduClsTypeName];
objDR[convCurrEduCls_Syn.CourseCode] = objInFor[convCurrEduCls_Syn.CourseCode];
objDR[convCurrEduCls_Syn.CourseDescription] = objInFor[convCurrEduCls_Syn.CourseDescription];
objDR[convCurrEduCls_Syn.CourseName] = objInFor[convCurrEduCls_Syn.CourseName];
objDR[convCurrEduCls_Syn.ViewCount] = objInFor[convCurrEduCls_Syn.ViewCount];
objDR[convCurrEduCls_Syn.ExampleImgPath] = objInFor[convCurrEduCls_Syn.ExampleImgPath];
objDR[convCurrEduCls_Syn.TeachingSolutionName] = objInFor[convCurrEduCls_Syn.TeachingSolutionName];
objDR[convCurrEduCls_Syn.id_Teacher] = objInFor[convCurrEduCls_Syn.id_Teacher];
objDR[convCurrEduCls_Syn.TeacherID] = objInFor[convCurrEduCls_Syn.TeacherID];
objDR[convCurrEduCls_Syn.TeacherName] = objInFor[convCurrEduCls_Syn.TeacherName];
objDR[convCurrEduCls_Syn.CollegeID] = objInFor[convCurrEduCls_Syn.CollegeID];
objDR[convCurrEduCls_Syn.CollegeName] = objInFor[convCurrEduCls_Syn.CollegeName];
objDR[convCurrEduCls_Syn.id_XzMajor] = objInFor[convCurrEduCls_Syn.id_XzMajor];
objDR[convCurrEduCls_Syn.MajorName] = objInFor[convCurrEduCls_Syn.MajorName];
objDR[convCurrEduCls_Syn.GradeBaseID] = objInFor[convCurrEduCls_Syn.GradeBaseID];
objDR[convCurrEduCls_Syn.GradeBaseName] = objInFor[convCurrEduCls_Syn.GradeBaseName];
objDR[convCurrEduCls_Syn.GradeBaseNameA] = objInFor[convCurrEduCls_Syn.GradeBaseNameA];
objDR[convCurrEduCls_Syn.CourseTypeID] = objInFor[convCurrEduCls_Syn.CourseTypeID];
objDR[convCurrEduCls_Syn.CourseTypeName] = objInFor[convCurrEduCls_Syn.CourseTypeName];
objDR[convCurrEduCls_Syn.CurrStuNum_Valid] = objInFor[convCurrEduCls_Syn.CurrStuNum_Valid];
objDR[convCurrEduCls_Syn.CurrStuNum] = objInFor[convCurrEduCls_Syn.CurrStuNum];
objDR[convCurrEduCls_Syn.CurrEduClsId] = objInFor[convCurrEduCls_Syn.CurrEduClsId];
objDR[convCurrEduCls_Syn.EduClsName] = objInFor[convCurrEduCls_Syn.EduClsName];
objDR[convCurrEduCls_Syn.EduClsTypeId] = objInFor[convCurrEduCls_Syn.EduClsTypeId];
objDR[convCurrEduCls_Syn.CourseId] = objInFor[convCurrEduCls_Syn.CourseId];
objDR[convCurrEduCls_Syn.TeachingSolutionId] = objInFor[convCurrEduCls_Syn.TeachingSolutionId];
objDR[convCurrEduCls_Syn.id_XzCollege] = objInFor[convCurrEduCls_Syn.id_XzCollege];
objDR[convCurrEduCls_Syn.id_EduWay] = objInFor[convCurrEduCls_Syn.id_EduWay];
objDR[convCurrEduCls_Syn.id_ClassRoomType] = objInFor[convCurrEduCls_Syn.id_ClassRoomType];
objDR[convCurrEduCls_Syn.TotalLessonQty] = objInFor[convCurrEduCls_Syn.TotalLessonQty];
objDR[convCurrEduCls_Syn.MaxStuQty] = objInFor[convCurrEduCls_Syn.MaxStuQty];
objDR[convCurrEduCls_Syn.WeekQty] = objInFor[convCurrEduCls_Syn.WeekQty];
objDR[convCurrEduCls_Syn.ScheUnitPW] = objInFor[convCurrEduCls_Syn.ScheUnitPW];
objDR[convCurrEduCls_Syn.WeekStatusID] = objInFor[convCurrEduCls_Syn.WeekStatusID];
objDR[convCurrEduCls_Syn.CustomerWeek] = objInFor[convCurrEduCls_Syn.CustomerWeek];
objDR[convCurrEduCls_Syn.IsCompleteScore] = objInFor[convCurrEduCls_Syn.IsCompleteScore];
objDR[convCurrEduCls_Syn.id_ExecPlan] = objInFor[convCurrEduCls_Syn.id_ExecPlan];
objDR[convCurrEduCls_Syn.LessonQtyPerWeek] = objInFor[convCurrEduCls_Syn.LessonQtyPerWeek];
objDR[convCurrEduCls_Syn.Mark] = objInFor[convCurrEduCls_Syn.Mark];
objDR[convCurrEduCls_Syn.CheckClassRoom] = objInFor[convCurrEduCls_Syn.CheckClassRoom];
objDR[convCurrEduCls_Syn.CheckAdminCls] = objInFor[convCurrEduCls_Syn.CheckAdminCls];
objDR[convCurrEduCls_Syn.CheckTeacher] = objInFor[convCurrEduCls_Syn.CheckTeacher];
objDR[convCurrEduCls_Syn.EditLocked] = objInFor[convCurrEduCls_Syn.EditLocked];
objDR[convCurrEduCls_Syn.Sched] = objInFor[convCurrEduCls_Syn.Sched];
objDR[convCurrEduCls_Syn.id_UniZone] = objInFor[convCurrEduCls_Syn.id_UniZone];
objDR[convCurrEduCls_Syn.Locked] = objInFor[convCurrEduCls_Syn.Locked];
objDR[convCurrEduCls_Syn.id_GradeBase] = objInFor[convCurrEduCls_Syn.id_GradeBase];
objDR[convCurrEduCls_Syn.IsEffective] = objInFor[convCurrEduCls_Syn.IsEffective];
objDR[convCurrEduCls_Syn.IsForPaperReading] = objInFor[convCurrEduCls_Syn.IsForPaperReading];
objDR[convCurrEduCls_Syn.IsUnDeterminedClsRm] = objInFor[convCurrEduCls_Syn.IsUnDeterminedClsRm];
objDR[convCurrEduCls_Syn.SchoolYear] = objInFor[convCurrEduCls_Syn.SchoolYear];
objDR[convCurrEduCls_Syn.SchoolTerm] = objInFor[convCurrEduCls_Syn.SchoolTerm];
objDR[convCurrEduCls_Syn.ArrangeCourseMemo] = objInFor[convCurrEduCls_Syn.ArrangeCourseMemo];
objDR[convCurrEduCls_Syn.id_CourseType] = objInFor[convCurrEduCls_Syn.id_CourseType];
objDR[convCurrEduCls_Syn.IsDegree] = objInFor[convCurrEduCls_Syn.IsDegree];
objDR[convCurrEduCls_Syn.id_ScoreType] = objInFor[convCurrEduCls_Syn.id_ScoreType];
objDR[convCurrEduCls_Syn.GetScoreWayId] = objInFor[convCurrEduCls_Syn.GetScoreWayId];
objDR[convCurrEduCls_Syn.IsProportionalCtrl] = objInFor[convCurrEduCls_Syn.IsProportionalCtrl];
objDR[convCurrEduCls_Syn.id_ExamType] = objInFor[convCurrEduCls_Syn.id_ExamType];
objDR[convCurrEduCls_Syn.ExamPortion] = objInFor[convCurrEduCls_Syn.ExamPortion];
objDR[convCurrEduCls_Syn.MidExamScorePortion] = objInFor[convCurrEduCls_Syn.MidExamScorePortion];
objDR[convCurrEduCls_Syn.IsClearScore] = objInFor[convCurrEduCls_Syn.IsClearScore];
objDR[convCurrEduCls_Syn.IsGeneratePwd] = objInFor[convCurrEduCls_Syn.IsGeneratePwd];
objDR[convCurrEduCls_Syn.GeneratePwdDate] = objInFor[convCurrEduCls_Syn.GeneratePwdDate];
objDR[convCurrEduCls_Syn.PkWeekTime] = objInFor[convCurrEduCls_Syn.PkWeekTime];
objDR[convCurrEduCls_Syn.PkClassRooms] = objInFor[convCurrEduCls_Syn.PkClassRooms];
objDR[convCurrEduCls_Syn.BeginWeek] = objInFor[convCurrEduCls_Syn.BeginWeek];
objDR[convCurrEduCls_Syn.TeacherNames] = objInFor[convCurrEduCls_Syn.TeacherNames];
objDR[convCurrEduCls_Syn.IsSynch] = objInFor[convCurrEduCls_Syn.IsSynch];
objDR[convCurrEduCls_Syn.SynchDate] = objInFor[convCurrEduCls_Syn.SynchDate];
objDR[convCurrEduCls_Syn.ModifyDate] = objInFor[convCurrEduCls_Syn.ModifyDate];
objDR[convCurrEduCls_Syn.ModifyUserID] = objInFor[convCurrEduCls_Syn.ModifyUserID];
objDR[convCurrEduCls_Syn.Memo] = objInFor[convCurrEduCls_Syn.Memo];
objDR[convCurrEduCls_Syn.SignInDate] = objInFor[convCurrEduCls_Syn.SignInDate];
objDR[convCurrEduCls_Syn.SignInStateID] = objInFor[convCurrEduCls_Syn.SignInStateID];
objDR[convCurrEduCls_Syn.SignInUser] = objInFor[convCurrEduCls_Syn.SignInUser];
objDR[convCurrEduCls_Syn.SynchToWebUser] = objInFor[convCurrEduCls_Syn.SynchToWebUser];
objDR[convCurrEduCls_Syn.IsSynchToWeb] = objInFor[convCurrEduCls_Syn.IsSynchToWeb];
objDR[convCurrEduCls_Syn.SynchToWebDate] = objInFor[convCurrEduCls_Syn.SynchToWebDate];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}