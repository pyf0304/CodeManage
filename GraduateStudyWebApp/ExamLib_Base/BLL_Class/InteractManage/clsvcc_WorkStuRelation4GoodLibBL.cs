
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkStuRelation4GoodLibBL
 表名:vcc_WorkStuRelation4GoodLib(01120225)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:18
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
public static class  clsvcc_WorkStuRelation4GoodLibBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkStuRelation4GoodLibEN GetObj(this K_mId_vcc_WorkStuRelation4GoodLib myKey)
{
clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN = clsvcc_WorkStuRelation4GoodLibBL.vcc_WorkStuRelation4GoodLibDA.GetObjBymId(myKey.Value);
return objvcc_WorkStuRelation4GoodLibEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetCourseName(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_WorkStuRelation4GoodLib.CourseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetStuID(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strStuID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuID, 20, convcc_WorkStuRelation4GoodLib.StuID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetStuName(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strStuName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuName, 50, convcc_WorkStuRelation4GoodLib.StuName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetIdXzCollege(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convcc_WorkStuRelation4GoodLib.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convcc_WorkStuRelation4GoodLib.IdXzCollege);
}
objvcc_WorkStuRelation4GoodLibEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.IdXzCollege) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.IdXzCollege, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.IdXzCollege] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetCollegeName(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convcc_WorkStuRelation4GoodLib.CollegeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetCollegeNameA(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convcc_WorkStuRelation4GoodLib.CollegeNameA);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetIdXzMajor(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convcc_WorkStuRelation4GoodLib.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convcc_WorkStuRelation4GoodLib.IdXzMajor);
}
objvcc_WorkStuRelation4GoodLibEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.IdXzMajor) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.IdXzMajor, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.IdXzMajor] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetMajorID(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strMajorID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorID, 4, convcc_WorkStuRelation4GoodLib.MajorID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convcc_WorkStuRelation4GoodLib.MajorID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetMajorName(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convcc_WorkStuRelation4GoodLib.MajorName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetIdGradeBase(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strIdGradeBase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, convcc_WorkStuRelation4GoodLib.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, convcc_WorkStuRelation4GoodLib.IdGradeBase);
}
objvcc_WorkStuRelation4GoodLibEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.IdGradeBase) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.IdGradeBase, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.IdGradeBase] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetGradeBaseName(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strGradeBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convcc_WorkStuRelation4GoodLib.GradeBaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetQuestionIndex(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, int? intQuestionIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetQuestionName(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strQuestionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionName, 500, convcc_WorkStuRelation4GoodLib.QuestionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetQuestionContent(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strQuestionContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionContent, 4000, convcc_WorkStuRelation4GoodLib.QuestionContent);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetCourseChapterId(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_WorkStuRelation4GoodLib.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_WorkStuRelation4GoodLib.CourseChapterId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetCourseChapterName(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strCourseChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_WorkStuRelation4GoodLib.CourseChapterName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetChapterName(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_WorkStuRelation4GoodLib.ChapterName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetSectionName(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_WorkStuRelation4GoodLib.SectionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetChapterNameSim(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strChapterNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterNameSim, 10, convcc_WorkStuRelation4GoodLib.ChapterNameSim);
}
objvcc_WorkStuRelation4GoodLibEN.ChapterNameSim = strChapterNameSim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.ChapterNameSim) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.ChapterNameSim, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.ChapterNameSim] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetSectionNameSim(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strSectionNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionNameSim, 10, convcc_WorkStuRelation4GoodLib.SectionNameSim);
}
objvcc_WorkStuRelation4GoodLibEN.SectionNameSim = strSectionNameSim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.SectionNameSim) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.SectionNameSim, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.SectionNameSim] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetParentNodeID(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strParentNodeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convcc_WorkStuRelation4GoodLib.ParentNodeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetCourseChapterReferred(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strCourseChapterReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convcc_WorkStuRelation4GoodLib.CourseChapterReferred);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetParentNodeName(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strParentNodeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convcc_WorkStuRelation4GoodLib.ParentNodeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetParentNodeReferred(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strParentNodeReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convcc_WorkStuRelation4GoodLib.ParentNodeReferred);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetSourceTypeName(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strSourceTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSourceTypeName, 20, convcc_WorkStuRelation4GoodLib.SourceTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetQuestionID(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strQuestionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionID, 8, convcc_WorkStuRelation4GoodLib.QuestionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convcc_WorkStuRelation4GoodLib.QuestionID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetCourseId(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convcc_WorkStuRelation4GoodLib.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_WorkStuRelation4GoodLib.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_WorkStuRelation4GoodLib.CourseId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetIdStudentInfo(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strIdStudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdStudentInfo, convcc_WorkStuRelation4GoodLib.IdStudentInfo);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudentInfo, 8, convcc_WorkStuRelation4GoodLib.IdStudentInfo);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudentInfo, 8, convcc_WorkStuRelation4GoodLib.IdStudentInfo);
}
objvcc_WorkStuRelation4GoodLibEN.IdStudentInfo = strIdStudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4GoodLib.IdStudentInfo) == false)
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4GoodLib.IdStudentInfo, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.IdStudentInfo] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetCreator(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strCreator, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreator, 18, convcc_WorkStuRelation4GoodLib.Creator);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetCreateDate(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convcc_WorkStuRelation4GoodLib.CreateDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetSourceTypeId(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strSourceTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSourceTypeId, convcc_WorkStuRelation4GoodLib.SourceTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSourceTypeId, 2, convcc_WorkStuRelation4GoodLib.SourceTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSourceTypeId, 2, convcc_WorkStuRelation4GoodLib.SourceTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetRedoDate(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strRedoDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRedoDate, 8, convcc_WorkStuRelation4GoodLib.RedoDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetUpdDate(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_WorkStuRelation4GoodLib.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetUpdUser(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convcc_WorkStuRelation4GoodLib.UpdUser);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelation4GoodLibEN SetMemo(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_WorkStuRelation4GoodLib.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibENS">源对象</param>
 /// <param name = "objvcc_WorkStuRelation4GoodLibENT">目标对象</param>
 public static void CopyTo(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibENS, clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibENT)
{
try
{
objvcc_WorkStuRelation4GoodLibENT.CourseName = objvcc_WorkStuRelation4GoodLibENS.CourseName; //课程名称
objvcc_WorkStuRelation4GoodLibENT.StuID = objvcc_WorkStuRelation4GoodLibENS.StuID; //学号
objvcc_WorkStuRelation4GoodLibENT.StuName = objvcc_WorkStuRelation4GoodLibENS.StuName; //姓名
objvcc_WorkStuRelation4GoodLibENT.IdXzCollege = objvcc_WorkStuRelation4GoodLibENS.IdXzCollege; //学院流水号
objvcc_WorkStuRelation4GoodLibENT.CollegeName = objvcc_WorkStuRelation4GoodLibENS.CollegeName; //学院名称
objvcc_WorkStuRelation4GoodLibENT.CollegeNameA = objvcc_WorkStuRelation4GoodLibENS.CollegeNameA; //学院名称简写
objvcc_WorkStuRelation4GoodLibENT.IdXzMajor = objvcc_WorkStuRelation4GoodLibENS.IdXzMajor; //专业流水号
objvcc_WorkStuRelation4GoodLibENT.MajorID = objvcc_WorkStuRelation4GoodLibENS.MajorID; //专业ID
objvcc_WorkStuRelation4GoodLibENT.MajorName = objvcc_WorkStuRelation4GoodLibENS.MajorName; //专业名称
objvcc_WorkStuRelation4GoodLibENT.IdGradeBase = objvcc_WorkStuRelation4GoodLibENS.IdGradeBase; //年级流水号
objvcc_WorkStuRelation4GoodLibENT.GradeBaseName = objvcc_WorkStuRelation4GoodLibENS.GradeBaseName; //年级名称
objvcc_WorkStuRelation4GoodLibENT.QuestionIndex = objvcc_WorkStuRelation4GoodLibENS.QuestionIndex; //题目序号
objvcc_WorkStuRelation4GoodLibENT.QuestionName = objvcc_WorkStuRelation4GoodLibENS.QuestionName; //题目名称
objvcc_WorkStuRelation4GoodLibENT.QuestionContent = objvcc_WorkStuRelation4GoodLibENS.QuestionContent; //题目内容
objvcc_WorkStuRelation4GoodLibENT.CourseChapterId = objvcc_WorkStuRelation4GoodLibENS.CourseChapterId; //课程章节ID
objvcc_WorkStuRelation4GoodLibENT.CourseChapterName = objvcc_WorkStuRelation4GoodLibENS.CourseChapterName; //课程章节名称
objvcc_WorkStuRelation4GoodLibENT.ChapterName = objvcc_WorkStuRelation4GoodLibENS.ChapterName; //章名
objvcc_WorkStuRelation4GoodLibENT.SectionName = objvcc_WorkStuRelation4GoodLibENS.SectionName; //节名
objvcc_WorkStuRelation4GoodLibENT.ChapterNameSim = objvcc_WorkStuRelation4GoodLibENS.ChapterNameSim; //章名简称
objvcc_WorkStuRelation4GoodLibENT.SectionNameSim = objvcc_WorkStuRelation4GoodLibENS.SectionNameSim; //节名简称
objvcc_WorkStuRelation4GoodLibENT.ParentNodeID = objvcc_WorkStuRelation4GoodLibENS.ParentNodeID; //父节点编号
objvcc_WorkStuRelation4GoodLibENT.CourseChapterReferred = objvcc_WorkStuRelation4GoodLibENS.CourseChapterReferred; //节简称
objvcc_WorkStuRelation4GoodLibENT.ParentNodeName = objvcc_WorkStuRelation4GoodLibENS.ParentNodeName; //父节点名称
objvcc_WorkStuRelation4GoodLibENT.ParentNodeReferred = objvcc_WorkStuRelation4GoodLibENS.ParentNodeReferred; //章简称
objvcc_WorkStuRelation4GoodLibENT.SourceTypeName = objvcc_WorkStuRelation4GoodLibENS.SourceTypeName; //来源类型名称
objvcc_WorkStuRelation4GoodLibENT.QuestionID = objvcc_WorkStuRelation4GoodLibENS.QuestionID; //题目ID
objvcc_WorkStuRelation4GoodLibENT.mId = objvcc_WorkStuRelation4GoodLibENS.mId; //mId
objvcc_WorkStuRelation4GoodLibENT.CourseId = objvcc_WorkStuRelation4GoodLibENS.CourseId; //课程Id
objvcc_WorkStuRelation4GoodLibENT.IdStudentInfo = objvcc_WorkStuRelation4GoodLibENS.IdStudentInfo; //学生流水号
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
 /// <param name = "objvcc_WorkStuRelation4GoodLibENS">源对象</param>
 /// <returns>目标对象=>clsvcc_WorkStuRelation4GoodLibEN:objvcc_WorkStuRelation4GoodLibENT</returns>
 public static clsvcc_WorkStuRelation4GoodLibEN CopyTo(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibENS)
{
try
{
 clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibENT = new clsvcc_WorkStuRelation4GoodLibEN()
{
CourseName = objvcc_WorkStuRelation4GoodLibENS.CourseName, //课程名称
StuID = objvcc_WorkStuRelation4GoodLibENS.StuID, //学号
StuName = objvcc_WorkStuRelation4GoodLibENS.StuName, //姓名
IdXzCollege = objvcc_WorkStuRelation4GoodLibENS.IdXzCollege, //学院流水号
CollegeName = objvcc_WorkStuRelation4GoodLibENS.CollegeName, //学院名称
CollegeNameA = objvcc_WorkStuRelation4GoodLibENS.CollegeNameA, //学院名称简写
IdXzMajor = objvcc_WorkStuRelation4GoodLibENS.IdXzMajor, //专业流水号
MajorID = objvcc_WorkStuRelation4GoodLibENS.MajorID, //专业ID
MajorName = objvcc_WorkStuRelation4GoodLibENS.MajorName, //专业名称
IdGradeBase = objvcc_WorkStuRelation4GoodLibENS.IdGradeBase, //年级流水号
GradeBaseName = objvcc_WorkStuRelation4GoodLibENS.GradeBaseName, //年级名称
QuestionIndex = objvcc_WorkStuRelation4GoodLibENS.QuestionIndex, //题目序号
QuestionName = objvcc_WorkStuRelation4GoodLibENS.QuestionName, //题目名称
QuestionContent = objvcc_WorkStuRelation4GoodLibENS.QuestionContent, //题目内容
CourseChapterId = objvcc_WorkStuRelation4GoodLibENS.CourseChapterId, //课程章节ID
CourseChapterName = objvcc_WorkStuRelation4GoodLibENS.CourseChapterName, //课程章节名称
ChapterName = objvcc_WorkStuRelation4GoodLibENS.ChapterName, //章名
SectionName = objvcc_WorkStuRelation4GoodLibENS.SectionName, //节名
ChapterNameSim = objvcc_WorkStuRelation4GoodLibENS.ChapterNameSim, //章名简称
SectionNameSim = objvcc_WorkStuRelation4GoodLibENS.SectionNameSim, //节名简称
ParentNodeID = objvcc_WorkStuRelation4GoodLibENS.ParentNodeID, //父节点编号
CourseChapterReferred = objvcc_WorkStuRelation4GoodLibENS.CourseChapterReferred, //节简称
ParentNodeName = objvcc_WorkStuRelation4GoodLibENS.ParentNodeName, //父节点名称
ParentNodeReferred = objvcc_WorkStuRelation4GoodLibENS.ParentNodeReferred, //章简称
SourceTypeName = objvcc_WorkStuRelation4GoodLibENS.SourceTypeName, //来源类型名称
QuestionID = objvcc_WorkStuRelation4GoodLibENS.QuestionID, //题目ID
mId = objvcc_WorkStuRelation4GoodLibENS.mId, //mId
CourseId = objvcc_WorkStuRelation4GoodLibENS.CourseId, //课程Id
IdStudentInfo = objvcc_WorkStuRelation4GoodLibENS.IdStudentInfo, //学生流水号
Creator = objvcc_WorkStuRelation4GoodLibENS.Creator, //创建者
CreateDate = objvcc_WorkStuRelation4GoodLibENS.CreateDate, //建立日期
SourceTypeId = objvcc_WorkStuRelation4GoodLibENS.SourceTypeId, //来源类型Id
IsRedo = objvcc_WorkStuRelation4GoodLibENS.IsRedo, //是否重做
RedoDate = objvcc_WorkStuRelation4GoodLibENS.RedoDate, //重做日期
IsPassed = objvcc_WorkStuRelation4GoodLibENS.IsPassed, //是否通过
UpdDate = objvcc_WorkStuRelation4GoodLibENS.UpdDate, //修改日期
UpdUser = objvcc_WorkStuRelation4GoodLibENS.UpdUser, //修改人
Memo = objvcc_WorkStuRelation4GoodLibENS.Memo, //备注
};
 return objvcc_WorkStuRelation4GoodLibENT;
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
public static void CheckProperty4Condition(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN)
{
 clsvcc_WorkStuRelation4GoodLibBL.vcc_WorkStuRelation4GoodLibDA.CheckProperty4Condition(objvcc_WorkStuRelation4GoodLibEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.CourseName) == true)
{
string strComparisonOpCourseName = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.CourseName, objvcc_WorkStuRelation4GoodLibCond.CourseName, strComparisonOpCourseName);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.StuID) == true)
{
string strComparisonOpStuID = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.StuID, objvcc_WorkStuRelation4GoodLibCond.StuID, strComparisonOpStuID);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.StuName) == true)
{
string strComparisonOpStuName = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.StuName, objvcc_WorkStuRelation4GoodLibCond.StuName, strComparisonOpStuName);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.IdXzCollege, objvcc_WorkStuRelation4GoodLibCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.CollegeName) == true)
{
string strComparisonOpCollegeName = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.CollegeName, objvcc_WorkStuRelation4GoodLibCond.CollegeName, strComparisonOpCollegeName);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.CollegeNameA, objvcc_WorkStuRelation4GoodLibCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.IdXzMajor, objvcc_WorkStuRelation4GoodLibCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.MajorID) == true)
{
string strComparisonOpMajorID = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.MajorID, objvcc_WorkStuRelation4GoodLibCond.MajorID, strComparisonOpMajorID);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.MajorName) == true)
{
string strComparisonOpMajorName = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.MajorName, objvcc_WorkStuRelation4GoodLibCond.MajorName, strComparisonOpMajorName);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.IdGradeBase, objvcc_WorkStuRelation4GoodLibCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.GradeBaseName) == true)
{
string strComparisonOpGradeBaseName = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.GradeBaseName, objvcc_WorkStuRelation4GoodLibCond.GradeBaseName, strComparisonOpGradeBaseName);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.QuestionIndex) == true)
{
string strComparisonOpQuestionIndex = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation4GoodLib.QuestionIndex, objvcc_WorkStuRelation4GoodLibCond.QuestionIndex, strComparisonOpQuestionIndex);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.QuestionName) == true)
{
string strComparisonOpQuestionName = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.QuestionName, objvcc_WorkStuRelation4GoodLibCond.QuestionName, strComparisonOpQuestionName);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.QuestionContent) == true)
{
string strComparisonOpQuestionContent = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.QuestionContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.QuestionContent, objvcc_WorkStuRelation4GoodLibCond.QuestionContent, strComparisonOpQuestionContent);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.CourseChapterId, objvcc_WorkStuRelation4GoodLibCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.CourseChapterName) == true)
{
string strComparisonOpCourseChapterName = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.CourseChapterName, objvcc_WorkStuRelation4GoodLibCond.CourseChapterName, strComparisonOpCourseChapterName);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.ChapterName) == true)
{
string strComparisonOpChapterName = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.ChapterName, objvcc_WorkStuRelation4GoodLibCond.ChapterName, strComparisonOpChapterName);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.SectionName) == true)
{
string strComparisonOpSectionName = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.SectionName, objvcc_WorkStuRelation4GoodLibCond.SectionName, strComparisonOpSectionName);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.ChapterNameSim) == true)
{
string strComparisonOpChapterNameSim = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.ChapterNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.ChapterNameSim, objvcc_WorkStuRelation4GoodLibCond.ChapterNameSim, strComparisonOpChapterNameSim);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.SectionNameSim) == true)
{
string strComparisonOpSectionNameSim = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.SectionNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.SectionNameSim, objvcc_WorkStuRelation4GoodLibCond.SectionNameSim, strComparisonOpSectionNameSim);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.ParentNodeID) == true)
{
string strComparisonOpParentNodeID = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.ParentNodeID, objvcc_WorkStuRelation4GoodLibCond.ParentNodeID, strComparisonOpParentNodeID);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.CourseChapterReferred) == true)
{
string strComparisonOpCourseChapterReferred = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.CourseChapterReferred, objvcc_WorkStuRelation4GoodLibCond.CourseChapterReferred, strComparisonOpCourseChapterReferred);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.ParentNodeName) == true)
{
string strComparisonOpParentNodeName = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.ParentNodeName, objvcc_WorkStuRelation4GoodLibCond.ParentNodeName, strComparisonOpParentNodeName);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.ParentNodeReferred) == true)
{
string strComparisonOpParentNodeReferred = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.ParentNodeReferred, objvcc_WorkStuRelation4GoodLibCond.ParentNodeReferred, strComparisonOpParentNodeReferred);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.SourceTypeName) == true)
{
string strComparisonOpSourceTypeName = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.SourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.SourceTypeName, objvcc_WorkStuRelation4GoodLibCond.SourceTypeName, strComparisonOpSourceTypeName);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.QuestionID) == true)
{
string strComparisonOpQuestionID = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.QuestionID, objvcc_WorkStuRelation4GoodLibCond.QuestionID, strComparisonOpQuestionID);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.mId) == true)
{
string strComparisonOpmId = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation4GoodLib.mId, objvcc_WorkStuRelation4GoodLibCond.mId, strComparisonOpmId);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.CourseId) == true)
{
string strComparisonOpCourseId = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.CourseId, objvcc_WorkStuRelation4GoodLibCond.CourseId, strComparisonOpCourseId);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.IdStudentInfo) == true)
{
string strComparisonOpIdStudentInfo = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.IdStudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.IdStudentInfo, objvcc_WorkStuRelation4GoodLibCond.IdStudentInfo, strComparisonOpIdStudentInfo);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.Creator) == true)
{
string strComparisonOpCreator = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.Creator];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.Creator, objvcc_WorkStuRelation4GoodLibCond.Creator, strComparisonOpCreator);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.CreateDate) == true)
{
string strComparisonOpCreateDate = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.CreateDate, objvcc_WorkStuRelation4GoodLibCond.CreateDate, strComparisonOpCreateDate);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.SourceTypeId) == true)
{
string strComparisonOpSourceTypeId = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.SourceTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.SourceTypeId, objvcc_WorkStuRelation4GoodLibCond.SourceTypeId, strComparisonOpSourceTypeId);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.IsRedo) == true)
{
if (objvcc_WorkStuRelation4GoodLibCond.IsRedo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation4GoodLib.IsRedo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation4GoodLib.IsRedo);
}
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.RedoDate) == true)
{
string strComparisonOpRedoDate = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.RedoDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.RedoDate, objvcc_WorkStuRelation4GoodLibCond.RedoDate, strComparisonOpRedoDate);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.IsPassed) == true)
{
if (objvcc_WorkStuRelation4GoodLibCond.IsPassed == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation4GoodLib.IsPassed);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation4GoodLib.IsPassed);
}
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.UpdDate) == true)
{
string strComparisonOpUpdDate = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.UpdDate, objvcc_WorkStuRelation4GoodLibCond.UpdDate, strComparisonOpUpdDate);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.UpdUser) == true)
{
string strComparisonOpUpdUser = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.UpdUser, objvcc_WorkStuRelation4GoodLibCond.UpdUser, strComparisonOpUpdUser);
}
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(convcc_WorkStuRelation4GoodLib.Memo) == true)
{
string strComparisonOpMemo = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[convcc_WorkStuRelation4GoodLib.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4GoodLib.Memo, objvcc_WorkStuRelation4GoodLibCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcc_WorkStuRelation4GoodLib
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v学生好题集(vcc_WorkStuRelation4GoodLib)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcc_WorkStuRelation4GoodLibBL
{
public static RelatedActions_vcc_WorkStuRelation4GoodLib relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcc_WorkStuRelation4GoodLibDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcc_WorkStuRelation4GoodLibDA vcc_WorkStuRelation4GoodLibDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcc_WorkStuRelation4GoodLibDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcc_WorkStuRelation4GoodLibBL()
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
if (string.IsNullOrEmpty(clsvcc_WorkStuRelation4GoodLibEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_WorkStuRelation4GoodLibEN._ConnectString);
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
public static DataTable GetDataTable_vcc_WorkStuRelation4GoodLib(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcc_WorkStuRelation4GoodLibDA.GetDataTable_vcc_WorkStuRelation4GoodLib(strWhereCond);
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
objDT = vcc_WorkStuRelation4GoodLibDA.GetDataTable(strWhereCond);
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
objDT = vcc_WorkStuRelation4GoodLibDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcc_WorkStuRelation4GoodLibDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcc_WorkStuRelation4GoodLibDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcc_WorkStuRelation4GoodLibDA.GetDataTable_Top(objTopPara);
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
objDT = vcc_WorkStuRelation4GoodLibDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcc_WorkStuRelation4GoodLibDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcc_WorkStuRelation4GoodLibDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvcc_WorkStuRelation4GoodLibEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvcc_WorkStuRelation4GoodLibEN> arrObjLst = new List<clsvcc_WorkStuRelation4GoodLibEN>(); 
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
	clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN = new clsvcc_WorkStuRelation4GoodLibEN();
try
{
objvcc_WorkStuRelation4GoodLibEN.CourseName = objRow[convcc_WorkStuRelation4GoodLib.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4GoodLibEN.StuID = objRow[convcc_WorkStuRelation4GoodLib.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4GoodLibEN.StuName = objRow[convcc_WorkStuRelation4GoodLib.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4GoodLibEN.IdXzCollege = objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4GoodLibEN.CollegeName = objRow[convcc_WorkStuRelation4GoodLib.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4GoodLibEN.CollegeNameA = objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4GoodLibEN.IdXzMajor = objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4GoodLibEN.MajorID = objRow[convcc_WorkStuRelation4GoodLib.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4GoodLibEN.MajorName = objRow[convcc_WorkStuRelation4GoodLib.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4GoodLibEN.IdGradeBase = objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4GoodLibEN.GradeBaseName = objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4GoodLibEN.QuestionIndex = objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4GoodLibEN.QuestionName = objRow[convcc_WorkStuRelation4GoodLib.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4GoodLibEN.QuestionContent = objRow[convcc_WorkStuRelation4GoodLib.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelation4GoodLibEN.CourseChapterId = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4GoodLibEN.CourseChapterName = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4GoodLibEN.ChapterName = objRow[convcc_WorkStuRelation4GoodLib.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4GoodLibEN.SectionName = objRow[convcc_WorkStuRelation4GoodLib.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4GoodLibEN.ChapterNameSim = objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4GoodLibEN.SectionNameSim = objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeID = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4GoodLibEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeName = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4GoodLibEN.SourceTypeName = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName].ToString().Trim(); //来源类型名称
objvcc_WorkStuRelation4GoodLibEN.QuestionID = objRow[convcc_WorkStuRelation4GoodLib.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4GoodLibEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4GoodLib.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4GoodLibEN.CourseId = objRow[convcc_WorkStuRelation4GoodLib.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4GoodLibEN.IdStudentInfo = objRow[convcc_WorkStuRelation4GoodLib.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4GoodLibEN.Creator = objRow[convcc_WorkStuRelation4GoodLib.Creator] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Creator].ToString().Trim(); //创建者
objvcc_WorkStuRelation4GoodLibEN.CreateDate = objRow[convcc_WorkStuRelation4GoodLib.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkStuRelation4GoodLibEN.SourceTypeId = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeId].ToString().Trim(); //来源类型Id
objvcc_WorkStuRelation4GoodLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4GoodLib.IsRedo].ToString().Trim()); //是否重做
objvcc_WorkStuRelation4GoodLibEN.RedoDate = objRow[convcc_WorkStuRelation4GoodLib.RedoDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.RedoDate].ToString().Trim(); //重做日期
objvcc_WorkStuRelation4GoodLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4GoodLib.IsPassed].ToString().Trim()); //是否通过
objvcc_WorkStuRelation4GoodLibEN.UpdDate = objRow[convcc_WorkStuRelation4GoodLib.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4GoodLibEN.UpdUser = objRow[convcc_WorkStuRelation4GoodLib.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4GoodLibEN.Memo = objRow[convcc_WorkStuRelation4GoodLib.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelation4GoodLibEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelation4GoodLibEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcc_WorkStuRelation4GoodLibEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsvcc_WorkStuRelation4GoodLibEN._CurrTabName, strCourseId);
List<clsvcc_WorkStuRelation4GoodLibEN> arrvcc_WorkStuRelation4GoodLibObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_WorkStuRelation4GoodLibEN> arrvcc_WorkStuRelation4GoodLibObjLst_Sel =
arrvcc_WorkStuRelation4GoodLibObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvcc_WorkStuRelation4GoodLibObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelation4GoodLibEN> GetObjLst(string strWhereCond)
{
List<clsvcc_WorkStuRelation4GoodLibEN> arrObjLst = new List<clsvcc_WorkStuRelation4GoodLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN = new clsvcc_WorkStuRelation4GoodLibEN();
try
{
objvcc_WorkStuRelation4GoodLibEN.CourseName = objRow[convcc_WorkStuRelation4GoodLib.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4GoodLibEN.StuID = objRow[convcc_WorkStuRelation4GoodLib.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4GoodLibEN.StuName = objRow[convcc_WorkStuRelation4GoodLib.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4GoodLibEN.IdXzCollege = objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4GoodLibEN.CollegeName = objRow[convcc_WorkStuRelation4GoodLib.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4GoodLibEN.CollegeNameA = objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4GoodLibEN.IdXzMajor = objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4GoodLibEN.MajorID = objRow[convcc_WorkStuRelation4GoodLib.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4GoodLibEN.MajorName = objRow[convcc_WorkStuRelation4GoodLib.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4GoodLibEN.IdGradeBase = objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4GoodLibEN.GradeBaseName = objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4GoodLibEN.QuestionIndex = objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4GoodLibEN.QuestionName = objRow[convcc_WorkStuRelation4GoodLib.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4GoodLibEN.QuestionContent = objRow[convcc_WorkStuRelation4GoodLib.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelation4GoodLibEN.CourseChapterId = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4GoodLibEN.CourseChapterName = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4GoodLibEN.ChapterName = objRow[convcc_WorkStuRelation4GoodLib.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4GoodLibEN.SectionName = objRow[convcc_WorkStuRelation4GoodLib.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4GoodLibEN.ChapterNameSim = objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4GoodLibEN.SectionNameSim = objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeID = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4GoodLibEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeName = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4GoodLibEN.SourceTypeName = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName].ToString().Trim(); //来源类型名称
objvcc_WorkStuRelation4GoodLibEN.QuestionID = objRow[convcc_WorkStuRelation4GoodLib.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4GoodLibEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4GoodLib.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4GoodLibEN.CourseId = objRow[convcc_WorkStuRelation4GoodLib.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4GoodLibEN.IdStudentInfo = objRow[convcc_WorkStuRelation4GoodLib.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4GoodLibEN.Creator = objRow[convcc_WorkStuRelation4GoodLib.Creator] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Creator].ToString().Trim(); //创建者
objvcc_WorkStuRelation4GoodLibEN.CreateDate = objRow[convcc_WorkStuRelation4GoodLib.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkStuRelation4GoodLibEN.SourceTypeId = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeId].ToString().Trim(); //来源类型Id
objvcc_WorkStuRelation4GoodLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4GoodLib.IsRedo].ToString().Trim()); //是否重做
objvcc_WorkStuRelation4GoodLibEN.RedoDate = objRow[convcc_WorkStuRelation4GoodLib.RedoDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.RedoDate].ToString().Trim(); //重做日期
objvcc_WorkStuRelation4GoodLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4GoodLib.IsPassed].ToString().Trim()); //是否通过
objvcc_WorkStuRelation4GoodLibEN.UpdDate = objRow[convcc_WorkStuRelation4GoodLib.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4GoodLibEN.UpdUser = objRow[convcc_WorkStuRelation4GoodLib.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4GoodLibEN.Memo = objRow[convcc_WorkStuRelation4GoodLib.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelation4GoodLibEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelation4GoodLibEN);
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
public static List<clsvcc_WorkStuRelation4GoodLibEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcc_WorkStuRelation4GoodLibEN> arrObjLst = new List<clsvcc_WorkStuRelation4GoodLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN = new clsvcc_WorkStuRelation4GoodLibEN();
try
{
objvcc_WorkStuRelation4GoodLibEN.CourseName = objRow[convcc_WorkStuRelation4GoodLib.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4GoodLibEN.StuID = objRow[convcc_WorkStuRelation4GoodLib.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4GoodLibEN.StuName = objRow[convcc_WorkStuRelation4GoodLib.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4GoodLibEN.IdXzCollege = objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4GoodLibEN.CollegeName = objRow[convcc_WorkStuRelation4GoodLib.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4GoodLibEN.CollegeNameA = objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4GoodLibEN.IdXzMajor = objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4GoodLibEN.MajorID = objRow[convcc_WorkStuRelation4GoodLib.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4GoodLibEN.MajorName = objRow[convcc_WorkStuRelation4GoodLib.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4GoodLibEN.IdGradeBase = objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4GoodLibEN.GradeBaseName = objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4GoodLibEN.QuestionIndex = objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4GoodLibEN.QuestionName = objRow[convcc_WorkStuRelation4GoodLib.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4GoodLibEN.QuestionContent = objRow[convcc_WorkStuRelation4GoodLib.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelation4GoodLibEN.CourseChapterId = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4GoodLibEN.CourseChapterName = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4GoodLibEN.ChapterName = objRow[convcc_WorkStuRelation4GoodLib.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4GoodLibEN.SectionName = objRow[convcc_WorkStuRelation4GoodLib.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4GoodLibEN.ChapterNameSim = objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4GoodLibEN.SectionNameSim = objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeID = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4GoodLibEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeName = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4GoodLibEN.SourceTypeName = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName].ToString().Trim(); //来源类型名称
objvcc_WorkStuRelation4GoodLibEN.QuestionID = objRow[convcc_WorkStuRelation4GoodLib.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4GoodLibEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4GoodLib.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4GoodLibEN.CourseId = objRow[convcc_WorkStuRelation4GoodLib.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4GoodLibEN.IdStudentInfo = objRow[convcc_WorkStuRelation4GoodLib.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4GoodLibEN.Creator = objRow[convcc_WorkStuRelation4GoodLib.Creator] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Creator].ToString().Trim(); //创建者
objvcc_WorkStuRelation4GoodLibEN.CreateDate = objRow[convcc_WorkStuRelation4GoodLib.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkStuRelation4GoodLibEN.SourceTypeId = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeId].ToString().Trim(); //来源类型Id
objvcc_WorkStuRelation4GoodLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4GoodLib.IsRedo].ToString().Trim()); //是否重做
objvcc_WorkStuRelation4GoodLibEN.RedoDate = objRow[convcc_WorkStuRelation4GoodLib.RedoDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.RedoDate].ToString().Trim(); //重做日期
objvcc_WorkStuRelation4GoodLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4GoodLib.IsPassed].ToString().Trim()); //是否通过
objvcc_WorkStuRelation4GoodLibEN.UpdDate = objRow[convcc_WorkStuRelation4GoodLib.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4GoodLibEN.UpdUser = objRow[convcc_WorkStuRelation4GoodLib.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4GoodLibEN.Memo = objRow[convcc_WorkStuRelation4GoodLib.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelation4GoodLibEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelation4GoodLibEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcc_WorkStuRelation4GoodLibEN> GetSubObjLstCache(clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibCond)
{
 string strCourseId = objvcc_WorkStuRelation4GoodLibCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvcc_WorkStuRelation4GoodLibBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvcc_WorkStuRelation4GoodLibEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_WorkStuRelation4GoodLibEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_WorkStuRelation4GoodLib.AttributeName)
{
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(strFldName) == false) continue;
if (objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkStuRelation4GoodLibCond[strFldName].ToString());
}
else
{
if (objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkStuRelation4GoodLibCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_WorkStuRelation4GoodLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_WorkStuRelation4GoodLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_WorkStuRelation4GoodLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_WorkStuRelation4GoodLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_WorkStuRelation4GoodLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_WorkStuRelation4GoodLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_WorkStuRelation4GoodLibCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_WorkStuRelation4GoodLibCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_WorkStuRelation4GoodLibCond[strFldName]));
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
public static List<clsvcc_WorkStuRelation4GoodLibEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcc_WorkStuRelation4GoodLibEN> arrObjLst = new List<clsvcc_WorkStuRelation4GoodLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN = new clsvcc_WorkStuRelation4GoodLibEN();
try
{
objvcc_WorkStuRelation4GoodLibEN.CourseName = objRow[convcc_WorkStuRelation4GoodLib.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4GoodLibEN.StuID = objRow[convcc_WorkStuRelation4GoodLib.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4GoodLibEN.StuName = objRow[convcc_WorkStuRelation4GoodLib.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4GoodLibEN.IdXzCollege = objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4GoodLibEN.CollegeName = objRow[convcc_WorkStuRelation4GoodLib.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4GoodLibEN.CollegeNameA = objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4GoodLibEN.IdXzMajor = objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4GoodLibEN.MajorID = objRow[convcc_WorkStuRelation4GoodLib.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4GoodLibEN.MajorName = objRow[convcc_WorkStuRelation4GoodLib.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4GoodLibEN.IdGradeBase = objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4GoodLibEN.GradeBaseName = objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4GoodLibEN.QuestionIndex = objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4GoodLibEN.QuestionName = objRow[convcc_WorkStuRelation4GoodLib.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4GoodLibEN.QuestionContent = objRow[convcc_WorkStuRelation4GoodLib.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelation4GoodLibEN.CourseChapterId = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4GoodLibEN.CourseChapterName = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4GoodLibEN.ChapterName = objRow[convcc_WorkStuRelation4GoodLib.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4GoodLibEN.SectionName = objRow[convcc_WorkStuRelation4GoodLib.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4GoodLibEN.ChapterNameSim = objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4GoodLibEN.SectionNameSim = objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeID = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4GoodLibEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeName = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4GoodLibEN.SourceTypeName = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName].ToString().Trim(); //来源类型名称
objvcc_WorkStuRelation4GoodLibEN.QuestionID = objRow[convcc_WorkStuRelation4GoodLib.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4GoodLibEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4GoodLib.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4GoodLibEN.CourseId = objRow[convcc_WorkStuRelation4GoodLib.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4GoodLibEN.IdStudentInfo = objRow[convcc_WorkStuRelation4GoodLib.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4GoodLibEN.Creator = objRow[convcc_WorkStuRelation4GoodLib.Creator] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Creator].ToString().Trim(); //创建者
objvcc_WorkStuRelation4GoodLibEN.CreateDate = objRow[convcc_WorkStuRelation4GoodLib.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkStuRelation4GoodLibEN.SourceTypeId = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeId].ToString().Trim(); //来源类型Id
objvcc_WorkStuRelation4GoodLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4GoodLib.IsRedo].ToString().Trim()); //是否重做
objvcc_WorkStuRelation4GoodLibEN.RedoDate = objRow[convcc_WorkStuRelation4GoodLib.RedoDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.RedoDate].ToString().Trim(); //重做日期
objvcc_WorkStuRelation4GoodLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4GoodLib.IsPassed].ToString().Trim()); //是否通过
objvcc_WorkStuRelation4GoodLibEN.UpdDate = objRow[convcc_WorkStuRelation4GoodLib.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4GoodLibEN.UpdUser = objRow[convcc_WorkStuRelation4GoodLib.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4GoodLibEN.Memo = objRow[convcc_WorkStuRelation4GoodLib.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelation4GoodLibEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelation4GoodLibEN);
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
public static List<clsvcc_WorkStuRelation4GoodLibEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcc_WorkStuRelation4GoodLibEN> arrObjLst = new List<clsvcc_WorkStuRelation4GoodLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN = new clsvcc_WorkStuRelation4GoodLibEN();
try
{
objvcc_WorkStuRelation4GoodLibEN.CourseName = objRow[convcc_WorkStuRelation4GoodLib.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4GoodLibEN.StuID = objRow[convcc_WorkStuRelation4GoodLib.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4GoodLibEN.StuName = objRow[convcc_WorkStuRelation4GoodLib.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4GoodLibEN.IdXzCollege = objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4GoodLibEN.CollegeName = objRow[convcc_WorkStuRelation4GoodLib.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4GoodLibEN.CollegeNameA = objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4GoodLibEN.IdXzMajor = objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4GoodLibEN.MajorID = objRow[convcc_WorkStuRelation4GoodLib.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4GoodLibEN.MajorName = objRow[convcc_WorkStuRelation4GoodLib.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4GoodLibEN.IdGradeBase = objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4GoodLibEN.GradeBaseName = objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4GoodLibEN.QuestionIndex = objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4GoodLibEN.QuestionName = objRow[convcc_WorkStuRelation4GoodLib.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4GoodLibEN.QuestionContent = objRow[convcc_WorkStuRelation4GoodLib.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelation4GoodLibEN.CourseChapterId = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4GoodLibEN.CourseChapterName = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4GoodLibEN.ChapterName = objRow[convcc_WorkStuRelation4GoodLib.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4GoodLibEN.SectionName = objRow[convcc_WorkStuRelation4GoodLib.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4GoodLibEN.ChapterNameSim = objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4GoodLibEN.SectionNameSim = objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeID = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4GoodLibEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeName = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4GoodLibEN.SourceTypeName = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName].ToString().Trim(); //来源类型名称
objvcc_WorkStuRelation4GoodLibEN.QuestionID = objRow[convcc_WorkStuRelation4GoodLib.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4GoodLibEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4GoodLib.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4GoodLibEN.CourseId = objRow[convcc_WorkStuRelation4GoodLib.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4GoodLibEN.IdStudentInfo = objRow[convcc_WorkStuRelation4GoodLib.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4GoodLibEN.Creator = objRow[convcc_WorkStuRelation4GoodLib.Creator] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Creator].ToString().Trim(); //创建者
objvcc_WorkStuRelation4GoodLibEN.CreateDate = objRow[convcc_WorkStuRelation4GoodLib.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkStuRelation4GoodLibEN.SourceTypeId = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeId].ToString().Trim(); //来源类型Id
objvcc_WorkStuRelation4GoodLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4GoodLib.IsRedo].ToString().Trim()); //是否重做
objvcc_WorkStuRelation4GoodLibEN.RedoDate = objRow[convcc_WorkStuRelation4GoodLib.RedoDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.RedoDate].ToString().Trim(); //重做日期
objvcc_WorkStuRelation4GoodLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4GoodLib.IsPassed].ToString().Trim()); //是否通过
objvcc_WorkStuRelation4GoodLibEN.UpdDate = objRow[convcc_WorkStuRelation4GoodLib.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4GoodLibEN.UpdUser = objRow[convcc_WorkStuRelation4GoodLib.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4GoodLibEN.Memo = objRow[convcc_WorkStuRelation4GoodLib.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelation4GoodLibEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelation4GoodLibEN);
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
List<clsvcc_WorkStuRelation4GoodLibEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcc_WorkStuRelation4GoodLibEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelation4GoodLibEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcc_WorkStuRelation4GoodLibEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_WorkStuRelation4GoodLibEN> arrObjLst = new List<clsvcc_WorkStuRelation4GoodLibEN>(); 
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
	clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN = new clsvcc_WorkStuRelation4GoodLibEN();
try
{
objvcc_WorkStuRelation4GoodLibEN.CourseName = objRow[convcc_WorkStuRelation4GoodLib.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4GoodLibEN.StuID = objRow[convcc_WorkStuRelation4GoodLib.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4GoodLibEN.StuName = objRow[convcc_WorkStuRelation4GoodLib.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4GoodLibEN.IdXzCollege = objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4GoodLibEN.CollegeName = objRow[convcc_WorkStuRelation4GoodLib.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4GoodLibEN.CollegeNameA = objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4GoodLibEN.IdXzMajor = objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4GoodLibEN.MajorID = objRow[convcc_WorkStuRelation4GoodLib.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4GoodLibEN.MajorName = objRow[convcc_WorkStuRelation4GoodLib.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4GoodLibEN.IdGradeBase = objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4GoodLibEN.GradeBaseName = objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4GoodLibEN.QuestionIndex = objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4GoodLibEN.QuestionName = objRow[convcc_WorkStuRelation4GoodLib.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4GoodLibEN.QuestionContent = objRow[convcc_WorkStuRelation4GoodLib.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelation4GoodLibEN.CourseChapterId = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4GoodLibEN.CourseChapterName = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4GoodLibEN.ChapterName = objRow[convcc_WorkStuRelation4GoodLib.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4GoodLibEN.SectionName = objRow[convcc_WorkStuRelation4GoodLib.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4GoodLibEN.ChapterNameSim = objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4GoodLibEN.SectionNameSim = objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeID = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4GoodLibEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeName = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4GoodLibEN.SourceTypeName = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName].ToString().Trim(); //来源类型名称
objvcc_WorkStuRelation4GoodLibEN.QuestionID = objRow[convcc_WorkStuRelation4GoodLib.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4GoodLibEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4GoodLib.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4GoodLibEN.CourseId = objRow[convcc_WorkStuRelation4GoodLib.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4GoodLibEN.IdStudentInfo = objRow[convcc_WorkStuRelation4GoodLib.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4GoodLibEN.Creator = objRow[convcc_WorkStuRelation4GoodLib.Creator] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Creator].ToString().Trim(); //创建者
objvcc_WorkStuRelation4GoodLibEN.CreateDate = objRow[convcc_WorkStuRelation4GoodLib.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkStuRelation4GoodLibEN.SourceTypeId = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeId].ToString().Trim(); //来源类型Id
objvcc_WorkStuRelation4GoodLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4GoodLib.IsRedo].ToString().Trim()); //是否重做
objvcc_WorkStuRelation4GoodLibEN.RedoDate = objRow[convcc_WorkStuRelation4GoodLib.RedoDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.RedoDate].ToString().Trim(); //重做日期
objvcc_WorkStuRelation4GoodLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4GoodLib.IsPassed].ToString().Trim()); //是否通过
objvcc_WorkStuRelation4GoodLibEN.UpdDate = objRow[convcc_WorkStuRelation4GoodLib.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4GoodLibEN.UpdUser = objRow[convcc_WorkStuRelation4GoodLib.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4GoodLibEN.Memo = objRow[convcc_WorkStuRelation4GoodLib.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelation4GoodLibEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelation4GoodLibEN);
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
public static List<clsvcc_WorkStuRelation4GoodLibEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcc_WorkStuRelation4GoodLibEN> arrObjLst = new List<clsvcc_WorkStuRelation4GoodLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN = new clsvcc_WorkStuRelation4GoodLibEN();
try
{
objvcc_WorkStuRelation4GoodLibEN.CourseName = objRow[convcc_WorkStuRelation4GoodLib.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4GoodLibEN.StuID = objRow[convcc_WorkStuRelation4GoodLib.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4GoodLibEN.StuName = objRow[convcc_WorkStuRelation4GoodLib.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4GoodLibEN.IdXzCollege = objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4GoodLibEN.CollegeName = objRow[convcc_WorkStuRelation4GoodLib.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4GoodLibEN.CollegeNameA = objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4GoodLibEN.IdXzMajor = objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4GoodLibEN.MajorID = objRow[convcc_WorkStuRelation4GoodLib.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4GoodLibEN.MajorName = objRow[convcc_WorkStuRelation4GoodLib.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4GoodLibEN.IdGradeBase = objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4GoodLibEN.GradeBaseName = objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4GoodLibEN.QuestionIndex = objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4GoodLibEN.QuestionName = objRow[convcc_WorkStuRelation4GoodLib.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4GoodLibEN.QuestionContent = objRow[convcc_WorkStuRelation4GoodLib.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelation4GoodLibEN.CourseChapterId = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4GoodLibEN.CourseChapterName = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4GoodLibEN.ChapterName = objRow[convcc_WorkStuRelation4GoodLib.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4GoodLibEN.SectionName = objRow[convcc_WorkStuRelation4GoodLib.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4GoodLibEN.ChapterNameSim = objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4GoodLibEN.SectionNameSim = objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeID = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4GoodLibEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeName = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4GoodLibEN.SourceTypeName = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName].ToString().Trim(); //来源类型名称
objvcc_WorkStuRelation4GoodLibEN.QuestionID = objRow[convcc_WorkStuRelation4GoodLib.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4GoodLibEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4GoodLib.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4GoodLibEN.CourseId = objRow[convcc_WorkStuRelation4GoodLib.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4GoodLibEN.IdStudentInfo = objRow[convcc_WorkStuRelation4GoodLib.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4GoodLibEN.Creator = objRow[convcc_WorkStuRelation4GoodLib.Creator] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Creator].ToString().Trim(); //创建者
objvcc_WorkStuRelation4GoodLibEN.CreateDate = objRow[convcc_WorkStuRelation4GoodLib.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkStuRelation4GoodLibEN.SourceTypeId = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeId].ToString().Trim(); //来源类型Id
objvcc_WorkStuRelation4GoodLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4GoodLib.IsRedo].ToString().Trim()); //是否重做
objvcc_WorkStuRelation4GoodLibEN.RedoDate = objRow[convcc_WorkStuRelation4GoodLib.RedoDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.RedoDate].ToString().Trim(); //重做日期
objvcc_WorkStuRelation4GoodLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4GoodLib.IsPassed].ToString().Trim()); //是否通过
objvcc_WorkStuRelation4GoodLibEN.UpdDate = objRow[convcc_WorkStuRelation4GoodLib.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4GoodLibEN.UpdUser = objRow[convcc_WorkStuRelation4GoodLib.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4GoodLibEN.Memo = objRow[convcc_WorkStuRelation4GoodLib.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelation4GoodLibEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelation4GoodLibEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcc_WorkStuRelation4GoodLibEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcc_WorkStuRelation4GoodLibEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_WorkStuRelation4GoodLibEN> arrObjLst = new List<clsvcc_WorkStuRelation4GoodLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN = new clsvcc_WorkStuRelation4GoodLibEN();
try
{
objvcc_WorkStuRelation4GoodLibEN.CourseName = objRow[convcc_WorkStuRelation4GoodLib.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4GoodLibEN.StuID = objRow[convcc_WorkStuRelation4GoodLib.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4GoodLibEN.StuName = objRow[convcc_WorkStuRelation4GoodLib.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4GoodLibEN.IdXzCollege = objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4GoodLibEN.CollegeName = objRow[convcc_WorkStuRelation4GoodLib.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4GoodLibEN.CollegeNameA = objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4GoodLibEN.IdXzMajor = objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4GoodLibEN.MajorID = objRow[convcc_WorkStuRelation4GoodLib.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4GoodLibEN.MajorName = objRow[convcc_WorkStuRelation4GoodLib.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4GoodLibEN.IdGradeBase = objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4GoodLibEN.GradeBaseName = objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4GoodLibEN.QuestionIndex = objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4GoodLibEN.QuestionName = objRow[convcc_WorkStuRelation4GoodLib.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4GoodLibEN.QuestionContent = objRow[convcc_WorkStuRelation4GoodLib.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelation4GoodLibEN.CourseChapterId = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4GoodLibEN.CourseChapterName = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4GoodLibEN.ChapterName = objRow[convcc_WorkStuRelation4GoodLib.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4GoodLibEN.SectionName = objRow[convcc_WorkStuRelation4GoodLib.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4GoodLibEN.ChapterNameSim = objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4GoodLibEN.SectionNameSim = objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeID = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4GoodLibEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeName = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4GoodLibEN.SourceTypeName = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName].ToString().Trim(); //来源类型名称
objvcc_WorkStuRelation4GoodLibEN.QuestionID = objRow[convcc_WorkStuRelation4GoodLib.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4GoodLibEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4GoodLib.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4GoodLibEN.CourseId = objRow[convcc_WorkStuRelation4GoodLib.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4GoodLibEN.IdStudentInfo = objRow[convcc_WorkStuRelation4GoodLib.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4GoodLibEN.Creator = objRow[convcc_WorkStuRelation4GoodLib.Creator] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Creator].ToString().Trim(); //创建者
objvcc_WorkStuRelation4GoodLibEN.CreateDate = objRow[convcc_WorkStuRelation4GoodLib.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkStuRelation4GoodLibEN.SourceTypeId = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeId].ToString().Trim(); //来源类型Id
objvcc_WorkStuRelation4GoodLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4GoodLib.IsRedo].ToString().Trim()); //是否重做
objvcc_WorkStuRelation4GoodLibEN.RedoDate = objRow[convcc_WorkStuRelation4GoodLib.RedoDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.RedoDate].ToString().Trim(); //重做日期
objvcc_WorkStuRelation4GoodLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4GoodLib.IsPassed].ToString().Trim()); //是否通过
objvcc_WorkStuRelation4GoodLibEN.UpdDate = objRow[convcc_WorkStuRelation4GoodLib.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4GoodLibEN.UpdUser = objRow[convcc_WorkStuRelation4GoodLib.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4GoodLibEN.Memo = objRow[convcc_WorkStuRelation4GoodLib.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelation4GoodLibEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelation4GoodLibEN);
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
public static List<clsvcc_WorkStuRelation4GoodLibEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcc_WorkStuRelation4GoodLibEN> arrObjLst = new List<clsvcc_WorkStuRelation4GoodLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN = new clsvcc_WorkStuRelation4GoodLibEN();
try
{
objvcc_WorkStuRelation4GoodLibEN.CourseName = objRow[convcc_WorkStuRelation4GoodLib.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4GoodLibEN.StuID = objRow[convcc_WorkStuRelation4GoodLib.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4GoodLibEN.StuName = objRow[convcc_WorkStuRelation4GoodLib.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4GoodLibEN.IdXzCollege = objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4GoodLibEN.CollegeName = objRow[convcc_WorkStuRelation4GoodLib.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4GoodLibEN.CollegeNameA = objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4GoodLibEN.IdXzMajor = objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4GoodLibEN.MajorID = objRow[convcc_WorkStuRelation4GoodLib.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4GoodLibEN.MajorName = objRow[convcc_WorkStuRelation4GoodLib.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4GoodLibEN.IdGradeBase = objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4GoodLibEN.GradeBaseName = objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4GoodLibEN.QuestionIndex = objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4GoodLibEN.QuestionName = objRow[convcc_WorkStuRelation4GoodLib.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4GoodLibEN.QuestionContent = objRow[convcc_WorkStuRelation4GoodLib.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelation4GoodLibEN.CourseChapterId = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4GoodLibEN.CourseChapterName = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4GoodLibEN.ChapterName = objRow[convcc_WorkStuRelation4GoodLib.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4GoodLibEN.SectionName = objRow[convcc_WorkStuRelation4GoodLib.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4GoodLibEN.ChapterNameSim = objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4GoodLibEN.SectionNameSim = objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeID = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4GoodLibEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeName = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4GoodLibEN.SourceTypeName = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName].ToString().Trim(); //来源类型名称
objvcc_WorkStuRelation4GoodLibEN.QuestionID = objRow[convcc_WorkStuRelation4GoodLib.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4GoodLibEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4GoodLib.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4GoodLibEN.CourseId = objRow[convcc_WorkStuRelation4GoodLib.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4GoodLibEN.IdStudentInfo = objRow[convcc_WorkStuRelation4GoodLib.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4GoodLibEN.Creator = objRow[convcc_WorkStuRelation4GoodLib.Creator] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Creator].ToString().Trim(); //创建者
objvcc_WorkStuRelation4GoodLibEN.CreateDate = objRow[convcc_WorkStuRelation4GoodLib.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkStuRelation4GoodLibEN.SourceTypeId = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeId].ToString().Trim(); //来源类型Id
objvcc_WorkStuRelation4GoodLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4GoodLib.IsRedo].ToString().Trim()); //是否重做
objvcc_WorkStuRelation4GoodLibEN.RedoDate = objRow[convcc_WorkStuRelation4GoodLib.RedoDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.RedoDate].ToString().Trim(); //重做日期
objvcc_WorkStuRelation4GoodLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4GoodLib.IsPassed].ToString().Trim()); //是否通过
objvcc_WorkStuRelation4GoodLibEN.UpdDate = objRow[convcc_WorkStuRelation4GoodLib.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4GoodLibEN.UpdUser = objRow[convcc_WorkStuRelation4GoodLib.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4GoodLibEN.Memo = objRow[convcc_WorkStuRelation4GoodLib.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelation4GoodLibEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelation4GoodLibEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelation4GoodLibEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcc_WorkStuRelation4GoodLibEN> arrObjLst = new List<clsvcc_WorkStuRelation4GoodLibEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN = new clsvcc_WorkStuRelation4GoodLibEN();
try
{
objvcc_WorkStuRelation4GoodLibEN.CourseName = objRow[convcc_WorkStuRelation4GoodLib.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4GoodLibEN.StuID = objRow[convcc_WorkStuRelation4GoodLib.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4GoodLibEN.StuName = objRow[convcc_WorkStuRelation4GoodLib.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4GoodLibEN.IdXzCollege = objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4GoodLibEN.CollegeName = objRow[convcc_WorkStuRelation4GoodLib.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4GoodLibEN.CollegeNameA = objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4GoodLibEN.IdXzMajor = objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4GoodLibEN.MajorID = objRow[convcc_WorkStuRelation4GoodLib.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4GoodLibEN.MajorName = objRow[convcc_WorkStuRelation4GoodLib.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4GoodLibEN.IdGradeBase = objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4GoodLibEN.GradeBaseName = objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4GoodLibEN.QuestionIndex = objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4GoodLibEN.QuestionName = objRow[convcc_WorkStuRelation4GoodLib.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4GoodLibEN.QuestionContent = objRow[convcc_WorkStuRelation4GoodLib.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelation4GoodLibEN.CourseChapterId = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4GoodLibEN.CourseChapterName = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4GoodLibEN.ChapterName = objRow[convcc_WorkStuRelation4GoodLib.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4GoodLibEN.SectionName = objRow[convcc_WorkStuRelation4GoodLib.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4GoodLibEN.ChapterNameSim = objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4GoodLibEN.SectionNameSim = objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeID = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4GoodLibEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeName = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4GoodLibEN.SourceTypeName = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName].ToString().Trim(); //来源类型名称
objvcc_WorkStuRelation4GoodLibEN.QuestionID = objRow[convcc_WorkStuRelation4GoodLib.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4GoodLibEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4GoodLib.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4GoodLibEN.CourseId = objRow[convcc_WorkStuRelation4GoodLib.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4GoodLibEN.IdStudentInfo = objRow[convcc_WorkStuRelation4GoodLib.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4GoodLibEN.Creator = objRow[convcc_WorkStuRelation4GoodLib.Creator] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Creator].ToString().Trim(); //创建者
objvcc_WorkStuRelation4GoodLibEN.CreateDate = objRow[convcc_WorkStuRelation4GoodLib.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkStuRelation4GoodLibEN.SourceTypeId = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeId].ToString().Trim(); //来源类型Id
objvcc_WorkStuRelation4GoodLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4GoodLib.IsRedo].ToString().Trim()); //是否重做
objvcc_WorkStuRelation4GoodLibEN.RedoDate = objRow[convcc_WorkStuRelation4GoodLib.RedoDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.RedoDate].ToString().Trim(); //重做日期
objvcc_WorkStuRelation4GoodLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4GoodLib.IsPassed].ToString().Trim()); //是否通过
objvcc_WorkStuRelation4GoodLibEN.UpdDate = objRow[convcc_WorkStuRelation4GoodLib.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4GoodLibEN.UpdUser = objRow[convcc_WorkStuRelation4GoodLib.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4GoodLibEN.Memo = objRow[convcc_WorkStuRelation4GoodLib.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelation4GoodLibEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelation4GoodLibEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcc_WorkStuRelation4GoodLib(ref clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN)
{
bool bolResult = vcc_WorkStuRelation4GoodLibDA.Getvcc_WorkStuRelation4GoodLib(ref objvcc_WorkStuRelation4GoodLibEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkStuRelation4GoodLibEN GetObjBymId(long lngmId)
{
clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN = vcc_WorkStuRelation4GoodLibDA.GetObjBymId(lngmId);
return objvcc_WorkStuRelation4GoodLibEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcc_WorkStuRelation4GoodLibEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN = vcc_WorkStuRelation4GoodLibDA.GetFirstObj(strWhereCond);
 return objvcc_WorkStuRelation4GoodLibEN;
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
public static clsvcc_WorkStuRelation4GoodLibEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN = vcc_WorkStuRelation4GoodLibDA.GetObjByDataRow(objRow);
 return objvcc_WorkStuRelation4GoodLibEN;
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
public static clsvcc_WorkStuRelation4GoodLibEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN = vcc_WorkStuRelation4GoodLibDA.GetObjByDataRow(objRow);
 return objvcc_WorkStuRelation4GoodLibEN;
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
 /// <param name = "lstvcc_WorkStuRelation4GoodLibObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_WorkStuRelation4GoodLibEN GetObjBymIdFromList(long lngmId, List<clsvcc_WorkStuRelation4GoodLibEN> lstvcc_WorkStuRelation4GoodLibObjLst)
{
foreach (clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN in lstvcc_WorkStuRelation4GoodLibObjLst)
{
if (objvcc_WorkStuRelation4GoodLibEN.mId == lngmId)
{
return objvcc_WorkStuRelation4GoodLibEN;
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
 lngmId = new clsvcc_WorkStuRelation4GoodLibDA().GetFirstID(strWhereCond);
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
 arrList = vcc_WorkStuRelation4GoodLibDA.GetID(strWhereCond);
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
bool bolIsExist = vcc_WorkStuRelation4GoodLibDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vcc_WorkStuRelation4GoodLibDA.IsExist(lngmId);
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
 bolIsExist = clsvcc_WorkStuRelation4GoodLibDA.IsExistTable();
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
 bolIsExist = vcc_WorkStuRelation4GoodLibDA.IsExistTable(strTabName);
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
 /// <param name = "objvcc_WorkStuRelation4GoodLibENS">源对象</param>
 /// <param name = "objvcc_WorkStuRelation4GoodLibENT">目标对象</param>
 public static void CopyTo(clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibENS, clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibENT)
{
try
{
objvcc_WorkStuRelation4GoodLibENT.CourseName = objvcc_WorkStuRelation4GoodLibENS.CourseName; //课程名称
objvcc_WorkStuRelation4GoodLibENT.StuID = objvcc_WorkStuRelation4GoodLibENS.StuID; //学号
objvcc_WorkStuRelation4GoodLibENT.StuName = objvcc_WorkStuRelation4GoodLibENS.StuName; //姓名
objvcc_WorkStuRelation4GoodLibENT.IdXzCollege = objvcc_WorkStuRelation4GoodLibENS.IdXzCollege; //学院流水号
objvcc_WorkStuRelation4GoodLibENT.CollegeName = objvcc_WorkStuRelation4GoodLibENS.CollegeName; //学院名称
objvcc_WorkStuRelation4GoodLibENT.CollegeNameA = objvcc_WorkStuRelation4GoodLibENS.CollegeNameA; //学院名称简写
objvcc_WorkStuRelation4GoodLibENT.IdXzMajor = objvcc_WorkStuRelation4GoodLibENS.IdXzMajor; //专业流水号
objvcc_WorkStuRelation4GoodLibENT.MajorID = objvcc_WorkStuRelation4GoodLibENS.MajorID; //专业ID
objvcc_WorkStuRelation4GoodLibENT.MajorName = objvcc_WorkStuRelation4GoodLibENS.MajorName; //专业名称
objvcc_WorkStuRelation4GoodLibENT.IdGradeBase = objvcc_WorkStuRelation4GoodLibENS.IdGradeBase; //年级流水号
objvcc_WorkStuRelation4GoodLibENT.GradeBaseName = objvcc_WorkStuRelation4GoodLibENS.GradeBaseName; //年级名称
objvcc_WorkStuRelation4GoodLibENT.QuestionIndex = objvcc_WorkStuRelation4GoodLibENS.QuestionIndex; //题目序号
objvcc_WorkStuRelation4GoodLibENT.QuestionName = objvcc_WorkStuRelation4GoodLibENS.QuestionName; //题目名称
objvcc_WorkStuRelation4GoodLibENT.QuestionContent = objvcc_WorkStuRelation4GoodLibENS.QuestionContent; //题目内容
objvcc_WorkStuRelation4GoodLibENT.CourseChapterId = objvcc_WorkStuRelation4GoodLibENS.CourseChapterId; //课程章节ID
objvcc_WorkStuRelation4GoodLibENT.CourseChapterName = objvcc_WorkStuRelation4GoodLibENS.CourseChapterName; //课程章节名称
objvcc_WorkStuRelation4GoodLibENT.ChapterName = objvcc_WorkStuRelation4GoodLibENS.ChapterName; //章名
objvcc_WorkStuRelation4GoodLibENT.SectionName = objvcc_WorkStuRelation4GoodLibENS.SectionName; //节名
objvcc_WorkStuRelation4GoodLibENT.ChapterNameSim = objvcc_WorkStuRelation4GoodLibENS.ChapterNameSim; //章名简称
objvcc_WorkStuRelation4GoodLibENT.SectionNameSim = objvcc_WorkStuRelation4GoodLibENS.SectionNameSim; //节名简称
objvcc_WorkStuRelation4GoodLibENT.ParentNodeID = objvcc_WorkStuRelation4GoodLibENS.ParentNodeID; //父节点编号
objvcc_WorkStuRelation4GoodLibENT.CourseChapterReferred = objvcc_WorkStuRelation4GoodLibENS.CourseChapterReferred; //节简称
objvcc_WorkStuRelation4GoodLibENT.ParentNodeName = objvcc_WorkStuRelation4GoodLibENS.ParentNodeName; //父节点名称
objvcc_WorkStuRelation4GoodLibENT.ParentNodeReferred = objvcc_WorkStuRelation4GoodLibENS.ParentNodeReferred; //章简称
objvcc_WorkStuRelation4GoodLibENT.SourceTypeName = objvcc_WorkStuRelation4GoodLibENS.SourceTypeName; //来源类型名称
objvcc_WorkStuRelation4GoodLibENT.QuestionID = objvcc_WorkStuRelation4GoodLibENS.QuestionID; //题目ID
objvcc_WorkStuRelation4GoodLibENT.mId = objvcc_WorkStuRelation4GoodLibENS.mId; //mId
objvcc_WorkStuRelation4GoodLibENT.CourseId = objvcc_WorkStuRelation4GoodLibENS.CourseId; //课程Id
objvcc_WorkStuRelation4GoodLibENT.IdStudentInfo = objvcc_WorkStuRelation4GoodLibENS.IdStudentInfo; //学生流水号
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
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">源简化对象</param>
 public static void SetUpdFlag(clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN)
{
try
{
objvcc_WorkStuRelation4GoodLibEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcc_WorkStuRelation4GoodLibEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.CourseName = objvcc_WorkStuRelation4GoodLibEN.CourseName == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.StuID, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.StuID = objvcc_WorkStuRelation4GoodLibEN.StuID == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.StuID; //学号
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.StuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.StuName = objvcc_WorkStuRelation4GoodLibEN.StuName == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.StuName; //姓名
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.IdXzCollege = objvcc_WorkStuRelation4GoodLibEN.IdXzCollege == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.CollegeName = objvcc_WorkStuRelation4GoodLibEN.CollegeName == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.CollegeNameA = objvcc_WorkStuRelation4GoodLibEN.CollegeNameA == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.IdXzMajor = objvcc_WorkStuRelation4GoodLibEN.IdXzMajor == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.MajorID, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.MajorID = objvcc_WorkStuRelation4GoodLibEN.MajorID == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.MajorID; //专业ID
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.MajorName = objvcc_WorkStuRelation4GoodLibEN.MajorName == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.IdGradeBase = objvcc_WorkStuRelation4GoodLibEN.IdGradeBase == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.GradeBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.GradeBaseName = objvcc_WorkStuRelation4GoodLibEN.GradeBaseName == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.GradeBaseName; //年级名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.QuestionIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.QuestionIndex = objvcc_WorkStuRelation4GoodLibEN.QuestionIndex; //题目序号
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.QuestionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.QuestionName = objvcc_WorkStuRelation4GoodLibEN.QuestionName == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.QuestionName; //题目名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.QuestionContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.QuestionContent = objvcc_WorkStuRelation4GoodLibEN.QuestionContent == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.QuestionContent; //题目内容
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.CourseChapterId = objvcc_WorkStuRelation4GoodLibEN.CourseChapterId == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.CourseChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.CourseChapterName = objvcc_WorkStuRelation4GoodLibEN.CourseChapterName == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.CourseChapterName; //课程章节名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.ChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.ChapterName = objvcc_WorkStuRelation4GoodLibEN.ChapterName == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.ChapterName; //章名
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.SectionName = objvcc_WorkStuRelation4GoodLibEN.SectionName == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.SectionName; //节名
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.ChapterNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.ChapterNameSim = objvcc_WorkStuRelation4GoodLibEN.ChapterNameSim == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.ChapterNameSim; //章名简称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.SectionNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.SectionNameSim = objvcc_WorkStuRelation4GoodLibEN.SectionNameSim == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.SectionNameSim; //节名简称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.ParentNodeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.ParentNodeID = objvcc_WorkStuRelation4GoodLibEN.ParentNodeID == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.ParentNodeID; //父节点编号
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.CourseChapterReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.CourseChapterReferred = objvcc_WorkStuRelation4GoodLibEN.CourseChapterReferred == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.CourseChapterReferred; //节简称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.ParentNodeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.ParentNodeName = objvcc_WorkStuRelation4GoodLibEN.ParentNodeName == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.ParentNodeName; //父节点名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.ParentNodeReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.ParentNodeReferred = objvcc_WorkStuRelation4GoodLibEN.ParentNodeReferred == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.ParentNodeReferred; //章简称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.SourceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.SourceTypeName = objvcc_WorkStuRelation4GoodLibEN.SourceTypeName == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.SourceTypeName; //来源类型名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.QuestionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.QuestionID = objvcc_WorkStuRelation4GoodLibEN.QuestionID == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.QuestionID; //题目ID
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.mId = objvcc_WorkStuRelation4GoodLibEN.mId; //mId
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.CourseId = objvcc_WorkStuRelation4GoodLibEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.IdStudentInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.IdStudentInfo = objvcc_WorkStuRelation4GoodLibEN.IdStudentInfo; //学生流水号
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.Creator, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.Creator = objvcc_WorkStuRelation4GoodLibEN.Creator == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.Creator; //创建者
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.CreateDate = objvcc_WorkStuRelation4GoodLibEN.CreateDate == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.SourceTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.SourceTypeId = objvcc_WorkStuRelation4GoodLibEN.SourceTypeId; //来源类型Id
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.IsRedo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.IsRedo = objvcc_WorkStuRelation4GoodLibEN.IsRedo; //是否重做
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.RedoDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.RedoDate = objvcc_WorkStuRelation4GoodLibEN.RedoDate == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.RedoDate; //重做日期
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.IsPassed, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.IsPassed = objvcc_WorkStuRelation4GoodLibEN.IsPassed; //是否通过
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.UpdDate = objvcc_WorkStuRelation4GoodLibEN.UpdDate == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.UpdUser = objvcc_WorkStuRelation4GoodLibEN.UpdUser == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convcc_WorkStuRelation4GoodLib.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelation4GoodLibEN.Memo = objvcc_WorkStuRelation4GoodLibEN.Memo == "[null]" ? null :  objvcc_WorkStuRelation4GoodLibEN.Memo; //备注
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
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN)
{
try
{
if (objvcc_WorkStuRelation4GoodLibEN.CourseName == "[null]") objvcc_WorkStuRelation4GoodLibEN.CourseName = null; //课程名称
if (objvcc_WorkStuRelation4GoodLibEN.StuID == "[null]") objvcc_WorkStuRelation4GoodLibEN.StuID = null; //学号
if (objvcc_WorkStuRelation4GoodLibEN.StuName == "[null]") objvcc_WorkStuRelation4GoodLibEN.StuName = null; //姓名
if (objvcc_WorkStuRelation4GoodLibEN.IdXzCollege == "[null]") objvcc_WorkStuRelation4GoodLibEN.IdXzCollege = null; //学院流水号
if (objvcc_WorkStuRelation4GoodLibEN.CollegeName == "[null]") objvcc_WorkStuRelation4GoodLibEN.CollegeName = null; //学院名称
if (objvcc_WorkStuRelation4GoodLibEN.CollegeNameA == "[null]") objvcc_WorkStuRelation4GoodLibEN.CollegeNameA = null; //学院名称简写
if (objvcc_WorkStuRelation4GoodLibEN.IdXzMajor == "[null]") objvcc_WorkStuRelation4GoodLibEN.IdXzMajor = null; //专业流水号
if (objvcc_WorkStuRelation4GoodLibEN.MajorID == "[null]") objvcc_WorkStuRelation4GoodLibEN.MajorID = null; //专业ID
if (objvcc_WorkStuRelation4GoodLibEN.MajorName == "[null]") objvcc_WorkStuRelation4GoodLibEN.MajorName = null; //专业名称
if (objvcc_WorkStuRelation4GoodLibEN.IdGradeBase == "[null]") objvcc_WorkStuRelation4GoodLibEN.IdGradeBase = null; //年级流水号
if (objvcc_WorkStuRelation4GoodLibEN.GradeBaseName == "[null]") objvcc_WorkStuRelation4GoodLibEN.GradeBaseName = null; //年级名称
if (objvcc_WorkStuRelation4GoodLibEN.QuestionName == "[null]") objvcc_WorkStuRelation4GoodLibEN.QuestionName = null; //题目名称
if (objvcc_WorkStuRelation4GoodLibEN.QuestionContent == "[null]") objvcc_WorkStuRelation4GoodLibEN.QuestionContent = null; //题目内容
if (objvcc_WorkStuRelation4GoodLibEN.CourseChapterId == "[null]") objvcc_WorkStuRelation4GoodLibEN.CourseChapterId = null; //课程章节ID
if (objvcc_WorkStuRelation4GoodLibEN.CourseChapterName == "[null]") objvcc_WorkStuRelation4GoodLibEN.CourseChapterName = null; //课程章节名称
if (objvcc_WorkStuRelation4GoodLibEN.ChapterName == "[null]") objvcc_WorkStuRelation4GoodLibEN.ChapterName = null; //章名
if (objvcc_WorkStuRelation4GoodLibEN.SectionName == "[null]") objvcc_WorkStuRelation4GoodLibEN.SectionName = null; //节名
if (objvcc_WorkStuRelation4GoodLibEN.ChapterNameSim == "[null]") objvcc_WorkStuRelation4GoodLibEN.ChapterNameSim = null; //章名简称
if (objvcc_WorkStuRelation4GoodLibEN.SectionNameSim == "[null]") objvcc_WorkStuRelation4GoodLibEN.SectionNameSim = null; //节名简称
if (objvcc_WorkStuRelation4GoodLibEN.ParentNodeID == "[null]") objvcc_WorkStuRelation4GoodLibEN.ParentNodeID = null; //父节点编号
if (objvcc_WorkStuRelation4GoodLibEN.CourseChapterReferred == "[null]") objvcc_WorkStuRelation4GoodLibEN.CourseChapterReferred = null; //节简称
if (objvcc_WorkStuRelation4GoodLibEN.ParentNodeName == "[null]") objvcc_WorkStuRelation4GoodLibEN.ParentNodeName = null; //父节点名称
if (objvcc_WorkStuRelation4GoodLibEN.ParentNodeReferred == "[null]") objvcc_WorkStuRelation4GoodLibEN.ParentNodeReferred = null; //章简称
if (objvcc_WorkStuRelation4GoodLibEN.SourceTypeName == "[null]") objvcc_WorkStuRelation4GoodLibEN.SourceTypeName = null; //来源类型名称
if (objvcc_WorkStuRelation4GoodLibEN.QuestionID == "[null]") objvcc_WorkStuRelation4GoodLibEN.QuestionID = null; //题目ID
if (objvcc_WorkStuRelation4GoodLibEN.Creator == "[null]") objvcc_WorkStuRelation4GoodLibEN.Creator = null; //创建者
if (objvcc_WorkStuRelation4GoodLibEN.CreateDate == "[null]") objvcc_WorkStuRelation4GoodLibEN.CreateDate = null; //建立日期
if (objvcc_WorkStuRelation4GoodLibEN.RedoDate == "[null]") objvcc_WorkStuRelation4GoodLibEN.RedoDate = null; //重做日期
if (objvcc_WorkStuRelation4GoodLibEN.UpdDate == "[null]") objvcc_WorkStuRelation4GoodLibEN.UpdDate = null; //修改日期
if (objvcc_WorkStuRelation4GoodLibEN.UpdUser == "[null]") objvcc_WorkStuRelation4GoodLibEN.UpdUser = null; //修改人
if (objvcc_WorkStuRelation4GoodLibEN.Memo == "[null]") objvcc_WorkStuRelation4GoodLibEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN)
{
 vcc_WorkStuRelation4GoodLibDA.CheckProperty4Condition(objvcc_WorkStuRelation4GoodLibEN);
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
if (clsSourceTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSourceTypeBL没有刷新缓存机制(clsSourceTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_WorkStuRelation4GoodLibBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkStuRelation4GoodLibBL没有刷新缓存机制(clscc_WorkStuRelation4GoodLibBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvcc_WorkStuRelation4GoodLibObjLstCache == null)
//{
//arrvcc_WorkStuRelation4GoodLibObjLstCache = vcc_WorkStuRelation4GoodLibDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_WorkStuRelation4GoodLibEN GetObjBymIdCache(long lngmId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvcc_WorkStuRelation4GoodLibEN._CurrTabName, strCourseId);
List<clsvcc_WorkStuRelation4GoodLibEN> arrvcc_WorkStuRelation4GoodLibObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_WorkStuRelation4GoodLibEN> arrvcc_WorkStuRelation4GoodLibObjLst_Sel =
arrvcc_WorkStuRelation4GoodLibObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvcc_WorkStuRelation4GoodLibObjLst_Sel.Count() == 0)
{
   clsvcc_WorkStuRelation4GoodLibEN obj = clsvcc_WorkStuRelation4GoodLibBL.GetObjBymId(lngmId);
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
return arrvcc_WorkStuRelation4GoodLibObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_WorkStuRelation4GoodLibEN> GetAllvcc_WorkStuRelation4GoodLibObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsvcc_WorkStuRelation4GoodLibEN> arrvcc_WorkStuRelation4GoodLibObjLstCache = GetObjLstCache(strCourseId); 
return arrvcc_WorkStuRelation4GoodLibObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_WorkStuRelation4GoodLibEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvcc_WorkStuRelation4GoodLibEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsvcc_WorkStuRelation4GoodLibEN> arrvcc_WorkStuRelation4GoodLibObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvcc_WorkStuRelation4GoodLibObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvcc_WorkStuRelation4GoodLibEN._CurrTabName, strCourseId);
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
if (strInFldName != convcc_WorkStuRelation4GoodLib.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcc_WorkStuRelation4GoodLib.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcc_WorkStuRelation4GoodLib.AttributeName));
throw new Exception(strMsg);
}
var objvcc_WorkStuRelation4GoodLib = clsvcc_WorkStuRelation4GoodLibBL.GetObjBymIdCache(lngmId, strCourseId);
if (objvcc_WorkStuRelation4GoodLib == null) return "";
return objvcc_WorkStuRelation4GoodLib[strOutFldName].ToString();
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
int intRecCount = clsvcc_WorkStuRelation4GoodLibDA.GetRecCount(strTabName);
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
int intRecCount = clsvcc_WorkStuRelation4GoodLibDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcc_WorkStuRelation4GoodLibDA.GetRecCount();
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
int intRecCount = clsvcc_WorkStuRelation4GoodLibDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibCond)
{
 string strCourseId = objvcc_WorkStuRelation4GoodLibCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvcc_WorkStuRelation4GoodLibBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvcc_WorkStuRelation4GoodLibEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_WorkStuRelation4GoodLibEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_WorkStuRelation4GoodLib.AttributeName)
{
if (objvcc_WorkStuRelation4GoodLibCond.IsUpdated(strFldName) == false) continue;
if (objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkStuRelation4GoodLibCond[strFldName].ToString());
}
else
{
if (objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_WorkStuRelation4GoodLibCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkStuRelation4GoodLibCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_WorkStuRelation4GoodLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_WorkStuRelation4GoodLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_WorkStuRelation4GoodLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_WorkStuRelation4GoodLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_WorkStuRelation4GoodLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_WorkStuRelation4GoodLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_WorkStuRelation4GoodLibCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_WorkStuRelation4GoodLibCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_WorkStuRelation4GoodLibCond[strFldName]));
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
 List<string> arrList = clsvcc_WorkStuRelation4GoodLibDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcc_WorkStuRelation4GoodLibDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcc_WorkStuRelation4GoodLibDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}