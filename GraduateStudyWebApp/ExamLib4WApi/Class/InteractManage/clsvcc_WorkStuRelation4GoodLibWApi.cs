
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkStuRelation4GoodLibWApi
 表名:vcc_WorkStuRelation4GoodLib(01120225)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:46:19
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
public static class clsvcc_WorkStuRelation4GoodLibWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetCourseName(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_WorkStuRelation4GoodLib.CourseName);
objvcc_WorkStuRelation4GoodLibEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.CourseName) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.CourseName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.CourseName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetStuID(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convcc_WorkStuRelation4GoodLib.StuID);
objvcc_WorkStuRelation4GoodLibEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.StuID) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.StuID, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.StuID] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetStuName(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convcc_WorkStuRelation4GoodLib.StuName);
objvcc_WorkStuRelation4GoodLibEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.StuName) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.StuName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.StuName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN Setid_XzCollege(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convcc_WorkStuRelation4GoodLib.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convcc_WorkStuRelation4GoodLib.id_XzCollege);
objvcc_WorkStuRelation4GoodLibEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.id_XzCollege) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.id_XzCollege, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.id_XzCollege] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetCollegeName(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convcc_WorkStuRelation4GoodLib.CollegeName);
objvcc_WorkStuRelation4GoodLibEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.CollegeName) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.CollegeName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.CollegeName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetCollegeNameA(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convcc_WorkStuRelation4GoodLib.CollegeNameA);
objvcc_WorkStuRelation4GoodLibEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.CollegeNameA) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.CollegeNameA, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.CollegeNameA] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN Setid_XzMajor(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convcc_WorkStuRelation4GoodLib.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convcc_WorkStuRelation4GoodLib.id_XzMajor);
objvcc_WorkStuRelation4GoodLibEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.id_XzMajor) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.id_XzMajor, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.id_XzMajor] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetMajorID(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convcc_WorkStuRelation4GoodLib.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convcc_WorkStuRelation4GoodLib.MajorID);
objvcc_WorkStuRelation4GoodLibEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.MajorID) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.MajorID, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.MajorID] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetMajorName(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convcc_WorkStuRelation4GoodLib.MajorName);
objvcc_WorkStuRelation4GoodLibEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.MajorName) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.MajorName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.MajorName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN Setid_GradeBase(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convcc_WorkStuRelation4GoodLib.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convcc_WorkStuRelation4GoodLib.id_GradeBase);
objvcc_WorkStuRelation4GoodLibEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.id_GradeBase) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.id_GradeBase, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.id_GradeBase] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetGradeBaseName(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convcc_WorkStuRelation4GoodLib.GradeBaseName);
objvcc_WorkStuRelation4GoodLibEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.GradeBaseName) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.GradeBaseName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.GradeBaseName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetAdminClsName(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strAdminClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, convcc_WorkStuRelation4GoodLib.AdminClsName);
objvcc_WorkStuRelation4GoodLibEN.AdminClsName = strAdminClsName; //行政班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.AdminClsName) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.AdminClsName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.AdminClsName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetAdminClsId(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strAdminClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, convcc_WorkStuRelation4GoodLib.AdminClsId);
objvcc_WorkStuRelation4GoodLibEN.AdminClsId = strAdminClsId; //行政班代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.AdminClsId) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.AdminClsId, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.AdminClsId] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetQuestionIndex(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, int intQuestionIndex, string strComparisonOp="")
	{
objvcc_WorkStuRelation4GoodLibEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.QuestionIndex) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.QuestionIndex, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.QuestionIndex] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetQuestionName(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strQuestionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionName, 1000, convcc_WorkStuRelation4GoodLib.QuestionName);
objvcc_WorkStuRelation4GoodLibEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.QuestionName) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.QuestionName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.QuestionName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetQuestionContent(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strQuestionContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionContent, 4000, convcc_WorkStuRelation4GoodLib.QuestionContent);
objvcc_WorkStuRelation4GoodLibEN.QuestionContent = strQuestionContent; //题目内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.QuestionContent) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.QuestionContent, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.QuestionContent] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetCourseChapterId(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_WorkStuRelation4GoodLib.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_WorkStuRelation4GoodLib.CourseChapterId);
objvcc_WorkStuRelation4GoodLibEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.CourseChapterId) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.CourseChapterId, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.CourseChapterId] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetCourseChapterName(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_WorkStuRelation4GoodLib.CourseChapterName);
objvcc_WorkStuRelation4GoodLibEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.CourseChapterName) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.CourseChapterName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.CourseChapterName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetChapterName(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_WorkStuRelation4GoodLib.ChapterName);
objvcc_WorkStuRelation4GoodLibEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.ChapterName) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.ChapterName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.ChapterName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetSectionName(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_WorkStuRelation4GoodLib.SectionName);
objvcc_WorkStuRelation4GoodLibEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.SectionName) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.SectionName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.SectionName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetChapterName_Sim(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convcc_WorkStuRelation4GoodLib.ChapterName_Sim);
objvcc_WorkStuRelation4GoodLibEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.ChapterName_Sim) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.ChapterName_Sim, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.ChapterName_Sim] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetSectionName_Sim(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, convcc_WorkStuRelation4GoodLib.SectionName_Sim);
objvcc_WorkStuRelation4GoodLibEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.SectionName_Sim) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.SectionName_Sim, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.SectionName_Sim] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetParentNodeID(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convcc_WorkStuRelation4GoodLib.ParentNodeID);
objvcc_WorkStuRelation4GoodLibEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.ParentNodeID) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.ParentNodeID, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.ParentNodeID] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetCourseChapterReferred(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strCourseChapterReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convcc_WorkStuRelation4GoodLib.CourseChapterReferred);
objvcc_WorkStuRelation4GoodLibEN.CourseChapterReferred = strCourseChapterReferred; //节简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.CourseChapterReferred) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.CourseChapterReferred, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.CourseChapterReferred] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetParentNodeName(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strParentNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convcc_WorkStuRelation4GoodLib.ParentNodeName);
objvcc_WorkStuRelation4GoodLibEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.ParentNodeName) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.ParentNodeName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.ParentNodeName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetParentNodeReferred(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strParentNodeReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convcc_WorkStuRelation4GoodLib.ParentNodeReferred);
objvcc_WorkStuRelation4GoodLibEN.ParentNodeReferred = strParentNodeReferred; //章简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.ParentNodeReferred) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.ParentNodeReferred, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.ParentNodeReferred] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetSourceTypeName(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strSourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSourceTypeName, 20, convcc_WorkStuRelation4GoodLib.SourceTypeName);
objvcc_WorkStuRelation4GoodLibEN.SourceTypeName = strSourceTypeName; //来源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.SourceTypeName) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.SourceTypeName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.SourceTypeName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetQuestionID(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionID, 8, convcc_WorkStuRelation4GoodLib.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convcc_WorkStuRelation4GoodLib.QuestionID);
objvcc_WorkStuRelation4GoodLibEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.QuestionID) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.QuestionID, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.QuestionID] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetmId(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, long lngmId, string strComparisonOp="")
	{
objvcc_WorkStuRelation4GoodLibEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.mId) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.mId, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.mId] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetCourseId(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convcc_WorkStuRelation4GoodLib.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_WorkStuRelation4GoodLib.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_WorkStuRelation4GoodLib.CourseId);
objvcc_WorkStuRelation4GoodLibEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.CourseId) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.CourseId, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.CourseId] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN Setid_StudentInfo(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudentInfo, convcc_WorkStuRelation4GoodLib.id_StudentInfo);
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, convcc_WorkStuRelation4GoodLib.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, convcc_WorkStuRelation4GoodLib.id_StudentInfo);
objvcc_WorkStuRelation4GoodLibEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.id_StudentInfo) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.id_StudentInfo, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.id_StudentInfo] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetCreator(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strCreator, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreator, 18, convcc_WorkStuRelation4GoodLib.Creator);
objvcc_WorkStuRelation4GoodLibEN.Creator = strCreator; //创建者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.Creator) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.Creator, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.Creator] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetCreateDate(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convcc_WorkStuRelation4GoodLib.CreateDate);
objvcc_WorkStuRelation4GoodLibEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.CreateDate) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.CreateDate, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.CreateDate] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetSourceTypeId(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strSourceTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSourceTypeId, convcc_WorkStuRelation4GoodLib.SourceTypeId);
clsCheckSql.CheckFieldLen(strSourceTypeId, 2, convcc_WorkStuRelation4GoodLib.SourceTypeId);
clsCheckSql.CheckFieldForeignKey(strSourceTypeId, 2, convcc_WorkStuRelation4GoodLib.SourceTypeId);
objvcc_WorkStuRelation4GoodLibEN.SourceTypeId = strSourceTypeId; //来源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.SourceTypeId) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.SourceTypeId, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.SourceTypeId] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetIsRedo(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, bool bolIsRedo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsRedo, convcc_WorkStuRelation4GoodLib.IsRedo);
objvcc_WorkStuRelation4GoodLibEN.IsRedo = bolIsRedo; //是否重做
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.IsRedo) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.IsRedo, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.IsRedo] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetRedoDate(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strRedoDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRedoDate, 8, convcc_WorkStuRelation4GoodLib.RedoDate);
objvcc_WorkStuRelation4GoodLibEN.RedoDate = strRedoDate; //重做日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.RedoDate) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.RedoDate, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.RedoDate] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetIsPassed(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, bool bolIsPassed, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsPassed, convcc_WorkStuRelation4GoodLib.IsPassed);
objvcc_WorkStuRelation4GoodLibEN.IsPassed = bolIsPassed; //是否通过
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.IsPassed) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.IsPassed, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.IsPassed] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetUpdDate(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_WorkStuRelation4GoodLib.UpdDate);
objvcc_WorkStuRelation4GoodLibEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.UpdDate) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.UpdDate, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.UpdDate] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetUpdUser(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convcc_WorkStuRelation4GoodLib.UpdUser);
objvcc_WorkStuRelation4GoodLibEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.UpdUser) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.UpdUser, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.UpdUser] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetMemo(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_WorkStuRelation4GoodLib.Memo);
objvcc_WorkStuRelation4GoodLibEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.Memo) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.Memo, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.Memo] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLib_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.CourseName, objvcc_WorkStuRelation4GoodLib_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.StuID) == true)
{
string strComparisonOp_StuID = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.StuID, objvcc_WorkStuRelation4GoodLib_Cond.StuID, strComparisonOp_StuID);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.StuName) == true)
{
string strComparisonOp_StuName = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.StuName, objvcc_WorkStuRelation4GoodLib_Cond.StuName, strComparisonOp_StuName);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.id_XzCollege, objvcc_WorkStuRelation4GoodLib_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.CollegeName, objvcc_WorkStuRelation4GoodLib_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.CollegeNameA, objvcc_WorkStuRelation4GoodLib_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.id_XzMajor, objvcc_WorkStuRelation4GoodLib_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.MajorID) == true)
{
string strComparisonOp_MajorID = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.MajorID, objvcc_WorkStuRelation4GoodLib_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.MajorName) == true)
{
string strComparisonOp_MajorName = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.MajorName, objvcc_WorkStuRelation4GoodLib_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.id_GradeBase, objvcc_WorkStuRelation4GoodLib_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.GradeBaseName, objvcc_WorkStuRelation4GoodLib_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.AdminClsName) == true)
{
string strComparisonOp_AdminClsName = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.AdminClsName, objvcc_WorkStuRelation4GoodLib_Cond.AdminClsName, strComparisonOp_AdminClsName);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.AdminClsId) == true)
{
string strComparisonOp_AdminClsId = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.AdminClsId, objvcc_WorkStuRelation4GoodLib_Cond.AdminClsId, strComparisonOp_AdminClsId);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.QuestionIndex) == true)
{
string strComparisonOp_QuestionIndex = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation4GoodLib.QuestionIndex, objvcc_WorkStuRelation4GoodLib_Cond.QuestionIndex, strComparisonOp_QuestionIndex);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.QuestionName) == true)
{
string strComparisonOp_QuestionName = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.QuestionName, objvcc_WorkStuRelation4GoodLib_Cond.QuestionName, strComparisonOp_QuestionName);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.QuestionContent) == true)
{
string strComparisonOp_QuestionContent = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.QuestionContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.QuestionContent, objvcc_WorkStuRelation4GoodLib_Cond.QuestionContent, strComparisonOp_QuestionContent);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.CourseChapterId, objvcc_WorkStuRelation4GoodLib_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.CourseChapterName, objvcc_WorkStuRelation4GoodLib_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.ChapterName, objvcc_WorkStuRelation4GoodLib_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.SectionName) == true)
{
string strComparisonOp_SectionName = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.SectionName, objvcc_WorkStuRelation4GoodLib_Cond.SectionName, strComparisonOp_SectionName);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.ChapterName_Sim, objvcc_WorkStuRelation4GoodLib_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.SectionName_Sim, objvcc_WorkStuRelation4GoodLib_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.ParentNodeID, objvcc_WorkStuRelation4GoodLib_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.CourseChapterReferred) == true)
{
string strComparisonOp_CourseChapterReferred = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.CourseChapterReferred, objvcc_WorkStuRelation4GoodLib_Cond.CourseChapterReferred, strComparisonOp_CourseChapterReferred);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.ParentNodeName) == true)
{
string strComparisonOp_ParentNodeName = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.ParentNodeName, objvcc_WorkStuRelation4GoodLib_Cond.ParentNodeName, strComparisonOp_ParentNodeName);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.ParentNodeReferred) == true)
{
string strComparisonOp_ParentNodeReferred = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.ParentNodeReferred, objvcc_WorkStuRelation4GoodLib_Cond.ParentNodeReferred, strComparisonOp_ParentNodeReferred);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.SourceTypeName) == true)
{
string strComparisonOp_SourceTypeName = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.SourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.SourceTypeName, objvcc_WorkStuRelation4GoodLib_Cond.SourceTypeName, strComparisonOp_SourceTypeName);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.QuestionID) == true)
{
string strComparisonOp_QuestionID = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.QuestionID, objvcc_WorkStuRelation4GoodLib_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.mId) == true)
{
string strComparisonOp_mId = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation4GoodLib.mId, objvcc_WorkStuRelation4GoodLib_Cond.mId, strComparisonOp_mId);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.CourseId, objvcc_WorkStuRelation4GoodLib_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.id_StudentInfo, objvcc_WorkStuRelation4GoodLib_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.Creator) == true)
{
string strComparisonOp_Creator = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.Creator];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.Creator, objvcc_WorkStuRelation4GoodLib_Cond.Creator, strComparisonOp_Creator);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.CreateDate) == true)
{
string strComparisonOp_CreateDate = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.CreateDate, objvcc_WorkStuRelation4GoodLib_Cond.CreateDate, strComparisonOp_CreateDate);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.SourceTypeId) == true)
{
string strComparisonOp_SourceTypeId = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.SourceTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.SourceTypeId, objvcc_WorkStuRelation4GoodLib_Cond.SourceTypeId, strComparisonOp_SourceTypeId);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.IsRedo) == true)
{
if (objvcc_WorkStuRelation4GoodLib_Cond.IsRedo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation4GoodLib.IsRedo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation4GoodLib.IsRedo);
}
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.RedoDate) == true)
{
string strComparisonOp_RedoDate = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.RedoDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.RedoDate, objvcc_WorkStuRelation4GoodLib_Cond.RedoDate, strComparisonOp_RedoDate);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.IsPassed) == true)
{
if (objvcc_WorkStuRelation4GoodLib_Cond.IsPassed == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation4GoodLib.IsPassed);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation4GoodLib.IsPassed);
}
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.UpdDate, objvcc_WorkStuRelation4GoodLib_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.UpdUser, objvcc_WorkStuRelation4GoodLib_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvcc_WorkStuRelation4GoodLib_Cond.IsUpdated(convcc_WorkStuRelation4GoodLib.Memo) == true)
{
string strComparisonOp_Memo = objvcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.Memo, objvcc_WorkStuRelation4GoodLib_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v学生好题集(vcc_WorkStuRelation4GoodLib)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_WorkStuRelation4GoodLibWApi
{
private static readonly string mstrApiControllerName = "vcc_WorkStuRelation4GoodLibApi";

 public clsvcc_WorkStuRelation4GoodLibWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkStuRelation4GoodLibEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN = null;
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
objvcc_WorkStuRelation4GoodLibEN = JsonConvert.DeserializeObject<clsvcc_WorkStuRelation4GoodLibEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkStuRelation4GoodLibEN;
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
public static clsvcc_WorkStuRelation4GoodLibEN GetObjBymId_WA_Cache(long lngmId, string strCourseId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN = null;
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
objvcc_WorkStuRelation4GoodLibEN = JsonConvert.DeserializeObject<clsvcc_WorkStuRelation4GoodLibEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkStuRelation4GoodLibEN;
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
public static clsvcc_WorkStuRelation4GoodLibEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN = null;
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
objvcc_WorkStuRelation4GoodLibEN = JsonConvert.DeserializeObject<clsvcc_WorkStuRelation4GoodLibEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkStuRelation4GoodLibEN;
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
public static clsvcc_WorkStuRelation4GoodLibEN GetObjBymId_Cache(long lngmId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_WorkStuRelation4GoodLibEN._CurrTabName_S, strCourseId);
List<clsvcc_WorkStuRelation4GoodLibEN> arrvcc_WorkStuRelation4GoodLibObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvcc_WorkStuRelation4GoodLibEN> arrvcc_WorkStuRelation4GoodLibObjLst_Sel =
from objvcc_WorkStuRelation4GoodLibEN in arrvcc_WorkStuRelation4GoodLibObjLst_Cache
where objvcc_WorkStuRelation4GoodLibEN.mId == lngmId
select objvcc_WorkStuRelation4GoodLibEN;
if (arrvcc_WorkStuRelation4GoodLibObjLst_Sel.Count() == 0)
{
   clsvcc_WorkStuRelation4GoodLibEN obj = clsvcc_WorkStuRelation4GoodLibWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_WorkStuRelation4GoodLibObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelation4GoodLibEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_WorkStuRelation4GoodLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation4GoodLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelation4GoodLibEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvcc_WorkStuRelation4GoodLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation4GoodLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvcc_WorkStuRelation4GoodLibEN> GetObjLstByMIdLst_Cache(List<long> arrMId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_WorkStuRelation4GoodLibEN._CurrTabName_S, strCourseId);
List<clsvcc_WorkStuRelation4GoodLibEN> arrvcc_WorkStuRelation4GoodLibObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvcc_WorkStuRelation4GoodLibEN> arrvcc_WorkStuRelation4GoodLibObjLst_Sel =
from objvcc_WorkStuRelation4GoodLibEN in arrvcc_WorkStuRelation4GoodLibObjLst_Cache
where arrMId.Contains(objvcc_WorkStuRelation4GoodLibEN.mId)
select objvcc_WorkStuRelation4GoodLibEN;
return arrvcc_WorkStuRelation4GoodLibObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelation4GoodLibEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId, string strCourseId)
{
 List<clsvcc_WorkStuRelation4GoodLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation4GoodLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelation4GoodLibEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_WorkStuRelation4GoodLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation4GoodLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelation4GoodLibEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_WorkStuRelation4GoodLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation4GoodLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelation4GoodLibEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_WorkStuRelation4GoodLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation4GoodLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelation4GoodLibEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_WorkStuRelation4GoodLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation4GoodLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvcc_WorkStuRelation4GoodLibENS">源对象</param>
 /// <param name = "objvcc_WorkStuRelation4GoodLibENT">目标对象</param>
 public static void CopyTo(clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibENS, clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibENT)
{
try
{
objvcc_WorkStuRelation4GoodLibENT.CourseName = objvcc_WorkStuRelation4GoodLibENS.CourseName; //课程名称
objvcc_WorkStuRelation4GoodLibENT.StuID = objvcc_WorkStuRelation4GoodLibENS.StuID; //学号
objvcc_WorkStuRelation4GoodLibENT.StuName = objvcc_WorkStuRelation4GoodLibENS.StuName; //姓名
objvcc_WorkStuRelation4GoodLibENT.id_XzCollege = objvcc_WorkStuRelation4GoodLibENS.id_XzCollege; //学院流水号
objvcc_WorkStuRelation4GoodLibENT.CollegeName = objvcc_WorkStuRelation4GoodLibENS.CollegeName; //学院名称
objvcc_WorkStuRelation4GoodLibENT.CollegeNameA = objvcc_WorkStuRelation4GoodLibENS.CollegeNameA; //学院名称简写
objvcc_WorkStuRelation4GoodLibENT.id_XzMajor = objvcc_WorkStuRelation4GoodLibENS.id_XzMajor; //专业流水号
objvcc_WorkStuRelation4GoodLibENT.MajorID = objvcc_WorkStuRelation4GoodLibENS.MajorID; //专业ID
objvcc_WorkStuRelation4GoodLibENT.MajorName = objvcc_WorkStuRelation4GoodLibENS.MajorName; //专业名称
objvcc_WorkStuRelation4GoodLibENT.id_GradeBase = objvcc_WorkStuRelation4GoodLibENS.id_GradeBase; //年级流水号
objvcc_WorkStuRelation4GoodLibENT.GradeBaseName = objvcc_WorkStuRelation4GoodLibENS.GradeBaseName; //年级名称
objvcc_WorkStuRelation4GoodLibENT.AdminClsName = objvcc_WorkStuRelation4GoodLibENS.AdminClsName; //行政班名称
objvcc_WorkStuRelation4GoodLibENT.AdminClsId = objvcc_WorkStuRelation4GoodLibENS.AdminClsId; //行政班代号
objvcc_WorkStuRelation4GoodLibENT.QuestionIndex = objvcc_WorkStuRelation4GoodLibENS.QuestionIndex; //题目序号
objvcc_WorkStuRelation4GoodLibENT.QuestionName = objvcc_WorkStuRelation4GoodLibENS.QuestionName; //题目名称
objvcc_WorkStuRelation4GoodLibENT.QuestionContent = objvcc_WorkStuRelation4GoodLibENS.QuestionContent; //题目内容
objvcc_WorkStuRelation4GoodLibENT.CourseChapterId = objvcc_WorkStuRelation4GoodLibENS.CourseChapterId; //课程章节ID
objvcc_WorkStuRelation4GoodLibENT.CourseChapterName = objvcc_WorkStuRelation4GoodLibENS.CourseChapterName; //课程章节名称
objvcc_WorkStuRelation4GoodLibENT.ChapterName = objvcc_WorkStuRelation4GoodLibENS.ChapterName; //章名
objvcc_WorkStuRelation4GoodLibENT.SectionName = objvcc_WorkStuRelation4GoodLibENS.SectionName; //节名
objvcc_WorkStuRelation4GoodLibENT.ChapterName_Sim = objvcc_WorkStuRelation4GoodLibENS.ChapterName_Sim; //章名简称
objvcc_WorkStuRelation4GoodLibENT.SectionName_Sim = objvcc_WorkStuRelation4GoodLibENS.SectionName_Sim; //节名简称
objvcc_WorkStuRelation4GoodLibENT.ParentNodeID = objvcc_WorkStuRelation4GoodLibENS.ParentNodeID; //父节点编号
objvcc_WorkStuRelation4GoodLibENT.CourseChapterReferred = objvcc_WorkStuRelation4GoodLibENS.CourseChapterReferred; //节简称
objvcc_WorkStuRelation4GoodLibENT.ParentNodeName = objvcc_WorkStuRelation4GoodLibENS.ParentNodeName; //父节点名称
objvcc_WorkStuRelation4GoodLibENT.ParentNodeReferred = objvcc_WorkStuRelation4GoodLibENS.ParentNodeReferred; //章简称
objvcc_WorkStuRelation4GoodLibENT.SourceTypeName = objvcc_WorkStuRelation4GoodLibENS.SourceTypeName; //来源类型名称
objvcc_WorkStuRelation4GoodLibENT.QuestionID = objvcc_WorkStuRelation4GoodLibENS.QuestionID; //题目ID
objvcc_WorkStuRelation4GoodLibENT.mId = objvcc_WorkStuRelation4GoodLibENS.mId; //mId
objvcc_WorkStuRelation4GoodLibENT.CourseId = objvcc_WorkStuRelation4GoodLibENS.CourseId; //课程Id
objvcc_WorkStuRelation4GoodLibENT.id_StudentInfo = objvcc_WorkStuRelation4GoodLibENS.id_StudentInfo; //学生流水号
objvcc_WorkStuRelation4GoodLibENT.Creator = objvcc_WorkStuRelation4GoodLibENS.Creator; //创建者
objvcc_WorkStuRelation4GoodLibENT.CreateDate = objvcc_WorkStuRelation4GoodLibENS.CreateDate; //建立日期
objvcc_WorkStuRelation4GoodLibENT.SourceTypeId = objvcc_WorkStuRelation4GoodLibENS.SourceTypeId; //来源类型Id
objvcc_WorkStuRelation4GoodLibENT.IsRedo = objvcc_WorkStuRelation4GoodLibENS.IsRedo; //是否重做
objvcc_WorkStuRelation4GoodLibENT.RedoDate = objvcc_WorkStuRelation4GoodLibENS.RedoDate; //重做日期
objvcc_WorkStuRelation4GoodLibENT.IsPassed = objvcc_WorkStuRelation4GoodLibENS.IsPassed; //是否通过
objvcc_WorkStuRelation4GoodLibENT.UpdDate = objvcc_WorkStuRelation4GoodLibENS.UpdDate; //修改日期
objvcc_WorkStuRelation4GoodLibENT.UpdUser = objvcc_WorkStuRelation4GoodLibENS.UpdUser; //修改人
objvcc_WorkStuRelation4GoodLibENT.Memo = objvcc_WorkStuRelation4GoodLibENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvcc_WorkStuRelation4GoodLibEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_WorkStuRelation4GoodLibEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_WorkStuRelation4GoodLibEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_WorkStuRelation4GoodLibEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_WorkStuRelation4GoodLibEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_WorkStuRelation4GoodLibEN.AttributeName)
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
if (clsSourceTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSourceTypeWApi没有刷新缓存机制(clsSourceTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_WorkStuRelation4GoodLibWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkStuRelation4GoodLibWApi没有刷新缓存机制(clscc_WorkStuRelation4GoodLibWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvcc_WorkStuRelation4GoodLibObjLst_Cache == null)
//{
//arrvcc_WorkStuRelation4GoodLibObjLst_Cache = await clsvcc_WorkStuRelation4GoodLibWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsvcc_WorkStuRelation4GoodLibEN._CurrTabName_S, strCourseId);
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
public static List<clsvcc_WorkStuRelation4GoodLibEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvcc_WorkStuRelation4GoodLibEN._CurrTabName_S, strCourseId);
List<clsvcc_WorkStuRelation4GoodLibEN> arrvcc_WorkStuRelation4GoodLibObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrvcc_WorkStuRelation4GoodLibObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_WorkStuRelation4GoodLibEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.AdminClsName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.AdminClsId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.QuestionIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.QuestionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.QuestionContent, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.SectionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.CourseChapterReferred, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.ParentNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.ParentNodeReferred, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.SourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.Creator, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.CreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.SourceTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.IsRedo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.RedoDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.IsPassed, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4GoodLib.Memo, Type.GetType("System.String"));
foreach (clsvcc_WorkStuRelation4GoodLibEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_WorkStuRelation4GoodLib.CourseName] = objInFor[convcc_WorkStuRelation4GoodLib.CourseName];
objDR[convcc_WorkStuRelation4GoodLib.StuID] = objInFor[convcc_WorkStuRelation4GoodLib.StuID];
objDR[convcc_WorkStuRelation4GoodLib.StuName] = objInFor[convcc_WorkStuRelation4GoodLib.StuName];
objDR[convcc_WorkStuRelation4GoodLib.id_XzCollege] = objInFor[convcc_WorkStuRelation4GoodLib.id_XzCollege];
objDR[convcc_WorkStuRelation4GoodLib.CollegeName] = objInFor[convcc_WorkStuRelation4GoodLib.CollegeName];
objDR[convcc_WorkStuRelation4GoodLib.CollegeNameA] = objInFor[convcc_WorkStuRelation4GoodLib.CollegeNameA];
objDR[convcc_WorkStuRelation4GoodLib.id_XzMajor] = objInFor[convcc_WorkStuRelation4GoodLib.id_XzMajor];
objDR[convcc_WorkStuRelation4GoodLib.MajorID] = objInFor[convcc_WorkStuRelation4GoodLib.MajorID];
objDR[convcc_WorkStuRelation4GoodLib.MajorName] = objInFor[convcc_WorkStuRelation4GoodLib.MajorName];
objDR[convcc_WorkStuRelation4GoodLib.id_GradeBase] = objInFor[convcc_WorkStuRelation4GoodLib.id_GradeBase];
objDR[convcc_WorkStuRelation4GoodLib.GradeBaseName] = objInFor[convcc_WorkStuRelation4GoodLib.GradeBaseName];
objDR[convcc_WorkStuRelation4GoodLib.AdminClsName] = objInFor[convcc_WorkStuRelation4GoodLib.AdminClsName];
objDR[convcc_WorkStuRelation4GoodLib.AdminClsId] = objInFor[convcc_WorkStuRelation4GoodLib.AdminClsId];
objDR[convcc_WorkStuRelation4GoodLib.QuestionIndex] = objInFor[convcc_WorkStuRelation4GoodLib.QuestionIndex];
objDR[convcc_WorkStuRelation4GoodLib.QuestionName] = objInFor[convcc_WorkStuRelation4GoodLib.QuestionName];
objDR[convcc_WorkStuRelation4GoodLib.QuestionContent] = objInFor[convcc_WorkStuRelation4GoodLib.QuestionContent];
objDR[convcc_WorkStuRelation4GoodLib.CourseChapterId] = objInFor[convcc_WorkStuRelation4GoodLib.CourseChapterId];
objDR[convcc_WorkStuRelation4GoodLib.CourseChapterName] = objInFor[convcc_WorkStuRelation4GoodLib.CourseChapterName];
objDR[convcc_WorkStuRelation4GoodLib.ChapterName] = objInFor[convcc_WorkStuRelation4GoodLib.ChapterName];
objDR[convcc_WorkStuRelation4GoodLib.SectionName] = objInFor[convcc_WorkStuRelation4GoodLib.SectionName];
objDR[convcc_WorkStuRelation4GoodLib.ChapterName_Sim] = objInFor[convcc_WorkStuRelation4GoodLib.ChapterName_Sim];
objDR[convcc_WorkStuRelation4GoodLib.SectionName_Sim] = objInFor[convcc_WorkStuRelation4GoodLib.SectionName_Sim];
objDR[convcc_WorkStuRelation4GoodLib.ParentNodeID] = objInFor[convcc_WorkStuRelation4GoodLib.ParentNodeID];
objDR[convcc_WorkStuRelation4GoodLib.CourseChapterReferred] = objInFor[convcc_WorkStuRelation4GoodLib.CourseChapterReferred];
objDR[convcc_WorkStuRelation4GoodLib.ParentNodeName] = objInFor[convcc_WorkStuRelation4GoodLib.ParentNodeName];
objDR[convcc_WorkStuRelation4GoodLib.ParentNodeReferred] = objInFor[convcc_WorkStuRelation4GoodLib.ParentNodeReferred];
objDR[convcc_WorkStuRelation4GoodLib.SourceTypeName] = objInFor[convcc_WorkStuRelation4GoodLib.SourceTypeName];
objDR[convcc_WorkStuRelation4GoodLib.QuestionID] = objInFor[convcc_WorkStuRelation4GoodLib.QuestionID];
objDR[convcc_WorkStuRelation4GoodLib.mId] = objInFor[convcc_WorkStuRelation4GoodLib.mId];
objDR[convcc_WorkStuRelation4GoodLib.CourseId] = objInFor[convcc_WorkStuRelation4GoodLib.CourseId];
objDR[convcc_WorkStuRelation4GoodLib.id_StudentInfo] = objInFor[convcc_WorkStuRelation4GoodLib.id_StudentInfo];
objDR[convcc_WorkStuRelation4GoodLib.Creator] = objInFor[convcc_WorkStuRelation4GoodLib.Creator];
objDR[convcc_WorkStuRelation4GoodLib.CreateDate] = objInFor[convcc_WorkStuRelation4GoodLib.CreateDate];
objDR[convcc_WorkStuRelation4GoodLib.SourceTypeId] = objInFor[convcc_WorkStuRelation4GoodLib.SourceTypeId];
objDR[convcc_WorkStuRelation4GoodLib.IsRedo] = objInFor[convcc_WorkStuRelation4GoodLib.IsRedo];
objDR[convcc_WorkStuRelation4GoodLib.RedoDate] = objInFor[convcc_WorkStuRelation4GoodLib.RedoDate];
objDR[convcc_WorkStuRelation4GoodLib.IsPassed] = objInFor[convcc_WorkStuRelation4GoodLib.IsPassed];
objDR[convcc_WorkStuRelation4GoodLib.UpdDate] = objInFor[convcc_WorkStuRelation4GoodLib.UpdDate];
objDR[convcc_WorkStuRelation4GoodLib.UpdUser] = objInFor[convcc_WorkStuRelation4GoodLib.UpdUser];
objDR[convcc_WorkStuRelation4GoodLib.Memo] = objInFor[convcc_WorkStuRelation4GoodLib.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}