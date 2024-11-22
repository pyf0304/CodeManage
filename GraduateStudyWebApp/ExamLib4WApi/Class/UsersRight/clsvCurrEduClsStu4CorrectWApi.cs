
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCurrEduClsStu4CorrectWApi
 表名:vCurrEduClsStu4Correct(01120181)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:40:18
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:权限管理
 模块英文名:UsersRight
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
public static class clsvCurrEduClsStu4CorrectWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetId_CurrEduClsStu4Correct(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, long lngId_CurrEduClsStu4Correct, string strComparisonOp="")
	{
objvCurrEduClsStu4CorrectEN.Id_CurrEduClsStu4Correct = lngId_CurrEduClsStu4Correct; //教学班学生_批改作业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.Id_CurrEduClsStu4Correct) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.Id_CurrEduClsStu4Correct, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.Id_CurrEduClsStu4Correct] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN Setid_CurrEduCls(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CurrEduCls, convCurrEduClsStu4Correct.id_CurrEduCls);
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convCurrEduClsStu4Correct.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convCurrEduClsStu4Correct.id_CurrEduCls);
objvCurrEduClsStu4CorrectEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.id_CurrEduCls) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.id_CurrEduCls, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.id_CurrEduCls] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetCurrEduClsId(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strCurrEduClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, convCurrEduClsStu4Correct.CurrEduClsId);
objvCurrEduClsStu4CorrectEN.CurrEduClsId = strCurrEduClsId; //当前教学班Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.CurrEduClsId) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.CurrEduClsId, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.CurrEduClsId] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetEduClsName(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduClsName, convCurrEduClsStu4Correct.EduClsName);
clsCheckSql.CheckFieldLen(strEduClsName, 100, convCurrEduClsStu4Correct.EduClsName);
objvCurrEduClsStu4CorrectEN.EduClsName = strEduClsName; //教学班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.EduClsName) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.EduClsName, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.EduClsName] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetCourseId(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCurrEduClsStu4Correct.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCurrEduClsStu4Correct.CourseId);
objvCurrEduClsStu4CorrectEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.CourseId) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.CourseId, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.CourseId] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetCourseCode(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCurrEduClsStu4Correct.CourseCode);
objvCurrEduClsStu4CorrectEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.CourseCode) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.CourseCode, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.CourseCode] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetCourseName(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCurrEduClsStu4Correct.CourseName);
objvCurrEduClsStu4CorrectEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.CourseName) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.CourseName, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.CourseName] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetTeachingSolutionId(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strTeachingSolutionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingSolutionId, convCurrEduClsStu4Correct.TeachingSolutionId);
clsCheckSql.CheckFieldLen(strTeachingSolutionId, 8, convCurrEduClsStu4Correct.TeachingSolutionId);
clsCheckSql.CheckFieldForeignKey(strTeachingSolutionId, 8, convCurrEduClsStu4Correct.TeachingSolutionId);
objvCurrEduClsStu4CorrectEN.TeachingSolutionId = strTeachingSolutionId; //教学方案Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.TeachingSolutionId) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.TeachingSolutionId, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.TeachingSolutionId] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetTeachingSolutionName(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strTeachingSolutionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingSolutionName, convCurrEduClsStu4Correct.TeachingSolutionName);
clsCheckSql.CheckFieldLen(strTeachingSolutionName, 100, convCurrEduClsStu4Correct.TeachingSolutionName);
objvCurrEduClsStu4CorrectEN.TeachingSolutionName = strTeachingSolutionName; //教学方案名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.TeachingSolutionName) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.TeachingSolutionName, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.TeachingSolutionName] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN Setid_XzCollege(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convCurrEduClsStu4Correct.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convCurrEduClsStu4Correct.id_XzCollege);
objvCurrEduClsStu4CorrectEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.id_XzCollege) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.id_XzCollege, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.id_XzCollege] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetCollegeID(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeID, convCurrEduClsStu4Correct.CollegeID);
clsCheckSql.CheckFieldLen(strCollegeID, 4, convCurrEduClsStu4Correct.CollegeID);
objvCurrEduClsStu4CorrectEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.CollegeID) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.CollegeID, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.CollegeID] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetCollegeName(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convCurrEduClsStu4Correct.CollegeName);
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCurrEduClsStu4Correct.CollegeName);
objvCurrEduClsStu4CorrectEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.CollegeName) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.CollegeName, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.CollegeName] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetLessonQtyPerWeek(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, short shtLessonQtyPerWeek, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(shtLessonQtyPerWeek, convCurrEduClsStu4Correct.LessonQtyPerWeek);
objvCurrEduClsStu4CorrectEN.LessonQtyPerWeek = shtLessonQtyPerWeek; //周课时数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.LessonQtyPerWeek) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.LessonQtyPerWeek, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.LessonQtyPerWeek] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetMark(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, double dblMark, string strComparisonOp="")
	{
objvCurrEduClsStu4CorrectEN.Mark = dblMark; //获得学分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.Mark) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.Mark, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.Mark] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN Setid_UniZone(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strid_UniZone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_UniZone, convCurrEduClsStu4Correct.id_UniZone);
clsCheckSql.CheckFieldLen(strid_UniZone, 4, convCurrEduClsStu4Correct.id_UniZone);
clsCheckSql.CheckFieldForeignKey(strid_UniZone, 4, convCurrEduClsStu4Correct.id_UniZone);
objvCurrEduClsStu4CorrectEN.id_UniZone = strid_UniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.id_UniZone) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.id_UniZone, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.id_UniZone] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetGradeBaseName(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGradeBaseName, convCurrEduClsStu4Correct.GradeBaseName);
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convCurrEduClsStu4Correct.GradeBaseName);
objvCurrEduClsStu4CorrectEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.GradeBaseName) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.GradeBaseName, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.GradeBaseName] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetIsEffective(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, bool bolIsEffective, string strComparisonOp="")
	{
objvCurrEduClsStu4CorrectEN.IsEffective = bolIsEffective; //是否有效
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.IsEffective) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.IsEffective, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.IsEffective] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN Setid_CourseType(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strid_CourseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CourseType, convCurrEduClsStu4Correct.id_CourseType);
clsCheckSql.CheckFieldLen(strid_CourseType, 4, convCurrEduClsStu4Correct.id_CourseType);
clsCheckSql.CheckFieldForeignKey(strid_CourseType, 4, convCurrEduClsStu4Correct.id_CourseType);
objvCurrEduClsStu4CorrectEN.id_CourseType = strid_CourseType; //课程类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.id_CourseType) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.id_CourseType, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.id_CourseType] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetCourseTypeID(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strCourseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseTypeID, convCurrEduClsStu4Correct.CourseTypeID);
clsCheckSql.CheckFieldLen(strCourseTypeID, 4, convCurrEduClsStu4Correct.CourseTypeID);
clsCheckSql.CheckFieldForeignKey(strCourseTypeID, 4, convCurrEduClsStu4Correct.CourseTypeID);
objvCurrEduClsStu4CorrectEN.CourseTypeID = strCourseTypeID; //课程类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.CourseTypeID) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.CourseTypeID, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.CourseTypeID] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetCourseTypeName(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strCourseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseTypeName, convCurrEduClsStu4Correct.CourseTypeName);
clsCheckSql.CheckFieldLen(strCourseTypeName, 30, convCurrEduClsStu4Correct.CourseTypeName);
objvCurrEduClsStu4CorrectEN.CourseTypeName = strCourseTypeName; //课程类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.CourseTypeName) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.CourseTypeName, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.CourseTypeName] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetIsDegree(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, bool bolIsDegree, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDegree, convCurrEduClsStu4Correct.IsDegree);
objvCurrEduClsStu4CorrectEN.IsDegree = bolIsDegree; //是否学位课
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.IsDegree) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.IsDegree, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.IsDegree] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetCurrStuNum(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, int intCurrStuNum, string strComparisonOp="")
	{
objvCurrEduClsStu4CorrectEN.CurrStuNum = intCurrStuNum; //当前学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.CurrStuNum) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.CurrStuNum, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.CurrStuNum] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN Setid_Stu(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strid_Stu, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Stu, 8, convCurrEduClsStu4Correct.id_Stu);
clsCheckSql.CheckFieldForeignKey(strid_Stu, 8, convCurrEduClsStu4Correct.id_Stu);
objvCurrEduClsStu4CorrectEN.id_Stu = strid_Stu; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.id_Stu) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.id_Stu, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.id_Stu] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetStuID(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convCurrEduClsStu4Correct.StuID);
objvCurrEduClsStu4CorrectEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.StuID) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.StuID, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.StuID] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetStuName(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convCurrEduClsStu4Correct.StuName);
objvCurrEduClsStu4CorrectEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.StuName) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.StuName, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.StuName] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN Setid_Sex(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strid_Sex, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Sex, convCurrEduClsStu4Correct.id_Sex);
clsCheckSql.CheckFieldLen(strid_Sex, 4, convCurrEduClsStu4Correct.id_Sex);
clsCheckSql.CheckFieldForeignKey(strid_Sex, 4, convCurrEduClsStu4Correct.id_Sex);
objvCurrEduClsStu4CorrectEN.id_Sex = strid_Sex; //性别流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.id_Sex) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.id_Sex, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.id_Sex] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetSexDesc(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strSexDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convCurrEduClsStu4Correct.SexDesc);
objvCurrEduClsStu4CorrectEN.SexDesc = strSexDesc; //性别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.SexDesc) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.SexDesc, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.SexDesc] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetMajorID(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorID, convCurrEduClsStu4Correct.MajorID);
clsCheckSql.CheckFieldLen(strMajorID, 4, convCurrEduClsStu4Correct.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convCurrEduClsStu4Correct.MajorID);
objvCurrEduClsStu4CorrectEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.MajorID) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.MajorID, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.MajorID] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetMajorName(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorName, convCurrEduClsStu4Correct.MajorName);
clsCheckSql.CheckFieldLen(strMajorName, 100, convCurrEduClsStu4Correct.MajorName);
objvCurrEduClsStu4CorrectEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.MajorName) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.MajorName, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.MajorName] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN Setid_AdminCls(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strid_AdminCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_AdminCls, 8, convCurrEduClsStu4Correct.id_AdminCls);
clsCheckSql.CheckFieldForeignKey(strid_AdminCls, 8, convCurrEduClsStu4Correct.id_AdminCls);
objvCurrEduClsStu4CorrectEN.id_AdminCls = strid_AdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.id_AdminCls) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.id_AdminCls, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.id_AdminCls] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetBirthday(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strBirthday, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBirthday, 8, convCurrEduClsStu4Correct.Birthday);
clsCheckSql.CheckFieldForeignKey(strBirthday, 8, convCurrEduClsStu4Correct.Birthday);
objvCurrEduClsStu4CorrectEN.Birthday = strBirthday; //出生日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.Birthday) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.Birthday, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.Birthday] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetRightId(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strRightId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightId, convCurrEduClsStu4Correct.RightId);
clsCheckSql.CheckFieldLen(strRightId, 8, convCurrEduClsStu4Correct.RightId);
clsCheckSql.CheckFieldForeignKey(strRightId, 8, convCurrEduClsStu4Correct.RightId);
objvCurrEduClsStu4CorrectEN.RightId = strRightId; //权限编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.RightId) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.RightId, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.RightId] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetRightName(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strRightName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightName, convCurrEduClsStu4Correct.RightName);
clsCheckSql.CheckFieldLen(strRightName, 200, convCurrEduClsStu4Correct.RightName);
objvCurrEduClsStu4CorrectEN.RightName = strRightName; //权限名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.RightName) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.RightName, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.RightName] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetRightTypeId(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strRightTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightTypeId, convCurrEduClsStu4Correct.RightTypeId);
clsCheckSql.CheckFieldLen(strRightTypeId, 4, convCurrEduClsStu4Correct.RightTypeId);
clsCheckSql.CheckFieldForeignKey(strRightTypeId, 4, convCurrEduClsStu4Correct.RightTypeId);
objvCurrEduClsStu4CorrectEN.RightTypeId = strRightTypeId; //权限类型编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.RightTypeId) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.RightTypeId, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.RightTypeId] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetRightTypeName(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strRightTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightTypeName, convCurrEduClsStu4Correct.RightTypeName);
clsCheckSql.CheckFieldLen(strRightTypeName, 50, convCurrEduClsStu4Correct.RightTypeName);
objvCurrEduClsStu4CorrectEN.RightTypeName = strRightTypeName; //权限类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.RightTypeName) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.RightTypeName, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.RightTypeName] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetFuncModuleId(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCurrEduClsStu4Correct.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCurrEduClsStu4Correct.FuncModuleId);
objvCurrEduClsStu4CorrectEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.FuncModuleId) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.FuncModuleId, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.FuncModuleId] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetFuncModuleName(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convCurrEduClsStu4Correct.FuncModuleName);
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCurrEduClsStu4Correct.FuncModuleName);
objvCurrEduClsStu4CorrectEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.FuncModuleName) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.FuncModuleName, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.FuncModuleName] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetFuncModuleName_Sim(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strFuncModuleName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName_Sim, 30, convCurrEduClsStu4Correct.FuncModuleName_Sim);
objvCurrEduClsStu4CorrectEN.FuncModuleName_Sim = strFuncModuleName_Sim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.FuncModuleName_Sim) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.FuncModuleName_Sim, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.FuncModuleName_Sim] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetRightRangeLevelId(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strRightRangeLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightRangeLevelId, convCurrEduClsStu4Correct.RightRangeLevelId);
clsCheckSql.CheckFieldLen(strRightRangeLevelId, 2, convCurrEduClsStu4Correct.RightRangeLevelId);
clsCheckSql.CheckFieldForeignKey(strRightRangeLevelId, 2, convCurrEduClsStu4Correct.RightRangeLevelId);
objvCurrEduClsStu4CorrectEN.RightRangeLevelId = strRightRangeLevelId; //权限范围等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.RightRangeLevelId) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.RightRangeLevelId, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.RightRangeLevelId] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetRightRangeLevelName(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strRightRangeLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightRangeLevelName, convCurrEduClsStu4Correct.RightRangeLevelName);
clsCheckSql.CheckFieldLen(strRightRangeLevelName, 30, convCurrEduClsStu4Correct.RightRangeLevelName);
objvCurrEduClsStu4CorrectEN.RightRangeLevelName = strRightRangeLevelName; //权限范围等级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.RightRangeLevelName) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.RightRangeLevelName, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.RightRangeLevelName] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetSchoolTerm(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, convCurrEduClsStu4Correct.SchoolTerm);
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, convCurrEduClsStu4Correct.SchoolTerm);
objvCurrEduClsStu4CorrectEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.SchoolTerm) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.SchoolTerm, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.SchoolTerm] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetSchoolYear(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strSchoolYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, convCurrEduClsStu4Correct.SchoolYear);
objvCurrEduClsStu4CorrectEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.SchoolYear) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.SchoolYear, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.SchoolYear] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetModifyDate(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strModifyDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyDate, 20, convCurrEduClsStu4Correct.ModifyDate);
objvCurrEduClsStu4CorrectEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.ModifyDate) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.ModifyDate, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.ModifyDate] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetModifyUserID(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strModifyUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyUserID, 18, convCurrEduClsStu4Correct.ModifyUserID);
objvCurrEduClsStu4CorrectEN.ModifyUserID = strModifyUserID; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.ModifyUserID) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.ModifyUserID, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.ModifyUserID] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetMemo(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCurrEduClsStu4Correct.Memo);
objvCurrEduClsStu4CorrectEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.Memo) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.Memo, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.Memo] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4CorrectEN SetCollegeName4Stu(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN, string strCollegeName4Stu, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName4Stu, 100, convCurrEduClsStu4Correct.CollegeName4Stu);
objvCurrEduClsStu4CorrectEN.CollegeName4Stu = strCollegeName4Stu; //CollegeName4Stu
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4Correct.CollegeName4Stu) == false)
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(convCurrEduClsStu4Correct.CollegeName4Stu, strComparisonOp);
}
else
{
objvCurrEduClsStu4CorrectEN.dicFldComparisonOp[convCurrEduClsStu4Correct.CollegeName4Stu] = strComparisonOp;
}
}
return objvCurrEduClsStu4CorrectEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4Correct_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.Id_CurrEduClsStu4Correct) == true)
{
string strComparisonOp_Id_CurrEduClsStu4Correct = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.Id_CurrEduClsStu4Correct];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsStu4Correct.Id_CurrEduClsStu4Correct, objvCurrEduClsStu4Correct_Cond.Id_CurrEduClsStu4Correct, strComparisonOp_Id_CurrEduClsStu4Correct);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.id_CurrEduCls, objvCurrEduClsStu4Correct_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.CurrEduClsId) == true)
{
string strComparisonOp_CurrEduClsId = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.CurrEduClsId, objvCurrEduClsStu4Correct_Cond.CurrEduClsId, strComparisonOp_CurrEduClsId);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.EduClsName) == true)
{
string strComparisonOp_EduClsName = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.EduClsName, objvCurrEduClsStu4Correct_Cond.EduClsName, strComparisonOp_EduClsName);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.CourseId) == true)
{
string strComparisonOp_CourseId = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.CourseId, objvCurrEduClsStu4Correct_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.CourseCode, objvCurrEduClsStu4Correct_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.CourseName) == true)
{
string strComparisonOp_CourseName = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.CourseName, objvCurrEduClsStu4Correct_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.TeachingSolutionId) == true)
{
string strComparisonOp_TeachingSolutionId = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.TeachingSolutionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.TeachingSolutionId, objvCurrEduClsStu4Correct_Cond.TeachingSolutionId, strComparisonOp_TeachingSolutionId);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.TeachingSolutionName) == true)
{
string strComparisonOp_TeachingSolutionName = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.TeachingSolutionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.TeachingSolutionName, objvCurrEduClsStu4Correct_Cond.TeachingSolutionName, strComparisonOp_TeachingSolutionName);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.id_XzCollege, objvCurrEduClsStu4Correct_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.CollegeID, objvCurrEduClsStu4Correct_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.CollegeName, objvCurrEduClsStu4Correct_Cond.CollegeName, strComparisonOp_CollegeName);
}
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.Mark) == true)
{
string strComparisonOp_Mark = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.Mark];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsStu4Correct.Mark, objvCurrEduClsStu4Correct_Cond.Mark, strComparisonOp_Mark);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.id_UniZone) == true)
{
string strComparisonOp_id_UniZone = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.id_UniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.id_UniZone, objvCurrEduClsStu4Correct_Cond.id_UniZone, strComparisonOp_id_UniZone);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.GradeBaseName, objvCurrEduClsStu4Correct_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.IsEffective) == true)
{
if (objvCurrEduClsStu4Correct_Cond.IsEffective == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduClsStu4Correct.IsEffective);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduClsStu4Correct.IsEffective);
}
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.id_CourseType) == true)
{
string strComparisonOp_id_CourseType = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.id_CourseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.id_CourseType, objvCurrEduClsStu4Correct_Cond.id_CourseType, strComparisonOp_id_CourseType);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.CourseTypeID) == true)
{
string strComparisonOp_CourseTypeID = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.CourseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.CourseTypeID, objvCurrEduClsStu4Correct_Cond.CourseTypeID, strComparisonOp_CourseTypeID);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.CourseTypeName) == true)
{
string strComparisonOp_CourseTypeName = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.CourseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.CourseTypeName, objvCurrEduClsStu4Correct_Cond.CourseTypeName, strComparisonOp_CourseTypeName);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.IsDegree) == true)
{
if (objvCurrEduClsStu4Correct_Cond.IsDegree == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduClsStu4Correct.IsDegree);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduClsStu4Correct.IsDegree);
}
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.CurrStuNum) == true)
{
string strComparisonOp_CurrStuNum = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.CurrStuNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsStu4Correct.CurrStuNum, objvCurrEduClsStu4Correct_Cond.CurrStuNum, strComparisonOp_CurrStuNum);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.id_Stu) == true)
{
string strComparisonOp_id_Stu = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.id_Stu];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.id_Stu, objvCurrEduClsStu4Correct_Cond.id_Stu, strComparisonOp_id_Stu);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.StuID) == true)
{
string strComparisonOp_StuID = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.StuID, objvCurrEduClsStu4Correct_Cond.StuID, strComparisonOp_StuID);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.StuName) == true)
{
string strComparisonOp_StuName = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.StuName, objvCurrEduClsStu4Correct_Cond.StuName, strComparisonOp_StuName);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.id_Sex) == true)
{
string strComparisonOp_id_Sex = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.id_Sex];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.id_Sex, objvCurrEduClsStu4Correct_Cond.id_Sex, strComparisonOp_id_Sex);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.SexDesc) == true)
{
string strComparisonOp_SexDesc = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.SexDesc, objvCurrEduClsStu4Correct_Cond.SexDesc, strComparisonOp_SexDesc);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.MajorID) == true)
{
string strComparisonOp_MajorID = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.MajorID, objvCurrEduClsStu4Correct_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.MajorName) == true)
{
string strComparisonOp_MajorName = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.MajorName, objvCurrEduClsStu4Correct_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.id_AdminCls) == true)
{
string strComparisonOp_id_AdminCls = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.id_AdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.id_AdminCls, objvCurrEduClsStu4Correct_Cond.id_AdminCls, strComparisonOp_id_AdminCls);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.Birthday) == true)
{
string strComparisonOp_Birthday = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.Birthday];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.Birthday, objvCurrEduClsStu4Correct_Cond.Birthday, strComparisonOp_Birthday);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.RightId) == true)
{
string strComparisonOp_RightId = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.RightId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.RightId, objvCurrEduClsStu4Correct_Cond.RightId, strComparisonOp_RightId);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.RightName) == true)
{
string strComparisonOp_RightName = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.RightName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.RightName, objvCurrEduClsStu4Correct_Cond.RightName, strComparisonOp_RightName);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.RightTypeId) == true)
{
string strComparisonOp_RightTypeId = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.RightTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.RightTypeId, objvCurrEduClsStu4Correct_Cond.RightTypeId, strComparisonOp_RightTypeId);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.RightTypeName) == true)
{
string strComparisonOp_RightTypeName = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.RightTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.RightTypeName, objvCurrEduClsStu4Correct_Cond.RightTypeName, strComparisonOp_RightTypeName);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.FuncModuleId, objvCurrEduClsStu4Correct_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.FuncModuleName, objvCurrEduClsStu4Correct_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.FuncModuleName_Sim) == true)
{
string strComparisonOp_FuncModuleName_Sim = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.FuncModuleName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.FuncModuleName_Sim, objvCurrEduClsStu4Correct_Cond.FuncModuleName_Sim, strComparisonOp_FuncModuleName_Sim);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.RightRangeLevelId) == true)
{
string strComparisonOp_RightRangeLevelId = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.RightRangeLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.RightRangeLevelId, objvCurrEduClsStu4Correct_Cond.RightRangeLevelId, strComparisonOp_RightRangeLevelId);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.RightRangeLevelName) == true)
{
string strComparisonOp_RightRangeLevelName = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.RightRangeLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.RightRangeLevelName, objvCurrEduClsStu4Correct_Cond.RightRangeLevelName, strComparisonOp_RightRangeLevelName);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.SchoolTerm) == true)
{
string strComparisonOp_SchoolTerm = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.SchoolTerm, objvCurrEduClsStu4Correct_Cond.SchoolTerm, strComparisonOp_SchoolTerm);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.SchoolYear) == true)
{
string strComparisonOp_SchoolYear = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.SchoolYear, objvCurrEduClsStu4Correct_Cond.SchoolYear, strComparisonOp_SchoolYear);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.ModifyDate) == true)
{
string strComparisonOp_ModifyDate = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.ModifyDate, objvCurrEduClsStu4Correct_Cond.ModifyDate, strComparisonOp_ModifyDate);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.ModifyUserID) == true)
{
string strComparisonOp_ModifyUserID = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.ModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.ModifyUserID, objvCurrEduClsStu4Correct_Cond.ModifyUserID, strComparisonOp_ModifyUserID);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.Memo) == true)
{
string strComparisonOp_Memo = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.Memo, objvCurrEduClsStu4Correct_Cond.Memo, strComparisonOp_Memo);
}
if (objvCurrEduClsStu4Correct_Cond.IsUpdated(convCurrEduClsStu4Correct.CollegeName4Stu) == true)
{
string strComparisonOp_CollegeName4Stu = objvCurrEduClsStu4Correct_Cond.dicFldComparisonOp[convCurrEduClsStu4Correct.CollegeName4Stu];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4Correct.CollegeName4Stu, objvCurrEduClsStu4Correct_Cond.CollegeName4Stu, strComparisonOp_CollegeName4Stu);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v教学班学生_批改作业(vCurrEduClsStu4Correct)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCurrEduClsStu4CorrectWApi
{
private static readonly string mstrApiControllerName = "vCurrEduClsStu4CorrectApi";

 public clsvCurrEduClsStu4CorrectWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_CurrEduClsStu4Correct">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCurrEduClsStu4CorrectEN GetObjById_CurrEduClsStu4Correct(long lngId_CurrEduClsStu4Correct)
{
string strAction = "GetObjById_CurrEduClsStu4Correct";
string strErrMsg = string.Empty;
string strResult = "";
clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_CurrEduClsStu4Correct"] = lngId_CurrEduClsStu4Correct.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCurrEduClsStu4CorrectEN = JsonConvert.DeserializeObject<clsvCurrEduClsStu4CorrectEN>((string)jobjReturn["ReturnObj"]);
return objvCurrEduClsStu4CorrectEN;
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
 /// <param name = "lngId_CurrEduClsStu4Correct">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCurrEduClsStu4CorrectEN GetObjById_CurrEduClsStu4Correct_WA_Cache(long lngId_CurrEduClsStu4Correct)
{
string strAction = "GetObjById_CurrEduClsStu4Correct_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_CurrEduClsStu4Correct"] = lngId_CurrEduClsStu4Correct.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCurrEduClsStu4CorrectEN = JsonConvert.DeserializeObject<clsvCurrEduClsStu4CorrectEN>((string)jobjReturn["ReturnObj"]);
return objvCurrEduClsStu4CorrectEN;
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
public static clsvCurrEduClsStu4CorrectEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectEN = null;
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
objvCurrEduClsStu4CorrectEN = JsonConvert.DeserializeObject<clsvCurrEduClsStu4CorrectEN>((string)jobjReturn["ReturnObj"]);
return objvCurrEduClsStu4CorrectEN;
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
 /// <param name = "lngId_CurrEduClsStu4Correct">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCurrEduClsStu4CorrectEN GetObjById_CurrEduClsStu4Correct_Cache(long lngId_CurrEduClsStu4Correct)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCurrEduClsStu4CorrectEN._CurrTabName_S);
List<clsvCurrEduClsStu4CorrectEN> arrvCurrEduClsStu4CorrectObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCurrEduClsStu4CorrectEN> arrvCurrEduClsStu4CorrectObjLst_Sel =
from objvCurrEduClsStu4CorrectEN in arrvCurrEduClsStu4CorrectObjLst_Cache
where objvCurrEduClsStu4CorrectEN.Id_CurrEduClsStu4Correct == lngId_CurrEduClsStu4Correct
select objvCurrEduClsStu4CorrectEN;
if (arrvCurrEduClsStu4CorrectObjLst_Sel.Count() == 0)
{
   clsvCurrEduClsStu4CorrectEN obj = clsvCurrEduClsStu4CorrectWApi.GetObjById_CurrEduClsStu4Correct(lngId_CurrEduClsStu4Correct);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCurrEduClsStu4CorrectObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduClsStu4CorrectEN> GetObjLst(string strWhereCond)
{
 List<clsvCurrEduClsStu4CorrectEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsStu4CorrectEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsStu4CorrectEN> GetObjLstById_CurrEduClsStu4CorrectLst(List<long> arrId_CurrEduClsStu4Correct)
{
 List<clsvCurrEduClsStu4CorrectEN> arrObjLst = null; 
string strAction = "GetObjLstById_CurrEduClsStu4CorrectLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CurrEduClsStu4Correct);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsStu4CorrectEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngId_CurrEduClsStu4Correct">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvCurrEduClsStu4CorrectEN> GetObjLstById_CurrEduClsStu4CorrectLst_Cache(List<long> arrId_CurrEduClsStu4Correct)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCurrEduClsStu4CorrectEN._CurrTabName_S);
List<clsvCurrEduClsStu4CorrectEN> arrvCurrEduClsStu4CorrectObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCurrEduClsStu4CorrectEN> arrvCurrEduClsStu4CorrectObjLst_Sel =
from objvCurrEduClsStu4CorrectEN in arrvCurrEduClsStu4CorrectObjLst_Cache
where arrId_CurrEduClsStu4Correct.Contains(objvCurrEduClsStu4CorrectEN.Id_CurrEduClsStu4Correct)
select objvCurrEduClsStu4CorrectEN;
return arrvCurrEduClsStu4CorrectObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduClsStu4CorrectEN> GetObjLstById_CurrEduClsStu4CorrectLst_WA_Cache(List<long> arrId_CurrEduClsStu4Correct)
{
 List<clsvCurrEduClsStu4CorrectEN> arrObjLst = null; 
string strAction = "GetObjLstById_CurrEduClsStu4CorrectLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CurrEduClsStu4Correct);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsStu4CorrectEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsStu4CorrectEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCurrEduClsStu4CorrectEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsStu4CorrectEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsStu4CorrectEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCurrEduClsStu4CorrectEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsStu4CorrectEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsStu4CorrectEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCurrEduClsStu4CorrectEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsStu4CorrectEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsStu4CorrectEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCurrEduClsStu4CorrectEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsStu4CorrectEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngId_CurrEduClsStu4Correct)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_CurrEduClsStu4Correct"] = lngId_CurrEduClsStu4Correct.ToString()
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
 /// <param name = "objvCurrEduClsStu4CorrectENS">源对象</param>
 /// <param name = "objvCurrEduClsStu4CorrectENT">目标对象</param>
 public static void CopyTo(clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectENS, clsvCurrEduClsStu4CorrectEN objvCurrEduClsStu4CorrectENT)
{
try
{
objvCurrEduClsStu4CorrectENT.Id_CurrEduClsStu4Correct = objvCurrEduClsStu4CorrectENS.Id_CurrEduClsStu4Correct; //教学班学生_批改作业流水号
objvCurrEduClsStu4CorrectENT.id_CurrEduCls = objvCurrEduClsStu4CorrectENS.id_CurrEduCls; //当前教学班流水号
objvCurrEduClsStu4CorrectENT.CurrEduClsId = objvCurrEduClsStu4CorrectENS.CurrEduClsId; //当前教学班Id
objvCurrEduClsStu4CorrectENT.EduClsName = objvCurrEduClsStu4CorrectENS.EduClsName; //教学班名称
objvCurrEduClsStu4CorrectENT.CourseId = objvCurrEduClsStu4CorrectENS.CourseId; //课程Id
objvCurrEduClsStu4CorrectENT.CourseCode = objvCurrEduClsStu4CorrectENS.CourseCode; //课程代码
objvCurrEduClsStu4CorrectENT.CourseName = objvCurrEduClsStu4CorrectENS.CourseName; //课程名称
objvCurrEduClsStu4CorrectENT.TeachingSolutionId = objvCurrEduClsStu4CorrectENS.TeachingSolutionId; //教学方案Id
objvCurrEduClsStu4CorrectENT.TeachingSolutionName = objvCurrEduClsStu4CorrectENS.TeachingSolutionName; //教学方案名称
objvCurrEduClsStu4CorrectENT.id_XzCollege = objvCurrEduClsStu4CorrectENS.id_XzCollege; //学院流水号
objvCurrEduClsStu4CorrectENT.CollegeID = objvCurrEduClsStu4CorrectENS.CollegeID; //学院ID
objvCurrEduClsStu4CorrectENT.CollegeName = objvCurrEduClsStu4CorrectENS.CollegeName; //学院名称
objvCurrEduClsStu4CorrectENT.LessonQtyPerWeek = objvCurrEduClsStu4CorrectENS.LessonQtyPerWeek; //周课时数
objvCurrEduClsStu4CorrectENT.Mark = objvCurrEduClsStu4CorrectENS.Mark; //获得学分
objvCurrEduClsStu4CorrectENT.id_UniZone = objvCurrEduClsStu4CorrectENS.id_UniZone; //校区流水号
objvCurrEduClsStu4CorrectENT.GradeBaseName = objvCurrEduClsStu4CorrectENS.GradeBaseName; //年级名称
objvCurrEduClsStu4CorrectENT.IsEffective = objvCurrEduClsStu4CorrectENS.IsEffective; //是否有效
objvCurrEduClsStu4CorrectENT.id_CourseType = objvCurrEduClsStu4CorrectENS.id_CourseType; //课程类型流水号
objvCurrEduClsStu4CorrectENT.CourseTypeID = objvCurrEduClsStu4CorrectENS.CourseTypeID; //课程类型ID
objvCurrEduClsStu4CorrectENT.CourseTypeName = objvCurrEduClsStu4CorrectENS.CourseTypeName; //课程类型名称
objvCurrEduClsStu4CorrectENT.IsDegree = objvCurrEduClsStu4CorrectENS.IsDegree; //是否学位课
objvCurrEduClsStu4CorrectENT.CurrStuNum = objvCurrEduClsStu4CorrectENS.CurrStuNum; //当前学生数
objvCurrEduClsStu4CorrectENT.id_Stu = objvCurrEduClsStu4CorrectENS.id_Stu; //学生流水号
objvCurrEduClsStu4CorrectENT.StuID = objvCurrEduClsStu4CorrectENS.StuID; //学号
objvCurrEduClsStu4CorrectENT.StuName = objvCurrEduClsStu4CorrectENS.StuName; //姓名
objvCurrEduClsStu4CorrectENT.id_Sex = objvCurrEduClsStu4CorrectENS.id_Sex; //性别流水号
objvCurrEduClsStu4CorrectENT.SexDesc = objvCurrEduClsStu4CorrectENS.SexDesc; //性别名称
objvCurrEduClsStu4CorrectENT.MajorID = objvCurrEduClsStu4CorrectENS.MajorID; //专业ID
objvCurrEduClsStu4CorrectENT.MajorName = objvCurrEduClsStu4CorrectENS.MajorName; //专业名称
objvCurrEduClsStu4CorrectENT.id_AdminCls = objvCurrEduClsStu4CorrectENS.id_AdminCls; //行政班流水号
objvCurrEduClsStu4CorrectENT.Birthday = objvCurrEduClsStu4CorrectENS.Birthday; //出生日期
objvCurrEduClsStu4CorrectENT.RightId = objvCurrEduClsStu4CorrectENS.RightId; //权限编号
objvCurrEduClsStu4CorrectENT.RightName = objvCurrEduClsStu4CorrectENS.RightName; //权限名称
objvCurrEduClsStu4CorrectENT.RightTypeId = objvCurrEduClsStu4CorrectENS.RightTypeId; //权限类型编号
objvCurrEduClsStu4CorrectENT.RightTypeName = objvCurrEduClsStu4CorrectENS.RightTypeName; //权限类型名
objvCurrEduClsStu4CorrectENT.FuncModuleId = objvCurrEduClsStu4CorrectENS.FuncModuleId; //功能模块Id
objvCurrEduClsStu4CorrectENT.FuncModuleName = objvCurrEduClsStu4CorrectENS.FuncModuleName; //功能模块名称
objvCurrEduClsStu4CorrectENT.FuncModuleName_Sim = objvCurrEduClsStu4CorrectENS.FuncModuleName_Sim; //功能模块简称
objvCurrEduClsStu4CorrectENT.RightRangeLevelId = objvCurrEduClsStu4CorrectENS.RightRangeLevelId; //权限范围等级Id
objvCurrEduClsStu4CorrectENT.RightRangeLevelName = objvCurrEduClsStu4CorrectENS.RightRangeLevelName; //权限范围等级名称
objvCurrEduClsStu4CorrectENT.SchoolTerm = objvCurrEduClsStu4CorrectENS.SchoolTerm; //学期
objvCurrEduClsStu4CorrectENT.SchoolYear = objvCurrEduClsStu4CorrectENS.SchoolYear; //学年
objvCurrEduClsStu4CorrectENT.ModifyDate = objvCurrEduClsStu4CorrectENS.ModifyDate; //修改日期
objvCurrEduClsStu4CorrectENT.ModifyUserID = objvCurrEduClsStu4CorrectENS.ModifyUserID; //修改人
objvCurrEduClsStu4CorrectENT.Memo = objvCurrEduClsStu4CorrectENS.Memo; //备注
objvCurrEduClsStu4CorrectENT.CollegeName4Stu = objvCurrEduClsStu4CorrectENS.CollegeName4Stu; //CollegeName4Stu
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
public static DataTable ToDataTable(List<clsvCurrEduClsStu4CorrectEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCurrEduClsStu4CorrectEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCurrEduClsStu4CorrectEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCurrEduClsStu4CorrectEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCurrEduClsStu4CorrectEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCurrEduClsStu4CorrectEN.AttributeName)
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
if (clsCurrEduClsStu4CorrectWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsStu4CorrectWApi没有刷新缓存机制(clsCurrEduClsStu4CorrectWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxRightWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRightWApi没有刷新缓存机制(clsQxRightWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxRightRangeLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRightRangeLevelWApi没有刷新缓存机制(clsQxRightRangeLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsQxRightTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRightTypeWApi没有刷新缓存机制(clsQxRightTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsRsProfGradeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsProfGradeWApi没有刷新缓存机制(clsRsProfGradeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsRsAdminGradeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsAdminGradeWApi没有刷新缓存机制(clsRsAdminGradeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelWApi没有刷新缓存机制(clsStudyLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_CurrEduClsStu4Correct");
//if (arrvCurrEduClsStu4CorrectObjLst_Cache == null)
//{
//arrvCurrEduClsStu4CorrectObjLst_Cache = await clsvCurrEduClsStu4CorrectWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCurrEduClsStu4CorrectEN._CurrTabName_S);
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
public static List<clsvCurrEduClsStu4CorrectEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCurrEduClsStu4CorrectEN._CurrTabName_S);
List<clsvCurrEduClsStu4CorrectEN> arrvCurrEduClsStu4CorrectObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCurrEduClsStu4CorrectObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCurrEduClsStu4CorrectEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCurrEduClsStu4Correct.Id_CurrEduClsStu4Correct, Type.GetType("System.Int64"));
objDT.Columns.Add(convCurrEduClsStu4Correct.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.CurrEduClsId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.EduClsName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.TeachingSolutionId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.TeachingSolutionName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.LessonQtyPerWeek, Type.GetType("System.Int16"));
objDT.Columns.Add(convCurrEduClsStu4Correct.Mark, Type.GetType("System.Decimal"));
objDT.Columns.Add(convCurrEduClsStu4Correct.id_UniZone, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.IsEffective, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduClsStu4Correct.id_CourseType, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.CourseTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.CourseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.IsDegree, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduClsStu4Correct.CurrStuNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduClsStu4Correct.id_Stu, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.id_Sex, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.SexDesc, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.id_AdminCls, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.Birthday, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.RightId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.RightName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.RightTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.RightTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.FuncModuleName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.RightRangeLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.RightRangeLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.SchoolTerm, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.SchoolYear, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.ModifyDate, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.ModifyUserID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4Correct.CollegeName4Stu, Type.GetType("System.String"));
foreach (clsvCurrEduClsStu4CorrectEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCurrEduClsStu4Correct.Id_CurrEduClsStu4Correct] = objInFor[convCurrEduClsStu4Correct.Id_CurrEduClsStu4Correct];
objDR[convCurrEduClsStu4Correct.id_CurrEduCls] = objInFor[convCurrEduClsStu4Correct.id_CurrEduCls];
objDR[convCurrEduClsStu4Correct.CurrEduClsId] = objInFor[convCurrEduClsStu4Correct.CurrEduClsId];
objDR[convCurrEduClsStu4Correct.EduClsName] = objInFor[convCurrEduClsStu4Correct.EduClsName];
objDR[convCurrEduClsStu4Correct.CourseId] = objInFor[convCurrEduClsStu4Correct.CourseId];
objDR[convCurrEduClsStu4Correct.CourseCode] = objInFor[convCurrEduClsStu4Correct.CourseCode];
objDR[convCurrEduClsStu4Correct.CourseName] = objInFor[convCurrEduClsStu4Correct.CourseName];
objDR[convCurrEduClsStu4Correct.TeachingSolutionId] = objInFor[convCurrEduClsStu4Correct.TeachingSolutionId];
objDR[convCurrEduClsStu4Correct.TeachingSolutionName] = objInFor[convCurrEduClsStu4Correct.TeachingSolutionName];
objDR[convCurrEduClsStu4Correct.id_XzCollege] = objInFor[convCurrEduClsStu4Correct.id_XzCollege];
objDR[convCurrEduClsStu4Correct.CollegeID] = objInFor[convCurrEduClsStu4Correct.CollegeID];
objDR[convCurrEduClsStu4Correct.CollegeName] = objInFor[convCurrEduClsStu4Correct.CollegeName];
objDR[convCurrEduClsStu4Correct.LessonQtyPerWeek] = objInFor[convCurrEduClsStu4Correct.LessonQtyPerWeek];
objDR[convCurrEduClsStu4Correct.Mark] = objInFor[convCurrEduClsStu4Correct.Mark];
objDR[convCurrEduClsStu4Correct.id_UniZone] = objInFor[convCurrEduClsStu4Correct.id_UniZone];
objDR[convCurrEduClsStu4Correct.GradeBaseName] = objInFor[convCurrEduClsStu4Correct.GradeBaseName];
objDR[convCurrEduClsStu4Correct.IsEffective] = objInFor[convCurrEduClsStu4Correct.IsEffective];
objDR[convCurrEduClsStu4Correct.id_CourseType] = objInFor[convCurrEduClsStu4Correct.id_CourseType];
objDR[convCurrEduClsStu4Correct.CourseTypeID] = objInFor[convCurrEduClsStu4Correct.CourseTypeID];
objDR[convCurrEduClsStu4Correct.CourseTypeName] = objInFor[convCurrEduClsStu4Correct.CourseTypeName];
objDR[convCurrEduClsStu4Correct.IsDegree] = objInFor[convCurrEduClsStu4Correct.IsDegree];
objDR[convCurrEduClsStu4Correct.CurrStuNum] = objInFor[convCurrEduClsStu4Correct.CurrStuNum];
objDR[convCurrEduClsStu4Correct.id_Stu] = objInFor[convCurrEduClsStu4Correct.id_Stu];
objDR[convCurrEduClsStu4Correct.StuID] = objInFor[convCurrEduClsStu4Correct.StuID];
objDR[convCurrEduClsStu4Correct.StuName] = objInFor[convCurrEduClsStu4Correct.StuName];
objDR[convCurrEduClsStu4Correct.id_Sex] = objInFor[convCurrEduClsStu4Correct.id_Sex];
objDR[convCurrEduClsStu4Correct.SexDesc] = objInFor[convCurrEduClsStu4Correct.SexDesc];
objDR[convCurrEduClsStu4Correct.MajorID] = objInFor[convCurrEduClsStu4Correct.MajorID];
objDR[convCurrEduClsStu4Correct.MajorName] = objInFor[convCurrEduClsStu4Correct.MajorName];
objDR[convCurrEduClsStu4Correct.id_AdminCls] = objInFor[convCurrEduClsStu4Correct.id_AdminCls];
objDR[convCurrEduClsStu4Correct.Birthday] = objInFor[convCurrEduClsStu4Correct.Birthday];
objDR[convCurrEduClsStu4Correct.RightId] = objInFor[convCurrEduClsStu4Correct.RightId];
objDR[convCurrEduClsStu4Correct.RightName] = objInFor[convCurrEduClsStu4Correct.RightName];
objDR[convCurrEduClsStu4Correct.RightTypeId] = objInFor[convCurrEduClsStu4Correct.RightTypeId];
objDR[convCurrEduClsStu4Correct.RightTypeName] = objInFor[convCurrEduClsStu4Correct.RightTypeName];
objDR[convCurrEduClsStu4Correct.FuncModuleId] = objInFor[convCurrEduClsStu4Correct.FuncModuleId];
objDR[convCurrEduClsStu4Correct.FuncModuleName] = objInFor[convCurrEduClsStu4Correct.FuncModuleName];
objDR[convCurrEduClsStu4Correct.FuncModuleName_Sim] = objInFor[convCurrEduClsStu4Correct.FuncModuleName_Sim];
objDR[convCurrEduClsStu4Correct.RightRangeLevelId] = objInFor[convCurrEduClsStu4Correct.RightRangeLevelId];
objDR[convCurrEduClsStu4Correct.RightRangeLevelName] = objInFor[convCurrEduClsStu4Correct.RightRangeLevelName];
objDR[convCurrEduClsStu4Correct.SchoolTerm] = objInFor[convCurrEduClsStu4Correct.SchoolTerm];
objDR[convCurrEduClsStu4Correct.SchoolYear] = objInFor[convCurrEduClsStu4Correct.SchoolYear];
objDR[convCurrEduClsStu4Correct.ModifyDate] = objInFor[convCurrEduClsStu4Correct.ModifyDate];
objDR[convCurrEduClsStu4Correct.ModifyUserID] = objInFor[convCurrEduClsStu4Correct.ModifyUserID];
objDR[convCurrEduClsStu4Correct.Memo] = objInFor[convCurrEduClsStu4Correct.Memo];
objDR[convCurrEduClsStu4Correct.CollegeName4Stu] = objInFor[convCurrEduClsStu4Correct.CollegeName4Stu];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}