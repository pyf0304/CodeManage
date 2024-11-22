
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkStuRelation4ErrorLibBL
 表名:vcc_WorkStuRelation4ErrorLib(01120206)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:16
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
public static class  clsvcc_WorkStuRelation4ErrorLibBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN GetObj(this K_mId_vcc_WorkStuRelation4ErrorLib myKey)
{
clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN = clsvcc_WorkStuRelation4ErrorLibBL.vcc_WorkStuRelation4ErrorLibDA.GetObjBymId(myKey.Value);
return objvcc_WorkStuRelation4ErrorLibEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetCourseName(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_WorkStuRelation4ErrorLib.CourseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetStuID(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strStuID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuID, 20, convcc_WorkStuRelation4ErrorLib.StuID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetStuName(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strStuName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuName, 50, convcc_WorkStuRelation4ErrorLib.StuName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetIdXzCollege(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convcc_WorkStuRelation4ErrorLib.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convcc_WorkStuRelation4ErrorLib.IdXzCollege);
}
objvcc_WorkStuRelation4ErrorLibEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.IdXzCollege) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.IdXzCollege, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.IdXzCollege] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetCollegeName(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convcc_WorkStuRelation4ErrorLib.CollegeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetIdXzMajor(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convcc_WorkStuRelation4ErrorLib.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convcc_WorkStuRelation4ErrorLib.IdXzMajor);
}
objvcc_WorkStuRelation4ErrorLibEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.IdXzMajor) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.IdXzMajor, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.IdXzMajor] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetMajorID(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strMajorID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorID, 4, convcc_WorkStuRelation4ErrorLib.MajorID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convcc_WorkStuRelation4ErrorLib.MajorID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetMajorName(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convcc_WorkStuRelation4ErrorLib.MajorName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetIdGradeBase(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strIdGradeBase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, convcc_WorkStuRelation4ErrorLib.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, convcc_WorkStuRelation4ErrorLib.IdGradeBase);
}
objvcc_WorkStuRelation4ErrorLibEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.IdGradeBase) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.IdGradeBase, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.IdGradeBase] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetCollegeNameA(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convcc_WorkStuRelation4ErrorLib.CollegeNameA);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetGradeBaseName(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strGradeBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convcc_WorkStuRelation4ErrorLib.GradeBaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetQuestionIndex(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, int? intQuestionIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetQuestionName(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strQuestionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionName, 500, convcc_WorkStuRelation4ErrorLib.QuestionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetQuestionContent(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strQuestionContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionContent, 4000, convcc_WorkStuRelation4ErrorLib.QuestionContent);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetCourseChapterId(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_WorkStuRelation4ErrorLib.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_WorkStuRelation4ErrorLib.CourseChapterId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetCourseChapterName(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strCourseChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_WorkStuRelation4ErrorLib.CourseChapterName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetChapterName(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_WorkStuRelation4ErrorLib.ChapterName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetSectionName(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_WorkStuRelation4ErrorLib.SectionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetChapterNameSim(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strChapterNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterNameSim, 10, convcc_WorkStuRelation4ErrorLib.ChapterNameSim);
}
objvcc_WorkStuRelation4ErrorLibEN.ChapterNameSim = strChapterNameSim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.ChapterNameSim) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.ChapterNameSim, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.ChapterNameSim] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetSectionNameSim(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strSectionNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionNameSim, 10, convcc_WorkStuRelation4ErrorLib.SectionNameSim);
}
objvcc_WorkStuRelation4ErrorLibEN.SectionNameSim = strSectionNameSim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.SectionNameSim) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.SectionNameSim, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.SectionNameSim] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetParentNodeID(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strParentNodeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convcc_WorkStuRelation4ErrorLib.ParentNodeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetCourseChapterReferred(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strCourseChapterReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convcc_WorkStuRelation4ErrorLib.CourseChapterReferred);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetParentNodeName(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strParentNodeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convcc_WorkStuRelation4ErrorLib.ParentNodeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetParentNodeReferred(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strParentNodeReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convcc_WorkStuRelation4ErrorLib.ParentNodeReferred);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetSourceTypeName(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strSourceTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSourceTypeName, 20, convcc_WorkStuRelation4ErrorLib.SourceTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetQuestionID(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strQuestionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionID, 8, convcc_WorkStuRelation4ErrorLib.QuestionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convcc_WorkStuRelation4ErrorLib.QuestionID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetCourseId(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convcc_WorkStuRelation4ErrorLib.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_WorkStuRelation4ErrorLib.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_WorkStuRelation4ErrorLib.CourseId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetIdStudentInfo(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strIdStudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdStudentInfo, convcc_WorkStuRelation4ErrorLib.IdStudentInfo);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudentInfo, 8, convcc_WorkStuRelation4ErrorLib.IdStudentInfo);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudentInfo, 8, convcc_WorkStuRelation4ErrorLib.IdStudentInfo);
}
objvcc_WorkStuRelation4ErrorLibEN.IdStudentInfo = strIdStudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4ErrorLib.IdStudentInfo) == false)
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4ErrorLib.IdStudentInfo, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.IdStudentInfo] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetCreator(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strCreator, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreator, 18, convcc_WorkStuRelation4ErrorLib.Creator);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetCreateDate(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convcc_WorkStuRelation4ErrorLib.CreateDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetSourceTypeId(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strSourceTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSourceTypeId, convcc_WorkStuRelation4ErrorLib.SourceTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSourceTypeId, 2, convcc_WorkStuRelation4ErrorLib.SourceTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSourceTypeId, 2, convcc_WorkStuRelation4ErrorLib.SourceTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetRedoDate(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strRedoDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRedoDate, 8, convcc_WorkStuRelation4ErrorLib.RedoDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetUpdDate(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_WorkStuRelation4ErrorLib.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetUpdUser(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convcc_WorkStuRelation4ErrorLib.UpdUser);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN SetMemo(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_WorkStuRelation4ErrorLib.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibENS">源对象</param>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibENT">目标对象</param>
 public static void CopyTo(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibENS, clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibENT)
{
try
{
objvcc_WorkStuRelation4ErrorLibENT.CourseName = objvcc_WorkStuRelation4ErrorLibENS.CourseName; //课程名称
objvcc_WorkStuRelation4ErrorLibENT.StuID = objvcc_WorkStuRelation4ErrorLibENS.StuID; //学号
objvcc_WorkStuRelation4ErrorLibENT.StuName = objvcc_WorkStuRelation4ErrorLibENS.StuName; //姓名
objvcc_WorkStuRelation4ErrorLibENT.IdXzCollege = objvcc_WorkStuRelation4ErrorLibENS.IdXzCollege; //学院流水号
objvcc_WorkStuRelation4ErrorLibENT.CollegeName = objvcc_WorkStuRelation4ErrorLibENS.CollegeName; //学院名称
objvcc_WorkStuRelation4ErrorLibENT.IdXzMajor = objvcc_WorkStuRelation4ErrorLibENS.IdXzMajor; //专业流水号
objvcc_WorkStuRelation4ErrorLibENT.MajorID = objvcc_WorkStuRelation4ErrorLibENS.MajorID; //专业ID
objvcc_WorkStuRelation4ErrorLibENT.MajorName = objvcc_WorkStuRelation4ErrorLibENS.MajorName; //专业名称
objvcc_WorkStuRelation4ErrorLibENT.IdGradeBase = objvcc_WorkStuRelation4ErrorLibENS.IdGradeBase; //年级流水号
objvcc_WorkStuRelation4ErrorLibENT.CollegeNameA = objvcc_WorkStuRelation4ErrorLibENS.CollegeNameA; //学院名称简写
objvcc_WorkStuRelation4ErrorLibENT.GradeBaseName = objvcc_WorkStuRelation4ErrorLibENS.GradeBaseName; //年级名称
objvcc_WorkStuRelation4ErrorLibENT.QuestionIndex = objvcc_WorkStuRelation4ErrorLibENS.QuestionIndex; //题目序号
objvcc_WorkStuRelation4ErrorLibENT.QuestionName = objvcc_WorkStuRelation4ErrorLibENS.QuestionName; //题目名称
objvcc_WorkStuRelation4ErrorLibENT.QuestionContent = objvcc_WorkStuRelation4ErrorLibENS.QuestionContent; //题目内容
objvcc_WorkStuRelation4ErrorLibENT.CourseChapterId = objvcc_WorkStuRelation4ErrorLibENS.CourseChapterId; //课程章节ID
objvcc_WorkStuRelation4ErrorLibENT.CourseChapterName = objvcc_WorkStuRelation4ErrorLibENS.CourseChapterName; //课程章节名称
objvcc_WorkStuRelation4ErrorLibENT.ChapterName = objvcc_WorkStuRelation4ErrorLibENS.ChapterName; //章名
objvcc_WorkStuRelation4ErrorLibENT.SectionName = objvcc_WorkStuRelation4ErrorLibENS.SectionName; //节名
objvcc_WorkStuRelation4ErrorLibENT.ChapterNameSim = objvcc_WorkStuRelation4ErrorLibENS.ChapterNameSim; //章名简称
objvcc_WorkStuRelation4ErrorLibENT.SectionNameSim = objvcc_WorkStuRelation4ErrorLibENS.SectionNameSim; //节名简称
objvcc_WorkStuRelation4ErrorLibENT.ParentNodeID = objvcc_WorkStuRelation4ErrorLibENS.ParentNodeID; //父节点编号
objvcc_WorkStuRelation4ErrorLibENT.CourseChapterReferred = objvcc_WorkStuRelation4ErrorLibENS.CourseChapterReferred; //节简称
objvcc_WorkStuRelation4ErrorLibENT.ParentNodeName = objvcc_WorkStuRelation4ErrorLibENS.ParentNodeName; //父节点名称
objvcc_WorkStuRelation4ErrorLibENT.ParentNodeReferred = objvcc_WorkStuRelation4ErrorLibENS.ParentNodeReferred; //章简称
objvcc_WorkStuRelation4ErrorLibENT.SourceTypeName = objvcc_WorkStuRelation4ErrorLibENS.SourceTypeName; //来源类型名称
objvcc_WorkStuRelation4ErrorLibENT.QuestionID = objvcc_WorkStuRelation4ErrorLibENS.QuestionID; //题目ID
objvcc_WorkStuRelation4ErrorLibENT.mId = objvcc_WorkStuRelation4ErrorLibENS.mId; //mId
objvcc_WorkStuRelation4ErrorLibENT.CourseId = objvcc_WorkStuRelation4ErrorLibENS.CourseId; //课程Id
objvcc_WorkStuRelation4ErrorLibENT.IdStudentInfo = objvcc_WorkStuRelation4ErrorLibENS.IdStudentInfo; //学生流水号
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
 /// <param name = "objvcc_WorkStuRelation4ErrorLibENS">源对象</param>
 /// <returns>目标对象=>clsvcc_WorkStuRelation4ErrorLibEN:objvcc_WorkStuRelation4ErrorLibENT</returns>
 public static clsvcc_WorkStuRelation4ErrorLibEN CopyTo(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibENS)
{
try
{
 clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibENT = new clsvcc_WorkStuRelation4ErrorLibEN()
{
CourseName = objvcc_WorkStuRelation4ErrorLibENS.CourseName, //课程名称
StuID = objvcc_WorkStuRelation4ErrorLibENS.StuID, //学号
StuName = objvcc_WorkStuRelation4ErrorLibENS.StuName, //姓名
IdXzCollege = objvcc_WorkStuRelation4ErrorLibENS.IdXzCollege, //学院流水号
CollegeName = objvcc_WorkStuRelation4ErrorLibENS.CollegeName, //学院名称
IdXzMajor = objvcc_WorkStuRelation4ErrorLibENS.IdXzMajor, //专业流水号
MajorID = objvcc_WorkStuRelation4ErrorLibENS.MajorID, //专业ID
MajorName = objvcc_WorkStuRelation4ErrorLibENS.MajorName, //专业名称
IdGradeBase = objvcc_WorkStuRelation4ErrorLibENS.IdGradeBase, //年级流水号
CollegeNameA = objvcc_WorkStuRelation4ErrorLibENS.CollegeNameA, //学院名称简写
GradeBaseName = objvcc_WorkStuRelation4ErrorLibENS.GradeBaseName, //年级名称
QuestionIndex = objvcc_WorkStuRelation4ErrorLibENS.QuestionIndex, //题目序号
QuestionName = objvcc_WorkStuRelation4ErrorLibENS.QuestionName, //题目名称
QuestionContent = objvcc_WorkStuRelation4ErrorLibENS.QuestionContent, //题目内容
CourseChapterId = objvcc_WorkStuRelation4ErrorLibENS.CourseChapterId, //课程章节ID
CourseChapterName = objvcc_WorkStuRelation4ErrorLibENS.CourseChapterName, //课程章节名称
ChapterName = objvcc_WorkStuRelation4ErrorLibENS.ChapterName, //章名
SectionName = objvcc_WorkStuRelation4ErrorLibENS.SectionName, //节名
ChapterNameSim = objvcc_WorkStuRelation4ErrorLibENS.ChapterNameSim, //章名简称
SectionNameSim = objvcc_WorkStuRelation4ErrorLibENS.SectionNameSim, //节名简称
ParentNodeID = objvcc_WorkStuRelation4ErrorLibENS.ParentNodeID, //父节点编号
CourseChapterReferred = objvcc_WorkStuRelation4ErrorLibENS.CourseChapterReferred, //节简称
ParentNodeName = objvcc_WorkStuRelation4ErrorLibENS.ParentNodeName, //父节点名称
ParentNodeReferred = objvcc_WorkStuRelation4ErrorLibENS.ParentNodeReferred, //章简称
SourceTypeName = objvcc_WorkStuRelation4ErrorLibENS.SourceTypeName, //来源类型名称
QuestionID = objvcc_WorkStuRelation4ErrorLibENS.QuestionID, //题目ID
mId = objvcc_WorkStuRelation4ErrorLibENS.mId, //mId
CourseId = objvcc_WorkStuRelation4ErrorLibENS.CourseId, //课程Id
IdStudentInfo = objvcc_WorkStuRelation4ErrorLibENS.IdStudentInfo, //学生流水号
Creator = objvcc_WorkStuRelation4ErrorLibENS.Creator, //创建者
CreateDate = objvcc_WorkStuRelation4ErrorLibENS.CreateDate, //建立日期
SourceTypeId = objvcc_WorkStuRelation4ErrorLibENS.SourceTypeId, //来源类型Id
IsRedo = objvcc_WorkStuRelation4ErrorLibENS.IsRedo, //是否重做
RedoDate = objvcc_WorkStuRelation4ErrorLibENS.RedoDate, //重做日期
IsPassed = objvcc_WorkStuRelation4ErrorLibENS.IsPassed, //是否通过
UpdDate = objvcc_WorkStuRelation4ErrorLibENS.UpdDate, //修改日期
UpdUser = objvcc_WorkStuRelation4ErrorLibENS.UpdUser, //修改人
Memo = objvcc_WorkStuRelation4ErrorLibENS.Memo, //备注
};
 return objvcc_WorkStuRelation4ErrorLibENT;
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
public static void CheckProperty4Condition(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN)
{
 clsvcc_WorkStuRelation4ErrorLibBL.vcc_WorkStuRelation4ErrorLibDA.CheckProperty4Condition(objvcc_WorkStuRelation4ErrorLibEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.CourseName) == true)
{
string strComparisonOpCourseName = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.CourseName, objvcc_WorkStuRelation4ErrorLibCond.CourseName, strComparisonOpCourseName);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.StuID) == true)
{
string strComparisonOpStuID = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.StuID, objvcc_WorkStuRelation4ErrorLibCond.StuID, strComparisonOpStuID);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.StuName) == true)
{
string strComparisonOpStuName = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.StuName, objvcc_WorkStuRelation4ErrorLibCond.StuName, strComparisonOpStuName);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.IdXzCollege, objvcc_WorkStuRelation4ErrorLibCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.CollegeName) == true)
{
string strComparisonOpCollegeName = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.CollegeName, objvcc_WorkStuRelation4ErrorLibCond.CollegeName, strComparisonOpCollegeName);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.IdXzMajor, objvcc_WorkStuRelation4ErrorLibCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.MajorID) == true)
{
string strComparisonOpMajorID = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.MajorID, objvcc_WorkStuRelation4ErrorLibCond.MajorID, strComparisonOpMajorID);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.MajorName) == true)
{
string strComparisonOpMajorName = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.MajorName, objvcc_WorkStuRelation4ErrorLibCond.MajorName, strComparisonOpMajorName);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.IdGradeBase, objvcc_WorkStuRelation4ErrorLibCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.CollegeNameA, objvcc_WorkStuRelation4ErrorLibCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.GradeBaseName) == true)
{
string strComparisonOpGradeBaseName = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.GradeBaseName, objvcc_WorkStuRelation4ErrorLibCond.GradeBaseName, strComparisonOpGradeBaseName);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.QuestionIndex) == true)
{
string strComparisonOpQuestionIndex = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation4ErrorLib.QuestionIndex, objvcc_WorkStuRelation4ErrorLibCond.QuestionIndex, strComparisonOpQuestionIndex);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.QuestionName) == true)
{
string strComparisonOpQuestionName = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.QuestionName, objvcc_WorkStuRelation4ErrorLibCond.QuestionName, strComparisonOpQuestionName);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.QuestionContent) == true)
{
string strComparisonOpQuestionContent = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.QuestionContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.QuestionContent, objvcc_WorkStuRelation4ErrorLibCond.QuestionContent, strComparisonOpQuestionContent);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.CourseChapterId, objvcc_WorkStuRelation4ErrorLibCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.CourseChapterName) == true)
{
string strComparisonOpCourseChapterName = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.CourseChapterName, objvcc_WorkStuRelation4ErrorLibCond.CourseChapterName, strComparisonOpCourseChapterName);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.ChapterName) == true)
{
string strComparisonOpChapterName = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.ChapterName, objvcc_WorkStuRelation4ErrorLibCond.ChapterName, strComparisonOpChapterName);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.SectionName) == true)
{
string strComparisonOpSectionName = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.SectionName, objvcc_WorkStuRelation4ErrorLibCond.SectionName, strComparisonOpSectionName);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.ChapterNameSim) == true)
{
string strComparisonOpChapterNameSim = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.ChapterNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.ChapterNameSim, objvcc_WorkStuRelation4ErrorLibCond.ChapterNameSim, strComparisonOpChapterNameSim);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.SectionNameSim) == true)
{
string strComparisonOpSectionNameSim = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.SectionNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.SectionNameSim, objvcc_WorkStuRelation4ErrorLibCond.SectionNameSim, strComparisonOpSectionNameSim);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.ParentNodeID) == true)
{
string strComparisonOpParentNodeID = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.ParentNodeID, objvcc_WorkStuRelation4ErrorLibCond.ParentNodeID, strComparisonOpParentNodeID);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.CourseChapterReferred) == true)
{
string strComparisonOpCourseChapterReferred = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.CourseChapterReferred, objvcc_WorkStuRelation4ErrorLibCond.CourseChapterReferred, strComparisonOpCourseChapterReferred);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.ParentNodeName) == true)
{
string strComparisonOpParentNodeName = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.ParentNodeName, objvcc_WorkStuRelation4ErrorLibCond.ParentNodeName, strComparisonOpParentNodeName);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.ParentNodeReferred) == true)
{
string strComparisonOpParentNodeReferred = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.ParentNodeReferred, objvcc_WorkStuRelation4ErrorLibCond.ParentNodeReferred, strComparisonOpParentNodeReferred);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.SourceTypeName) == true)
{
string strComparisonOpSourceTypeName = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.SourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.SourceTypeName, objvcc_WorkStuRelation4ErrorLibCond.SourceTypeName, strComparisonOpSourceTypeName);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.QuestionID) == true)
{
string strComparisonOpQuestionID = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.QuestionID, objvcc_WorkStuRelation4ErrorLibCond.QuestionID, strComparisonOpQuestionID);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.mId) == true)
{
string strComparisonOpmId = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation4ErrorLib.mId, objvcc_WorkStuRelation4ErrorLibCond.mId, strComparisonOpmId);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.CourseId) == true)
{
string strComparisonOpCourseId = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.CourseId, objvcc_WorkStuRelation4ErrorLibCond.CourseId, strComparisonOpCourseId);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.IdStudentInfo) == true)
{
string strComparisonOpIdStudentInfo = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.IdStudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.IdStudentInfo, objvcc_WorkStuRelation4ErrorLibCond.IdStudentInfo, strComparisonOpIdStudentInfo);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.Creator) == true)
{
string strComparisonOpCreator = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.Creator];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.Creator, objvcc_WorkStuRelation4ErrorLibCond.Creator, strComparisonOpCreator);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.CreateDate) == true)
{
string strComparisonOpCreateDate = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.CreateDate, objvcc_WorkStuRelation4ErrorLibCond.CreateDate, strComparisonOpCreateDate);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.SourceTypeId) == true)
{
string strComparisonOpSourceTypeId = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.SourceTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.SourceTypeId, objvcc_WorkStuRelation4ErrorLibCond.SourceTypeId, strComparisonOpSourceTypeId);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.IsRedo) == true)
{
if (objvcc_WorkStuRelation4ErrorLibCond.IsRedo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation4ErrorLib.IsRedo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation4ErrorLib.IsRedo);
}
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.RedoDate) == true)
{
string strComparisonOpRedoDate = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.RedoDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.RedoDate, objvcc_WorkStuRelation4ErrorLibCond.RedoDate, strComparisonOpRedoDate);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.IsPassed) == true)
{
if (objvcc_WorkStuRelation4ErrorLibCond.IsPassed == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation4ErrorLib.IsPassed);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation4ErrorLib.IsPassed);
}
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.UpdDate) == true)
{
string strComparisonOpUpdDate = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.UpdDate, objvcc_WorkStuRelation4ErrorLibCond.UpdDate, strComparisonOpUpdDate);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.UpdUser) == true)
{
string strComparisonOpUpdUser = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.UpdUser, objvcc_WorkStuRelation4ErrorLibCond.UpdUser, strComparisonOpUpdUser);
}
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(convcc_WorkStuRelation4ErrorLib.Memo) == true)
{
string strComparisonOpMemo = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[convcc_WorkStuRelation4ErrorLib.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4ErrorLib.Memo, objvcc_WorkStuRelation4ErrorLibCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcc_WorkStuRelation4ErrorLib
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v学生错误作业集(vcc_WorkStuRelation4ErrorLib)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcc_WorkStuRelation4ErrorLibBL
{
public static RelatedActions_vcc_WorkStuRelation4ErrorLib relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcc_WorkStuRelation4ErrorLibDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcc_WorkStuRelation4ErrorLibDA vcc_WorkStuRelation4ErrorLibDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcc_WorkStuRelation4ErrorLibDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcc_WorkStuRelation4ErrorLibBL()
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
if (string.IsNullOrEmpty(clsvcc_WorkStuRelation4ErrorLibEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_WorkStuRelation4ErrorLibEN._ConnectString);
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
public static DataTable GetDataTable_vcc_WorkStuRelation4ErrorLib(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcc_WorkStuRelation4ErrorLibDA.GetDataTable_vcc_WorkStuRelation4ErrorLib(strWhereCond);
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
objDT = vcc_WorkStuRelation4ErrorLibDA.GetDataTable(strWhereCond);
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
objDT = vcc_WorkStuRelation4ErrorLibDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcc_WorkStuRelation4ErrorLibDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcc_WorkStuRelation4ErrorLibDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcc_WorkStuRelation4ErrorLibDA.GetDataTable_Top(objTopPara);
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
objDT = vcc_WorkStuRelation4ErrorLibDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcc_WorkStuRelation4ErrorLibDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcc_WorkStuRelation4ErrorLibDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvcc_WorkStuRelation4ErrorLibEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvcc_WorkStuRelation4ErrorLibEN> arrObjLst = new List<clsvcc_WorkStuRelation4ErrorLibEN>(); 
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
	clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN = new clsvcc_WorkStuRelation4ErrorLibEN();
try
{
objvcc_WorkStuRelation4ErrorLibEN.CourseName = objRow[convcc_WorkStuRelation4ErrorLib.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4ErrorLibEN.StuID = objRow[convcc_WorkStuRelation4ErrorLib.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4ErrorLibEN.StuName = objRow[convcc_WorkStuRelation4ErrorLib.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4ErrorLibEN.IdXzCollege = objRow[convcc_WorkStuRelation4ErrorLib.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4ErrorLibEN.CollegeName = objRow[convcc_WorkStuRelation4ErrorLib.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4ErrorLibEN.IdXzMajor = objRow[convcc_WorkStuRelation4ErrorLib.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4ErrorLibEN.MajorID = objRow[convcc_WorkStuRelation4ErrorLib.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4ErrorLibEN.MajorName = objRow[convcc_WorkStuRelation4ErrorLib.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4ErrorLibEN.IdGradeBase = objRow[convcc_WorkStuRelation4ErrorLib.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4ErrorLibEN.CollegeNameA = objRow[convcc_WorkStuRelation4ErrorLib.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4ErrorLibEN.GradeBaseName = objRow[convcc_WorkStuRelation4ErrorLib.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4ErrorLibEN.QuestionIndex = objRow[convcc_WorkStuRelation4ErrorLib.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4ErrorLib.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4ErrorLibEN.QuestionName = objRow[convcc_WorkStuRelation4ErrorLib.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4ErrorLibEN.QuestionContent = objRow[convcc_WorkStuRelation4ErrorLib.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterId = objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterName = objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4ErrorLibEN.ChapterName = objRow[convcc_WorkStuRelation4ErrorLib.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4ErrorLibEN.SectionName = objRow[convcc_WorkStuRelation4ErrorLib.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4ErrorLibEN.ChapterNameSim = objRow[convcc_WorkStuRelation4ErrorLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4ErrorLibEN.SectionNameSim = objRow[convcc_WorkStuRelation4ErrorLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeID = objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeName = objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4ErrorLibEN.SourceTypeName = objRow[convcc_WorkStuRelation4ErrorLib.SourceTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.SourceTypeName].ToString().Trim(); //来源类型名称
objvcc_WorkStuRelation4ErrorLibEN.QuestionID = objRow[convcc_WorkStuRelation4ErrorLib.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4ErrorLibEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4ErrorLib.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4ErrorLibEN.CourseId = objRow[convcc_WorkStuRelation4ErrorLib.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4ErrorLibEN.IdStudentInfo = objRow[convcc_WorkStuRelation4ErrorLib.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4ErrorLibEN.Creator = objRow[convcc_WorkStuRelation4ErrorLib.Creator] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.Creator].ToString().Trim(); //创建者
objvcc_WorkStuRelation4ErrorLibEN.CreateDate = objRow[convcc_WorkStuRelation4ErrorLib.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkStuRelation4ErrorLibEN.SourceTypeId = objRow[convcc_WorkStuRelation4ErrorLib.SourceTypeId].ToString().Trim(); //来源类型Id
objvcc_WorkStuRelation4ErrorLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4ErrorLib.IsRedo].ToString().Trim()); //是否重做
objvcc_WorkStuRelation4ErrorLibEN.RedoDate = objRow[convcc_WorkStuRelation4ErrorLib.RedoDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.RedoDate].ToString().Trim(); //重做日期
objvcc_WorkStuRelation4ErrorLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4ErrorLib.IsPassed].ToString().Trim()); //是否通过
objvcc_WorkStuRelation4ErrorLibEN.UpdDate = objRow[convcc_WorkStuRelation4ErrorLib.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4ErrorLibEN.UpdUser = objRow[convcc_WorkStuRelation4ErrorLib.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4ErrorLibEN.Memo = objRow[convcc_WorkStuRelation4ErrorLib.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelation4ErrorLibEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelation4ErrorLibEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcc_WorkStuRelation4ErrorLibEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsvcc_WorkStuRelation4ErrorLibEN._CurrTabName, strCourseId);
List<clsvcc_WorkStuRelation4ErrorLibEN> arrvcc_WorkStuRelation4ErrorLibObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_WorkStuRelation4ErrorLibEN> arrvcc_WorkStuRelation4ErrorLibObjLst_Sel =
arrvcc_WorkStuRelation4ErrorLibObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvcc_WorkStuRelation4ErrorLibObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelation4ErrorLibEN> GetObjLst(string strWhereCond)
{
List<clsvcc_WorkStuRelation4ErrorLibEN> arrObjLst = new List<clsvcc_WorkStuRelation4ErrorLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN = new clsvcc_WorkStuRelation4ErrorLibEN();
try
{
objvcc_WorkStuRelation4ErrorLibEN.CourseName = objRow[convcc_WorkStuRelation4ErrorLib.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4ErrorLibEN.StuID = objRow[convcc_WorkStuRelation4ErrorLib.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4ErrorLibEN.StuName = objRow[convcc_WorkStuRelation4ErrorLib.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4ErrorLibEN.IdXzCollege = objRow[convcc_WorkStuRelation4ErrorLib.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4ErrorLibEN.CollegeName = objRow[convcc_WorkStuRelation4ErrorLib.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4ErrorLibEN.IdXzMajor = objRow[convcc_WorkStuRelation4ErrorLib.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4ErrorLibEN.MajorID = objRow[convcc_WorkStuRelation4ErrorLib.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4ErrorLibEN.MajorName = objRow[convcc_WorkStuRelation4ErrorLib.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4ErrorLibEN.IdGradeBase = objRow[convcc_WorkStuRelation4ErrorLib.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4ErrorLibEN.CollegeNameA = objRow[convcc_WorkStuRelation4ErrorLib.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4ErrorLibEN.GradeBaseName = objRow[convcc_WorkStuRelation4ErrorLib.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4ErrorLibEN.QuestionIndex = objRow[convcc_WorkStuRelation4ErrorLib.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4ErrorLib.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4ErrorLibEN.QuestionName = objRow[convcc_WorkStuRelation4ErrorLib.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4ErrorLibEN.QuestionContent = objRow[convcc_WorkStuRelation4ErrorLib.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterId = objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterName = objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4ErrorLibEN.ChapterName = objRow[convcc_WorkStuRelation4ErrorLib.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4ErrorLibEN.SectionName = objRow[convcc_WorkStuRelation4ErrorLib.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4ErrorLibEN.ChapterNameSim = objRow[convcc_WorkStuRelation4ErrorLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4ErrorLibEN.SectionNameSim = objRow[convcc_WorkStuRelation4ErrorLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeID = objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeName = objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4ErrorLibEN.SourceTypeName = objRow[convcc_WorkStuRelation4ErrorLib.SourceTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.SourceTypeName].ToString().Trim(); //来源类型名称
objvcc_WorkStuRelation4ErrorLibEN.QuestionID = objRow[convcc_WorkStuRelation4ErrorLib.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4ErrorLibEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4ErrorLib.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4ErrorLibEN.CourseId = objRow[convcc_WorkStuRelation4ErrorLib.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4ErrorLibEN.IdStudentInfo = objRow[convcc_WorkStuRelation4ErrorLib.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4ErrorLibEN.Creator = objRow[convcc_WorkStuRelation4ErrorLib.Creator] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.Creator].ToString().Trim(); //创建者
objvcc_WorkStuRelation4ErrorLibEN.CreateDate = objRow[convcc_WorkStuRelation4ErrorLib.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkStuRelation4ErrorLibEN.SourceTypeId = objRow[convcc_WorkStuRelation4ErrorLib.SourceTypeId].ToString().Trim(); //来源类型Id
objvcc_WorkStuRelation4ErrorLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4ErrorLib.IsRedo].ToString().Trim()); //是否重做
objvcc_WorkStuRelation4ErrorLibEN.RedoDate = objRow[convcc_WorkStuRelation4ErrorLib.RedoDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.RedoDate].ToString().Trim(); //重做日期
objvcc_WorkStuRelation4ErrorLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4ErrorLib.IsPassed].ToString().Trim()); //是否通过
objvcc_WorkStuRelation4ErrorLibEN.UpdDate = objRow[convcc_WorkStuRelation4ErrorLib.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4ErrorLibEN.UpdUser = objRow[convcc_WorkStuRelation4ErrorLib.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4ErrorLibEN.Memo = objRow[convcc_WorkStuRelation4ErrorLib.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelation4ErrorLibEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelation4ErrorLibEN);
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
public static List<clsvcc_WorkStuRelation4ErrorLibEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcc_WorkStuRelation4ErrorLibEN> arrObjLst = new List<clsvcc_WorkStuRelation4ErrorLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN = new clsvcc_WorkStuRelation4ErrorLibEN();
try
{
objvcc_WorkStuRelation4ErrorLibEN.CourseName = objRow[convcc_WorkStuRelation4ErrorLib.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4ErrorLibEN.StuID = objRow[convcc_WorkStuRelation4ErrorLib.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4ErrorLibEN.StuName = objRow[convcc_WorkStuRelation4ErrorLib.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4ErrorLibEN.IdXzCollege = objRow[convcc_WorkStuRelation4ErrorLib.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4ErrorLibEN.CollegeName = objRow[convcc_WorkStuRelation4ErrorLib.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4ErrorLibEN.IdXzMajor = objRow[convcc_WorkStuRelation4ErrorLib.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4ErrorLibEN.MajorID = objRow[convcc_WorkStuRelation4ErrorLib.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4ErrorLibEN.MajorName = objRow[convcc_WorkStuRelation4ErrorLib.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4ErrorLibEN.IdGradeBase = objRow[convcc_WorkStuRelation4ErrorLib.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4ErrorLibEN.CollegeNameA = objRow[convcc_WorkStuRelation4ErrorLib.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4ErrorLibEN.GradeBaseName = objRow[convcc_WorkStuRelation4ErrorLib.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4ErrorLibEN.QuestionIndex = objRow[convcc_WorkStuRelation4ErrorLib.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4ErrorLib.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4ErrorLibEN.QuestionName = objRow[convcc_WorkStuRelation4ErrorLib.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4ErrorLibEN.QuestionContent = objRow[convcc_WorkStuRelation4ErrorLib.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterId = objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterName = objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4ErrorLibEN.ChapterName = objRow[convcc_WorkStuRelation4ErrorLib.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4ErrorLibEN.SectionName = objRow[convcc_WorkStuRelation4ErrorLib.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4ErrorLibEN.ChapterNameSim = objRow[convcc_WorkStuRelation4ErrorLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4ErrorLibEN.SectionNameSim = objRow[convcc_WorkStuRelation4ErrorLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeID = objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeName = objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4ErrorLibEN.SourceTypeName = objRow[convcc_WorkStuRelation4ErrorLib.SourceTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.SourceTypeName].ToString().Trim(); //来源类型名称
objvcc_WorkStuRelation4ErrorLibEN.QuestionID = objRow[convcc_WorkStuRelation4ErrorLib.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4ErrorLibEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4ErrorLib.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4ErrorLibEN.CourseId = objRow[convcc_WorkStuRelation4ErrorLib.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4ErrorLibEN.IdStudentInfo = objRow[convcc_WorkStuRelation4ErrorLib.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4ErrorLibEN.Creator = objRow[convcc_WorkStuRelation4ErrorLib.Creator] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.Creator].ToString().Trim(); //创建者
objvcc_WorkStuRelation4ErrorLibEN.CreateDate = objRow[convcc_WorkStuRelation4ErrorLib.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkStuRelation4ErrorLibEN.SourceTypeId = objRow[convcc_WorkStuRelation4ErrorLib.SourceTypeId].ToString().Trim(); //来源类型Id
objvcc_WorkStuRelation4ErrorLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4ErrorLib.IsRedo].ToString().Trim()); //是否重做
objvcc_WorkStuRelation4ErrorLibEN.RedoDate = objRow[convcc_WorkStuRelation4ErrorLib.RedoDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.RedoDate].ToString().Trim(); //重做日期
objvcc_WorkStuRelation4ErrorLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4ErrorLib.IsPassed].ToString().Trim()); //是否通过
objvcc_WorkStuRelation4ErrorLibEN.UpdDate = objRow[convcc_WorkStuRelation4ErrorLib.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4ErrorLibEN.UpdUser = objRow[convcc_WorkStuRelation4ErrorLib.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4ErrorLibEN.Memo = objRow[convcc_WorkStuRelation4ErrorLib.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelation4ErrorLibEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelation4ErrorLibEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcc_WorkStuRelation4ErrorLibEN> GetSubObjLstCache(clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibCond)
{
 string strCourseId = objvcc_WorkStuRelation4ErrorLibCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvcc_WorkStuRelation4ErrorLibBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvcc_WorkStuRelation4ErrorLibEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_WorkStuRelation4ErrorLibEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_WorkStuRelation4ErrorLib.AttributeName)
{
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(strFldName) == false) continue;
if (objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkStuRelation4ErrorLibCond[strFldName].ToString());
}
else
{
if (objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkStuRelation4ErrorLibCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_WorkStuRelation4ErrorLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_WorkStuRelation4ErrorLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_WorkStuRelation4ErrorLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_WorkStuRelation4ErrorLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_WorkStuRelation4ErrorLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_WorkStuRelation4ErrorLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_WorkStuRelation4ErrorLibCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_WorkStuRelation4ErrorLibCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_WorkStuRelation4ErrorLibCond[strFldName]));
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
public static List<clsvcc_WorkStuRelation4ErrorLibEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcc_WorkStuRelation4ErrorLibEN> arrObjLst = new List<clsvcc_WorkStuRelation4ErrorLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN = new clsvcc_WorkStuRelation4ErrorLibEN();
try
{
objvcc_WorkStuRelation4ErrorLibEN.CourseName = objRow[convcc_WorkStuRelation4ErrorLib.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4ErrorLibEN.StuID = objRow[convcc_WorkStuRelation4ErrorLib.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4ErrorLibEN.StuName = objRow[convcc_WorkStuRelation4ErrorLib.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4ErrorLibEN.IdXzCollege = objRow[convcc_WorkStuRelation4ErrorLib.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4ErrorLibEN.CollegeName = objRow[convcc_WorkStuRelation4ErrorLib.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4ErrorLibEN.IdXzMajor = objRow[convcc_WorkStuRelation4ErrorLib.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4ErrorLibEN.MajorID = objRow[convcc_WorkStuRelation4ErrorLib.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4ErrorLibEN.MajorName = objRow[convcc_WorkStuRelation4ErrorLib.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4ErrorLibEN.IdGradeBase = objRow[convcc_WorkStuRelation4ErrorLib.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4ErrorLibEN.CollegeNameA = objRow[convcc_WorkStuRelation4ErrorLib.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4ErrorLibEN.GradeBaseName = objRow[convcc_WorkStuRelation4ErrorLib.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4ErrorLibEN.QuestionIndex = objRow[convcc_WorkStuRelation4ErrorLib.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4ErrorLib.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4ErrorLibEN.QuestionName = objRow[convcc_WorkStuRelation4ErrorLib.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4ErrorLibEN.QuestionContent = objRow[convcc_WorkStuRelation4ErrorLib.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterId = objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterName = objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4ErrorLibEN.ChapterName = objRow[convcc_WorkStuRelation4ErrorLib.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4ErrorLibEN.SectionName = objRow[convcc_WorkStuRelation4ErrorLib.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4ErrorLibEN.ChapterNameSim = objRow[convcc_WorkStuRelation4ErrorLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4ErrorLibEN.SectionNameSim = objRow[convcc_WorkStuRelation4ErrorLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeID = objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeName = objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4ErrorLibEN.SourceTypeName = objRow[convcc_WorkStuRelation4ErrorLib.SourceTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.SourceTypeName].ToString().Trim(); //来源类型名称
objvcc_WorkStuRelation4ErrorLibEN.QuestionID = objRow[convcc_WorkStuRelation4ErrorLib.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4ErrorLibEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4ErrorLib.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4ErrorLibEN.CourseId = objRow[convcc_WorkStuRelation4ErrorLib.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4ErrorLibEN.IdStudentInfo = objRow[convcc_WorkStuRelation4ErrorLib.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4ErrorLibEN.Creator = objRow[convcc_WorkStuRelation4ErrorLib.Creator] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.Creator].ToString().Trim(); //创建者
objvcc_WorkStuRelation4ErrorLibEN.CreateDate = objRow[convcc_WorkStuRelation4ErrorLib.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkStuRelation4ErrorLibEN.SourceTypeId = objRow[convcc_WorkStuRelation4ErrorLib.SourceTypeId].ToString().Trim(); //来源类型Id
objvcc_WorkStuRelation4ErrorLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4ErrorLib.IsRedo].ToString().Trim()); //是否重做
objvcc_WorkStuRelation4ErrorLibEN.RedoDate = objRow[convcc_WorkStuRelation4ErrorLib.RedoDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.RedoDate].ToString().Trim(); //重做日期
objvcc_WorkStuRelation4ErrorLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4ErrorLib.IsPassed].ToString().Trim()); //是否通过
objvcc_WorkStuRelation4ErrorLibEN.UpdDate = objRow[convcc_WorkStuRelation4ErrorLib.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4ErrorLibEN.UpdUser = objRow[convcc_WorkStuRelation4ErrorLib.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4ErrorLibEN.Memo = objRow[convcc_WorkStuRelation4ErrorLib.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelation4ErrorLibEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelation4ErrorLibEN);
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
public static List<clsvcc_WorkStuRelation4ErrorLibEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcc_WorkStuRelation4ErrorLibEN> arrObjLst = new List<clsvcc_WorkStuRelation4ErrorLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN = new clsvcc_WorkStuRelation4ErrorLibEN();
try
{
objvcc_WorkStuRelation4ErrorLibEN.CourseName = objRow[convcc_WorkStuRelation4ErrorLib.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4ErrorLibEN.StuID = objRow[convcc_WorkStuRelation4ErrorLib.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4ErrorLibEN.StuName = objRow[convcc_WorkStuRelation4ErrorLib.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4ErrorLibEN.IdXzCollege = objRow[convcc_WorkStuRelation4ErrorLib.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4ErrorLibEN.CollegeName = objRow[convcc_WorkStuRelation4ErrorLib.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4ErrorLibEN.IdXzMajor = objRow[convcc_WorkStuRelation4ErrorLib.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4ErrorLibEN.MajorID = objRow[convcc_WorkStuRelation4ErrorLib.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4ErrorLibEN.MajorName = objRow[convcc_WorkStuRelation4ErrorLib.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4ErrorLibEN.IdGradeBase = objRow[convcc_WorkStuRelation4ErrorLib.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4ErrorLibEN.CollegeNameA = objRow[convcc_WorkStuRelation4ErrorLib.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4ErrorLibEN.GradeBaseName = objRow[convcc_WorkStuRelation4ErrorLib.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4ErrorLibEN.QuestionIndex = objRow[convcc_WorkStuRelation4ErrorLib.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4ErrorLib.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4ErrorLibEN.QuestionName = objRow[convcc_WorkStuRelation4ErrorLib.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4ErrorLibEN.QuestionContent = objRow[convcc_WorkStuRelation4ErrorLib.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterId = objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterName = objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4ErrorLibEN.ChapterName = objRow[convcc_WorkStuRelation4ErrorLib.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4ErrorLibEN.SectionName = objRow[convcc_WorkStuRelation4ErrorLib.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4ErrorLibEN.ChapterNameSim = objRow[convcc_WorkStuRelation4ErrorLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4ErrorLibEN.SectionNameSim = objRow[convcc_WorkStuRelation4ErrorLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeID = objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeName = objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4ErrorLibEN.SourceTypeName = objRow[convcc_WorkStuRelation4ErrorLib.SourceTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.SourceTypeName].ToString().Trim(); //来源类型名称
objvcc_WorkStuRelation4ErrorLibEN.QuestionID = objRow[convcc_WorkStuRelation4ErrorLib.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4ErrorLibEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4ErrorLib.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4ErrorLibEN.CourseId = objRow[convcc_WorkStuRelation4ErrorLib.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4ErrorLibEN.IdStudentInfo = objRow[convcc_WorkStuRelation4ErrorLib.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4ErrorLibEN.Creator = objRow[convcc_WorkStuRelation4ErrorLib.Creator] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.Creator].ToString().Trim(); //创建者
objvcc_WorkStuRelation4ErrorLibEN.CreateDate = objRow[convcc_WorkStuRelation4ErrorLib.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkStuRelation4ErrorLibEN.SourceTypeId = objRow[convcc_WorkStuRelation4ErrorLib.SourceTypeId].ToString().Trim(); //来源类型Id
objvcc_WorkStuRelation4ErrorLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4ErrorLib.IsRedo].ToString().Trim()); //是否重做
objvcc_WorkStuRelation4ErrorLibEN.RedoDate = objRow[convcc_WorkStuRelation4ErrorLib.RedoDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.RedoDate].ToString().Trim(); //重做日期
objvcc_WorkStuRelation4ErrorLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4ErrorLib.IsPassed].ToString().Trim()); //是否通过
objvcc_WorkStuRelation4ErrorLibEN.UpdDate = objRow[convcc_WorkStuRelation4ErrorLib.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4ErrorLibEN.UpdUser = objRow[convcc_WorkStuRelation4ErrorLib.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4ErrorLibEN.Memo = objRow[convcc_WorkStuRelation4ErrorLib.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelation4ErrorLibEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelation4ErrorLibEN);
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
List<clsvcc_WorkStuRelation4ErrorLibEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcc_WorkStuRelation4ErrorLibEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelation4ErrorLibEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcc_WorkStuRelation4ErrorLibEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_WorkStuRelation4ErrorLibEN> arrObjLst = new List<clsvcc_WorkStuRelation4ErrorLibEN>(); 
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
	clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN = new clsvcc_WorkStuRelation4ErrorLibEN();
try
{
objvcc_WorkStuRelation4ErrorLibEN.CourseName = objRow[convcc_WorkStuRelation4ErrorLib.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4ErrorLibEN.StuID = objRow[convcc_WorkStuRelation4ErrorLib.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4ErrorLibEN.StuName = objRow[convcc_WorkStuRelation4ErrorLib.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4ErrorLibEN.IdXzCollege = objRow[convcc_WorkStuRelation4ErrorLib.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4ErrorLibEN.CollegeName = objRow[convcc_WorkStuRelation4ErrorLib.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4ErrorLibEN.IdXzMajor = objRow[convcc_WorkStuRelation4ErrorLib.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4ErrorLibEN.MajorID = objRow[convcc_WorkStuRelation4ErrorLib.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4ErrorLibEN.MajorName = objRow[convcc_WorkStuRelation4ErrorLib.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4ErrorLibEN.IdGradeBase = objRow[convcc_WorkStuRelation4ErrorLib.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4ErrorLibEN.CollegeNameA = objRow[convcc_WorkStuRelation4ErrorLib.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4ErrorLibEN.GradeBaseName = objRow[convcc_WorkStuRelation4ErrorLib.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4ErrorLibEN.QuestionIndex = objRow[convcc_WorkStuRelation4ErrorLib.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4ErrorLib.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4ErrorLibEN.QuestionName = objRow[convcc_WorkStuRelation4ErrorLib.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4ErrorLibEN.QuestionContent = objRow[convcc_WorkStuRelation4ErrorLib.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterId = objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterName = objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4ErrorLibEN.ChapterName = objRow[convcc_WorkStuRelation4ErrorLib.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4ErrorLibEN.SectionName = objRow[convcc_WorkStuRelation4ErrorLib.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4ErrorLibEN.ChapterNameSim = objRow[convcc_WorkStuRelation4ErrorLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4ErrorLibEN.SectionNameSim = objRow[convcc_WorkStuRelation4ErrorLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeID = objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeName = objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4ErrorLibEN.SourceTypeName = objRow[convcc_WorkStuRelation4ErrorLib.SourceTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.SourceTypeName].ToString().Trim(); //来源类型名称
objvcc_WorkStuRelation4ErrorLibEN.QuestionID = objRow[convcc_WorkStuRelation4ErrorLib.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4ErrorLibEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4ErrorLib.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4ErrorLibEN.CourseId = objRow[convcc_WorkStuRelation4ErrorLib.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4ErrorLibEN.IdStudentInfo = objRow[convcc_WorkStuRelation4ErrorLib.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4ErrorLibEN.Creator = objRow[convcc_WorkStuRelation4ErrorLib.Creator] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.Creator].ToString().Trim(); //创建者
objvcc_WorkStuRelation4ErrorLibEN.CreateDate = objRow[convcc_WorkStuRelation4ErrorLib.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkStuRelation4ErrorLibEN.SourceTypeId = objRow[convcc_WorkStuRelation4ErrorLib.SourceTypeId].ToString().Trim(); //来源类型Id
objvcc_WorkStuRelation4ErrorLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4ErrorLib.IsRedo].ToString().Trim()); //是否重做
objvcc_WorkStuRelation4ErrorLibEN.RedoDate = objRow[convcc_WorkStuRelation4ErrorLib.RedoDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.RedoDate].ToString().Trim(); //重做日期
objvcc_WorkStuRelation4ErrorLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4ErrorLib.IsPassed].ToString().Trim()); //是否通过
objvcc_WorkStuRelation4ErrorLibEN.UpdDate = objRow[convcc_WorkStuRelation4ErrorLib.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4ErrorLibEN.UpdUser = objRow[convcc_WorkStuRelation4ErrorLib.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4ErrorLibEN.Memo = objRow[convcc_WorkStuRelation4ErrorLib.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelation4ErrorLibEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelation4ErrorLibEN);
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
public static List<clsvcc_WorkStuRelation4ErrorLibEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcc_WorkStuRelation4ErrorLibEN> arrObjLst = new List<clsvcc_WorkStuRelation4ErrorLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN = new clsvcc_WorkStuRelation4ErrorLibEN();
try
{
objvcc_WorkStuRelation4ErrorLibEN.CourseName = objRow[convcc_WorkStuRelation4ErrorLib.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4ErrorLibEN.StuID = objRow[convcc_WorkStuRelation4ErrorLib.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4ErrorLibEN.StuName = objRow[convcc_WorkStuRelation4ErrorLib.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4ErrorLibEN.IdXzCollege = objRow[convcc_WorkStuRelation4ErrorLib.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4ErrorLibEN.CollegeName = objRow[convcc_WorkStuRelation4ErrorLib.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4ErrorLibEN.IdXzMajor = objRow[convcc_WorkStuRelation4ErrorLib.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4ErrorLibEN.MajorID = objRow[convcc_WorkStuRelation4ErrorLib.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4ErrorLibEN.MajorName = objRow[convcc_WorkStuRelation4ErrorLib.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4ErrorLibEN.IdGradeBase = objRow[convcc_WorkStuRelation4ErrorLib.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4ErrorLibEN.CollegeNameA = objRow[convcc_WorkStuRelation4ErrorLib.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4ErrorLibEN.GradeBaseName = objRow[convcc_WorkStuRelation4ErrorLib.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4ErrorLibEN.QuestionIndex = objRow[convcc_WorkStuRelation4ErrorLib.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4ErrorLib.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4ErrorLibEN.QuestionName = objRow[convcc_WorkStuRelation4ErrorLib.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4ErrorLibEN.QuestionContent = objRow[convcc_WorkStuRelation4ErrorLib.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterId = objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterName = objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4ErrorLibEN.ChapterName = objRow[convcc_WorkStuRelation4ErrorLib.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4ErrorLibEN.SectionName = objRow[convcc_WorkStuRelation4ErrorLib.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4ErrorLibEN.ChapterNameSim = objRow[convcc_WorkStuRelation4ErrorLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4ErrorLibEN.SectionNameSim = objRow[convcc_WorkStuRelation4ErrorLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeID = objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeName = objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4ErrorLibEN.SourceTypeName = objRow[convcc_WorkStuRelation4ErrorLib.SourceTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.SourceTypeName].ToString().Trim(); //来源类型名称
objvcc_WorkStuRelation4ErrorLibEN.QuestionID = objRow[convcc_WorkStuRelation4ErrorLib.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4ErrorLibEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4ErrorLib.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4ErrorLibEN.CourseId = objRow[convcc_WorkStuRelation4ErrorLib.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4ErrorLibEN.IdStudentInfo = objRow[convcc_WorkStuRelation4ErrorLib.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4ErrorLibEN.Creator = objRow[convcc_WorkStuRelation4ErrorLib.Creator] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.Creator].ToString().Trim(); //创建者
objvcc_WorkStuRelation4ErrorLibEN.CreateDate = objRow[convcc_WorkStuRelation4ErrorLib.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkStuRelation4ErrorLibEN.SourceTypeId = objRow[convcc_WorkStuRelation4ErrorLib.SourceTypeId].ToString().Trim(); //来源类型Id
objvcc_WorkStuRelation4ErrorLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4ErrorLib.IsRedo].ToString().Trim()); //是否重做
objvcc_WorkStuRelation4ErrorLibEN.RedoDate = objRow[convcc_WorkStuRelation4ErrorLib.RedoDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.RedoDate].ToString().Trim(); //重做日期
objvcc_WorkStuRelation4ErrorLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4ErrorLib.IsPassed].ToString().Trim()); //是否通过
objvcc_WorkStuRelation4ErrorLibEN.UpdDate = objRow[convcc_WorkStuRelation4ErrorLib.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4ErrorLibEN.UpdUser = objRow[convcc_WorkStuRelation4ErrorLib.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4ErrorLibEN.Memo = objRow[convcc_WorkStuRelation4ErrorLib.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelation4ErrorLibEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelation4ErrorLibEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcc_WorkStuRelation4ErrorLibEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcc_WorkStuRelation4ErrorLibEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_WorkStuRelation4ErrorLibEN> arrObjLst = new List<clsvcc_WorkStuRelation4ErrorLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN = new clsvcc_WorkStuRelation4ErrorLibEN();
try
{
objvcc_WorkStuRelation4ErrorLibEN.CourseName = objRow[convcc_WorkStuRelation4ErrorLib.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4ErrorLibEN.StuID = objRow[convcc_WorkStuRelation4ErrorLib.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4ErrorLibEN.StuName = objRow[convcc_WorkStuRelation4ErrorLib.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4ErrorLibEN.IdXzCollege = objRow[convcc_WorkStuRelation4ErrorLib.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4ErrorLibEN.CollegeName = objRow[convcc_WorkStuRelation4ErrorLib.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4ErrorLibEN.IdXzMajor = objRow[convcc_WorkStuRelation4ErrorLib.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4ErrorLibEN.MajorID = objRow[convcc_WorkStuRelation4ErrorLib.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4ErrorLibEN.MajorName = objRow[convcc_WorkStuRelation4ErrorLib.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4ErrorLibEN.IdGradeBase = objRow[convcc_WorkStuRelation4ErrorLib.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4ErrorLibEN.CollegeNameA = objRow[convcc_WorkStuRelation4ErrorLib.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4ErrorLibEN.GradeBaseName = objRow[convcc_WorkStuRelation4ErrorLib.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4ErrorLibEN.QuestionIndex = objRow[convcc_WorkStuRelation4ErrorLib.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4ErrorLib.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4ErrorLibEN.QuestionName = objRow[convcc_WorkStuRelation4ErrorLib.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4ErrorLibEN.QuestionContent = objRow[convcc_WorkStuRelation4ErrorLib.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterId = objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterName = objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4ErrorLibEN.ChapterName = objRow[convcc_WorkStuRelation4ErrorLib.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4ErrorLibEN.SectionName = objRow[convcc_WorkStuRelation4ErrorLib.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4ErrorLibEN.ChapterNameSim = objRow[convcc_WorkStuRelation4ErrorLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4ErrorLibEN.SectionNameSim = objRow[convcc_WorkStuRelation4ErrorLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeID = objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeName = objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4ErrorLibEN.SourceTypeName = objRow[convcc_WorkStuRelation4ErrorLib.SourceTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.SourceTypeName].ToString().Trim(); //来源类型名称
objvcc_WorkStuRelation4ErrorLibEN.QuestionID = objRow[convcc_WorkStuRelation4ErrorLib.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4ErrorLibEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4ErrorLib.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4ErrorLibEN.CourseId = objRow[convcc_WorkStuRelation4ErrorLib.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4ErrorLibEN.IdStudentInfo = objRow[convcc_WorkStuRelation4ErrorLib.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4ErrorLibEN.Creator = objRow[convcc_WorkStuRelation4ErrorLib.Creator] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.Creator].ToString().Trim(); //创建者
objvcc_WorkStuRelation4ErrorLibEN.CreateDate = objRow[convcc_WorkStuRelation4ErrorLib.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkStuRelation4ErrorLibEN.SourceTypeId = objRow[convcc_WorkStuRelation4ErrorLib.SourceTypeId].ToString().Trim(); //来源类型Id
objvcc_WorkStuRelation4ErrorLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4ErrorLib.IsRedo].ToString().Trim()); //是否重做
objvcc_WorkStuRelation4ErrorLibEN.RedoDate = objRow[convcc_WorkStuRelation4ErrorLib.RedoDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.RedoDate].ToString().Trim(); //重做日期
objvcc_WorkStuRelation4ErrorLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4ErrorLib.IsPassed].ToString().Trim()); //是否通过
objvcc_WorkStuRelation4ErrorLibEN.UpdDate = objRow[convcc_WorkStuRelation4ErrorLib.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4ErrorLibEN.UpdUser = objRow[convcc_WorkStuRelation4ErrorLib.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4ErrorLibEN.Memo = objRow[convcc_WorkStuRelation4ErrorLib.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelation4ErrorLibEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelation4ErrorLibEN);
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
public static List<clsvcc_WorkStuRelation4ErrorLibEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcc_WorkStuRelation4ErrorLibEN> arrObjLst = new List<clsvcc_WorkStuRelation4ErrorLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN = new clsvcc_WorkStuRelation4ErrorLibEN();
try
{
objvcc_WorkStuRelation4ErrorLibEN.CourseName = objRow[convcc_WorkStuRelation4ErrorLib.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4ErrorLibEN.StuID = objRow[convcc_WorkStuRelation4ErrorLib.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4ErrorLibEN.StuName = objRow[convcc_WorkStuRelation4ErrorLib.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4ErrorLibEN.IdXzCollege = objRow[convcc_WorkStuRelation4ErrorLib.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4ErrorLibEN.CollegeName = objRow[convcc_WorkStuRelation4ErrorLib.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4ErrorLibEN.IdXzMajor = objRow[convcc_WorkStuRelation4ErrorLib.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4ErrorLibEN.MajorID = objRow[convcc_WorkStuRelation4ErrorLib.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4ErrorLibEN.MajorName = objRow[convcc_WorkStuRelation4ErrorLib.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4ErrorLibEN.IdGradeBase = objRow[convcc_WorkStuRelation4ErrorLib.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4ErrorLibEN.CollegeNameA = objRow[convcc_WorkStuRelation4ErrorLib.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4ErrorLibEN.GradeBaseName = objRow[convcc_WorkStuRelation4ErrorLib.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4ErrorLibEN.QuestionIndex = objRow[convcc_WorkStuRelation4ErrorLib.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4ErrorLib.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4ErrorLibEN.QuestionName = objRow[convcc_WorkStuRelation4ErrorLib.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4ErrorLibEN.QuestionContent = objRow[convcc_WorkStuRelation4ErrorLib.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterId = objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterName = objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4ErrorLibEN.ChapterName = objRow[convcc_WorkStuRelation4ErrorLib.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4ErrorLibEN.SectionName = objRow[convcc_WorkStuRelation4ErrorLib.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4ErrorLibEN.ChapterNameSim = objRow[convcc_WorkStuRelation4ErrorLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4ErrorLibEN.SectionNameSim = objRow[convcc_WorkStuRelation4ErrorLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeID = objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeName = objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4ErrorLibEN.SourceTypeName = objRow[convcc_WorkStuRelation4ErrorLib.SourceTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.SourceTypeName].ToString().Trim(); //来源类型名称
objvcc_WorkStuRelation4ErrorLibEN.QuestionID = objRow[convcc_WorkStuRelation4ErrorLib.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4ErrorLibEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4ErrorLib.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4ErrorLibEN.CourseId = objRow[convcc_WorkStuRelation4ErrorLib.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4ErrorLibEN.IdStudentInfo = objRow[convcc_WorkStuRelation4ErrorLib.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4ErrorLibEN.Creator = objRow[convcc_WorkStuRelation4ErrorLib.Creator] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.Creator].ToString().Trim(); //创建者
objvcc_WorkStuRelation4ErrorLibEN.CreateDate = objRow[convcc_WorkStuRelation4ErrorLib.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkStuRelation4ErrorLibEN.SourceTypeId = objRow[convcc_WorkStuRelation4ErrorLib.SourceTypeId].ToString().Trim(); //来源类型Id
objvcc_WorkStuRelation4ErrorLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4ErrorLib.IsRedo].ToString().Trim()); //是否重做
objvcc_WorkStuRelation4ErrorLibEN.RedoDate = objRow[convcc_WorkStuRelation4ErrorLib.RedoDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.RedoDate].ToString().Trim(); //重做日期
objvcc_WorkStuRelation4ErrorLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4ErrorLib.IsPassed].ToString().Trim()); //是否通过
objvcc_WorkStuRelation4ErrorLibEN.UpdDate = objRow[convcc_WorkStuRelation4ErrorLib.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4ErrorLibEN.UpdUser = objRow[convcc_WorkStuRelation4ErrorLib.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4ErrorLibEN.Memo = objRow[convcc_WorkStuRelation4ErrorLib.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelation4ErrorLibEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelation4ErrorLibEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelation4ErrorLibEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcc_WorkStuRelation4ErrorLibEN> arrObjLst = new List<clsvcc_WorkStuRelation4ErrorLibEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN = new clsvcc_WorkStuRelation4ErrorLibEN();
try
{
objvcc_WorkStuRelation4ErrorLibEN.CourseName = objRow[convcc_WorkStuRelation4ErrorLib.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4ErrorLibEN.StuID = objRow[convcc_WorkStuRelation4ErrorLib.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4ErrorLibEN.StuName = objRow[convcc_WorkStuRelation4ErrorLib.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4ErrorLibEN.IdXzCollege = objRow[convcc_WorkStuRelation4ErrorLib.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4ErrorLibEN.CollegeName = objRow[convcc_WorkStuRelation4ErrorLib.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4ErrorLibEN.IdXzMajor = objRow[convcc_WorkStuRelation4ErrorLib.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4ErrorLibEN.MajorID = objRow[convcc_WorkStuRelation4ErrorLib.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4ErrorLibEN.MajorName = objRow[convcc_WorkStuRelation4ErrorLib.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4ErrorLibEN.IdGradeBase = objRow[convcc_WorkStuRelation4ErrorLib.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4ErrorLibEN.CollegeNameA = objRow[convcc_WorkStuRelation4ErrorLib.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4ErrorLibEN.GradeBaseName = objRow[convcc_WorkStuRelation4ErrorLib.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4ErrorLibEN.QuestionIndex = objRow[convcc_WorkStuRelation4ErrorLib.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4ErrorLib.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4ErrorLibEN.QuestionName = objRow[convcc_WorkStuRelation4ErrorLib.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4ErrorLibEN.QuestionContent = objRow[convcc_WorkStuRelation4ErrorLib.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterId = objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterName = objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4ErrorLibEN.ChapterName = objRow[convcc_WorkStuRelation4ErrorLib.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4ErrorLibEN.SectionName = objRow[convcc_WorkStuRelation4ErrorLib.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4ErrorLibEN.ChapterNameSim = objRow[convcc_WorkStuRelation4ErrorLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4ErrorLibEN.SectionNameSim = objRow[convcc_WorkStuRelation4ErrorLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeID = objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeName = objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4ErrorLibEN.SourceTypeName = objRow[convcc_WorkStuRelation4ErrorLib.SourceTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.SourceTypeName].ToString().Trim(); //来源类型名称
objvcc_WorkStuRelation4ErrorLibEN.QuestionID = objRow[convcc_WorkStuRelation4ErrorLib.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4ErrorLibEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4ErrorLib.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4ErrorLibEN.CourseId = objRow[convcc_WorkStuRelation4ErrorLib.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4ErrorLibEN.IdStudentInfo = objRow[convcc_WorkStuRelation4ErrorLib.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4ErrorLibEN.Creator = objRow[convcc_WorkStuRelation4ErrorLib.Creator] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.Creator].ToString().Trim(); //创建者
objvcc_WorkStuRelation4ErrorLibEN.CreateDate = objRow[convcc_WorkStuRelation4ErrorLib.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkStuRelation4ErrorLibEN.SourceTypeId = objRow[convcc_WorkStuRelation4ErrorLib.SourceTypeId].ToString().Trim(); //来源类型Id
objvcc_WorkStuRelation4ErrorLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4ErrorLib.IsRedo].ToString().Trim()); //是否重做
objvcc_WorkStuRelation4ErrorLibEN.RedoDate = objRow[convcc_WorkStuRelation4ErrorLib.RedoDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.RedoDate].ToString().Trim(); //重做日期
objvcc_WorkStuRelation4ErrorLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4ErrorLib.IsPassed].ToString().Trim()); //是否通过
objvcc_WorkStuRelation4ErrorLibEN.UpdDate = objRow[convcc_WorkStuRelation4ErrorLib.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4ErrorLibEN.UpdUser = objRow[convcc_WorkStuRelation4ErrorLib.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4ErrorLibEN.Memo = objRow[convcc_WorkStuRelation4ErrorLib.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4ErrorLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelation4ErrorLibEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelation4ErrorLibEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcc_WorkStuRelation4ErrorLib(ref clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN)
{
bool bolResult = vcc_WorkStuRelation4ErrorLibDA.Getvcc_WorkStuRelation4ErrorLib(ref objvcc_WorkStuRelation4ErrorLibEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN GetObjBymId(long lngmId)
{
clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN = vcc_WorkStuRelation4ErrorLibDA.GetObjBymId(lngmId);
return objvcc_WorkStuRelation4ErrorLibEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN = vcc_WorkStuRelation4ErrorLibDA.GetFirstObj(strWhereCond);
 return objvcc_WorkStuRelation4ErrorLibEN;
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
public static clsvcc_WorkStuRelation4ErrorLibEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN = vcc_WorkStuRelation4ErrorLibDA.GetObjByDataRow(objRow);
 return objvcc_WorkStuRelation4ErrorLibEN;
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
public static clsvcc_WorkStuRelation4ErrorLibEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN = vcc_WorkStuRelation4ErrorLibDA.GetObjByDataRow(objRow);
 return objvcc_WorkStuRelation4ErrorLibEN;
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
 /// <param name = "lstvcc_WorkStuRelation4ErrorLibObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN GetObjBymIdFromList(long lngmId, List<clsvcc_WorkStuRelation4ErrorLibEN> lstvcc_WorkStuRelation4ErrorLibObjLst)
{
foreach (clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN in lstvcc_WorkStuRelation4ErrorLibObjLst)
{
if (objvcc_WorkStuRelation4ErrorLibEN.mId == lngmId)
{
return objvcc_WorkStuRelation4ErrorLibEN;
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
 lngmId = new clsvcc_WorkStuRelation4ErrorLibDA().GetFirstID(strWhereCond);
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
 arrList = vcc_WorkStuRelation4ErrorLibDA.GetID(strWhereCond);
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
bool bolIsExist = vcc_WorkStuRelation4ErrorLibDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vcc_WorkStuRelation4ErrorLibDA.IsExist(lngmId);
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
 bolIsExist = clsvcc_WorkStuRelation4ErrorLibDA.IsExistTable();
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
 bolIsExist = vcc_WorkStuRelation4ErrorLibDA.IsExistTable(strTabName);
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
 /// <param name = "objvcc_WorkStuRelation4ErrorLibENS">源对象</param>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibENT">目标对象</param>
 public static void CopyTo(clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibENS, clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibENT)
{
try
{
objvcc_WorkStuRelation4ErrorLibENT.CourseName = objvcc_WorkStuRelation4ErrorLibENS.CourseName; //课程名称
objvcc_WorkStuRelation4ErrorLibENT.StuID = objvcc_WorkStuRelation4ErrorLibENS.StuID; //学号
objvcc_WorkStuRelation4ErrorLibENT.StuName = objvcc_WorkStuRelation4ErrorLibENS.StuName; //姓名
objvcc_WorkStuRelation4ErrorLibENT.IdXzCollege = objvcc_WorkStuRelation4ErrorLibENS.IdXzCollege; //学院流水号
objvcc_WorkStuRelation4ErrorLibENT.CollegeName = objvcc_WorkStuRelation4ErrorLibENS.CollegeName; //学院名称
objvcc_WorkStuRelation4ErrorLibENT.IdXzMajor = objvcc_WorkStuRelation4ErrorLibENS.IdXzMajor; //专业流水号
objvcc_WorkStuRelation4ErrorLibENT.MajorID = objvcc_WorkStuRelation4ErrorLibENS.MajorID; //专业ID
objvcc_WorkStuRelation4ErrorLibENT.MajorName = objvcc_WorkStuRelation4ErrorLibENS.MajorName; //专业名称
objvcc_WorkStuRelation4ErrorLibENT.IdGradeBase = objvcc_WorkStuRelation4ErrorLibENS.IdGradeBase; //年级流水号
objvcc_WorkStuRelation4ErrorLibENT.CollegeNameA = objvcc_WorkStuRelation4ErrorLibENS.CollegeNameA; //学院名称简写
objvcc_WorkStuRelation4ErrorLibENT.GradeBaseName = objvcc_WorkStuRelation4ErrorLibENS.GradeBaseName; //年级名称
objvcc_WorkStuRelation4ErrorLibENT.QuestionIndex = objvcc_WorkStuRelation4ErrorLibENS.QuestionIndex; //题目序号
objvcc_WorkStuRelation4ErrorLibENT.QuestionName = objvcc_WorkStuRelation4ErrorLibENS.QuestionName; //题目名称
objvcc_WorkStuRelation4ErrorLibENT.QuestionContent = objvcc_WorkStuRelation4ErrorLibENS.QuestionContent; //题目内容
objvcc_WorkStuRelation4ErrorLibENT.CourseChapterId = objvcc_WorkStuRelation4ErrorLibENS.CourseChapterId; //课程章节ID
objvcc_WorkStuRelation4ErrorLibENT.CourseChapterName = objvcc_WorkStuRelation4ErrorLibENS.CourseChapterName; //课程章节名称
objvcc_WorkStuRelation4ErrorLibENT.ChapterName = objvcc_WorkStuRelation4ErrorLibENS.ChapterName; //章名
objvcc_WorkStuRelation4ErrorLibENT.SectionName = objvcc_WorkStuRelation4ErrorLibENS.SectionName; //节名
objvcc_WorkStuRelation4ErrorLibENT.ChapterNameSim = objvcc_WorkStuRelation4ErrorLibENS.ChapterNameSim; //章名简称
objvcc_WorkStuRelation4ErrorLibENT.SectionNameSim = objvcc_WorkStuRelation4ErrorLibENS.SectionNameSim; //节名简称
objvcc_WorkStuRelation4ErrorLibENT.ParentNodeID = objvcc_WorkStuRelation4ErrorLibENS.ParentNodeID; //父节点编号
objvcc_WorkStuRelation4ErrorLibENT.CourseChapterReferred = objvcc_WorkStuRelation4ErrorLibENS.CourseChapterReferred; //节简称
objvcc_WorkStuRelation4ErrorLibENT.ParentNodeName = objvcc_WorkStuRelation4ErrorLibENS.ParentNodeName; //父节点名称
objvcc_WorkStuRelation4ErrorLibENT.ParentNodeReferred = objvcc_WorkStuRelation4ErrorLibENS.ParentNodeReferred; //章简称
objvcc_WorkStuRelation4ErrorLibENT.SourceTypeName = objvcc_WorkStuRelation4ErrorLibENS.SourceTypeName; //来源类型名称
objvcc_WorkStuRelation4ErrorLibENT.QuestionID = objvcc_WorkStuRelation4ErrorLibENS.QuestionID; //题目ID
objvcc_WorkStuRelation4ErrorLibENT.mId = objvcc_WorkStuRelation4ErrorLibENS.mId; //mId
objvcc_WorkStuRelation4ErrorLibENT.CourseId = objvcc_WorkStuRelation4ErrorLibENS.CourseId; //课程Id
objvcc_WorkStuRelation4ErrorLibENT.IdStudentInfo = objvcc_WorkStuRelation4ErrorLibENS.IdStudentInfo; //学生流水号
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
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">源简化对象</param>
 public static void SetUpdFlag(clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN)
{
try
{
objvcc_WorkStuRelation4ErrorLibEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcc_WorkStuRelation4ErrorLibEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.CourseName = objvcc_WorkStuRelation4ErrorLibEN.CourseName == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.StuID, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.StuID = objvcc_WorkStuRelation4ErrorLibEN.StuID == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.StuID; //学号
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.StuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.StuName = objvcc_WorkStuRelation4ErrorLibEN.StuName == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.StuName; //姓名
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.IdXzCollege = objvcc_WorkStuRelation4ErrorLibEN.IdXzCollege == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.CollegeName = objvcc_WorkStuRelation4ErrorLibEN.CollegeName == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.IdXzMajor = objvcc_WorkStuRelation4ErrorLibEN.IdXzMajor == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.MajorID, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.MajorID = objvcc_WorkStuRelation4ErrorLibEN.MajorID == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.MajorID; //专业ID
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.MajorName = objvcc_WorkStuRelation4ErrorLibEN.MajorName == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.IdGradeBase = objvcc_WorkStuRelation4ErrorLibEN.IdGradeBase == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.CollegeNameA = objvcc_WorkStuRelation4ErrorLibEN.CollegeNameA == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.GradeBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.GradeBaseName = objvcc_WorkStuRelation4ErrorLibEN.GradeBaseName == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.GradeBaseName; //年级名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.QuestionIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.QuestionIndex = objvcc_WorkStuRelation4ErrorLibEN.QuestionIndex; //题目序号
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.QuestionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.QuestionName = objvcc_WorkStuRelation4ErrorLibEN.QuestionName == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.QuestionName; //题目名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.QuestionContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.QuestionContent = objvcc_WorkStuRelation4ErrorLibEN.QuestionContent == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.QuestionContent; //题目内容
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterId = objvcc_WorkStuRelation4ErrorLibEN.CourseChapterId == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.CourseChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterName = objvcc_WorkStuRelation4ErrorLibEN.CourseChapterName == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.CourseChapterName; //课程章节名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.ChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.ChapterName = objvcc_WorkStuRelation4ErrorLibEN.ChapterName == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.ChapterName; //章名
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.SectionName = objvcc_WorkStuRelation4ErrorLibEN.SectionName == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.SectionName; //节名
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.ChapterNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.ChapterNameSim = objvcc_WorkStuRelation4ErrorLibEN.ChapterNameSim == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.ChapterNameSim; //章名简称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.SectionNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.SectionNameSim = objvcc_WorkStuRelation4ErrorLibEN.SectionNameSim == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.SectionNameSim; //节名简称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.ParentNodeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeID = objvcc_WorkStuRelation4ErrorLibEN.ParentNodeID == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.ParentNodeID; //父节点编号
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.CourseChapterReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.CourseChapterReferred = objvcc_WorkStuRelation4ErrorLibEN.CourseChapterReferred == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.CourseChapterReferred; //节简称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.ParentNodeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeName = objvcc_WorkStuRelation4ErrorLibEN.ParentNodeName == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.ParentNodeName; //父节点名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.ParentNodeReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.ParentNodeReferred = objvcc_WorkStuRelation4ErrorLibEN.ParentNodeReferred == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.ParentNodeReferred; //章简称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.SourceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.SourceTypeName = objvcc_WorkStuRelation4ErrorLibEN.SourceTypeName == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.SourceTypeName; //来源类型名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.QuestionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.QuestionID = objvcc_WorkStuRelation4ErrorLibEN.QuestionID == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.QuestionID; //题目ID
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.mId = objvcc_WorkStuRelation4ErrorLibEN.mId; //mId
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.CourseId = objvcc_WorkStuRelation4ErrorLibEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.IdStudentInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.IdStudentInfo = objvcc_WorkStuRelation4ErrorLibEN.IdStudentInfo; //学生流水号
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.Creator, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.Creator = objvcc_WorkStuRelation4ErrorLibEN.Creator == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.Creator; //创建者
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.CreateDate = objvcc_WorkStuRelation4ErrorLibEN.CreateDate == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.SourceTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.SourceTypeId = objvcc_WorkStuRelation4ErrorLibEN.SourceTypeId; //来源类型Id
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.IsRedo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.IsRedo = objvcc_WorkStuRelation4ErrorLibEN.IsRedo; //是否重做
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.RedoDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.RedoDate = objvcc_WorkStuRelation4ErrorLibEN.RedoDate == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.RedoDate; //重做日期
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.IsPassed, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.IsPassed = objvcc_WorkStuRelation4ErrorLibEN.IsPassed; //是否通过
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.UpdDate = objvcc_WorkStuRelation4ErrorLibEN.UpdDate == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.UpdUser = objvcc_WorkStuRelation4ErrorLibEN.UpdUser == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convcc_WorkStuRelation4ErrorLib.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4ErrorLibEN.Memo = objvcc_WorkStuRelation4ErrorLibEN.Memo == "[null]" ? null :  objvcc_WorkStuRelation4ErrorLibEN.Memo; //备注
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
 /// <param name = "objvcc_WorkStuRelation4ErrorLibEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN)
{
try
{
if (objvcc_WorkStuRelation4ErrorLibEN.CourseName == "[null]") objvcc_WorkStuRelation4ErrorLibEN.CourseName = null; //课程名称
if (objvcc_WorkStuRelation4ErrorLibEN.StuID == "[null]") objvcc_WorkStuRelation4ErrorLibEN.StuID = null; //学号
if (objvcc_WorkStuRelation4ErrorLibEN.StuName == "[null]") objvcc_WorkStuRelation4ErrorLibEN.StuName = null; //姓名
if (objvcc_WorkStuRelation4ErrorLibEN.IdXzCollege == "[null]") objvcc_WorkStuRelation4ErrorLibEN.IdXzCollege = null; //学院流水号
if (objvcc_WorkStuRelation4ErrorLibEN.CollegeName == "[null]") objvcc_WorkStuRelation4ErrorLibEN.CollegeName = null; //学院名称
if (objvcc_WorkStuRelation4ErrorLibEN.IdXzMajor == "[null]") objvcc_WorkStuRelation4ErrorLibEN.IdXzMajor = null; //专业流水号
if (objvcc_WorkStuRelation4ErrorLibEN.MajorID == "[null]") objvcc_WorkStuRelation4ErrorLibEN.MajorID = null; //专业ID
if (objvcc_WorkStuRelation4ErrorLibEN.MajorName == "[null]") objvcc_WorkStuRelation4ErrorLibEN.MajorName = null; //专业名称
if (objvcc_WorkStuRelation4ErrorLibEN.IdGradeBase == "[null]") objvcc_WorkStuRelation4ErrorLibEN.IdGradeBase = null; //年级流水号
if (objvcc_WorkStuRelation4ErrorLibEN.CollegeNameA == "[null]") objvcc_WorkStuRelation4ErrorLibEN.CollegeNameA = null; //学院名称简写
if (objvcc_WorkStuRelation4ErrorLibEN.GradeBaseName == "[null]") objvcc_WorkStuRelation4ErrorLibEN.GradeBaseName = null; //年级名称
if (objvcc_WorkStuRelation4ErrorLibEN.QuestionName == "[null]") objvcc_WorkStuRelation4ErrorLibEN.QuestionName = null; //题目名称
if (objvcc_WorkStuRelation4ErrorLibEN.QuestionContent == "[null]") objvcc_WorkStuRelation4ErrorLibEN.QuestionContent = null; //题目内容
if (objvcc_WorkStuRelation4ErrorLibEN.CourseChapterId == "[null]") objvcc_WorkStuRelation4ErrorLibEN.CourseChapterId = null; //课程章节ID
if (objvcc_WorkStuRelation4ErrorLibEN.CourseChapterName == "[null]") objvcc_WorkStuRelation4ErrorLibEN.CourseChapterName = null; //课程章节名称
if (objvcc_WorkStuRelation4ErrorLibEN.ChapterName == "[null]") objvcc_WorkStuRelation4ErrorLibEN.ChapterName = null; //章名
if (objvcc_WorkStuRelation4ErrorLibEN.SectionName == "[null]") objvcc_WorkStuRelation4ErrorLibEN.SectionName = null; //节名
if (objvcc_WorkStuRelation4ErrorLibEN.ChapterNameSim == "[null]") objvcc_WorkStuRelation4ErrorLibEN.ChapterNameSim = null; //章名简称
if (objvcc_WorkStuRelation4ErrorLibEN.SectionNameSim == "[null]") objvcc_WorkStuRelation4ErrorLibEN.SectionNameSim = null; //节名简称
if (objvcc_WorkStuRelation4ErrorLibEN.ParentNodeID == "[null]") objvcc_WorkStuRelation4ErrorLibEN.ParentNodeID = null; //父节点编号
if (objvcc_WorkStuRelation4ErrorLibEN.CourseChapterReferred == "[null]") objvcc_WorkStuRelation4ErrorLibEN.CourseChapterReferred = null; //节简称
if (objvcc_WorkStuRelation4ErrorLibEN.ParentNodeName == "[null]") objvcc_WorkStuRelation4ErrorLibEN.ParentNodeName = null; //父节点名称
if (objvcc_WorkStuRelation4ErrorLibEN.ParentNodeReferred == "[null]") objvcc_WorkStuRelation4ErrorLibEN.ParentNodeReferred = null; //章简称
if (objvcc_WorkStuRelation4ErrorLibEN.SourceTypeName == "[null]") objvcc_WorkStuRelation4ErrorLibEN.SourceTypeName = null; //来源类型名称
if (objvcc_WorkStuRelation4ErrorLibEN.QuestionID == "[null]") objvcc_WorkStuRelation4ErrorLibEN.QuestionID = null; //题目ID
if (objvcc_WorkStuRelation4ErrorLibEN.Creator == "[null]") objvcc_WorkStuRelation4ErrorLibEN.Creator = null; //创建者
if (objvcc_WorkStuRelation4ErrorLibEN.CreateDate == "[null]") objvcc_WorkStuRelation4ErrorLibEN.CreateDate = null; //建立日期
if (objvcc_WorkStuRelation4ErrorLibEN.RedoDate == "[null]") objvcc_WorkStuRelation4ErrorLibEN.RedoDate = null; //重做日期
if (objvcc_WorkStuRelation4ErrorLibEN.UpdDate == "[null]") objvcc_WorkStuRelation4ErrorLibEN.UpdDate = null; //修改日期
if (objvcc_WorkStuRelation4ErrorLibEN.UpdUser == "[null]") objvcc_WorkStuRelation4ErrorLibEN.UpdUser = null; //修改人
if (objvcc_WorkStuRelation4ErrorLibEN.Memo == "[null]") objvcc_WorkStuRelation4ErrorLibEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibEN)
{
 vcc_WorkStuRelation4ErrorLibDA.CheckProperty4Condition(objvcc_WorkStuRelation4ErrorLibEN);
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
if (clscc_WorkStuRelation4ErrorLibBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkStuRelation4ErrorLibBL没有刷新缓存机制(clscc_WorkStuRelation4ErrorLibBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSourceTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSourceTypeBL没有刷新缓存机制(clsSourceTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvcc_WorkStuRelation4ErrorLibObjLstCache == null)
//{
//arrvcc_WorkStuRelation4ErrorLibObjLstCache = vcc_WorkStuRelation4ErrorLibDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_WorkStuRelation4ErrorLibEN GetObjBymIdCache(long lngmId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvcc_WorkStuRelation4ErrorLibEN._CurrTabName, strCourseId);
List<clsvcc_WorkStuRelation4ErrorLibEN> arrvcc_WorkStuRelation4ErrorLibObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_WorkStuRelation4ErrorLibEN> arrvcc_WorkStuRelation4ErrorLibObjLst_Sel =
arrvcc_WorkStuRelation4ErrorLibObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvcc_WorkStuRelation4ErrorLibObjLst_Sel.Count() == 0)
{
   clsvcc_WorkStuRelation4ErrorLibEN obj = clsvcc_WorkStuRelation4ErrorLibBL.GetObjBymId(lngmId);
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
return arrvcc_WorkStuRelation4ErrorLibObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_WorkStuRelation4ErrorLibEN> GetAllvcc_WorkStuRelation4ErrorLibObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsvcc_WorkStuRelation4ErrorLibEN> arrvcc_WorkStuRelation4ErrorLibObjLstCache = GetObjLstCache(strCourseId); 
return arrvcc_WorkStuRelation4ErrorLibObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_WorkStuRelation4ErrorLibEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvcc_WorkStuRelation4ErrorLibEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsvcc_WorkStuRelation4ErrorLibEN> arrvcc_WorkStuRelation4ErrorLibObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvcc_WorkStuRelation4ErrorLibObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvcc_WorkStuRelation4ErrorLibEN._CurrTabName, strCourseId);
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
if (strInFldName != convcc_WorkStuRelation4ErrorLib.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcc_WorkStuRelation4ErrorLib.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcc_WorkStuRelation4ErrorLib.AttributeName));
throw new Exception(strMsg);
}
var objvcc_WorkStuRelation4ErrorLib = clsvcc_WorkStuRelation4ErrorLibBL.GetObjBymIdCache(lngmId, strCourseId);
if (objvcc_WorkStuRelation4ErrorLib == null) return "";
return objvcc_WorkStuRelation4ErrorLib[strOutFldName].ToString();
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
int intRecCount = clsvcc_WorkStuRelation4ErrorLibDA.GetRecCount(strTabName);
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
int intRecCount = clsvcc_WorkStuRelation4ErrorLibDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcc_WorkStuRelation4ErrorLibDA.GetRecCount();
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
int intRecCount = clsvcc_WorkStuRelation4ErrorLibDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4ErrorLibCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcc_WorkStuRelation4ErrorLibEN objvcc_WorkStuRelation4ErrorLibCond)
{
 string strCourseId = objvcc_WorkStuRelation4ErrorLibCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvcc_WorkStuRelation4ErrorLibBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvcc_WorkStuRelation4ErrorLibEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_WorkStuRelation4ErrorLibEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_WorkStuRelation4ErrorLib.AttributeName)
{
if (objvcc_WorkStuRelation4ErrorLibCond.IsUpdated(strFldName) == false) continue;
if (objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkStuRelation4ErrorLibCond[strFldName].ToString());
}
else
{
if (objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_WorkStuRelation4ErrorLibCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkStuRelation4ErrorLibCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_WorkStuRelation4ErrorLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_WorkStuRelation4ErrorLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_WorkStuRelation4ErrorLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_WorkStuRelation4ErrorLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_WorkStuRelation4ErrorLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_WorkStuRelation4ErrorLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_WorkStuRelation4ErrorLibCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_WorkStuRelation4ErrorLibCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_WorkStuRelation4ErrorLibCond[strFldName]));
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
 List<string> arrList = clsvcc_WorkStuRelation4ErrorLibDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcc_WorkStuRelation4ErrorLibDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcc_WorkStuRelation4ErrorLibDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}