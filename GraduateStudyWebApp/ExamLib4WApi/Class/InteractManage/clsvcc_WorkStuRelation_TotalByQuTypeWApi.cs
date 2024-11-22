
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkStuRelation_TotalByQuTypeWApi
 表名:vcc_WorkStuRelation_TotalByQuType(01120355)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:45:54
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理
 模块英文名:InteractManage
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
public static class clsvcc_WorkStuRelation_TotalByQuTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetId_WorkStuRelation_Total(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, long lngId_WorkStuRelation_Total, string strComparisonOp="")
	{
objvcc_WorkStuRelation_TotalByQuTypeEN.Id_WorkStuRelation_Total = lngId_WorkStuRelation_Total; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.Id_WorkStuRelation_Total) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.Id_WorkStuRelation_Total, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.Id_WorkStuRelation_Total] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN Setid_CurrEduCls(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CurrEduCls, convcc_WorkStuRelation_TotalByQuType.id_CurrEduCls);
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convcc_WorkStuRelation_TotalByQuType.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convcc_WorkStuRelation_TotalByQuType.id_CurrEduCls);
objvcc_WorkStuRelation_TotalByQuTypeEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.id_CurrEduCls) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.id_CurrEduCls, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.id_CurrEduCls] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetCurrEduClsId(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, string strCurrEduClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, convcc_WorkStuRelation_TotalByQuType.CurrEduClsId);
objvcc_WorkStuRelation_TotalByQuTypeEN.CurrEduClsId = strCurrEduClsId; //当前教学班Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.CurrEduClsId) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.CurrEduClsId, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.CurrEduClsId] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetEduClsName(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduClsName, convcc_WorkStuRelation_TotalByQuType.EduClsName);
clsCheckSql.CheckFieldLen(strEduClsName, 100, convcc_WorkStuRelation_TotalByQuType.EduClsName);
objvcc_WorkStuRelation_TotalByQuTypeEN.EduClsName = strEduClsName; //教学班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.EduClsName) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.EduClsName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.EduClsName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetCourseId(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_WorkStuRelation_TotalByQuType.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_WorkStuRelation_TotalByQuType.CourseId);
objvcc_WorkStuRelation_TotalByQuTypeEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.CourseId) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.CourseId, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.CourseId] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetCourseName(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_WorkStuRelation_TotalByQuType.CourseName);
objvcc_WorkStuRelation_TotalByQuTypeEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.CourseName) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.CourseName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.CourseName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetTeacherID(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, string strTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherID, convcc_WorkStuRelation_TotalByQuType.TeacherID);
clsCheckSql.CheckFieldLen(strTeacherID, 12, convcc_WorkStuRelation_TotalByQuType.TeacherID);
objvcc_WorkStuRelation_TotalByQuTypeEN.TeacherID = strTeacherID; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.TeacherID) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.TeacherID, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.TeacherID] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetTeacherName(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, string strTeacherName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherName, convcc_WorkStuRelation_TotalByQuType.TeacherName);
clsCheckSql.CheckFieldLen(strTeacherName, 50, convcc_WorkStuRelation_TotalByQuType.TeacherName);
objvcc_WorkStuRelation_TotalByQuTypeEN.TeacherName = strTeacherName; //教师姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.TeacherName) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.TeacherName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.TeacherName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN Setid_StudentInfo(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudentInfo, convcc_WorkStuRelation_TotalByQuType.id_StudentInfo);
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, convcc_WorkStuRelation_TotalByQuType.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, convcc_WorkStuRelation_TotalByQuType.id_StudentInfo);
objvcc_WorkStuRelation_TotalByQuTypeEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.id_StudentInfo) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.id_StudentInfo, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.id_StudentInfo] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetStuID(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convcc_WorkStuRelation_TotalByQuType.StuID);
objvcc_WorkStuRelation_TotalByQuTypeEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.StuID) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.StuID, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.StuID] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetStuName(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convcc_WorkStuRelation_TotalByQuType.StuName);
objvcc_WorkStuRelation_TotalByQuTypeEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.StuName) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.StuName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.StuName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN Setid_XzCollege(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convcc_WorkStuRelation_TotalByQuType.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convcc_WorkStuRelation_TotalByQuType.id_XzCollege);
objvcc_WorkStuRelation_TotalByQuTypeEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.id_XzCollege) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.id_XzCollege, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.id_XzCollege] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetCollegeName(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convcc_WorkStuRelation_TotalByQuType.CollegeName);
clsCheckSql.CheckFieldLen(strCollegeName, 100, convcc_WorkStuRelation_TotalByQuType.CollegeName);
objvcc_WorkStuRelation_TotalByQuTypeEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.CollegeName) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.CollegeName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.CollegeName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetCollegeNameA(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convcc_WorkStuRelation_TotalByQuType.CollegeNameA);
objvcc_WorkStuRelation_TotalByQuTypeEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.CollegeNameA) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.CollegeNameA, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.CollegeNameA] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN Setid_XzMajor(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzMajor, convcc_WorkStuRelation_TotalByQuType.id_XzMajor);
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convcc_WorkStuRelation_TotalByQuType.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convcc_WorkStuRelation_TotalByQuType.id_XzMajor);
objvcc_WorkStuRelation_TotalByQuTypeEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.id_XzMajor) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.id_XzMajor, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.id_XzMajor] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetMajorID(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorID, convcc_WorkStuRelation_TotalByQuType.MajorID);
clsCheckSql.CheckFieldLen(strMajorID, 4, convcc_WorkStuRelation_TotalByQuType.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convcc_WorkStuRelation_TotalByQuType.MajorID);
objvcc_WorkStuRelation_TotalByQuTypeEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.MajorID) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.MajorID, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.MajorID] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetMajorName(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorName, convcc_WorkStuRelation_TotalByQuType.MajorName);
clsCheckSql.CheckFieldLen(strMajorName, 100, convcc_WorkStuRelation_TotalByQuType.MajorName);
objvcc_WorkStuRelation_TotalByQuTypeEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.MajorName) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.MajorName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.MajorName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN Setid_GradeBase(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convcc_WorkStuRelation_TotalByQuType.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convcc_WorkStuRelation_TotalByQuType.id_GradeBase);
objvcc_WorkStuRelation_TotalByQuTypeEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.id_GradeBase) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.id_GradeBase, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.id_GradeBase] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetGradeBaseName(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGradeBaseName, convcc_WorkStuRelation_TotalByQuType.GradeBaseName);
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convcc_WorkStuRelation_TotalByQuType.GradeBaseName);
objvcc_WorkStuRelation_TotalByQuTypeEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.GradeBaseName) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.GradeBaseName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.GradeBaseName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetAdminClsName(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, string strAdminClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, convcc_WorkStuRelation_TotalByQuType.AdminClsName);
objvcc_WorkStuRelation_TotalByQuTypeEN.AdminClsName = strAdminClsName; //行政班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.AdminClsName) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.AdminClsName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.AdminClsName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetAdminClsId(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, string strAdminClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, convcc_WorkStuRelation_TotalByQuType.AdminClsId);
objvcc_WorkStuRelation_TotalByQuTypeEN.AdminClsId = strAdminClsId; //行政班代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.AdminClsId) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.AdminClsId, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.AdminClsId] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetQuestionTypeId(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convcc_WorkStuRelation_TotalByQuType.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convcc_WorkStuRelation_TotalByQuType.QuestionTypeId);
objvcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.QuestionTypeId) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.QuestionTypeId, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.QuestionTypeId] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetQuestionTypeName(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, string strQuestionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convcc_WorkStuRelation_TotalByQuType.QuestionTypeName);
objvcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.QuestionTypeName) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.QuestionTypeName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.QuestionTypeName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetQuestionTypeId4Course(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, string strQuestionTypeId4Course, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionTypeId4Course, convcc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course);
clsCheckSql.CheckFieldLen(strQuestionTypeId4Course, 8, convcc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId4Course, 8, convcc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course);
objvcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId4Course = strQuestionTypeId4Course; //题目类型Id4课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetQuestionTypeName4Course(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, string strQuestionTypeName4Course, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionTypeName4Course, convcc_WorkStuRelation_TotalByQuType.QuestionTypeName4Course);
clsCheckSql.CheckFieldLen(strQuestionTypeName4Course, 30, convcc_WorkStuRelation_TotalByQuType.QuestionTypeName4Course);
objvcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeName4Course = strQuestionTypeName4Course; //题目类型名4课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.QuestionTypeName4Course) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.QuestionTypeName4Course, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.QuestionTypeName4Course] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetWorkNum(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, int intWorkNum, string strComparisonOp="")
	{
objvcc_WorkStuRelation_TotalByQuTypeEN.WorkNum = intWorkNum; //作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.WorkNum) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.WorkNum, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.WorkNum] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetWorkNum_Submit(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, int intWorkNum_Submit, string strComparisonOp="")
	{
objvcc_WorkStuRelation_TotalByQuTypeEN.WorkNum_Submit = intWorkNum_Submit; //提交作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.WorkNum_Submit) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.WorkNum_Submit, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.WorkNum_Submit] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetWorkNum_Save(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, int intWorkNum_Save, string strComparisonOp="")
	{
objvcc_WorkStuRelation_TotalByQuTypeEN.WorkNum_Save = intWorkNum_Save; //保存作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.WorkNum_Save) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.WorkNum_Save, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.WorkNum_Save] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetWorkNum_NoFinish(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, int intWorkNum_NoFinish, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intWorkNum_NoFinish, convcc_WorkStuRelation_TotalByQuType.WorkNum_NoFinish);
objvcc_WorkStuRelation_TotalByQuTypeEN.WorkNum_NoFinish = intWorkNum_NoFinish; //未完成作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.WorkNum_NoFinish) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.WorkNum_NoFinish, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.WorkNum_NoFinish] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetWorkNum_SendBack(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, int intWorkNum_SendBack, string strComparisonOp="")
	{
objvcc_WorkStuRelation_TotalByQuTypeEN.WorkNum_SendBack = intWorkNum_SendBack; //退回作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.WorkNum_SendBack) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.WorkNum_SendBack, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.WorkNum_SendBack] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetWorkNum_Mark(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, int intWorkNum_Mark, string strComparisonOp="")
	{
objvcc_WorkStuRelation_TotalByQuTypeEN.WorkNum_Mark = intWorkNum_Mark; //批改作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.WorkNum_Mark) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.WorkNum_Mark, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.WorkNum_Mark] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetWorkNum_Look(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, int intWorkNum_Look, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intWorkNum_Look, convcc_WorkStuRelation_TotalByQuType.WorkNum_Look);
objvcc_WorkStuRelation_TotalByQuTypeEN.WorkNum_Look = intWorkNum_Look; //查看作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.WorkNum_Look) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.WorkNum_Look, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.WorkNum_Look] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetWorkNum_Overdue(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, int intWorkNum_Overdue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intWorkNum_Overdue, convcc_WorkStuRelation_TotalByQuType.WorkNum_Overdue);
objvcc_WorkStuRelation_TotalByQuTypeEN.WorkNum_Overdue = intWorkNum_Overdue; //逾期作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.WorkNum_Overdue) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.WorkNum_Overdue, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.WorkNum_Overdue] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetTotalScore(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, double dblTotalScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dblTotalScore, convcc_WorkStuRelation_TotalByQuType.TotalScore);
objvcc_WorkStuRelation_TotalByQuTypeEN.TotalScore = dblTotalScore; //总得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.TotalScore) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.TotalScore, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.TotalScore] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetTotalScores(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, double dblTotalScores, string strComparisonOp="")
	{
objvcc_WorkStuRelation_TotalByQuTypeEN.TotalScores = dblTotalScores; //总分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.TotalScores) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.TotalScores, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.TotalScores] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetSchoolYear(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, string strSchoolYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, convcc_WorkStuRelation_TotalByQuType.SchoolYear);
objvcc_WorkStuRelation_TotalByQuTypeEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.SchoolYear) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.SchoolYear, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.SchoolYear] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetSchoolTerm(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, convcc_WorkStuRelation_TotalByQuType.SchoolTerm);
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, convcc_WorkStuRelation_TotalByQuType.SchoolTerm);
objvcc_WorkStuRelation_TotalByQuTypeEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.SchoolTerm) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.SchoolTerm, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.SchoolTerm] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetUpdDate(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_WorkStuRelation_TotalByQuType.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_WorkStuRelation_TotalByQuType.UpdDate);
objvcc_WorkStuRelation_TotalByQuTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.UpdDate) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.UpdDate, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.UpdDate] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetUpdUserId(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_WorkStuRelation_TotalByQuType.UpdUserId);
objvcc_WorkStuRelation_TotalByQuTypeEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.UpdUserId) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.UpdUserId, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.UpdUserId] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN SetMemo(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_WorkStuRelation_TotalByQuType.Memo);
objvcc_WorkStuRelation_TotalByQuTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_TotalByQuType.Memo) == false)
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_TotalByQuType.Memo, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.Memo] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalByQuTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuType_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.Id_WorkStuRelation_Total) == true)
{
string strComparisonOp_Id_WorkStuRelation_Total = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.Id_WorkStuRelation_Total];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation_TotalByQuType.Id_WorkStuRelation_Total, objvcc_WorkStuRelation_TotalByQuType_Cond.Id_WorkStuRelation_Total, strComparisonOp_Id_WorkStuRelation_Total);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_TotalByQuType.id_CurrEduCls, objvcc_WorkStuRelation_TotalByQuType_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.CurrEduClsId) == true)
{
string strComparisonOp_CurrEduClsId = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_TotalByQuType.CurrEduClsId, objvcc_WorkStuRelation_TotalByQuType_Cond.CurrEduClsId, strComparisonOp_CurrEduClsId);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.EduClsName) == true)
{
string strComparisonOp_EduClsName = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_TotalByQuType.EduClsName, objvcc_WorkStuRelation_TotalByQuType_Cond.EduClsName, strComparisonOp_EduClsName);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_TotalByQuType.CourseId, objvcc_WorkStuRelation_TotalByQuType_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_TotalByQuType.CourseName, objvcc_WorkStuRelation_TotalByQuType_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.TeacherID) == true)
{
string strComparisonOp_TeacherID = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_TotalByQuType.TeacherID, objvcc_WorkStuRelation_TotalByQuType_Cond.TeacherID, strComparisonOp_TeacherID);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.TeacherName) == true)
{
string strComparisonOp_TeacherName = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.TeacherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_TotalByQuType.TeacherName, objvcc_WorkStuRelation_TotalByQuType_Cond.TeacherName, strComparisonOp_TeacherName);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_TotalByQuType.id_StudentInfo, objvcc_WorkStuRelation_TotalByQuType_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.StuID) == true)
{
string strComparisonOp_StuID = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_TotalByQuType.StuID, objvcc_WorkStuRelation_TotalByQuType_Cond.StuID, strComparisonOp_StuID);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.StuName) == true)
{
string strComparisonOp_StuName = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_TotalByQuType.StuName, objvcc_WorkStuRelation_TotalByQuType_Cond.StuName, strComparisonOp_StuName);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_TotalByQuType.id_XzCollege, objvcc_WorkStuRelation_TotalByQuType_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_TotalByQuType.CollegeName, objvcc_WorkStuRelation_TotalByQuType_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_TotalByQuType.CollegeNameA, objvcc_WorkStuRelation_TotalByQuType_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_TotalByQuType.id_XzMajor, objvcc_WorkStuRelation_TotalByQuType_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.MajorID) == true)
{
string strComparisonOp_MajorID = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_TotalByQuType.MajorID, objvcc_WorkStuRelation_TotalByQuType_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.MajorName) == true)
{
string strComparisonOp_MajorName = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_TotalByQuType.MajorName, objvcc_WorkStuRelation_TotalByQuType_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_TotalByQuType.id_GradeBase, objvcc_WorkStuRelation_TotalByQuType_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_TotalByQuType.GradeBaseName, objvcc_WorkStuRelation_TotalByQuType_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.AdminClsName) == true)
{
string strComparisonOp_AdminClsName = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_TotalByQuType.AdminClsName, objvcc_WorkStuRelation_TotalByQuType_Cond.AdminClsName, strComparisonOp_AdminClsName);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.AdminClsId) == true)
{
string strComparisonOp_AdminClsId = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_TotalByQuType.AdminClsId, objvcc_WorkStuRelation_TotalByQuType_Cond.AdminClsId, strComparisonOp_AdminClsId);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_TotalByQuType.QuestionTypeId, objvcc_WorkStuRelation_TotalByQuType_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.QuestionTypeName) == true)
{
string strComparisonOp_QuestionTypeName = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_TotalByQuType.QuestionTypeName, objvcc_WorkStuRelation_TotalByQuType_Cond.QuestionTypeName, strComparisonOp_QuestionTypeName);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course) == true)
{
string strComparisonOp_QuestionTypeId4Course = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course, objvcc_WorkStuRelation_TotalByQuType_Cond.QuestionTypeId4Course, strComparisonOp_QuestionTypeId4Course);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.QuestionTypeName4Course) == true)
{
string strComparisonOp_QuestionTypeName4Course = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.QuestionTypeName4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_TotalByQuType.QuestionTypeName4Course, objvcc_WorkStuRelation_TotalByQuType_Cond.QuestionTypeName4Course, strComparisonOp_QuestionTypeName4Course);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.WorkNum) == true)
{
string strComparisonOp_WorkNum = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.WorkNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation_TotalByQuType.WorkNum, objvcc_WorkStuRelation_TotalByQuType_Cond.WorkNum, strComparisonOp_WorkNum);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.WorkNum_Submit) == true)
{
string strComparisonOp_WorkNum_Submit = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.WorkNum_Submit];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation_TotalByQuType.WorkNum_Submit, objvcc_WorkStuRelation_TotalByQuType_Cond.WorkNum_Submit, strComparisonOp_WorkNum_Submit);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.WorkNum_Save) == true)
{
string strComparisonOp_WorkNum_Save = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.WorkNum_Save];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation_TotalByQuType.WorkNum_Save, objvcc_WorkStuRelation_TotalByQuType_Cond.WorkNum_Save, strComparisonOp_WorkNum_Save);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.WorkNum_NoFinish) == true)
{
string strComparisonOp_WorkNum_NoFinish = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.WorkNum_NoFinish];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation_TotalByQuType.WorkNum_NoFinish, objvcc_WorkStuRelation_TotalByQuType_Cond.WorkNum_NoFinish, strComparisonOp_WorkNum_NoFinish);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.WorkNum_SendBack) == true)
{
string strComparisonOp_WorkNum_SendBack = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.WorkNum_SendBack];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation_TotalByQuType.WorkNum_SendBack, objvcc_WorkStuRelation_TotalByQuType_Cond.WorkNum_SendBack, strComparisonOp_WorkNum_SendBack);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.WorkNum_Mark) == true)
{
string strComparisonOp_WorkNum_Mark = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.WorkNum_Mark];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation_TotalByQuType.WorkNum_Mark, objvcc_WorkStuRelation_TotalByQuType_Cond.WorkNum_Mark, strComparisonOp_WorkNum_Mark);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.WorkNum_Look) == true)
{
string strComparisonOp_WorkNum_Look = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.WorkNum_Look];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation_TotalByQuType.WorkNum_Look, objvcc_WorkStuRelation_TotalByQuType_Cond.WorkNum_Look, strComparisonOp_WorkNum_Look);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.WorkNum_Overdue) == true)
{
string strComparisonOp_WorkNum_Overdue = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.WorkNum_Overdue];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation_TotalByQuType.WorkNum_Overdue, objvcc_WorkStuRelation_TotalByQuType_Cond.WorkNum_Overdue, strComparisonOp_WorkNum_Overdue);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.TotalScore) == true)
{
string strComparisonOp_TotalScore = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.TotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation_TotalByQuType.TotalScore, objvcc_WorkStuRelation_TotalByQuType_Cond.TotalScore, strComparisonOp_TotalScore);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.TotalScores) == true)
{
string strComparisonOp_TotalScores = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.TotalScores];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation_TotalByQuType.TotalScores, objvcc_WorkStuRelation_TotalByQuType_Cond.TotalScores, strComparisonOp_TotalScores);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.SchoolYear) == true)
{
string strComparisonOp_SchoolYear = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_TotalByQuType.SchoolYear, objvcc_WorkStuRelation_TotalByQuType_Cond.SchoolYear, strComparisonOp_SchoolYear);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.SchoolTerm) == true)
{
string strComparisonOp_SchoolTerm = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_TotalByQuType.SchoolTerm, objvcc_WorkStuRelation_TotalByQuType_Cond.SchoolTerm, strComparisonOp_SchoolTerm);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_TotalByQuType.UpdDate, objvcc_WorkStuRelation_TotalByQuType_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_TotalByQuType.UpdUserId, objvcc_WorkStuRelation_TotalByQuType_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvcc_WorkStuRelation_TotalByQuType_Cond.IsUpdated(convcc_WorkStuRelation_TotalByQuType.Memo) == true)
{
string strComparisonOp_Memo = objvcc_WorkStuRelation_TotalByQuType_Cond.dicFldComparisonOp[convcc_WorkStuRelation_TotalByQuType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_TotalByQuType.Memo, objvcc_WorkStuRelation_TotalByQuType_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v作业完成情况汇总表ByQuType(vcc_WorkStuRelation_TotalByQuType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_WorkStuRelation_TotalByQuTypeWApi
{
private static readonly string mstrApiControllerName = "vcc_WorkStuRelation_TotalByQuTypeApi";

 public clsvcc_WorkStuRelation_TotalByQuTypeWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_WorkStuRelation_Total">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN GetObjById_WorkStuRelation_Total(long lngId_WorkStuRelation_Total)
{
string strAction = "GetObjById_WorkStuRelation_Total";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_WorkStuRelation_Total"] = lngId_WorkStuRelation_Total.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_WorkStuRelation_TotalByQuTypeEN = JsonConvert.DeserializeObject<clsvcc_WorkStuRelation_TotalByQuTypeEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkStuRelation_TotalByQuTypeEN;
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
 /// <param name = "lngId_WorkStuRelation_Total">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN GetObjById_WorkStuRelation_Total_WA_Cache(long lngId_WorkStuRelation_Total)
{
string strAction = "GetObjById_WorkStuRelation_Total_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_WorkStuRelation_Total"] = lngId_WorkStuRelation_Total.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_WorkStuRelation_TotalByQuTypeEN = JsonConvert.DeserializeObject<clsvcc_WorkStuRelation_TotalByQuTypeEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkStuRelation_TotalByQuTypeEN;
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
public static clsvcc_WorkStuRelation_TotalByQuTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeEN = null;
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
objvcc_WorkStuRelation_TotalByQuTypeEN = JsonConvert.DeserializeObject<clsvcc_WorkStuRelation_TotalByQuTypeEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkStuRelation_TotalByQuTypeEN;
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
 /// <param name = "lngId_WorkStuRelation_Total">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_WorkStuRelation_TotalByQuTypeEN GetObjById_WorkStuRelation_Total_Cache(long lngId_WorkStuRelation_Total)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_WorkStuRelation_TotalByQuTypeEN._CurrTabName_S);
List<clsvcc_WorkStuRelation_TotalByQuTypeEN> arrvcc_WorkStuRelation_TotalByQuTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_WorkStuRelation_TotalByQuTypeEN> arrvcc_WorkStuRelation_TotalByQuTypeObjLst_Sel =
from objvcc_WorkStuRelation_TotalByQuTypeEN in arrvcc_WorkStuRelation_TotalByQuTypeObjLst_Cache
where objvcc_WorkStuRelation_TotalByQuTypeEN.Id_WorkStuRelation_Total == lngId_WorkStuRelation_Total
select objvcc_WorkStuRelation_TotalByQuTypeEN;
if (arrvcc_WorkStuRelation_TotalByQuTypeObjLst_Sel.Count() == 0)
{
   clsvcc_WorkStuRelation_TotalByQuTypeEN obj = clsvcc_WorkStuRelation_TotalByQuTypeWApi.GetObjById_WorkStuRelation_Total(lngId_WorkStuRelation_Total);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_WorkStuRelation_TotalByQuTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelation_TotalByQuTypeEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_WorkStuRelation_TotalByQuTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation_TotalByQuTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelation_TotalByQuTypeEN> GetObjLstById_WorkStuRelation_TotalLst(List<long> arrId_WorkStuRelation_Total)
{
 List<clsvcc_WorkStuRelation_TotalByQuTypeEN> arrObjLst = null; 
string strAction = "GetObjLstById_WorkStuRelation_TotalLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_WorkStuRelation_Total);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation_TotalByQuTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngId_WorkStuRelation_Total">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvcc_WorkStuRelation_TotalByQuTypeEN> GetObjLstById_WorkStuRelation_TotalLst_Cache(List<long> arrId_WorkStuRelation_Total)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_WorkStuRelation_TotalByQuTypeEN._CurrTabName_S);
List<clsvcc_WorkStuRelation_TotalByQuTypeEN> arrvcc_WorkStuRelation_TotalByQuTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_WorkStuRelation_TotalByQuTypeEN> arrvcc_WorkStuRelation_TotalByQuTypeObjLst_Sel =
from objvcc_WorkStuRelation_TotalByQuTypeEN in arrvcc_WorkStuRelation_TotalByQuTypeObjLst_Cache
where arrId_WorkStuRelation_Total.Contains(objvcc_WorkStuRelation_TotalByQuTypeEN.Id_WorkStuRelation_Total)
select objvcc_WorkStuRelation_TotalByQuTypeEN;
return arrvcc_WorkStuRelation_TotalByQuTypeObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelation_TotalByQuTypeEN> GetObjLstById_WorkStuRelation_TotalLst_WA_Cache(List<long> arrId_WorkStuRelation_Total)
{
 List<clsvcc_WorkStuRelation_TotalByQuTypeEN> arrObjLst = null; 
string strAction = "GetObjLstById_WorkStuRelation_TotalLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_WorkStuRelation_Total);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation_TotalByQuTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelation_TotalByQuTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_WorkStuRelation_TotalByQuTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation_TotalByQuTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelation_TotalByQuTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_WorkStuRelation_TotalByQuTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation_TotalByQuTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelation_TotalByQuTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_WorkStuRelation_TotalByQuTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation_TotalByQuTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelation_TotalByQuTypeEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_WorkStuRelation_TotalByQuTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation_TotalByQuTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngId_WorkStuRelation_Total)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_WorkStuRelation_Total"] = lngId_WorkStuRelation_Total.ToString()
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
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeENS">源对象</param>
 /// <param name = "objvcc_WorkStuRelation_TotalByQuTypeENT">目标对象</param>
 public static void CopyTo(clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeENS, clsvcc_WorkStuRelation_TotalByQuTypeEN objvcc_WorkStuRelation_TotalByQuTypeENT)
{
try
{
objvcc_WorkStuRelation_TotalByQuTypeENT.Id_WorkStuRelation_Total = objvcc_WorkStuRelation_TotalByQuTypeENS.Id_WorkStuRelation_Total; //流水号
objvcc_WorkStuRelation_TotalByQuTypeENT.id_CurrEduCls = objvcc_WorkStuRelation_TotalByQuTypeENS.id_CurrEduCls; //当前教学班流水号
objvcc_WorkStuRelation_TotalByQuTypeENT.CurrEduClsId = objvcc_WorkStuRelation_TotalByQuTypeENS.CurrEduClsId; //当前教学班Id
objvcc_WorkStuRelation_TotalByQuTypeENT.EduClsName = objvcc_WorkStuRelation_TotalByQuTypeENS.EduClsName; //教学班名称
objvcc_WorkStuRelation_TotalByQuTypeENT.CourseId = objvcc_WorkStuRelation_TotalByQuTypeENS.CourseId; //课程Id
objvcc_WorkStuRelation_TotalByQuTypeENT.CourseName = objvcc_WorkStuRelation_TotalByQuTypeENS.CourseName; //课程名称
objvcc_WorkStuRelation_TotalByQuTypeENT.TeacherID = objvcc_WorkStuRelation_TotalByQuTypeENS.TeacherID; //教师工号
objvcc_WorkStuRelation_TotalByQuTypeENT.TeacherName = objvcc_WorkStuRelation_TotalByQuTypeENS.TeacherName; //教师姓名
objvcc_WorkStuRelation_TotalByQuTypeENT.id_StudentInfo = objvcc_WorkStuRelation_TotalByQuTypeENS.id_StudentInfo; //学生流水号
objvcc_WorkStuRelation_TotalByQuTypeENT.StuID = objvcc_WorkStuRelation_TotalByQuTypeENS.StuID; //学号
objvcc_WorkStuRelation_TotalByQuTypeENT.StuName = objvcc_WorkStuRelation_TotalByQuTypeENS.StuName; //姓名
objvcc_WorkStuRelation_TotalByQuTypeENT.id_XzCollege = objvcc_WorkStuRelation_TotalByQuTypeENS.id_XzCollege; //学院流水号
objvcc_WorkStuRelation_TotalByQuTypeENT.CollegeName = objvcc_WorkStuRelation_TotalByQuTypeENS.CollegeName; //学院名称
objvcc_WorkStuRelation_TotalByQuTypeENT.CollegeNameA = objvcc_WorkStuRelation_TotalByQuTypeENS.CollegeNameA; //学院名称简写
objvcc_WorkStuRelation_TotalByQuTypeENT.id_XzMajor = objvcc_WorkStuRelation_TotalByQuTypeENS.id_XzMajor; //专业流水号
objvcc_WorkStuRelation_TotalByQuTypeENT.MajorID = objvcc_WorkStuRelation_TotalByQuTypeENS.MajorID; //专业ID
objvcc_WorkStuRelation_TotalByQuTypeENT.MajorName = objvcc_WorkStuRelation_TotalByQuTypeENS.MajorName; //专业名称
objvcc_WorkStuRelation_TotalByQuTypeENT.id_GradeBase = objvcc_WorkStuRelation_TotalByQuTypeENS.id_GradeBase; //年级流水号
objvcc_WorkStuRelation_TotalByQuTypeENT.GradeBaseName = objvcc_WorkStuRelation_TotalByQuTypeENS.GradeBaseName; //年级名称
objvcc_WorkStuRelation_TotalByQuTypeENT.AdminClsName = objvcc_WorkStuRelation_TotalByQuTypeENS.AdminClsName; //行政班名称
objvcc_WorkStuRelation_TotalByQuTypeENT.AdminClsId = objvcc_WorkStuRelation_TotalByQuTypeENS.AdminClsId; //行政班代号
objvcc_WorkStuRelation_TotalByQuTypeENT.QuestionTypeId = objvcc_WorkStuRelation_TotalByQuTypeENS.QuestionTypeId; //题目类型Id
objvcc_WorkStuRelation_TotalByQuTypeENT.QuestionTypeName = objvcc_WorkStuRelation_TotalByQuTypeENS.QuestionTypeName; //题目类型名
objvcc_WorkStuRelation_TotalByQuTypeENT.QuestionTypeId4Course = objvcc_WorkStuRelation_TotalByQuTypeENS.QuestionTypeId4Course; //题目类型Id4课程
objvcc_WorkStuRelation_TotalByQuTypeENT.QuestionTypeName4Course = objvcc_WorkStuRelation_TotalByQuTypeENS.QuestionTypeName4Course; //题目类型名4课程
objvcc_WorkStuRelation_TotalByQuTypeENT.WorkNum = objvcc_WorkStuRelation_TotalByQuTypeENS.WorkNum; //作业数
objvcc_WorkStuRelation_TotalByQuTypeENT.WorkNum_Submit = objvcc_WorkStuRelation_TotalByQuTypeENS.WorkNum_Submit; //提交作业数
objvcc_WorkStuRelation_TotalByQuTypeENT.WorkNum_Save = objvcc_WorkStuRelation_TotalByQuTypeENS.WorkNum_Save; //保存作业数
objvcc_WorkStuRelation_TotalByQuTypeENT.WorkNum_NoFinish = objvcc_WorkStuRelation_TotalByQuTypeENS.WorkNum_NoFinish; //未完成作业数
objvcc_WorkStuRelation_TotalByQuTypeENT.WorkNum_SendBack = objvcc_WorkStuRelation_TotalByQuTypeENS.WorkNum_SendBack; //退回作业数
objvcc_WorkStuRelation_TotalByQuTypeENT.WorkNum_Mark = objvcc_WorkStuRelation_TotalByQuTypeENS.WorkNum_Mark; //批改作业数
objvcc_WorkStuRelation_TotalByQuTypeENT.WorkNum_Look = objvcc_WorkStuRelation_TotalByQuTypeENS.WorkNum_Look; //查看作业数
objvcc_WorkStuRelation_TotalByQuTypeENT.WorkNum_Overdue = objvcc_WorkStuRelation_TotalByQuTypeENS.WorkNum_Overdue; //逾期作业数
objvcc_WorkStuRelation_TotalByQuTypeENT.TotalScore = objvcc_WorkStuRelation_TotalByQuTypeENS.TotalScore; //总得分
objvcc_WorkStuRelation_TotalByQuTypeENT.TotalScores = objvcc_WorkStuRelation_TotalByQuTypeENS.TotalScores; //总分值
objvcc_WorkStuRelation_TotalByQuTypeENT.SchoolYear = objvcc_WorkStuRelation_TotalByQuTypeENS.SchoolYear; //学年
objvcc_WorkStuRelation_TotalByQuTypeENT.SchoolTerm = objvcc_WorkStuRelation_TotalByQuTypeENS.SchoolTerm; //学期
objvcc_WorkStuRelation_TotalByQuTypeENT.UpdDate = objvcc_WorkStuRelation_TotalByQuTypeENS.UpdDate; //修改日期
objvcc_WorkStuRelation_TotalByQuTypeENT.UpdUserId = objvcc_WorkStuRelation_TotalByQuTypeENS.UpdUserId; //修改用户Id
objvcc_WorkStuRelation_TotalByQuTypeENT.Memo = objvcc_WorkStuRelation_TotalByQuTypeENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvcc_WorkStuRelation_TotalByQuTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_WorkStuRelation_TotalByQuTypeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_WorkStuRelation_TotalByQuTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_WorkStuRelation_TotalByQuTypeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_WorkStuRelation_TotalByQuTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_WorkStuRelation_TotalByQuTypeEN.AttributeName)
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
if (clsQuestionTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeWApi没有刷新缓存机制(clsQuestionTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionType4CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionType4CourseWApi没有刷新缓存机制(clsQuestionType4CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_WorkStuRelation_TotalByQuTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkStuRelation_TotalByQuTypeWApi没有刷新缓存机制(clscc_WorkStuRelation_TotalByQuTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by Id_WorkStuRelation_Total");
//if (arrvcc_WorkStuRelation_TotalByQuTypeObjLst_Cache == null)
//{
//arrvcc_WorkStuRelation_TotalByQuTypeObjLst_Cache = await clsvcc_WorkStuRelation_TotalByQuTypeWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvcc_WorkStuRelation_TotalByQuTypeEN._CurrTabName_S);
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
public static List<clsvcc_WorkStuRelation_TotalByQuTypeEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvcc_WorkStuRelation_TotalByQuTypeEN._CurrTabName_S);
List<clsvcc_WorkStuRelation_TotalByQuTypeEN> arrvcc_WorkStuRelation_TotalByQuTypeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_WorkStuRelation_TotalByQuTypeObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_WorkStuRelation_TotalByQuTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.Id_WorkStuRelation_Total, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.CurrEduClsId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.EduClsName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.TeacherID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.TeacherName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.AdminClsName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.AdminClsId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.QuestionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.QuestionTypeName4Course, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.WorkNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.WorkNum_Submit, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.WorkNum_Save, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.WorkNum_NoFinish, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.WorkNum_SendBack, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.WorkNum_Mark, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.WorkNum_Look, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.WorkNum_Overdue, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.TotalScore, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.TotalScores, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.SchoolYear, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.SchoolTerm, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_TotalByQuType.Memo, Type.GetType("System.String"));
foreach (clsvcc_WorkStuRelation_TotalByQuTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_WorkStuRelation_TotalByQuType.Id_WorkStuRelation_Total] = objInFor[convcc_WorkStuRelation_TotalByQuType.Id_WorkStuRelation_Total];
objDR[convcc_WorkStuRelation_TotalByQuType.id_CurrEduCls] = objInFor[convcc_WorkStuRelation_TotalByQuType.id_CurrEduCls];
objDR[convcc_WorkStuRelation_TotalByQuType.CurrEduClsId] = objInFor[convcc_WorkStuRelation_TotalByQuType.CurrEduClsId];
objDR[convcc_WorkStuRelation_TotalByQuType.EduClsName] = objInFor[convcc_WorkStuRelation_TotalByQuType.EduClsName];
objDR[convcc_WorkStuRelation_TotalByQuType.CourseId] = objInFor[convcc_WorkStuRelation_TotalByQuType.CourseId];
objDR[convcc_WorkStuRelation_TotalByQuType.CourseName] = objInFor[convcc_WorkStuRelation_TotalByQuType.CourseName];
objDR[convcc_WorkStuRelation_TotalByQuType.TeacherID] = objInFor[convcc_WorkStuRelation_TotalByQuType.TeacherID];
objDR[convcc_WorkStuRelation_TotalByQuType.TeacherName] = objInFor[convcc_WorkStuRelation_TotalByQuType.TeacherName];
objDR[convcc_WorkStuRelation_TotalByQuType.id_StudentInfo] = objInFor[convcc_WorkStuRelation_TotalByQuType.id_StudentInfo];
objDR[convcc_WorkStuRelation_TotalByQuType.StuID] = objInFor[convcc_WorkStuRelation_TotalByQuType.StuID];
objDR[convcc_WorkStuRelation_TotalByQuType.StuName] = objInFor[convcc_WorkStuRelation_TotalByQuType.StuName];
objDR[convcc_WorkStuRelation_TotalByQuType.id_XzCollege] = objInFor[convcc_WorkStuRelation_TotalByQuType.id_XzCollege];
objDR[convcc_WorkStuRelation_TotalByQuType.CollegeName] = objInFor[convcc_WorkStuRelation_TotalByQuType.CollegeName];
objDR[convcc_WorkStuRelation_TotalByQuType.CollegeNameA] = objInFor[convcc_WorkStuRelation_TotalByQuType.CollegeNameA];
objDR[convcc_WorkStuRelation_TotalByQuType.id_XzMajor] = objInFor[convcc_WorkStuRelation_TotalByQuType.id_XzMajor];
objDR[convcc_WorkStuRelation_TotalByQuType.MajorID] = objInFor[convcc_WorkStuRelation_TotalByQuType.MajorID];
objDR[convcc_WorkStuRelation_TotalByQuType.MajorName] = objInFor[convcc_WorkStuRelation_TotalByQuType.MajorName];
objDR[convcc_WorkStuRelation_TotalByQuType.id_GradeBase] = objInFor[convcc_WorkStuRelation_TotalByQuType.id_GradeBase];
objDR[convcc_WorkStuRelation_TotalByQuType.GradeBaseName] = objInFor[convcc_WorkStuRelation_TotalByQuType.GradeBaseName];
objDR[convcc_WorkStuRelation_TotalByQuType.AdminClsName] = objInFor[convcc_WorkStuRelation_TotalByQuType.AdminClsName];
objDR[convcc_WorkStuRelation_TotalByQuType.AdminClsId] = objInFor[convcc_WorkStuRelation_TotalByQuType.AdminClsId];
objDR[convcc_WorkStuRelation_TotalByQuType.QuestionTypeId] = objInFor[convcc_WorkStuRelation_TotalByQuType.QuestionTypeId];
objDR[convcc_WorkStuRelation_TotalByQuType.QuestionTypeName] = objInFor[convcc_WorkStuRelation_TotalByQuType.QuestionTypeName];
objDR[convcc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course] = objInFor[convcc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course];
objDR[convcc_WorkStuRelation_TotalByQuType.QuestionTypeName4Course] = objInFor[convcc_WorkStuRelation_TotalByQuType.QuestionTypeName4Course];
objDR[convcc_WorkStuRelation_TotalByQuType.WorkNum] = objInFor[convcc_WorkStuRelation_TotalByQuType.WorkNum];
objDR[convcc_WorkStuRelation_TotalByQuType.WorkNum_Submit] = objInFor[convcc_WorkStuRelation_TotalByQuType.WorkNum_Submit];
objDR[convcc_WorkStuRelation_TotalByQuType.WorkNum_Save] = objInFor[convcc_WorkStuRelation_TotalByQuType.WorkNum_Save];
objDR[convcc_WorkStuRelation_TotalByQuType.WorkNum_NoFinish] = objInFor[convcc_WorkStuRelation_TotalByQuType.WorkNum_NoFinish];
objDR[convcc_WorkStuRelation_TotalByQuType.WorkNum_SendBack] = objInFor[convcc_WorkStuRelation_TotalByQuType.WorkNum_SendBack];
objDR[convcc_WorkStuRelation_TotalByQuType.WorkNum_Mark] = objInFor[convcc_WorkStuRelation_TotalByQuType.WorkNum_Mark];
objDR[convcc_WorkStuRelation_TotalByQuType.WorkNum_Look] = objInFor[convcc_WorkStuRelation_TotalByQuType.WorkNum_Look];
objDR[convcc_WorkStuRelation_TotalByQuType.WorkNum_Overdue] = objInFor[convcc_WorkStuRelation_TotalByQuType.WorkNum_Overdue];
objDR[convcc_WorkStuRelation_TotalByQuType.TotalScore] = objInFor[convcc_WorkStuRelation_TotalByQuType.TotalScore];
objDR[convcc_WorkStuRelation_TotalByQuType.TotalScores] = objInFor[convcc_WorkStuRelation_TotalByQuType.TotalScores];
objDR[convcc_WorkStuRelation_TotalByQuType.SchoolYear] = objInFor[convcc_WorkStuRelation_TotalByQuType.SchoolYear];
objDR[convcc_WorkStuRelation_TotalByQuType.SchoolTerm] = objInFor[convcc_WorkStuRelation_TotalByQuType.SchoolTerm];
objDR[convcc_WorkStuRelation_TotalByQuType.UpdDate] = objInFor[convcc_WorkStuRelation_TotalByQuType.UpdDate];
objDR[convcc_WorkStuRelation_TotalByQuType.UpdUserId] = objInFor[convcc_WorkStuRelation_TotalByQuType.UpdUserId];
objDR[convcc_WorkStuRelation_TotalByQuType.Memo] = objInFor[convcc_WorkStuRelation_TotalByQuType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}