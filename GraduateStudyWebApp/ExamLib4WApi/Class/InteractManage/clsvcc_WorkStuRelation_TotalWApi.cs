
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkStuRelation_TotalWApi
 表名:vcc_WorkStuRelation_Total(01120168)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:50:08
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
public static class clsvcc_WorkStuRelation_TotalWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetId_WorkStuRelation_Total(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, long lngId_WorkStuRelation_Total, string strComparisonOp="")
	{
objvcc_WorkStuRelation_TotalEN.Id_WorkStuRelation_Total = lngId_WorkStuRelation_Total; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.Id_WorkStuRelation_Total) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.Id_WorkStuRelation_Total, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.Id_WorkStuRelation_Total] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN Setid_CurrEduCls(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CurrEduCls, convcc_WorkStuRelation_Total.id_CurrEduCls);
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convcc_WorkStuRelation_Total.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convcc_WorkStuRelation_Total.id_CurrEduCls);
objvcc_WorkStuRelation_TotalEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.id_CurrEduCls) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.id_CurrEduCls, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.id_CurrEduCls] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetCurrEduClsId(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, string strCurrEduClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, convcc_WorkStuRelation_Total.CurrEduClsId);
objvcc_WorkStuRelation_TotalEN.CurrEduClsId = strCurrEduClsId; //当前教学班Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.CurrEduClsId) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.CurrEduClsId, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.CurrEduClsId] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetEduClsName(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduClsName, convcc_WorkStuRelation_Total.EduClsName);
clsCheckSql.CheckFieldLen(strEduClsName, 100, convcc_WorkStuRelation_Total.EduClsName);
objvcc_WorkStuRelation_TotalEN.EduClsName = strEduClsName; //教学班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.EduClsName) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.EduClsName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.EduClsName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetCourseId(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_WorkStuRelation_Total.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_WorkStuRelation_Total.CourseId);
objvcc_WorkStuRelation_TotalEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.CourseId) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.CourseId, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.CourseId] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetCourseName(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_WorkStuRelation_Total.CourseName);
objvcc_WorkStuRelation_TotalEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.CourseName) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.CourseName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.CourseName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetTeacherID(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, string strTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherID, convcc_WorkStuRelation_Total.TeacherID);
clsCheckSql.CheckFieldLen(strTeacherID, 12, convcc_WorkStuRelation_Total.TeacherID);
objvcc_WorkStuRelation_TotalEN.TeacherID = strTeacherID; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.TeacherID) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.TeacherID, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.TeacherID] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetTeacherName(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, string strTeacherName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeacherName, 50, convcc_WorkStuRelation_Total.TeacherName);
objvcc_WorkStuRelation_TotalEN.TeacherName = strTeacherName; //教师姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.TeacherName) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.TeacherName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.TeacherName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN Setid_StudentInfo(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudentInfo, convcc_WorkStuRelation_Total.id_StudentInfo);
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, convcc_WorkStuRelation_Total.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, convcc_WorkStuRelation_Total.id_StudentInfo);
objvcc_WorkStuRelation_TotalEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.id_StudentInfo) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.id_StudentInfo, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.id_StudentInfo] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetStuID(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convcc_WorkStuRelation_Total.StuID);
objvcc_WorkStuRelation_TotalEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.StuID) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.StuID, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.StuID] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetStuName(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convcc_WorkStuRelation_Total.StuName);
objvcc_WorkStuRelation_TotalEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.StuName) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.StuName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.StuName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN Setid_XzCollege(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convcc_WorkStuRelation_Total.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convcc_WorkStuRelation_Total.id_XzCollege);
objvcc_WorkStuRelation_TotalEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.id_XzCollege) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.id_XzCollege, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.id_XzCollege] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetCollegeName(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convcc_WorkStuRelation_Total.CollegeName);
clsCheckSql.CheckFieldLen(strCollegeName, 100, convcc_WorkStuRelation_Total.CollegeName);
objvcc_WorkStuRelation_TotalEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.CollegeName) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.CollegeName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.CollegeName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN Setid_XzMajor(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzMajor, convcc_WorkStuRelation_Total.id_XzMajor);
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convcc_WorkStuRelation_Total.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convcc_WorkStuRelation_Total.id_XzMajor);
objvcc_WorkStuRelation_TotalEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.id_XzMajor) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.id_XzMajor, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.id_XzMajor] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetMajorID(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorID, convcc_WorkStuRelation_Total.MajorID);
clsCheckSql.CheckFieldLen(strMajorID, 4, convcc_WorkStuRelation_Total.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convcc_WorkStuRelation_Total.MajorID);
objvcc_WorkStuRelation_TotalEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.MajorID) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.MajorID, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.MajorID] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetMajorName(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorName, convcc_WorkStuRelation_Total.MajorName);
clsCheckSql.CheckFieldLen(strMajorName, 100, convcc_WorkStuRelation_Total.MajorName);
objvcc_WorkStuRelation_TotalEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.MajorName) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.MajorName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.MajorName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN Setid_GradeBase(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convcc_WorkStuRelation_Total.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convcc_WorkStuRelation_Total.id_GradeBase);
objvcc_WorkStuRelation_TotalEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.id_GradeBase) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.id_GradeBase, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.id_GradeBase] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetAdminClsId(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, string strAdminClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, convcc_WorkStuRelation_Total.AdminClsId);
objvcc_WorkStuRelation_TotalEN.AdminClsId = strAdminClsId; //行政班代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.AdminClsId) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.AdminClsId, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.AdminClsId] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetAdminClsName(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, string strAdminClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, convcc_WorkStuRelation_Total.AdminClsName);
objvcc_WorkStuRelation_TotalEN.AdminClsName = strAdminClsName; //行政班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.AdminClsName) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.AdminClsName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.AdminClsName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetCollegeNameA(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convcc_WorkStuRelation_Total.CollegeNameA);
objvcc_WorkStuRelation_TotalEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.CollegeNameA) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.CollegeNameA, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.CollegeNameA] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetGradeBaseName(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGradeBaseName, convcc_WorkStuRelation_Total.GradeBaseName);
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convcc_WorkStuRelation_Total.GradeBaseName);
objvcc_WorkStuRelation_TotalEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.GradeBaseName) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.GradeBaseName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.GradeBaseName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetWorkNum(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, int intWorkNum, string strComparisonOp="")
	{
objvcc_WorkStuRelation_TotalEN.WorkNum = intWorkNum; //作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.WorkNum) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.WorkNum, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.WorkNum] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetWorkNum_Submit(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, int intWorkNum_Submit, string strComparisonOp="")
	{
objvcc_WorkStuRelation_TotalEN.WorkNum_Submit = intWorkNum_Submit; //提交作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.WorkNum_Submit) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.WorkNum_Submit, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.WorkNum_Submit] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetWorkNum_Save(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, int intWorkNum_Save, string strComparisonOp="")
	{
objvcc_WorkStuRelation_TotalEN.WorkNum_Save = intWorkNum_Save; //保存作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.WorkNum_Save) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.WorkNum_Save, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.WorkNum_Save] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetWorkNum_NoFinish(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, int intWorkNum_NoFinish, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intWorkNum_NoFinish, convcc_WorkStuRelation_Total.WorkNum_NoFinish);
objvcc_WorkStuRelation_TotalEN.WorkNum_NoFinish = intWorkNum_NoFinish; //未完成作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.WorkNum_NoFinish) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.WorkNum_NoFinish, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.WorkNum_NoFinish] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetWorkNum_SendBack(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, int intWorkNum_SendBack, string strComparisonOp="")
	{
objvcc_WorkStuRelation_TotalEN.WorkNum_SendBack = intWorkNum_SendBack; //退回作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.WorkNum_SendBack) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.WorkNum_SendBack, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.WorkNum_SendBack] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetWorkNum_Mark(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, int intWorkNum_Mark, string strComparisonOp="")
	{
objvcc_WorkStuRelation_TotalEN.WorkNum_Mark = intWorkNum_Mark; //批改作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.WorkNum_Mark) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.WorkNum_Mark, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.WorkNum_Mark] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetWorkNum_Look(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, int intWorkNum_Look, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intWorkNum_Look, convcc_WorkStuRelation_Total.WorkNum_Look);
objvcc_WorkStuRelation_TotalEN.WorkNum_Look = intWorkNum_Look; //查看作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.WorkNum_Look) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.WorkNum_Look, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.WorkNum_Look] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetWorkNum_Overdue(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, int intWorkNum_Overdue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intWorkNum_Overdue, convcc_WorkStuRelation_Total.WorkNum_Overdue);
objvcc_WorkStuRelation_TotalEN.WorkNum_Overdue = intWorkNum_Overdue; //逾期作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.WorkNum_Overdue) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.WorkNum_Overdue, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.WorkNum_Overdue] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetTotalScore(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, double dblTotalScore, string strComparisonOp="")
	{
objvcc_WorkStuRelation_TotalEN.TotalScore = dblTotalScore; //总得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.TotalScore) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.TotalScore, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.TotalScore] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetTotalScores(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, double dblTotalScores, string strComparisonOp="")
	{
objvcc_WorkStuRelation_TotalEN.TotalScores = dblTotalScores; //总分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.TotalScores) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.TotalScores, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.TotalScores] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetSchoolYear(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, string strSchoolYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, convcc_WorkStuRelation_Total.SchoolYear);
objvcc_WorkStuRelation_TotalEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.SchoolYear) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.SchoolYear, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.SchoolYear] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetSchoolTerm(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, convcc_WorkStuRelation_Total.SchoolTerm);
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, convcc_WorkStuRelation_Total.SchoolTerm);
objvcc_WorkStuRelation_TotalEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.SchoolTerm) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.SchoolTerm, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.SchoolTerm] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetUpdDate(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_WorkStuRelation_Total.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_WorkStuRelation_Total.UpdDate);
objvcc_WorkStuRelation_TotalEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.UpdDate) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.UpdDate, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.UpdDate] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetUpdUserId(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_WorkStuRelation_Total.UpdUserId);
objvcc_WorkStuRelation_TotalEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.UpdUserId) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.UpdUserId, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.UpdUserId] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation_TotalEN SetMemo(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_WorkStuRelation_Total.Memo);
objvcc_WorkStuRelation_TotalEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation_Total.Memo) == false)
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(convcc_WorkStuRelation_Total.Memo, strComparisonOp);
}
else
{
objvcc_WorkStuRelation_TotalEN.dicFldComparisonOp[convcc_WorkStuRelation_Total.Memo] = strComparisonOp;
}
}
return objvcc_WorkStuRelation_TotalEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_Total_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.Id_WorkStuRelation_Total) == true)
{
string strComparisonOp_Id_WorkStuRelation_Total = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.Id_WorkStuRelation_Total];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation_Total.Id_WorkStuRelation_Total, objvcc_WorkStuRelation_Total_Cond.Id_WorkStuRelation_Total, strComparisonOp_Id_WorkStuRelation_Total);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_Total.id_CurrEduCls, objvcc_WorkStuRelation_Total_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.CurrEduClsId) == true)
{
string strComparisonOp_CurrEduClsId = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_Total.CurrEduClsId, objvcc_WorkStuRelation_Total_Cond.CurrEduClsId, strComparisonOp_CurrEduClsId);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.EduClsName) == true)
{
string strComparisonOp_EduClsName = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_Total.EduClsName, objvcc_WorkStuRelation_Total_Cond.EduClsName, strComparisonOp_EduClsName);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_Total.CourseId, objvcc_WorkStuRelation_Total_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_Total.CourseName, objvcc_WorkStuRelation_Total_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.TeacherID) == true)
{
string strComparisonOp_TeacherID = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_Total.TeacherID, objvcc_WorkStuRelation_Total_Cond.TeacherID, strComparisonOp_TeacherID);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.TeacherName) == true)
{
string strComparisonOp_TeacherName = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.TeacherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_Total.TeacherName, objvcc_WorkStuRelation_Total_Cond.TeacherName, strComparisonOp_TeacherName);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_Total.id_StudentInfo, objvcc_WorkStuRelation_Total_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.StuID) == true)
{
string strComparisonOp_StuID = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_Total.StuID, objvcc_WorkStuRelation_Total_Cond.StuID, strComparisonOp_StuID);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.StuName) == true)
{
string strComparisonOp_StuName = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_Total.StuName, objvcc_WorkStuRelation_Total_Cond.StuName, strComparisonOp_StuName);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_Total.id_XzCollege, objvcc_WorkStuRelation_Total_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_Total.CollegeName, objvcc_WorkStuRelation_Total_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_Total.id_XzMajor, objvcc_WorkStuRelation_Total_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.MajorID) == true)
{
string strComparisonOp_MajorID = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_Total.MajorID, objvcc_WorkStuRelation_Total_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.MajorName) == true)
{
string strComparisonOp_MajorName = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_Total.MajorName, objvcc_WorkStuRelation_Total_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_Total.id_GradeBase, objvcc_WorkStuRelation_Total_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.AdminClsId) == true)
{
string strComparisonOp_AdminClsId = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_Total.AdminClsId, objvcc_WorkStuRelation_Total_Cond.AdminClsId, strComparisonOp_AdminClsId);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.AdminClsName) == true)
{
string strComparisonOp_AdminClsName = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_Total.AdminClsName, objvcc_WorkStuRelation_Total_Cond.AdminClsName, strComparisonOp_AdminClsName);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_Total.CollegeNameA, objvcc_WorkStuRelation_Total_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_Total.GradeBaseName, objvcc_WorkStuRelation_Total_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.WorkNum) == true)
{
string strComparisonOp_WorkNum = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.WorkNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation_Total.WorkNum, objvcc_WorkStuRelation_Total_Cond.WorkNum, strComparisonOp_WorkNum);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.WorkNum_Submit) == true)
{
string strComparisonOp_WorkNum_Submit = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.WorkNum_Submit];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation_Total.WorkNum_Submit, objvcc_WorkStuRelation_Total_Cond.WorkNum_Submit, strComparisonOp_WorkNum_Submit);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.WorkNum_Save) == true)
{
string strComparisonOp_WorkNum_Save = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.WorkNum_Save];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation_Total.WorkNum_Save, objvcc_WorkStuRelation_Total_Cond.WorkNum_Save, strComparisonOp_WorkNum_Save);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.WorkNum_NoFinish) == true)
{
string strComparisonOp_WorkNum_NoFinish = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.WorkNum_NoFinish];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation_Total.WorkNum_NoFinish, objvcc_WorkStuRelation_Total_Cond.WorkNum_NoFinish, strComparisonOp_WorkNum_NoFinish);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.WorkNum_SendBack) == true)
{
string strComparisonOp_WorkNum_SendBack = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.WorkNum_SendBack];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation_Total.WorkNum_SendBack, objvcc_WorkStuRelation_Total_Cond.WorkNum_SendBack, strComparisonOp_WorkNum_SendBack);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.WorkNum_Mark) == true)
{
string strComparisonOp_WorkNum_Mark = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.WorkNum_Mark];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation_Total.WorkNum_Mark, objvcc_WorkStuRelation_Total_Cond.WorkNum_Mark, strComparisonOp_WorkNum_Mark);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.WorkNum_Look) == true)
{
string strComparisonOp_WorkNum_Look = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.WorkNum_Look];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation_Total.WorkNum_Look, objvcc_WorkStuRelation_Total_Cond.WorkNum_Look, strComparisonOp_WorkNum_Look);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.WorkNum_Overdue) == true)
{
string strComparisonOp_WorkNum_Overdue = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.WorkNum_Overdue];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation_Total.WorkNum_Overdue, objvcc_WorkStuRelation_Total_Cond.WorkNum_Overdue, strComparisonOp_WorkNum_Overdue);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.TotalScore) == true)
{
string strComparisonOp_TotalScore = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.TotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation_Total.TotalScore, objvcc_WorkStuRelation_Total_Cond.TotalScore, strComparisonOp_TotalScore);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.TotalScores) == true)
{
string strComparisonOp_TotalScores = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.TotalScores];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation_Total.TotalScores, objvcc_WorkStuRelation_Total_Cond.TotalScores, strComparisonOp_TotalScores);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.SchoolYear) == true)
{
string strComparisonOp_SchoolYear = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_Total.SchoolYear, objvcc_WorkStuRelation_Total_Cond.SchoolYear, strComparisonOp_SchoolYear);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.SchoolTerm) == true)
{
string strComparisonOp_SchoolTerm = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_Total.SchoolTerm, objvcc_WorkStuRelation_Total_Cond.SchoolTerm, strComparisonOp_SchoolTerm);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_Total.UpdDate, objvcc_WorkStuRelation_Total_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_Total.UpdUserId, objvcc_WorkStuRelation_Total_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvcc_WorkStuRelation_Total_Cond.IsUpdated(convcc_WorkStuRelation_Total.Memo) == true)
{
string strComparisonOp_Memo = objvcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[convcc_WorkStuRelation_Total.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation_Total.Memo, objvcc_WorkStuRelation_Total_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v学生作业完成情况汇总(vcc_WorkStuRelation_Total)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_WorkStuRelation_TotalWApi
{
private static readonly string mstrApiControllerName = "vcc_WorkStuRelation_TotalApi";

 public clsvcc_WorkStuRelation_TotalWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_WorkStuRelation_Total">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkStuRelation_TotalEN GetObjById_WorkStuRelation_Total(long lngId_WorkStuRelation_Total)
{
string strAction = "GetObjById_WorkStuRelation_Total";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN = null;
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
objvcc_WorkStuRelation_TotalEN = JsonConvert.DeserializeObject<clsvcc_WorkStuRelation_TotalEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkStuRelation_TotalEN;
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
public static clsvcc_WorkStuRelation_TotalEN GetObjById_WorkStuRelation_Total_WA_Cache(long lngId_WorkStuRelation_Total)
{
string strAction = "GetObjById_WorkStuRelation_Total_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN = null;
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
objvcc_WorkStuRelation_TotalEN = JsonConvert.DeserializeObject<clsvcc_WorkStuRelation_TotalEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkStuRelation_TotalEN;
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
public static clsvcc_WorkStuRelation_TotalEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalEN = null;
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
objvcc_WorkStuRelation_TotalEN = JsonConvert.DeserializeObject<clsvcc_WorkStuRelation_TotalEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkStuRelation_TotalEN;
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
public static clsvcc_WorkStuRelation_TotalEN GetObjById_WorkStuRelation_Total_Cache(long lngId_WorkStuRelation_Total)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_WorkStuRelation_TotalEN._CurrTabName_S);
List<clsvcc_WorkStuRelation_TotalEN> arrvcc_WorkStuRelation_TotalObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_WorkStuRelation_TotalEN> arrvcc_WorkStuRelation_TotalObjLst_Sel =
from objvcc_WorkStuRelation_TotalEN in arrvcc_WorkStuRelation_TotalObjLst_Cache
where objvcc_WorkStuRelation_TotalEN.Id_WorkStuRelation_Total == lngId_WorkStuRelation_Total
select objvcc_WorkStuRelation_TotalEN;
if (arrvcc_WorkStuRelation_TotalObjLst_Sel.Count() == 0)
{
   clsvcc_WorkStuRelation_TotalEN obj = clsvcc_WorkStuRelation_TotalWApi.GetObjById_WorkStuRelation_Total(lngId_WorkStuRelation_Total);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_WorkStuRelation_TotalObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelation_TotalEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_WorkStuRelation_TotalEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation_TotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelation_TotalEN> GetObjLstById_WorkStuRelation_TotalLst(List<long> arrId_WorkStuRelation_Total)
{
 List<clsvcc_WorkStuRelation_TotalEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation_TotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvcc_WorkStuRelation_TotalEN> GetObjLstById_WorkStuRelation_TotalLst_Cache(List<long> arrId_WorkStuRelation_Total)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_WorkStuRelation_TotalEN._CurrTabName_S);
List<clsvcc_WorkStuRelation_TotalEN> arrvcc_WorkStuRelation_TotalObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_WorkStuRelation_TotalEN> arrvcc_WorkStuRelation_TotalObjLst_Sel =
from objvcc_WorkStuRelation_TotalEN in arrvcc_WorkStuRelation_TotalObjLst_Cache
where arrId_WorkStuRelation_Total.Contains(objvcc_WorkStuRelation_TotalEN.Id_WorkStuRelation_Total)
select objvcc_WorkStuRelation_TotalEN;
return arrvcc_WorkStuRelation_TotalObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelation_TotalEN> GetObjLstById_WorkStuRelation_TotalLst_WA_Cache(List<long> arrId_WorkStuRelation_Total)
{
 List<clsvcc_WorkStuRelation_TotalEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation_TotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelation_TotalEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_WorkStuRelation_TotalEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation_TotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelation_TotalEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_WorkStuRelation_TotalEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation_TotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelation_TotalEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_WorkStuRelation_TotalEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation_TotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelation_TotalEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_WorkStuRelation_TotalEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation_TotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvcc_WorkStuRelation_TotalENS">源对象</param>
 /// <param name = "objvcc_WorkStuRelation_TotalENT">目标对象</param>
 public static void CopyTo(clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalENS, clsvcc_WorkStuRelation_TotalEN objvcc_WorkStuRelation_TotalENT)
{
try
{
objvcc_WorkStuRelation_TotalENT.Id_WorkStuRelation_Total = objvcc_WorkStuRelation_TotalENS.Id_WorkStuRelation_Total; //流水号
objvcc_WorkStuRelation_TotalENT.id_CurrEduCls = objvcc_WorkStuRelation_TotalENS.id_CurrEduCls; //当前教学班流水号
objvcc_WorkStuRelation_TotalENT.CurrEduClsId = objvcc_WorkStuRelation_TotalENS.CurrEduClsId; //当前教学班Id
objvcc_WorkStuRelation_TotalENT.EduClsName = objvcc_WorkStuRelation_TotalENS.EduClsName; //教学班名称
objvcc_WorkStuRelation_TotalENT.CourseId = objvcc_WorkStuRelation_TotalENS.CourseId; //课程Id
objvcc_WorkStuRelation_TotalENT.CourseName = objvcc_WorkStuRelation_TotalENS.CourseName; //课程名称
objvcc_WorkStuRelation_TotalENT.TeacherID = objvcc_WorkStuRelation_TotalENS.TeacherID; //教师工号
objvcc_WorkStuRelation_TotalENT.TeacherName = objvcc_WorkStuRelation_TotalENS.TeacherName; //教师姓名
objvcc_WorkStuRelation_TotalENT.id_StudentInfo = objvcc_WorkStuRelation_TotalENS.id_StudentInfo; //学生流水号
objvcc_WorkStuRelation_TotalENT.StuID = objvcc_WorkStuRelation_TotalENS.StuID; //学号
objvcc_WorkStuRelation_TotalENT.StuName = objvcc_WorkStuRelation_TotalENS.StuName; //姓名
objvcc_WorkStuRelation_TotalENT.id_XzCollege = objvcc_WorkStuRelation_TotalENS.id_XzCollege; //学院流水号
objvcc_WorkStuRelation_TotalENT.CollegeName = objvcc_WorkStuRelation_TotalENS.CollegeName; //学院名称
objvcc_WorkStuRelation_TotalENT.id_XzMajor = objvcc_WorkStuRelation_TotalENS.id_XzMajor; //专业流水号
objvcc_WorkStuRelation_TotalENT.MajorID = objvcc_WorkStuRelation_TotalENS.MajorID; //专业ID
objvcc_WorkStuRelation_TotalENT.MajorName = objvcc_WorkStuRelation_TotalENS.MajorName; //专业名称
objvcc_WorkStuRelation_TotalENT.id_GradeBase = objvcc_WorkStuRelation_TotalENS.id_GradeBase; //年级流水号
objvcc_WorkStuRelation_TotalENT.AdminClsId = objvcc_WorkStuRelation_TotalENS.AdminClsId; //行政班代号
objvcc_WorkStuRelation_TotalENT.AdminClsName = objvcc_WorkStuRelation_TotalENS.AdminClsName; //行政班名称
objvcc_WorkStuRelation_TotalENT.CollegeNameA = objvcc_WorkStuRelation_TotalENS.CollegeNameA; //学院名称简写
objvcc_WorkStuRelation_TotalENT.GradeBaseName = objvcc_WorkStuRelation_TotalENS.GradeBaseName; //年级名称
objvcc_WorkStuRelation_TotalENT.WorkNum = objvcc_WorkStuRelation_TotalENS.WorkNum; //作业数
objvcc_WorkStuRelation_TotalENT.WorkNum_Submit = objvcc_WorkStuRelation_TotalENS.WorkNum_Submit; //提交作业数
objvcc_WorkStuRelation_TotalENT.WorkNum_Save = objvcc_WorkStuRelation_TotalENS.WorkNum_Save; //保存作业数
objvcc_WorkStuRelation_TotalENT.WorkNum_NoFinish = objvcc_WorkStuRelation_TotalENS.WorkNum_NoFinish; //未完成作业数
objvcc_WorkStuRelation_TotalENT.WorkNum_SendBack = objvcc_WorkStuRelation_TotalENS.WorkNum_SendBack; //退回作业数
objvcc_WorkStuRelation_TotalENT.WorkNum_Mark = objvcc_WorkStuRelation_TotalENS.WorkNum_Mark; //批改作业数
objvcc_WorkStuRelation_TotalENT.WorkNum_Look = objvcc_WorkStuRelation_TotalENS.WorkNum_Look; //查看作业数
objvcc_WorkStuRelation_TotalENT.WorkNum_Overdue = objvcc_WorkStuRelation_TotalENS.WorkNum_Overdue; //逾期作业数
objvcc_WorkStuRelation_TotalENT.TotalScore = objvcc_WorkStuRelation_TotalENS.TotalScore; //总得分
objvcc_WorkStuRelation_TotalENT.TotalScores = objvcc_WorkStuRelation_TotalENS.TotalScores; //总分值
objvcc_WorkStuRelation_TotalENT.SchoolYear = objvcc_WorkStuRelation_TotalENS.SchoolYear; //学年
objvcc_WorkStuRelation_TotalENT.SchoolTerm = objvcc_WorkStuRelation_TotalENS.SchoolTerm; //学期
objvcc_WorkStuRelation_TotalENT.UpdDate = objvcc_WorkStuRelation_TotalENS.UpdDate; //修改日期
objvcc_WorkStuRelation_TotalENT.UpdUserId = objvcc_WorkStuRelation_TotalENS.UpdUserId; //修改用户Id
objvcc_WorkStuRelation_TotalENT.Memo = objvcc_WorkStuRelation_TotalENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvcc_WorkStuRelation_TotalEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_WorkStuRelation_TotalEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_WorkStuRelation_TotalEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_WorkStuRelation_TotalEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_WorkStuRelation_TotalEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_WorkStuRelation_TotalEN.AttributeName)
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
if (clscc_WorkStuRelation_TotalWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkStuRelation_TotalWApi没有刷新缓存机制(clscc_WorkStuRelation_TotalWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvcc_WorkStuRelation_TotalObjLst_Cache == null)
//{
//arrvcc_WorkStuRelation_TotalObjLst_Cache = await clsvcc_WorkStuRelation_TotalWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvcc_WorkStuRelation_TotalEN._CurrTabName_S);
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
public static List<clsvcc_WorkStuRelation_TotalEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvcc_WorkStuRelation_TotalEN._CurrTabName_S);
List<clsvcc_WorkStuRelation_TotalEN> arrvcc_WorkStuRelation_TotalObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_WorkStuRelation_TotalObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_WorkStuRelation_TotalEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_WorkStuRelation_Total.Id_WorkStuRelation_Total, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.CurrEduClsId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.EduClsName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.TeacherID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.TeacherName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.AdminClsId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.AdminClsName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.WorkNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.WorkNum_Submit, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.WorkNum_Save, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.WorkNum_NoFinish, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.WorkNum_SendBack, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.WorkNum_Mark, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.WorkNum_Look, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.WorkNum_Overdue, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.TotalScore, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.TotalScores, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.SchoolYear, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.SchoolTerm, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation_Total.Memo, Type.GetType("System.String"));
foreach (clsvcc_WorkStuRelation_TotalEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_WorkStuRelation_Total.Id_WorkStuRelation_Total] = objInFor[convcc_WorkStuRelation_Total.Id_WorkStuRelation_Total];
objDR[convcc_WorkStuRelation_Total.id_CurrEduCls] = objInFor[convcc_WorkStuRelation_Total.id_CurrEduCls];
objDR[convcc_WorkStuRelation_Total.CurrEduClsId] = objInFor[convcc_WorkStuRelation_Total.CurrEduClsId];
objDR[convcc_WorkStuRelation_Total.EduClsName] = objInFor[convcc_WorkStuRelation_Total.EduClsName];
objDR[convcc_WorkStuRelation_Total.CourseId] = objInFor[convcc_WorkStuRelation_Total.CourseId];
objDR[convcc_WorkStuRelation_Total.CourseName] = objInFor[convcc_WorkStuRelation_Total.CourseName];
objDR[convcc_WorkStuRelation_Total.TeacherID] = objInFor[convcc_WorkStuRelation_Total.TeacherID];
objDR[convcc_WorkStuRelation_Total.TeacherName] = objInFor[convcc_WorkStuRelation_Total.TeacherName];
objDR[convcc_WorkStuRelation_Total.id_StudentInfo] = objInFor[convcc_WorkStuRelation_Total.id_StudentInfo];
objDR[convcc_WorkStuRelation_Total.StuID] = objInFor[convcc_WorkStuRelation_Total.StuID];
objDR[convcc_WorkStuRelation_Total.StuName] = objInFor[convcc_WorkStuRelation_Total.StuName];
objDR[convcc_WorkStuRelation_Total.id_XzCollege] = objInFor[convcc_WorkStuRelation_Total.id_XzCollege];
objDR[convcc_WorkStuRelation_Total.CollegeName] = objInFor[convcc_WorkStuRelation_Total.CollegeName];
objDR[convcc_WorkStuRelation_Total.id_XzMajor] = objInFor[convcc_WorkStuRelation_Total.id_XzMajor];
objDR[convcc_WorkStuRelation_Total.MajorID] = objInFor[convcc_WorkStuRelation_Total.MajorID];
objDR[convcc_WorkStuRelation_Total.MajorName] = objInFor[convcc_WorkStuRelation_Total.MajorName];
objDR[convcc_WorkStuRelation_Total.id_GradeBase] = objInFor[convcc_WorkStuRelation_Total.id_GradeBase];
objDR[convcc_WorkStuRelation_Total.AdminClsId] = objInFor[convcc_WorkStuRelation_Total.AdminClsId];
objDR[convcc_WorkStuRelation_Total.AdminClsName] = objInFor[convcc_WorkStuRelation_Total.AdminClsName];
objDR[convcc_WorkStuRelation_Total.CollegeNameA] = objInFor[convcc_WorkStuRelation_Total.CollegeNameA];
objDR[convcc_WorkStuRelation_Total.GradeBaseName] = objInFor[convcc_WorkStuRelation_Total.GradeBaseName];
objDR[convcc_WorkStuRelation_Total.WorkNum] = objInFor[convcc_WorkStuRelation_Total.WorkNum];
objDR[convcc_WorkStuRelation_Total.WorkNum_Submit] = objInFor[convcc_WorkStuRelation_Total.WorkNum_Submit];
objDR[convcc_WorkStuRelation_Total.WorkNum_Save] = objInFor[convcc_WorkStuRelation_Total.WorkNum_Save];
objDR[convcc_WorkStuRelation_Total.WorkNum_NoFinish] = objInFor[convcc_WorkStuRelation_Total.WorkNum_NoFinish];
objDR[convcc_WorkStuRelation_Total.WorkNum_SendBack] = objInFor[convcc_WorkStuRelation_Total.WorkNum_SendBack];
objDR[convcc_WorkStuRelation_Total.WorkNum_Mark] = objInFor[convcc_WorkStuRelation_Total.WorkNum_Mark];
objDR[convcc_WorkStuRelation_Total.WorkNum_Look] = objInFor[convcc_WorkStuRelation_Total.WorkNum_Look];
objDR[convcc_WorkStuRelation_Total.WorkNum_Overdue] = objInFor[convcc_WorkStuRelation_Total.WorkNum_Overdue];
objDR[convcc_WorkStuRelation_Total.TotalScore] = objInFor[convcc_WorkStuRelation_Total.TotalScore];
objDR[convcc_WorkStuRelation_Total.TotalScores] = objInFor[convcc_WorkStuRelation_Total.TotalScores];
objDR[convcc_WorkStuRelation_Total.SchoolYear] = objInFor[convcc_WorkStuRelation_Total.SchoolYear];
objDR[convcc_WorkStuRelation_Total.SchoolTerm] = objInFor[convcc_WorkStuRelation_Total.SchoolTerm];
objDR[convcc_WorkStuRelation_Total.UpdDate] = objInFor[convcc_WorkStuRelation_Total.UpdDate];
objDR[convcc_WorkStuRelation_Total.UpdUserId] = objInFor[convcc_WorkStuRelation_Total.UpdUserId];
objDR[convcc_WorkStuRelation_Total.Memo] = objInFor[convcc_WorkStuRelation_Total.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}