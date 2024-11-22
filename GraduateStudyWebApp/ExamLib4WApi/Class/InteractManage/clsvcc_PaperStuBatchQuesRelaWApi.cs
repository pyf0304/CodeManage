
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_PaperStuBatchQuesRelaWApi
 表名:vcc_PaperStuBatchQuesRela(01120241)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:40:30
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
public static class clsvcc_PaperStuBatchQuesRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetId_PaperStuBatchQuesRela(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, long lngId_PaperStuBatchQuesRela, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRelaEN.Id_PaperStuBatchQuesRela = lngId_PaperStuBatchQuesRela; //学生批次题目关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.Id_PaperStuBatchQuesRela) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.Id_PaperStuBatchQuesRela, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.Id_PaperStuBatchQuesRela] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetId_PaperStuBatch(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strId_PaperStuBatch, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strId_PaperStuBatch, convcc_PaperStuBatchQuesRela.Id_PaperStuBatch);
clsCheckSql.CheckFieldLen(strId_PaperStuBatch, 10, convcc_PaperStuBatchQuesRela.Id_PaperStuBatch);
clsCheckSql.CheckFieldForeignKey(strId_PaperStuBatch, 10, convcc_PaperStuBatchQuesRela.Id_PaperStuBatch);
objvcc_PaperStuBatchQuesRelaEN.Id_PaperStuBatch = strId_PaperStuBatch; //学生试卷批次流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.Id_PaperStuBatch) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.Id_PaperStuBatch, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.Id_PaperStuBatch] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetCourseExamPaperId(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, convcc_PaperStuBatchQuesRela.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, convcc_PaperStuBatchQuesRela.CourseExamPaperId);
objvcc_PaperStuBatchQuesRelaEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.CourseExamPaperId) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.CourseExamPaperId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.CourseExamPaperId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetExamPaperName(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strExamPaperName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamPaperName, 500, convcc_PaperStuBatchQuesRela.ExamPaperName);
objvcc_PaperStuBatchQuesRelaEN.ExamPaperName = strExamPaperName; //考卷名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.ExamPaperName) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.ExamPaperName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.ExamPaperName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetExamPaperTypeId(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strExamPaperTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strExamPaperTypeId, convcc_PaperStuBatchQuesRela.ExamPaperTypeId);
clsCheckSql.CheckFieldLen(strExamPaperTypeId, 2, convcc_PaperStuBatchQuesRela.ExamPaperTypeId);
clsCheckSql.CheckFieldForeignKey(strExamPaperTypeId, 2, convcc_PaperStuBatchQuesRela.ExamPaperTypeId);
objvcc_PaperStuBatchQuesRelaEN.ExamPaperTypeId = strExamPaperTypeId; //试卷类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.ExamPaperTypeId) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.ExamPaperTypeId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.ExamPaperTypeId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN Setid_StudentInfo(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, convcc_PaperStuBatchQuesRela.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, convcc_PaperStuBatchQuesRela.id_StudentInfo);
objvcc_PaperStuBatchQuesRelaEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.id_StudentInfo) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.id_StudentInfo, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.id_StudentInfo] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetStuID(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convcc_PaperStuBatchQuesRela.StuID);
objvcc_PaperStuBatchQuesRelaEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.StuID) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.StuID, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.StuID] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetStuName(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convcc_PaperStuBatchQuesRela.StuName);
objvcc_PaperStuBatchQuesRelaEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.StuName) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.StuName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.StuName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN Setid_XzCollege(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convcc_PaperStuBatchQuesRela.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convcc_PaperStuBatchQuesRela.id_XzCollege);
objvcc_PaperStuBatchQuesRelaEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.id_XzCollege) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.id_XzCollege, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.id_XzCollege] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetCollegeName(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convcc_PaperStuBatchQuesRela.CollegeName);
clsCheckSql.CheckFieldLen(strCollegeName, 100, convcc_PaperStuBatchQuesRela.CollegeName);
objvcc_PaperStuBatchQuesRelaEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.CollegeName) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.CollegeName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.CollegeName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetCollegeNameA(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convcc_PaperStuBatchQuesRela.CollegeNameA);
objvcc_PaperStuBatchQuesRelaEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.CollegeNameA) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.CollegeNameA, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.CollegeNameA] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN Setid_XzMajor(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzMajor, convcc_PaperStuBatchQuesRela.id_XzMajor);
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convcc_PaperStuBatchQuesRela.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convcc_PaperStuBatchQuesRela.id_XzMajor);
objvcc_PaperStuBatchQuesRelaEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.id_XzMajor) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.id_XzMajor, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.id_XzMajor] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetMajorID(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorID, convcc_PaperStuBatchQuesRela.MajorID);
clsCheckSql.CheckFieldLen(strMajorID, 4, convcc_PaperStuBatchQuesRela.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convcc_PaperStuBatchQuesRela.MajorID);
objvcc_PaperStuBatchQuesRelaEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.MajorID) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.MajorID, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.MajorID] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetMajorName(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorName, convcc_PaperStuBatchQuesRela.MajorName);
clsCheckSql.CheckFieldLen(strMajorName, 100, convcc_PaperStuBatchQuesRela.MajorName);
objvcc_PaperStuBatchQuesRelaEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.MajorName) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.MajorName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.MajorName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN Setid_GradeBase(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convcc_PaperStuBatchQuesRela.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convcc_PaperStuBatchQuesRela.id_GradeBase);
objvcc_PaperStuBatchQuesRelaEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.id_GradeBase) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.id_GradeBase, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.id_GradeBase] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetGradeBaseName(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGradeBaseName, convcc_PaperStuBatchQuesRela.GradeBaseName);
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convcc_PaperStuBatchQuesRela.GradeBaseName);
objvcc_PaperStuBatchQuesRelaEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.GradeBaseName) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.GradeBaseName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.GradeBaseName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetAdminClsName(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strAdminClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, convcc_PaperStuBatchQuesRela.AdminClsName);
objvcc_PaperStuBatchQuesRelaEN.AdminClsName = strAdminClsName; //行政班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.AdminClsName) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.AdminClsName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.AdminClsName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetAdminClsId(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strAdminClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, convcc_PaperStuBatchQuesRela.AdminClsId);
objvcc_PaperStuBatchQuesRelaEN.AdminClsId = strAdminClsId; //行政班代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.AdminClsId) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.AdminClsId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.AdminClsId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetBatchTime(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strBatchTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBatchTime, 14, convcc_PaperStuBatchQuesRela.BatchTime);
objvcc_PaperStuBatchQuesRelaEN.BatchTime = strBatchTime; //批次
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.BatchTime) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.BatchTime, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.BatchTime] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN Setid_CurrEduCls(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convcc_PaperStuBatchQuesRela.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convcc_PaperStuBatchQuesRela.id_CurrEduCls);
objvcc_PaperStuBatchQuesRelaEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.id_CurrEduCls) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.id_CurrEduCls, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.id_CurrEduCls] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetEduClsName(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convcc_PaperStuBatchQuesRela.EduClsName);
objvcc_PaperStuBatchQuesRelaEN.EduClsName = strEduClsName; //教学班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.EduClsName) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.EduClsName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.EduClsName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetQuestionID(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionID, 8, convcc_PaperStuBatchQuesRela.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convcc_PaperStuBatchQuesRela.QuestionID);
objvcc_PaperStuBatchQuesRelaEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.QuestionID) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.QuestionID, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.QuestionID] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetQuestionIndex(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, int intQuestionIndex, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRelaEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.QuestionIndex) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.QuestionIndex, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.QuestionIndex] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetQuestionName(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strQuestionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionName, 1000, convcc_PaperStuBatchQuesRela.QuestionName);
objvcc_PaperStuBatchQuesRelaEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.QuestionName) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.QuestionName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.QuestionName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetQuestionContent(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strQuestionContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionContent, 4000, convcc_PaperStuBatchQuesRela.QuestionContent);
objvcc_PaperStuBatchQuesRelaEN.QuestionContent = strQuestionContent; //题目内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.QuestionContent) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.QuestionContent, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.QuestionContent] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetCourseId(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_PaperStuBatchQuesRela.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_PaperStuBatchQuesRela.CourseId);
objvcc_PaperStuBatchQuesRelaEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.CourseId) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.CourseId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.CourseId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetCourseName(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_PaperStuBatchQuesRela.CourseName);
objvcc_PaperStuBatchQuesRelaEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.CourseName) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.CourseName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.CourseName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetCourseChapterId(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, convcc_PaperStuBatchQuesRela.CourseChapterId);
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_PaperStuBatchQuesRela.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_PaperStuBatchQuesRela.CourseChapterId);
objvcc_PaperStuBatchQuesRelaEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.CourseChapterId) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.CourseChapterId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.CourseChapterId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetCourseChapterName(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterName, convcc_PaperStuBatchQuesRela.CourseChapterName);
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_PaperStuBatchQuesRela.CourseChapterName);
objvcc_PaperStuBatchQuesRelaEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.CourseChapterName) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.CourseChapterName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.CourseChapterName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetChapterName(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_PaperStuBatchQuesRela.ChapterName);
objvcc_PaperStuBatchQuesRelaEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.ChapterName) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.ChapterName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.ChapterName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetSectionName(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_PaperStuBatchQuesRela.SectionName);
objvcc_PaperStuBatchQuesRelaEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.SectionName) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.SectionName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.SectionName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetChapterName_Sim(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convcc_PaperStuBatchQuesRela.ChapterName_Sim);
objvcc_PaperStuBatchQuesRelaEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.ChapterName_Sim) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.ChapterName_Sim, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.ChapterName_Sim] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetSectionName_Sim(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, convcc_PaperStuBatchQuesRela.SectionName_Sim);
objvcc_PaperStuBatchQuesRelaEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.SectionName_Sim) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.SectionName_Sim, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.SectionName_Sim] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetParentNodeID(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convcc_PaperStuBatchQuesRela.ParentNodeID);
objvcc_PaperStuBatchQuesRelaEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.ParentNodeID) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.ParentNodeID, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.ParentNodeID] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetCourseChapterReferred(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strCourseChapterReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convcc_PaperStuBatchQuesRela.CourseChapterReferred);
objvcc_PaperStuBatchQuesRelaEN.CourseChapterReferred = strCourseChapterReferred; //节简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.CourseChapterReferred) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.CourseChapterReferred, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.CourseChapterReferred] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetParentNodeName(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strParentNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convcc_PaperStuBatchQuesRela.ParentNodeName);
objvcc_PaperStuBatchQuesRelaEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.ParentNodeName) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.ParentNodeName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.ParentNodeName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetParentNodeReferred(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strParentNodeReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convcc_PaperStuBatchQuesRela.ParentNodeReferred);
objvcc_PaperStuBatchQuesRelaEN.ParentNodeReferred = strParentNodeReferred; //章简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.ParentNodeReferred) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.ParentNodeReferred, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.ParentNodeReferred] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetQuestionTypeId(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convcc_PaperStuBatchQuesRela.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convcc_PaperStuBatchQuesRela.QuestionTypeId);
objvcc_PaperStuBatchQuesRelaEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.QuestionTypeId) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.QuestionTypeId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.QuestionTypeId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetQuestionTypeName(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strQuestionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convcc_PaperStuBatchQuesRela.QuestionTypeName);
objvcc_PaperStuBatchQuesRelaEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.QuestionTypeName) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.QuestionTypeName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.QuestionTypeName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetAnswerTypeId(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strAnswerTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convcc_PaperStuBatchQuesRela.AnswerTypeId);
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convcc_PaperStuBatchQuesRela.AnswerTypeId);
objvcc_PaperStuBatchQuesRelaEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.AnswerTypeId) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.AnswerTypeId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.AnswerTypeId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetDefaultValue(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strDefaultValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convcc_PaperStuBatchQuesRela.DefaultValue);
objvcc_PaperStuBatchQuesRelaEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.DefaultValue) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.DefaultValue, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.DefaultValue] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetTextDirectId(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strTextDirectId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTextDirectId, 4, convcc_PaperStuBatchQuesRela.TextDirectId);
clsCheckSql.CheckFieldForeignKey(strTextDirectId, 4, convcc_PaperStuBatchQuesRela.TextDirectId);
objvcc_PaperStuBatchQuesRelaEN.TextDirectId = strTextDirectId; //文本方向ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.TextDirectId) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.TextDirectId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.TextDirectId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetRelaEvent(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strRelaEvent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaEvent, 4000, convcc_PaperStuBatchQuesRela.RelaEvent);
objvcc_PaperStuBatchQuesRelaEN.RelaEvent = strRelaEvent; //相关事件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.RelaEvent) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.RelaEvent, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.RelaEvent] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetCheckBoxLimitCount(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, int intCheckBoxLimitCount, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRelaEN.CheckBoxLimitCount = intCheckBoxLimitCount; //复选框限制数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.CheckBoxLimitCount) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.CheckBoxLimitCount, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.CheckBoxLimitCount] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetAnswerAttLimitSize(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, long lngAnswerAttLimitSize, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRelaEN.AnswerAttLimitSize = lngAnswerAttLimitSize; //回答附件限制大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.AnswerAttLimitSize) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.AnswerAttLimitSize, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.AnswerAttLimitSize] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetLimitedResourceType(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strLimitedResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLimitedResourceType, 100, convcc_PaperStuBatchQuesRela.LimitedResourceType);
objvcc_PaperStuBatchQuesRelaEN.LimitedResourceType = strLimitedResourceType; //限制资源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.LimitedResourceType) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.LimitedResourceType, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.LimitedResourceType] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetQuestionIndex4Batch(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, int intQuestionIndex4Batch, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch = intQuestionIndex4Batch; //题序号4批次
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.QuestionIndex4Batch) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.QuestionIndex4Batch, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.QuestionIndex4Batch] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetScores(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, double dblScores, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRelaEN.Scores = dblScores; //分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.Scores) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.Scores, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.Scores] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetAnswerModeId(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strAnswerModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, convcc_PaperStuBatchQuesRela.AnswerModeId);
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, convcc_PaperStuBatchQuesRela.AnswerModeId);
objvcc_PaperStuBatchQuesRelaEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.AnswerModeId) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.AnswerModeId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.AnswerModeId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetAnswerOptionId(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strAnswerOptionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerOptionId, 8, convcc_PaperStuBatchQuesRela.AnswerOptionId);
clsCheckSql.CheckFieldForeignKey(strAnswerOptionId, 8, convcc_PaperStuBatchQuesRela.AnswerOptionId);
objvcc_PaperStuBatchQuesRelaEN.AnswerOptionId = strAnswerOptionId; //回答选项Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.AnswerOptionId) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.AnswerOptionId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.AnswerOptionId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetAnswerMultiOptions(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strAnswerMultiOptions, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerMultiOptions, 300, convcc_PaperStuBatchQuesRela.AnswerMultiOptions);
objvcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions = strAnswerMultiOptions; //多选项答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.AnswerMultiOptions) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.AnswerMultiOptions, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.AnswerMultiOptions] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetStuAnswerText(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strStuAnswerText, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRelaEN.StuAnswerText = strStuAnswerText; //学生回答文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.StuAnswerText) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.StuAnswerText, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.StuAnswerText] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetIsPublish(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, bool bolIsPublish, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRelaEN.IsPublish = bolIsPublish; //是否发布
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.IsPublish) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.IsPublish, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.IsPublish] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetIsLook(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, bool bolIsLook, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRelaEN.IsLook = bolIsLook; //是否查看
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.IsLook) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.IsLook, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.IsLook] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetIsSave(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, bool bolIsSave, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRelaEN.IsSave = bolIsSave; //是否保存
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.IsSave) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.IsSave, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.IsSave] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetIsSubmit(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRelaEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.IsSubmit) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.IsSubmit, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.IsSubmit] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetApplySendBackDate(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strApplySendBackDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplySendBackDate, 14, convcc_PaperStuBatchQuesRela.ApplySendBackDate);
objvcc_PaperStuBatchQuesRelaEN.ApplySendBackDate = strApplySendBackDate; //申请退回日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.ApplySendBackDate) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.ApplySendBackDate, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.ApplySendBackDate] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetIsApplySendBack(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, bool bolIsApplySendBack, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRelaEN.IsApplySendBack = bolIsApplySendBack; //是否申请退回
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.IsApplySendBack) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.IsApplySendBack, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.IsApplySendBack] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetRealFinishDate(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strRealFinishDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRealFinishDate, 14, convcc_PaperStuBatchQuesRela.RealFinishDate);
objvcc_PaperStuBatchQuesRelaEN.RealFinishDate = strRealFinishDate; //实际完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.RealFinishDate) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.RealFinishDate, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.RealFinishDate] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetOperateTime(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strOperateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOperateTime, 14, convcc_PaperStuBatchQuesRela.OperateTime);
objvcc_PaperStuBatchQuesRelaEN.OperateTime = strOperateTime; //操作时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.OperateTime) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.OperateTime, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.OperateTime] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetScore(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, double dblScore, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRelaEN.Score = dblScore; //得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.Score) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.Score, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.Score] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetComment(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strComment, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRelaEN.Comment = strComment; //批注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.Comment) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.Comment, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.Comment] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetIsMarking(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, bool bolIsMarking, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRelaEN.IsMarking = bolIsMarking; //是否批阅
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.IsMarking) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.IsMarking, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.IsMarking] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetMarkerId(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strMarkerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkerId, 20, convcc_PaperStuBatchQuesRela.MarkerId);
objvcc_PaperStuBatchQuesRelaEN.MarkerId = strMarkerId; //打分者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.MarkerId) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.MarkerId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.MarkerId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetMarkDate(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strMarkDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkDate, 14, convcc_PaperStuBatchQuesRela.MarkDate);
objvcc_PaperStuBatchQuesRelaEN.MarkDate = strMarkDate; //打分日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.MarkDate) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.MarkDate, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.MarkDate] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetIsSendBack(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, bool bolIsSendBack, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRelaEN.IsSendBack = bolIsSendBack; //是否退回
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.IsSendBack) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.IsSendBack, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.IsSendBack] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetIsInErrorQuestion(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, bool bolIsInErrorQuestion, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion = bolIsInErrorQuestion; //是否进入错题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.IsInErrorQuestion) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.IsInErrorQuestion, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.IsInErrorQuestion] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetAnswerIP(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strAnswerIP, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerIP, 30, convcc_PaperStuBatchQuesRela.AnswerIP);
objvcc_PaperStuBatchQuesRelaEN.AnswerIP = strAnswerIP; //回答IP
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.AnswerIP) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.AnswerIP, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.AnswerIP] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetAnswerDate(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strAnswerDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerDate, 8, convcc_PaperStuBatchQuesRela.AnswerDate);
objvcc_PaperStuBatchQuesRelaEN.AnswerDate = strAnswerDate; //回答日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.AnswerDate) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.AnswerDate, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.AnswerDate] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetAnswerTime(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strAnswerTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTime, 10, convcc_PaperStuBatchQuesRela.AnswerTime);
objvcc_PaperStuBatchQuesRelaEN.AnswerTime = strAnswerTime; //回答时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.AnswerTime) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.AnswerTime, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.AnswerTime] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetIsRight(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, bool bolIsRight, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRelaEN.IsRight = bolIsRight; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.IsRight) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.IsRight, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.IsRight] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetIsAccessKnowledge(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, bool bolIsAccessKnowledge, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge = bolIsAccessKnowledge; //是否处理知识点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.IsAccessKnowledge) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.IsAccessKnowledge, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.IsAccessKnowledge] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetIsNotProcessTimeout(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, bool bolIsNotProcessTimeout, string strComparisonOp="")
	{
objvcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout = bolIsNotProcessTimeout; //是否不处理超时
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.IsNotProcessTimeout) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.IsNotProcessTimeout, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.IsNotProcessTimeout] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetSchoolYear(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strSchoolYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, convcc_PaperStuBatchQuesRela.SchoolYear);
objvcc_PaperStuBatchQuesRelaEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.SchoolYear) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.SchoolYear, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.SchoolYear] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetSchoolTerm(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, convcc_PaperStuBatchQuesRela.SchoolTerm);
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, convcc_PaperStuBatchQuesRela.SchoolTerm);
objvcc_PaperStuBatchQuesRelaEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.SchoolTerm) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.SchoolTerm, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.SchoolTerm] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetErrMsg(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrMsg, 200, convcc_PaperStuBatchQuesRela.ErrMsg);
objvcc_PaperStuBatchQuesRelaEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.ErrMsg) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.ErrMsg, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.ErrMsg] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetUpdDate(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_PaperStuBatchQuesRela.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_PaperStuBatchQuesRela.UpdDate);
objvcc_PaperStuBatchQuesRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.UpdDate) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.UpdDate, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.UpdDate] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetUpdUserId(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_PaperStuBatchQuesRela.UpdUserId);
objvcc_PaperStuBatchQuesRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.UpdUserId) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.UpdUserId, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.UpdUserId] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetMemo(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_PaperStuBatchQuesRela.Memo);
objvcc_PaperStuBatchQuesRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.Memo) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.Memo, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.Memo] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PaperStuBatchQuesRelaEN SetIsMarkingName(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN, string strIsMarkingName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIsMarkingName, convcc_PaperStuBatchQuesRela.IsMarkingName);
clsCheckSql.CheckFieldLen(strIsMarkingName, 2, convcc_PaperStuBatchQuesRela.IsMarkingName);
objvcc_PaperStuBatchQuesRelaEN.IsMarkingName = strIsMarkingName; //IsMarkingName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(convcc_PaperStuBatchQuesRela.IsMarkingName) == false)
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(convcc_PaperStuBatchQuesRela.IsMarkingName, strComparisonOp);
}
else
{
objvcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.IsMarkingName] = strComparisonOp;
}
}
return objvcc_PaperStuBatchQuesRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRela_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.Id_PaperStuBatchQuesRela) == true)
{
string strComparisonOp_Id_PaperStuBatchQuesRela = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.Id_PaperStuBatchQuesRela];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela.Id_PaperStuBatchQuesRela, objvcc_PaperStuBatchQuesRela_Cond.Id_PaperStuBatchQuesRela, strComparisonOp_Id_PaperStuBatchQuesRela);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.Id_PaperStuBatch) == true)
{
string strComparisonOp_Id_PaperStuBatch = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.Id_PaperStuBatch];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.Id_PaperStuBatch, objvcc_PaperStuBatchQuesRela_Cond.Id_PaperStuBatch, strComparisonOp_Id_PaperStuBatch);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.CourseExamPaperId) == true)
{
string strComparisonOp_CourseExamPaperId = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.CourseExamPaperId, objvcc_PaperStuBatchQuesRela_Cond.CourseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.ExamPaperName) == true)
{
string strComparisonOp_ExamPaperName = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.ExamPaperName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.ExamPaperName, objvcc_PaperStuBatchQuesRela_Cond.ExamPaperName, strComparisonOp_ExamPaperName);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.ExamPaperTypeId) == true)
{
string strComparisonOp_ExamPaperTypeId = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.ExamPaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.ExamPaperTypeId, objvcc_PaperStuBatchQuesRela_Cond.ExamPaperTypeId, strComparisonOp_ExamPaperTypeId);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.id_StudentInfo, objvcc_PaperStuBatchQuesRela_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.StuID) == true)
{
string strComparisonOp_StuID = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.StuID, objvcc_PaperStuBatchQuesRela_Cond.StuID, strComparisonOp_StuID);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.StuName) == true)
{
string strComparisonOp_StuName = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.StuName, objvcc_PaperStuBatchQuesRela_Cond.StuName, strComparisonOp_StuName);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.id_XzCollege, objvcc_PaperStuBatchQuesRela_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.CollegeName, objvcc_PaperStuBatchQuesRela_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.CollegeNameA, objvcc_PaperStuBatchQuesRela_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.id_XzMajor, objvcc_PaperStuBatchQuesRela_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.MajorID) == true)
{
string strComparisonOp_MajorID = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.MajorID, objvcc_PaperStuBatchQuesRela_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.MajorName) == true)
{
string strComparisonOp_MajorName = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.MajorName, objvcc_PaperStuBatchQuesRela_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.id_GradeBase, objvcc_PaperStuBatchQuesRela_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.GradeBaseName, objvcc_PaperStuBatchQuesRela_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.AdminClsName) == true)
{
string strComparisonOp_AdminClsName = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.AdminClsName, objvcc_PaperStuBatchQuesRela_Cond.AdminClsName, strComparisonOp_AdminClsName);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.AdminClsId) == true)
{
string strComparisonOp_AdminClsId = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.AdminClsId, objvcc_PaperStuBatchQuesRela_Cond.AdminClsId, strComparisonOp_AdminClsId);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.BatchTime) == true)
{
string strComparisonOp_BatchTime = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.BatchTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.BatchTime, objvcc_PaperStuBatchQuesRela_Cond.BatchTime, strComparisonOp_BatchTime);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.id_CurrEduCls, objvcc_PaperStuBatchQuesRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.EduClsName) == true)
{
string strComparisonOp_EduClsName = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.EduClsName, objvcc_PaperStuBatchQuesRela_Cond.EduClsName, strComparisonOp_EduClsName);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.QuestionID) == true)
{
string strComparisonOp_QuestionID = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.QuestionID, objvcc_PaperStuBatchQuesRela_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.QuestionIndex) == true)
{
string strComparisonOp_QuestionIndex = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela.QuestionIndex, objvcc_PaperStuBatchQuesRela_Cond.QuestionIndex, strComparisonOp_QuestionIndex);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.QuestionName) == true)
{
string strComparisonOp_QuestionName = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.QuestionName, objvcc_PaperStuBatchQuesRela_Cond.QuestionName, strComparisonOp_QuestionName);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.QuestionContent) == true)
{
string strComparisonOp_QuestionContent = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.QuestionContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.QuestionContent, objvcc_PaperStuBatchQuesRela_Cond.QuestionContent, strComparisonOp_QuestionContent);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.CourseId, objvcc_PaperStuBatchQuesRela_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.CourseName, objvcc_PaperStuBatchQuesRela_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.CourseChapterId, objvcc_PaperStuBatchQuesRela_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.CourseChapterName, objvcc_PaperStuBatchQuesRela_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.ChapterName, objvcc_PaperStuBatchQuesRela_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.SectionName) == true)
{
string strComparisonOp_SectionName = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.SectionName, objvcc_PaperStuBatchQuesRela_Cond.SectionName, strComparisonOp_SectionName);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.ChapterName_Sim, objvcc_PaperStuBatchQuesRela_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.SectionName_Sim, objvcc_PaperStuBatchQuesRela_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.ParentNodeID, objvcc_PaperStuBatchQuesRela_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.CourseChapterReferred) == true)
{
string strComparisonOp_CourseChapterReferred = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.CourseChapterReferred, objvcc_PaperStuBatchQuesRela_Cond.CourseChapterReferred, strComparisonOp_CourseChapterReferred);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.ParentNodeName) == true)
{
string strComparisonOp_ParentNodeName = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.ParentNodeName, objvcc_PaperStuBatchQuesRela_Cond.ParentNodeName, strComparisonOp_ParentNodeName);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.ParentNodeReferred) == true)
{
string strComparisonOp_ParentNodeReferred = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.ParentNodeReferred, objvcc_PaperStuBatchQuesRela_Cond.ParentNodeReferred, strComparisonOp_ParentNodeReferred);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.QuestionTypeId, objvcc_PaperStuBatchQuesRela_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.QuestionTypeName) == true)
{
string strComparisonOp_QuestionTypeName = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.QuestionTypeName, objvcc_PaperStuBatchQuesRela_Cond.QuestionTypeName, strComparisonOp_QuestionTypeName);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.AnswerTypeId) == true)
{
string strComparisonOp_AnswerTypeId = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.AnswerTypeId, objvcc_PaperStuBatchQuesRela_Cond.AnswerTypeId, strComparisonOp_AnswerTypeId);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.DefaultValue) == true)
{
string strComparisonOp_DefaultValue = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.DefaultValue, objvcc_PaperStuBatchQuesRela_Cond.DefaultValue, strComparisonOp_DefaultValue);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.TextDirectId) == true)
{
string strComparisonOp_TextDirectId = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.TextDirectId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.TextDirectId, objvcc_PaperStuBatchQuesRela_Cond.TextDirectId, strComparisonOp_TextDirectId);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.RelaEvent) == true)
{
string strComparisonOp_RelaEvent = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.RelaEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.RelaEvent, objvcc_PaperStuBatchQuesRela_Cond.RelaEvent, strComparisonOp_RelaEvent);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.CheckBoxLimitCount) == true)
{
string strComparisonOp_CheckBoxLimitCount = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.CheckBoxLimitCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela.CheckBoxLimitCount, objvcc_PaperStuBatchQuesRela_Cond.CheckBoxLimitCount, strComparisonOp_CheckBoxLimitCount);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.AnswerAttLimitSize) == true)
{
string strComparisonOp_AnswerAttLimitSize = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.AnswerAttLimitSize];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela.AnswerAttLimitSize, objvcc_PaperStuBatchQuesRela_Cond.AnswerAttLimitSize, strComparisonOp_AnswerAttLimitSize);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.LimitedResourceType) == true)
{
string strComparisonOp_LimitedResourceType = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.LimitedResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.LimitedResourceType, objvcc_PaperStuBatchQuesRela_Cond.LimitedResourceType, strComparisonOp_LimitedResourceType);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.QuestionIndex4Batch) == true)
{
string strComparisonOp_QuestionIndex4Batch = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.QuestionIndex4Batch];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela.QuestionIndex4Batch, objvcc_PaperStuBatchQuesRela_Cond.QuestionIndex4Batch, strComparisonOp_QuestionIndex4Batch);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.Scores) == true)
{
string strComparisonOp_Scores = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.Scores];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela.Scores, objvcc_PaperStuBatchQuesRela_Cond.Scores, strComparisonOp_Scores);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.AnswerModeId) == true)
{
string strComparisonOp_AnswerModeId = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.AnswerModeId, objvcc_PaperStuBatchQuesRela_Cond.AnswerModeId, strComparisonOp_AnswerModeId);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.AnswerOptionId) == true)
{
string strComparisonOp_AnswerOptionId = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.AnswerOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.AnswerOptionId, objvcc_PaperStuBatchQuesRela_Cond.AnswerOptionId, strComparisonOp_AnswerOptionId);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.AnswerMultiOptions) == true)
{
string strComparisonOp_AnswerMultiOptions = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.AnswerMultiOptions];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.AnswerMultiOptions, objvcc_PaperStuBatchQuesRela_Cond.AnswerMultiOptions, strComparisonOp_AnswerMultiOptions);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.IsPublish) == true)
{
if (objvcc_PaperStuBatchQuesRela_Cond.IsPublish == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_PaperStuBatchQuesRela.IsPublish);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_PaperStuBatchQuesRela.IsPublish);
}
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.IsLook) == true)
{
if (objvcc_PaperStuBatchQuesRela_Cond.IsLook == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_PaperStuBatchQuesRela.IsLook);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_PaperStuBatchQuesRela.IsLook);
}
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.IsSave) == true)
{
if (objvcc_PaperStuBatchQuesRela_Cond.IsSave == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_PaperStuBatchQuesRela.IsSave);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_PaperStuBatchQuesRela.IsSave);
}
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.IsSubmit) == true)
{
if (objvcc_PaperStuBatchQuesRela_Cond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_PaperStuBatchQuesRela.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_PaperStuBatchQuesRela.IsSubmit);
}
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.ApplySendBackDate) == true)
{
string strComparisonOp_ApplySendBackDate = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.ApplySendBackDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.ApplySendBackDate, objvcc_PaperStuBatchQuesRela_Cond.ApplySendBackDate, strComparisonOp_ApplySendBackDate);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.IsApplySendBack) == true)
{
if (objvcc_PaperStuBatchQuesRela_Cond.IsApplySendBack == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_PaperStuBatchQuesRela.IsApplySendBack);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_PaperStuBatchQuesRela.IsApplySendBack);
}
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.RealFinishDate) == true)
{
string strComparisonOp_RealFinishDate = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.RealFinishDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.RealFinishDate, objvcc_PaperStuBatchQuesRela_Cond.RealFinishDate, strComparisonOp_RealFinishDate);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.OperateTime) == true)
{
string strComparisonOp_OperateTime = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.OperateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.OperateTime, objvcc_PaperStuBatchQuesRela_Cond.OperateTime, strComparisonOp_OperateTime);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.Score) == true)
{
string strComparisonOp_Score = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PaperStuBatchQuesRela.Score, objvcc_PaperStuBatchQuesRela_Cond.Score, strComparisonOp_Score);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.IsMarking) == true)
{
if (objvcc_PaperStuBatchQuesRela_Cond.IsMarking == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_PaperStuBatchQuesRela.IsMarking);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_PaperStuBatchQuesRela.IsMarking);
}
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.MarkerId) == true)
{
string strComparisonOp_MarkerId = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.MarkerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.MarkerId, objvcc_PaperStuBatchQuesRela_Cond.MarkerId, strComparisonOp_MarkerId);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.MarkDate) == true)
{
string strComparisonOp_MarkDate = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.MarkDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.MarkDate, objvcc_PaperStuBatchQuesRela_Cond.MarkDate, strComparisonOp_MarkDate);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.IsSendBack) == true)
{
if (objvcc_PaperStuBatchQuesRela_Cond.IsSendBack == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_PaperStuBatchQuesRela.IsSendBack);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_PaperStuBatchQuesRela.IsSendBack);
}
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.IsInErrorQuestion) == true)
{
if (objvcc_PaperStuBatchQuesRela_Cond.IsInErrorQuestion == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_PaperStuBatchQuesRela.IsInErrorQuestion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_PaperStuBatchQuesRela.IsInErrorQuestion);
}
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.AnswerIP) == true)
{
string strComparisonOp_AnswerIP = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.AnswerIP];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.AnswerIP, objvcc_PaperStuBatchQuesRela_Cond.AnswerIP, strComparisonOp_AnswerIP);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.AnswerDate) == true)
{
string strComparisonOp_AnswerDate = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.AnswerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.AnswerDate, objvcc_PaperStuBatchQuesRela_Cond.AnswerDate, strComparisonOp_AnswerDate);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.AnswerTime) == true)
{
string strComparisonOp_AnswerTime = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.AnswerTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.AnswerTime, objvcc_PaperStuBatchQuesRela_Cond.AnswerTime, strComparisonOp_AnswerTime);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.IsRight) == true)
{
if (objvcc_PaperStuBatchQuesRela_Cond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_PaperStuBatchQuesRela.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_PaperStuBatchQuesRela.IsRight);
}
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.IsAccessKnowledge) == true)
{
if (objvcc_PaperStuBatchQuesRela_Cond.IsAccessKnowledge == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_PaperStuBatchQuesRela.IsAccessKnowledge);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_PaperStuBatchQuesRela.IsAccessKnowledge);
}
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.IsNotProcessTimeout) == true)
{
if (objvcc_PaperStuBatchQuesRela_Cond.IsNotProcessTimeout == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_PaperStuBatchQuesRela.IsNotProcessTimeout);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_PaperStuBatchQuesRela.IsNotProcessTimeout);
}
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.SchoolYear) == true)
{
string strComparisonOp_SchoolYear = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.SchoolYear, objvcc_PaperStuBatchQuesRela_Cond.SchoolYear, strComparisonOp_SchoolYear);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.SchoolTerm) == true)
{
string strComparisonOp_SchoolTerm = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.SchoolTerm, objvcc_PaperStuBatchQuesRela_Cond.SchoolTerm, strComparisonOp_SchoolTerm);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.ErrMsg) == true)
{
string strComparisonOp_ErrMsg = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.ErrMsg, objvcc_PaperStuBatchQuesRela_Cond.ErrMsg, strComparisonOp_ErrMsg);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.UpdDate, objvcc_PaperStuBatchQuesRela_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.UpdUserId, objvcc_PaperStuBatchQuesRela_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.Memo) == true)
{
string strComparisonOp_Memo = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.Memo, objvcc_PaperStuBatchQuesRela_Cond.Memo, strComparisonOp_Memo);
}
if (objvcc_PaperStuBatchQuesRela_Cond.IsUpdated(convcc_PaperStuBatchQuesRela.IsMarkingName) == true)
{
string strComparisonOp_IsMarkingName = objvcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[convcc_PaperStuBatchQuesRela.IsMarkingName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PaperStuBatchQuesRela.IsMarkingName, objvcc_PaperStuBatchQuesRela_Cond.IsMarkingName, strComparisonOp_IsMarkingName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v学生批次题目关系(vcc_PaperStuBatchQuesRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_PaperStuBatchQuesRelaWApi
{
private static readonly string mstrApiControllerName = "vcc_PaperStuBatchQuesRelaApi";

 public clsvcc_PaperStuBatchQuesRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_PaperStuBatchQuesRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_PaperStuBatchQuesRelaEN GetObjById_PaperStuBatchQuesRela(long lngId_PaperStuBatchQuesRela)
{
string strAction = "GetObjById_PaperStuBatchQuesRela";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_PaperStuBatchQuesRela"] = lngId_PaperStuBatchQuesRela.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_PaperStuBatchQuesRelaEN = JsonConvert.DeserializeObject<clsvcc_PaperStuBatchQuesRelaEN>((string)jobjReturn["ReturnObj"]);
return objvcc_PaperStuBatchQuesRelaEN;
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
 /// <param name = "lngId_PaperStuBatchQuesRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_PaperStuBatchQuesRelaEN GetObjById_PaperStuBatchQuesRela_WA_Cache(long lngId_PaperStuBatchQuesRela)
{
string strAction = "GetObjById_PaperStuBatchQuesRela_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_PaperStuBatchQuesRela"] = lngId_PaperStuBatchQuesRela.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_PaperStuBatchQuesRelaEN = JsonConvert.DeserializeObject<clsvcc_PaperStuBatchQuesRelaEN>((string)jobjReturn["ReturnObj"]);
return objvcc_PaperStuBatchQuesRelaEN;
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
public static clsvcc_PaperStuBatchQuesRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaEN = null;
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
objvcc_PaperStuBatchQuesRelaEN = JsonConvert.DeserializeObject<clsvcc_PaperStuBatchQuesRelaEN>((string)jobjReturn["ReturnObj"]);
return objvcc_PaperStuBatchQuesRelaEN;
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
 /// <param name = "lngId_PaperStuBatchQuesRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_PaperStuBatchQuesRelaEN GetObjById_PaperStuBatchQuesRela_Cache(long lngId_PaperStuBatchQuesRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_PaperStuBatchQuesRelaEN._CurrTabName_S);
List<clsvcc_PaperStuBatchQuesRelaEN> arrvcc_PaperStuBatchQuesRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_PaperStuBatchQuesRelaEN> arrvcc_PaperStuBatchQuesRelaObjLst_Sel =
from objvcc_PaperStuBatchQuesRelaEN in arrvcc_PaperStuBatchQuesRelaObjLst_Cache
where objvcc_PaperStuBatchQuesRelaEN.Id_PaperStuBatchQuesRela == lngId_PaperStuBatchQuesRela
select objvcc_PaperStuBatchQuesRelaEN;
if (arrvcc_PaperStuBatchQuesRelaObjLst_Sel.Count() == 0)
{
   clsvcc_PaperStuBatchQuesRelaEN obj = clsvcc_PaperStuBatchQuesRelaWApi.GetObjById_PaperStuBatchQuesRela(lngId_PaperStuBatchQuesRela);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_PaperStuBatchQuesRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_PaperStuBatchQuesRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_PaperStuBatchQuesRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PaperStuBatchQuesRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_PaperStuBatchQuesRelaEN> GetObjLstById_PaperStuBatchQuesRelaLst(List<long> arrId_PaperStuBatchQuesRela)
{
 List<clsvcc_PaperStuBatchQuesRelaEN> arrObjLst = null; 
string strAction = "GetObjLstById_PaperStuBatchQuesRelaLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PaperStuBatchQuesRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PaperStuBatchQuesRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngId_PaperStuBatchQuesRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvcc_PaperStuBatchQuesRelaEN> GetObjLstById_PaperStuBatchQuesRelaLst_Cache(List<long> arrId_PaperStuBatchQuesRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_PaperStuBatchQuesRelaEN._CurrTabName_S);
List<clsvcc_PaperStuBatchQuesRelaEN> arrvcc_PaperStuBatchQuesRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_PaperStuBatchQuesRelaEN> arrvcc_PaperStuBatchQuesRelaObjLst_Sel =
from objvcc_PaperStuBatchQuesRelaEN in arrvcc_PaperStuBatchQuesRelaObjLst_Cache
where arrId_PaperStuBatchQuesRela.Contains(objvcc_PaperStuBatchQuesRelaEN.Id_PaperStuBatchQuesRela)
select objvcc_PaperStuBatchQuesRelaEN;
return arrvcc_PaperStuBatchQuesRelaObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_PaperStuBatchQuesRelaEN> GetObjLstById_PaperStuBatchQuesRelaLst_WA_Cache(List<long> arrId_PaperStuBatchQuesRela)
{
 List<clsvcc_PaperStuBatchQuesRelaEN> arrObjLst = null; 
string strAction = "GetObjLstById_PaperStuBatchQuesRelaLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PaperStuBatchQuesRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PaperStuBatchQuesRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_PaperStuBatchQuesRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_PaperStuBatchQuesRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PaperStuBatchQuesRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_PaperStuBatchQuesRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_PaperStuBatchQuesRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PaperStuBatchQuesRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_PaperStuBatchQuesRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_PaperStuBatchQuesRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PaperStuBatchQuesRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_PaperStuBatchQuesRelaEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_PaperStuBatchQuesRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PaperStuBatchQuesRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngId_PaperStuBatchQuesRela)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_PaperStuBatchQuesRela"] = lngId_PaperStuBatchQuesRela.ToString()
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
 /// <param name = "objvcc_PaperStuBatchQuesRelaENS">源对象</param>
 /// <param name = "objvcc_PaperStuBatchQuesRelaENT">目标对象</param>
 public static void CopyTo(clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaENS, clsvcc_PaperStuBatchQuesRelaEN objvcc_PaperStuBatchQuesRelaENT)
{
try
{
objvcc_PaperStuBatchQuesRelaENT.Id_PaperStuBatchQuesRela = objvcc_PaperStuBatchQuesRelaENS.Id_PaperStuBatchQuesRela; //学生批次题目关系流水号
objvcc_PaperStuBatchQuesRelaENT.Id_PaperStuBatch = objvcc_PaperStuBatchQuesRelaENS.Id_PaperStuBatch; //学生试卷批次流水号
objvcc_PaperStuBatchQuesRelaENT.CourseExamPaperId = objvcc_PaperStuBatchQuesRelaENS.CourseExamPaperId; //考卷流水号
objvcc_PaperStuBatchQuesRelaENT.ExamPaperName = objvcc_PaperStuBatchQuesRelaENS.ExamPaperName; //考卷名称
objvcc_PaperStuBatchQuesRelaENT.ExamPaperTypeId = objvcc_PaperStuBatchQuesRelaENS.ExamPaperTypeId; //试卷类型Id
objvcc_PaperStuBatchQuesRelaENT.id_StudentInfo = objvcc_PaperStuBatchQuesRelaENS.id_StudentInfo; //学生流水号
objvcc_PaperStuBatchQuesRelaENT.StuID = objvcc_PaperStuBatchQuesRelaENS.StuID; //学号
objvcc_PaperStuBatchQuesRelaENT.StuName = objvcc_PaperStuBatchQuesRelaENS.StuName; //姓名
objvcc_PaperStuBatchQuesRelaENT.id_XzCollege = objvcc_PaperStuBatchQuesRelaENS.id_XzCollege; //学院流水号
objvcc_PaperStuBatchQuesRelaENT.CollegeName = objvcc_PaperStuBatchQuesRelaENS.CollegeName; //学院名称
objvcc_PaperStuBatchQuesRelaENT.CollegeNameA = objvcc_PaperStuBatchQuesRelaENS.CollegeNameA; //学院名称简写
objvcc_PaperStuBatchQuesRelaENT.id_XzMajor = objvcc_PaperStuBatchQuesRelaENS.id_XzMajor; //专业流水号
objvcc_PaperStuBatchQuesRelaENT.MajorID = objvcc_PaperStuBatchQuesRelaENS.MajorID; //专业ID
objvcc_PaperStuBatchQuesRelaENT.MajorName = objvcc_PaperStuBatchQuesRelaENS.MajorName; //专业名称
objvcc_PaperStuBatchQuesRelaENT.id_GradeBase = objvcc_PaperStuBatchQuesRelaENS.id_GradeBase; //年级流水号
objvcc_PaperStuBatchQuesRelaENT.GradeBaseName = objvcc_PaperStuBatchQuesRelaENS.GradeBaseName; //年级名称
objvcc_PaperStuBatchQuesRelaENT.AdminClsName = objvcc_PaperStuBatchQuesRelaENS.AdminClsName; //行政班名称
objvcc_PaperStuBatchQuesRelaENT.AdminClsId = objvcc_PaperStuBatchQuesRelaENS.AdminClsId; //行政班代号
objvcc_PaperStuBatchQuesRelaENT.BatchTime = objvcc_PaperStuBatchQuesRelaENS.BatchTime; //批次
objvcc_PaperStuBatchQuesRelaENT.id_CurrEduCls = objvcc_PaperStuBatchQuesRelaENS.id_CurrEduCls; //当前教学班流水号
objvcc_PaperStuBatchQuesRelaENT.EduClsName = objvcc_PaperStuBatchQuesRelaENS.EduClsName; //教学班名称
objvcc_PaperStuBatchQuesRelaENT.QuestionID = objvcc_PaperStuBatchQuesRelaENS.QuestionID; //题目ID
objvcc_PaperStuBatchQuesRelaENT.QuestionIndex = objvcc_PaperStuBatchQuesRelaENS.QuestionIndex; //题目序号
objvcc_PaperStuBatchQuesRelaENT.QuestionName = objvcc_PaperStuBatchQuesRelaENS.QuestionName; //题目名称
objvcc_PaperStuBatchQuesRelaENT.QuestionContent = objvcc_PaperStuBatchQuesRelaENS.QuestionContent; //题目内容
objvcc_PaperStuBatchQuesRelaENT.CourseId = objvcc_PaperStuBatchQuesRelaENS.CourseId; //课程Id
objvcc_PaperStuBatchQuesRelaENT.CourseName = objvcc_PaperStuBatchQuesRelaENS.CourseName; //课程名称
objvcc_PaperStuBatchQuesRelaENT.CourseChapterId = objvcc_PaperStuBatchQuesRelaENS.CourseChapterId; //课程章节ID
objvcc_PaperStuBatchQuesRelaENT.CourseChapterName = objvcc_PaperStuBatchQuesRelaENS.CourseChapterName; //课程章节名称
objvcc_PaperStuBatchQuesRelaENT.ChapterName = objvcc_PaperStuBatchQuesRelaENS.ChapterName; //章名
objvcc_PaperStuBatchQuesRelaENT.SectionName = objvcc_PaperStuBatchQuesRelaENS.SectionName; //节名
objvcc_PaperStuBatchQuesRelaENT.ChapterName_Sim = objvcc_PaperStuBatchQuesRelaENS.ChapterName_Sim; //章名简称
objvcc_PaperStuBatchQuesRelaENT.SectionName_Sim = objvcc_PaperStuBatchQuesRelaENS.SectionName_Sim; //节名简称
objvcc_PaperStuBatchQuesRelaENT.ParentNodeID = objvcc_PaperStuBatchQuesRelaENS.ParentNodeID; //父节点编号
objvcc_PaperStuBatchQuesRelaENT.CourseChapterReferred = objvcc_PaperStuBatchQuesRelaENS.CourseChapterReferred; //节简称
objvcc_PaperStuBatchQuesRelaENT.ParentNodeName = objvcc_PaperStuBatchQuesRelaENS.ParentNodeName; //父节点名称
objvcc_PaperStuBatchQuesRelaENT.ParentNodeReferred = objvcc_PaperStuBatchQuesRelaENS.ParentNodeReferred; //章简称
objvcc_PaperStuBatchQuesRelaENT.QuestionTypeId = objvcc_PaperStuBatchQuesRelaENS.QuestionTypeId; //题目类型Id
objvcc_PaperStuBatchQuesRelaENT.QuestionTypeName = objvcc_PaperStuBatchQuesRelaENS.QuestionTypeName; //题目类型名
objvcc_PaperStuBatchQuesRelaENT.AnswerTypeId = objvcc_PaperStuBatchQuesRelaENS.AnswerTypeId; //答案类型ID
objvcc_PaperStuBatchQuesRelaENT.DefaultValue = objvcc_PaperStuBatchQuesRelaENS.DefaultValue; //缺省值
objvcc_PaperStuBatchQuesRelaENT.TextDirectId = objvcc_PaperStuBatchQuesRelaENS.TextDirectId; //文本方向ID
objvcc_PaperStuBatchQuesRelaENT.RelaEvent = objvcc_PaperStuBatchQuesRelaENS.RelaEvent; //相关事件
objvcc_PaperStuBatchQuesRelaENT.CheckBoxLimitCount = objvcc_PaperStuBatchQuesRelaENS.CheckBoxLimitCount; //复选框限制数
objvcc_PaperStuBatchQuesRelaENT.AnswerAttLimitSize = objvcc_PaperStuBatchQuesRelaENS.AnswerAttLimitSize; //回答附件限制大小
objvcc_PaperStuBatchQuesRelaENT.LimitedResourceType = objvcc_PaperStuBatchQuesRelaENS.LimitedResourceType; //限制资源类型
objvcc_PaperStuBatchQuesRelaENT.QuestionIndex4Batch = objvcc_PaperStuBatchQuesRelaENS.QuestionIndex4Batch; //题序号4批次
objvcc_PaperStuBatchQuesRelaENT.Scores = objvcc_PaperStuBatchQuesRelaENS.Scores; //分值
objvcc_PaperStuBatchQuesRelaENT.AnswerModeId = objvcc_PaperStuBatchQuesRelaENS.AnswerModeId; //答案模式Id
objvcc_PaperStuBatchQuesRelaENT.AnswerOptionId = objvcc_PaperStuBatchQuesRelaENS.AnswerOptionId; //回答选项Id
objvcc_PaperStuBatchQuesRelaENT.AnswerMultiOptions = objvcc_PaperStuBatchQuesRelaENS.AnswerMultiOptions; //多选项答案
objvcc_PaperStuBatchQuesRelaENT.StuAnswerText = objvcc_PaperStuBatchQuesRelaENS.StuAnswerText; //学生回答文本
objvcc_PaperStuBatchQuesRelaENT.IsPublish = objvcc_PaperStuBatchQuesRelaENS.IsPublish; //是否发布
objvcc_PaperStuBatchQuesRelaENT.IsLook = objvcc_PaperStuBatchQuesRelaENS.IsLook; //是否查看
objvcc_PaperStuBatchQuesRelaENT.IsSave = objvcc_PaperStuBatchQuesRelaENS.IsSave; //是否保存
objvcc_PaperStuBatchQuesRelaENT.IsSubmit = objvcc_PaperStuBatchQuesRelaENS.IsSubmit; //是否提交
objvcc_PaperStuBatchQuesRelaENT.ApplySendBackDate = objvcc_PaperStuBatchQuesRelaENS.ApplySendBackDate; //申请退回日期
objvcc_PaperStuBatchQuesRelaENT.IsApplySendBack = objvcc_PaperStuBatchQuesRelaENS.IsApplySendBack; //是否申请退回
objvcc_PaperStuBatchQuesRelaENT.RealFinishDate = objvcc_PaperStuBatchQuesRelaENS.RealFinishDate; //实际完成日期
objvcc_PaperStuBatchQuesRelaENT.OperateTime = objvcc_PaperStuBatchQuesRelaENS.OperateTime; //操作时间
objvcc_PaperStuBatchQuesRelaENT.Score = objvcc_PaperStuBatchQuesRelaENS.Score; //得分
objvcc_PaperStuBatchQuesRelaENT.Comment = objvcc_PaperStuBatchQuesRelaENS.Comment; //批注
objvcc_PaperStuBatchQuesRelaENT.IsMarking = objvcc_PaperStuBatchQuesRelaENS.IsMarking; //是否批阅
objvcc_PaperStuBatchQuesRelaENT.MarkerId = objvcc_PaperStuBatchQuesRelaENS.MarkerId; //打分者
objvcc_PaperStuBatchQuesRelaENT.MarkDate = objvcc_PaperStuBatchQuesRelaENS.MarkDate; //打分日期
objvcc_PaperStuBatchQuesRelaENT.IsSendBack = objvcc_PaperStuBatchQuesRelaENS.IsSendBack; //是否退回
objvcc_PaperStuBatchQuesRelaENT.IsInErrorQuestion = objvcc_PaperStuBatchQuesRelaENS.IsInErrorQuestion; //是否进入错题
objvcc_PaperStuBatchQuesRelaENT.AnswerIP = objvcc_PaperStuBatchQuesRelaENS.AnswerIP; //回答IP
objvcc_PaperStuBatchQuesRelaENT.AnswerDate = objvcc_PaperStuBatchQuesRelaENS.AnswerDate; //回答日期
objvcc_PaperStuBatchQuesRelaENT.AnswerTime = objvcc_PaperStuBatchQuesRelaENS.AnswerTime; //回答时间
objvcc_PaperStuBatchQuesRelaENT.IsRight = objvcc_PaperStuBatchQuesRelaENS.IsRight; //是否正确
objvcc_PaperStuBatchQuesRelaENT.IsAccessKnowledge = objvcc_PaperStuBatchQuesRelaENS.IsAccessKnowledge; //是否处理知识点
objvcc_PaperStuBatchQuesRelaENT.IsNotProcessTimeout = objvcc_PaperStuBatchQuesRelaENS.IsNotProcessTimeout; //是否不处理超时
objvcc_PaperStuBatchQuesRelaENT.SchoolYear = objvcc_PaperStuBatchQuesRelaENS.SchoolYear; //学年
objvcc_PaperStuBatchQuesRelaENT.SchoolTerm = objvcc_PaperStuBatchQuesRelaENS.SchoolTerm; //学期
objvcc_PaperStuBatchQuesRelaENT.ErrMsg = objvcc_PaperStuBatchQuesRelaENS.ErrMsg; //错误信息
objvcc_PaperStuBatchQuesRelaENT.UpdDate = objvcc_PaperStuBatchQuesRelaENS.UpdDate; //修改日期
objvcc_PaperStuBatchQuesRelaENT.UpdUserId = objvcc_PaperStuBatchQuesRelaENS.UpdUserId; //修改用户Id
objvcc_PaperStuBatchQuesRelaENT.Memo = objvcc_PaperStuBatchQuesRelaENS.Memo; //备注
objvcc_PaperStuBatchQuesRelaENT.IsMarkingName = objvcc_PaperStuBatchQuesRelaENS.IsMarkingName; //IsMarkingName
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
public static DataTable ToDataTable(List<clsvcc_PaperStuBatchQuesRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_PaperStuBatchQuesRelaEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_PaperStuBatchQuesRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_PaperStuBatchQuesRelaEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_PaperStuBatchQuesRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_PaperStuBatchQuesRelaEN.AttributeName)
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
if (clscc_PaperStuBatchQuesRelaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_PaperStuBatchQuesRelaWApi没有刷新缓存机制(clscc_PaperStuBatchQuesRelaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsCurrEduClsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsWApi没有刷新缓存机制(clsCurrEduClsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExamPaperStuBatchRelaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamPaperStuBatchRelaWApi没有刷新缓存机制(clscc_ExamPaperStuBatchRelaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterWApi没有刷新缓存机制(clscc_CourseChapterWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorWApi没有刷新缓存机制(clsXzMajorWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseExamPaperWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseExamPaperWApi没有刷新缓存机制(clscc_CourseExamPaperWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_PaperDispModeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_PaperDispModeWApi没有刷新缓存机制(clscc_PaperDispModeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExamPaperTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamPaperTypeWApi没有刷新缓存机制(clscc_ExamPaperTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsStudyLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelWApi没有刷新缓存机制(clsStudyLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_PaperStuBatchQuesRela");
//if (arrvcc_PaperStuBatchQuesRelaObjLst_Cache == null)
//{
//arrvcc_PaperStuBatchQuesRelaObjLst_Cache = await clsvcc_PaperStuBatchQuesRelaWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvcc_PaperStuBatchQuesRelaEN._CurrTabName_S);
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
public static List<clsvcc_PaperStuBatchQuesRelaEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvcc_PaperStuBatchQuesRelaEN._CurrTabName_S);
List<clsvcc_PaperStuBatchQuesRelaEN> arrvcc_PaperStuBatchQuesRelaObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_PaperStuBatchQuesRelaObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_PaperStuBatchQuesRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.Id_PaperStuBatchQuesRela, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.Id_PaperStuBatch, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.CourseExamPaperId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.ExamPaperName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.ExamPaperTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.AdminClsName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.AdminClsId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.BatchTime, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.EduClsName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.QuestionIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.QuestionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.QuestionContent, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.SectionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.CourseChapterReferred, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.ParentNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.ParentNodeReferred, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.QuestionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.AnswerTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.DefaultValue, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.TextDirectId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.RelaEvent, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.CheckBoxLimitCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.AnswerAttLimitSize, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.LimitedResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.QuestionIndex4Batch, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.Scores, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.AnswerModeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.AnswerOptionId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.AnswerMultiOptions, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.StuAnswerText, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.IsPublish, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.IsLook, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.IsSave, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.IsSubmit, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.ApplySendBackDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.IsApplySendBack, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.RealFinishDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.OperateTime, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.Score, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.Comment, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.IsMarking, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.MarkerId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.MarkDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.IsSendBack, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.IsInErrorQuestion, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.AnswerIP, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.AnswerDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.AnswerTime, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.IsRight, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.IsAccessKnowledge, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.IsNotProcessTimeout, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.SchoolYear, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.SchoolTerm, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.ErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PaperStuBatchQuesRela.IsMarkingName, Type.GetType("System.String"));
foreach (clsvcc_PaperStuBatchQuesRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_PaperStuBatchQuesRela.Id_PaperStuBatchQuesRela] = objInFor[convcc_PaperStuBatchQuesRela.Id_PaperStuBatchQuesRela];
objDR[convcc_PaperStuBatchQuesRela.Id_PaperStuBatch] = objInFor[convcc_PaperStuBatchQuesRela.Id_PaperStuBatch];
objDR[convcc_PaperStuBatchQuesRela.CourseExamPaperId] = objInFor[convcc_PaperStuBatchQuesRela.CourseExamPaperId];
objDR[convcc_PaperStuBatchQuesRela.ExamPaperName] = objInFor[convcc_PaperStuBatchQuesRela.ExamPaperName];
objDR[convcc_PaperStuBatchQuesRela.ExamPaperTypeId] = objInFor[convcc_PaperStuBatchQuesRela.ExamPaperTypeId];
objDR[convcc_PaperStuBatchQuesRela.id_StudentInfo] = objInFor[convcc_PaperStuBatchQuesRela.id_StudentInfo];
objDR[convcc_PaperStuBatchQuesRela.StuID] = objInFor[convcc_PaperStuBatchQuesRela.StuID];
objDR[convcc_PaperStuBatchQuesRela.StuName] = objInFor[convcc_PaperStuBatchQuesRela.StuName];
objDR[convcc_PaperStuBatchQuesRela.id_XzCollege] = objInFor[convcc_PaperStuBatchQuesRela.id_XzCollege];
objDR[convcc_PaperStuBatchQuesRela.CollegeName] = objInFor[convcc_PaperStuBatchQuesRela.CollegeName];
objDR[convcc_PaperStuBatchQuesRela.CollegeNameA] = objInFor[convcc_PaperStuBatchQuesRela.CollegeNameA];
objDR[convcc_PaperStuBatchQuesRela.id_XzMajor] = objInFor[convcc_PaperStuBatchQuesRela.id_XzMajor];
objDR[convcc_PaperStuBatchQuesRela.MajorID] = objInFor[convcc_PaperStuBatchQuesRela.MajorID];
objDR[convcc_PaperStuBatchQuesRela.MajorName] = objInFor[convcc_PaperStuBatchQuesRela.MajorName];
objDR[convcc_PaperStuBatchQuesRela.id_GradeBase] = objInFor[convcc_PaperStuBatchQuesRela.id_GradeBase];
objDR[convcc_PaperStuBatchQuesRela.GradeBaseName] = objInFor[convcc_PaperStuBatchQuesRela.GradeBaseName];
objDR[convcc_PaperStuBatchQuesRela.AdminClsName] = objInFor[convcc_PaperStuBatchQuesRela.AdminClsName];
objDR[convcc_PaperStuBatchQuesRela.AdminClsId] = objInFor[convcc_PaperStuBatchQuesRela.AdminClsId];
objDR[convcc_PaperStuBatchQuesRela.BatchTime] = objInFor[convcc_PaperStuBatchQuesRela.BatchTime];
objDR[convcc_PaperStuBatchQuesRela.id_CurrEduCls] = objInFor[convcc_PaperStuBatchQuesRela.id_CurrEduCls];
objDR[convcc_PaperStuBatchQuesRela.EduClsName] = objInFor[convcc_PaperStuBatchQuesRela.EduClsName];
objDR[convcc_PaperStuBatchQuesRela.QuestionID] = objInFor[convcc_PaperStuBatchQuesRela.QuestionID];
objDR[convcc_PaperStuBatchQuesRela.QuestionIndex] = objInFor[convcc_PaperStuBatchQuesRela.QuestionIndex];
objDR[convcc_PaperStuBatchQuesRela.QuestionName] = objInFor[convcc_PaperStuBatchQuesRela.QuestionName];
objDR[convcc_PaperStuBatchQuesRela.QuestionContent] = objInFor[convcc_PaperStuBatchQuesRela.QuestionContent];
objDR[convcc_PaperStuBatchQuesRela.CourseId] = objInFor[convcc_PaperStuBatchQuesRela.CourseId];
objDR[convcc_PaperStuBatchQuesRela.CourseName] = objInFor[convcc_PaperStuBatchQuesRela.CourseName];
objDR[convcc_PaperStuBatchQuesRela.CourseChapterId] = objInFor[convcc_PaperStuBatchQuesRela.CourseChapterId];
objDR[convcc_PaperStuBatchQuesRela.CourseChapterName] = objInFor[convcc_PaperStuBatchQuesRela.CourseChapterName];
objDR[convcc_PaperStuBatchQuesRela.ChapterName] = objInFor[convcc_PaperStuBatchQuesRela.ChapterName];
objDR[convcc_PaperStuBatchQuesRela.SectionName] = objInFor[convcc_PaperStuBatchQuesRela.SectionName];
objDR[convcc_PaperStuBatchQuesRela.ChapterName_Sim] = objInFor[convcc_PaperStuBatchQuesRela.ChapterName_Sim];
objDR[convcc_PaperStuBatchQuesRela.SectionName_Sim] = objInFor[convcc_PaperStuBatchQuesRela.SectionName_Sim];
objDR[convcc_PaperStuBatchQuesRela.ParentNodeID] = objInFor[convcc_PaperStuBatchQuesRela.ParentNodeID];
objDR[convcc_PaperStuBatchQuesRela.CourseChapterReferred] = objInFor[convcc_PaperStuBatchQuesRela.CourseChapterReferred];
objDR[convcc_PaperStuBatchQuesRela.ParentNodeName] = objInFor[convcc_PaperStuBatchQuesRela.ParentNodeName];
objDR[convcc_PaperStuBatchQuesRela.ParentNodeReferred] = objInFor[convcc_PaperStuBatchQuesRela.ParentNodeReferred];
objDR[convcc_PaperStuBatchQuesRela.QuestionTypeId] = objInFor[convcc_PaperStuBatchQuesRela.QuestionTypeId];
objDR[convcc_PaperStuBatchQuesRela.QuestionTypeName] = objInFor[convcc_PaperStuBatchQuesRela.QuestionTypeName];
objDR[convcc_PaperStuBatchQuesRela.AnswerTypeId] = objInFor[convcc_PaperStuBatchQuesRela.AnswerTypeId];
objDR[convcc_PaperStuBatchQuesRela.DefaultValue] = objInFor[convcc_PaperStuBatchQuesRela.DefaultValue];
objDR[convcc_PaperStuBatchQuesRela.TextDirectId] = objInFor[convcc_PaperStuBatchQuesRela.TextDirectId];
objDR[convcc_PaperStuBatchQuesRela.RelaEvent] = objInFor[convcc_PaperStuBatchQuesRela.RelaEvent];
objDR[convcc_PaperStuBatchQuesRela.CheckBoxLimitCount] = objInFor[convcc_PaperStuBatchQuesRela.CheckBoxLimitCount];
objDR[convcc_PaperStuBatchQuesRela.AnswerAttLimitSize] = objInFor[convcc_PaperStuBatchQuesRela.AnswerAttLimitSize];
objDR[convcc_PaperStuBatchQuesRela.LimitedResourceType] = objInFor[convcc_PaperStuBatchQuesRela.LimitedResourceType];
objDR[convcc_PaperStuBatchQuesRela.QuestionIndex4Batch] = objInFor[convcc_PaperStuBatchQuesRela.QuestionIndex4Batch];
objDR[convcc_PaperStuBatchQuesRela.Scores] = objInFor[convcc_PaperStuBatchQuesRela.Scores];
objDR[convcc_PaperStuBatchQuesRela.AnswerModeId] = objInFor[convcc_PaperStuBatchQuesRela.AnswerModeId];
objDR[convcc_PaperStuBatchQuesRela.AnswerOptionId] = objInFor[convcc_PaperStuBatchQuesRela.AnswerOptionId];
objDR[convcc_PaperStuBatchQuesRela.AnswerMultiOptions] = objInFor[convcc_PaperStuBatchQuesRela.AnswerMultiOptions];
objDR[convcc_PaperStuBatchQuesRela.StuAnswerText] = objInFor[convcc_PaperStuBatchQuesRela.StuAnswerText];
objDR[convcc_PaperStuBatchQuesRela.IsPublish] = objInFor[convcc_PaperStuBatchQuesRela.IsPublish];
objDR[convcc_PaperStuBatchQuesRela.IsLook] = objInFor[convcc_PaperStuBatchQuesRela.IsLook];
objDR[convcc_PaperStuBatchQuesRela.IsSave] = objInFor[convcc_PaperStuBatchQuesRela.IsSave];
objDR[convcc_PaperStuBatchQuesRela.IsSubmit] = objInFor[convcc_PaperStuBatchQuesRela.IsSubmit];
objDR[convcc_PaperStuBatchQuesRela.ApplySendBackDate] = objInFor[convcc_PaperStuBatchQuesRela.ApplySendBackDate];
objDR[convcc_PaperStuBatchQuesRela.IsApplySendBack] = objInFor[convcc_PaperStuBatchQuesRela.IsApplySendBack];
objDR[convcc_PaperStuBatchQuesRela.RealFinishDate] = objInFor[convcc_PaperStuBatchQuesRela.RealFinishDate];
objDR[convcc_PaperStuBatchQuesRela.OperateTime] = objInFor[convcc_PaperStuBatchQuesRela.OperateTime];
objDR[convcc_PaperStuBatchQuesRela.Score] = objInFor[convcc_PaperStuBatchQuesRela.Score];
objDR[convcc_PaperStuBatchQuesRela.Comment] = objInFor[convcc_PaperStuBatchQuesRela.Comment];
objDR[convcc_PaperStuBatchQuesRela.IsMarking] = objInFor[convcc_PaperStuBatchQuesRela.IsMarking];
objDR[convcc_PaperStuBatchQuesRela.MarkerId] = objInFor[convcc_PaperStuBatchQuesRela.MarkerId];
objDR[convcc_PaperStuBatchQuesRela.MarkDate] = objInFor[convcc_PaperStuBatchQuesRela.MarkDate];
objDR[convcc_PaperStuBatchQuesRela.IsSendBack] = objInFor[convcc_PaperStuBatchQuesRela.IsSendBack];
objDR[convcc_PaperStuBatchQuesRela.IsInErrorQuestion] = objInFor[convcc_PaperStuBatchQuesRela.IsInErrorQuestion];
objDR[convcc_PaperStuBatchQuesRela.AnswerIP] = objInFor[convcc_PaperStuBatchQuesRela.AnswerIP];
objDR[convcc_PaperStuBatchQuesRela.AnswerDate] = objInFor[convcc_PaperStuBatchQuesRela.AnswerDate];
objDR[convcc_PaperStuBatchQuesRela.AnswerTime] = objInFor[convcc_PaperStuBatchQuesRela.AnswerTime];
objDR[convcc_PaperStuBatchQuesRela.IsRight] = objInFor[convcc_PaperStuBatchQuesRela.IsRight];
objDR[convcc_PaperStuBatchQuesRela.IsAccessKnowledge] = objInFor[convcc_PaperStuBatchQuesRela.IsAccessKnowledge];
objDR[convcc_PaperStuBatchQuesRela.IsNotProcessTimeout] = objInFor[convcc_PaperStuBatchQuesRela.IsNotProcessTimeout];
objDR[convcc_PaperStuBatchQuesRela.SchoolYear] = objInFor[convcc_PaperStuBatchQuesRela.SchoolYear];
objDR[convcc_PaperStuBatchQuesRela.SchoolTerm] = objInFor[convcc_PaperStuBatchQuesRela.SchoolTerm];
objDR[convcc_PaperStuBatchQuesRela.ErrMsg] = objInFor[convcc_PaperStuBatchQuesRela.ErrMsg];
objDR[convcc_PaperStuBatchQuesRela.UpdDate] = objInFor[convcc_PaperStuBatchQuesRela.UpdDate];
objDR[convcc_PaperStuBatchQuesRela.UpdUserId] = objInFor[convcc_PaperStuBatchQuesRela.UpdUserId];
objDR[convcc_PaperStuBatchQuesRela.Memo] = objInFor[convcc_PaperStuBatchQuesRela.Memo];
objDR[convcc_PaperStuBatchQuesRela.IsMarkingName] = objInFor[convcc_PaperStuBatchQuesRela.IsMarkingName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}