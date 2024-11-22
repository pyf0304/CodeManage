
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkStuRelation4CorrectBL
 表名:vcc_WorkStuRelation4Correct(01120205)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:15
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
public static class  clsvcc_WorkStuRelation4CorrectBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkStuRelation4CorrectEN GetObj(this K_mId_vcc_WorkStuRelation4Correct myKey)
{
clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN = clsvcc_WorkStuRelation4CorrectBL.vcc_WorkStuRelation4CorrectDA.GetObjBymId(myKey.Value);
return objvcc_WorkStuRelation4CorrectEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetCourseId(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convcc_WorkStuRelation4Correct.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_WorkStuRelation4Correct.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_WorkStuRelation4Correct.CourseId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetCourseName(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_WorkStuRelation4Correct.CourseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetIdStudentInfo(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strIdStudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdStudentInfo, convcc_WorkStuRelation4Correct.IdStudentInfo);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudentInfo, 8, convcc_WorkStuRelation4Correct.IdStudentInfo);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudentInfo, 8, convcc_WorkStuRelation4Correct.IdStudentInfo);
}
objvcc_WorkStuRelation4CorrectEN.IdStudentInfo = strIdStudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.IdStudentInfo) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.IdStudentInfo, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.IdStudentInfo] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetStuID(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strStuID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuID, 20, convcc_WorkStuRelation4Correct.StuID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetStuName(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strStuName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuName, 50, convcc_WorkStuRelation4Correct.StuName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetIdXzCollege(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convcc_WorkStuRelation4Correct.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convcc_WorkStuRelation4Correct.IdXzCollege);
}
objvcc_WorkStuRelation4CorrectEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.IdXzCollege) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.IdXzCollege, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.IdXzCollege] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetCollegeName(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convcc_WorkStuRelation4Correct.CollegeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetIdXzMajor(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convcc_WorkStuRelation4Correct.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convcc_WorkStuRelation4Correct.IdXzMajor);
}
objvcc_WorkStuRelation4CorrectEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.IdXzMajor) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.IdXzMajor, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.IdXzMajor] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetMajorID(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strMajorID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorID, 4, convcc_WorkStuRelation4Correct.MajorID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convcc_WorkStuRelation4Correct.MajorID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetMajorName(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convcc_WorkStuRelation4Correct.MajorName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetIdGradeBase(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strIdGradeBase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, convcc_WorkStuRelation4Correct.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, convcc_WorkStuRelation4Correct.IdGradeBase);
}
objvcc_WorkStuRelation4CorrectEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.IdGradeBase) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.IdGradeBase, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.IdGradeBase] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetCollegeNameA(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convcc_WorkStuRelation4Correct.CollegeNameA);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetGradeBaseName(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strGradeBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convcc_WorkStuRelation4Correct.GradeBaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetQuestionID(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strQuestionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionID, 8, convcc_WorkStuRelation4Correct.QuestionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convcc_WorkStuRelation4Correct.QuestionID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetQuestionIndex(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, int? intQuestionIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetQuestionName(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strQuestionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionName, 500, convcc_WorkStuRelation4Correct.QuestionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetCourseChapterId(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_WorkStuRelation4Correct.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_WorkStuRelation4Correct.CourseChapterId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetCourseChapterName(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strCourseChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_WorkStuRelation4Correct.CourseChapterName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetChapterName(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_WorkStuRelation4Correct.ChapterName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetSectionName(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_WorkStuRelation4Correct.SectionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetChapterNameSim(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strChapterNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterNameSim, 10, convcc_WorkStuRelation4Correct.ChapterNameSim);
}
objvcc_WorkStuRelation4CorrectEN.ChapterNameSim = strChapterNameSim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.ChapterNameSim) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.ChapterNameSim, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.ChapterNameSim] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetSectionNameSim(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strSectionNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionNameSim, 10, convcc_WorkStuRelation4Correct.SectionNameSim);
}
objvcc_WorkStuRelation4CorrectEN.SectionNameSim = strSectionNameSim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4Correct.SectionNameSim) == false)
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4Correct.SectionNameSim, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[convcc_WorkStuRelation4Correct.SectionNameSim] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetParentNodeID(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strParentNodeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convcc_WorkStuRelation4Correct.ParentNodeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetCourseChapterReferred(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strCourseChapterReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convcc_WorkStuRelation4Correct.CourseChapterReferred);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetParentNodeName(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strParentNodeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convcc_WorkStuRelation4Correct.ParentNodeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetParentNodeReferred(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strParentNodeReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convcc_WorkStuRelation4Correct.ParentNodeReferred);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetAnswerAttLimitSize(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, long? lngAnswerAttLimitSize, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetRightId(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strRightId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightId, convcc_WorkStuRelation4Correct.RightId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRightId, 8, convcc_WorkStuRelation4Correct.RightId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRightId, 8, convcc_WorkStuRelation4Correct.RightId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetRightName(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strRightName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRightName, 200, convcc_WorkStuRelation4Correct.RightName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetAuthorizer(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strAuthorizer, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAuthorizer, convcc_WorkStuRelation4Correct.Authorizer);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthorizer, 18, convcc_WorkStuRelation4Correct.Authorizer);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetUpdDate(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_WorkStuRelation4Correct.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetUpdUser(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convcc_WorkStuRelation4Correct.UpdUser);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4CorrectEN SetMemo(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_WorkStuRelation4Correct.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectENS">源对象</param>
 /// <param name = "objvcc_WorkStuRelation4CorrectENT">目标对象</param>
 public static void CopyTo(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectENS, clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectENT)
{
try
{
objvcc_WorkStuRelation4CorrectENT.mId = objvcc_WorkStuRelation4CorrectENS.mId; //mId
objvcc_WorkStuRelation4CorrectENT.CourseId = objvcc_WorkStuRelation4CorrectENS.CourseId; //课程Id
objvcc_WorkStuRelation4CorrectENT.CourseName = objvcc_WorkStuRelation4CorrectENS.CourseName; //课程名称
objvcc_WorkStuRelation4CorrectENT.IdStudentInfo = objvcc_WorkStuRelation4CorrectENS.IdStudentInfo; //学生流水号
objvcc_WorkStuRelation4CorrectENT.StuID = objvcc_WorkStuRelation4CorrectENS.StuID; //学号
objvcc_WorkStuRelation4CorrectENT.StuName = objvcc_WorkStuRelation4CorrectENS.StuName; //姓名
objvcc_WorkStuRelation4CorrectENT.IdXzCollege = objvcc_WorkStuRelation4CorrectENS.IdXzCollege; //学院流水号
objvcc_WorkStuRelation4CorrectENT.CollegeName = objvcc_WorkStuRelation4CorrectENS.CollegeName; //学院名称
objvcc_WorkStuRelation4CorrectENT.IdXzMajor = objvcc_WorkStuRelation4CorrectENS.IdXzMajor; //专业流水号
objvcc_WorkStuRelation4CorrectENT.MajorID = objvcc_WorkStuRelation4CorrectENS.MajorID; //专业ID
objvcc_WorkStuRelation4CorrectENT.MajorName = objvcc_WorkStuRelation4CorrectENS.MajorName; //专业名称
objvcc_WorkStuRelation4CorrectENT.IdGradeBase = objvcc_WorkStuRelation4CorrectENS.IdGradeBase; //年级流水号
objvcc_WorkStuRelation4CorrectENT.CollegeNameA = objvcc_WorkStuRelation4CorrectENS.CollegeNameA; //学院名称简写
objvcc_WorkStuRelation4CorrectENT.GradeBaseName = objvcc_WorkStuRelation4CorrectENS.GradeBaseName; //年级名称
objvcc_WorkStuRelation4CorrectENT.QuestionID = objvcc_WorkStuRelation4CorrectENS.QuestionID; //题目ID
objvcc_WorkStuRelation4CorrectENT.QuestionIndex = objvcc_WorkStuRelation4CorrectENS.QuestionIndex; //题目序号
objvcc_WorkStuRelation4CorrectENT.QuestionName = objvcc_WorkStuRelation4CorrectENS.QuestionName; //题目名称
objvcc_WorkStuRelation4CorrectENT.CourseChapterId = objvcc_WorkStuRelation4CorrectENS.CourseChapterId; //课程章节ID
objvcc_WorkStuRelation4CorrectENT.CourseChapterName = objvcc_WorkStuRelation4CorrectENS.CourseChapterName; //课程章节名称
objvcc_WorkStuRelation4CorrectENT.ChapterName = objvcc_WorkStuRelation4CorrectENS.ChapterName; //章名
objvcc_WorkStuRelation4CorrectENT.SectionName = objvcc_WorkStuRelation4CorrectENS.SectionName; //节名
objvcc_WorkStuRelation4CorrectENT.ChapterNameSim = objvcc_WorkStuRelation4CorrectENS.ChapterNameSim; //章名简称
objvcc_WorkStuRelation4CorrectENT.SectionNameSim = objvcc_WorkStuRelation4CorrectENS.SectionNameSim; //节名简称
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
 /// <param name = "objvcc_WorkStuRelation4CorrectENS">源对象</param>
 /// <returns>目标对象=>clsvcc_WorkStuRelation4CorrectEN:objvcc_WorkStuRelation4CorrectENT</returns>
 public static clsvcc_WorkStuRelation4CorrectEN CopyTo(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectENS)
{
try
{
 clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectENT = new clsvcc_WorkStuRelation4CorrectEN()
{
mId = objvcc_WorkStuRelation4CorrectENS.mId, //mId
CourseId = objvcc_WorkStuRelation4CorrectENS.CourseId, //课程Id
CourseName = objvcc_WorkStuRelation4CorrectENS.CourseName, //课程名称
IdStudentInfo = objvcc_WorkStuRelation4CorrectENS.IdStudentInfo, //学生流水号
StuID = objvcc_WorkStuRelation4CorrectENS.StuID, //学号
StuName = objvcc_WorkStuRelation4CorrectENS.StuName, //姓名
IdXzCollege = objvcc_WorkStuRelation4CorrectENS.IdXzCollege, //学院流水号
CollegeName = objvcc_WorkStuRelation4CorrectENS.CollegeName, //学院名称
IdXzMajor = objvcc_WorkStuRelation4CorrectENS.IdXzMajor, //专业流水号
MajorID = objvcc_WorkStuRelation4CorrectENS.MajorID, //专业ID
MajorName = objvcc_WorkStuRelation4CorrectENS.MajorName, //专业名称
IdGradeBase = objvcc_WorkStuRelation4CorrectENS.IdGradeBase, //年级流水号
CollegeNameA = objvcc_WorkStuRelation4CorrectENS.CollegeNameA, //学院名称简写
GradeBaseName = objvcc_WorkStuRelation4CorrectENS.GradeBaseName, //年级名称
QuestionID = objvcc_WorkStuRelation4CorrectENS.QuestionID, //题目ID
QuestionIndex = objvcc_WorkStuRelation4CorrectENS.QuestionIndex, //题目序号
QuestionName = objvcc_WorkStuRelation4CorrectENS.QuestionName, //题目名称
CourseChapterId = objvcc_WorkStuRelation4CorrectENS.CourseChapterId, //课程章节ID
CourseChapterName = objvcc_WorkStuRelation4CorrectENS.CourseChapterName, //课程章节名称
ChapterName = objvcc_WorkStuRelation4CorrectENS.ChapterName, //章名
SectionName = objvcc_WorkStuRelation4CorrectENS.SectionName, //节名
ChapterNameSim = objvcc_WorkStuRelation4CorrectENS.ChapterNameSim, //章名简称
SectionNameSim = objvcc_WorkStuRelation4CorrectENS.SectionNameSim, //节名简称
ParentNodeID = objvcc_WorkStuRelation4CorrectENS.ParentNodeID, //父节点编号
CourseChapterReferred = objvcc_WorkStuRelation4CorrectENS.CourseChapterReferred, //节简称
ParentNodeName = objvcc_WorkStuRelation4CorrectENS.ParentNodeName, //父节点名称
ParentNodeReferred = objvcc_WorkStuRelation4CorrectENS.ParentNodeReferred, //章简称
AnswerAttLimitSize = objvcc_WorkStuRelation4CorrectENS.AnswerAttLimitSize, //回答附件限制大小
RightId = objvcc_WorkStuRelation4CorrectENS.RightId, //权限编号
RightName = objvcc_WorkStuRelation4CorrectENS.RightName, //权限名称
Authorizer = objvcc_WorkStuRelation4CorrectENS.Authorizer, //授权人
UpdDate = objvcc_WorkStuRelation4CorrectENS.UpdDate, //修改日期
UpdUser = objvcc_WorkStuRelation4CorrectENS.UpdUser, //修改人
Memo = objvcc_WorkStuRelation4CorrectENS.Memo, //备注
};
 return objvcc_WorkStuRelation4CorrectENT;
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
public static void CheckProperty4Condition(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN)
{
 clsvcc_WorkStuRelation4CorrectBL.vcc_WorkStuRelation4CorrectDA.CheckProperty4Condition(objvcc_WorkStuRelation4CorrectEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.mId) == true)
{
string strComparisonOpmId = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation4Correct.mId, objvcc_WorkStuRelation4CorrectCond.mId, strComparisonOpmId);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.CourseId) == true)
{
string strComparisonOpCourseId = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.CourseId, objvcc_WorkStuRelation4CorrectCond.CourseId, strComparisonOpCourseId);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.CourseName) == true)
{
string strComparisonOpCourseName = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.CourseName, objvcc_WorkStuRelation4CorrectCond.CourseName, strComparisonOpCourseName);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.IdStudentInfo) == true)
{
string strComparisonOpIdStudentInfo = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.IdStudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.IdStudentInfo, objvcc_WorkStuRelation4CorrectCond.IdStudentInfo, strComparisonOpIdStudentInfo);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.StuID) == true)
{
string strComparisonOpStuID = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.StuID, objvcc_WorkStuRelation4CorrectCond.StuID, strComparisonOpStuID);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.StuName) == true)
{
string strComparisonOpStuName = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.StuName, objvcc_WorkStuRelation4CorrectCond.StuName, strComparisonOpStuName);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.IdXzCollege, objvcc_WorkStuRelation4CorrectCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.CollegeName) == true)
{
string strComparisonOpCollegeName = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.CollegeName, objvcc_WorkStuRelation4CorrectCond.CollegeName, strComparisonOpCollegeName);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.IdXzMajor, objvcc_WorkStuRelation4CorrectCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.MajorID) == true)
{
string strComparisonOpMajorID = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.MajorID, objvcc_WorkStuRelation4CorrectCond.MajorID, strComparisonOpMajorID);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.MajorName) == true)
{
string strComparisonOpMajorName = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.MajorName, objvcc_WorkStuRelation4CorrectCond.MajorName, strComparisonOpMajorName);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.IdGradeBase, objvcc_WorkStuRelation4CorrectCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.CollegeNameA, objvcc_WorkStuRelation4CorrectCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.GradeBaseName) == true)
{
string strComparisonOpGradeBaseName = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.GradeBaseName, objvcc_WorkStuRelation4CorrectCond.GradeBaseName, strComparisonOpGradeBaseName);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.QuestionID) == true)
{
string strComparisonOpQuestionID = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.QuestionID, objvcc_WorkStuRelation4CorrectCond.QuestionID, strComparisonOpQuestionID);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.QuestionIndex) == true)
{
string strComparisonOpQuestionIndex = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation4Correct.QuestionIndex, objvcc_WorkStuRelation4CorrectCond.QuestionIndex, strComparisonOpQuestionIndex);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.QuestionName) == true)
{
string strComparisonOpQuestionName = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.QuestionName, objvcc_WorkStuRelation4CorrectCond.QuestionName, strComparisonOpQuestionName);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.CourseChapterId, objvcc_WorkStuRelation4CorrectCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.CourseChapterName) == true)
{
string strComparisonOpCourseChapterName = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.CourseChapterName, objvcc_WorkStuRelation4CorrectCond.CourseChapterName, strComparisonOpCourseChapterName);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.ChapterName) == true)
{
string strComparisonOpChapterName = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.ChapterName, objvcc_WorkStuRelation4CorrectCond.ChapterName, strComparisonOpChapterName);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.SectionName) == true)
{
string strComparisonOpSectionName = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.SectionName, objvcc_WorkStuRelation4CorrectCond.SectionName, strComparisonOpSectionName);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.ChapterNameSim) == true)
{
string strComparisonOpChapterNameSim = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.ChapterNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.ChapterNameSim, objvcc_WorkStuRelation4CorrectCond.ChapterNameSim, strComparisonOpChapterNameSim);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.SectionNameSim) == true)
{
string strComparisonOpSectionNameSim = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.SectionNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.SectionNameSim, objvcc_WorkStuRelation4CorrectCond.SectionNameSim, strComparisonOpSectionNameSim);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.ParentNodeID) == true)
{
string strComparisonOpParentNodeID = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.ParentNodeID, objvcc_WorkStuRelation4CorrectCond.ParentNodeID, strComparisonOpParentNodeID);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.CourseChapterReferred) == true)
{
string strComparisonOpCourseChapterReferred = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.CourseChapterReferred, objvcc_WorkStuRelation4CorrectCond.CourseChapterReferred, strComparisonOpCourseChapterReferred);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.ParentNodeName) == true)
{
string strComparisonOpParentNodeName = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.ParentNodeName, objvcc_WorkStuRelation4CorrectCond.ParentNodeName, strComparisonOpParentNodeName);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.ParentNodeReferred) == true)
{
string strComparisonOpParentNodeReferred = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.ParentNodeReferred, objvcc_WorkStuRelation4CorrectCond.ParentNodeReferred, strComparisonOpParentNodeReferred);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.AnswerAttLimitSize) == true)
{
string strComparisonOpAnswerAttLimitSize = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.AnswerAttLimitSize];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation4Correct.AnswerAttLimitSize, objvcc_WorkStuRelation4CorrectCond.AnswerAttLimitSize, strComparisonOpAnswerAttLimitSize);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.RightId) == true)
{
string strComparisonOpRightId = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.RightId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.RightId, objvcc_WorkStuRelation4CorrectCond.RightId, strComparisonOpRightId);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.RightName) == true)
{
string strComparisonOpRightName = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.RightName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.RightName, objvcc_WorkStuRelation4CorrectCond.RightName, strComparisonOpRightName);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.Authorizer) == true)
{
string strComparisonOpAuthorizer = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.Authorizer];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.Authorizer, objvcc_WorkStuRelation4CorrectCond.Authorizer, strComparisonOpAuthorizer);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.UpdDate) == true)
{
string strComparisonOpUpdDate = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.UpdDate, objvcc_WorkStuRelation4CorrectCond.UpdDate, strComparisonOpUpdDate);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.UpdUser) == true)
{
string strComparisonOpUpdUser = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.UpdUser, objvcc_WorkStuRelation4CorrectCond.UpdUser, strComparisonOpUpdUser);
}
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(convcc_WorkStuRelation4Correct.Memo) == true)
{
string strComparisonOpMemo = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[convcc_WorkStuRelation4Correct.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4Correct.Memo, objvcc_WorkStuRelation4CorrectCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcc_WorkStuRelation4Correct
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v学生批改作业关系表(vcc_WorkStuRelation4Correct)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcc_WorkStuRelation4CorrectBL
{
public static RelatedActions_vcc_WorkStuRelation4Correct relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcc_WorkStuRelation4CorrectDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcc_WorkStuRelation4CorrectDA vcc_WorkStuRelation4CorrectDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcc_WorkStuRelation4CorrectDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcc_WorkStuRelation4CorrectBL()
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
if (string.IsNullOrEmpty(clsvcc_WorkStuRelation4CorrectEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_WorkStuRelation4CorrectEN._ConnectString);
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
public static DataTable GetDataTable_vcc_WorkStuRelation4Correct(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcc_WorkStuRelation4CorrectDA.GetDataTable_vcc_WorkStuRelation4Correct(strWhereCond);
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
objDT = vcc_WorkStuRelation4CorrectDA.GetDataTable(strWhereCond);
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
objDT = vcc_WorkStuRelation4CorrectDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcc_WorkStuRelation4CorrectDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcc_WorkStuRelation4CorrectDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcc_WorkStuRelation4CorrectDA.GetDataTable_Top(objTopPara);
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
objDT = vcc_WorkStuRelation4CorrectDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcc_WorkStuRelation4CorrectDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcc_WorkStuRelation4CorrectDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvcc_WorkStuRelation4CorrectEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvcc_WorkStuRelation4CorrectEN> arrObjLst = new List<clsvcc_WorkStuRelation4CorrectEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN = new clsvcc_WorkStuRelation4CorrectEN();
try
{
objvcc_WorkStuRelation4CorrectEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4Correct.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4CorrectEN.CourseId = objRow[convcc_WorkStuRelation4Correct.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4CorrectEN.CourseName = objRow[convcc_WorkStuRelation4Correct.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4CorrectEN.IdStudentInfo = objRow[convcc_WorkStuRelation4Correct.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4CorrectEN.StuID = objRow[convcc_WorkStuRelation4Correct.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4CorrectEN.StuName = objRow[convcc_WorkStuRelation4Correct.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4CorrectEN.IdXzCollege = objRow[convcc_WorkStuRelation4Correct.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4CorrectEN.CollegeName = objRow[convcc_WorkStuRelation4Correct.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4CorrectEN.IdXzMajor = objRow[convcc_WorkStuRelation4Correct.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4CorrectEN.MajorID = objRow[convcc_WorkStuRelation4Correct.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4CorrectEN.MajorName = objRow[convcc_WorkStuRelation4Correct.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4CorrectEN.IdGradeBase = objRow[convcc_WorkStuRelation4Correct.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4CorrectEN.CollegeNameA = objRow[convcc_WorkStuRelation4Correct.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4CorrectEN.GradeBaseName = objRow[convcc_WorkStuRelation4Correct.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4CorrectEN.QuestionID = objRow[convcc_WorkStuRelation4Correct.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4CorrectEN.QuestionIndex = objRow[convcc_WorkStuRelation4Correct.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4Correct.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4CorrectEN.QuestionName = objRow[convcc_WorkStuRelation4Correct.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4CorrectEN.CourseChapterId = objRow[convcc_WorkStuRelation4Correct.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4CorrectEN.CourseChapterName = objRow[convcc_WorkStuRelation4Correct.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4CorrectEN.ChapterName = objRow[convcc_WorkStuRelation4Correct.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4CorrectEN.SectionName = objRow[convcc_WorkStuRelation4Correct.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4CorrectEN.ChapterNameSim = objRow[convcc_WorkStuRelation4Correct.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4CorrectEN.SectionNameSim = objRow[convcc_WorkStuRelation4Correct.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4CorrectEN.ParentNodeID = objRow[convcc_WorkStuRelation4Correct.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4CorrectEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4Correct.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4CorrectEN.ParentNodeName = objRow[convcc_WorkStuRelation4Correct.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4CorrectEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4Correct.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4CorrectEN.AnswerAttLimitSize = objRow[convcc_WorkStuRelation4Correct.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4Correct.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkStuRelation4CorrectEN.RightId = objRow[convcc_WorkStuRelation4Correct.RightId].ToString().Trim(); //权限编号
objvcc_WorkStuRelation4CorrectEN.RightName = objRow[convcc_WorkStuRelation4Correct.RightName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.RightName].ToString().Trim(); //权限名称
objvcc_WorkStuRelation4CorrectEN.Authorizer = objRow[convcc_WorkStuRelation4Correct.Authorizer].ToString().Trim(); //授权人
objvcc_WorkStuRelation4CorrectEN.UpdDate = objRow[convcc_WorkStuRelation4Correct.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4CorrectEN.UpdUser = objRow[convcc_WorkStuRelation4Correct.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4CorrectEN.Memo = objRow[convcc_WorkStuRelation4Correct.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelation4CorrectEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelation4CorrectEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcc_WorkStuRelation4CorrectEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsvcc_WorkStuRelation4CorrectEN._CurrTabName, strCourseId);
List<clsvcc_WorkStuRelation4CorrectEN> arrvcc_WorkStuRelation4CorrectObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_WorkStuRelation4CorrectEN> arrvcc_WorkStuRelation4CorrectObjLst_Sel =
arrvcc_WorkStuRelation4CorrectObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvcc_WorkStuRelation4CorrectObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelation4CorrectEN> GetObjLst(string strWhereCond)
{
List<clsvcc_WorkStuRelation4CorrectEN> arrObjLst = new List<clsvcc_WorkStuRelation4CorrectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN = new clsvcc_WorkStuRelation4CorrectEN();
try
{
objvcc_WorkStuRelation4CorrectEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4Correct.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4CorrectEN.CourseId = objRow[convcc_WorkStuRelation4Correct.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4CorrectEN.CourseName = objRow[convcc_WorkStuRelation4Correct.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4CorrectEN.IdStudentInfo = objRow[convcc_WorkStuRelation4Correct.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4CorrectEN.StuID = objRow[convcc_WorkStuRelation4Correct.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4CorrectEN.StuName = objRow[convcc_WorkStuRelation4Correct.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4CorrectEN.IdXzCollege = objRow[convcc_WorkStuRelation4Correct.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4CorrectEN.CollegeName = objRow[convcc_WorkStuRelation4Correct.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4CorrectEN.IdXzMajor = objRow[convcc_WorkStuRelation4Correct.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4CorrectEN.MajorID = objRow[convcc_WorkStuRelation4Correct.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4CorrectEN.MajorName = objRow[convcc_WorkStuRelation4Correct.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4CorrectEN.IdGradeBase = objRow[convcc_WorkStuRelation4Correct.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4CorrectEN.CollegeNameA = objRow[convcc_WorkStuRelation4Correct.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4CorrectEN.GradeBaseName = objRow[convcc_WorkStuRelation4Correct.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4CorrectEN.QuestionID = objRow[convcc_WorkStuRelation4Correct.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4CorrectEN.QuestionIndex = objRow[convcc_WorkStuRelation4Correct.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4Correct.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4CorrectEN.QuestionName = objRow[convcc_WorkStuRelation4Correct.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4CorrectEN.CourseChapterId = objRow[convcc_WorkStuRelation4Correct.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4CorrectEN.CourseChapterName = objRow[convcc_WorkStuRelation4Correct.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4CorrectEN.ChapterName = objRow[convcc_WorkStuRelation4Correct.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4CorrectEN.SectionName = objRow[convcc_WorkStuRelation4Correct.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4CorrectEN.ChapterNameSim = objRow[convcc_WorkStuRelation4Correct.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4CorrectEN.SectionNameSim = objRow[convcc_WorkStuRelation4Correct.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4CorrectEN.ParentNodeID = objRow[convcc_WorkStuRelation4Correct.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4CorrectEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4Correct.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4CorrectEN.ParentNodeName = objRow[convcc_WorkStuRelation4Correct.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4CorrectEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4Correct.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4CorrectEN.AnswerAttLimitSize = objRow[convcc_WorkStuRelation4Correct.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4Correct.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkStuRelation4CorrectEN.RightId = objRow[convcc_WorkStuRelation4Correct.RightId].ToString().Trim(); //权限编号
objvcc_WorkStuRelation4CorrectEN.RightName = objRow[convcc_WorkStuRelation4Correct.RightName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.RightName].ToString().Trim(); //权限名称
objvcc_WorkStuRelation4CorrectEN.Authorizer = objRow[convcc_WorkStuRelation4Correct.Authorizer].ToString().Trim(); //授权人
objvcc_WorkStuRelation4CorrectEN.UpdDate = objRow[convcc_WorkStuRelation4Correct.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4CorrectEN.UpdUser = objRow[convcc_WorkStuRelation4Correct.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4CorrectEN.Memo = objRow[convcc_WorkStuRelation4Correct.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelation4CorrectEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelation4CorrectEN);
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
public static List<clsvcc_WorkStuRelation4CorrectEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcc_WorkStuRelation4CorrectEN> arrObjLst = new List<clsvcc_WorkStuRelation4CorrectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN = new clsvcc_WorkStuRelation4CorrectEN();
try
{
objvcc_WorkStuRelation4CorrectEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4Correct.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4CorrectEN.CourseId = objRow[convcc_WorkStuRelation4Correct.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4CorrectEN.CourseName = objRow[convcc_WorkStuRelation4Correct.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4CorrectEN.IdStudentInfo = objRow[convcc_WorkStuRelation4Correct.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4CorrectEN.StuID = objRow[convcc_WorkStuRelation4Correct.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4CorrectEN.StuName = objRow[convcc_WorkStuRelation4Correct.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4CorrectEN.IdXzCollege = objRow[convcc_WorkStuRelation4Correct.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4CorrectEN.CollegeName = objRow[convcc_WorkStuRelation4Correct.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4CorrectEN.IdXzMajor = objRow[convcc_WorkStuRelation4Correct.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4CorrectEN.MajorID = objRow[convcc_WorkStuRelation4Correct.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4CorrectEN.MajorName = objRow[convcc_WorkStuRelation4Correct.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4CorrectEN.IdGradeBase = objRow[convcc_WorkStuRelation4Correct.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4CorrectEN.CollegeNameA = objRow[convcc_WorkStuRelation4Correct.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4CorrectEN.GradeBaseName = objRow[convcc_WorkStuRelation4Correct.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4CorrectEN.QuestionID = objRow[convcc_WorkStuRelation4Correct.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4CorrectEN.QuestionIndex = objRow[convcc_WorkStuRelation4Correct.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4Correct.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4CorrectEN.QuestionName = objRow[convcc_WorkStuRelation4Correct.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4CorrectEN.CourseChapterId = objRow[convcc_WorkStuRelation4Correct.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4CorrectEN.CourseChapterName = objRow[convcc_WorkStuRelation4Correct.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4CorrectEN.ChapterName = objRow[convcc_WorkStuRelation4Correct.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4CorrectEN.SectionName = objRow[convcc_WorkStuRelation4Correct.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4CorrectEN.ChapterNameSim = objRow[convcc_WorkStuRelation4Correct.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4CorrectEN.SectionNameSim = objRow[convcc_WorkStuRelation4Correct.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4CorrectEN.ParentNodeID = objRow[convcc_WorkStuRelation4Correct.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4CorrectEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4Correct.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4CorrectEN.ParentNodeName = objRow[convcc_WorkStuRelation4Correct.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4CorrectEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4Correct.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4CorrectEN.AnswerAttLimitSize = objRow[convcc_WorkStuRelation4Correct.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4Correct.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkStuRelation4CorrectEN.RightId = objRow[convcc_WorkStuRelation4Correct.RightId].ToString().Trim(); //权限编号
objvcc_WorkStuRelation4CorrectEN.RightName = objRow[convcc_WorkStuRelation4Correct.RightName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.RightName].ToString().Trim(); //权限名称
objvcc_WorkStuRelation4CorrectEN.Authorizer = objRow[convcc_WorkStuRelation4Correct.Authorizer].ToString().Trim(); //授权人
objvcc_WorkStuRelation4CorrectEN.UpdDate = objRow[convcc_WorkStuRelation4Correct.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4CorrectEN.UpdUser = objRow[convcc_WorkStuRelation4Correct.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4CorrectEN.Memo = objRow[convcc_WorkStuRelation4Correct.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelation4CorrectEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelation4CorrectEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcc_WorkStuRelation4CorrectEN> GetSubObjLstCache(clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectCond)
{
 string strCourseId = objvcc_WorkStuRelation4CorrectCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvcc_WorkStuRelation4CorrectBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvcc_WorkStuRelation4CorrectEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_WorkStuRelation4CorrectEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_WorkStuRelation4Correct.AttributeName)
{
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(strFldName) == false) continue;
if (objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkStuRelation4CorrectCond[strFldName].ToString());
}
else
{
if (objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkStuRelation4CorrectCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_WorkStuRelation4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_WorkStuRelation4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_WorkStuRelation4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_WorkStuRelation4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_WorkStuRelation4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_WorkStuRelation4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_WorkStuRelation4CorrectCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_WorkStuRelation4CorrectCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_WorkStuRelation4CorrectCond[strFldName]));
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
public static List<clsvcc_WorkStuRelation4CorrectEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcc_WorkStuRelation4CorrectEN> arrObjLst = new List<clsvcc_WorkStuRelation4CorrectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN = new clsvcc_WorkStuRelation4CorrectEN();
try
{
objvcc_WorkStuRelation4CorrectEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4Correct.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4CorrectEN.CourseId = objRow[convcc_WorkStuRelation4Correct.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4CorrectEN.CourseName = objRow[convcc_WorkStuRelation4Correct.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4CorrectEN.IdStudentInfo = objRow[convcc_WorkStuRelation4Correct.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4CorrectEN.StuID = objRow[convcc_WorkStuRelation4Correct.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4CorrectEN.StuName = objRow[convcc_WorkStuRelation4Correct.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4CorrectEN.IdXzCollege = objRow[convcc_WorkStuRelation4Correct.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4CorrectEN.CollegeName = objRow[convcc_WorkStuRelation4Correct.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4CorrectEN.IdXzMajor = objRow[convcc_WorkStuRelation4Correct.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4CorrectEN.MajorID = objRow[convcc_WorkStuRelation4Correct.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4CorrectEN.MajorName = objRow[convcc_WorkStuRelation4Correct.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4CorrectEN.IdGradeBase = objRow[convcc_WorkStuRelation4Correct.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4CorrectEN.CollegeNameA = objRow[convcc_WorkStuRelation4Correct.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4CorrectEN.GradeBaseName = objRow[convcc_WorkStuRelation4Correct.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4CorrectEN.QuestionID = objRow[convcc_WorkStuRelation4Correct.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4CorrectEN.QuestionIndex = objRow[convcc_WorkStuRelation4Correct.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4Correct.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4CorrectEN.QuestionName = objRow[convcc_WorkStuRelation4Correct.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4CorrectEN.CourseChapterId = objRow[convcc_WorkStuRelation4Correct.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4CorrectEN.CourseChapterName = objRow[convcc_WorkStuRelation4Correct.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4CorrectEN.ChapterName = objRow[convcc_WorkStuRelation4Correct.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4CorrectEN.SectionName = objRow[convcc_WorkStuRelation4Correct.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4CorrectEN.ChapterNameSim = objRow[convcc_WorkStuRelation4Correct.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4CorrectEN.SectionNameSim = objRow[convcc_WorkStuRelation4Correct.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4CorrectEN.ParentNodeID = objRow[convcc_WorkStuRelation4Correct.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4CorrectEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4Correct.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4CorrectEN.ParentNodeName = objRow[convcc_WorkStuRelation4Correct.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4CorrectEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4Correct.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4CorrectEN.AnswerAttLimitSize = objRow[convcc_WorkStuRelation4Correct.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4Correct.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkStuRelation4CorrectEN.RightId = objRow[convcc_WorkStuRelation4Correct.RightId].ToString().Trim(); //权限编号
objvcc_WorkStuRelation4CorrectEN.RightName = objRow[convcc_WorkStuRelation4Correct.RightName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.RightName].ToString().Trim(); //权限名称
objvcc_WorkStuRelation4CorrectEN.Authorizer = objRow[convcc_WorkStuRelation4Correct.Authorizer].ToString().Trim(); //授权人
objvcc_WorkStuRelation4CorrectEN.UpdDate = objRow[convcc_WorkStuRelation4Correct.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4CorrectEN.UpdUser = objRow[convcc_WorkStuRelation4Correct.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4CorrectEN.Memo = objRow[convcc_WorkStuRelation4Correct.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelation4CorrectEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelation4CorrectEN);
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
public static List<clsvcc_WorkStuRelation4CorrectEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcc_WorkStuRelation4CorrectEN> arrObjLst = new List<clsvcc_WorkStuRelation4CorrectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN = new clsvcc_WorkStuRelation4CorrectEN();
try
{
objvcc_WorkStuRelation4CorrectEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4Correct.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4CorrectEN.CourseId = objRow[convcc_WorkStuRelation4Correct.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4CorrectEN.CourseName = objRow[convcc_WorkStuRelation4Correct.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4CorrectEN.IdStudentInfo = objRow[convcc_WorkStuRelation4Correct.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4CorrectEN.StuID = objRow[convcc_WorkStuRelation4Correct.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4CorrectEN.StuName = objRow[convcc_WorkStuRelation4Correct.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4CorrectEN.IdXzCollege = objRow[convcc_WorkStuRelation4Correct.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4CorrectEN.CollegeName = objRow[convcc_WorkStuRelation4Correct.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4CorrectEN.IdXzMajor = objRow[convcc_WorkStuRelation4Correct.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4CorrectEN.MajorID = objRow[convcc_WorkStuRelation4Correct.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4CorrectEN.MajorName = objRow[convcc_WorkStuRelation4Correct.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4CorrectEN.IdGradeBase = objRow[convcc_WorkStuRelation4Correct.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4CorrectEN.CollegeNameA = objRow[convcc_WorkStuRelation4Correct.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4CorrectEN.GradeBaseName = objRow[convcc_WorkStuRelation4Correct.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4CorrectEN.QuestionID = objRow[convcc_WorkStuRelation4Correct.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4CorrectEN.QuestionIndex = objRow[convcc_WorkStuRelation4Correct.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4Correct.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4CorrectEN.QuestionName = objRow[convcc_WorkStuRelation4Correct.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4CorrectEN.CourseChapterId = objRow[convcc_WorkStuRelation4Correct.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4CorrectEN.CourseChapterName = objRow[convcc_WorkStuRelation4Correct.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4CorrectEN.ChapterName = objRow[convcc_WorkStuRelation4Correct.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4CorrectEN.SectionName = objRow[convcc_WorkStuRelation4Correct.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4CorrectEN.ChapterNameSim = objRow[convcc_WorkStuRelation4Correct.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4CorrectEN.SectionNameSim = objRow[convcc_WorkStuRelation4Correct.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4CorrectEN.ParentNodeID = objRow[convcc_WorkStuRelation4Correct.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4CorrectEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4Correct.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4CorrectEN.ParentNodeName = objRow[convcc_WorkStuRelation4Correct.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4CorrectEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4Correct.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4CorrectEN.AnswerAttLimitSize = objRow[convcc_WorkStuRelation4Correct.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4Correct.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkStuRelation4CorrectEN.RightId = objRow[convcc_WorkStuRelation4Correct.RightId].ToString().Trim(); //权限编号
objvcc_WorkStuRelation4CorrectEN.RightName = objRow[convcc_WorkStuRelation4Correct.RightName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.RightName].ToString().Trim(); //权限名称
objvcc_WorkStuRelation4CorrectEN.Authorizer = objRow[convcc_WorkStuRelation4Correct.Authorizer].ToString().Trim(); //授权人
objvcc_WorkStuRelation4CorrectEN.UpdDate = objRow[convcc_WorkStuRelation4Correct.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4CorrectEN.UpdUser = objRow[convcc_WorkStuRelation4Correct.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4CorrectEN.Memo = objRow[convcc_WorkStuRelation4Correct.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelation4CorrectEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelation4CorrectEN);
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
List<clsvcc_WorkStuRelation4CorrectEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcc_WorkStuRelation4CorrectEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelation4CorrectEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcc_WorkStuRelation4CorrectEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_WorkStuRelation4CorrectEN> arrObjLst = new List<clsvcc_WorkStuRelation4CorrectEN>(); 
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
	clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN = new clsvcc_WorkStuRelation4CorrectEN();
try
{
objvcc_WorkStuRelation4CorrectEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4Correct.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4CorrectEN.CourseId = objRow[convcc_WorkStuRelation4Correct.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4CorrectEN.CourseName = objRow[convcc_WorkStuRelation4Correct.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4CorrectEN.IdStudentInfo = objRow[convcc_WorkStuRelation4Correct.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4CorrectEN.StuID = objRow[convcc_WorkStuRelation4Correct.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4CorrectEN.StuName = objRow[convcc_WorkStuRelation4Correct.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4CorrectEN.IdXzCollege = objRow[convcc_WorkStuRelation4Correct.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4CorrectEN.CollegeName = objRow[convcc_WorkStuRelation4Correct.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4CorrectEN.IdXzMajor = objRow[convcc_WorkStuRelation4Correct.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4CorrectEN.MajorID = objRow[convcc_WorkStuRelation4Correct.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4CorrectEN.MajorName = objRow[convcc_WorkStuRelation4Correct.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4CorrectEN.IdGradeBase = objRow[convcc_WorkStuRelation4Correct.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4CorrectEN.CollegeNameA = objRow[convcc_WorkStuRelation4Correct.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4CorrectEN.GradeBaseName = objRow[convcc_WorkStuRelation4Correct.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4CorrectEN.QuestionID = objRow[convcc_WorkStuRelation4Correct.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4CorrectEN.QuestionIndex = objRow[convcc_WorkStuRelation4Correct.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4Correct.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4CorrectEN.QuestionName = objRow[convcc_WorkStuRelation4Correct.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4CorrectEN.CourseChapterId = objRow[convcc_WorkStuRelation4Correct.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4CorrectEN.CourseChapterName = objRow[convcc_WorkStuRelation4Correct.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4CorrectEN.ChapterName = objRow[convcc_WorkStuRelation4Correct.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4CorrectEN.SectionName = objRow[convcc_WorkStuRelation4Correct.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4CorrectEN.ChapterNameSim = objRow[convcc_WorkStuRelation4Correct.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4CorrectEN.SectionNameSim = objRow[convcc_WorkStuRelation4Correct.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4CorrectEN.ParentNodeID = objRow[convcc_WorkStuRelation4Correct.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4CorrectEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4Correct.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4CorrectEN.ParentNodeName = objRow[convcc_WorkStuRelation4Correct.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4CorrectEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4Correct.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4CorrectEN.AnswerAttLimitSize = objRow[convcc_WorkStuRelation4Correct.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4Correct.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkStuRelation4CorrectEN.RightId = objRow[convcc_WorkStuRelation4Correct.RightId].ToString().Trim(); //权限编号
objvcc_WorkStuRelation4CorrectEN.RightName = objRow[convcc_WorkStuRelation4Correct.RightName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.RightName].ToString().Trim(); //权限名称
objvcc_WorkStuRelation4CorrectEN.Authorizer = objRow[convcc_WorkStuRelation4Correct.Authorizer].ToString().Trim(); //授权人
objvcc_WorkStuRelation4CorrectEN.UpdDate = objRow[convcc_WorkStuRelation4Correct.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4CorrectEN.UpdUser = objRow[convcc_WorkStuRelation4Correct.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4CorrectEN.Memo = objRow[convcc_WorkStuRelation4Correct.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelation4CorrectEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelation4CorrectEN);
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
public static List<clsvcc_WorkStuRelation4CorrectEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcc_WorkStuRelation4CorrectEN> arrObjLst = new List<clsvcc_WorkStuRelation4CorrectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN = new clsvcc_WorkStuRelation4CorrectEN();
try
{
objvcc_WorkStuRelation4CorrectEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4Correct.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4CorrectEN.CourseId = objRow[convcc_WorkStuRelation4Correct.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4CorrectEN.CourseName = objRow[convcc_WorkStuRelation4Correct.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4CorrectEN.IdStudentInfo = objRow[convcc_WorkStuRelation4Correct.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4CorrectEN.StuID = objRow[convcc_WorkStuRelation4Correct.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4CorrectEN.StuName = objRow[convcc_WorkStuRelation4Correct.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4CorrectEN.IdXzCollege = objRow[convcc_WorkStuRelation4Correct.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4CorrectEN.CollegeName = objRow[convcc_WorkStuRelation4Correct.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4CorrectEN.IdXzMajor = objRow[convcc_WorkStuRelation4Correct.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4CorrectEN.MajorID = objRow[convcc_WorkStuRelation4Correct.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4CorrectEN.MajorName = objRow[convcc_WorkStuRelation4Correct.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4CorrectEN.IdGradeBase = objRow[convcc_WorkStuRelation4Correct.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4CorrectEN.CollegeNameA = objRow[convcc_WorkStuRelation4Correct.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4CorrectEN.GradeBaseName = objRow[convcc_WorkStuRelation4Correct.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4CorrectEN.QuestionID = objRow[convcc_WorkStuRelation4Correct.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4CorrectEN.QuestionIndex = objRow[convcc_WorkStuRelation4Correct.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4Correct.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4CorrectEN.QuestionName = objRow[convcc_WorkStuRelation4Correct.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4CorrectEN.CourseChapterId = objRow[convcc_WorkStuRelation4Correct.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4CorrectEN.CourseChapterName = objRow[convcc_WorkStuRelation4Correct.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4CorrectEN.ChapterName = objRow[convcc_WorkStuRelation4Correct.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4CorrectEN.SectionName = objRow[convcc_WorkStuRelation4Correct.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4CorrectEN.ChapterNameSim = objRow[convcc_WorkStuRelation4Correct.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4CorrectEN.SectionNameSim = objRow[convcc_WorkStuRelation4Correct.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4CorrectEN.ParentNodeID = objRow[convcc_WorkStuRelation4Correct.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4CorrectEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4Correct.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4CorrectEN.ParentNodeName = objRow[convcc_WorkStuRelation4Correct.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4CorrectEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4Correct.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4CorrectEN.AnswerAttLimitSize = objRow[convcc_WorkStuRelation4Correct.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4Correct.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkStuRelation4CorrectEN.RightId = objRow[convcc_WorkStuRelation4Correct.RightId].ToString().Trim(); //权限编号
objvcc_WorkStuRelation4CorrectEN.RightName = objRow[convcc_WorkStuRelation4Correct.RightName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.RightName].ToString().Trim(); //权限名称
objvcc_WorkStuRelation4CorrectEN.Authorizer = objRow[convcc_WorkStuRelation4Correct.Authorizer].ToString().Trim(); //授权人
objvcc_WorkStuRelation4CorrectEN.UpdDate = objRow[convcc_WorkStuRelation4Correct.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4CorrectEN.UpdUser = objRow[convcc_WorkStuRelation4Correct.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4CorrectEN.Memo = objRow[convcc_WorkStuRelation4Correct.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelation4CorrectEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelation4CorrectEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcc_WorkStuRelation4CorrectEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcc_WorkStuRelation4CorrectEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_WorkStuRelation4CorrectEN> arrObjLst = new List<clsvcc_WorkStuRelation4CorrectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN = new clsvcc_WorkStuRelation4CorrectEN();
try
{
objvcc_WorkStuRelation4CorrectEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4Correct.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4CorrectEN.CourseId = objRow[convcc_WorkStuRelation4Correct.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4CorrectEN.CourseName = objRow[convcc_WorkStuRelation4Correct.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4CorrectEN.IdStudentInfo = objRow[convcc_WorkStuRelation4Correct.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4CorrectEN.StuID = objRow[convcc_WorkStuRelation4Correct.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4CorrectEN.StuName = objRow[convcc_WorkStuRelation4Correct.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4CorrectEN.IdXzCollege = objRow[convcc_WorkStuRelation4Correct.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4CorrectEN.CollegeName = objRow[convcc_WorkStuRelation4Correct.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4CorrectEN.IdXzMajor = objRow[convcc_WorkStuRelation4Correct.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4CorrectEN.MajorID = objRow[convcc_WorkStuRelation4Correct.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4CorrectEN.MajorName = objRow[convcc_WorkStuRelation4Correct.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4CorrectEN.IdGradeBase = objRow[convcc_WorkStuRelation4Correct.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4CorrectEN.CollegeNameA = objRow[convcc_WorkStuRelation4Correct.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4CorrectEN.GradeBaseName = objRow[convcc_WorkStuRelation4Correct.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4CorrectEN.QuestionID = objRow[convcc_WorkStuRelation4Correct.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4CorrectEN.QuestionIndex = objRow[convcc_WorkStuRelation4Correct.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4Correct.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4CorrectEN.QuestionName = objRow[convcc_WorkStuRelation4Correct.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4CorrectEN.CourseChapterId = objRow[convcc_WorkStuRelation4Correct.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4CorrectEN.CourseChapterName = objRow[convcc_WorkStuRelation4Correct.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4CorrectEN.ChapterName = objRow[convcc_WorkStuRelation4Correct.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4CorrectEN.SectionName = objRow[convcc_WorkStuRelation4Correct.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4CorrectEN.ChapterNameSim = objRow[convcc_WorkStuRelation4Correct.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4CorrectEN.SectionNameSim = objRow[convcc_WorkStuRelation4Correct.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4CorrectEN.ParentNodeID = objRow[convcc_WorkStuRelation4Correct.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4CorrectEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4Correct.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4CorrectEN.ParentNodeName = objRow[convcc_WorkStuRelation4Correct.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4CorrectEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4Correct.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4CorrectEN.AnswerAttLimitSize = objRow[convcc_WorkStuRelation4Correct.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4Correct.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkStuRelation4CorrectEN.RightId = objRow[convcc_WorkStuRelation4Correct.RightId].ToString().Trim(); //权限编号
objvcc_WorkStuRelation4CorrectEN.RightName = objRow[convcc_WorkStuRelation4Correct.RightName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.RightName].ToString().Trim(); //权限名称
objvcc_WorkStuRelation4CorrectEN.Authorizer = objRow[convcc_WorkStuRelation4Correct.Authorizer].ToString().Trim(); //授权人
objvcc_WorkStuRelation4CorrectEN.UpdDate = objRow[convcc_WorkStuRelation4Correct.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4CorrectEN.UpdUser = objRow[convcc_WorkStuRelation4Correct.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4CorrectEN.Memo = objRow[convcc_WorkStuRelation4Correct.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelation4CorrectEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelation4CorrectEN);
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
public static List<clsvcc_WorkStuRelation4CorrectEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcc_WorkStuRelation4CorrectEN> arrObjLst = new List<clsvcc_WorkStuRelation4CorrectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN = new clsvcc_WorkStuRelation4CorrectEN();
try
{
objvcc_WorkStuRelation4CorrectEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4Correct.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4CorrectEN.CourseId = objRow[convcc_WorkStuRelation4Correct.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4CorrectEN.CourseName = objRow[convcc_WorkStuRelation4Correct.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4CorrectEN.IdStudentInfo = objRow[convcc_WorkStuRelation4Correct.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4CorrectEN.StuID = objRow[convcc_WorkStuRelation4Correct.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4CorrectEN.StuName = objRow[convcc_WorkStuRelation4Correct.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4CorrectEN.IdXzCollege = objRow[convcc_WorkStuRelation4Correct.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4CorrectEN.CollegeName = objRow[convcc_WorkStuRelation4Correct.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4CorrectEN.IdXzMajor = objRow[convcc_WorkStuRelation4Correct.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4CorrectEN.MajorID = objRow[convcc_WorkStuRelation4Correct.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4CorrectEN.MajorName = objRow[convcc_WorkStuRelation4Correct.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4CorrectEN.IdGradeBase = objRow[convcc_WorkStuRelation4Correct.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4CorrectEN.CollegeNameA = objRow[convcc_WorkStuRelation4Correct.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4CorrectEN.GradeBaseName = objRow[convcc_WorkStuRelation4Correct.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4CorrectEN.QuestionID = objRow[convcc_WorkStuRelation4Correct.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4CorrectEN.QuestionIndex = objRow[convcc_WorkStuRelation4Correct.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4Correct.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4CorrectEN.QuestionName = objRow[convcc_WorkStuRelation4Correct.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4CorrectEN.CourseChapterId = objRow[convcc_WorkStuRelation4Correct.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4CorrectEN.CourseChapterName = objRow[convcc_WorkStuRelation4Correct.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4CorrectEN.ChapterName = objRow[convcc_WorkStuRelation4Correct.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4CorrectEN.SectionName = objRow[convcc_WorkStuRelation4Correct.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4CorrectEN.ChapterNameSim = objRow[convcc_WorkStuRelation4Correct.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4CorrectEN.SectionNameSim = objRow[convcc_WorkStuRelation4Correct.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4CorrectEN.ParentNodeID = objRow[convcc_WorkStuRelation4Correct.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4CorrectEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4Correct.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4CorrectEN.ParentNodeName = objRow[convcc_WorkStuRelation4Correct.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4CorrectEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4Correct.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4CorrectEN.AnswerAttLimitSize = objRow[convcc_WorkStuRelation4Correct.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4Correct.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkStuRelation4CorrectEN.RightId = objRow[convcc_WorkStuRelation4Correct.RightId].ToString().Trim(); //权限编号
objvcc_WorkStuRelation4CorrectEN.RightName = objRow[convcc_WorkStuRelation4Correct.RightName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.RightName].ToString().Trim(); //权限名称
objvcc_WorkStuRelation4CorrectEN.Authorizer = objRow[convcc_WorkStuRelation4Correct.Authorizer].ToString().Trim(); //授权人
objvcc_WorkStuRelation4CorrectEN.UpdDate = objRow[convcc_WorkStuRelation4Correct.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4CorrectEN.UpdUser = objRow[convcc_WorkStuRelation4Correct.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4CorrectEN.Memo = objRow[convcc_WorkStuRelation4Correct.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelation4CorrectEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelation4CorrectEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelation4CorrectEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcc_WorkStuRelation4CorrectEN> arrObjLst = new List<clsvcc_WorkStuRelation4CorrectEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN = new clsvcc_WorkStuRelation4CorrectEN();
try
{
objvcc_WorkStuRelation4CorrectEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4Correct.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4CorrectEN.CourseId = objRow[convcc_WorkStuRelation4Correct.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4CorrectEN.CourseName = objRow[convcc_WorkStuRelation4Correct.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4CorrectEN.IdStudentInfo = objRow[convcc_WorkStuRelation4Correct.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4CorrectEN.StuID = objRow[convcc_WorkStuRelation4Correct.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4CorrectEN.StuName = objRow[convcc_WorkStuRelation4Correct.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4CorrectEN.IdXzCollege = objRow[convcc_WorkStuRelation4Correct.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4CorrectEN.CollegeName = objRow[convcc_WorkStuRelation4Correct.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4CorrectEN.IdXzMajor = objRow[convcc_WorkStuRelation4Correct.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4CorrectEN.MajorID = objRow[convcc_WorkStuRelation4Correct.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4CorrectEN.MajorName = objRow[convcc_WorkStuRelation4Correct.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4CorrectEN.IdGradeBase = objRow[convcc_WorkStuRelation4Correct.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4CorrectEN.CollegeNameA = objRow[convcc_WorkStuRelation4Correct.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4CorrectEN.GradeBaseName = objRow[convcc_WorkStuRelation4Correct.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4CorrectEN.QuestionID = objRow[convcc_WorkStuRelation4Correct.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4CorrectEN.QuestionIndex = objRow[convcc_WorkStuRelation4Correct.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4Correct.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4CorrectEN.QuestionName = objRow[convcc_WorkStuRelation4Correct.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4CorrectEN.CourseChapterId = objRow[convcc_WorkStuRelation4Correct.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4CorrectEN.CourseChapterName = objRow[convcc_WorkStuRelation4Correct.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4CorrectEN.ChapterName = objRow[convcc_WorkStuRelation4Correct.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4CorrectEN.SectionName = objRow[convcc_WorkStuRelation4Correct.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4CorrectEN.ChapterNameSim = objRow[convcc_WorkStuRelation4Correct.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4CorrectEN.SectionNameSim = objRow[convcc_WorkStuRelation4Correct.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4CorrectEN.ParentNodeID = objRow[convcc_WorkStuRelation4Correct.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4CorrectEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4Correct.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4CorrectEN.ParentNodeName = objRow[convcc_WorkStuRelation4Correct.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4CorrectEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4Correct.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4CorrectEN.AnswerAttLimitSize = objRow[convcc_WorkStuRelation4Correct.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4Correct.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkStuRelation4CorrectEN.RightId = objRow[convcc_WorkStuRelation4Correct.RightId].ToString().Trim(); //权限编号
objvcc_WorkStuRelation4CorrectEN.RightName = objRow[convcc_WorkStuRelation4Correct.RightName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.RightName].ToString().Trim(); //权限名称
objvcc_WorkStuRelation4CorrectEN.Authorizer = objRow[convcc_WorkStuRelation4Correct.Authorizer].ToString().Trim(); //授权人
objvcc_WorkStuRelation4CorrectEN.UpdDate = objRow[convcc_WorkStuRelation4Correct.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4CorrectEN.UpdUser = objRow[convcc_WorkStuRelation4Correct.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4CorrectEN.Memo = objRow[convcc_WorkStuRelation4Correct.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4Correct.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelation4CorrectEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelation4CorrectEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcc_WorkStuRelation4Correct(ref clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN)
{
bool bolResult = vcc_WorkStuRelation4CorrectDA.Getvcc_WorkStuRelation4Correct(ref objvcc_WorkStuRelation4CorrectEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkStuRelation4CorrectEN GetObjBymId(long lngmId)
{
clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN = vcc_WorkStuRelation4CorrectDA.GetObjBymId(lngmId);
return objvcc_WorkStuRelation4CorrectEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcc_WorkStuRelation4CorrectEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN = vcc_WorkStuRelation4CorrectDA.GetFirstObj(strWhereCond);
 return objvcc_WorkStuRelation4CorrectEN;
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
public static clsvcc_WorkStuRelation4CorrectEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN = vcc_WorkStuRelation4CorrectDA.GetObjByDataRow(objRow);
 return objvcc_WorkStuRelation4CorrectEN;
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
public static clsvcc_WorkStuRelation4CorrectEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN = vcc_WorkStuRelation4CorrectDA.GetObjByDataRow(objRow);
 return objvcc_WorkStuRelation4CorrectEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvcc_WorkStuRelation4CorrectObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_WorkStuRelation4CorrectEN GetObjBymIdFromList(long lngmId, List<clsvcc_WorkStuRelation4CorrectEN> lstvcc_WorkStuRelation4CorrectObjLst)
{
foreach (clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN in lstvcc_WorkStuRelation4CorrectObjLst)
{
if (objvcc_WorkStuRelation4CorrectEN.mId == lngmId)
{
return objvcc_WorkStuRelation4CorrectEN;
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
 long lngmId;
 try
 {
 lngmId = new clsvcc_WorkStuRelation4CorrectDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = vcc_WorkStuRelation4CorrectDA.GetID(strWhereCond);
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
bool bolIsExist = vcc_WorkStuRelation4CorrectDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vcc_WorkStuRelation4CorrectDA.IsExist(lngmId);
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
 bolIsExist = clsvcc_WorkStuRelation4CorrectDA.IsExistTable();
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
 bolIsExist = vcc_WorkStuRelation4CorrectDA.IsExistTable(strTabName);
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
 /// <param name = "objvcc_WorkStuRelation4CorrectENS">源对象</param>
 /// <param name = "objvcc_WorkStuRelation4CorrectENT">目标对象</param>
 public static void CopyTo(clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectENS, clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectENT)
{
try
{
objvcc_WorkStuRelation4CorrectENT.mId = objvcc_WorkStuRelation4CorrectENS.mId; //mId
objvcc_WorkStuRelation4CorrectENT.CourseId = objvcc_WorkStuRelation4CorrectENS.CourseId; //课程Id
objvcc_WorkStuRelation4CorrectENT.CourseName = objvcc_WorkStuRelation4CorrectENS.CourseName; //课程名称
objvcc_WorkStuRelation4CorrectENT.IdStudentInfo = objvcc_WorkStuRelation4CorrectENS.IdStudentInfo; //学生流水号
objvcc_WorkStuRelation4CorrectENT.StuID = objvcc_WorkStuRelation4CorrectENS.StuID; //学号
objvcc_WorkStuRelation4CorrectENT.StuName = objvcc_WorkStuRelation4CorrectENS.StuName; //姓名
objvcc_WorkStuRelation4CorrectENT.IdXzCollege = objvcc_WorkStuRelation4CorrectENS.IdXzCollege; //学院流水号
objvcc_WorkStuRelation4CorrectENT.CollegeName = objvcc_WorkStuRelation4CorrectENS.CollegeName; //学院名称
objvcc_WorkStuRelation4CorrectENT.IdXzMajor = objvcc_WorkStuRelation4CorrectENS.IdXzMajor; //专业流水号
objvcc_WorkStuRelation4CorrectENT.MajorID = objvcc_WorkStuRelation4CorrectENS.MajorID; //专业ID
objvcc_WorkStuRelation4CorrectENT.MajorName = objvcc_WorkStuRelation4CorrectENS.MajorName; //专业名称
objvcc_WorkStuRelation4CorrectENT.IdGradeBase = objvcc_WorkStuRelation4CorrectENS.IdGradeBase; //年级流水号
objvcc_WorkStuRelation4CorrectENT.CollegeNameA = objvcc_WorkStuRelation4CorrectENS.CollegeNameA; //学院名称简写
objvcc_WorkStuRelation4CorrectENT.GradeBaseName = objvcc_WorkStuRelation4CorrectENS.GradeBaseName; //年级名称
objvcc_WorkStuRelation4CorrectENT.QuestionID = objvcc_WorkStuRelation4CorrectENS.QuestionID; //题目ID
objvcc_WorkStuRelation4CorrectENT.QuestionIndex = objvcc_WorkStuRelation4CorrectENS.QuestionIndex; //题目序号
objvcc_WorkStuRelation4CorrectENT.QuestionName = objvcc_WorkStuRelation4CorrectENS.QuestionName; //题目名称
objvcc_WorkStuRelation4CorrectENT.CourseChapterId = objvcc_WorkStuRelation4CorrectENS.CourseChapterId; //课程章节ID
objvcc_WorkStuRelation4CorrectENT.CourseChapterName = objvcc_WorkStuRelation4CorrectENS.CourseChapterName; //课程章节名称
objvcc_WorkStuRelation4CorrectENT.ChapterName = objvcc_WorkStuRelation4CorrectENS.ChapterName; //章名
objvcc_WorkStuRelation4CorrectENT.SectionName = objvcc_WorkStuRelation4CorrectENS.SectionName; //节名
objvcc_WorkStuRelation4CorrectENT.ChapterNameSim = objvcc_WorkStuRelation4CorrectENS.ChapterNameSim; //章名简称
objvcc_WorkStuRelation4CorrectENT.SectionNameSim = objvcc_WorkStuRelation4CorrectENS.SectionNameSim; //节名简称
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
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">源简化对象</param>
 public static void SetUpdFlag(clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN)
{
try
{
objvcc_WorkStuRelation4CorrectEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcc_WorkStuRelation4CorrectEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.mId = objvcc_WorkStuRelation4CorrectEN.mId; //mId
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.CourseId = objvcc_WorkStuRelation4CorrectEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.CourseName = objvcc_WorkStuRelation4CorrectEN.CourseName == "[null]" ? null :  objvcc_WorkStuRelation4CorrectEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.IdStudentInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.IdStudentInfo = objvcc_WorkStuRelation4CorrectEN.IdStudentInfo; //学生流水号
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.StuID, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.StuID = objvcc_WorkStuRelation4CorrectEN.StuID == "[null]" ? null :  objvcc_WorkStuRelation4CorrectEN.StuID; //学号
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.StuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.StuName = objvcc_WorkStuRelation4CorrectEN.StuName == "[null]" ? null :  objvcc_WorkStuRelation4CorrectEN.StuName; //姓名
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.IdXzCollege = objvcc_WorkStuRelation4CorrectEN.IdXzCollege == "[null]" ? null :  objvcc_WorkStuRelation4CorrectEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.CollegeName = objvcc_WorkStuRelation4CorrectEN.CollegeName == "[null]" ? null :  objvcc_WorkStuRelation4CorrectEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.IdXzMajor = objvcc_WorkStuRelation4CorrectEN.IdXzMajor == "[null]" ? null :  objvcc_WorkStuRelation4CorrectEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.MajorID, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.MajorID = objvcc_WorkStuRelation4CorrectEN.MajorID == "[null]" ? null :  objvcc_WorkStuRelation4CorrectEN.MajorID; //专业ID
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.MajorName = objvcc_WorkStuRelation4CorrectEN.MajorName == "[null]" ? null :  objvcc_WorkStuRelation4CorrectEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.IdGradeBase = objvcc_WorkStuRelation4CorrectEN.IdGradeBase == "[null]" ? null :  objvcc_WorkStuRelation4CorrectEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.CollegeNameA = objvcc_WorkStuRelation4CorrectEN.CollegeNameA == "[null]" ? null :  objvcc_WorkStuRelation4CorrectEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.GradeBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.GradeBaseName = objvcc_WorkStuRelation4CorrectEN.GradeBaseName == "[null]" ? null :  objvcc_WorkStuRelation4CorrectEN.GradeBaseName; //年级名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.QuestionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.QuestionID = objvcc_WorkStuRelation4CorrectEN.QuestionID == "[null]" ? null :  objvcc_WorkStuRelation4CorrectEN.QuestionID; //题目ID
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.QuestionIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.QuestionIndex = objvcc_WorkStuRelation4CorrectEN.QuestionIndex; //题目序号
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.QuestionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.QuestionName = objvcc_WorkStuRelation4CorrectEN.QuestionName == "[null]" ? null :  objvcc_WorkStuRelation4CorrectEN.QuestionName; //题目名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.CourseChapterId = objvcc_WorkStuRelation4CorrectEN.CourseChapterId == "[null]" ? null :  objvcc_WorkStuRelation4CorrectEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.CourseChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.CourseChapterName = objvcc_WorkStuRelation4CorrectEN.CourseChapterName == "[null]" ? null :  objvcc_WorkStuRelation4CorrectEN.CourseChapterName; //课程章节名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.ChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.ChapterName = objvcc_WorkStuRelation4CorrectEN.ChapterName == "[null]" ? null :  objvcc_WorkStuRelation4CorrectEN.ChapterName; //章名
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.SectionName = objvcc_WorkStuRelation4CorrectEN.SectionName == "[null]" ? null :  objvcc_WorkStuRelation4CorrectEN.SectionName; //节名
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.ChapterNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.ChapterNameSim = objvcc_WorkStuRelation4CorrectEN.ChapterNameSim == "[null]" ? null :  objvcc_WorkStuRelation4CorrectEN.ChapterNameSim; //章名简称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.SectionNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.SectionNameSim = objvcc_WorkStuRelation4CorrectEN.SectionNameSim == "[null]" ? null :  objvcc_WorkStuRelation4CorrectEN.SectionNameSim; //节名简称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.ParentNodeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.ParentNodeID = objvcc_WorkStuRelation4CorrectEN.ParentNodeID == "[null]" ? null :  objvcc_WorkStuRelation4CorrectEN.ParentNodeID; //父节点编号
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.CourseChapterReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.CourseChapterReferred = objvcc_WorkStuRelation4CorrectEN.CourseChapterReferred == "[null]" ? null :  objvcc_WorkStuRelation4CorrectEN.CourseChapterReferred; //节简称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.ParentNodeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.ParentNodeName = objvcc_WorkStuRelation4CorrectEN.ParentNodeName == "[null]" ? null :  objvcc_WorkStuRelation4CorrectEN.ParentNodeName; //父节点名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.ParentNodeReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.ParentNodeReferred = objvcc_WorkStuRelation4CorrectEN.ParentNodeReferred == "[null]" ? null :  objvcc_WorkStuRelation4CorrectEN.ParentNodeReferred; //章简称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.AnswerAttLimitSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.AnswerAttLimitSize = objvcc_WorkStuRelation4CorrectEN.AnswerAttLimitSize; //回答附件限制大小
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.RightId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.RightId = objvcc_WorkStuRelation4CorrectEN.RightId; //权限编号
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.RightName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.RightName = objvcc_WorkStuRelation4CorrectEN.RightName == "[null]" ? null :  objvcc_WorkStuRelation4CorrectEN.RightName; //权限名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.Authorizer, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.Authorizer = objvcc_WorkStuRelation4CorrectEN.Authorizer; //授权人
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.UpdDate = objvcc_WorkStuRelation4CorrectEN.UpdDate == "[null]" ? null :  objvcc_WorkStuRelation4CorrectEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.UpdUser = objvcc_WorkStuRelation4CorrectEN.UpdUser == "[null]" ? null :  objvcc_WorkStuRelation4CorrectEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convcc_WorkStuRelation4Correct.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4CorrectEN.Memo = objvcc_WorkStuRelation4CorrectEN.Memo == "[null]" ? null :  objvcc_WorkStuRelation4CorrectEN.Memo; //备注
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
 /// <param name = "objvcc_WorkStuRelation4CorrectEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN)
{
try
{
if (objvcc_WorkStuRelation4CorrectEN.CourseName == "[null]") objvcc_WorkStuRelation4CorrectEN.CourseName = null; //课程名称
if (objvcc_WorkStuRelation4CorrectEN.StuID == "[null]") objvcc_WorkStuRelation4CorrectEN.StuID = null; //学号
if (objvcc_WorkStuRelation4CorrectEN.StuName == "[null]") objvcc_WorkStuRelation4CorrectEN.StuName = null; //姓名
if (objvcc_WorkStuRelation4CorrectEN.IdXzCollege == "[null]") objvcc_WorkStuRelation4CorrectEN.IdXzCollege = null; //学院流水号
if (objvcc_WorkStuRelation4CorrectEN.CollegeName == "[null]") objvcc_WorkStuRelation4CorrectEN.CollegeName = null; //学院名称
if (objvcc_WorkStuRelation4CorrectEN.IdXzMajor == "[null]") objvcc_WorkStuRelation4CorrectEN.IdXzMajor = null; //专业流水号
if (objvcc_WorkStuRelation4CorrectEN.MajorID == "[null]") objvcc_WorkStuRelation4CorrectEN.MajorID = null; //专业ID
if (objvcc_WorkStuRelation4CorrectEN.MajorName == "[null]") objvcc_WorkStuRelation4CorrectEN.MajorName = null; //专业名称
if (objvcc_WorkStuRelation4CorrectEN.IdGradeBase == "[null]") objvcc_WorkStuRelation4CorrectEN.IdGradeBase = null; //年级流水号
if (objvcc_WorkStuRelation4CorrectEN.CollegeNameA == "[null]") objvcc_WorkStuRelation4CorrectEN.CollegeNameA = null; //学院名称简写
if (objvcc_WorkStuRelation4CorrectEN.GradeBaseName == "[null]") objvcc_WorkStuRelation4CorrectEN.GradeBaseName = null; //年级名称
if (objvcc_WorkStuRelation4CorrectEN.QuestionID == "[null]") objvcc_WorkStuRelation4CorrectEN.QuestionID = null; //题目ID
if (objvcc_WorkStuRelation4CorrectEN.QuestionName == "[null]") objvcc_WorkStuRelation4CorrectEN.QuestionName = null; //题目名称
if (objvcc_WorkStuRelation4CorrectEN.CourseChapterId == "[null]") objvcc_WorkStuRelation4CorrectEN.CourseChapterId = null; //课程章节ID
if (objvcc_WorkStuRelation4CorrectEN.CourseChapterName == "[null]") objvcc_WorkStuRelation4CorrectEN.CourseChapterName = null; //课程章节名称
if (objvcc_WorkStuRelation4CorrectEN.ChapterName == "[null]") objvcc_WorkStuRelation4CorrectEN.ChapterName = null; //章名
if (objvcc_WorkStuRelation4CorrectEN.SectionName == "[null]") objvcc_WorkStuRelation4CorrectEN.SectionName = null; //节名
if (objvcc_WorkStuRelation4CorrectEN.ChapterNameSim == "[null]") objvcc_WorkStuRelation4CorrectEN.ChapterNameSim = null; //章名简称
if (objvcc_WorkStuRelation4CorrectEN.SectionNameSim == "[null]") objvcc_WorkStuRelation4CorrectEN.SectionNameSim = null; //节名简称
if (objvcc_WorkStuRelation4CorrectEN.ParentNodeID == "[null]") objvcc_WorkStuRelation4CorrectEN.ParentNodeID = null; //父节点编号
if (objvcc_WorkStuRelation4CorrectEN.CourseChapterReferred == "[null]") objvcc_WorkStuRelation4CorrectEN.CourseChapterReferred = null; //节简称
if (objvcc_WorkStuRelation4CorrectEN.ParentNodeName == "[null]") objvcc_WorkStuRelation4CorrectEN.ParentNodeName = null; //父节点名称
if (objvcc_WorkStuRelation4CorrectEN.ParentNodeReferred == "[null]") objvcc_WorkStuRelation4CorrectEN.ParentNodeReferred = null; //章简称
if (objvcc_WorkStuRelation4CorrectEN.RightName == "[null]") objvcc_WorkStuRelation4CorrectEN.RightName = null; //权限名称
if (objvcc_WorkStuRelation4CorrectEN.UpdDate == "[null]") objvcc_WorkStuRelation4CorrectEN.UpdDate = null; //修改日期
if (objvcc_WorkStuRelation4CorrectEN.UpdUser == "[null]") objvcc_WorkStuRelation4CorrectEN.UpdUser = null; //修改人
if (objvcc_WorkStuRelation4CorrectEN.Memo == "[null]") objvcc_WorkStuRelation4CorrectEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectEN)
{
 vcc_WorkStuRelation4CorrectDA.CheckProperty4Condition(objvcc_WorkStuRelation4CorrectEN);
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
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_WorkStuRelation4CorrectBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkStuRelation4CorrectBL没有刷新缓存机制(clscc_WorkStuRelation4CorrectBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionnaireBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireBL没有刷新缓存机制(clsQuestionnaireBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerModeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerModeBL没有刷新缓存机制(clsAnswerModeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerTypeBL没有刷新缓存机制(clsAnswerTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeBL没有刷新缓存机制(clsQuestionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExamGradeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamGradeBL没有刷新缓存机制(clscc_ExamGradeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionType4CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionType4CourseBL没有刷新缓存机制(clsQuestionType4CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzUniZoneBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneBL没有刷新缓存机制(clsXzUniZoneBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexBL没有刷新缓存机制(clsSexBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicBL没有刷新缓存机制(clsRsEthnicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsBL没有刷新缓存机制(clsRsPoliticsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseBL没有刷新缓存机制(clsXzGradeBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudentInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfoBL没有刷新缓存机制(clsStudentInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStuTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStuTypeBL没有刷新缓存机制(clsRsStuTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxRightBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRightBL没有刷新缓存机制(clsQxRightBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxRightRangeLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRightRangeLevelBL没有刷新缓存机制(clsQxRightRangeLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterBL没有刷新缓存机制(clscc_CourseChapterBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsBL没有刷新缓存机制(clsXzAdminClsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsTypeBL没有刷新缓存机制(clsXzAdminClsTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxRightTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRightTypeBL没有刷新缓存机制(clsQxRightTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeBL没有刷新缓存机制(clscc_CourseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsStudyLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelBL没有刷新缓存机制(clsStudyLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeBL没有刷新缓存机制(clscc_CourseIsLikeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvcc_WorkStuRelation4CorrectObjLstCache == null)
//{
//arrvcc_WorkStuRelation4CorrectObjLstCache = vcc_WorkStuRelation4CorrectDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_WorkStuRelation4CorrectEN GetObjBymIdCache(long lngmId, string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvcc_WorkStuRelation4CorrectEN._CurrTabName, strCourseId);
List<clsvcc_WorkStuRelation4CorrectEN> arrvcc_WorkStuRelation4CorrectObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_WorkStuRelation4CorrectEN> arrvcc_WorkStuRelation4CorrectObjLst_Sel =
arrvcc_WorkStuRelation4CorrectObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvcc_WorkStuRelation4CorrectObjLst_Sel.Count() == 0)
{
   clsvcc_WorkStuRelation4CorrectEN obj = clsvcc_WorkStuRelation4CorrectBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvcc_WorkStuRelation4CorrectObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_WorkStuRelation4CorrectEN> GetAllvcc_WorkStuRelation4CorrectObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsvcc_WorkStuRelation4CorrectEN> arrvcc_WorkStuRelation4CorrectObjLstCache = GetObjLstCache(strCourseId); 
return arrvcc_WorkStuRelation4CorrectObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_WorkStuRelation4CorrectEN> GetObjLstCache(string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvcc_WorkStuRelation4CorrectEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsvcc_WorkStuRelation4CorrectEN> arrvcc_WorkStuRelation4CorrectObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvcc_WorkStuRelation4CorrectObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvcc_WorkStuRelation4CorrectEN._CurrTabName, strCourseId);
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
 /// 日期:2023-08-24
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strCourseId)
{
if (strInFldName != convcc_WorkStuRelation4Correct.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcc_WorkStuRelation4Correct.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcc_WorkStuRelation4Correct.AttributeName));
throw new Exception(strMsg);
}
var objvcc_WorkStuRelation4Correct = clsvcc_WorkStuRelation4CorrectBL.GetObjBymIdCache(lngmId, strCourseId);
if (objvcc_WorkStuRelation4Correct == null) return "";
return objvcc_WorkStuRelation4Correct[strOutFldName].ToString();
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
int intRecCount = clsvcc_WorkStuRelation4CorrectDA.GetRecCount(strTabName);
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
int intRecCount = clsvcc_WorkStuRelation4CorrectDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcc_WorkStuRelation4CorrectDA.GetRecCount();
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
int intRecCount = clsvcc_WorkStuRelation4CorrectDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4CorrectCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcc_WorkStuRelation4CorrectEN objvcc_WorkStuRelation4CorrectCond)
{
 string strCourseId = objvcc_WorkStuRelation4CorrectCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvcc_WorkStuRelation4CorrectBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvcc_WorkStuRelation4CorrectEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_WorkStuRelation4CorrectEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_WorkStuRelation4Correct.AttributeName)
{
if (objvcc_WorkStuRelation4CorrectCond.IsUpdated(strFldName) == false) continue;
if (objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkStuRelation4CorrectCond[strFldName].ToString());
}
else
{
if (objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkStuRelation4CorrectCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_WorkStuRelation4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_WorkStuRelation4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_WorkStuRelation4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_WorkStuRelation4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_WorkStuRelation4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_WorkStuRelation4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_WorkStuRelation4CorrectCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_WorkStuRelation4CorrectCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_WorkStuRelation4CorrectCond[strFldName]));
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
 List<string> arrList = clsvcc_WorkStuRelation4CorrectDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcc_WorkStuRelation4CorrectDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcc_WorkStuRelation4CorrectDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}