
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkBL
 表名:vcc_Work(01120146)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:12
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
public static class  clsvcc_WorkBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdWork">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkEN GetObj(this K_IdWork_vcc_Work myKey)
{
clsvcc_WorkEN objvcc_WorkEN = clsvcc_WorkBL.vcc_WorkDA.GetObjByIdWork(myKey.Value);
return objvcc_WorkEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEN SetIdWork(this clsvcc_WorkEN objvcc_WorkEN, string strIdWork, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdWork, 8, convcc_Work.IdWork);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdWork, 8, convcc_Work.IdWork);
}
objvcc_WorkEN.IdWork = strIdWork; //作业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEN.dicFldComparisonOp.ContainsKey(convcc_Work.IdWork) == false)
{
objvcc_WorkEN.dicFldComparisonOp.Add(convcc_Work.IdWork, strComparisonOp);
}
else
{
objvcc_WorkEN.dicFldComparisonOp[convcc_Work.IdWork] = strComparisonOp;
}
}
return objvcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEN SetWorkIndex(this clsvcc_WorkEN objvcc_WorkEN, int? intWorkIndex, string strComparisonOp="")
	{
objvcc_WorkEN.WorkIndex = intWorkIndex; //作业序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEN.dicFldComparisonOp.ContainsKey(convcc_Work.WorkIndex) == false)
{
objvcc_WorkEN.dicFldComparisonOp.Add(convcc_Work.WorkIndex, strComparisonOp);
}
else
{
objvcc_WorkEN.dicFldComparisonOp[convcc_Work.WorkIndex] = strComparisonOp;
}
}
return objvcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEN SetWorkName(this clsvcc_WorkEN objvcc_WorkEN, string strWorkName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkName, convcc_Work.WorkName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkName, 5000, convcc_Work.WorkName);
}
objvcc_WorkEN.WorkName = strWorkName; //作业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEN.dicFldComparisonOp.ContainsKey(convcc_Work.WorkName) == false)
{
objvcc_WorkEN.dicFldComparisonOp.Add(convcc_Work.WorkName, strComparisonOp);
}
else
{
objvcc_WorkEN.dicFldComparisonOp[convcc_Work.WorkName] = strComparisonOp;
}
}
return objvcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEN SetWorkDesc(this clsvcc_WorkEN objvcc_WorkEN, string strWorkDesc, string strComparisonOp="")
	{
objvcc_WorkEN.WorkDesc = strWorkDesc; //作业说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEN.dicFldComparisonOp.ContainsKey(convcc_Work.WorkDesc) == false)
{
objvcc_WorkEN.dicFldComparisonOp.Add(convcc_Work.WorkDesc, strComparisonOp);
}
else
{
objvcc_WorkEN.dicFldComparisonOp[convcc_Work.WorkDesc] = strComparisonOp;
}
}
return objvcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEN SetCourseId(this clsvcc_WorkEN objvcc_WorkEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_Work.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_Work.CourseId);
}
objvcc_WorkEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEN.dicFldComparisonOp.ContainsKey(convcc_Work.CourseId) == false)
{
objvcc_WorkEN.dicFldComparisonOp.Add(convcc_Work.CourseId, strComparisonOp);
}
else
{
objvcc_WorkEN.dicFldComparisonOp[convcc_Work.CourseId] = strComparisonOp;
}
}
return objvcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEN SetCourseName(this clsvcc_WorkEN objvcc_WorkEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_Work.CourseName);
}
objvcc_WorkEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEN.dicFldComparisonOp.ContainsKey(convcc_Work.CourseName) == false)
{
objvcc_WorkEN.dicFldComparisonOp.Add(convcc_Work.CourseName, strComparisonOp);
}
else
{
objvcc_WorkEN.dicFldComparisonOp[convcc_Work.CourseName] = strComparisonOp;
}
}
return objvcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEN SetCourseChapterId(this clsvcc_WorkEN objvcc_WorkEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_Work.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_Work.CourseChapterId);
}
objvcc_WorkEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEN.dicFldComparisonOp.ContainsKey(convcc_Work.CourseChapterId) == false)
{
objvcc_WorkEN.dicFldComparisonOp.Add(convcc_Work.CourseChapterId, strComparisonOp);
}
else
{
objvcc_WorkEN.dicFldComparisonOp[convcc_Work.CourseChapterId] = strComparisonOp;
}
}
return objvcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEN SetCourseChapterName(this clsvcc_WorkEN objvcc_WorkEN, string strCourseChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_Work.CourseChapterName);
}
objvcc_WorkEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEN.dicFldComparisonOp.ContainsKey(convcc_Work.CourseChapterName) == false)
{
objvcc_WorkEN.dicFldComparisonOp.Add(convcc_Work.CourseChapterName, strComparisonOp);
}
else
{
objvcc_WorkEN.dicFldComparisonOp[convcc_Work.CourseChapterName] = strComparisonOp;
}
}
return objvcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEN SetChapterName(this clsvcc_WorkEN objvcc_WorkEN, string strChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_Work.ChapterName);
}
objvcc_WorkEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEN.dicFldComparisonOp.ContainsKey(convcc_Work.ChapterName) == false)
{
objvcc_WorkEN.dicFldComparisonOp.Add(convcc_Work.ChapterName, strComparisonOp);
}
else
{
objvcc_WorkEN.dicFldComparisonOp[convcc_Work.ChapterName] = strComparisonOp;
}
}
return objvcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEN SetSectionName(this clsvcc_WorkEN objvcc_WorkEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_Work.SectionName);
}
objvcc_WorkEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEN.dicFldComparisonOp.ContainsKey(convcc_Work.SectionName) == false)
{
objvcc_WorkEN.dicFldComparisonOp.Add(convcc_Work.SectionName, strComparisonOp);
}
else
{
objvcc_WorkEN.dicFldComparisonOp[convcc_Work.SectionName] = strComparisonOp;
}
}
return objvcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEN SetChapterNameSim(this clsvcc_WorkEN objvcc_WorkEN, string strChapterNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterNameSim, 10, convcc_Work.ChapterNameSim);
}
objvcc_WorkEN.ChapterNameSim = strChapterNameSim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEN.dicFldComparisonOp.ContainsKey(convcc_Work.ChapterNameSim) == false)
{
objvcc_WorkEN.dicFldComparisonOp.Add(convcc_Work.ChapterNameSim, strComparisonOp);
}
else
{
objvcc_WorkEN.dicFldComparisonOp[convcc_Work.ChapterNameSim] = strComparisonOp;
}
}
return objvcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEN SetSectionNameSim(this clsvcc_WorkEN objvcc_WorkEN, string strSectionNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionNameSim, 10, convcc_Work.SectionNameSim);
}
objvcc_WorkEN.SectionNameSim = strSectionNameSim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEN.dicFldComparisonOp.ContainsKey(convcc_Work.SectionNameSim) == false)
{
objvcc_WorkEN.dicFldComparisonOp.Add(convcc_Work.SectionNameSim, strComparisonOp);
}
else
{
objvcc_WorkEN.dicFldComparisonOp[convcc_Work.SectionNameSim] = strComparisonOp;
}
}
return objvcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEN SetParentNodeID(this clsvcc_WorkEN objvcc_WorkEN, string strParentNodeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convcc_Work.ParentNodeID);
}
objvcc_WorkEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEN.dicFldComparisonOp.ContainsKey(convcc_Work.ParentNodeID) == false)
{
objvcc_WorkEN.dicFldComparisonOp.Add(convcc_Work.ParentNodeID, strComparisonOp);
}
else
{
objvcc_WorkEN.dicFldComparisonOp[convcc_Work.ParentNodeID] = strComparisonOp;
}
}
return objvcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEN SetCourseChapterReferred(this clsvcc_WorkEN objvcc_WorkEN, string strCourseChapterReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convcc_Work.CourseChapterReferred);
}
objvcc_WorkEN.CourseChapterReferred = strCourseChapterReferred; //节简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEN.dicFldComparisonOp.ContainsKey(convcc_Work.CourseChapterReferred) == false)
{
objvcc_WorkEN.dicFldComparisonOp.Add(convcc_Work.CourseChapterReferred, strComparisonOp);
}
else
{
objvcc_WorkEN.dicFldComparisonOp[convcc_Work.CourseChapterReferred] = strComparisonOp;
}
}
return objvcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEN SetParentNodeName(this clsvcc_WorkEN objvcc_WorkEN, string strParentNodeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convcc_Work.ParentNodeName);
}
objvcc_WorkEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEN.dicFldComparisonOp.ContainsKey(convcc_Work.ParentNodeName) == false)
{
objvcc_WorkEN.dicFldComparisonOp.Add(convcc_Work.ParentNodeName, strComparisonOp);
}
else
{
objvcc_WorkEN.dicFldComparisonOp[convcc_Work.ParentNodeName] = strComparisonOp;
}
}
return objvcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEN SetParentNodeReferred(this clsvcc_WorkEN objvcc_WorkEN, string strParentNodeReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convcc_Work.ParentNodeReferred);
}
objvcc_WorkEN.ParentNodeReferred = strParentNodeReferred; //章简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEN.dicFldComparisonOp.ContainsKey(convcc_Work.ParentNodeReferred) == false)
{
objvcc_WorkEN.dicFldComparisonOp.Add(convcc_Work.ParentNodeReferred, strComparisonOp);
}
else
{
objvcc_WorkEN.dicFldComparisonOp[convcc_Work.ParentNodeReferred] = strComparisonOp;
}
}
return objvcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEN SetCreator(this clsvcc_WorkEN objvcc_WorkEN, string strCreator, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreator, 18, convcc_Work.Creator);
}
objvcc_WorkEN.Creator = strCreator; //创建者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEN.dicFldComparisonOp.ContainsKey(convcc_Work.Creator) == false)
{
objvcc_WorkEN.dicFldComparisonOp.Add(convcc_Work.Creator, strComparisonOp);
}
else
{
objvcc_WorkEN.dicFldComparisonOp[convcc_Work.Creator] = strComparisonOp;
}
}
return objvcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEN SetCreateDate(this clsvcc_WorkEN objvcc_WorkEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convcc_Work.CreateDate);
}
objvcc_WorkEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEN.dicFldComparisonOp.ContainsKey(convcc_Work.CreateDate) == false)
{
objvcc_WorkEN.dicFldComparisonOp.Add(convcc_Work.CreateDate, strComparisonOp);
}
else
{
objvcc_WorkEN.dicFldComparisonOp[convcc_Work.CreateDate] = strComparisonOp;
}
}
return objvcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEN SetAnswerAttLimitSize(this clsvcc_WorkEN objvcc_WorkEN, long? lngAnswerAttLimitSize, string strComparisonOp="")
	{
objvcc_WorkEN.AnswerAttLimitSize = lngAnswerAttLimitSize; //回答附件限制大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEN.dicFldComparisonOp.ContainsKey(convcc_Work.AnswerAttLimitSize) == false)
{
objvcc_WorkEN.dicFldComparisonOp.Add(convcc_Work.AnswerAttLimitSize, strComparisonOp);
}
else
{
objvcc_WorkEN.dicFldComparisonOp[convcc_Work.AnswerAttLimitSize] = strComparisonOp;
}
}
return objvcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEN SetLimitedResourceType(this clsvcc_WorkEN objvcc_WorkEN, string strLimitedResourceType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLimitedResourceType, 100, convcc_Work.LimitedResourceType);
}
objvcc_WorkEN.LimitedResourceType = strLimitedResourceType; //限制资源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEN.dicFldComparisonOp.ContainsKey(convcc_Work.LimitedResourceType) == false)
{
objvcc_WorkEN.dicFldComparisonOp.Add(convcc_Work.LimitedResourceType, strComparisonOp);
}
else
{
objvcc_WorkEN.dicFldComparisonOp[convcc_Work.LimitedResourceType] = strComparisonOp;
}
}
return objvcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEN SetUpdDate(this clsvcc_WorkEN objvcc_WorkEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_Work.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_Work.UpdDate);
}
objvcc_WorkEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEN.dicFldComparisonOp.ContainsKey(convcc_Work.UpdDate) == false)
{
objvcc_WorkEN.dicFldComparisonOp.Add(convcc_Work.UpdDate, strComparisonOp);
}
else
{
objvcc_WorkEN.dicFldComparisonOp[convcc_Work.UpdDate] = strComparisonOp;
}
}
return objvcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEN SetUpdUserId(this clsvcc_WorkEN objvcc_WorkEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_Work.UpdUserId);
}
objvcc_WorkEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEN.dicFldComparisonOp.ContainsKey(convcc_Work.UpdUserId) == false)
{
objvcc_WorkEN.dicFldComparisonOp.Add(convcc_Work.UpdUserId, strComparisonOp);
}
else
{
objvcc_WorkEN.dicFldComparisonOp[convcc_Work.UpdUserId] = strComparisonOp;
}
}
return objvcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEN SetMemo(this clsvcc_WorkEN objvcc_WorkEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_Work.Memo);
}
objvcc_WorkEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEN.dicFldComparisonOp.ContainsKey(convcc_Work.Memo) == false)
{
objvcc_WorkEN.dicFldComparisonOp.Add(convcc_Work.Memo, strComparisonOp);
}
else
{
objvcc_WorkEN.dicFldComparisonOp[convcc_Work.Memo] = strComparisonOp;
}
}
return objvcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEN SetCourseId4Chapter(this clsvcc_WorkEN objvcc_WorkEN, string strCourseId4Chapter, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId4Chapter, 8, convcc_Work.CourseId4Chapter);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId4Chapter, 8, convcc_Work.CourseId4Chapter);
}
objvcc_WorkEN.CourseId4Chapter = strCourseId4Chapter; //CourseId4Chapter
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEN.dicFldComparisonOp.ContainsKey(convcc_Work.CourseId4Chapter) == false)
{
objvcc_WorkEN.dicFldComparisonOp.Add(convcc_Work.CourseId4Chapter, strComparisonOp);
}
else
{
objvcc_WorkEN.dicFldComparisonOp[convcc_Work.CourseId4Chapter] = strComparisonOp;
}
}
return objvcc_WorkEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcc_WorkENS">源对象</param>
 /// <param name = "objvcc_WorkENT">目标对象</param>
 public static void CopyTo(this clsvcc_WorkEN objvcc_WorkENS, clsvcc_WorkEN objvcc_WorkENT)
{
try
{
objvcc_WorkENT.IdWork = objvcc_WorkENS.IdWork; //作业流水号
objvcc_WorkENT.WorkIndex = objvcc_WorkENS.WorkIndex; //作业序号
objvcc_WorkENT.WorkName = objvcc_WorkENS.WorkName; //作业名称
objvcc_WorkENT.WorkDesc = objvcc_WorkENS.WorkDesc; //作业说明
objvcc_WorkENT.CourseId = objvcc_WorkENS.CourseId; //课程Id
objvcc_WorkENT.CourseName = objvcc_WorkENS.CourseName; //课程名称
objvcc_WorkENT.CourseChapterId = objvcc_WorkENS.CourseChapterId; //课程章节ID
objvcc_WorkENT.CourseChapterName = objvcc_WorkENS.CourseChapterName; //课程章节名称
objvcc_WorkENT.ChapterName = objvcc_WorkENS.ChapterName; //章名
objvcc_WorkENT.SectionName = objvcc_WorkENS.SectionName; //节名
objvcc_WorkENT.ChapterNameSim = objvcc_WorkENS.ChapterNameSim; //章名简称
objvcc_WorkENT.SectionNameSim = objvcc_WorkENS.SectionNameSim; //节名简称
objvcc_WorkENT.ParentNodeID = objvcc_WorkENS.ParentNodeID; //父节点编号
objvcc_WorkENT.CourseChapterReferred = objvcc_WorkENS.CourseChapterReferred; //节简称
objvcc_WorkENT.ParentNodeName = objvcc_WorkENS.ParentNodeName; //父节点名称
objvcc_WorkENT.ParentNodeReferred = objvcc_WorkENS.ParentNodeReferred; //章简称
objvcc_WorkENT.Creator = objvcc_WorkENS.Creator; //创建者
objvcc_WorkENT.CreateDate = objvcc_WorkENS.CreateDate; //建立日期
objvcc_WorkENT.AnswerAttLimitSize = objvcc_WorkENS.AnswerAttLimitSize; //回答附件限制大小
objvcc_WorkENT.LimitedResourceType = objvcc_WorkENS.LimitedResourceType; //限制资源类型
objvcc_WorkENT.UpdDate = objvcc_WorkENS.UpdDate; //修改日期
objvcc_WorkENT.UpdUserId = objvcc_WorkENS.UpdUserId; //修改用户Id
objvcc_WorkENT.Memo = objvcc_WorkENS.Memo; //备注
objvcc_WorkENT.CourseId4Chapter = objvcc_WorkENS.CourseId4Chapter; //CourseId4Chapter
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
 /// <param name = "objvcc_WorkENS">源对象</param>
 /// <returns>目标对象=>clsvcc_WorkEN:objvcc_WorkENT</returns>
 public static clsvcc_WorkEN CopyTo(this clsvcc_WorkEN objvcc_WorkENS)
{
try
{
 clsvcc_WorkEN objvcc_WorkENT = new clsvcc_WorkEN()
{
IdWork = objvcc_WorkENS.IdWork, //作业流水号
WorkIndex = objvcc_WorkENS.WorkIndex, //作业序号
WorkName = objvcc_WorkENS.WorkName, //作业名称
WorkDesc = objvcc_WorkENS.WorkDesc, //作业说明
CourseId = objvcc_WorkENS.CourseId, //课程Id
CourseName = objvcc_WorkENS.CourseName, //课程名称
CourseChapterId = objvcc_WorkENS.CourseChapterId, //课程章节ID
CourseChapterName = objvcc_WorkENS.CourseChapterName, //课程章节名称
ChapterName = objvcc_WorkENS.ChapterName, //章名
SectionName = objvcc_WorkENS.SectionName, //节名
ChapterNameSim = objvcc_WorkENS.ChapterNameSim, //章名简称
SectionNameSim = objvcc_WorkENS.SectionNameSim, //节名简称
ParentNodeID = objvcc_WorkENS.ParentNodeID, //父节点编号
CourseChapterReferred = objvcc_WorkENS.CourseChapterReferred, //节简称
ParentNodeName = objvcc_WorkENS.ParentNodeName, //父节点名称
ParentNodeReferred = objvcc_WorkENS.ParentNodeReferred, //章简称
Creator = objvcc_WorkENS.Creator, //创建者
CreateDate = objvcc_WorkENS.CreateDate, //建立日期
AnswerAttLimitSize = objvcc_WorkENS.AnswerAttLimitSize, //回答附件限制大小
LimitedResourceType = objvcc_WorkENS.LimitedResourceType, //限制资源类型
UpdDate = objvcc_WorkENS.UpdDate, //修改日期
UpdUserId = objvcc_WorkENS.UpdUserId, //修改用户Id
Memo = objvcc_WorkENS.Memo, //备注
CourseId4Chapter = objvcc_WorkENS.CourseId4Chapter, //CourseId4Chapter
};
 return objvcc_WorkENT;
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
public static void CheckProperty4Condition(this clsvcc_WorkEN objvcc_WorkEN)
{
 clsvcc_WorkBL.vcc_WorkDA.CheckProperty4Condition(objvcc_WorkEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_WorkEN objvcc_WorkCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_WorkCond.IsUpdated(convcc_Work.IdWork) == true)
{
string strComparisonOpIdWork = objvcc_WorkCond.dicFldComparisonOp[convcc_Work.IdWork];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.IdWork, objvcc_WorkCond.IdWork, strComparisonOpIdWork);
}
if (objvcc_WorkCond.IsUpdated(convcc_Work.WorkIndex) == true)
{
string strComparisonOpWorkIndex = objvcc_WorkCond.dicFldComparisonOp[convcc_Work.WorkIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_Work.WorkIndex, objvcc_WorkCond.WorkIndex, strComparisonOpWorkIndex);
}
if (objvcc_WorkCond.IsUpdated(convcc_Work.WorkName) == true)
{
string strComparisonOpWorkName = objvcc_WorkCond.dicFldComparisonOp[convcc_Work.WorkName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.WorkName, objvcc_WorkCond.WorkName, strComparisonOpWorkName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvcc_WorkCond.IsUpdated(convcc_Work.CourseId) == true)
{
string strComparisonOpCourseId = objvcc_WorkCond.dicFldComparisonOp[convcc_Work.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.CourseId, objvcc_WorkCond.CourseId, strComparisonOpCourseId);
}
if (objvcc_WorkCond.IsUpdated(convcc_Work.CourseName) == true)
{
string strComparisonOpCourseName = objvcc_WorkCond.dicFldComparisonOp[convcc_Work.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.CourseName, objvcc_WorkCond.CourseName, strComparisonOpCourseName);
}
if (objvcc_WorkCond.IsUpdated(convcc_Work.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvcc_WorkCond.dicFldComparisonOp[convcc_Work.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.CourseChapterId, objvcc_WorkCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvcc_WorkCond.IsUpdated(convcc_Work.CourseChapterName) == true)
{
string strComparisonOpCourseChapterName = objvcc_WorkCond.dicFldComparisonOp[convcc_Work.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.CourseChapterName, objvcc_WorkCond.CourseChapterName, strComparisonOpCourseChapterName);
}
if (objvcc_WorkCond.IsUpdated(convcc_Work.ChapterName) == true)
{
string strComparisonOpChapterName = objvcc_WorkCond.dicFldComparisonOp[convcc_Work.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.ChapterName, objvcc_WorkCond.ChapterName, strComparisonOpChapterName);
}
if (objvcc_WorkCond.IsUpdated(convcc_Work.SectionName) == true)
{
string strComparisonOpSectionName = objvcc_WorkCond.dicFldComparisonOp[convcc_Work.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.SectionName, objvcc_WorkCond.SectionName, strComparisonOpSectionName);
}
if (objvcc_WorkCond.IsUpdated(convcc_Work.ChapterNameSim) == true)
{
string strComparisonOpChapterNameSim = objvcc_WorkCond.dicFldComparisonOp[convcc_Work.ChapterNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.ChapterNameSim, objvcc_WorkCond.ChapterNameSim, strComparisonOpChapterNameSim);
}
if (objvcc_WorkCond.IsUpdated(convcc_Work.SectionNameSim) == true)
{
string strComparisonOpSectionNameSim = objvcc_WorkCond.dicFldComparisonOp[convcc_Work.SectionNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.SectionNameSim, objvcc_WorkCond.SectionNameSim, strComparisonOpSectionNameSim);
}
if (objvcc_WorkCond.IsUpdated(convcc_Work.ParentNodeID) == true)
{
string strComparisonOpParentNodeID = objvcc_WorkCond.dicFldComparisonOp[convcc_Work.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.ParentNodeID, objvcc_WorkCond.ParentNodeID, strComparisonOpParentNodeID);
}
if (objvcc_WorkCond.IsUpdated(convcc_Work.CourseChapterReferred) == true)
{
string strComparisonOpCourseChapterReferred = objvcc_WorkCond.dicFldComparisonOp[convcc_Work.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.CourseChapterReferred, objvcc_WorkCond.CourseChapterReferred, strComparisonOpCourseChapterReferred);
}
if (objvcc_WorkCond.IsUpdated(convcc_Work.ParentNodeName) == true)
{
string strComparisonOpParentNodeName = objvcc_WorkCond.dicFldComparisonOp[convcc_Work.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.ParentNodeName, objvcc_WorkCond.ParentNodeName, strComparisonOpParentNodeName);
}
if (objvcc_WorkCond.IsUpdated(convcc_Work.ParentNodeReferred) == true)
{
string strComparisonOpParentNodeReferred = objvcc_WorkCond.dicFldComparisonOp[convcc_Work.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.ParentNodeReferred, objvcc_WorkCond.ParentNodeReferred, strComparisonOpParentNodeReferred);
}
if (objvcc_WorkCond.IsUpdated(convcc_Work.Creator) == true)
{
string strComparisonOpCreator = objvcc_WorkCond.dicFldComparisonOp[convcc_Work.Creator];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.Creator, objvcc_WorkCond.Creator, strComparisonOpCreator);
}
if (objvcc_WorkCond.IsUpdated(convcc_Work.CreateDate) == true)
{
string strComparisonOpCreateDate = objvcc_WorkCond.dicFldComparisonOp[convcc_Work.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.CreateDate, objvcc_WorkCond.CreateDate, strComparisonOpCreateDate);
}
if (objvcc_WorkCond.IsUpdated(convcc_Work.AnswerAttLimitSize) == true)
{
string strComparisonOpAnswerAttLimitSize = objvcc_WorkCond.dicFldComparisonOp[convcc_Work.AnswerAttLimitSize];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_Work.AnswerAttLimitSize, objvcc_WorkCond.AnswerAttLimitSize, strComparisonOpAnswerAttLimitSize);
}
if (objvcc_WorkCond.IsUpdated(convcc_Work.LimitedResourceType) == true)
{
string strComparisonOpLimitedResourceType = objvcc_WorkCond.dicFldComparisonOp[convcc_Work.LimitedResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.LimitedResourceType, objvcc_WorkCond.LimitedResourceType, strComparisonOpLimitedResourceType);
}
if (objvcc_WorkCond.IsUpdated(convcc_Work.UpdDate) == true)
{
string strComparisonOpUpdDate = objvcc_WorkCond.dicFldComparisonOp[convcc_Work.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.UpdDate, objvcc_WorkCond.UpdDate, strComparisonOpUpdDate);
}
if (objvcc_WorkCond.IsUpdated(convcc_Work.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvcc_WorkCond.dicFldComparisonOp[convcc_Work.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.UpdUserId, objvcc_WorkCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvcc_WorkCond.IsUpdated(convcc_Work.Memo) == true)
{
string strComparisonOpMemo = objvcc_WorkCond.dicFldComparisonOp[convcc_Work.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.Memo, objvcc_WorkCond.Memo, strComparisonOpMemo);
}
if (objvcc_WorkCond.IsUpdated(convcc_Work.CourseId4Chapter) == true)
{
string strComparisonOpCourseId4Chapter = objvcc_WorkCond.dicFldComparisonOp[convcc_Work.CourseId4Chapter];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.CourseId4Chapter, objvcc_WorkCond.CourseId4Chapter, strComparisonOpCourseId4Chapter);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcc_Work
{
public virtual bool UpdRelaTabDate(string strIdWork, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 作业(vcc_Work)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcc_WorkBL
{
public static RelatedActions_vcc_Work relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcc_WorkDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcc_WorkDA vcc_WorkDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcc_WorkDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcc_WorkBL()
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
if (string.IsNullOrEmpty(clsvcc_WorkEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_WorkEN._ConnectString);
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
public static DataTable GetDataTable_vcc_Work(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcc_WorkDA.GetDataTable_vcc_Work(strWhereCond);
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
objDT = vcc_WorkDA.GetDataTable(strWhereCond);
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
objDT = vcc_WorkDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcc_WorkDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcc_WorkDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcc_WorkDA.GetDataTable_Top(objTopPara);
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
objDT = vcc_WorkDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcc_WorkDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcc_WorkDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdWorkLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvcc_WorkEN> GetObjLstByIdWorkLst(List<string> arrIdWorkLst)
{
List<clsvcc_WorkEN> arrObjLst = new List<clsvcc_WorkEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdWorkLst, true);
 string strWhereCond = string.Format("IdWork in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkEN objvcc_WorkEN = new clsvcc_WorkEN();
try
{
objvcc_WorkEN.IdWork = objRow[convcc_Work.IdWork].ToString().Trim(); //作业流水号
objvcc_WorkEN.WorkIndex = objRow[convcc_Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Work.WorkIndex].ToString().Trim()); //作业序号
objvcc_WorkEN.WorkName = objRow[convcc_Work.WorkName].ToString().Trim(); //作业名称
objvcc_WorkEN.WorkDesc = objRow[convcc_Work.WorkDesc] == DBNull.Value ? null : objRow[convcc_Work.WorkDesc].ToString().Trim(); //作业说明
objvcc_WorkEN.CourseId = objRow[convcc_Work.CourseId] == DBNull.Value ? null : objRow[convcc_Work.CourseId].ToString().Trim(); //课程Id
objvcc_WorkEN.CourseName = objRow[convcc_Work.CourseName] == DBNull.Value ? null : objRow[convcc_Work.CourseName].ToString().Trim(); //课程名称
objvcc_WorkEN.CourseChapterId = objRow[convcc_Work.CourseChapterId] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkEN.CourseChapterName = objRow[convcc_Work.CourseChapterName] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkEN.ChapterName = objRow[convcc_Work.ChapterName] == DBNull.Value ? null : objRow[convcc_Work.ChapterName].ToString().Trim(); //章名
objvcc_WorkEN.SectionName = objRow[convcc_Work.SectionName] == DBNull.Value ? null : objRow[convcc_Work.SectionName].ToString().Trim(); //节名
objvcc_WorkEN.ChapterNameSim = objRow[convcc_Work.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_Work.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkEN.SectionNameSim = objRow[convcc_Work.SectionNameSim] == DBNull.Value ? null : objRow[convcc_Work.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkEN.ParentNodeID = objRow[convcc_Work.ParentNodeID] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkEN.CourseChapterReferred = objRow[convcc_Work.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkEN.ParentNodeName = objRow[convcc_Work.ParentNodeName] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkEN.ParentNodeReferred = objRow[convcc_Work.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkEN.Creator = objRow[convcc_Work.Creator] == DBNull.Value ? null : objRow[convcc_Work.Creator].ToString().Trim(); //创建者
objvcc_WorkEN.CreateDate = objRow[convcc_Work.CreateDate] == DBNull.Value ? null : objRow[convcc_Work.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkEN.AnswerAttLimitSize = objRow[convcc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkEN.LimitedResourceType = objRow[convcc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkEN.UpdDate = objRow[convcc_Work.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkEN.UpdUserId = objRow[convcc_Work.UpdUserId] == DBNull.Value ? null : objRow[convcc_Work.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkEN.Memo = objRow[convcc_Work.Memo] == DBNull.Value ? null : objRow[convcc_Work.Memo].ToString().Trim(); //备注
objvcc_WorkEN.CourseId4Chapter = objRow[convcc_Work.CourseId4Chapter] == DBNull.Value ? null : objRow[convcc_Work.CourseId4Chapter].ToString().Trim(); //CourseId4Chapter
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkEN.IdWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdWorkLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcc_WorkEN> GetObjLstByIdWorkLstCache(List<string> arrIdWorkLst)
{
string strKey = string.Format("{0}", clsvcc_WorkEN._CurrTabName);
List<clsvcc_WorkEN> arrvcc_WorkObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_WorkEN> arrvcc_WorkObjLst_Sel =
arrvcc_WorkObjLstCache
.Where(x => arrIdWorkLst.Contains(x.IdWork));
return arrvcc_WorkObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkEN> GetObjLst(string strWhereCond)
{
List<clsvcc_WorkEN> arrObjLst = new List<clsvcc_WorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkEN objvcc_WorkEN = new clsvcc_WorkEN();
try
{
objvcc_WorkEN.IdWork = objRow[convcc_Work.IdWork].ToString().Trim(); //作业流水号
objvcc_WorkEN.WorkIndex = objRow[convcc_Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Work.WorkIndex].ToString().Trim()); //作业序号
objvcc_WorkEN.WorkName = objRow[convcc_Work.WorkName].ToString().Trim(); //作业名称
objvcc_WorkEN.WorkDesc = objRow[convcc_Work.WorkDesc] == DBNull.Value ? null : objRow[convcc_Work.WorkDesc].ToString().Trim(); //作业说明
objvcc_WorkEN.CourseId = objRow[convcc_Work.CourseId] == DBNull.Value ? null : objRow[convcc_Work.CourseId].ToString().Trim(); //课程Id
objvcc_WorkEN.CourseName = objRow[convcc_Work.CourseName] == DBNull.Value ? null : objRow[convcc_Work.CourseName].ToString().Trim(); //课程名称
objvcc_WorkEN.CourseChapterId = objRow[convcc_Work.CourseChapterId] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkEN.CourseChapterName = objRow[convcc_Work.CourseChapterName] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkEN.ChapterName = objRow[convcc_Work.ChapterName] == DBNull.Value ? null : objRow[convcc_Work.ChapterName].ToString().Trim(); //章名
objvcc_WorkEN.SectionName = objRow[convcc_Work.SectionName] == DBNull.Value ? null : objRow[convcc_Work.SectionName].ToString().Trim(); //节名
objvcc_WorkEN.ChapterNameSim = objRow[convcc_Work.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_Work.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkEN.SectionNameSim = objRow[convcc_Work.SectionNameSim] == DBNull.Value ? null : objRow[convcc_Work.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkEN.ParentNodeID = objRow[convcc_Work.ParentNodeID] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkEN.CourseChapterReferred = objRow[convcc_Work.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkEN.ParentNodeName = objRow[convcc_Work.ParentNodeName] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkEN.ParentNodeReferred = objRow[convcc_Work.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkEN.Creator = objRow[convcc_Work.Creator] == DBNull.Value ? null : objRow[convcc_Work.Creator].ToString().Trim(); //创建者
objvcc_WorkEN.CreateDate = objRow[convcc_Work.CreateDate] == DBNull.Value ? null : objRow[convcc_Work.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkEN.AnswerAttLimitSize = objRow[convcc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkEN.LimitedResourceType = objRow[convcc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkEN.UpdDate = objRow[convcc_Work.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkEN.UpdUserId = objRow[convcc_Work.UpdUserId] == DBNull.Value ? null : objRow[convcc_Work.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkEN.Memo = objRow[convcc_Work.Memo] == DBNull.Value ? null : objRow[convcc_Work.Memo].ToString().Trim(); //备注
objvcc_WorkEN.CourseId4Chapter = objRow[convcc_Work.CourseId4Chapter] == DBNull.Value ? null : objRow[convcc_Work.CourseId4Chapter].ToString().Trim(); //CourseId4Chapter
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkEN.IdWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkEN);
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
public static List<clsvcc_WorkEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcc_WorkEN> arrObjLst = new List<clsvcc_WorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkEN objvcc_WorkEN = new clsvcc_WorkEN();
try
{
objvcc_WorkEN.IdWork = objRow[convcc_Work.IdWork].ToString().Trim(); //作业流水号
objvcc_WorkEN.WorkIndex = objRow[convcc_Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Work.WorkIndex].ToString().Trim()); //作业序号
objvcc_WorkEN.WorkName = objRow[convcc_Work.WorkName].ToString().Trim(); //作业名称
objvcc_WorkEN.WorkDesc = objRow[convcc_Work.WorkDesc] == DBNull.Value ? null : objRow[convcc_Work.WorkDesc].ToString().Trim(); //作业说明
objvcc_WorkEN.CourseId = objRow[convcc_Work.CourseId] == DBNull.Value ? null : objRow[convcc_Work.CourseId].ToString().Trim(); //课程Id
objvcc_WorkEN.CourseName = objRow[convcc_Work.CourseName] == DBNull.Value ? null : objRow[convcc_Work.CourseName].ToString().Trim(); //课程名称
objvcc_WorkEN.CourseChapterId = objRow[convcc_Work.CourseChapterId] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkEN.CourseChapterName = objRow[convcc_Work.CourseChapterName] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkEN.ChapterName = objRow[convcc_Work.ChapterName] == DBNull.Value ? null : objRow[convcc_Work.ChapterName].ToString().Trim(); //章名
objvcc_WorkEN.SectionName = objRow[convcc_Work.SectionName] == DBNull.Value ? null : objRow[convcc_Work.SectionName].ToString().Trim(); //节名
objvcc_WorkEN.ChapterNameSim = objRow[convcc_Work.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_Work.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkEN.SectionNameSim = objRow[convcc_Work.SectionNameSim] == DBNull.Value ? null : objRow[convcc_Work.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkEN.ParentNodeID = objRow[convcc_Work.ParentNodeID] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkEN.CourseChapterReferred = objRow[convcc_Work.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkEN.ParentNodeName = objRow[convcc_Work.ParentNodeName] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkEN.ParentNodeReferred = objRow[convcc_Work.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkEN.Creator = objRow[convcc_Work.Creator] == DBNull.Value ? null : objRow[convcc_Work.Creator].ToString().Trim(); //创建者
objvcc_WorkEN.CreateDate = objRow[convcc_Work.CreateDate] == DBNull.Value ? null : objRow[convcc_Work.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkEN.AnswerAttLimitSize = objRow[convcc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkEN.LimitedResourceType = objRow[convcc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkEN.UpdDate = objRow[convcc_Work.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkEN.UpdUserId = objRow[convcc_Work.UpdUserId] == DBNull.Value ? null : objRow[convcc_Work.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkEN.Memo = objRow[convcc_Work.Memo] == DBNull.Value ? null : objRow[convcc_Work.Memo].ToString().Trim(); //备注
objvcc_WorkEN.CourseId4Chapter = objRow[convcc_Work.CourseId4Chapter] == DBNull.Value ? null : objRow[convcc_Work.CourseId4Chapter].ToString().Trim(); //CourseId4Chapter
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkEN.IdWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcc_WorkCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcc_WorkEN> GetSubObjLstCache(clsvcc_WorkEN objvcc_WorkCond)
{
List<clsvcc_WorkEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_WorkEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_Work.AttributeName)
{
if (objvcc_WorkCond.IsUpdated(strFldName) == false) continue;
if (objvcc_WorkCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkCond[strFldName].ToString());
}
else
{
if (objvcc_WorkCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_WorkCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_WorkCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_WorkCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_WorkCond[strFldName]));
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
public static List<clsvcc_WorkEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcc_WorkEN> arrObjLst = new List<clsvcc_WorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkEN objvcc_WorkEN = new clsvcc_WorkEN();
try
{
objvcc_WorkEN.IdWork = objRow[convcc_Work.IdWork].ToString().Trim(); //作业流水号
objvcc_WorkEN.WorkIndex = objRow[convcc_Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Work.WorkIndex].ToString().Trim()); //作业序号
objvcc_WorkEN.WorkName = objRow[convcc_Work.WorkName].ToString().Trim(); //作业名称
objvcc_WorkEN.WorkDesc = objRow[convcc_Work.WorkDesc] == DBNull.Value ? null : objRow[convcc_Work.WorkDesc].ToString().Trim(); //作业说明
objvcc_WorkEN.CourseId = objRow[convcc_Work.CourseId] == DBNull.Value ? null : objRow[convcc_Work.CourseId].ToString().Trim(); //课程Id
objvcc_WorkEN.CourseName = objRow[convcc_Work.CourseName] == DBNull.Value ? null : objRow[convcc_Work.CourseName].ToString().Trim(); //课程名称
objvcc_WorkEN.CourseChapterId = objRow[convcc_Work.CourseChapterId] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkEN.CourseChapterName = objRow[convcc_Work.CourseChapterName] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkEN.ChapterName = objRow[convcc_Work.ChapterName] == DBNull.Value ? null : objRow[convcc_Work.ChapterName].ToString().Trim(); //章名
objvcc_WorkEN.SectionName = objRow[convcc_Work.SectionName] == DBNull.Value ? null : objRow[convcc_Work.SectionName].ToString().Trim(); //节名
objvcc_WorkEN.ChapterNameSim = objRow[convcc_Work.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_Work.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkEN.SectionNameSim = objRow[convcc_Work.SectionNameSim] == DBNull.Value ? null : objRow[convcc_Work.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkEN.ParentNodeID = objRow[convcc_Work.ParentNodeID] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkEN.CourseChapterReferred = objRow[convcc_Work.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkEN.ParentNodeName = objRow[convcc_Work.ParentNodeName] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkEN.ParentNodeReferred = objRow[convcc_Work.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkEN.Creator = objRow[convcc_Work.Creator] == DBNull.Value ? null : objRow[convcc_Work.Creator].ToString().Trim(); //创建者
objvcc_WorkEN.CreateDate = objRow[convcc_Work.CreateDate] == DBNull.Value ? null : objRow[convcc_Work.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkEN.AnswerAttLimitSize = objRow[convcc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkEN.LimitedResourceType = objRow[convcc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkEN.UpdDate = objRow[convcc_Work.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkEN.UpdUserId = objRow[convcc_Work.UpdUserId] == DBNull.Value ? null : objRow[convcc_Work.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkEN.Memo = objRow[convcc_Work.Memo] == DBNull.Value ? null : objRow[convcc_Work.Memo].ToString().Trim(); //备注
objvcc_WorkEN.CourseId4Chapter = objRow[convcc_Work.CourseId4Chapter] == DBNull.Value ? null : objRow[convcc_Work.CourseId4Chapter].ToString().Trim(); //CourseId4Chapter
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkEN.IdWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkEN);
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
public static List<clsvcc_WorkEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcc_WorkEN> arrObjLst = new List<clsvcc_WorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkEN objvcc_WorkEN = new clsvcc_WorkEN();
try
{
objvcc_WorkEN.IdWork = objRow[convcc_Work.IdWork].ToString().Trim(); //作业流水号
objvcc_WorkEN.WorkIndex = objRow[convcc_Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Work.WorkIndex].ToString().Trim()); //作业序号
objvcc_WorkEN.WorkName = objRow[convcc_Work.WorkName].ToString().Trim(); //作业名称
objvcc_WorkEN.WorkDesc = objRow[convcc_Work.WorkDesc] == DBNull.Value ? null : objRow[convcc_Work.WorkDesc].ToString().Trim(); //作业说明
objvcc_WorkEN.CourseId = objRow[convcc_Work.CourseId] == DBNull.Value ? null : objRow[convcc_Work.CourseId].ToString().Trim(); //课程Id
objvcc_WorkEN.CourseName = objRow[convcc_Work.CourseName] == DBNull.Value ? null : objRow[convcc_Work.CourseName].ToString().Trim(); //课程名称
objvcc_WorkEN.CourseChapterId = objRow[convcc_Work.CourseChapterId] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkEN.CourseChapterName = objRow[convcc_Work.CourseChapterName] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkEN.ChapterName = objRow[convcc_Work.ChapterName] == DBNull.Value ? null : objRow[convcc_Work.ChapterName].ToString().Trim(); //章名
objvcc_WorkEN.SectionName = objRow[convcc_Work.SectionName] == DBNull.Value ? null : objRow[convcc_Work.SectionName].ToString().Trim(); //节名
objvcc_WorkEN.ChapterNameSim = objRow[convcc_Work.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_Work.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkEN.SectionNameSim = objRow[convcc_Work.SectionNameSim] == DBNull.Value ? null : objRow[convcc_Work.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkEN.ParentNodeID = objRow[convcc_Work.ParentNodeID] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkEN.CourseChapterReferred = objRow[convcc_Work.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkEN.ParentNodeName = objRow[convcc_Work.ParentNodeName] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkEN.ParentNodeReferred = objRow[convcc_Work.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkEN.Creator = objRow[convcc_Work.Creator] == DBNull.Value ? null : objRow[convcc_Work.Creator].ToString().Trim(); //创建者
objvcc_WorkEN.CreateDate = objRow[convcc_Work.CreateDate] == DBNull.Value ? null : objRow[convcc_Work.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkEN.AnswerAttLimitSize = objRow[convcc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkEN.LimitedResourceType = objRow[convcc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkEN.UpdDate = objRow[convcc_Work.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkEN.UpdUserId = objRow[convcc_Work.UpdUserId] == DBNull.Value ? null : objRow[convcc_Work.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkEN.Memo = objRow[convcc_Work.Memo] == DBNull.Value ? null : objRow[convcc_Work.Memo].ToString().Trim(); //备注
objvcc_WorkEN.CourseId4Chapter = objRow[convcc_Work.CourseId4Chapter] == DBNull.Value ? null : objRow[convcc_Work.CourseId4Chapter].ToString().Trim(); //CourseId4Chapter
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkEN.IdWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkEN);
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
List<clsvcc_WorkEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcc_WorkEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcc_WorkEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_WorkEN> arrObjLst = new List<clsvcc_WorkEN>(); 
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
	clsvcc_WorkEN objvcc_WorkEN = new clsvcc_WorkEN();
try
{
objvcc_WorkEN.IdWork = objRow[convcc_Work.IdWork].ToString().Trim(); //作业流水号
objvcc_WorkEN.WorkIndex = objRow[convcc_Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Work.WorkIndex].ToString().Trim()); //作业序号
objvcc_WorkEN.WorkName = objRow[convcc_Work.WorkName].ToString().Trim(); //作业名称
objvcc_WorkEN.WorkDesc = objRow[convcc_Work.WorkDesc] == DBNull.Value ? null : objRow[convcc_Work.WorkDesc].ToString().Trim(); //作业说明
objvcc_WorkEN.CourseId = objRow[convcc_Work.CourseId] == DBNull.Value ? null : objRow[convcc_Work.CourseId].ToString().Trim(); //课程Id
objvcc_WorkEN.CourseName = objRow[convcc_Work.CourseName] == DBNull.Value ? null : objRow[convcc_Work.CourseName].ToString().Trim(); //课程名称
objvcc_WorkEN.CourseChapterId = objRow[convcc_Work.CourseChapterId] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkEN.CourseChapterName = objRow[convcc_Work.CourseChapterName] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkEN.ChapterName = objRow[convcc_Work.ChapterName] == DBNull.Value ? null : objRow[convcc_Work.ChapterName].ToString().Trim(); //章名
objvcc_WorkEN.SectionName = objRow[convcc_Work.SectionName] == DBNull.Value ? null : objRow[convcc_Work.SectionName].ToString().Trim(); //节名
objvcc_WorkEN.ChapterNameSim = objRow[convcc_Work.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_Work.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkEN.SectionNameSim = objRow[convcc_Work.SectionNameSim] == DBNull.Value ? null : objRow[convcc_Work.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkEN.ParentNodeID = objRow[convcc_Work.ParentNodeID] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkEN.CourseChapterReferred = objRow[convcc_Work.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkEN.ParentNodeName = objRow[convcc_Work.ParentNodeName] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkEN.ParentNodeReferred = objRow[convcc_Work.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkEN.Creator = objRow[convcc_Work.Creator] == DBNull.Value ? null : objRow[convcc_Work.Creator].ToString().Trim(); //创建者
objvcc_WorkEN.CreateDate = objRow[convcc_Work.CreateDate] == DBNull.Value ? null : objRow[convcc_Work.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkEN.AnswerAttLimitSize = objRow[convcc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkEN.LimitedResourceType = objRow[convcc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkEN.UpdDate = objRow[convcc_Work.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkEN.UpdUserId = objRow[convcc_Work.UpdUserId] == DBNull.Value ? null : objRow[convcc_Work.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkEN.Memo = objRow[convcc_Work.Memo] == DBNull.Value ? null : objRow[convcc_Work.Memo].ToString().Trim(); //备注
objvcc_WorkEN.CourseId4Chapter = objRow[convcc_Work.CourseId4Chapter] == DBNull.Value ? null : objRow[convcc_Work.CourseId4Chapter].ToString().Trim(); //CourseId4Chapter
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkEN.IdWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkEN);
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
public static List<clsvcc_WorkEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcc_WorkEN> arrObjLst = new List<clsvcc_WorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkEN objvcc_WorkEN = new clsvcc_WorkEN();
try
{
objvcc_WorkEN.IdWork = objRow[convcc_Work.IdWork].ToString().Trim(); //作业流水号
objvcc_WorkEN.WorkIndex = objRow[convcc_Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Work.WorkIndex].ToString().Trim()); //作业序号
objvcc_WorkEN.WorkName = objRow[convcc_Work.WorkName].ToString().Trim(); //作业名称
objvcc_WorkEN.WorkDesc = objRow[convcc_Work.WorkDesc] == DBNull.Value ? null : objRow[convcc_Work.WorkDesc].ToString().Trim(); //作业说明
objvcc_WorkEN.CourseId = objRow[convcc_Work.CourseId] == DBNull.Value ? null : objRow[convcc_Work.CourseId].ToString().Trim(); //课程Id
objvcc_WorkEN.CourseName = objRow[convcc_Work.CourseName] == DBNull.Value ? null : objRow[convcc_Work.CourseName].ToString().Trim(); //课程名称
objvcc_WorkEN.CourseChapterId = objRow[convcc_Work.CourseChapterId] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkEN.CourseChapterName = objRow[convcc_Work.CourseChapterName] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkEN.ChapterName = objRow[convcc_Work.ChapterName] == DBNull.Value ? null : objRow[convcc_Work.ChapterName].ToString().Trim(); //章名
objvcc_WorkEN.SectionName = objRow[convcc_Work.SectionName] == DBNull.Value ? null : objRow[convcc_Work.SectionName].ToString().Trim(); //节名
objvcc_WorkEN.ChapterNameSim = objRow[convcc_Work.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_Work.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkEN.SectionNameSim = objRow[convcc_Work.SectionNameSim] == DBNull.Value ? null : objRow[convcc_Work.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkEN.ParentNodeID = objRow[convcc_Work.ParentNodeID] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkEN.CourseChapterReferred = objRow[convcc_Work.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkEN.ParentNodeName = objRow[convcc_Work.ParentNodeName] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkEN.ParentNodeReferred = objRow[convcc_Work.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkEN.Creator = objRow[convcc_Work.Creator] == DBNull.Value ? null : objRow[convcc_Work.Creator].ToString().Trim(); //创建者
objvcc_WorkEN.CreateDate = objRow[convcc_Work.CreateDate] == DBNull.Value ? null : objRow[convcc_Work.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkEN.AnswerAttLimitSize = objRow[convcc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkEN.LimitedResourceType = objRow[convcc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkEN.UpdDate = objRow[convcc_Work.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkEN.UpdUserId = objRow[convcc_Work.UpdUserId] == DBNull.Value ? null : objRow[convcc_Work.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkEN.Memo = objRow[convcc_Work.Memo] == DBNull.Value ? null : objRow[convcc_Work.Memo].ToString().Trim(); //备注
objvcc_WorkEN.CourseId4Chapter = objRow[convcc_Work.CourseId4Chapter] == DBNull.Value ? null : objRow[convcc_Work.CourseId4Chapter].ToString().Trim(); //CourseId4Chapter
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkEN.IdWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcc_WorkEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcc_WorkEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_WorkEN> arrObjLst = new List<clsvcc_WorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkEN objvcc_WorkEN = new clsvcc_WorkEN();
try
{
objvcc_WorkEN.IdWork = objRow[convcc_Work.IdWork].ToString().Trim(); //作业流水号
objvcc_WorkEN.WorkIndex = objRow[convcc_Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Work.WorkIndex].ToString().Trim()); //作业序号
objvcc_WorkEN.WorkName = objRow[convcc_Work.WorkName].ToString().Trim(); //作业名称
objvcc_WorkEN.WorkDesc = objRow[convcc_Work.WorkDesc] == DBNull.Value ? null : objRow[convcc_Work.WorkDesc].ToString().Trim(); //作业说明
objvcc_WorkEN.CourseId = objRow[convcc_Work.CourseId] == DBNull.Value ? null : objRow[convcc_Work.CourseId].ToString().Trim(); //课程Id
objvcc_WorkEN.CourseName = objRow[convcc_Work.CourseName] == DBNull.Value ? null : objRow[convcc_Work.CourseName].ToString().Trim(); //课程名称
objvcc_WorkEN.CourseChapterId = objRow[convcc_Work.CourseChapterId] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkEN.CourseChapterName = objRow[convcc_Work.CourseChapterName] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkEN.ChapterName = objRow[convcc_Work.ChapterName] == DBNull.Value ? null : objRow[convcc_Work.ChapterName].ToString().Trim(); //章名
objvcc_WorkEN.SectionName = objRow[convcc_Work.SectionName] == DBNull.Value ? null : objRow[convcc_Work.SectionName].ToString().Trim(); //节名
objvcc_WorkEN.ChapterNameSim = objRow[convcc_Work.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_Work.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkEN.SectionNameSim = objRow[convcc_Work.SectionNameSim] == DBNull.Value ? null : objRow[convcc_Work.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkEN.ParentNodeID = objRow[convcc_Work.ParentNodeID] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkEN.CourseChapterReferred = objRow[convcc_Work.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkEN.ParentNodeName = objRow[convcc_Work.ParentNodeName] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkEN.ParentNodeReferred = objRow[convcc_Work.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkEN.Creator = objRow[convcc_Work.Creator] == DBNull.Value ? null : objRow[convcc_Work.Creator].ToString().Trim(); //创建者
objvcc_WorkEN.CreateDate = objRow[convcc_Work.CreateDate] == DBNull.Value ? null : objRow[convcc_Work.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkEN.AnswerAttLimitSize = objRow[convcc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkEN.LimitedResourceType = objRow[convcc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkEN.UpdDate = objRow[convcc_Work.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkEN.UpdUserId = objRow[convcc_Work.UpdUserId] == DBNull.Value ? null : objRow[convcc_Work.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkEN.Memo = objRow[convcc_Work.Memo] == DBNull.Value ? null : objRow[convcc_Work.Memo].ToString().Trim(); //备注
objvcc_WorkEN.CourseId4Chapter = objRow[convcc_Work.CourseId4Chapter] == DBNull.Value ? null : objRow[convcc_Work.CourseId4Chapter].ToString().Trim(); //CourseId4Chapter
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkEN.IdWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkEN);
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
public static List<clsvcc_WorkEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcc_WorkEN> arrObjLst = new List<clsvcc_WorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkEN objvcc_WorkEN = new clsvcc_WorkEN();
try
{
objvcc_WorkEN.IdWork = objRow[convcc_Work.IdWork].ToString().Trim(); //作业流水号
objvcc_WorkEN.WorkIndex = objRow[convcc_Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Work.WorkIndex].ToString().Trim()); //作业序号
objvcc_WorkEN.WorkName = objRow[convcc_Work.WorkName].ToString().Trim(); //作业名称
objvcc_WorkEN.WorkDesc = objRow[convcc_Work.WorkDesc] == DBNull.Value ? null : objRow[convcc_Work.WorkDesc].ToString().Trim(); //作业说明
objvcc_WorkEN.CourseId = objRow[convcc_Work.CourseId] == DBNull.Value ? null : objRow[convcc_Work.CourseId].ToString().Trim(); //课程Id
objvcc_WorkEN.CourseName = objRow[convcc_Work.CourseName] == DBNull.Value ? null : objRow[convcc_Work.CourseName].ToString().Trim(); //课程名称
objvcc_WorkEN.CourseChapterId = objRow[convcc_Work.CourseChapterId] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkEN.CourseChapterName = objRow[convcc_Work.CourseChapterName] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkEN.ChapterName = objRow[convcc_Work.ChapterName] == DBNull.Value ? null : objRow[convcc_Work.ChapterName].ToString().Trim(); //章名
objvcc_WorkEN.SectionName = objRow[convcc_Work.SectionName] == DBNull.Value ? null : objRow[convcc_Work.SectionName].ToString().Trim(); //节名
objvcc_WorkEN.ChapterNameSim = objRow[convcc_Work.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_Work.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkEN.SectionNameSim = objRow[convcc_Work.SectionNameSim] == DBNull.Value ? null : objRow[convcc_Work.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkEN.ParentNodeID = objRow[convcc_Work.ParentNodeID] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkEN.CourseChapterReferred = objRow[convcc_Work.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkEN.ParentNodeName = objRow[convcc_Work.ParentNodeName] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkEN.ParentNodeReferred = objRow[convcc_Work.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkEN.Creator = objRow[convcc_Work.Creator] == DBNull.Value ? null : objRow[convcc_Work.Creator].ToString().Trim(); //创建者
objvcc_WorkEN.CreateDate = objRow[convcc_Work.CreateDate] == DBNull.Value ? null : objRow[convcc_Work.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkEN.AnswerAttLimitSize = objRow[convcc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkEN.LimitedResourceType = objRow[convcc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkEN.UpdDate = objRow[convcc_Work.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkEN.UpdUserId = objRow[convcc_Work.UpdUserId] == DBNull.Value ? null : objRow[convcc_Work.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkEN.Memo = objRow[convcc_Work.Memo] == DBNull.Value ? null : objRow[convcc_Work.Memo].ToString().Trim(); //备注
objvcc_WorkEN.CourseId4Chapter = objRow[convcc_Work.CourseId4Chapter] == DBNull.Value ? null : objRow[convcc_Work.CourseId4Chapter].ToString().Trim(); //CourseId4Chapter
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkEN.IdWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcc_WorkEN> arrObjLst = new List<clsvcc_WorkEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkEN objvcc_WorkEN = new clsvcc_WorkEN();
try
{
objvcc_WorkEN.IdWork = objRow[convcc_Work.IdWork].ToString().Trim(); //作业流水号
objvcc_WorkEN.WorkIndex = objRow[convcc_Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Work.WorkIndex].ToString().Trim()); //作业序号
objvcc_WorkEN.WorkName = objRow[convcc_Work.WorkName].ToString().Trim(); //作业名称
objvcc_WorkEN.WorkDesc = objRow[convcc_Work.WorkDesc] == DBNull.Value ? null : objRow[convcc_Work.WorkDesc].ToString().Trim(); //作业说明
objvcc_WorkEN.CourseId = objRow[convcc_Work.CourseId] == DBNull.Value ? null : objRow[convcc_Work.CourseId].ToString().Trim(); //课程Id
objvcc_WorkEN.CourseName = objRow[convcc_Work.CourseName] == DBNull.Value ? null : objRow[convcc_Work.CourseName].ToString().Trim(); //课程名称
objvcc_WorkEN.CourseChapterId = objRow[convcc_Work.CourseChapterId] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkEN.CourseChapterName = objRow[convcc_Work.CourseChapterName] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkEN.ChapterName = objRow[convcc_Work.ChapterName] == DBNull.Value ? null : objRow[convcc_Work.ChapterName].ToString().Trim(); //章名
objvcc_WorkEN.SectionName = objRow[convcc_Work.SectionName] == DBNull.Value ? null : objRow[convcc_Work.SectionName].ToString().Trim(); //节名
objvcc_WorkEN.ChapterNameSim = objRow[convcc_Work.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_Work.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkEN.SectionNameSim = objRow[convcc_Work.SectionNameSim] == DBNull.Value ? null : objRow[convcc_Work.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkEN.ParentNodeID = objRow[convcc_Work.ParentNodeID] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkEN.CourseChapterReferred = objRow[convcc_Work.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkEN.ParentNodeName = objRow[convcc_Work.ParentNodeName] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkEN.ParentNodeReferred = objRow[convcc_Work.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkEN.Creator = objRow[convcc_Work.Creator] == DBNull.Value ? null : objRow[convcc_Work.Creator].ToString().Trim(); //创建者
objvcc_WorkEN.CreateDate = objRow[convcc_Work.CreateDate] == DBNull.Value ? null : objRow[convcc_Work.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkEN.AnswerAttLimitSize = objRow[convcc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkEN.LimitedResourceType = objRow[convcc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkEN.UpdDate = objRow[convcc_Work.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkEN.UpdUserId = objRow[convcc_Work.UpdUserId] == DBNull.Value ? null : objRow[convcc_Work.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkEN.Memo = objRow[convcc_Work.Memo] == DBNull.Value ? null : objRow[convcc_Work.Memo].ToString().Trim(); //备注
objvcc_WorkEN.CourseId4Chapter = objRow[convcc_Work.CourseId4Chapter] == DBNull.Value ? null : objRow[convcc_Work.CourseId4Chapter].ToString().Trim(); //CourseId4Chapter
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkEN.IdWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcc_WorkEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcc_Work(ref clsvcc_WorkEN objvcc_WorkEN)
{
bool bolResult = vcc_WorkDA.Getvcc_Work(ref objvcc_WorkEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdWork">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkEN GetObjByIdWork(string strIdWork)
{
if (strIdWork.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdWork]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdWork) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdWork]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvcc_WorkEN objvcc_WorkEN = vcc_WorkDA.GetObjByIdWork(strIdWork);
return objvcc_WorkEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcc_WorkEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcc_WorkEN objvcc_WorkEN = vcc_WorkDA.GetFirstObj(strWhereCond);
 return objvcc_WorkEN;
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
public static clsvcc_WorkEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcc_WorkEN objvcc_WorkEN = vcc_WorkDA.GetObjByDataRow(objRow);
 return objvcc_WorkEN;
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
public static clsvcc_WorkEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcc_WorkEN objvcc_WorkEN = vcc_WorkDA.GetObjByDataRow(objRow);
 return objvcc_WorkEN;
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
 /// <param name = "strIdWork">所给的关键字</param>
 /// <param name = "lstvcc_WorkObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_WorkEN GetObjByIdWorkFromList(string strIdWork, List<clsvcc_WorkEN> lstvcc_WorkObjLst)
{
foreach (clsvcc_WorkEN objvcc_WorkEN in lstvcc_WorkObjLst)
{
if (objvcc_WorkEN.IdWork == strIdWork)
{
return objvcc_WorkEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxIdWork;
 try
 {
 strMaxIdWork = clsvcc_WorkDA.GetMaxStrId();
 return strMaxIdWork;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strIdWork;
 try
 {
 strIdWork = new clsvcc_WorkDA().GetFirstID(strWhereCond);
 return strIdWork;
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
 arrList = vcc_WorkDA.GetID(strWhereCond);
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
bool bolIsExist = vcc_WorkDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdWork">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdWork)
{
if (string.IsNullOrEmpty(strIdWork) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdWork]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vcc_WorkDA.IsExist(strIdWork);
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
 bolIsExist = clsvcc_WorkDA.IsExistTable();
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
 bolIsExist = vcc_WorkDA.IsExistTable(strTabName);
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
 /// <param name = "objvcc_WorkENS">源对象</param>
 /// <param name = "objvcc_WorkENT">目标对象</param>
 public static void CopyTo(clsvcc_WorkEN objvcc_WorkENS, clsvcc_WorkEN objvcc_WorkENT)
{
try
{
objvcc_WorkENT.IdWork = objvcc_WorkENS.IdWork; //作业流水号
objvcc_WorkENT.WorkIndex = objvcc_WorkENS.WorkIndex; //作业序号
objvcc_WorkENT.WorkName = objvcc_WorkENS.WorkName; //作业名称
objvcc_WorkENT.WorkDesc = objvcc_WorkENS.WorkDesc; //作业说明
objvcc_WorkENT.CourseId = objvcc_WorkENS.CourseId; //课程Id
objvcc_WorkENT.CourseName = objvcc_WorkENS.CourseName; //课程名称
objvcc_WorkENT.CourseChapterId = objvcc_WorkENS.CourseChapterId; //课程章节ID
objvcc_WorkENT.CourseChapterName = objvcc_WorkENS.CourseChapterName; //课程章节名称
objvcc_WorkENT.ChapterName = objvcc_WorkENS.ChapterName; //章名
objvcc_WorkENT.SectionName = objvcc_WorkENS.SectionName; //节名
objvcc_WorkENT.ChapterNameSim = objvcc_WorkENS.ChapterNameSim; //章名简称
objvcc_WorkENT.SectionNameSim = objvcc_WorkENS.SectionNameSim; //节名简称
objvcc_WorkENT.ParentNodeID = objvcc_WorkENS.ParentNodeID; //父节点编号
objvcc_WorkENT.CourseChapterReferred = objvcc_WorkENS.CourseChapterReferred; //节简称
objvcc_WorkENT.ParentNodeName = objvcc_WorkENS.ParentNodeName; //父节点名称
objvcc_WorkENT.ParentNodeReferred = objvcc_WorkENS.ParentNodeReferred; //章简称
objvcc_WorkENT.Creator = objvcc_WorkENS.Creator; //创建者
objvcc_WorkENT.CreateDate = objvcc_WorkENS.CreateDate; //建立日期
objvcc_WorkENT.AnswerAttLimitSize = objvcc_WorkENS.AnswerAttLimitSize; //回答附件限制大小
objvcc_WorkENT.LimitedResourceType = objvcc_WorkENS.LimitedResourceType; //限制资源类型
objvcc_WorkENT.UpdDate = objvcc_WorkENS.UpdDate; //修改日期
objvcc_WorkENT.UpdUserId = objvcc_WorkENS.UpdUserId; //修改用户Id
objvcc_WorkENT.Memo = objvcc_WorkENS.Memo; //备注
objvcc_WorkENT.CourseId4Chapter = objvcc_WorkENS.CourseId4Chapter; //CourseId4Chapter
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
 /// <param name = "objvcc_WorkEN">源简化对象</param>
 public static void SetUpdFlag(clsvcc_WorkEN objvcc_WorkEN)
{
try
{
objvcc_WorkEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcc_WorkEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcc_Work.IdWork, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEN.IdWork = objvcc_WorkEN.IdWork; //作业流水号
}
if (arrFldSet.Contains(convcc_Work.WorkIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEN.WorkIndex = objvcc_WorkEN.WorkIndex; //作业序号
}
if (arrFldSet.Contains(convcc_Work.WorkName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEN.WorkName = objvcc_WorkEN.WorkName; //作业名称
}
if (arrFldSet.Contains(convcc_Work.WorkDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEN.WorkDesc = objvcc_WorkEN.WorkDesc == "[null]" ? null :  objvcc_WorkEN.WorkDesc; //作业说明
}
if (arrFldSet.Contains(convcc_Work.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEN.CourseId = objvcc_WorkEN.CourseId == "[null]" ? null :  objvcc_WorkEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convcc_Work.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEN.CourseName = objvcc_WorkEN.CourseName == "[null]" ? null :  objvcc_WorkEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convcc_Work.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEN.CourseChapterId = objvcc_WorkEN.CourseChapterId == "[null]" ? null :  objvcc_WorkEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convcc_Work.CourseChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEN.CourseChapterName = objvcc_WorkEN.CourseChapterName == "[null]" ? null :  objvcc_WorkEN.CourseChapterName; //课程章节名称
}
if (arrFldSet.Contains(convcc_Work.ChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEN.ChapterName = objvcc_WorkEN.ChapterName == "[null]" ? null :  objvcc_WorkEN.ChapterName; //章名
}
if (arrFldSet.Contains(convcc_Work.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEN.SectionName = objvcc_WorkEN.SectionName == "[null]" ? null :  objvcc_WorkEN.SectionName; //节名
}
if (arrFldSet.Contains(convcc_Work.ChapterNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEN.ChapterNameSim = objvcc_WorkEN.ChapterNameSim == "[null]" ? null :  objvcc_WorkEN.ChapterNameSim; //章名简称
}
if (arrFldSet.Contains(convcc_Work.SectionNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEN.SectionNameSim = objvcc_WorkEN.SectionNameSim == "[null]" ? null :  objvcc_WorkEN.SectionNameSim; //节名简称
}
if (arrFldSet.Contains(convcc_Work.ParentNodeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEN.ParentNodeID = objvcc_WorkEN.ParentNodeID == "[null]" ? null :  objvcc_WorkEN.ParentNodeID; //父节点编号
}
if (arrFldSet.Contains(convcc_Work.CourseChapterReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEN.CourseChapterReferred = objvcc_WorkEN.CourseChapterReferred == "[null]" ? null :  objvcc_WorkEN.CourseChapterReferred; //节简称
}
if (arrFldSet.Contains(convcc_Work.ParentNodeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEN.ParentNodeName = objvcc_WorkEN.ParentNodeName == "[null]" ? null :  objvcc_WorkEN.ParentNodeName; //父节点名称
}
if (arrFldSet.Contains(convcc_Work.ParentNodeReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEN.ParentNodeReferred = objvcc_WorkEN.ParentNodeReferred == "[null]" ? null :  objvcc_WorkEN.ParentNodeReferred; //章简称
}
if (arrFldSet.Contains(convcc_Work.Creator, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEN.Creator = objvcc_WorkEN.Creator == "[null]" ? null :  objvcc_WorkEN.Creator; //创建者
}
if (arrFldSet.Contains(convcc_Work.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEN.CreateDate = objvcc_WorkEN.CreateDate == "[null]" ? null :  objvcc_WorkEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convcc_Work.AnswerAttLimitSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEN.AnswerAttLimitSize = objvcc_WorkEN.AnswerAttLimitSize; //回答附件限制大小
}
if (arrFldSet.Contains(convcc_Work.LimitedResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEN.LimitedResourceType = objvcc_WorkEN.LimitedResourceType == "[null]" ? null :  objvcc_WorkEN.LimitedResourceType; //限制资源类型
}
if (arrFldSet.Contains(convcc_Work.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEN.UpdDate = objvcc_WorkEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convcc_Work.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEN.UpdUserId = objvcc_WorkEN.UpdUserId == "[null]" ? null :  objvcc_WorkEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convcc_Work.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEN.Memo = objvcc_WorkEN.Memo == "[null]" ? null :  objvcc_WorkEN.Memo; //备注
}
if (arrFldSet.Contains(convcc_Work.CourseId4Chapter, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEN.CourseId4Chapter = objvcc_WorkEN.CourseId4Chapter == "[null]" ? null :  objvcc_WorkEN.CourseId4Chapter; //CourseId4Chapter
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
 /// <param name = "objvcc_WorkEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcc_WorkEN objvcc_WorkEN)
{
try
{
if (objvcc_WorkEN.WorkDesc == "[null]") objvcc_WorkEN.WorkDesc = null; //作业说明
if (objvcc_WorkEN.CourseId == "[null]") objvcc_WorkEN.CourseId = null; //课程Id
if (objvcc_WorkEN.CourseName == "[null]") objvcc_WorkEN.CourseName = null; //课程名称
if (objvcc_WorkEN.CourseChapterId == "[null]") objvcc_WorkEN.CourseChapterId = null; //课程章节ID
if (objvcc_WorkEN.CourseChapterName == "[null]") objvcc_WorkEN.CourseChapterName = null; //课程章节名称
if (objvcc_WorkEN.ChapterName == "[null]") objvcc_WorkEN.ChapterName = null; //章名
if (objvcc_WorkEN.SectionName == "[null]") objvcc_WorkEN.SectionName = null; //节名
if (objvcc_WorkEN.ChapterNameSim == "[null]") objvcc_WorkEN.ChapterNameSim = null; //章名简称
if (objvcc_WorkEN.SectionNameSim == "[null]") objvcc_WorkEN.SectionNameSim = null; //节名简称
if (objvcc_WorkEN.ParentNodeID == "[null]") objvcc_WorkEN.ParentNodeID = null; //父节点编号
if (objvcc_WorkEN.CourseChapterReferred == "[null]") objvcc_WorkEN.CourseChapterReferred = null; //节简称
if (objvcc_WorkEN.ParentNodeName == "[null]") objvcc_WorkEN.ParentNodeName = null; //父节点名称
if (objvcc_WorkEN.ParentNodeReferred == "[null]") objvcc_WorkEN.ParentNodeReferred = null; //章简称
if (objvcc_WorkEN.Creator == "[null]") objvcc_WorkEN.Creator = null; //创建者
if (objvcc_WorkEN.CreateDate == "[null]") objvcc_WorkEN.CreateDate = null; //建立日期
if (objvcc_WorkEN.LimitedResourceType == "[null]") objvcc_WorkEN.LimitedResourceType = null; //限制资源类型
if (objvcc_WorkEN.UpdUserId == "[null]") objvcc_WorkEN.UpdUserId = null; //修改用户Id
if (objvcc_WorkEN.Memo == "[null]") objvcc_WorkEN.Memo = null; //备注
if (objvcc_WorkEN.CourseId4Chapter == "[null]") objvcc_WorkEN.CourseId4Chapter = null; //CourseId4Chapter
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
public static void CheckProperty4Condition(clsvcc_WorkEN objvcc_WorkEN)
{
 vcc_WorkDA.CheckProperty4Condition(objvcc_WorkEN);
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
//string strWhereCond = string.Format("1 = 1 order by IdWork");
//if (arrvcc_WorkObjLstCache == null)
//{
//arrvcc_WorkObjLstCache = vcc_WorkDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdWork">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_WorkEN GetObjByIdWorkCache(string strIdWork)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvcc_WorkEN._CurrTabName);
List<clsvcc_WorkEN> arrvcc_WorkObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_WorkEN> arrvcc_WorkObjLst_Sel =
arrvcc_WorkObjLstCache
.Where(x=> x.IdWork == strIdWork 
);
if (arrvcc_WorkObjLst_Sel.Count() == 0)
{
   clsvcc_WorkEN obj = clsvcc_WorkBL.GetObjByIdWork(strIdWork);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvcc_WorkObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_WorkEN> GetAllvcc_WorkObjLstCache()
{
//获取缓存中的对象列表
List<clsvcc_WorkEN> arrvcc_WorkObjLstCache = GetObjLstCache(); 
return arrvcc_WorkObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_WorkEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvcc_WorkEN._CurrTabName);
List<clsvcc_WorkEN> arrvcc_WorkObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_WorkObjLstCache;
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
string strKey = string.Format("{0}", clsvcc_WorkEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strIdWork)
{
if (strInFldName != convcc_Work.IdWork)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcc_Work.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcc_Work.AttributeName));
throw new Exception(strMsg);
}
var objvcc_Work = clsvcc_WorkBL.GetObjByIdWorkCache(strIdWork);
if (objvcc_Work == null) return "";
return objvcc_Work[strOutFldName].ToString();
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
int intRecCount = clsvcc_WorkDA.GetRecCount(strTabName);
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
int intRecCount = clsvcc_WorkDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcc_WorkDA.GetRecCount();
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
int intRecCount = clsvcc_WorkDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcc_WorkCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcc_WorkEN objvcc_WorkCond)
{
List<clsvcc_WorkEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_WorkEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_Work.AttributeName)
{
if (objvcc_WorkCond.IsUpdated(strFldName) == false) continue;
if (objvcc_WorkCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkCond[strFldName].ToString());
}
else
{
if (objvcc_WorkCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_WorkCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_WorkCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_WorkCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_WorkCond[strFldName]));
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
 List<string> arrList = clsvcc_WorkDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcc_WorkDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcc_WorkDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}