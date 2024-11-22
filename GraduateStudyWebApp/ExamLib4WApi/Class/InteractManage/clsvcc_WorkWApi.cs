
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkWApi
 表名:vcc_Work(01120146)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:46:46
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
public static class clsvcc_WorkWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEN SetId_Work(this clsvcc_WorkEN objvcc_WorkEN, string strId_Work, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_Work, 8, convcc_Work.Id_Work);
clsCheckSql.CheckFieldForeignKey(strId_Work, 8, convcc_Work.Id_Work);
objvcc_WorkEN.Id_Work = strId_Work; //作业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEN.dicFldComparisonOp.ContainsKey(convcc_Work.Id_Work) == false)
{
objvcc_WorkEN.dicFldComparisonOp.Add(convcc_Work.Id_Work, strComparisonOp);
}
else
{
objvcc_WorkEN.dicFldComparisonOp[convcc_Work.Id_Work] = strComparisonOp;
}
}
return objvcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEN SetWorkIndex(this clsvcc_WorkEN objvcc_WorkEN, int intWorkIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEN SetWorkName(this clsvcc_WorkEN objvcc_WorkEN, string strWorkName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkName, convcc_Work.WorkName);
clsCheckSql.CheckFieldLen(strWorkName, 5000, convcc_Work.WorkName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEN SetCourseId(this clsvcc_WorkEN objvcc_WorkEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_Work.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_Work.CourseId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEN SetCourseName(this clsvcc_WorkEN objvcc_WorkEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_Work.CourseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEN SetCourseChapterId(this clsvcc_WorkEN objvcc_WorkEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_Work.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_Work.CourseChapterId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEN SetCourseChapterName(this clsvcc_WorkEN objvcc_WorkEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_Work.CourseChapterName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEN SetChapterName(this clsvcc_WorkEN objvcc_WorkEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_Work.ChapterName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEN SetSectionName(this clsvcc_WorkEN objvcc_WorkEN, string strSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_Work.SectionName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEN SetChapterName_Sim(this clsvcc_WorkEN objvcc_WorkEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convcc_Work.ChapterName_Sim);
objvcc_WorkEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEN.dicFldComparisonOp.ContainsKey(convcc_Work.ChapterName_Sim) == false)
{
objvcc_WorkEN.dicFldComparisonOp.Add(convcc_Work.ChapterName_Sim, strComparisonOp);
}
else
{
objvcc_WorkEN.dicFldComparisonOp[convcc_Work.ChapterName_Sim] = strComparisonOp;
}
}
return objvcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEN SetSectionName_Sim(this clsvcc_WorkEN objvcc_WorkEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, convcc_Work.SectionName_Sim);
objvcc_WorkEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEN.dicFldComparisonOp.ContainsKey(convcc_Work.SectionName_Sim) == false)
{
objvcc_WorkEN.dicFldComparisonOp.Add(convcc_Work.SectionName_Sim, strComparisonOp);
}
else
{
objvcc_WorkEN.dicFldComparisonOp[convcc_Work.SectionName_Sim] = strComparisonOp;
}
}
return objvcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEN SetParentNodeID(this clsvcc_WorkEN objvcc_WorkEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convcc_Work.ParentNodeID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEN SetCourseChapterReferred(this clsvcc_WorkEN objvcc_WorkEN, string strCourseChapterReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convcc_Work.CourseChapterReferred);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEN SetParentNodeName(this clsvcc_WorkEN objvcc_WorkEN, string strParentNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convcc_Work.ParentNodeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEN SetParentNodeReferred(this clsvcc_WorkEN objvcc_WorkEN, string strParentNodeReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convcc_Work.ParentNodeReferred);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEN SetCreator(this clsvcc_WorkEN objvcc_WorkEN, string strCreator, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreator, 18, convcc_Work.Creator);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEN SetCreateDate(this clsvcc_WorkEN objvcc_WorkEN, string strCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convcc_Work.CreateDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEN SetAnswerAttLimitSize(this clsvcc_WorkEN objvcc_WorkEN, long lngAnswerAttLimitSize, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEN SetLimitedResourceType(this clsvcc_WorkEN objvcc_WorkEN, string strLimitedResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLimitedResourceType, 100, convcc_Work.LimitedResourceType);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEN SetUpdDate(this clsvcc_WorkEN objvcc_WorkEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_Work.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_Work.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEN SetUpdUserId(this clsvcc_WorkEN objvcc_WorkEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_Work.UpdUserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEN SetMemo(this clsvcc_WorkEN objvcc_WorkEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_Work.Memo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEN SetCourseId4Chapter(this clsvcc_WorkEN objvcc_WorkEN, string strCourseId4Chapter, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId4Chapter, 8, convcc_Work.CourseId4Chapter);
clsCheckSql.CheckFieldForeignKey(strCourseId4Chapter, 8, convcc_Work.CourseId4Chapter);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_WorkEN objvcc_Work_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_Work_Cond.IsUpdated(convcc_Work.Id_Work) == true)
{
string strComparisonOp_Id_Work = objvcc_Work_Cond.dicFldComparisonOp[convcc_Work.Id_Work];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.Id_Work, objvcc_Work_Cond.Id_Work, strComparisonOp_Id_Work);
}
if (objvcc_Work_Cond.IsUpdated(convcc_Work.WorkIndex) == true)
{
string strComparisonOp_WorkIndex = objvcc_Work_Cond.dicFldComparisonOp[convcc_Work.WorkIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_Work.WorkIndex, objvcc_Work_Cond.WorkIndex, strComparisonOp_WorkIndex);
}
if (objvcc_Work_Cond.IsUpdated(convcc_Work.WorkName) == true)
{
string strComparisonOp_WorkName = objvcc_Work_Cond.dicFldComparisonOp[convcc_Work.WorkName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.WorkName, objvcc_Work_Cond.WorkName, strComparisonOp_WorkName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvcc_Work_Cond.IsUpdated(convcc_Work.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_Work_Cond.dicFldComparisonOp[convcc_Work.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.CourseId, objvcc_Work_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_Work_Cond.IsUpdated(convcc_Work.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_Work_Cond.dicFldComparisonOp[convcc_Work.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.CourseName, objvcc_Work_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_Work_Cond.IsUpdated(convcc_Work.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvcc_Work_Cond.dicFldComparisonOp[convcc_Work.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.CourseChapterId, objvcc_Work_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvcc_Work_Cond.IsUpdated(convcc_Work.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvcc_Work_Cond.dicFldComparisonOp[convcc_Work.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.CourseChapterName, objvcc_Work_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvcc_Work_Cond.IsUpdated(convcc_Work.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvcc_Work_Cond.dicFldComparisonOp[convcc_Work.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.ChapterName, objvcc_Work_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvcc_Work_Cond.IsUpdated(convcc_Work.SectionName) == true)
{
string strComparisonOp_SectionName = objvcc_Work_Cond.dicFldComparisonOp[convcc_Work.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.SectionName, objvcc_Work_Cond.SectionName, strComparisonOp_SectionName);
}
if (objvcc_Work_Cond.IsUpdated(convcc_Work.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvcc_Work_Cond.dicFldComparisonOp[convcc_Work.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.ChapterName_Sim, objvcc_Work_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvcc_Work_Cond.IsUpdated(convcc_Work.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objvcc_Work_Cond.dicFldComparisonOp[convcc_Work.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.SectionName_Sim, objvcc_Work_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
if (objvcc_Work_Cond.IsUpdated(convcc_Work.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvcc_Work_Cond.dicFldComparisonOp[convcc_Work.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.ParentNodeID, objvcc_Work_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvcc_Work_Cond.IsUpdated(convcc_Work.CourseChapterReferred) == true)
{
string strComparisonOp_CourseChapterReferred = objvcc_Work_Cond.dicFldComparisonOp[convcc_Work.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.CourseChapterReferred, objvcc_Work_Cond.CourseChapterReferred, strComparisonOp_CourseChapterReferred);
}
if (objvcc_Work_Cond.IsUpdated(convcc_Work.ParentNodeName) == true)
{
string strComparisonOp_ParentNodeName = objvcc_Work_Cond.dicFldComparisonOp[convcc_Work.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.ParentNodeName, objvcc_Work_Cond.ParentNodeName, strComparisonOp_ParentNodeName);
}
if (objvcc_Work_Cond.IsUpdated(convcc_Work.ParentNodeReferred) == true)
{
string strComparisonOp_ParentNodeReferred = objvcc_Work_Cond.dicFldComparisonOp[convcc_Work.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.ParentNodeReferred, objvcc_Work_Cond.ParentNodeReferred, strComparisonOp_ParentNodeReferred);
}
if (objvcc_Work_Cond.IsUpdated(convcc_Work.Creator) == true)
{
string strComparisonOp_Creator = objvcc_Work_Cond.dicFldComparisonOp[convcc_Work.Creator];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.Creator, objvcc_Work_Cond.Creator, strComparisonOp_Creator);
}
if (objvcc_Work_Cond.IsUpdated(convcc_Work.CreateDate) == true)
{
string strComparisonOp_CreateDate = objvcc_Work_Cond.dicFldComparisonOp[convcc_Work.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.CreateDate, objvcc_Work_Cond.CreateDate, strComparisonOp_CreateDate);
}
if (objvcc_Work_Cond.IsUpdated(convcc_Work.AnswerAttLimitSize) == true)
{
string strComparisonOp_AnswerAttLimitSize = objvcc_Work_Cond.dicFldComparisonOp[convcc_Work.AnswerAttLimitSize];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_Work.AnswerAttLimitSize, objvcc_Work_Cond.AnswerAttLimitSize, strComparisonOp_AnswerAttLimitSize);
}
if (objvcc_Work_Cond.IsUpdated(convcc_Work.LimitedResourceType) == true)
{
string strComparisonOp_LimitedResourceType = objvcc_Work_Cond.dicFldComparisonOp[convcc_Work.LimitedResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.LimitedResourceType, objvcc_Work_Cond.LimitedResourceType, strComparisonOp_LimitedResourceType);
}
if (objvcc_Work_Cond.IsUpdated(convcc_Work.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_Work_Cond.dicFldComparisonOp[convcc_Work.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.UpdDate, objvcc_Work_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_Work_Cond.IsUpdated(convcc_Work.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvcc_Work_Cond.dicFldComparisonOp[convcc_Work.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.UpdUserId, objvcc_Work_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvcc_Work_Cond.IsUpdated(convcc_Work.Memo) == true)
{
string strComparisonOp_Memo = objvcc_Work_Cond.dicFldComparisonOp[convcc_Work.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.Memo, objvcc_Work_Cond.Memo, strComparisonOp_Memo);
}
if (objvcc_Work_Cond.IsUpdated(convcc_Work.CourseId4Chapter) == true)
{
string strComparisonOp_CourseId4Chapter = objvcc_Work_Cond.dicFldComparisonOp[convcc_Work.CourseId4Chapter];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Work.CourseId4Chapter, objvcc_Work_Cond.CourseId4Chapter, strComparisonOp_CourseId4Chapter);
}
 return strWhereCond;
}
}
 /// <summary>
 /// 作业(vcc_Work)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_WorkWApi
{
private static readonly string mstrApiControllerName = "vcc_WorkApi";

 public clsvcc_WorkWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_Work">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkEN GetObjById_Work(string strId_Work)
{
string strAction = "GetObjById_Work";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkEN objvcc_WorkEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_Work"] = strId_Work
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_WorkEN = JsonConvert.DeserializeObject<clsvcc_WorkEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkEN;
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
 /// <param name = "strId_Work">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkEN GetObjById_Work_WA_Cache(string strId_Work)
{
string strAction = "GetObjById_Work_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkEN objvcc_WorkEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_Work"] = strId_Work
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_WorkEN = JsonConvert.DeserializeObject<clsvcc_WorkEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkEN;
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
public static string GetFirstID(string strWhereCond)
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
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
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
public static clsvcc_WorkEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkEN objvcc_WorkEN = null;
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
objvcc_WorkEN = JsonConvert.DeserializeObject<clsvcc_WorkEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkEN;
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
 /// <param name = "strId_Work">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_WorkEN GetObjById_Work_Cache(string strId_Work)
{
if (string.IsNullOrEmpty(strId_Work) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_WorkEN._CurrTabName_S);
List<clsvcc_WorkEN> arrvcc_WorkObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_WorkEN> arrvcc_WorkObjLst_Sel =
from objvcc_WorkEN in arrvcc_WorkObjLst_Cache
where objvcc_WorkEN.Id_Work == strId_Work
select objvcc_WorkEN;
if (arrvcc_WorkObjLst_Sel.Count() == 0)
{
   clsvcc_WorkEN obj = clsvcc_WorkWApi.GetObjById_Work(strId_Work);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_WorkObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_WorkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkEN> GetObjLstById_WorkLst(List<string> arrId_Work)
{
 List<clsvcc_WorkEN> arrObjLst = null; 
string strAction = "GetObjLstById_WorkLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_Work);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strId_Work">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvcc_WorkEN> GetObjLstById_WorkLst_Cache(List<string> arrId_Work)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_WorkEN._CurrTabName_S);
List<clsvcc_WorkEN> arrvcc_WorkObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_WorkEN> arrvcc_WorkObjLst_Sel =
from objvcc_WorkEN in arrvcc_WorkObjLst_Cache
where arrId_Work.Contains(objvcc_WorkEN.Id_Work)
select objvcc_WorkEN;
return arrvcc_WorkObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkEN> GetObjLstById_WorkLst_WA_Cache(List<string> arrId_Work)
{
 List<clsvcc_WorkEN> arrObjLst = null; 
string strAction = "GetObjLstById_WorkLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_Work);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_WorkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_WorkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_WorkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_WorkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strId_Work)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_Work"] = strId_Work
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
 /// <param name = "objvcc_WorkENS">源对象</param>
 /// <param name = "objvcc_WorkENT">目标对象</param>
 public static void CopyTo(clsvcc_WorkEN objvcc_WorkENS, clsvcc_WorkEN objvcc_WorkENT)
{
try
{
objvcc_WorkENT.Id_Work = objvcc_WorkENS.Id_Work; //作业流水号
objvcc_WorkENT.WorkIndex = objvcc_WorkENS.WorkIndex; //作业序号
objvcc_WorkENT.WorkName = objvcc_WorkENS.WorkName; //作业名称
objvcc_WorkENT.WorkDesc = objvcc_WorkENS.WorkDesc; //作业说明
objvcc_WorkENT.CourseId = objvcc_WorkENS.CourseId; //课程Id
objvcc_WorkENT.CourseName = objvcc_WorkENS.CourseName; //课程名称
objvcc_WorkENT.CourseChapterId = objvcc_WorkENS.CourseChapterId; //课程章节ID
objvcc_WorkENT.CourseChapterName = objvcc_WorkENS.CourseChapterName; //课程章节名称
objvcc_WorkENT.ChapterName = objvcc_WorkENS.ChapterName; //章名
objvcc_WorkENT.SectionName = objvcc_WorkENS.SectionName; //节名
objvcc_WorkENT.ChapterName_Sim = objvcc_WorkENS.ChapterName_Sim; //章名简称
objvcc_WorkENT.SectionName_Sim = objvcc_WorkENS.SectionName_Sim; //节名简称
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
public static DataTable ToDataTable(List<clsvcc_WorkEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_WorkEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_WorkEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_WorkEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_WorkEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_WorkEN.AttributeName)
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
//string strWhereCond = string.Format("1 = 1 order by Id_Work");
//if (arrvcc_WorkObjLst_Cache == null)
//{
//arrvcc_WorkObjLst_Cache = await clsvcc_WorkWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvcc_WorkEN._CurrTabName_S);
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
public static List<clsvcc_WorkEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvcc_WorkEN._CurrTabName_S);
List<clsvcc_WorkEN> arrvcc_WorkObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_WorkObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_WorkEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_Work.Id_Work, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Work.WorkIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_Work.WorkName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Work.WorkDesc, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Work.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Work.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Work.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Work.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Work.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Work.SectionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Work.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Work.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Work.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Work.CourseChapterReferred, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Work.ParentNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Work.ParentNodeReferred, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Work.Creator, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Work.CreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Work.AnswerAttLimitSize, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_Work.LimitedResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Work.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Work.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Work.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Work.CourseId4Chapter, Type.GetType("System.String"));
foreach (clsvcc_WorkEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_Work.Id_Work] = objInFor[convcc_Work.Id_Work];
objDR[convcc_Work.WorkIndex] = objInFor[convcc_Work.WorkIndex];
objDR[convcc_Work.WorkName] = objInFor[convcc_Work.WorkName];
objDR[convcc_Work.WorkDesc] = objInFor[convcc_Work.WorkDesc];
objDR[convcc_Work.CourseId] = objInFor[convcc_Work.CourseId];
objDR[convcc_Work.CourseName] = objInFor[convcc_Work.CourseName];
objDR[convcc_Work.CourseChapterId] = objInFor[convcc_Work.CourseChapterId];
objDR[convcc_Work.CourseChapterName] = objInFor[convcc_Work.CourseChapterName];
objDR[convcc_Work.ChapterName] = objInFor[convcc_Work.ChapterName];
objDR[convcc_Work.SectionName] = objInFor[convcc_Work.SectionName];
objDR[convcc_Work.ChapterName_Sim] = objInFor[convcc_Work.ChapterName_Sim];
objDR[convcc_Work.SectionName_Sim] = objInFor[convcc_Work.SectionName_Sim];
objDR[convcc_Work.ParentNodeID] = objInFor[convcc_Work.ParentNodeID];
objDR[convcc_Work.CourseChapterReferred] = objInFor[convcc_Work.CourseChapterReferred];
objDR[convcc_Work.ParentNodeName] = objInFor[convcc_Work.ParentNodeName];
objDR[convcc_Work.ParentNodeReferred] = objInFor[convcc_Work.ParentNodeReferred];
objDR[convcc_Work.Creator] = objInFor[convcc_Work.Creator];
objDR[convcc_Work.CreateDate] = objInFor[convcc_Work.CreateDate];
objDR[convcc_Work.AnswerAttLimitSize] = objInFor[convcc_Work.AnswerAttLimitSize];
objDR[convcc_Work.LimitedResourceType] = objInFor[convcc_Work.LimitedResourceType];
objDR[convcc_Work.UpdDate] = objInFor[convcc_Work.UpdDate];
objDR[convcc_Work.UpdUserId] = objInFor[convcc_Work.UpdUserId];
objDR[convcc_Work.Memo] = objInFor[convcc_Work.Memo];
objDR[convcc_Work.CourseId4Chapter] = objInFor[convcc_Work.CourseId4Chapter];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}