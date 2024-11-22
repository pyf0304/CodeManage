
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkStuRelation4AppWApi
 表名:vcc_WorkStuRelation4App(01120252)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:51:03
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
public static class clsvcc_WorkStuRelation4AppWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN SetId_WorkStuRelation(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, long lngId_WorkStuRelation, string strComparisonOp="")
	{
objvcc_WorkStuRelation4AppEN.Id_WorkStuRelation = lngId_WorkStuRelation; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.Id_WorkStuRelation) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.Id_WorkStuRelation, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.Id_WorkStuRelation] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN Setid_CurrEduCls(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CurrEduCls, convcc_WorkStuRelation4App.id_CurrEduCls);
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convcc_WorkStuRelation4App.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convcc_WorkStuRelation4App.id_CurrEduCls);
objvcc_WorkStuRelation4AppEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.id_CurrEduCls) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.id_CurrEduCls, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.id_CurrEduCls] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN SetQuestionID(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionID, 8, convcc_WorkStuRelation4App.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convcc_WorkStuRelation4App.QuestionID);
objvcc_WorkStuRelation4AppEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.QuestionID) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.QuestionID, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.QuestionID] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN SetQuestionIndex(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, int intQuestionIndex, string strComparisonOp="")
	{
objvcc_WorkStuRelation4AppEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.QuestionIndex) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.QuestionIndex, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.QuestionIndex] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN SetQuestionName(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, string strQuestionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionName, 1000, convcc_WorkStuRelation4App.QuestionName);
objvcc_WorkStuRelation4AppEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.QuestionName) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.QuestionName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.QuestionName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN SetCourseName(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_WorkStuRelation4App.CourseName);
objvcc_WorkStuRelation4AppEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.CourseName) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.CourseName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.CourseName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN SetChapterName(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_WorkStuRelation4App.ChapterName);
objvcc_WorkStuRelation4AppEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.ChapterName) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.ChapterName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.ChapterName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN SetSectionName(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, string strSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_WorkStuRelation4App.SectionName);
objvcc_WorkStuRelation4AppEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.SectionName) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.SectionName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.SectionName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN SetChapterName_Sim(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convcc_WorkStuRelation4App.ChapterName_Sim);
objvcc_WorkStuRelation4AppEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.ChapterName_Sim) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.ChapterName_Sim, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.ChapterName_Sim] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN SetSectionName_Sim(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, convcc_WorkStuRelation4App.SectionName_Sim);
objvcc_WorkStuRelation4AppEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.SectionName_Sim) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.SectionName_Sim, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.SectionName_Sim] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN SetQuestionTypeId(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convcc_WorkStuRelation4App.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convcc_WorkStuRelation4App.QuestionTypeId);
objvcc_WorkStuRelation4AppEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.QuestionTypeId) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.QuestionTypeId, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.QuestionTypeId] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN SetQuestionTypeName(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, string strQuestionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convcc_WorkStuRelation4App.QuestionTypeName);
objvcc_WorkStuRelation4AppEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.QuestionTypeName) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.QuestionTypeName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.QuestionTypeName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN SetEduClsName(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convcc_WorkStuRelation4App.EduClsName);
objvcc_WorkStuRelation4AppEN.EduClsName = strEduClsName; //教学班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.EduClsName) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.EduClsName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.EduClsName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN SetSpecifyCompletionDate(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, string strSpecifyCompletionDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSpecifyCompletionDate, convcc_WorkStuRelation4App.SpecifyCompletionDate);
clsCheckSql.CheckFieldLen(strSpecifyCompletionDate, 14, convcc_WorkStuRelation4App.SpecifyCompletionDate);
objvcc_WorkStuRelation4AppEN.SpecifyCompletionDate = strSpecifyCompletionDate; //指定完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.SpecifyCompletionDate) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.SpecifyCompletionDate, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.SpecifyCompletionDate] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN Setid_StudentInfo(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudentInfo, convcc_WorkStuRelation4App.id_StudentInfo);
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, convcc_WorkStuRelation4App.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, convcc_WorkStuRelation4App.id_StudentInfo);
objvcc_WorkStuRelation4AppEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.id_StudentInfo) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.id_StudentInfo, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.id_StudentInfo] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN SetStuID(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convcc_WorkStuRelation4App.StuID);
objvcc_WorkStuRelation4AppEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.StuID) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.StuID, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.StuID] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN SetStuName(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convcc_WorkStuRelation4App.StuName);
objvcc_WorkStuRelation4AppEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.StuName) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.StuName, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.StuName] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN SetIsLook(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, bool bolIsLook, string strComparisonOp="")
	{
objvcc_WorkStuRelation4AppEN.IsLook = bolIsLook; //是否查看
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.IsLook) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.IsLook, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.IsLook] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN SetIsSave(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, bool bolIsSave, string strComparisonOp="")
	{
objvcc_WorkStuRelation4AppEN.IsSave = bolIsSave; //是否保存
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.IsSave) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.IsSave, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.IsSave] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN SetIsSubmit(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvcc_WorkStuRelation4AppEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.IsSubmit) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.IsSubmit, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.IsSubmit] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN SetRealFinishDate(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, string strRealFinishDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRealFinishDate, 14, convcc_WorkStuRelation4App.RealFinishDate);
objvcc_WorkStuRelation4AppEN.RealFinishDate = strRealFinishDate; //实际完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.RealFinishDate) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.RealFinishDate, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.RealFinishDate] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN SetScore(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, double dblScore, string strComparisonOp="")
	{
objvcc_WorkStuRelation4AppEN.Score = dblScore; //得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.Score) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.Score, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.Score] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN SetIsMarking(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, bool bolIsMarking, string strComparisonOp="")
	{
objvcc_WorkStuRelation4AppEN.IsMarking = bolIsMarking; //是否批阅
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.IsMarking) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.IsMarking, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.IsMarking] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN SetMarkerId(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, string strMarkerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkerId, 20, convcc_WorkStuRelation4App.MarkerId);
objvcc_WorkStuRelation4AppEN.MarkerId = strMarkerId; //打分者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.MarkerId) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.MarkerId, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.MarkerId] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN SetMarkDate(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, string strMarkDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkDate, 14, convcc_WorkStuRelation4App.MarkDate);
objvcc_WorkStuRelation4AppEN.MarkDate = strMarkDate; //打分日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.MarkDate) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.MarkDate, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.MarkDate] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN SetAnswerDate(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, string strAnswerDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerDate, 8, convcc_WorkStuRelation4App.AnswerDate);
objvcc_WorkStuRelation4AppEN.AnswerDate = strAnswerDate; //回答日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.AnswerDate) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.AnswerDate, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.AnswerDate] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN SetAnswerTime(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, string strAnswerTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTime, 10, convcc_WorkStuRelation4App.AnswerTime);
objvcc_WorkStuRelation4AppEN.AnswerTime = strAnswerTime; //回答时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.AnswerTime) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.AnswerTime, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.AnswerTime] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN SetIsRight(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, bool bolIsRight, string strComparisonOp="")
	{
objvcc_WorkStuRelation4AppEN.IsRight = bolIsRight; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.IsRight) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.IsRight, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.IsRight] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN SetErrMsg(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, string strErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrMsg, 200, convcc_WorkStuRelation4App.ErrMsg);
objvcc_WorkStuRelation4AppEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.ErrMsg) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.ErrMsg, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.ErrMsg] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN SetUpdDate(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_WorkStuRelation4App.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_WorkStuRelation4App.UpdDate);
objvcc_WorkStuRelation4AppEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.UpdDate) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.UpdDate, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.UpdDate] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN SetUpdUserId(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_WorkStuRelation4App.UpdUserId);
objvcc_WorkStuRelation4AppEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.UpdUserId) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.UpdUserId, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.UpdUserId] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelation4AppEN SetMemo(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_WorkStuRelation4App.Memo);
objvcc_WorkStuRelation4AppEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation4App.Memo) == false)
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp.Add(convcc_WorkStuRelation4App.Memo, strComparisonOp);
}
else
{
objvcc_WorkStuRelation4AppEN.dicFldComparisonOp[convcc_WorkStuRelation4App.Memo] = strComparisonOp;
}
}
return objvcc_WorkStuRelation4AppEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4App_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.Id_WorkStuRelation) == true)
{
string strComparisonOp_Id_WorkStuRelation = objvcc_WorkStuRelation4App_Cond.dicFldComparisonOp[convcc_WorkStuRelation4App.Id_WorkStuRelation];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation4App.Id_WorkStuRelation, objvcc_WorkStuRelation4App_Cond.Id_WorkStuRelation, strComparisonOp_Id_WorkStuRelation);
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvcc_WorkStuRelation4App_Cond.dicFldComparisonOp[convcc_WorkStuRelation4App.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4App.id_CurrEduCls, objvcc_WorkStuRelation4App_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.QuestionID) == true)
{
string strComparisonOp_QuestionID = objvcc_WorkStuRelation4App_Cond.dicFldComparisonOp[convcc_WorkStuRelation4App.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4App.QuestionID, objvcc_WorkStuRelation4App_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.QuestionIndex) == true)
{
string strComparisonOp_QuestionIndex = objvcc_WorkStuRelation4App_Cond.dicFldComparisonOp[convcc_WorkStuRelation4App.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation4App.QuestionIndex, objvcc_WorkStuRelation4App_Cond.QuestionIndex, strComparisonOp_QuestionIndex);
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.QuestionName) == true)
{
string strComparisonOp_QuestionName = objvcc_WorkStuRelation4App_Cond.dicFldComparisonOp[convcc_WorkStuRelation4App.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4App.QuestionName, objvcc_WorkStuRelation4App_Cond.QuestionName, strComparisonOp_QuestionName);
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_WorkStuRelation4App_Cond.dicFldComparisonOp[convcc_WorkStuRelation4App.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4App.CourseName, objvcc_WorkStuRelation4App_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvcc_WorkStuRelation4App_Cond.dicFldComparisonOp[convcc_WorkStuRelation4App.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4App.ChapterName, objvcc_WorkStuRelation4App_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.SectionName) == true)
{
string strComparisonOp_SectionName = objvcc_WorkStuRelation4App_Cond.dicFldComparisonOp[convcc_WorkStuRelation4App.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4App.SectionName, objvcc_WorkStuRelation4App_Cond.SectionName, strComparisonOp_SectionName);
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvcc_WorkStuRelation4App_Cond.dicFldComparisonOp[convcc_WorkStuRelation4App.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4App.ChapterName_Sim, objvcc_WorkStuRelation4App_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objvcc_WorkStuRelation4App_Cond.dicFldComparisonOp[convcc_WorkStuRelation4App.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4App.SectionName_Sim, objvcc_WorkStuRelation4App_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objvcc_WorkStuRelation4App_Cond.dicFldComparisonOp[convcc_WorkStuRelation4App.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4App.QuestionTypeId, objvcc_WorkStuRelation4App_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.QuestionTypeName) == true)
{
string strComparisonOp_QuestionTypeName = objvcc_WorkStuRelation4App_Cond.dicFldComparisonOp[convcc_WorkStuRelation4App.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4App.QuestionTypeName, objvcc_WorkStuRelation4App_Cond.QuestionTypeName, strComparisonOp_QuestionTypeName);
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.EduClsName) == true)
{
string strComparisonOp_EduClsName = objvcc_WorkStuRelation4App_Cond.dicFldComparisonOp[convcc_WorkStuRelation4App.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4App.EduClsName, objvcc_WorkStuRelation4App_Cond.EduClsName, strComparisonOp_EduClsName);
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.SpecifyCompletionDate) == true)
{
string strComparisonOp_SpecifyCompletionDate = objvcc_WorkStuRelation4App_Cond.dicFldComparisonOp[convcc_WorkStuRelation4App.SpecifyCompletionDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4App.SpecifyCompletionDate, objvcc_WorkStuRelation4App_Cond.SpecifyCompletionDate, strComparisonOp_SpecifyCompletionDate);
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objvcc_WorkStuRelation4App_Cond.dicFldComparisonOp[convcc_WorkStuRelation4App.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4App.id_StudentInfo, objvcc_WorkStuRelation4App_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.StuID) == true)
{
string strComparisonOp_StuID = objvcc_WorkStuRelation4App_Cond.dicFldComparisonOp[convcc_WorkStuRelation4App.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4App.StuID, objvcc_WorkStuRelation4App_Cond.StuID, strComparisonOp_StuID);
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.StuName) == true)
{
string strComparisonOp_StuName = objvcc_WorkStuRelation4App_Cond.dicFldComparisonOp[convcc_WorkStuRelation4App.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4App.StuName, objvcc_WorkStuRelation4App_Cond.StuName, strComparisonOp_StuName);
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.IsLook) == true)
{
if (objvcc_WorkStuRelation4App_Cond.IsLook == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation4App.IsLook);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation4App.IsLook);
}
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.IsSave) == true)
{
if (objvcc_WorkStuRelation4App_Cond.IsSave == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation4App.IsSave);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation4App.IsSave);
}
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.IsSubmit) == true)
{
if (objvcc_WorkStuRelation4App_Cond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation4App.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation4App.IsSubmit);
}
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.RealFinishDate) == true)
{
string strComparisonOp_RealFinishDate = objvcc_WorkStuRelation4App_Cond.dicFldComparisonOp[convcc_WorkStuRelation4App.RealFinishDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4App.RealFinishDate, objvcc_WorkStuRelation4App_Cond.RealFinishDate, strComparisonOp_RealFinishDate);
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.Score) == true)
{
string strComparisonOp_Score = objvcc_WorkStuRelation4App_Cond.dicFldComparisonOp[convcc_WorkStuRelation4App.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation4App.Score, objvcc_WorkStuRelation4App_Cond.Score, strComparisonOp_Score);
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.IsMarking) == true)
{
if (objvcc_WorkStuRelation4App_Cond.IsMarking == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation4App.IsMarking);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation4App.IsMarking);
}
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.MarkerId) == true)
{
string strComparisonOp_MarkerId = objvcc_WorkStuRelation4App_Cond.dicFldComparisonOp[convcc_WorkStuRelation4App.MarkerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4App.MarkerId, objvcc_WorkStuRelation4App_Cond.MarkerId, strComparisonOp_MarkerId);
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.MarkDate) == true)
{
string strComparisonOp_MarkDate = objvcc_WorkStuRelation4App_Cond.dicFldComparisonOp[convcc_WorkStuRelation4App.MarkDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4App.MarkDate, objvcc_WorkStuRelation4App_Cond.MarkDate, strComparisonOp_MarkDate);
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.AnswerDate) == true)
{
string strComparisonOp_AnswerDate = objvcc_WorkStuRelation4App_Cond.dicFldComparisonOp[convcc_WorkStuRelation4App.AnswerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4App.AnswerDate, objvcc_WorkStuRelation4App_Cond.AnswerDate, strComparisonOp_AnswerDate);
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.AnswerTime) == true)
{
string strComparisonOp_AnswerTime = objvcc_WorkStuRelation4App_Cond.dicFldComparisonOp[convcc_WorkStuRelation4App.AnswerTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4App.AnswerTime, objvcc_WorkStuRelation4App_Cond.AnswerTime, strComparisonOp_AnswerTime);
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.IsRight) == true)
{
if (objvcc_WorkStuRelation4App_Cond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation4App.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation4App.IsRight);
}
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.ErrMsg) == true)
{
string strComparisonOp_ErrMsg = objvcc_WorkStuRelation4App_Cond.dicFldComparisonOp[convcc_WorkStuRelation4App.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4App.ErrMsg, objvcc_WorkStuRelation4App_Cond.ErrMsg, strComparisonOp_ErrMsg);
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_WorkStuRelation4App_Cond.dicFldComparisonOp[convcc_WorkStuRelation4App.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4App.UpdDate, objvcc_WorkStuRelation4App_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvcc_WorkStuRelation4App_Cond.dicFldComparisonOp[convcc_WorkStuRelation4App.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4App.UpdUserId, objvcc_WorkStuRelation4App_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvcc_WorkStuRelation4App_Cond.IsUpdated(convcc_WorkStuRelation4App.Memo) == true)
{
string strComparisonOp_Memo = objvcc_WorkStuRelation4App_Cond.dicFldComparisonOp[convcc_WorkStuRelation4App.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation4App.Memo, objvcc_WorkStuRelation4App_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vcc_WorkStuRelation4App(vcc_WorkStuRelation4App)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_WorkStuRelation4AppWApi
{
private static readonly string mstrApiControllerName = "vcc_WorkStuRelation4AppApi";

 public clsvcc_WorkStuRelation4AppWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_WorkStuRelation">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkStuRelation4AppEN GetObjById_WorkStuRelation(long lngId_WorkStuRelation)
{
string strAction = "GetObjById_WorkStuRelation";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_WorkStuRelation"] = lngId_WorkStuRelation.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_WorkStuRelation4AppEN = JsonConvert.DeserializeObject<clsvcc_WorkStuRelation4AppEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkStuRelation4AppEN;
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
 /// <param name = "lngId_WorkStuRelation">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkStuRelation4AppEN GetObjById_WorkStuRelation_WA_Cache(long lngId_WorkStuRelation)
{
string strAction = "GetObjById_WorkStuRelation_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_WorkStuRelation"] = lngId_WorkStuRelation.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_WorkStuRelation4AppEN = JsonConvert.DeserializeObject<clsvcc_WorkStuRelation4AppEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkStuRelation4AppEN;
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
public static clsvcc_WorkStuRelation4AppEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppEN = null;
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
objvcc_WorkStuRelation4AppEN = JsonConvert.DeserializeObject<clsvcc_WorkStuRelation4AppEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkStuRelation4AppEN;
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
 /// <param name = "lngId_WorkStuRelation">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_WorkStuRelation4AppEN GetObjById_WorkStuRelation_Cache(long lngId_WorkStuRelation)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_WorkStuRelation4AppEN._CurrTabName_S);
List<clsvcc_WorkStuRelation4AppEN> arrvcc_WorkStuRelation4AppObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_WorkStuRelation4AppEN> arrvcc_WorkStuRelation4AppObjLst_Sel =
from objvcc_WorkStuRelation4AppEN in arrvcc_WorkStuRelation4AppObjLst_Cache
where objvcc_WorkStuRelation4AppEN.Id_WorkStuRelation == lngId_WorkStuRelation
select objvcc_WorkStuRelation4AppEN;
if (arrvcc_WorkStuRelation4AppObjLst_Sel.Count() == 0)
{
   clsvcc_WorkStuRelation4AppEN obj = clsvcc_WorkStuRelation4AppWApi.GetObjById_WorkStuRelation(lngId_WorkStuRelation);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_WorkStuRelation4AppObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelation4AppEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_WorkStuRelation4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelation4AppEN> GetObjLstById_WorkStuRelationLst(List<long> arrId_WorkStuRelation)
{
 List<clsvcc_WorkStuRelation4AppEN> arrObjLst = null; 
string strAction = "GetObjLstById_WorkStuRelationLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_WorkStuRelation);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngId_WorkStuRelation">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvcc_WorkStuRelation4AppEN> GetObjLstById_WorkStuRelationLst_Cache(List<long> arrId_WorkStuRelation)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_WorkStuRelation4AppEN._CurrTabName_S);
List<clsvcc_WorkStuRelation4AppEN> arrvcc_WorkStuRelation4AppObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_WorkStuRelation4AppEN> arrvcc_WorkStuRelation4AppObjLst_Sel =
from objvcc_WorkStuRelation4AppEN in arrvcc_WorkStuRelation4AppObjLst_Cache
where arrId_WorkStuRelation.Contains(objvcc_WorkStuRelation4AppEN.Id_WorkStuRelation)
select objvcc_WorkStuRelation4AppEN;
return arrvcc_WorkStuRelation4AppObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelation4AppEN> GetObjLstById_WorkStuRelationLst_WA_Cache(List<long> arrId_WorkStuRelation)
{
 List<clsvcc_WorkStuRelation4AppEN> arrObjLst = null; 
string strAction = "GetObjLstById_WorkStuRelationLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_WorkStuRelation);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelation4AppEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_WorkStuRelation4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelation4AppEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_WorkStuRelation4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelation4AppEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_WorkStuRelation4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelation4AppEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_WorkStuRelation4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelation4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngId_WorkStuRelation)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_WorkStuRelation"] = lngId_WorkStuRelation.ToString()
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
 /// <param name = "objvcc_WorkStuRelation4AppENS">源对象</param>
 /// <param name = "objvcc_WorkStuRelation4AppENT">目标对象</param>
 public static void CopyTo(clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppENS, clsvcc_WorkStuRelation4AppEN objvcc_WorkStuRelation4AppENT)
{
try
{
objvcc_WorkStuRelation4AppENT.Id_WorkStuRelation = objvcc_WorkStuRelation4AppENS.Id_WorkStuRelation; //流水号
objvcc_WorkStuRelation4AppENT.id_CurrEduCls = objvcc_WorkStuRelation4AppENS.id_CurrEduCls; //当前教学班流水号
objvcc_WorkStuRelation4AppENT.QuestionID = objvcc_WorkStuRelation4AppENS.QuestionID; //题目ID
objvcc_WorkStuRelation4AppENT.QuestionIndex = objvcc_WorkStuRelation4AppENS.QuestionIndex; //题目序号
objvcc_WorkStuRelation4AppENT.QuestionName = objvcc_WorkStuRelation4AppENS.QuestionName; //题目名称
objvcc_WorkStuRelation4AppENT.CourseName = objvcc_WorkStuRelation4AppENS.CourseName; //课程名称
objvcc_WorkStuRelation4AppENT.ChapterName = objvcc_WorkStuRelation4AppENS.ChapterName; //章名
objvcc_WorkStuRelation4AppENT.SectionName = objvcc_WorkStuRelation4AppENS.SectionName; //节名
objvcc_WorkStuRelation4AppENT.ChapterName_Sim = objvcc_WorkStuRelation4AppENS.ChapterName_Sim; //章名简称
objvcc_WorkStuRelation4AppENT.SectionName_Sim = objvcc_WorkStuRelation4AppENS.SectionName_Sim; //节名简称
objvcc_WorkStuRelation4AppENT.QuestionTypeId = objvcc_WorkStuRelation4AppENS.QuestionTypeId; //题目类型Id
objvcc_WorkStuRelation4AppENT.QuestionTypeName = objvcc_WorkStuRelation4AppENS.QuestionTypeName; //题目类型名
objvcc_WorkStuRelation4AppENT.EduClsName = objvcc_WorkStuRelation4AppENS.EduClsName; //教学班名称
objvcc_WorkStuRelation4AppENT.SpecifyCompletionDate = objvcc_WorkStuRelation4AppENS.SpecifyCompletionDate; //指定完成日期
objvcc_WorkStuRelation4AppENT.id_StudentInfo = objvcc_WorkStuRelation4AppENS.id_StudentInfo; //学生流水号
objvcc_WorkStuRelation4AppENT.StuID = objvcc_WorkStuRelation4AppENS.StuID; //学号
objvcc_WorkStuRelation4AppENT.StuName = objvcc_WorkStuRelation4AppENS.StuName; //姓名
objvcc_WorkStuRelation4AppENT.IsLook = objvcc_WorkStuRelation4AppENS.IsLook; //是否查看
objvcc_WorkStuRelation4AppENT.IsSave = objvcc_WorkStuRelation4AppENS.IsSave; //是否保存
objvcc_WorkStuRelation4AppENT.IsSubmit = objvcc_WorkStuRelation4AppENS.IsSubmit; //是否提交
objvcc_WorkStuRelation4AppENT.RealFinishDate = objvcc_WorkStuRelation4AppENS.RealFinishDate; //实际完成日期
objvcc_WorkStuRelation4AppENT.Score = objvcc_WorkStuRelation4AppENS.Score; //得分
objvcc_WorkStuRelation4AppENT.IsMarking = objvcc_WorkStuRelation4AppENS.IsMarking; //是否批阅
objvcc_WorkStuRelation4AppENT.MarkerId = objvcc_WorkStuRelation4AppENS.MarkerId; //打分者
objvcc_WorkStuRelation4AppENT.MarkDate = objvcc_WorkStuRelation4AppENS.MarkDate; //打分日期
objvcc_WorkStuRelation4AppENT.AnswerDate = objvcc_WorkStuRelation4AppENS.AnswerDate; //回答日期
objvcc_WorkStuRelation4AppENT.AnswerTime = objvcc_WorkStuRelation4AppENS.AnswerTime; //回答时间
objvcc_WorkStuRelation4AppENT.IsRight = objvcc_WorkStuRelation4AppENS.IsRight; //是否正确
objvcc_WorkStuRelation4AppENT.ErrMsg = objvcc_WorkStuRelation4AppENS.ErrMsg; //错误信息
objvcc_WorkStuRelation4AppENT.UpdDate = objvcc_WorkStuRelation4AppENS.UpdDate; //修改日期
objvcc_WorkStuRelation4AppENT.UpdUserId = objvcc_WorkStuRelation4AppENS.UpdUserId; //修改用户Id
objvcc_WorkStuRelation4AppENT.Memo = objvcc_WorkStuRelation4AppENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvcc_WorkStuRelation4AppEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_WorkStuRelation4AppEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_WorkStuRelation4AppEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_WorkStuRelation4AppEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_WorkStuRelation4AppEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_WorkStuRelation4AppEN.AttributeName)
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
if (clscc_WorkStuRelationWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkStuRelationWApi没有刷新缓存机制(clscc_WorkStuRelationWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsCurrEduClsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsWApi没有刷新缓存机制(clsCurrEduClsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_WorkEduClsRelaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkEduClsRelaWApi没有刷新缓存机制(clscc_WorkEduClsRelaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsWorkTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsWorkTypeWApi没有刷新缓存机制(clsWorkTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsStudyLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelWApi没有刷新缓存机制(clsStudyLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by Id_WorkStuRelation");
//if (arrvcc_WorkStuRelation4AppObjLst_Cache == null)
//{
//arrvcc_WorkStuRelation4AppObjLst_Cache = await clsvcc_WorkStuRelation4AppWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvcc_WorkStuRelation4AppEN._CurrTabName_S);
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
public static List<clsvcc_WorkStuRelation4AppEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvcc_WorkStuRelation4AppEN._CurrTabName_S);
List<clsvcc_WorkStuRelation4AppEN> arrvcc_WorkStuRelation4AppObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_WorkStuRelation4AppObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_WorkStuRelation4AppEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_WorkStuRelation4App.Id_WorkStuRelation, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_WorkStuRelation4App.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4App.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4App.QuestionIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_WorkStuRelation4App.QuestionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4App.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4App.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4App.SectionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4App.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4App.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4App.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4App.QuestionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4App.EduClsName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4App.SpecifyCompletionDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4App.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4App.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4App.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4App.IsLook, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_WorkStuRelation4App.IsSave, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_WorkStuRelation4App.IsSubmit, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_WorkStuRelation4App.RealFinishDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4App.Score, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_WorkStuRelation4App.IsMarking, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_WorkStuRelation4App.MarkerId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4App.MarkDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4App.AnswerDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4App.AnswerTime, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4App.IsRight, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_WorkStuRelation4App.ErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4App.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4App.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation4App.Memo, Type.GetType("System.String"));
foreach (clsvcc_WorkStuRelation4AppEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_WorkStuRelation4App.Id_WorkStuRelation] = objInFor[convcc_WorkStuRelation4App.Id_WorkStuRelation];
objDR[convcc_WorkStuRelation4App.id_CurrEduCls] = objInFor[convcc_WorkStuRelation4App.id_CurrEduCls];
objDR[convcc_WorkStuRelation4App.QuestionID] = objInFor[convcc_WorkStuRelation4App.QuestionID];
objDR[convcc_WorkStuRelation4App.QuestionIndex] = objInFor[convcc_WorkStuRelation4App.QuestionIndex];
objDR[convcc_WorkStuRelation4App.QuestionName] = objInFor[convcc_WorkStuRelation4App.QuestionName];
objDR[convcc_WorkStuRelation4App.CourseName] = objInFor[convcc_WorkStuRelation4App.CourseName];
objDR[convcc_WorkStuRelation4App.ChapterName] = objInFor[convcc_WorkStuRelation4App.ChapterName];
objDR[convcc_WorkStuRelation4App.SectionName] = objInFor[convcc_WorkStuRelation4App.SectionName];
objDR[convcc_WorkStuRelation4App.ChapterName_Sim] = objInFor[convcc_WorkStuRelation4App.ChapterName_Sim];
objDR[convcc_WorkStuRelation4App.SectionName_Sim] = objInFor[convcc_WorkStuRelation4App.SectionName_Sim];
objDR[convcc_WorkStuRelation4App.QuestionTypeId] = objInFor[convcc_WorkStuRelation4App.QuestionTypeId];
objDR[convcc_WorkStuRelation4App.QuestionTypeName] = objInFor[convcc_WorkStuRelation4App.QuestionTypeName];
objDR[convcc_WorkStuRelation4App.EduClsName] = objInFor[convcc_WorkStuRelation4App.EduClsName];
objDR[convcc_WorkStuRelation4App.SpecifyCompletionDate] = objInFor[convcc_WorkStuRelation4App.SpecifyCompletionDate];
objDR[convcc_WorkStuRelation4App.id_StudentInfo] = objInFor[convcc_WorkStuRelation4App.id_StudentInfo];
objDR[convcc_WorkStuRelation4App.StuID] = objInFor[convcc_WorkStuRelation4App.StuID];
objDR[convcc_WorkStuRelation4App.StuName] = objInFor[convcc_WorkStuRelation4App.StuName];
objDR[convcc_WorkStuRelation4App.IsLook] = objInFor[convcc_WorkStuRelation4App.IsLook];
objDR[convcc_WorkStuRelation4App.IsSave] = objInFor[convcc_WorkStuRelation4App.IsSave];
objDR[convcc_WorkStuRelation4App.IsSubmit] = objInFor[convcc_WorkStuRelation4App.IsSubmit];
objDR[convcc_WorkStuRelation4App.RealFinishDate] = objInFor[convcc_WorkStuRelation4App.RealFinishDate];
objDR[convcc_WorkStuRelation4App.Score] = objInFor[convcc_WorkStuRelation4App.Score];
objDR[convcc_WorkStuRelation4App.IsMarking] = objInFor[convcc_WorkStuRelation4App.IsMarking];
objDR[convcc_WorkStuRelation4App.MarkerId] = objInFor[convcc_WorkStuRelation4App.MarkerId];
objDR[convcc_WorkStuRelation4App.MarkDate] = objInFor[convcc_WorkStuRelation4App.MarkDate];
objDR[convcc_WorkStuRelation4App.AnswerDate] = objInFor[convcc_WorkStuRelation4App.AnswerDate];
objDR[convcc_WorkStuRelation4App.AnswerTime] = objInFor[convcc_WorkStuRelation4App.AnswerTime];
objDR[convcc_WorkStuRelation4App.IsRight] = objInFor[convcc_WorkStuRelation4App.IsRight];
objDR[convcc_WorkStuRelation4App.ErrMsg] = objInFor[convcc_WorkStuRelation4App.ErrMsg];
objDR[convcc_WorkStuRelation4App.UpdDate] = objInFor[convcc_WorkStuRelation4App.UpdDate];
objDR[convcc_WorkStuRelation4App.UpdUserId] = objInFor[convcc_WorkStuRelation4App.UpdUserId];
objDR[convcc_WorkStuRelation4App.Memo] = objInFor[convcc_WorkStuRelation4App.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}