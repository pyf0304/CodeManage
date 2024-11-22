
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCurrEduClsStu_JTWApi
 表名:vCurrEduClsStu_JT(01120336)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:48:38
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
public static class clsvCurrEduClsStu_JTWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu_JTEN Setid_EduClsStu(this clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN, long lngid_EduClsStu, string strComparisonOp="")
	{
objvCurrEduClsStu_JTEN.id_EduClsStu = lngid_EduClsStu; //教学班学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu_JTEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu_JT.id_EduClsStu) == false)
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp.Add(convCurrEduClsStu_JT.id_EduClsStu, strComparisonOp);
}
else
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp[convCurrEduClsStu_JT.id_EduClsStu] = strComparisonOp;
}
}
return objvCurrEduClsStu_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu_JTEN Setid_CurrEduCls(this clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convCurrEduClsStu_JT.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convCurrEduClsStu_JT.id_CurrEduCls);
objvCurrEduClsStu_JTEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu_JTEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu_JT.id_CurrEduCls) == false)
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp.Add(convCurrEduClsStu_JT.id_CurrEduCls, strComparisonOp);
}
else
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp[convCurrEduClsStu_JT.id_CurrEduCls] = strComparisonOp;
}
}
return objvCurrEduClsStu_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu_JTEN SetEduClsName(this clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convCurrEduClsStu_JT.EduClsName);
objvCurrEduClsStu_JTEN.EduClsName = strEduClsName; //教学班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu_JTEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu_JT.EduClsName) == false)
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp.Add(convCurrEduClsStu_JT.EduClsName, strComparisonOp);
}
else
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp[convCurrEduClsStu_JT.EduClsName] = strComparisonOp;
}
}
return objvCurrEduClsStu_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu_JTEN SetCourseId(this clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCurrEduClsStu_JT.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCurrEduClsStu_JT.CourseId);
objvCurrEduClsStu_JTEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu_JTEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu_JT.CourseId) == false)
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp.Add(convCurrEduClsStu_JT.CourseId, strComparisonOp);
}
else
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp[convCurrEduClsStu_JT.CourseId] = strComparisonOp;
}
}
return objvCurrEduClsStu_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu_JTEN SetCourseName(this clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCurrEduClsStu_JT.CourseName);
objvCurrEduClsStu_JTEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu_JTEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu_JT.CourseName) == false)
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp.Add(convCurrEduClsStu_JT.CourseName, strComparisonOp);
}
else
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp[convCurrEduClsStu_JT.CourseName] = strComparisonOp;
}
}
return objvCurrEduClsStu_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu_JTEN Setid_Stu(this clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN, string strid_Stu, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Stu, 8, convCurrEduClsStu_JT.id_Stu);
clsCheckSql.CheckFieldForeignKey(strid_Stu, 8, convCurrEduClsStu_JT.id_Stu);
objvCurrEduClsStu_JTEN.id_Stu = strid_Stu; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu_JTEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu_JT.id_Stu) == false)
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp.Add(convCurrEduClsStu_JT.id_Stu, strComparisonOp);
}
else
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp[convCurrEduClsStu_JT.id_Stu] = strComparisonOp;
}
}
return objvCurrEduClsStu_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu_JTEN SetStuID(this clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convCurrEduClsStu_JT.StuID);
objvCurrEduClsStu_JTEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu_JTEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu_JT.StuID) == false)
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp.Add(convCurrEduClsStu_JT.StuID, strComparisonOp);
}
else
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp[convCurrEduClsStu_JT.StuID] = strComparisonOp;
}
}
return objvCurrEduClsStu_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu_JTEN SetSiteName(this clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN, string strSiteName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSiteName, 100, convCurrEduClsStu_JT.SiteName);
objvCurrEduClsStu_JTEN.SiteName = strSiteName; //工地名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu_JTEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu_JT.SiteName) == false)
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp.Add(convCurrEduClsStu_JT.SiteName, strComparisonOp);
}
else
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp[convCurrEduClsStu_JT.SiteName] = strComparisonOp;
}
}
return objvCurrEduClsStu_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu_JTEN SetStuName(this clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convCurrEduClsStu_JT.StuName);
objvCurrEduClsStu_JTEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu_JTEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu_JT.StuName) == false)
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp.Add(convCurrEduClsStu_JT.StuName, strComparisonOp);
}
else
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp[convCurrEduClsStu_JT.StuName] = strComparisonOp;
}
}
return objvCurrEduClsStu_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu_JTEN SetManagedDepartmentId(this clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN, string strManagedDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strManagedDepartmentId, 4, convCurrEduClsStu_JT.ManagedDepartmentId);
clsCheckSql.CheckFieldForeignKey(strManagedDepartmentId, 4, convCurrEduClsStu_JT.ManagedDepartmentId);
objvCurrEduClsStu_JTEN.ManagedDepartmentId = strManagedDepartmentId; //管理的部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu_JTEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu_JT.ManagedDepartmentId) == false)
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp.Add(convCurrEduClsStu_JT.ManagedDepartmentId, strComparisonOp);
}
else
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp[convCurrEduClsStu_JT.ManagedDepartmentId] = strComparisonOp;
}
}
return objvCurrEduClsStu_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu_JTEN SetManagedDepartmentName(this clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN, string strManagedDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strManagedDepartmentName, 50, convCurrEduClsStu_JT.ManagedDepartmentName);
objvCurrEduClsStu_JTEN.ManagedDepartmentName = strManagedDepartmentName; //管理的部门名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu_JTEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu_JT.ManagedDepartmentName) == false)
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp.Add(convCurrEduClsStu_JT.ManagedDepartmentName, strComparisonOp);
}
else
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp[convCurrEduClsStu_JT.ManagedDepartmentName] = strComparisonOp;
}
}
return objvCurrEduClsStu_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu_JTEN SetJobCategoryId(this clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN, string strJobCategoryId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strJobCategoryId, 2, convCurrEduClsStu_JT.JobCategoryId);
clsCheckSql.CheckFieldForeignKey(strJobCategoryId, 2, convCurrEduClsStu_JT.JobCategoryId);
objvCurrEduClsStu_JTEN.JobCategoryId = strJobCategoryId; //岗位类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu_JTEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu_JT.JobCategoryId) == false)
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp.Add(convCurrEduClsStu_JT.JobCategoryId, strComparisonOp);
}
else
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp[convCurrEduClsStu_JT.JobCategoryId] = strComparisonOp;
}
}
return objvCurrEduClsStu_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu_JTEN SetUserId(this clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, convCurrEduClsStu_JT.UserId);
objvCurrEduClsStu_JTEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu_JTEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu_JT.UserId) == false)
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp.Add(convCurrEduClsStu_JT.UserId, strComparisonOp);
}
else
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp[convCurrEduClsStu_JT.UserId] = strComparisonOp;
}
}
return objvCurrEduClsStu_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu_JTEN SetJobCategoryName(this clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN, string strJobCategoryName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strJobCategoryName, 50, convCurrEduClsStu_JT.JobCategoryName);
objvCurrEduClsStu_JTEN.JobCategoryName = strJobCategoryName; //岗位类别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu_JTEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu_JT.JobCategoryName) == false)
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp.Add(convCurrEduClsStu_JT.JobCategoryName, strComparisonOp);
}
else
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp[convCurrEduClsStu_JT.JobCategoryName] = strComparisonOp;
}
}
return objvCurrEduClsStu_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu_JTEN SetSexDesc(this clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN, string strSexDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convCurrEduClsStu_JT.SexDesc);
objvCurrEduClsStu_JTEN.SexDesc = strSexDesc; //性别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu_JTEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu_JT.SexDesc) == false)
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp.Add(convCurrEduClsStu_JT.SexDesc, strComparisonOp);
}
else
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp[convCurrEduClsStu_JT.SexDesc] = strComparisonOp;
}
}
return objvCurrEduClsStu_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu_JTEN SetScore(this clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN, double dblScore, string strComparisonOp="")
	{
objvCurrEduClsStu_JTEN.Score = dblScore; //得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu_JTEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu_JT.Score) == false)
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp.Add(convCurrEduClsStu_JT.Score, strComparisonOp);
}
else
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp[convCurrEduClsStu_JT.Score] = strComparisonOp;
}
}
return objvCurrEduClsStu_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu_JTEN SetTotalScores(this clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN, double dblTotalScores, string strComparisonOp="")
	{
objvCurrEduClsStu_JTEN.TotalScores = dblTotalScores; //总分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu_JTEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu_JT.TotalScores) == false)
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp.Add(convCurrEduClsStu_JT.TotalScores, strComparisonOp);
}
else
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp[convCurrEduClsStu_JT.TotalScores] = strComparisonOp;
}
}
return objvCurrEduClsStu_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu_JTEN SetRanking(this clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN, int intRanking, string strComparisonOp="")
	{
objvCurrEduClsStu_JTEN.Ranking = intRanking; //名次
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu_JTEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu_JT.Ranking) == false)
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp.Add(convCurrEduClsStu_JT.Ranking, strComparisonOp);
}
else
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp[convCurrEduClsStu_JT.Ranking] = strComparisonOp;
}
}
return objvCurrEduClsStu_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu_JTEN SetPercentile(this clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN, double dblPercentile, string strComparisonOp="")
	{
objvCurrEduClsStu_JTEN.Percentile = dblPercentile; //百分位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu_JTEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu_JT.Percentile) == false)
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp.Add(convCurrEduClsStu_JT.Percentile, strComparisonOp);
}
else
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp[convCurrEduClsStu_JT.Percentile] = strComparisonOp;
}
}
return objvCurrEduClsStu_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu_JTEN SetRanking2(this clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN, int intRanking2, string strComparisonOp="")
	{
objvCurrEduClsStu_JTEN.Ranking2 = intRanking2; //Ranking2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu_JTEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu_JT.Ranking2) == false)
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp.Add(convCurrEduClsStu_JT.Ranking2, strComparisonOp);
}
else
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp[convCurrEduClsStu_JT.Ranking2] = strComparisonOp;
}
}
return objvCurrEduClsStu_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu_JTEN SetPercentile2(this clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN, double dblPercentile2, string strComparisonOp="")
	{
objvCurrEduClsStu_JTEN.Percentile2 = dblPercentile2; //Percentile2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu_JTEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu_JT.Percentile2) == false)
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp.Add(convCurrEduClsStu_JT.Percentile2, strComparisonOp);
}
else
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp[convCurrEduClsStu_JT.Percentile2] = strComparisonOp;
}
}
return objvCurrEduClsStu_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu_JTEN SetRanking3(this clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN, int intRanking3, string strComparisonOp="")
	{
objvCurrEduClsStu_JTEN.Ranking3 = intRanking3; //Ranking3
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu_JTEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu_JT.Ranking3) == false)
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp.Add(convCurrEduClsStu_JT.Ranking3, strComparisonOp);
}
else
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp[convCurrEduClsStu_JT.Ranking3] = strComparisonOp;
}
}
return objvCurrEduClsStu_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu_JTEN SetPercentile3(this clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN, double dblPercentile3, string strComparisonOp="")
	{
objvCurrEduClsStu_JTEN.Percentile3 = dblPercentile3; //Percentile3
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu_JTEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu_JT.Percentile3) == false)
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp.Add(convCurrEduClsStu_JT.Percentile3, strComparisonOp);
}
else
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp[convCurrEduClsStu_JT.Percentile3] = strComparisonOp;
}
}
return objvCurrEduClsStu_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu_JTEN SetSchoolTerm(this clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, convCurrEduClsStu_JT.SchoolTerm);
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, convCurrEduClsStu_JT.SchoolTerm);
objvCurrEduClsStu_JTEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu_JTEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu_JT.SchoolTerm) == false)
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp.Add(convCurrEduClsStu_JT.SchoolTerm, strComparisonOp);
}
else
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp[convCurrEduClsStu_JT.SchoolTerm] = strComparisonOp;
}
}
return objvCurrEduClsStu_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu_JTEN SetSchoolYear(this clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN, string strSchoolYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, convCurrEduClsStu_JT.SchoolYear);
objvCurrEduClsStu_JTEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu_JTEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu_JT.SchoolYear) == false)
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp.Add(convCurrEduClsStu_JT.SchoolYear, strComparisonOp);
}
else
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp[convCurrEduClsStu_JT.SchoolYear] = strComparisonOp;
}
}
return objvCurrEduClsStu_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu_JTEN SetIsSynScore(this clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN, bool bolIsSynScore, string strComparisonOp="")
	{
objvCurrEduClsStu_JTEN.IsSynScore = bolIsSynScore; //是否同步成绩
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu_JTEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu_JT.IsSynScore) == false)
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp.Add(convCurrEduClsStu_JT.IsSynScore, strComparisonOp);
}
else
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp[convCurrEduClsStu_JT.IsSynScore] = strComparisonOp;
}
}
return objvCurrEduClsStu_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu_JTEN SetModifyDate(this clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN, string strModifyDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyDate, 20, convCurrEduClsStu_JT.ModifyDate);
objvCurrEduClsStu_JTEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu_JTEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu_JT.ModifyDate) == false)
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp.Add(convCurrEduClsStu_JT.ModifyDate, strComparisonOp);
}
else
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp[convCurrEduClsStu_JT.ModifyDate] = strComparisonOp;
}
}
return objvCurrEduClsStu_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStu_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStu_JTEN SetModifyUserID(this clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN, string strModifyUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyUserID, 18, convCurrEduClsStu_JT.ModifyUserID);
objvCurrEduClsStu_JTEN.ModifyUserID = strModifyUserID; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStu_JTEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu_JT.ModifyUserID) == false)
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp.Add(convCurrEduClsStu_JT.ModifyUserID, strComparisonOp);
}
else
{
objvCurrEduClsStu_JTEN.dicFldComparisonOp[convCurrEduClsStu_JT.ModifyUserID] = strComparisonOp;
}
}
return objvCurrEduClsStu_JTEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JT_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCurrEduClsStu_JT_Cond.IsUpdated(convCurrEduClsStu_JT.id_EduClsStu) == true)
{
string strComparisonOp_id_EduClsStu = objvCurrEduClsStu_JT_Cond.dicFldComparisonOp[convCurrEduClsStu_JT.id_EduClsStu];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsStu_JT.id_EduClsStu, objvCurrEduClsStu_JT_Cond.id_EduClsStu, strComparisonOp_id_EduClsStu);
}
if (objvCurrEduClsStu_JT_Cond.IsUpdated(convCurrEduClsStu_JT.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvCurrEduClsStu_JT_Cond.dicFldComparisonOp[convCurrEduClsStu_JT.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu_JT.id_CurrEduCls, objvCurrEduClsStu_JT_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvCurrEduClsStu_JT_Cond.IsUpdated(convCurrEduClsStu_JT.EduClsName) == true)
{
string strComparisonOp_EduClsName = objvCurrEduClsStu_JT_Cond.dicFldComparisonOp[convCurrEduClsStu_JT.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu_JT.EduClsName, objvCurrEduClsStu_JT_Cond.EduClsName, strComparisonOp_EduClsName);
}
if (objvCurrEduClsStu_JT_Cond.IsUpdated(convCurrEduClsStu_JT.CourseId) == true)
{
string strComparisonOp_CourseId = objvCurrEduClsStu_JT_Cond.dicFldComparisonOp[convCurrEduClsStu_JT.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu_JT.CourseId, objvCurrEduClsStu_JT_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvCurrEduClsStu_JT_Cond.IsUpdated(convCurrEduClsStu_JT.CourseName) == true)
{
string strComparisonOp_CourseName = objvCurrEduClsStu_JT_Cond.dicFldComparisonOp[convCurrEduClsStu_JT.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu_JT.CourseName, objvCurrEduClsStu_JT_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvCurrEduClsStu_JT_Cond.IsUpdated(convCurrEduClsStu_JT.id_Stu) == true)
{
string strComparisonOp_id_Stu = objvCurrEduClsStu_JT_Cond.dicFldComparisonOp[convCurrEduClsStu_JT.id_Stu];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu_JT.id_Stu, objvCurrEduClsStu_JT_Cond.id_Stu, strComparisonOp_id_Stu);
}
if (objvCurrEduClsStu_JT_Cond.IsUpdated(convCurrEduClsStu_JT.StuID) == true)
{
string strComparisonOp_StuID = objvCurrEduClsStu_JT_Cond.dicFldComparisonOp[convCurrEduClsStu_JT.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu_JT.StuID, objvCurrEduClsStu_JT_Cond.StuID, strComparisonOp_StuID);
}
if (objvCurrEduClsStu_JT_Cond.IsUpdated(convCurrEduClsStu_JT.SiteName) == true)
{
string strComparisonOp_SiteName = objvCurrEduClsStu_JT_Cond.dicFldComparisonOp[convCurrEduClsStu_JT.SiteName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu_JT.SiteName, objvCurrEduClsStu_JT_Cond.SiteName, strComparisonOp_SiteName);
}
if (objvCurrEduClsStu_JT_Cond.IsUpdated(convCurrEduClsStu_JT.StuName) == true)
{
string strComparisonOp_StuName = objvCurrEduClsStu_JT_Cond.dicFldComparisonOp[convCurrEduClsStu_JT.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu_JT.StuName, objvCurrEduClsStu_JT_Cond.StuName, strComparisonOp_StuName);
}
if (objvCurrEduClsStu_JT_Cond.IsUpdated(convCurrEduClsStu_JT.ManagedDepartmentId) == true)
{
string strComparisonOp_ManagedDepartmentId = objvCurrEduClsStu_JT_Cond.dicFldComparisonOp[convCurrEduClsStu_JT.ManagedDepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu_JT.ManagedDepartmentId, objvCurrEduClsStu_JT_Cond.ManagedDepartmentId, strComparisonOp_ManagedDepartmentId);
}
if (objvCurrEduClsStu_JT_Cond.IsUpdated(convCurrEduClsStu_JT.ManagedDepartmentName) == true)
{
string strComparisonOp_ManagedDepartmentName = objvCurrEduClsStu_JT_Cond.dicFldComparisonOp[convCurrEduClsStu_JT.ManagedDepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu_JT.ManagedDepartmentName, objvCurrEduClsStu_JT_Cond.ManagedDepartmentName, strComparisonOp_ManagedDepartmentName);
}
if (objvCurrEduClsStu_JT_Cond.IsUpdated(convCurrEduClsStu_JT.JobCategoryId) == true)
{
string strComparisonOp_JobCategoryId = objvCurrEduClsStu_JT_Cond.dicFldComparisonOp[convCurrEduClsStu_JT.JobCategoryId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu_JT.JobCategoryId, objvCurrEduClsStu_JT_Cond.JobCategoryId, strComparisonOp_JobCategoryId);
}
if (objvCurrEduClsStu_JT_Cond.IsUpdated(convCurrEduClsStu_JT.UserId) == true)
{
string strComparisonOp_UserId = objvCurrEduClsStu_JT_Cond.dicFldComparisonOp[convCurrEduClsStu_JT.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu_JT.UserId, objvCurrEduClsStu_JT_Cond.UserId, strComparisonOp_UserId);
}
if (objvCurrEduClsStu_JT_Cond.IsUpdated(convCurrEduClsStu_JT.JobCategoryName) == true)
{
string strComparisonOp_JobCategoryName = objvCurrEduClsStu_JT_Cond.dicFldComparisonOp[convCurrEduClsStu_JT.JobCategoryName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu_JT.JobCategoryName, objvCurrEduClsStu_JT_Cond.JobCategoryName, strComparisonOp_JobCategoryName);
}
if (objvCurrEduClsStu_JT_Cond.IsUpdated(convCurrEduClsStu_JT.SexDesc) == true)
{
string strComparisonOp_SexDesc = objvCurrEduClsStu_JT_Cond.dicFldComparisonOp[convCurrEduClsStu_JT.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu_JT.SexDesc, objvCurrEduClsStu_JT_Cond.SexDesc, strComparisonOp_SexDesc);
}
if (objvCurrEduClsStu_JT_Cond.IsUpdated(convCurrEduClsStu_JT.Score) == true)
{
string strComparisonOp_Score = objvCurrEduClsStu_JT_Cond.dicFldComparisonOp[convCurrEduClsStu_JT.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsStu_JT.Score, objvCurrEduClsStu_JT_Cond.Score, strComparisonOp_Score);
}
if (objvCurrEduClsStu_JT_Cond.IsUpdated(convCurrEduClsStu_JT.TotalScores) == true)
{
string strComparisonOp_TotalScores = objvCurrEduClsStu_JT_Cond.dicFldComparisonOp[convCurrEduClsStu_JT.TotalScores];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsStu_JT.TotalScores, objvCurrEduClsStu_JT_Cond.TotalScores, strComparisonOp_TotalScores);
}
if (objvCurrEduClsStu_JT_Cond.IsUpdated(convCurrEduClsStu_JT.Ranking) == true)
{
string strComparisonOp_Ranking = objvCurrEduClsStu_JT_Cond.dicFldComparisonOp[convCurrEduClsStu_JT.Ranking];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsStu_JT.Ranking, objvCurrEduClsStu_JT_Cond.Ranking, strComparisonOp_Ranking);
}
if (objvCurrEduClsStu_JT_Cond.IsUpdated(convCurrEduClsStu_JT.Percentile) == true)
{
string strComparisonOp_Percentile = objvCurrEduClsStu_JT_Cond.dicFldComparisonOp[convCurrEduClsStu_JT.Percentile];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsStu_JT.Percentile, objvCurrEduClsStu_JT_Cond.Percentile, strComparisonOp_Percentile);
}
if (objvCurrEduClsStu_JT_Cond.IsUpdated(convCurrEduClsStu_JT.Ranking2) == true)
{
string strComparisonOp_Ranking2 = objvCurrEduClsStu_JT_Cond.dicFldComparisonOp[convCurrEduClsStu_JT.Ranking2];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsStu_JT.Ranking2, objvCurrEduClsStu_JT_Cond.Ranking2, strComparisonOp_Ranking2);
}
if (objvCurrEduClsStu_JT_Cond.IsUpdated(convCurrEduClsStu_JT.Percentile2) == true)
{
string strComparisonOp_Percentile2 = objvCurrEduClsStu_JT_Cond.dicFldComparisonOp[convCurrEduClsStu_JT.Percentile2];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsStu_JT.Percentile2, objvCurrEduClsStu_JT_Cond.Percentile2, strComparisonOp_Percentile2);
}
if (objvCurrEduClsStu_JT_Cond.IsUpdated(convCurrEduClsStu_JT.Ranking3) == true)
{
string strComparisonOp_Ranking3 = objvCurrEduClsStu_JT_Cond.dicFldComparisonOp[convCurrEduClsStu_JT.Ranking3];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsStu_JT.Ranking3, objvCurrEduClsStu_JT_Cond.Ranking3, strComparisonOp_Ranking3);
}
if (objvCurrEduClsStu_JT_Cond.IsUpdated(convCurrEduClsStu_JT.Percentile3) == true)
{
string strComparisonOp_Percentile3 = objvCurrEduClsStu_JT_Cond.dicFldComparisonOp[convCurrEduClsStu_JT.Percentile3];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsStu_JT.Percentile3, objvCurrEduClsStu_JT_Cond.Percentile3, strComparisonOp_Percentile3);
}
if (objvCurrEduClsStu_JT_Cond.IsUpdated(convCurrEduClsStu_JT.SchoolTerm) == true)
{
string strComparisonOp_SchoolTerm = objvCurrEduClsStu_JT_Cond.dicFldComparisonOp[convCurrEduClsStu_JT.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu_JT.SchoolTerm, objvCurrEduClsStu_JT_Cond.SchoolTerm, strComparisonOp_SchoolTerm);
}
if (objvCurrEduClsStu_JT_Cond.IsUpdated(convCurrEduClsStu_JT.SchoolYear) == true)
{
string strComparisonOp_SchoolYear = objvCurrEduClsStu_JT_Cond.dicFldComparisonOp[convCurrEduClsStu_JT.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu_JT.SchoolYear, objvCurrEduClsStu_JT_Cond.SchoolYear, strComparisonOp_SchoolYear);
}
if (objvCurrEduClsStu_JT_Cond.IsUpdated(convCurrEduClsStu_JT.IsSynScore) == true)
{
if (objvCurrEduClsStu_JT_Cond.IsSynScore == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduClsStu_JT.IsSynScore);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduClsStu_JT.IsSynScore);
}
}
if (objvCurrEduClsStu_JT_Cond.IsUpdated(convCurrEduClsStu_JT.ModifyDate) == true)
{
string strComparisonOp_ModifyDate = objvCurrEduClsStu_JT_Cond.dicFldComparisonOp[convCurrEduClsStu_JT.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu_JT.ModifyDate, objvCurrEduClsStu_JT_Cond.ModifyDate, strComparisonOp_ModifyDate);
}
if (objvCurrEduClsStu_JT_Cond.IsUpdated(convCurrEduClsStu_JT.ModifyUserID) == true)
{
string strComparisonOp_ModifyUserID = objvCurrEduClsStu_JT_Cond.dicFldComparisonOp[convCurrEduClsStu_JT.ModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu_JT.ModifyUserID, objvCurrEduClsStu_JT_Cond.ModifyUserID, strComparisonOp_ModifyUserID);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v教学班与学生关系_JT(vCurrEduClsStu_JT)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCurrEduClsStu_JTWApi
{
private static readonly string mstrApiControllerName = "vCurrEduClsStu_JTApi";

 public clsvCurrEduClsStu_JTWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_EduClsStu">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCurrEduClsStu_JTEN GetObjByid_EduClsStu(long lngid_EduClsStu)
{
string strAction = "GetObjByid_EduClsStu";
string strErrMsg = string.Empty;
string strResult = "";
clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN = null;
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
objvCurrEduClsStu_JTEN = JsonConvert.DeserializeObject<clsvCurrEduClsStu_JTEN>((string)jobjReturn["ReturnObj"]);
return objvCurrEduClsStu_JTEN;
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
public static clsvCurrEduClsStu_JTEN GetObjByid_EduClsStu_WA_Cache(long lngid_EduClsStu)
{
string strAction = "GetObjByid_EduClsStu_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN = null;
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
objvCurrEduClsStu_JTEN = JsonConvert.DeserializeObject<clsvCurrEduClsStu_JTEN>((string)jobjReturn["ReturnObj"]);
return objvCurrEduClsStu_JTEN;
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
public static clsvCurrEduClsStu_JTEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTEN = null;
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
objvCurrEduClsStu_JTEN = JsonConvert.DeserializeObject<clsvCurrEduClsStu_JTEN>((string)jobjReturn["ReturnObj"]);
return objvCurrEduClsStu_JTEN;
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
public static clsvCurrEduClsStu_JTEN GetObjByid_EduClsStu_Cache(long lngid_EduClsStu)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCurrEduClsStu_JTEN._CurrTabName_S);
List<clsvCurrEduClsStu_JTEN> arrvCurrEduClsStu_JTObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCurrEduClsStu_JTEN> arrvCurrEduClsStu_JTObjLst_Sel =
from objvCurrEduClsStu_JTEN in arrvCurrEduClsStu_JTObjLst_Cache
where objvCurrEduClsStu_JTEN.id_EduClsStu == lngid_EduClsStu
select objvCurrEduClsStu_JTEN;
if (arrvCurrEduClsStu_JTObjLst_Sel.Count() == 0)
{
   clsvCurrEduClsStu_JTEN obj = clsvCurrEduClsStu_JTWApi.GetObjByid_EduClsStu(lngid_EduClsStu);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCurrEduClsStu_JTObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduClsStu_JTEN> GetObjLst(string strWhereCond)
{
 List<clsvCurrEduClsStu_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsStu_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsStu_JTEN> GetObjLstById_EduClsStuLst(List<long> arrId_EduClsStu)
{
 List<clsvCurrEduClsStu_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsStu_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvCurrEduClsStu_JTEN> GetObjLstById_EduClsStuLst_Cache(List<long> arrId_EduClsStu)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCurrEduClsStu_JTEN._CurrTabName_S);
List<clsvCurrEduClsStu_JTEN> arrvCurrEduClsStu_JTObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCurrEduClsStu_JTEN> arrvCurrEduClsStu_JTObjLst_Sel =
from objvCurrEduClsStu_JTEN in arrvCurrEduClsStu_JTObjLst_Cache
where arrId_EduClsStu.Contains(objvCurrEduClsStu_JTEN.id_EduClsStu)
select objvCurrEduClsStu_JTEN;
return arrvCurrEduClsStu_JTObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduClsStu_JTEN> GetObjLstById_EduClsStuLst_WA_Cache(List<long> arrId_EduClsStu)
{
 List<clsvCurrEduClsStu_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsStu_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsStu_JTEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCurrEduClsStu_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsStu_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsStu_JTEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCurrEduClsStu_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsStu_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsStu_JTEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCurrEduClsStu_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsStu_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsStu_JTEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCurrEduClsStu_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsStu_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvCurrEduClsStu_JTENS">源对象</param>
 /// <param name = "objvCurrEduClsStu_JTENT">目标对象</param>
 public static void CopyTo(clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTENS, clsvCurrEduClsStu_JTEN objvCurrEduClsStu_JTENT)
{
try
{
objvCurrEduClsStu_JTENT.id_EduClsStu = objvCurrEduClsStu_JTENS.id_EduClsStu; //教学班学生流水号
objvCurrEduClsStu_JTENT.id_CurrEduCls = objvCurrEduClsStu_JTENS.id_CurrEduCls; //当前教学班流水号
objvCurrEduClsStu_JTENT.EduClsName = objvCurrEduClsStu_JTENS.EduClsName; //教学班名称
objvCurrEduClsStu_JTENT.CourseId = objvCurrEduClsStu_JTENS.CourseId; //课程Id
objvCurrEduClsStu_JTENT.CourseName = objvCurrEduClsStu_JTENS.CourseName; //课程名称
objvCurrEduClsStu_JTENT.id_Stu = objvCurrEduClsStu_JTENS.id_Stu; //学生流水号
objvCurrEduClsStu_JTENT.StuID = objvCurrEduClsStu_JTENS.StuID; //学号
objvCurrEduClsStu_JTENT.SiteName = objvCurrEduClsStu_JTENS.SiteName; //工地名称
objvCurrEduClsStu_JTENT.StuName = objvCurrEduClsStu_JTENS.StuName; //姓名
objvCurrEduClsStu_JTENT.ManagedDepartmentId = objvCurrEduClsStu_JTENS.ManagedDepartmentId; //管理的部门Id
objvCurrEduClsStu_JTENT.ManagedDepartmentName = objvCurrEduClsStu_JTENS.ManagedDepartmentName; //管理的部门名
objvCurrEduClsStu_JTENT.JobCategoryId = objvCurrEduClsStu_JTENS.JobCategoryId; //岗位类别Id
objvCurrEduClsStu_JTENT.UserId = objvCurrEduClsStu_JTENS.UserId; //用户ID
objvCurrEduClsStu_JTENT.JobCategoryName = objvCurrEduClsStu_JTENS.JobCategoryName; //岗位类别名
objvCurrEduClsStu_JTENT.SexDesc = objvCurrEduClsStu_JTENS.SexDesc; //性别名称
objvCurrEduClsStu_JTENT.Score = objvCurrEduClsStu_JTENS.Score; //得分
objvCurrEduClsStu_JTENT.TotalScores = objvCurrEduClsStu_JTENS.TotalScores; //总分值
objvCurrEduClsStu_JTENT.Ranking = objvCurrEduClsStu_JTENS.Ranking; //名次
objvCurrEduClsStu_JTENT.Percentile = objvCurrEduClsStu_JTENS.Percentile; //百分位
objvCurrEduClsStu_JTENT.Ranking2 = objvCurrEduClsStu_JTENS.Ranking2; //Ranking2
objvCurrEduClsStu_JTENT.Percentile2 = objvCurrEduClsStu_JTENS.Percentile2; //Percentile2
objvCurrEduClsStu_JTENT.Ranking3 = objvCurrEduClsStu_JTENS.Ranking3; //Ranking3
objvCurrEduClsStu_JTENT.Percentile3 = objvCurrEduClsStu_JTENS.Percentile3; //Percentile3
objvCurrEduClsStu_JTENT.SchoolTerm = objvCurrEduClsStu_JTENS.SchoolTerm; //学期
objvCurrEduClsStu_JTENT.SchoolYear = objvCurrEduClsStu_JTENS.SchoolYear; //学年
objvCurrEduClsStu_JTENT.IsSynScore = objvCurrEduClsStu_JTENS.IsSynScore; //是否同步成绩
objvCurrEduClsStu_JTENT.ModifyDate = objvCurrEduClsStu_JTENS.ModifyDate; //修改日期
objvCurrEduClsStu_JTENT.ModifyUserID = objvCurrEduClsStu_JTENS.ModifyUserID; //修改人
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
public static DataTable ToDataTable(List<clsvCurrEduClsStu_JTEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCurrEduClsStu_JTEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCurrEduClsStu_JTEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCurrEduClsStu_JTEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCurrEduClsStu_JTEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCurrEduClsStu_JTEN.AttributeName)
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
if (clsManagedDepartmentWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsManagedDepartmentWApi没有刷新缓存机制(clsManagedDepartmentWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsJobCategoryWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsJobCategoryWApi没有刷新缓存机制(clsJobCategoryWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudentInfo_JTWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfo_JTWApi没有刷新缓存机制(clsStudentInfo_JTWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvCurrEduClsStu_JTObjLst_Cache == null)
//{
//arrvCurrEduClsStu_JTObjLst_Cache = await clsvCurrEduClsStu_JTWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCurrEduClsStu_JTEN._CurrTabName_S);
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
public static List<clsvCurrEduClsStu_JTEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCurrEduClsStu_JTEN._CurrTabName_S);
List<clsvCurrEduClsStu_JTEN> arrvCurrEduClsStu_JTObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCurrEduClsStu_JTObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCurrEduClsStu_JTEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCurrEduClsStu_JT.id_EduClsStu, Type.GetType("System.Int64"));
objDT.Columns.Add(convCurrEduClsStu_JT.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu_JT.EduClsName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu_JT.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu_JT.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu_JT.id_Stu, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu_JT.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu_JT.SiteName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu_JT.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu_JT.ManagedDepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu_JT.ManagedDepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu_JT.JobCategoryId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu_JT.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu_JT.JobCategoryName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu_JT.SexDesc, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu_JT.Score, Type.GetType("System.Decimal"));
objDT.Columns.Add(convCurrEduClsStu_JT.TotalScores, Type.GetType("System.Decimal"));
objDT.Columns.Add(convCurrEduClsStu_JT.Ranking, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduClsStu_JT.Percentile, Type.GetType("System.Decimal"));
objDT.Columns.Add(convCurrEduClsStu_JT.Ranking2, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduClsStu_JT.Percentile2, Type.GetType("System.Decimal"));
objDT.Columns.Add(convCurrEduClsStu_JT.Ranking3, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduClsStu_JT.Percentile3, Type.GetType("System.Decimal"));
objDT.Columns.Add(convCurrEduClsStu_JT.SchoolTerm, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu_JT.SchoolYear, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu_JT.IsSynScore, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduClsStu_JT.ModifyDate, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu_JT.ModifyUserID, Type.GetType("System.String"));
foreach (clsvCurrEduClsStu_JTEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCurrEduClsStu_JT.id_EduClsStu] = objInFor[convCurrEduClsStu_JT.id_EduClsStu];
objDR[convCurrEduClsStu_JT.id_CurrEduCls] = objInFor[convCurrEduClsStu_JT.id_CurrEduCls];
objDR[convCurrEduClsStu_JT.EduClsName] = objInFor[convCurrEduClsStu_JT.EduClsName];
objDR[convCurrEduClsStu_JT.CourseId] = objInFor[convCurrEduClsStu_JT.CourseId];
objDR[convCurrEduClsStu_JT.CourseName] = objInFor[convCurrEduClsStu_JT.CourseName];
objDR[convCurrEduClsStu_JT.id_Stu] = objInFor[convCurrEduClsStu_JT.id_Stu];
objDR[convCurrEduClsStu_JT.StuID] = objInFor[convCurrEduClsStu_JT.StuID];
objDR[convCurrEduClsStu_JT.SiteName] = objInFor[convCurrEduClsStu_JT.SiteName];
objDR[convCurrEduClsStu_JT.StuName] = objInFor[convCurrEduClsStu_JT.StuName];
objDR[convCurrEduClsStu_JT.ManagedDepartmentId] = objInFor[convCurrEduClsStu_JT.ManagedDepartmentId];
objDR[convCurrEduClsStu_JT.ManagedDepartmentName] = objInFor[convCurrEduClsStu_JT.ManagedDepartmentName];
objDR[convCurrEduClsStu_JT.JobCategoryId] = objInFor[convCurrEduClsStu_JT.JobCategoryId];
objDR[convCurrEduClsStu_JT.UserId] = objInFor[convCurrEduClsStu_JT.UserId];
objDR[convCurrEduClsStu_JT.JobCategoryName] = objInFor[convCurrEduClsStu_JT.JobCategoryName];
objDR[convCurrEduClsStu_JT.SexDesc] = objInFor[convCurrEduClsStu_JT.SexDesc];
objDR[convCurrEduClsStu_JT.Score] = objInFor[convCurrEduClsStu_JT.Score];
objDR[convCurrEduClsStu_JT.TotalScores] = objInFor[convCurrEduClsStu_JT.TotalScores];
objDR[convCurrEduClsStu_JT.Ranking] = objInFor[convCurrEduClsStu_JT.Ranking];
objDR[convCurrEduClsStu_JT.Percentile] = objInFor[convCurrEduClsStu_JT.Percentile];
objDR[convCurrEduClsStu_JT.Ranking2] = objInFor[convCurrEduClsStu_JT.Ranking2];
objDR[convCurrEduClsStu_JT.Percentile2] = objInFor[convCurrEduClsStu_JT.Percentile2];
objDR[convCurrEduClsStu_JT.Ranking3] = objInFor[convCurrEduClsStu_JT.Ranking3];
objDR[convCurrEduClsStu_JT.Percentile3] = objInFor[convCurrEduClsStu_JT.Percentile3];
objDR[convCurrEduClsStu_JT.SchoolTerm] = objInFor[convCurrEduClsStu_JT.SchoolTerm];
objDR[convCurrEduClsStu_JT.SchoolYear] = objInFor[convCurrEduClsStu_JT.SchoolYear];
objDR[convCurrEduClsStu_JT.IsSynScore] = objInFor[convCurrEduClsStu_JT.IsSynScore];
objDR[convCurrEduClsStu_JT.ModifyDate] = objInFor[convCurrEduClsStu_JT.ModifyDate];
objDR[convCurrEduClsStu_JT.ModifyUserID] = objInFor[convCurrEduClsStu_JT.ModifyUserID];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}