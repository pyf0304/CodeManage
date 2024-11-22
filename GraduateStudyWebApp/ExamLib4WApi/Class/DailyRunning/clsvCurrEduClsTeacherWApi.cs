
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCurrEduClsTeacherWApi
 表名:vCurrEduClsTeacher(01120128)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:37:58
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
public static class clsvCurrEduClsTeacherWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN Setid_EduClsTeacher(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, long lngid_EduClsTeacher, string strComparisonOp="")
	{
objvCurrEduClsTeacherEN.id_EduClsTeacher = lngid_EduClsTeacher; //教学班老师流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.id_EduClsTeacher) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.id_EduClsTeacher, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.id_EduClsTeacher] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN Setid_CurrEduCls(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CurrEduCls, convCurrEduClsTeacher.id_CurrEduCls);
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convCurrEduClsTeacher.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convCurrEduClsTeacher.id_CurrEduCls);
objvCurrEduClsTeacherEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.id_CurrEduCls) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.id_CurrEduCls, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.id_CurrEduCls] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetCurrEduClsId(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strCurrEduClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, convCurrEduClsTeacher.CurrEduClsId);
objvCurrEduClsTeacherEN.CurrEduClsId = strCurrEduClsId; //当前教学班Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.CurrEduClsId) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.CurrEduClsId, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.CurrEduClsId] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetEduClsName(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduClsName, convCurrEduClsTeacher.EduClsName);
clsCheckSql.CheckFieldLen(strEduClsName, 100, convCurrEduClsTeacher.EduClsName);
objvCurrEduClsTeacherEN.EduClsName = strEduClsName; //教学班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.EduClsName) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.EduClsName, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.EduClsName] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetEduClsTypeId(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strEduClsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduClsTypeId, convCurrEduClsTeacher.EduClsTypeId);
clsCheckSql.CheckFieldLen(strEduClsTypeId, 4, convCurrEduClsTeacher.EduClsTypeId);
clsCheckSql.CheckFieldForeignKey(strEduClsTypeId, 4, convCurrEduClsTeacher.EduClsTypeId);
objvCurrEduClsTeacherEN.EduClsTypeId = strEduClsTypeId; //教学班类型代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.EduClsTypeId) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.EduClsTypeId, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.EduClsTypeId] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetCourseId(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCurrEduClsTeacher.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCurrEduClsTeacher.CourseId);
objvCurrEduClsTeacherEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.CourseId) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.CourseId, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.CourseId] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetCourseCode(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCurrEduClsTeacher.CourseCode);
objvCurrEduClsTeacherEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.CourseCode) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.CourseCode, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.CourseCode] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetCourseName(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCurrEduClsTeacher.CourseName);
objvCurrEduClsTeacherEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.CourseName) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.CourseName, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.CourseName] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetTeachingSolutionId(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strTeachingSolutionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingSolutionId, 8, convCurrEduClsTeacher.TeachingSolutionId);
clsCheckSql.CheckFieldForeignKey(strTeachingSolutionId, 8, convCurrEduClsTeacher.TeachingSolutionId);
objvCurrEduClsTeacherEN.TeachingSolutionId = strTeachingSolutionId; //教学方案Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.TeachingSolutionId) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.TeachingSolutionId, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.TeachingSolutionId] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetTeachingSolutionName(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strTeachingSolutionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingSolutionName, 100, convCurrEduClsTeacher.TeachingSolutionName);
objvCurrEduClsTeacherEN.TeachingSolutionName = strTeachingSolutionName; //教学方案名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.TeachingSolutionName) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.TeachingSolutionName, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.TeachingSolutionName] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN Setid_XzCollege(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convCurrEduClsTeacher.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convCurrEduClsTeacher.id_XzCollege);
objvCurrEduClsTeacherEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.id_XzCollege) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.id_XzCollege, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.id_XzCollege] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetCollegeID(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convCurrEduClsTeacher.CollegeID);
objvCurrEduClsTeacherEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.CollegeID) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.CollegeID, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.CollegeID] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetCollegeName4EduCls(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strCollegeName4EduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName4EduCls, 60, convCurrEduClsTeacher.CollegeName4EduCls);
objvCurrEduClsTeacherEN.CollegeName4EduCls = strCollegeName4EduCls; //学院名_教学班
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.CollegeName4EduCls) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.CollegeName4EduCls, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.CollegeName4EduCls] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN Setid_EduWay(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strid_EduWay, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_EduWay, 4, convCurrEduClsTeacher.id_EduWay);
clsCheckSql.CheckFieldForeignKey(strid_EduWay, 4, convCurrEduClsTeacher.id_EduWay);
objvCurrEduClsTeacherEN.id_EduWay = strid_EduWay; //教学方式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.id_EduWay) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.id_EduWay, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.id_EduWay] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetTotalLessonQty(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, int intTotalLessonQty, string strComparisonOp="")
	{
objvCurrEduClsTeacherEN.TotalLessonQty = intTotalLessonQty; //总课时数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.TotalLessonQty) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.TotalLessonQty, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.TotalLessonQty] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetMaxStuQty(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, int intMaxStuQty, string strComparisonOp="")
	{
objvCurrEduClsTeacherEN.MaxStuQty = intMaxStuQty; //最大学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.MaxStuQty) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.MaxStuQty, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.MaxStuQty] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetWeekQty(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, int intWeekQty, string strComparisonOp="")
	{
objvCurrEduClsTeacherEN.WeekQty = intWeekQty; //总周数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.WeekQty) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.WeekQty, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.WeekQty] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetScheUnitPW(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, short shtScheUnitPW, string strComparisonOp="")
	{
objvCurrEduClsTeacherEN.ScheUnitPW = shtScheUnitPW; //周排课次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.ScheUnitPW) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.ScheUnitPW, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.ScheUnitPW] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetWeekStatusID(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strWeekStatusID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWeekStatusID, 2, convCurrEduClsTeacher.WeekStatusID);
clsCheckSql.CheckFieldForeignKey(strWeekStatusID, 2, convCurrEduClsTeacher.WeekStatusID);
objvCurrEduClsTeacherEN.WeekStatusID = strWeekStatusID; //周状态编号(单,双,全周)
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.WeekStatusID) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.WeekStatusID, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.WeekStatusID] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetCustomerWeek(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strCustomerWeek, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCustomerWeek, 50, convCurrEduClsTeacher.CustomerWeek);
objvCurrEduClsTeacherEN.CustomerWeek = strCustomerWeek; //自定义上课周
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.CustomerWeek) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.CustomerWeek, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.CustomerWeek] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetLessonQtyPerWeek(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, short shtLessonQtyPerWeek, string strComparisonOp="")
	{
objvCurrEduClsTeacherEN.LessonQtyPerWeek = shtLessonQtyPerWeek; //周课时数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.LessonQtyPerWeek) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.LessonQtyPerWeek, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.LessonQtyPerWeek] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN Setid_UniZone(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strid_UniZone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_UniZone, 4, convCurrEduClsTeacher.id_UniZone);
clsCheckSql.CheckFieldForeignKey(strid_UniZone, 4, convCurrEduClsTeacher.id_UniZone);
objvCurrEduClsTeacherEN.id_UniZone = strid_UniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.id_UniZone) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.id_UniZone, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.id_UniZone] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN Setid_GradeBase(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convCurrEduClsTeacher.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convCurrEduClsTeacher.id_GradeBase);
objvCurrEduClsTeacherEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.id_GradeBase) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.id_GradeBase, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.id_GradeBase] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetGradeBaseID(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strGradeBaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseID, 4, convCurrEduClsTeacher.GradeBaseID);
clsCheckSql.CheckFieldForeignKey(strGradeBaseID, 4, convCurrEduClsTeacher.GradeBaseID);
objvCurrEduClsTeacherEN.GradeBaseID = strGradeBaseID; //年级代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.GradeBaseID) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.GradeBaseID, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.GradeBaseID] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetGradeBaseName(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convCurrEduClsTeacher.GradeBaseName);
objvCurrEduClsTeacherEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.GradeBaseName) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.GradeBaseName, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.GradeBaseName] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetIsEffective(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, bool bolIsEffective, string strComparisonOp="")
	{
objvCurrEduClsTeacherEN.IsEffective = bolIsEffective; //是否有效
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.IsEffective) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.IsEffective, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.IsEffective] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN Setid_CourseType(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strid_CourseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CourseType, 4, convCurrEduClsTeacher.id_CourseType);
clsCheckSql.CheckFieldForeignKey(strid_CourseType, 4, convCurrEduClsTeacher.id_CourseType);
objvCurrEduClsTeacherEN.id_CourseType = strid_CourseType; //课程类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.id_CourseType) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.id_CourseType, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.id_CourseType] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetCourseTypeID(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strCourseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseTypeID, 4, convCurrEduClsTeacher.CourseTypeID);
clsCheckSql.CheckFieldForeignKey(strCourseTypeID, 4, convCurrEduClsTeacher.CourseTypeID);
objvCurrEduClsTeacherEN.CourseTypeID = strCourseTypeID; //课程类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.CourseTypeID) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.CourseTypeID, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.CourseTypeID] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetCourseTypeName(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strCourseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseTypeName, 30, convCurrEduClsTeacher.CourseTypeName);
objvCurrEduClsTeacherEN.CourseTypeName = strCourseTypeName; //课程类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.CourseTypeName) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.CourseTypeName, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.CourseTypeName] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetIsDegree(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, bool bolIsDegree, string strComparisonOp="")
	{
objvCurrEduClsTeacherEN.IsDegree = bolIsDegree; //是否学位课
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.IsDegree) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.IsDegree, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.IsDegree] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN Setid_ScoreType(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strid_ScoreType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ScoreType, 4, convCurrEduClsTeacher.id_ScoreType);
clsCheckSql.CheckFieldForeignKey(strid_ScoreType, 4, convCurrEduClsTeacher.id_ScoreType);
objvCurrEduClsTeacherEN.id_ScoreType = strid_ScoreType; //成绩类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.id_ScoreType) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.id_ScoreType, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.id_ScoreType] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetIsProportionalCtrl(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, bool bolIsProportionalCtrl, string strComparisonOp="")
	{
objvCurrEduClsTeacherEN.IsProportionalCtrl = bolIsProportionalCtrl; //是否比例控制
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.IsProportionalCtrl) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.IsProportionalCtrl, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.IsProportionalCtrl] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN Setid_ExamType(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strid_ExamType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ExamType, 4, convCurrEduClsTeacher.id_ExamType);
clsCheckSql.CheckFieldForeignKey(strid_ExamType, 4, convCurrEduClsTeacher.id_ExamType);
objvCurrEduClsTeacherEN.id_ExamType = strid_ExamType; //考试方式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.id_ExamType) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.id_ExamType, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.id_ExamType] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetBeginWeek(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, short shtBeginWeek, string strComparisonOp="")
	{
objvCurrEduClsTeacherEN.BeginWeek = shtBeginWeek; //开始周
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.BeginWeek) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.BeginWeek, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.BeginWeek] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetCurrStuNum_Valid(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, int intCurrStuNum_Valid, string strComparisonOp="")
	{
objvCurrEduClsTeacherEN.CurrStuNum_Valid = intCurrStuNum_Valid; //CurrStuNum_Valid
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.CurrStuNum_Valid) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.CurrStuNum_Valid, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.CurrStuNum_Valid] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetCurrStuNum(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, int intCurrStuNum, string strComparisonOp="")
	{
objvCurrEduClsTeacherEN.CurrStuNum = intCurrStuNum; //当前学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.CurrStuNum) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.CurrStuNum, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.CurrStuNum] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN Setid_Teacher(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strid_Teacher, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Teacher, 8, convCurrEduClsTeacher.id_Teacher);
clsCheckSql.CheckFieldForeignKey(strid_Teacher, 8, convCurrEduClsTeacher.id_Teacher);
objvCurrEduClsTeacherEN.id_Teacher = strid_Teacher; //教师流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.id_Teacher) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.id_Teacher, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.id_Teacher] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetTeacherID(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeacherID, 12, convCurrEduClsTeacher.TeacherID);
objvCurrEduClsTeacherEN.TeacherID = strTeacherID; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.TeacherID) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.TeacherID, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.TeacherID] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetTeacherName(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strTeacherName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeacherName, 50, convCurrEduClsTeacher.TeacherName);
objvCurrEduClsTeacherEN.TeacherName = strTeacherName; //教师姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.TeacherName) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.TeacherName, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.TeacherName] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetBirthday(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strBirthday, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBirthday, 8, convCurrEduClsTeacher.Birthday);
clsCheckSql.CheckFieldForeignKey(strBirthday, 8, convCurrEduClsTeacher.Birthday);
objvCurrEduClsTeacherEN.Birthday = strBirthday; //出生日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.Birthday) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.Birthday, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.Birthday] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetCollegeName(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCurrEduClsTeacher.CollegeName);
objvCurrEduClsTeacherEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.CollegeName) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.CollegeName, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.CollegeName] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetCollegeName4Teacher(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strCollegeName4Teacher, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName4Teacher, 60, convCurrEduClsTeacher.CollegeName4Teacher);
objvCurrEduClsTeacherEN.CollegeName4Teacher = strCollegeName4Teacher; //学院名_教师
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.CollegeName4Teacher) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.CollegeName4Teacher, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.CollegeName4Teacher] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetDegreeName(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDegreeName, 30, convCurrEduClsTeacher.DegreeName);
objvCurrEduClsTeacherEN.DegreeName = strDegreeName; //学位名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.DegreeName) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.DegreeName, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.DegreeName] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN Setid_ProfGrade(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strid_ProfGrade, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ProfGrade, 4, convCurrEduClsTeacher.id_ProfGrade);
clsCheckSql.CheckFieldForeignKey(strid_ProfGrade, 4, convCurrEduClsTeacher.id_ProfGrade);
objvCurrEduClsTeacherEN.id_ProfGrade = strid_ProfGrade; //专业职称流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.id_ProfGrade) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.id_ProfGrade, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.id_ProfGrade] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetProfenssionalGradeName(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strProfenssionalGradeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProfenssionalGradeName, 30, convCurrEduClsTeacher.ProfenssionalGradeName);
objvCurrEduClsTeacherEN.ProfenssionalGradeName = strProfenssionalGradeName; //专业职称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.ProfenssionalGradeName) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.ProfenssionalGradeName, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.ProfenssionalGradeName] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetIsGpUser(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, bool bolIsGpUser, string strComparisonOp="")
	{
objvCurrEduClsTeacherEN.IsGpUser = bolIsGpUser; //是否Gp用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.IsGpUser) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.IsGpUser, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.IsGpUser] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN Setid_Pk2EduClsTeacherType(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strid_Pk2EduClsTeacherType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Pk2EduClsTeacherType, convCurrEduClsTeacher.id_Pk2EduClsTeacherType);
clsCheckSql.CheckFieldLen(strid_Pk2EduClsTeacherType, 4, convCurrEduClsTeacher.id_Pk2EduClsTeacherType);
clsCheckSql.CheckFieldForeignKey(strid_Pk2EduClsTeacherType, 4, convCurrEduClsTeacher.id_Pk2EduClsTeacherType);
objvCurrEduClsTeacherEN.id_Pk2EduClsTeacherType = strid_Pk2EduClsTeacherType; //教学班老师角色(主讲,辅导)流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.id_Pk2EduClsTeacherType) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.id_Pk2EduClsTeacherType, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.id_Pk2EduClsTeacherType] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetEduClsTeacherTypeID(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strEduClsTeacherTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduClsTeacherTypeID, 4, convCurrEduClsTeacher.EduClsTeacherTypeID);
clsCheckSql.CheckFieldForeignKey(strEduClsTeacherTypeID, 4, convCurrEduClsTeacher.EduClsTeacherTypeID);
objvCurrEduClsTeacherEN.EduClsTeacherTypeID = strEduClsTeacherTypeID; //教学班教学类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.EduClsTeacherTypeID) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.EduClsTeacherTypeID, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.EduClsTeacherTypeID] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetEduClsTeacherTypeDesc(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strEduClsTeacherTypeDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduClsTeacherTypeDesc, 20, convCurrEduClsTeacher.EduClsTeacherTypeDesc);
objvCurrEduClsTeacherEN.EduClsTeacherTypeDesc = strEduClsTeacherTypeDesc; //教学班教师类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.EduClsTeacherTypeDesc) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.EduClsTeacherTypeDesc, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.EduClsTeacherTypeDesc] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetSchoolTerm(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, convCurrEduClsTeacher.SchoolTerm);
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, convCurrEduClsTeacher.SchoolTerm);
objvCurrEduClsTeacherEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.SchoolTerm) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.SchoolTerm, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.SchoolTerm] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetSchoolYear(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strSchoolYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, convCurrEduClsTeacher.SchoolYear);
objvCurrEduClsTeacherEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.SchoolYear) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.SchoolYear, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.SchoolYear] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetOpenBeginDate(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strOpenBeginDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOpenBeginDate, 8, convCurrEduClsTeacher.OpenBeginDate);
objvCurrEduClsTeacherEN.OpenBeginDate = strOpenBeginDate; //开放开始日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.OpenBeginDate) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.OpenBeginDate, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.OpenBeginDate] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetOpenEndDate(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strOpenEndDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOpenEndDate, 8, convCurrEduClsTeacher.OpenEndDate);
objvCurrEduClsTeacherEN.OpenEndDate = strOpenEndDate; //开放结束日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.OpenEndDate) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.OpenEndDate, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.OpenEndDate] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetUpdDate(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCurrEduClsTeacher.UpdDate);
objvCurrEduClsTeacherEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.UpdDate) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.UpdDate, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.UpdDate] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetUpdUser(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCurrEduClsTeacher.UpdUser);
objvCurrEduClsTeacherEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.UpdUser) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.UpdUser, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.UpdUser] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetMemo(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCurrEduClsTeacher.Memo);
objvCurrEduClsTeacherEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.Memo) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.Memo, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.Memo] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetEduClsTypeName(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strEduClsTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduClsTypeName, 100, convCurrEduClsTeacher.EduClsTypeName);
objvCurrEduClsTeacherEN.EduClsTypeName = strEduClsTypeName; //教学班类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.EduClsTypeName) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.EduClsTypeName, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.EduClsTypeName] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetExampleImgPath(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strExampleImgPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExampleImgPath, 300, convCurrEduClsTeacher.ExampleImgPath);
objvCurrEduClsTeacherEN.ExampleImgPath = strExampleImgPath; //示例图路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.ExampleImgPath) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.ExampleImgPath, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.ExampleImgPath] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacher_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.id_EduClsTeacher) == true)
{
string strComparisonOp_id_EduClsTeacher = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.id_EduClsTeacher];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsTeacher.id_EduClsTeacher, objvCurrEduClsTeacher_Cond.id_EduClsTeacher, strComparisonOp_id_EduClsTeacher);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.id_CurrEduCls, objvCurrEduClsTeacher_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.CurrEduClsId) == true)
{
string strComparisonOp_CurrEduClsId = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.CurrEduClsId, objvCurrEduClsTeacher_Cond.CurrEduClsId, strComparisonOp_CurrEduClsId);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.EduClsName) == true)
{
string strComparisonOp_EduClsName = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.EduClsName, objvCurrEduClsTeacher_Cond.EduClsName, strComparisonOp_EduClsName);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.EduClsTypeId) == true)
{
string strComparisonOp_EduClsTypeId = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.EduClsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.EduClsTypeId, objvCurrEduClsTeacher_Cond.EduClsTypeId, strComparisonOp_EduClsTypeId);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.CourseId) == true)
{
string strComparisonOp_CourseId = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.CourseId, objvCurrEduClsTeacher_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.CourseCode, objvCurrEduClsTeacher_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.CourseName) == true)
{
string strComparisonOp_CourseName = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.CourseName, objvCurrEduClsTeacher_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.TeachingSolutionId) == true)
{
string strComparisonOp_TeachingSolutionId = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.TeachingSolutionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.TeachingSolutionId, objvCurrEduClsTeacher_Cond.TeachingSolutionId, strComparisonOp_TeachingSolutionId);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.TeachingSolutionName) == true)
{
string strComparisonOp_TeachingSolutionName = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.TeachingSolutionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.TeachingSolutionName, objvCurrEduClsTeacher_Cond.TeachingSolutionName, strComparisonOp_TeachingSolutionName);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.id_XzCollege, objvCurrEduClsTeacher_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.CollegeID, objvCurrEduClsTeacher_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.CollegeName4EduCls) == true)
{
string strComparisonOp_CollegeName4EduCls = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.CollegeName4EduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.CollegeName4EduCls, objvCurrEduClsTeacher_Cond.CollegeName4EduCls, strComparisonOp_CollegeName4EduCls);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.id_EduWay) == true)
{
string strComparisonOp_id_EduWay = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.id_EduWay];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.id_EduWay, objvCurrEduClsTeacher_Cond.id_EduWay, strComparisonOp_id_EduWay);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.TotalLessonQty) == true)
{
string strComparisonOp_TotalLessonQty = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.TotalLessonQty];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsTeacher.TotalLessonQty, objvCurrEduClsTeacher_Cond.TotalLessonQty, strComparisonOp_TotalLessonQty);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.MaxStuQty) == true)
{
string strComparisonOp_MaxStuQty = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.MaxStuQty];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsTeacher.MaxStuQty, objvCurrEduClsTeacher_Cond.MaxStuQty, strComparisonOp_MaxStuQty);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.WeekQty) == true)
{
string strComparisonOp_WeekQty = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.WeekQty];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsTeacher.WeekQty, objvCurrEduClsTeacher_Cond.WeekQty, strComparisonOp_WeekQty);
}
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.WeekStatusID) == true)
{
string strComparisonOp_WeekStatusID = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.WeekStatusID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.WeekStatusID, objvCurrEduClsTeacher_Cond.WeekStatusID, strComparisonOp_WeekStatusID);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.CustomerWeek) == true)
{
string strComparisonOp_CustomerWeek = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.CustomerWeek];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.CustomerWeek, objvCurrEduClsTeacher_Cond.CustomerWeek, strComparisonOp_CustomerWeek);
}
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.id_UniZone) == true)
{
string strComparisonOp_id_UniZone = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.id_UniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.id_UniZone, objvCurrEduClsTeacher_Cond.id_UniZone, strComparisonOp_id_UniZone);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.id_GradeBase, objvCurrEduClsTeacher_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.GradeBaseID) == true)
{
string strComparisonOp_GradeBaseID = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.GradeBaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.GradeBaseID, objvCurrEduClsTeacher_Cond.GradeBaseID, strComparisonOp_GradeBaseID);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.GradeBaseName, objvCurrEduClsTeacher_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.IsEffective) == true)
{
if (objvCurrEduClsTeacher_Cond.IsEffective == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduClsTeacher.IsEffective);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduClsTeacher.IsEffective);
}
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.id_CourseType) == true)
{
string strComparisonOp_id_CourseType = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.id_CourseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.id_CourseType, objvCurrEduClsTeacher_Cond.id_CourseType, strComparisonOp_id_CourseType);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.CourseTypeID) == true)
{
string strComparisonOp_CourseTypeID = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.CourseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.CourseTypeID, objvCurrEduClsTeacher_Cond.CourseTypeID, strComparisonOp_CourseTypeID);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.CourseTypeName) == true)
{
string strComparisonOp_CourseTypeName = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.CourseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.CourseTypeName, objvCurrEduClsTeacher_Cond.CourseTypeName, strComparisonOp_CourseTypeName);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.IsDegree) == true)
{
if (objvCurrEduClsTeacher_Cond.IsDegree == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduClsTeacher.IsDegree);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduClsTeacher.IsDegree);
}
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.id_ScoreType) == true)
{
string strComparisonOp_id_ScoreType = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.id_ScoreType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.id_ScoreType, objvCurrEduClsTeacher_Cond.id_ScoreType, strComparisonOp_id_ScoreType);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.IsProportionalCtrl) == true)
{
if (objvCurrEduClsTeacher_Cond.IsProportionalCtrl == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduClsTeacher.IsProportionalCtrl);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduClsTeacher.IsProportionalCtrl);
}
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.id_ExamType) == true)
{
string strComparisonOp_id_ExamType = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.id_ExamType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.id_ExamType, objvCurrEduClsTeacher_Cond.id_ExamType, strComparisonOp_id_ExamType);
}
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.CurrStuNum_Valid) == true)
{
string strComparisonOp_CurrStuNum_Valid = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.CurrStuNum_Valid];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsTeacher.CurrStuNum_Valid, objvCurrEduClsTeacher_Cond.CurrStuNum_Valid, strComparisonOp_CurrStuNum_Valid);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.CurrStuNum) == true)
{
string strComparisonOp_CurrStuNum = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.CurrStuNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsTeacher.CurrStuNum, objvCurrEduClsTeacher_Cond.CurrStuNum, strComparisonOp_CurrStuNum);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.id_Teacher) == true)
{
string strComparisonOp_id_Teacher = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.id_Teacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.id_Teacher, objvCurrEduClsTeacher_Cond.id_Teacher, strComparisonOp_id_Teacher);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.TeacherID) == true)
{
string strComparisonOp_TeacherID = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.TeacherID, objvCurrEduClsTeacher_Cond.TeacherID, strComparisonOp_TeacherID);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.TeacherName) == true)
{
string strComparisonOp_TeacherName = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.TeacherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.TeacherName, objvCurrEduClsTeacher_Cond.TeacherName, strComparisonOp_TeacherName);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.Birthday) == true)
{
string strComparisonOp_Birthday = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.Birthday];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.Birthday, objvCurrEduClsTeacher_Cond.Birthday, strComparisonOp_Birthday);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.CollegeName, objvCurrEduClsTeacher_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.CollegeName4Teacher) == true)
{
string strComparisonOp_CollegeName4Teacher = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.CollegeName4Teacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.CollegeName4Teacher, objvCurrEduClsTeacher_Cond.CollegeName4Teacher, strComparisonOp_CollegeName4Teacher);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.DegreeName) == true)
{
string strComparisonOp_DegreeName = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.DegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.DegreeName, objvCurrEduClsTeacher_Cond.DegreeName, strComparisonOp_DegreeName);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.id_ProfGrade) == true)
{
string strComparisonOp_id_ProfGrade = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.id_ProfGrade];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.id_ProfGrade, objvCurrEduClsTeacher_Cond.id_ProfGrade, strComparisonOp_id_ProfGrade);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.ProfenssionalGradeName) == true)
{
string strComparisonOp_ProfenssionalGradeName = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.ProfenssionalGradeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.ProfenssionalGradeName, objvCurrEduClsTeacher_Cond.ProfenssionalGradeName, strComparisonOp_ProfenssionalGradeName);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.IsGpUser) == true)
{
if (objvCurrEduClsTeacher_Cond.IsGpUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduClsTeacher.IsGpUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduClsTeacher.IsGpUser);
}
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.id_Pk2EduClsTeacherType) == true)
{
string strComparisonOp_id_Pk2EduClsTeacherType = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.id_Pk2EduClsTeacherType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.id_Pk2EduClsTeacherType, objvCurrEduClsTeacher_Cond.id_Pk2EduClsTeacherType, strComparisonOp_id_Pk2EduClsTeacherType);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.EduClsTeacherTypeID) == true)
{
string strComparisonOp_EduClsTeacherTypeID = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.EduClsTeacherTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.EduClsTeacherTypeID, objvCurrEduClsTeacher_Cond.EduClsTeacherTypeID, strComparisonOp_EduClsTeacherTypeID);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.EduClsTeacherTypeDesc) == true)
{
string strComparisonOp_EduClsTeacherTypeDesc = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.EduClsTeacherTypeDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.EduClsTeacherTypeDesc, objvCurrEduClsTeacher_Cond.EduClsTeacherTypeDesc, strComparisonOp_EduClsTeacherTypeDesc);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.SchoolTerm) == true)
{
string strComparisonOp_SchoolTerm = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.SchoolTerm, objvCurrEduClsTeacher_Cond.SchoolTerm, strComparisonOp_SchoolTerm);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.SchoolYear) == true)
{
string strComparisonOp_SchoolYear = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.SchoolYear, objvCurrEduClsTeacher_Cond.SchoolYear, strComparisonOp_SchoolYear);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.OpenBeginDate) == true)
{
string strComparisonOp_OpenBeginDate = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.OpenBeginDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.OpenBeginDate, objvCurrEduClsTeacher_Cond.OpenBeginDate, strComparisonOp_OpenBeginDate);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.OpenEndDate) == true)
{
string strComparisonOp_OpenEndDate = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.OpenEndDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.OpenEndDate, objvCurrEduClsTeacher_Cond.OpenEndDate, strComparisonOp_OpenEndDate);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.UpdDate, objvCurrEduClsTeacher_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.UpdUser, objvCurrEduClsTeacher_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.Memo) == true)
{
string strComparisonOp_Memo = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.Memo, objvCurrEduClsTeacher_Cond.Memo, strComparisonOp_Memo);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.EduClsTypeName) == true)
{
string strComparisonOp_EduClsTypeName = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.EduClsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.EduClsTypeName, objvCurrEduClsTeacher_Cond.EduClsTypeName, strComparisonOp_EduClsTypeName);
}
if (objvCurrEduClsTeacher_Cond.IsUpdated(convCurrEduClsTeacher.ExampleImgPath) == true)
{
string strComparisonOp_ExampleImgPath = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[convCurrEduClsTeacher.ExampleImgPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.ExampleImgPath, objvCurrEduClsTeacher_Cond.ExampleImgPath, strComparisonOp_ExampleImgPath);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v当前教学班教师(vCurrEduClsTeacher)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCurrEduClsTeacherWApi
{
private static readonly string mstrApiControllerName = "vCurrEduClsTeacherApi";

 public clsvCurrEduClsTeacherWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_EduClsTeacher">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCurrEduClsTeacherEN GetObjByid_EduClsTeacher(long lngid_EduClsTeacher)
{
string strAction = "GetObjByid_EduClsTeacher";
string strErrMsg = string.Empty;
string strResult = "";
clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_EduClsTeacher"] = lngid_EduClsTeacher.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCurrEduClsTeacherEN = JsonConvert.DeserializeObject<clsvCurrEduClsTeacherEN>((string)jobjReturn["ReturnObj"]);
return objvCurrEduClsTeacherEN;
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
 /// <param name = "lngid_EduClsTeacher">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCurrEduClsTeacherEN GetObjByid_EduClsTeacher_WA_Cache(long lngid_EduClsTeacher, string strid_CurrEduCls)
{
string strAction = "GetObjByid_EduClsTeacher_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_EduClsTeacher"] = lngid_EduClsTeacher.ToString(),
["id_CurrEduCls"] = strid_CurrEduCls
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCurrEduClsTeacherEN = JsonConvert.DeserializeObject<clsvCurrEduClsTeacherEN>((string)jobjReturn["ReturnObj"]);
return objvCurrEduClsTeacherEN;
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
public static clsvCurrEduClsTeacherEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN = null;
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
objvCurrEduClsTeacherEN = JsonConvert.DeserializeObject<clsvCurrEduClsTeacherEN>((string)jobjReturn["ReturnObj"]);
return objvCurrEduClsTeacherEN;
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
 /// <param name = "lngid_EduClsTeacher">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCurrEduClsTeacherEN GetObjByid_EduClsTeacher_Cache(long lngid_EduClsTeacher, string strid_CurrEduCls)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvCurrEduClsTeacherEN._CurrTabName_S, strid_CurrEduCls);
List<clsvCurrEduClsTeacherEN> arrvCurrEduClsTeacherObjLst_Cache = GetObjLst_Cache(strid_CurrEduCls);
IEnumerable <clsvCurrEduClsTeacherEN> arrvCurrEduClsTeacherObjLst_Sel =
from objvCurrEduClsTeacherEN in arrvCurrEduClsTeacherObjLst_Cache
where objvCurrEduClsTeacherEN.id_EduClsTeacher == lngid_EduClsTeacher
select objvCurrEduClsTeacherEN;
if (arrvCurrEduClsTeacherObjLst_Sel.Count() == 0)
{
   clsvCurrEduClsTeacherEN obj = clsvCurrEduClsTeacherWApi.GetObjByid_EduClsTeacher(lngid_EduClsTeacher);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCurrEduClsTeacherObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduClsTeacherEN> GetObjLst(string strWhereCond)
{
 List<clsvCurrEduClsTeacherEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsTeacherEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsTeacherEN> GetObjLstById_EduClsTeacherLst(List<long> arrId_EduClsTeacher)
{
 List<clsvCurrEduClsTeacherEN> arrObjLst = null; 
string strAction = "GetObjLstById_EduClsTeacherLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_EduClsTeacher);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsTeacherEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_EduClsTeacher">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvCurrEduClsTeacherEN> GetObjLstById_EduClsTeacherLst_Cache(List<long> arrId_EduClsTeacher, string strid_CurrEduCls)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvCurrEduClsTeacherEN._CurrTabName_S, strid_CurrEduCls);
List<clsvCurrEduClsTeacherEN> arrvCurrEduClsTeacherObjLst_Cache = GetObjLst_Cache(strid_CurrEduCls);
IEnumerable <clsvCurrEduClsTeacherEN> arrvCurrEduClsTeacherObjLst_Sel =
from objvCurrEduClsTeacherEN in arrvCurrEduClsTeacherObjLst_Cache
where arrId_EduClsTeacher.Contains(objvCurrEduClsTeacherEN.id_EduClsTeacher)
select objvCurrEduClsTeacherEN;
return arrvCurrEduClsTeacherObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduClsTeacherEN> GetObjLstById_EduClsTeacherLst_WA_Cache(List<long> arrId_EduClsTeacher, string strid_CurrEduCls)
{
 List<clsvCurrEduClsTeacherEN> arrObjLst = null; 
string strAction = "GetObjLstById_EduClsTeacherLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CurrEduCls"] = strid_CurrEduCls
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_EduClsTeacher);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsTeacherEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsTeacherEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCurrEduClsTeacherEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsTeacherEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsTeacherEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCurrEduClsTeacherEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsTeacherEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsTeacherEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCurrEduClsTeacherEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsTeacherEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsTeacherEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCurrEduClsTeacherEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsTeacherEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_EduClsTeacher)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_EduClsTeacher"] = lngid_EduClsTeacher.ToString()
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
 /// <param name = "objvCurrEduClsTeacherENS">源对象</param>
 /// <param name = "objvCurrEduClsTeacherENT">目标对象</param>
 public static void CopyTo(clsvCurrEduClsTeacherEN objvCurrEduClsTeacherENS, clsvCurrEduClsTeacherEN objvCurrEduClsTeacherENT)
{
try
{
objvCurrEduClsTeacherENT.id_EduClsTeacher = objvCurrEduClsTeacherENS.id_EduClsTeacher; //教学班老师流水号
objvCurrEduClsTeacherENT.id_CurrEduCls = objvCurrEduClsTeacherENS.id_CurrEduCls; //当前教学班流水号
objvCurrEduClsTeacherENT.CurrEduClsId = objvCurrEduClsTeacherENS.CurrEduClsId; //当前教学班Id
objvCurrEduClsTeacherENT.EduClsName = objvCurrEduClsTeacherENS.EduClsName; //教学班名称
objvCurrEduClsTeacherENT.EduClsTypeId = objvCurrEduClsTeacherENS.EduClsTypeId; //教学班类型代号
objvCurrEduClsTeacherENT.CourseId = objvCurrEduClsTeacherENS.CourseId; //课程Id
objvCurrEduClsTeacherENT.CourseCode = objvCurrEduClsTeacherENS.CourseCode; //课程代码
objvCurrEduClsTeacherENT.CourseName = objvCurrEduClsTeacherENS.CourseName; //课程名称
objvCurrEduClsTeacherENT.TeachingSolutionId = objvCurrEduClsTeacherENS.TeachingSolutionId; //教学方案Id
objvCurrEduClsTeacherENT.TeachingSolutionName = objvCurrEduClsTeacherENS.TeachingSolutionName; //教学方案名称
objvCurrEduClsTeacherENT.id_XzCollege = objvCurrEduClsTeacherENS.id_XzCollege; //学院流水号
objvCurrEduClsTeacherENT.CollegeID = objvCurrEduClsTeacherENS.CollegeID; //学院ID
objvCurrEduClsTeacherENT.CollegeName4EduCls = objvCurrEduClsTeacherENS.CollegeName4EduCls; //学院名_教学班
objvCurrEduClsTeacherENT.id_EduWay = objvCurrEduClsTeacherENS.id_EduWay; //教学方式流水号
objvCurrEduClsTeacherENT.TotalLessonQty = objvCurrEduClsTeacherENS.TotalLessonQty; //总课时数
objvCurrEduClsTeacherENT.MaxStuQty = objvCurrEduClsTeacherENS.MaxStuQty; //最大学生数
objvCurrEduClsTeacherENT.WeekQty = objvCurrEduClsTeacherENS.WeekQty; //总周数
objvCurrEduClsTeacherENT.ScheUnitPW = objvCurrEduClsTeacherENS.ScheUnitPW; //周排课次数
objvCurrEduClsTeacherENT.WeekStatusID = objvCurrEduClsTeacherENS.WeekStatusID; //周状态编号(单,双,全周)
objvCurrEduClsTeacherENT.CustomerWeek = objvCurrEduClsTeacherENS.CustomerWeek; //自定义上课周
objvCurrEduClsTeacherENT.LessonQtyPerWeek = objvCurrEduClsTeacherENS.LessonQtyPerWeek; //周课时数
objvCurrEduClsTeacherENT.id_UniZone = objvCurrEduClsTeacherENS.id_UniZone; //校区流水号
objvCurrEduClsTeacherENT.id_GradeBase = objvCurrEduClsTeacherENS.id_GradeBase; //年级流水号
objvCurrEduClsTeacherENT.GradeBaseID = objvCurrEduClsTeacherENS.GradeBaseID; //年级代号
objvCurrEduClsTeacherENT.GradeBaseName = objvCurrEduClsTeacherENS.GradeBaseName; //年级名称
objvCurrEduClsTeacherENT.IsEffective = objvCurrEduClsTeacherENS.IsEffective; //是否有效
objvCurrEduClsTeacherENT.id_CourseType = objvCurrEduClsTeacherENS.id_CourseType; //课程类型流水号
objvCurrEduClsTeacherENT.CourseTypeID = objvCurrEduClsTeacherENS.CourseTypeID; //课程类型ID
objvCurrEduClsTeacherENT.CourseTypeName = objvCurrEduClsTeacherENS.CourseTypeName; //课程类型名称
objvCurrEduClsTeacherENT.IsDegree = objvCurrEduClsTeacherENS.IsDegree; //是否学位课
objvCurrEduClsTeacherENT.id_ScoreType = objvCurrEduClsTeacherENS.id_ScoreType; //成绩类型流水号
objvCurrEduClsTeacherENT.IsProportionalCtrl = objvCurrEduClsTeacherENS.IsProportionalCtrl; //是否比例控制
objvCurrEduClsTeacherENT.id_ExamType = objvCurrEduClsTeacherENS.id_ExamType; //考试方式流水号
objvCurrEduClsTeacherENT.BeginWeek = objvCurrEduClsTeacherENS.BeginWeek; //开始周
objvCurrEduClsTeacherENT.CurrStuNum_Valid = objvCurrEduClsTeacherENS.CurrStuNum_Valid; //CurrStuNum_Valid
objvCurrEduClsTeacherENT.CurrStuNum = objvCurrEduClsTeacherENS.CurrStuNum; //当前学生数
objvCurrEduClsTeacherENT.id_Teacher = objvCurrEduClsTeacherENS.id_Teacher; //教师流水号
objvCurrEduClsTeacherENT.TeacherID = objvCurrEduClsTeacherENS.TeacherID; //教师工号
objvCurrEduClsTeacherENT.TeacherName = objvCurrEduClsTeacherENS.TeacherName; //教师姓名
objvCurrEduClsTeacherENT.Birthday = objvCurrEduClsTeacherENS.Birthday; //出生日期
objvCurrEduClsTeacherENT.CollegeName = objvCurrEduClsTeacherENS.CollegeName; //学院名称
objvCurrEduClsTeacherENT.CollegeName4Teacher = objvCurrEduClsTeacherENS.CollegeName4Teacher; //学院名_教师
objvCurrEduClsTeacherENT.DegreeName = objvCurrEduClsTeacherENS.DegreeName; //学位名称
objvCurrEduClsTeacherENT.id_ProfGrade = objvCurrEduClsTeacherENS.id_ProfGrade; //专业职称流水号
objvCurrEduClsTeacherENT.ProfenssionalGradeName = objvCurrEduClsTeacherENS.ProfenssionalGradeName; //专业职称
objvCurrEduClsTeacherENT.IsGpUser = objvCurrEduClsTeacherENS.IsGpUser; //是否Gp用户
objvCurrEduClsTeacherENT.id_Pk2EduClsTeacherType = objvCurrEduClsTeacherENS.id_Pk2EduClsTeacherType; //教学班老师角色(主讲,辅导)流水号
objvCurrEduClsTeacherENT.EduClsTeacherTypeID = objvCurrEduClsTeacherENS.EduClsTeacherTypeID; //教学班教学类型ID
objvCurrEduClsTeacherENT.EduClsTeacherTypeDesc = objvCurrEduClsTeacherENS.EduClsTeacherTypeDesc; //教学班教师类型名
objvCurrEduClsTeacherENT.SchoolTerm = objvCurrEduClsTeacherENS.SchoolTerm; //学期
objvCurrEduClsTeacherENT.SchoolYear = objvCurrEduClsTeacherENS.SchoolYear; //学年
objvCurrEduClsTeacherENT.OpenBeginDate = objvCurrEduClsTeacherENS.OpenBeginDate; //开放开始日期
objvCurrEduClsTeacherENT.OpenEndDate = objvCurrEduClsTeacherENS.OpenEndDate; //开放结束日期
objvCurrEduClsTeacherENT.UpdDate = objvCurrEduClsTeacherENS.UpdDate; //修改日期
objvCurrEduClsTeacherENT.UpdUser = objvCurrEduClsTeacherENS.UpdUser; //修改人
objvCurrEduClsTeacherENT.Memo = objvCurrEduClsTeacherENS.Memo; //备注
objvCurrEduClsTeacherENT.EduClsTypeName = objvCurrEduClsTeacherENS.EduClsTypeName; //教学班类型名称
objvCurrEduClsTeacherENT.ExampleImgPath = objvCurrEduClsTeacherENS.ExampleImgPath; //示例图路径
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
public static DataTable ToDataTable(List<clsvCurrEduClsTeacherEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCurrEduClsTeacherEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCurrEduClsTeacherEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCurrEduClsTeacherEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCurrEduClsTeacherEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCurrEduClsTeacherEN.AttributeName)
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
if (clsCurrEduClsTeacherWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsTeacherWApi没有刷新缓存机制(clsCurrEduClsTeacherWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPk2EduClsTeacherTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPk2EduClsTeacherTypeWApi没有刷新缓存机制(clsPk2EduClsTeacherTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeWApi没有刷新缓存机制(clscc_CourseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_EduClsTeacher");
//if (arrvCurrEduClsTeacherObjLst_Cache == null)
//{
//arrvCurrEduClsTeacherObjLst_Cache = await clsvCurrEduClsTeacherWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsvCurrEduClsTeacherEN._CurrTabName_S, strid_CurrEduCls);
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
public static List<clsvCurrEduClsTeacherEN> GetObjLst_Cache(string strid_CurrEduCls)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvCurrEduClsTeacherEN._CurrTabName_S, strid_CurrEduCls);
List<clsvCurrEduClsTeacherEN> arrvCurrEduClsTeacherObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("id_CurrEduCls='{0}'", strid_CurrEduCls)); });
return arrvCurrEduClsTeacherObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCurrEduClsTeacherEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCurrEduClsTeacher.id_EduClsTeacher, Type.GetType("System.Int64"));
objDT.Columns.Add(convCurrEduClsTeacher.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.CurrEduClsId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.EduClsName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.EduClsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.TeachingSolutionId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.TeachingSolutionName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.CollegeName4EduCls, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.id_EduWay, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.TotalLessonQty, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduClsTeacher.MaxStuQty, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduClsTeacher.WeekQty, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduClsTeacher.ScheUnitPW, Type.GetType("System.Int16"));
objDT.Columns.Add(convCurrEduClsTeacher.WeekStatusID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.CustomerWeek, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.LessonQtyPerWeek, Type.GetType("System.Int16"));
objDT.Columns.Add(convCurrEduClsTeacher.id_UniZone, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.GradeBaseID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.IsEffective, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduClsTeacher.id_CourseType, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.CourseTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.CourseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.IsDegree, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduClsTeacher.id_ScoreType, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.IsProportionalCtrl, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduClsTeacher.id_ExamType, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.BeginWeek, Type.GetType("System.Int16"));
objDT.Columns.Add(convCurrEduClsTeacher.CurrStuNum_Valid, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduClsTeacher.CurrStuNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduClsTeacher.id_Teacher, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.TeacherID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.TeacherName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.Birthday, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.CollegeName4Teacher, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.DegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.id_ProfGrade, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.ProfenssionalGradeName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.IsGpUser, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduClsTeacher.id_Pk2EduClsTeacherType, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.EduClsTeacherTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.EduClsTeacherTypeDesc, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.SchoolTerm, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.SchoolYear, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.OpenBeginDate, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.OpenEndDate, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.EduClsTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher.ExampleImgPath, Type.GetType("System.String"));
foreach (clsvCurrEduClsTeacherEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCurrEduClsTeacher.id_EduClsTeacher] = objInFor[convCurrEduClsTeacher.id_EduClsTeacher];
objDR[convCurrEduClsTeacher.id_CurrEduCls] = objInFor[convCurrEduClsTeacher.id_CurrEduCls];
objDR[convCurrEduClsTeacher.CurrEduClsId] = objInFor[convCurrEduClsTeacher.CurrEduClsId];
objDR[convCurrEduClsTeacher.EduClsName] = objInFor[convCurrEduClsTeacher.EduClsName];
objDR[convCurrEduClsTeacher.EduClsTypeId] = objInFor[convCurrEduClsTeacher.EduClsTypeId];
objDR[convCurrEduClsTeacher.CourseId] = objInFor[convCurrEduClsTeacher.CourseId];
objDR[convCurrEduClsTeacher.CourseCode] = objInFor[convCurrEduClsTeacher.CourseCode];
objDR[convCurrEduClsTeacher.CourseName] = objInFor[convCurrEduClsTeacher.CourseName];
objDR[convCurrEduClsTeacher.TeachingSolutionId] = objInFor[convCurrEduClsTeacher.TeachingSolutionId];
objDR[convCurrEduClsTeacher.TeachingSolutionName] = objInFor[convCurrEduClsTeacher.TeachingSolutionName];
objDR[convCurrEduClsTeacher.id_XzCollege] = objInFor[convCurrEduClsTeacher.id_XzCollege];
objDR[convCurrEduClsTeacher.CollegeID] = objInFor[convCurrEduClsTeacher.CollegeID];
objDR[convCurrEduClsTeacher.CollegeName4EduCls] = objInFor[convCurrEduClsTeacher.CollegeName4EduCls];
objDR[convCurrEduClsTeacher.id_EduWay] = objInFor[convCurrEduClsTeacher.id_EduWay];
objDR[convCurrEduClsTeacher.TotalLessonQty] = objInFor[convCurrEduClsTeacher.TotalLessonQty];
objDR[convCurrEduClsTeacher.MaxStuQty] = objInFor[convCurrEduClsTeacher.MaxStuQty];
objDR[convCurrEduClsTeacher.WeekQty] = objInFor[convCurrEduClsTeacher.WeekQty];
objDR[convCurrEduClsTeacher.ScheUnitPW] = objInFor[convCurrEduClsTeacher.ScheUnitPW];
objDR[convCurrEduClsTeacher.WeekStatusID] = objInFor[convCurrEduClsTeacher.WeekStatusID];
objDR[convCurrEduClsTeacher.CustomerWeek] = objInFor[convCurrEduClsTeacher.CustomerWeek];
objDR[convCurrEduClsTeacher.LessonQtyPerWeek] = objInFor[convCurrEduClsTeacher.LessonQtyPerWeek];
objDR[convCurrEduClsTeacher.id_UniZone] = objInFor[convCurrEduClsTeacher.id_UniZone];
objDR[convCurrEduClsTeacher.id_GradeBase] = objInFor[convCurrEduClsTeacher.id_GradeBase];
objDR[convCurrEduClsTeacher.GradeBaseID] = objInFor[convCurrEduClsTeacher.GradeBaseID];
objDR[convCurrEduClsTeacher.GradeBaseName] = objInFor[convCurrEduClsTeacher.GradeBaseName];
objDR[convCurrEduClsTeacher.IsEffective] = objInFor[convCurrEduClsTeacher.IsEffective];
objDR[convCurrEduClsTeacher.id_CourseType] = objInFor[convCurrEduClsTeacher.id_CourseType];
objDR[convCurrEduClsTeacher.CourseTypeID] = objInFor[convCurrEduClsTeacher.CourseTypeID];
objDR[convCurrEduClsTeacher.CourseTypeName] = objInFor[convCurrEduClsTeacher.CourseTypeName];
objDR[convCurrEduClsTeacher.IsDegree] = objInFor[convCurrEduClsTeacher.IsDegree];
objDR[convCurrEduClsTeacher.id_ScoreType] = objInFor[convCurrEduClsTeacher.id_ScoreType];
objDR[convCurrEduClsTeacher.IsProportionalCtrl] = objInFor[convCurrEduClsTeacher.IsProportionalCtrl];
objDR[convCurrEduClsTeacher.id_ExamType] = objInFor[convCurrEduClsTeacher.id_ExamType];
objDR[convCurrEduClsTeacher.BeginWeek] = objInFor[convCurrEduClsTeacher.BeginWeek];
objDR[convCurrEduClsTeacher.CurrStuNum_Valid] = objInFor[convCurrEduClsTeacher.CurrStuNum_Valid];
objDR[convCurrEduClsTeacher.CurrStuNum] = objInFor[convCurrEduClsTeacher.CurrStuNum];
objDR[convCurrEduClsTeacher.id_Teacher] = objInFor[convCurrEduClsTeacher.id_Teacher];
objDR[convCurrEduClsTeacher.TeacherID] = objInFor[convCurrEduClsTeacher.TeacherID];
objDR[convCurrEduClsTeacher.TeacherName] = objInFor[convCurrEduClsTeacher.TeacherName];
objDR[convCurrEduClsTeacher.Birthday] = objInFor[convCurrEduClsTeacher.Birthday];
objDR[convCurrEduClsTeacher.CollegeName] = objInFor[convCurrEduClsTeacher.CollegeName];
objDR[convCurrEduClsTeacher.CollegeName4Teacher] = objInFor[convCurrEduClsTeacher.CollegeName4Teacher];
objDR[convCurrEduClsTeacher.DegreeName] = objInFor[convCurrEduClsTeacher.DegreeName];
objDR[convCurrEduClsTeacher.id_ProfGrade] = objInFor[convCurrEduClsTeacher.id_ProfGrade];
objDR[convCurrEduClsTeacher.ProfenssionalGradeName] = objInFor[convCurrEduClsTeacher.ProfenssionalGradeName];
objDR[convCurrEduClsTeacher.IsGpUser] = objInFor[convCurrEduClsTeacher.IsGpUser];
objDR[convCurrEduClsTeacher.id_Pk2EduClsTeacherType] = objInFor[convCurrEduClsTeacher.id_Pk2EduClsTeacherType];
objDR[convCurrEduClsTeacher.EduClsTeacherTypeID] = objInFor[convCurrEduClsTeacher.EduClsTeacherTypeID];
objDR[convCurrEduClsTeacher.EduClsTeacherTypeDesc] = objInFor[convCurrEduClsTeacher.EduClsTeacherTypeDesc];
objDR[convCurrEduClsTeacher.SchoolTerm] = objInFor[convCurrEduClsTeacher.SchoolTerm];
objDR[convCurrEduClsTeacher.SchoolYear] = objInFor[convCurrEduClsTeacher.SchoolYear];
objDR[convCurrEduClsTeacher.OpenBeginDate] = objInFor[convCurrEduClsTeacher.OpenBeginDate];
objDR[convCurrEduClsTeacher.OpenEndDate] = objInFor[convCurrEduClsTeacher.OpenEndDate];
objDR[convCurrEduClsTeacher.UpdDate] = objInFor[convCurrEduClsTeacher.UpdDate];
objDR[convCurrEduClsTeacher.UpdUser] = objInFor[convCurrEduClsTeacher.UpdUser];
objDR[convCurrEduClsTeacher.Memo] = objInFor[convCurrEduClsTeacher.Memo];
objDR[convCurrEduClsTeacher.EduClsTypeName] = objInFor[convCurrEduClsTeacher.EduClsTypeName];
objDR[convCurrEduClsTeacher.ExampleImgPath] = objInFor[convCurrEduClsTeacher.ExampleImgPath];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}