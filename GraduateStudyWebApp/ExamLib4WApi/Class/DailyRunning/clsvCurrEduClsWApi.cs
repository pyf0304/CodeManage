
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCurrEduClsWApi
 表名:vCurrEduCls(01120126)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:51:44
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
public static class clsvCurrEduClsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN Setid_CurrEduCls(this clsvCurrEduClsEN objvCurrEduClsEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convCurrEduCls.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convCurrEduCls.id_CurrEduCls);
objvCurrEduClsEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.id_CurrEduCls) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.id_CurrEduCls, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.id_CurrEduCls] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetCurrEduClsId(this clsvCurrEduClsEN objvCurrEduClsEN, string strCurrEduClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCurrEduClsId, convCurrEduCls.CurrEduClsId);
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, convCurrEduCls.CurrEduClsId);
objvCurrEduClsEN.CurrEduClsId = strCurrEduClsId; //当前教学班Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.CurrEduClsId) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.CurrEduClsId, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.CurrEduClsId] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetEduClsName(this clsvCurrEduClsEN objvCurrEduClsEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduClsName, convCurrEduCls.EduClsName);
clsCheckSql.CheckFieldLen(strEduClsName, 100, convCurrEduCls.EduClsName);
objvCurrEduClsEN.EduClsName = strEduClsName; //教学班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.EduClsName) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.EduClsName, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.EduClsName] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetEduClsTypeId(this clsvCurrEduClsEN objvCurrEduClsEN, string strEduClsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduClsTypeId, convCurrEduCls.EduClsTypeId);
clsCheckSql.CheckFieldLen(strEduClsTypeId, 4, convCurrEduCls.EduClsTypeId);
clsCheckSql.CheckFieldForeignKey(strEduClsTypeId, 4, convCurrEduCls.EduClsTypeId);
objvCurrEduClsEN.EduClsTypeId = strEduClsTypeId; //教学班类型代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.EduClsTypeId) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.EduClsTypeId, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.EduClsTypeId] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetEduClsTypeName(this clsvCurrEduClsEN objvCurrEduClsEN, string strEduClsTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduClsTypeName, 100, convCurrEduCls.EduClsTypeName);
objvCurrEduClsEN.EduClsTypeName = strEduClsTypeName; //教学班类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.EduClsTypeName) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.EduClsTypeName, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.EduClsTypeName] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetCourseId(this clsvCurrEduClsEN objvCurrEduClsEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCurrEduCls.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCurrEduCls.CourseId);
objvCurrEduClsEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.CourseId) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.CourseId, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.CourseId] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetCourseCode(this clsvCurrEduClsEN objvCurrEduClsEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCurrEduCls.CourseCode);
objvCurrEduClsEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.CourseCode) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.CourseCode, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.CourseCode] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetCourseDescription(this clsvCurrEduClsEN objvCurrEduClsEN, string strCourseDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseDescription, 8000, convCurrEduCls.CourseDescription);
objvCurrEduClsEN.CourseDescription = strCourseDescription; //课程描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.CourseDescription) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.CourseDescription, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.CourseDescription] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetCourseName(this clsvCurrEduClsEN objvCurrEduClsEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCurrEduCls.CourseName);
objvCurrEduClsEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.CourseName) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.CourseName, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.CourseName] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetViewCount(this clsvCurrEduClsEN objvCurrEduClsEN, int intViewCount, string strComparisonOp="")
	{
objvCurrEduClsEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.ViewCount) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.ViewCount, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.ViewCount] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetExampleImgPath(this clsvCurrEduClsEN objvCurrEduClsEN, string strExampleImgPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExampleImgPath, 300, convCurrEduCls.ExampleImgPath);
objvCurrEduClsEN.ExampleImgPath = strExampleImgPath; //示例图路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.ExampleImgPath) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.ExampleImgPath, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.ExampleImgPath] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetTeachingSolutionId(this clsvCurrEduClsEN objvCurrEduClsEN, string strTeachingSolutionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingSolutionId, convCurrEduCls.TeachingSolutionId);
clsCheckSql.CheckFieldLen(strTeachingSolutionId, 8, convCurrEduCls.TeachingSolutionId);
clsCheckSql.CheckFieldForeignKey(strTeachingSolutionId, 8, convCurrEduCls.TeachingSolutionId);
objvCurrEduClsEN.TeachingSolutionId = strTeachingSolutionId; //教学方案Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.TeachingSolutionId) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.TeachingSolutionId, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.TeachingSolutionId] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetTeachingSolutionName(this clsvCurrEduClsEN objvCurrEduClsEN, string strTeachingSolutionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingSolutionName, 100, convCurrEduCls.TeachingSolutionName);
objvCurrEduClsEN.TeachingSolutionName = strTeachingSolutionName; //教学方案名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.TeachingSolutionName) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.TeachingSolutionName, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.TeachingSolutionName] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN Setid_Teacher(this clsvCurrEduClsEN objvCurrEduClsEN, string strid_Teacher, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Teacher, 8, convCurrEduCls.id_Teacher);
clsCheckSql.CheckFieldForeignKey(strid_Teacher, 8, convCurrEduCls.id_Teacher);
objvCurrEduClsEN.id_Teacher = strid_Teacher; //教师流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.id_Teacher) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.id_Teacher, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.id_Teacher] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetTeacherID(this clsvCurrEduClsEN objvCurrEduClsEN, string strTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeacherID, 12, convCurrEduCls.TeacherID);
objvCurrEduClsEN.TeacherID = strTeacherID; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.TeacherID) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.TeacherID, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.TeacherID] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetTeacherName(this clsvCurrEduClsEN objvCurrEduClsEN, string strTeacherName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeacherName, 50, convCurrEduCls.TeacherName);
objvCurrEduClsEN.TeacherName = strTeacherName; //教师姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.TeacherName) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.TeacherName, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.TeacherName] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN Setid_XzCollege(this clsvCurrEduClsEN objvCurrEduClsEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convCurrEduCls.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convCurrEduCls.id_XzCollege);
objvCurrEduClsEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.id_XzCollege) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.id_XzCollege, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.id_XzCollege] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetCollegeID(this clsvCurrEduClsEN objvCurrEduClsEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convCurrEduCls.CollegeID);
objvCurrEduClsEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.CollegeID) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.CollegeID, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.CollegeID] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetCollegeName(this clsvCurrEduClsEN objvCurrEduClsEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCurrEduCls.CollegeName);
objvCurrEduClsEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.CollegeName) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.CollegeName, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.CollegeName] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetClgEnglishName(this clsvCurrEduClsEN objvCurrEduClsEN, string strClgEnglishName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClgEnglishName, 60, convCurrEduCls.ClgEnglishName);
objvCurrEduClsEN.ClgEnglishName = strClgEnglishName; //ClgEnglishName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.ClgEnglishName) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.ClgEnglishName, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.ClgEnglishName] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetPhoneNumber(this clsvCurrEduClsEN objvCurrEduClsEN, string strPhoneNumber, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPhoneNumber, 15, convCurrEduCls.PhoneNumber);
objvCurrEduClsEN.PhoneNumber = strPhoneNumber; //PhoneNumber
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.PhoneNumber) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.PhoneNumber, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.PhoneNumber] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN Setid_XzMajor(this clsvCurrEduClsEN objvCurrEduClsEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzMajor, convCurrEduCls.id_XzMajor);
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convCurrEduCls.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convCurrEduCls.id_XzMajor);
objvCurrEduClsEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.id_XzMajor) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.id_XzMajor, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.id_XzMajor] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetMajorName(this clsvCurrEduClsEN objvCurrEduClsEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convCurrEduCls.MajorName);
objvCurrEduClsEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.MajorName) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.MajorName, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.MajorName] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN Setid_EduWay(this clsvCurrEduClsEN objvCurrEduClsEN, string strid_EduWay, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_EduWay, convCurrEduCls.id_EduWay);
clsCheckSql.CheckFieldLen(strid_EduWay, 4, convCurrEduCls.id_EduWay);
clsCheckSql.CheckFieldForeignKey(strid_EduWay, 4, convCurrEduCls.id_EduWay);
objvCurrEduClsEN.id_EduWay = strid_EduWay; //教学方式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.id_EduWay) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.id_EduWay, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.id_EduWay] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN Setid_ClassRoomType(this clsvCurrEduClsEN objvCurrEduClsEN, string strid_ClassRoomType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ClassRoomType, convCurrEduCls.id_ClassRoomType);
clsCheckSql.CheckFieldLen(strid_ClassRoomType, 4, convCurrEduCls.id_ClassRoomType);
clsCheckSql.CheckFieldForeignKey(strid_ClassRoomType, 4, convCurrEduCls.id_ClassRoomType);
objvCurrEduClsEN.id_ClassRoomType = strid_ClassRoomType; //教室类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.id_ClassRoomType) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.id_ClassRoomType, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.id_ClassRoomType] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetTotalLessonQty(this clsvCurrEduClsEN objvCurrEduClsEN, int intTotalLessonQty, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intTotalLessonQty, convCurrEduCls.TotalLessonQty);
objvCurrEduClsEN.TotalLessonQty = intTotalLessonQty; //总课时数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.TotalLessonQty) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.TotalLessonQty, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.TotalLessonQty] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetMaxStuQty(this clsvCurrEduClsEN objvCurrEduClsEN, int intMaxStuQty, string strComparisonOp="")
	{
objvCurrEduClsEN.MaxStuQty = intMaxStuQty; //最大学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.MaxStuQty) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.MaxStuQty, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.MaxStuQty] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetWeekQty(this clsvCurrEduClsEN objvCurrEduClsEN, int intWeekQty, string strComparisonOp="")
	{
objvCurrEduClsEN.WeekQty = intWeekQty; //总周数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.WeekQty) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.WeekQty, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.WeekQty] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetScheUnitPW(this clsvCurrEduClsEN objvCurrEduClsEN, short shtScheUnitPW, string strComparisonOp="")
	{
objvCurrEduClsEN.ScheUnitPW = shtScheUnitPW; //周排课次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.ScheUnitPW) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.ScheUnitPW, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.ScheUnitPW] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetWeekStatusID(this clsvCurrEduClsEN objvCurrEduClsEN, string strWeekStatusID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWeekStatusID, 2, convCurrEduCls.WeekStatusID);
clsCheckSql.CheckFieldForeignKey(strWeekStatusID, 2, convCurrEduCls.WeekStatusID);
objvCurrEduClsEN.WeekStatusID = strWeekStatusID; //周状态编号(单,双,全周)
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.WeekStatusID) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.WeekStatusID, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.WeekStatusID] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetCustomerWeek(this clsvCurrEduClsEN objvCurrEduClsEN, string strCustomerWeek, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCustomerWeek, 50, convCurrEduCls.CustomerWeek);
objvCurrEduClsEN.CustomerWeek = strCustomerWeek; //自定义上课周
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.CustomerWeek) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.CustomerWeek, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.CustomerWeek] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetLessonQtyPerWeek(this clsvCurrEduClsEN objvCurrEduClsEN, short shtLessonQtyPerWeek, string strComparisonOp="")
	{
objvCurrEduClsEN.LessonQtyPerWeek = shtLessonQtyPerWeek; //周课时数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.LessonQtyPerWeek) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.LessonQtyPerWeek, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.LessonQtyPerWeek] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetMark(this clsvCurrEduClsEN objvCurrEduClsEN, double dblMark, string strComparisonOp="")
	{
objvCurrEduClsEN.Mark = dblMark; //获得学分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.Mark) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.Mark, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.Mark] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN Setid_UniZone(this clsvCurrEduClsEN objvCurrEduClsEN, string strid_UniZone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_UniZone, 4, convCurrEduCls.id_UniZone);
clsCheckSql.CheckFieldForeignKey(strid_UniZone, 4, convCurrEduCls.id_UniZone);
objvCurrEduClsEN.id_UniZone = strid_UniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.id_UniZone) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.id_UniZone, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.id_UniZone] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN Setid_GradeBase(this clsvCurrEduClsEN objvCurrEduClsEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convCurrEduCls.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convCurrEduCls.id_GradeBase);
objvCurrEduClsEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.id_GradeBase) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.id_GradeBase, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.id_GradeBase] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetGradeBaseID(this clsvCurrEduClsEN objvCurrEduClsEN, string strGradeBaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseID, 4, convCurrEduCls.GradeBaseID);
clsCheckSql.CheckFieldForeignKey(strGradeBaseID, 4, convCurrEduCls.GradeBaseID);
objvCurrEduClsEN.GradeBaseID = strGradeBaseID; //年级代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.GradeBaseID) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.GradeBaseID, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.GradeBaseID] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetGradeBaseName(this clsvCurrEduClsEN objvCurrEduClsEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convCurrEduCls.GradeBaseName);
objvCurrEduClsEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.GradeBaseName) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.GradeBaseName, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.GradeBaseName] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetGradeBaseNameA(this clsvCurrEduClsEN objvCurrEduClsEN, string strGradeBaseNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseNameA, 10, convCurrEduCls.GradeBaseNameA);
objvCurrEduClsEN.GradeBaseNameA = strGradeBaseNameA; //年级名称缩写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.GradeBaseNameA) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.GradeBaseNameA, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.GradeBaseNameA] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetIsEffective(this clsvCurrEduClsEN objvCurrEduClsEN, bool bolIsEffective, string strComparisonOp="")
	{
objvCurrEduClsEN.IsEffective = bolIsEffective; //是否有效
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.IsEffective) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.IsEffective, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.IsEffective] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetIsForPaperReading(this clsvCurrEduClsEN objvCurrEduClsEN, bool bolIsForPaperReading, string strComparisonOp="")
	{
objvCurrEduClsEN.IsForPaperReading = bolIsForPaperReading; //是否参与论文阅读
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.IsForPaperReading) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.IsForPaperReading, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.IsForPaperReading] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetSchoolYear(this clsvCurrEduClsEN objvCurrEduClsEN, string strSchoolYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, convCurrEduCls.SchoolYear);
objvCurrEduClsEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.SchoolYear) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.SchoolYear, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.SchoolYear] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetSchoolTerm(this clsvCurrEduClsEN objvCurrEduClsEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, convCurrEduCls.SchoolTerm);
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, convCurrEduCls.SchoolTerm);
objvCurrEduClsEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.SchoolTerm) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.SchoolTerm, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.SchoolTerm] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN Setid_CourseType(this clsvCurrEduClsEN objvCurrEduClsEN, string strid_CourseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CourseType, convCurrEduCls.id_CourseType);
clsCheckSql.CheckFieldLen(strid_CourseType, 4, convCurrEduCls.id_CourseType);
clsCheckSql.CheckFieldForeignKey(strid_CourseType, 4, convCurrEduCls.id_CourseType);
objvCurrEduClsEN.id_CourseType = strid_CourseType; //课程类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.id_CourseType) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.id_CourseType, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.id_CourseType] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetCourseTypeID(this clsvCurrEduClsEN objvCurrEduClsEN, string strCourseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseTypeID, 4, convCurrEduCls.CourseTypeID);
clsCheckSql.CheckFieldForeignKey(strCourseTypeID, 4, convCurrEduCls.CourseTypeID);
objvCurrEduClsEN.CourseTypeID = strCourseTypeID; //课程类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.CourseTypeID) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.CourseTypeID, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.CourseTypeID] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetCourseTypeName(this clsvCurrEduClsEN objvCurrEduClsEN, string strCourseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseTypeName, 30, convCurrEduCls.CourseTypeName);
objvCurrEduClsEN.CourseTypeName = strCourseTypeName; //课程类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.CourseTypeName) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.CourseTypeName, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.CourseTypeName] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetIsDegree(this clsvCurrEduClsEN objvCurrEduClsEN, bool bolIsDegree, string strComparisonOp="")
	{
objvCurrEduClsEN.IsDegree = bolIsDegree; //是否学位课
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.IsDegree) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.IsDegree, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.IsDegree] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN Setid_ScoreType(this clsvCurrEduClsEN objvCurrEduClsEN, string strid_ScoreType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ScoreType, 4, convCurrEduCls.id_ScoreType);
clsCheckSql.CheckFieldForeignKey(strid_ScoreType, 4, convCurrEduCls.id_ScoreType);
objvCurrEduClsEN.id_ScoreType = strid_ScoreType; //成绩类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.id_ScoreType) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.id_ScoreType, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.id_ScoreType] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetGetScoreWayId(this clsvCurrEduClsEN objvCurrEduClsEN, string strGetScoreWayId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGetScoreWayId, 2, convCurrEduCls.GetScoreWayId);
clsCheckSql.CheckFieldForeignKey(strGetScoreWayId, 2, convCurrEduCls.GetScoreWayId);
objvCurrEduClsEN.GetScoreWayId = strGetScoreWayId; //获得成绩方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.GetScoreWayId) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.GetScoreWayId, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.GetScoreWayId] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetIsProportionalCtrl(this clsvCurrEduClsEN objvCurrEduClsEN, bool bolIsProportionalCtrl, string strComparisonOp="")
	{
objvCurrEduClsEN.IsProportionalCtrl = bolIsProportionalCtrl; //是否比例控制
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.IsProportionalCtrl) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.IsProportionalCtrl, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.IsProportionalCtrl] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN Setid_ExamType(this clsvCurrEduClsEN objvCurrEduClsEN, string strid_ExamType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ExamType, 4, convCurrEduCls.id_ExamType);
clsCheckSql.CheckFieldForeignKey(strid_ExamType, 4, convCurrEduCls.id_ExamType);
objvCurrEduClsEN.id_ExamType = strid_ExamType; //考试方式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.id_ExamType) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.id_ExamType, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.id_ExamType] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetBeginWeek(this clsvCurrEduClsEN objvCurrEduClsEN, short shtBeginWeek, string strComparisonOp="")
	{
objvCurrEduClsEN.BeginWeek = shtBeginWeek; //开始周
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.BeginWeek) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.BeginWeek, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.BeginWeek] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetModifyDate(this clsvCurrEduClsEN objvCurrEduClsEN, string strModifyDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyDate, 20, convCurrEduCls.ModifyDate);
objvCurrEduClsEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.ModifyDate) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.ModifyDate, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.ModifyDate] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetModifyUserID(this clsvCurrEduClsEN objvCurrEduClsEN, string strModifyUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyUserID, 18, convCurrEduCls.ModifyUserID);
objvCurrEduClsEN.ModifyUserID = strModifyUserID; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.ModifyUserID) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.ModifyUserID, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.ModifyUserID] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetMemo(this clsvCurrEduClsEN objvCurrEduClsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCurrEduCls.Memo);
objvCurrEduClsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.Memo) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.Memo, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.Memo] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetCurrStuNum_Valid(this clsvCurrEduClsEN objvCurrEduClsEN, int intCurrStuNum_Valid, string strComparisonOp="")
	{
objvCurrEduClsEN.CurrStuNum_Valid = intCurrStuNum_Valid; //CurrStuNum_Valid
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.CurrStuNum_Valid) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.CurrStuNum_Valid, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.CurrStuNum_Valid] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsEN SetCurrStuNum(this clsvCurrEduClsEN objvCurrEduClsEN, int intCurrStuNum, string strComparisonOp="")
	{
objvCurrEduClsEN.CurrStuNum = intCurrStuNum; //当前学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.CurrStuNum) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.CurrStuNum, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.CurrStuNum] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCurrEduClsEN objvCurrEduCls_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.id_CurrEduCls, objvCurrEduCls_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.CurrEduClsId) == true)
{
string strComparisonOp_CurrEduClsId = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.CurrEduClsId, objvCurrEduCls_Cond.CurrEduClsId, strComparisonOp_CurrEduClsId);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.EduClsName) == true)
{
string strComparisonOp_EduClsName = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.EduClsName, objvCurrEduCls_Cond.EduClsName, strComparisonOp_EduClsName);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.EduClsTypeId) == true)
{
string strComparisonOp_EduClsTypeId = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.EduClsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.EduClsTypeId, objvCurrEduCls_Cond.EduClsTypeId, strComparisonOp_EduClsTypeId);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.EduClsTypeName) == true)
{
string strComparisonOp_EduClsTypeName = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.EduClsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.EduClsTypeName, objvCurrEduCls_Cond.EduClsTypeName, strComparisonOp_EduClsTypeName);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.CourseId) == true)
{
string strComparisonOp_CourseId = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.CourseId, objvCurrEduCls_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.CourseCode, objvCurrEduCls_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.CourseDescription) == true)
{
string strComparisonOp_CourseDescription = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.CourseDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.CourseDescription, objvCurrEduCls_Cond.CourseDescription, strComparisonOp_CourseDescription);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.CourseName) == true)
{
string strComparisonOp_CourseName = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.CourseName, objvCurrEduCls_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls.ViewCount, objvCurrEduCls_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.ExampleImgPath) == true)
{
string strComparisonOp_ExampleImgPath = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.ExampleImgPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.ExampleImgPath, objvCurrEduCls_Cond.ExampleImgPath, strComparisonOp_ExampleImgPath);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.TeachingSolutionId) == true)
{
string strComparisonOp_TeachingSolutionId = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.TeachingSolutionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.TeachingSolutionId, objvCurrEduCls_Cond.TeachingSolutionId, strComparisonOp_TeachingSolutionId);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.TeachingSolutionName) == true)
{
string strComparisonOp_TeachingSolutionName = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.TeachingSolutionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.TeachingSolutionName, objvCurrEduCls_Cond.TeachingSolutionName, strComparisonOp_TeachingSolutionName);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.id_Teacher) == true)
{
string strComparisonOp_id_Teacher = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.id_Teacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.id_Teacher, objvCurrEduCls_Cond.id_Teacher, strComparisonOp_id_Teacher);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.TeacherID) == true)
{
string strComparisonOp_TeacherID = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.TeacherID, objvCurrEduCls_Cond.TeacherID, strComparisonOp_TeacherID);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.TeacherName) == true)
{
string strComparisonOp_TeacherName = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.TeacherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.TeacherName, objvCurrEduCls_Cond.TeacherName, strComparisonOp_TeacherName);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.id_XzCollege, objvCurrEduCls_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.CollegeID, objvCurrEduCls_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.CollegeName, objvCurrEduCls_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.ClgEnglishName) == true)
{
string strComparisonOp_ClgEnglishName = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.ClgEnglishName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.ClgEnglishName, objvCurrEduCls_Cond.ClgEnglishName, strComparisonOp_ClgEnglishName);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.PhoneNumber) == true)
{
string strComparisonOp_PhoneNumber = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.PhoneNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.PhoneNumber, objvCurrEduCls_Cond.PhoneNumber, strComparisonOp_PhoneNumber);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.id_XzMajor, objvCurrEduCls_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.MajorName) == true)
{
string strComparisonOp_MajorName = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.MajorName, objvCurrEduCls_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.id_EduWay) == true)
{
string strComparisonOp_id_EduWay = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.id_EduWay];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.id_EduWay, objvCurrEduCls_Cond.id_EduWay, strComparisonOp_id_EduWay);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.id_ClassRoomType) == true)
{
string strComparisonOp_id_ClassRoomType = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.id_ClassRoomType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.id_ClassRoomType, objvCurrEduCls_Cond.id_ClassRoomType, strComparisonOp_id_ClassRoomType);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.TotalLessonQty) == true)
{
string strComparisonOp_TotalLessonQty = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.TotalLessonQty];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls.TotalLessonQty, objvCurrEduCls_Cond.TotalLessonQty, strComparisonOp_TotalLessonQty);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.MaxStuQty) == true)
{
string strComparisonOp_MaxStuQty = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.MaxStuQty];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls.MaxStuQty, objvCurrEduCls_Cond.MaxStuQty, strComparisonOp_MaxStuQty);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.WeekQty) == true)
{
string strComparisonOp_WeekQty = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.WeekQty];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls.WeekQty, objvCurrEduCls_Cond.WeekQty, strComparisonOp_WeekQty);
}
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.WeekStatusID) == true)
{
string strComparisonOp_WeekStatusID = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.WeekStatusID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.WeekStatusID, objvCurrEduCls_Cond.WeekStatusID, strComparisonOp_WeekStatusID);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.CustomerWeek) == true)
{
string strComparisonOp_CustomerWeek = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.CustomerWeek];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.CustomerWeek, objvCurrEduCls_Cond.CustomerWeek, strComparisonOp_CustomerWeek);
}
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.Mark) == true)
{
string strComparisonOp_Mark = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.Mark];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls.Mark, objvCurrEduCls_Cond.Mark, strComparisonOp_Mark);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.id_UniZone) == true)
{
string strComparisonOp_id_UniZone = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.id_UniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.id_UniZone, objvCurrEduCls_Cond.id_UniZone, strComparisonOp_id_UniZone);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.id_GradeBase, objvCurrEduCls_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.GradeBaseID) == true)
{
string strComparisonOp_GradeBaseID = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.GradeBaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.GradeBaseID, objvCurrEduCls_Cond.GradeBaseID, strComparisonOp_GradeBaseID);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.GradeBaseName, objvCurrEduCls_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.GradeBaseNameA) == true)
{
string strComparisonOp_GradeBaseNameA = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.GradeBaseNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.GradeBaseNameA, objvCurrEduCls_Cond.GradeBaseNameA, strComparisonOp_GradeBaseNameA);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.IsEffective) == true)
{
if (objvCurrEduCls_Cond.IsEffective == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls.IsEffective);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls.IsEffective);
}
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.IsForPaperReading) == true)
{
if (objvCurrEduCls_Cond.IsForPaperReading == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls.IsForPaperReading);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls.IsForPaperReading);
}
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.SchoolYear) == true)
{
string strComparisonOp_SchoolYear = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.SchoolYear, objvCurrEduCls_Cond.SchoolYear, strComparisonOp_SchoolYear);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.SchoolTerm) == true)
{
string strComparisonOp_SchoolTerm = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.SchoolTerm, objvCurrEduCls_Cond.SchoolTerm, strComparisonOp_SchoolTerm);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.id_CourseType) == true)
{
string strComparisonOp_id_CourseType = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.id_CourseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.id_CourseType, objvCurrEduCls_Cond.id_CourseType, strComparisonOp_id_CourseType);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.CourseTypeID) == true)
{
string strComparisonOp_CourseTypeID = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.CourseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.CourseTypeID, objvCurrEduCls_Cond.CourseTypeID, strComparisonOp_CourseTypeID);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.CourseTypeName) == true)
{
string strComparisonOp_CourseTypeName = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.CourseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.CourseTypeName, objvCurrEduCls_Cond.CourseTypeName, strComparisonOp_CourseTypeName);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.IsDegree) == true)
{
if (objvCurrEduCls_Cond.IsDegree == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls.IsDegree);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls.IsDegree);
}
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.id_ScoreType) == true)
{
string strComparisonOp_id_ScoreType = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.id_ScoreType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.id_ScoreType, objvCurrEduCls_Cond.id_ScoreType, strComparisonOp_id_ScoreType);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.GetScoreWayId) == true)
{
string strComparisonOp_GetScoreWayId = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.GetScoreWayId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.GetScoreWayId, objvCurrEduCls_Cond.GetScoreWayId, strComparisonOp_GetScoreWayId);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.IsProportionalCtrl) == true)
{
if (objvCurrEduCls_Cond.IsProportionalCtrl == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls.IsProportionalCtrl);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls.IsProportionalCtrl);
}
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.id_ExamType) == true)
{
string strComparisonOp_id_ExamType = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.id_ExamType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.id_ExamType, objvCurrEduCls_Cond.id_ExamType, strComparisonOp_id_ExamType);
}
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.ModifyDate) == true)
{
string strComparisonOp_ModifyDate = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.ModifyDate, objvCurrEduCls_Cond.ModifyDate, strComparisonOp_ModifyDate);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.ModifyUserID) == true)
{
string strComparisonOp_ModifyUserID = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.ModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.ModifyUserID, objvCurrEduCls_Cond.ModifyUserID, strComparisonOp_ModifyUserID);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.Memo) == true)
{
string strComparisonOp_Memo = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.Memo, objvCurrEduCls_Cond.Memo, strComparisonOp_Memo);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.CurrStuNum_Valid) == true)
{
string strComparisonOp_CurrStuNum_Valid = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.CurrStuNum_Valid];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls.CurrStuNum_Valid, objvCurrEduCls_Cond.CurrStuNum_Valid, strComparisonOp_CurrStuNum_Valid);
}
if (objvCurrEduCls_Cond.IsUpdated(convCurrEduCls.CurrStuNum) == true)
{
string strComparisonOp_CurrStuNum = objvCurrEduCls_Cond.dicFldComparisonOp[convCurrEduCls.CurrStuNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls.CurrStuNum, objvCurrEduCls_Cond.CurrStuNum, strComparisonOp_CurrStuNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v当前教学班(vCurrEduCls)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCurrEduClsWApi
{
private static readonly string mstrApiControllerName = "vCurrEduClsApi";

 public clsvCurrEduClsWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v当前教学班]...","0");
List<clsvCurrEduClsEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_CurrEduCls";
objDDL.DataTextField="EduClsName";
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
string strCondition = string.Format("1 =1 Order By {0}", convCurrEduCls.id_CurrEduCls); 
List<clsvCurrEduClsEN> arrObjLst = clsvCurrEduClsWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvCurrEduClsEN objvCurrEduClsEN = new clsvCurrEduClsEN()
{
id_CurrEduCls = "0",
EduClsName = "选[v当前教学班]..."
};
arrObjLst.Insert(0, objvCurrEduClsEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convCurrEduCls.id_CurrEduCls;
objComboBox.DisplayMember = convCurrEduCls.EduClsName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_CurrEduCls">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCurrEduClsEN GetObjByid_CurrEduCls(string strid_CurrEduCls)
{
string strAction = "GetObjByid_CurrEduCls";
string strErrMsg = string.Empty;
string strResult = "";
clsvCurrEduClsEN objvCurrEduClsEN = null;
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
objvCurrEduClsEN = JsonConvert.DeserializeObject<clsvCurrEduClsEN>((string)jobjReturn["ReturnObj"]);
return objvCurrEduClsEN;
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
public static clsvCurrEduClsEN GetObjByid_CurrEduCls_WA_Cache(string strid_CurrEduCls)
{
string strAction = "GetObjByid_CurrEduCls_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCurrEduClsEN objvCurrEduClsEN = null;
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
objvCurrEduClsEN = JsonConvert.DeserializeObject<clsvCurrEduClsEN>((string)jobjReturn["ReturnObj"]);
return objvCurrEduClsEN;
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
public static clsvCurrEduClsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCurrEduClsEN objvCurrEduClsEN = null;
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
objvCurrEduClsEN = JsonConvert.DeserializeObject<clsvCurrEduClsEN>((string)jobjReturn["ReturnObj"]);
return objvCurrEduClsEN;
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
public static clsvCurrEduClsEN GetObjByid_CurrEduCls_Cache(string strid_CurrEduCls)
{
if (string.IsNullOrEmpty(strid_CurrEduCls) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvCurrEduClsEN._CurrTabName_S);
List<clsvCurrEduClsEN> arrvCurrEduClsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCurrEduClsEN> arrvCurrEduClsObjLst_Sel =
from objvCurrEduClsEN in arrvCurrEduClsObjLst_Cache
where objvCurrEduClsEN.id_CurrEduCls == strid_CurrEduCls
select objvCurrEduClsEN;
if (arrvCurrEduClsObjLst_Sel.Count() == 0)
{
   clsvCurrEduClsEN obj = clsvCurrEduClsWApi.GetObjByid_CurrEduCls(strid_CurrEduCls);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCurrEduClsObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_CurrEduCls">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetEduClsNameByid_CurrEduCls_Cache(string strid_CurrEduCls)
{
if (string.IsNullOrEmpty(strid_CurrEduCls) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvCurrEduClsEN._CurrTabName_S);
List<clsvCurrEduClsEN> arrvCurrEduClsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCurrEduClsEN> arrvCurrEduClsObjLst_Sel1 =
from objvCurrEduClsEN in arrvCurrEduClsObjLst_Cache
where objvCurrEduClsEN.id_CurrEduCls == strid_CurrEduCls
select objvCurrEduClsEN;
List <clsvCurrEduClsEN> arrvCurrEduClsObjLst_Sel = new List<clsvCurrEduClsEN>();
foreach (clsvCurrEduClsEN obj in arrvCurrEduClsObjLst_Sel1)
{
arrvCurrEduClsObjLst_Sel.Add(obj);
}
if (arrvCurrEduClsObjLst_Sel.Count > 0)
{
return arrvCurrEduClsObjLst_Sel[0].EduClsName;
}
string strErrMsgForGetObjById = string.Format("在vCurrEduCls对象缓存列表中,找不到记录[id_CurrEduCls = {0}](函数:{1})", strid_CurrEduCls, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvCurrEduClsBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
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
string strKey = string.Format("{0}", clsvCurrEduClsEN._CurrTabName_S);
List<clsvCurrEduClsEN> arrvCurrEduClsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCurrEduClsEN> arrvCurrEduClsObjLst_Sel1 =
from objvCurrEduClsEN in arrvCurrEduClsObjLst_Cache
where objvCurrEduClsEN.id_CurrEduCls == strid_CurrEduCls
select objvCurrEduClsEN;
List <clsvCurrEduClsEN> arrvCurrEduClsObjLst_Sel = new List<clsvCurrEduClsEN>();
foreach (clsvCurrEduClsEN obj in arrvCurrEduClsObjLst_Sel1)
{
arrvCurrEduClsObjLst_Sel.Add(obj);
}
if (arrvCurrEduClsObjLst_Sel.Count > 0)
{
return arrvCurrEduClsObjLst_Sel[0].EduClsName;
}
string strErrMsgForGetObjById = string.Format("在vCurrEduCls对象缓存列表中,找不到记录的相关名称[id_CurrEduCls = {0}](函数:{1})", strid_CurrEduCls, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvCurrEduClsBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduClsEN> GetObjLst(string strWhereCond)
{
 List<clsvCurrEduClsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsEN> GetObjLstById_CurrEduClsLst(List<string> arrId_CurrEduCls)
{
 List<clsvCurrEduClsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvCurrEduClsEN> GetObjLstById_CurrEduClsLst_Cache(List<string> arrId_CurrEduCls)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCurrEduClsEN._CurrTabName_S);
List<clsvCurrEduClsEN> arrvCurrEduClsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCurrEduClsEN> arrvCurrEduClsObjLst_Sel =
from objvCurrEduClsEN in arrvCurrEduClsObjLst_Cache
where arrId_CurrEduCls.Contains(objvCurrEduClsEN.id_CurrEduCls)
select objvCurrEduClsEN;
return arrvCurrEduClsObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduClsEN> GetObjLstById_CurrEduClsLst_WA_Cache(List<string> arrId_CurrEduCls)
{
 List<clsvCurrEduClsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCurrEduClsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCurrEduClsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCurrEduClsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCurrEduClsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvCurrEduClsENS">源对象</param>
 /// <param name = "objvCurrEduClsENT">目标对象</param>
 public static void CopyTo(clsvCurrEduClsEN objvCurrEduClsENS, clsvCurrEduClsEN objvCurrEduClsENT)
{
try
{
objvCurrEduClsENT.id_CurrEduCls = objvCurrEduClsENS.id_CurrEduCls; //当前教学班流水号
objvCurrEduClsENT.CurrEduClsId = objvCurrEduClsENS.CurrEduClsId; //当前教学班Id
objvCurrEduClsENT.EduClsName = objvCurrEduClsENS.EduClsName; //教学班名称
objvCurrEduClsENT.EduClsTypeId = objvCurrEduClsENS.EduClsTypeId; //教学班类型代号
objvCurrEduClsENT.EduClsTypeName = objvCurrEduClsENS.EduClsTypeName; //教学班类型名称
objvCurrEduClsENT.CourseId = objvCurrEduClsENS.CourseId; //课程Id
objvCurrEduClsENT.CourseCode = objvCurrEduClsENS.CourseCode; //课程代码
objvCurrEduClsENT.CourseDescription = objvCurrEduClsENS.CourseDescription; //课程描述
objvCurrEduClsENT.CourseName = objvCurrEduClsENS.CourseName; //课程名称
objvCurrEduClsENT.ViewCount = objvCurrEduClsENS.ViewCount; //浏览量
objvCurrEduClsENT.ExampleImgPath = objvCurrEduClsENS.ExampleImgPath; //示例图路径
objvCurrEduClsENT.TeachingSolutionId = objvCurrEduClsENS.TeachingSolutionId; //教学方案Id
objvCurrEduClsENT.TeachingSolutionName = objvCurrEduClsENS.TeachingSolutionName; //教学方案名称
objvCurrEduClsENT.id_Teacher = objvCurrEduClsENS.id_Teacher; //教师流水号
objvCurrEduClsENT.TeacherID = objvCurrEduClsENS.TeacherID; //教师工号
objvCurrEduClsENT.TeacherName = objvCurrEduClsENS.TeacherName; //教师姓名
objvCurrEduClsENT.id_XzCollege = objvCurrEduClsENS.id_XzCollege; //学院流水号
objvCurrEduClsENT.CollegeID = objvCurrEduClsENS.CollegeID; //学院ID
objvCurrEduClsENT.CollegeName = objvCurrEduClsENS.CollegeName; //学院名称
objvCurrEduClsENT.ClgEnglishName = objvCurrEduClsENS.ClgEnglishName; //ClgEnglishName
objvCurrEduClsENT.PhoneNumber = objvCurrEduClsENS.PhoneNumber; //PhoneNumber
objvCurrEduClsENT.id_XzMajor = objvCurrEduClsENS.id_XzMajor; //专业流水号
objvCurrEduClsENT.MajorName = objvCurrEduClsENS.MajorName; //专业名称
objvCurrEduClsENT.id_EduWay = objvCurrEduClsENS.id_EduWay; //教学方式流水号
objvCurrEduClsENT.id_ClassRoomType = objvCurrEduClsENS.id_ClassRoomType; //教室类型流水号
objvCurrEduClsENT.TotalLessonQty = objvCurrEduClsENS.TotalLessonQty; //总课时数
objvCurrEduClsENT.MaxStuQty = objvCurrEduClsENS.MaxStuQty; //最大学生数
objvCurrEduClsENT.WeekQty = objvCurrEduClsENS.WeekQty; //总周数
objvCurrEduClsENT.ScheUnitPW = objvCurrEduClsENS.ScheUnitPW; //周排课次数
objvCurrEduClsENT.WeekStatusID = objvCurrEduClsENS.WeekStatusID; //周状态编号(单,双,全周)
objvCurrEduClsENT.CustomerWeek = objvCurrEduClsENS.CustomerWeek; //自定义上课周
objvCurrEduClsENT.LessonQtyPerWeek = objvCurrEduClsENS.LessonQtyPerWeek; //周课时数
objvCurrEduClsENT.Mark = objvCurrEduClsENS.Mark; //获得学分
objvCurrEduClsENT.id_UniZone = objvCurrEduClsENS.id_UniZone; //校区流水号
objvCurrEduClsENT.id_GradeBase = objvCurrEduClsENS.id_GradeBase; //年级流水号
objvCurrEduClsENT.GradeBaseID = objvCurrEduClsENS.GradeBaseID; //年级代号
objvCurrEduClsENT.GradeBaseName = objvCurrEduClsENS.GradeBaseName; //年级名称
objvCurrEduClsENT.GradeBaseNameA = objvCurrEduClsENS.GradeBaseNameA; //年级名称缩写
objvCurrEduClsENT.IsEffective = objvCurrEduClsENS.IsEffective; //是否有效
objvCurrEduClsENT.IsForPaperReading = objvCurrEduClsENS.IsForPaperReading; //是否参与论文阅读
objvCurrEduClsENT.SchoolYear = objvCurrEduClsENS.SchoolYear; //学年
objvCurrEduClsENT.SchoolTerm = objvCurrEduClsENS.SchoolTerm; //学期
objvCurrEduClsENT.id_CourseType = objvCurrEduClsENS.id_CourseType; //课程类型流水号
objvCurrEduClsENT.CourseTypeID = objvCurrEduClsENS.CourseTypeID; //课程类型ID
objvCurrEduClsENT.CourseTypeName = objvCurrEduClsENS.CourseTypeName; //课程类型名称
objvCurrEduClsENT.IsDegree = objvCurrEduClsENS.IsDegree; //是否学位课
objvCurrEduClsENT.id_ScoreType = objvCurrEduClsENS.id_ScoreType; //成绩类型流水号
objvCurrEduClsENT.GetScoreWayId = objvCurrEduClsENS.GetScoreWayId; //获得成绩方式Id
objvCurrEduClsENT.IsProportionalCtrl = objvCurrEduClsENS.IsProportionalCtrl; //是否比例控制
objvCurrEduClsENT.id_ExamType = objvCurrEduClsENS.id_ExamType; //考试方式流水号
objvCurrEduClsENT.BeginWeek = objvCurrEduClsENS.BeginWeek; //开始周
objvCurrEduClsENT.ModifyDate = objvCurrEduClsENS.ModifyDate; //修改日期
objvCurrEduClsENT.ModifyUserID = objvCurrEduClsENS.ModifyUserID; //修改人
objvCurrEduClsENT.Memo = objvCurrEduClsENS.Memo; //备注
objvCurrEduClsENT.CurrStuNum_Valid = objvCurrEduClsENS.CurrStuNum_Valid; //CurrStuNum_Valid
objvCurrEduClsENT.CurrStuNum = objvCurrEduClsENS.CurrStuNum; //当前学生数
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
public static DataTable ToDataTable(List<clsvCurrEduClsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCurrEduClsEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCurrEduClsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCurrEduClsEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCurrEduClsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCurrEduClsEN.AttributeName)
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
//if (arrvCurrEduClsObjLst_Cache == null)
//{
//arrvCurrEduClsObjLst_Cache = await clsvCurrEduClsWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCurrEduClsEN._CurrTabName_S);
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
public static List<clsvCurrEduClsEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCurrEduClsEN._CurrTabName_S);
List<clsvCurrEduClsEN> arrvCurrEduClsObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCurrEduClsObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCurrEduClsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCurrEduCls.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.CurrEduClsId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.EduClsName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.EduClsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.EduClsTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.CourseDescription, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduCls.ExampleImgPath, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.TeachingSolutionId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.TeachingSolutionName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.id_Teacher, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.TeacherID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.TeacherName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.ClgEnglishName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.PhoneNumber, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.id_EduWay, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.id_ClassRoomType, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.TotalLessonQty, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduCls.MaxStuQty, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduCls.WeekQty, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduCls.ScheUnitPW, Type.GetType("System.Int16"));
objDT.Columns.Add(convCurrEduCls.WeekStatusID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.CustomerWeek, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.LessonQtyPerWeek, Type.GetType("System.Int16"));
objDT.Columns.Add(convCurrEduCls.Mark, Type.GetType("System.Decimal"));
objDT.Columns.Add(convCurrEduCls.id_UniZone, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.GradeBaseID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.GradeBaseNameA, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.IsEffective, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduCls.IsForPaperReading, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduCls.SchoolYear, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.SchoolTerm, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.id_CourseType, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.CourseTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.CourseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.IsDegree, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduCls.id_ScoreType, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.GetScoreWayId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.IsProportionalCtrl, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduCls.id_ExamType, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.BeginWeek, Type.GetType("System.Int16"));
objDT.Columns.Add(convCurrEduCls.ModifyDate, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.ModifyUserID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls.CurrStuNum_Valid, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduCls.CurrStuNum, Type.GetType("System.Int32"));
foreach (clsvCurrEduClsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCurrEduCls.id_CurrEduCls] = objInFor[convCurrEduCls.id_CurrEduCls];
objDR[convCurrEduCls.CurrEduClsId] = objInFor[convCurrEduCls.CurrEduClsId];
objDR[convCurrEduCls.EduClsName] = objInFor[convCurrEduCls.EduClsName];
objDR[convCurrEduCls.EduClsTypeId] = objInFor[convCurrEduCls.EduClsTypeId];
objDR[convCurrEduCls.EduClsTypeName] = objInFor[convCurrEduCls.EduClsTypeName];
objDR[convCurrEduCls.CourseId] = objInFor[convCurrEduCls.CourseId];
objDR[convCurrEduCls.CourseCode] = objInFor[convCurrEduCls.CourseCode];
objDR[convCurrEduCls.CourseDescription] = objInFor[convCurrEduCls.CourseDescription];
objDR[convCurrEduCls.CourseName] = objInFor[convCurrEduCls.CourseName];
objDR[convCurrEduCls.ViewCount] = objInFor[convCurrEduCls.ViewCount];
objDR[convCurrEduCls.ExampleImgPath] = objInFor[convCurrEduCls.ExampleImgPath];
objDR[convCurrEduCls.TeachingSolutionId] = objInFor[convCurrEduCls.TeachingSolutionId];
objDR[convCurrEduCls.TeachingSolutionName] = objInFor[convCurrEduCls.TeachingSolutionName];
objDR[convCurrEduCls.id_Teacher] = objInFor[convCurrEduCls.id_Teacher];
objDR[convCurrEduCls.TeacherID] = objInFor[convCurrEduCls.TeacherID];
objDR[convCurrEduCls.TeacherName] = objInFor[convCurrEduCls.TeacherName];
objDR[convCurrEduCls.id_XzCollege] = objInFor[convCurrEduCls.id_XzCollege];
objDR[convCurrEduCls.CollegeID] = objInFor[convCurrEduCls.CollegeID];
objDR[convCurrEduCls.CollegeName] = objInFor[convCurrEduCls.CollegeName];
objDR[convCurrEduCls.ClgEnglishName] = objInFor[convCurrEduCls.ClgEnglishName];
objDR[convCurrEduCls.PhoneNumber] = objInFor[convCurrEduCls.PhoneNumber];
objDR[convCurrEduCls.id_XzMajor] = objInFor[convCurrEduCls.id_XzMajor];
objDR[convCurrEduCls.MajorName] = objInFor[convCurrEduCls.MajorName];
objDR[convCurrEduCls.id_EduWay] = objInFor[convCurrEduCls.id_EduWay];
objDR[convCurrEduCls.id_ClassRoomType] = objInFor[convCurrEduCls.id_ClassRoomType];
objDR[convCurrEduCls.TotalLessonQty] = objInFor[convCurrEduCls.TotalLessonQty];
objDR[convCurrEduCls.MaxStuQty] = objInFor[convCurrEduCls.MaxStuQty];
objDR[convCurrEduCls.WeekQty] = objInFor[convCurrEduCls.WeekQty];
objDR[convCurrEduCls.ScheUnitPW] = objInFor[convCurrEduCls.ScheUnitPW];
objDR[convCurrEduCls.WeekStatusID] = objInFor[convCurrEduCls.WeekStatusID];
objDR[convCurrEduCls.CustomerWeek] = objInFor[convCurrEduCls.CustomerWeek];
objDR[convCurrEduCls.LessonQtyPerWeek] = objInFor[convCurrEduCls.LessonQtyPerWeek];
objDR[convCurrEduCls.Mark] = objInFor[convCurrEduCls.Mark];
objDR[convCurrEduCls.id_UniZone] = objInFor[convCurrEduCls.id_UniZone];
objDR[convCurrEduCls.id_GradeBase] = objInFor[convCurrEduCls.id_GradeBase];
objDR[convCurrEduCls.GradeBaseID] = objInFor[convCurrEduCls.GradeBaseID];
objDR[convCurrEduCls.GradeBaseName] = objInFor[convCurrEduCls.GradeBaseName];
objDR[convCurrEduCls.GradeBaseNameA] = objInFor[convCurrEduCls.GradeBaseNameA];
objDR[convCurrEduCls.IsEffective] = objInFor[convCurrEduCls.IsEffective];
objDR[convCurrEduCls.IsForPaperReading] = objInFor[convCurrEduCls.IsForPaperReading];
objDR[convCurrEduCls.SchoolYear] = objInFor[convCurrEduCls.SchoolYear];
objDR[convCurrEduCls.SchoolTerm] = objInFor[convCurrEduCls.SchoolTerm];
objDR[convCurrEduCls.id_CourseType] = objInFor[convCurrEduCls.id_CourseType];
objDR[convCurrEduCls.CourseTypeID] = objInFor[convCurrEduCls.CourseTypeID];
objDR[convCurrEduCls.CourseTypeName] = objInFor[convCurrEduCls.CourseTypeName];
objDR[convCurrEduCls.IsDegree] = objInFor[convCurrEduCls.IsDegree];
objDR[convCurrEduCls.id_ScoreType] = objInFor[convCurrEduCls.id_ScoreType];
objDR[convCurrEduCls.GetScoreWayId] = objInFor[convCurrEduCls.GetScoreWayId];
objDR[convCurrEduCls.IsProportionalCtrl] = objInFor[convCurrEduCls.IsProportionalCtrl];
objDR[convCurrEduCls.id_ExamType] = objInFor[convCurrEduCls.id_ExamType];
objDR[convCurrEduCls.BeginWeek] = objInFor[convCurrEduCls.BeginWeek];
objDR[convCurrEduCls.ModifyDate] = objInFor[convCurrEduCls.ModifyDate];
objDR[convCurrEduCls.ModifyUserID] = objInFor[convCurrEduCls.ModifyUserID];
objDR[convCurrEduCls.Memo] = objInFor[convCurrEduCls.Memo];
objDR[convCurrEduCls.CurrStuNum_Valid] = objInFor[convCurrEduCls.CurrStuNum_Valid];
objDR[convCurrEduCls.CurrStuNum] = objInFor[convCurrEduCls.CurrStuNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}