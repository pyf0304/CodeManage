
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkCorrectKeyWorkWApi
 表名:vcc_WorkCorrectKeyWork(01120192)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:43:21
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
public static class clsvcc_WorkCorrectKeyWorkWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetId_WorkCorrectKeyWork(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, long lngId_WorkCorrectKeyWork, string strComparisonOp="")
	{
objvcc_WorkCorrectKeyWorkEN.Id_WorkCorrectKeyWork = lngId_WorkCorrectKeyWork; //作业批改关键词流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(convcc_WorkCorrectKeyWork.Id_WorkCorrectKeyWork) == false)
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(convcc_WorkCorrectKeyWork.Id_WorkCorrectKeyWork, strComparisonOp);
}
else
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[convcc_WorkCorrectKeyWork.Id_WorkCorrectKeyWork] = strComparisonOp;
}
}
return objvcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetQuestionID(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionID, convcc_WorkCorrectKeyWork.QuestionID);
clsCheckSql.CheckFieldLen(strQuestionID, 8, convcc_WorkCorrectKeyWork.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convcc_WorkCorrectKeyWork.QuestionID);
objvcc_WorkCorrectKeyWorkEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(convcc_WorkCorrectKeyWork.QuestionID) == false)
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(convcc_WorkCorrectKeyWork.QuestionID, strComparisonOp);
}
else
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[convcc_WorkCorrectKeyWork.QuestionID] = strComparisonOp;
}
}
return objvcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetWorkIndex(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, int intWorkIndex, string strComparisonOp="")
	{
objvcc_WorkCorrectKeyWorkEN.WorkIndex = intWorkIndex; //作业序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(convcc_WorkCorrectKeyWork.WorkIndex) == false)
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(convcc_WorkCorrectKeyWork.WorkIndex, strComparisonOp);
}
else
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[convcc_WorkCorrectKeyWork.WorkIndex] = strComparisonOp;
}
}
return objvcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetWorkName(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strWorkName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkName, convcc_WorkCorrectKeyWork.WorkName);
clsCheckSql.CheckFieldLen(strWorkName, 5000, convcc_WorkCorrectKeyWork.WorkName);
objvcc_WorkCorrectKeyWorkEN.WorkName = strWorkName; //作业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(convcc_WorkCorrectKeyWork.WorkName) == false)
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(convcc_WorkCorrectKeyWork.WorkName, strComparisonOp);
}
else
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[convcc_WorkCorrectKeyWork.WorkName] = strComparisonOp;
}
}
return objvcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetWorkDesc(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strWorkDesc, string strComparisonOp="")
	{
objvcc_WorkCorrectKeyWorkEN.WorkDesc = strWorkDesc; //作业说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(convcc_WorkCorrectKeyWork.WorkDesc) == false)
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(convcc_WorkCorrectKeyWork.WorkDesc, strComparisonOp);
}
else
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[convcc_WorkCorrectKeyWork.WorkDesc] = strComparisonOp;
}
}
return objvcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetCourseId(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_WorkCorrectKeyWork.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_WorkCorrectKeyWork.CourseId);
objvcc_WorkCorrectKeyWorkEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(convcc_WorkCorrectKeyWork.CourseId) == false)
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(convcc_WorkCorrectKeyWork.CourseId, strComparisonOp);
}
else
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[convcc_WorkCorrectKeyWork.CourseId] = strComparisonOp;
}
}
return objvcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetCourseName(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_WorkCorrectKeyWork.CourseName);
objvcc_WorkCorrectKeyWorkEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(convcc_WorkCorrectKeyWork.CourseName) == false)
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(convcc_WorkCorrectKeyWork.CourseName, strComparisonOp);
}
else
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[convcc_WorkCorrectKeyWork.CourseName] = strComparisonOp;
}
}
return objvcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetCourseChapterId(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, convcc_WorkCorrectKeyWork.CourseChapterId);
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_WorkCorrectKeyWork.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_WorkCorrectKeyWork.CourseChapterId);
objvcc_WorkCorrectKeyWorkEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(convcc_WorkCorrectKeyWork.CourseChapterId) == false)
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(convcc_WorkCorrectKeyWork.CourseChapterId, strComparisonOp);
}
else
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[convcc_WorkCorrectKeyWork.CourseChapterId] = strComparisonOp;
}
}
return objvcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetCourseChapterName(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterName, convcc_WorkCorrectKeyWork.CourseChapterName);
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_WorkCorrectKeyWork.CourseChapterName);
objvcc_WorkCorrectKeyWorkEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(convcc_WorkCorrectKeyWork.CourseChapterName) == false)
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(convcc_WorkCorrectKeyWork.CourseChapterName, strComparisonOp);
}
else
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[convcc_WorkCorrectKeyWork.CourseChapterName] = strComparisonOp;
}
}
return objvcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetCourseChapterReferred(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strCourseChapterReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convcc_WorkCorrectKeyWork.CourseChapterReferred);
objvcc_WorkCorrectKeyWorkEN.CourseChapterReferred = strCourseChapterReferred; //节简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(convcc_WorkCorrectKeyWork.CourseChapterReferred) == false)
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(convcc_WorkCorrectKeyWork.CourseChapterReferred, strComparisonOp);
}
else
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[convcc_WorkCorrectKeyWork.CourseChapterReferred] = strComparisonOp;
}
}
return objvcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetParentNodeID(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convcc_WorkCorrectKeyWork.ParentNodeID);
objvcc_WorkCorrectKeyWorkEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(convcc_WorkCorrectKeyWork.ParentNodeID) == false)
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(convcc_WorkCorrectKeyWork.ParentNodeID, strComparisonOp);
}
else
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[convcc_WorkCorrectKeyWork.ParentNodeID] = strComparisonOp;
}
}
return objvcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetParentNodeName(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strParentNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convcc_WorkCorrectKeyWork.ParentNodeName);
objvcc_WorkCorrectKeyWorkEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(convcc_WorkCorrectKeyWork.ParentNodeName) == false)
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(convcc_WorkCorrectKeyWork.ParentNodeName, strComparisonOp);
}
else
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[convcc_WorkCorrectKeyWork.ParentNodeName] = strComparisonOp;
}
}
return objvcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetParentNodeReferred(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strParentNodeReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convcc_WorkCorrectKeyWork.ParentNodeReferred);
objvcc_WorkCorrectKeyWorkEN.ParentNodeReferred = strParentNodeReferred; //章简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(convcc_WorkCorrectKeyWork.ParentNodeReferred) == false)
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(convcc_WorkCorrectKeyWork.ParentNodeReferred, strComparisonOp);
}
else
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[convcc_WorkCorrectKeyWork.ParentNodeReferred] = strComparisonOp;
}
}
return objvcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetKeyWorkIndex(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, int intKeyWorkIndex, string strComparisonOp="")
	{
objvcc_WorkCorrectKeyWorkEN.KeyWorkIndex = intKeyWorkIndex; //关键字序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(convcc_WorkCorrectKeyWork.KeyWorkIndex) == false)
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(convcc_WorkCorrectKeyWork.KeyWorkIndex, strComparisonOp);
}
else
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[convcc_WorkCorrectKeyWork.KeyWorkIndex] = strComparisonOp;
}
}
return objvcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetCorrectKeyWork(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strCorrectKeyWork, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCorrectKeyWork, convcc_WorkCorrectKeyWork.CorrectKeyWork);
clsCheckSql.CheckFieldLen(strCorrectKeyWork, 200, convcc_WorkCorrectKeyWork.CorrectKeyWork);
objvcc_WorkCorrectKeyWorkEN.CorrectKeyWork = strCorrectKeyWork; //批改关键词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(convcc_WorkCorrectKeyWork.CorrectKeyWork) == false)
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(convcc_WorkCorrectKeyWork.CorrectKeyWork, strComparisonOp);
}
else
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[convcc_WorkCorrectKeyWork.CorrectKeyWork] = strComparisonOp;
}
}
return objvcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetIsUseFormatPara(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, bool bolIsUseFormatPara, string strComparisonOp="")
	{
objvcc_WorkCorrectKeyWorkEN.IsUseFormatPara = bolIsUseFormatPara; //是否使用格式化参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(convcc_WorkCorrectKeyWork.IsUseFormatPara) == false)
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(convcc_WorkCorrectKeyWork.IsUseFormatPara, strComparisonOp);
}
else
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[convcc_WorkCorrectKeyWork.IsUseFormatPara] = strComparisonOp;
}
}
return objvcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetFormatPara(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strFormatPara, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFormatPara, 100, convcc_WorkCorrectKeyWork.FormatPara);
objvcc_WorkCorrectKeyWorkEN.FormatPara = strFormatPara; //格式化参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(convcc_WorkCorrectKeyWork.FormatPara) == false)
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(convcc_WorkCorrectKeyWork.FormatPara, strComparisonOp);
}
else
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[convcc_WorkCorrectKeyWork.FormatPara] = strComparisonOp;
}
}
return objvcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetInOutTypeId(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strInOutTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strInOutTypeId, convcc_WorkCorrectKeyWork.InOutTypeId);
clsCheckSql.CheckFieldLen(strInOutTypeId, 2, convcc_WorkCorrectKeyWork.InOutTypeId);
clsCheckSql.CheckFieldForeignKey(strInOutTypeId, 2, convcc_WorkCorrectKeyWork.InOutTypeId);
objvcc_WorkCorrectKeyWorkEN.InOutTypeId = strInOutTypeId; //InOut类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(convcc_WorkCorrectKeyWork.InOutTypeId) == false)
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(convcc_WorkCorrectKeyWork.InOutTypeId, strComparisonOp);
}
else
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[convcc_WorkCorrectKeyWork.InOutTypeId] = strComparisonOp;
}
}
return objvcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetInOutTypeName(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strInOutTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strInOutTypeName, convcc_WorkCorrectKeyWork.InOutTypeName);
clsCheckSql.CheckFieldLen(strInOutTypeName, 30, convcc_WorkCorrectKeyWork.InOutTypeName);
objvcc_WorkCorrectKeyWorkEN.InOutTypeName = strInOutTypeName; //InOut类型类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(convcc_WorkCorrectKeyWork.InOutTypeName) == false)
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(convcc_WorkCorrectKeyWork.InOutTypeName, strComparisonOp);
}
else
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[convcc_WorkCorrectKeyWork.InOutTypeName] = strComparisonOp;
}
}
return objvcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetCreator(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strCreator, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreator, 18, convcc_WorkCorrectKeyWork.Creator);
objvcc_WorkCorrectKeyWorkEN.Creator = strCreator; //创建者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(convcc_WorkCorrectKeyWork.Creator) == false)
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(convcc_WorkCorrectKeyWork.Creator, strComparisonOp);
}
else
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[convcc_WorkCorrectKeyWork.Creator] = strComparisonOp;
}
}
return objvcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetCreateDate(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convcc_WorkCorrectKeyWork.CreateDate);
objvcc_WorkCorrectKeyWorkEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(convcc_WorkCorrectKeyWork.CreateDate) == false)
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(convcc_WorkCorrectKeyWork.CreateDate, strComparisonOp);
}
else
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[convcc_WorkCorrectKeyWork.CreateDate] = strComparisonOp;
}
}
return objvcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetIsEnable(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, bool bolIsEnable, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsEnable, convcc_WorkCorrectKeyWork.IsEnable);
objvcc_WorkCorrectKeyWorkEN.IsEnable = bolIsEnable; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(convcc_WorkCorrectKeyWork.IsEnable) == false)
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(convcc_WorkCorrectKeyWork.IsEnable, strComparisonOp);
}
else
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[convcc_WorkCorrectKeyWork.IsEnable] = strComparisonOp;
}
}
return objvcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetUpdDate(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_WorkCorrectKeyWork.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_WorkCorrectKeyWork.UpdDate);
objvcc_WorkCorrectKeyWorkEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(convcc_WorkCorrectKeyWork.UpdDate) == false)
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(convcc_WorkCorrectKeyWork.UpdDate, strComparisonOp);
}
else
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[convcc_WorkCorrectKeyWork.UpdDate] = strComparisonOp;
}
}
return objvcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetUpdUser(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convcc_WorkCorrectKeyWork.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convcc_WorkCorrectKeyWork.UpdUser);
objvcc_WorkCorrectKeyWorkEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(convcc_WorkCorrectKeyWork.UpdUser) == false)
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(convcc_WorkCorrectKeyWork.UpdUser, strComparisonOp);
}
else
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[convcc_WorkCorrectKeyWork.UpdUser] = strComparisonOp;
}
}
return objvcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetMemo(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_WorkCorrectKeyWork.Memo);
objvcc_WorkCorrectKeyWorkEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(convcc_WorkCorrectKeyWork.Memo) == false)
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(convcc_WorkCorrectKeyWork.Memo, strComparisonOp);
}
else
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[convcc_WorkCorrectKeyWork.Memo] = strComparisonOp;
}
}
return objvcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetId_Work(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strId_Work, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_Work, 8, convcc_WorkCorrectKeyWork.Id_Work);
clsCheckSql.CheckFieldForeignKey(strId_Work, 8, convcc_WorkCorrectKeyWork.Id_Work);
objvcc_WorkCorrectKeyWorkEN.Id_Work = strId_Work; //作业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(convcc_WorkCorrectKeyWork.Id_Work) == false)
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(convcc_WorkCorrectKeyWork.Id_Work, strComparisonOp);
}
else
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[convcc_WorkCorrectKeyWork.Id_Work] = strComparisonOp;
}
}
return objvcc_WorkCorrectKeyWorkEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWork_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_WorkCorrectKeyWork_Cond.IsUpdated(convcc_WorkCorrectKeyWork.Id_WorkCorrectKeyWork) == true)
{
string strComparisonOp_Id_WorkCorrectKeyWork = objvcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.Id_WorkCorrectKeyWork];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkCorrectKeyWork.Id_WorkCorrectKeyWork, objvcc_WorkCorrectKeyWork_Cond.Id_WorkCorrectKeyWork, strComparisonOp_Id_WorkCorrectKeyWork);
}
if (objvcc_WorkCorrectKeyWork_Cond.IsUpdated(convcc_WorkCorrectKeyWork.QuestionID) == true)
{
string strComparisonOp_QuestionID = objvcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.QuestionID, objvcc_WorkCorrectKeyWork_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objvcc_WorkCorrectKeyWork_Cond.IsUpdated(convcc_WorkCorrectKeyWork.WorkIndex) == true)
{
string strComparisonOp_WorkIndex = objvcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.WorkIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkCorrectKeyWork.WorkIndex, objvcc_WorkCorrectKeyWork_Cond.WorkIndex, strComparisonOp_WorkIndex);
}
if (objvcc_WorkCorrectKeyWork_Cond.IsUpdated(convcc_WorkCorrectKeyWork.WorkName) == true)
{
string strComparisonOp_WorkName = objvcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.WorkName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.WorkName, objvcc_WorkCorrectKeyWork_Cond.WorkName, strComparisonOp_WorkName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvcc_WorkCorrectKeyWork_Cond.IsUpdated(convcc_WorkCorrectKeyWork.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.CourseId, objvcc_WorkCorrectKeyWork_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_WorkCorrectKeyWork_Cond.IsUpdated(convcc_WorkCorrectKeyWork.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.CourseName, objvcc_WorkCorrectKeyWork_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_WorkCorrectKeyWork_Cond.IsUpdated(convcc_WorkCorrectKeyWork.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.CourseChapterId, objvcc_WorkCorrectKeyWork_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvcc_WorkCorrectKeyWork_Cond.IsUpdated(convcc_WorkCorrectKeyWork.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.CourseChapterName, objvcc_WorkCorrectKeyWork_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvcc_WorkCorrectKeyWork_Cond.IsUpdated(convcc_WorkCorrectKeyWork.CourseChapterReferred) == true)
{
string strComparisonOp_CourseChapterReferred = objvcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.CourseChapterReferred, objvcc_WorkCorrectKeyWork_Cond.CourseChapterReferred, strComparisonOp_CourseChapterReferred);
}
if (objvcc_WorkCorrectKeyWork_Cond.IsUpdated(convcc_WorkCorrectKeyWork.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.ParentNodeID, objvcc_WorkCorrectKeyWork_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvcc_WorkCorrectKeyWork_Cond.IsUpdated(convcc_WorkCorrectKeyWork.ParentNodeName) == true)
{
string strComparisonOp_ParentNodeName = objvcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.ParentNodeName, objvcc_WorkCorrectKeyWork_Cond.ParentNodeName, strComparisonOp_ParentNodeName);
}
if (objvcc_WorkCorrectKeyWork_Cond.IsUpdated(convcc_WorkCorrectKeyWork.ParentNodeReferred) == true)
{
string strComparisonOp_ParentNodeReferred = objvcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.ParentNodeReferred, objvcc_WorkCorrectKeyWork_Cond.ParentNodeReferred, strComparisonOp_ParentNodeReferred);
}
if (objvcc_WorkCorrectKeyWork_Cond.IsUpdated(convcc_WorkCorrectKeyWork.KeyWorkIndex) == true)
{
string strComparisonOp_KeyWorkIndex = objvcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.KeyWorkIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkCorrectKeyWork.KeyWorkIndex, objvcc_WorkCorrectKeyWork_Cond.KeyWorkIndex, strComparisonOp_KeyWorkIndex);
}
if (objvcc_WorkCorrectKeyWork_Cond.IsUpdated(convcc_WorkCorrectKeyWork.CorrectKeyWork) == true)
{
string strComparisonOp_CorrectKeyWork = objvcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.CorrectKeyWork];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.CorrectKeyWork, objvcc_WorkCorrectKeyWork_Cond.CorrectKeyWork, strComparisonOp_CorrectKeyWork);
}
if (objvcc_WorkCorrectKeyWork_Cond.IsUpdated(convcc_WorkCorrectKeyWork.IsUseFormatPara) == true)
{
if (objvcc_WorkCorrectKeyWork_Cond.IsUseFormatPara == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkCorrectKeyWork.IsUseFormatPara);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkCorrectKeyWork.IsUseFormatPara);
}
}
if (objvcc_WorkCorrectKeyWork_Cond.IsUpdated(convcc_WorkCorrectKeyWork.FormatPara) == true)
{
string strComparisonOp_FormatPara = objvcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.FormatPara];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.FormatPara, objvcc_WorkCorrectKeyWork_Cond.FormatPara, strComparisonOp_FormatPara);
}
if (objvcc_WorkCorrectKeyWork_Cond.IsUpdated(convcc_WorkCorrectKeyWork.InOutTypeId) == true)
{
string strComparisonOp_InOutTypeId = objvcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.InOutTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.InOutTypeId, objvcc_WorkCorrectKeyWork_Cond.InOutTypeId, strComparisonOp_InOutTypeId);
}
if (objvcc_WorkCorrectKeyWork_Cond.IsUpdated(convcc_WorkCorrectKeyWork.InOutTypeName) == true)
{
string strComparisonOp_InOutTypeName = objvcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.InOutTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.InOutTypeName, objvcc_WorkCorrectKeyWork_Cond.InOutTypeName, strComparisonOp_InOutTypeName);
}
if (objvcc_WorkCorrectKeyWork_Cond.IsUpdated(convcc_WorkCorrectKeyWork.Creator) == true)
{
string strComparisonOp_Creator = objvcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.Creator];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.Creator, objvcc_WorkCorrectKeyWork_Cond.Creator, strComparisonOp_Creator);
}
if (objvcc_WorkCorrectKeyWork_Cond.IsUpdated(convcc_WorkCorrectKeyWork.CreateDate) == true)
{
string strComparisonOp_CreateDate = objvcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.CreateDate, objvcc_WorkCorrectKeyWork_Cond.CreateDate, strComparisonOp_CreateDate);
}
if (objvcc_WorkCorrectKeyWork_Cond.IsUpdated(convcc_WorkCorrectKeyWork.IsEnable) == true)
{
if (objvcc_WorkCorrectKeyWork_Cond.IsEnable == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkCorrectKeyWork.IsEnable);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkCorrectKeyWork.IsEnable);
}
}
if (objvcc_WorkCorrectKeyWork_Cond.IsUpdated(convcc_WorkCorrectKeyWork.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.UpdDate, objvcc_WorkCorrectKeyWork_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_WorkCorrectKeyWork_Cond.IsUpdated(convcc_WorkCorrectKeyWork.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.UpdUser, objvcc_WorkCorrectKeyWork_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvcc_WorkCorrectKeyWork_Cond.IsUpdated(convcc_WorkCorrectKeyWork.Memo) == true)
{
string strComparisonOp_Memo = objvcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.Memo, objvcc_WorkCorrectKeyWork_Cond.Memo, strComparisonOp_Memo);
}
if (objvcc_WorkCorrectKeyWork_Cond.IsUpdated(convcc_WorkCorrectKeyWork.Id_Work) == true)
{
string strComparisonOp_Id_Work = objvcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.Id_Work];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.Id_Work, objvcc_WorkCorrectKeyWork_Cond.Id_Work, strComparisonOp_Id_Work);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v作业批改关键词(vcc_WorkCorrectKeyWork)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_WorkCorrectKeyWorkWApi
{
private static readonly string mstrApiControllerName = "vcc_WorkCorrectKeyWorkApi";

 public clsvcc_WorkCorrectKeyWorkWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_WorkCorrectKeyWork">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkCorrectKeyWorkEN GetObjById_WorkCorrectKeyWork(long lngId_WorkCorrectKeyWork)
{
string strAction = "GetObjById_WorkCorrectKeyWork";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_WorkCorrectKeyWork"] = lngId_WorkCorrectKeyWork.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_WorkCorrectKeyWorkEN = JsonConvert.DeserializeObject<clsvcc_WorkCorrectKeyWorkEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkCorrectKeyWorkEN;
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
 /// <param name = "lngId_WorkCorrectKeyWork">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkCorrectKeyWorkEN GetObjById_WorkCorrectKeyWork_WA_Cache(long lngId_WorkCorrectKeyWork)
{
string strAction = "GetObjById_WorkCorrectKeyWork_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_WorkCorrectKeyWork"] = lngId_WorkCorrectKeyWork.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_WorkCorrectKeyWorkEN = JsonConvert.DeserializeObject<clsvcc_WorkCorrectKeyWorkEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkCorrectKeyWorkEN;
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
public static clsvcc_WorkCorrectKeyWorkEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN = null;
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
objvcc_WorkCorrectKeyWorkEN = JsonConvert.DeserializeObject<clsvcc_WorkCorrectKeyWorkEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkCorrectKeyWorkEN;
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
 /// <param name = "lngId_WorkCorrectKeyWork">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_WorkCorrectKeyWorkEN GetObjById_WorkCorrectKeyWork_Cache(long lngId_WorkCorrectKeyWork)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_WorkCorrectKeyWorkEN._CurrTabName_S);
List<clsvcc_WorkCorrectKeyWorkEN> arrvcc_WorkCorrectKeyWorkObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_WorkCorrectKeyWorkEN> arrvcc_WorkCorrectKeyWorkObjLst_Sel =
from objvcc_WorkCorrectKeyWorkEN in arrvcc_WorkCorrectKeyWorkObjLst_Cache
where objvcc_WorkCorrectKeyWorkEN.Id_WorkCorrectKeyWork == lngId_WorkCorrectKeyWork
select objvcc_WorkCorrectKeyWorkEN;
if (arrvcc_WorkCorrectKeyWorkObjLst_Sel.Count() == 0)
{
   clsvcc_WorkCorrectKeyWorkEN obj = clsvcc_WorkCorrectKeyWorkWApi.GetObjById_WorkCorrectKeyWork(lngId_WorkCorrectKeyWork);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_WorkCorrectKeyWorkObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkCorrectKeyWorkEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_WorkCorrectKeyWorkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkCorrectKeyWorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkCorrectKeyWorkEN> GetObjLstById_WorkCorrectKeyWorkLst(List<long> arrId_WorkCorrectKeyWork)
{
 List<clsvcc_WorkCorrectKeyWorkEN> arrObjLst = null; 
string strAction = "GetObjLstById_WorkCorrectKeyWorkLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_WorkCorrectKeyWork);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkCorrectKeyWorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngId_WorkCorrectKeyWork">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvcc_WorkCorrectKeyWorkEN> GetObjLstById_WorkCorrectKeyWorkLst_Cache(List<long> arrId_WorkCorrectKeyWork)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_WorkCorrectKeyWorkEN._CurrTabName_S);
List<clsvcc_WorkCorrectKeyWorkEN> arrvcc_WorkCorrectKeyWorkObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_WorkCorrectKeyWorkEN> arrvcc_WorkCorrectKeyWorkObjLst_Sel =
from objvcc_WorkCorrectKeyWorkEN in arrvcc_WorkCorrectKeyWorkObjLst_Cache
where arrId_WorkCorrectKeyWork.Contains(objvcc_WorkCorrectKeyWorkEN.Id_WorkCorrectKeyWork)
select objvcc_WorkCorrectKeyWorkEN;
return arrvcc_WorkCorrectKeyWorkObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkCorrectKeyWorkEN> GetObjLstById_WorkCorrectKeyWorkLst_WA_Cache(List<long> arrId_WorkCorrectKeyWork)
{
 List<clsvcc_WorkCorrectKeyWorkEN> arrObjLst = null; 
string strAction = "GetObjLstById_WorkCorrectKeyWorkLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_WorkCorrectKeyWork);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkCorrectKeyWorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkCorrectKeyWorkEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_WorkCorrectKeyWorkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkCorrectKeyWorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkCorrectKeyWorkEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_WorkCorrectKeyWorkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkCorrectKeyWorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkCorrectKeyWorkEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_WorkCorrectKeyWorkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkCorrectKeyWorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkCorrectKeyWorkEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_WorkCorrectKeyWorkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkCorrectKeyWorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngId_WorkCorrectKeyWork)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_WorkCorrectKeyWork"] = lngId_WorkCorrectKeyWork.ToString()
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
 /// <param name = "objvcc_WorkCorrectKeyWorkENS">源对象</param>
 /// <param name = "objvcc_WorkCorrectKeyWorkENT">目标对象</param>
 public static void CopyTo(clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkENS, clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkENT)
{
try
{
objvcc_WorkCorrectKeyWorkENT.Id_WorkCorrectKeyWork = objvcc_WorkCorrectKeyWorkENS.Id_WorkCorrectKeyWork; //作业批改关键词流水号
objvcc_WorkCorrectKeyWorkENT.QuestionID = objvcc_WorkCorrectKeyWorkENS.QuestionID; //题目ID
objvcc_WorkCorrectKeyWorkENT.WorkIndex = objvcc_WorkCorrectKeyWorkENS.WorkIndex; //作业序号
objvcc_WorkCorrectKeyWorkENT.WorkName = objvcc_WorkCorrectKeyWorkENS.WorkName; //作业名称
objvcc_WorkCorrectKeyWorkENT.WorkDesc = objvcc_WorkCorrectKeyWorkENS.WorkDesc; //作业说明
objvcc_WorkCorrectKeyWorkENT.CourseId = objvcc_WorkCorrectKeyWorkENS.CourseId; //课程Id
objvcc_WorkCorrectKeyWorkENT.CourseName = objvcc_WorkCorrectKeyWorkENS.CourseName; //课程名称
objvcc_WorkCorrectKeyWorkENT.CourseChapterId = objvcc_WorkCorrectKeyWorkENS.CourseChapterId; //课程章节ID
objvcc_WorkCorrectKeyWorkENT.CourseChapterName = objvcc_WorkCorrectKeyWorkENS.CourseChapterName; //课程章节名称
objvcc_WorkCorrectKeyWorkENT.CourseChapterReferred = objvcc_WorkCorrectKeyWorkENS.CourseChapterReferred; //节简称
objvcc_WorkCorrectKeyWorkENT.ParentNodeID = objvcc_WorkCorrectKeyWorkENS.ParentNodeID; //父节点编号
objvcc_WorkCorrectKeyWorkENT.ParentNodeName = objvcc_WorkCorrectKeyWorkENS.ParentNodeName; //父节点名称
objvcc_WorkCorrectKeyWorkENT.ParentNodeReferred = objvcc_WorkCorrectKeyWorkENS.ParentNodeReferred; //章简称
objvcc_WorkCorrectKeyWorkENT.KeyWorkIndex = objvcc_WorkCorrectKeyWorkENS.KeyWorkIndex; //关键字序号
objvcc_WorkCorrectKeyWorkENT.CorrectKeyWork = objvcc_WorkCorrectKeyWorkENS.CorrectKeyWork; //批改关键词
objvcc_WorkCorrectKeyWorkENT.IsUseFormatPara = objvcc_WorkCorrectKeyWorkENS.IsUseFormatPara; //是否使用格式化参数
objvcc_WorkCorrectKeyWorkENT.FormatPara = objvcc_WorkCorrectKeyWorkENS.FormatPara; //格式化参数
objvcc_WorkCorrectKeyWorkENT.InOutTypeId = objvcc_WorkCorrectKeyWorkENS.InOutTypeId; //InOut类型Id
objvcc_WorkCorrectKeyWorkENT.InOutTypeName = objvcc_WorkCorrectKeyWorkENS.InOutTypeName; //InOut类型类型
objvcc_WorkCorrectKeyWorkENT.Creator = objvcc_WorkCorrectKeyWorkENS.Creator; //创建者
objvcc_WorkCorrectKeyWorkENT.CreateDate = objvcc_WorkCorrectKeyWorkENS.CreateDate; //建立日期
objvcc_WorkCorrectKeyWorkENT.IsEnable = objvcc_WorkCorrectKeyWorkENS.IsEnable; //是否启用
objvcc_WorkCorrectKeyWorkENT.UpdDate = objvcc_WorkCorrectKeyWorkENS.UpdDate; //修改日期
objvcc_WorkCorrectKeyWorkENT.UpdUser = objvcc_WorkCorrectKeyWorkENS.UpdUser; //修改人
objvcc_WorkCorrectKeyWorkENT.Memo = objvcc_WorkCorrectKeyWorkENS.Memo; //备注
objvcc_WorkCorrectKeyWorkENT.Id_Work = objvcc_WorkCorrectKeyWorkENS.Id_Work; //作业流水号
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
public static DataTable ToDataTable(List<clsvcc_WorkCorrectKeyWorkEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_WorkCorrectKeyWorkEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_WorkCorrectKeyWorkEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_WorkCorrectKeyWorkEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_WorkCorrectKeyWorkEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_WorkCorrectKeyWorkEN.AttributeName)
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
if (clscc_WorkCorrectKeyWorkWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkCorrectKeyWorkWApi没有刷新缓存机制(clscc_WorkCorrectKeyWorkWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsInOutTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsInOutTypeWApi没有刷新缓存机制(clsInOutTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_WorkWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkWApi没有刷新缓存机制(clscc_WorkWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterWApi没有刷新缓存机制(clscc_CourseChapterWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by Id_WorkCorrectKeyWork");
//if (arrvcc_WorkCorrectKeyWorkObjLst_Cache == null)
//{
//arrvcc_WorkCorrectKeyWorkObjLst_Cache = await clsvcc_WorkCorrectKeyWorkWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvcc_WorkCorrectKeyWorkEN._CurrTabName_S);
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
public static List<clsvcc_WorkCorrectKeyWorkEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvcc_WorkCorrectKeyWorkEN._CurrTabName_S);
List<clsvcc_WorkCorrectKeyWorkEN> arrvcc_WorkCorrectKeyWorkObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_WorkCorrectKeyWorkObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_WorkCorrectKeyWorkEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_WorkCorrectKeyWork.Id_WorkCorrectKeyWork, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_WorkCorrectKeyWork.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkCorrectKeyWork.WorkIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_WorkCorrectKeyWork.WorkName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkCorrectKeyWork.WorkDesc, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkCorrectKeyWork.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkCorrectKeyWork.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkCorrectKeyWork.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkCorrectKeyWork.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkCorrectKeyWork.CourseChapterReferred, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkCorrectKeyWork.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkCorrectKeyWork.ParentNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkCorrectKeyWork.ParentNodeReferred, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkCorrectKeyWork.KeyWorkIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_WorkCorrectKeyWork.CorrectKeyWork, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkCorrectKeyWork.IsUseFormatPara, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_WorkCorrectKeyWork.FormatPara, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkCorrectKeyWork.InOutTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkCorrectKeyWork.InOutTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkCorrectKeyWork.Creator, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkCorrectKeyWork.CreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkCorrectKeyWork.IsEnable, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_WorkCorrectKeyWork.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkCorrectKeyWork.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkCorrectKeyWork.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkCorrectKeyWork.Id_Work, Type.GetType("System.String"));
foreach (clsvcc_WorkCorrectKeyWorkEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_WorkCorrectKeyWork.Id_WorkCorrectKeyWork] = objInFor[convcc_WorkCorrectKeyWork.Id_WorkCorrectKeyWork];
objDR[convcc_WorkCorrectKeyWork.QuestionID] = objInFor[convcc_WorkCorrectKeyWork.QuestionID];
objDR[convcc_WorkCorrectKeyWork.WorkIndex] = objInFor[convcc_WorkCorrectKeyWork.WorkIndex];
objDR[convcc_WorkCorrectKeyWork.WorkName] = objInFor[convcc_WorkCorrectKeyWork.WorkName];
objDR[convcc_WorkCorrectKeyWork.WorkDesc] = objInFor[convcc_WorkCorrectKeyWork.WorkDesc];
objDR[convcc_WorkCorrectKeyWork.CourseId] = objInFor[convcc_WorkCorrectKeyWork.CourseId];
objDR[convcc_WorkCorrectKeyWork.CourseName] = objInFor[convcc_WorkCorrectKeyWork.CourseName];
objDR[convcc_WorkCorrectKeyWork.CourseChapterId] = objInFor[convcc_WorkCorrectKeyWork.CourseChapterId];
objDR[convcc_WorkCorrectKeyWork.CourseChapterName] = objInFor[convcc_WorkCorrectKeyWork.CourseChapterName];
objDR[convcc_WorkCorrectKeyWork.CourseChapterReferred] = objInFor[convcc_WorkCorrectKeyWork.CourseChapterReferred];
objDR[convcc_WorkCorrectKeyWork.ParentNodeID] = objInFor[convcc_WorkCorrectKeyWork.ParentNodeID];
objDR[convcc_WorkCorrectKeyWork.ParentNodeName] = objInFor[convcc_WorkCorrectKeyWork.ParentNodeName];
objDR[convcc_WorkCorrectKeyWork.ParentNodeReferred] = objInFor[convcc_WorkCorrectKeyWork.ParentNodeReferred];
objDR[convcc_WorkCorrectKeyWork.KeyWorkIndex] = objInFor[convcc_WorkCorrectKeyWork.KeyWorkIndex];
objDR[convcc_WorkCorrectKeyWork.CorrectKeyWork] = objInFor[convcc_WorkCorrectKeyWork.CorrectKeyWork];
objDR[convcc_WorkCorrectKeyWork.IsUseFormatPara] = objInFor[convcc_WorkCorrectKeyWork.IsUseFormatPara];
objDR[convcc_WorkCorrectKeyWork.FormatPara] = objInFor[convcc_WorkCorrectKeyWork.FormatPara];
objDR[convcc_WorkCorrectKeyWork.InOutTypeId] = objInFor[convcc_WorkCorrectKeyWork.InOutTypeId];
objDR[convcc_WorkCorrectKeyWork.InOutTypeName] = objInFor[convcc_WorkCorrectKeyWork.InOutTypeName];
objDR[convcc_WorkCorrectKeyWork.Creator] = objInFor[convcc_WorkCorrectKeyWork.Creator];
objDR[convcc_WorkCorrectKeyWork.CreateDate] = objInFor[convcc_WorkCorrectKeyWork.CreateDate];
objDR[convcc_WorkCorrectKeyWork.IsEnable] = objInFor[convcc_WorkCorrectKeyWork.IsEnable];
objDR[convcc_WorkCorrectKeyWork.UpdDate] = objInFor[convcc_WorkCorrectKeyWork.UpdDate];
objDR[convcc_WorkCorrectKeyWork.UpdUser] = objInFor[convcc_WorkCorrectKeyWork.UpdUser];
objDR[convcc_WorkCorrectKeyWork.Memo] = objInFor[convcc_WorkCorrectKeyWork.Memo];
objDR[convcc_WorkCorrectKeyWork.Id_Work] = objInFor[convcc_WorkCorrectKeyWork.Id_Work];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}