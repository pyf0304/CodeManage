
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCurrEduClsBL
 表名:vCurrEduCls(01120126)
 * 版本:2024.03.11.1(服务器:WIN-SRV103-116)
 日期:2024/03/18 12:58:42
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
public static class  clsvCurrEduClsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCurrEduCls">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCurrEduClsEN GetObj(this K_IdCurrEduCls_vCurrEduCls myKey)
{
clsvCurrEduClsEN objvCurrEduClsEN = clsvCurrEduClsBL.vCurrEduClsDA.GetObjByIdCurrEduCls(myKey.Value);
return objvCurrEduClsEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetIdCurrEduCls(this clsvCurrEduClsEN objvCurrEduClsEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convCurrEduCls.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convCurrEduCls.IdCurrEduCls);
}
objvCurrEduClsEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.IdCurrEduCls) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.IdCurrEduCls, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.IdCurrEduCls] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetCurrEduClsId(this clsvCurrEduClsEN objvCurrEduClsEN, string strCurrEduClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCurrEduClsId, convCurrEduCls.CurrEduClsId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, convCurrEduCls.CurrEduClsId);
}
objvCurrEduClsEN.CurrEduClsId = strCurrEduClsId; //教学班Id
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetEduClsName(this clsvCurrEduClsEN objvCurrEduClsEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduClsName, convCurrEduCls.EduClsName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convCurrEduCls.EduClsName);
}
objvCurrEduClsEN.EduClsName = strEduClsName; //教学班名
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetEduClsTypeId(this clsvCurrEduClsEN objvCurrEduClsEN, string strEduClsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduClsTypeId, convCurrEduCls.EduClsTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsTypeId, 4, convCurrEduCls.EduClsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEduClsTypeId, 4, convCurrEduCls.EduClsTypeId);
}
objvCurrEduClsEN.EduClsTypeId = strEduClsTypeId; //教学班类型Id
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetEduClsTypeName(this clsvCurrEduClsEN objvCurrEduClsEN, string strEduClsTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsTypeName, 100, convCurrEduCls.EduClsTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetCourseId(this clsvCurrEduClsEN objvCurrEduClsEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCurrEduCls.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCurrEduCls.CourseId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetCourseCode(this clsvCurrEduClsEN objvCurrEduClsEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCurrEduCls.CourseCode);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetCourseDescription(this clsvCurrEduClsEN objvCurrEduClsEN, string strCourseDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseDescription, 8000, convCurrEduCls.CourseDescription);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetCourseName(this clsvCurrEduClsEN objvCurrEduClsEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCurrEduCls.CourseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetViewCount(this clsvCurrEduClsEN objvCurrEduClsEN, int? intViewCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetExampleImgPath(this clsvCurrEduClsEN objvCurrEduClsEN, string strExampleImgPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExampleImgPath, 300, convCurrEduCls.ExampleImgPath);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetTeachingSolutionId(this clsvCurrEduClsEN objvCurrEduClsEN, string strTeachingSolutionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingSolutionId, convCurrEduCls.TeachingSolutionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingSolutionId, 8, convCurrEduCls.TeachingSolutionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingSolutionId, 8, convCurrEduCls.TeachingSolutionId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetTeachingSolutionName(this clsvCurrEduClsEN objvCurrEduClsEN, string strTeachingSolutionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingSolutionName, 100, convCurrEduCls.TeachingSolutionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetIdTeacher(this clsvCurrEduClsEN objvCurrEduClsEN, string strIdTeacher, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeacher, 8, convCurrEduCls.IdTeacher);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeacher, 8, convCurrEduCls.IdTeacher);
}
objvCurrEduClsEN.IdTeacher = strIdTeacher; //教师流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.IdTeacher) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.IdTeacher, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.IdTeacher] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetTeacherId(this clsvCurrEduClsEN objvCurrEduClsEN, string strTeacherId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeacherId, 12, convCurrEduCls.TeacherId);
}
objvCurrEduClsEN.TeacherId = strTeacherId; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.TeacherId) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.TeacherId, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.TeacherId] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetTeacherName(this clsvCurrEduClsEN objvCurrEduClsEN, string strTeacherName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeacherName, 50, convCurrEduCls.TeacherName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetIdXzCollege(this clsvCurrEduClsEN objvCurrEduClsEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convCurrEduCls.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convCurrEduCls.IdXzCollege);
}
objvCurrEduClsEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.IdXzCollege) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.IdXzCollege, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.IdXzCollege] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetCollegeId(this clsvCurrEduClsEN objvCurrEduClsEN, string strCollegeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeId, 4, convCurrEduCls.CollegeId);
}
objvCurrEduClsEN.CollegeId = strCollegeId; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.CollegeId) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.CollegeId, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.CollegeId] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetCollegeName(this clsvCurrEduClsEN objvCurrEduClsEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCurrEduCls.CollegeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetClgEnglishName(this clsvCurrEduClsEN objvCurrEduClsEN, string strClgEnglishName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClgEnglishName, 60, convCurrEduCls.ClgEnglishName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetPhoneNumber(this clsvCurrEduClsEN objvCurrEduClsEN, string strPhoneNumber, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPhoneNumber, 15, convCurrEduCls.PhoneNumber);
}
objvCurrEduClsEN.PhoneNumber = strPhoneNumber; //电话
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetIdXzMajor(this clsvCurrEduClsEN objvCurrEduClsEN, string strIdXzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzMajor, convCurrEduCls.IdXzMajor);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convCurrEduCls.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convCurrEduCls.IdXzMajor);
}
objvCurrEduClsEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.IdXzMajor) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.IdXzMajor, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.IdXzMajor] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetMajorName(this clsvCurrEduClsEN objvCurrEduClsEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convCurrEduCls.MajorName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetIdEduWay(this clsvCurrEduClsEN objvCurrEduClsEN, string strIdEduWay, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdEduWay, convCurrEduCls.IdEduWay);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdEduWay, 4, convCurrEduCls.IdEduWay);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdEduWay, 4, convCurrEduCls.IdEduWay);
}
objvCurrEduClsEN.IdEduWay = strIdEduWay; //教学方式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.IdEduWay) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.IdEduWay, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.IdEduWay] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetIdClassRoomType(this clsvCurrEduClsEN objvCurrEduClsEN, string strIdClassRoomType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdClassRoomType, convCurrEduCls.IdClassRoomType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdClassRoomType, 4, convCurrEduCls.IdClassRoomType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdClassRoomType, 4, convCurrEduCls.IdClassRoomType);
}
objvCurrEduClsEN.IdClassRoomType = strIdClassRoomType; //教室类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.IdClassRoomType) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.IdClassRoomType, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.IdClassRoomType] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetMaxStuQty(this clsvCurrEduClsEN objvCurrEduClsEN, int? intMaxStuQty, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetWeekQty(this clsvCurrEduClsEN objvCurrEduClsEN, int? intWeekQty, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetScheUnitPW(this clsvCurrEduClsEN objvCurrEduClsEN, short? shtScheUnitPW, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetWeekStatusId(this clsvCurrEduClsEN objvCurrEduClsEN, string strWeekStatusId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWeekStatusId, 2, convCurrEduCls.WeekStatusId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWeekStatusId, 2, convCurrEduCls.WeekStatusId);
}
objvCurrEduClsEN.WeekStatusId = strWeekStatusId; //周状态编号(单,双,全周)
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.WeekStatusId) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.WeekStatusId, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.WeekStatusId] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetCustomerWeek(this clsvCurrEduClsEN objvCurrEduClsEN, string strCustomerWeek, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCustomerWeek, 50, convCurrEduCls.CustomerWeek);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetLessonQtyPerWeek(this clsvCurrEduClsEN objvCurrEduClsEN, short? shtLessonQtyPerWeek, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetMark(this clsvCurrEduClsEN objvCurrEduClsEN, double? dblMark, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetIdUniZone(this clsvCurrEduClsEN objvCurrEduClsEN, string strIdUniZone, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdUniZone, 4, convCurrEduCls.IdUniZone);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdUniZone, 4, convCurrEduCls.IdUniZone);
}
objvCurrEduClsEN.IdUniZone = strIdUniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.IdUniZone) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.IdUniZone, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.IdUniZone] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetIdGradeBase(this clsvCurrEduClsEN objvCurrEduClsEN, string strIdGradeBase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, convCurrEduCls.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, convCurrEduCls.IdGradeBase);
}
objvCurrEduClsEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.IdGradeBase) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.IdGradeBase, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.IdGradeBase] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetGradeBaseId(this clsvCurrEduClsEN objvCurrEduClsEN, string strGradeBaseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseId, 4, convCurrEduCls.GradeBaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGradeBaseId, 4, convCurrEduCls.GradeBaseId);
}
objvCurrEduClsEN.GradeBaseId = strGradeBaseId; //年级代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.GradeBaseId) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.GradeBaseId, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.GradeBaseId] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetGradeBaseName(this clsvCurrEduClsEN objvCurrEduClsEN, string strGradeBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convCurrEduCls.GradeBaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetGradeBaseNameA(this clsvCurrEduClsEN objvCurrEduClsEN, string strGradeBaseNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseNameA, 10, convCurrEduCls.GradeBaseNameA);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetSchoolYear(this clsvCurrEduClsEN objvCurrEduClsEN, string strSchoolYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, convCurrEduCls.SchoolYear);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetSchoolTerm(this clsvCurrEduClsEN objvCurrEduClsEN, string strSchoolTerm, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, convCurrEduCls.SchoolTerm);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, convCurrEduCls.SchoolTerm);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetIdCourseType(this clsvCurrEduClsEN objvCurrEduClsEN, string strIdCourseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCourseType, convCurrEduCls.IdCourseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCourseType, 4, convCurrEduCls.IdCourseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCourseType, 4, convCurrEduCls.IdCourseType);
}
objvCurrEduClsEN.IdCourseType = strIdCourseType; //课程类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.IdCourseType) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.IdCourseType, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.IdCourseType] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetCourseTypeId(this clsvCurrEduClsEN objvCurrEduClsEN, string strCourseTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseTypeId, 4, convCurrEduCls.CourseTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseTypeId, 4, convCurrEduCls.CourseTypeId);
}
objvCurrEduClsEN.CourseTypeId = strCourseTypeId; //课程类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.CourseTypeId) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.CourseTypeId, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.CourseTypeId] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetCourseTypeName(this clsvCurrEduClsEN objvCurrEduClsEN, string strCourseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseTypeName, 30, convCurrEduCls.CourseTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetIdScoreType(this clsvCurrEduClsEN objvCurrEduClsEN, string strIdScoreType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdScoreType, 4, convCurrEduCls.IdScoreType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdScoreType, 4, convCurrEduCls.IdScoreType);
}
objvCurrEduClsEN.IdScoreType = strIdScoreType; //成绩类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.IdScoreType) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.IdScoreType, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.IdScoreType] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetGetScoreWayId(this clsvCurrEduClsEN objvCurrEduClsEN, string strGetScoreWayId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGetScoreWayId, 2, convCurrEduCls.GetScoreWayId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGetScoreWayId, 2, convCurrEduCls.GetScoreWayId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetIdExamType(this clsvCurrEduClsEN objvCurrEduClsEN, string strIdExamType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdExamType, 4, convCurrEduCls.IdExamType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdExamType, 4, convCurrEduCls.IdExamType);
}
objvCurrEduClsEN.IdExamType = strIdExamType; //考试方式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.IdExamType) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.IdExamType, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.IdExamType] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetBeginWeek(this clsvCurrEduClsEN objvCurrEduClsEN, short? shtBeginWeek, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetUserType(this clsvCurrEduClsEN objvCurrEduClsEN, string strUserType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserType, 50, convCurrEduCls.UserType);
}
objvCurrEduClsEN.UserType = strUserType; //用户类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.UserType) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.UserType, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.UserType] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetModifyDate(this clsvCurrEduClsEN objvCurrEduClsEN, string strModifyDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyDate, 20, convCurrEduCls.ModifyDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetModifyUserId(this clsvCurrEduClsEN objvCurrEduClsEN, string strModifyUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyUserId, 18, convCurrEduCls.ModifyUserId);
}
objvCurrEduClsEN.ModifyUserId = strModifyUserId; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.ModifyUserId) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.ModifyUserId, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.ModifyUserId] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetMemo(this clsvCurrEduClsEN objvCurrEduClsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCurrEduCls.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetCurrStuNumValid(this clsvCurrEduClsEN objvCurrEduClsEN, int? intCurrStuNumValid, string strComparisonOp="")
	{
objvCurrEduClsEN.CurrStuNumValid = intCurrStuNumValid; //CurrStuNum_Valid
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsEN.dicFldComparisonOp.ContainsKey(convCurrEduCls.CurrStuNumValid) == false)
{
objvCurrEduClsEN.dicFldComparisonOp.Add(convCurrEduCls.CurrStuNumValid, strComparisonOp);
}
else
{
objvCurrEduClsEN.dicFldComparisonOp[convCurrEduCls.CurrStuNumValid] = strComparisonOp;
}
}
return objvCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsEN SetCurrStuNum(this clsvCurrEduClsEN objvCurrEduClsEN, int? intCurrStuNum, string strComparisonOp="")
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCurrEduClsENS">源对象</param>
 /// <param name = "objvCurrEduClsENT">目标对象</param>
 public static void CopyTo(this clsvCurrEduClsEN objvCurrEduClsENS, clsvCurrEduClsEN objvCurrEduClsENT)
{
try
{
objvCurrEduClsENT.IdCurrEduCls = objvCurrEduClsENS.IdCurrEduCls; //教学班流水号
objvCurrEduClsENT.CurrEduClsId = objvCurrEduClsENS.CurrEduClsId; //教学班Id
objvCurrEduClsENT.EduClsName = objvCurrEduClsENS.EduClsName; //教学班名
objvCurrEduClsENT.EduClsTypeId = objvCurrEduClsENS.EduClsTypeId; //教学班类型Id
objvCurrEduClsENT.EduClsTypeName = objvCurrEduClsENS.EduClsTypeName; //教学班类型名称
objvCurrEduClsENT.CourseId = objvCurrEduClsENS.CourseId; //课程Id
objvCurrEduClsENT.CourseCode = objvCurrEduClsENS.CourseCode; //课程代码
objvCurrEduClsENT.CourseDescription = objvCurrEduClsENS.CourseDescription; //课程描述
objvCurrEduClsENT.CourseName = objvCurrEduClsENS.CourseName; //课程名称
objvCurrEduClsENT.ViewCount = objvCurrEduClsENS.ViewCount; //浏览量
objvCurrEduClsENT.ExampleImgPath = objvCurrEduClsENS.ExampleImgPath; //示例图路径
objvCurrEduClsENT.TeachingSolutionId = objvCurrEduClsENS.TeachingSolutionId; //教学方案Id
objvCurrEduClsENT.TeachingSolutionName = objvCurrEduClsENS.TeachingSolutionName; //教学方案名称
objvCurrEduClsENT.IdTeacher = objvCurrEduClsENS.IdTeacher; //教师流水号
objvCurrEduClsENT.TeacherId = objvCurrEduClsENS.TeacherId; //教师工号
objvCurrEduClsENT.TeacherName = objvCurrEduClsENS.TeacherName; //教师姓名
objvCurrEduClsENT.IdXzCollege = objvCurrEduClsENS.IdXzCollege; //学院流水号
objvCurrEduClsENT.CollegeId = objvCurrEduClsENS.CollegeId; //学院ID
objvCurrEduClsENT.CollegeName = objvCurrEduClsENS.CollegeName; //学院名称
objvCurrEduClsENT.ClgEnglishName = objvCurrEduClsENS.ClgEnglishName; //ClgEnglishName
objvCurrEduClsENT.PhoneNumber = objvCurrEduClsENS.PhoneNumber; //电话
objvCurrEduClsENT.IdXzMajor = objvCurrEduClsENS.IdXzMajor; //专业流水号
objvCurrEduClsENT.MajorName = objvCurrEduClsENS.MajorName; //专业名称
objvCurrEduClsENT.IdEduWay = objvCurrEduClsENS.IdEduWay; //教学方式流水号
objvCurrEduClsENT.IdClassRoomType = objvCurrEduClsENS.IdClassRoomType; //教室类型流水号
objvCurrEduClsENT.TotalLessonQty = objvCurrEduClsENS.TotalLessonQty; //总课时数
objvCurrEduClsENT.MaxStuQty = objvCurrEduClsENS.MaxStuQty; //最大学生数
objvCurrEduClsENT.WeekQty = objvCurrEduClsENS.WeekQty; //总周数
objvCurrEduClsENT.ScheUnitPW = objvCurrEduClsENS.ScheUnitPW; //周排课次数
objvCurrEduClsENT.WeekStatusId = objvCurrEduClsENS.WeekStatusId; //周状态编号(单,双,全周)
objvCurrEduClsENT.CustomerWeek = objvCurrEduClsENS.CustomerWeek; //自定义上课周
objvCurrEduClsENT.LessonQtyPerWeek = objvCurrEduClsENS.LessonQtyPerWeek; //周课时数
objvCurrEduClsENT.Mark = objvCurrEduClsENS.Mark; //获得学分
objvCurrEduClsENT.IdUniZone = objvCurrEduClsENS.IdUniZone; //校区流水号
objvCurrEduClsENT.IdGradeBase = objvCurrEduClsENS.IdGradeBase; //年级流水号
objvCurrEduClsENT.GradeBaseId = objvCurrEduClsENS.GradeBaseId; //年级代号
objvCurrEduClsENT.GradeBaseName = objvCurrEduClsENS.GradeBaseName; //年级名称
objvCurrEduClsENT.GradeBaseNameA = objvCurrEduClsENS.GradeBaseNameA; //年级名称缩写
objvCurrEduClsENT.IsEffective = objvCurrEduClsENS.IsEffective; //是否有效
objvCurrEduClsENT.IsForPaperReading = objvCurrEduClsENS.IsForPaperReading; //是否参与论文阅读
objvCurrEduClsENT.SchoolYear = objvCurrEduClsENS.SchoolYear; //学年
objvCurrEduClsENT.SchoolTerm = objvCurrEduClsENS.SchoolTerm; //学期
objvCurrEduClsENT.IdCourseType = objvCurrEduClsENS.IdCourseType; //课程类型流水号
objvCurrEduClsENT.CourseTypeId = objvCurrEduClsENS.CourseTypeId; //课程类型ID
objvCurrEduClsENT.CourseTypeName = objvCurrEduClsENS.CourseTypeName; //课程类型名称
objvCurrEduClsENT.IsDegree = objvCurrEduClsENS.IsDegree; //是否学位课
objvCurrEduClsENT.IdScoreType = objvCurrEduClsENS.IdScoreType; //成绩类型流水号
objvCurrEduClsENT.GetScoreWayId = objvCurrEduClsENS.GetScoreWayId; //获得成绩方式Id
objvCurrEduClsENT.IsProportionalCtrl = objvCurrEduClsENS.IsProportionalCtrl; //是否比例控制
objvCurrEduClsENT.IdExamType = objvCurrEduClsENS.IdExamType; //考试方式流水号
objvCurrEduClsENT.BeginWeek = objvCurrEduClsENS.BeginWeek; //开始周
objvCurrEduClsENT.UserType = objvCurrEduClsENS.UserType; //用户类型
objvCurrEduClsENT.ModifyDate = objvCurrEduClsENS.ModifyDate; //修改日期
objvCurrEduClsENT.ModifyUserId = objvCurrEduClsENS.ModifyUserId; //修改人
objvCurrEduClsENT.Memo = objvCurrEduClsENS.Memo; //备注
objvCurrEduClsENT.CurrStuNumValid = objvCurrEduClsENS.CurrStuNumValid; //CurrStuNum_Valid
objvCurrEduClsENT.CurrStuNum = objvCurrEduClsENS.CurrStuNum; //当前学生数
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
 /// <param name = "objvCurrEduClsENS">源对象</param>
 /// <returns>目标对象=>clsvCurrEduClsEN:objvCurrEduClsENT</returns>
 public static clsvCurrEduClsEN CopyTo(this clsvCurrEduClsEN objvCurrEduClsENS)
{
try
{
 clsvCurrEduClsEN objvCurrEduClsENT = new clsvCurrEduClsEN()
{
IdCurrEduCls = objvCurrEduClsENS.IdCurrEduCls, //教学班流水号
CurrEduClsId = objvCurrEduClsENS.CurrEduClsId, //教学班Id
EduClsName = objvCurrEduClsENS.EduClsName, //教学班名
EduClsTypeId = objvCurrEduClsENS.EduClsTypeId, //教学班类型Id
EduClsTypeName = objvCurrEduClsENS.EduClsTypeName, //教学班类型名称
CourseId = objvCurrEduClsENS.CourseId, //课程Id
CourseCode = objvCurrEduClsENS.CourseCode, //课程代码
CourseDescription = objvCurrEduClsENS.CourseDescription, //课程描述
CourseName = objvCurrEduClsENS.CourseName, //课程名称
ViewCount = objvCurrEduClsENS.ViewCount, //浏览量
ExampleImgPath = objvCurrEduClsENS.ExampleImgPath, //示例图路径
TeachingSolutionId = objvCurrEduClsENS.TeachingSolutionId, //教学方案Id
TeachingSolutionName = objvCurrEduClsENS.TeachingSolutionName, //教学方案名称
IdTeacher = objvCurrEduClsENS.IdTeacher, //教师流水号
TeacherId = objvCurrEduClsENS.TeacherId, //教师工号
TeacherName = objvCurrEduClsENS.TeacherName, //教师姓名
IdXzCollege = objvCurrEduClsENS.IdXzCollege, //学院流水号
CollegeId = objvCurrEduClsENS.CollegeId, //学院ID
CollegeName = objvCurrEduClsENS.CollegeName, //学院名称
ClgEnglishName = objvCurrEduClsENS.ClgEnglishName, //ClgEnglishName
PhoneNumber = objvCurrEduClsENS.PhoneNumber, //电话
IdXzMajor = objvCurrEduClsENS.IdXzMajor, //专业流水号
MajorName = objvCurrEduClsENS.MajorName, //专业名称
IdEduWay = objvCurrEduClsENS.IdEduWay, //教学方式流水号
IdClassRoomType = objvCurrEduClsENS.IdClassRoomType, //教室类型流水号
TotalLessonQty = objvCurrEduClsENS.TotalLessonQty, //总课时数
MaxStuQty = objvCurrEduClsENS.MaxStuQty, //最大学生数
WeekQty = objvCurrEduClsENS.WeekQty, //总周数
ScheUnitPW = objvCurrEduClsENS.ScheUnitPW, //周排课次数
WeekStatusId = objvCurrEduClsENS.WeekStatusId, //周状态编号(单,双,全周)
CustomerWeek = objvCurrEduClsENS.CustomerWeek, //自定义上课周
LessonQtyPerWeek = objvCurrEduClsENS.LessonQtyPerWeek, //周课时数
Mark = objvCurrEduClsENS.Mark, //获得学分
IdUniZone = objvCurrEduClsENS.IdUniZone, //校区流水号
IdGradeBase = objvCurrEduClsENS.IdGradeBase, //年级流水号
GradeBaseId = objvCurrEduClsENS.GradeBaseId, //年级代号
GradeBaseName = objvCurrEduClsENS.GradeBaseName, //年级名称
GradeBaseNameA = objvCurrEduClsENS.GradeBaseNameA, //年级名称缩写
IsEffective = objvCurrEduClsENS.IsEffective, //是否有效
IsForPaperReading = objvCurrEduClsENS.IsForPaperReading, //是否参与论文阅读
SchoolYear = objvCurrEduClsENS.SchoolYear, //学年
SchoolTerm = objvCurrEduClsENS.SchoolTerm, //学期
IdCourseType = objvCurrEduClsENS.IdCourseType, //课程类型流水号
CourseTypeId = objvCurrEduClsENS.CourseTypeId, //课程类型ID
CourseTypeName = objvCurrEduClsENS.CourseTypeName, //课程类型名称
IsDegree = objvCurrEduClsENS.IsDegree, //是否学位课
IdScoreType = objvCurrEduClsENS.IdScoreType, //成绩类型流水号
GetScoreWayId = objvCurrEduClsENS.GetScoreWayId, //获得成绩方式Id
IsProportionalCtrl = objvCurrEduClsENS.IsProportionalCtrl, //是否比例控制
IdExamType = objvCurrEduClsENS.IdExamType, //考试方式流水号
BeginWeek = objvCurrEduClsENS.BeginWeek, //开始周
UserType = objvCurrEduClsENS.UserType, //用户类型
ModifyDate = objvCurrEduClsENS.ModifyDate, //修改日期
ModifyUserId = objvCurrEduClsENS.ModifyUserId, //修改人
Memo = objvCurrEduClsENS.Memo, //备注
CurrStuNumValid = objvCurrEduClsENS.CurrStuNumValid, //CurrStuNum_Valid
CurrStuNum = objvCurrEduClsENS.CurrStuNum, //当前学生数
};
 return objvCurrEduClsENT;
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
public static void CheckProperty4Condition(this clsvCurrEduClsEN objvCurrEduClsEN)
{
 clsvCurrEduClsBL.vCurrEduClsDA.CheckProperty4Condition(objvCurrEduClsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCurrEduClsEN objvCurrEduClsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.IdCurrEduCls, objvCurrEduClsCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.CurrEduClsId) == true)
{
string strComparisonOpCurrEduClsId = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.CurrEduClsId, objvCurrEduClsCond.CurrEduClsId, strComparisonOpCurrEduClsId);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.EduClsName) == true)
{
string strComparisonOpEduClsName = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.EduClsName, objvCurrEduClsCond.EduClsName, strComparisonOpEduClsName);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.EduClsTypeId) == true)
{
string strComparisonOpEduClsTypeId = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.EduClsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.EduClsTypeId, objvCurrEduClsCond.EduClsTypeId, strComparisonOpEduClsTypeId);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.EduClsTypeName) == true)
{
string strComparisonOpEduClsTypeName = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.EduClsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.EduClsTypeName, objvCurrEduClsCond.EduClsTypeName, strComparisonOpEduClsTypeName);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.CourseId) == true)
{
string strComparisonOpCourseId = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.CourseId, objvCurrEduClsCond.CourseId, strComparisonOpCourseId);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.CourseCode) == true)
{
string strComparisonOpCourseCode = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.CourseCode, objvCurrEduClsCond.CourseCode, strComparisonOpCourseCode);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.CourseDescription) == true)
{
string strComparisonOpCourseDescription = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.CourseDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.CourseDescription, objvCurrEduClsCond.CourseDescription, strComparisonOpCourseDescription);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.CourseName) == true)
{
string strComparisonOpCourseName = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.CourseName, objvCurrEduClsCond.CourseName, strComparisonOpCourseName);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.ViewCount) == true)
{
string strComparisonOpViewCount = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls.ViewCount, objvCurrEduClsCond.ViewCount, strComparisonOpViewCount);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.ExampleImgPath) == true)
{
string strComparisonOpExampleImgPath = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.ExampleImgPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.ExampleImgPath, objvCurrEduClsCond.ExampleImgPath, strComparisonOpExampleImgPath);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.TeachingSolutionId) == true)
{
string strComparisonOpTeachingSolutionId = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.TeachingSolutionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.TeachingSolutionId, objvCurrEduClsCond.TeachingSolutionId, strComparisonOpTeachingSolutionId);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.TeachingSolutionName) == true)
{
string strComparisonOpTeachingSolutionName = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.TeachingSolutionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.TeachingSolutionName, objvCurrEduClsCond.TeachingSolutionName, strComparisonOpTeachingSolutionName);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.IdTeacher) == true)
{
string strComparisonOpIdTeacher = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.IdTeacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.IdTeacher, objvCurrEduClsCond.IdTeacher, strComparisonOpIdTeacher);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.TeacherId) == true)
{
string strComparisonOpTeacherId = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.TeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.TeacherId, objvCurrEduClsCond.TeacherId, strComparisonOpTeacherId);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.TeacherName) == true)
{
string strComparisonOpTeacherName = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.TeacherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.TeacherName, objvCurrEduClsCond.TeacherName, strComparisonOpTeacherName);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.IdXzCollege, objvCurrEduClsCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.CollegeId) == true)
{
string strComparisonOpCollegeId = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.CollegeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.CollegeId, objvCurrEduClsCond.CollegeId, strComparisonOpCollegeId);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.CollegeName) == true)
{
string strComparisonOpCollegeName = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.CollegeName, objvCurrEduClsCond.CollegeName, strComparisonOpCollegeName);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.ClgEnglishName) == true)
{
string strComparisonOpClgEnglishName = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.ClgEnglishName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.ClgEnglishName, objvCurrEduClsCond.ClgEnglishName, strComparisonOpClgEnglishName);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.PhoneNumber) == true)
{
string strComparisonOpPhoneNumber = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.PhoneNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.PhoneNumber, objvCurrEduClsCond.PhoneNumber, strComparisonOpPhoneNumber);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.IdXzMajor, objvCurrEduClsCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.MajorName) == true)
{
string strComparisonOpMajorName = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.MajorName, objvCurrEduClsCond.MajorName, strComparisonOpMajorName);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.IdEduWay) == true)
{
string strComparisonOpIdEduWay = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.IdEduWay];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.IdEduWay, objvCurrEduClsCond.IdEduWay, strComparisonOpIdEduWay);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.IdClassRoomType) == true)
{
string strComparisonOpIdClassRoomType = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.IdClassRoomType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.IdClassRoomType, objvCurrEduClsCond.IdClassRoomType, strComparisonOpIdClassRoomType);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.TotalLessonQty) == true)
{
string strComparisonOpTotalLessonQty = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.TotalLessonQty];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls.TotalLessonQty, objvCurrEduClsCond.TotalLessonQty, strComparisonOpTotalLessonQty);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.MaxStuQty) == true)
{
string strComparisonOpMaxStuQty = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.MaxStuQty];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls.MaxStuQty, objvCurrEduClsCond.MaxStuQty, strComparisonOpMaxStuQty);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.WeekQty) == true)
{
string strComparisonOpWeekQty = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.WeekQty];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls.WeekQty, objvCurrEduClsCond.WeekQty, strComparisonOpWeekQty);
}
//数据类型short(smallint)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.WeekStatusId) == true)
{
string strComparisonOpWeekStatusId = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.WeekStatusId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.WeekStatusId, objvCurrEduClsCond.WeekStatusId, strComparisonOpWeekStatusId);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.CustomerWeek) == true)
{
string strComparisonOpCustomerWeek = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.CustomerWeek];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.CustomerWeek, objvCurrEduClsCond.CustomerWeek, strComparisonOpCustomerWeek);
}
//数据类型short(smallint)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.Mark) == true)
{
string strComparisonOpMark = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.Mark];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls.Mark, objvCurrEduClsCond.Mark, strComparisonOpMark);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.IdUniZone) == true)
{
string strComparisonOpIdUniZone = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.IdUniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.IdUniZone, objvCurrEduClsCond.IdUniZone, strComparisonOpIdUniZone);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.IdGradeBase, objvCurrEduClsCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.GradeBaseId) == true)
{
string strComparisonOpGradeBaseId = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.GradeBaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.GradeBaseId, objvCurrEduClsCond.GradeBaseId, strComparisonOpGradeBaseId);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.GradeBaseName) == true)
{
string strComparisonOpGradeBaseName = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.GradeBaseName, objvCurrEduClsCond.GradeBaseName, strComparisonOpGradeBaseName);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.GradeBaseNameA) == true)
{
string strComparisonOpGradeBaseNameA = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.GradeBaseNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.GradeBaseNameA, objvCurrEduClsCond.GradeBaseNameA, strComparisonOpGradeBaseNameA);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.IsEffective) == true)
{
if (objvCurrEduClsCond.IsEffective == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls.IsEffective);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls.IsEffective);
}
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.IsForPaperReading) == true)
{
if (objvCurrEduClsCond.IsForPaperReading == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls.IsForPaperReading);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls.IsForPaperReading);
}
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.SchoolYear) == true)
{
string strComparisonOpSchoolYear = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.SchoolYear, objvCurrEduClsCond.SchoolYear, strComparisonOpSchoolYear);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.SchoolTerm) == true)
{
string strComparisonOpSchoolTerm = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.SchoolTerm, objvCurrEduClsCond.SchoolTerm, strComparisonOpSchoolTerm);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.IdCourseType) == true)
{
string strComparisonOpIdCourseType = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.IdCourseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.IdCourseType, objvCurrEduClsCond.IdCourseType, strComparisonOpIdCourseType);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.CourseTypeId) == true)
{
string strComparisonOpCourseTypeId = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.CourseTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.CourseTypeId, objvCurrEduClsCond.CourseTypeId, strComparisonOpCourseTypeId);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.CourseTypeName) == true)
{
string strComparisonOpCourseTypeName = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.CourseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.CourseTypeName, objvCurrEduClsCond.CourseTypeName, strComparisonOpCourseTypeName);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.IsDegree) == true)
{
if (objvCurrEduClsCond.IsDegree == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls.IsDegree);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls.IsDegree);
}
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.IdScoreType) == true)
{
string strComparisonOpIdScoreType = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.IdScoreType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.IdScoreType, objvCurrEduClsCond.IdScoreType, strComparisonOpIdScoreType);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.GetScoreWayId) == true)
{
string strComparisonOpGetScoreWayId = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.GetScoreWayId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.GetScoreWayId, objvCurrEduClsCond.GetScoreWayId, strComparisonOpGetScoreWayId);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.IsProportionalCtrl) == true)
{
if (objvCurrEduClsCond.IsProportionalCtrl == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls.IsProportionalCtrl);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls.IsProportionalCtrl);
}
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.IdExamType) == true)
{
string strComparisonOpIdExamType = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.IdExamType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.IdExamType, objvCurrEduClsCond.IdExamType, strComparisonOpIdExamType);
}
//数据类型short(smallint)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.UserType) == true)
{
string strComparisonOpUserType = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.UserType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.UserType, objvCurrEduClsCond.UserType, strComparisonOpUserType);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.ModifyDate) == true)
{
string strComparisonOpModifyDate = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.ModifyDate, objvCurrEduClsCond.ModifyDate, strComparisonOpModifyDate);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.ModifyUserId) == true)
{
string strComparisonOpModifyUserId = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.ModifyUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.ModifyUserId, objvCurrEduClsCond.ModifyUserId, strComparisonOpModifyUserId);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.Memo) == true)
{
string strComparisonOpMemo = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls.Memo, objvCurrEduClsCond.Memo, strComparisonOpMemo);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.CurrStuNumValid) == true)
{
string strComparisonOpCurrStuNumValid = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.CurrStuNumValid];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls.CurrStuNumValid, objvCurrEduClsCond.CurrStuNumValid, strComparisonOpCurrStuNumValid);
}
if (objvCurrEduClsCond.IsUpdated(convCurrEduCls.CurrStuNum) == true)
{
string strComparisonOpCurrStuNum = objvCurrEduClsCond.dicFldComparisonOp[convCurrEduCls.CurrStuNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls.CurrStuNum, objvCurrEduClsCond.CurrStuNum, strComparisonOpCurrStuNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCurrEduCls
{
public virtual bool UpdRelaTabDate(string strIdCurrEduCls, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v当前教学班(vCurrEduCls)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCurrEduClsBL
{
public static RelatedActions_vCurrEduCls relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCurrEduClsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCurrEduClsDA vCurrEduClsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCurrEduClsDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCurrEduClsBL()
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
if (string.IsNullOrEmpty(clsvCurrEduClsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCurrEduClsEN._ConnectString);
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
public static DataTable GetDataTable_vCurrEduCls(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCurrEduClsDA.GetDataTable_vCurrEduCls(strWhereCond);
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
objDT = vCurrEduClsDA.GetDataTable(strWhereCond);
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
objDT = vCurrEduClsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCurrEduClsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCurrEduClsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCurrEduClsDA.GetDataTable_Top(objTopPara);
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
objDT = vCurrEduClsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCurrEduClsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCurrEduClsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvCurrEduClsEN> GetObjLstByIdCurrEduClsLst(List<string> arrIdCurrEduClsLst)
{
List<clsvCurrEduClsEN> arrObjLst = new List<clsvCurrEduClsEN>(); 
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
	clsvCurrEduClsEN objvCurrEduClsEN = new clsvCurrEduClsEN();
try
{
objvCurrEduClsEN.IdCurrEduCls = objRow[convCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsEN.CurrEduClsId = objRow[convCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsEN.EduClsName = objRow[convCurrEduCls.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsEN.EduClsTypeId = objRow[convCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsEN.EduClsTypeName = objRow[convCurrEduCls.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsEN.CourseId = objRow[convCurrEduCls.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsEN.CourseCode = objRow[convCurrEduCls.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsEN.CourseDescription = objRow[convCurrEduCls.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls.CourseDescription].ToString().Trim(); //课程描述
objvCurrEduClsEN.CourseName = objRow[convCurrEduCls.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsEN.ViewCount = objRow[convCurrEduCls.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.ViewCount].ToString().Trim()); //浏览量
objvCurrEduClsEN.ExampleImgPath = objRow[convCurrEduCls.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduClsEN.TeachingSolutionId = objRow[convCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsEN.TeachingSolutionName = objRow[convCurrEduCls.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduCls.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsEN.IdTeacher = objRow[convCurrEduCls.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduCls.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduClsEN.TeacherId = objRow[convCurrEduCls.TeacherId] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherId].ToString().Trim(); //教师工号
objvCurrEduClsEN.TeacherName = objRow[convCurrEduCls.TeacherName] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduClsEN.IdXzCollege = objRow[convCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsEN.CollegeId = objRow[convCurrEduCls.CollegeId] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsEN.CollegeName = objRow[convCurrEduCls.CollegeName] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsEN.ClgEnglishName = objRow[convCurrEduCls.ClgEnglishName] == DBNull.Value ? null : objRow[convCurrEduCls.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objvCurrEduClsEN.PhoneNumber = objRow[convCurrEduCls.PhoneNumber] == DBNull.Value ? null : objRow[convCurrEduCls.PhoneNumber].ToString().Trim(); //电话
objvCurrEduClsEN.IdXzMajor = objRow[convCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号
objvCurrEduClsEN.MajorName = objRow[convCurrEduCls.MajorName] == DBNull.Value ? null : objRow[convCurrEduCls.MajorName].ToString().Trim(); //专业名称
objvCurrEduClsEN.IdEduWay = objRow[convCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduClsEN.IdClassRoomType = objRow[convCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号
objvCurrEduClsEN.TotalLessonQty = Int32.Parse(objRow[convCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduClsEN.MaxStuQty = objRow[convCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduClsEN.WeekQty = objRow[convCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.WeekQty].ToString().Trim()); //总周数
objvCurrEduClsEN.ScheUnitPW = objRow[convCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduClsEN.WeekStatusId = objRow[convCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduClsEN.CustomerWeek = objRow[convCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduClsEN.LessonQtyPerWeek = objRow[convCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsEN.Mark = objRow[convCurrEduCls.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduCls.Mark].ToString().Trim()); //获得学分
objvCurrEduClsEN.IdUniZone = objRow[convCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsEN.IdGradeBase = objRow[convCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduClsEN.GradeBaseId = objRow[convCurrEduCls.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduClsEN.GradeBaseName = objRow[convCurrEduCls.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsEN.GradeBaseNameA = objRow[convCurrEduCls.GradeBaseNameA] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvCurrEduClsEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objvCurrEduClsEN.SchoolYear = objRow[convCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsEN.SchoolTerm = objRow[convCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsEN.IdCourseType = objRow[convCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsEN.CourseTypeId = objRow[convCurrEduCls.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsEN.CourseTypeName = objRow[convCurrEduCls.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsEN.IdScoreType = objRow[convCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduClsEN.GetScoreWayId = objRow[convCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objvCurrEduClsEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduClsEN.IdExamType = objRow[convCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[convCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduClsEN.BeginWeek = objRow[convCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.BeginWeek].ToString().Trim()); //开始周
objvCurrEduClsEN.UserType = objRow[convCurrEduCls.UserType] == DBNull.Value ? null : objRow[convCurrEduCls.UserType].ToString().Trim(); //用户类型
objvCurrEduClsEN.ModifyDate = objRow[convCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduClsEN.ModifyUserId = objRow[convCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduClsEN.Memo = objRow[convCurrEduCls.Memo] == DBNull.Value ? null : objRow[convCurrEduCls.Memo].ToString().Trim(); //备注
objvCurrEduClsEN.CurrStuNumValid = objRow[convCurrEduCls.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduClsEN.CurrStuNum = objRow[convCurrEduCls.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.CurrStuNum].ToString().Trim()); //当前学生数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduClsEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduClsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdCurrEduClsLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCurrEduClsEN> GetObjLstByIdCurrEduClsLstCache(List<string> arrIdCurrEduClsLst)
{
string strKey = string.Format("{0}", clsvCurrEduClsEN._CurrTabName);
List<clsvCurrEduClsEN> arrvCurrEduClsObjLstCache = GetObjLstCache();
IEnumerable <clsvCurrEduClsEN> arrvCurrEduClsObjLst_Sel =
arrvCurrEduClsObjLstCache
.Where(x => arrIdCurrEduClsLst.Contains(x.IdCurrEduCls));
return arrvCurrEduClsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduClsEN> GetObjLst(string strWhereCond)
{
List<clsvCurrEduClsEN> arrObjLst = new List<clsvCurrEduClsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsEN objvCurrEduClsEN = new clsvCurrEduClsEN();
try
{
objvCurrEduClsEN.IdCurrEduCls = objRow[convCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsEN.CurrEduClsId = objRow[convCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsEN.EduClsName = objRow[convCurrEduCls.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsEN.EduClsTypeId = objRow[convCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsEN.EduClsTypeName = objRow[convCurrEduCls.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsEN.CourseId = objRow[convCurrEduCls.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsEN.CourseCode = objRow[convCurrEduCls.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsEN.CourseDescription = objRow[convCurrEduCls.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls.CourseDescription].ToString().Trim(); //课程描述
objvCurrEduClsEN.CourseName = objRow[convCurrEduCls.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsEN.ViewCount = objRow[convCurrEduCls.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.ViewCount].ToString().Trim()); //浏览量
objvCurrEduClsEN.ExampleImgPath = objRow[convCurrEduCls.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduClsEN.TeachingSolutionId = objRow[convCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsEN.TeachingSolutionName = objRow[convCurrEduCls.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduCls.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsEN.IdTeacher = objRow[convCurrEduCls.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduCls.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduClsEN.TeacherId = objRow[convCurrEduCls.TeacherId] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherId].ToString().Trim(); //教师工号
objvCurrEduClsEN.TeacherName = objRow[convCurrEduCls.TeacherName] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduClsEN.IdXzCollege = objRow[convCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsEN.CollegeId = objRow[convCurrEduCls.CollegeId] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsEN.CollegeName = objRow[convCurrEduCls.CollegeName] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsEN.ClgEnglishName = objRow[convCurrEduCls.ClgEnglishName] == DBNull.Value ? null : objRow[convCurrEduCls.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objvCurrEduClsEN.PhoneNumber = objRow[convCurrEduCls.PhoneNumber] == DBNull.Value ? null : objRow[convCurrEduCls.PhoneNumber].ToString().Trim(); //电话
objvCurrEduClsEN.IdXzMajor = objRow[convCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号
objvCurrEduClsEN.MajorName = objRow[convCurrEduCls.MajorName] == DBNull.Value ? null : objRow[convCurrEduCls.MajorName].ToString().Trim(); //专业名称
objvCurrEduClsEN.IdEduWay = objRow[convCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduClsEN.IdClassRoomType = objRow[convCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号
objvCurrEduClsEN.TotalLessonQty = Int32.Parse(objRow[convCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduClsEN.MaxStuQty = objRow[convCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduClsEN.WeekQty = objRow[convCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.WeekQty].ToString().Trim()); //总周数
objvCurrEduClsEN.ScheUnitPW = objRow[convCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduClsEN.WeekStatusId = objRow[convCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduClsEN.CustomerWeek = objRow[convCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduClsEN.LessonQtyPerWeek = objRow[convCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsEN.Mark = objRow[convCurrEduCls.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduCls.Mark].ToString().Trim()); //获得学分
objvCurrEduClsEN.IdUniZone = objRow[convCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsEN.IdGradeBase = objRow[convCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduClsEN.GradeBaseId = objRow[convCurrEduCls.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduClsEN.GradeBaseName = objRow[convCurrEduCls.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsEN.GradeBaseNameA = objRow[convCurrEduCls.GradeBaseNameA] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvCurrEduClsEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objvCurrEduClsEN.SchoolYear = objRow[convCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsEN.SchoolTerm = objRow[convCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsEN.IdCourseType = objRow[convCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsEN.CourseTypeId = objRow[convCurrEduCls.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsEN.CourseTypeName = objRow[convCurrEduCls.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsEN.IdScoreType = objRow[convCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduClsEN.GetScoreWayId = objRow[convCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objvCurrEduClsEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduClsEN.IdExamType = objRow[convCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[convCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduClsEN.BeginWeek = objRow[convCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.BeginWeek].ToString().Trim()); //开始周
objvCurrEduClsEN.UserType = objRow[convCurrEduCls.UserType] == DBNull.Value ? null : objRow[convCurrEduCls.UserType].ToString().Trim(); //用户类型
objvCurrEduClsEN.ModifyDate = objRow[convCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduClsEN.ModifyUserId = objRow[convCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduClsEN.Memo = objRow[convCurrEduCls.Memo] == DBNull.Value ? null : objRow[convCurrEduCls.Memo].ToString().Trim(); //备注
objvCurrEduClsEN.CurrStuNumValid = objRow[convCurrEduCls.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduClsEN.CurrStuNum = objRow[convCurrEduCls.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.CurrStuNum].ToString().Trim()); //当前学生数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduClsEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduClsEN);
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
public static List<clsvCurrEduClsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCurrEduClsEN> arrObjLst = new List<clsvCurrEduClsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsEN objvCurrEduClsEN = new clsvCurrEduClsEN();
try
{
objvCurrEduClsEN.IdCurrEduCls = objRow[convCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsEN.CurrEduClsId = objRow[convCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsEN.EduClsName = objRow[convCurrEduCls.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsEN.EduClsTypeId = objRow[convCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsEN.EduClsTypeName = objRow[convCurrEduCls.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsEN.CourseId = objRow[convCurrEduCls.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsEN.CourseCode = objRow[convCurrEduCls.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsEN.CourseDescription = objRow[convCurrEduCls.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls.CourseDescription].ToString().Trim(); //课程描述
objvCurrEduClsEN.CourseName = objRow[convCurrEduCls.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsEN.ViewCount = objRow[convCurrEduCls.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.ViewCount].ToString().Trim()); //浏览量
objvCurrEduClsEN.ExampleImgPath = objRow[convCurrEduCls.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduClsEN.TeachingSolutionId = objRow[convCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsEN.TeachingSolutionName = objRow[convCurrEduCls.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduCls.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsEN.IdTeacher = objRow[convCurrEduCls.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduCls.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduClsEN.TeacherId = objRow[convCurrEduCls.TeacherId] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherId].ToString().Trim(); //教师工号
objvCurrEduClsEN.TeacherName = objRow[convCurrEduCls.TeacherName] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduClsEN.IdXzCollege = objRow[convCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsEN.CollegeId = objRow[convCurrEduCls.CollegeId] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsEN.CollegeName = objRow[convCurrEduCls.CollegeName] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsEN.ClgEnglishName = objRow[convCurrEduCls.ClgEnglishName] == DBNull.Value ? null : objRow[convCurrEduCls.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objvCurrEduClsEN.PhoneNumber = objRow[convCurrEduCls.PhoneNumber] == DBNull.Value ? null : objRow[convCurrEduCls.PhoneNumber].ToString().Trim(); //电话
objvCurrEduClsEN.IdXzMajor = objRow[convCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号
objvCurrEduClsEN.MajorName = objRow[convCurrEduCls.MajorName] == DBNull.Value ? null : objRow[convCurrEduCls.MajorName].ToString().Trim(); //专业名称
objvCurrEduClsEN.IdEduWay = objRow[convCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduClsEN.IdClassRoomType = objRow[convCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号
objvCurrEduClsEN.TotalLessonQty = Int32.Parse(objRow[convCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduClsEN.MaxStuQty = objRow[convCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduClsEN.WeekQty = objRow[convCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.WeekQty].ToString().Trim()); //总周数
objvCurrEduClsEN.ScheUnitPW = objRow[convCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduClsEN.WeekStatusId = objRow[convCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduClsEN.CustomerWeek = objRow[convCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduClsEN.LessonQtyPerWeek = objRow[convCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsEN.Mark = objRow[convCurrEduCls.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduCls.Mark].ToString().Trim()); //获得学分
objvCurrEduClsEN.IdUniZone = objRow[convCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsEN.IdGradeBase = objRow[convCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduClsEN.GradeBaseId = objRow[convCurrEduCls.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduClsEN.GradeBaseName = objRow[convCurrEduCls.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsEN.GradeBaseNameA = objRow[convCurrEduCls.GradeBaseNameA] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvCurrEduClsEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objvCurrEduClsEN.SchoolYear = objRow[convCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsEN.SchoolTerm = objRow[convCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsEN.IdCourseType = objRow[convCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsEN.CourseTypeId = objRow[convCurrEduCls.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsEN.CourseTypeName = objRow[convCurrEduCls.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsEN.IdScoreType = objRow[convCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduClsEN.GetScoreWayId = objRow[convCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objvCurrEduClsEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduClsEN.IdExamType = objRow[convCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[convCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduClsEN.BeginWeek = objRow[convCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.BeginWeek].ToString().Trim()); //开始周
objvCurrEduClsEN.UserType = objRow[convCurrEduCls.UserType] == DBNull.Value ? null : objRow[convCurrEduCls.UserType].ToString().Trim(); //用户类型
objvCurrEduClsEN.ModifyDate = objRow[convCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduClsEN.ModifyUserId = objRow[convCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduClsEN.Memo = objRow[convCurrEduCls.Memo] == DBNull.Value ? null : objRow[convCurrEduCls.Memo].ToString().Trim(); //备注
objvCurrEduClsEN.CurrStuNumValid = objRow[convCurrEduCls.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduClsEN.CurrStuNum = objRow[convCurrEduCls.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.CurrStuNum].ToString().Trim()); //当前学生数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduClsEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduClsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCurrEduClsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCurrEduClsEN> GetSubObjLstCache(clsvCurrEduClsEN objvCurrEduClsCond)
{
List<clsvCurrEduClsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCurrEduClsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCurrEduCls.AttributeName)
{
if (objvCurrEduClsCond.IsUpdated(strFldName) == false) continue;
if (objvCurrEduClsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCurrEduClsCond[strFldName].ToString());
}
else
{
if (objvCurrEduClsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCurrEduClsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCurrEduClsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCurrEduClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCurrEduClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCurrEduClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCurrEduClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCurrEduClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCurrEduClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCurrEduClsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCurrEduClsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCurrEduClsCond[strFldName]));
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
public static List<clsvCurrEduClsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCurrEduClsEN> arrObjLst = new List<clsvCurrEduClsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsEN objvCurrEduClsEN = new clsvCurrEduClsEN();
try
{
objvCurrEduClsEN.IdCurrEduCls = objRow[convCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsEN.CurrEduClsId = objRow[convCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsEN.EduClsName = objRow[convCurrEduCls.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsEN.EduClsTypeId = objRow[convCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsEN.EduClsTypeName = objRow[convCurrEduCls.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsEN.CourseId = objRow[convCurrEduCls.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsEN.CourseCode = objRow[convCurrEduCls.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsEN.CourseDescription = objRow[convCurrEduCls.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls.CourseDescription].ToString().Trim(); //课程描述
objvCurrEduClsEN.CourseName = objRow[convCurrEduCls.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsEN.ViewCount = objRow[convCurrEduCls.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.ViewCount].ToString().Trim()); //浏览量
objvCurrEduClsEN.ExampleImgPath = objRow[convCurrEduCls.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduClsEN.TeachingSolutionId = objRow[convCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsEN.TeachingSolutionName = objRow[convCurrEduCls.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduCls.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsEN.IdTeacher = objRow[convCurrEduCls.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduCls.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduClsEN.TeacherId = objRow[convCurrEduCls.TeacherId] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherId].ToString().Trim(); //教师工号
objvCurrEduClsEN.TeacherName = objRow[convCurrEduCls.TeacherName] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduClsEN.IdXzCollege = objRow[convCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsEN.CollegeId = objRow[convCurrEduCls.CollegeId] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsEN.CollegeName = objRow[convCurrEduCls.CollegeName] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsEN.ClgEnglishName = objRow[convCurrEduCls.ClgEnglishName] == DBNull.Value ? null : objRow[convCurrEduCls.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objvCurrEduClsEN.PhoneNumber = objRow[convCurrEduCls.PhoneNumber] == DBNull.Value ? null : objRow[convCurrEduCls.PhoneNumber].ToString().Trim(); //电话
objvCurrEduClsEN.IdXzMajor = objRow[convCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号
objvCurrEduClsEN.MajorName = objRow[convCurrEduCls.MajorName] == DBNull.Value ? null : objRow[convCurrEduCls.MajorName].ToString().Trim(); //专业名称
objvCurrEduClsEN.IdEduWay = objRow[convCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduClsEN.IdClassRoomType = objRow[convCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号
objvCurrEduClsEN.TotalLessonQty = Int32.Parse(objRow[convCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduClsEN.MaxStuQty = objRow[convCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduClsEN.WeekQty = objRow[convCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.WeekQty].ToString().Trim()); //总周数
objvCurrEduClsEN.ScheUnitPW = objRow[convCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduClsEN.WeekStatusId = objRow[convCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduClsEN.CustomerWeek = objRow[convCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduClsEN.LessonQtyPerWeek = objRow[convCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsEN.Mark = objRow[convCurrEduCls.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduCls.Mark].ToString().Trim()); //获得学分
objvCurrEduClsEN.IdUniZone = objRow[convCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsEN.IdGradeBase = objRow[convCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduClsEN.GradeBaseId = objRow[convCurrEduCls.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduClsEN.GradeBaseName = objRow[convCurrEduCls.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsEN.GradeBaseNameA = objRow[convCurrEduCls.GradeBaseNameA] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvCurrEduClsEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objvCurrEduClsEN.SchoolYear = objRow[convCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsEN.SchoolTerm = objRow[convCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsEN.IdCourseType = objRow[convCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsEN.CourseTypeId = objRow[convCurrEduCls.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsEN.CourseTypeName = objRow[convCurrEduCls.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsEN.IdScoreType = objRow[convCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduClsEN.GetScoreWayId = objRow[convCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objvCurrEduClsEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduClsEN.IdExamType = objRow[convCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[convCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduClsEN.BeginWeek = objRow[convCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.BeginWeek].ToString().Trim()); //开始周
objvCurrEduClsEN.UserType = objRow[convCurrEduCls.UserType] == DBNull.Value ? null : objRow[convCurrEduCls.UserType].ToString().Trim(); //用户类型
objvCurrEduClsEN.ModifyDate = objRow[convCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduClsEN.ModifyUserId = objRow[convCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduClsEN.Memo = objRow[convCurrEduCls.Memo] == DBNull.Value ? null : objRow[convCurrEduCls.Memo].ToString().Trim(); //备注
objvCurrEduClsEN.CurrStuNumValid = objRow[convCurrEduCls.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduClsEN.CurrStuNum = objRow[convCurrEduCls.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.CurrStuNum].ToString().Trim()); //当前学生数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduClsEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduClsEN);
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
public static List<clsvCurrEduClsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCurrEduClsEN> arrObjLst = new List<clsvCurrEduClsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsEN objvCurrEduClsEN = new clsvCurrEduClsEN();
try
{
objvCurrEduClsEN.IdCurrEduCls = objRow[convCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsEN.CurrEduClsId = objRow[convCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsEN.EduClsName = objRow[convCurrEduCls.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsEN.EduClsTypeId = objRow[convCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsEN.EduClsTypeName = objRow[convCurrEduCls.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsEN.CourseId = objRow[convCurrEduCls.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsEN.CourseCode = objRow[convCurrEduCls.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsEN.CourseDescription = objRow[convCurrEduCls.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls.CourseDescription].ToString().Trim(); //课程描述
objvCurrEduClsEN.CourseName = objRow[convCurrEduCls.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsEN.ViewCount = objRow[convCurrEduCls.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.ViewCount].ToString().Trim()); //浏览量
objvCurrEduClsEN.ExampleImgPath = objRow[convCurrEduCls.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduClsEN.TeachingSolutionId = objRow[convCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsEN.TeachingSolutionName = objRow[convCurrEduCls.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduCls.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsEN.IdTeacher = objRow[convCurrEduCls.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduCls.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduClsEN.TeacherId = objRow[convCurrEduCls.TeacherId] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherId].ToString().Trim(); //教师工号
objvCurrEduClsEN.TeacherName = objRow[convCurrEduCls.TeacherName] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduClsEN.IdXzCollege = objRow[convCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsEN.CollegeId = objRow[convCurrEduCls.CollegeId] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsEN.CollegeName = objRow[convCurrEduCls.CollegeName] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsEN.ClgEnglishName = objRow[convCurrEduCls.ClgEnglishName] == DBNull.Value ? null : objRow[convCurrEduCls.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objvCurrEduClsEN.PhoneNumber = objRow[convCurrEduCls.PhoneNumber] == DBNull.Value ? null : objRow[convCurrEduCls.PhoneNumber].ToString().Trim(); //电话
objvCurrEduClsEN.IdXzMajor = objRow[convCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号
objvCurrEduClsEN.MajorName = objRow[convCurrEduCls.MajorName] == DBNull.Value ? null : objRow[convCurrEduCls.MajorName].ToString().Trim(); //专业名称
objvCurrEduClsEN.IdEduWay = objRow[convCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduClsEN.IdClassRoomType = objRow[convCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号
objvCurrEduClsEN.TotalLessonQty = Int32.Parse(objRow[convCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduClsEN.MaxStuQty = objRow[convCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduClsEN.WeekQty = objRow[convCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.WeekQty].ToString().Trim()); //总周数
objvCurrEduClsEN.ScheUnitPW = objRow[convCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduClsEN.WeekStatusId = objRow[convCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduClsEN.CustomerWeek = objRow[convCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduClsEN.LessonQtyPerWeek = objRow[convCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsEN.Mark = objRow[convCurrEduCls.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduCls.Mark].ToString().Trim()); //获得学分
objvCurrEduClsEN.IdUniZone = objRow[convCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsEN.IdGradeBase = objRow[convCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduClsEN.GradeBaseId = objRow[convCurrEduCls.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduClsEN.GradeBaseName = objRow[convCurrEduCls.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsEN.GradeBaseNameA = objRow[convCurrEduCls.GradeBaseNameA] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvCurrEduClsEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objvCurrEduClsEN.SchoolYear = objRow[convCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsEN.SchoolTerm = objRow[convCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsEN.IdCourseType = objRow[convCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsEN.CourseTypeId = objRow[convCurrEduCls.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsEN.CourseTypeName = objRow[convCurrEduCls.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsEN.IdScoreType = objRow[convCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduClsEN.GetScoreWayId = objRow[convCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objvCurrEduClsEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduClsEN.IdExamType = objRow[convCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[convCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduClsEN.BeginWeek = objRow[convCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.BeginWeek].ToString().Trim()); //开始周
objvCurrEduClsEN.UserType = objRow[convCurrEduCls.UserType] == DBNull.Value ? null : objRow[convCurrEduCls.UserType].ToString().Trim(); //用户类型
objvCurrEduClsEN.ModifyDate = objRow[convCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduClsEN.ModifyUserId = objRow[convCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduClsEN.Memo = objRow[convCurrEduCls.Memo] == DBNull.Value ? null : objRow[convCurrEduCls.Memo].ToString().Trim(); //备注
objvCurrEduClsEN.CurrStuNumValid = objRow[convCurrEduCls.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduClsEN.CurrStuNum = objRow[convCurrEduCls.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.CurrStuNum].ToString().Trim()); //当前学生数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduClsEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduClsEN);
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
List<clsvCurrEduClsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCurrEduClsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduClsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCurrEduClsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCurrEduClsEN> arrObjLst = new List<clsvCurrEduClsEN>(); 
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
	clsvCurrEduClsEN objvCurrEduClsEN = new clsvCurrEduClsEN();
try
{
objvCurrEduClsEN.IdCurrEduCls = objRow[convCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsEN.CurrEduClsId = objRow[convCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsEN.EduClsName = objRow[convCurrEduCls.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsEN.EduClsTypeId = objRow[convCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsEN.EduClsTypeName = objRow[convCurrEduCls.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsEN.CourseId = objRow[convCurrEduCls.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsEN.CourseCode = objRow[convCurrEduCls.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsEN.CourseDescription = objRow[convCurrEduCls.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls.CourseDescription].ToString().Trim(); //课程描述
objvCurrEduClsEN.CourseName = objRow[convCurrEduCls.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsEN.ViewCount = objRow[convCurrEduCls.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.ViewCount].ToString().Trim()); //浏览量
objvCurrEduClsEN.ExampleImgPath = objRow[convCurrEduCls.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduClsEN.TeachingSolutionId = objRow[convCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsEN.TeachingSolutionName = objRow[convCurrEduCls.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduCls.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsEN.IdTeacher = objRow[convCurrEduCls.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduCls.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduClsEN.TeacherId = objRow[convCurrEduCls.TeacherId] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherId].ToString().Trim(); //教师工号
objvCurrEduClsEN.TeacherName = objRow[convCurrEduCls.TeacherName] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduClsEN.IdXzCollege = objRow[convCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsEN.CollegeId = objRow[convCurrEduCls.CollegeId] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsEN.CollegeName = objRow[convCurrEduCls.CollegeName] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsEN.ClgEnglishName = objRow[convCurrEduCls.ClgEnglishName] == DBNull.Value ? null : objRow[convCurrEduCls.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objvCurrEduClsEN.PhoneNumber = objRow[convCurrEduCls.PhoneNumber] == DBNull.Value ? null : objRow[convCurrEduCls.PhoneNumber].ToString().Trim(); //电话
objvCurrEduClsEN.IdXzMajor = objRow[convCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号
objvCurrEduClsEN.MajorName = objRow[convCurrEduCls.MajorName] == DBNull.Value ? null : objRow[convCurrEduCls.MajorName].ToString().Trim(); //专业名称
objvCurrEduClsEN.IdEduWay = objRow[convCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduClsEN.IdClassRoomType = objRow[convCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号
objvCurrEduClsEN.TotalLessonQty = Int32.Parse(objRow[convCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduClsEN.MaxStuQty = objRow[convCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduClsEN.WeekQty = objRow[convCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.WeekQty].ToString().Trim()); //总周数
objvCurrEduClsEN.ScheUnitPW = objRow[convCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduClsEN.WeekStatusId = objRow[convCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduClsEN.CustomerWeek = objRow[convCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduClsEN.LessonQtyPerWeek = objRow[convCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsEN.Mark = objRow[convCurrEduCls.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduCls.Mark].ToString().Trim()); //获得学分
objvCurrEduClsEN.IdUniZone = objRow[convCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsEN.IdGradeBase = objRow[convCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduClsEN.GradeBaseId = objRow[convCurrEduCls.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduClsEN.GradeBaseName = objRow[convCurrEduCls.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsEN.GradeBaseNameA = objRow[convCurrEduCls.GradeBaseNameA] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvCurrEduClsEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objvCurrEduClsEN.SchoolYear = objRow[convCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsEN.SchoolTerm = objRow[convCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsEN.IdCourseType = objRow[convCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsEN.CourseTypeId = objRow[convCurrEduCls.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsEN.CourseTypeName = objRow[convCurrEduCls.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsEN.IdScoreType = objRow[convCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduClsEN.GetScoreWayId = objRow[convCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objvCurrEduClsEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduClsEN.IdExamType = objRow[convCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[convCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduClsEN.BeginWeek = objRow[convCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.BeginWeek].ToString().Trim()); //开始周
objvCurrEduClsEN.UserType = objRow[convCurrEduCls.UserType] == DBNull.Value ? null : objRow[convCurrEduCls.UserType].ToString().Trim(); //用户类型
objvCurrEduClsEN.ModifyDate = objRow[convCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduClsEN.ModifyUserId = objRow[convCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduClsEN.Memo = objRow[convCurrEduCls.Memo] == DBNull.Value ? null : objRow[convCurrEduCls.Memo].ToString().Trim(); //备注
objvCurrEduClsEN.CurrStuNumValid = objRow[convCurrEduCls.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduClsEN.CurrStuNum = objRow[convCurrEduCls.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.CurrStuNum].ToString().Trim()); //当前学生数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduClsEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduClsEN);
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
public static List<clsvCurrEduClsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCurrEduClsEN> arrObjLst = new List<clsvCurrEduClsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsEN objvCurrEduClsEN = new clsvCurrEduClsEN();
try
{
objvCurrEduClsEN.IdCurrEduCls = objRow[convCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsEN.CurrEduClsId = objRow[convCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsEN.EduClsName = objRow[convCurrEduCls.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsEN.EduClsTypeId = objRow[convCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsEN.EduClsTypeName = objRow[convCurrEduCls.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsEN.CourseId = objRow[convCurrEduCls.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsEN.CourseCode = objRow[convCurrEduCls.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsEN.CourseDescription = objRow[convCurrEduCls.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls.CourseDescription].ToString().Trim(); //课程描述
objvCurrEduClsEN.CourseName = objRow[convCurrEduCls.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsEN.ViewCount = objRow[convCurrEduCls.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.ViewCount].ToString().Trim()); //浏览量
objvCurrEduClsEN.ExampleImgPath = objRow[convCurrEduCls.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduClsEN.TeachingSolutionId = objRow[convCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsEN.TeachingSolutionName = objRow[convCurrEduCls.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduCls.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsEN.IdTeacher = objRow[convCurrEduCls.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduCls.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduClsEN.TeacherId = objRow[convCurrEduCls.TeacherId] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherId].ToString().Trim(); //教师工号
objvCurrEduClsEN.TeacherName = objRow[convCurrEduCls.TeacherName] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduClsEN.IdXzCollege = objRow[convCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsEN.CollegeId = objRow[convCurrEduCls.CollegeId] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsEN.CollegeName = objRow[convCurrEduCls.CollegeName] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsEN.ClgEnglishName = objRow[convCurrEduCls.ClgEnglishName] == DBNull.Value ? null : objRow[convCurrEduCls.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objvCurrEduClsEN.PhoneNumber = objRow[convCurrEduCls.PhoneNumber] == DBNull.Value ? null : objRow[convCurrEduCls.PhoneNumber].ToString().Trim(); //电话
objvCurrEduClsEN.IdXzMajor = objRow[convCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号
objvCurrEduClsEN.MajorName = objRow[convCurrEduCls.MajorName] == DBNull.Value ? null : objRow[convCurrEduCls.MajorName].ToString().Trim(); //专业名称
objvCurrEduClsEN.IdEduWay = objRow[convCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduClsEN.IdClassRoomType = objRow[convCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号
objvCurrEduClsEN.TotalLessonQty = Int32.Parse(objRow[convCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduClsEN.MaxStuQty = objRow[convCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduClsEN.WeekQty = objRow[convCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.WeekQty].ToString().Trim()); //总周数
objvCurrEduClsEN.ScheUnitPW = objRow[convCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduClsEN.WeekStatusId = objRow[convCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduClsEN.CustomerWeek = objRow[convCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduClsEN.LessonQtyPerWeek = objRow[convCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsEN.Mark = objRow[convCurrEduCls.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduCls.Mark].ToString().Trim()); //获得学分
objvCurrEduClsEN.IdUniZone = objRow[convCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsEN.IdGradeBase = objRow[convCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduClsEN.GradeBaseId = objRow[convCurrEduCls.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduClsEN.GradeBaseName = objRow[convCurrEduCls.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsEN.GradeBaseNameA = objRow[convCurrEduCls.GradeBaseNameA] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvCurrEduClsEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objvCurrEduClsEN.SchoolYear = objRow[convCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsEN.SchoolTerm = objRow[convCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsEN.IdCourseType = objRow[convCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsEN.CourseTypeId = objRow[convCurrEduCls.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsEN.CourseTypeName = objRow[convCurrEduCls.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsEN.IdScoreType = objRow[convCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduClsEN.GetScoreWayId = objRow[convCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objvCurrEduClsEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduClsEN.IdExamType = objRow[convCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[convCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduClsEN.BeginWeek = objRow[convCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.BeginWeek].ToString().Trim()); //开始周
objvCurrEduClsEN.UserType = objRow[convCurrEduCls.UserType] == DBNull.Value ? null : objRow[convCurrEduCls.UserType].ToString().Trim(); //用户类型
objvCurrEduClsEN.ModifyDate = objRow[convCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduClsEN.ModifyUserId = objRow[convCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduClsEN.Memo = objRow[convCurrEduCls.Memo] == DBNull.Value ? null : objRow[convCurrEduCls.Memo].ToString().Trim(); //备注
objvCurrEduClsEN.CurrStuNumValid = objRow[convCurrEduCls.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduClsEN.CurrStuNum = objRow[convCurrEduCls.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.CurrStuNum].ToString().Trim()); //当前学生数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduClsEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduClsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCurrEduClsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCurrEduClsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCurrEduClsEN> arrObjLst = new List<clsvCurrEduClsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsEN objvCurrEduClsEN = new clsvCurrEduClsEN();
try
{
objvCurrEduClsEN.IdCurrEduCls = objRow[convCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsEN.CurrEduClsId = objRow[convCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsEN.EduClsName = objRow[convCurrEduCls.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsEN.EduClsTypeId = objRow[convCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsEN.EduClsTypeName = objRow[convCurrEduCls.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsEN.CourseId = objRow[convCurrEduCls.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsEN.CourseCode = objRow[convCurrEduCls.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsEN.CourseDescription = objRow[convCurrEduCls.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls.CourseDescription].ToString().Trim(); //课程描述
objvCurrEduClsEN.CourseName = objRow[convCurrEduCls.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsEN.ViewCount = objRow[convCurrEduCls.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.ViewCount].ToString().Trim()); //浏览量
objvCurrEduClsEN.ExampleImgPath = objRow[convCurrEduCls.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduClsEN.TeachingSolutionId = objRow[convCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsEN.TeachingSolutionName = objRow[convCurrEduCls.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduCls.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsEN.IdTeacher = objRow[convCurrEduCls.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduCls.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduClsEN.TeacherId = objRow[convCurrEduCls.TeacherId] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherId].ToString().Trim(); //教师工号
objvCurrEduClsEN.TeacherName = objRow[convCurrEduCls.TeacherName] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduClsEN.IdXzCollege = objRow[convCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsEN.CollegeId = objRow[convCurrEduCls.CollegeId] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsEN.CollegeName = objRow[convCurrEduCls.CollegeName] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsEN.ClgEnglishName = objRow[convCurrEduCls.ClgEnglishName] == DBNull.Value ? null : objRow[convCurrEduCls.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objvCurrEduClsEN.PhoneNumber = objRow[convCurrEduCls.PhoneNumber] == DBNull.Value ? null : objRow[convCurrEduCls.PhoneNumber].ToString().Trim(); //电话
objvCurrEduClsEN.IdXzMajor = objRow[convCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号
objvCurrEduClsEN.MajorName = objRow[convCurrEduCls.MajorName] == DBNull.Value ? null : objRow[convCurrEduCls.MajorName].ToString().Trim(); //专业名称
objvCurrEduClsEN.IdEduWay = objRow[convCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduClsEN.IdClassRoomType = objRow[convCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号
objvCurrEduClsEN.TotalLessonQty = Int32.Parse(objRow[convCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduClsEN.MaxStuQty = objRow[convCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduClsEN.WeekQty = objRow[convCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.WeekQty].ToString().Trim()); //总周数
objvCurrEduClsEN.ScheUnitPW = objRow[convCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduClsEN.WeekStatusId = objRow[convCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduClsEN.CustomerWeek = objRow[convCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduClsEN.LessonQtyPerWeek = objRow[convCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsEN.Mark = objRow[convCurrEduCls.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduCls.Mark].ToString().Trim()); //获得学分
objvCurrEduClsEN.IdUniZone = objRow[convCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsEN.IdGradeBase = objRow[convCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduClsEN.GradeBaseId = objRow[convCurrEduCls.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduClsEN.GradeBaseName = objRow[convCurrEduCls.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsEN.GradeBaseNameA = objRow[convCurrEduCls.GradeBaseNameA] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvCurrEduClsEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objvCurrEduClsEN.SchoolYear = objRow[convCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsEN.SchoolTerm = objRow[convCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsEN.IdCourseType = objRow[convCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsEN.CourseTypeId = objRow[convCurrEduCls.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsEN.CourseTypeName = objRow[convCurrEduCls.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsEN.IdScoreType = objRow[convCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduClsEN.GetScoreWayId = objRow[convCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objvCurrEduClsEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduClsEN.IdExamType = objRow[convCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[convCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduClsEN.BeginWeek = objRow[convCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.BeginWeek].ToString().Trim()); //开始周
objvCurrEduClsEN.UserType = objRow[convCurrEduCls.UserType] == DBNull.Value ? null : objRow[convCurrEduCls.UserType].ToString().Trim(); //用户类型
objvCurrEduClsEN.ModifyDate = objRow[convCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduClsEN.ModifyUserId = objRow[convCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduClsEN.Memo = objRow[convCurrEduCls.Memo] == DBNull.Value ? null : objRow[convCurrEduCls.Memo].ToString().Trim(); //备注
objvCurrEduClsEN.CurrStuNumValid = objRow[convCurrEduCls.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduClsEN.CurrStuNum = objRow[convCurrEduCls.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.CurrStuNum].ToString().Trim()); //当前学生数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduClsEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduClsEN);
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
public static List<clsvCurrEduClsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCurrEduClsEN> arrObjLst = new List<clsvCurrEduClsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsEN objvCurrEduClsEN = new clsvCurrEduClsEN();
try
{
objvCurrEduClsEN.IdCurrEduCls = objRow[convCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsEN.CurrEduClsId = objRow[convCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsEN.EduClsName = objRow[convCurrEduCls.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsEN.EduClsTypeId = objRow[convCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsEN.EduClsTypeName = objRow[convCurrEduCls.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsEN.CourseId = objRow[convCurrEduCls.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsEN.CourseCode = objRow[convCurrEduCls.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsEN.CourseDescription = objRow[convCurrEduCls.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls.CourseDescription].ToString().Trim(); //课程描述
objvCurrEduClsEN.CourseName = objRow[convCurrEduCls.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsEN.ViewCount = objRow[convCurrEduCls.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.ViewCount].ToString().Trim()); //浏览量
objvCurrEduClsEN.ExampleImgPath = objRow[convCurrEduCls.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduClsEN.TeachingSolutionId = objRow[convCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsEN.TeachingSolutionName = objRow[convCurrEduCls.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduCls.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsEN.IdTeacher = objRow[convCurrEduCls.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduCls.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduClsEN.TeacherId = objRow[convCurrEduCls.TeacherId] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherId].ToString().Trim(); //教师工号
objvCurrEduClsEN.TeacherName = objRow[convCurrEduCls.TeacherName] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduClsEN.IdXzCollege = objRow[convCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsEN.CollegeId = objRow[convCurrEduCls.CollegeId] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsEN.CollegeName = objRow[convCurrEduCls.CollegeName] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsEN.ClgEnglishName = objRow[convCurrEduCls.ClgEnglishName] == DBNull.Value ? null : objRow[convCurrEduCls.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objvCurrEduClsEN.PhoneNumber = objRow[convCurrEduCls.PhoneNumber] == DBNull.Value ? null : objRow[convCurrEduCls.PhoneNumber].ToString().Trim(); //电话
objvCurrEduClsEN.IdXzMajor = objRow[convCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号
objvCurrEduClsEN.MajorName = objRow[convCurrEduCls.MajorName] == DBNull.Value ? null : objRow[convCurrEduCls.MajorName].ToString().Trim(); //专业名称
objvCurrEduClsEN.IdEduWay = objRow[convCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduClsEN.IdClassRoomType = objRow[convCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号
objvCurrEduClsEN.TotalLessonQty = Int32.Parse(objRow[convCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduClsEN.MaxStuQty = objRow[convCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduClsEN.WeekQty = objRow[convCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.WeekQty].ToString().Trim()); //总周数
objvCurrEduClsEN.ScheUnitPW = objRow[convCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduClsEN.WeekStatusId = objRow[convCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduClsEN.CustomerWeek = objRow[convCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduClsEN.LessonQtyPerWeek = objRow[convCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsEN.Mark = objRow[convCurrEduCls.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduCls.Mark].ToString().Trim()); //获得学分
objvCurrEduClsEN.IdUniZone = objRow[convCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsEN.IdGradeBase = objRow[convCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduClsEN.GradeBaseId = objRow[convCurrEduCls.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduClsEN.GradeBaseName = objRow[convCurrEduCls.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsEN.GradeBaseNameA = objRow[convCurrEduCls.GradeBaseNameA] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvCurrEduClsEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objvCurrEduClsEN.SchoolYear = objRow[convCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsEN.SchoolTerm = objRow[convCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsEN.IdCourseType = objRow[convCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsEN.CourseTypeId = objRow[convCurrEduCls.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsEN.CourseTypeName = objRow[convCurrEduCls.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsEN.IdScoreType = objRow[convCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduClsEN.GetScoreWayId = objRow[convCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objvCurrEduClsEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduClsEN.IdExamType = objRow[convCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[convCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduClsEN.BeginWeek = objRow[convCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.BeginWeek].ToString().Trim()); //开始周
objvCurrEduClsEN.UserType = objRow[convCurrEduCls.UserType] == DBNull.Value ? null : objRow[convCurrEduCls.UserType].ToString().Trim(); //用户类型
objvCurrEduClsEN.ModifyDate = objRow[convCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduClsEN.ModifyUserId = objRow[convCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduClsEN.Memo = objRow[convCurrEduCls.Memo] == DBNull.Value ? null : objRow[convCurrEduCls.Memo].ToString().Trim(); //备注
objvCurrEduClsEN.CurrStuNumValid = objRow[convCurrEduCls.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduClsEN.CurrStuNum = objRow[convCurrEduCls.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.CurrStuNum].ToString().Trim()); //当前学生数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduClsEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduClsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduClsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCurrEduClsEN> arrObjLst = new List<clsvCurrEduClsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsEN objvCurrEduClsEN = new clsvCurrEduClsEN();
try
{
objvCurrEduClsEN.IdCurrEduCls = objRow[convCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsEN.CurrEduClsId = objRow[convCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsEN.EduClsName = objRow[convCurrEduCls.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsEN.EduClsTypeId = objRow[convCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsEN.EduClsTypeName = objRow[convCurrEduCls.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsEN.CourseId = objRow[convCurrEduCls.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsEN.CourseCode = objRow[convCurrEduCls.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsEN.CourseDescription = objRow[convCurrEduCls.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls.CourseDescription].ToString().Trim(); //课程描述
objvCurrEduClsEN.CourseName = objRow[convCurrEduCls.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsEN.ViewCount = objRow[convCurrEduCls.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.ViewCount].ToString().Trim()); //浏览量
objvCurrEduClsEN.ExampleImgPath = objRow[convCurrEduCls.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduClsEN.TeachingSolutionId = objRow[convCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsEN.TeachingSolutionName = objRow[convCurrEduCls.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduCls.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsEN.IdTeacher = objRow[convCurrEduCls.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduCls.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduClsEN.TeacherId = objRow[convCurrEduCls.TeacherId] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherId].ToString().Trim(); //教师工号
objvCurrEduClsEN.TeacherName = objRow[convCurrEduCls.TeacherName] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduClsEN.IdXzCollege = objRow[convCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsEN.CollegeId = objRow[convCurrEduCls.CollegeId] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsEN.CollegeName = objRow[convCurrEduCls.CollegeName] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsEN.ClgEnglishName = objRow[convCurrEduCls.ClgEnglishName] == DBNull.Value ? null : objRow[convCurrEduCls.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objvCurrEduClsEN.PhoneNumber = objRow[convCurrEduCls.PhoneNumber] == DBNull.Value ? null : objRow[convCurrEduCls.PhoneNumber].ToString().Trim(); //电话
objvCurrEduClsEN.IdXzMajor = objRow[convCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号
objvCurrEduClsEN.MajorName = objRow[convCurrEduCls.MajorName] == DBNull.Value ? null : objRow[convCurrEduCls.MajorName].ToString().Trim(); //专业名称
objvCurrEduClsEN.IdEduWay = objRow[convCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduClsEN.IdClassRoomType = objRow[convCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号
objvCurrEduClsEN.TotalLessonQty = Int32.Parse(objRow[convCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduClsEN.MaxStuQty = objRow[convCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduClsEN.WeekQty = objRow[convCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.WeekQty].ToString().Trim()); //总周数
objvCurrEduClsEN.ScheUnitPW = objRow[convCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduClsEN.WeekStatusId = objRow[convCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduClsEN.CustomerWeek = objRow[convCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduClsEN.LessonQtyPerWeek = objRow[convCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsEN.Mark = objRow[convCurrEduCls.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduCls.Mark].ToString().Trim()); //获得学分
objvCurrEduClsEN.IdUniZone = objRow[convCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsEN.IdGradeBase = objRow[convCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduClsEN.GradeBaseId = objRow[convCurrEduCls.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduClsEN.GradeBaseName = objRow[convCurrEduCls.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsEN.GradeBaseNameA = objRow[convCurrEduCls.GradeBaseNameA] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvCurrEduClsEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objvCurrEduClsEN.SchoolYear = objRow[convCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsEN.SchoolTerm = objRow[convCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsEN.IdCourseType = objRow[convCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsEN.CourseTypeId = objRow[convCurrEduCls.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsEN.CourseTypeName = objRow[convCurrEduCls.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsEN.IdScoreType = objRow[convCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduClsEN.GetScoreWayId = objRow[convCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objvCurrEduClsEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduClsEN.IdExamType = objRow[convCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[convCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduClsEN.BeginWeek = objRow[convCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.BeginWeek].ToString().Trim()); //开始周
objvCurrEduClsEN.UserType = objRow[convCurrEduCls.UserType] == DBNull.Value ? null : objRow[convCurrEduCls.UserType].ToString().Trim(); //用户类型
objvCurrEduClsEN.ModifyDate = objRow[convCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduClsEN.ModifyUserId = objRow[convCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduClsEN.Memo = objRow[convCurrEduCls.Memo] == DBNull.Value ? null : objRow[convCurrEduCls.Memo].ToString().Trim(); //备注
objvCurrEduClsEN.CurrStuNumValid = objRow[convCurrEduCls.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduClsEN.CurrStuNum = objRow[convCurrEduCls.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.CurrStuNum].ToString().Trim()); //当前学生数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduClsEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduClsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCurrEduCls(ref clsvCurrEduClsEN objvCurrEduClsEN)
{
bool bolResult = vCurrEduClsDA.GetvCurrEduCls(ref objvCurrEduClsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCurrEduCls">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCurrEduClsEN GetObjByIdCurrEduCls(string strIdCurrEduCls)
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
clsvCurrEduClsEN objvCurrEduClsEN = vCurrEduClsDA.GetObjByIdCurrEduCls(strIdCurrEduCls);
return objvCurrEduClsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCurrEduClsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCurrEduClsEN objvCurrEduClsEN = vCurrEduClsDA.GetFirstObj(strWhereCond);
 return objvCurrEduClsEN;
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
public static clsvCurrEduClsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCurrEduClsEN objvCurrEduClsEN = vCurrEduClsDA.GetObjByDataRow(objRow);
 return objvCurrEduClsEN;
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
public static clsvCurrEduClsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCurrEduClsEN objvCurrEduClsEN = vCurrEduClsDA.GetObjByDataRow(objRow);
 return objvCurrEduClsEN;
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
 /// <param name = "lstvCurrEduClsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCurrEduClsEN GetObjByIdCurrEduClsFromList(string strIdCurrEduCls, List<clsvCurrEduClsEN> lstvCurrEduClsObjLst)
{
foreach (clsvCurrEduClsEN objvCurrEduClsEN in lstvCurrEduClsObjLst)
{
if (objvCurrEduClsEN.IdCurrEduCls == strIdCurrEduCls)
{
return objvCurrEduClsEN;
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
 strMaxIdCurrEduCls = clsvCurrEduClsDA.GetMaxStrId();
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
 strIdCurrEduCls = new clsvCurrEduClsDA().GetFirstID(strWhereCond);
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
 arrList = vCurrEduClsDA.GetID(strWhereCond);
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
bool bolIsExist = vCurrEduClsDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vCurrEduClsDA.IsExist(strIdCurrEduCls);
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
 bolIsExist = clsvCurrEduClsDA.IsExistTable();
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
 bolIsExist = vCurrEduClsDA.IsExistTable(strTabName);
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
 /// <param name = "objvCurrEduClsENS">源对象</param>
 /// <param name = "objvCurrEduClsENT">目标对象</param>
 public static void CopyTo(clsvCurrEduClsEN objvCurrEduClsENS, clsvCurrEduClsEN objvCurrEduClsENT)
{
try
{
objvCurrEduClsENT.IdCurrEduCls = objvCurrEduClsENS.IdCurrEduCls; //教学班流水号
objvCurrEduClsENT.CurrEduClsId = objvCurrEduClsENS.CurrEduClsId; //教学班Id
objvCurrEduClsENT.EduClsName = objvCurrEduClsENS.EduClsName; //教学班名
objvCurrEduClsENT.EduClsTypeId = objvCurrEduClsENS.EduClsTypeId; //教学班类型Id
objvCurrEduClsENT.EduClsTypeName = objvCurrEduClsENS.EduClsTypeName; //教学班类型名称
objvCurrEduClsENT.CourseId = objvCurrEduClsENS.CourseId; //课程Id
objvCurrEduClsENT.CourseCode = objvCurrEduClsENS.CourseCode; //课程代码
objvCurrEduClsENT.CourseDescription = objvCurrEduClsENS.CourseDescription; //课程描述
objvCurrEduClsENT.CourseName = objvCurrEduClsENS.CourseName; //课程名称
objvCurrEduClsENT.ViewCount = objvCurrEduClsENS.ViewCount; //浏览量
objvCurrEduClsENT.ExampleImgPath = objvCurrEduClsENS.ExampleImgPath; //示例图路径
objvCurrEduClsENT.TeachingSolutionId = objvCurrEduClsENS.TeachingSolutionId; //教学方案Id
objvCurrEduClsENT.TeachingSolutionName = objvCurrEduClsENS.TeachingSolutionName; //教学方案名称
objvCurrEduClsENT.IdTeacher = objvCurrEduClsENS.IdTeacher; //教师流水号
objvCurrEduClsENT.TeacherId = objvCurrEduClsENS.TeacherId; //教师工号
objvCurrEduClsENT.TeacherName = objvCurrEduClsENS.TeacherName; //教师姓名
objvCurrEduClsENT.IdXzCollege = objvCurrEduClsENS.IdXzCollege; //学院流水号
objvCurrEduClsENT.CollegeId = objvCurrEduClsENS.CollegeId; //学院ID
objvCurrEduClsENT.CollegeName = objvCurrEduClsENS.CollegeName; //学院名称
objvCurrEduClsENT.ClgEnglishName = objvCurrEduClsENS.ClgEnglishName; //ClgEnglishName
objvCurrEduClsENT.PhoneNumber = objvCurrEduClsENS.PhoneNumber; //电话
objvCurrEduClsENT.IdXzMajor = objvCurrEduClsENS.IdXzMajor; //专业流水号
objvCurrEduClsENT.MajorName = objvCurrEduClsENS.MajorName; //专业名称
objvCurrEduClsENT.IdEduWay = objvCurrEduClsENS.IdEduWay; //教学方式流水号
objvCurrEduClsENT.IdClassRoomType = objvCurrEduClsENS.IdClassRoomType; //教室类型流水号
objvCurrEduClsENT.TotalLessonQty = objvCurrEduClsENS.TotalLessonQty; //总课时数
objvCurrEduClsENT.MaxStuQty = objvCurrEduClsENS.MaxStuQty; //最大学生数
objvCurrEduClsENT.WeekQty = objvCurrEduClsENS.WeekQty; //总周数
objvCurrEduClsENT.ScheUnitPW = objvCurrEduClsENS.ScheUnitPW; //周排课次数
objvCurrEduClsENT.WeekStatusId = objvCurrEduClsENS.WeekStatusId; //周状态编号(单,双,全周)
objvCurrEduClsENT.CustomerWeek = objvCurrEduClsENS.CustomerWeek; //自定义上课周
objvCurrEduClsENT.LessonQtyPerWeek = objvCurrEduClsENS.LessonQtyPerWeek; //周课时数
objvCurrEduClsENT.Mark = objvCurrEduClsENS.Mark; //获得学分
objvCurrEduClsENT.IdUniZone = objvCurrEduClsENS.IdUniZone; //校区流水号
objvCurrEduClsENT.IdGradeBase = objvCurrEduClsENS.IdGradeBase; //年级流水号
objvCurrEduClsENT.GradeBaseId = objvCurrEduClsENS.GradeBaseId; //年级代号
objvCurrEduClsENT.GradeBaseName = objvCurrEduClsENS.GradeBaseName; //年级名称
objvCurrEduClsENT.GradeBaseNameA = objvCurrEduClsENS.GradeBaseNameA; //年级名称缩写
objvCurrEduClsENT.IsEffective = objvCurrEduClsENS.IsEffective; //是否有效
objvCurrEduClsENT.IsForPaperReading = objvCurrEduClsENS.IsForPaperReading; //是否参与论文阅读
objvCurrEduClsENT.SchoolYear = objvCurrEduClsENS.SchoolYear; //学年
objvCurrEduClsENT.SchoolTerm = objvCurrEduClsENS.SchoolTerm; //学期
objvCurrEduClsENT.IdCourseType = objvCurrEduClsENS.IdCourseType; //课程类型流水号
objvCurrEduClsENT.CourseTypeId = objvCurrEduClsENS.CourseTypeId; //课程类型ID
objvCurrEduClsENT.CourseTypeName = objvCurrEduClsENS.CourseTypeName; //课程类型名称
objvCurrEduClsENT.IsDegree = objvCurrEduClsENS.IsDegree; //是否学位课
objvCurrEduClsENT.IdScoreType = objvCurrEduClsENS.IdScoreType; //成绩类型流水号
objvCurrEduClsENT.GetScoreWayId = objvCurrEduClsENS.GetScoreWayId; //获得成绩方式Id
objvCurrEduClsENT.IsProportionalCtrl = objvCurrEduClsENS.IsProportionalCtrl; //是否比例控制
objvCurrEduClsENT.IdExamType = objvCurrEduClsENS.IdExamType; //考试方式流水号
objvCurrEduClsENT.BeginWeek = objvCurrEduClsENS.BeginWeek; //开始周
objvCurrEduClsENT.UserType = objvCurrEduClsENS.UserType; //用户类型
objvCurrEduClsENT.ModifyDate = objvCurrEduClsENS.ModifyDate; //修改日期
objvCurrEduClsENT.ModifyUserId = objvCurrEduClsENS.ModifyUserId; //修改人
objvCurrEduClsENT.Memo = objvCurrEduClsENS.Memo; //备注
objvCurrEduClsENT.CurrStuNumValid = objvCurrEduClsENS.CurrStuNumValid; //CurrStuNum_Valid
objvCurrEduClsENT.CurrStuNum = objvCurrEduClsENS.CurrStuNum; //当前学生数
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
 /// <param name = "objvCurrEduClsEN">源简化对象</param>
 public static void SetUpdFlag(clsvCurrEduClsEN objvCurrEduClsEN)
{
try
{
objvCurrEduClsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCurrEduClsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCurrEduCls.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.IdCurrEduCls = objvCurrEduClsEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convCurrEduCls.CurrEduClsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.CurrEduClsId = objvCurrEduClsEN.CurrEduClsId; //教学班Id
}
if (arrFldSet.Contains(convCurrEduCls.EduClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.EduClsName = objvCurrEduClsEN.EduClsName; //教学班名
}
if (arrFldSet.Contains(convCurrEduCls.EduClsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.EduClsTypeId = objvCurrEduClsEN.EduClsTypeId; //教学班类型Id
}
if (arrFldSet.Contains(convCurrEduCls.EduClsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.EduClsTypeName = objvCurrEduClsEN.EduClsTypeName == "[null]" ? null :  objvCurrEduClsEN.EduClsTypeName; //教学班类型名称
}
if (arrFldSet.Contains(convCurrEduCls.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.CourseId = objvCurrEduClsEN.CourseId == "[null]" ? null :  objvCurrEduClsEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convCurrEduCls.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.CourseCode = objvCurrEduClsEN.CourseCode == "[null]" ? null :  objvCurrEduClsEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convCurrEduCls.CourseDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.CourseDescription = objvCurrEduClsEN.CourseDescription == "[null]" ? null :  objvCurrEduClsEN.CourseDescription; //课程描述
}
if (arrFldSet.Contains(convCurrEduCls.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.CourseName = objvCurrEduClsEN.CourseName == "[null]" ? null :  objvCurrEduClsEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convCurrEduCls.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.ViewCount = objvCurrEduClsEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(convCurrEduCls.ExampleImgPath, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.ExampleImgPath = objvCurrEduClsEN.ExampleImgPath == "[null]" ? null :  objvCurrEduClsEN.ExampleImgPath; //示例图路径
}
if (arrFldSet.Contains(convCurrEduCls.TeachingSolutionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.TeachingSolutionId = objvCurrEduClsEN.TeachingSolutionId; //教学方案Id
}
if (arrFldSet.Contains(convCurrEduCls.TeachingSolutionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.TeachingSolutionName = objvCurrEduClsEN.TeachingSolutionName == "[null]" ? null :  objvCurrEduClsEN.TeachingSolutionName; //教学方案名称
}
if (arrFldSet.Contains(convCurrEduCls.IdTeacher, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.IdTeacher = objvCurrEduClsEN.IdTeacher == "[null]" ? null :  objvCurrEduClsEN.IdTeacher; //教师流水号
}
if (arrFldSet.Contains(convCurrEduCls.TeacherId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.TeacherId = objvCurrEduClsEN.TeacherId == "[null]" ? null :  objvCurrEduClsEN.TeacherId; //教师工号
}
if (arrFldSet.Contains(convCurrEduCls.TeacherName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.TeacherName = objvCurrEduClsEN.TeacherName == "[null]" ? null :  objvCurrEduClsEN.TeacherName; //教师姓名
}
if (arrFldSet.Contains(convCurrEduCls.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.IdXzCollege = objvCurrEduClsEN.IdXzCollege == "[null]" ? null :  objvCurrEduClsEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convCurrEduCls.CollegeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.CollegeId = objvCurrEduClsEN.CollegeId == "[null]" ? null :  objvCurrEduClsEN.CollegeId; //学院ID
}
if (arrFldSet.Contains(convCurrEduCls.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.CollegeName = objvCurrEduClsEN.CollegeName == "[null]" ? null :  objvCurrEduClsEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convCurrEduCls.ClgEnglishName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.ClgEnglishName = objvCurrEduClsEN.ClgEnglishName == "[null]" ? null :  objvCurrEduClsEN.ClgEnglishName; //ClgEnglishName
}
if (arrFldSet.Contains(convCurrEduCls.PhoneNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.PhoneNumber = objvCurrEduClsEN.PhoneNumber == "[null]" ? null :  objvCurrEduClsEN.PhoneNumber; //电话
}
if (arrFldSet.Contains(convCurrEduCls.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.IdXzMajor = objvCurrEduClsEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convCurrEduCls.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.MajorName = objvCurrEduClsEN.MajorName == "[null]" ? null :  objvCurrEduClsEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convCurrEduCls.IdEduWay, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.IdEduWay = objvCurrEduClsEN.IdEduWay; //教学方式流水号
}
if (arrFldSet.Contains(convCurrEduCls.IdClassRoomType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.IdClassRoomType = objvCurrEduClsEN.IdClassRoomType; //教室类型流水号
}
if (arrFldSet.Contains(convCurrEduCls.TotalLessonQty, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.TotalLessonQty = objvCurrEduClsEN.TotalLessonQty; //总课时数
}
if (arrFldSet.Contains(convCurrEduCls.MaxStuQty, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.MaxStuQty = objvCurrEduClsEN.MaxStuQty; //最大学生数
}
if (arrFldSet.Contains(convCurrEduCls.WeekQty, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.WeekQty = objvCurrEduClsEN.WeekQty; //总周数
}
if (arrFldSet.Contains(convCurrEduCls.ScheUnitPW, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.ScheUnitPW = objvCurrEduClsEN.ScheUnitPW; //周排课次数
}
if (arrFldSet.Contains(convCurrEduCls.WeekStatusId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.WeekStatusId = objvCurrEduClsEN.WeekStatusId == "[null]" ? null :  objvCurrEduClsEN.WeekStatusId; //周状态编号(单,双,全周)
}
if (arrFldSet.Contains(convCurrEduCls.CustomerWeek, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.CustomerWeek = objvCurrEduClsEN.CustomerWeek == "[null]" ? null :  objvCurrEduClsEN.CustomerWeek; //自定义上课周
}
if (arrFldSet.Contains(convCurrEduCls.LessonQtyPerWeek, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.LessonQtyPerWeek = objvCurrEduClsEN.LessonQtyPerWeek; //周课时数
}
if (arrFldSet.Contains(convCurrEduCls.Mark, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.Mark = objvCurrEduClsEN.Mark; //获得学分
}
if (arrFldSet.Contains(convCurrEduCls.IdUniZone, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.IdUniZone = objvCurrEduClsEN.IdUniZone == "[null]" ? null :  objvCurrEduClsEN.IdUniZone; //校区流水号
}
if (arrFldSet.Contains(convCurrEduCls.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.IdGradeBase = objvCurrEduClsEN.IdGradeBase == "[null]" ? null :  objvCurrEduClsEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(convCurrEduCls.GradeBaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.GradeBaseId = objvCurrEduClsEN.GradeBaseId == "[null]" ? null :  objvCurrEduClsEN.GradeBaseId; //年级代号
}
if (arrFldSet.Contains(convCurrEduCls.GradeBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.GradeBaseName = objvCurrEduClsEN.GradeBaseName == "[null]" ? null :  objvCurrEduClsEN.GradeBaseName; //年级名称
}
if (arrFldSet.Contains(convCurrEduCls.GradeBaseNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.GradeBaseNameA = objvCurrEduClsEN.GradeBaseNameA == "[null]" ? null :  objvCurrEduClsEN.GradeBaseNameA; //年级名称缩写
}
if (arrFldSet.Contains(convCurrEduCls.IsEffective, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.IsEffective = objvCurrEduClsEN.IsEffective; //是否有效
}
if (arrFldSet.Contains(convCurrEduCls.IsForPaperReading, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.IsForPaperReading = objvCurrEduClsEN.IsForPaperReading; //是否参与论文阅读
}
if (arrFldSet.Contains(convCurrEduCls.SchoolYear, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.SchoolYear = objvCurrEduClsEN.SchoolYear == "[null]" ? null :  objvCurrEduClsEN.SchoolYear; //学年
}
if (arrFldSet.Contains(convCurrEduCls.SchoolTerm, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.SchoolTerm = objvCurrEduClsEN.SchoolTerm == "[null]" ? null :  objvCurrEduClsEN.SchoolTerm; //学期
}
if (arrFldSet.Contains(convCurrEduCls.IdCourseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.IdCourseType = objvCurrEduClsEN.IdCourseType; //课程类型流水号
}
if (arrFldSet.Contains(convCurrEduCls.CourseTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.CourseTypeId = objvCurrEduClsEN.CourseTypeId == "[null]" ? null :  objvCurrEduClsEN.CourseTypeId; //课程类型ID
}
if (arrFldSet.Contains(convCurrEduCls.CourseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.CourseTypeName = objvCurrEduClsEN.CourseTypeName == "[null]" ? null :  objvCurrEduClsEN.CourseTypeName; //课程类型名称
}
if (arrFldSet.Contains(convCurrEduCls.IsDegree, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.IsDegree = objvCurrEduClsEN.IsDegree; //是否学位课
}
if (arrFldSet.Contains(convCurrEduCls.IdScoreType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.IdScoreType = objvCurrEduClsEN.IdScoreType == "[null]" ? null :  objvCurrEduClsEN.IdScoreType; //成绩类型流水号
}
if (arrFldSet.Contains(convCurrEduCls.GetScoreWayId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.GetScoreWayId = objvCurrEduClsEN.GetScoreWayId == "[null]" ? null :  objvCurrEduClsEN.GetScoreWayId; //获得成绩方式Id
}
if (arrFldSet.Contains(convCurrEduCls.IsProportionalCtrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.IsProportionalCtrl = objvCurrEduClsEN.IsProportionalCtrl; //是否比例控制
}
if (arrFldSet.Contains(convCurrEduCls.IdExamType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.IdExamType = objvCurrEduClsEN.IdExamType == "[null]" ? null :  objvCurrEduClsEN.IdExamType; //考试方式流水号
}
if (arrFldSet.Contains(convCurrEduCls.BeginWeek, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.BeginWeek = objvCurrEduClsEN.BeginWeek; //开始周
}
if (arrFldSet.Contains(convCurrEduCls.UserType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.UserType = objvCurrEduClsEN.UserType == "[null]" ? null :  objvCurrEduClsEN.UserType; //用户类型
}
if (arrFldSet.Contains(convCurrEduCls.ModifyDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.ModifyDate = objvCurrEduClsEN.ModifyDate == "[null]" ? null :  objvCurrEduClsEN.ModifyDate; //修改日期
}
if (arrFldSet.Contains(convCurrEduCls.ModifyUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.ModifyUserId = objvCurrEduClsEN.ModifyUserId == "[null]" ? null :  objvCurrEduClsEN.ModifyUserId; //修改人
}
if (arrFldSet.Contains(convCurrEduCls.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.Memo = objvCurrEduClsEN.Memo == "[null]" ? null :  objvCurrEduClsEN.Memo; //备注
}
if (arrFldSet.Contains(convCurrEduCls.CurrStuNumValid, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.CurrStuNumValid = objvCurrEduClsEN.CurrStuNumValid; //CurrStuNum_Valid
}
if (arrFldSet.Contains(convCurrEduCls.CurrStuNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsEN.CurrStuNum = objvCurrEduClsEN.CurrStuNum; //当前学生数
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
 /// <param name = "objvCurrEduClsEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCurrEduClsEN objvCurrEduClsEN)
{
try
{
if (objvCurrEduClsEN.EduClsTypeName == "[null]") objvCurrEduClsEN.EduClsTypeName = null; //教学班类型名称
if (objvCurrEduClsEN.CourseId == "[null]") objvCurrEduClsEN.CourseId = null; //课程Id
if (objvCurrEduClsEN.CourseCode == "[null]") objvCurrEduClsEN.CourseCode = null; //课程代码
if (objvCurrEduClsEN.CourseDescription == "[null]") objvCurrEduClsEN.CourseDescription = null; //课程描述
if (objvCurrEduClsEN.CourseName == "[null]") objvCurrEduClsEN.CourseName = null; //课程名称
if (objvCurrEduClsEN.ExampleImgPath == "[null]") objvCurrEduClsEN.ExampleImgPath = null; //示例图路径
if (objvCurrEduClsEN.TeachingSolutionName == "[null]") objvCurrEduClsEN.TeachingSolutionName = null; //教学方案名称
if (objvCurrEduClsEN.IdTeacher == "[null]") objvCurrEduClsEN.IdTeacher = null; //教师流水号
if (objvCurrEduClsEN.TeacherId == "[null]") objvCurrEduClsEN.TeacherId = null; //教师工号
if (objvCurrEduClsEN.TeacherName == "[null]") objvCurrEduClsEN.TeacherName = null; //教师姓名
if (objvCurrEduClsEN.IdXzCollege == "[null]") objvCurrEduClsEN.IdXzCollege = null; //学院流水号
if (objvCurrEduClsEN.CollegeId == "[null]") objvCurrEduClsEN.CollegeId = null; //学院ID
if (objvCurrEduClsEN.CollegeName == "[null]") objvCurrEduClsEN.CollegeName = null; //学院名称
if (objvCurrEduClsEN.ClgEnglishName == "[null]") objvCurrEduClsEN.ClgEnglishName = null; //ClgEnglishName
if (objvCurrEduClsEN.PhoneNumber == "[null]") objvCurrEduClsEN.PhoneNumber = null; //电话
if (objvCurrEduClsEN.MajorName == "[null]") objvCurrEduClsEN.MajorName = null; //专业名称
if (objvCurrEduClsEN.WeekStatusId == "[null]") objvCurrEduClsEN.WeekStatusId = null; //周状态编号(单,双,全周)
if (objvCurrEduClsEN.CustomerWeek == "[null]") objvCurrEduClsEN.CustomerWeek = null; //自定义上课周
if (objvCurrEduClsEN.IdUniZone == "[null]") objvCurrEduClsEN.IdUniZone = null; //校区流水号
if (objvCurrEduClsEN.IdGradeBase == "[null]") objvCurrEduClsEN.IdGradeBase = null; //年级流水号
if (objvCurrEduClsEN.GradeBaseId == "[null]") objvCurrEduClsEN.GradeBaseId = null; //年级代号
if (objvCurrEduClsEN.GradeBaseName == "[null]") objvCurrEduClsEN.GradeBaseName = null; //年级名称
if (objvCurrEduClsEN.GradeBaseNameA == "[null]") objvCurrEduClsEN.GradeBaseNameA = null; //年级名称缩写
if (objvCurrEduClsEN.SchoolYear == "[null]") objvCurrEduClsEN.SchoolYear = null; //学年
if (objvCurrEduClsEN.SchoolTerm == "[null]") objvCurrEduClsEN.SchoolTerm = null; //学期
if (objvCurrEduClsEN.CourseTypeId == "[null]") objvCurrEduClsEN.CourseTypeId = null; //课程类型ID
if (objvCurrEduClsEN.CourseTypeName == "[null]") objvCurrEduClsEN.CourseTypeName = null; //课程类型名称
if (objvCurrEduClsEN.IdScoreType == "[null]") objvCurrEduClsEN.IdScoreType = null; //成绩类型流水号
if (objvCurrEduClsEN.GetScoreWayId == "[null]") objvCurrEduClsEN.GetScoreWayId = null; //获得成绩方式Id
if (objvCurrEduClsEN.IdExamType == "[null]") objvCurrEduClsEN.IdExamType = null; //考试方式流水号
if (objvCurrEduClsEN.UserType == "[null]") objvCurrEduClsEN.UserType = null; //用户类型
if (objvCurrEduClsEN.ModifyDate == "[null]") objvCurrEduClsEN.ModifyDate = null; //修改日期
if (objvCurrEduClsEN.ModifyUserId == "[null]") objvCurrEduClsEN.ModifyUserId = null; //修改人
if (objvCurrEduClsEN.Memo == "[null]") objvCurrEduClsEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvCurrEduClsEN objvCurrEduClsEN)
{
 vCurrEduClsDA.CheckProperty4Condition(objvCurrEduClsEN);
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
string strCondition = string.Format("1 =1 Order By {0}", convCurrEduCls.IdCurrEduCls); 
List<clsvCurrEduClsEN> arrObjLst = clsvCurrEduClsBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvCurrEduClsEN objvCurrEduClsEN = new clsvCurrEduClsEN()
{
IdCurrEduCls = "0",
EduClsName = "选[v当前教学班]..."
};
arrObjLst.Insert(0, objvCurrEduClsEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convCurrEduCls.IdCurrEduCls;
objComboBox.DisplayMember = convCurrEduCls.EduClsName;
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v当前教学班]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convCurrEduCls.IdCurrEduCls); 
IEnumerable<clsvCurrEduClsEN> arrObjLst = clsvCurrEduClsBL.GetObjLst(strCondition);
objDDL.DataValueField = convCurrEduCls.IdCurrEduCls;
objDDL.DataTextField = convCurrEduCls.EduClsName;
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v当前教学班]...","0");
List<clsvCurrEduClsEN> arrvCurrEduClsObjLst = GetAllvCurrEduClsObjLstCache(); 
objDDL.DataValueField = convCurrEduCls.IdCurrEduCls;
objDDL.DataTextField = convCurrEduCls.EduClsName;
objDDL.DataSource = arrvCurrEduClsObjLst;
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
//if (arrvCurrEduClsObjLstCache == null)
//{
//arrvCurrEduClsObjLstCache = vCurrEduClsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdCurrEduCls">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCurrEduClsEN GetObjByIdCurrEduClsCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvCurrEduClsEN._CurrTabName);
List<clsvCurrEduClsEN> arrvCurrEduClsObjLstCache = GetObjLstCache();
IEnumerable <clsvCurrEduClsEN> arrvCurrEduClsObjLst_Sel =
arrvCurrEduClsObjLstCache
.Where(x=> x.IdCurrEduCls == strIdCurrEduCls 
);
if (arrvCurrEduClsObjLst_Sel.Count() == 0)
{
   clsvCurrEduClsEN obj = clsvCurrEduClsBL.GetObjByIdCurrEduCls(strIdCurrEduCls);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvCurrEduClsObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdCurrEduCls">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetEduClsNameByIdCurrEduClsCache(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true) return "";
//获取缓存中的对象列表
clsvCurrEduClsEN objvCurrEduCls = GetObjByIdCurrEduClsCache(strIdCurrEduCls);
if (objvCurrEduCls == null) return "";
return objvCurrEduCls.EduClsName;
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
clsvCurrEduClsEN objvCurrEduCls = GetObjByIdCurrEduClsCache(strIdCurrEduCls);
if (objvCurrEduCls == null) return "";
return objvCurrEduCls.EduClsName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCurrEduClsEN> GetAllvCurrEduClsObjLstCache()
{
//获取缓存中的对象列表
List<clsvCurrEduClsEN> arrvCurrEduClsObjLstCache = GetObjLstCache(); 
return arrvCurrEduClsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCurrEduClsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvCurrEduClsEN._CurrTabName);
List<clsvCurrEduClsEN> arrvCurrEduClsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCurrEduClsObjLstCache;
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
string strKey = string.Format("{0}", clsvCurrEduClsEN._CurrTabName);
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
 /// 日期:2024-03-18
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strIdCurrEduCls)
{
if (strInFldName != convCurrEduCls.IdCurrEduCls)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCurrEduCls.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCurrEduCls.AttributeName));
throw new Exception(strMsg);
}
var objvCurrEduCls = clsvCurrEduClsBL.GetObjByIdCurrEduClsCache(strIdCurrEduCls);
if (objvCurrEduCls == null) return "";
return objvCurrEduCls[strOutFldName].ToString();
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
int intRecCount = clsvCurrEduClsDA.GetRecCount(strTabName);
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
int intRecCount = clsvCurrEduClsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCurrEduClsDA.GetRecCount();
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
int intRecCount = clsvCurrEduClsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCurrEduClsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCurrEduClsEN objvCurrEduClsCond)
{
List<clsvCurrEduClsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCurrEduClsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCurrEduCls.AttributeName)
{
if (objvCurrEduClsCond.IsUpdated(strFldName) == false) continue;
if (objvCurrEduClsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCurrEduClsCond[strFldName].ToString());
}
else
{
if (objvCurrEduClsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCurrEduClsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCurrEduClsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCurrEduClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCurrEduClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCurrEduClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCurrEduClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCurrEduClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCurrEduClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCurrEduClsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCurrEduClsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCurrEduClsCond[strFldName]));
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
 List<string> arrList = clsvCurrEduClsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCurrEduClsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCurrEduClsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}