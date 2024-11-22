
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_ExamPaperEduClsRelaWApi
 表名:cc_ExamPaperEduClsRela(01120233)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:42:53
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
public static class clscc_ExamPaperEduClsRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN SetId_ExamPaperEduClsRela(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, long lngId_ExamPaperEduClsRela, string strComparisonOp="")
	{
objcc_ExamPaperEduClsRelaEN.Id_ExamPaperEduClsRela = lngId_ExamPaperEduClsRela; //作业教学班关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.Id_ExamPaperEduClsRela) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.Id_ExamPaperEduClsRela, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.Id_ExamPaperEduClsRela] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN SetCourseExamPaperId(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseExamPaperId, concc_ExamPaperEduClsRela.CourseExamPaperId);
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, concc_ExamPaperEduClsRela.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, concc_ExamPaperEduClsRela.CourseExamPaperId);
objcc_ExamPaperEduClsRelaEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.CourseExamPaperId) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.CourseExamPaperId, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.CourseExamPaperId] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN Setid_CurrEduCls(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CurrEduCls, concc_ExamPaperEduClsRela.id_CurrEduCls);
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, concc_ExamPaperEduClsRela.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, concc_ExamPaperEduClsRela.id_CurrEduCls);
objcc_ExamPaperEduClsRelaEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.id_CurrEduCls) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.id_CurrEduCls, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.id_CurrEduCls] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN SetScores(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, double dblScores, string strComparisonOp="")
	{
objcc_ExamPaperEduClsRelaEN.Scores = dblScores; //分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.Scores) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.Scores, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.Scores] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN SetTeacherID(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, string strTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherID, concc_ExamPaperEduClsRela.TeacherID);
clsCheckSql.CheckFieldLen(strTeacherID, 12, concc_ExamPaperEduClsRela.TeacherID);
objcc_ExamPaperEduClsRelaEN.TeacherID = strTeacherID; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.TeacherID) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.TeacherID, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.TeacherID] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN SetIsPublish(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, bool bolIsPublish, string strComparisonOp="")
	{
objcc_ExamPaperEduClsRelaEN.IsPublish = bolIsPublish; //是否发布
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.IsPublish) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.IsPublish, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.IsPublish] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN SetPubDate(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, string strPubDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubDate, 14, concc_ExamPaperEduClsRela.PubDate);
objcc_ExamPaperEduClsRelaEN.PubDate = strPubDate; //发布日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.PubDate) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.PubDate, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.PubDate] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN Setpublisher(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, string strpublisher, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strpublisher, 20, concc_ExamPaperEduClsRela.publisher);
objcc_ExamPaperEduClsRelaEN.publisher = strpublisher; //发布者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.publisher) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.publisher, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.publisher] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN SetSpecifyCompletionDate(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, string strSpecifyCompletionDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSpecifyCompletionDate, 14, concc_ExamPaperEduClsRela.SpecifyCompletionDate);
objcc_ExamPaperEduClsRelaEN.SpecifyCompletionDate = strSpecifyCompletionDate; //指定完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.SpecifyCompletionDate) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.SpecifyCompletionDate, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.SpecifyCompletionDate] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN SetIsCurrEduCls(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, bool bolIsCurrEduCls, string strComparisonOp="")
	{
objcc_ExamPaperEduClsRelaEN.IsCurrEduCls = bolIsCurrEduCls; //是否为教学班作业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.IsCurrEduCls) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.IsCurrEduCls, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.IsCurrEduCls] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN SetIsGroupWork(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, bool bolIsGroupWork, string strComparisonOp="")
	{
objcc_ExamPaperEduClsRelaEN.IsGroupWork = bolIsGroupWork; //是否为小组作业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.IsGroupWork) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.IsGroupWork, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.IsGroupWork] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN SetCourseStudentGroupId(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, long lngCourseStudentGroupId, string strComparisonOp="")
	{
objcc_ExamPaperEduClsRelaEN.CourseStudentGroupId = lngCourseStudentGroupId; //学生分组表流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.CourseStudentGroupId) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.CourseStudentGroupId, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.CourseStudentGroupId] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN SetWorkTypeId(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, string strWorkTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkTypeId, concc_ExamPaperEduClsRela.WorkTypeId);
clsCheckSql.CheckFieldLen(strWorkTypeId, 2, concc_ExamPaperEduClsRela.WorkTypeId);
clsCheckSql.CheckFieldForeignKey(strWorkTypeId, 2, concc_ExamPaperEduClsRela.WorkTypeId);
objcc_ExamPaperEduClsRelaEN.WorkTypeId = strWorkTypeId; //作业类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.WorkTypeId) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.WorkTypeId, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.WorkTypeId] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN SetUpdDate(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, concc_ExamPaperEduClsRela.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_ExamPaperEduClsRela.UpdDate);
objcc_ExamPaperEduClsRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.UpdDate) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.UpdDate, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.UpdDate] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN SetUpdUserId(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, concc_ExamPaperEduClsRela.UpdUserId);
objcc_ExamPaperEduClsRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.UpdUserId) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.UpdUserId, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.UpdUserId] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN SetMemo(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_ExamPaperEduClsRela.Memo);
objcc_ExamPaperEduClsRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.Memo) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.Memo, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.Memo] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRela_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_ExamPaperEduClsRela_Cond.IsUpdated(concc_ExamPaperEduClsRela.Id_ExamPaperEduClsRela) == true)
{
string strComparisonOp_Id_ExamPaperEduClsRela = objcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[concc_ExamPaperEduClsRela.Id_ExamPaperEduClsRela];
strWhereCond += string.Format(" And {0} {2} {1}", concc_ExamPaperEduClsRela.Id_ExamPaperEduClsRela, objcc_ExamPaperEduClsRela_Cond.Id_ExamPaperEduClsRela, strComparisonOp_Id_ExamPaperEduClsRela);
}
if (objcc_ExamPaperEduClsRela_Cond.IsUpdated(concc_ExamPaperEduClsRela.CourseExamPaperId) == true)
{
string strComparisonOp_CourseExamPaperId = objcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[concc_ExamPaperEduClsRela.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperEduClsRela.CourseExamPaperId, objcc_ExamPaperEduClsRela_Cond.CourseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (objcc_ExamPaperEduClsRela_Cond.IsUpdated(concc_ExamPaperEduClsRela.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[concc_ExamPaperEduClsRela.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperEduClsRela.id_CurrEduCls, objcc_ExamPaperEduClsRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objcc_ExamPaperEduClsRela_Cond.IsUpdated(concc_ExamPaperEduClsRela.Scores) == true)
{
string strComparisonOp_Scores = objcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[concc_ExamPaperEduClsRela.Scores];
strWhereCond += string.Format(" And {0} {2} {1}", concc_ExamPaperEduClsRela.Scores, objcc_ExamPaperEduClsRela_Cond.Scores, strComparisonOp_Scores);
}
if (objcc_ExamPaperEduClsRela_Cond.IsUpdated(concc_ExamPaperEduClsRela.TeacherID) == true)
{
string strComparisonOp_TeacherID = objcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[concc_ExamPaperEduClsRela.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperEduClsRela.TeacherID, objcc_ExamPaperEduClsRela_Cond.TeacherID, strComparisonOp_TeacherID);
}
if (objcc_ExamPaperEduClsRela_Cond.IsUpdated(concc_ExamPaperEduClsRela.IsPublish) == true)
{
if (objcc_ExamPaperEduClsRela_Cond.IsPublish == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperEduClsRela.IsPublish);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperEduClsRela.IsPublish);
}
}
if (objcc_ExamPaperEduClsRela_Cond.IsUpdated(concc_ExamPaperEduClsRela.PubDate) == true)
{
string strComparisonOp_PubDate = objcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[concc_ExamPaperEduClsRela.PubDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperEduClsRela.PubDate, objcc_ExamPaperEduClsRela_Cond.PubDate, strComparisonOp_PubDate);
}
if (objcc_ExamPaperEduClsRela_Cond.IsUpdated(concc_ExamPaperEduClsRela.publisher) == true)
{
string strComparisonOp_publisher = objcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[concc_ExamPaperEduClsRela.publisher];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperEduClsRela.publisher, objcc_ExamPaperEduClsRela_Cond.publisher, strComparisonOp_publisher);
}
if (objcc_ExamPaperEduClsRela_Cond.IsUpdated(concc_ExamPaperEduClsRela.SpecifyCompletionDate) == true)
{
string strComparisonOp_SpecifyCompletionDate = objcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[concc_ExamPaperEduClsRela.SpecifyCompletionDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperEduClsRela.SpecifyCompletionDate, objcc_ExamPaperEduClsRela_Cond.SpecifyCompletionDate, strComparisonOp_SpecifyCompletionDate);
}
if (objcc_ExamPaperEduClsRela_Cond.IsUpdated(concc_ExamPaperEduClsRela.IsCurrEduCls) == true)
{
if (objcc_ExamPaperEduClsRela_Cond.IsCurrEduCls == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperEduClsRela.IsCurrEduCls);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperEduClsRela.IsCurrEduCls);
}
}
if (objcc_ExamPaperEduClsRela_Cond.IsUpdated(concc_ExamPaperEduClsRela.IsGroupWork) == true)
{
if (objcc_ExamPaperEduClsRela_Cond.IsGroupWork == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperEduClsRela.IsGroupWork);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperEduClsRela.IsGroupWork);
}
}
if (objcc_ExamPaperEduClsRela_Cond.IsUpdated(concc_ExamPaperEduClsRela.CourseStudentGroupId) == true)
{
string strComparisonOp_CourseStudentGroupId = objcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[concc_ExamPaperEduClsRela.CourseStudentGroupId];
strWhereCond += string.Format(" And {0} {2} {1}", concc_ExamPaperEduClsRela.CourseStudentGroupId, objcc_ExamPaperEduClsRela_Cond.CourseStudentGroupId, strComparisonOp_CourseStudentGroupId);
}
if (objcc_ExamPaperEduClsRela_Cond.IsUpdated(concc_ExamPaperEduClsRela.WorkTypeId) == true)
{
string strComparisonOp_WorkTypeId = objcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[concc_ExamPaperEduClsRela.WorkTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperEduClsRela.WorkTypeId, objcc_ExamPaperEduClsRela_Cond.WorkTypeId, strComparisonOp_WorkTypeId);
}
if (objcc_ExamPaperEduClsRela_Cond.IsUpdated(concc_ExamPaperEduClsRela.UpdDate) == true)
{
string strComparisonOp_UpdDate = objcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[concc_ExamPaperEduClsRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperEduClsRela.UpdDate, objcc_ExamPaperEduClsRela_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objcc_ExamPaperEduClsRela_Cond.IsUpdated(concc_ExamPaperEduClsRela.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[concc_ExamPaperEduClsRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperEduClsRela.UpdUserId, objcc_ExamPaperEduClsRela_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objcc_ExamPaperEduClsRela_Cond.IsUpdated(concc_ExamPaperEduClsRela.Memo) == true)
{
string strComparisonOp_Memo = objcc_ExamPaperEduClsRela_Cond.dicFldComparisonOp[concc_ExamPaperEduClsRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperEduClsRela.Memo, objcc_ExamPaperEduClsRela_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN)
{
 if (objcc_ExamPaperEduClsRelaEN.Id_ExamPaperEduClsRela == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objcc_ExamPaperEduClsRelaEN.sf_UpdFldSetStr = objcc_ExamPaperEduClsRelaEN.getsf_UpdFldSetStr();
clscc_ExamPaperEduClsRelaWApi.CheckPropertyNew(objcc_ExamPaperEduClsRelaEN); 
bool bolResult = clscc_ExamPaperEduClsRelaWApi.UpdateRecord(objcc_ExamPaperEduClsRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperEduClsRelaWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--cc_ExamPaperEduClsRela(考卷教学班关系), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_CourseExamPaperId_id_CurrEduCls(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_ExamPaperEduClsRelaEN == null) return "";
if (objcc_ExamPaperEduClsRelaEN.Id_ExamPaperEduClsRela == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_ExamPaperEduClsRelaEN.CourseExamPaperId);
 sbCondition.AppendFormat(" and id_CurrEduCls = '{0}'", objcc_ExamPaperEduClsRelaEN.id_CurrEduCls);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("Id_ExamPaperEduClsRela !=  {0}", objcc_ExamPaperEduClsRelaEN.Id_ExamPaperEduClsRela);
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_ExamPaperEduClsRelaEN.CourseExamPaperId);
 sbCondition.AppendFormat(" and id_CurrEduCls = '{0}'", objcc_ExamPaperEduClsRelaEN.id_CurrEduCls);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN)
{
try
{
clscc_ExamPaperEduClsRelaWApi.CheckPropertyNew(objcc_ExamPaperEduClsRelaEN); 
bool bolResult = clscc_ExamPaperEduClsRelaWApi.AddNewRecord(objcc_ExamPaperEduClsRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperEduClsRelaWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, string strWhereCond)
{
try
{
clscc_ExamPaperEduClsRelaWApi.CheckPropertyNew(objcc_ExamPaperEduClsRelaEN); 
bool bolResult = clscc_ExamPaperEduClsRelaWApi.UpdateWithCondition(objcc_ExamPaperEduClsRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperEduClsRelaWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 考卷教学班关系(cc_ExamPaperEduClsRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clscc_ExamPaperEduClsRelaWApi
{
private static readonly string mstrApiControllerName = "cc_ExamPaperEduClsRelaApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clscc_ExamPaperEduClsRelaWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN)
{
if (!Object.Equals(null, objcc_ExamPaperEduClsRelaEN.CourseExamPaperId) && GetStrLen(objcc_ExamPaperEduClsRelaEN.CourseExamPaperId) > 8)
{
 throw new Exception("字段[考卷流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_ExamPaperEduClsRelaEN.id_CurrEduCls) && GetStrLen(objcc_ExamPaperEduClsRelaEN.id_CurrEduCls) > 8)
{
 throw new Exception("字段[当前教学班流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_ExamPaperEduClsRelaEN.TeacherID) && GetStrLen(objcc_ExamPaperEduClsRelaEN.TeacherID) > 12)
{
 throw new Exception("字段[教师工号]的长度不能超过12!");
}
if (!Object.Equals(null, objcc_ExamPaperEduClsRelaEN.PubDate) && GetStrLen(objcc_ExamPaperEduClsRelaEN.PubDate) > 14)
{
 throw new Exception("字段[发布日期]的长度不能超过14!");
}
if (!Object.Equals(null, objcc_ExamPaperEduClsRelaEN.publisher) && GetStrLen(objcc_ExamPaperEduClsRelaEN.publisher) > 20)
{
 throw new Exception("字段[发布者Id]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_ExamPaperEduClsRelaEN.SpecifyCompletionDate) && GetStrLen(objcc_ExamPaperEduClsRelaEN.SpecifyCompletionDate) > 14)
{
 throw new Exception("字段[指定完成日期]的长度不能超过14!");
}
if (!Object.Equals(null, objcc_ExamPaperEduClsRelaEN.WorkTypeId) && GetStrLen(objcc_ExamPaperEduClsRelaEN.WorkTypeId) > 2)
{
 throw new Exception("字段[作业类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objcc_ExamPaperEduClsRelaEN.UpdDate) && GetStrLen(objcc_ExamPaperEduClsRelaEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_ExamPaperEduClsRelaEN.UpdUserId) && GetStrLen(objcc_ExamPaperEduClsRelaEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_ExamPaperEduClsRelaEN.Memo) && GetStrLen(objcc_ExamPaperEduClsRelaEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objcc_ExamPaperEduClsRelaEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_ExamPaperEduClsRela">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_ExamPaperEduClsRelaEN GetObjById_ExamPaperEduClsRela(long lngId_ExamPaperEduClsRela)
{
string strAction = "GetObjById_ExamPaperEduClsRela";
string strErrMsg = string.Empty;
string strResult = "";
clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_ExamPaperEduClsRela"] = lngId_ExamPaperEduClsRela.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_ExamPaperEduClsRelaEN = JsonConvert.DeserializeObject<clscc_ExamPaperEduClsRelaEN>((string)jobjReturn["ReturnObj"]);
return objcc_ExamPaperEduClsRelaEN;
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
 /// <param name = "lngId_ExamPaperEduClsRela">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_ExamPaperEduClsRelaEN GetObjById_ExamPaperEduClsRela_WA_Cache(long lngId_ExamPaperEduClsRela)
{
string strAction = "GetObjById_ExamPaperEduClsRela_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_ExamPaperEduClsRela"] = lngId_ExamPaperEduClsRela.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_ExamPaperEduClsRelaEN = JsonConvert.DeserializeObject<clscc_ExamPaperEduClsRelaEN>((string)jobjReturn["ReturnObj"]);
return objcc_ExamPaperEduClsRelaEN;
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
public static clscc_ExamPaperEduClsRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN = null;
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
objcc_ExamPaperEduClsRelaEN = JsonConvert.DeserializeObject<clscc_ExamPaperEduClsRelaEN>((string)jobjReturn["ReturnObj"]);
return objcc_ExamPaperEduClsRelaEN;
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
 /// <param name = "lngId_ExamPaperEduClsRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_ExamPaperEduClsRelaEN GetObjById_ExamPaperEduClsRela_Cache(long lngId_ExamPaperEduClsRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clscc_ExamPaperEduClsRelaEN._CurrTabName_S);
List<clscc_ExamPaperEduClsRelaEN> arrcc_ExamPaperEduClsRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_ExamPaperEduClsRelaEN> arrcc_ExamPaperEduClsRelaObjLst_Sel =
from objcc_ExamPaperEduClsRelaEN in arrcc_ExamPaperEduClsRelaObjLst_Cache
where objcc_ExamPaperEduClsRelaEN.Id_ExamPaperEduClsRela == lngId_ExamPaperEduClsRela
select objcc_ExamPaperEduClsRelaEN;
if (arrcc_ExamPaperEduClsRelaObjLst_Sel.Count() == 0)
{
   clscc_ExamPaperEduClsRelaEN obj = clscc_ExamPaperEduClsRelaWApi.GetObjById_ExamPaperEduClsRela(lngId_ExamPaperEduClsRela);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrcc_ExamPaperEduClsRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_ExamPaperEduClsRelaEN> GetObjLst(string strWhereCond)
{
 List<clscc_ExamPaperEduClsRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExamPaperEduClsRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_ExamPaperEduClsRelaEN> GetObjLstById_ExamPaperEduClsRelaLst(List<long> arrId_ExamPaperEduClsRela)
{
 List<clscc_ExamPaperEduClsRelaEN> arrObjLst = null; 
string strAction = "GetObjLstById_ExamPaperEduClsRelaLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_ExamPaperEduClsRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExamPaperEduClsRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngId_ExamPaperEduClsRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clscc_ExamPaperEduClsRelaEN> GetObjLstById_ExamPaperEduClsRelaLst_Cache(List<long> arrId_ExamPaperEduClsRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clscc_ExamPaperEduClsRelaEN._CurrTabName_S);
List<clscc_ExamPaperEduClsRelaEN> arrcc_ExamPaperEduClsRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_ExamPaperEduClsRelaEN> arrcc_ExamPaperEduClsRelaObjLst_Sel =
from objcc_ExamPaperEduClsRelaEN in arrcc_ExamPaperEduClsRelaObjLst_Cache
where arrId_ExamPaperEduClsRela.Contains(objcc_ExamPaperEduClsRelaEN.Id_ExamPaperEduClsRela)
select objcc_ExamPaperEduClsRelaEN;
return arrcc_ExamPaperEduClsRelaObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_ExamPaperEduClsRelaEN> GetObjLstById_ExamPaperEduClsRelaLst_WA_Cache(List<long> arrId_ExamPaperEduClsRela)
{
 List<clscc_ExamPaperEduClsRelaEN> arrObjLst = null; 
string strAction = "GetObjLstById_ExamPaperEduClsRelaLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_ExamPaperEduClsRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExamPaperEduClsRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_ExamPaperEduClsRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clscc_ExamPaperEduClsRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExamPaperEduClsRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_ExamPaperEduClsRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clscc_ExamPaperEduClsRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExamPaperEduClsRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_ExamPaperEduClsRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clscc_ExamPaperEduClsRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExamPaperEduClsRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_ExamPaperEduClsRelaEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clscc_ExamPaperEduClsRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExamPaperEduClsRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(long lngId_ExamPaperEduClsRela)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN = clscc_ExamPaperEduClsRelaWApi.GetObjById_ExamPaperEduClsRela(lngId_ExamPaperEduClsRela);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngId_ExamPaperEduClsRela.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_ExamPaperEduClsRelaWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int Delcc_ExamPaperEduClsRelas(List<string> arrId_ExamPaperEduClsRela)
{
string strAction = "Delcc_ExamPaperEduClsRelas";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_ExamPaperEduClsRela);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_ExamPaperEduClsRelaWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int Delcc_ExamPaperEduClsRelasByCond(string strWhereCond)
{
string strAction = "Delcc_ExamPaperEduClsRelasByCond";
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_ExamPaperEduClsRelaEN>(objcc_ExamPaperEduClsRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperEduClsRelaWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_ExamPaperEduClsRelaEN>(objcc_ExamPaperEduClsRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperEduClsRelaWApi.ReFreshCache();
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN)
{
if (string.IsNullOrEmpty(objcc_ExamPaperEduClsRelaEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_ExamPaperEduClsRelaEN.Id_ExamPaperEduClsRela, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_ExamPaperEduClsRelaEN>(objcc_ExamPaperEduClsRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objcc_ExamPaperEduClsRelaEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_ExamPaperEduClsRelaEN.Id_ExamPaperEduClsRela, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_ExamPaperEduClsRelaEN.Id_ExamPaperEduClsRela, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_ExamPaperEduClsRelaEN>(objcc_ExamPaperEduClsRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
public static bool IsExist(long lngId_ExamPaperEduClsRela)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_ExamPaperEduClsRela"] = lngId_ExamPaperEduClsRela.ToString()
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaENS">源对象</param>
 /// <param name = "objcc_ExamPaperEduClsRelaENT">目标对象</param>
 public static void CopyTo(clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaENS, clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaENT)
{
try
{
objcc_ExamPaperEduClsRelaENT.Id_ExamPaperEduClsRela = objcc_ExamPaperEduClsRelaENS.Id_ExamPaperEduClsRela; //作业教学班关系流水号
objcc_ExamPaperEduClsRelaENT.CourseExamPaperId = objcc_ExamPaperEduClsRelaENS.CourseExamPaperId; //考卷流水号
objcc_ExamPaperEduClsRelaENT.id_CurrEduCls = objcc_ExamPaperEduClsRelaENS.id_CurrEduCls; //当前教学班流水号
objcc_ExamPaperEduClsRelaENT.Scores = objcc_ExamPaperEduClsRelaENS.Scores; //分值
objcc_ExamPaperEduClsRelaENT.TeacherID = objcc_ExamPaperEduClsRelaENS.TeacherID; //教师工号
objcc_ExamPaperEduClsRelaENT.IsPublish = objcc_ExamPaperEduClsRelaENS.IsPublish; //是否发布
objcc_ExamPaperEduClsRelaENT.PubDate = objcc_ExamPaperEduClsRelaENS.PubDate; //发布日期
objcc_ExamPaperEduClsRelaENT.publisher = objcc_ExamPaperEduClsRelaENS.publisher; //发布者Id
objcc_ExamPaperEduClsRelaENT.SpecifyCompletionDate = objcc_ExamPaperEduClsRelaENS.SpecifyCompletionDate; //指定完成日期
objcc_ExamPaperEduClsRelaENT.IsCurrEduCls = objcc_ExamPaperEduClsRelaENS.IsCurrEduCls; //是否为教学班作业
objcc_ExamPaperEduClsRelaENT.IsGroupWork = objcc_ExamPaperEduClsRelaENS.IsGroupWork; //是否为小组作业
objcc_ExamPaperEduClsRelaENT.CourseStudentGroupId = objcc_ExamPaperEduClsRelaENS.CourseStudentGroupId; //学生分组表流水号
objcc_ExamPaperEduClsRelaENT.WorkTypeId = objcc_ExamPaperEduClsRelaENS.WorkTypeId; //作业类型Id
objcc_ExamPaperEduClsRelaENT.UpdDate = objcc_ExamPaperEduClsRelaENS.UpdDate; //修改日期
objcc_ExamPaperEduClsRelaENT.UpdUserId = objcc_ExamPaperEduClsRelaENS.UpdUserId; //修改用户Id
objcc_ExamPaperEduClsRelaENT.Memo = objcc_ExamPaperEduClsRelaENS.Memo; //备注
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
public static DataTable ToDataTable(List<clscc_ExamPaperEduClsRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clscc_ExamPaperEduClsRelaEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clscc_ExamPaperEduClsRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clscc_ExamPaperEduClsRelaEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clscc_ExamPaperEduClsRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clscc_ExamPaperEduClsRelaEN.AttributeName)
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
if (clscc_ExamPaperEduClsRelaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamPaperEduClsRelaWApi没有刷新缓存机制(clscc_ExamPaperEduClsRelaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_ExamPaperEduClsRela");
//if (arrcc_ExamPaperEduClsRelaObjLst_Cache == null)
//{
//arrcc_ExamPaperEduClsRelaObjLst_Cache = await clscc_ExamPaperEduClsRelaWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clscc_ExamPaperEduClsRelaEN._CurrTabName_S);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clscc_ExamPaperEduClsRelaWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscc_ExamPaperEduClsRelaEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clscc_ExamPaperEduClsRelaWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_ExamPaperEduClsRelaEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clscc_ExamPaperEduClsRelaEN._CurrTabName_S);
List<clscc_ExamPaperEduClsRelaEN> arrcc_ExamPaperEduClsRelaObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcc_ExamPaperEduClsRelaObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clscc_ExamPaperEduClsRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(concc_ExamPaperEduClsRela.Id_ExamPaperEduClsRela, Type.GetType("System.Int64"));
objDT.Columns.Add(concc_ExamPaperEduClsRela.CourseExamPaperId, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperEduClsRela.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperEduClsRela.Scores, Type.GetType("System.Decimal"));
objDT.Columns.Add(concc_ExamPaperEduClsRela.TeacherID, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperEduClsRela.IsPublish, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_ExamPaperEduClsRela.PubDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperEduClsRela.publisher, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperEduClsRela.SpecifyCompletionDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperEduClsRela.IsCurrEduCls, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_ExamPaperEduClsRela.IsGroupWork, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_ExamPaperEduClsRela.CourseStudentGroupId, Type.GetType("System.Int64"));
objDT.Columns.Add(concc_ExamPaperEduClsRela.WorkTypeId, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperEduClsRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperEduClsRela.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperEduClsRela.Memo, Type.GetType("System.String"));
foreach (clscc_ExamPaperEduClsRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[concc_ExamPaperEduClsRela.Id_ExamPaperEduClsRela] = objInFor[concc_ExamPaperEduClsRela.Id_ExamPaperEduClsRela];
objDR[concc_ExamPaperEduClsRela.CourseExamPaperId] = objInFor[concc_ExamPaperEduClsRela.CourseExamPaperId];
objDR[concc_ExamPaperEduClsRela.id_CurrEduCls] = objInFor[concc_ExamPaperEduClsRela.id_CurrEduCls];
objDR[concc_ExamPaperEduClsRela.Scores] = objInFor[concc_ExamPaperEduClsRela.Scores];
objDR[concc_ExamPaperEduClsRela.TeacherID] = objInFor[concc_ExamPaperEduClsRela.TeacherID];
objDR[concc_ExamPaperEduClsRela.IsPublish] = objInFor[concc_ExamPaperEduClsRela.IsPublish];
objDR[concc_ExamPaperEduClsRela.PubDate] = objInFor[concc_ExamPaperEduClsRela.PubDate];
objDR[concc_ExamPaperEduClsRela.publisher] = objInFor[concc_ExamPaperEduClsRela.publisher];
objDR[concc_ExamPaperEduClsRela.SpecifyCompletionDate] = objInFor[concc_ExamPaperEduClsRela.SpecifyCompletionDate];
objDR[concc_ExamPaperEduClsRela.IsCurrEduCls] = objInFor[concc_ExamPaperEduClsRela.IsCurrEduCls];
objDR[concc_ExamPaperEduClsRela.IsGroupWork] = objInFor[concc_ExamPaperEduClsRela.IsGroupWork];
objDR[concc_ExamPaperEduClsRela.CourseStudentGroupId] = objInFor[concc_ExamPaperEduClsRela.CourseStudentGroupId];
objDR[concc_ExamPaperEduClsRela.WorkTypeId] = objInFor[concc_ExamPaperEduClsRela.WorkTypeId];
objDR[concc_ExamPaperEduClsRela.UpdDate] = objInFor[concc_ExamPaperEduClsRela.UpdDate];
objDR[concc_ExamPaperEduClsRela.UpdUserId] = objInFor[concc_ExamPaperEduClsRela.UpdUserId];
objDR[concc_ExamPaperEduClsRela.Memo] = objInFor[concc_ExamPaperEduClsRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 考卷教学班关系(cc_ExamPaperEduClsRela)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4cc_ExamPaperEduClsRela : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperEduClsRelaWApi.ReFreshThisCache();
clsvcc_ExamPaperEduClsRelaWApi.ReFreshThisCache();
clsvcc_ExamPaperEduClsRela4AppWApi.ReFreshThisCache();
}
}

}