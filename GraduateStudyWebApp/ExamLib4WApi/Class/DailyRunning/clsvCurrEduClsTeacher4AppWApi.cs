
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCurrEduClsTeacher4AppWApi
 表名:vCurrEduClsTeacher4App(01120259)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:48:28
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
public static class clsvCurrEduClsTeacher4AppWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN Setid_EduClsTeacher(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, long lngid_EduClsTeacher, string strComparisonOp="")
	{
objvCurrEduClsTeacher4AppEN.id_EduClsTeacher = lngid_EduClsTeacher; //教学班老师流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.id_EduClsTeacher) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.id_EduClsTeacher, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.id_EduClsTeacher] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN Setid_CurrEduCls(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convCurrEduClsTeacher4App.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convCurrEduClsTeacher4App.id_CurrEduCls);
objvCurrEduClsTeacher4AppEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.id_CurrEduCls) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.id_CurrEduCls, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.id_CurrEduCls] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetCurrEduClsId(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strCurrEduClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, convCurrEduClsTeacher4App.CurrEduClsId);
objvCurrEduClsTeacher4AppEN.CurrEduClsId = strCurrEduClsId; //当前教学班Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.CurrEduClsId) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.CurrEduClsId, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.CurrEduClsId] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetEduClsName(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convCurrEduClsTeacher4App.EduClsName);
objvCurrEduClsTeacher4AppEN.EduClsName = strEduClsName; //教学班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.EduClsName) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.EduClsName, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.EduClsName] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetEduClsTypeId(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strEduClsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduClsTypeId, 4, convCurrEduClsTeacher4App.EduClsTypeId);
clsCheckSql.CheckFieldForeignKey(strEduClsTypeId, 4, convCurrEduClsTeacher4App.EduClsTypeId);
objvCurrEduClsTeacher4AppEN.EduClsTypeId = strEduClsTypeId; //教学班类型代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.EduClsTypeId) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.EduClsTypeId, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.EduClsTypeId] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetCourseId(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCurrEduClsTeacher4App.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCurrEduClsTeacher4App.CourseId);
objvCurrEduClsTeacher4AppEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.CourseId) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.CourseId, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.CourseId] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetCourseCode(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCurrEduClsTeacher4App.CourseCode);
objvCurrEduClsTeacher4AppEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.CourseCode) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.CourseCode, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.CourseCode] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetCourseName(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCurrEduClsTeacher4App.CourseName);
objvCurrEduClsTeacher4AppEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.CourseName) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.CourseName, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.CourseName] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetExampleImgPath(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strExampleImgPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExampleImgPath, 300, convCurrEduClsTeacher4App.ExampleImgPath);
objvCurrEduClsTeacher4AppEN.ExampleImgPath = strExampleImgPath; //示例图路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.ExampleImgPath) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.ExampleImgPath, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.ExampleImgPath] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetTeachingSolutionId(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strTeachingSolutionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingSolutionId, 8, convCurrEduClsTeacher4App.TeachingSolutionId);
clsCheckSql.CheckFieldForeignKey(strTeachingSolutionId, 8, convCurrEduClsTeacher4App.TeachingSolutionId);
objvCurrEduClsTeacher4AppEN.TeachingSolutionId = strTeachingSolutionId; //教学方案Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.TeachingSolutionId) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.TeachingSolutionId, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.TeachingSolutionId] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetTeachingSolutionName(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strTeachingSolutionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingSolutionName, 100, convCurrEduClsTeacher4App.TeachingSolutionName);
objvCurrEduClsTeacher4AppEN.TeachingSolutionName = strTeachingSolutionName; //教学方案名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.TeachingSolutionName) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.TeachingSolutionName, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.TeachingSolutionName] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN Setid_XzCollege(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convCurrEduClsTeacher4App.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convCurrEduClsTeacher4App.id_XzCollege);
objvCurrEduClsTeacher4AppEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.id_XzCollege) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.id_XzCollege, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.id_XzCollege] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetCollegeID(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convCurrEduClsTeacher4App.CollegeID);
objvCurrEduClsTeacher4AppEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.CollegeID) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.CollegeID, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.CollegeID] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetTotalLessonQty(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, int intTotalLessonQty, string strComparisonOp="")
	{
objvCurrEduClsTeacher4AppEN.TotalLessonQty = intTotalLessonQty; //总课时数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.TotalLessonQty) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.TotalLessonQty, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.TotalLessonQty] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetMaxStuQty(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, int intMaxStuQty, string strComparisonOp="")
	{
objvCurrEduClsTeacher4AppEN.MaxStuQty = intMaxStuQty; //最大学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.MaxStuQty) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.MaxStuQty, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.MaxStuQty] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetWeekQty(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, int intWeekQty, string strComparisonOp="")
	{
objvCurrEduClsTeacher4AppEN.WeekQty = intWeekQty; //总周数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.WeekQty) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.WeekQty, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.WeekQty] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetScheUnitPW(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, short shtScheUnitPW, string strComparisonOp="")
	{
objvCurrEduClsTeacher4AppEN.ScheUnitPW = shtScheUnitPW; //周排课次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.ScheUnitPW) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.ScheUnitPW, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.ScheUnitPW] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetWeekStatusID(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strWeekStatusID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWeekStatusID, 2, convCurrEduClsTeacher4App.WeekStatusID);
clsCheckSql.CheckFieldForeignKey(strWeekStatusID, 2, convCurrEduClsTeacher4App.WeekStatusID);
objvCurrEduClsTeacher4AppEN.WeekStatusID = strWeekStatusID; //周状态编号(单,双,全周)
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.WeekStatusID) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.WeekStatusID, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.WeekStatusID] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetCustomerWeek(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strCustomerWeek, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCustomerWeek, 50, convCurrEduClsTeacher4App.CustomerWeek);
objvCurrEduClsTeacher4AppEN.CustomerWeek = strCustomerWeek; //自定义上课周
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.CustomerWeek) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.CustomerWeek, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.CustomerWeek] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetLessonQtyPerWeek(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, short shtLessonQtyPerWeek, string strComparisonOp="")
	{
objvCurrEduClsTeacher4AppEN.LessonQtyPerWeek = shtLessonQtyPerWeek; //周课时数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.LessonQtyPerWeek) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.LessonQtyPerWeek, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.LessonQtyPerWeek] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN Setid_UniZone(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strid_UniZone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_UniZone, 4, convCurrEduClsTeacher4App.id_UniZone);
clsCheckSql.CheckFieldForeignKey(strid_UniZone, 4, convCurrEduClsTeacher4App.id_UniZone);
objvCurrEduClsTeacher4AppEN.id_UniZone = strid_UniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.id_UniZone) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.id_UniZone, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.id_UniZone] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN Setid_GradeBase(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convCurrEduClsTeacher4App.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convCurrEduClsTeacher4App.id_GradeBase);
objvCurrEduClsTeacher4AppEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.id_GradeBase) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.id_GradeBase, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.id_GradeBase] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetGradeBaseID(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strGradeBaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseID, 4, convCurrEduClsTeacher4App.GradeBaseID);
clsCheckSql.CheckFieldForeignKey(strGradeBaseID, 4, convCurrEduClsTeacher4App.GradeBaseID);
objvCurrEduClsTeacher4AppEN.GradeBaseID = strGradeBaseID; //年级代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.GradeBaseID) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.GradeBaseID, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.GradeBaseID] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetGradeBaseName(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convCurrEduClsTeacher4App.GradeBaseName);
objvCurrEduClsTeacher4AppEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.GradeBaseName) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.GradeBaseName, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.GradeBaseName] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetIsEffective(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, bool bolIsEffective, string strComparisonOp="")
	{
objvCurrEduClsTeacher4AppEN.IsEffective = bolIsEffective; //是否有效
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.IsEffective) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.IsEffective, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.IsEffective] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN Setid_CourseType(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strid_CourseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CourseType, 4, convCurrEduClsTeacher4App.id_CourseType);
clsCheckSql.CheckFieldForeignKey(strid_CourseType, 4, convCurrEduClsTeacher4App.id_CourseType);
objvCurrEduClsTeacher4AppEN.id_CourseType = strid_CourseType; //课程类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.id_CourseType) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.id_CourseType, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.id_CourseType] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetCourseTypeID(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strCourseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseTypeID, 4, convCurrEduClsTeacher4App.CourseTypeID);
clsCheckSql.CheckFieldForeignKey(strCourseTypeID, 4, convCurrEduClsTeacher4App.CourseTypeID);
objvCurrEduClsTeacher4AppEN.CourseTypeID = strCourseTypeID; //课程类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.CourseTypeID) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.CourseTypeID, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.CourseTypeID] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetCourseTypeName(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strCourseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseTypeName, 30, convCurrEduClsTeacher4App.CourseTypeName);
objvCurrEduClsTeacher4AppEN.CourseTypeName = strCourseTypeName; //课程类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.CourseTypeName) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.CourseTypeName, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.CourseTypeName] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetIsDegree(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, bool bolIsDegree, string strComparisonOp="")
	{
objvCurrEduClsTeacher4AppEN.IsDegree = bolIsDegree; //是否学位课
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.IsDegree) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.IsDegree, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.IsDegree] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN Setid_ScoreType(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strid_ScoreType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ScoreType, 4, convCurrEduClsTeacher4App.id_ScoreType);
clsCheckSql.CheckFieldForeignKey(strid_ScoreType, 4, convCurrEduClsTeacher4App.id_ScoreType);
objvCurrEduClsTeacher4AppEN.id_ScoreType = strid_ScoreType; //成绩类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.id_ScoreType) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.id_ScoreType, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.id_ScoreType] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetIsProportionalCtrl(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, bool bolIsProportionalCtrl, string strComparisonOp="")
	{
objvCurrEduClsTeacher4AppEN.IsProportionalCtrl = bolIsProportionalCtrl; //是否比例控制
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.IsProportionalCtrl) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.IsProportionalCtrl, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.IsProportionalCtrl] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN Setid_ExamType(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strid_ExamType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ExamType, 4, convCurrEduClsTeacher4App.id_ExamType);
clsCheckSql.CheckFieldForeignKey(strid_ExamType, 4, convCurrEduClsTeacher4App.id_ExamType);
objvCurrEduClsTeacher4AppEN.id_ExamType = strid_ExamType; //考试方式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.id_ExamType) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.id_ExamType, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.id_ExamType] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetBeginWeek(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, short shtBeginWeek, string strComparisonOp="")
	{
objvCurrEduClsTeacher4AppEN.BeginWeek = shtBeginWeek; //开始周
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.BeginWeek) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.BeginWeek, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.BeginWeek] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetCurrStuNum_Valid(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, int intCurrStuNum_Valid, string strComparisonOp="")
	{
objvCurrEduClsTeacher4AppEN.CurrStuNum_Valid = intCurrStuNum_Valid; //CurrStuNum_Valid
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.CurrStuNum_Valid) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.CurrStuNum_Valid, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.CurrStuNum_Valid] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetCurrStuNum(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, int intCurrStuNum, string strComparisonOp="")
	{
objvCurrEduClsTeacher4AppEN.CurrStuNum = intCurrStuNum; //当前学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.CurrStuNum) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.CurrStuNum, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.CurrStuNum] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN Setid_Teacher(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strid_Teacher, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Teacher, 8, convCurrEduClsTeacher4App.id_Teacher);
clsCheckSql.CheckFieldForeignKey(strid_Teacher, 8, convCurrEduClsTeacher4App.id_Teacher);
objvCurrEduClsTeacher4AppEN.id_Teacher = strid_Teacher; //教师流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.id_Teacher) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.id_Teacher, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.id_Teacher] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetTeacherID(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeacherID, 12, convCurrEduClsTeacher4App.TeacherID);
objvCurrEduClsTeacher4AppEN.TeacherID = strTeacherID; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.TeacherID) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.TeacherID, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.TeacherID] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetTeacherName(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strTeacherName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeacherName, 50, convCurrEduClsTeacher4App.TeacherName);
objvCurrEduClsTeacher4AppEN.TeacherName = strTeacherName; //教师姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.TeacherName) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.TeacherName, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.TeacherName] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetProfenssionalGradeName(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strProfenssionalGradeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProfenssionalGradeName, 30, convCurrEduClsTeacher4App.ProfenssionalGradeName);
objvCurrEduClsTeacher4AppEN.ProfenssionalGradeName = strProfenssionalGradeName; //专业职称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.ProfenssionalGradeName) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.ProfenssionalGradeName, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.ProfenssionalGradeName] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetIsGpUser(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, bool bolIsGpUser, string strComparisonOp="")
	{
objvCurrEduClsTeacher4AppEN.IsGpUser = bolIsGpUser; //是否Gp用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.IsGpUser) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.IsGpUser, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.IsGpUser] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetCollegeName(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCurrEduClsTeacher4App.CollegeName);
objvCurrEduClsTeacher4AppEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.CollegeName) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.CollegeName, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.CollegeName] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN Setid_Pk2EduClsTeacherType(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strid_Pk2EduClsTeacherType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Pk2EduClsTeacherType, 4, convCurrEduClsTeacher4App.id_Pk2EduClsTeacherType);
clsCheckSql.CheckFieldForeignKey(strid_Pk2EduClsTeacherType, 4, convCurrEduClsTeacher4App.id_Pk2EduClsTeacherType);
objvCurrEduClsTeacher4AppEN.id_Pk2EduClsTeacherType = strid_Pk2EduClsTeacherType; //教学班老师角色(主讲,辅导)流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.id_Pk2EduClsTeacherType) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.id_Pk2EduClsTeacherType, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.id_Pk2EduClsTeacherType] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetEduClsTeacherTypeID(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strEduClsTeacherTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduClsTeacherTypeID, 4, convCurrEduClsTeacher4App.EduClsTeacherTypeID);
clsCheckSql.CheckFieldForeignKey(strEduClsTeacherTypeID, 4, convCurrEduClsTeacher4App.EduClsTeacherTypeID);
objvCurrEduClsTeacher4AppEN.EduClsTeacherTypeID = strEduClsTeacherTypeID; //教学班教学类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.EduClsTeacherTypeID) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.EduClsTeacherTypeID, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.EduClsTeacherTypeID] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetEduClsTeacherTypeDesc(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strEduClsTeacherTypeDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduClsTeacherTypeDesc, 20, convCurrEduClsTeacher4App.EduClsTeacherTypeDesc);
objvCurrEduClsTeacher4AppEN.EduClsTeacherTypeDesc = strEduClsTeacherTypeDesc; //教学班教师类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.EduClsTeacherTypeDesc) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.EduClsTeacherTypeDesc, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.EduClsTeacherTypeDesc] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetUpdDate(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCurrEduClsTeacher4App.UpdDate);
objvCurrEduClsTeacher4AppEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.UpdDate) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.UpdDate, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.UpdDate] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetUpdUser(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCurrEduClsTeacher4App.UpdUser);
objvCurrEduClsTeacher4AppEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.UpdUser) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.UpdUser, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.UpdUser] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetMemo(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCurrEduClsTeacher4App.Memo);
objvCurrEduClsTeacher4AppEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.Memo) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.Memo, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.Memo] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetCollegeName4EduCls(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strCollegeName4EduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName4EduCls, 60, convCurrEduClsTeacher4App.CollegeName4EduCls);
objvCurrEduClsTeacher4AppEN.CollegeName4EduCls = strCollegeName4EduCls; //学院名_教学班
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.CollegeName4EduCls) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.CollegeName4EduCls, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.CollegeName4EduCls] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacher4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsTeacher4AppEN SetCollegeName4Teacher(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN, string strCollegeName4Teacher, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName4Teacher, 60, convCurrEduClsTeacher4App.CollegeName4Teacher);
objvCurrEduClsTeacher4AppEN.CollegeName4Teacher = strCollegeName4Teacher; //学院名_教师
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher4App.CollegeName4Teacher) == false)
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp.Add(convCurrEduClsTeacher4App.CollegeName4Teacher, strComparisonOp);
}
else
{
objvCurrEduClsTeacher4AppEN.dicFldComparisonOp[convCurrEduClsTeacher4App.CollegeName4Teacher] = strComparisonOp;
}
}
return objvCurrEduClsTeacher4AppEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4App_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.id_EduClsTeacher) == true)
{
string strComparisonOp_id_EduClsTeacher = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.id_EduClsTeacher];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsTeacher4App.id_EduClsTeacher, objvCurrEduClsTeacher4App_Cond.id_EduClsTeacher, strComparisonOp_id_EduClsTeacher);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.id_CurrEduCls, objvCurrEduClsTeacher4App_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.CurrEduClsId) == true)
{
string strComparisonOp_CurrEduClsId = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.CurrEduClsId, objvCurrEduClsTeacher4App_Cond.CurrEduClsId, strComparisonOp_CurrEduClsId);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.EduClsName) == true)
{
string strComparisonOp_EduClsName = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.EduClsName, objvCurrEduClsTeacher4App_Cond.EduClsName, strComparisonOp_EduClsName);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.EduClsTypeId) == true)
{
string strComparisonOp_EduClsTypeId = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.EduClsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.EduClsTypeId, objvCurrEduClsTeacher4App_Cond.EduClsTypeId, strComparisonOp_EduClsTypeId);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.CourseId) == true)
{
string strComparisonOp_CourseId = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.CourseId, objvCurrEduClsTeacher4App_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.CourseCode, objvCurrEduClsTeacher4App_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.CourseName) == true)
{
string strComparisonOp_CourseName = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.CourseName, objvCurrEduClsTeacher4App_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.ExampleImgPath) == true)
{
string strComparisonOp_ExampleImgPath = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.ExampleImgPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.ExampleImgPath, objvCurrEduClsTeacher4App_Cond.ExampleImgPath, strComparisonOp_ExampleImgPath);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.TeachingSolutionId) == true)
{
string strComparisonOp_TeachingSolutionId = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.TeachingSolutionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.TeachingSolutionId, objvCurrEduClsTeacher4App_Cond.TeachingSolutionId, strComparisonOp_TeachingSolutionId);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.TeachingSolutionName) == true)
{
string strComparisonOp_TeachingSolutionName = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.TeachingSolutionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.TeachingSolutionName, objvCurrEduClsTeacher4App_Cond.TeachingSolutionName, strComparisonOp_TeachingSolutionName);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.id_XzCollege, objvCurrEduClsTeacher4App_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.CollegeID, objvCurrEduClsTeacher4App_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.TotalLessonQty) == true)
{
string strComparisonOp_TotalLessonQty = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.TotalLessonQty];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsTeacher4App.TotalLessonQty, objvCurrEduClsTeacher4App_Cond.TotalLessonQty, strComparisonOp_TotalLessonQty);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.MaxStuQty) == true)
{
string strComparisonOp_MaxStuQty = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.MaxStuQty];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsTeacher4App.MaxStuQty, objvCurrEduClsTeacher4App_Cond.MaxStuQty, strComparisonOp_MaxStuQty);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.WeekQty) == true)
{
string strComparisonOp_WeekQty = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.WeekQty];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsTeacher4App.WeekQty, objvCurrEduClsTeacher4App_Cond.WeekQty, strComparisonOp_WeekQty);
}
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.WeekStatusID) == true)
{
string strComparisonOp_WeekStatusID = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.WeekStatusID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.WeekStatusID, objvCurrEduClsTeacher4App_Cond.WeekStatusID, strComparisonOp_WeekStatusID);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.CustomerWeek) == true)
{
string strComparisonOp_CustomerWeek = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.CustomerWeek];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.CustomerWeek, objvCurrEduClsTeacher4App_Cond.CustomerWeek, strComparisonOp_CustomerWeek);
}
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.id_UniZone) == true)
{
string strComparisonOp_id_UniZone = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.id_UniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.id_UniZone, objvCurrEduClsTeacher4App_Cond.id_UniZone, strComparisonOp_id_UniZone);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.id_GradeBase, objvCurrEduClsTeacher4App_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.GradeBaseID) == true)
{
string strComparisonOp_GradeBaseID = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.GradeBaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.GradeBaseID, objvCurrEduClsTeacher4App_Cond.GradeBaseID, strComparisonOp_GradeBaseID);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.GradeBaseName, objvCurrEduClsTeacher4App_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.IsEffective) == true)
{
if (objvCurrEduClsTeacher4App_Cond.IsEffective == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduClsTeacher4App.IsEffective);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduClsTeacher4App.IsEffective);
}
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.id_CourseType) == true)
{
string strComparisonOp_id_CourseType = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.id_CourseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.id_CourseType, objvCurrEduClsTeacher4App_Cond.id_CourseType, strComparisonOp_id_CourseType);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.CourseTypeID) == true)
{
string strComparisonOp_CourseTypeID = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.CourseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.CourseTypeID, objvCurrEduClsTeacher4App_Cond.CourseTypeID, strComparisonOp_CourseTypeID);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.CourseTypeName) == true)
{
string strComparisonOp_CourseTypeName = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.CourseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.CourseTypeName, objvCurrEduClsTeacher4App_Cond.CourseTypeName, strComparisonOp_CourseTypeName);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.IsDegree) == true)
{
if (objvCurrEduClsTeacher4App_Cond.IsDegree == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduClsTeacher4App.IsDegree);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduClsTeacher4App.IsDegree);
}
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.id_ScoreType) == true)
{
string strComparisonOp_id_ScoreType = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.id_ScoreType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.id_ScoreType, objvCurrEduClsTeacher4App_Cond.id_ScoreType, strComparisonOp_id_ScoreType);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.IsProportionalCtrl) == true)
{
if (objvCurrEduClsTeacher4App_Cond.IsProportionalCtrl == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduClsTeacher4App.IsProportionalCtrl);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduClsTeacher4App.IsProportionalCtrl);
}
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.id_ExamType) == true)
{
string strComparisonOp_id_ExamType = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.id_ExamType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.id_ExamType, objvCurrEduClsTeacher4App_Cond.id_ExamType, strComparisonOp_id_ExamType);
}
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.CurrStuNum_Valid) == true)
{
string strComparisonOp_CurrStuNum_Valid = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.CurrStuNum_Valid];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsTeacher4App.CurrStuNum_Valid, objvCurrEduClsTeacher4App_Cond.CurrStuNum_Valid, strComparisonOp_CurrStuNum_Valid);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.CurrStuNum) == true)
{
string strComparisonOp_CurrStuNum = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.CurrStuNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsTeacher4App.CurrStuNum, objvCurrEduClsTeacher4App_Cond.CurrStuNum, strComparisonOp_CurrStuNum);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.id_Teacher) == true)
{
string strComparisonOp_id_Teacher = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.id_Teacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.id_Teacher, objvCurrEduClsTeacher4App_Cond.id_Teacher, strComparisonOp_id_Teacher);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.TeacherID) == true)
{
string strComparisonOp_TeacherID = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.TeacherID, objvCurrEduClsTeacher4App_Cond.TeacherID, strComparisonOp_TeacherID);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.TeacherName) == true)
{
string strComparisonOp_TeacherName = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.TeacherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.TeacherName, objvCurrEduClsTeacher4App_Cond.TeacherName, strComparisonOp_TeacherName);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.ProfenssionalGradeName) == true)
{
string strComparisonOp_ProfenssionalGradeName = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.ProfenssionalGradeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.ProfenssionalGradeName, objvCurrEduClsTeacher4App_Cond.ProfenssionalGradeName, strComparisonOp_ProfenssionalGradeName);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.IsGpUser) == true)
{
if (objvCurrEduClsTeacher4App_Cond.IsGpUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduClsTeacher4App.IsGpUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduClsTeacher4App.IsGpUser);
}
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.CollegeName, objvCurrEduClsTeacher4App_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.id_Pk2EduClsTeacherType) == true)
{
string strComparisonOp_id_Pk2EduClsTeacherType = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.id_Pk2EduClsTeacherType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.id_Pk2EduClsTeacherType, objvCurrEduClsTeacher4App_Cond.id_Pk2EduClsTeacherType, strComparisonOp_id_Pk2EduClsTeacherType);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.EduClsTeacherTypeID) == true)
{
string strComparisonOp_EduClsTeacherTypeID = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.EduClsTeacherTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.EduClsTeacherTypeID, objvCurrEduClsTeacher4App_Cond.EduClsTeacherTypeID, strComparisonOp_EduClsTeacherTypeID);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.EduClsTeacherTypeDesc) == true)
{
string strComparisonOp_EduClsTeacherTypeDesc = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.EduClsTeacherTypeDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.EduClsTeacherTypeDesc, objvCurrEduClsTeacher4App_Cond.EduClsTeacherTypeDesc, strComparisonOp_EduClsTeacherTypeDesc);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.UpdDate, objvCurrEduClsTeacher4App_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.UpdUser, objvCurrEduClsTeacher4App_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.Memo) == true)
{
string strComparisonOp_Memo = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.Memo, objvCurrEduClsTeacher4App_Cond.Memo, strComparisonOp_Memo);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.CollegeName4EduCls) == true)
{
string strComparisonOp_CollegeName4EduCls = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.CollegeName4EduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.CollegeName4EduCls, objvCurrEduClsTeacher4App_Cond.CollegeName4EduCls, strComparisonOp_CollegeName4EduCls);
}
if (objvCurrEduClsTeacher4App_Cond.IsUpdated(convCurrEduClsTeacher4App.CollegeName4Teacher) == true)
{
string strComparisonOp_CollegeName4Teacher = objvCurrEduClsTeacher4App_Cond.dicFldComparisonOp[convCurrEduClsTeacher4App.CollegeName4Teacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher4App.CollegeName4Teacher, objvCurrEduClsTeacher4App_Cond.CollegeName4Teacher, strComparisonOp_CollegeName4Teacher);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v当前教学班教师4App(vCurrEduClsTeacher4App)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCurrEduClsTeacher4AppWApi
{
private static readonly string mstrApiControllerName = "vCurrEduClsTeacher4AppApi";

 public clsvCurrEduClsTeacher4AppWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_EduClsTeacher">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCurrEduClsTeacher4AppEN GetObjByid_EduClsTeacher(long lngid_EduClsTeacher)
{
string strAction = "GetObjByid_EduClsTeacher";
string strErrMsg = string.Empty;
string strResult = "";
clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN = null;
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
objvCurrEduClsTeacher4AppEN = JsonConvert.DeserializeObject<clsvCurrEduClsTeacher4AppEN>((string)jobjReturn["ReturnObj"]);
return objvCurrEduClsTeacher4AppEN;
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
public static clsvCurrEduClsTeacher4AppEN GetObjByid_EduClsTeacher_WA_Cache(long lngid_EduClsTeacher)
{
string strAction = "GetObjByid_EduClsTeacher_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN = null;
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
objvCurrEduClsTeacher4AppEN = JsonConvert.DeserializeObject<clsvCurrEduClsTeacher4AppEN>((string)jobjReturn["ReturnObj"]);
return objvCurrEduClsTeacher4AppEN;
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
public static clsvCurrEduClsTeacher4AppEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppEN = null;
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
objvCurrEduClsTeacher4AppEN = JsonConvert.DeserializeObject<clsvCurrEduClsTeacher4AppEN>((string)jobjReturn["ReturnObj"]);
return objvCurrEduClsTeacher4AppEN;
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
public static clsvCurrEduClsTeacher4AppEN GetObjByid_EduClsTeacher_Cache(long lngid_EduClsTeacher)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCurrEduClsTeacher4AppEN._CurrTabName_S);
List<clsvCurrEduClsTeacher4AppEN> arrvCurrEduClsTeacher4AppObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCurrEduClsTeacher4AppEN> arrvCurrEduClsTeacher4AppObjLst_Sel =
from objvCurrEduClsTeacher4AppEN in arrvCurrEduClsTeacher4AppObjLst_Cache
where objvCurrEduClsTeacher4AppEN.id_EduClsTeacher == lngid_EduClsTeacher
select objvCurrEduClsTeacher4AppEN;
if (arrvCurrEduClsTeacher4AppObjLst_Sel.Count() == 0)
{
   clsvCurrEduClsTeacher4AppEN obj = clsvCurrEduClsTeacher4AppWApi.GetObjByid_EduClsTeacher(lngid_EduClsTeacher);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCurrEduClsTeacher4AppObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduClsTeacher4AppEN> GetObjLst(string strWhereCond)
{
 List<clsvCurrEduClsTeacher4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsTeacher4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsTeacher4AppEN> GetObjLstById_EduClsTeacherLst(List<long> arrId_EduClsTeacher)
{
 List<clsvCurrEduClsTeacher4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsTeacher4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvCurrEduClsTeacher4AppEN> GetObjLstById_EduClsTeacherLst_Cache(List<long> arrId_EduClsTeacher)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCurrEduClsTeacher4AppEN._CurrTabName_S);
List<clsvCurrEduClsTeacher4AppEN> arrvCurrEduClsTeacher4AppObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCurrEduClsTeacher4AppEN> arrvCurrEduClsTeacher4AppObjLst_Sel =
from objvCurrEduClsTeacher4AppEN in arrvCurrEduClsTeacher4AppObjLst_Cache
where arrId_EduClsTeacher.Contains(objvCurrEduClsTeacher4AppEN.id_EduClsTeacher)
select objvCurrEduClsTeacher4AppEN;
return arrvCurrEduClsTeacher4AppObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduClsTeacher4AppEN> GetObjLstById_EduClsTeacherLst_WA_Cache(List<long> arrId_EduClsTeacher)
{
 List<clsvCurrEduClsTeacher4AppEN> arrObjLst = null; 
string strAction = "GetObjLstById_EduClsTeacherLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_EduClsTeacher);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsTeacher4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsTeacher4AppEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCurrEduClsTeacher4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsTeacher4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsTeacher4AppEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCurrEduClsTeacher4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsTeacher4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsTeacher4AppEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCurrEduClsTeacher4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsTeacher4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsTeacher4AppEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCurrEduClsTeacher4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsTeacher4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvCurrEduClsTeacher4AppENS">源对象</param>
 /// <param name = "objvCurrEduClsTeacher4AppENT">目标对象</param>
 public static void CopyTo(clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppENS, clsvCurrEduClsTeacher4AppEN objvCurrEduClsTeacher4AppENT)
{
try
{
objvCurrEduClsTeacher4AppENT.id_EduClsTeacher = objvCurrEduClsTeacher4AppENS.id_EduClsTeacher; //教学班老师流水号
objvCurrEduClsTeacher4AppENT.id_CurrEduCls = objvCurrEduClsTeacher4AppENS.id_CurrEduCls; //当前教学班流水号
objvCurrEduClsTeacher4AppENT.CurrEduClsId = objvCurrEduClsTeacher4AppENS.CurrEduClsId; //当前教学班Id
objvCurrEduClsTeacher4AppENT.EduClsName = objvCurrEduClsTeacher4AppENS.EduClsName; //教学班名称
objvCurrEduClsTeacher4AppENT.EduClsTypeId = objvCurrEduClsTeacher4AppENS.EduClsTypeId; //教学班类型代号
objvCurrEduClsTeacher4AppENT.CourseId = objvCurrEduClsTeacher4AppENS.CourseId; //课程Id
objvCurrEduClsTeacher4AppENT.CourseCode = objvCurrEduClsTeacher4AppENS.CourseCode; //课程代码
objvCurrEduClsTeacher4AppENT.CourseName = objvCurrEduClsTeacher4AppENS.CourseName; //课程名称
objvCurrEduClsTeacher4AppENT.ExampleImgPath = objvCurrEduClsTeacher4AppENS.ExampleImgPath; //示例图路径
objvCurrEduClsTeacher4AppENT.TeachingSolutionId = objvCurrEduClsTeacher4AppENS.TeachingSolutionId; //教学方案Id
objvCurrEduClsTeacher4AppENT.TeachingSolutionName = objvCurrEduClsTeacher4AppENS.TeachingSolutionName; //教学方案名称
objvCurrEduClsTeacher4AppENT.id_XzCollege = objvCurrEduClsTeacher4AppENS.id_XzCollege; //学院流水号
objvCurrEduClsTeacher4AppENT.CollegeID = objvCurrEduClsTeacher4AppENS.CollegeID; //学院ID
objvCurrEduClsTeacher4AppENT.TotalLessonQty = objvCurrEduClsTeacher4AppENS.TotalLessonQty; //总课时数
objvCurrEduClsTeacher4AppENT.MaxStuQty = objvCurrEduClsTeacher4AppENS.MaxStuQty; //最大学生数
objvCurrEduClsTeacher4AppENT.WeekQty = objvCurrEduClsTeacher4AppENS.WeekQty; //总周数
objvCurrEduClsTeacher4AppENT.ScheUnitPW = objvCurrEduClsTeacher4AppENS.ScheUnitPW; //周排课次数
objvCurrEduClsTeacher4AppENT.WeekStatusID = objvCurrEduClsTeacher4AppENS.WeekStatusID; //周状态编号(单,双,全周)
objvCurrEduClsTeacher4AppENT.CustomerWeek = objvCurrEduClsTeacher4AppENS.CustomerWeek; //自定义上课周
objvCurrEduClsTeacher4AppENT.LessonQtyPerWeek = objvCurrEduClsTeacher4AppENS.LessonQtyPerWeek; //周课时数
objvCurrEduClsTeacher4AppENT.id_UniZone = objvCurrEduClsTeacher4AppENS.id_UniZone; //校区流水号
objvCurrEduClsTeacher4AppENT.id_GradeBase = objvCurrEduClsTeacher4AppENS.id_GradeBase; //年级流水号
objvCurrEduClsTeacher4AppENT.GradeBaseID = objvCurrEduClsTeacher4AppENS.GradeBaseID; //年级代号
objvCurrEduClsTeacher4AppENT.GradeBaseName = objvCurrEduClsTeacher4AppENS.GradeBaseName; //年级名称
objvCurrEduClsTeacher4AppENT.IsEffective = objvCurrEduClsTeacher4AppENS.IsEffective; //是否有效
objvCurrEduClsTeacher4AppENT.id_CourseType = objvCurrEduClsTeacher4AppENS.id_CourseType; //课程类型流水号
objvCurrEduClsTeacher4AppENT.CourseTypeID = objvCurrEduClsTeacher4AppENS.CourseTypeID; //课程类型ID
objvCurrEduClsTeacher4AppENT.CourseTypeName = objvCurrEduClsTeacher4AppENS.CourseTypeName; //课程类型名称
objvCurrEduClsTeacher4AppENT.IsDegree = objvCurrEduClsTeacher4AppENS.IsDegree; //是否学位课
objvCurrEduClsTeacher4AppENT.id_ScoreType = objvCurrEduClsTeacher4AppENS.id_ScoreType; //成绩类型流水号
objvCurrEduClsTeacher4AppENT.IsProportionalCtrl = objvCurrEduClsTeacher4AppENS.IsProportionalCtrl; //是否比例控制
objvCurrEduClsTeacher4AppENT.id_ExamType = objvCurrEduClsTeacher4AppENS.id_ExamType; //考试方式流水号
objvCurrEduClsTeacher4AppENT.BeginWeek = objvCurrEduClsTeacher4AppENS.BeginWeek; //开始周
objvCurrEduClsTeacher4AppENT.CurrStuNum_Valid = objvCurrEduClsTeacher4AppENS.CurrStuNum_Valid; //CurrStuNum_Valid
objvCurrEduClsTeacher4AppENT.CurrStuNum = objvCurrEduClsTeacher4AppENS.CurrStuNum; //当前学生数
objvCurrEduClsTeacher4AppENT.id_Teacher = objvCurrEduClsTeacher4AppENS.id_Teacher; //教师流水号
objvCurrEduClsTeacher4AppENT.TeacherID = objvCurrEduClsTeacher4AppENS.TeacherID; //教师工号
objvCurrEduClsTeacher4AppENT.TeacherName = objvCurrEduClsTeacher4AppENS.TeacherName; //教师姓名
objvCurrEduClsTeacher4AppENT.ProfenssionalGradeName = objvCurrEduClsTeacher4AppENS.ProfenssionalGradeName; //专业职称
objvCurrEduClsTeacher4AppENT.IsGpUser = objvCurrEduClsTeacher4AppENS.IsGpUser; //是否Gp用户
objvCurrEduClsTeacher4AppENT.CollegeName = objvCurrEduClsTeacher4AppENS.CollegeName; //学院名称
objvCurrEduClsTeacher4AppENT.id_Pk2EduClsTeacherType = objvCurrEduClsTeacher4AppENS.id_Pk2EduClsTeacherType; //教学班老师角色(主讲,辅导)流水号
objvCurrEduClsTeacher4AppENT.EduClsTeacherTypeID = objvCurrEduClsTeacher4AppENS.EduClsTeacherTypeID; //教学班教学类型ID
objvCurrEduClsTeacher4AppENT.EduClsTeacherTypeDesc = objvCurrEduClsTeacher4AppENS.EduClsTeacherTypeDesc; //教学班教师类型名
objvCurrEduClsTeacher4AppENT.UpdDate = objvCurrEduClsTeacher4AppENS.UpdDate; //修改日期
objvCurrEduClsTeacher4AppENT.UpdUser = objvCurrEduClsTeacher4AppENS.UpdUser; //修改人
objvCurrEduClsTeacher4AppENT.Memo = objvCurrEduClsTeacher4AppENS.Memo; //备注
objvCurrEduClsTeacher4AppENT.CollegeName4EduCls = objvCurrEduClsTeacher4AppENS.CollegeName4EduCls; //学院名_教学班
objvCurrEduClsTeacher4AppENT.CollegeName4Teacher = objvCurrEduClsTeacher4AppENS.CollegeName4Teacher; //学院名_教师
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
public static DataTable ToDataTable(List<clsvCurrEduClsTeacher4AppEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCurrEduClsTeacher4AppEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCurrEduClsTeacher4AppEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCurrEduClsTeacher4AppEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCurrEduClsTeacher4AppEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCurrEduClsTeacher4AppEN.AttributeName)
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
//if (arrvCurrEduClsTeacher4AppObjLst_Cache == null)
//{
//arrvCurrEduClsTeacher4AppObjLst_Cache = await clsvCurrEduClsTeacher4AppWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCurrEduClsTeacher4AppEN._CurrTabName_S);
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
public static List<clsvCurrEduClsTeacher4AppEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCurrEduClsTeacher4AppEN._CurrTabName_S);
List<clsvCurrEduClsTeacher4AppEN> arrvCurrEduClsTeacher4AppObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCurrEduClsTeacher4AppObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCurrEduClsTeacher4AppEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCurrEduClsTeacher4App.id_EduClsTeacher, Type.GetType("System.Int64"));
objDT.Columns.Add(convCurrEduClsTeacher4App.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.CurrEduClsId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.EduClsName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.EduClsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.ExampleImgPath, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.TeachingSolutionId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.TeachingSolutionName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.TotalLessonQty, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduClsTeacher4App.MaxStuQty, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduClsTeacher4App.WeekQty, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduClsTeacher4App.ScheUnitPW, Type.GetType("System.Int16"));
objDT.Columns.Add(convCurrEduClsTeacher4App.WeekStatusID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.CustomerWeek, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.LessonQtyPerWeek, Type.GetType("System.Int16"));
objDT.Columns.Add(convCurrEduClsTeacher4App.id_UniZone, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.GradeBaseID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.IsEffective, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduClsTeacher4App.id_CourseType, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.CourseTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.CourseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.IsDegree, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduClsTeacher4App.id_ScoreType, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.IsProportionalCtrl, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduClsTeacher4App.id_ExamType, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.BeginWeek, Type.GetType("System.Int16"));
objDT.Columns.Add(convCurrEduClsTeacher4App.CurrStuNum_Valid, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduClsTeacher4App.CurrStuNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduClsTeacher4App.id_Teacher, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.TeacherID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.TeacherName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.ProfenssionalGradeName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.IsGpUser, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduClsTeacher4App.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.id_Pk2EduClsTeacherType, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.EduClsTeacherTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.EduClsTeacherTypeDesc, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.CollegeName4EduCls, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsTeacher4App.CollegeName4Teacher, Type.GetType("System.String"));
foreach (clsvCurrEduClsTeacher4AppEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCurrEduClsTeacher4App.id_EduClsTeacher] = objInFor[convCurrEduClsTeacher4App.id_EduClsTeacher];
objDR[convCurrEduClsTeacher4App.id_CurrEduCls] = objInFor[convCurrEduClsTeacher4App.id_CurrEduCls];
objDR[convCurrEduClsTeacher4App.CurrEduClsId] = objInFor[convCurrEduClsTeacher4App.CurrEduClsId];
objDR[convCurrEduClsTeacher4App.EduClsName] = objInFor[convCurrEduClsTeacher4App.EduClsName];
objDR[convCurrEduClsTeacher4App.EduClsTypeId] = objInFor[convCurrEduClsTeacher4App.EduClsTypeId];
objDR[convCurrEduClsTeacher4App.CourseId] = objInFor[convCurrEduClsTeacher4App.CourseId];
objDR[convCurrEduClsTeacher4App.CourseCode] = objInFor[convCurrEduClsTeacher4App.CourseCode];
objDR[convCurrEduClsTeacher4App.CourseName] = objInFor[convCurrEduClsTeacher4App.CourseName];
objDR[convCurrEduClsTeacher4App.ExampleImgPath] = objInFor[convCurrEduClsTeacher4App.ExampleImgPath];
objDR[convCurrEduClsTeacher4App.TeachingSolutionId] = objInFor[convCurrEduClsTeacher4App.TeachingSolutionId];
objDR[convCurrEduClsTeacher4App.TeachingSolutionName] = objInFor[convCurrEduClsTeacher4App.TeachingSolutionName];
objDR[convCurrEduClsTeacher4App.id_XzCollege] = objInFor[convCurrEduClsTeacher4App.id_XzCollege];
objDR[convCurrEduClsTeacher4App.CollegeID] = objInFor[convCurrEduClsTeacher4App.CollegeID];
objDR[convCurrEduClsTeacher4App.TotalLessonQty] = objInFor[convCurrEduClsTeacher4App.TotalLessonQty];
objDR[convCurrEduClsTeacher4App.MaxStuQty] = objInFor[convCurrEduClsTeacher4App.MaxStuQty];
objDR[convCurrEduClsTeacher4App.WeekQty] = objInFor[convCurrEduClsTeacher4App.WeekQty];
objDR[convCurrEduClsTeacher4App.ScheUnitPW] = objInFor[convCurrEduClsTeacher4App.ScheUnitPW];
objDR[convCurrEduClsTeacher4App.WeekStatusID] = objInFor[convCurrEduClsTeacher4App.WeekStatusID];
objDR[convCurrEduClsTeacher4App.CustomerWeek] = objInFor[convCurrEduClsTeacher4App.CustomerWeek];
objDR[convCurrEduClsTeacher4App.LessonQtyPerWeek] = objInFor[convCurrEduClsTeacher4App.LessonQtyPerWeek];
objDR[convCurrEduClsTeacher4App.id_UniZone] = objInFor[convCurrEduClsTeacher4App.id_UniZone];
objDR[convCurrEduClsTeacher4App.id_GradeBase] = objInFor[convCurrEduClsTeacher4App.id_GradeBase];
objDR[convCurrEduClsTeacher4App.GradeBaseID] = objInFor[convCurrEduClsTeacher4App.GradeBaseID];
objDR[convCurrEduClsTeacher4App.GradeBaseName] = objInFor[convCurrEduClsTeacher4App.GradeBaseName];
objDR[convCurrEduClsTeacher4App.IsEffective] = objInFor[convCurrEduClsTeacher4App.IsEffective];
objDR[convCurrEduClsTeacher4App.id_CourseType] = objInFor[convCurrEduClsTeacher4App.id_CourseType];
objDR[convCurrEduClsTeacher4App.CourseTypeID] = objInFor[convCurrEduClsTeacher4App.CourseTypeID];
objDR[convCurrEduClsTeacher4App.CourseTypeName] = objInFor[convCurrEduClsTeacher4App.CourseTypeName];
objDR[convCurrEduClsTeacher4App.IsDegree] = objInFor[convCurrEduClsTeacher4App.IsDegree];
objDR[convCurrEduClsTeacher4App.id_ScoreType] = objInFor[convCurrEduClsTeacher4App.id_ScoreType];
objDR[convCurrEduClsTeacher4App.IsProportionalCtrl] = objInFor[convCurrEduClsTeacher4App.IsProportionalCtrl];
objDR[convCurrEduClsTeacher4App.id_ExamType] = objInFor[convCurrEduClsTeacher4App.id_ExamType];
objDR[convCurrEduClsTeacher4App.BeginWeek] = objInFor[convCurrEduClsTeacher4App.BeginWeek];
objDR[convCurrEduClsTeacher4App.CurrStuNum_Valid] = objInFor[convCurrEduClsTeacher4App.CurrStuNum_Valid];
objDR[convCurrEduClsTeacher4App.CurrStuNum] = objInFor[convCurrEduClsTeacher4App.CurrStuNum];
objDR[convCurrEduClsTeacher4App.id_Teacher] = objInFor[convCurrEduClsTeacher4App.id_Teacher];
objDR[convCurrEduClsTeacher4App.TeacherID] = objInFor[convCurrEduClsTeacher4App.TeacherID];
objDR[convCurrEduClsTeacher4App.TeacherName] = objInFor[convCurrEduClsTeacher4App.TeacherName];
objDR[convCurrEduClsTeacher4App.ProfenssionalGradeName] = objInFor[convCurrEduClsTeacher4App.ProfenssionalGradeName];
objDR[convCurrEduClsTeacher4App.IsGpUser] = objInFor[convCurrEduClsTeacher4App.IsGpUser];
objDR[convCurrEduClsTeacher4App.CollegeName] = objInFor[convCurrEduClsTeacher4App.CollegeName];
objDR[convCurrEduClsTeacher4App.id_Pk2EduClsTeacherType] = objInFor[convCurrEduClsTeacher4App.id_Pk2EduClsTeacherType];
objDR[convCurrEduClsTeacher4App.EduClsTeacherTypeID] = objInFor[convCurrEduClsTeacher4App.EduClsTeacherTypeID];
objDR[convCurrEduClsTeacher4App.EduClsTeacherTypeDesc] = objInFor[convCurrEduClsTeacher4App.EduClsTeacherTypeDesc];
objDR[convCurrEduClsTeacher4App.UpdDate] = objInFor[convCurrEduClsTeacher4App.UpdDate];
objDR[convCurrEduClsTeacher4App.UpdUser] = objInFor[convCurrEduClsTeacher4App.UpdUser];
objDR[convCurrEduClsTeacher4App.Memo] = objInFor[convCurrEduClsTeacher4App.Memo];
objDR[convCurrEduClsTeacher4App.CollegeName4EduCls] = objInFor[convCurrEduClsTeacher4App.CollegeName4EduCls];
objDR[convCurrEduClsTeacher4App.CollegeName4Teacher] = objInFor[convCurrEduClsTeacher4App.CollegeName4Teacher];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}