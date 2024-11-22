
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningAppraiseWApi
 表名:vCourseLearningAppraise(01120269)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:42:48
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习
 模块英文名:CourseLearning
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
public static class clsvCourseLearningAppraiseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetId_CourseLearningCase(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strId_CourseLearningCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CourseLearningCase, 8, convCourseLearningAppraise.Id_CourseLearningCase);
clsCheckSql.CheckFieldForeignKey(strId_CourseLearningCase, 8, convCourseLearningAppraise.Id_CourseLearningCase);
objvCourseLearningAppraiseEN.Id_CourseLearningCase = strId_CourseLearningCase; //课程学习案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.Id_CourseLearningCase) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.Id_CourseLearningCase, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.Id_CourseLearningCase] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetCourseLearningCaseID(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strCourseLearningCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseID, 8, convCourseLearningAppraise.CourseLearningCaseID);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseID, 8, convCourseLearningAppraise.CourseLearningCaseID);
objvCourseLearningAppraiseEN.CourseLearningCaseID = strCourseLearningCaseID; //课程学习案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.CourseLearningCaseID) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.CourseLearningCaseID, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseID] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetCourseLearningCaseName(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strCourseLearningCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseName, 100, convCourseLearningAppraise.CourseLearningCaseName);
objvCourseLearningAppraiseEN.CourseLearningCaseName = strCourseLearningCaseName; //课程学习案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.CourseLearningCaseName) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.CourseLearningCaseName, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseName] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetCourseLearningCaseTheme(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strCourseLearningCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTheme, 200, convCourseLearningAppraise.CourseLearningCaseTheme);
objvCourseLearningAppraiseEN.CourseLearningCaseTheme = strCourseLearningCaseTheme; //课程学习案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.CourseLearningCaseTheme) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.CourseLearningCaseTheme, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseTheme] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetCourseLearningCaseDate(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strCourseLearningCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseDate, 8, convCourseLearningAppraise.CourseLearningCaseDate);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseDate, 8, convCourseLearningAppraise.CourseLearningCaseDate);
objvCourseLearningAppraiseEN.CourseLearningCaseDate = strCourseLearningCaseDate; //课程学习日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.CourseLearningCaseDate) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.CourseLearningCaseDate, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseDate] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetCourseLearningCaseTime(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strCourseLearningCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTime, 6, convCourseLearningAppraise.CourseLearningCaseTime);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseTime, 6, convCourseLearningAppraise.CourseLearningCaseTime);
objvCourseLearningAppraiseEN.CourseLearningCaseTime = strCourseLearningCaseTime; //课程学习时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.CourseLearningCaseTime) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.CourseLearningCaseTime, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseTime] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetCourseLearningCaseDateIn(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strCourseLearningCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseDateIn, 8, convCourseLearningAppraise.CourseLearningCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseDateIn, 8, convCourseLearningAppraise.CourseLearningCaseDateIn);
objvCourseLearningAppraiseEN.CourseLearningCaseDateIn = strCourseLearningCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.CourseLearningCaseDateIn) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.CourseLearningCaseDateIn, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseDateIn] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetCourseLearningCaseTimeIn(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strCourseLearningCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTimeIn, 6, convCourseLearningAppraise.CourseLearningCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseTimeIn, 6, convCourseLearningAppraise.CourseLearningCaseTimeIn);
objvCourseLearningAppraiseEN.CourseLearningCaseTimeIn = strCourseLearningCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.CourseLearningCaseTimeIn) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.CourseLearningCaseTimeIn, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseTimeIn] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetCourseLearningCaseTypeName(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strCourseLearningCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTypeName, 30, convCourseLearningAppraise.CourseLearningCaseTypeName);
objvCourseLearningAppraiseEN.CourseLearningCaseTypeName = strCourseLearningCaseTypeName; //课程学习案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.CourseLearningCaseTypeName) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.CourseLearningCaseTypeName, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseTypeName] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetUserNameWithUserId(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strUserNameWithUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserNameWithUserId, 51, convCourseLearningAppraise.UserNameWithUserId);
objvCourseLearningAppraiseEN.UserNameWithUserId = strUserNameWithUserId; //UserNameWithUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.UserNameWithUserId) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.UserNameWithUserId, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.UserNameWithUserId] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN Setid_XzCollege(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convCourseLearningAppraise.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convCourseLearningAppraise.id_XzCollege);
objvCourseLearningAppraiseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.id_XzCollege) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.id_XzCollege, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.id_XzCollege] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetCollegeID(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convCourseLearningAppraise.CollegeID);
objvCourseLearningAppraiseEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.CollegeID) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.CollegeID, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.CollegeID] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetCollegeName(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCourseLearningAppraise.CollegeName);
objvCourseLearningAppraiseEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.CollegeName) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.CollegeName, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.CollegeName] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN Setid_XzMajor(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convCourseLearningAppraise.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convCourseLearningAppraise.id_XzMajor);
objvCourseLearningAppraiseEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.id_XzMajor) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.id_XzMajor, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.id_XzMajor] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetMajorID(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convCourseLearningAppraise.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convCourseLearningAppraise.MajorID);
objvCourseLearningAppraiseEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.MajorID) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.MajorID, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.MajorID] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetMajorName(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convCourseLearningAppraise.MajorName);
objvCourseLearningAppraiseEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.MajorName) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.MajorName, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.MajorName] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetCourseId(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCourseLearningAppraise.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCourseLearningAppraise.CourseId);
objvCourseLearningAppraiseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.CourseId) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.CourseId, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.CourseId] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetCourseCode(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCourseLearningAppraise.CourseCode);
objvCourseLearningAppraiseEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.CourseCode) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.CourseCode, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.CourseCode] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetCourseName(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCourseLearningAppraise.CourseName);
objvCourseLearningAppraiseEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.CourseName) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.CourseName, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.CourseName] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetCollegeNameA(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convCourseLearningAppraise.CollegeNameA);
objvCourseLearningAppraiseEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.CollegeNameA) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.CollegeNameA, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.CollegeNameA] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN Setid_MicroteachAppraise(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, long lngid_MicroteachAppraise, string strComparisonOp="")
	{
objvCourseLearningAppraiseEN.id_MicroteachAppraise = lngid_MicroteachAppraise; //评议流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.id_MicroteachAppraise) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.id_MicroteachAppraise, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.id_MicroteachAppraise] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetFuncModuleId(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convCourseLearningAppraise.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCourseLearningAppraise.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCourseLearningAppraise.FuncModuleId);
objvCourseLearningAppraiseEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.FuncModuleId) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.FuncModuleId, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.FuncModuleId] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetFuncModuleName(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCourseLearningAppraise.FuncModuleName);
objvCourseLearningAppraiseEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.FuncModuleName) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.FuncModuleName, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.FuncModuleName] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN Setid_MicroteachCase(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convCourseLearningAppraise.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convCourseLearningAppraise.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convCourseLearningAppraise.id_MicroteachCase);
objvCourseLearningAppraiseEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.id_MicroteachCase) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.id_MicroteachCase, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.id_MicroteachCase] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN Setid_AppraiseType(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strid_AppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_AppraiseType, convCourseLearningAppraise.id_AppraiseType);
clsCheckSql.CheckFieldLen(strid_AppraiseType, 4, convCourseLearningAppraise.id_AppraiseType);
clsCheckSql.CheckFieldForeignKey(strid_AppraiseType, 4, convCourseLearningAppraise.id_AppraiseType);
objvCourseLearningAppraiseEN.id_AppraiseType = strid_AppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.id_AppraiseType) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.id_AppraiseType, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.id_AppraiseType] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetAppraiseTypeName(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strAppraiseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convCourseLearningAppraise.AppraiseTypeName);
objvCourseLearningAppraiseEN.AppraiseTypeName = strAppraiseTypeName; //评议类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.AppraiseTypeName) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.AppraiseTypeName, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.AppraiseTypeName] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetAppraiseTheme(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strAppraiseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTheme, 200, convCourseLearningAppraise.AppraiseTheme);
objvCourseLearningAppraiseEN.AppraiseTheme = strAppraiseTheme; //评议主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.AppraiseTheme) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.AppraiseTheme, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.AppraiseTheme] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetAppraiseContent(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strAppraiseContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseContent, 2000, convCourseLearningAppraise.AppraiseContent);
objvCourseLearningAppraiseEN.AppraiseContent = strAppraiseContent; //评议内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.AppraiseContent) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.AppraiseContent, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.AppraiseContent] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetAppraiseDate(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strAppraiseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseDate, 8, convCourseLearningAppraise.AppraiseDate);
clsCheckSql.CheckFieldForeignKey(strAppraiseDate, 8, convCourseLearningAppraise.AppraiseDate);
objvCourseLearningAppraiseEN.AppraiseDate = strAppraiseDate; //评议日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.AppraiseDate) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.AppraiseDate, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.AppraiseDate] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetAppraiseTime(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strAppraiseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTime, 6, convCourseLearningAppraise.AppraiseTime);
clsCheckSql.CheckFieldForeignKey(strAppraiseTime, 6, convCourseLearningAppraise.AppraiseTime);
objvCourseLearningAppraiseEN.AppraiseTime = strAppraiseTime; //评议时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.AppraiseTime) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.AppraiseTime, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.AppraiseTime] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetIsVisual(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, bool bolIsVisual, string strComparisonOp="")
	{
objvCourseLearningAppraiseEN.IsVisual = bolIsVisual; //隐藏标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.IsVisual) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.IsVisual, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.IsVisual] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetIsElite(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, bool bolIsElite, string strComparisonOp="")
	{
objvCourseLearningAppraiseEN.IsElite = bolIsElite; //精华标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.IsElite) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.IsElite, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.IsElite] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetUserId(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convCourseLearningAppraise.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, convCourseLearningAppraise.UserId);
objvCourseLearningAppraiseEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.UserId) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.UserId, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.UserId] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetExcellentOne(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strExcellentOne, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExcellentOne, 1000, convCourseLearningAppraise.ExcellentOne);
objvCourseLearningAppraiseEN.ExcellentOne = strExcellentOne; //优点1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.ExcellentOne) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.ExcellentOne, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.ExcellentOne] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetExcellentTwo(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strExcellentTwo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExcellentTwo, 1000, convCourseLearningAppraise.ExcellentTwo);
objvCourseLearningAppraiseEN.ExcellentTwo = strExcellentTwo; //优点2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.ExcellentTwo) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.ExcellentTwo, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.ExcellentTwo] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetSuggestOne(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strSuggestOne, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSuggestOne, 1000, convCourseLearningAppraise.SuggestOne);
objvCourseLearningAppraiseEN.SuggestOne = strSuggestOne; //建议1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.SuggestOne) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.SuggestOne, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.SuggestOne] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetSuggestTwo(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strSuggestTwo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSuggestTwo, 1000, convCourseLearningAppraise.SuggestTwo);
objvCourseLearningAppraiseEN.SuggestTwo = strSuggestTwo; //建议2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.SuggestTwo) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.SuggestTwo, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.SuggestTwo] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetMicroteachAppriseScore(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, float fltMicroteachAppriseScore, string strComparisonOp="")
	{
objvCourseLearningAppraiseEN.MicroteachAppriseScore = fltMicroteachAppriseScore; //打分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.MicroteachAppriseScore) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.MicroteachAppriseScore, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.MicroteachAppriseScore] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetVideoStopTime(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strVideoStopTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoStopTime, 48, convCourseLearningAppraise.VideoStopTime);
objvCourseLearningAppraiseEN.VideoStopTime = strVideoStopTime; //公开课案例视频暂停时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.VideoStopTime) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.VideoStopTime, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.VideoStopTime] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetBrowseCount(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, int intBrowseCount, string strComparisonOp="")
	{
objvCourseLearningAppraiseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.BrowseCount) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.BrowseCount, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.BrowseCount] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetBrowseCount4Case(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvCourseLearningAppraiseEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.BrowseCount4Case) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.BrowseCount4Case, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.BrowseCount4Case] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetUserName(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convCourseLearningAppraise.UserName);
objvCourseLearningAppraiseEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.UserName) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.UserName, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.UserName] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCourseLearningAppraiseEN objvCourseLearningAppraise_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.Id_CourseLearningCase) == true)
{
string strComparisonOp_Id_CourseLearningCase = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.Id_CourseLearningCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.Id_CourseLearningCase, objvCourseLearningAppraise_Cond.Id_CourseLearningCase, strComparisonOp_Id_CourseLearningCase);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.CourseLearningCaseID) == true)
{
string strComparisonOp_CourseLearningCaseID = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.CourseLearningCaseID, objvCourseLearningAppraise_Cond.CourseLearningCaseID, strComparisonOp_CourseLearningCaseID);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.CourseLearningCaseName) == true)
{
string strComparisonOp_CourseLearningCaseName = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.CourseLearningCaseName, objvCourseLearningAppraise_Cond.CourseLearningCaseName, strComparisonOp_CourseLearningCaseName);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.CourseLearningCaseTheme) == true)
{
string strComparisonOp_CourseLearningCaseTheme = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.CourseLearningCaseTheme, objvCourseLearningAppraise_Cond.CourseLearningCaseTheme, strComparisonOp_CourseLearningCaseTheme);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.CourseLearningCaseDate) == true)
{
string strComparisonOp_CourseLearningCaseDate = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.CourseLearningCaseDate, objvCourseLearningAppraise_Cond.CourseLearningCaseDate, strComparisonOp_CourseLearningCaseDate);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.CourseLearningCaseTime) == true)
{
string strComparisonOp_CourseLearningCaseTime = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.CourseLearningCaseTime, objvCourseLearningAppraise_Cond.CourseLearningCaseTime, strComparisonOp_CourseLearningCaseTime);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.CourseLearningCaseDateIn) == true)
{
string strComparisonOp_CourseLearningCaseDateIn = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.CourseLearningCaseDateIn, objvCourseLearningAppraise_Cond.CourseLearningCaseDateIn, strComparisonOp_CourseLearningCaseDateIn);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.CourseLearningCaseTimeIn) == true)
{
string strComparisonOp_CourseLearningCaseTimeIn = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.CourseLearningCaseTimeIn, objvCourseLearningAppraise_Cond.CourseLearningCaseTimeIn, strComparisonOp_CourseLearningCaseTimeIn);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.CourseLearningCaseTypeName) == true)
{
string strComparisonOp_CourseLearningCaseTypeName = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.CourseLearningCaseTypeName, objvCourseLearningAppraise_Cond.CourseLearningCaseTypeName, strComparisonOp_CourseLearningCaseTypeName);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.UserNameWithUserId) == true)
{
string strComparisonOp_UserNameWithUserId = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.UserNameWithUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.UserNameWithUserId, objvCourseLearningAppraise_Cond.UserNameWithUserId, strComparisonOp_UserNameWithUserId);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.id_XzCollege, objvCourseLearningAppraise_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.CollegeID, objvCourseLearningAppraise_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.CollegeName, objvCourseLearningAppraise_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.id_XzMajor, objvCourseLearningAppraise_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.MajorID) == true)
{
string strComparisonOp_MajorID = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.MajorID, objvCourseLearningAppraise_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.MajorName) == true)
{
string strComparisonOp_MajorName = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.MajorName, objvCourseLearningAppraise_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.CourseId) == true)
{
string strComparisonOp_CourseId = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.CourseId, objvCourseLearningAppraise_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.CourseCode, objvCourseLearningAppraise_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.CourseName) == true)
{
string strComparisonOp_CourseName = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.CourseName, objvCourseLearningAppraise_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.CollegeNameA, objvCourseLearningAppraise_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.id_MicroteachAppraise) == true)
{
string strComparisonOp_id_MicroteachAppraise = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.id_MicroteachAppraise];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningAppraise.id_MicroteachAppraise, objvCourseLearningAppraise_Cond.id_MicroteachAppraise, strComparisonOp_id_MicroteachAppraise);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.FuncModuleId, objvCourseLearningAppraise_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.FuncModuleName, objvCourseLearningAppraise_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.id_MicroteachCase, objvCourseLearningAppraise_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.id_AppraiseType) == true)
{
string strComparisonOp_id_AppraiseType = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.id_AppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.id_AppraiseType, objvCourseLearningAppraise_Cond.id_AppraiseType, strComparisonOp_id_AppraiseType);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.AppraiseTypeName) == true)
{
string strComparisonOp_AppraiseTypeName = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.AppraiseTypeName, objvCourseLearningAppraise_Cond.AppraiseTypeName, strComparisonOp_AppraiseTypeName);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.AppraiseTheme) == true)
{
string strComparisonOp_AppraiseTheme = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.AppraiseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.AppraiseTheme, objvCourseLearningAppraise_Cond.AppraiseTheme, strComparisonOp_AppraiseTheme);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.AppraiseContent) == true)
{
string strComparisonOp_AppraiseContent = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.AppraiseContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.AppraiseContent, objvCourseLearningAppraise_Cond.AppraiseContent, strComparisonOp_AppraiseContent);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.AppraiseDate) == true)
{
string strComparisonOp_AppraiseDate = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.AppraiseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.AppraiseDate, objvCourseLearningAppraise_Cond.AppraiseDate, strComparisonOp_AppraiseDate);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.AppraiseTime) == true)
{
string strComparisonOp_AppraiseTime = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.AppraiseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.AppraiseTime, objvCourseLearningAppraise_Cond.AppraiseTime, strComparisonOp_AppraiseTime);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.IsVisual) == true)
{
if (objvCourseLearningAppraise_Cond.IsVisual == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningAppraise.IsVisual);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningAppraise.IsVisual);
}
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.IsElite) == true)
{
if (objvCourseLearningAppraise_Cond.IsElite == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningAppraise.IsElite);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningAppraise.IsElite);
}
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.UserId) == true)
{
string strComparisonOp_UserId = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.UserId, objvCourseLearningAppraise_Cond.UserId, strComparisonOp_UserId);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.ExcellentOne) == true)
{
string strComparisonOp_ExcellentOne = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.ExcellentOne];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.ExcellentOne, objvCourseLearningAppraise_Cond.ExcellentOne, strComparisonOp_ExcellentOne);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.ExcellentTwo) == true)
{
string strComparisonOp_ExcellentTwo = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.ExcellentTwo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.ExcellentTwo, objvCourseLearningAppraise_Cond.ExcellentTwo, strComparisonOp_ExcellentTwo);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.SuggestOne) == true)
{
string strComparisonOp_SuggestOne = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.SuggestOne];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.SuggestOne, objvCourseLearningAppraise_Cond.SuggestOne, strComparisonOp_SuggestOne);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.SuggestTwo) == true)
{
string strComparisonOp_SuggestTwo = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.SuggestTwo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.SuggestTwo, objvCourseLearningAppraise_Cond.SuggestTwo, strComparisonOp_SuggestTwo);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.MicroteachAppriseScore) == true)
{
string strComparisonOp_MicroteachAppriseScore = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.MicroteachAppriseScore];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningAppraise.MicroteachAppriseScore, objvCourseLearningAppraise_Cond.MicroteachAppriseScore, strComparisonOp_MicroteachAppriseScore);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.VideoStopTime) == true)
{
string strComparisonOp_VideoStopTime = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.VideoStopTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.VideoStopTime, objvCourseLearningAppraise_Cond.VideoStopTime, strComparisonOp_VideoStopTime);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningAppraise.BrowseCount, objvCourseLearningAppraise_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningAppraise.BrowseCount4Case, objvCourseLearningAppraise_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvCourseLearningAppraise_Cond.IsUpdated(convCourseLearningAppraise.UserName) == true)
{
string strComparisonOp_UserName = objvCourseLearningAppraise_Cond.dicFldComparisonOp[convCourseLearningAppraise.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.UserName, objvCourseLearningAppraise_Cond.UserName, strComparisonOp_UserName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课程学习定性评议(vCourseLearningAppraise)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCourseLearningAppraiseWApi
{
private static readonly string mstrApiControllerName = "vCourseLearningAppraiseApi";

 public clsvCourseLearningAppraiseWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroteachAppraise">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningAppraiseEN GetObjByid_MicroteachAppraise(long lngid_MicroteachAppraise)
{
string strAction = "GetObjByid_MicroteachAppraise";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachAppraise"] = lngid_MicroteachAppraise.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCourseLearningAppraiseEN = JsonConvert.DeserializeObject<clsvCourseLearningAppraiseEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningAppraiseEN;
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
 /// <param name = "lngid_MicroteachAppraise">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningAppraiseEN GetObjByid_MicroteachAppraise_WA_Cache(long lngid_MicroteachAppraise)
{
string strAction = "GetObjByid_MicroteachAppraise_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachAppraise"] = lngid_MicroteachAppraise.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCourseLearningAppraiseEN = JsonConvert.DeserializeObject<clsvCourseLearningAppraiseEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningAppraiseEN;
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
public static clsvCourseLearningAppraiseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN = null;
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
objvCourseLearningAppraiseEN = JsonConvert.DeserializeObject<clsvCourseLearningAppraiseEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningAppraiseEN;
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
 /// <param name = "lngid_MicroteachAppraise">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCourseLearningAppraiseEN GetObjByid_MicroteachAppraise_Cache(long lngid_MicroteachAppraise)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCourseLearningAppraiseEN._CurrTabName_S);
List<clsvCourseLearningAppraiseEN> arrvCourseLearningAppraiseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCourseLearningAppraiseEN> arrvCourseLearningAppraiseObjLst_Sel =
from objvCourseLearningAppraiseEN in arrvCourseLearningAppraiseObjLst_Cache
where objvCourseLearningAppraiseEN.id_MicroteachAppraise == lngid_MicroteachAppraise
select objvCourseLearningAppraiseEN;
if (arrvCourseLearningAppraiseObjLst_Sel.Count() == 0)
{
   clsvCourseLearningAppraiseEN obj = clsvCourseLearningAppraiseWApi.GetObjByid_MicroteachAppraise(lngid_MicroteachAppraise);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCourseLearningAppraiseObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningAppraiseEN> GetObjLst(string strWhereCond)
{
 List<clsvCourseLearningAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningAppraiseEN> GetObjLstById_MicroteachAppraiseLst(List<long> arrId_MicroteachAppraise)
{
 List<clsvCourseLearningAppraiseEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroteachAppraiseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroteachAppraise);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_MicroteachAppraise">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvCourseLearningAppraiseEN> GetObjLstById_MicroteachAppraiseLst_Cache(List<long> arrId_MicroteachAppraise)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCourseLearningAppraiseEN._CurrTabName_S);
List<clsvCourseLearningAppraiseEN> arrvCourseLearningAppraiseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCourseLearningAppraiseEN> arrvCourseLearningAppraiseObjLst_Sel =
from objvCourseLearningAppraiseEN in arrvCourseLearningAppraiseObjLst_Cache
where arrId_MicroteachAppraise.Contains(objvCourseLearningAppraiseEN.id_MicroteachAppraise)
select objvCourseLearningAppraiseEN;
return arrvCourseLearningAppraiseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningAppraiseEN> GetObjLstById_MicroteachAppraiseLst_WA_Cache(List<long> arrId_MicroteachAppraise)
{
 List<clsvCourseLearningAppraiseEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroteachAppraiseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroteachAppraise);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningAppraiseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCourseLearningAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningAppraiseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCourseLearningAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningAppraiseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCourseLearningAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningAppraiseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCourseLearningAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_MicroteachAppraise)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachAppraise"] = lngid_MicroteachAppraise.ToString()
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
 /// <param name = "objvCourseLearningAppraiseENS">源对象</param>
 /// <param name = "objvCourseLearningAppraiseENT">目标对象</param>
 public static void CopyTo(clsvCourseLearningAppraiseEN objvCourseLearningAppraiseENS, clsvCourseLearningAppraiseEN objvCourseLearningAppraiseENT)
{
try
{
objvCourseLearningAppraiseENT.Id_CourseLearningCase = objvCourseLearningAppraiseENS.Id_CourseLearningCase; //课程学习案例流水号
objvCourseLearningAppraiseENT.CourseLearningCaseID = objvCourseLearningAppraiseENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningAppraiseENT.CourseLearningCaseName = objvCourseLearningAppraiseENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningAppraiseENT.CourseLearningCaseTheme = objvCourseLearningAppraiseENS.CourseLearningCaseTheme; //课程学习案例主题词
objvCourseLearningAppraiseENT.CourseLearningCaseDate = objvCourseLearningAppraiseENS.CourseLearningCaseDate; //课程学习日期
objvCourseLearningAppraiseENT.CourseLearningCaseTime = objvCourseLearningAppraiseENS.CourseLearningCaseTime; //课程学习时间
objvCourseLearningAppraiseENT.CourseLearningCaseDateIn = objvCourseLearningAppraiseENS.CourseLearningCaseDateIn; //案例入库日期
objvCourseLearningAppraiseENT.CourseLearningCaseTimeIn = objvCourseLearningAppraiseENS.CourseLearningCaseTimeIn; //案例入库时间
objvCourseLearningAppraiseENT.CourseLearningCaseTypeName = objvCourseLearningAppraiseENS.CourseLearningCaseTypeName; //课程学习案例类型名称
objvCourseLearningAppraiseENT.UserNameWithUserId = objvCourseLearningAppraiseENS.UserNameWithUserId; //UserNameWithUserId
objvCourseLearningAppraiseENT.id_XzCollege = objvCourseLearningAppraiseENS.id_XzCollege; //学院流水号
objvCourseLearningAppraiseENT.CollegeID = objvCourseLearningAppraiseENS.CollegeID; //学院ID
objvCourseLearningAppraiseENT.CollegeName = objvCourseLearningAppraiseENS.CollegeName; //学院名称
objvCourseLearningAppraiseENT.id_XzMajor = objvCourseLearningAppraiseENS.id_XzMajor; //专业流水号
objvCourseLearningAppraiseENT.MajorID = objvCourseLearningAppraiseENS.MajorID; //专业ID
objvCourseLearningAppraiseENT.MajorName = objvCourseLearningAppraiseENS.MajorName; //专业名称
objvCourseLearningAppraiseENT.CourseId = objvCourseLearningAppraiseENS.CourseId; //课程Id
objvCourseLearningAppraiseENT.CourseCode = objvCourseLearningAppraiseENS.CourseCode; //课程代码
objvCourseLearningAppraiseENT.CourseName = objvCourseLearningAppraiseENS.CourseName; //课程名称
objvCourseLearningAppraiseENT.CollegeNameA = objvCourseLearningAppraiseENS.CollegeNameA; //学院名称简写
objvCourseLearningAppraiseENT.id_MicroteachAppraise = objvCourseLearningAppraiseENS.id_MicroteachAppraise; //评议流水号
objvCourseLearningAppraiseENT.FuncModuleId = objvCourseLearningAppraiseENS.FuncModuleId; //功能模块Id
objvCourseLearningAppraiseENT.FuncModuleName = objvCourseLearningAppraiseENS.FuncModuleName; //功能模块名称
objvCourseLearningAppraiseENT.id_MicroteachCase = objvCourseLearningAppraiseENS.id_MicroteachCase; //微格教学案例流水号
objvCourseLearningAppraiseENT.id_AppraiseType = objvCourseLearningAppraiseENS.id_AppraiseType; //评议类型流水号
objvCourseLearningAppraiseENT.AppraiseTypeName = objvCourseLearningAppraiseENS.AppraiseTypeName; //评议类型名称
objvCourseLearningAppraiseENT.AppraiseTheme = objvCourseLearningAppraiseENS.AppraiseTheme; //评议主题
objvCourseLearningAppraiseENT.AppraiseContent = objvCourseLearningAppraiseENS.AppraiseContent; //评议内容
objvCourseLearningAppraiseENT.AppraiseDate = objvCourseLearningAppraiseENS.AppraiseDate; //评议日期
objvCourseLearningAppraiseENT.AppraiseTime = objvCourseLearningAppraiseENS.AppraiseTime; //评议时间
objvCourseLearningAppraiseENT.IsVisual = objvCourseLearningAppraiseENS.IsVisual; //隐藏标志
objvCourseLearningAppraiseENT.IsElite = objvCourseLearningAppraiseENS.IsElite; //精华标志
objvCourseLearningAppraiseENT.UserId = objvCourseLearningAppraiseENS.UserId; //用户ID
objvCourseLearningAppraiseENT.ExcellentOne = objvCourseLearningAppraiseENS.ExcellentOne; //优点1
objvCourseLearningAppraiseENT.ExcellentTwo = objvCourseLearningAppraiseENS.ExcellentTwo; //优点2
objvCourseLearningAppraiseENT.SuggestOne = objvCourseLearningAppraiseENS.SuggestOne; //建议1
objvCourseLearningAppraiseENT.SuggestTwo = objvCourseLearningAppraiseENS.SuggestTwo; //建议2
objvCourseLearningAppraiseENT.MicroteachAppriseScore = objvCourseLearningAppraiseENS.MicroteachAppriseScore; //打分
objvCourseLearningAppraiseENT.VideoStopTime = objvCourseLearningAppraiseENS.VideoStopTime; //公开课案例视频暂停时间
objvCourseLearningAppraiseENT.BrowseCount = objvCourseLearningAppraiseENS.BrowseCount; //浏览次数
objvCourseLearningAppraiseENT.BrowseCount4Case = objvCourseLearningAppraiseENS.BrowseCount4Case; //课例浏览次数
objvCourseLearningAppraiseENT.UserName = objvCourseLearningAppraiseENS.UserName; //用户名
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
public static DataTable ToDataTable(List<clsvCourseLearningAppraiseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCourseLearningAppraiseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCourseLearningAppraiseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCourseLearningAppraiseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCourseLearningAppraiseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCourseLearningAppraiseEN.AttributeName)
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
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachAppraiseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachAppraiseWApi没有刷新缓存机制(clsMicroteachAppraiseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAppraiseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppraiseTypeWApi没有刷新缓存机制(clsAppraiseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserStateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserStateWApi没有刷新缓存机制(clsUserStateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzGradeBaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseWApi没有刷新缓存机制(clsXzGradeBaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserIdentityWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserIdentityWApi没有刷新缓存机制(clsUserIdentityWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelWApi没有刷新缓存机制(clsStudyLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCourseLearningCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCourseLearningCaseWApi没有刷新缓存机制(clsCourseLearningCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCourseLearningCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCourseLearningCaseTypeWApi没有刷新缓存机制(clsCourseLearningCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeWApi没有刷新缓存机制(clsRecommendedDegreeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeVersionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionWApi没有刷新缓存机制(clsSenateGaugeVersionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseLevelWApi没有刷新缓存机制(clsCaseLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseTypeWApi没有刷新缓存机制(clsCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseChapterWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterWApi没有刷新缓存机制(clscc_CourseChapterWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzDegreeTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzDegreeTypeWApi没有刷新缓存机制(clsXzDegreeTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorTypeWApi没有刷新缓存机制(clsXzMajorTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorShoolTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorShoolTypeWApi没有刷新缓存机制(clsXzMajorShoolTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSkillTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSkillTypeWApi没有刷新缓存机制(clsSkillTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachSkillWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachSkillWApi没有刷新缓存机制(clsTeachSkillWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_MicroteachAppraise");
//if (arrvCourseLearningAppraiseObjLst_Cache == null)
//{
//arrvCourseLearningAppraiseObjLst_Cache = await clsvCourseLearningAppraiseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCourseLearningAppraiseEN._CurrTabName_S);
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
public static List<clsvCourseLearningAppraiseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCourseLearningAppraiseEN._CurrTabName_S);
List<clsvCourseLearningAppraiseEN> arrvCourseLearningAppraiseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCourseLearningAppraiseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCourseLearningAppraiseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCourseLearningAppraise.Id_CourseLearningCase, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.CourseLearningCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.CourseLearningCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.CourseLearningCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.CourseLearningCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.CourseLearningCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.CourseLearningCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.CourseLearningCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.CourseLearningCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.UserNameWithUserId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.id_MicroteachAppraise, Type.GetType("System.Int64"));
objDT.Columns.Add(convCourseLearningAppraise.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.id_AppraiseType, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.AppraiseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.AppraiseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.AppraiseContent, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.AppraiseDate, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.AppraiseTime, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.IsVisual, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCourseLearningAppraise.IsElite, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCourseLearningAppraise.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.ExcellentOne, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.ExcellentTwo, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.SuggestOne, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.SuggestTwo, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.MicroteachAppriseScore, Type.GetType("System.Single"));
objDT.Columns.Add(convCourseLearningAppraise.VideoStopTime, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningAppraise.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningAppraise.UserName, Type.GetType("System.String"));
foreach (clsvCourseLearningAppraiseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCourseLearningAppraise.Id_CourseLearningCase] = objInFor[convCourseLearningAppraise.Id_CourseLearningCase];
objDR[convCourseLearningAppraise.CourseLearningCaseID] = objInFor[convCourseLearningAppraise.CourseLearningCaseID];
objDR[convCourseLearningAppraise.CourseLearningCaseName] = objInFor[convCourseLearningAppraise.CourseLearningCaseName];
objDR[convCourseLearningAppraise.CourseLearningCaseTheme] = objInFor[convCourseLearningAppraise.CourseLearningCaseTheme];
objDR[convCourseLearningAppraise.CourseLearningCaseDate] = objInFor[convCourseLearningAppraise.CourseLearningCaseDate];
objDR[convCourseLearningAppraise.CourseLearningCaseTime] = objInFor[convCourseLearningAppraise.CourseLearningCaseTime];
objDR[convCourseLearningAppraise.CourseLearningCaseDateIn] = objInFor[convCourseLearningAppraise.CourseLearningCaseDateIn];
objDR[convCourseLearningAppraise.CourseLearningCaseTimeIn] = objInFor[convCourseLearningAppraise.CourseLearningCaseTimeIn];
objDR[convCourseLearningAppraise.CourseLearningCaseTypeName] = objInFor[convCourseLearningAppraise.CourseLearningCaseTypeName];
objDR[convCourseLearningAppraise.UserNameWithUserId] = objInFor[convCourseLearningAppraise.UserNameWithUserId];
objDR[convCourseLearningAppraise.id_XzCollege] = objInFor[convCourseLearningAppraise.id_XzCollege];
objDR[convCourseLearningAppraise.CollegeID] = objInFor[convCourseLearningAppraise.CollegeID];
objDR[convCourseLearningAppraise.CollegeName] = objInFor[convCourseLearningAppraise.CollegeName];
objDR[convCourseLearningAppraise.id_XzMajor] = objInFor[convCourseLearningAppraise.id_XzMajor];
objDR[convCourseLearningAppraise.MajorID] = objInFor[convCourseLearningAppraise.MajorID];
objDR[convCourseLearningAppraise.MajorName] = objInFor[convCourseLearningAppraise.MajorName];
objDR[convCourseLearningAppraise.CourseId] = objInFor[convCourseLearningAppraise.CourseId];
objDR[convCourseLearningAppraise.CourseCode] = objInFor[convCourseLearningAppraise.CourseCode];
objDR[convCourseLearningAppraise.CourseName] = objInFor[convCourseLearningAppraise.CourseName];
objDR[convCourseLearningAppraise.CollegeNameA] = objInFor[convCourseLearningAppraise.CollegeNameA];
objDR[convCourseLearningAppraise.id_MicroteachAppraise] = objInFor[convCourseLearningAppraise.id_MicroteachAppraise];
objDR[convCourseLearningAppraise.FuncModuleId] = objInFor[convCourseLearningAppraise.FuncModuleId];
objDR[convCourseLearningAppraise.FuncModuleName] = objInFor[convCourseLearningAppraise.FuncModuleName];
objDR[convCourseLearningAppraise.id_MicroteachCase] = objInFor[convCourseLearningAppraise.id_MicroteachCase];
objDR[convCourseLearningAppraise.id_AppraiseType] = objInFor[convCourseLearningAppraise.id_AppraiseType];
objDR[convCourseLearningAppraise.AppraiseTypeName] = objInFor[convCourseLearningAppraise.AppraiseTypeName];
objDR[convCourseLearningAppraise.AppraiseTheme] = objInFor[convCourseLearningAppraise.AppraiseTheme];
objDR[convCourseLearningAppraise.AppraiseContent] = objInFor[convCourseLearningAppraise.AppraiseContent];
objDR[convCourseLearningAppraise.AppraiseDate] = objInFor[convCourseLearningAppraise.AppraiseDate];
objDR[convCourseLearningAppraise.AppraiseTime] = objInFor[convCourseLearningAppraise.AppraiseTime];
objDR[convCourseLearningAppraise.IsVisual] = objInFor[convCourseLearningAppraise.IsVisual];
objDR[convCourseLearningAppraise.IsElite] = objInFor[convCourseLearningAppraise.IsElite];
objDR[convCourseLearningAppraise.UserId] = objInFor[convCourseLearningAppraise.UserId];
objDR[convCourseLearningAppraise.ExcellentOne] = objInFor[convCourseLearningAppraise.ExcellentOne];
objDR[convCourseLearningAppraise.ExcellentTwo] = objInFor[convCourseLearningAppraise.ExcellentTwo];
objDR[convCourseLearningAppraise.SuggestOne] = objInFor[convCourseLearningAppraise.SuggestOne];
objDR[convCourseLearningAppraise.SuggestTwo] = objInFor[convCourseLearningAppraise.SuggestTwo];
objDR[convCourseLearningAppraise.MicroteachAppriseScore] = objInFor[convCourseLearningAppraise.MicroteachAppriseScore];
objDR[convCourseLearningAppraise.VideoStopTime] = objInFor[convCourseLearningAppraise.VideoStopTime];
objDR[convCourseLearningAppraise.BrowseCount] = objInFor[convCourseLearningAppraise.BrowseCount];
objDR[convCourseLearningAppraise.BrowseCount4Case] = objInFor[convCourseLearningAppraise.BrowseCount4Case];
objDR[convCourseLearningAppraise.UserName] = objInFor[convCourseLearningAppraise.UserName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}