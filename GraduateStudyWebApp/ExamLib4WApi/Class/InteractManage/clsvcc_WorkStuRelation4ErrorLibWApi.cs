
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkStuRelation4ErrorLibWApi
 表名:vcc_WorkStuRelation4ErrorLib(01120206)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:45:04
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
public static class clsvcc_WorkStuRelation4ErrorLibWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetCourseName(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_WorkStuRelation4ErrorLib.CourseName);
objvcc_WorkStuRelation4ErrorLibEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.CourseName) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.CourseName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.CourseName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetStuID(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convcc_WorkStuRelation4ErrorLib.StuID);
objvcc_WorkStuRelation4ErrorLibEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.StuID) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.StuID, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.StuID] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetStuName(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convcc_WorkStuRelation4ErrorLib.StuName);
objvcc_WorkStuRelation4ErrorLibEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.StuName) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.StuName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.StuName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN Setid_XzCollege(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convcc_WorkStuRelation4ErrorLib.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convcc_WorkStuRelation4ErrorLib.id_XzCollege);
objvcc_WorkStuRelation4ErrorLibEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.id_XzCollege) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.id_XzCollege, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.id_XzCollege] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetCollegeName(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convcc_WorkStuRelation4ErrorLib.CollegeName);
objvcc_WorkStuRelation4ErrorLibEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.CollegeName) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.CollegeName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.CollegeName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN Setid_XzMajor(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convcc_WorkStuRelation4ErrorLib.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convcc_WorkStuRelation4ErrorLib.id_XzMajor);
objvcc_WorkStuRelation4ErrorLibEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.id_XzMajor) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.id_XzMajor, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.id_XzMajor] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetMajorID(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convcc_WorkStuRelation4ErrorLib.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convcc_WorkStuRelation4ErrorLib.MajorID);
objvcc_WorkStuRelation4ErrorLibEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.MajorID) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.MajorID, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.MajorID] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetMajorName(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convcc_WorkStuRelation4ErrorLib.MajorName);
objvcc_WorkStuRelation4ErrorLibEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.MajorName) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.MajorName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.MajorName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN Setid_GradeBase(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convcc_WorkStuRelation4ErrorLib.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convcc_WorkStuRelation4ErrorLib.id_GradeBase);
objvcc_WorkStuRelation4ErrorLibEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.id_GradeBase) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.id_GradeBase, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.id_GradeBase] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetAdminClsId(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strAdminClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, convcc_WorkStuRelation4ErrorLib.AdminClsId);
objvcc_WorkStuRelation4ErrorLibEN.AdminClsId = strAdminClsId; //行政班代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.AdminClsId) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.AdminClsId, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.AdminClsId] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetAdminClsName(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strAdminClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, convcc_WorkStuRelation4ErrorLib.AdminClsName);
objvcc_WorkStuRelation4ErrorLibEN.AdminClsName = strAdminClsName; //行政班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.AdminClsName) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.AdminClsName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.AdminClsName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetCollegeNameA(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convcc_WorkStuRelation4ErrorLib.CollegeNameA);
objvcc_WorkStuRelation4ErrorLibEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.CollegeNameA) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.CollegeNameA, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.CollegeNameA] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetGradeBaseName(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convcc_WorkStuRelation4ErrorLib.GradeBaseName);
objvcc_WorkStuRelation4ErrorLibEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.GradeBaseName) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.GradeBaseName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.GradeBaseName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetQuestionIndex(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, int intQuestionIndex, string strComparisonOp="")
	{
objvcc_WorkStuRelation4ErrorLibEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.QuestionIndex) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.QuestionIndex, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.QuestionIndex] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetQuestionName(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strQuestionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionName, 1000, convcc_WorkStuRelation4ErrorLib.QuestionName);
objvcc_WorkStuRelation4ErrorLibEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.QuestionName) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.QuestionName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.QuestionName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetQuestionContent(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strQuestionContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionContent, 4000, convcc_WorkStuRelation4ErrorLib.QuestionContent);
objvcc_WorkStuRelation4ErrorLibEN.QuestionContent = strQuestionContent; //题目内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.QuestionContent) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.QuestionContent, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.QuestionContent] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetCourseChapterId(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_WorkStuRelation4ErrorLib.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_WorkStuRelation4ErrorLib.CourseChapterId);
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.CourseChapterId) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.CourseChapterId, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.CourseChapterId] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetCourseChapterName(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_WorkStuRelation4ErrorLib.CourseChapterName);
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.CourseChapterName) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.CourseChapterName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.CourseChapterName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetChapterName(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_WorkStuRelation4ErrorLib.ChapterName);
objvcc_WorkStuRelation4ErrorLibEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.ChapterName) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.ChapterName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.ChapterName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetSectionName(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_WorkStuRelation4ErrorLib.SectionName);
objvcc_WorkStuRelation4ErrorLibEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.SectionName) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.SectionName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.SectionName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetChapterName_Sim(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convcc_WorkStuRelation4ErrorLib.ChapterName_Sim);
objvcc_WorkStuRelation4ErrorLibEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.ChapterName_Sim) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.ChapterName_Sim, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.ChapterName_Sim] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetSectionName_Sim(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, convcc_WorkStuRelation4ErrorLib.SectionName_Sim);
objvcc_WorkStuRelation4ErrorLibEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.SectionName_Sim) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.SectionName_Sim, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.SectionName_Sim] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetParentNodeID(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convcc_WorkStuRelation4ErrorLib.ParentNodeID);
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.ParentNodeID) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.ParentNodeID, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.ParentNodeID] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetCourseChapterReferred(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strCourseChapterReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convcc_WorkStuRelation4ErrorLib.CourseChapterReferred);
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterReferred = strCourseChapterReferred; //节简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.CourseChapterReferred) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.CourseChapterReferred, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.CourseChapterReferred] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetParentNodeName(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strParentNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convcc_WorkStuRelation4ErrorLib.ParentNodeName);
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.ParentNodeName) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.ParentNodeName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.ParentNodeName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetParentNodeReferred(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strParentNodeReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convcc_WorkStuRelation4ErrorLib.ParentNodeReferred);
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeReferred = strParentNodeReferred; //章简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.ParentNodeReferred) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.ParentNodeReferred, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.ParentNodeReferred] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetSourceTypeName(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strSourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSourceTypeName, 20, convcc_WorkStuRelation4ErrorLib.SourceTypeName);
objvcc_WorkStuRelation4ErrorLibEN.SourceTypeName = strSourceTypeName; //来源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.SourceTypeName) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.SourceTypeName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.SourceTypeName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetQuestionID(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionID, 8, convcc_WorkStuRelation4ErrorLib.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convcc_WorkStuRelation4ErrorLib.QuestionID);
objvcc_WorkStuRelation4ErrorLibEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.QuestionID) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.QuestionID, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.QuestionID] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetmId(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, long lngmId, string strComparisonOp="")
	{
objvcc_WorkStuRelation4ErrorLibEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.mId) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.mId, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.mId] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetCourseId(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convcc_WorkStuRelation4ErrorLib.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_WorkStuRelation4ErrorLib.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_WorkStuRelation4ErrorLib.CourseId);
objvcc_WorkStuRelation4ErrorLibEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.CourseId) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.CourseId, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.CourseId] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN Setid_StudentInfo(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudentInfo, convcc_WorkStuRelation4ErrorLib.id_StudentInfo);
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, convcc_WorkStuRelation4ErrorLib.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, convcc_WorkStuRelation4ErrorLib.id_StudentInfo);
objvcc_WorkStuRelation4ErrorLibEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.id_StudentInfo) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.id_StudentInfo, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.id_StudentInfo] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetCreator(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strCreator, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreator, 18, convcc_WorkStuRelation4ErrorLib.Creator);
objvcc_WorkStuRelation4ErrorLibEN.Creator = strCreator; //创建者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.Creator) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.Creator, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.Creator] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetCreateDate(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convcc_WorkStuRelation4ErrorLib.CreateDate);
objvcc_WorkStuRelation4ErrorLibEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.CreateDate) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.CreateDate, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.CreateDate] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetSourceTypeId(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strSourceTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSourceTypeId, convcc_WorkStuRelation4ErrorLib.SourceTypeId);
clsCheckSql.CheckFieldLen(strSourceTypeId, 2, convcc_WorkStuRelation4ErrorLib.SourceTypeId);
clsCheckSql.CheckFieldForeignKey(strSourceTypeId, 2, convcc_WorkStuRelation4ErrorLib.SourceTypeId);
objvcc_WorkStuRelation4ErrorLibEN.SourceTypeId = strSourceTypeId; //来源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.SourceTypeId) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.SourceTypeId, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.SourceTypeId] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetIsRedo(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, bool bolIsRedo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsRedo, convcc_WorkStuRelation4ErrorLib.IsRedo);
objvcc_WorkStuRelation4ErrorLibEN.IsRedo = bolIsRedo; //是否重做
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.IsRedo) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.IsRedo, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.IsRedo] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetRedoDate(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strRedoDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRedoDate, 8, convcc_WorkStuRelation4ErrorLib.RedoDate);
objvcc_WorkStuRelation4ErrorLibEN.RedoDate = strRedoDate; //重做日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.RedoDate) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.RedoDate, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.RedoDate] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetIsPassed(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, bool bolIsPassed, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsPassed, convcc_WorkStuRelation4ErrorLib.IsPassed);
objvcc_WorkStuRelation4ErrorLibEN.IsPassed = bolIsPassed; //是否通过
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.IsPassed) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.IsPassed, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.IsPassed] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetUpdDate(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_WorkStuRelation4ErrorLib.UpdDate);
objvcc_WorkStuRelation4ErrorLibEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.UpdDate) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.UpdDate, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.UpdDate] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetUpdUser(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convcc_WorkStuRelation4ErrorLib.UpdUser);
objvcc_WorkStuRelation4ErrorLibEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.UpdUser) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.UpdUser, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.UpdUser] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetMemo(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_WorkStuRelation4ErrorLib.Memo);
objvcc_WorkStuRelation4ErrorLibEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.Memo) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.Memo, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.Memo] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLib_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.CourseName, objvcc_WorkStuRelation4ErrorLib_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.StuID) == true)
{
string strComparisonOp_StuID = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.StuID, objvcc_WorkStuRelation4ErrorLib_Cond.StuID, strComparisonOp_StuID);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.StuName) == true)
{
string strComparisonOp_StuName = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.StuName, objvcc_WorkStuRelation4ErrorLib_Cond.StuName, strComparisonOp_StuName);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.id_XzCollege, objvcc_WorkStuRelation4ErrorLib_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.CollegeName, objvcc_WorkStuRelation4ErrorLib_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.id_XzMajor, objvcc_WorkStuRelation4ErrorLib_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.MajorID) == true)
{
string strComparisonOp_MajorID = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.MajorID, objvcc_WorkStuRelation4ErrorLib_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.MajorName) == true)
{
string strComparisonOp_MajorName = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.MajorName, objvcc_WorkStuRelation4ErrorLib_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.id_GradeBase, objvcc_WorkStuRelation4ErrorLib_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.AdminClsId) == true)
{
string strComparisonOp_AdminClsId = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.AdminClsId, objvcc_WorkStuRelation4ErrorLib_Cond.AdminClsId, strComparisonOp_AdminClsId);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.AdminClsName) == true)
{
string strComparisonOp_AdminClsName = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.AdminClsName, objvcc_WorkStuRelation4ErrorLib_Cond.AdminClsName, strComparisonOp_AdminClsName);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.CollegeNameA, objvcc_WorkStuRelation4ErrorLib_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.GradeBaseName, objvcc_WorkStuRelation4ErrorLib_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.QuestionIndex) == true)
{
string strComparisonOp_QuestionIndex = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation4ErrorLib.QuestionIndex, objvcc_WorkStuRelation4ErrorLib_Cond.QuestionIndex, strComparisonOp_QuestionIndex);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.QuestionName) == true)
{
string strComparisonOp_QuestionName = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.QuestionName, objvcc_WorkStuRelation4ErrorLib_Cond.QuestionName, strComparisonOp_QuestionName);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.QuestionContent) == true)
{
string strComparisonOp_QuestionContent = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.QuestionContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.QuestionContent, objvcc_WorkStuRelation4ErrorLib_Cond.QuestionContent, strComparisonOp_QuestionContent);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.CourseChapterId, objvcc_WorkStuRelation4ErrorLib_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.CourseChapterName, objvcc_WorkStuRelation4ErrorLib_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.ChapterName, objvcc_WorkStuRelation4ErrorLib_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.SectionName) == true)
{
string strComparisonOp_SectionName = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.SectionName, objvcc_WorkStuRelation4ErrorLib_Cond.SectionName, strComparisonOp_SectionName);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.ChapterName_Sim, objvcc_WorkStuRelation4ErrorLib_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.SectionName_Sim, objvcc_WorkStuRelation4ErrorLib_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.ParentNodeID, objvcc_WorkStuRelation4ErrorLib_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.CourseChapterReferred) == true)
{
string strComparisonOp_CourseChapterReferred = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.CourseChapterReferred, objvcc_WorkStuRelation4ErrorLib_Cond.CourseChapterReferred, strComparisonOp_CourseChapterReferred);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.ParentNodeName) == true)
{
string strComparisonOp_ParentNodeName = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.ParentNodeName, objvcc_WorkStuRelation4ErrorLib_Cond.ParentNodeName, strComparisonOp_ParentNodeName);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.ParentNodeReferred) == true)
{
string strComparisonOp_ParentNodeReferred = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.ParentNodeReferred, objvcc_WorkStuRelation4ErrorLib_Cond.ParentNodeReferred, strComparisonOp_ParentNodeReferred);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.SourceTypeName) == true)
{
string strComparisonOp_SourceTypeName = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.SourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.SourceTypeName, objvcc_WorkStuRelation4ErrorLib_Cond.SourceTypeName, strComparisonOp_SourceTypeName);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.QuestionID) == true)
{
string strComparisonOp_QuestionID = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.QuestionID, objvcc_WorkStuRelation4ErrorLib_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.mId) == true)
{
string strComparisonOp_mId = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation4ErrorLib.mId, objvcc_WorkStuRelation4ErrorLib_Cond.mId, strComparisonOp_mId);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.CourseId, objvcc_WorkStuRelation4ErrorLib_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.id_StudentInfo, objvcc_WorkStuRelation4ErrorLib_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.Creator) == true)
{
string strComparisonOp_Creator = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.Creator];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.Creator, objvcc_WorkStuRelation4ErrorLib_Cond.Creator, strComparisonOp_Creator);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.CreateDate) == true)
{
string strComparisonOp_CreateDate = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.CreateDate, objvcc_WorkStuRelation4ErrorLib_Cond.CreateDate, strComparisonOp_CreateDate);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.SourceTypeId) == true)
{
string strComparisonOp_SourceTypeId = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.SourceTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.SourceTypeId, objvcc_WorkStuRelation4ErrorLib_Cond.SourceTypeId, strComparisonOp_SourceTypeId);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.IsRedo) == true)
{
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsRedo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation4ErrorLib.IsRedo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation4ErrorLib.IsRedo);
}
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.RedoDate) == true)
{
string strComparisonOp_RedoDate = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.RedoDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.RedoDate, objvcc_WorkStuRelation4ErrorLib_Cond.RedoDate, strComparisonOp_RedoDate);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.IsPassed) == true)
{
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsPassed == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation4ErrorLib.IsPassed);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation4ErrorLib.IsPassed);
}
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.UpdDate, objvcc_WorkStuRelation4ErrorLib_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.UpdUser, objvcc_WorkStuRelation4ErrorLib_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(convcc_WorkStuRelation4ErrorLib.Memo) == true)
{
string strComparisonOp_Memo = objvcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.Memo, objvcc_WorkStuRelation4ErrorLib_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v学生错误作业集(vcc_WorkStuRelation4ErrorLib)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_WorkStuRelation4ErrorLibWApi
{
private static readonly string mstrApiControllerName = "vcc_WorkStuRelation4ErrorLibApi";

 public clsvcc_WorkStuRelation4ErrorLibWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN = null;
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
objvcc_WorkStuRelation4ErrorLibEN = JsonConvert.DeserializeObject<clsvcc_WorkStuRelation4ErrorLibEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkStuRelation4ErrorLibEN;
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
public static clsvcc_WorkStuRelation4ErrorLibEN GetObjBymId_WA_Cache(long lngmId, string strCourseId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN = null;
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
objvcc_WorkStuRelation4ErrorLibEN = JsonConvert.DeserializeObject<clsvcc_WorkStuRelation4ErrorLibEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkStuRelation4ErrorLibEN;
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
public static clsvcc_WorkStuRelation4ErrorLibEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN = null;
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
objvcc_WorkStuRelation4ErrorLibEN = JsonConvert.DeserializeObject<clsvcc_WorkStuRelation4ErrorLibEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkStuRelation4ErrorLibEN;
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
public static clsvcc_WorkStuRelation4ErrorLibEN GetObjBymId_Cache(long lngmId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_WorkStuRelation4ErrorLibEN._CurrTabName_S, strCourseId);
List<clsvcc_WorkStuRelation4ErrorLibEN> arrvcc_WorkStuRelation4ErrorLibObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvcc_WorkStuRelation4ErrorLibEN> arrvcc_WorkStuRelation4ErrorLibObjLst_Sel =
from objvcc_WorkStuRelation4ErrorLibEN in arrvcc_WorkStuRelation4ErrorLibObjLst_Cache
where objvcc_WorkStuRelation4ErrorLibEN.mId == lngmId
select objvcc_WorkStuRelation4ErrorLibEN;
if (arrvcc_WorkStuRelation4ErrorLibObjLst_Sel.Count() == 0)
{
   clsvcc_WorkStuRelation4ErrorLibEN obj = clsvcc_WorkStuRelation4ErrorLibWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_WorkStuRelation4ErrorLibObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelation4ErrorLibEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_WorkStuRelation4ErrorLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation4ErrorLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelation4ErrorLibEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvcc_WorkStuRelation4ErrorLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation4ErrorLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvcc_WorkStuRelation4ErrorLibEN> GetObjLstByMIdLst_Cache(List<long> arrMId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_WorkStuRelation4ErrorLibEN._CurrTabName_S, strCourseId);
List<clsvcc_WorkStuRelation4ErrorLibEN> arrvcc_WorkStuRelation4ErrorLibObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvcc_WorkStuRelation4ErrorLibEN> arrvcc_WorkStuRelation4ErrorLibObjLst_Sel =
from objvcc_WorkStuRelation4ErrorLibEN in arrvcc_WorkStuRelation4ErrorLibObjLst_Cache
where arrMId.Contains(objvcc_WorkStuRelation4ErrorLibEN.mId)
select objvcc_WorkStuRelation4ErrorLibEN;
return arrvcc_WorkStuRelation4ErrorLibObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelation4ErrorLibEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId, string strCourseId)
{
 List<clsvcc_WorkStuRelation4ErrorLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation4ErrorLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelation4ErrorLibEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_WorkStuRelation4ErrorLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation4ErrorLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelation4ErrorLibEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_WorkStuRelation4ErrorLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation4ErrorLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelation4ErrorLibEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_WorkStuRelation4ErrorLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation4ErrorLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelation4ErrorLibEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_WorkStuRelation4ErrorLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation4ErrorLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvcc_WorkStuRelation4ErrorLibENS">源对象</param>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibENT">目标对象</param>
 public static void CopyTo(clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibENS, clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibENT)
{
try
{
objvcc_WorkStuRelation4ErrorLibENT.CourseName = objvcc_WorkStuRelation4ErrorLibENS.CourseName; //课程名称
objvcc_WorkStuRelation4ErrorLibENT.StuID = objvcc_WorkStuRelation4ErrorLibENS.StuID; //学号
objvcc_WorkStuRelation4ErrorLibENT.StuName = objvcc_WorkStuRelation4ErrorLibENS.StuName; //姓名
objvcc_WorkStuRelation4ErrorLibENT.id_XzCollege = objvcc_WorkStuRelation4ErrorLibENS.id_XzCollege; //学院流水号
objvcc_WorkStuRelation4ErrorLibENT.CollegeName = objvcc_WorkStuRelation4ErrorLibENS.CollegeName; //学院名称
objvcc_WorkStuRelation4ErrorLibENT.id_XzMajor = objvcc_WorkStuRelation4ErrorLibENS.id_XzMajor; //专业流水号
objvcc_WorkStuRelation4ErrorLibENT.MajorID = objvcc_WorkStuRelation4ErrorLibENS.MajorID; //专业ID
objvcc_WorkStuRelation4ErrorLibENT.MajorName = objvcc_WorkStuRelation4ErrorLibENS.MajorName; //专业名称
objvcc_WorkStuRelation4ErrorLibENT.id_GradeBase = objvcc_WorkStuRelation4ErrorLibENS.id_GradeBase; //年级流水号
objvcc_WorkStuRelation4ErrorLibENT.AdminClsId = objvcc_WorkStuRelation4ErrorLibENS.AdminClsId; //行政班代号
objvcc_WorkStuRelation4ErrorLibENT.AdminClsName = objvcc_WorkStuRelation4ErrorLibENS.AdminClsName; //行政班名称
objvcc_WorkStuRelation4ErrorLibENT.CollegeNameA = objvcc_WorkStuRelation4ErrorLibENS.CollegeNameA; //学院名称简写
objvcc_WorkStuRelation4ErrorLibENT.GradeBaseName = objvcc_WorkStuRelation4ErrorLibENS.GradeBaseName; //年级名称
objvcc_WorkStuRelation4ErrorLibENT.QuestionIndex = objvcc_WorkStuRelation4ErrorLibENS.QuestionIndex; //题目序号
objvcc_WorkStuRelation4ErrorLibENT.QuestionName = objvcc_WorkStuRelation4ErrorLibENS.QuestionName; //题目名称
objvcc_WorkStuRelation4ErrorLibENT.QuestionContent = objvcc_WorkStuRelation4ErrorLibENS.QuestionContent; //题目内容
objvcc_WorkStuRelation4ErrorLibENT.CourseChapterId = objvcc_WorkStuRelation4ErrorLibENS.CourseChapterId; //课程章节ID
objvcc_WorkStuRelation4ErrorLibENT.CourseChapterName = objvcc_WorkStuRelation4ErrorLibENS.CourseChapterName; //课程章节名称
objvcc_WorkStuRelation4ErrorLibENT.ChapterName = objvcc_WorkStuRelation4ErrorLibENS.ChapterName; //章名
objvcc_WorkStuRelation4ErrorLibENT.SectionName = objvcc_WorkStuRelation4ErrorLibENS.SectionName; //节名
objvcc_WorkStuRelation4ErrorLibENT.ChapterName_Sim = objvcc_WorkStuRelation4ErrorLibENS.ChapterName_Sim; //章名简称
objvcc_WorkStuRelation4ErrorLibENT.SectionName_Sim = objvcc_WorkStuRelation4ErrorLibENS.SectionName_Sim; //节名简称
objvcc_WorkStuRelation4ErrorLibENT.ParentNodeID = objvcc_WorkStuRelation4ErrorLibENS.ParentNodeID; //父节点编号
objvcc_WorkStuRelation4ErrorLibENT.CourseChapterReferred = objvcc_WorkStuRelation4ErrorLibENS.CourseChapterReferred; //节简称
objvcc_WorkStuRelation4ErrorLibENT.ParentNodeName = objvcc_WorkStuRelation4ErrorLibENS.ParentNodeName; //父节点名称
objvcc_WorkStuRelation4ErrorLibENT.ParentNodeReferred = objvcc_WorkStuRelation4ErrorLibENS.ParentNodeReferred; //章简称
objvcc_WorkStuRelation4ErrorLibENT.SourceTypeName = objvcc_WorkStuRelation4ErrorLibENS.SourceTypeName; //来源类型名称
objvcc_WorkStuRelation4ErrorLibENT.QuestionID = objvcc_WorkStuRelation4ErrorLibENS.QuestionID; //题目ID
objvcc_WorkStuRelation4ErrorLibENT.mId = objvcc_WorkStuRelation4ErrorLibENS.mId; //mId
objvcc_WorkStuRelation4ErrorLibENT.CourseId = objvcc_WorkStuRelation4ErrorLibENS.CourseId; //课程Id
objvcc_WorkStuRelation4ErrorLibENT.id_StudentInfo = objvcc_WorkStuRelation4ErrorLibENS.id_StudentInfo; //学生流水号
objvcc_WorkStuRelation4ErrorLibENT.Creator = objvcc_WorkStuRelation4ErrorLibENS.Creator; //创建者
objvcc_WorkStuRelation4ErrorLibENT.CreateDate = objvcc_WorkStuRelation4ErrorLibENS.CreateDate; //建立日期
objvcc_WorkStuRelation4ErrorLibENT.SourceTypeId = objvcc_WorkStuRelation4ErrorLibENS.SourceTypeId; //来源类型Id
objvcc_WorkStuRelation4ErrorLibENT.IsRedo = objvcc_WorkStuRelation4ErrorLibENS.IsRedo; //是否重做
objvcc_WorkStuRelation4ErrorLibENT.RedoDate = objvcc_WorkStuRelation4ErrorLibENS.RedoDate; //重做日期
objvcc_WorkStuRelation4ErrorLibENT.IsPassed = objvcc_WorkStuRelation4ErrorLibENS.IsPassed; //是否通过
objvcc_WorkStuRelation4ErrorLibENT.UpdDate = objvcc_WorkStuRelation4ErrorLibENS.UpdDate; //修改日期
objvcc_WorkStuRelation4ErrorLibENT.UpdUser = objvcc_WorkStuRelation4ErrorLibENS.UpdUser; //修改人
objvcc_WorkStuRelation4ErrorLibENT.Memo = objvcc_WorkStuRelation4ErrorLibENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvcc_WorkStuRelation4ErrorLibEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_WorkStuRelation4ErrorLibEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_WorkStuRelation4ErrorLibEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_WorkStuRelation4ErrorLibEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_WorkStuRelation4ErrorLibEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_WorkStuRelation4ErrorLibEN.AttributeName)
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
if (clscc_WorkStuRelation4ErrorLibWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkStuRelation4ErrorLibWApi没有刷新缓存机制(clscc_WorkStuRelation4ErrorLibWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSourceTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSourceTypeWApi没有刷新缓存机制(clsSourceTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvcc_WorkStuRelation4ErrorLibObjLst_Cache == null)
//{
//arrvcc_WorkStuRelation4ErrorLibObjLst_Cache = await clsvcc_WorkStuRelation4ErrorLibWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsvcc_WorkStuRelation4ErrorLibEN._CurrTabName_S, strCourseId);
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
public static List<clsvcc_WorkStuRelation4ErrorLibEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvcc_WorkStuRelation4ErrorLibEN._CurrTabName_S, strCourseId);
List<clsvcc_WorkStuRelation4ErrorLibEN> arrvcc_WorkStuRelation4ErrorLibObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrvcc_WorkStuRelation4ErrorLibObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_WorkStuRelation4ErrorLibEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.AdminClsId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.AdminClsName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.QuestionIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.QuestionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.QuestionContent, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.SectionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.CourseChapterReferred, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.ParentNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.ParentNodeReferred, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.SourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.Creator, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.CreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.SourceTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.IsRedo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.RedoDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.IsPassed, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4ErrorLib.Memo, Type.GetType("System.String"));
foreach (clsvcc_WorkStuRelation4ErrorLibEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_WorkStuRelation4ErrorLib.CourseName] = objInFor[convcc_WorkStuRelation4ErrorLib.CourseName];
objDR[convcc_WorkStuRelation4ErrorLib.StuID] = objInFor[convcc_WorkStuRelation4ErrorLib.StuID];
objDR[convcc_WorkStuRelation4ErrorLib.StuName] = objInFor[convcc_WorkStuRelation4ErrorLib.StuName];
objDR[convcc_WorkStuRelation4ErrorLib.id_XzCollege] = objInFor[convcc_WorkStuRelation4ErrorLib.id_XzCollege];
objDR[convcc_WorkStuRelation4ErrorLib.CollegeName] = objInFor[convcc_WorkStuRelation4ErrorLib.CollegeName];
objDR[convcc_WorkStuRelation4ErrorLib.id_XzMajor] = objInFor[convcc_WorkStuRelation4ErrorLib.id_XzMajor];
objDR[convcc_WorkStuRelation4ErrorLib.MajorID] = objInFor[convcc_WorkStuRelation4ErrorLib.MajorID];
objDR[convcc_WorkStuRelation4ErrorLib.MajorName] = objInFor[convcc_WorkStuRelation4ErrorLib.MajorName];
objDR[convcc_WorkStuRelation4ErrorLib.id_GradeBase] = objInFor[convcc_WorkStuRelation4ErrorLib.id_GradeBase];
objDR[convcc_WorkStuRelation4ErrorLib.AdminClsId] = objInFor[convcc_WorkStuRelation4ErrorLib.AdminClsId];
objDR[convcc_WorkStuRelation4ErrorLib.AdminClsName] = objInFor[convcc_WorkStuRelation4ErrorLib.AdminClsName];
objDR[convcc_WorkStuRelation4ErrorLib.CollegeNameA] = objInFor[convcc_WorkStuRelation4ErrorLib.CollegeNameA];
objDR[convcc_WorkStuRelation4ErrorLib.GradeBaseName] = objInFor[convcc_WorkStuRelation4ErrorLib.GradeBaseName];
objDR[convcc_WorkStuRelation4ErrorLib.QuestionIndex] = objInFor[convcc_WorkStuRelation4ErrorLib.QuestionIndex];
objDR[convcc_WorkStuRelation4ErrorLib.QuestionName] = objInFor[convcc_WorkStuRelation4ErrorLib.QuestionName];
objDR[convcc_WorkStuRelation4ErrorLib.QuestionContent] = objInFor[convcc_WorkStuRelation4ErrorLib.QuestionContent];
objDR[convcc_WorkStuRelation4ErrorLib.CourseChapterId] = objInFor[convcc_WorkStuRelation4ErrorLib.CourseChapterId];
objDR[convcc_WorkStuRelation4ErrorLib.CourseChapterName] = objInFor[convcc_WorkStuRelation4ErrorLib.CourseChapterName];
objDR[convcc_WorkStuRelation4ErrorLib.ChapterName] = objInFor[convcc_WorkStuRelation4ErrorLib.ChapterName];
objDR[convcc_WorkStuRelation4ErrorLib.SectionName] = objInFor[convcc_WorkStuRelation4ErrorLib.SectionName];
objDR[convcc_WorkStuRelation4ErrorLib.ChapterName_Sim] = objInFor[convcc_WorkStuRelation4ErrorLib.ChapterName_Sim];
objDR[convcc_WorkStuRelation4ErrorLib.SectionName_Sim] = objInFor[convcc_WorkStuRelation4ErrorLib.SectionName_Sim];
objDR[convcc_WorkStuRelation4ErrorLib.ParentNodeID] = objInFor[convcc_WorkStuRelation4ErrorLib.ParentNodeID];
objDR[convcc_WorkStuRelation4ErrorLib.CourseChapterReferred] = objInFor[convcc_WorkStuRelation4ErrorLib.CourseChapterReferred];
objDR[convcc_WorkStuRelation4ErrorLib.ParentNodeName] = objInFor[convcc_WorkStuRelation4ErrorLib.ParentNodeName];
objDR[convcc_WorkStuRelation4ErrorLib.ParentNodeReferred] = objInFor[convcc_WorkStuRelation4ErrorLib.ParentNodeReferred];
objDR[convcc_WorkStuRelation4ErrorLib.SourceTypeName] = objInFor[convcc_WorkStuRelation4ErrorLib.SourceTypeName];
objDR[convcc_WorkStuRelation4ErrorLib.QuestionID] = objInFor[convcc_WorkStuRelation4ErrorLib.QuestionID];
objDR[convcc_WorkStuRelation4ErrorLib.mId] = objInFor[convcc_WorkStuRelation4ErrorLib.mId];
objDR[convcc_WorkStuRelation4ErrorLib.CourseId] = objInFor[convcc_WorkStuRelation4ErrorLib.CourseId];
objDR[convcc_WorkStuRelation4ErrorLib.id_StudentInfo] = objInFor[convcc_WorkStuRelation4ErrorLib.id_StudentInfo];
objDR[convcc_WorkStuRelation4ErrorLib.Creator] = objInFor[convcc_WorkStuRelation4ErrorLib.Creator];
objDR[convcc_WorkStuRelation4ErrorLib.CreateDate] = objInFor[convcc_WorkStuRelation4ErrorLib.CreateDate];
objDR[convcc_WorkStuRelation4ErrorLib.SourceTypeId] = objInFor[convcc_WorkStuRelation4ErrorLib.SourceTypeId];
objDR[convcc_WorkStuRelation4ErrorLib.IsRedo] = objInFor[convcc_WorkStuRelation4ErrorLib.IsRedo];
objDR[convcc_WorkStuRelation4ErrorLib.RedoDate] = objInFor[convcc_WorkStuRelation4ErrorLib.RedoDate];
objDR[convcc_WorkStuRelation4ErrorLib.IsPassed] = objInFor[convcc_WorkStuRelation4ErrorLib.IsPassed];
objDR[convcc_WorkStuRelation4ErrorLib.UpdDate] = objInFor[convcc_WorkStuRelation4ErrorLib.UpdDate];
objDR[convcc_WorkStuRelation4ErrorLib.UpdUser] = objInFor[convcc_WorkStuRelation4ErrorLib.UpdUser];
objDR[convcc_WorkStuRelation4ErrorLib.Memo] = objInFor[convcc_WorkStuRelation4ErrorLib.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}