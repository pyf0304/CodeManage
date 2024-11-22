
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseTeacherRelation4AppWApi
 表名:vcc_CourseTeacherRelation4App(01120260)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:38:11
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程管理
 模块英文名:CourseManage
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
public static class clsvcc_CourseTeacherRelation4AppWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetCourseTeacherRelationId(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, long lngCourseTeacherRelationId, string strComparisonOp="")
	{
objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId = lngCourseTeacherRelationId; //课程教师关系表流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.CourseTeacherRelationId) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.CourseTeacherRelationId, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.CourseTeacherRelationId] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetCourseId(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convcc_CourseTeacherRelation4App.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_CourseTeacherRelation4App.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_CourseTeacherRelation4App.CourseId);
objvcc_CourseTeacherRelation4AppEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.CourseId) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.CourseId, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.CourseId] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetCourseCode(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convcc_CourseTeacherRelation4App.CourseCode);
objvcc_CourseTeacherRelation4AppEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.CourseCode) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.CourseCode, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.CourseCode] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetCourseDescription(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strCourseDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseDescription, 8000, convcc_CourseTeacherRelation4App.CourseDescription);
objvcc_CourseTeacherRelation4AppEN.CourseDescription = strCourseDescription; //课程描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.CourseDescription) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.CourseDescription, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.CourseDescription] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetCourseName(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_CourseTeacherRelation4App.CourseName);
objvcc_CourseTeacherRelation4AppEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.CourseName) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.CourseName, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.CourseName] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetCourseTypeID(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strCourseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseTypeID, 4, convcc_CourseTeacherRelation4App.CourseTypeID);
clsCheckSql.CheckFieldForeignKey(strCourseTypeID, 4, convcc_CourseTeacherRelation4App.CourseTypeID);
objvcc_CourseTeacherRelation4AppEN.CourseTypeID = strCourseTypeID; //课程类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.CourseTypeID) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.CourseTypeID, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.CourseTypeID] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetCreateDate(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convcc_CourseTeacherRelation4App.CreateDate);
objvcc_CourseTeacherRelation4AppEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.CreateDate) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.CreateDate, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.CreateDate] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetIsOpen(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, bool bolIsOpen, string strComparisonOp="")
	{
objvcc_CourseTeacherRelation4AppEN.IsOpen = bolIsOpen; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.IsOpen) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.IsOpen, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.IsOpen] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetIsRecommendedCourse(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, bool bolIsRecommendedCourse, string strComparisonOp="")
	{
objvcc_CourseTeacherRelation4AppEN.IsRecommendedCourse = bolIsRecommendedCourse; //是否推荐课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.IsRecommendedCourse) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.IsRecommendedCourse, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.IsRecommendedCourse] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetOrderNum(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, int intOrderNum, string strComparisonOp="")
	{
objvcc_CourseTeacherRelation4AppEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.OrderNum) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.OrderNum, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.OrderNum] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetExampleImgPath(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strExampleImgPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExampleImgPath, 300, convcc_CourseTeacherRelation4App.ExampleImgPath);
objvcc_CourseTeacherRelation4AppEN.ExampleImgPath = strExampleImgPath; //示例图路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.ExampleImgPath) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.ExampleImgPath, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.ExampleImgPath] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetViewCount(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, int intViewCount, string strComparisonOp="")
	{
objvcc_CourseTeacherRelation4AppEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.ViewCount) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.ViewCount, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.ViewCount] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN Setid_XzMajor(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convcc_CourseTeacherRelation4App.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convcc_CourseTeacherRelation4App.id_XzMajor);
objvcc_CourseTeacherRelation4AppEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.id_XzMajor) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.id_XzMajor, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.id_XzMajor] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN Setid_XzCollege(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convcc_CourseTeacherRelation4App.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convcc_CourseTeacherRelation4App.id_XzCollege);
objvcc_CourseTeacherRelation4AppEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.id_XzCollege) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.id_XzCollege, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.id_XzCollege] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN Setid_Teacher(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strid_Teacher, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Teacher, convcc_CourseTeacherRelation4App.id_Teacher);
clsCheckSql.CheckFieldLen(strid_Teacher, 8, convcc_CourseTeacherRelation4App.id_Teacher);
clsCheckSql.CheckFieldForeignKey(strid_Teacher, 8, convcc_CourseTeacherRelation4App.id_Teacher);
objvcc_CourseTeacherRelation4AppEN.id_Teacher = strid_Teacher; //教师流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.id_Teacher) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.id_Teacher, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.id_Teacher] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetTeacherID(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeacherID, 12, convcc_CourseTeacherRelation4App.TeacherID);
objvcc_CourseTeacherRelation4AppEN.TeacherID = strTeacherID; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.TeacherID) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.TeacherID, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.TeacherID] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetTeacherName(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strTeacherName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeacherName, 50, convcc_CourseTeacherRelation4App.TeacherName);
objvcc_CourseTeacherRelation4AppEN.TeacherName = strTeacherName; //教师姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.TeacherName) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.TeacherName, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.TeacherName] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetIsCourseManager(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, bool bolIsCourseManager, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsCourseManager, convcc_CourseTeacherRelation4App.IsCourseManager);
objvcc_CourseTeacherRelation4AppEN.IsCourseManager = bolIsCourseManager; //是否课程主要人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.IsCourseManager) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.IsCourseManager, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.IsCourseManager] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetLastVisitedDate(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strLastVisitedDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLastVisitedDate, 14, convcc_CourseTeacherRelation4App.LastVisitedDate);
objvcc_CourseTeacherRelation4AppEN.LastVisitedDate = strLastVisitedDate; //最后访问时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.LastVisitedDate) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.LastVisitedDate, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.LastVisitedDate] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetUpdDate(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_CourseTeacherRelation4App.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_CourseTeacherRelation4App.UpdDate);
objvcc_CourseTeacherRelation4AppEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.UpdDate) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.UpdDate, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.UpdDate] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetUpdUser(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convcc_CourseTeacherRelation4App.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convcc_CourseTeacherRelation4App.UpdUser);
objvcc_CourseTeacherRelation4AppEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.UpdUser) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.UpdUser, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.UpdUser] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetMemo(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_CourseTeacherRelation4App.Memo);
objvcc_CourseTeacherRelation4AppEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.Memo) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.Memo, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.Memo] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4App_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_CourseTeacherRelation4App_Cond.IsUpdated(convcc_CourseTeacherRelation4App.CourseTeacherRelationId) == true)
{
string strComparisonOp_CourseTeacherRelationId = objvcc_CourseTeacherRelation4App_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.CourseTeacherRelationId];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseTeacherRelation4App.CourseTeacherRelationId, objvcc_CourseTeacherRelation4App_Cond.CourseTeacherRelationId, strComparisonOp_CourseTeacherRelationId);
}
if (objvcc_CourseTeacherRelation4App_Cond.IsUpdated(convcc_CourseTeacherRelation4App.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_CourseTeacherRelation4App_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.CourseId, objvcc_CourseTeacherRelation4App_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_CourseTeacherRelation4App_Cond.IsUpdated(convcc_CourseTeacherRelation4App.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvcc_CourseTeacherRelation4App_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.CourseCode, objvcc_CourseTeacherRelation4App_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvcc_CourseTeacherRelation4App_Cond.IsUpdated(convcc_CourseTeacherRelation4App.CourseDescription) == true)
{
string strComparisonOp_CourseDescription = objvcc_CourseTeacherRelation4App_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.CourseDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.CourseDescription, objvcc_CourseTeacherRelation4App_Cond.CourseDescription, strComparisonOp_CourseDescription);
}
if (objvcc_CourseTeacherRelation4App_Cond.IsUpdated(convcc_CourseTeacherRelation4App.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_CourseTeacherRelation4App_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.CourseName, objvcc_CourseTeacherRelation4App_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_CourseTeacherRelation4App_Cond.IsUpdated(convcc_CourseTeacherRelation4App.CourseTypeID) == true)
{
string strComparisonOp_CourseTypeID = objvcc_CourseTeacherRelation4App_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.CourseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.CourseTypeID, objvcc_CourseTeacherRelation4App_Cond.CourseTypeID, strComparisonOp_CourseTypeID);
}
if (objvcc_CourseTeacherRelation4App_Cond.IsUpdated(convcc_CourseTeacherRelation4App.CreateDate) == true)
{
string strComparisonOp_CreateDate = objvcc_CourseTeacherRelation4App_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.CreateDate, objvcc_CourseTeacherRelation4App_Cond.CreateDate, strComparisonOp_CreateDate);
}
if (objvcc_CourseTeacherRelation4App_Cond.IsUpdated(convcc_CourseTeacherRelation4App.IsOpen) == true)
{
if (objvcc_CourseTeacherRelation4App_Cond.IsOpen == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseTeacherRelation4App.IsOpen);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseTeacherRelation4App.IsOpen);
}
}
if (objvcc_CourseTeacherRelation4App_Cond.IsUpdated(convcc_CourseTeacherRelation4App.IsRecommendedCourse) == true)
{
if (objvcc_CourseTeacherRelation4App_Cond.IsRecommendedCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseTeacherRelation4App.IsRecommendedCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseTeacherRelation4App.IsRecommendedCourse);
}
}
if (objvcc_CourseTeacherRelation4App_Cond.IsUpdated(convcc_CourseTeacherRelation4App.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvcc_CourseTeacherRelation4App_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseTeacherRelation4App.OrderNum, objvcc_CourseTeacherRelation4App_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvcc_CourseTeacherRelation4App_Cond.IsUpdated(convcc_CourseTeacherRelation4App.ExampleImgPath) == true)
{
string strComparisonOp_ExampleImgPath = objvcc_CourseTeacherRelation4App_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.ExampleImgPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.ExampleImgPath, objvcc_CourseTeacherRelation4App_Cond.ExampleImgPath, strComparisonOp_ExampleImgPath);
}
if (objvcc_CourseTeacherRelation4App_Cond.IsUpdated(convcc_CourseTeacherRelation4App.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvcc_CourseTeacherRelation4App_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseTeacherRelation4App.ViewCount, objvcc_CourseTeacherRelation4App_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvcc_CourseTeacherRelation4App_Cond.IsUpdated(convcc_CourseTeacherRelation4App.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvcc_CourseTeacherRelation4App_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.id_XzMajor, objvcc_CourseTeacherRelation4App_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvcc_CourseTeacherRelation4App_Cond.IsUpdated(convcc_CourseTeacherRelation4App.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvcc_CourseTeacherRelation4App_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.id_XzCollege, objvcc_CourseTeacherRelation4App_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvcc_CourseTeacherRelation4App_Cond.IsUpdated(convcc_CourseTeacherRelation4App.id_Teacher) == true)
{
string strComparisonOp_id_Teacher = objvcc_CourseTeacherRelation4App_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.id_Teacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.id_Teacher, objvcc_CourseTeacherRelation4App_Cond.id_Teacher, strComparisonOp_id_Teacher);
}
if (objvcc_CourseTeacherRelation4App_Cond.IsUpdated(convcc_CourseTeacherRelation4App.TeacherID) == true)
{
string strComparisonOp_TeacherID = objvcc_CourseTeacherRelation4App_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.TeacherID, objvcc_CourseTeacherRelation4App_Cond.TeacherID, strComparisonOp_TeacherID);
}
if (objvcc_CourseTeacherRelation4App_Cond.IsUpdated(convcc_CourseTeacherRelation4App.TeacherName) == true)
{
string strComparisonOp_TeacherName = objvcc_CourseTeacherRelation4App_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.TeacherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.TeacherName, objvcc_CourseTeacherRelation4App_Cond.TeacherName, strComparisonOp_TeacherName);
}
if (objvcc_CourseTeacherRelation4App_Cond.IsUpdated(convcc_CourseTeacherRelation4App.IsCourseManager) == true)
{
if (objvcc_CourseTeacherRelation4App_Cond.IsCourseManager == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseTeacherRelation4App.IsCourseManager);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseTeacherRelation4App.IsCourseManager);
}
}
if (objvcc_CourseTeacherRelation4App_Cond.IsUpdated(convcc_CourseTeacherRelation4App.LastVisitedDate) == true)
{
string strComparisonOp_LastVisitedDate = objvcc_CourseTeacherRelation4App_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.LastVisitedDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.LastVisitedDate, objvcc_CourseTeacherRelation4App_Cond.LastVisitedDate, strComparisonOp_LastVisitedDate);
}
if (objvcc_CourseTeacherRelation4App_Cond.IsUpdated(convcc_CourseTeacherRelation4App.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_CourseTeacherRelation4App_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.UpdDate, objvcc_CourseTeacherRelation4App_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_CourseTeacherRelation4App_Cond.IsUpdated(convcc_CourseTeacherRelation4App.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvcc_CourseTeacherRelation4App_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.UpdUser, objvcc_CourseTeacherRelation4App_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvcc_CourseTeacherRelation4App_Cond.IsUpdated(convcc_CourseTeacherRelation4App.Memo) == true)
{
string strComparisonOp_Memo = objvcc_CourseTeacherRelation4App_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.Memo, objvcc_CourseTeacherRelation4App_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课程和教师关系4App(vcc_CourseTeacherRelation4App)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_CourseTeacherRelation4AppWApi
{
private static readonly string mstrApiControllerName = "vcc_CourseTeacherRelation4AppApi";

 public clsvcc_CourseTeacherRelation4AppWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngCourseTeacherRelationId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseTeacherRelation4AppEN GetObjByCourseTeacherRelationId(long lngCourseTeacherRelationId)
{
string strAction = "GetObjByCourseTeacherRelationId";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseTeacherRelationId"] = lngCourseTeacherRelationId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_CourseTeacherRelation4AppEN = JsonConvert.DeserializeObject<clsvcc_CourseTeacherRelation4AppEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseTeacherRelation4AppEN;
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
 /// <param name = "lngCourseTeacherRelationId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseTeacherRelation4AppEN GetObjByCourseTeacherRelationId_WA_Cache(long lngCourseTeacherRelationId, string strCourseId)
{
string strAction = "GetObjByCourseTeacherRelationId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseTeacherRelationId"] = lngCourseTeacherRelationId.ToString(),
["CourseId"] = strCourseId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_CourseTeacherRelation4AppEN = JsonConvert.DeserializeObject<clsvcc_CourseTeacherRelation4AppEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseTeacherRelation4AppEN;
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
public static clsvcc_CourseTeacherRelation4AppEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN = null;
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
objvcc_CourseTeacherRelation4AppEN = JsonConvert.DeserializeObject<clsvcc_CourseTeacherRelation4AppEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseTeacherRelation4AppEN;
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
 /// <param name = "lngCourseTeacherRelationId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseTeacherRelation4AppEN GetObjByCourseTeacherRelationId_Cache(long lngCourseTeacherRelationId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_CourseTeacherRelation4AppEN._CurrTabName_S, strCourseId);
List<clsvcc_CourseTeacherRelation4AppEN> arrvcc_CourseTeacherRelation4AppObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvcc_CourseTeacherRelation4AppEN> arrvcc_CourseTeacherRelation4AppObjLst_Sel =
from objvcc_CourseTeacherRelation4AppEN in arrvcc_CourseTeacherRelation4AppObjLst_Cache
where objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId == lngCourseTeacherRelationId
select objvcc_CourseTeacherRelation4AppEN;
if (arrvcc_CourseTeacherRelation4AppObjLst_Sel.Count() == 0)
{
   clsvcc_CourseTeacherRelation4AppEN obj = clsvcc_CourseTeacherRelation4AppWApi.GetObjByCourseTeacherRelationId(lngCourseTeacherRelationId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_CourseTeacherRelation4AppObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseTeacherRelation4AppEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_CourseTeacherRelation4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseTeacherRelation4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseTeacherRelation4AppEN> GetObjLstByCourseTeacherRelationIdLst(List<long> arrCourseTeacherRelationId)
{
 List<clsvcc_CourseTeacherRelation4AppEN> arrObjLst = null; 
string strAction = "GetObjLstByCourseTeacherRelationIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCourseTeacherRelationId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseTeacherRelation4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngCourseTeacherRelationId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvcc_CourseTeacherRelation4AppEN> GetObjLstByCourseTeacherRelationIdLst_Cache(List<long> arrCourseTeacherRelationId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_CourseTeacherRelation4AppEN._CurrTabName_S, strCourseId);
List<clsvcc_CourseTeacherRelation4AppEN> arrvcc_CourseTeacherRelation4AppObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvcc_CourseTeacherRelation4AppEN> arrvcc_CourseTeacherRelation4AppObjLst_Sel =
from objvcc_CourseTeacherRelation4AppEN in arrvcc_CourseTeacherRelation4AppObjLst_Cache
where arrCourseTeacherRelationId.Contains(objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId)
select objvcc_CourseTeacherRelation4AppEN;
return arrvcc_CourseTeacherRelation4AppObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseTeacherRelation4AppEN> GetObjLstByCourseTeacherRelationIdLst_WA_Cache(List<long> arrCourseTeacherRelationId, string strCourseId)
{
 List<clsvcc_CourseTeacherRelation4AppEN> arrObjLst = null; 
string strAction = "GetObjLstByCourseTeacherRelationIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCourseTeacherRelationId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseTeacherRelation4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseTeacherRelation4AppEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_CourseTeacherRelation4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseTeacherRelation4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseTeacherRelation4AppEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_CourseTeacherRelation4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseTeacherRelation4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseTeacherRelation4AppEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_CourseTeacherRelation4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseTeacherRelation4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseTeacherRelation4AppEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_CourseTeacherRelation4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseTeacherRelation4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngCourseTeacherRelationId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseTeacherRelationId"] = lngCourseTeacherRelationId.ToString()
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
 /// <param name = "objvcc_CourseTeacherRelation4AppENS">源对象</param>
 /// <param name = "objvcc_CourseTeacherRelation4AppENT">目标对象</param>
 public static void CopyTo(clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppENS, clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppENT)
{
try
{
objvcc_CourseTeacherRelation4AppENT.CourseTeacherRelationId = objvcc_CourseTeacherRelation4AppENS.CourseTeacherRelationId; //课程教师关系表流水号
objvcc_CourseTeacherRelation4AppENT.CourseId = objvcc_CourseTeacherRelation4AppENS.CourseId; //课程Id
objvcc_CourseTeacherRelation4AppENT.CourseCode = objvcc_CourseTeacherRelation4AppENS.CourseCode; //课程代码
objvcc_CourseTeacherRelation4AppENT.CourseDescription = objvcc_CourseTeacherRelation4AppENS.CourseDescription; //课程描述
objvcc_CourseTeacherRelation4AppENT.CourseName = objvcc_CourseTeacherRelation4AppENS.CourseName; //课程名称
objvcc_CourseTeacherRelation4AppENT.CourseTypeID = objvcc_CourseTeacherRelation4AppENS.CourseTypeID; //课程类型ID
objvcc_CourseTeacherRelation4AppENT.CreateDate = objvcc_CourseTeacherRelation4AppENS.CreateDate; //建立日期
objvcc_CourseTeacherRelation4AppENT.IsOpen = objvcc_CourseTeacherRelation4AppENS.IsOpen; //是否公开
objvcc_CourseTeacherRelation4AppENT.IsRecommendedCourse = objvcc_CourseTeacherRelation4AppENS.IsRecommendedCourse; //是否推荐课程
objvcc_CourseTeacherRelation4AppENT.OrderNum = objvcc_CourseTeacherRelation4AppENS.OrderNum; //序号
objvcc_CourseTeacherRelation4AppENT.ExampleImgPath = objvcc_CourseTeacherRelation4AppENS.ExampleImgPath; //示例图路径
objvcc_CourseTeacherRelation4AppENT.ViewCount = objvcc_CourseTeacherRelation4AppENS.ViewCount; //浏览量
objvcc_CourseTeacherRelation4AppENT.id_XzMajor = objvcc_CourseTeacherRelation4AppENS.id_XzMajor; //专业流水号
objvcc_CourseTeacherRelation4AppENT.id_XzCollege = objvcc_CourseTeacherRelation4AppENS.id_XzCollege; //学院流水号
objvcc_CourseTeacherRelation4AppENT.id_Teacher = objvcc_CourseTeacherRelation4AppENS.id_Teacher; //教师流水号
objvcc_CourseTeacherRelation4AppENT.TeacherID = objvcc_CourseTeacherRelation4AppENS.TeacherID; //教师工号
objvcc_CourseTeacherRelation4AppENT.TeacherName = objvcc_CourseTeacherRelation4AppENS.TeacherName; //教师姓名
objvcc_CourseTeacherRelation4AppENT.IsCourseManager = objvcc_CourseTeacherRelation4AppENS.IsCourseManager; //是否课程主要人
objvcc_CourseTeacherRelation4AppENT.LastVisitedDate = objvcc_CourseTeacherRelation4AppENS.LastVisitedDate; //最后访问时间
objvcc_CourseTeacherRelation4AppENT.UpdDate = objvcc_CourseTeacherRelation4AppENS.UpdDate; //修改日期
objvcc_CourseTeacherRelation4AppENT.UpdUser = objvcc_CourseTeacherRelation4AppENS.UpdUser; //修改人
objvcc_CourseTeacherRelation4AppENT.Memo = objvcc_CourseTeacherRelation4AppENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvcc_CourseTeacherRelation4AppEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_CourseTeacherRelation4AppEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_CourseTeacherRelation4AppEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_CourseTeacherRelation4AppEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_CourseTeacherRelation4AppEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_CourseTeacherRelation4AppEN.AttributeName)
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
if (clsTeacherInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeacherInfoWApi没有刷新缓存机制(clsTeacherInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTeacherRelationWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTeacherRelationWApi没有刷新缓存机制(clscc_CourseTeacherRelationWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_ThemesWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesWApi没有刷新缓存机制(clscc_ThemesWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CourseTeacherRelationId");
//if (arrvcc_CourseTeacherRelation4AppObjLst_Cache == null)
//{
//arrvcc_CourseTeacherRelation4AppObjLst_Cache = await clsvcc_CourseTeacherRelation4AppWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsvcc_CourseTeacherRelation4AppEN._CurrTabName_S, strCourseId);
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
public static List<clsvcc_CourseTeacherRelation4AppEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvcc_CourseTeacherRelation4AppEN._CurrTabName_S, strCourseId);
List<clsvcc_CourseTeacherRelation4AppEN> arrvcc_CourseTeacherRelation4AppObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrvcc_CourseTeacherRelation4AppObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_CourseTeacherRelation4AppEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_CourseTeacherRelation4App.CourseTeacherRelationId, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_CourseTeacherRelation4App.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation4App.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation4App.CourseDescription, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation4App.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation4App.CourseTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation4App.CreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation4App.IsOpen, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseTeacherRelation4App.IsRecommendedCourse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseTeacherRelation4App.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseTeacherRelation4App.ExampleImgPath, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation4App.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseTeacherRelation4App.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation4App.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation4App.id_Teacher, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation4App.TeacherID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation4App.TeacherName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation4App.IsCourseManager, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseTeacherRelation4App.LastVisitedDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation4App.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation4App.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation4App.Memo, Type.GetType("System.String"));
foreach (clsvcc_CourseTeacherRelation4AppEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_CourseTeacherRelation4App.CourseTeacherRelationId] = objInFor[convcc_CourseTeacherRelation4App.CourseTeacherRelationId];
objDR[convcc_CourseTeacherRelation4App.CourseId] = objInFor[convcc_CourseTeacherRelation4App.CourseId];
objDR[convcc_CourseTeacherRelation4App.CourseCode] = objInFor[convcc_CourseTeacherRelation4App.CourseCode];
objDR[convcc_CourseTeacherRelation4App.CourseDescription] = objInFor[convcc_CourseTeacherRelation4App.CourseDescription];
objDR[convcc_CourseTeacherRelation4App.CourseName] = objInFor[convcc_CourseTeacherRelation4App.CourseName];
objDR[convcc_CourseTeacherRelation4App.CourseTypeID] = objInFor[convcc_CourseTeacherRelation4App.CourseTypeID];
objDR[convcc_CourseTeacherRelation4App.CreateDate] = objInFor[convcc_CourseTeacherRelation4App.CreateDate];
objDR[convcc_CourseTeacherRelation4App.IsOpen] = objInFor[convcc_CourseTeacherRelation4App.IsOpen];
objDR[convcc_CourseTeacherRelation4App.IsRecommendedCourse] = objInFor[convcc_CourseTeacherRelation4App.IsRecommendedCourse];
objDR[convcc_CourseTeacherRelation4App.OrderNum] = objInFor[convcc_CourseTeacherRelation4App.OrderNum];
objDR[convcc_CourseTeacherRelation4App.ExampleImgPath] = objInFor[convcc_CourseTeacherRelation4App.ExampleImgPath];
objDR[convcc_CourseTeacherRelation4App.ViewCount] = objInFor[convcc_CourseTeacherRelation4App.ViewCount];
objDR[convcc_CourseTeacherRelation4App.id_XzMajor] = objInFor[convcc_CourseTeacherRelation4App.id_XzMajor];
objDR[convcc_CourseTeacherRelation4App.id_XzCollege] = objInFor[convcc_CourseTeacherRelation4App.id_XzCollege];
objDR[convcc_CourseTeacherRelation4App.id_Teacher] = objInFor[convcc_CourseTeacherRelation4App.id_Teacher];
objDR[convcc_CourseTeacherRelation4App.TeacherID] = objInFor[convcc_CourseTeacherRelation4App.TeacherID];
objDR[convcc_CourseTeacherRelation4App.TeacherName] = objInFor[convcc_CourseTeacherRelation4App.TeacherName];
objDR[convcc_CourseTeacherRelation4App.IsCourseManager] = objInFor[convcc_CourseTeacherRelation4App.IsCourseManager];
objDR[convcc_CourseTeacherRelation4App.LastVisitedDate] = objInFor[convcc_CourseTeacherRelation4App.LastVisitedDate];
objDR[convcc_CourseTeacherRelation4App.UpdDate] = objInFor[convcc_CourseTeacherRelation4App.UpdDate];
objDR[convcc_CourseTeacherRelation4App.UpdUser] = objInFor[convcc_CourseTeacherRelation4App.UpdUser];
objDR[convcc_CourseTeacherRelation4App.Memo] = objInFor[convcc_CourseTeacherRelation4App.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}