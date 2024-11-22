
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCurrEduClsStu4AppWApi
 表名:vCurrEduClsStu4App(01120224)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:51:11
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
public static class clsvCurrEduClsStu4AppWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4AppEN Setid_EduClsStu(this clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN, long lngid_EduClsStu, string strComparisonOp="")
	{
objvCurrEduClsStu4AppEN.id_EduClsStu = lngid_EduClsStu; //教学班学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4App.id_EduClsStu) == false)
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp.Add(convCurrEduClsStu4App.id_EduClsStu, strComparisonOp);
}
else
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp[convCurrEduClsStu4App.id_EduClsStu] = strComparisonOp;
}
}
return objvCurrEduClsStu4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4AppEN Setid_CurrEduCls(this clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convCurrEduClsStu4App.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convCurrEduClsStu4App.id_CurrEduCls);
objvCurrEduClsStu4AppEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4App.id_CurrEduCls) == false)
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp.Add(convCurrEduClsStu4App.id_CurrEduCls, strComparisonOp);
}
else
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp[convCurrEduClsStu4App.id_CurrEduCls] = strComparisonOp;
}
}
return objvCurrEduClsStu4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4AppEN SetCurrEduClsId(this clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN, string strCurrEduClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, convCurrEduClsStu4App.CurrEduClsId);
objvCurrEduClsStu4AppEN.CurrEduClsId = strCurrEduClsId; //当前教学班Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4App.CurrEduClsId) == false)
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp.Add(convCurrEduClsStu4App.CurrEduClsId, strComparisonOp);
}
else
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp[convCurrEduClsStu4App.CurrEduClsId] = strComparisonOp;
}
}
return objvCurrEduClsStu4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4AppEN SetEduClsName(this clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convCurrEduClsStu4App.EduClsName);
objvCurrEduClsStu4AppEN.EduClsName = strEduClsName; //教学班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4App.EduClsName) == false)
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp.Add(convCurrEduClsStu4App.EduClsName, strComparisonOp);
}
else
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp[convCurrEduClsStu4App.EduClsName] = strComparisonOp;
}
}
return objvCurrEduClsStu4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4AppEN SetCourseId(this clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCurrEduClsStu4App.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCurrEduClsStu4App.CourseId);
objvCurrEduClsStu4AppEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4App.CourseId) == false)
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp.Add(convCurrEduClsStu4App.CourseId, strComparisonOp);
}
else
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp[convCurrEduClsStu4App.CourseId] = strComparisonOp;
}
}
return objvCurrEduClsStu4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4AppEN SetCourseCode(this clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCurrEduClsStu4App.CourseCode);
objvCurrEduClsStu4AppEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4App.CourseCode) == false)
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp.Add(convCurrEduClsStu4App.CourseCode, strComparisonOp);
}
else
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp[convCurrEduClsStu4App.CourseCode] = strComparisonOp;
}
}
return objvCurrEduClsStu4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4AppEN SetCourseDescription(this clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN, string strCourseDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseDescription, 8000, convCurrEduClsStu4App.CourseDescription);
objvCurrEduClsStu4AppEN.CourseDescription = strCourseDescription; //课程描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4App.CourseDescription) == false)
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp.Add(convCurrEduClsStu4App.CourseDescription, strComparisonOp);
}
else
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp[convCurrEduClsStu4App.CourseDescription] = strComparisonOp;
}
}
return objvCurrEduClsStu4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4AppEN SetCourseName(this clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCurrEduClsStu4App.CourseName);
objvCurrEduClsStu4AppEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4App.CourseName) == false)
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp.Add(convCurrEduClsStu4App.CourseName, strComparisonOp);
}
else
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp[convCurrEduClsStu4App.CourseName] = strComparisonOp;
}
}
return objvCurrEduClsStu4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4AppEN SetExampleImgPath(this clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN, string strExampleImgPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExampleImgPath, 300, convCurrEduClsStu4App.ExampleImgPath);
objvCurrEduClsStu4AppEN.ExampleImgPath = strExampleImgPath; //示例图路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4App.ExampleImgPath) == false)
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp.Add(convCurrEduClsStu4App.ExampleImgPath, strComparisonOp);
}
else
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp[convCurrEduClsStu4App.ExampleImgPath] = strComparisonOp;
}
}
return objvCurrEduClsStu4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4AppEN SetViewCount(this clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN, int intViewCount, string strComparisonOp="")
	{
objvCurrEduClsStu4AppEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4App.ViewCount) == false)
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp.Add(convCurrEduClsStu4App.ViewCount, strComparisonOp);
}
else
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp[convCurrEduClsStu4App.ViewCount] = strComparisonOp;
}
}
return objvCurrEduClsStu4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4AppEN SetMark(this clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN, double dblMark, string strComparisonOp="")
	{
objvCurrEduClsStu4AppEN.Mark = dblMark; //获得学分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4App.Mark) == false)
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp.Add(convCurrEduClsStu4App.Mark, strComparisonOp);
}
else
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp[convCurrEduClsStu4App.Mark] = strComparisonOp;
}
}
return objvCurrEduClsStu4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4AppEN SetGradeBaseName(this clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convCurrEduClsStu4App.GradeBaseName);
objvCurrEduClsStu4AppEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4App.GradeBaseName) == false)
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp.Add(convCurrEduClsStu4App.GradeBaseName, strComparisonOp);
}
else
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp[convCurrEduClsStu4App.GradeBaseName] = strComparisonOp;
}
}
return objvCurrEduClsStu4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4AppEN SetIsEffective(this clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN, bool bolIsEffective, string strComparisonOp="")
	{
objvCurrEduClsStu4AppEN.IsEffective = bolIsEffective; //是否有效
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4App.IsEffective) == false)
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp.Add(convCurrEduClsStu4App.IsEffective, strComparisonOp);
}
else
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp[convCurrEduClsStu4App.IsEffective] = strComparisonOp;
}
}
return objvCurrEduClsStu4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4AppEN Setid_CourseType(this clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN, string strid_CourseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CourseType, 4, convCurrEduClsStu4App.id_CourseType);
clsCheckSql.CheckFieldForeignKey(strid_CourseType, 4, convCurrEduClsStu4App.id_CourseType);
objvCurrEduClsStu4AppEN.id_CourseType = strid_CourseType; //课程类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4App.id_CourseType) == false)
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp.Add(convCurrEduClsStu4App.id_CourseType, strComparisonOp);
}
else
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp[convCurrEduClsStu4App.id_CourseType] = strComparisonOp;
}
}
return objvCurrEduClsStu4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4AppEN SetCourseTypeID(this clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN, string strCourseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseTypeID, 4, convCurrEduClsStu4App.CourseTypeID);
clsCheckSql.CheckFieldForeignKey(strCourseTypeID, 4, convCurrEduClsStu4App.CourseTypeID);
objvCurrEduClsStu4AppEN.CourseTypeID = strCourseTypeID; //课程类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4App.CourseTypeID) == false)
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp.Add(convCurrEduClsStu4App.CourseTypeID, strComparisonOp);
}
else
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp[convCurrEduClsStu4App.CourseTypeID] = strComparisonOp;
}
}
return objvCurrEduClsStu4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4AppEN SetCourseTypeName(this clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN, string strCourseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseTypeName, 30, convCurrEduClsStu4App.CourseTypeName);
objvCurrEduClsStu4AppEN.CourseTypeName = strCourseTypeName; //课程类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4App.CourseTypeName) == false)
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp.Add(convCurrEduClsStu4App.CourseTypeName, strComparisonOp);
}
else
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp[convCurrEduClsStu4App.CourseTypeName] = strComparisonOp;
}
}
return objvCurrEduClsStu4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4AppEN Setid_Stu(this clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN, string strid_Stu, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Stu, 8, convCurrEduClsStu4App.id_Stu);
clsCheckSql.CheckFieldForeignKey(strid_Stu, 8, convCurrEduClsStu4App.id_Stu);
objvCurrEduClsStu4AppEN.id_Stu = strid_Stu; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4App.id_Stu) == false)
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp.Add(convCurrEduClsStu4App.id_Stu, strComparisonOp);
}
else
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp[convCurrEduClsStu4App.id_Stu] = strComparisonOp;
}
}
return objvCurrEduClsStu4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4AppEN SetStuID(this clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convCurrEduClsStu4App.StuID);
objvCurrEduClsStu4AppEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4App.StuID) == false)
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp.Add(convCurrEduClsStu4App.StuID, strComparisonOp);
}
else
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp[convCurrEduClsStu4App.StuID] = strComparisonOp;
}
}
return objvCurrEduClsStu4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4AppEN SetStuName(this clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convCurrEduClsStu4App.StuName);
objvCurrEduClsStu4AppEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4App.StuName) == false)
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp.Add(convCurrEduClsStu4App.StuName, strComparisonOp);
}
else
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp[convCurrEduClsStu4App.StuName] = strComparisonOp;
}
}
return objvCurrEduClsStu4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4AppEN Setid_Sex(this clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN, string strid_Sex, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Sex, 4, convCurrEduClsStu4App.id_Sex);
clsCheckSql.CheckFieldForeignKey(strid_Sex, 4, convCurrEduClsStu4App.id_Sex);
objvCurrEduClsStu4AppEN.id_Sex = strid_Sex; //性别流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4App.id_Sex) == false)
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp.Add(convCurrEduClsStu4App.id_Sex, strComparisonOp);
}
else
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp[convCurrEduClsStu4App.id_Sex] = strComparisonOp;
}
}
return objvCurrEduClsStu4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4AppEN SetSexDesc(this clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN, string strSexDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convCurrEduClsStu4App.SexDesc);
objvCurrEduClsStu4AppEN.SexDesc = strSexDesc; //性别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4App.SexDesc) == false)
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp.Add(convCurrEduClsStu4App.SexDesc, strComparisonOp);
}
else
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp[convCurrEduClsStu4App.SexDesc] = strComparisonOp;
}
}
return objvCurrEduClsStu4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4AppEN SetMajorID(this clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convCurrEduClsStu4App.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convCurrEduClsStu4App.MajorID);
objvCurrEduClsStu4AppEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4App.MajorID) == false)
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp.Add(convCurrEduClsStu4App.MajorID, strComparisonOp);
}
else
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp[convCurrEduClsStu4App.MajorID] = strComparisonOp;
}
}
return objvCurrEduClsStu4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4AppEN SetMajorName(this clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convCurrEduClsStu4App.MajorName);
objvCurrEduClsStu4AppEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4App.MajorName) == false)
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp.Add(convCurrEduClsStu4App.MajorName, strComparisonOp);
}
else
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp[convCurrEduClsStu4App.MajorName] = strComparisonOp;
}
}
return objvCurrEduClsStu4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4AppEN Setid_AdminCls(this clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN, string strid_AdminCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_AdminCls, 8, convCurrEduClsStu4App.id_AdminCls);
clsCheckSql.CheckFieldForeignKey(strid_AdminCls, 8, convCurrEduClsStu4App.id_AdminCls);
objvCurrEduClsStu4AppEN.id_AdminCls = strid_AdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4App.id_AdminCls) == false)
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp.Add(convCurrEduClsStu4App.id_AdminCls, strComparisonOp);
}
else
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp[convCurrEduClsStu4App.id_AdminCls] = strComparisonOp;
}
}
return objvCurrEduClsStu4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4AppEN SetBirthday(this clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN, string strBirthday, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBirthday, 8, convCurrEduClsStu4App.Birthday);
clsCheckSql.CheckFieldForeignKey(strBirthday, 8, convCurrEduClsStu4App.Birthday);
objvCurrEduClsStu4AppEN.Birthday = strBirthday; //出生日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4App.Birthday) == false)
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp.Add(convCurrEduClsStu4App.Birthday, strComparisonOp);
}
else
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp[convCurrEduClsStu4App.Birthday] = strComparisonOp;
}
}
return objvCurrEduClsStu4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4AppEN SetIsOpByTeacher(this clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN, bool bolIsOpByTeacher, string strComparisonOp="")
	{
objvCurrEduClsStu4AppEN.IsOpByTeacher = bolIsOpByTeacher; //是否教师操作
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4App.IsOpByTeacher) == false)
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp.Add(convCurrEduClsStu4App.IsOpByTeacher, strComparisonOp);
}
else
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp[convCurrEduClsStu4App.IsOpByTeacher] = strComparisonOp;
}
}
return objvCurrEduClsStu4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4AppEN SetModifyDate(this clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN, string strModifyDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyDate, 20, convCurrEduClsStu4App.ModifyDate);
objvCurrEduClsStu4AppEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4App.ModifyDate) == false)
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp.Add(convCurrEduClsStu4App.ModifyDate, strComparisonOp);
}
else
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp[convCurrEduClsStu4App.ModifyDate] = strComparisonOp;
}
}
return objvCurrEduClsStu4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu4AppEN SetModifyUserID(this clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN, string strModifyUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyUserID, 18, convCurrEduClsStu4App.ModifyUserID);
objvCurrEduClsStu4AppEN.ModifyUserID = strModifyUserID; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu4AppEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu4App.ModifyUserID) == false)
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp.Add(convCurrEduClsStu4App.ModifyUserID, strComparisonOp);
}
else
{
objvCurrEduClsStu4AppEN.dicFldComparisonOp[convCurrEduClsStu4App.ModifyUserID] = strComparisonOp;
}
}
return objvCurrEduClsStu4AppEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCurrEduClsStu4AppEN objvCurrEduClsStu4App_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCurrEduClsStu4App_Cond.IsUpdated(convCurrEduClsStu4App.id_EduClsStu) == true)
{
string strComparisonOp_id_EduClsStu = objvCurrEduClsStu4App_Cond.dicFldComparisonOp[convCurrEduClsStu4App.id_EduClsStu];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsStu4App.id_EduClsStu, objvCurrEduClsStu4App_Cond.id_EduClsStu, strComparisonOp_id_EduClsStu);
}
if (objvCurrEduClsStu4App_Cond.IsUpdated(convCurrEduClsStu4App.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvCurrEduClsStu4App_Cond.dicFldComparisonOp[convCurrEduClsStu4App.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4App.id_CurrEduCls, objvCurrEduClsStu4App_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvCurrEduClsStu4App_Cond.IsUpdated(convCurrEduClsStu4App.CurrEduClsId) == true)
{
string strComparisonOp_CurrEduClsId = objvCurrEduClsStu4App_Cond.dicFldComparisonOp[convCurrEduClsStu4App.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4App.CurrEduClsId, objvCurrEduClsStu4App_Cond.CurrEduClsId, strComparisonOp_CurrEduClsId);
}
if (objvCurrEduClsStu4App_Cond.IsUpdated(convCurrEduClsStu4App.EduClsName) == true)
{
string strComparisonOp_EduClsName = objvCurrEduClsStu4App_Cond.dicFldComparisonOp[convCurrEduClsStu4App.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4App.EduClsName, objvCurrEduClsStu4App_Cond.EduClsName, strComparisonOp_EduClsName);
}
if (objvCurrEduClsStu4App_Cond.IsUpdated(convCurrEduClsStu4App.CourseId) == true)
{
string strComparisonOp_CourseId = objvCurrEduClsStu4App_Cond.dicFldComparisonOp[convCurrEduClsStu4App.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4App.CourseId, objvCurrEduClsStu4App_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvCurrEduClsStu4App_Cond.IsUpdated(convCurrEduClsStu4App.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvCurrEduClsStu4App_Cond.dicFldComparisonOp[convCurrEduClsStu4App.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4App.CourseCode, objvCurrEduClsStu4App_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvCurrEduClsStu4App_Cond.IsUpdated(convCurrEduClsStu4App.CourseDescription) == true)
{
string strComparisonOp_CourseDescription = objvCurrEduClsStu4App_Cond.dicFldComparisonOp[convCurrEduClsStu4App.CourseDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4App.CourseDescription, objvCurrEduClsStu4App_Cond.CourseDescription, strComparisonOp_CourseDescription);
}
if (objvCurrEduClsStu4App_Cond.IsUpdated(convCurrEduClsStu4App.CourseName) == true)
{
string strComparisonOp_CourseName = objvCurrEduClsStu4App_Cond.dicFldComparisonOp[convCurrEduClsStu4App.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4App.CourseName, objvCurrEduClsStu4App_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvCurrEduClsStu4App_Cond.IsUpdated(convCurrEduClsStu4App.ExampleImgPath) == true)
{
string strComparisonOp_ExampleImgPath = objvCurrEduClsStu4App_Cond.dicFldComparisonOp[convCurrEduClsStu4App.ExampleImgPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4App.ExampleImgPath, objvCurrEduClsStu4App_Cond.ExampleImgPath, strComparisonOp_ExampleImgPath);
}
if (objvCurrEduClsStu4App_Cond.IsUpdated(convCurrEduClsStu4App.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvCurrEduClsStu4App_Cond.dicFldComparisonOp[convCurrEduClsStu4App.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsStu4App.ViewCount, objvCurrEduClsStu4App_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvCurrEduClsStu4App_Cond.IsUpdated(convCurrEduClsStu4App.Mark) == true)
{
string strComparisonOp_Mark = objvCurrEduClsStu4App_Cond.dicFldComparisonOp[convCurrEduClsStu4App.Mark];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsStu4App.Mark, objvCurrEduClsStu4App_Cond.Mark, strComparisonOp_Mark);
}
if (objvCurrEduClsStu4App_Cond.IsUpdated(convCurrEduClsStu4App.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvCurrEduClsStu4App_Cond.dicFldComparisonOp[convCurrEduClsStu4App.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4App.GradeBaseName, objvCurrEduClsStu4App_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvCurrEduClsStu4App_Cond.IsUpdated(convCurrEduClsStu4App.IsEffective) == true)
{
if (objvCurrEduClsStu4App_Cond.IsEffective == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduClsStu4App.IsEffective);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduClsStu4App.IsEffective);
}
}
if (objvCurrEduClsStu4App_Cond.IsUpdated(convCurrEduClsStu4App.id_CourseType) == true)
{
string strComparisonOp_id_CourseType = objvCurrEduClsStu4App_Cond.dicFldComparisonOp[convCurrEduClsStu4App.id_CourseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4App.id_CourseType, objvCurrEduClsStu4App_Cond.id_CourseType, strComparisonOp_id_CourseType);
}
if (objvCurrEduClsStu4App_Cond.IsUpdated(convCurrEduClsStu4App.CourseTypeID) == true)
{
string strComparisonOp_CourseTypeID = objvCurrEduClsStu4App_Cond.dicFldComparisonOp[convCurrEduClsStu4App.CourseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4App.CourseTypeID, objvCurrEduClsStu4App_Cond.CourseTypeID, strComparisonOp_CourseTypeID);
}
if (objvCurrEduClsStu4App_Cond.IsUpdated(convCurrEduClsStu4App.CourseTypeName) == true)
{
string strComparisonOp_CourseTypeName = objvCurrEduClsStu4App_Cond.dicFldComparisonOp[convCurrEduClsStu4App.CourseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4App.CourseTypeName, objvCurrEduClsStu4App_Cond.CourseTypeName, strComparisonOp_CourseTypeName);
}
if (objvCurrEduClsStu4App_Cond.IsUpdated(convCurrEduClsStu4App.id_Stu) == true)
{
string strComparisonOp_id_Stu = objvCurrEduClsStu4App_Cond.dicFldComparisonOp[convCurrEduClsStu4App.id_Stu];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4App.id_Stu, objvCurrEduClsStu4App_Cond.id_Stu, strComparisonOp_id_Stu);
}
if (objvCurrEduClsStu4App_Cond.IsUpdated(convCurrEduClsStu4App.StuID) == true)
{
string strComparisonOp_StuID = objvCurrEduClsStu4App_Cond.dicFldComparisonOp[convCurrEduClsStu4App.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4App.StuID, objvCurrEduClsStu4App_Cond.StuID, strComparisonOp_StuID);
}
if (objvCurrEduClsStu4App_Cond.IsUpdated(convCurrEduClsStu4App.StuName) == true)
{
string strComparisonOp_StuName = objvCurrEduClsStu4App_Cond.dicFldComparisonOp[convCurrEduClsStu4App.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4App.StuName, objvCurrEduClsStu4App_Cond.StuName, strComparisonOp_StuName);
}
if (objvCurrEduClsStu4App_Cond.IsUpdated(convCurrEduClsStu4App.id_Sex) == true)
{
string strComparisonOp_id_Sex = objvCurrEduClsStu4App_Cond.dicFldComparisonOp[convCurrEduClsStu4App.id_Sex];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4App.id_Sex, objvCurrEduClsStu4App_Cond.id_Sex, strComparisonOp_id_Sex);
}
if (objvCurrEduClsStu4App_Cond.IsUpdated(convCurrEduClsStu4App.SexDesc) == true)
{
string strComparisonOp_SexDesc = objvCurrEduClsStu4App_Cond.dicFldComparisonOp[convCurrEduClsStu4App.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4App.SexDesc, objvCurrEduClsStu4App_Cond.SexDesc, strComparisonOp_SexDesc);
}
if (objvCurrEduClsStu4App_Cond.IsUpdated(convCurrEduClsStu4App.MajorID) == true)
{
string strComparisonOp_MajorID = objvCurrEduClsStu4App_Cond.dicFldComparisonOp[convCurrEduClsStu4App.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4App.MajorID, objvCurrEduClsStu4App_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvCurrEduClsStu4App_Cond.IsUpdated(convCurrEduClsStu4App.MajorName) == true)
{
string strComparisonOp_MajorName = objvCurrEduClsStu4App_Cond.dicFldComparisonOp[convCurrEduClsStu4App.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4App.MajorName, objvCurrEduClsStu4App_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvCurrEduClsStu4App_Cond.IsUpdated(convCurrEduClsStu4App.id_AdminCls) == true)
{
string strComparisonOp_id_AdminCls = objvCurrEduClsStu4App_Cond.dicFldComparisonOp[convCurrEduClsStu4App.id_AdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4App.id_AdminCls, objvCurrEduClsStu4App_Cond.id_AdminCls, strComparisonOp_id_AdminCls);
}
if (objvCurrEduClsStu4App_Cond.IsUpdated(convCurrEduClsStu4App.Birthday) == true)
{
string strComparisonOp_Birthday = objvCurrEduClsStu4App_Cond.dicFldComparisonOp[convCurrEduClsStu4App.Birthday];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4App.Birthday, objvCurrEduClsStu4App_Cond.Birthday, strComparisonOp_Birthday);
}
if (objvCurrEduClsStu4App_Cond.IsUpdated(convCurrEduClsStu4App.IsOpByTeacher) == true)
{
if (objvCurrEduClsStu4App_Cond.IsOpByTeacher == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduClsStu4App.IsOpByTeacher);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduClsStu4App.IsOpByTeacher);
}
}
if (objvCurrEduClsStu4App_Cond.IsUpdated(convCurrEduClsStu4App.ModifyDate) == true)
{
string strComparisonOp_ModifyDate = objvCurrEduClsStu4App_Cond.dicFldComparisonOp[convCurrEduClsStu4App.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4App.ModifyDate, objvCurrEduClsStu4App_Cond.ModifyDate, strComparisonOp_ModifyDate);
}
if (objvCurrEduClsStu4App_Cond.IsUpdated(convCurrEduClsStu4App.ModifyUserID) == true)
{
string strComparisonOp_ModifyUserID = objvCurrEduClsStu4App_Cond.dicFldComparisonOp[convCurrEduClsStu4App.ModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu4App.ModifyUserID, objvCurrEduClsStu4App_Cond.ModifyUserID, strComparisonOp_ModifyUserID);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v当前教学班学生4App(vCurrEduClsStu4App)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCurrEduClsStu4AppWApi
{
private static readonly string mstrApiControllerName = "vCurrEduClsStu4AppApi";

 public clsvCurrEduClsStu4AppWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_EduClsStu">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCurrEduClsStu4AppEN GetObjByid_EduClsStu(long lngid_EduClsStu)
{
string strAction = "GetObjByid_EduClsStu";
string strErrMsg = string.Empty;
string strResult = "";
clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_EduClsStu"] = lngid_EduClsStu.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCurrEduClsStu4AppEN = JsonConvert.DeserializeObject<clsvCurrEduClsStu4AppEN>((string)jobjReturn["ReturnObj"]);
return objvCurrEduClsStu4AppEN;
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
 /// <param name = "lngid_EduClsStu">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCurrEduClsStu4AppEN GetObjByid_EduClsStu_WA_Cache(long lngid_EduClsStu)
{
string strAction = "GetObjByid_EduClsStu_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_EduClsStu"] = lngid_EduClsStu.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCurrEduClsStu4AppEN = JsonConvert.DeserializeObject<clsvCurrEduClsStu4AppEN>((string)jobjReturn["ReturnObj"]);
return objvCurrEduClsStu4AppEN;
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
public static clsvCurrEduClsStu4AppEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppEN = null;
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
objvCurrEduClsStu4AppEN = JsonConvert.DeserializeObject<clsvCurrEduClsStu4AppEN>((string)jobjReturn["ReturnObj"]);
return objvCurrEduClsStu4AppEN;
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
 /// <param name = "lngid_EduClsStu">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCurrEduClsStu4AppEN GetObjByid_EduClsStu_Cache(long lngid_EduClsStu)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCurrEduClsStu4AppEN._CurrTabName_S);
List<clsvCurrEduClsStu4AppEN> arrvCurrEduClsStu4AppObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCurrEduClsStu4AppEN> arrvCurrEduClsStu4AppObjLst_Sel =
from objvCurrEduClsStu4AppEN in arrvCurrEduClsStu4AppObjLst_Cache
where objvCurrEduClsStu4AppEN.id_EduClsStu == lngid_EduClsStu
select objvCurrEduClsStu4AppEN;
if (arrvCurrEduClsStu4AppObjLst_Sel.Count() == 0)
{
   clsvCurrEduClsStu4AppEN obj = clsvCurrEduClsStu4AppWApi.GetObjByid_EduClsStu(lngid_EduClsStu);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCurrEduClsStu4AppObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduClsStu4AppEN> GetObjLst(string strWhereCond)
{
 List<clsvCurrEduClsStu4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsStu4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsStu4AppEN> GetObjLstById_EduClsStuLst(List<long> arrId_EduClsStu)
{
 List<clsvCurrEduClsStu4AppEN> arrObjLst = null; 
string strAction = "GetObjLstById_EduClsStuLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_EduClsStu);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsStu4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_EduClsStu">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvCurrEduClsStu4AppEN> GetObjLstById_EduClsStuLst_Cache(List<long> arrId_EduClsStu)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCurrEduClsStu4AppEN._CurrTabName_S);
List<clsvCurrEduClsStu4AppEN> arrvCurrEduClsStu4AppObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCurrEduClsStu4AppEN> arrvCurrEduClsStu4AppObjLst_Sel =
from objvCurrEduClsStu4AppEN in arrvCurrEduClsStu4AppObjLst_Cache
where arrId_EduClsStu.Contains(objvCurrEduClsStu4AppEN.id_EduClsStu)
select objvCurrEduClsStu4AppEN;
return arrvCurrEduClsStu4AppObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduClsStu4AppEN> GetObjLstById_EduClsStuLst_WA_Cache(List<long> arrId_EduClsStu)
{
 List<clsvCurrEduClsStu4AppEN> arrObjLst = null; 
string strAction = "GetObjLstById_EduClsStuLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_EduClsStu);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsStu4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsStu4AppEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCurrEduClsStu4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsStu4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsStu4AppEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCurrEduClsStu4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsStu4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsStu4AppEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCurrEduClsStu4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsStu4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsStu4AppEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCurrEduClsStu4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsStu4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_EduClsStu)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_EduClsStu"] = lngid_EduClsStu.ToString()
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
 /// <param name = "objvCurrEduClsStu4AppENS">源对象</param>
 /// <param name = "objvCurrEduClsStu4AppENT">目标对象</param>
 public static void CopyTo(clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppENS, clsvCurrEduClsStu4AppEN objvCurrEduClsStu4AppENT)
{
try
{
objvCurrEduClsStu4AppENT.id_EduClsStu = objvCurrEduClsStu4AppENS.id_EduClsStu; //教学班学生流水号
objvCurrEduClsStu4AppENT.id_CurrEduCls = objvCurrEduClsStu4AppENS.id_CurrEduCls; //当前教学班流水号
objvCurrEduClsStu4AppENT.CurrEduClsId = objvCurrEduClsStu4AppENS.CurrEduClsId; //当前教学班Id
objvCurrEduClsStu4AppENT.EduClsName = objvCurrEduClsStu4AppENS.EduClsName; //教学班名称
objvCurrEduClsStu4AppENT.CourseId = objvCurrEduClsStu4AppENS.CourseId; //课程Id
objvCurrEduClsStu4AppENT.CourseCode = objvCurrEduClsStu4AppENS.CourseCode; //课程代码
objvCurrEduClsStu4AppENT.CourseDescription = objvCurrEduClsStu4AppENS.CourseDescription; //课程描述
objvCurrEduClsStu4AppENT.CourseName = objvCurrEduClsStu4AppENS.CourseName; //课程名称
objvCurrEduClsStu4AppENT.ExampleImgPath = objvCurrEduClsStu4AppENS.ExampleImgPath; //示例图路径
objvCurrEduClsStu4AppENT.ViewCount = objvCurrEduClsStu4AppENS.ViewCount; //浏览量
objvCurrEduClsStu4AppENT.Mark = objvCurrEduClsStu4AppENS.Mark; //获得学分
objvCurrEduClsStu4AppENT.GradeBaseName = objvCurrEduClsStu4AppENS.GradeBaseName; //年级名称
objvCurrEduClsStu4AppENT.IsEffective = objvCurrEduClsStu4AppENS.IsEffective; //是否有效
objvCurrEduClsStu4AppENT.id_CourseType = objvCurrEduClsStu4AppENS.id_CourseType; //课程类型流水号
objvCurrEduClsStu4AppENT.CourseTypeID = objvCurrEduClsStu4AppENS.CourseTypeID; //课程类型ID
objvCurrEduClsStu4AppENT.CourseTypeName = objvCurrEduClsStu4AppENS.CourseTypeName; //课程类型名称
objvCurrEduClsStu4AppENT.id_Stu = objvCurrEduClsStu4AppENS.id_Stu; //学生流水号
objvCurrEduClsStu4AppENT.StuID = objvCurrEduClsStu4AppENS.StuID; //学号
objvCurrEduClsStu4AppENT.StuName = objvCurrEduClsStu4AppENS.StuName; //姓名
objvCurrEduClsStu4AppENT.id_Sex = objvCurrEduClsStu4AppENS.id_Sex; //性别流水号
objvCurrEduClsStu4AppENT.SexDesc = objvCurrEduClsStu4AppENS.SexDesc; //性别名称
objvCurrEduClsStu4AppENT.MajorID = objvCurrEduClsStu4AppENS.MajorID; //专业ID
objvCurrEduClsStu4AppENT.MajorName = objvCurrEduClsStu4AppENS.MajorName; //专业名称
objvCurrEduClsStu4AppENT.id_AdminCls = objvCurrEduClsStu4AppENS.id_AdminCls; //行政班流水号
objvCurrEduClsStu4AppENT.Birthday = objvCurrEduClsStu4AppENS.Birthday; //出生日期
objvCurrEduClsStu4AppENT.IsOpByTeacher = objvCurrEduClsStu4AppENS.IsOpByTeacher; //是否教师操作
objvCurrEduClsStu4AppENT.ModifyDate = objvCurrEduClsStu4AppENS.ModifyDate; //修改日期
objvCurrEduClsStu4AppENT.ModifyUserID = objvCurrEduClsStu4AppENS.ModifyUserID; //修改人
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
public static DataTable ToDataTable(List<clsvCurrEduClsStu4AppEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCurrEduClsStu4AppEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCurrEduClsStu4AppEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCurrEduClsStu4AppEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCurrEduClsStu4AppEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCurrEduClsStu4AppEN.AttributeName)
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
if (clsCurrEduClsStuWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsStuWApi没有刷新缓存机制(clsCurrEduClsStuWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by id_EduClsStu");
//if (arrvCurrEduClsStu4AppObjLst_Cache == null)
//{
//arrvCurrEduClsStu4AppObjLst_Cache = await clsvCurrEduClsStu4AppWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCurrEduClsStu4AppEN._CurrTabName_S);
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
public static List<clsvCurrEduClsStu4AppEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCurrEduClsStu4AppEN._CurrTabName_S);
List<clsvCurrEduClsStu4AppEN> arrvCurrEduClsStu4AppObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCurrEduClsStu4AppObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCurrEduClsStu4AppEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCurrEduClsStu4App.id_EduClsStu, Type.GetType("System.Int64"));
objDT.Columns.Add(convCurrEduClsStu4App.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4App.CurrEduClsId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4App.EduClsName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4App.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4App.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4App.CourseDescription, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4App.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4App.ExampleImgPath, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4App.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduClsStu4App.Mark, Type.GetType("System.Decimal"));
objDT.Columns.Add(convCurrEduClsStu4App.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4App.IsEffective, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduClsStu4App.id_CourseType, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4App.CourseTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4App.CourseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4App.id_Stu, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4App.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4App.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4App.id_Sex, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4App.SexDesc, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4App.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4App.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4App.id_AdminCls, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4App.Birthday, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4App.IsOpByTeacher, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduClsStu4App.ModifyDate, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu4App.ModifyUserID, Type.GetType("System.String"));
foreach (clsvCurrEduClsStu4AppEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCurrEduClsStu4App.id_EduClsStu] = objInFor[convCurrEduClsStu4App.id_EduClsStu];
objDR[convCurrEduClsStu4App.id_CurrEduCls] = objInFor[convCurrEduClsStu4App.id_CurrEduCls];
objDR[convCurrEduClsStu4App.CurrEduClsId] = objInFor[convCurrEduClsStu4App.CurrEduClsId];
objDR[convCurrEduClsStu4App.EduClsName] = objInFor[convCurrEduClsStu4App.EduClsName];
objDR[convCurrEduClsStu4App.CourseId] = objInFor[convCurrEduClsStu4App.CourseId];
objDR[convCurrEduClsStu4App.CourseCode] = objInFor[convCurrEduClsStu4App.CourseCode];
objDR[convCurrEduClsStu4App.CourseDescription] = objInFor[convCurrEduClsStu4App.CourseDescription];
objDR[convCurrEduClsStu4App.CourseName] = objInFor[convCurrEduClsStu4App.CourseName];
objDR[convCurrEduClsStu4App.ExampleImgPath] = objInFor[convCurrEduClsStu4App.ExampleImgPath];
objDR[convCurrEduClsStu4App.ViewCount] = objInFor[convCurrEduClsStu4App.ViewCount];
objDR[convCurrEduClsStu4App.Mark] = objInFor[convCurrEduClsStu4App.Mark];
objDR[convCurrEduClsStu4App.GradeBaseName] = objInFor[convCurrEduClsStu4App.GradeBaseName];
objDR[convCurrEduClsStu4App.IsEffective] = objInFor[convCurrEduClsStu4App.IsEffective];
objDR[convCurrEduClsStu4App.id_CourseType] = objInFor[convCurrEduClsStu4App.id_CourseType];
objDR[convCurrEduClsStu4App.CourseTypeID] = objInFor[convCurrEduClsStu4App.CourseTypeID];
objDR[convCurrEduClsStu4App.CourseTypeName] = objInFor[convCurrEduClsStu4App.CourseTypeName];
objDR[convCurrEduClsStu4App.id_Stu] = objInFor[convCurrEduClsStu4App.id_Stu];
objDR[convCurrEduClsStu4App.StuID] = objInFor[convCurrEduClsStu4App.StuID];
objDR[convCurrEduClsStu4App.StuName] = objInFor[convCurrEduClsStu4App.StuName];
objDR[convCurrEduClsStu4App.id_Sex] = objInFor[convCurrEduClsStu4App.id_Sex];
objDR[convCurrEduClsStu4App.SexDesc] = objInFor[convCurrEduClsStu4App.SexDesc];
objDR[convCurrEduClsStu4App.MajorID] = objInFor[convCurrEduClsStu4App.MajorID];
objDR[convCurrEduClsStu4App.MajorName] = objInFor[convCurrEduClsStu4App.MajorName];
objDR[convCurrEduClsStu4App.id_AdminCls] = objInFor[convCurrEduClsStu4App.id_AdminCls];
objDR[convCurrEduClsStu4App.Birthday] = objInFor[convCurrEduClsStu4App.Birthday];
objDR[convCurrEduClsStu4App.IsOpByTeacher] = objInFor[convCurrEduClsStu4App.IsOpByTeacher];
objDR[convCurrEduClsStu4App.ModifyDate] = objInFor[convCurrEduClsStu4App.ModifyDate];
objDR[convCurrEduClsStu4App.ModifyUserID] = objInFor[convCurrEduClsStu4App.ModifyUserID];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}