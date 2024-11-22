
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCurrEduClsTeacherBL
 表名:vCurrEduClsTeacher(01120128)
 * 版本:2024.03.11.1(服务器:WIN-SRV103-116)
 日期:2024/03/18 17:50:13
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
public static class  clsvCurrEduClsTeacherBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdEduClsTeacher">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCurrEduClsTeacherEN GetObj(this K_IdEduClsTeacher_vCurrEduClsTeacher myKey)
{
clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN = clsvCurrEduClsTeacherBL.vCurrEduClsTeacherDA.GetObjByIdEduClsTeacher(myKey.Value);
return objvCurrEduClsTeacherEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetIdEduClsTeacher(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, long lngIdEduClsTeacher, string strComparisonOp="")
	{
objvCurrEduClsTeacherEN.IdEduClsTeacher = lngIdEduClsTeacher; //教学班老师流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.IdEduClsTeacher) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.IdEduClsTeacher, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.IdEduClsTeacher] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetIdCurrEduCls(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strIdCurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCurrEduCls, convCurrEduClsTeacher.IdCurrEduCls);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convCurrEduClsTeacher.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convCurrEduClsTeacher.IdCurrEduCls);
}
objvCurrEduClsTeacherEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.IdCurrEduCls) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.IdCurrEduCls, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.IdCurrEduCls] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetCurrEduClsId(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strCurrEduClsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, convCurrEduClsTeacher.CurrEduClsId);
}
objvCurrEduClsTeacherEN.CurrEduClsId = strCurrEduClsId; //教学班Id
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetEduClsName(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduClsName, convCurrEduClsTeacher.EduClsName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convCurrEduClsTeacher.EduClsName);
}
objvCurrEduClsTeacherEN.EduClsName = strEduClsName; //教学班名
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetEduClsTypeId(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strEduClsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduClsTypeId, convCurrEduClsTeacher.EduClsTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsTypeId, 4, convCurrEduClsTeacher.EduClsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEduClsTypeId, 4, convCurrEduClsTeacher.EduClsTypeId);
}
objvCurrEduClsTeacherEN.EduClsTypeId = strEduClsTypeId; //教学班类型Id
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetEduClsTypeName(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strEduClsTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsTypeName, 100, convCurrEduClsTeacher.EduClsTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetCourseId(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCurrEduClsTeacher.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCurrEduClsTeacher.CourseId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetCourseCode(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCurrEduClsTeacher.CourseCode);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetCourseName(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCurrEduClsTeacher.CourseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetExampleImgPath(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strExampleImgPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExampleImgPath, 300, convCurrEduClsTeacher.ExampleImgPath);
}
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
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetTeachingSolutionId(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strTeachingSolutionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingSolutionId, 8, convCurrEduClsTeacher.TeachingSolutionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingSolutionId, 8, convCurrEduClsTeacher.TeachingSolutionId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetTeachingSolutionName(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strTeachingSolutionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingSolutionName, 100, convCurrEduClsTeacher.TeachingSolutionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetIdXzCollege(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convCurrEduClsTeacher.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convCurrEduClsTeacher.IdXzCollege);
}
objvCurrEduClsTeacherEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.IdXzCollege) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.IdXzCollege, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.IdXzCollege] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetCollegeId(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strCollegeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeId, 4, convCurrEduClsTeacher.CollegeId);
}
objvCurrEduClsTeacherEN.CollegeId = strCollegeId; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.CollegeId) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.CollegeId, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.CollegeId] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetIdEduWay(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strIdEduWay, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdEduWay, 4, convCurrEduClsTeacher.IdEduWay);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdEduWay, 4, convCurrEduClsTeacher.IdEduWay);
}
objvCurrEduClsTeacherEN.IdEduWay = strIdEduWay; //教学方式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.IdEduWay) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.IdEduWay, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.IdEduWay] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetTotalLessonQty(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, int? intTotalLessonQty, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetMaxStuQty(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, int? intMaxStuQty, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetWeekQty(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, int? intWeekQty, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetScheUnitPW(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, short? shtScheUnitPW, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetWeekStatusId(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strWeekStatusId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWeekStatusId, 2, convCurrEduClsTeacher.WeekStatusId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWeekStatusId, 2, convCurrEduClsTeacher.WeekStatusId);
}
objvCurrEduClsTeacherEN.WeekStatusId = strWeekStatusId; //周状态编号(单,双,全周)
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.WeekStatusId) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.WeekStatusId, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.WeekStatusId] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetCustomerWeek(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strCustomerWeek, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCustomerWeek, 50, convCurrEduClsTeacher.CustomerWeek);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetLessonQtyPerWeek(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, short? shtLessonQtyPerWeek, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetIdUniZone(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strIdUniZone, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdUniZone, 4, convCurrEduClsTeacher.IdUniZone);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdUniZone, 4, convCurrEduClsTeacher.IdUniZone);
}
objvCurrEduClsTeacherEN.IdUniZone = strIdUniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.IdUniZone) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.IdUniZone, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.IdUniZone] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetIdGradeBase(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strIdGradeBase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, convCurrEduClsTeacher.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, convCurrEduClsTeacher.IdGradeBase);
}
objvCurrEduClsTeacherEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.IdGradeBase) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.IdGradeBase, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.IdGradeBase] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetGradeBaseId(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strGradeBaseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseId, 4, convCurrEduClsTeacher.GradeBaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGradeBaseId, 4, convCurrEduClsTeacher.GradeBaseId);
}
objvCurrEduClsTeacherEN.GradeBaseId = strGradeBaseId; //年级代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.GradeBaseId) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.GradeBaseId, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.GradeBaseId] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetGradeBaseName(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strGradeBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convCurrEduClsTeacher.GradeBaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetIdCourseType(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strIdCourseType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCourseType, 4, convCurrEduClsTeacher.IdCourseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCourseType, 4, convCurrEduClsTeacher.IdCourseType);
}
objvCurrEduClsTeacherEN.IdCourseType = strIdCourseType; //课程类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.IdCourseType) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.IdCourseType, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.IdCourseType] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetCourseTypeId(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strCourseTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseTypeId, 4, convCurrEduClsTeacher.CourseTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseTypeId, 4, convCurrEduClsTeacher.CourseTypeId);
}
objvCurrEduClsTeacherEN.CourseTypeId = strCourseTypeId; //课程类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.CourseTypeId) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.CourseTypeId, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.CourseTypeId] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetCourseTypeName(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strCourseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseTypeName, 30, convCurrEduClsTeacher.CourseTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetIdScoreType(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strIdScoreType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdScoreType, 4, convCurrEduClsTeacher.IdScoreType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdScoreType, 4, convCurrEduClsTeacher.IdScoreType);
}
objvCurrEduClsTeacherEN.IdScoreType = strIdScoreType; //成绩类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.IdScoreType) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.IdScoreType, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.IdScoreType] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetIdExamType(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strIdExamType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdExamType, 4, convCurrEduClsTeacher.IdExamType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdExamType, 4, convCurrEduClsTeacher.IdExamType);
}
objvCurrEduClsTeacherEN.IdExamType = strIdExamType; //考试方式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.IdExamType) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.IdExamType, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.IdExamType] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetBeginWeek(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, short? shtBeginWeek, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetCurrStuNumValid(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, int? intCurrStuNumValid, string strComparisonOp="")
	{
objvCurrEduClsTeacherEN.CurrStuNumValid = intCurrStuNumValid; //CurrStuNum_Valid
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.CurrStuNumValid) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.CurrStuNumValid, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.CurrStuNumValid] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetCurrStuNum(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, int? intCurrStuNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetIdTeacher(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strIdTeacher, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeacher, 8, convCurrEduClsTeacher.IdTeacher);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeacher, 8, convCurrEduClsTeacher.IdTeacher);
}
objvCurrEduClsTeacherEN.IdTeacher = strIdTeacher; //教师流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.IdTeacher) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.IdTeacher, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.IdTeacher] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetTeacherId(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strTeacherId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeacherId, 12, convCurrEduClsTeacher.TeacherId);
}
objvCurrEduClsTeacherEN.TeacherId = strTeacherId; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.TeacherId) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.TeacherId, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.TeacherId] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetTeacherName(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strTeacherName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeacherName, 50, convCurrEduClsTeacher.TeacherName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetIdProfGrade(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strIdProfGrade, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdProfGrade, 4, convCurrEduClsTeacher.IdProfGrade);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdProfGrade, 4, convCurrEduClsTeacher.IdProfGrade);
}
objvCurrEduClsTeacherEN.IdProfGrade = strIdProfGrade; //专业职称流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.IdProfGrade) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.IdProfGrade, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.IdProfGrade] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetProfenssionalGradeName(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strProfenssionalGradeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProfenssionalGradeName, 30, convCurrEduClsTeacher.ProfenssionalGradeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetDegreeName(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strDegreeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDegreeName, 30, convCurrEduClsTeacher.DegreeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetBirthday(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strBirthday, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBirthday, 8, convCurrEduClsTeacher.Birthday);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strBirthday, 8, convCurrEduClsTeacher.Birthday);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetCollegeName(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCurrEduClsTeacher.CollegeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetIdPk2EduClsTeacherType(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strIdPk2EduClsTeacherType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdPk2EduClsTeacherType, convCurrEduClsTeacher.IdPk2EduClsTeacherType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPk2EduClsTeacherType, 4, convCurrEduClsTeacher.IdPk2EduClsTeacherType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPk2EduClsTeacherType, 4, convCurrEduClsTeacher.IdPk2EduClsTeacherType);
}
objvCurrEduClsTeacherEN.IdPk2EduClsTeacherType = strIdPk2EduClsTeacherType; //教学班老师角色(主讲,辅导)流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.IdPk2EduClsTeacherType) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.IdPk2EduClsTeacherType, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.IdPk2EduClsTeacherType] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetEduClsTeacherTypeId(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strEduClsTeacherTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsTeacherTypeId, 4, convCurrEduClsTeacher.EduClsTeacherTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEduClsTeacherTypeId, 4, convCurrEduClsTeacher.EduClsTeacherTypeId);
}
objvCurrEduClsTeacherEN.EduClsTeacherTypeId = strEduClsTeacherTypeId; //教学班教学类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.EduClsTeacherTypeId) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.EduClsTeacherTypeId, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.EduClsTeacherTypeId] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetEduClsTeacherTypeDesc(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strEduClsTeacherTypeDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsTeacherTypeDesc, 20, convCurrEduClsTeacher.EduClsTeacherTypeDesc);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetSchoolTerm(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strSchoolTerm, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, convCurrEduClsTeacher.SchoolTerm);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, convCurrEduClsTeacher.SchoolTerm);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetSchoolYear(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strSchoolYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, convCurrEduClsTeacher.SchoolYear);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetOpenBeginDate(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strOpenBeginDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOpenBeginDate, 8, convCurrEduClsTeacher.OpenBeginDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetOpenEndDate(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strOpenEndDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOpenEndDate, 8, convCurrEduClsTeacher.OpenEndDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetOrderNum(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, int? intOrderNum, string strComparisonOp="")
	{
objvCurrEduClsTeacherEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.OrderNum) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.OrderNum, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.OrderNum] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetUpdDate(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCurrEduClsTeacher.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetUpdUser(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCurrEduClsTeacher.UpdUser);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetMemo(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCurrEduClsTeacher.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetCollegeName4EduCls(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strCollegeName4EduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName4EduCls, 60, convCurrEduClsTeacher.CollegeName4EduCls);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetCollegeName4Teacher(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strCollegeName4Teacher, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName4Teacher, 60, convCurrEduClsTeacher.CollegeName4Teacher);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsTeacherEN SetUserType(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN, string strUserType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserType, 50, convCurrEduClsTeacher.UserType);
}
objvCurrEduClsTeacherEN.UserType = strUserType; //用户类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(convCurrEduClsTeacher.UserType) == false)
{
objvCurrEduClsTeacherEN.dicFldComparisonOp.Add(convCurrEduClsTeacher.UserType, strComparisonOp);
}
else
{
objvCurrEduClsTeacherEN.dicFldComparisonOp[convCurrEduClsTeacher.UserType] = strComparisonOp;
}
}
return objvCurrEduClsTeacherEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherENS">源对象</param>
 /// <param name = "objvCurrEduClsTeacherENT">目标对象</param>
 public static void CopyTo(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherENS, clsvCurrEduClsTeacherEN objvCurrEduClsTeacherENT)
{
try
{
objvCurrEduClsTeacherENT.IdEduClsTeacher = objvCurrEduClsTeacherENS.IdEduClsTeacher; //教学班老师流水号
objvCurrEduClsTeacherENT.IdCurrEduCls = objvCurrEduClsTeacherENS.IdCurrEduCls; //教学班流水号
objvCurrEduClsTeacherENT.CurrEduClsId = objvCurrEduClsTeacherENS.CurrEduClsId; //教学班Id
objvCurrEduClsTeacherENT.EduClsName = objvCurrEduClsTeacherENS.EduClsName; //教学班名
objvCurrEduClsTeacherENT.EduClsTypeId = objvCurrEduClsTeacherENS.EduClsTypeId; //教学班类型Id
objvCurrEduClsTeacherENT.EduClsTypeName = objvCurrEduClsTeacherENS.EduClsTypeName; //教学班类型名称
objvCurrEduClsTeacherENT.CourseId = objvCurrEduClsTeacherENS.CourseId; //课程Id
objvCurrEduClsTeacherENT.CourseCode = objvCurrEduClsTeacherENS.CourseCode; //课程代码
objvCurrEduClsTeacherENT.CourseName = objvCurrEduClsTeacherENS.CourseName; //课程名称
objvCurrEduClsTeacherENT.ExampleImgPath = objvCurrEduClsTeacherENS.ExampleImgPath; //示例图路径
objvCurrEduClsTeacherENT.TeachingSolutionId = objvCurrEduClsTeacherENS.TeachingSolutionId; //教学方案Id
objvCurrEduClsTeacherENT.TeachingSolutionName = objvCurrEduClsTeacherENS.TeachingSolutionName; //教学方案名称
objvCurrEduClsTeacherENT.IdXzCollege = objvCurrEduClsTeacherENS.IdXzCollege; //学院流水号
objvCurrEduClsTeacherENT.CollegeId = objvCurrEduClsTeacherENS.CollegeId; //学院ID
objvCurrEduClsTeacherENT.IdEduWay = objvCurrEduClsTeacherENS.IdEduWay; //教学方式流水号
objvCurrEduClsTeacherENT.TotalLessonQty = objvCurrEduClsTeacherENS.TotalLessonQty; //总课时数
objvCurrEduClsTeacherENT.MaxStuQty = objvCurrEduClsTeacherENS.MaxStuQty; //最大学生数
objvCurrEduClsTeacherENT.WeekQty = objvCurrEduClsTeacherENS.WeekQty; //总周数
objvCurrEduClsTeacherENT.ScheUnitPW = objvCurrEduClsTeacherENS.ScheUnitPW; //周排课次数
objvCurrEduClsTeacherENT.WeekStatusId = objvCurrEduClsTeacherENS.WeekStatusId; //周状态编号(单,双,全周)
objvCurrEduClsTeacherENT.CustomerWeek = objvCurrEduClsTeacherENS.CustomerWeek; //自定义上课周
objvCurrEduClsTeacherENT.LessonQtyPerWeek = objvCurrEduClsTeacherENS.LessonQtyPerWeek; //周课时数
objvCurrEduClsTeacherENT.IdUniZone = objvCurrEduClsTeacherENS.IdUniZone; //校区流水号
objvCurrEduClsTeacherENT.IdGradeBase = objvCurrEduClsTeacherENS.IdGradeBase; //年级流水号
objvCurrEduClsTeacherENT.GradeBaseId = objvCurrEduClsTeacherENS.GradeBaseId; //年级代号
objvCurrEduClsTeacherENT.GradeBaseName = objvCurrEduClsTeacherENS.GradeBaseName; //年级名称
objvCurrEduClsTeacherENT.IsEffective = objvCurrEduClsTeacherENS.IsEffective; //是否有效
objvCurrEduClsTeacherENT.IdCourseType = objvCurrEduClsTeacherENS.IdCourseType; //课程类型流水号
objvCurrEduClsTeacherENT.CourseTypeId = objvCurrEduClsTeacherENS.CourseTypeId; //课程类型ID
objvCurrEduClsTeacherENT.CourseTypeName = objvCurrEduClsTeacherENS.CourseTypeName; //课程类型名称
objvCurrEduClsTeacherENT.IsDegree = objvCurrEduClsTeacherENS.IsDegree; //是否学位课
objvCurrEduClsTeacherENT.IdScoreType = objvCurrEduClsTeacherENS.IdScoreType; //成绩类型流水号
objvCurrEduClsTeacherENT.IsProportionalCtrl = objvCurrEduClsTeacherENS.IsProportionalCtrl; //是否比例控制
objvCurrEduClsTeacherENT.IdExamType = objvCurrEduClsTeacherENS.IdExamType; //考试方式流水号
objvCurrEduClsTeacherENT.BeginWeek = objvCurrEduClsTeacherENS.BeginWeek; //开始周
objvCurrEduClsTeacherENT.CurrStuNumValid = objvCurrEduClsTeacherENS.CurrStuNumValid; //CurrStuNum_Valid
objvCurrEduClsTeacherENT.CurrStuNum = objvCurrEduClsTeacherENS.CurrStuNum; //当前学生数
objvCurrEduClsTeacherENT.IdTeacher = objvCurrEduClsTeacherENS.IdTeacher; //教师流水号
objvCurrEduClsTeacherENT.TeacherId = objvCurrEduClsTeacherENS.TeacherId; //教师工号
objvCurrEduClsTeacherENT.TeacherName = objvCurrEduClsTeacherENS.TeacherName; //教师姓名
objvCurrEduClsTeacherENT.IdProfGrade = objvCurrEduClsTeacherENS.IdProfGrade; //专业职称流水号
objvCurrEduClsTeacherENT.ProfenssionalGradeName = objvCurrEduClsTeacherENS.ProfenssionalGradeName; //专业职称
objvCurrEduClsTeacherENT.DegreeName = objvCurrEduClsTeacherENS.DegreeName; //学位名称
objvCurrEduClsTeacherENT.Birthday = objvCurrEduClsTeacherENS.Birthday; //出生日期
objvCurrEduClsTeacherENT.IsGpUser = objvCurrEduClsTeacherENS.IsGpUser; //是否Gp用户
objvCurrEduClsTeacherENT.CollegeName = objvCurrEduClsTeacherENS.CollegeName; //学院名称
objvCurrEduClsTeacherENT.IdPk2EduClsTeacherType = objvCurrEduClsTeacherENS.IdPk2EduClsTeacherType; //教学班老师角色(主讲,辅导)流水号
objvCurrEduClsTeacherENT.EduClsTeacherTypeId = objvCurrEduClsTeacherENS.EduClsTeacherTypeId; //教学班教学类型ID
objvCurrEduClsTeacherENT.EduClsTeacherTypeDesc = objvCurrEduClsTeacherENS.EduClsTeacherTypeDesc; //教学班教师类型名
objvCurrEduClsTeacherENT.SchoolTerm = objvCurrEduClsTeacherENS.SchoolTerm; //学期
objvCurrEduClsTeacherENT.SchoolYear = objvCurrEduClsTeacherENS.SchoolYear; //学年
objvCurrEduClsTeacherENT.OpenBeginDate = objvCurrEduClsTeacherENS.OpenBeginDate; //开放开始日期
objvCurrEduClsTeacherENT.OpenEndDate = objvCurrEduClsTeacherENS.OpenEndDate; //开放结束日期
objvCurrEduClsTeacherENT.OrderNum = objvCurrEduClsTeacherENS.OrderNum; //序号
objvCurrEduClsTeacherENT.UpdDate = objvCurrEduClsTeacherENS.UpdDate; //修改日期
objvCurrEduClsTeacherENT.UpdUser = objvCurrEduClsTeacherENS.UpdUser; //修改人
objvCurrEduClsTeacherENT.Memo = objvCurrEduClsTeacherENS.Memo; //备注
objvCurrEduClsTeacherENT.CollegeName4EduCls = objvCurrEduClsTeacherENS.CollegeName4EduCls; //学院名_教学班
objvCurrEduClsTeacherENT.CollegeName4Teacher = objvCurrEduClsTeacherENS.CollegeName4Teacher; //学院名_教师
objvCurrEduClsTeacherENT.UserType = objvCurrEduClsTeacherENS.UserType; //用户类型
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
 /// <param name = "objvCurrEduClsTeacherENS">源对象</param>
 /// <returns>目标对象=>clsvCurrEduClsTeacherEN:objvCurrEduClsTeacherENT</returns>
 public static clsvCurrEduClsTeacherEN CopyTo(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherENS)
{
try
{
 clsvCurrEduClsTeacherEN objvCurrEduClsTeacherENT = new clsvCurrEduClsTeacherEN()
{
IdEduClsTeacher = objvCurrEduClsTeacherENS.IdEduClsTeacher, //教学班老师流水号
IdCurrEduCls = objvCurrEduClsTeacherENS.IdCurrEduCls, //教学班流水号
CurrEduClsId = objvCurrEduClsTeacherENS.CurrEduClsId, //教学班Id
EduClsName = objvCurrEduClsTeacherENS.EduClsName, //教学班名
EduClsTypeId = objvCurrEduClsTeacherENS.EduClsTypeId, //教学班类型Id
EduClsTypeName = objvCurrEduClsTeacherENS.EduClsTypeName, //教学班类型名称
CourseId = objvCurrEduClsTeacherENS.CourseId, //课程Id
CourseCode = objvCurrEduClsTeacherENS.CourseCode, //课程代码
CourseName = objvCurrEduClsTeacherENS.CourseName, //课程名称
ExampleImgPath = objvCurrEduClsTeacherENS.ExampleImgPath, //示例图路径
TeachingSolutionId = objvCurrEduClsTeacherENS.TeachingSolutionId, //教学方案Id
TeachingSolutionName = objvCurrEduClsTeacherENS.TeachingSolutionName, //教学方案名称
IdXzCollege = objvCurrEduClsTeacherENS.IdXzCollege, //学院流水号
CollegeId = objvCurrEduClsTeacherENS.CollegeId, //学院ID
IdEduWay = objvCurrEduClsTeacherENS.IdEduWay, //教学方式流水号
TotalLessonQty = objvCurrEduClsTeacherENS.TotalLessonQty, //总课时数
MaxStuQty = objvCurrEduClsTeacherENS.MaxStuQty, //最大学生数
WeekQty = objvCurrEduClsTeacherENS.WeekQty, //总周数
ScheUnitPW = objvCurrEduClsTeacherENS.ScheUnitPW, //周排课次数
WeekStatusId = objvCurrEduClsTeacherENS.WeekStatusId, //周状态编号(单,双,全周)
CustomerWeek = objvCurrEduClsTeacherENS.CustomerWeek, //自定义上课周
LessonQtyPerWeek = objvCurrEduClsTeacherENS.LessonQtyPerWeek, //周课时数
IdUniZone = objvCurrEduClsTeacherENS.IdUniZone, //校区流水号
IdGradeBase = objvCurrEduClsTeacherENS.IdGradeBase, //年级流水号
GradeBaseId = objvCurrEduClsTeacherENS.GradeBaseId, //年级代号
GradeBaseName = objvCurrEduClsTeacherENS.GradeBaseName, //年级名称
IsEffective = objvCurrEduClsTeacherENS.IsEffective, //是否有效
IdCourseType = objvCurrEduClsTeacherENS.IdCourseType, //课程类型流水号
CourseTypeId = objvCurrEduClsTeacherENS.CourseTypeId, //课程类型ID
CourseTypeName = objvCurrEduClsTeacherENS.CourseTypeName, //课程类型名称
IsDegree = objvCurrEduClsTeacherENS.IsDegree, //是否学位课
IdScoreType = objvCurrEduClsTeacherENS.IdScoreType, //成绩类型流水号
IsProportionalCtrl = objvCurrEduClsTeacherENS.IsProportionalCtrl, //是否比例控制
IdExamType = objvCurrEduClsTeacherENS.IdExamType, //考试方式流水号
BeginWeek = objvCurrEduClsTeacherENS.BeginWeek, //开始周
CurrStuNumValid = objvCurrEduClsTeacherENS.CurrStuNumValid, //CurrStuNum_Valid
CurrStuNum = objvCurrEduClsTeacherENS.CurrStuNum, //当前学生数
IdTeacher = objvCurrEduClsTeacherENS.IdTeacher, //教师流水号
TeacherId = objvCurrEduClsTeacherENS.TeacherId, //教师工号
TeacherName = objvCurrEduClsTeacherENS.TeacherName, //教师姓名
IdProfGrade = objvCurrEduClsTeacherENS.IdProfGrade, //专业职称流水号
ProfenssionalGradeName = objvCurrEduClsTeacherENS.ProfenssionalGradeName, //专业职称
DegreeName = objvCurrEduClsTeacherENS.DegreeName, //学位名称
Birthday = objvCurrEduClsTeacherENS.Birthday, //出生日期
IsGpUser = objvCurrEduClsTeacherENS.IsGpUser, //是否Gp用户
CollegeName = objvCurrEduClsTeacherENS.CollegeName, //学院名称
IdPk2EduClsTeacherType = objvCurrEduClsTeacherENS.IdPk2EduClsTeacherType, //教学班老师角色(主讲,辅导)流水号
EduClsTeacherTypeId = objvCurrEduClsTeacherENS.EduClsTeacherTypeId, //教学班教学类型ID
EduClsTeacherTypeDesc = objvCurrEduClsTeacherENS.EduClsTeacherTypeDesc, //教学班教师类型名
SchoolTerm = objvCurrEduClsTeacherENS.SchoolTerm, //学期
SchoolYear = objvCurrEduClsTeacherENS.SchoolYear, //学年
OpenBeginDate = objvCurrEduClsTeacherENS.OpenBeginDate, //开放开始日期
OpenEndDate = objvCurrEduClsTeacherENS.OpenEndDate, //开放结束日期
OrderNum = objvCurrEduClsTeacherENS.OrderNum, //序号
UpdDate = objvCurrEduClsTeacherENS.UpdDate, //修改日期
UpdUser = objvCurrEduClsTeacherENS.UpdUser, //修改人
Memo = objvCurrEduClsTeacherENS.Memo, //备注
CollegeName4EduCls = objvCurrEduClsTeacherENS.CollegeName4EduCls, //学院名_教学班
CollegeName4Teacher = objvCurrEduClsTeacherENS.CollegeName4Teacher, //学院名_教师
UserType = objvCurrEduClsTeacherENS.UserType, //用户类型
};
 return objvCurrEduClsTeacherENT;
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
public static void CheckProperty4Condition(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN)
{
 clsvCurrEduClsTeacherBL.vCurrEduClsTeacherDA.CheckProperty4Condition(objvCurrEduClsTeacherEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCurrEduClsTeacherEN objvCurrEduClsTeacherCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.IdEduClsTeacher) == true)
{
string strComparisonOpIdEduClsTeacher = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.IdEduClsTeacher];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsTeacher.IdEduClsTeacher, objvCurrEduClsTeacherCond.IdEduClsTeacher, strComparisonOpIdEduClsTeacher);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.IdCurrEduCls, objvCurrEduClsTeacherCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.CurrEduClsId) == true)
{
string strComparisonOpCurrEduClsId = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.CurrEduClsId, objvCurrEduClsTeacherCond.CurrEduClsId, strComparisonOpCurrEduClsId);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.EduClsName) == true)
{
string strComparisonOpEduClsName = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.EduClsName, objvCurrEduClsTeacherCond.EduClsName, strComparisonOpEduClsName);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.EduClsTypeId) == true)
{
string strComparisonOpEduClsTypeId = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.EduClsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.EduClsTypeId, objvCurrEduClsTeacherCond.EduClsTypeId, strComparisonOpEduClsTypeId);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.EduClsTypeName) == true)
{
string strComparisonOpEduClsTypeName = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.EduClsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.EduClsTypeName, objvCurrEduClsTeacherCond.EduClsTypeName, strComparisonOpEduClsTypeName);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.CourseId) == true)
{
string strComparisonOpCourseId = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.CourseId, objvCurrEduClsTeacherCond.CourseId, strComparisonOpCourseId);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.CourseCode) == true)
{
string strComparisonOpCourseCode = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.CourseCode, objvCurrEduClsTeacherCond.CourseCode, strComparisonOpCourseCode);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.CourseName) == true)
{
string strComparisonOpCourseName = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.CourseName, objvCurrEduClsTeacherCond.CourseName, strComparisonOpCourseName);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.ExampleImgPath) == true)
{
string strComparisonOpExampleImgPath = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.ExampleImgPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.ExampleImgPath, objvCurrEduClsTeacherCond.ExampleImgPath, strComparisonOpExampleImgPath);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.TeachingSolutionId) == true)
{
string strComparisonOpTeachingSolutionId = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.TeachingSolutionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.TeachingSolutionId, objvCurrEduClsTeacherCond.TeachingSolutionId, strComparisonOpTeachingSolutionId);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.TeachingSolutionName) == true)
{
string strComparisonOpTeachingSolutionName = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.TeachingSolutionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.TeachingSolutionName, objvCurrEduClsTeacherCond.TeachingSolutionName, strComparisonOpTeachingSolutionName);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.IdXzCollege, objvCurrEduClsTeacherCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.CollegeId) == true)
{
string strComparisonOpCollegeId = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.CollegeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.CollegeId, objvCurrEduClsTeacherCond.CollegeId, strComparisonOpCollegeId);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.IdEduWay) == true)
{
string strComparisonOpIdEduWay = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.IdEduWay];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.IdEduWay, objvCurrEduClsTeacherCond.IdEduWay, strComparisonOpIdEduWay);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.TotalLessonQty) == true)
{
string strComparisonOpTotalLessonQty = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.TotalLessonQty];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsTeacher.TotalLessonQty, objvCurrEduClsTeacherCond.TotalLessonQty, strComparisonOpTotalLessonQty);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.MaxStuQty) == true)
{
string strComparisonOpMaxStuQty = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.MaxStuQty];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsTeacher.MaxStuQty, objvCurrEduClsTeacherCond.MaxStuQty, strComparisonOpMaxStuQty);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.WeekQty) == true)
{
string strComparisonOpWeekQty = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.WeekQty];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsTeacher.WeekQty, objvCurrEduClsTeacherCond.WeekQty, strComparisonOpWeekQty);
}
//数据类型short(smallint)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.WeekStatusId) == true)
{
string strComparisonOpWeekStatusId = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.WeekStatusId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.WeekStatusId, objvCurrEduClsTeacherCond.WeekStatusId, strComparisonOpWeekStatusId);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.CustomerWeek) == true)
{
string strComparisonOpCustomerWeek = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.CustomerWeek];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.CustomerWeek, objvCurrEduClsTeacherCond.CustomerWeek, strComparisonOpCustomerWeek);
}
//数据类型short(smallint)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.IdUniZone) == true)
{
string strComparisonOpIdUniZone = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.IdUniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.IdUniZone, objvCurrEduClsTeacherCond.IdUniZone, strComparisonOpIdUniZone);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.IdGradeBase, objvCurrEduClsTeacherCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.GradeBaseId) == true)
{
string strComparisonOpGradeBaseId = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.GradeBaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.GradeBaseId, objvCurrEduClsTeacherCond.GradeBaseId, strComparisonOpGradeBaseId);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.GradeBaseName) == true)
{
string strComparisonOpGradeBaseName = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.GradeBaseName, objvCurrEduClsTeacherCond.GradeBaseName, strComparisonOpGradeBaseName);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.IsEffective) == true)
{
if (objvCurrEduClsTeacherCond.IsEffective == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduClsTeacher.IsEffective);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduClsTeacher.IsEffective);
}
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.IdCourseType) == true)
{
string strComparisonOpIdCourseType = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.IdCourseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.IdCourseType, objvCurrEduClsTeacherCond.IdCourseType, strComparisonOpIdCourseType);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.CourseTypeId) == true)
{
string strComparisonOpCourseTypeId = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.CourseTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.CourseTypeId, objvCurrEduClsTeacherCond.CourseTypeId, strComparisonOpCourseTypeId);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.CourseTypeName) == true)
{
string strComparisonOpCourseTypeName = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.CourseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.CourseTypeName, objvCurrEduClsTeacherCond.CourseTypeName, strComparisonOpCourseTypeName);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.IsDegree) == true)
{
if (objvCurrEduClsTeacherCond.IsDegree == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduClsTeacher.IsDegree);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduClsTeacher.IsDegree);
}
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.IdScoreType) == true)
{
string strComparisonOpIdScoreType = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.IdScoreType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.IdScoreType, objvCurrEduClsTeacherCond.IdScoreType, strComparisonOpIdScoreType);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.IsProportionalCtrl) == true)
{
if (objvCurrEduClsTeacherCond.IsProportionalCtrl == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduClsTeacher.IsProportionalCtrl);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduClsTeacher.IsProportionalCtrl);
}
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.IdExamType) == true)
{
string strComparisonOpIdExamType = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.IdExamType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.IdExamType, objvCurrEduClsTeacherCond.IdExamType, strComparisonOpIdExamType);
}
//数据类型short(smallint)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.CurrStuNumValid) == true)
{
string strComparisonOpCurrStuNumValid = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.CurrStuNumValid];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsTeacher.CurrStuNumValid, objvCurrEduClsTeacherCond.CurrStuNumValid, strComparisonOpCurrStuNumValid);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.CurrStuNum) == true)
{
string strComparisonOpCurrStuNum = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.CurrStuNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsTeacher.CurrStuNum, objvCurrEduClsTeacherCond.CurrStuNum, strComparisonOpCurrStuNum);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.IdTeacher) == true)
{
string strComparisonOpIdTeacher = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.IdTeacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.IdTeacher, objvCurrEduClsTeacherCond.IdTeacher, strComparisonOpIdTeacher);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.TeacherId) == true)
{
string strComparisonOpTeacherId = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.TeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.TeacherId, objvCurrEduClsTeacherCond.TeacherId, strComparisonOpTeacherId);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.TeacherName) == true)
{
string strComparisonOpTeacherName = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.TeacherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.TeacherName, objvCurrEduClsTeacherCond.TeacherName, strComparisonOpTeacherName);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.IdProfGrade) == true)
{
string strComparisonOpIdProfGrade = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.IdProfGrade];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.IdProfGrade, objvCurrEduClsTeacherCond.IdProfGrade, strComparisonOpIdProfGrade);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.ProfenssionalGradeName) == true)
{
string strComparisonOpProfenssionalGradeName = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.ProfenssionalGradeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.ProfenssionalGradeName, objvCurrEduClsTeacherCond.ProfenssionalGradeName, strComparisonOpProfenssionalGradeName);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.DegreeName) == true)
{
string strComparisonOpDegreeName = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.DegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.DegreeName, objvCurrEduClsTeacherCond.DegreeName, strComparisonOpDegreeName);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.Birthday) == true)
{
string strComparisonOpBirthday = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.Birthday];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.Birthday, objvCurrEduClsTeacherCond.Birthday, strComparisonOpBirthday);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.IsGpUser) == true)
{
if (objvCurrEduClsTeacherCond.IsGpUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduClsTeacher.IsGpUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduClsTeacher.IsGpUser);
}
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.CollegeName) == true)
{
string strComparisonOpCollegeName = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.CollegeName, objvCurrEduClsTeacherCond.CollegeName, strComparisonOpCollegeName);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.IdPk2EduClsTeacherType) == true)
{
string strComparisonOpIdPk2EduClsTeacherType = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.IdPk2EduClsTeacherType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.IdPk2EduClsTeacherType, objvCurrEduClsTeacherCond.IdPk2EduClsTeacherType, strComparisonOpIdPk2EduClsTeacherType);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.EduClsTeacherTypeId) == true)
{
string strComparisonOpEduClsTeacherTypeId = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.EduClsTeacherTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.EduClsTeacherTypeId, objvCurrEduClsTeacherCond.EduClsTeacherTypeId, strComparisonOpEduClsTeacherTypeId);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.EduClsTeacherTypeDesc) == true)
{
string strComparisonOpEduClsTeacherTypeDesc = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.EduClsTeacherTypeDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.EduClsTeacherTypeDesc, objvCurrEduClsTeacherCond.EduClsTeacherTypeDesc, strComparisonOpEduClsTeacherTypeDesc);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.SchoolTerm) == true)
{
string strComparisonOpSchoolTerm = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.SchoolTerm, objvCurrEduClsTeacherCond.SchoolTerm, strComparisonOpSchoolTerm);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.SchoolYear) == true)
{
string strComparisonOpSchoolYear = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.SchoolYear, objvCurrEduClsTeacherCond.SchoolYear, strComparisonOpSchoolYear);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.OpenBeginDate) == true)
{
string strComparisonOpOpenBeginDate = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.OpenBeginDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.OpenBeginDate, objvCurrEduClsTeacherCond.OpenBeginDate, strComparisonOpOpenBeginDate);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.OpenEndDate) == true)
{
string strComparisonOpOpenEndDate = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.OpenEndDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.OpenEndDate, objvCurrEduClsTeacherCond.OpenEndDate, strComparisonOpOpenEndDate);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.OrderNum) == true)
{
string strComparisonOpOrderNum = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsTeacher.OrderNum, objvCurrEduClsTeacherCond.OrderNum, strComparisonOpOrderNum);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.UpdDate, objvCurrEduClsTeacherCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.UpdUser) == true)
{
string strComparisonOpUpdUser = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.UpdUser, objvCurrEduClsTeacherCond.UpdUser, strComparisonOpUpdUser);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.Memo) == true)
{
string strComparisonOpMemo = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.Memo, objvCurrEduClsTeacherCond.Memo, strComparisonOpMemo);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.CollegeName4EduCls) == true)
{
string strComparisonOpCollegeName4EduCls = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.CollegeName4EduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.CollegeName4EduCls, objvCurrEduClsTeacherCond.CollegeName4EduCls, strComparisonOpCollegeName4EduCls);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.CollegeName4Teacher) == true)
{
string strComparisonOpCollegeName4Teacher = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.CollegeName4Teacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.CollegeName4Teacher, objvCurrEduClsTeacherCond.CollegeName4Teacher, strComparisonOpCollegeName4Teacher);
}
if (objvCurrEduClsTeacherCond.IsUpdated(convCurrEduClsTeacher.UserType) == true)
{
string strComparisonOpUserType = objvCurrEduClsTeacherCond.dicFldComparisonOp[convCurrEduClsTeacher.UserType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsTeacher.UserType, objvCurrEduClsTeacherCond.UserType, strComparisonOpUserType);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCurrEduClsTeacher
{
public virtual bool UpdRelaTabDate(long lngIdEduClsTeacher, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v当前教学班教师(vCurrEduClsTeacher)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCurrEduClsTeacherBL
{
public static RelatedActions_vCurrEduClsTeacher relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCurrEduClsTeacherDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCurrEduClsTeacherDA vCurrEduClsTeacherDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCurrEduClsTeacherDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCurrEduClsTeacherBL()
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
if (string.IsNullOrEmpty(clsvCurrEduClsTeacherEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCurrEduClsTeacherEN._ConnectString);
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
public static DataTable GetDataTable_vCurrEduClsTeacher(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCurrEduClsTeacherDA.GetDataTable_vCurrEduClsTeacher(strWhereCond);
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
objDT = vCurrEduClsTeacherDA.GetDataTable(strWhereCond);
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
objDT = vCurrEduClsTeacherDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCurrEduClsTeacherDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCurrEduClsTeacherDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCurrEduClsTeacherDA.GetDataTable_Top(objTopPara);
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
objDT = vCurrEduClsTeacherDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCurrEduClsTeacherDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCurrEduClsTeacherDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdEduClsTeacherLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCurrEduClsTeacherEN> GetObjLstByIdEduClsTeacherLst(List<long> arrIdEduClsTeacherLst)
{
List<clsvCurrEduClsTeacherEN> arrObjLst = new List<clsvCurrEduClsTeacherEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdEduClsTeacherLst);
 string strWhereCond = string.Format("IdEduClsTeacher in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN = new clsvCurrEduClsTeacherEN();
try
{
objvCurrEduClsTeacherEN.IdEduClsTeacher = Int32.Parse(objRow[convCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号
objvCurrEduClsTeacherEN.IdCurrEduCls = objRow[convCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsTeacherEN.CurrEduClsId = objRow[convCurrEduClsTeacher.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsTeacherEN.EduClsName = objRow[convCurrEduClsTeacher.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsTeacherEN.EduClsTypeId = objRow[convCurrEduClsTeacher.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsTeacherEN.EduClsTypeName = objRow[convCurrEduClsTeacher.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsTeacherEN.CourseId = objRow[convCurrEduClsTeacher.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsTeacherEN.CourseCode = objRow[convCurrEduClsTeacher.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsTeacherEN.CourseName = objRow[convCurrEduClsTeacher.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsTeacherEN.ExampleImgPath = objRow[convCurrEduClsTeacher.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduClsTeacherEN.TeachingSolutionId = objRow[convCurrEduClsTeacher.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsTeacherEN.TeachingSolutionName = objRow[convCurrEduClsTeacher.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsTeacherEN.IdXzCollege = objRow[convCurrEduClsTeacher.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsTeacherEN.CollegeId = objRow[convCurrEduClsTeacher.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsTeacherEN.IdEduWay = objRow[convCurrEduClsTeacher.IdEduWay] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduClsTeacherEN.TotalLessonQty = objRow[convCurrEduClsTeacher.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduClsTeacherEN.MaxStuQty = objRow[convCurrEduClsTeacher.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduClsTeacherEN.WeekQty = objRow[convCurrEduClsTeacher.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.WeekQty].ToString().Trim()); //总周数
objvCurrEduClsTeacherEN.ScheUnitPW = objRow[convCurrEduClsTeacher.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduClsTeacherEN.WeekStatusId = objRow[convCurrEduClsTeacher.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduClsTeacherEN.CustomerWeek = objRow[convCurrEduClsTeacher.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduClsTeacherEN.LessonQtyPerWeek = objRow[convCurrEduClsTeacher.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsTeacherEN.IdUniZone = objRow[convCurrEduClsTeacher.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsTeacherEN.IdGradeBase = objRow[convCurrEduClsTeacher.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduClsTeacherEN.GradeBaseId = objRow[convCurrEduClsTeacher.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduClsTeacherEN.GradeBaseName = objRow[convCurrEduClsTeacher.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsTeacherEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsTeacherEN.IdCourseType = objRow[convCurrEduClsTeacher.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsTeacherEN.CourseTypeId = objRow[convCurrEduClsTeacher.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsTeacherEN.CourseTypeName = objRow[convCurrEduClsTeacher.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsTeacherEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsTeacherEN.IdScoreType = objRow[convCurrEduClsTeacher.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduClsTeacherEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduClsTeacherEN.IdExamType = objRow[convCurrEduClsTeacher.IdExamType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduClsTeacherEN.BeginWeek = objRow[convCurrEduClsTeacher.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.BeginWeek].ToString().Trim()); //开始周
objvCurrEduClsTeacherEN.CurrStuNumValid = objRow[convCurrEduClsTeacher.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduClsTeacherEN.CurrStuNum = objRow[convCurrEduClsTeacher.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduClsTeacherEN.IdTeacher = objRow[convCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduClsTeacherEN.TeacherId = objRow[convCurrEduClsTeacher.TeacherId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherId].ToString().Trim(); //教师工号
objvCurrEduClsTeacherEN.TeacherName = objRow[convCurrEduClsTeacher.TeacherName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduClsTeacherEN.IdProfGrade = objRow[convCurrEduClsTeacher.IdProfGrade] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdProfGrade].ToString().Trim(); //专业职称流水号
objvCurrEduClsTeacherEN.ProfenssionalGradeName = objRow[convCurrEduClsTeacher.ProfenssionalGradeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvCurrEduClsTeacherEN.DegreeName = objRow[convCurrEduClsTeacher.DegreeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.DegreeName].ToString().Trim(); //学位名称
objvCurrEduClsTeacherEN.Birthday = objRow[convCurrEduClsTeacher.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Birthday].ToString().Trim(); //出生日期
objvCurrEduClsTeacherEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsGpUser].ToString().Trim()); //是否Gp用户
objvCurrEduClsTeacherEN.CollegeName = objRow[convCurrEduClsTeacher.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objRow[convCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号
objvCurrEduClsTeacherEN.EduClsTeacherTypeId = objRow[convCurrEduClsTeacher.EduClsTeacherTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeId].ToString().Trim(); //教学班教学类型ID
objvCurrEduClsTeacherEN.EduClsTeacherTypeDesc = objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc].ToString().Trim(); //教学班教师类型名
objvCurrEduClsTeacherEN.SchoolTerm = objRow[convCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsTeacherEN.SchoolYear = objRow[convCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsTeacherEN.OpenBeginDate = objRow[convCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期
objvCurrEduClsTeacherEN.OpenEndDate = objRow[convCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期
objvCurrEduClsTeacherEN.OrderNum = objRow[convCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号
objvCurrEduClsTeacherEN.UpdDate = objRow[convCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期
objvCurrEduClsTeacherEN.UpdUser = objRow[convCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人
objvCurrEduClsTeacherEN.Memo = objRow[convCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Memo].ToString().Trim(); //备注
objvCurrEduClsTeacherEN.CollegeName4EduCls = objRow[convCurrEduClsTeacher.CollegeName4EduCls] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4EduCls].ToString().Trim(); //学院名_教学班
objvCurrEduClsTeacherEN.CollegeName4Teacher = objRow[convCurrEduClsTeacher.CollegeName4Teacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4Teacher].ToString().Trim(); //学院名_教师
objvCurrEduClsTeacherEN.UserType = objRow[convCurrEduClsTeacher.UserType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UserType].ToString().Trim(); //用户类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduClsTeacherEN.IdEduClsTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduClsTeacherEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdEduClsTeacherLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCurrEduClsTeacherEN> GetObjLstByIdEduClsTeacherLstCache(List<long> arrIdEduClsTeacherLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvCurrEduClsTeacherEN._CurrTabName, strIdCurrEduCls);
List<clsvCurrEduClsTeacherEN> arrvCurrEduClsTeacherObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvCurrEduClsTeacherEN> arrvCurrEduClsTeacherObjLst_Sel =
arrvCurrEduClsTeacherObjLstCache
.Where(x => arrIdEduClsTeacherLst.Contains(x.IdEduClsTeacher));
return arrvCurrEduClsTeacherObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduClsTeacherEN> GetObjLst(string strWhereCond)
{
List<clsvCurrEduClsTeacherEN> arrObjLst = new List<clsvCurrEduClsTeacherEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN = new clsvCurrEduClsTeacherEN();
try
{
objvCurrEduClsTeacherEN.IdEduClsTeacher = Int32.Parse(objRow[convCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号
objvCurrEduClsTeacherEN.IdCurrEduCls = objRow[convCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsTeacherEN.CurrEduClsId = objRow[convCurrEduClsTeacher.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsTeacherEN.EduClsName = objRow[convCurrEduClsTeacher.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsTeacherEN.EduClsTypeId = objRow[convCurrEduClsTeacher.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsTeacherEN.EduClsTypeName = objRow[convCurrEduClsTeacher.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsTeacherEN.CourseId = objRow[convCurrEduClsTeacher.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsTeacherEN.CourseCode = objRow[convCurrEduClsTeacher.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsTeacherEN.CourseName = objRow[convCurrEduClsTeacher.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsTeacherEN.ExampleImgPath = objRow[convCurrEduClsTeacher.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduClsTeacherEN.TeachingSolutionId = objRow[convCurrEduClsTeacher.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsTeacherEN.TeachingSolutionName = objRow[convCurrEduClsTeacher.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsTeacherEN.IdXzCollege = objRow[convCurrEduClsTeacher.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsTeacherEN.CollegeId = objRow[convCurrEduClsTeacher.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsTeacherEN.IdEduWay = objRow[convCurrEduClsTeacher.IdEduWay] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduClsTeacherEN.TotalLessonQty = objRow[convCurrEduClsTeacher.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduClsTeacherEN.MaxStuQty = objRow[convCurrEduClsTeacher.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduClsTeacherEN.WeekQty = objRow[convCurrEduClsTeacher.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.WeekQty].ToString().Trim()); //总周数
objvCurrEduClsTeacherEN.ScheUnitPW = objRow[convCurrEduClsTeacher.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduClsTeacherEN.WeekStatusId = objRow[convCurrEduClsTeacher.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduClsTeacherEN.CustomerWeek = objRow[convCurrEduClsTeacher.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduClsTeacherEN.LessonQtyPerWeek = objRow[convCurrEduClsTeacher.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsTeacherEN.IdUniZone = objRow[convCurrEduClsTeacher.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsTeacherEN.IdGradeBase = objRow[convCurrEduClsTeacher.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduClsTeacherEN.GradeBaseId = objRow[convCurrEduClsTeacher.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduClsTeacherEN.GradeBaseName = objRow[convCurrEduClsTeacher.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsTeacherEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsTeacherEN.IdCourseType = objRow[convCurrEduClsTeacher.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsTeacherEN.CourseTypeId = objRow[convCurrEduClsTeacher.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsTeacherEN.CourseTypeName = objRow[convCurrEduClsTeacher.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsTeacherEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsTeacherEN.IdScoreType = objRow[convCurrEduClsTeacher.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduClsTeacherEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduClsTeacherEN.IdExamType = objRow[convCurrEduClsTeacher.IdExamType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduClsTeacherEN.BeginWeek = objRow[convCurrEduClsTeacher.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.BeginWeek].ToString().Trim()); //开始周
objvCurrEduClsTeacherEN.CurrStuNumValid = objRow[convCurrEduClsTeacher.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduClsTeacherEN.CurrStuNum = objRow[convCurrEduClsTeacher.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduClsTeacherEN.IdTeacher = objRow[convCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduClsTeacherEN.TeacherId = objRow[convCurrEduClsTeacher.TeacherId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherId].ToString().Trim(); //教师工号
objvCurrEduClsTeacherEN.TeacherName = objRow[convCurrEduClsTeacher.TeacherName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduClsTeacherEN.IdProfGrade = objRow[convCurrEduClsTeacher.IdProfGrade] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdProfGrade].ToString().Trim(); //专业职称流水号
objvCurrEduClsTeacherEN.ProfenssionalGradeName = objRow[convCurrEduClsTeacher.ProfenssionalGradeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvCurrEduClsTeacherEN.DegreeName = objRow[convCurrEduClsTeacher.DegreeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.DegreeName].ToString().Trim(); //学位名称
objvCurrEduClsTeacherEN.Birthday = objRow[convCurrEduClsTeacher.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Birthday].ToString().Trim(); //出生日期
objvCurrEduClsTeacherEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsGpUser].ToString().Trim()); //是否Gp用户
objvCurrEduClsTeacherEN.CollegeName = objRow[convCurrEduClsTeacher.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objRow[convCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号
objvCurrEduClsTeacherEN.EduClsTeacherTypeId = objRow[convCurrEduClsTeacher.EduClsTeacherTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeId].ToString().Trim(); //教学班教学类型ID
objvCurrEduClsTeacherEN.EduClsTeacherTypeDesc = objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc].ToString().Trim(); //教学班教师类型名
objvCurrEduClsTeacherEN.SchoolTerm = objRow[convCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsTeacherEN.SchoolYear = objRow[convCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsTeacherEN.OpenBeginDate = objRow[convCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期
objvCurrEduClsTeacherEN.OpenEndDate = objRow[convCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期
objvCurrEduClsTeacherEN.OrderNum = objRow[convCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号
objvCurrEduClsTeacherEN.UpdDate = objRow[convCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期
objvCurrEduClsTeacherEN.UpdUser = objRow[convCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人
objvCurrEduClsTeacherEN.Memo = objRow[convCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Memo].ToString().Trim(); //备注
objvCurrEduClsTeacherEN.CollegeName4EduCls = objRow[convCurrEduClsTeacher.CollegeName4EduCls] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4EduCls].ToString().Trim(); //学院名_教学班
objvCurrEduClsTeacherEN.CollegeName4Teacher = objRow[convCurrEduClsTeacher.CollegeName4Teacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4Teacher].ToString().Trim(); //学院名_教师
objvCurrEduClsTeacherEN.UserType = objRow[convCurrEduClsTeacher.UserType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UserType].ToString().Trim(); //用户类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduClsTeacherEN.IdEduClsTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduClsTeacherEN);
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
public static List<clsvCurrEduClsTeacherEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCurrEduClsTeacherEN> arrObjLst = new List<clsvCurrEduClsTeacherEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN = new clsvCurrEduClsTeacherEN();
try
{
objvCurrEduClsTeacherEN.IdEduClsTeacher = Int32.Parse(objRow[convCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号
objvCurrEduClsTeacherEN.IdCurrEduCls = objRow[convCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsTeacherEN.CurrEduClsId = objRow[convCurrEduClsTeacher.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsTeacherEN.EduClsName = objRow[convCurrEduClsTeacher.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsTeacherEN.EduClsTypeId = objRow[convCurrEduClsTeacher.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsTeacherEN.EduClsTypeName = objRow[convCurrEduClsTeacher.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsTeacherEN.CourseId = objRow[convCurrEduClsTeacher.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsTeacherEN.CourseCode = objRow[convCurrEduClsTeacher.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsTeacherEN.CourseName = objRow[convCurrEduClsTeacher.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsTeacherEN.ExampleImgPath = objRow[convCurrEduClsTeacher.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduClsTeacherEN.TeachingSolutionId = objRow[convCurrEduClsTeacher.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsTeacherEN.TeachingSolutionName = objRow[convCurrEduClsTeacher.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsTeacherEN.IdXzCollege = objRow[convCurrEduClsTeacher.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsTeacherEN.CollegeId = objRow[convCurrEduClsTeacher.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsTeacherEN.IdEduWay = objRow[convCurrEduClsTeacher.IdEduWay] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduClsTeacherEN.TotalLessonQty = objRow[convCurrEduClsTeacher.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduClsTeacherEN.MaxStuQty = objRow[convCurrEduClsTeacher.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduClsTeacherEN.WeekQty = objRow[convCurrEduClsTeacher.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.WeekQty].ToString().Trim()); //总周数
objvCurrEduClsTeacherEN.ScheUnitPW = objRow[convCurrEduClsTeacher.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduClsTeacherEN.WeekStatusId = objRow[convCurrEduClsTeacher.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduClsTeacherEN.CustomerWeek = objRow[convCurrEduClsTeacher.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduClsTeacherEN.LessonQtyPerWeek = objRow[convCurrEduClsTeacher.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsTeacherEN.IdUniZone = objRow[convCurrEduClsTeacher.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsTeacherEN.IdGradeBase = objRow[convCurrEduClsTeacher.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduClsTeacherEN.GradeBaseId = objRow[convCurrEduClsTeacher.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduClsTeacherEN.GradeBaseName = objRow[convCurrEduClsTeacher.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsTeacherEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsTeacherEN.IdCourseType = objRow[convCurrEduClsTeacher.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsTeacherEN.CourseTypeId = objRow[convCurrEduClsTeacher.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsTeacherEN.CourseTypeName = objRow[convCurrEduClsTeacher.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsTeacherEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsTeacherEN.IdScoreType = objRow[convCurrEduClsTeacher.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduClsTeacherEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduClsTeacherEN.IdExamType = objRow[convCurrEduClsTeacher.IdExamType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduClsTeacherEN.BeginWeek = objRow[convCurrEduClsTeacher.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.BeginWeek].ToString().Trim()); //开始周
objvCurrEduClsTeacherEN.CurrStuNumValid = objRow[convCurrEduClsTeacher.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduClsTeacherEN.CurrStuNum = objRow[convCurrEduClsTeacher.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduClsTeacherEN.IdTeacher = objRow[convCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduClsTeacherEN.TeacherId = objRow[convCurrEduClsTeacher.TeacherId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherId].ToString().Trim(); //教师工号
objvCurrEduClsTeacherEN.TeacherName = objRow[convCurrEduClsTeacher.TeacherName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduClsTeacherEN.IdProfGrade = objRow[convCurrEduClsTeacher.IdProfGrade] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdProfGrade].ToString().Trim(); //专业职称流水号
objvCurrEduClsTeacherEN.ProfenssionalGradeName = objRow[convCurrEduClsTeacher.ProfenssionalGradeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvCurrEduClsTeacherEN.DegreeName = objRow[convCurrEduClsTeacher.DegreeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.DegreeName].ToString().Trim(); //学位名称
objvCurrEduClsTeacherEN.Birthday = objRow[convCurrEduClsTeacher.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Birthday].ToString().Trim(); //出生日期
objvCurrEduClsTeacherEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsGpUser].ToString().Trim()); //是否Gp用户
objvCurrEduClsTeacherEN.CollegeName = objRow[convCurrEduClsTeacher.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objRow[convCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号
objvCurrEduClsTeacherEN.EduClsTeacherTypeId = objRow[convCurrEduClsTeacher.EduClsTeacherTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeId].ToString().Trim(); //教学班教学类型ID
objvCurrEduClsTeacherEN.EduClsTeacherTypeDesc = objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc].ToString().Trim(); //教学班教师类型名
objvCurrEduClsTeacherEN.SchoolTerm = objRow[convCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsTeacherEN.SchoolYear = objRow[convCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsTeacherEN.OpenBeginDate = objRow[convCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期
objvCurrEduClsTeacherEN.OpenEndDate = objRow[convCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期
objvCurrEduClsTeacherEN.OrderNum = objRow[convCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号
objvCurrEduClsTeacherEN.UpdDate = objRow[convCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期
objvCurrEduClsTeacherEN.UpdUser = objRow[convCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人
objvCurrEduClsTeacherEN.Memo = objRow[convCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Memo].ToString().Trim(); //备注
objvCurrEduClsTeacherEN.CollegeName4EduCls = objRow[convCurrEduClsTeacher.CollegeName4EduCls] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4EduCls].ToString().Trim(); //学院名_教学班
objvCurrEduClsTeacherEN.CollegeName4Teacher = objRow[convCurrEduClsTeacher.CollegeName4Teacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4Teacher].ToString().Trim(); //学院名_教师
objvCurrEduClsTeacherEN.UserType = objRow[convCurrEduClsTeacher.UserType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UserType].ToString().Trim(); //用户类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduClsTeacherEN.IdEduClsTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduClsTeacherEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCurrEduClsTeacherEN> GetSubObjLstCache(clsvCurrEduClsTeacherEN objvCurrEduClsTeacherCond)
{
 string strIdCurrEduCls = objvCurrEduClsTeacherCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvCurrEduClsTeacherBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvCurrEduClsTeacherEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvCurrEduClsTeacherEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCurrEduClsTeacher.AttributeName)
{
if (objvCurrEduClsTeacherCond.IsUpdated(strFldName) == false) continue;
if (objvCurrEduClsTeacherCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCurrEduClsTeacherCond[strFldName].ToString());
}
else
{
if (objvCurrEduClsTeacherCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCurrEduClsTeacherCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCurrEduClsTeacherCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCurrEduClsTeacherCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCurrEduClsTeacherCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCurrEduClsTeacherCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCurrEduClsTeacherCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCurrEduClsTeacherCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCurrEduClsTeacherCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCurrEduClsTeacherCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCurrEduClsTeacherCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCurrEduClsTeacherCond[strFldName]));
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
public static List<clsvCurrEduClsTeacherEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCurrEduClsTeacherEN> arrObjLst = new List<clsvCurrEduClsTeacherEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN = new clsvCurrEduClsTeacherEN();
try
{
objvCurrEduClsTeacherEN.IdEduClsTeacher = Int32.Parse(objRow[convCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号
objvCurrEduClsTeacherEN.IdCurrEduCls = objRow[convCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsTeacherEN.CurrEduClsId = objRow[convCurrEduClsTeacher.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsTeacherEN.EduClsName = objRow[convCurrEduClsTeacher.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsTeacherEN.EduClsTypeId = objRow[convCurrEduClsTeacher.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsTeacherEN.EduClsTypeName = objRow[convCurrEduClsTeacher.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsTeacherEN.CourseId = objRow[convCurrEduClsTeacher.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsTeacherEN.CourseCode = objRow[convCurrEduClsTeacher.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsTeacherEN.CourseName = objRow[convCurrEduClsTeacher.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsTeacherEN.ExampleImgPath = objRow[convCurrEduClsTeacher.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduClsTeacherEN.TeachingSolutionId = objRow[convCurrEduClsTeacher.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsTeacherEN.TeachingSolutionName = objRow[convCurrEduClsTeacher.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsTeacherEN.IdXzCollege = objRow[convCurrEduClsTeacher.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsTeacherEN.CollegeId = objRow[convCurrEduClsTeacher.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsTeacherEN.IdEduWay = objRow[convCurrEduClsTeacher.IdEduWay] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduClsTeacherEN.TotalLessonQty = objRow[convCurrEduClsTeacher.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduClsTeacherEN.MaxStuQty = objRow[convCurrEduClsTeacher.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduClsTeacherEN.WeekQty = objRow[convCurrEduClsTeacher.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.WeekQty].ToString().Trim()); //总周数
objvCurrEduClsTeacherEN.ScheUnitPW = objRow[convCurrEduClsTeacher.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduClsTeacherEN.WeekStatusId = objRow[convCurrEduClsTeacher.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduClsTeacherEN.CustomerWeek = objRow[convCurrEduClsTeacher.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduClsTeacherEN.LessonQtyPerWeek = objRow[convCurrEduClsTeacher.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsTeacherEN.IdUniZone = objRow[convCurrEduClsTeacher.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsTeacherEN.IdGradeBase = objRow[convCurrEduClsTeacher.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduClsTeacherEN.GradeBaseId = objRow[convCurrEduClsTeacher.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduClsTeacherEN.GradeBaseName = objRow[convCurrEduClsTeacher.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsTeacherEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsTeacherEN.IdCourseType = objRow[convCurrEduClsTeacher.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsTeacherEN.CourseTypeId = objRow[convCurrEduClsTeacher.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsTeacherEN.CourseTypeName = objRow[convCurrEduClsTeacher.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsTeacherEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsTeacherEN.IdScoreType = objRow[convCurrEduClsTeacher.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduClsTeacherEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduClsTeacherEN.IdExamType = objRow[convCurrEduClsTeacher.IdExamType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduClsTeacherEN.BeginWeek = objRow[convCurrEduClsTeacher.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.BeginWeek].ToString().Trim()); //开始周
objvCurrEduClsTeacherEN.CurrStuNumValid = objRow[convCurrEduClsTeacher.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduClsTeacherEN.CurrStuNum = objRow[convCurrEduClsTeacher.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduClsTeacherEN.IdTeacher = objRow[convCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduClsTeacherEN.TeacherId = objRow[convCurrEduClsTeacher.TeacherId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherId].ToString().Trim(); //教师工号
objvCurrEduClsTeacherEN.TeacherName = objRow[convCurrEduClsTeacher.TeacherName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduClsTeacherEN.IdProfGrade = objRow[convCurrEduClsTeacher.IdProfGrade] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdProfGrade].ToString().Trim(); //专业职称流水号
objvCurrEduClsTeacherEN.ProfenssionalGradeName = objRow[convCurrEduClsTeacher.ProfenssionalGradeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvCurrEduClsTeacherEN.DegreeName = objRow[convCurrEduClsTeacher.DegreeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.DegreeName].ToString().Trim(); //学位名称
objvCurrEduClsTeacherEN.Birthday = objRow[convCurrEduClsTeacher.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Birthday].ToString().Trim(); //出生日期
objvCurrEduClsTeacherEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsGpUser].ToString().Trim()); //是否Gp用户
objvCurrEduClsTeacherEN.CollegeName = objRow[convCurrEduClsTeacher.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objRow[convCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号
objvCurrEduClsTeacherEN.EduClsTeacherTypeId = objRow[convCurrEduClsTeacher.EduClsTeacherTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeId].ToString().Trim(); //教学班教学类型ID
objvCurrEduClsTeacherEN.EduClsTeacherTypeDesc = objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc].ToString().Trim(); //教学班教师类型名
objvCurrEduClsTeacherEN.SchoolTerm = objRow[convCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsTeacherEN.SchoolYear = objRow[convCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsTeacherEN.OpenBeginDate = objRow[convCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期
objvCurrEduClsTeacherEN.OpenEndDate = objRow[convCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期
objvCurrEduClsTeacherEN.OrderNum = objRow[convCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号
objvCurrEduClsTeacherEN.UpdDate = objRow[convCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期
objvCurrEduClsTeacherEN.UpdUser = objRow[convCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人
objvCurrEduClsTeacherEN.Memo = objRow[convCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Memo].ToString().Trim(); //备注
objvCurrEduClsTeacherEN.CollegeName4EduCls = objRow[convCurrEduClsTeacher.CollegeName4EduCls] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4EduCls].ToString().Trim(); //学院名_教学班
objvCurrEduClsTeacherEN.CollegeName4Teacher = objRow[convCurrEduClsTeacher.CollegeName4Teacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4Teacher].ToString().Trim(); //学院名_教师
objvCurrEduClsTeacherEN.UserType = objRow[convCurrEduClsTeacher.UserType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UserType].ToString().Trim(); //用户类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduClsTeacherEN.IdEduClsTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduClsTeacherEN);
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
public static List<clsvCurrEduClsTeacherEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCurrEduClsTeacherEN> arrObjLst = new List<clsvCurrEduClsTeacherEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN = new clsvCurrEduClsTeacherEN();
try
{
objvCurrEduClsTeacherEN.IdEduClsTeacher = Int32.Parse(objRow[convCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号
objvCurrEduClsTeacherEN.IdCurrEduCls = objRow[convCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsTeacherEN.CurrEduClsId = objRow[convCurrEduClsTeacher.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsTeacherEN.EduClsName = objRow[convCurrEduClsTeacher.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsTeacherEN.EduClsTypeId = objRow[convCurrEduClsTeacher.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsTeacherEN.EduClsTypeName = objRow[convCurrEduClsTeacher.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsTeacherEN.CourseId = objRow[convCurrEduClsTeacher.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsTeacherEN.CourseCode = objRow[convCurrEduClsTeacher.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsTeacherEN.CourseName = objRow[convCurrEduClsTeacher.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsTeacherEN.ExampleImgPath = objRow[convCurrEduClsTeacher.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduClsTeacherEN.TeachingSolutionId = objRow[convCurrEduClsTeacher.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsTeacherEN.TeachingSolutionName = objRow[convCurrEduClsTeacher.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsTeacherEN.IdXzCollege = objRow[convCurrEduClsTeacher.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsTeacherEN.CollegeId = objRow[convCurrEduClsTeacher.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsTeacherEN.IdEduWay = objRow[convCurrEduClsTeacher.IdEduWay] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduClsTeacherEN.TotalLessonQty = objRow[convCurrEduClsTeacher.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduClsTeacherEN.MaxStuQty = objRow[convCurrEduClsTeacher.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduClsTeacherEN.WeekQty = objRow[convCurrEduClsTeacher.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.WeekQty].ToString().Trim()); //总周数
objvCurrEduClsTeacherEN.ScheUnitPW = objRow[convCurrEduClsTeacher.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduClsTeacherEN.WeekStatusId = objRow[convCurrEduClsTeacher.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduClsTeacherEN.CustomerWeek = objRow[convCurrEduClsTeacher.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduClsTeacherEN.LessonQtyPerWeek = objRow[convCurrEduClsTeacher.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsTeacherEN.IdUniZone = objRow[convCurrEduClsTeacher.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsTeacherEN.IdGradeBase = objRow[convCurrEduClsTeacher.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduClsTeacherEN.GradeBaseId = objRow[convCurrEduClsTeacher.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduClsTeacherEN.GradeBaseName = objRow[convCurrEduClsTeacher.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsTeacherEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsTeacherEN.IdCourseType = objRow[convCurrEduClsTeacher.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsTeacherEN.CourseTypeId = objRow[convCurrEduClsTeacher.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsTeacherEN.CourseTypeName = objRow[convCurrEduClsTeacher.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsTeacherEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsTeacherEN.IdScoreType = objRow[convCurrEduClsTeacher.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduClsTeacherEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduClsTeacherEN.IdExamType = objRow[convCurrEduClsTeacher.IdExamType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduClsTeacherEN.BeginWeek = objRow[convCurrEduClsTeacher.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.BeginWeek].ToString().Trim()); //开始周
objvCurrEduClsTeacherEN.CurrStuNumValid = objRow[convCurrEduClsTeacher.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduClsTeacherEN.CurrStuNum = objRow[convCurrEduClsTeacher.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduClsTeacherEN.IdTeacher = objRow[convCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduClsTeacherEN.TeacherId = objRow[convCurrEduClsTeacher.TeacherId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherId].ToString().Trim(); //教师工号
objvCurrEduClsTeacherEN.TeacherName = objRow[convCurrEduClsTeacher.TeacherName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduClsTeacherEN.IdProfGrade = objRow[convCurrEduClsTeacher.IdProfGrade] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdProfGrade].ToString().Trim(); //专业职称流水号
objvCurrEduClsTeacherEN.ProfenssionalGradeName = objRow[convCurrEduClsTeacher.ProfenssionalGradeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvCurrEduClsTeacherEN.DegreeName = objRow[convCurrEduClsTeacher.DegreeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.DegreeName].ToString().Trim(); //学位名称
objvCurrEduClsTeacherEN.Birthday = objRow[convCurrEduClsTeacher.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Birthday].ToString().Trim(); //出生日期
objvCurrEduClsTeacherEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsGpUser].ToString().Trim()); //是否Gp用户
objvCurrEduClsTeacherEN.CollegeName = objRow[convCurrEduClsTeacher.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objRow[convCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号
objvCurrEduClsTeacherEN.EduClsTeacherTypeId = objRow[convCurrEduClsTeacher.EduClsTeacherTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeId].ToString().Trim(); //教学班教学类型ID
objvCurrEduClsTeacherEN.EduClsTeacherTypeDesc = objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc].ToString().Trim(); //教学班教师类型名
objvCurrEduClsTeacherEN.SchoolTerm = objRow[convCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsTeacherEN.SchoolYear = objRow[convCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsTeacherEN.OpenBeginDate = objRow[convCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期
objvCurrEduClsTeacherEN.OpenEndDate = objRow[convCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期
objvCurrEduClsTeacherEN.OrderNum = objRow[convCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号
objvCurrEduClsTeacherEN.UpdDate = objRow[convCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期
objvCurrEduClsTeacherEN.UpdUser = objRow[convCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人
objvCurrEduClsTeacherEN.Memo = objRow[convCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Memo].ToString().Trim(); //备注
objvCurrEduClsTeacherEN.CollegeName4EduCls = objRow[convCurrEduClsTeacher.CollegeName4EduCls] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4EduCls].ToString().Trim(); //学院名_教学班
objvCurrEduClsTeacherEN.CollegeName4Teacher = objRow[convCurrEduClsTeacher.CollegeName4Teacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4Teacher].ToString().Trim(); //学院名_教师
objvCurrEduClsTeacherEN.UserType = objRow[convCurrEduClsTeacher.UserType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UserType].ToString().Trim(); //用户类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduClsTeacherEN.IdEduClsTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduClsTeacherEN);
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
List<clsvCurrEduClsTeacherEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCurrEduClsTeacherEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduClsTeacherEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCurrEduClsTeacherEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCurrEduClsTeacherEN> arrObjLst = new List<clsvCurrEduClsTeacherEN>(); 
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
	clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN = new clsvCurrEduClsTeacherEN();
try
{
objvCurrEduClsTeacherEN.IdEduClsTeacher = Int32.Parse(objRow[convCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号
objvCurrEduClsTeacherEN.IdCurrEduCls = objRow[convCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsTeacherEN.CurrEduClsId = objRow[convCurrEduClsTeacher.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsTeacherEN.EduClsName = objRow[convCurrEduClsTeacher.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsTeacherEN.EduClsTypeId = objRow[convCurrEduClsTeacher.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsTeacherEN.EduClsTypeName = objRow[convCurrEduClsTeacher.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsTeacherEN.CourseId = objRow[convCurrEduClsTeacher.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsTeacherEN.CourseCode = objRow[convCurrEduClsTeacher.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsTeacherEN.CourseName = objRow[convCurrEduClsTeacher.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsTeacherEN.ExampleImgPath = objRow[convCurrEduClsTeacher.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduClsTeacherEN.TeachingSolutionId = objRow[convCurrEduClsTeacher.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsTeacherEN.TeachingSolutionName = objRow[convCurrEduClsTeacher.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsTeacherEN.IdXzCollege = objRow[convCurrEduClsTeacher.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsTeacherEN.CollegeId = objRow[convCurrEduClsTeacher.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsTeacherEN.IdEduWay = objRow[convCurrEduClsTeacher.IdEduWay] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduClsTeacherEN.TotalLessonQty = objRow[convCurrEduClsTeacher.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduClsTeacherEN.MaxStuQty = objRow[convCurrEduClsTeacher.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduClsTeacherEN.WeekQty = objRow[convCurrEduClsTeacher.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.WeekQty].ToString().Trim()); //总周数
objvCurrEduClsTeacherEN.ScheUnitPW = objRow[convCurrEduClsTeacher.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduClsTeacherEN.WeekStatusId = objRow[convCurrEduClsTeacher.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduClsTeacherEN.CustomerWeek = objRow[convCurrEduClsTeacher.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduClsTeacherEN.LessonQtyPerWeek = objRow[convCurrEduClsTeacher.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsTeacherEN.IdUniZone = objRow[convCurrEduClsTeacher.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsTeacherEN.IdGradeBase = objRow[convCurrEduClsTeacher.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduClsTeacherEN.GradeBaseId = objRow[convCurrEduClsTeacher.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduClsTeacherEN.GradeBaseName = objRow[convCurrEduClsTeacher.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsTeacherEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsTeacherEN.IdCourseType = objRow[convCurrEduClsTeacher.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsTeacherEN.CourseTypeId = objRow[convCurrEduClsTeacher.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsTeacherEN.CourseTypeName = objRow[convCurrEduClsTeacher.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsTeacherEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsTeacherEN.IdScoreType = objRow[convCurrEduClsTeacher.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduClsTeacherEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduClsTeacherEN.IdExamType = objRow[convCurrEduClsTeacher.IdExamType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduClsTeacherEN.BeginWeek = objRow[convCurrEduClsTeacher.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.BeginWeek].ToString().Trim()); //开始周
objvCurrEduClsTeacherEN.CurrStuNumValid = objRow[convCurrEduClsTeacher.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduClsTeacherEN.CurrStuNum = objRow[convCurrEduClsTeacher.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduClsTeacherEN.IdTeacher = objRow[convCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduClsTeacherEN.TeacherId = objRow[convCurrEduClsTeacher.TeacherId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherId].ToString().Trim(); //教师工号
objvCurrEduClsTeacherEN.TeacherName = objRow[convCurrEduClsTeacher.TeacherName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduClsTeacherEN.IdProfGrade = objRow[convCurrEduClsTeacher.IdProfGrade] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdProfGrade].ToString().Trim(); //专业职称流水号
objvCurrEduClsTeacherEN.ProfenssionalGradeName = objRow[convCurrEduClsTeacher.ProfenssionalGradeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvCurrEduClsTeacherEN.DegreeName = objRow[convCurrEduClsTeacher.DegreeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.DegreeName].ToString().Trim(); //学位名称
objvCurrEduClsTeacherEN.Birthday = objRow[convCurrEduClsTeacher.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Birthday].ToString().Trim(); //出生日期
objvCurrEduClsTeacherEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsGpUser].ToString().Trim()); //是否Gp用户
objvCurrEduClsTeacherEN.CollegeName = objRow[convCurrEduClsTeacher.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objRow[convCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号
objvCurrEduClsTeacherEN.EduClsTeacherTypeId = objRow[convCurrEduClsTeacher.EduClsTeacherTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeId].ToString().Trim(); //教学班教学类型ID
objvCurrEduClsTeacherEN.EduClsTeacherTypeDesc = objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc].ToString().Trim(); //教学班教师类型名
objvCurrEduClsTeacherEN.SchoolTerm = objRow[convCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsTeacherEN.SchoolYear = objRow[convCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsTeacherEN.OpenBeginDate = objRow[convCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期
objvCurrEduClsTeacherEN.OpenEndDate = objRow[convCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期
objvCurrEduClsTeacherEN.OrderNum = objRow[convCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号
objvCurrEduClsTeacherEN.UpdDate = objRow[convCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期
objvCurrEduClsTeacherEN.UpdUser = objRow[convCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人
objvCurrEduClsTeacherEN.Memo = objRow[convCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Memo].ToString().Trim(); //备注
objvCurrEduClsTeacherEN.CollegeName4EduCls = objRow[convCurrEduClsTeacher.CollegeName4EduCls] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4EduCls].ToString().Trim(); //学院名_教学班
objvCurrEduClsTeacherEN.CollegeName4Teacher = objRow[convCurrEduClsTeacher.CollegeName4Teacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4Teacher].ToString().Trim(); //学院名_教师
objvCurrEduClsTeacherEN.UserType = objRow[convCurrEduClsTeacher.UserType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UserType].ToString().Trim(); //用户类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduClsTeacherEN.IdEduClsTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduClsTeacherEN);
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
public static List<clsvCurrEduClsTeacherEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCurrEduClsTeacherEN> arrObjLst = new List<clsvCurrEduClsTeacherEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN = new clsvCurrEduClsTeacherEN();
try
{
objvCurrEduClsTeacherEN.IdEduClsTeacher = Int32.Parse(objRow[convCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号
objvCurrEduClsTeacherEN.IdCurrEduCls = objRow[convCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsTeacherEN.CurrEduClsId = objRow[convCurrEduClsTeacher.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsTeacherEN.EduClsName = objRow[convCurrEduClsTeacher.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsTeacherEN.EduClsTypeId = objRow[convCurrEduClsTeacher.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsTeacherEN.EduClsTypeName = objRow[convCurrEduClsTeacher.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsTeacherEN.CourseId = objRow[convCurrEduClsTeacher.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsTeacherEN.CourseCode = objRow[convCurrEduClsTeacher.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsTeacherEN.CourseName = objRow[convCurrEduClsTeacher.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsTeacherEN.ExampleImgPath = objRow[convCurrEduClsTeacher.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduClsTeacherEN.TeachingSolutionId = objRow[convCurrEduClsTeacher.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsTeacherEN.TeachingSolutionName = objRow[convCurrEduClsTeacher.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsTeacherEN.IdXzCollege = objRow[convCurrEduClsTeacher.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsTeacherEN.CollegeId = objRow[convCurrEduClsTeacher.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsTeacherEN.IdEduWay = objRow[convCurrEduClsTeacher.IdEduWay] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduClsTeacherEN.TotalLessonQty = objRow[convCurrEduClsTeacher.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduClsTeacherEN.MaxStuQty = objRow[convCurrEduClsTeacher.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduClsTeacherEN.WeekQty = objRow[convCurrEduClsTeacher.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.WeekQty].ToString().Trim()); //总周数
objvCurrEduClsTeacherEN.ScheUnitPW = objRow[convCurrEduClsTeacher.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduClsTeacherEN.WeekStatusId = objRow[convCurrEduClsTeacher.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduClsTeacherEN.CustomerWeek = objRow[convCurrEduClsTeacher.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduClsTeacherEN.LessonQtyPerWeek = objRow[convCurrEduClsTeacher.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsTeacherEN.IdUniZone = objRow[convCurrEduClsTeacher.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsTeacherEN.IdGradeBase = objRow[convCurrEduClsTeacher.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduClsTeacherEN.GradeBaseId = objRow[convCurrEduClsTeacher.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduClsTeacherEN.GradeBaseName = objRow[convCurrEduClsTeacher.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsTeacherEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsTeacherEN.IdCourseType = objRow[convCurrEduClsTeacher.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsTeacherEN.CourseTypeId = objRow[convCurrEduClsTeacher.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsTeacherEN.CourseTypeName = objRow[convCurrEduClsTeacher.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsTeacherEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsTeacherEN.IdScoreType = objRow[convCurrEduClsTeacher.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduClsTeacherEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduClsTeacherEN.IdExamType = objRow[convCurrEduClsTeacher.IdExamType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduClsTeacherEN.BeginWeek = objRow[convCurrEduClsTeacher.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.BeginWeek].ToString().Trim()); //开始周
objvCurrEduClsTeacherEN.CurrStuNumValid = objRow[convCurrEduClsTeacher.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduClsTeacherEN.CurrStuNum = objRow[convCurrEduClsTeacher.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduClsTeacherEN.IdTeacher = objRow[convCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduClsTeacherEN.TeacherId = objRow[convCurrEduClsTeacher.TeacherId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherId].ToString().Trim(); //教师工号
objvCurrEduClsTeacherEN.TeacherName = objRow[convCurrEduClsTeacher.TeacherName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduClsTeacherEN.IdProfGrade = objRow[convCurrEduClsTeacher.IdProfGrade] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdProfGrade].ToString().Trim(); //专业职称流水号
objvCurrEduClsTeacherEN.ProfenssionalGradeName = objRow[convCurrEduClsTeacher.ProfenssionalGradeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvCurrEduClsTeacherEN.DegreeName = objRow[convCurrEduClsTeacher.DegreeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.DegreeName].ToString().Trim(); //学位名称
objvCurrEduClsTeacherEN.Birthday = objRow[convCurrEduClsTeacher.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Birthday].ToString().Trim(); //出生日期
objvCurrEduClsTeacherEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsGpUser].ToString().Trim()); //是否Gp用户
objvCurrEduClsTeacherEN.CollegeName = objRow[convCurrEduClsTeacher.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objRow[convCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号
objvCurrEduClsTeacherEN.EduClsTeacherTypeId = objRow[convCurrEduClsTeacher.EduClsTeacherTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeId].ToString().Trim(); //教学班教学类型ID
objvCurrEduClsTeacherEN.EduClsTeacherTypeDesc = objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc].ToString().Trim(); //教学班教师类型名
objvCurrEduClsTeacherEN.SchoolTerm = objRow[convCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsTeacherEN.SchoolYear = objRow[convCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsTeacherEN.OpenBeginDate = objRow[convCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期
objvCurrEduClsTeacherEN.OpenEndDate = objRow[convCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期
objvCurrEduClsTeacherEN.OrderNum = objRow[convCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号
objvCurrEduClsTeacherEN.UpdDate = objRow[convCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期
objvCurrEduClsTeacherEN.UpdUser = objRow[convCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人
objvCurrEduClsTeacherEN.Memo = objRow[convCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Memo].ToString().Trim(); //备注
objvCurrEduClsTeacherEN.CollegeName4EduCls = objRow[convCurrEduClsTeacher.CollegeName4EduCls] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4EduCls].ToString().Trim(); //学院名_教学班
objvCurrEduClsTeacherEN.CollegeName4Teacher = objRow[convCurrEduClsTeacher.CollegeName4Teacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4Teacher].ToString().Trim(); //学院名_教师
objvCurrEduClsTeacherEN.UserType = objRow[convCurrEduClsTeacher.UserType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UserType].ToString().Trim(); //用户类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduClsTeacherEN.IdEduClsTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduClsTeacherEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCurrEduClsTeacherEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCurrEduClsTeacherEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCurrEduClsTeacherEN> arrObjLst = new List<clsvCurrEduClsTeacherEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN = new clsvCurrEduClsTeacherEN();
try
{
objvCurrEduClsTeacherEN.IdEduClsTeacher = Int32.Parse(objRow[convCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号
objvCurrEduClsTeacherEN.IdCurrEduCls = objRow[convCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsTeacherEN.CurrEduClsId = objRow[convCurrEduClsTeacher.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsTeacherEN.EduClsName = objRow[convCurrEduClsTeacher.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsTeacherEN.EduClsTypeId = objRow[convCurrEduClsTeacher.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsTeacherEN.EduClsTypeName = objRow[convCurrEduClsTeacher.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsTeacherEN.CourseId = objRow[convCurrEduClsTeacher.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsTeacherEN.CourseCode = objRow[convCurrEduClsTeacher.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsTeacherEN.CourseName = objRow[convCurrEduClsTeacher.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsTeacherEN.ExampleImgPath = objRow[convCurrEduClsTeacher.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduClsTeacherEN.TeachingSolutionId = objRow[convCurrEduClsTeacher.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsTeacherEN.TeachingSolutionName = objRow[convCurrEduClsTeacher.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsTeacherEN.IdXzCollege = objRow[convCurrEduClsTeacher.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsTeacherEN.CollegeId = objRow[convCurrEduClsTeacher.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsTeacherEN.IdEduWay = objRow[convCurrEduClsTeacher.IdEduWay] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduClsTeacherEN.TotalLessonQty = objRow[convCurrEduClsTeacher.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduClsTeacherEN.MaxStuQty = objRow[convCurrEduClsTeacher.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduClsTeacherEN.WeekQty = objRow[convCurrEduClsTeacher.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.WeekQty].ToString().Trim()); //总周数
objvCurrEduClsTeacherEN.ScheUnitPW = objRow[convCurrEduClsTeacher.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduClsTeacherEN.WeekStatusId = objRow[convCurrEduClsTeacher.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduClsTeacherEN.CustomerWeek = objRow[convCurrEduClsTeacher.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduClsTeacherEN.LessonQtyPerWeek = objRow[convCurrEduClsTeacher.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsTeacherEN.IdUniZone = objRow[convCurrEduClsTeacher.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsTeacherEN.IdGradeBase = objRow[convCurrEduClsTeacher.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduClsTeacherEN.GradeBaseId = objRow[convCurrEduClsTeacher.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduClsTeacherEN.GradeBaseName = objRow[convCurrEduClsTeacher.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsTeacherEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsTeacherEN.IdCourseType = objRow[convCurrEduClsTeacher.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsTeacherEN.CourseTypeId = objRow[convCurrEduClsTeacher.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsTeacherEN.CourseTypeName = objRow[convCurrEduClsTeacher.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsTeacherEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsTeacherEN.IdScoreType = objRow[convCurrEduClsTeacher.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduClsTeacherEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduClsTeacherEN.IdExamType = objRow[convCurrEduClsTeacher.IdExamType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduClsTeacherEN.BeginWeek = objRow[convCurrEduClsTeacher.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.BeginWeek].ToString().Trim()); //开始周
objvCurrEduClsTeacherEN.CurrStuNumValid = objRow[convCurrEduClsTeacher.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduClsTeacherEN.CurrStuNum = objRow[convCurrEduClsTeacher.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduClsTeacherEN.IdTeacher = objRow[convCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduClsTeacherEN.TeacherId = objRow[convCurrEduClsTeacher.TeacherId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherId].ToString().Trim(); //教师工号
objvCurrEduClsTeacherEN.TeacherName = objRow[convCurrEduClsTeacher.TeacherName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduClsTeacherEN.IdProfGrade = objRow[convCurrEduClsTeacher.IdProfGrade] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdProfGrade].ToString().Trim(); //专业职称流水号
objvCurrEduClsTeacherEN.ProfenssionalGradeName = objRow[convCurrEduClsTeacher.ProfenssionalGradeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvCurrEduClsTeacherEN.DegreeName = objRow[convCurrEduClsTeacher.DegreeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.DegreeName].ToString().Trim(); //学位名称
objvCurrEduClsTeacherEN.Birthday = objRow[convCurrEduClsTeacher.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Birthday].ToString().Trim(); //出生日期
objvCurrEduClsTeacherEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsGpUser].ToString().Trim()); //是否Gp用户
objvCurrEduClsTeacherEN.CollegeName = objRow[convCurrEduClsTeacher.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objRow[convCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号
objvCurrEduClsTeacherEN.EduClsTeacherTypeId = objRow[convCurrEduClsTeacher.EduClsTeacherTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeId].ToString().Trim(); //教学班教学类型ID
objvCurrEduClsTeacherEN.EduClsTeacherTypeDesc = objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc].ToString().Trim(); //教学班教师类型名
objvCurrEduClsTeacherEN.SchoolTerm = objRow[convCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsTeacherEN.SchoolYear = objRow[convCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsTeacherEN.OpenBeginDate = objRow[convCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期
objvCurrEduClsTeacherEN.OpenEndDate = objRow[convCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期
objvCurrEduClsTeacherEN.OrderNum = objRow[convCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号
objvCurrEduClsTeacherEN.UpdDate = objRow[convCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期
objvCurrEduClsTeacherEN.UpdUser = objRow[convCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人
objvCurrEduClsTeacherEN.Memo = objRow[convCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Memo].ToString().Trim(); //备注
objvCurrEduClsTeacherEN.CollegeName4EduCls = objRow[convCurrEduClsTeacher.CollegeName4EduCls] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4EduCls].ToString().Trim(); //学院名_教学班
objvCurrEduClsTeacherEN.CollegeName4Teacher = objRow[convCurrEduClsTeacher.CollegeName4Teacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4Teacher].ToString().Trim(); //学院名_教师
objvCurrEduClsTeacherEN.UserType = objRow[convCurrEduClsTeacher.UserType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UserType].ToString().Trim(); //用户类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduClsTeacherEN.IdEduClsTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduClsTeacherEN);
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
public static List<clsvCurrEduClsTeacherEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCurrEduClsTeacherEN> arrObjLst = new List<clsvCurrEduClsTeacherEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN = new clsvCurrEduClsTeacherEN();
try
{
objvCurrEduClsTeacherEN.IdEduClsTeacher = Int32.Parse(objRow[convCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号
objvCurrEduClsTeacherEN.IdCurrEduCls = objRow[convCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsTeacherEN.CurrEduClsId = objRow[convCurrEduClsTeacher.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsTeacherEN.EduClsName = objRow[convCurrEduClsTeacher.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsTeacherEN.EduClsTypeId = objRow[convCurrEduClsTeacher.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsTeacherEN.EduClsTypeName = objRow[convCurrEduClsTeacher.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsTeacherEN.CourseId = objRow[convCurrEduClsTeacher.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsTeacherEN.CourseCode = objRow[convCurrEduClsTeacher.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsTeacherEN.CourseName = objRow[convCurrEduClsTeacher.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsTeacherEN.ExampleImgPath = objRow[convCurrEduClsTeacher.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduClsTeacherEN.TeachingSolutionId = objRow[convCurrEduClsTeacher.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsTeacherEN.TeachingSolutionName = objRow[convCurrEduClsTeacher.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsTeacherEN.IdXzCollege = objRow[convCurrEduClsTeacher.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsTeacherEN.CollegeId = objRow[convCurrEduClsTeacher.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsTeacherEN.IdEduWay = objRow[convCurrEduClsTeacher.IdEduWay] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduClsTeacherEN.TotalLessonQty = objRow[convCurrEduClsTeacher.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduClsTeacherEN.MaxStuQty = objRow[convCurrEduClsTeacher.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduClsTeacherEN.WeekQty = objRow[convCurrEduClsTeacher.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.WeekQty].ToString().Trim()); //总周数
objvCurrEduClsTeacherEN.ScheUnitPW = objRow[convCurrEduClsTeacher.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduClsTeacherEN.WeekStatusId = objRow[convCurrEduClsTeacher.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduClsTeacherEN.CustomerWeek = objRow[convCurrEduClsTeacher.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduClsTeacherEN.LessonQtyPerWeek = objRow[convCurrEduClsTeacher.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsTeacherEN.IdUniZone = objRow[convCurrEduClsTeacher.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsTeacherEN.IdGradeBase = objRow[convCurrEduClsTeacher.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduClsTeacherEN.GradeBaseId = objRow[convCurrEduClsTeacher.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduClsTeacherEN.GradeBaseName = objRow[convCurrEduClsTeacher.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsTeacherEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsTeacherEN.IdCourseType = objRow[convCurrEduClsTeacher.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsTeacherEN.CourseTypeId = objRow[convCurrEduClsTeacher.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsTeacherEN.CourseTypeName = objRow[convCurrEduClsTeacher.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsTeacherEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsTeacherEN.IdScoreType = objRow[convCurrEduClsTeacher.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduClsTeacherEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduClsTeacherEN.IdExamType = objRow[convCurrEduClsTeacher.IdExamType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduClsTeacherEN.BeginWeek = objRow[convCurrEduClsTeacher.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.BeginWeek].ToString().Trim()); //开始周
objvCurrEduClsTeacherEN.CurrStuNumValid = objRow[convCurrEduClsTeacher.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduClsTeacherEN.CurrStuNum = objRow[convCurrEduClsTeacher.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduClsTeacherEN.IdTeacher = objRow[convCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduClsTeacherEN.TeacherId = objRow[convCurrEduClsTeacher.TeacherId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherId].ToString().Trim(); //教师工号
objvCurrEduClsTeacherEN.TeacherName = objRow[convCurrEduClsTeacher.TeacherName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduClsTeacherEN.IdProfGrade = objRow[convCurrEduClsTeacher.IdProfGrade] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdProfGrade].ToString().Trim(); //专业职称流水号
objvCurrEduClsTeacherEN.ProfenssionalGradeName = objRow[convCurrEduClsTeacher.ProfenssionalGradeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvCurrEduClsTeacherEN.DegreeName = objRow[convCurrEduClsTeacher.DegreeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.DegreeName].ToString().Trim(); //学位名称
objvCurrEduClsTeacherEN.Birthday = objRow[convCurrEduClsTeacher.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Birthday].ToString().Trim(); //出生日期
objvCurrEduClsTeacherEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsGpUser].ToString().Trim()); //是否Gp用户
objvCurrEduClsTeacherEN.CollegeName = objRow[convCurrEduClsTeacher.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objRow[convCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号
objvCurrEduClsTeacherEN.EduClsTeacherTypeId = objRow[convCurrEduClsTeacher.EduClsTeacherTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeId].ToString().Trim(); //教学班教学类型ID
objvCurrEduClsTeacherEN.EduClsTeacherTypeDesc = objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc].ToString().Trim(); //教学班教师类型名
objvCurrEduClsTeacherEN.SchoolTerm = objRow[convCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsTeacherEN.SchoolYear = objRow[convCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsTeacherEN.OpenBeginDate = objRow[convCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期
objvCurrEduClsTeacherEN.OpenEndDate = objRow[convCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期
objvCurrEduClsTeacherEN.OrderNum = objRow[convCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号
objvCurrEduClsTeacherEN.UpdDate = objRow[convCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期
objvCurrEduClsTeacherEN.UpdUser = objRow[convCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人
objvCurrEduClsTeacherEN.Memo = objRow[convCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Memo].ToString().Trim(); //备注
objvCurrEduClsTeacherEN.CollegeName4EduCls = objRow[convCurrEduClsTeacher.CollegeName4EduCls] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4EduCls].ToString().Trim(); //学院名_教学班
objvCurrEduClsTeacherEN.CollegeName4Teacher = objRow[convCurrEduClsTeacher.CollegeName4Teacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4Teacher].ToString().Trim(); //学院名_教师
objvCurrEduClsTeacherEN.UserType = objRow[convCurrEduClsTeacher.UserType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UserType].ToString().Trim(); //用户类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduClsTeacherEN.IdEduClsTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduClsTeacherEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduClsTeacherEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCurrEduClsTeacherEN> arrObjLst = new List<clsvCurrEduClsTeacherEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN = new clsvCurrEduClsTeacherEN();
try
{
objvCurrEduClsTeacherEN.IdEduClsTeacher = Int32.Parse(objRow[convCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号
objvCurrEduClsTeacherEN.IdCurrEduCls = objRow[convCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsTeacherEN.CurrEduClsId = objRow[convCurrEduClsTeacher.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsTeacherEN.EduClsName = objRow[convCurrEduClsTeacher.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsTeacherEN.EduClsTypeId = objRow[convCurrEduClsTeacher.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsTeacherEN.EduClsTypeName = objRow[convCurrEduClsTeacher.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsTeacherEN.CourseId = objRow[convCurrEduClsTeacher.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsTeacherEN.CourseCode = objRow[convCurrEduClsTeacher.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsTeacherEN.CourseName = objRow[convCurrEduClsTeacher.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsTeacherEN.ExampleImgPath = objRow[convCurrEduClsTeacher.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduClsTeacherEN.TeachingSolutionId = objRow[convCurrEduClsTeacher.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsTeacherEN.TeachingSolutionName = objRow[convCurrEduClsTeacher.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsTeacherEN.IdXzCollege = objRow[convCurrEduClsTeacher.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsTeacherEN.CollegeId = objRow[convCurrEduClsTeacher.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsTeacherEN.IdEduWay = objRow[convCurrEduClsTeacher.IdEduWay] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduClsTeacherEN.TotalLessonQty = objRow[convCurrEduClsTeacher.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduClsTeacherEN.MaxStuQty = objRow[convCurrEduClsTeacher.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduClsTeacherEN.WeekQty = objRow[convCurrEduClsTeacher.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.WeekQty].ToString().Trim()); //总周数
objvCurrEduClsTeacherEN.ScheUnitPW = objRow[convCurrEduClsTeacher.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduClsTeacherEN.WeekStatusId = objRow[convCurrEduClsTeacher.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduClsTeacherEN.CustomerWeek = objRow[convCurrEduClsTeacher.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduClsTeacherEN.LessonQtyPerWeek = objRow[convCurrEduClsTeacher.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsTeacherEN.IdUniZone = objRow[convCurrEduClsTeacher.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsTeacherEN.IdGradeBase = objRow[convCurrEduClsTeacher.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduClsTeacherEN.GradeBaseId = objRow[convCurrEduClsTeacher.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduClsTeacherEN.GradeBaseName = objRow[convCurrEduClsTeacher.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsTeacherEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsTeacherEN.IdCourseType = objRow[convCurrEduClsTeacher.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsTeacherEN.CourseTypeId = objRow[convCurrEduClsTeacher.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsTeacherEN.CourseTypeName = objRow[convCurrEduClsTeacher.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsTeacherEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsTeacherEN.IdScoreType = objRow[convCurrEduClsTeacher.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduClsTeacherEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduClsTeacherEN.IdExamType = objRow[convCurrEduClsTeacher.IdExamType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduClsTeacherEN.BeginWeek = objRow[convCurrEduClsTeacher.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.BeginWeek].ToString().Trim()); //开始周
objvCurrEduClsTeacherEN.CurrStuNumValid = objRow[convCurrEduClsTeacher.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduClsTeacherEN.CurrStuNum = objRow[convCurrEduClsTeacher.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduClsTeacherEN.IdTeacher = objRow[convCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduClsTeacherEN.TeacherId = objRow[convCurrEduClsTeacher.TeacherId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherId].ToString().Trim(); //教师工号
objvCurrEduClsTeacherEN.TeacherName = objRow[convCurrEduClsTeacher.TeacherName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduClsTeacherEN.IdProfGrade = objRow[convCurrEduClsTeacher.IdProfGrade] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdProfGrade].ToString().Trim(); //专业职称流水号
objvCurrEduClsTeacherEN.ProfenssionalGradeName = objRow[convCurrEduClsTeacher.ProfenssionalGradeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvCurrEduClsTeacherEN.DegreeName = objRow[convCurrEduClsTeacher.DegreeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.DegreeName].ToString().Trim(); //学位名称
objvCurrEduClsTeacherEN.Birthday = objRow[convCurrEduClsTeacher.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Birthday].ToString().Trim(); //出生日期
objvCurrEduClsTeacherEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsGpUser].ToString().Trim()); //是否Gp用户
objvCurrEduClsTeacherEN.CollegeName = objRow[convCurrEduClsTeacher.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objRow[convCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号
objvCurrEduClsTeacherEN.EduClsTeacherTypeId = objRow[convCurrEduClsTeacher.EduClsTeacherTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeId].ToString().Trim(); //教学班教学类型ID
objvCurrEduClsTeacherEN.EduClsTeacherTypeDesc = objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc].ToString().Trim(); //教学班教师类型名
objvCurrEduClsTeacherEN.SchoolTerm = objRow[convCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsTeacherEN.SchoolYear = objRow[convCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsTeacherEN.OpenBeginDate = objRow[convCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期
objvCurrEduClsTeacherEN.OpenEndDate = objRow[convCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期
objvCurrEduClsTeacherEN.OrderNum = objRow[convCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号
objvCurrEduClsTeacherEN.UpdDate = objRow[convCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期
objvCurrEduClsTeacherEN.UpdUser = objRow[convCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人
objvCurrEduClsTeacherEN.Memo = objRow[convCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Memo].ToString().Trim(); //备注
objvCurrEduClsTeacherEN.CollegeName4EduCls = objRow[convCurrEduClsTeacher.CollegeName4EduCls] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4EduCls].ToString().Trim(); //学院名_教学班
objvCurrEduClsTeacherEN.CollegeName4Teacher = objRow[convCurrEduClsTeacher.CollegeName4Teacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4Teacher].ToString().Trim(); //学院名_教师
objvCurrEduClsTeacherEN.UserType = objRow[convCurrEduClsTeacher.UserType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UserType].ToString().Trim(); //用户类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduClsTeacherEN.IdEduClsTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduClsTeacherEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCurrEduClsTeacher(ref clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN)
{
bool bolResult = vCurrEduClsTeacherDA.GetvCurrEduClsTeacher(ref objvCurrEduClsTeacherEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdEduClsTeacher">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCurrEduClsTeacherEN GetObjByIdEduClsTeacher(long lngIdEduClsTeacher)
{
clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN = vCurrEduClsTeacherDA.GetObjByIdEduClsTeacher(lngIdEduClsTeacher);
return objvCurrEduClsTeacherEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCurrEduClsTeacherEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN = vCurrEduClsTeacherDA.GetFirstObj(strWhereCond);
 return objvCurrEduClsTeacherEN;
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
public static clsvCurrEduClsTeacherEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN = vCurrEduClsTeacherDA.GetObjByDataRow(objRow);
 return objvCurrEduClsTeacherEN;
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
public static clsvCurrEduClsTeacherEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN = vCurrEduClsTeacherDA.GetObjByDataRow(objRow);
 return objvCurrEduClsTeacherEN;
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
 /// <param name = "lngIdEduClsTeacher">所给的关键字</param>
 /// <param name = "lstvCurrEduClsTeacherObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCurrEduClsTeacherEN GetObjByIdEduClsTeacherFromList(long lngIdEduClsTeacher, List<clsvCurrEduClsTeacherEN> lstvCurrEduClsTeacherObjLst)
{
foreach (clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN in lstvCurrEduClsTeacherObjLst)
{
if (objvCurrEduClsTeacherEN.IdEduClsTeacher == lngIdEduClsTeacher)
{
return objvCurrEduClsTeacherEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond) 
{
 long lngIdEduClsTeacher;
 try
 {
 lngIdEduClsTeacher = new clsvCurrEduClsTeacherDA().GetFirstID(strWhereCond);
 return lngIdEduClsTeacher;
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
 arrList = vCurrEduClsTeacherDA.GetID(strWhereCond);
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
bool bolIsExist = vCurrEduClsTeacherDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdEduClsTeacher">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdEduClsTeacher)
{
//检测记录是否存在
bool bolIsExist = vCurrEduClsTeacherDA.IsExist(lngIdEduClsTeacher);
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
 bolIsExist = clsvCurrEduClsTeacherDA.IsExistTable();
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
 bolIsExist = vCurrEduClsTeacherDA.IsExistTable(strTabName);
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
 /// <param name = "objvCurrEduClsTeacherENS">源对象</param>
 /// <param name = "objvCurrEduClsTeacherENT">目标对象</param>
 public static void CopyTo(clsvCurrEduClsTeacherEN objvCurrEduClsTeacherENS, clsvCurrEduClsTeacherEN objvCurrEduClsTeacherENT)
{
try
{
objvCurrEduClsTeacherENT.IdEduClsTeacher = objvCurrEduClsTeacherENS.IdEduClsTeacher; //教学班老师流水号
objvCurrEduClsTeacherENT.IdCurrEduCls = objvCurrEduClsTeacherENS.IdCurrEduCls; //教学班流水号
objvCurrEduClsTeacherENT.CurrEduClsId = objvCurrEduClsTeacherENS.CurrEduClsId; //教学班Id
objvCurrEduClsTeacherENT.EduClsName = objvCurrEduClsTeacherENS.EduClsName; //教学班名
objvCurrEduClsTeacherENT.EduClsTypeId = objvCurrEduClsTeacherENS.EduClsTypeId; //教学班类型Id
objvCurrEduClsTeacherENT.EduClsTypeName = objvCurrEduClsTeacherENS.EduClsTypeName; //教学班类型名称
objvCurrEduClsTeacherENT.CourseId = objvCurrEduClsTeacherENS.CourseId; //课程Id
objvCurrEduClsTeacherENT.CourseCode = objvCurrEduClsTeacherENS.CourseCode; //课程代码
objvCurrEduClsTeacherENT.CourseName = objvCurrEduClsTeacherENS.CourseName; //课程名称
objvCurrEduClsTeacherENT.ExampleImgPath = objvCurrEduClsTeacherENS.ExampleImgPath; //示例图路径
objvCurrEduClsTeacherENT.TeachingSolutionId = objvCurrEduClsTeacherENS.TeachingSolutionId; //教学方案Id
objvCurrEduClsTeacherENT.TeachingSolutionName = objvCurrEduClsTeacherENS.TeachingSolutionName; //教学方案名称
objvCurrEduClsTeacherENT.IdXzCollege = objvCurrEduClsTeacherENS.IdXzCollege; //学院流水号
objvCurrEduClsTeacherENT.CollegeId = objvCurrEduClsTeacherENS.CollegeId; //学院ID
objvCurrEduClsTeacherENT.IdEduWay = objvCurrEduClsTeacherENS.IdEduWay; //教学方式流水号
objvCurrEduClsTeacherENT.TotalLessonQty = objvCurrEduClsTeacherENS.TotalLessonQty; //总课时数
objvCurrEduClsTeacherENT.MaxStuQty = objvCurrEduClsTeacherENS.MaxStuQty; //最大学生数
objvCurrEduClsTeacherENT.WeekQty = objvCurrEduClsTeacherENS.WeekQty; //总周数
objvCurrEduClsTeacherENT.ScheUnitPW = objvCurrEduClsTeacherENS.ScheUnitPW; //周排课次数
objvCurrEduClsTeacherENT.WeekStatusId = objvCurrEduClsTeacherENS.WeekStatusId; //周状态编号(单,双,全周)
objvCurrEduClsTeacherENT.CustomerWeek = objvCurrEduClsTeacherENS.CustomerWeek; //自定义上课周
objvCurrEduClsTeacherENT.LessonQtyPerWeek = objvCurrEduClsTeacherENS.LessonQtyPerWeek; //周课时数
objvCurrEduClsTeacherENT.IdUniZone = objvCurrEduClsTeacherENS.IdUniZone; //校区流水号
objvCurrEduClsTeacherENT.IdGradeBase = objvCurrEduClsTeacherENS.IdGradeBase; //年级流水号
objvCurrEduClsTeacherENT.GradeBaseId = objvCurrEduClsTeacherENS.GradeBaseId; //年级代号
objvCurrEduClsTeacherENT.GradeBaseName = objvCurrEduClsTeacherENS.GradeBaseName; //年级名称
objvCurrEduClsTeacherENT.IsEffective = objvCurrEduClsTeacherENS.IsEffective; //是否有效
objvCurrEduClsTeacherENT.IdCourseType = objvCurrEduClsTeacherENS.IdCourseType; //课程类型流水号
objvCurrEduClsTeacherENT.CourseTypeId = objvCurrEduClsTeacherENS.CourseTypeId; //课程类型ID
objvCurrEduClsTeacherENT.CourseTypeName = objvCurrEduClsTeacherENS.CourseTypeName; //课程类型名称
objvCurrEduClsTeacherENT.IsDegree = objvCurrEduClsTeacherENS.IsDegree; //是否学位课
objvCurrEduClsTeacherENT.IdScoreType = objvCurrEduClsTeacherENS.IdScoreType; //成绩类型流水号
objvCurrEduClsTeacherENT.IsProportionalCtrl = objvCurrEduClsTeacherENS.IsProportionalCtrl; //是否比例控制
objvCurrEduClsTeacherENT.IdExamType = objvCurrEduClsTeacherENS.IdExamType; //考试方式流水号
objvCurrEduClsTeacherENT.BeginWeek = objvCurrEduClsTeacherENS.BeginWeek; //开始周
objvCurrEduClsTeacherENT.CurrStuNumValid = objvCurrEduClsTeacherENS.CurrStuNumValid; //CurrStuNum_Valid
objvCurrEduClsTeacherENT.CurrStuNum = objvCurrEduClsTeacherENS.CurrStuNum; //当前学生数
objvCurrEduClsTeacherENT.IdTeacher = objvCurrEduClsTeacherENS.IdTeacher; //教师流水号
objvCurrEduClsTeacherENT.TeacherId = objvCurrEduClsTeacherENS.TeacherId; //教师工号
objvCurrEduClsTeacherENT.TeacherName = objvCurrEduClsTeacherENS.TeacherName; //教师姓名
objvCurrEduClsTeacherENT.IdProfGrade = objvCurrEduClsTeacherENS.IdProfGrade; //专业职称流水号
objvCurrEduClsTeacherENT.ProfenssionalGradeName = objvCurrEduClsTeacherENS.ProfenssionalGradeName; //专业职称
objvCurrEduClsTeacherENT.DegreeName = objvCurrEduClsTeacherENS.DegreeName; //学位名称
objvCurrEduClsTeacherENT.Birthday = objvCurrEduClsTeacherENS.Birthday; //出生日期
objvCurrEduClsTeacherENT.IsGpUser = objvCurrEduClsTeacherENS.IsGpUser; //是否Gp用户
objvCurrEduClsTeacherENT.CollegeName = objvCurrEduClsTeacherENS.CollegeName; //学院名称
objvCurrEduClsTeacherENT.IdPk2EduClsTeacherType = objvCurrEduClsTeacherENS.IdPk2EduClsTeacherType; //教学班老师角色(主讲,辅导)流水号
objvCurrEduClsTeacherENT.EduClsTeacherTypeId = objvCurrEduClsTeacherENS.EduClsTeacherTypeId; //教学班教学类型ID
objvCurrEduClsTeacherENT.EduClsTeacherTypeDesc = objvCurrEduClsTeacherENS.EduClsTeacherTypeDesc; //教学班教师类型名
objvCurrEduClsTeacherENT.SchoolTerm = objvCurrEduClsTeacherENS.SchoolTerm; //学期
objvCurrEduClsTeacherENT.SchoolYear = objvCurrEduClsTeacherENS.SchoolYear; //学年
objvCurrEduClsTeacherENT.OpenBeginDate = objvCurrEduClsTeacherENS.OpenBeginDate; //开放开始日期
objvCurrEduClsTeacherENT.OpenEndDate = objvCurrEduClsTeacherENS.OpenEndDate; //开放结束日期
objvCurrEduClsTeacherENT.OrderNum = objvCurrEduClsTeacherENS.OrderNum; //序号
objvCurrEduClsTeacherENT.UpdDate = objvCurrEduClsTeacherENS.UpdDate; //修改日期
objvCurrEduClsTeacherENT.UpdUser = objvCurrEduClsTeacherENS.UpdUser; //修改人
objvCurrEduClsTeacherENT.Memo = objvCurrEduClsTeacherENS.Memo; //备注
objvCurrEduClsTeacherENT.CollegeName4EduCls = objvCurrEduClsTeacherENS.CollegeName4EduCls; //学院名_教学班
objvCurrEduClsTeacherENT.CollegeName4Teacher = objvCurrEduClsTeacherENS.CollegeName4Teacher; //学院名_教师
objvCurrEduClsTeacherENT.UserType = objvCurrEduClsTeacherENS.UserType; //用户类型
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
 /// <param name = "objvCurrEduClsTeacherEN">源简化对象</param>
 public static void SetUpdFlag(clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN)
{
try
{
objvCurrEduClsTeacherEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCurrEduClsTeacherEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCurrEduClsTeacher.IdEduClsTeacher, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.IdEduClsTeacher = objvCurrEduClsTeacherEN.IdEduClsTeacher; //教学班老师流水号
}
if (arrFldSet.Contains(convCurrEduClsTeacher.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.IdCurrEduCls = objvCurrEduClsTeacherEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convCurrEduClsTeacher.CurrEduClsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.CurrEduClsId = objvCurrEduClsTeacherEN.CurrEduClsId == "[null]" ? null :  objvCurrEduClsTeacherEN.CurrEduClsId; //教学班Id
}
if (arrFldSet.Contains(convCurrEduClsTeacher.EduClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.EduClsName = objvCurrEduClsTeacherEN.EduClsName; //教学班名
}
if (arrFldSet.Contains(convCurrEduClsTeacher.EduClsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.EduClsTypeId = objvCurrEduClsTeacherEN.EduClsTypeId; //教学班类型Id
}
if (arrFldSet.Contains(convCurrEduClsTeacher.EduClsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.EduClsTypeName = objvCurrEduClsTeacherEN.EduClsTypeName == "[null]" ? null :  objvCurrEduClsTeacherEN.EduClsTypeName; //教学班类型名称
}
if (arrFldSet.Contains(convCurrEduClsTeacher.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.CourseId = objvCurrEduClsTeacherEN.CourseId == "[null]" ? null :  objvCurrEduClsTeacherEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convCurrEduClsTeacher.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.CourseCode = objvCurrEduClsTeacherEN.CourseCode == "[null]" ? null :  objvCurrEduClsTeacherEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convCurrEduClsTeacher.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.CourseName = objvCurrEduClsTeacherEN.CourseName == "[null]" ? null :  objvCurrEduClsTeacherEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convCurrEduClsTeacher.ExampleImgPath, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.ExampleImgPath = objvCurrEduClsTeacherEN.ExampleImgPath == "[null]" ? null :  objvCurrEduClsTeacherEN.ExampleImgPath; //示例图路径
}
if (arrFldSet.Contains(convCurrEduClsTeacher.TeachingSolutionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.TeachingSolutionId = objvCurrEduClsTeacherEN.TeachingSolutionId == "[null]" ? null :  objvCurrEduClsTeacherEN.TeachingSolutionId; //教学方案Id
}
if (arrFldSet.Contains(convCurrEduClsTeacher.TeachingSolutionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.TeachingSolutionName = objvCurrEduClsTeacherEN.TeachingSolutionName == "[null]" ? null :  objvCurrEduClsTeacherEN.TeachingSolutionName; //教学方案名称
}
if (arrFldSet.Contains(convCurrEduClsTeacher.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.IdXzCollege = objvCurrEduClsTeacherEN.IdXzCollege == "[null]" ? null :  objvCurrEduClsTeacherEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convCurrEduClsTeacher.CollegeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.CollegeId = objvCurrEduClsTeacherEN.CollegeId == "[null]" ? null :  objvCurrEduClsTeacherEN.CollegeId; //学院ID
}
if (arrFldSet.Contains(convCurrEduClsTeacher.IdEduWay, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.IdEduWay = objvCurrEduClsTeacherEN.IdEduWay == "[null]" ? null :  objvCurrEduClsTeacherEN.IdEduWay; //教学方式流水号
}
if (arrFldSet.Contains(convCurrEduClsTeacher.TotalLessonQty, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.TotalLessonQty = objvCurrEduClsTeacherEN.TotalLessonQty; //总课时数
}
if (arrFldSet.Contains(convCurrEduClsTeacher.MaxStuQty, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.MaxStuQty = objvCurrEduClsTeacherEN.MaxStuQty; //最大学生数
}
if (arrFldSet.Contains(convCurrEduClsTeacher.WeekQty, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.WeekQty = objvCurrEduClsTeacherEN.WeekQty; //总周数
}
if (arrFldSet.Contains(convCurrEduClsTeacher.ScheUnitPW, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.ScheUnitPW = objvCurrEduClsTeacherEN.ScheUnitPW; //周排课次数
}
if (arrFldSet.Contains(convCurrEduClsTeacher.WeekStatusId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.WeekStatusId = objvCurrEduClsTeacherEN.WeekStatusId == "[null]" ? null :  objvCurrEduClsTeacherEN.WeekStatusId; //周状态编号(单,双,全周)
}
if (arrFldSet.Contains(convCurrEduClsTeacher.CustomerWeek, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.CustomerWeek = objvCurrEduClsTeacherEN.CustomerWeek == "[null]" ? null :  objvCurrEduClsTeacherEN.CustomerWeek; //自定义上课周
}
if (arrFldSet.Contains(convCurrEduClsTeacher.LessonQtyPerWeek, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.LessonQtyPerWeek = objvCurrEduClsTeacherEN.LessonQtyPerWeek; //周课时数
}
if (arrFldSet.Contains(convCurrEduClsTeacher.IdUniZone, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.IdUniZone = objvCurrEduClsTeacherEN.IdUniZone == "[null]" ? null :  objvCurrEduClsTeacherEN.IdUniZone; //校区流水号
}
if (arrFldSet.Contains(convCurrEduClsTeacher.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.IdGradeBase = objvCurrEduClsTeacherEN.IdGradeBase == "[null]" ? null :  objvCurrEduClsTeacherEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(convCurrEduClsTeacher.GradeBaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.GradeBaseId = objvCurrEduClsTeacherEN.GradeBaseId == "[null]" ? null :  objvCurrEduClsTeacherEN.GradeBaseId; //年级代号
}
if (arrFldSet.Contains(convCurrEduClsTeacher.GradeBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.GradeBaseName = objvCurrEduClsTeacherEN.GradeBaseName == "[null]" ? null :  objvCurrEduClsTeacherEN.GradeBaseName; //年级名称
}
if (arrFldSet.Contains(convCurrEduClsTeacher.IsEffective, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.IsEffective = objvCurrEduClsTeacherEN.IsEffective; //是否有效
}
if (arrFldSet.Contains(convCurrEduClsTeacher.IdCourseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.IdCourseType = objvCurrEduClsTeacherEN.IdCourseType == "[null]" ? null :  objvCurrEduClsTeacherEN.IdCourseType; //课程类型流水号
}
if (arrFldSet.Contains(convCurrEduClsTeacher.CourseTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.CourseTypeId = objvCurrEduClsTeacherEN.CourseTypeId == "[null]" ? null :  objvCurrEduClsTeacherEN.CourseTypeId; //课程类型ID
}
if (arrFldSet.Contains(convCurrEduClsTeacher.CourseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.CourseTypeName = objvCurrEduClsTeacherEN.CourseTypeName == "[null]" ? null :  objvCurrEduClsTeacherEN.CourseTypeName; //课程类型名称
}
if (arrFldSet.Contains(convCurrEduClsTeacher.IsDegree, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.IsDegree = objvCurrEduClsTeacherEN.IsDegree; //是否学位课
}
if (arrFldSet.Contains(convCurrEduClsTeacher.IdScoreType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.IdScoreType = objvCurrEduClsTeacherEN.IdScoreType == "[null]" ? null :  objvCurrEduClsTeacherEN.IdScoreType; //成绩类型流水号
}
if (arrFldSet.Contains(convCurrEduClsTeacher.IsProportionalCtrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.IsProportionalCtrl = objvCurrEduClsTeacherEN.IsProportionalCtrl; //是否比例控制
}
if (arrFldSet.Contains(convCurrEduClsTeacher.IdExamType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.IdExamType = objvCurrEduClsTeacherEN.IdExamType == "[null]" ? null :  objvCurrEduClsTeacherEN.IdExamType; //考试方式流水号
}
if (arrFldSet.Contains(convCurrEduClsTeacher.BeginWeek, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.BeginWeek = objvCurrEduClsTeacherEN.BeginWeek; //开始周
}
if (arrFldSet.Contains(convCurrEduClsTeacher.CurrStuNumValid, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.CurrStuNumValid = objvCurrEduClsTeacherEN.CurrStuNumValid; //CurrStuNum_Valid
}
if (arrFldSet.Contains(convCurrEduClsTeacher.CurrStuNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.CurrStuNum = objvCurrEduClsTeacherEN.CurrStuNum; //当前学生数
}
if (arrFldSet.Contains(convCurrEduClsTeacher.IdTeacher, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.IdTeacher = objvCurrEduClsTeacherEN.IdTeacher == "[null]" ? null :  objvCurrEduClsTeacherEN.IdTeacher; //教师流水号
}
if (arrFldSet.Contains(convCurrEduClsTeacher.TeacherId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.TeacherId = objvCurrEduClsTeacherEN.TeacherId == "[null]" ? null :  objvCurrEduClsTeacherEN.TeacherId; //教师工号
}
if (arrFldSet.Contains(convCurrEduClsTeacher.TeacherName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.TeacherName = objvCurrEduClsTeacherEN.TeacherName == "[null]" ? null :  objvCurrEduClsTeacherEN.TeacherName; //教师姓名
}
if (arrFldSet.Contains(convCurrEduClsTeacher.IdProfGrade, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.IdProfGrade = objvCurrEduClsTeacherEN.IdProfGrade == "[null]" ? null :  objvCurrEduClsTeacherEN.IdProfGrade; //专业职称流水号
}
if (arrFldSet.Contains(convCurrEduClsTeacher.ProfenssionalGradeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.ProfenssionalGradeName = objvCurrEduClsTeacherEN.ProfenssionalGradeName == "[null]" ? null :  objvCurrEduClsTeacherEN.ProfenssionalGradeName; //专业职称
}
if (arrFldSet.Contains(convCurrEduClsTeacher.DegreeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.DegreeName = objvCurrEduClsTeacherEN.DegreeName == "[null]" ? null :  objvCurrEduClsTeacherEN.DegreeName; //学位名称
}
if (arrFldSet.Contains(convCurrEduClsTeacher.Birthday, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.Birthday = objvCurrEduClsTeacherEN.Birthday == "[null]" ? null :  objvCurrEduClsTeacherEN.Birthday; //出生日期
}
if (arrFldSet.Contains(convCurrEduClsTeacher.IsGpUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.IsGpUser = objvCurrEduClsTeacherEN.IsGpUser; //是否Gp用户
}
if (arrFldSet.Contains(convCurrEduClsTeacher.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.CollegeName = objvCurrEduClsTeacherEN.CollegeName == "[null]" ? null :  objvCurrEduClsTeacherEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convCurrEduClsTeacher.IdPk2EduClsTeacherType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objvCurrEduClsTeacherEN.IdPk2EduClsTeacherType; //教学班老师角色(主讲,辅导)流水号
}
if (arrFldSet.Contains(convCurrEduClsTeacher.EduClsTeacherTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.EduClsTeacherTypeId = objvCurrEduClsTeacherEN.EduClsTeacherTypeId == "[null]" ? null :  objvCurrEduClsTeacherEN.EduClsTeacherTypeId; //教学班教学类型ID
}
if (arrFldSet.Contains(convCurrEduClsTeacher.EduClsTeacherTypeDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.EduClsTeacherTypeDesc = objvCurrEduClsTeacherEN.EduClsTeacherTypeDesc == "[null]" ? null :  objvCurrEduClsTeacherEN.EduClsTeacherTypeDesc; //教学班教师类型名
}
if (arrFldSet.Contains(convCurrEduClsTeacher.SchoolTerm, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.SchoolTerm = objvCurrEduClsTeacherEN.SchoolTerm == "[null]" ? null :  objvCurrEduClsTeacherEN.SchoolTerm; //学期
}
if (arrFldSet.Contains(convCurrEduClsTeacher.SchoolYear, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.SchoolYear = objvCurrEduClsTeacherEN.SchoolYear == "[null]" ? null :  objvCurrEduClsTeacherEN.SchoolYear; //学年
}
if (arrFldSet.Contains(convCurrEduClsTeacher.OpenBeginDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.OpenBeginDate = objvCurrEduClsTeacherEN.OpenBeginDate == "[null]" ? null :  objvCurrEduClsTeacherEN.OpenBeginDate; //开放开始日期
}
if (arrFldSet.Contains(convCurrEduClsTeacher.OpenEndDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.OpenEndDate = objvCurrEduClsTeacherEN.OpenEndDate == "[null]" ? null :  objvCurrEduClsTeacherEN.OpenEndDate; //开放结束日期
}
if (arrFldSet.Contains(convCurrEduClsTeacher.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.OrderNum = objvCurrEduClsTeacherEN.OrderNum; //序号
}
if (arrFldSet.Contains(convCurrEduClsTeacher.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.UpdDate = objvCurrEduClsTeacherEN.UpdDate == "[null]" ? null :  objvCurrEduClsTeacherEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convCurrEduClsTeacher.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.UpdUser = objvCurrEduClsTeacherEN.UpdUser == "[null]" ? null :  objvCurrEduClsTeacherEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convCurrEduClsTeacher.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.Memo = objvCurrEduClsTeacherEN.Memo == "[null]" ? null :  objvCurrEduClsTeacherEN.Memo; //备注
}
if (arrFldSet.Contains(convCurrEduClsTeacher.CollegeName4EduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.CollegeName4EduCls = objvCurrEduClsTeacherEN.CollegeName4EduCls == "[null]" ? null :  objvCurrEduClsTeacherEN.CollegeName4EduCls; //学院名_教学班
}
if (arrFldSet.Contains(convCurrEduClsTeacher.CollegeName4Teacher, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.CollegeName4Teacher = objvCurrEduClsTeacherEN.CollegeName4Teacher == "[null]" ? null :  objvCurrEduClsTeacherEN.CollegeName4Teacher; //学院名_教师
}
if (arrFldSet.Contains(convCurrEduClsTeacher.UserType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsTeacherEN.UserType = objvCurrEduClsTeacherEN.UserType == "[null]" ? null :  objvCurrEduClsTeacherEN.UserType; //用户类型
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
 /// <param name = "objvCurrEduClsTeacherEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN)
{
try
{
if (objvCurrEduClsTeacherEN.CurrEduClsId == "[null]") objvCurrEduClsTeacherEN.CurrEduClsId = null; //教学班Id
if (objvCurrEduClsTeacherEN.EduClsTypeName == "[null]") objvCurrEduClsTeacherEN.EduClsTypeName = null; //教学班类型名称
if (objvCurrEduClsTeacherEN.CourseId == "[null]") objvCurrEduClsTeacherEN.CourseId = null; //课程Id
if (objvCurrEduClsTeacherEN.CourseCode == "[null]") objvCurrEduClsTeacherEN.CourseCode = null; //课程代码
if (objvCurrEduClsTeacherEN.CourseName == "[null]") objvCurrEduClsTeacherEN.CourseName = null; //课程名称
if (objvCurrEduClsTeacherEN.ExampleImgPath == "[null]") objvCurrEduClsTeacherEN.ExampleImgPath = null; //示例图路径
if (objvCurrEduClsTeacherEN.TeachingSolutionId == "[null]") objvCurrEduClsTeacherEN.TeachingSolutionId = null; //教学方案Id
if (objvCurrEduClsTeacherEN.TeachingSolutionName == "[null]") objvCurrEduClsTeacherEN.TeachingSolutionName = null; //教学方案名称
if (objvCurrEduClsTeacherEN.IdXzCollege == "[null]") objvCurrEduClsTeacherEN.IdXzCollege = null; //学院流水号
if (objvCurrEduClsTeacherEN.CollegeId == "[null]") objvCurrEduClsTeacherEN.CollegeId = null; //学院ID
if (objvCurrEduClsTeacherEN.IdEduWay == "[null]") objvCurrEduClsTeacherEN.IdEduWay = null; //教学方式流水号
if (objvCurrEduClsTeacherEN.WeekStatusId == "[null]") objvCurrEduClsTeacherEN.WeekStatusId = null; //周状态编号(单,双,全周)
if (objvCurrEduClsTeacherEN.CustomerWeek == "[null]") objvCurrEduClsTeacherEN.CustomerWeek = null; //自定义上课周
if (objvCurrEduClsTeacherEN.IdUniZone == "[null]") objvCurrEduClsTeacherEN.IdUniZone = null; //校区流水号
if (objvCurrEduClsTeacherEN.IdGradeBase == "[null]") objvCurrEduClsTeacherEN.IdGradeBase = null; //年级流水号
if (objvCurrEduClsTeacherEN.GradeBaseId == "[null]") objvCurrEduClsTeacherEN.GradeBaseId = null; //年级代号
if (objvCurrEduClsTeacherEN.GradeBaseName == "[null]") objvCurrEduClsTeacherEN.GradeBaseName = null; //年级名称
if (objvCurrEduClsTeacherEN.IdCourseType == "[null]") objvCurrEduClsTeacherEN.IdCourseType = null; //课程类型流水号
if (objvCurrEduClsTeacherEN.CourseTypeId == "[null]") objvCurrEduClsTeacherEN.CourseTypeId = null; //课程类型ID
if (objvCurrEduClsTeacherEN.CourseTypeName == "[null]") objvCurrEduClsTeacherEN.CourseTypeName = null; //课程类型名称
if (objvCurrEduClsTeacherEN.IdScoreType == "[null]") objvCurrEduClsTeacherEN.IdScoreType = null; //成绩类型流水号
if (objvCurrEduClsTeacherEN.IdExamType == "[null]") objvCurrEduClsTeacherEN.IdExamType = null; //考试方式流水号
if (objvCurrEduClsTeacherEN.IdTeacher == "[null]") objvCurrEduClsTeacherEN.IdTeacher = null; //教师流水号
if (objvCurrEduClsTeacherEN.TeacherId == "[null]") objvCurrEduClsTeacherEN.TeacherId = null; //教师工号
if (objvCurrEduClsTeacherEN.TeacherName == "[null]") objvCurrEduClsTeacherEN.TeacherName = null; //教师姓名
if (objvCurrEduClsTeacherEN.IdProfGrade == "[null]") objvCurrEduClsTeacherEN.IdProfGrade = null; //专业职称流水号
if (objvCurrEduClsTeacherEN.ProfenssionalGradeName == "[null]") objvCurrEduClsTeacherEN.ProfenssionalGradeName = null; //专业职称
if (objvCurrEduClsTeacherEN.DegreeName == "[null]") objvCurrEduClsTeacherEN.DegreeName = null; //学位名称
if (objvCurrEduClsTeacherEN.Birthday == "[null]") objvCurrEduClsTeacherEN.Birthday = null; //出生日期
if (objvCurrEduClsTeacherEN.CollegeName == "[null]") objvCurrEduClsTeacherEN.CollegeName = null; //学院名称
if (objvCurrEduClsTeacherEN.EduClsTeacherTypeId == "[null]") objvCurrEduClsTeacherEN.EduClsTeacherTypeId = null; //教学班教学类型ID
if (objvCurrEduClsTeacherEN.EduClsTeacherTypeDesc == "[null]") objvCurrEduClsTeacherEN.EduClsTeacherTypeDesc = null; //教学班教师类型名
if (objvCurrEduClsTeacherEN.SchoolTerm == "[null]") objvCurrEduClsTeacherEN.SchoolTerm = null; //学期
if (objvCurrEduClsTeacherEN.SchoolYear == "[null]") objvCurrEduClsTeacherEN.SchoolYear = null; //学年
if (objvCurrEduClsTeacherEN.OpenBeginDate == "[null]") objvCurrEduClsTeacherEN.OpenBeginDate = null; //开放开始日期
if (objvCurrEduClsTeacherEN.OpenEndDate == "[null]") objvCurrEduClsTeacherEN.OpenEndDate = null; //开放结束日期
if (objvCurrEduClsTeacherEN.UpdDate == "[null]") objvCurrEduClsTeacherEN.UpdDate = null; //修改日期
if (objvCurrEduClsTeacherEN.UpdUser == "[null]") objvCurrEduClsTeacherEN.UpdUser = null; //修改人
if (objvCurrEduClsTeacherEN.Memo == "[null]") objvCurrEduClsTeacherEN.Memo = null; //备注
if (objvCurrEduClsTeacherEN.CollegeName4EduCls == "[null]") objvCurrEduClsTeacherEN.CollegeName4EduCls = null; //学院名_教学班
if (objvCurrEduClsTeacherEN.CollegeName4Teacher == "[null]") objvCurrEduClsTeacherEN.CollegeName4Teacher = null; //学院名_教师
if (objvCurrEduClsTeacherEN.UserType == "[null]") objvCurrEduClsTeacherEN.UserType = null; //用户类型
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
public static void CheckProperty4Condition(clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN)
{
 vCurrEduClsTeacherDA.CheckProperty4Condition(objvCurrEduClsTeacherEN);
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
if (clsCurrEduClsTeacherBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsTeacherBL没有刷新缓存机制(clsCurrEduClsTeacherBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPk2EduClsTeacherTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPk2EduClsTeacherTypeBL没有刷新缓存机制(clsPk2EduClsTeacherTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeBL没有刷新缓存机制(clscc_CourseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdEduClsTeacher");
//if (arrvCurrEduClsTeacherObjLstCache == null)
//{
//arrvCurrEduClsTeacherObjLstCache = vCurrEduClsTeacherDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdEduClsTeacher">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCurrEduClsTeacherEN GetObjByIdEduClsTeacherCache(long lngIdEduClsTeacher, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvCurrEduClsTeacherEN._CurrTabName, strIdCurrEduCls);
List<clsvCurrEduClsTeacherEN> arrvCurrEduClsTeacherObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvCurrEduClsTeacherEN> arrvCurrEduClsTeacherObjLst_Sel =
arrvCurrEduClsTeacherObjLstCache
.Where(x=> x.IdEduClsTeacher == lngIdEduClsTeacher 
);
if (arrvCurrEduClsTeacherObjLst_Sel.Count() == 0)
{
   clsvCurrEduClsTeacherEN obj = clsvCurrEduClsTeacherBL.GetObjByIdEduClsTeacher(lngIdEduClsTeacher);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngIdEduClsTeacher, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvCurrEduClsTeacherObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCurrEduClsTeacherEN> GetAllvCurrEduClsTeacherObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvCurrEduClsTeacherEN> arrvCurrEduClsTeacherObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvCurrEduClsTeacherObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCurrEduClsTeacherEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvCurrEduClsTeacherEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvCurrEduClsTeacherEN> arrvCurrEduClsTeacherObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvCurrEduClsTeacherObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvCurrEduClsTeacherEN._CurrTabName, strIdCurrEduCls);
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
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngIdEduClsTeacher, string strIdCurrEduCls)
{
if (strInFldName != convCurrEduClsTeacher.IdEduClsTeacher)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCurrEduClsTeacher.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCurrEduClsTeacher.AttributeName));
throw new Exception(strMsg);
}
var objvCurrEduClsTeacher = clsvCurrEduClsTeacherBL.GetObjByIdEduClsTeacherCache(lngIdEduClsTeacher, strIdCurrEduCls);
if (objvCurrEduClsTeacher == null) return "";
return objvCurrEduClsTeacher[strOutFldName].ToString();
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
int intRecCount = clsvCurrEduClsTeacherDA.GetRecCount(strTabName);
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
int intRecCount = clsvCurrEduClsTeacherDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCurrEduClsTeacherDA.GetRecCount();
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
int intRecCount = clsvCurrEduClsTeacherDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCurrEduClsTeacherEN objvCurrEduClsTeacherCond)
{
 string strIdCurrEduCls = objvCurrEduClsTeacherCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvCurrEduClsTeacherBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvCurrEduClsTeacherEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvCurrEduClsTeacherEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCurrEduClsTeacher.AttributeName)
{
if (objvCurrEduClsTeacherCond.IsUpdated(strFldName) == false) continue;
if (objvCurrEduClsTeacherCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCurrEduClsTeacherCond[strFldName].ToString());
}
else
{
if (objvCurrEduClsTeacherCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCurrEduClsTeacherCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCurrEduClsTeacherCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCurrEduClsTeacherCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCurrEduClsTeacherCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCurrEduClsTeacherCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCurrEduClsTeacherCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCurrEduClsTeacherCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCurrEduClsTeacherCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCurrEduClsTeacherCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCurrEduClsTeacherCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCurrEduClsTeacherCond[strFldName]));
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
 List<string> arrList = clsvCurrEduClsTeacherDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCurrEduClsTeacherDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCurrEduClsTeacherDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}