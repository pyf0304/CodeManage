
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkCorrectKeyWorkBL
 表名:vcc_WorkCorrectKeyWork(01120192)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:14
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
public static class  clsvcc_WorkCorrectKeyWorkBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdWorkCorrectKeyWork">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkCorrectKeyWorkEN GetObj(this K_IdWorkCorrectKeyWork_vcc_WorkCorrectKeyWork myKey)
{
clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN = clsvcc_WorkCorrectKeyWorkBL.vcc_WorkCorrectKeyWorkDA.GetObjByIdWorkCorrectKeyWork(myKey.Value);
return objvcc_WorkCorrectKeyWorkEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetIdWorkCorrectKeyWork(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, long lngIdWorkCorrectKeyWork, string strComparisonOp="")
	{
objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = lngIdWorkCorrectKeyWork; //作业批改关键词流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork) == false)
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork, strComparisonOp);
}
else
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork] = strComparisonOp;
}
}
return objvcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetQuestionID(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionID, convcc_WorkCorrectKeyWork.QuestionID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionID, 8, convcc_WorkCorrectKeyWork.QuestionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convcc_WorkCorrectKeyWork.QuestionID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetWorkIndex(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, int? intWorkIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetWorkName(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strWorkName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkName, convcc_WorkCorrectKeyWork.WorkName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkName, 5000, convcc_WorkCorrectKeyWork.WorkName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetCourseId(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_WorkCorrectKeyWork.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_WorkCorrectKeyWork.CourseId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetCourseName(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_WorkCorrectKeyWork.CourseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetCourseChapterId(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, convcc_WorkCorrectKeyWork.CourseChapterId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_WorkCorrectKeyWork.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_WorkCorrectKeyWork.CourseChapterId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetCourseChapterName(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterName, convcc_WorkCorrectKeyWork.CourseChapterName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_WorkCorrectKeyWork.CourseChapterName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetCourseChapterReferred(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strCourseChapterReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convcc_WorkCorrectKeyWork.CourseChapterReferred);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetParentNodeID(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strParentNodeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convcc_WorkCorrectKeyWork.ParentNodeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetParentNodeName(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strParentNodeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convcc_WorkCorrectKeyWork.ParentNodeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetParentNodeReferred(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strParentNodeReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convcc_WorkCorrectKeyWork.ParentNodeReferred);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetKeyWorkIndex(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, int? intKeyWorkIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetCorrectKeyWork(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strCorrectKeyWork, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCorrectKeyWork, convcc_WorkCorrectKeyWork.CorrectKeyWork);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCorrectKeyWork, 200, convcc_WorkCorrectKeyWork.CorrectKeyWork);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetFormatPara(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strFormatPara, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFormatPara, 100, convcc_WorkCorrectKeyWork.FormatPara);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetInOutTypeId(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strInOutTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strInOutTypeId, convcc_WorkCorrectKeyWork.InOutTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInOutTypeId, 2, convcc_WorkCorrectKeyWork.InOutTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strInOutTypeId, 2, convcc_WorkCorrectKeyWork.InOutTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetInOutTypeName(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strInOutTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strInOutTypeName, convcc_WorkCorrectKeyWork.InOutTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInOutTypeName, 30, convcc_WorkCorrectKeyWork.InOutTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetCreator(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strCreator, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreator, 18, convcc_WorkCorrectKeyWork.Creator);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetCreateDate(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convcc_WorkCorrectKeyWork.CreateDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetUpdDate(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_WorkCorrectKeyWork.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_WorkCorrectKeyWork.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetUpdUser(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convcc_WorkCorrectKeyWork.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convcc_WorkCorrectKeyWork.UpdUser);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetMemo(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_WorkCorrectKeyWork.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkCorrectKeyWorkEN SetIdWork(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN, string strIdWork, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdWork, 8, convcc_WorkCorrectKeyWork.IdWork);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdWork, 8, convcc_WorkCorrectKeyWork.IdWork);
}
objvcc_WorkCorrectKeyWorkEN.IdWork = strIdWork; //作业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(convcc_WorkCorrectKeyWork.IdWork) == false)
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(convcc_WorkCorrectKeyWork.IdWork, strComparisonOp);
}
else
{
objvcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[convcc_WorkCorrectKeyWork.IdWork] = strComparisonOp;
}
}
return objvcc_WorkCorrectKeyWorkEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkENS">源对象</param>
 /// <param name = "objvcc_WorkCorrectKeyWorkENT">目标对象</param>
 public static void CopyTo(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkENS, clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkENT)
{
try
{
objvcc_WorkCorrectKeyWorkENT.IdWorkCorrectKeyWork = objvcc_WorkCorrectKeyWorkENS.IdWorkCorrectKeyWork; //作业批改关键词流水号
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
objvcc_WorkCorrectKeyWorkENT.IdWork = objvcc_WorkCorrectKeyWorkENS.IdWork; //作业流水号
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
 /// <param name = "objvcc_WorkCorrectKeyWorkENS">源对象</param>
 /// <returns>目标对象=>clsvcc_WorkCorrectKeyWorkEN:objvcc_WorkCorrectKeyWorkENT</returns>
 public static clsvcc_WorkCorrectKeyWorkEN CopyTo(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkENS)
{
try
{
 clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkENT = new clsvcc_WorkCorrectKeyWorkEN()
{
IdWorkCorrectKeyWork = objvcc_WorkCorrectKeyWorkENS.IdWorkCorrectKeyWork, //作业批改关键词流水号
QuestionID = objvcc_WorkCorrectKeyWorkENS.QuestionID, //题目ID
WorkIndex = objvcc_WorkCorrectKeyWorkENS.WorkIndex, //作业序号
WorkName = objvcc_WorkCorrectKeyWorkENS.WorkName, //作业名称
WorkDesc = objvcc_WorkCorrectKeyWorkENS.WorkDesc, //作业说明
CourseId = objvcc_WorkCorrectKeyWorkENS.CourseId, //课程Id
CourseName = objvcc_WorkCorrectKeyWorkENS.CourseName, //课程名称
CourseChapterId = objvcc_WorkCorrectKeyWorkENS.CourseChapterId, //课程章节ID
CourseChapterName = objvcc_WorkCorrectKeyWorkENS.CourseChapterName, //课程章节名称
CourseChapterReferred = objvcc_WorkCorrectKeyWorkENS.CourseChapterReferred, //节简称
ParentNodeID = objvcc_WorkCorrectKeyWorkENS.ParentNodeID, //父节点编号
ParentNodeName = objvcc_WorkCorrectKeyWorkENS.ParentNodeName, //父节点名称
ParentNodeReferred = objvcc_WorkCorrectKeyWorkENS.ParentNodeReferred, //章简称
KeyWorkIndex = objvcc_WorkCorrectKeyWorkENS.KeyWorkIndex, //关键字序号
CorrectKeyWork = objvcc_WorkCorrectKeyWorkENS.CorrectKeyWork, //批改关键词
IsUseFormatPara = objvcc_WorkCorrectKeyWorkENS.IsUseFormatPara, //是否使用格式化参数
FormatPara = objvcc_WorkCorrectKeyWorkENS.FormatPara, //格式化参数
InOutTypeId = objvcc_WorkCorrectKeyWorkENS.InOutTypeId, //InOut类型Id
InOutTypeName = objvcc_WorkCorrectKeyWorkENS.InOutTypeName, //InOut类型类型
Creator = objvcc_WorkCorrectKeyWorkENS.Creator, //创建者
CreateDate = objvcc_WorkCorrectKeyWorkENS.CreateDate, //建立日期
IsEnable = objvcc_WorkCorrectKeyWorkENS.IsEnable, //是否启用
UpdDate = objvcc_WorkCorrectKeyWorkENS.UpdDate, //修改日期
UpdUser = objvcc_WorkCorrectKeyWorkENS.UpdUser, //修改人
Memo = objvcc_WorkCorrectKeyWorkENS.Memo, //备注
IdWork = objvcc_WorkCorrectKeyWorkENS.IdWork, //作业流水号
};
 return objvcc_WorkCorrectKeyWorkENT;
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
public static void CheckProperty4Condition(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN)
{
 clsvcc_WorkCorrectKeyWorkBL.vcc_WorkCorrectKeyWorkDA.CheckProperty4Condition(objvcc_WorkCorrectKeyWorkEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_WorkCorrectKeyWorkCond.IsUpdated(convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork) == true)
{
string strComparisonOpIdWorkCorrectKeyWork = objvcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork, objvcc_WorkCorrectKeyWorkCond.IdWorkCorrectKeyWork, strComparisonOpIdWorkCorrectKeyWork);
}
if (objvcc_WorkCorrectKeyWorkCond.IsUpdated(convcc_WorkCorrectKeyWork.QuestionID) == true)
{
string strComparisonOpQuestionID = objvcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.QuestionID, objvcc_WorkCorrectKeyWorkCond.QuestionID, strComparisonOpQuestionID);
}
if (objvcc_WorkCorrectKeyWorkCond.IsUpdated(convcc_WorkCorrectKeyWork.WorkIndex) == true)
{
string strComparisonOpWorkIndex = objvcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.WorkIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkCorrectKeyWork.WorkIndex, objvcc_WorkCorrectKeyWorkCond.WorkIndex, strComparisonOpWorkIndex);
}
if (objvcc_WorkCorrectKeyWorkCond.IsUpdated(convcc_WorkCorrectKeyWork.WorkName) == true)
{
string strComparisonOpWorkName = objvcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.WorkName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.WorkName, objvcc_WorkCorrectKeyWorkCond.WorkName, strComparisonOpWorkName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvcc_WorkCorrectKeyWorkCond.IsUpdated(convcc_WorkCorrectKeyWork.CourseId) == true)
{
string strComparisonOpCourseId = objvcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.CourseId, objvcc_WorkCorrectKeyWorkCond.CourseId, strComparisonOpCourseId);
}
if (objvcc_WorkCorrectKeyWorkCond.IsUpdated(convcc_WorkCorrectKeyWork.CourseName) == true)
{
string strComparisonOpCourseName = objvcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.CourseName, objvcc_WorkCorrectKeyWorkCond.CourseName, strComparisonOpCourseName);
}
if (objvcc_WorkCorrectKeyWorkCond.IsUpdated(convcc_WorkCorrectKeyWork.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.CourseChapterId, objvcc_WorkCorrectKeyWorkCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvcc_WorkCorrectKeyWorkCond.IsUpdated(convcc_WorkCorrectKeyWork.CourseChapterName) == true)
{
string strComparisonOpCourseChapterName = objvcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.CourseChapterName, objvcc_WorkCorrectKeyWorkCond.CourseChapterName, strComparisonOpCourseChapterName);
}
if (objvcc_WorkCorrectKeyWorkCond.IsUpdated(convcc_WorkCorrectKeyWork.CourseChapterReferred) == true)
{
string strComparisonOpCourseChapterReferred = objvcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.CourseChapterReferred, objvcc_WorkCorrectKeyWorkCond.CourseChapterReferred, strComparisonOpCourseChapterReferred);
}
if (objvcc_WorkCorrectKeyWorkCond.IsUpdated(convcc_WorkCorrectKeyWork.ParentNodeID) == true)
{
string strComparisonOpParentNodeID = objvcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.ParentNodeID, objvcc_WorkCorrectKeyWorkCond.ParentNodeID, strComparisonOpParentNodeID);
}
if (objvcc_WorkCorrectKeyWorkCond.IsUpdated(convcc_WorkCorrectKeyWork.ParentNodeName) == true)
{
string strComparisonOpParentNodeName = objvcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.ParentNodeName, objvcc_WorkCorrectKeyWorkCond.ParentNodeName, strComparisonOpParentNodeName);
}
if (objvcc_WorkCorrectKeyWorkCond.IsUpdated(convcc_WorkCorrectKeyWork.ParentNodeReferred) == true)
{
string strComparisonOpParentNodeReferred = objvcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.ParentNodeReferred, objvcc_WorkCorrectKeyWorkCond.ParentNodeReferred, strComparisonOpParentNodeReferred);
}
if (objvcc_WorkCorrectKeyWorkCond.IsUpdated(convcc_WorkCorrectKeyWork.KeyWorkIndex) == true)
{
string strComparisonOpKeyWorkIndex = objvcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.KeyWorkIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkCorrectKeyWork.KeyWorkIndex, objvcc_WorkCorrectKeyWorkCond.KeyWorkIndex, strComparisonOpKeyWorkIndex);
}
if (objvcc_WorkCorrectKeyWorkCond.IsUpdated(convcc_WorkCorrectKeyWork.CorrectKeyWork) == true)
{
string strComparisonOpCorrectKeyWork = objvcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.CorrectKeyWork];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.CorrectKeyWork, objvcc_WorkCorrectKeyWorkCond.CorrectKeyWork, strComparisonOpCorrectKeyWork);
}
if (objvcc_WorkCorrectKeyWorkCond.IsUpdated(convcc_WorkCorrectKeyWork.IsUseFormatPara) == true)
{
if (objvcc_WorkCorrectKeyWorkCond.IsUseFormatPara == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkCorrectKeyWork.IsUseFormatPara);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkCorrectKeyWork.IsUseFormatPara);
}
}
if (objvcc_WorkCorrectKeyWorkCond.IsUpdated(convcc_WorkCorrectKeyWork.FormatPara) == true)
{
string strComparisonOpFormatPara = objvcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.FormatPara];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.FormatPara, objvcc_WorkCorrectKeyWorkCond.FormatPara, strComparisonOpFormatPara);
}
if (objvcc_WorkCorrectKeyWorkCond.IsUpdated(convcc_WorkCorrectKeyWork.InOutTypeId) == true)
{
string strComparisonOpInOutTypeId = objvcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.InOutTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.InOutTypeId, objvcc_WorkCorrectKeyWorkCond.InOutTypeId, strComparisonOpInOutTypeId);
}
if (objvcc_WorkCorrectKeyWorkCond.IsUpdated(convcc_WorkCorrectKeyWork.InOutTypeName) == true)
{
string strComparisonOpInOutTypeName = objvcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.InOutTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.InOutTypeName, objvcc_WorkCorrectKeyWorkCond.InOutTypeName, strComparisonOpInOutTypeName);
}
if (objvcc_WorkCorrectKeyWorkCond.IsUpdated(convcc_WorkCorrectKeyWork.Creator) == true)
{
string strComparisonOpCreator = objvcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.Creator];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.Creator, objvcc_WorkCorrectKeyWorkCond.Creator, strComparisonOpCreator);
}
if (objvcc_WorkCorrectKeyWorkCond.IsUpdated(convcc_WorkCorrectKeyWork.CreateDate) == true)
{
string strComparisonOpCreateDate = objvcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.CreateDate, objvcc_WorkCorrectKeyWorkCond.CreateDate, strComparisonOpCreateDate);
}
if (objvcc_WorkCorrectKeyWorkCond.IsUpdated(convcc_WorkCorrectKeyWork.IsEnable) == true)
{
if (objvcc_WorkCorrectKeyWorkCond.IsEnable == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkCorrectKeyWork.IsEnable);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkCorrectKeyWork.IsEnable);
}
}
if (objvcc_WorkCorrectKeyWorkCond.IsUpdated(convcc_WorkCorrectKeyWork.UpdDate) == true)
{
string strComparisonOpUpdDate = objvcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.UpdDate, objvcc_WorkCorrectKeyWorkCond.UpdDate, strComparisonOpUpdDate);
}
if (objvcc_WorkCorrectKeyWorkCond.IsUpdated(convcc_WorkCorrectKeyWork.UpdUser) == true)
{
string strComparisonOpUpdUser = objvcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.UpdUser, objvcc_WorkCorrectKeyWorkCond.UpdUser, strComparisonOpUpdUser);
}
if (objvcc_WorkCorrectKeyWorkCond.IsUpdated(convcc_WorkCorrectKeyWork.Memo) == true)
{
string strComparisonOpMemo = objvcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.Memo, objvcc_WorkCorrectKeyWorkCond.Memo, strComparisonOpMemo);
}
if (objvcc_WorkCorrectKeyWorkCond.IsUpdated(convcc_WorkCorrectKeyWork.IdWork) == true)
{
string strComparisonOpIdWork = objvcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[convcc_WorkCorrectKeyWork.IdWork];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkCorrectKeyWork.IdWork, objvcc_WorkCorrectKeyWorkCond.IdWork, strComparisonOpIdWork);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcc_WorkCorrectKeyWork
{
public virtual bool UpdRelaTabDate(long lngIdWorkCorrectKeyWork, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v作业批改关键词(vcc_WorkCorrectKeyWork)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcc_WorkCorrectKeyWorkBL
{
public static RelatedActions_vcc_WorkCorrectKeyWork relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcc_WorkCorrectKeyWorkDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcc_WorkCorrectKeyWorkDA vcc_WorkCorrectKeyWorkDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcc_WorkCorrectKeyWorkDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcc_WorkCorrectKeyWorkBL()
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
if (string.IsNullOrEmpty(clsvcc_WorkCorrectKeyWorkEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_WorkCorrectKeyWorkEN._ConnectString);
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
public static DataTable GetDataTable_vcc_WorkCorrectKeyWork(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcc_WorkCorrectKeyWorkDA.GetDataTable_vcc_WorkCorrectKeyWork(strWhereCond);
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
objDT = vcc_WorkCorrectKeyWorkDA.GetDataTable(strWhereCond);
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
objDT = vcc_WorkCorrectKeyWorkDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcc_WorkCorrectKeyWorkDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcc_WorkCorrectKeyWorkDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcc_WorkCorrectKeyWorkDA.GetDataTable_Top(objTopPara);
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
objDT = vcc_WorkCorrectKeyWorkDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcc_WorkCorrectKeyWorkDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcc_WorkCorrectKeyWorkDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdWorkCorrectKeyWorkLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvcc_WorkCorrectKeyWorkEN> GetObjLstByIdWorkCorrectKeyWorkLst(List<long> arrIdWorkCorrectKeyWorkLst)
{
List<clsvcc_WorkCorrectKeyWorkEN> arrObjLst = new List<clsvcc_WorkCorrectKeyWorkEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdWorkCorrectKeyWorkLst);
 string strWhereCond = string.Format("IdWorkCorrectKeyWork in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN = new clsvcc_WorkCorrectKeyWorkEN();
try
{
objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = Int32.Parse(objRow[convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号
objvcc_WorkCorrectKeyWorkEN.QuestionID = objRow[convcc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkCorrectKeyWorkEN.WorkIndex = objRow[convcc_WorkCorrectKeyWork.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkCorrectKeyWork.WorkIndex].ToString().Trim()); //作业序号
objvcc_WorkCorrectKeyWorkEN.WorkName = objRow[convcc_WorkCorrectKeyWork.WorkName].ToString().Trim(); //作业名称
objvcc_WorkCorrectKeyWorkEN.WorkDesc = objRow[convcc_WorkCorrectKeyWork.WorkDesc] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.WorkDesc].ToString().Trim(); //作业说明
objvcc_WorkCorrectKeyWorkEN.CourseId = objRow[convcc_WorkCorrectKeyWork.CourseId] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseId].ToString().Trim(); //课程Id
objvcc_WorkCorrectKeyWorkEN.CourseName = objRow[convcc_WorkCorrectKeyWork.CourseName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseName].ToString().Trim(); //课程名称
objvcc_WorkCorrectKeyWorkEN.CourseChapterId = objRow[convcc_WorkCorrectKeyWork.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkCorrectKeyWorkEN.CourseChapterName = objRow[convcc_WorkCorrectKeyWork.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkCorrectKeyWorkEN.CourseChapterReferred = objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkCorrectKeyWorkEN.ParentNodeID = objRow[convcc_WorkCorrectKeyWork.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkCorrectKeyWorkEN.ParentNodeName = objRow[convcc_WorkCorrectKeyWork.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkCorrectKeyWorkEN.ParentNodeReferred = objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号
objvcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objRow[convcc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词
objvcc_WorkCorrectKeyWorkEN.IsUseFormatPara = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数
objvcc_WorkCorrectKeyWorkEN.FormatPara = objRow[convcc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数
objvcc_WorkCorrectKeyWorkEN.InOutTypeId = objRow[convcc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id
objvcc_WorkCorrectKeyWorkEN.InOutTypeName = objRow[convcc_WorkCorrectKeyWork.InOutTypeName].ToString().Trim(); //InOut类型类型
objvcc_WorkCorrectKeyWorkEN.Creator = objRow[convcc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者
objvcc_WorkCorrectKeyWorkEN.CreateDate = objRow[convcc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkCorrectKeyWorkEN.IsEnable = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用
objvcc_WorkCorrectKeyWorkEN.UpdDate = objRow[convcc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkCorrectKeyWorkEN.UpdUser = objRow[convcc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人
objvcc_WorkCorrectKeyWorkEN.Memo = objRow[convcc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注
objvcc_WorkCorrectKeyWorkEN.IdWork = objRow[convcc_WorkCorrectKeyWork.IdWork] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.IdWork].ToString().Trim(); //作业流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkCorrectKeyWorkEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdWorkCorrectKeyWorkLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcc_WorkCorrectKeyWorkEN> GetObjLstByIdWorkCorrectKeyWorkLstCache(List<long> arrIdWorkCorrectKeyWorkLst)
{
string strKey = string.Format("{0}", clsvcc_WorkCorrectKeyWorkEN._CurrTabName);
List<clsvcc_WorkCorrectKeyWorkEN> arrvcc_WorkCorrectKeyWorkObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_WorkCorrectKeyWorkEN> arrvcc_WorkCorrectKeyWorkObjLst_Sel =
arrvcc_WorkCorrectKeyWorkObjLstCache
.Where(x => arrIdWorkCorrectKeyWorkLst.Contains(x.IdWorkCorrectKeyWork));
return arrvcc_WorkCorrectKeyWorkObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkCorrectKeyWorkEN> GetObjLst(string strWhereCond)
{
List<clsvcc_WorkCorrectKeyWorkEN> arrObjLst = new List<clsvcc_WorkCorrectKeyWorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN = new clsvcc_WorkCorrectKeyWorkEN();
try
{
objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = Int32.Parse(objRow[convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号
objvcc_WorkCorrectKeyWorkEN.QuestionID = objRow[convcc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkCorrectKeyWorkEN.WorkIndex = objRow[convcc_WorkCorrectKeyWork.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkCorrectKeyWork.WorkIndex].ToString().Trim()); //作业序号
objvcc_WorkCorrectKeyWorkEN.WorkName = objRow[convcc_WorkCorrectKeyWork.WorkName].ToString().Trim(); //作业名称
objvcc_WorkCorrectKeyWorkEN.WorkDesc = objRow[convcc_WorkCorrectKeyWork.WorkDesc] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.WorkDesc].ToString().Trim(); //作业说明
objvcc_WorkCorrectKeyWorkEN.CourseId = objRow[convcc_WorkCorrectKeyWork.CourseId] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseId].ToString().Trim(); //课程Id
objvcc_WorkCorrectKeyWorkEN.CourseName = objRow[convcc_WorkCorrectKeyWork.CourseName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseName].ToString().Trim(); //课程名称
objvcc_WorkCorrectKeyWorkEN.CourseChapterId = objRow[convcc_WorkCorrectKeyWork.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkCorrectKeyWorkEN.CourseChapterName = objRow[convcc_WorkCorrectKeyWork.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkCorrectKeyWorkEN.CourseChapterReferred = objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkCorrectKeyWorkEN.ParentNodeID = objRow[convcc_WorkCorrectKeyWork.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkCorrectKeyWorkEN.ParentNodeName = objRow[convcc_WorkCorrectKeyWork.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkCorrectKeyWorkEN.ParentNodeReferred = objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号
objvcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objRow[convcc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词
objvcc_WorkCorrectKeyWorkEN.IsUseFormatPara = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数
objvcc_WorkCorrectKeyWorkEN.FormatPara = objRow[convcc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数
objvcc_WorkCorrectKeyWorkEN.InOutTypeId = objRow[convcc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id
objvcc_WorkCorrectKeyWorkEN.InOutTypeName = objRow[convcc_WorkCorrectKeyWork.InOutTypeName].ToString().Trim(); //InOut类型类型
objvcc_WorkCorrectKeyWorkEN.Creator = objRow[convcc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者
objvcc_WorkCorrectKeyWorkEN.CreateDate = objRow[convcc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkCorrectKeyWorkEN.IsEnable = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用
objvcc_WorkCorrectKeyWorkEN.UpdDate = objRow[convcc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkCorrectKeyWorkEN.UpdUser = objRow[convcc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人
objvcc_WorkCorrectKeyWorkEN.Memo = objRow[convcc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注
objvcc_WorkCorrectKeyWorkEN.IdWork = objRow[convcc_WorkCorrectKeyWork.IdWork] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.IdWork].ToString().Trim(); //作业流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkCorrectKeyWorkEN);
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
public static List<clsvcc_WorkCorrectKeyWorkEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcc_WorkCorrectKeyWorkEN> arrObjLst = new List<clsvcc_WorkCorrectKeyWorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN = new clsvcc_WorkCorrectKeyWorkEN();
try
{
objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = Int32.Parse(objRow[convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号
objvcc_WorkCorrectKeyWorkEN.QuestionID = objRow[convcc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkCorrectKeyWorkEN.WorkIndex = objRow[convcc_WorkCorrectKeyWork.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkCorrectKeyWork.WorkIndex].ToString().Trim()); //作业序号
objvcc_WorkCorrectKeyWorkEN.WorkName = objRow[convcc_WorkCorrectKeyWork.WorkName].ToString().Trim(); //作业名称
objvcc_WorkCorrectKeyWorkEN.WorkDesc = objRow[convcc_WorkCorrectKeyWork.WorkDesc] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.WorkDesc].ToString().Trim(); //作业说明
objvcc_WorkCorrectKeyWorkEN.CourseId = objRow[convcc_WorkCorrectKeyWork.CourseId] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseId].ToString().Trim(); //课程Id
objvcc_WorkCorrectKeyWorkEN.CourseName = objRow[convcc_WorkCorrectKeyWork.CourseName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseName].ToString().Trim(); //课程名称
objvcc_WorkCorrectKeyWorkEN.CourseChapterId = objRow[convcc_WorkCorrectKeyWork.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkCorrectKeyWorkEN.CourseChapterName = objRow[convcc_WorkCorrectKeyWork.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkCorrectKeyWorkEN.CourseChapterReferred = objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkCorrectKeyWorkEN.ParentNodeID = objRow[convcc_WorkCorrectKeyWork.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkCorrectKeyWorkEN.ParentNodeName = objRow[convcc_WorkCorrectKeyWork.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkCorrectKeyWorkEN.ParentNodeReferred = objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号
objvcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objRow[convcc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词
objvcc_WorkCorrectKeyWorkEN.IsUseFormatPara = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数
objvcc_WorkCorrectKeyWorkEN.FormatPara = objRow[convcc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数
objvcc_WorkCorrectKeyWorkEN.InOutTypeId = objRow[convcc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id
objvcc_WorkCorrectKeyWorkEN.InOutTypeName = objRow[convcc_WorkCorrectKeyWork.InOutTypeName].ToString().Trim(); //InOut类型类型
objvcc_WorkCorrectKeyWorkEN.Creator = objRow[convcc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者
objvcc_WorkCorrectKeyWorkEN.CreateDate = objRow[convcc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkCorrectKeyWorkEN.IsEnable = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用
objvcc_WorkCorrectKeyWorkEN.UpdDate = objRow[convcc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkCorrectKeyWorkEN.UpdUser = objRow[convcc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人
objvcc_WorkCorrectKeyWorkEN.Memo = objRow[convcc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注
objvcc_WorkCorrectKeyWorkEN.IdWork = objRow[convcc_WorkCorrectKeyWork.IdWork] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.IdWork].ToString().Trim(); //作业流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkCorrectKeyWorkEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcc_WorkCorrectKeyWorkEN> GetSubObjLstCache(clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkCond)
{
List<clsvcc_WorkCorrectKeyWorkEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_WorkCorrectKeyWorkEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_WorkCorrectKeyWork.AttributeName)
{
if (objvcc_WorkCorrectKeyWorkCond.IsUpdated(strFldName) == false) continue;
if (objvcc_WorkCorrectKeyWorkCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkCorrectKeyWorkCond[strFldName].ToString());
}
else
{
if (objvcc_WorkCorrectKeyWorkCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkCorrectKeyWorkCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_WorkCorrectKeyWorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_WorkCorrectKeyWorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_WorkCorrectKeyWorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_WorkCorrectKeyWorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_WorkCorrectKeyWorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_WorkCorrectKeyWorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_WorkCorrectKeyWorkCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_WorkCorrectKeyWorkCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_WorkCorrectKeyWorkCond[strFldName]));
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
public static List<clsvcc_WorkCorrectKeyWorkEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcc_WorkCorrectKeyWorkEN> arrObjLst = new List<clsvcc_WorkCorrectKeyWorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN = new clsvcc_WorkCorrectKeyWorkEN();
try
{
objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = Int32.Parse(objRow[convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号
objvcc_WorkCorrectKeyWorkEN.QuestionID = objRow[convcc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkCorrectKeyWorkEN.WorkIndex = objRow[convcc_WorkCorrectKeyWork.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkCorrectKeyWork.WorkIndex].ToString().Trim()); //作业序号
objvcc_WorkCorrectKeyWorkEN.WorkName = objRow[convcc_WorkCorrectKeyWork.WorkName].ToString().Trim(); //作业名称
objvcc_WorkCorrectKeyWorkEN.WorkDesc = objRow[convcc_WorkCorrectKeyWork.WorkDesc] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.WorkDesc].ToString().Trim(); //作业说明
objvcc_WorkCorrectKeyWorkEN.CourseId = objRow[convcc_WorkCorrectKeyWork.CourseId] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseId].ToString().Trim(); //课程Id
objvcc_WorkCorrectKeyWorkEN.CourseName = objRow[convcc_WorkCorrectKeyWork.CourseName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseName].ToString().Trim(); //课程名称
objvcc_WorkCorrectKeyWorkEN.CourseChapterId = objRow[convcc_WorkCorrectKeyWork.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkCorrectKeyWorkEN.CourseChapterName = objRow[convcc_WorkCorrectKeyWork.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkCorrectKeyWorkEN.CourseChapterReferred = objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkCorrectKeyWorkEN.ParentNodeID = objRow[convcc_WorkCorrectKeyWork.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkCorrectKeyWorkEN.ParentNodeName = objRow[convcc_WorkCorrectKeyWork.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkCorrectKeyWorkEN.ParentNodeReferred = objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号
objvcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objRow[convcc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词
objvcc_WorkCorrectKeyWorkEN.IsUseFormatPara = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数
objvcc_WorkCorrectKeyWorkEN.FormatPara = objRow[convcc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数
objvcc_WorkCorrectKeyWorkEN.InOutTypeId = objRow[convcc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id
objvcc_WorkCorrectKeyWorkEN.InOutTypeName = objRow[convcc_WorkCorrectKeyWork.InOutTypeName].ToString().Trim(); //InOut类型类型
objvcc_WorkCorrectKeyWorkEN.Creator = objRow[convcc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者
objvcc_WorkCorrectKeyWorkEN.CreateDate = objRow[convcc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkCorrectKeyWorkEN.IsEnable = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用
objvcc_WorkCorrectKeyWorkEN.UpdDate = objRow[convcc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkCorrectKeyWorkEN.UpdUser = objRow[convcc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人
objvcc_WorkCorrectKeyWorkEN.Memo = objRow[convcc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注
objvcc_WorkCorrectKeyWorkEN.IdWork = objRow[convcc_WorkCorrectKeyWork.IdWork] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.IdWork].ToString().Trim(); //作业流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkCorrectKeyWorkEN);
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
public static List<clsvcc_WorkCorrectKeyWorkEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcc_WorkCorrectKeyWorkEN> arrObjLst = new List<clsvcc_WorkCorrectKeyWorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN = new clsvcc_WorkCorrectKeyWorkEN();
try
{
objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = Int32.Parse(objRow[convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号
objvcc_WorkCorrectKeyWorkEN.QuestionID = objRow[convcc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkCorrectKeyWorkEN.WorkIndex = objRow[convcc_WorkCorrectKeyWork.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkCorrectKeyWork.WorkIndex].ToString().Trim()); //作业序号
objvcc_WorkCorrectKeyWorkEN.WorkName = objRow[convcc_WorkCorrectKeyWork.WorkName].ToString().Trim(); //作业名称
objvcc_WorkCorrectKeyWorkEN.WorkDesc = objRow[convcc_WorkCorrectKeyWork.WorkDesc] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.WorkDesc].ToString().Trim(); //作业说明
objvcc_WorkCorrectKeyWorkEN.CourseId = objRow[convcc_WorkCorrectKeyWork.CourseId] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseId].ToString().Trim(); //课程Id
objvcc_WorkCorrectKeyWorkEN.CourseName = objRow[convcc_WorkCorrectKeyWork.CourseName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseName].ToString().Trim(); //课程名称
objvcc_WorkCorrectKeyWorkEN.CourseChapterId = objRow[convcc_WorkCorrectKeyWork.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkCorrectKeyWorkEN.CourseChapterName = objRow[convcc_WorkCorrectKeyWork.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkCorrectKeyWorkEN.CourseChapterReferred = objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkCorrectKeyWorkEN.ParentNodeID = objRow[convcc_WorkCorrectKeyWork.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkCorrectKeyWorkEN.ParentNodeName = objRow[convcc_WorkCorrectKeyWork.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkCorrectKeyWorkEN.ParentNodeReferred = objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号
objvcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objRow[convcc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词
objvcc_WorkCorrectKeyWorkEN.IsUseFormatPara = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数
objvcc_WorkCorrectKeyWorkEN.FormatPara = objRow[convcc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数
objvcc_WorkCorrectKeyWorkEN.InOutTypeId = objRow[convcc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id
objvcc_WorkCorrectKeyWorkEN.InOutTypeName = objRow[convcc_WorkCorrectKeyWork.InOutTypeName].ToString().Trim(); //InOut类型类型
objvcc_WorkCorrectKeyWorkEN.Creator = objRow[convcc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者
objvcc_WorkCorrectKeyWorkEN.CreateDate = objRow[convcc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkCorrectKeyWorkEN.IsEnable = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用
objvcc_WorkCorrectKeyWorkEN.UpdDate = objRow[convcc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkCorrectKeyWorkEN.UpdUser = objRow[convcc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人
objvcc_WorkCorrectKeyWorkEN.Memo = objRow[convcc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注
objvcc_WorkCorrectKeyWorkEN.IdWork = objRow[convcc_WorkCorrectKeyWork.IdWork] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.IdWork].ToString().Trim(); //作业流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkCorrectKeyWorkEN);
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
List<clsvcc_WorkCorrectKeyWorkEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcc_WorkCorrectKeyWorkEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkCorrectKeyWorkEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcc_WorkCorrectKeyWorkEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_WorkCorrectKeyWorkEN> arrObjLst = new List<clsvcc_WorkCorrectKeyWorkEN>(); 
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
	clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN = new clsvcc_WorkCorrectKeyWorkEN();
try
{
objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = Int32.Parse(objRow[convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号
objvcc_WorkCorrectKeyWorkEN.QuestionID = objRow[convcc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkCorrectKeyWorkEN.WorkIndex = objRow[convcc_WorkCorrectKeyWork.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkCorrectKeyWork.WorkIndex].ToString().Trim()); //作业序号
objvcc_WorkCorrectKeyWorkEN.WorkName = objRow[convcc_WorkCorrectKeyWork.WorkName].ToString().Trim(); //作业名称
objvcc_WorkCorrectKeyWorkEN.WorkDesc = objRow[convcc_WorkCorrectKeyWork.WorkDesc] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.WorkDesc].ToString().Trim(); //作业说明
objvcc_WorkCorrectKeyWorkEN.CourseId = objRow[convcc_WorkCorrectKeyWork.CourseId] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseId].ToString().Trim(); //课程Id
objvcc_WorkCorrectKeyWorkEN.CourseName = objRow[convcc_WorkCorrectKeyWork.CourseName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseName].ToString().Trim(); //课程名称
objvcc_WorkCorrectKeyWorkEN.CourseChapterId = objRow[convcc_WorkCorrectKeyWork.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkCorrectKeyWorkEN.CourseChapterName = objRow[convcc_WorkCorrectKeyWork.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkCorrectKeyWorkEN.CourseChapterReferred = objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkCorrectKeyWorkEN.ParentNodeID = objRow[convcc_WorkCorrectKeyWork.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkCorrectKeyWorkEN.ParentNodeName = objRow[convcc_WorkCorrectKeyWork.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkCorrectKeyWorkEN.ParentNodeReferred = objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号
objvcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objRow[convcc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词
objvcc_WorkCorrectKeyWorkEN.IsUseFormatPara = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数
objvcc_WorkCorrectKeyWorkEN.FormatPara = objRow[convcc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数
objvcc_WorkCorrectKeyWorkEN.InOutTypeId = objRow[convcc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id
objvcc_WorkCorrectKeyWorkEN.InOutTypeName = objRow[convcc_WorkCorrectKeyWork.InOutTypeName].ToString().Trim(); //InOut类型类型
objvcc_WorkCorrectKeyWorkEN.Creator = objRow[convcc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者
objvcc_WorkCorrectKeyWorkEN.CreateDate = objRow[convcc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkCorrectKeyWorkEN.IsEnable = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用
objvcc_WorkCorrectKeyWorkEN.UpdDate = objRow[convcc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkCorrectKeyWorkEN.UpdUser = objRow[convcc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人
objvcc_WorkCorrectKeyWorkEN.Memo = objRow[convcc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注
objvcc_WorkCorrectKeyWorkEN.IdWork = objRow[convcc_WorkCorrectKeyWork.IdWork] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.IdWork].ToString().Trim(); //作业流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkCorrectKeyWorkEN);
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
public static List<clsvcc_WorkCorrectKeyWorkEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcc_WorkCorrectKeyWorkEN> arrObjLst = new List<clsvcc_WorkCorrectKeyWorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN = new clsvcc_WorkCorrectKeyWorkEN();
try
{
objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = Int32.Parse(objRow[convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号
objvcc_WorkCorrectKeyWorkEN.QuestionID = objRow[convcc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkCorrectKeyWorkEN.WorkIndex = objRow[convcc_WorkCorrectKeyWork.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkCorrectKeyWork.WorkIndex].ToString().Trim()); //作业序号
objvcc_WorkCorrectKeyWorkEN.WorkName = objRow[convcc_WorkCorrectKeyWork.WorkName].ToString().Trim(); //作业名称
objvcc_WorkCorrectKeyWorkEN.WorkDesc = objRow[convcc_WorkCorrectKeyWork.WorkDesc] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.WorkDesc].ToString().Trim(); //作业说明
objvcc_WorkCorrectKeyWorkEN.CourseId = objRow[convcc_WorkCorrectKeyWork.CourseId] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseId].ToString().Trim(); //课程Id
objvcc_WorkCorrectKeyWorkEN.CourseName = objRow[convcc_WorkCorrectKeyWork.CourseName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseName].ToString().Trim(); //课程名称
objvcc_WorkCorrectKeyWorkEN.CourseChapterId = objRow[convcc_WorkCorrectKeyWork.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkCorrectKeyWorkEN.CourseChapterName = objRow[convcc_WorkCorrectKeyWork.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkCorrectKeyWorkEN.CourseChapterReferred = objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkCorrectKeyWorkEN.ParentNodeID = objRow[convcc_WorkCorrectKeyWork.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkCorrectKeyWorkEN.ParentNodeName = objRow[convcc_WorkCorrectKeyWork.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkCorrectKeyWorkEN.ParentNodeReferred = objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号
objvcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objRow[convcc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词
objvcc_WorkCorrectKeyWorkEN.IsUseFormatPara = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数
objvcc_WorkCorrectKeyWorkEN.FormatPara = objRow[convcc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数
objvcc_WorkCorrectKeyWorkEN.InOutTypeId = objRow[convcc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id
objvcc_WorkCorrectKeyWorkEN.InOutTypeName = objRow[convcc_WorkCorrectKeyWork.InOutTypeName].ToString().Trim(); //InOut类型类型
objvcc_WorkCorrectKeyWorkEN.Creator = objRow[convcc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者
objvcc_WorkCorrectKeyWorkEN.CreateDate = objRow[convcc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkCorrectKeyWorkEN.IsEnable = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用
objvcc_WorkCorrectKeyWorkEN.UpdDate = objRow[convcc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkCorrectKeyWorkEN.UpdUser = objRow[convcc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人
objvcc_WorkCorrectKeyWorkEN.Memo = objRow[convcc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注
objvcc_WorkCorrectKeyWorkEN.IdWork = objRow[convcc_WorkCorrectKeyWork.IdWork] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.IdWork].ToString().Trim(); //作业流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkCorrectKeyWorkEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcc_WorkCorrectKeyWorkEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcc_WorkCorrectKeyWorkEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_WorkCorrectKeyWorkEN> arrObjLst = new List<clsvcc_WorkCorrectKeyWorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN = new clsvcc_WorkCorrectKeyWorkEN();
try
{
objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = Int32.Parse(objRow[convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号
objvcc_WorkCorrectKeyWorkEN.QuestionID = objRow[convcc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkCorrectKeyWorkEN.WorkIndex = objRow[convcc_WorkCorrectKeyWork.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkCorrectKeyWork.WorkIndex].ToString().Trim()); //作业序号
objvcc_WorkCorrectKeyWorkEN.WorkName = objRow[convcc_WorkCorrectKeyWork.WorkName].ToString().Trim(); //作业名称
objvcc_WorkCorrectKeyWorkEN.WorkDesc = objRow[convcc_WorkCorrectKeyWork.WorkDesc] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.WorkDesc].ToString().Trim(); //作业说明
objvcc_WorkCorrectKeyWorkEN.CourseId = objRow[convcc_WorkCorrectKeyWork.CourseId] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseId].ToString().Trim(); //课程Id
objvcc_WorkCorrectKeyWorkEN.CourseName = objRow[convcc_WorkCorrectKeyWork.CourseName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseName].ToString().Trim(); //课程名称
objvcc_WorkCorrectKeyWorkEN.CourseChapterId = objRow[convcc_WorkCorrectKeyWork.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkCorrectKeyWorkEN.CourseChapterName = objRow[convcc_WorkCorrectKeyWork.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkCorrectKeyWorkEN.CourseChapterReferred = objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkCorrectKeyWorkEN.ParentNodeID = objRow[convcc_WorkCorrectKeyWork.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkCorrectKeyWorkEN.ParentNodeName = objRow[convcc_WorkCorrectKeyWork.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkCorrectKeyWorkEN.ParentNodeReferred = objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号
objvcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objRow[convcc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词
objvcc_WorkCorrectKeyWorkEN.IsUseFormatPara = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数
objvcc_WorkCorrectKeyWorkEN.FormatPara = objRow[convcc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数
objvcc_WorkCorrectKeyWorkEN.InOutTypeId = objRow[convcc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id
objvcc_WorkCorrectKeyWorkEN.InOutTypeName = objRow[convcc_WorkCorrectKeyWork.InOutTypeName].ToString().Trim(); //InOut类型类型
objvcc_WorkCorrectKeyWorkEN.Creator = objRow[convcc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者
objvcc_WorkCorrectKeyWorkEN.CreateDate = objRow[convcc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkCorrectKeyWorkEN.IsEnable = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用
objvcc_WorkCorrectKeyWorkEN.UpdDate = objRow[convcc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkCorrectKeyWorkEN.UpdUser = objRow[convcc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人
objvcc_WorkCorrectKeyWorkEN.Memo = objRow[convcc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注
objvcc_WorkCorrectKeyWorkEN.IdWork = objRow[convcc_WorkCorrectKeyWork.IdWork] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.IdWork].ToString().Trim(); //作业流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkCorrectKeyWorkEN);
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
public static List<clsvcc_WorkCorrectKeyWorkEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcc_WorkCorrectKeyWorkEN> arrObjLst = new List<clsvcc_WorkCorrectKeyWorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN = new clsvcc_WorkCorrectKeyWorkEN();
try
{
objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = Int32.Parse(objRow[convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号
objvcc_WorkCorrectKeyWorkEN.QuestionID = objRow[convcc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkCorrectKeyWorkEN.WorkIndex = objRow[convcc_WorkCorrectKeyWork.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkCorrectKeyWork.WorkIndex].ToString().Trim()); //作业序号
objvcc_WorkCorrectKeyWorkEN.WorkName = objRow[convcc_WorkCorrectKeyWork.WorkName].ToString().Trim(); //作业名称
objvcc_WorkCorrectKeyWorkEN.WorkDesc = objRow[convcc_WorkCorrectKeyWork.WorkDesc] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.WorkDesc].ToString().Trim(); //作业说明
objvcc_WorkCorrectKeyWorkEN.CourseId = objRow[convcc_WorkCorrectKeyWork.CourseId] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseId].ToString().Trim(); //课程Id
objvcc_WorkCorrectKeyWorkEN.CourseName = objRow[convcc_WorkCorrectKeyWork.CourseName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseName].ToString().Trim(); //课程名称
objvcc_WorkCorrectKeyWorkEN.CourseChapterId = objRow[convcc_WorkCorrectKeyWork.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkCorrectKeyWorkEN.CourseChapterName = objRow[convcc_WorkCorrectKeyWork.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkCorrectKeyWorkEN.CourseChapterReferred = objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkCorrectKeyWorkEN.ParentNodeID = objRow[convcc_WorkCorrectKeyWork.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkCorrectKeyWorkEN.ParentNodeName = objRow[convcc_WorkCorrectKeyWork.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkCorrectKeyWorkEN.ParentNodeReferred = objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号
objvcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objRow[convcc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词
objvcc_WorkCorrectKeyWorkEN.IsUseFormatPara = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数
objvcc_WorkCorrectKeyWorkEN.FormatPara = objRow[convcc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数
objvcc_WorkCorrectKeyWorkEN.InOutTypeId = objRow[convcc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id
objvcc_WorkCorrectKeyWorkEN.InOutTypeName = objRow[convcc_WorkCorrectKeyWork.InOutTypeName].ToString().Trim(); //InOut类型类型
objvcc_WorkCorrectKeyWorkEN.Creator = objRow[convcc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者
objvcc_WorkCorrectKeyWorkEN.CreateDate = objRow[convcc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkCorrectKeyWorkEN.IsEnable = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用
objvcc_WorkCorrectKeyWorkEN.UpdDate = objRow[convcc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkCorrectKeyWorkEN.UpdUser = objRow[convcc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人
objvcc_WorkCorrectKeyWorkEN.Memo = objRow[convcc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注
objvcc_WorkCorrectKeyWorkEN.IdWork = objRow[convcc_WorkCorrectKeyWork.IdWork] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.IdWork].ToString().Trim(); //作业流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkCorrectKeyWorkEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkCorrectKeyWorkEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcc_WorkCorrectKeyWorkEN> arrObjLst = new List<clsvcc_WorkCorrectKeyWorkEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN = new clsvcc_WorkCorrectKeyWorkEN();
try
{
objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = Int32.Parse(objRow[convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号
objvcc_WorkCorrectKeyWorkEN.QuestionID = objRow[convcc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkCorrectKeyWorkEN.WorkIndex = objRow[convcc_WorkCorrectKeyWork.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkCorrectKeyWork.WorkIndex].ToString().Trim()); //作业序号
objvcc_WorkCorrectKeyWorkEN.WorkName = objRow[convcc_WorkCorrectKeyWork.WorkName].ToString().Trim(); //作业名称
objvcc_WorkCorrectKeyWorkEN.WorkDesc = objRow[convcc_WorkCorrectKeyWork.WorkDesc] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.WorkDesc].ToString().Trim(); //作业说明
objvcc_WorkCorrectKeyWorkEN.CourseId = objRow[convcc_WorkCorrectKeyWork.CourseId] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseId].ToString().Trim(); //课程Id
objvcc_WorkCorrectKeyWorkEN.CourseName = objRow[convcc_WorkCorrectKeyWork.CourseName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseName].ToString().Trim(); //课程名称
objvcc_WorkCorrectKeyWorkEN.CourseChapterId = objRow[convcc_WorkCorrectKeyWork.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkCorrectKeyWorkEN.CourseChapterName = objRow[convcc_WorkCorrectKeyWork.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkCorrectKeyWorkEN.CourseChapterReferred = objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkCorrectKeyWorkEN.ParentNodeID = objRow[convcc_WorkCorrectKeyWork.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkCorrectKeyWorkEN.ParentNodeName = objRow[convcc_WorkCorrectKeyWork.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkCorrectKeyWorkEN.ParentNodeReferred = objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号
objvcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objRow[convcc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词
objvcc_WorkCorrectKeyWorkEN.IsUseFormatPara = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数
objvcc_WorkCorrectKeyWorkEN.FormatPara = objRow[convcc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数
objvcc_WorkCorrectKeyWorkEN.InOutTypeId = objRow[convcc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id
objvcc_WorkCorrectKeyWorkEN.InOutTypeName = objRow[convcc_WorkCorrectKeyWork.InOutTypeName].ToString().Trim(); //InOut类型类型
objvcc_WorkCorrectKeyWorkEN.Creator = objRow[convcc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者
objvcc_WorkCorrectKeyWorkEN.CreateDate = objRow[convcc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkCorrectKeyWorkEN.IsEnable = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用
objvcc_WorkCorrectKeyWorkEN.UpdDate = objRow[convcc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkCorrectKeyWorkEN.UpdUser = objRow[convcc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人
objvcc_WorkCorrectKeyWorkEN.Memo = objRow[convcc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注
objvcc_WorkCorrectKeyWorkEN.IdWork = objRow[convcc_WorkCorrectKeyWork.IdWork] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.IdWork].ToString().Trim(); //作业流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkCorrectKeyWorkEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcc_WorkCorrectKeyWork(ref clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN)
{
bool bolResult = vcc_WorkCorrectKeyWorkDA.Getvcc_WorkCorrectKeyWork(ref objvcc_WorkCorrectKeyWorkEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdWorkCorrectKeyWork">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkCorrectKeyWorkEN GetObjByIdWorkCorrectKeyWork(long lngIdWorkCorrectKeyWork)
{
clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN = vcc_WorkCorrectKeyWorkDA.GetObjByIdWorkCorrectKeyWork(lngIdWorkCorrectKeyWork);
return objvcc_WorkCorrectKeyWorkEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcc_WorkCorrectKeyWorkEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN = vcc_WorkCorrectKeyWorkDA.GetFirstObj(strWhereCond);
 return objvcc_WorkCorrectKeyWorkEN;
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
public static clsvcc_WorkCorrectKeyWorkEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN = vcc_WorkCorrectKeyWorkDA.GetObjByDataRow(objRow);
 return objvcc_WorkCorrectKeyWorkEN;
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
public static clsvcc_WorkCorrectKeyWorkEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN = vcc_WorkCorrectKeyWorkDA.GetObjByDataRow(objRow);
 return objvcc_WorkCorrectKeyWorkEN;
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
 /// <param name = "lngIdWorkCorrectKeyWork">所给的关键字</param>
 /// <param name = "lstvcc_WorkCorrectKeyWorkObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_WorkCorrectKeyWorkEN GetObjByIdWorkCorrectKeyWorkFromList(long lngIdWorkCorrectKeyWork, List<clsvcc_WorkCorrectKeyWorkEN> lstvcc_WorkCorrectKeyWorkObjLst)
{
foreach (clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN in lstvcc_WorkCorrectKeyWorkObjLst)
{
if (objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork == lngIdWorkCorrectKeyWork)
{
return objvcc_WorkCorrectKeyWorkEN;
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
 long lngIdWorkCorrectKeyWork;
 try
 {
 lngIdWorkCorrectKeyWork = new clsvcc_WorkCorrectKeyWorkDA().GetFirstID(strWhereCond);
 return lngIdWorkCorrectKeyWork;
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
 arrList = vcc_WorkCorrectKeyWorkDA.GetID(strWhereCond);
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
bool bolIsExist = vcc_WorkCorrectKeyWorkDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdWorkCorrectKeyWork">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdWorkCorrectKeyWork)
{
//检测记录是否存在
bool bolIsExist = vcc_WorkCorrectKeyWorkDA.IsExist(lngIdWorkCorrectKeyWork);
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
 bolIsExist = clsvcc_WorkCorrectKeyWorkDA.IsExistTable();
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
 bolIsExist = vcc_WorkCorrectKeyWorkDA.IsExistTable(strTabName);
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
 /// <param name = "objvcc_WorkCorrectKeyWorkENS">源对象</param>
 /// <param name = "objvcc_WorkCorrectKeyWorkENT">目标对象</param>
 public static void CopyTo(clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkENS, clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkENT)
{
try
{
objvcc_WorkCorrectKeyWorkENT.IdWorkCorrectKeyWork = objvcc_WorkCorrectKeyWorkENS.IdWorkCorrectKeyWork; //作业批改关键词流水号
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
objvcc_WorkCorrectKeyWorkENT.IdWork = objvcc_WorkCorrectKeyWorkENS.IdWork; //作业流水号
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
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">源简化对象</param>
 public static void SetUpdFlag(clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN)
{
try
{
objvcc_WorkCorrectKeyWorkEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcc_WorkCorrectKeyWorkEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork; //作业批改关键词流水号
}
if (arrFldSet.Contains(convcc_WorkCorrectKeyWork.QuestionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkCorrectKeyWorkEN.QuestionID = objvcc_WorkCorrectKeyWorkEN.QuestionID; //题目ID
}
if (arrFldSet.Contains(convcc_WorkCorrectKeyWork.WorkIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkCorrectKeyWorkEN.WorkIndex = objvcc_WorkCorrectKeyWorkEN.WorkIndex; //作业序号
}
if (arrFldSet.Contains(convcc_WorkCorrectKeyWork.WorkName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkCorrectKeyWorkEN.WorkName = objvcc_WorkCorrectKeyWorkEN.WorkName; //作业名称
}
if (arrFldSet.Contains(convcc_WorkCorrectKeyWork.WorkDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkCorrectKeyWorkEN.WorkDesc = objvcc_WorkCorrectKeyWorkEN.WorkDesc == "[null]" ? null :  objvcc_WorkCorrectKeyWorkEN.WorkDesc; //作业说明
}
if (arrFldSet.Contains(convcc_WorkCorrectKeyWork.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkCorrectKeyWorkEN.CourseId = objvcc_WorkCorrectKeyWorkEN.CourseId == "[null]" ? null :  objvcc_WorkCorrectKeyWorkEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convcc_WorkCorrectKeyWork.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkCorrectKeyWorkEN.CourseName = objvcc_WorkCorrectKeyWorkEN.CourseName == "[null]" ? null :  objvcc_WorkCorrectKeyWorkEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convcc_WorkCorrectKeyWork.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkCorrectKeyWorkEN.CourseChapterId = objvcc_WorkCorrectKeyWorkEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convcc_WorkCorrectKeyWork.CourseChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkCorrectKeyWorkEN.CourseChapterName = objvcc_WorkCorrectKeyWorkEN.CourseChapterName; //课程章节名称
}
if (arrFldSet.Contains(convcc_WorkCorrectKeyWork.CourseChapterReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkCorrectKeyWorkEN.CourseChapterReferred = objvcc_WorkCorrectKeyWorkEN.CourseChapterReferred == "[null]" ? null :  objvcc_WorkCorrectKeyWorkEN.CourseChapterReferred; //节简称
}
if (arrFldSet.Contains(convcc_WorkCorrectKeyWork.ParentNodeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkCorrectKeyWorkEN.ParentNodeID = objvcc_WorkCorrectKeyWorkEN.ParentNodeID == "[null]" ? null :  objvcc_WorkCorrectKeyWorkEN.ParentNodeID; //父节点编号
}
if (arrFldSet.Contains(convcc_WorkCorrectKeyWork.ParentNodeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkCorrectKeyWorkEN.ParentNodeName = objvcc_WorkCorrectKeyWorkEN.ParentNodeName == "[null]" ? null :  objvcc_WorkCorrectKeyWorkEN.ParentNodeName; //父节点名称
}
if (arrFldSet.Contains(convcc_WorkCorrectKeyWork.ParentNodeReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkCorrectKeyWorkEN.ParentNodeReferred = objvcc_WorkCorrectKeyWorkEN.ParentNodeReferred == "[null]" ? null :  objvcc_WorkCorrectKeyWorkEN.ParentNodeReferred; //章简称
}
if (arrFldSet.Contains(convcc_WorkCorrectKeyWork.KeyWorkIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objvcc_WorkCorrectKeyWorkEN.KeyWorkIndex; //关键字序号
}
if (arrFldSet.Contains(convcc_WorkCorrectKeyWork.CorrectKeyWork, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objvcc_WorkCorrectKeyWorkEN.CorrectKeyWork; //批改关键词
}
if (arrFldSet.Contains(convcc_WorkCorrectKeyWork.IsUseFormatPara, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkCorrectKeyWorkEN.IsUseFormatPara = objvcc_WorkCorrectKeyWorkEN.IsUseFormatPara; //是否使用格式化参数
}
if (arrFldSet.Contains(convcc_WorkCorrectKeyWork.FormatPara, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkCorrectKeyWorkEN.FormatPara = objvcc_WorkCorrectKeyWorkEN.FormatPara == "[null]" ? null :  objvcc_WorkCorrectKeyWorkEN.FormatPara; //格式化参数
}
if (arrFldSet.Contains(convcc_WorkCorrectKeyWork.InOutTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkCorrectKeyWorkEN.InOutTypeId = objvcc_WorkCorrectKeyWorkEN.InOutTypeId; //InOut类型Id
}
if (arrFldSet.Contains(convcc_WorkCorrectKeyWork.InOutTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkCorrectKeyWorkEN.InOutTypeName = objvcc_WorkCorrectKeyWorkEN.InOutTypeName; //InOut类型类型
}
if (arrFldSet.Contains(convcc_WorkCorrectKeyWork.Creator, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkCorrectKeyWorkEN.Creator = objvcc_WorkCorrectKeyWorkEN.Creator == "[null]" ? null :  objvcc_WorkCorrectKeyWorkEN.Creator; //创建者
}
if (arrFldSet.Contains(convcc_WorkCorrectKeyWork.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkCorrectKeyWorkEN.CreateDate = objvcc_WorkCorrectKeyWorkEN.CreateDate == "[null]" ? null :  objvcc_WorkCorrectKeyWorkEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convcc_WorkCorrectKeyWork.IsEnable, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkCorrectKeyWorkEN.IsEnable = objvcc_WorkCorrectKeyWorkEN.IsEnable; //是否启用
}
if (arrFldSet.Contains(convcc_WorkCorrectKeyWork.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkCorrectKeyWorkEN.UpdDate = objvcc_WorkCorrectKeyWorkEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convcc_WorkCorrectKeyWork.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkCorrectKeyWorkEN.UpdUser = objvcc_WorkCorrectKeyWorkEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convcc_WorkCorrectKeyWork.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkCorrectKeyWorkEN.Memo = objvcc_WorkCorrectKeyWorkEN.Memo == "[null]" ? null :  objvcc_WorkCorrectKeyWorkEN.Memo; //备注
}
if (arrFldSet.Contains(convcc_WorkCorrectKeyWork.IdWork, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkCorrectKeyWorkEN.IdWork = objvcc_WorkCorrectKeyWorkEN.IdWork == "[null]" ? null :  objvcc_WorkCorrectKeyWorkEN.IdWork; //作业流水号
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
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN)
{
try
{
if (objvcc_WorkCorrectKeyWorkEN.WorkDesc == "[null]") objvcc_WorkCorrectKeyWorkEN.WorkDesc = null; //作业说明
if (objvcc_WorkCorrectKeyWorkEN.CourseId == "[null]") objvcc_WorkCorrectKeyWorkEN.CourseId = null; //课程Id
if (objvcc_WorkCorrectKeyWorkEN.CourseName == "[null]") objvcc_WorkCorrectKeyWorkEN.CourseName = null; //课程名称
if (objvcc_WorkCorrectKeyWorkEN.CourseChapterReferred == "[null]") objvcc_WorkCorrectKeyWorkEN.CourseChapterReferred = null; //节简称
if (objvcc_WorkCorrectKeyWorkEN.ParentNodeID == "[null]") objvcc_WorkCorrectKeyWorkEN.ParentNodeID = null; //父节点编号
if (objvcc_WorkCorrectKeyWorkEN.ParentNodeName == "[null]") objvcc_WorkCorrectKeyWorkEN.ParentNodeName = null; //父节点名称
if (objvcc_WorkCorrectKeyWorkEN.ParentNodeReferred == "[null]") objvcc_WorkCorrectKeyWorkEN.ParentNodeReferred = null; //章简称
if (objvcc_WorkCorrectKeyWorkEN.FormatPara == "[null]") objvcc_WorkCorrectKeyWorkEN.FormatPara = null; //格式化参数
if (objvcc_WorkCorrectKeyWorkEN.Creator == "[null]") objvcc_WorkCorrectKeyWorkEN.Creator = null; //创建者
if (objvcc_WorkCorrectKeyWorkEN.CreateDate == "[null]") objvcc_WorkCorrectKeyWorkEN.CreateDate = null; //建立日期
if (objvcc_WorkCorrectKeyWorkEN.Memo == "[null]") objvcc_WorkCorrectKeyWorkEN.Memo = null; //备注
if (objvcc_WorkCorrectKeyWorkEN.IdWork == "[null]") objvcc_WorkCorrectKeyWorkEN.IdWork = null; //作业流水号
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
public static void CheckProperty4Condition(clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN)
{
 vcc_WorkCorrectKeyWorkDA.CheckProperty4Condition(objvcc_WorkCorrectKeyWorkEN);
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
if (clscc_WorkCorrectKeyWorkBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkCorrectKeyWorkBL没有刷新缓存机制(clscc_WorkCorrectKeyWorkBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsInOutTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsInOutTypeBL没有刷新缓存机制(clsInOutTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_WorkBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkBL没有刷新缓存机制(clscc_WorkBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterBL没有刷新缓存机制(clscc_CourseChapterBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_ThemesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesBL没有刷新缓存机制(clscc_ThemesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeBL没有刷新缓存机制(clscc_CourseIsLikeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdWorkCorrectKeyWork");
//if (arrvcc_WorkCorrectKeyWorkObjLstCache == null)
//{
//arrvcc_WorkCorrectKeyWorkObjLstCache = vcc_WorkCorrectKeyWorkDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdWorkCorrectKeyWork">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_WorkCorrectKeyWorkEN GetObjByIdWorkCorrectKeyWorkCache(long lngIdWorkCorrectKeyWork)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvcc_WorkCorrectKeyWorkEN._CurrTabName);
List<clsvcc_WorkCorrectKeyWorkEN> arrvcc_WorkCorrectKeyWorkObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_WorkCorrectKeyWorkEN> arrvcc_WorkCorrectKeyWorkObjLst_Sel =
arrvcc_WorkCorrectKeyWorkObjLstCache
.Where(x=> x.IdWorkCorrectKeyWork == lngIdWorkCorrectKeyWork 
);
if (arrvcc_WorkCorrectKeyWorkObjLst_Sel.Count() == 0)
{
   clsvcc_WorkCorrectKeyWorkEN obj = clsvcc_WorkCorrectKeyWorkBL.GetObjByIdWorkCorrectKeyWork(lngIdWorkCorrectKeyWork);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvcc_WorkCorrectKeyWorkObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_WorkCorrectKeyWorkEN> GetAllvcc_WorkCorrectKeyWorkObjLstCache()
{
//获取缓存中的对象列表
List<clsvcc_WorkCorrectKeyWorkEN> arrvcc_WorkCorrectKeyWorkObjLstCache = GetObjLstCache(); 
return arrvcc_WorkCorrectKeyWorkObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_WorkCorrectKeyWorkEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvcc_WorkCorrectKeyWorkEN._CurrTabName);
List<clsvcc_WorkCorrectKeyWorkEN> arrvcc_WorkCorrectKeyWorkObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_WorkCorrectKeyWorkObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvcc_WorkCorrectKeyWorkEN._CurrTabName);
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngIdWorkCorrectKeyWork)
{
if (strInFldName != convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcc_WorkCorrectKeyWork.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcc_WorkCorrectKeyWork.AttributeName));
throw new Exception(strMsg);
}
var objvcc_WorkCorrectKeyWork = clsvcc_WorkCorrectKeyWorkBL.GetObjByIdWorkCorrectKeyWorkCache(lngIdWorkCorrectKeyWork);
if (objvcc_WorkCorrectKeyWork == null) return "";
return objvcc_WorkCorrectKeyWork[strOutFldName].ToString();
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
int intRecCount = clsvcc_WorkCorrectKeyWorkDA.GetRecCount(strTabName);
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
int intRecCount = clsvcc_WorkCorrectKeyWorkDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcc_WorkCorrectKeyWorkDA.GetRecCount();
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
int intRecCount = clsvcc_WorkCorrectKeyWorkDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkCond)
{
List<clsvcc_WorkCorrectKeyWorkEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_WorkCorrectKeyWorkEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_WorkCorrectKeyWork.AttributeName)
{
if (objvcc_WorkCorrectKeyWorkCond.IsUpdated(strFldName) == false) continue;
if (objvcc_WorkCorrectKeyWorkCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkCorrectKeyWorkCond[strFldName].ToString());
}
else
{
if (objvcc_WorkCorrectKeyWorkCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkCorrectKeyWorkCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_WorkCorrectKeyWorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_WorkCorrectKeyWorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_WorkCorrectKeyWorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_WorkCorrectKeyWorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_WorkCorrectKeyWorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_WorkCorrectKeyWorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_WorkCorrectKeyWorkCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_WorkCorrectKeyWorkCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_WorkCorrectKeyWorkCond[strFldName]));
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
 List<string> arrList = clsvcc_WorkCorrectKeyWorkDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcc_WorkCorrectKeyWorkDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcc_WorkCorrectKeyWorkDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}