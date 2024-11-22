
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkStuRelation4CorrectWApi
 表名:vcc_WorkStuRelation4Correct(01120205)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:45:16
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
public static class clsvcc_WorkStuRelation4CorrectWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetmId(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, long lngmId, string strComparisonOp="")
	{
objvcc_WorkStuRelation4CorrectEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.mId) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.mId, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.mId] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetCourseId(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convcc_WorkStuRelation4Correct.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_WorkStuRelation4Correct.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_WorkStuRelation4Correct.CourseId);
objvcc_WorkStuRelation4CorrectEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.CourseId) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.CourseId, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.CourseId] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetCourseName(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_WorkStuRelation4Correct.CourseName);
objvcc_WorkStuRelation4CorrectEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.CourseName) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.CourseName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.CourseName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN Setid_StudentInfo(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudentInfo, convcc_WorkStuRelation4Correct.id_StudentInfo);
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, convcc_WorkStuRelation4Correct.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, convcc_WorkStuRelation4Correct.id_StudentInfo);
objvcc_WorkStuRelation4CorrectEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.id_StudentInfo) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.id_StudentInfo, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.id_StudentInfo] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetStuID(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convcc_WorkStuRelation4Correct.StuID);
objvcc_WorkStuRelation4CorrectEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.StuID) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.StuID, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.StuID] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetStuName(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convcc_WorkStuRelation4Correct.StuName);
objvcc_WorkStuRelation4CorrectEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.StuName) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.StuName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.StuName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN Setid_XzCollege(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convcc_WorkStuRelation4Correct.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convcc_WorkStuRelation4Correct.id_XzCollege);
objvcc_WorkStuRelation4CorrectEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.id_XzCollege) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.id_XzCollege, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.id_XzCollege] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetCollegeName(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convcc_WorkStuRelation4Correct.CollegeName);
objvcc_WorkStuRelation4CorrectEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.CollegeName) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.CollegeName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.CollegeName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN Setid_XzMajor(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convcc_WorkStuRelation4Correct.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convcc_WorkStuRelation4Correct.id_XzMajor);
objvcc_WorkStuRelation4CorrectEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.id_XzMajor) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.id_XzMajor, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.id_XzMajor] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetMajorID(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convcc_WorkStuRelation4Correct.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convcc_WorkStuRelation4Correct.MajorID);
objvcc_WorkStuRelation4CorrectEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.MajorID) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.MajorID, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.MajorID] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetMajorName(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convcc_WorkStuRelation4Correct.MajorName);
objvcc_WorkStuRelation4CorrectEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.MajorName) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.MajorName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.MajorName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN Setid_GradeBase(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convcc_WorkStuRelation4Correct.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convcc_WorkStuRelation4Correct.id_GradeBase);
objvcc_WorkStuRelation4CorrectEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.id_GradeBase) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.id_GradeBase, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.id_GradeBase] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetAdminClsId(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strAdminClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, convcc_WorkStuRelation4Correct.AdminClsId);
objvcc_WorkStuRelation4CorrectEN.AdminClsId = strAdminClsId; //行政班代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.AdminClsId) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.AdminClsId, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.AdminClsId] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetAdminClsName(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strAdminClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, convcc_WorkStuRelation4Correct.AdminClsName);
objvcc_WorkStuRelation4CorrectEN.AdminClsName = strAdminClsName; //行政班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.AdminClsName) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.AdminClsName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.AdminClsName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetCollegeNameA(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convcc_WorkStuRelation4Correct.CollegeNameA);
objvcc_WorkStuRelation4CorrectEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.CollegeNameA) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.CollegeNameA, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.CollegeNameA] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetGradeBaseName(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convcc_WorkStuRelation4Correct.GradeBaseName);
objvcc_WorkStuRelation4CorrectEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.GradeBaseName) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.GradeBaseName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.GradeBaseName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetQuestionID(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionID, 8, convcc_WorkStuRelation4Correct.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convcc_WorkStuRelation4Correct.QuestionID);
objvcc_WorkStuRelation4CorrectEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.QuestionID) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.QuestionID, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.QuestionID] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetQuestionIndex(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, int intQuestionIndex, string strComparisonOp="")
	{
objvcc_WorkStuRelation4CorrectEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.QuestionIndex) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.QuestionIndex, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.QuestionIndex] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetQuestionName(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strQuestionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionName, 1000, convcc_WorkStuRelation4Correct.QuestionName);
objvcc_WorkStuRelation4CorrectEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.QuestionName) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.QuestionName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.QuestionName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetCourseChapterId(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_WorkStuRelation4Correct.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_WorkStuRelation4Correct.CourseChapterId);
objvcc_WorkStuRelation4CorrectEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.CourseChapterId) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.CourseChapterId, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.CourseChapterId] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetCourseChapterName(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_WorkStuRelation4Correct.CourseChapterName);
objvcc_WorkStuRelation4CorrectEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.CourseChapterName) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.CourseChapterName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.CourseChapterName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetChapterName(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_WorkStuRelation4Correct.ChapterName);
objvcc_WorkStuRelation4CorrectEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.ChapterName) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.ChapterName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.ChapterName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetSectionName(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_WorkStuRelation4Correct.SectionName);
objvcc_WorkStuRelation4CorrectEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.SectionName) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.SectionName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.SectionName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetChapterName_Sim(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convcc_WorkStuRelation4Correct.ChapterName_Sim);
objvcc_WorkStuRelation4CorrectEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.ChapterName_Sim) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.ChapterName_Sim, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.ChapterName_Sim] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetSectionName_Sim(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, convcc_WorkStuRelation4Correct.SectionName_Sim);
objvcc_WorkStuRelation4CorrectEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.SectionName_Sim) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.SectionName_Sim, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.SectionName_Sim] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetParentNodeID(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convcc_WorkStuRelation4Correct.ParentNodeID);
objvcc_WorkStuRelation4CorrectEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.ParentNodeID) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.ParentNodeID, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.ParentNodeID] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetCourseChapterReferred(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strCourseChapterReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convcc_WorkStuRelation4Correct.CourseChapterReferred);
objvcc_WorkStuRelation4CorrectEN.CourseChapterReferred = strCourseChapterReferred; //节简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.CourseChapterReferred) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.CourseChapterReferred, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.CourseChapterReferred] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetParentNodeName(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strParentNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convcc_WorkStuRelation4Correct.ParentNodeName);
objvcc_WorkStuRelation4CorrectEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.ParentNodeName) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.ParentNodeName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.ParentNodeName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetParentNodeReferred(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strParentNodeReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convcc_WorkStuRelation4Correct.ParentNodeReferred);
objvcc_WorkStuRelation4CorrectEN.ParentNodeReferred = strParentNodeReferred; //章简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.ParentNodeReferred) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.ParentNodeReferred, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.ParentNodeReferred] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetAnswerAttLimitSize(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, long lngAnswerAttLimitSize, string strComparisonOp="")
	{
objvcc_WorkStuRelation4CorrectEN.AnswerAttLimitSize = lngAnswerAttLimitSize; //回答附件限制大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.AnswerAttLimitSize) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.AnswerAttLimitSize, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.AnswerAttLimitSize] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetRightId(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strRightId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightId, convcc_WorkStuRelation4Correct.RightId);
clsCheckSql.CheckFieldLen(strRightId, 8, convcc_WorkStuRelation4Correct.RightId);
clsCheckSql.CheckFieldForeignKey(strRightId, 8, convcc_WorkStuRelation4Correct.RightId);
objvcc_WorkStuRelation4CorrectEN.RightId = strRightId; //权限编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.RightId) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.RightId, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.RightId] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetRightName(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strRightName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRightName, 200, convcc_WorkStuRelation4Correct.RightName);
objvcc_WorkStuRelation4CorrectEN.RightName = strRightName; //权限名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.RightName) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.RightName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.RightName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetAuthorizer(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strAuthorizer, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAuthorizer, convcc_WorkStuRelation4Correct.Authorizer);
clsCheckSql.CheckFieldLen(strAuthorizer, 18, convcc_WorkStuRelation4Correct.Authorizer);
objvcc_WorkStuRelation4CorrectEN.Authorizer = strAuthorizer; //授权人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.Authorizer) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.Authorizer, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.Authorizer] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetUpdDate(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_WorkStuRelation4Correct.UpdDate);
objvcc_WorkStuRelation4CorrectEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.UpdDate) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.UpdDate, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.UpdDate] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetUpdUser(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convcc_WorkStuRelation4Correct.UpdUser);
objvcc_WorkStuRelation4CorrectEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.UpdUser) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.UpdUser, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.UpdUser] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetMemo(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_WorkStuRelation4Correct.Memo);
objvcc_WorkStuRelation4CorrectEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.Memo) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.Memo, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.Memo] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4Correct_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.mId) == true)
{
string strComparisonOp_mId = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation4Correct.mId, objvcc_WorkStuRelation4Correct_Cond.mId, strComparisonOp_mId);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.CourseId, objvcc_WorkStuRelation4Correct_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.CourseName, objvcc_WorkStuRelation4Correct_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.id_StudentInfo, objvcc_WorkStuRelation4Correct_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.StuID) == true)
{
string strComparisonOp_StuID = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.StuID, objvcc_WorkStuRelation4Correct_Cond.StuID, strComparisonOp_StuID);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.StuName) == true)
{
string strComparisonOp_StuName = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.StuName, objvcc_WorkStuRelation4Correct_Cond.StuName, strComparisonOp_StuName);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.id_XzCollege, objvcc_WorkStuRelation4Correct_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.CollegeName, objvcc_WorkStuRelation4Correct_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.id_XzMajor, objvcc_WorkStuRelation4Correct_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.MajorID) == true)
{
string strComparisonOp_MajorID = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.MajorID, objvcc_WorkStuRelation4Correct_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.MajorName) == true)
{
string strComparisonOp_MajorName = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.MajorName, objvcc_WorkStuRelation4Correct_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.id_GradeBase, objvcc_WorkStuRelation4Correct_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.AdminClsId) == true)
{
string strComparisonOp_AdminClsId = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.AdminClsId, objvcc_WorkStuRelation4Correct_Cond.AdminClsId, strComparisonOp_AdminClsId);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.AdminClsName) == true)
{
string strComparisonOp_AdminClsName = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.AdminClsName, objvcc_WorkStuRelation4Correct_Cond.AdminClsName, strComparisonOp_AdminClsName);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.CollegeNameA, objvcc_WorkStuRelation4Correct_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.GradeBaseName, objvcc_WorkStuRelation4Correct_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.QuestionID) == true)
{
string strComparisonOp_QuestionID = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.QuestionID, objvcc_WorkStuRelation4Correct_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.QuestionIndex) == true)
{
string strComparisonOp_QuestionIndex = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation4Correct.QuestionIndex, objvcc_WorkStuRelation4Correct_Cond.QuestionIndex, strComparisonOp_QuestionIndex);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.QuestionName) == true)
{
string strComparisonOp_QuestionName = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.QuestionName, objvcc_WorkStuRelation4Correct_Cond.QuestionName, strComparisonOp_QuestionName);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.CourseChapterId, objvcc_WorkStuRelation4Correct_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.CourseChapterName, objvcc_WorkStuRelation4Correct_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.ChapterName, objvcc_WorkStuRelation4Correct_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.SectionName) == true)
{
string strComparisonOp_SectionName = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.SectionName, objvcc_WorkStuRelation4Correct_Cond.SectionName, strComparisonOp_SectionName);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.ChapterName_Sim, objvcc_WorkStuRelation4Correct_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.SectionName_Sim, objvcc_WorkStuRelation4Correct_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.ParentNodeID, objvcc_WorkStuRelation4Correct_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.CourseChapterReferred) == true)
{
string strComparisonOp_CourseChapterReferred = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.CourseChapterReferred, objvcc_WorkStuRelation4Correct_Cond.CourseChapterReferred, strComparisonOp_CourseChapterReferred);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.ParentNodeName) == true)
{
string strComparisonOp_ParentNodeName = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.ParentNodeName, objvcc_WorkStuRelation4Correct_Cond.ParentNodeName, strComparisonOp_ParentNodeName);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.ParentNodeReferred) == true)
{
string strComparisonOp_ParentNodeReferred = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.ParentNodeReferred, objvcc_WorkStuRelation4Correct_Cond.ParentNodeReferred, strComparisonOp_ParentNodeReferred);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.AnswerAttLimitSize) == true)
{
string strComparisonOp_AnswerAttLimitSize = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.AnswerAttLimitSize];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation4Correct.AnswerAttLimitSize, objvcc_WorkStuRelation4Correct_Cond.AnswerAttLimitSize, strComparisonOp_AnswerAttLimitSize);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.RightId) == true)
{
string strComparisonOp_RightId = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.RightId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.RightId, objvcc_WorkStuRelation4Correct_Cond.RightId, strComparisonOp_RightId);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.RightName) == true)
{
string strComparisonOp_RightName = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.RightName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.RightName, objvcc_WorkStuRelation4Correct_Cond.RightName, strComparisonOp_RightName);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.Authorizer) == true)
{
string strComparisonOp_Authorizer = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.Authorizer];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.Authorizer, objvcc_WorkStuRelation4Correct_Cond.Authorizer, strComparisonOp_Authorizer);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.UpdDate, objvcc_WorkStuRelation4Correct_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.UpdUser, objvcc_WorkStuRelation4Correct_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvcc_WorkStuRelation4Correct_Cond.IsUpdated(convcc_WorkStuRelation4Correct.Memo) == true)
{
string strComparisonOp_Memo = objvcc_WorkStuRelation4Correct_Cond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.Memo, objvcc_WorkStuRelation4Correct_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v学生批改作业关系表(vcc_WorkStuRelation4Correct)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_WorkStuRelation4CorrectWApi
{
private static readonly string mstrApiControllerName = "vcc_WorkStuRelation4CorrectApi";

 public clsvcc_WorkStuRelation4CorrectWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkStuRelation4CorrectEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_WorkStuRelation4CorrectEN = JsonConvert.DeserializeObject<clsvcc_WorkStuRelation4CorrectEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkStuRelation4CorrectEN;
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
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkStuRelation4CorrectEN GetObjBymId_WA_Cache(long lngmId, string strCourseId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString(),
["CourseId"] = strCourseId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_WorkStuRelation4CorrectEN = JsonConvert.DeserializeObject<clsvcc_WorkStuRelation4CorrectEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkStuRelation4CorrectEN;
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
public static clsvcc_WorkStuRelation4CorrectEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN = null;
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
objvcc_WorkStuRelation4CorrectEN = JsonConvert.DeserializeObject<clsvcc_WorkStuRelation4CorrectEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkStuRelation4CorrectEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_WorkStuRelation4CorrectEN GetObjBymId_Cache(long lngmId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_WorkStuRelation4CorrectEN._CurrTabName_S, strCourseId);
List<clsvcc_WorkStuRelation4CorrectEN> arrvcc_WorkStuRelation4CorrectObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvcc_WorkStuRelation4CorrectEN> arrvcc_WorkStuRelation4CorrectObjLst_Sel =
from objvcc_WorkStuRelation4CorrectEN in arrvcc_WorkStuRelation4CorrectObjLst_Cache
where objvcc_WorkStuRelation4CorrectEN.mId == lngmId
select objvcc_WorkStuRelation4CorrectEN;
if (arrvcc_WorkStuRelation4CorrectObjLst_Sel.Count() == 0)
{
   clsvcc_WorkStuRelation4CorrectEN obj = clsvcc_WorkStuRelation4CorrectWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_WorkStuRelation4CorrectObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelation4CorrectEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_WorkStuRelation4CorrectEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation4CorrectEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelation4CorrectEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvcc_WorkStuRelation4CorrectEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation4CorrectEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvcc_WorkStuRelation4CorrectEN> GetObjLstByMIdLst_Cache(List<long> arrMId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_WorkStuRelation4CorrectEN._CurrTabName_S, strCourseId);
List<clsvcc_WorkStuRelation4CorrectEN> arrvcc_WorkStuRelation4CorrectObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvcc_WorkStuRelation4CorrectEN> arrvcc_WorkStuRelation4CorrectObjLst_Sel =
from objvcc_WorkStuRelation4CorrectEN in arrvcc_WorkStuRelation4CorrectObjLst_Cache
where arrMId.Contains(objvcc_WorkStuRelation4CorrectEN.mId)
select objvcc_WorkStuRelation4CorrectEN;
return arrvcc_WorkStuRelation4CorrectObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelation4CorrectEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId, string strCourseId)
{
 List<clsvcc_WorkStuRelation4CorrectEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation4CorrectEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelation4CorrectEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_WorkStuRelation4CorrectEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation4CorrectEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelation4CorrectEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_WorkStuRelation4CorrectEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation4CorrectEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelation4CorrectEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_WorkStuRelation4CorrectEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation4CorrectEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelation4CorrectEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_WorkStuRelation4CorrectEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation4CorrectEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
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
 /// <param name = "objvcc_WorkStuRelation4CorrectENS">源对象</param>
 /// <param name = "objvcc_WorkStuRelation4CorrectENT">目标对象</param>
 public static void CopyTo(clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectENS, clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectENT)
{
try
{
objvcc_WorkStuRelation4CorrectENT.mId = objvcc_WorkStuRelation4CorrectENS.mId; //mId
objvcc_WorkStuRelation4CorrectENT.CourseId = objvcc_WorkStuRelation4CorrectENS.CourseId; //课程Id
objvcc_WorkStuRelation4CorrectENT.CourseName = objvcc_WorkStuRelation4CorrectENS.CourseName; //课程名称
objvcc_WorkStuRelation4CorrectENT.id_StudentInfo = objvcc_WorkStuRelation4CorrectENS.id_StudentInfo; //学生流水号
objvcc_WorkStuRelation4CorrectENT.StuID = objvcc_WorkStuRelation4CorrectENS.StuID; //学号
objvcc_WorkStuRelation4CorrectENT.StuName = objvcc_WorkStuRelation4CorrectENS.StuName; //姓名
objvcc_WorkStuRelation4CorrectENT.id_XzCollege = objvcc_WorkStuRelation4CorrectENS.id_XzCollege; //学院流水号
objvcc_WorkStuRelation4CorrectENT.CollegeName = objvcc_WorkStuRelation4CorrectENS.CollegeName; //学院名称
objvcc_WorkStuRelation4CorrectENT.id_XzMajor = objvcc_WorkStuRelation4CorrectENS.id_XzMajor; //专业流水号
objvcc_WorkStuRelation4CorrectENT.MajorID = objvcc_WorkStuRelation4CorrectENS.MajorID; //专业ID
objvcc_WorkStuRelation4CorrectENT.MajorName = objvcc_WorkStuRelation4CorrectENS.MajorName; //专业名称
objvcc_WorkStuRelation4CorrectENT.id_GradeBase = objvcc_WorkStuRelation4CorrectENS.id_GradeBase; //年级流水号
objvcc_WorkStuRelation4CorrectENT.AdminClsId = objvcc_WorkStuRelation4CorrectENS.AdminClsId; //行政班代号
objvcc_WorkStuRelation4CorrectENT.AdminClsName = objvcc_WorkStuRelation4CorrectENS.AdminClsName; //行政班名称
objvcc_WorkStuRelation4CorrectENT.CollegeNameA = objvcc_WorkStuRelation4CorrectENS.CollegeNameA; //学院名称简写
objvcc_WorkStuRelation4CorrectENT.GradeBaseName = objvcc_WorkStuRelation4CorrectENS.GradeBaseName; //年级名称
objvcc_WorkStuRelation4CorrectENT.QuestionID = objvcc_WorkStuRelation4CorrectENS.QuestionID; //题目ID
objvcc_WorkStuRelation4CorrectENT.QuestionIndex = objvcc_WorkStuRelation4CorrectENS.QuestionIndex; //题目序号
objvcc_WorkStuRelation4CorrectENT.QuestionName = objvcc_WorkStuRelation4CorrectENS.QuestionName; //题目名称
objvcc_WorkStuRelation4CorrectENT.CourseChapterId = objvcc_WorkStuRelation4CorrectENS.CourseChapterId; //课程章节ID
objvcc_WorkStuRelation4CorrectENT.CourseChapterName = objvcc_WorkStuRelation4CorrectENS.CourseChapterName; //课程章节名称
objvcc_WorkStuRelation4CorrectENT.ChapterName = objvcc_WorkStuRelation4CorrectENS.ChapterName; //章名
objvcc_WorkStuRelation4CorrectENT.SectionName = objvcc_WorkStuRelation4CorrectENS.SectionName; //节名
objvcc_WorkStuRelation4CorrectENT.ChapterName_Sim = objvcc_WorkStuRelation4CorrectENS.ChapterName_Sim; //章名简称
objvcc_WorkStuRelation4CorrectENT.SectionName_Sim = objvcc_WorkStuRelation4CorrectENS.SectionName_Sim; //节名简称
objvcc_WorkStuRelation4CorrectENT.ParentNodeID = objvcc_WorkStuRelation4CorrectENS.ParentNodeID; //父节点编号
objvcc_WorkStuRelation4CorrectENT.CourseChapterReferred = objvcc_WorkStuRelation4CorrectENS.CourseChapterReferred; //节简称
objvcc_WorkStuRelation4CorrectENT.ParentNodeName = objvcc_WorkStuRelation4CorrectENS.ParentNodeName; //父节点名称
objvcc_WorkStuRelation4CorrectENT.ParentNodeReferred = objvcc_WorkStuRelation4CorrectENS.ParentNodeReferred; //章简称
objvcc_WorkStuRelation4CorrectENT.AnswerAttLimitSize = objvcc_WorkStuRelation4CorrectENS.AnswerAttLimitSize; //回答附件限制大小
objvcc_WorkStuRelation4CorrectENT.RightId = objvcc_WorkStuRelation4CorrectENS.RightId; //权限编号
objvcc_WorkStuRelation4CorrectENT.RightName = objvcc_WorkStuRelation4CorrectENS.RightName; //权限名称
objvcc_WorkStuRelation4CorrectENT.Authorizer = objvcc_WorkStuRelation4CorrectENS.Authorizer; //授权人
objvcc_WorkStuRelation4CorrectENT.UpdDate = objvcc_WorkStuRelation4CorrectENS.UpdDate; //修改日期
objvcc_WorkStuRelation4CorrectENT.UpdUser = objvcc_WorkStuRelation4CorrectENS.UpdUser; //修改人
objvcc_WorkStuRelation4CorrectENT.Memo = objvcc_WorkStuRelation4CorrectENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvcc_WorkStuRelation4CorrectEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_WorkStuRelation4CorrectEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_WorkStuRelation4CorrectEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_WorkStuRelation4CorrectEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_WorkStuRelation4CorrectEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_WorkStuRelation4CorrectEN.AttributeName)
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
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_WorkStuRelation4CorrectWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkStuRelation4CorrectWApi没有刷新缓存机制(clscc_WorkStuRelation4CorrectWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionnaireWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireWApi没有刷新缓存机制(clsQuestionnaireWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerModeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerModeWApi没有刷新缓存机制(clsAnswerModeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerTypeWApi没有刷新缓存机制(clsAnswerTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeWApi没有刷新缓存机制(clsQuestionTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExamGradeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamGradeWApi没有刷新缓存机制(clscc_ExamGradeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionType4CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionType4CourseWApi没有刷新缓存机制(clsQuestionType4CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzGradeBaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseWApi没有刷新缓存机制(clsXzGradeBaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseChapterWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterWApi没有刷新缓存机制(clscc_CourseChapterWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeWApi没有刷新缓存机制(clscc_CourseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsStudyLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelWApi没有刷新缓存机制(clsStudyLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvcc_WorkStuRelation4CorrectObjLst_Cache == null)
//{
//arrvcc_WorkStuRelation4CorrectObjLst_Cache = await clsvcc_WorkStuRelation4CorrectWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvcc_WorkStuRelation4CorrectEN._CurrTabName_S, strCourseId);
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
public static List<clsvcc_WorkStuRelation4CorrectEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvcc_WorkStuRelation4CorrectEN._CurrTabName_S, strCourseId);
List<clsvcc_WorkStuRelation4CorrectEN> arrvcc_WorkStuRelation4CorrectObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrvcc_WorkStuRelation4CorrectObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_WorkStuRelation4CorrectEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_WorkStuRelation4Correct.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.AdminClsId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.AdminClsName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.QuestionIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.QuestionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.SectionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.CourseChapterReferred, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.ParentNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.ParentNodeReferred, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.AnswerAttLimitSize, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.RightId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.RightName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.Authorizer, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4Correct.Memo, Type.GetType("System.String"));
foreach (clsvcc_WorkStuRelation4CorrectEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_WorkStuRelation4Correct.mId] = objInFor[convcc_WorkStuRelation4Correct.mId];
objDR[convcc_WorkStuRelation4Correct.CourseId] = objInFor[convcc_WorkStuRelation4Correct.CourseId];
objDR[convcc_WorkStuRelation4Correct.CourseName] = objInFor[convcc_WorkStuRelation4Correct.CourseName];
objDR[convcc_WorkStuRelation4Correct.id_StudentInfo] = objInFor[convcc_WorkStuRelation4Correct.id_StudentInfo];
objDR[convcc_WorkStuRelation4Correct.StuID] = objInFor[convcc_WorkStuRelation4Correct.StuID];
objDR[convcc_WorkStuRelation4Correct.StuName] = objInFor[convcc_WorkStuRelation4Correct.StuName];
objDR[convcc_WorkStuRelation4Correct.id_XzCollege] = objInFor[convcc_WorkStuRelation4Correct.id_XzCollege];
objDR[convcc_WorkStuRelation4Correct.CollegeName] = objInFor[convcc_WorkStuRelation4Correct.CollegeName];
objDR[convcc_WorkStuRelation4Correct.id_XzMajor] = objInFor[convcc_WorkStuRelation4Correct.id_XzMajor];
objDR[convcc_WorkStuRelation4Correct.MajorID] = objInFor[convcc_WorkStuRelation4Correct.MajorID];
objDR[convcc_WorkStuRelation4Correct.MajorName] = objInFor[convcc_WorkStuRelation4Correct.MajorName];
objDR[convcc_WorkStuRelation4Correct.id_GradeBase] = objInFor[convcc_WorkStuRelation4Correct.id_GradeBase];
objDR[convcc_WorkStuRelation4Correct.AdminClsId] = objInFor[convcc_WorkStuRelation4Correct.AdminClsId];
objDR[convcc_WorkStuRelation4Correct.AdminClsName] = objInFor[convcc_WorkStuRelation4Correct.AdminClsName];
objDR[convcc_WorkStuRelation4Correct.CollegeNameA] = objInFor[convcc_WorkStuRelation4Correct.CollegeNameA];
objDR[convcc_WorkStuRelation4Correct.GradeBaseName] = objInFor[convcc_WorkStuRelation4Correct.GradeBaseName];
objDR[convcc_WorkStuRelation4Correct.QuestionID] = objInFor[convcc_WorkStuRelation4Correct.QuestionID];
objDR[convcc_WorkStuRelation4Correct.QuestionIndex] = objInFor[convcc_WorkStuRelation4Correct.QuestionIndex];
objDR[convcc_WorkStuRelation4Correct.QuestionName] = objInFor[convcc_WorkStuRelation4Correct.QuestionName];
objDR[convcc_WorkStuRelation4Correct.CourseChapterId] = objInFor[convcc_WorkStuRelation4Correct.CourseChapterId];
objDR[convcc_WorkStuRelation4Correct.CourseChapterName] = objInFor[convcc_WorkStuRelation4Correct.CourseChapterName];
objDR[convcc_WorkStuRelation4Correct.ChapterName] = objInFor[convcc_WorkStuRelation4Correct.ChapterName];
objDR[convcc_WorkStuRelation4Correct.SectionName] = objInFor[convcc_WorkStuRelation4Correct.SectionName];
objDR[convcc_WorkStuRelation4Correct.ChapterName_Sim] = objInFor[convcc_WorkStuRelation4Correct.ChapterName_Sim];
objDR[convcc_WorkStuRelation4Correct.SectionName_Sim] = objInFor[convcc_WorkStuRelation4Correct.SectionName_Sim];
objDR[convcc_WorkStuRelation4Correct.ParentNodeID] = objInFor[convcc_WorkStuRelation4Correct.ParentNodeID];
objDR[convcc_WorkStuRelation4Correct.CourseChapterReferred] = objInFor[convcc_WorkStuRelation4Correct.CourseChapterReferred];
objDR[convcc_WorkStuRelation4Correct.ParentNodeName] = objInFor[convcc_WorkStuRelation4Correct.ParentNodeName];
objDR[convcc_WorkStuRelation4Correct.ParentNodeReferred] = objInFor[convcc_WorkStuRelation4Correct.ParentNodeReferred];
objDR[convcc_WorkStuRelation4Correct.AnswerAttLimitSize] = objInFor[convcc_WorkStuRelation4Correct.AnswerAttLimitSize];
objDR[convcc_WorkStuRelation4Correct.RightId] = objInFor[convcc_WorkStuRelation4Correct.RightId];
objDR[convcc_WorkStuRelation4Correct.RightName] = objInFor[convcc_WorkStuRelation4Correct.RightName];
objDR[convcc_WorkStuRelation4Correct.Authorizer] = objInFor[convcc_WorkStuRelation4Correct.Authorizer];
objDR[convcc_WorkStuRelation4Correct.UpdDate] = objInFor[convcc_WorkStuRelation4Correct.UpdDate];
objDR[convcc_WorkStuRelation4Correct.UpdUser] = objInFor[convcc_WorkStuRelation4Correct.UpdUser];
objDR[convcc_WorkStuRelation4Correct.Memo] = objInFor[convcc_WorkStuRelation4Correct.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}