
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_ExamPaperStuRelationWApi
 表名:cc_ExamPaperStuRelation(01120235)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:37:41
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
public static class clscc_ExamPaperStuRelationWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetId_ExamPaperStuRelation(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, long lngId_ExamPaperStuRelation, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.Id_ExamPaperStuRelation = lngId_ExamPaperStuRelation; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.Id_ExamPaperStuRelation) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.Id_ExamPaperStuRelation, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.Id_ExamPaperStuRelation] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetCourseExamPaperId(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, concc_ExamPaperStuRelation.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, concc_ExamPaperStuRelation.CourseExamPaperId);
objcc_ExamPaperStuRelationEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.CourseExamPaperId) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.CourseExamPaperId, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.CourseExamPaperId] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN Setid_CurrEduCls(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CurrEduCls, concc_ExamPaperStuRelation.id_CurrEduCls);
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, concc_ExamPaperStuRelation.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, concc_ExamPaperStuRelation.id_CurrEduCls);
objcc_ExamPaperStuRelationEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.id_CurrEduCls) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.id_CurrEduCls, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.id_CurrEduCls] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetScores(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, double dblScores, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.Scores = dblScores; //分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.Scores) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.Scores, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.Scores] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetSpecifyCompletionDate(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strSpecifyCompletionDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSpecifyCompletionDate, concc_ExamPaperStuRelation.SpecifyCompletionDate);
clsCheckSql.CheckFieldLen(strSpecifyCompletionDate, 14, concc_ExamPaperStuRelation.SpecifyCompletionDate);
objcc_ExamPaperStuRelationEN.SpecifyCompletionDate = strSpecifyCompletionDate; //指定完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.SpecifyCompletionDate) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.SpecifyCompletionDate, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.SpecifyCompletionDate] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN Setid_StudentInfo(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudentInfo, concc_ExamPaperStuRelation.id_StudentInfo);
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, concc_ExamPaperStuRelation.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, concc_ExamPaperStuRelation.id_StudentInfo);
objcc_ExamPaperStuRelationEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.id_StudentInfo) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.id_StudentInfo, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.id_StudentInfo] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetAnswerModeId(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strAnswerModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, concc_ExamPaperStuRelation.AnswerModeId);
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, concc_ExamPaperStuRelation.AnswerModeId);
objcc_ExamPaperStuRelationEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.AnswerModeId) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.AnswerModeId, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.AnswerModeId] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetAnswerOptionId(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strAnswerOptionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerOptionId, 8, concc_ExamPaperStuRelation.AnswerOptionId);
clsCheckSql.CheckFieldForeignKey(strAnswerOptionId, 8, concc_ExamPaperStuRelation.AnswerOptionId);
objcc_ExamPaperStuRelationEN.AnswerOptionId = strAnswerOptionId; //回答选项Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.AnswerOptionId) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.AnswerOptionId, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.AnswerOptionId] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetAnswerMultiOptions(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strAnswerMultiOptions, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerMultiOptions, 300, concc_ExamPaperStuRelation.AnswerMultiOptions);
objcc_ExamPaperStuRelationEN.AnswerMultiOptions = strAnswerMultiOptions; //多选项答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.AnswerMultiOptions) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.AnswerMultiOptions, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.AnswerMultiOptions] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetStuAnswerText(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strStuAnswerText, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.StuAnswerText = strStuAnswerText; //学生回答文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.StuAnswerText) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.StuAnswerText, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.StuAnswerText] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetIsPublish(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, bool bolIsPublish, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.IsPublish = bolIsPublish; //是否发布
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.IsPublish) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.IsPublish, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.IsPublish] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetIsLook(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, bool bolIsLook, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.IsLook = bolIsLook; //是否查看
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.IsLook) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.IsLook, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.IsLook] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetIsSave(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, bool bolIsSave, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.IsSave = bolIsSave; //是否保存
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.IsSave) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.IsSave, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.IsSave] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetIsSubmit(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, bool bolIsSubmit, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.IsSubmit) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.IsSubmit, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.IsSubmit] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetApplySendBackDate(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strApplySendBackDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplySendBackDate, 14, concc_ExamPaperStuRelation.ApplySendBackDate);
objcc_ExamPaperStuRelationEN.ApplySendBackDate = strApplySendBackDate; //申请退回日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.ApplySendBackDate) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.ApplySendBackDate, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.ApplySendBackDate] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetIsApplySendBack(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, bool bolIsApplySendBack, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.IsApplySendBack = bolIsApplySendBack; //是否申请退回
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.IsApplySendBack) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.IsApplySendBack, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.IsApplySendBack] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetRealFinishDate(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strRealFinishDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRealFinishDate, 14, concc_ExamPaperStuRelation.RealFinishDate);
objcc_ExamPaperStuRelationEN.RealFinishDate = strRealFinishDate; //实际完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.RealFinishDate) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.RealFinishDate, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.RealFinishDate] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetOperateTime(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strOperateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOperateTime, 14, concc_ExamPaperStuRelation.OperateTime);
objcc_ExamPaperStuRelationEN.OperateTime = strOperateTime; //操作时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.OperateTime) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.OperateTime, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.OperateTime] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetScore(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, double dblScore, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.Score = dblScore; //得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.Score) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.Score, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.Score] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetComment(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strComment, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.Comment = strComment; //批注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.Comment) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.Comment, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.Comment] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetIsMarking(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, bool bolIsMarking, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.IsMarking = bolIsMarking; //是否批阅
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.IsMarking) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.IsMarking, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.IsMarking] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetMarkerId(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strMarkerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkerId, 20, concc_ExamPaperStuRelation.MarkerId);
objcc_ExamPaperStuRelationEN.MarkerId = strMarkerId; //打分者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.MarkerId) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.MarkerId, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.MarkerId] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetMarkDate(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strMarkDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkDate, 14, concc_ExamPaperStuRelation.MarkDate);
objcc_ExamPaperStuRelationEN.MarkDate = strMarkDate; //打分日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.MarkDate) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.MarkDate, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.MarkDate] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetIsSendBack(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, bool bolIsSendBack, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.IsSendBack = bolIsSendBack; //是否退回
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.IsSendBack) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.IsSendBack, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.IsSendBack] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetIsInErrorQuestion(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, bool bolIsInErrorQuestion, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.IsInErrorQuestion = bolIsInErrorQuestion; //是否进入错题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.IsInErrorQuestion) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.IsInErrorQuestion, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.IsInErrorQuestion] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetWorkTypeId(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strWorkTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkTypeId, concc_ExamPaperStuRelation.WorkTypeId);
clsCheckSql.CheckFieldLen(strWorkTypeId, 2, concc_ExamPaperStuRelation.WorkTypeId);
clsCheckSql.CheckFieldForeignKey(strWorkTypeId, 2, concc_ExamPaperStuRelation.WorkTypeId);
objcc_ExamPaperStuRelationEN.WorkTypeId = strWorkTypeId; //作业类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.WorkTypeId) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.WorkTypeId, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.WorkTypeId] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetAnswerIP(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strAnswerIP, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerIP, 30, concc_ExamPaperStuRelation.AnswerIP);
objcc_ExamPaperStuRelationEN.AnswerIP = strAnswerIP; //回答IP
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.AnswerIP) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.AnswerIP, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.AnswerIP] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetAnswerDate(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strAnswerDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerDate, 8, concc_ExamPaperStuRelation.AnswerDate);
objcc_ExamPaperStuRelationEN.AnswerDate = strAnswerDate; //回答日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.AnswerDate) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.AnswerDate, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.AnswerDate] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetAnswerTime(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strAnswerTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTime, 10, concc_ExamPaperStuRelation.AnswerTime);
objcc_ExamPaperStuRelationEN.AnswerTime = strAnswerTime; //回答时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.AnswerTime) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.AnswerTime, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.AnswerTime] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetIsRight(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, bool bolIsRight, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.IsRight = bolIsRight; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.IsRight) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.IsRight, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.IsRight] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetIsAccessKnowledge(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, bool bolIsAccessKnowledge, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.IsAccessKnowledge = bolIsAccessKnowledge; //是否处理知识点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.IsAccessKnowledge) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.IsAccessKnowledge, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.IsAccessKnowledge] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetIsNotProcessTimeout(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, bool bolIsNotProcessTimeout, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.IsNotProcessTimeout = bolIsNotProcessTimeout; //是否不处理超时
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.IsNotProcessTimeout) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.IsNotProcessTimeout, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.IsNotProcessTimeout] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetSchoolYear(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strSchoolYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, concc_ExamPaperStuRelation.SchoolYear);
objcc_ExamPaperStuRelationEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.SchoolYear) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.SchoolYear, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.SchoolYear] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetSchoolTerm(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, concc_ExamPaperStuRelation.SchoolTerm);
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, concc_ExamPaperStuRelation.SchoolTerm);
objcc_ExamPaperStuRelationEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.SchoolTerm) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.SchoolTerm, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.SchoolTerm] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetUpdDate(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, concc_ExamPaperStuRelation.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_ExamPaperStuRelation.UpdDate);
objcc_ExamPaperStuRelationEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.UpdDate) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.UpdDate, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.UpdDate] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetUpdUserId(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, concc_ExamPaperStuRelation.UpdUserId);
objcc_ExamPaperStuRelationEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.UpdUserId) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.UpdUserId, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.UpdUserId] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetMemo(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_ExamPaperStuRelation.Memo);
objcc_ExamPaperStuRelationEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.Memo) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.Memo, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.Memo] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelation_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.Id_ExamPaperStuRelation) == true)
{
string strComparisonOp_Id_ExamPaperStuRelation = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[concc_ExamPaperStuRelation.Id_ExamPaperStuRelation];
strWhereCond += string.Format(" And {0} {2} {1}", concc_ExamPaperStuRelation.Id_ExamPaperStuRelation, objcc_ExamPaperStuRelation_Cond.Id_ExamPaperStuRelation, strComparisonOp_Id_ExamPaperStuRelation);
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.CourseExamPaperId) == true)
{
string strComparisonOp_CourseExamPaperId = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[concc_ExamPaperStuRelation.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.CourseExamPaperId, objcc_ExamPaperStuRelation_Cond.CourseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[concc_ExamPaperStuRelation.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.id_CurrEduCls, objcc_ExamPaperStuRelation_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.Scores) == true)
{
string strComparisonOp_Scores = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[concc_ExamPaperStuRelation.Scores];
strWhereCond += string.Format(" And {0} {2} {1}", concc_ExamPaperStuRelation.Scores, objcc_ExamPaperStuRelation_Cond.Scores, strComparisonOp_Scores);
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.SpecifyCompletionDate) == true)
{
string strComparisonOp_SpecifyCompletionDate = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[concc_ExamPaperStuRelation.SpecifyCompletionDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.SpecifyCompletionDate, objcc_ExamPaperStuRelation_Cond.SpecifyCompletionDate, strComparisonOp_SpecifyCompletionDate);
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[concc_ExamPaperStuRelation.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.id_StudentInfo, objcc_ExamPaperStuRelation_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.AnswerModeId) == true)
{
string strComparisonOp_AnswerModeId = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[concc_ExamPaperStuRelation.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.AnswerModeId, objcc_ExamPaperStuRelation_Cond.AnswerModeId, strComparisonOp_AnswerModeId);
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.AnswerOptionId) == true)
{
string strComparisonOp_AnswerOptionId = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[concc_ExamPaperStuRelation.AnswerOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.AnswerOptionId, objcc_ExamPaperStuRelation_Cond.AnswerOptionId, strComparisonOp_AnswerOptionId);
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.AnswerMultiOptions) == true)
{
string strComparisonOp_AnswerMultiOptions = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[concc_ExamPaperStuRelation.AnswerMultiOptions];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.AnswerMultiOptions, objcc_ExamPaperStuRelation_Cond.AnswerMultiOptions, strComparisonOp_AnswerMultiOptions);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.IsPublish) == true)
{
if (objcc_ExamPaperStuRelation_Cond.IsPublish == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperStuRelation.IsPublish);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperStuRelation.IsPublish);
}
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.IsLook) == true)
{
if (objcc_ExamPaperStuRelation_Cond.IsLook == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperStuRelation.IsLook);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperStuRelation.IsLook);
}
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.IsSave) == true)
{
if (objcc_ExamPaperStuRelation_Cond.IsSave == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperStuRelation.IsSave);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperStuRelation.IsSave);
}
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.IsSubmit) == true)
{
if (objcc_ExamPaperStuRelation_Cond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperStuRelation.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperStuRelation.IsSubmit);
}
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.ApplySendBackDate) == true)
{
string strComparisonOp_ApplySendBackDate = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[concc_ExamPaperStuRelation.ApplySendBackDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.ApplySendBackDate, objcc_ExamPaperStuRelation_Cond.ApplySendBackDate, strComparisonOp_ApplySendBackDate);
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.IsApplySendBack) == true)
{
if (objcc_ExamPaperStuRelation_Cond.IsApplySendBack == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperStuRelation.IsApplySendBack);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperStuRelation.IsApplySendBack);
}
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.RealFinishDate) == true)
{
string strComparisonOp_RealFinishDate = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[concc_ExamPaperStuRelation.RealFinishDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.RealFinishDate, objcc_ExamPaperStuRelation_Cond.RealFinishDate, strComparisonOp_RealFinishDate);
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.OperateTime) == true)
{
string strComparisonOp_OperateTime = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[concc_ExamPaperStuRelation.OperateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.OperateTime, objcc_ExamPaperStuRelation_Cond.OperateTime, strComparisonOp_OperateTime);
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.Score) == true)
{
string strComparisonOp_Score = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[concc_ExamPaperStuRelation.Score];
strWhereCond += string.Format(" And {0} {2} {1}", concc_ExamPaperStuRelation.Score, objcc_ExamPaperStuRelation_Cond.Score, strComparisonOp_Score);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.IsMarking) == true)
{
if (objcc_ExamPaperStuRelation_Cond.IsMarking == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperStuRelation.IsMarking);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperStuRelation.IsMarking);
}
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.MarkerId) == true)
{
string strComparisonOp_MarkerId = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[concc_ExamPaperStuRelation.MarkerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.MarkerId, objcc_ExamPaperStuRelation_Cond.MarkerId, strComparisonOp_MarkerId);
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.MarkDate) == true)
{
string strComparisonOp_MarkDate = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[concc_ExamPaperStuRelation.MarkDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.MarkDate, objcc_ExamPaperStuRelation_Cond.MarkDate, strComparisonOp_MarkDate);
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.IsSendBack) == true)
{
if (objcc_ExamPaperStuRelation_Cond.IsSendBack == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperStuRelation.IsSendBack);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperStuRelation.IsSendBack);
}
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.IsInErrorQuestion) == true)
{
if (objcc_ExamPaperStuRelation_Cond.IsInErrorQuestion == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperStuRelation.IsInErrorQuestion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperStuRelation.IsInErrorQuestion);
}
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.WorkTypeId) == true)
{
string strComparisonOp_WorkTypeId = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[concc_ExamPaperStuRelation.WorkTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.WorkTypeId, objcc_ExamPaperStuRelation_Cond.WorkTypeId, strComparisonOp_WorkTypeId);
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.AnswerIP) == true)
{
string strComparisonOp_AnswerIP = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[concc_ExamPaperStuRelation.AnswerIP];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.AnswerIP, objcc_ExamPaperStuRelation_Cond.AnswerIP, strComparisonOp_AnswerIP);
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.AnswerDate) == true)
{
string strComparisonOp_AnswerDate = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[concc_ExamPaperStuRelation.AnswerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.AnswerDate, objcc_ExamPaperStuRelation_Cond.AnswerDate, strComparisonOp_AnswerDate);
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.AnswerTime) == true)
{
string strComparisonOp_AnswerTime = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[concc_ExamPaperStuRelation.AnswerTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.AnswerTime, objcc_ExamPaperStuRelation_Cond.AnswerTime, strComparisonOp_AnswerTime);
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.IsRight) == true)
{
if (objcc_ExamPaperStuRelation_Cond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperStuRelation.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperStuRelation.IsRight);
}
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.IsAccessKnowledge) == true)
{
if (objcc_ExamPaperStuRelation_Cond.IsAccessKnowledge == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperStuRelation.IsAccessKnowledge);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperStuRelation.IsAccessKnowledge);
}
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.IsNotProcessTimeout) == true)
{
if (objcc_ExamPaperStuRelation_Cond.IsNotProcessTimeout == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperStuRelation.IsNotProcessTimeout);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperStuRelation.IsNotProcessTimeout);
}
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.SchoolYear) == true)
{
string strComparisonOp_SchoolYear = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[concc_ExamPaperStuRelation.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.SchoolYear, objcc_ExamPaperStuRelation_Cond.SchoolYear, strComparisonOp_SchoolYear);
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.SchoolTerm) == true)
{
string strComparisonOp_SchoolTerm = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[concc_ExamPaperStuRelation.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.SchoolTerm, objcc_ExamPaperStuRelation_Cond.SchoolTerm, strComparisonOp_SchoolTerm);
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.UpdDate) == true)
{
string strComparisonOp_UpdDate = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[concc_ExamPaperStuRelation.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.UpdDate, objcc_ExamPaperStuRelation_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[concc_ExamPaperStuRelation.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.UpdUserId, objcc_ExamPaperStuRelation_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objcc_ExamPaperStuRelation_Cond.IsUpdated(concc_ExamPaperStuRelation.Memo) == true)
{
string strComparisonOp_Memo = objcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[concc_ExamPaperStuRelation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.Memo, objcc_ExamPaperStuRelation_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
 if (objcc_ExamPaperStuRelationEN.Id_ExamPaperStuRelation == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objcc_ExamPaperStuRelationEN.sf_UpdFldSetStr = objcc_ExamPaperStuRelationEN.getsf_UpdFldSetStr();
clscc_ExamPaperStuRelationWApi.CheckPropertyNew(objcc_ExamPaperStuRelationEN); 
bool bolResult = clscc_ExamPaperStuRelationWApi.UpdateRecord(objcc_ExamPaperStuRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuRelationWApi.ReFreshCache(objcc_ExamPaperStuRelationEN.id_CurrEduCls);
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
 /// 检查唯一性(Uniqueness)--cc_ExamPaperStuRelation(考卷与学生关系), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_CourseExamPaperId_id_StudentInfo_id_CurrEduCls(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_ExamPaperStuRelationEN == null) return "";
if (objcc_ExamPaperStuRelationEN.Id_ExamPaperStuRelation == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_ExamPaperStuRelationEN.CourseExamPaperId);
 sbCondition.AppendFormat(" and id_StudentInfo = '{0}'", objcc_ExamPaperStuRelationEN.id_StudentInfo);
 sbCondition.AppendFormat(" and id_CurrEduCls = '{0}'", objcc_ExamPaperStuRelationEN.id_CurrEduCls);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("Id_ExamPaperStuRelation !=  {0}", objcc_ExamPaperStuRelationEN.Id_ExamPaperStuRelation);
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_ExamPaperStuRelationEN.CourseExamPaperId);
 sbCondition.AppendFormat(" and id_StudentInfo = '{0}'", objcc_ExamPaperStuRelationEN.id_StudentInfo);
 sbCondition.AppendFormat(" and id_CurrEduCls = '{0}'", objcc_ExamPaperStuRelationEN.id_CurrEduCls);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
try
{
clscc_ExamPaperStuRelationWApi.CheckPropertyNew(objcc_ExamPaperStuRelationEN); 
bool bolResult = clscc_ExamPaperStuRelationWApi.AddNewRecord(objcc_ExamPaperStuRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuRelationWApi.ReFreshCache(objcc_ExamPaperStuRelationEN.id_CurrEduCls);
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
 /// <param name = "objcc_ExamPaperStuRelationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strWhereCond)
{
try
{
clscc_ExamPaperStuRelationWApi.CheckPropertyNew(objcc_ExamPaperStuRelationEN); 
bool bolResult = clscc_ExamPaperStuRelationWApi.UpdateWithCondition(objcc_ExamPaperStuRelationEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuRelationWApi.ReFreshCache(objcc_ExamPaperStuRelationEN.id_CurrEduCls);
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
 /// 考卷与学生关系(cc_ExamPaperStuRelation)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clscc_ExamPaperStuRelationWApi
{
private static readonly string mstrApiControllerName = "cc_ExamPaperStuRelationApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 public clscc_ExamPaperStuRelationWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
if (!Object.Equals(null, objcc_ExamPaperStuRelationEN.CourseExamPaperId) && GetStrLen(objcc_ExamPaperStuRelationEN.CourseExamPaperId) > 8)
{
 throw new Exception("字段[考卷流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_ExamPaperStuRelationEN.id_CurrEduCls) && GetStrLen(objcc_ExamPaperStuRelationEN.id_CurrEduCls) > 8)
{
 throw new Exception("字段[当前教学班流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_ExamPaperStuRelationEN.SpecifyCompletionDate) && GetStrLen(objcc_ExamPaperStuRelationEN.SpecifyCompletionDate) > 14)
{
 throw new Exception("字段[指定完成日期]的长度不能超过14!");
}
if (!Object.Equals(null, objcc_ExamPaperStuRelationEN.id_StudentInfo) && GetStrLen(objcc_ExamPaperStuRelationEN.id_StudentInfo) > 8)
{
 throw new Exception("字段[学生流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_ExamPaperStuRelationEN.AnswerModeId) && GetStrLen(objcc_ExamPaperStuRelationEN.AnswerModeId) > 4)
{
 throw new Exception("字段[答案模式Id]的长度不能超过4!");
}
if (!Object.Equals(null, objcc_ExamPaperStuRelationEN.AnswerOptionId) && GetStrLen(objcc_ExamPaperStuRelationEN.AnswerOptionId) > 8)
{
 throw new Exception("字段[回答选项Id]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_ExamPaperStuRelationEN.AnswerMultiOptions) && GetStrLen(objcc_ExamPaperStuRelationEN.AnswerMultiOptions) > 300)
{
 throw new Exception("字段[多选项答案]的长度不能超过300!");
}
if (!Object.Equals(null, objcc_ExamPaperStuRelationEN.ApplySendBackDate) && GetStrLen(objcc_ExamPaperStuRelationEN.ApplySendBackDate) > 14)
{
 throw new Exception("字段[申请退回日期]的长度不能超过14!");
}
if (!Object.Equals(null, objcc_ExamPaperStuRelationEN.RealFinishDate) && GetStrLen(objcc_ExamPaperStuRelationEN.RealFinishDate) > 14)
{
 throw new Exception("字段[实际完成日期]的长度不能超过14!");
}
if (!Object.Equals(null, objcc_ExamPaperStuRelationEN.OperateTime) && GetStrLen(objcc_ExamPaperStuRelationEN.OperateTime) > 14)
{
 throw new Exception("字段[操作时间]的长度不能超过14!");
}
if (!Object.Equals(null, objcc_ExamPaperStuRelationEN.MarkerId) && GetStrLen(objcc_ExamPaperStuRelationEN.MarkerId) > 20)
{
 throw new Exception("字段[打分者]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_ExamPaperStuRelationEN.MarkDate) && GetStrLen(objcc_ExamPaperStuRelationEN.MarkDate) > 14)
{
 throw new Exception("字段[打分日期]的长度不能超过14!");
}
if (!Object.Equals(null, objcc_ExamPaperStuRelationEN.WorkTypeId) && GetStrLen(objcc_ExamPaperStuRelationEN.WorkTypeId) > 2)
{
 throw new Exception("字段[作业类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objcc_ExamPaperStuRelationEN.AnswerIP) && GetStrLen(objcc_ExamPaperStuRelationEN.AnswerIP) > 30)
{
 throw new Exception("字段[回答IP]的长度不能超过30!");
}
if (!Object.Equals(null, objcc_ExamPaperStuRelationEN.AnswerDate) && GetStrLen(objcc_ExamPaperStuRelationEN.AnswerDate) > 8)
{
 throw new Exception("字段[回答日期]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_ExamPaperStuRelationEN.AnswerTime) && GetStrLen(objcc_ExamPaperStuRelationEN.AnswerTime) > 10)
{
 throw new Exception("字段[回答时间]的长度不能超过10!");
}
if (!Object.Equals(null, objcc_ExamPaperStuRelationEN.SchoolYear) && GetStrLen(objcc_ExamPaperStuRelationEN.SchoolYear) > 10)
{
 throw new Exception("字段[学年]的长度不能超过10!");
}
if (!Object.Equals(null, objcc_ExamPaperStuRelationEN.SchoolTerm) && GetStrLen(objcc_ExamPaperStuRelationEN.SchoolTerm) > 1)
{
 throw new Exception("字段[学期]的长度不能超过1!");
}
if (!Object.Equals(null, objcc_ExamPaperStuRelationEN.UpdDate) && GetStrLen(objcc_ExamPaperStuRelationEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_ExamPaperStuRelationEN.UpdUserId) && GetStrLen(objcc_ExamPaperStuRelationEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_ExamPaperStuRelationEN.Memo) && GetStrLen(objcc_ExamPaperStuRelationEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objcc_ExamPaperStuRelationEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_ExamPaperStuRelation">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_ExamPaperStuRelationEN GetObjById_ExamPaperStuRelation(long lngId_ExamPaperStuRelation)
{
string strAction = "GetObjById_ExamPaperStuRelation";
string strErrMsg = string.Empty;
string strResult = "";
clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_ExamPaperStuRelation"] = lngId_ExamPaperStuRelation.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_ExamPaperStuRelationEN = JsonConvert.DeserializeObject<clscc_ExamPaperStuRelationEN>((string)jobjReturn["ReturnObj"]);
return objcc_ExamPaperStuRelationEN;
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
 /// <param name = "lngId_ExamPaperStuRelation">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_ExamPaperStuRelationEN GetObjById_ExamPaperStuRelation_WA_Cache(long lngId_ExamPaperStuRelation, string strid_CurrEduCls)
{
string strAction = "GetObjById_ExamPaperStuRelation_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_ExamPaperStuRelation"] = lngId_ExamPaperStuRelation.ToString(),
["id_CurrEduCls"] = strid_CurrEduCls
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_ExamPaperStuRelationEN = JsonConvert.DeserializeObject<clscc_ExamPaperStuRelationEN>((string)jobjReturn["ReturnObj"]);
return objcc_ExamPaperStuRelationEN;
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
public static clscc_ExamPaperStuRelationEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = null;
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
objcc_ExamPaperStuRelationEN = JsonConvert.DeserializeObject<clscc_ExamPaperStuRelationEN>((string)jobjReturn["ReturnObj"]);
return objcc_ExamPaperStuRelationEN;
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
 /// <param name = "lngId_ExamPaperStuRelation">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_ExamPaperStuRelationEN GetObjById_ExamPaperStuRelation_Cache(long lngId_ExamPaperStuRelation, string strid_CurrEduCls)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clscc_ExamPaperStuRelationEN._CurrTabName_S, strid_CurrEduCls);
List<clscc_ExamPaperStuRelationEN> arrcc_ExamPaperStuRelationObjLst_Cache = GetObjLst_Cache(strid_CurrEduCls);
IEnumerable <clscc_ExamPaperStuRelationEN> arrcc_ExamPaperStuRelationObjLst_Sel =
from objcc_ExamPaperStuRelationEN in arrcc_ExamPaperStuRelationObjLst_Cache
where objcc_ExamPaperStuRelationEN.Id_ExamPaperStuRelation == lngId_ExamPaperStuRelation
select objcc_ExamPaperStuRelationEN;
if (arrcc_ExamPaperStuRelationObjLst_Sel.Count() == 0)
{
   clscc_ExamPaperStuRelationEN obj = clscc_ExamPaperStuRelationWApi.GetObjById_ExamPaperStuRelation(lngId_ExamPaperStuRelation);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrcc_ExamPaperStuRelationObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_ExamPaperStuRelationEN> GetObjLst(string strWhereCond)
{
 List<clscc_ExamPaperStuRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExamPaperStuRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_ExamPaperStuRelationEN> GetObjLstById_ExamPaperStuRelationLst(List<long> arrId_ExamPaperStuRelation)
{
 List<clscc_ExamPaperStuRelationEN> arrObjLst = null; 
string strAction = "GetObjLstById_ExamPaperStuRelationLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_ExamPaperStuRelation);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExamPaperStuRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngId_ExamPaperStuRelation">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clscc_ExamPaperStuRelationEN> GetObjLstById_ExamPaperStuRelationLst_Cache(List<long> arrId_ExamPaperStuRelation, string strid_CurrEduCls)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clscc_ExamPaperStuRelationEN._CurrTabName_S, strid_CurrEduCls);
List<clscc_ExamPaperStuRelationEN> arrcc_ExamPaperStuRelationObjLst_Cache = GetObjLst_Cache(strid_CurrEduCls);
IEnumerable <clscc_ExamPaperStuRelationEN> arrcc_ExamPaperStuRelationObjLst_Sel =
from objcc_ExamPaperStuRelationEN in arrcc_ExamPaperStuRelationObjLst_Cache
where arrId_ExamPaperStuRelation.Contains(objcc_ExamPaperStuRelationEN.Id_ExamPaperStuRelation)
select objcc_ExamPaperStuRelationEN;
return arrcc_ExamPaperStuRelationObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_ExamPaperStuRelationEN> GetObjLstById_ExamPaperStuRelationLst_WA_Cache(List<long> arrId_ExamPaperStuRelation, string strid_CurrEduCls)
{
 List<clscc_ExamPaperStuRelationEN> arrObjLst = null; 
string strAction = "GetObjLstById_ExamPaperStuRelationLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CurrEduCls"] = strid_CurrEduCls
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_ExamPaperStuRelation);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExamPaperStuRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_ExamPaperStuRelationEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clscc_ExamPaperStuRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExamPaperStuRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_ExamPaperStuRelationEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clscc_ExamPaperStuRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExamPaperStuRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_ExamPaperStuRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clscc_ExamPaperStuRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExamPaperStuRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_ExamPaperStuRelationEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clscc_ExamPaperStuRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExamPaperStuRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngId_ExamPaperStuRelation)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = clscc_ExamPaperStuRelationWApi.GetObjById_ExamPaperStuRelation(lngId_ExamPaperStuRelation);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngId_ExamPaperStuRelation.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_ExamPaperStuRelationWApi.ReFreshCache(objcc_ExamPaperStuRelationEN.id_CurrEduCls);
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
public static int Delcc_ExamPaperStuRelations(List<string> arrId_ExamPaperStuRelation)
{
string strAction = "Delcc_ExamPaperStuRelations";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_ExamPaperStuRelation);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
 clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = clscc_ExamPaperStuRelationWApi.GetObjById_ExamPaperStuRelation(long.Parse(arrId_ExamPaperStuRelation[0]));
clscc_ExamPaperStuRelationWApi.ReFreshCache(objcc_ExamPaperStuRelationEN.id_CurrEduCls);
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
public static int Delcc_ExamPaperStuRelationsByCond(string strWhereCond)
{
string strAction = "Delcc_ExamPaperStuRelationsByCond";
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
public static bool AddNewRecord(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_ExamPaperStuRelationEN>(objcc_ExamPaperStuRelationEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuRelationWApi.ReFreshCache(objcc_ExamPaperStuRelationEN.id_CurrEduCls);
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
 /// <param name = "objcc_ExamPaperStuRelationEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_ExamPaperStuRelationEN>(objcc_ExamPaperStuRelationEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuRelationWApi.ReFreshCache(objcc_ExamPaperStuRelationEN.id_CurrEduCls);
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
public static bool UpdateRecord(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
if (string.IsNullOrEmpty(objcc_ExamPaperStuRelationEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_ExamPaperStuRelationEN.Id_ExamPaperStuRelation, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_ExamPaperStuRelationEN>(objcc_ExamPaperStuRelationEN);
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
 /// <param name = "objcc_ExamPaperStuRelationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objcc_ExamPaperStuRelationEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_ExamPaperStuRelationEN.Id_ExamPaperStuRelation, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_ExamPaperStuRelationEN.Id_ExamPaperStuRelation, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_ExamPaperStuRelationEN>(objcc_ExamPaperStuRelationEN);
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
public static bool IsExist(long lngId_ExamPaperStuRelation)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_ExamPaperStuRelation"] = lngId_ExamPaperStuRelation.ToString()
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
 /// <param name = "objcc_ExamPaperStuRelationENS">源对象</param>
 /// <param name = "objcc_ExamPaperStuRelationENT">目标对象</param>
 public static void CopyTo(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationENS, clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationENT)
{
try
{
objcc_ExamPaperStuRelationENT.Id_ExamPaperStuRelation = objcc_ExamPaperStuRelationENS.Id_ExamPaperStuRelation; //流水号
objcc_ExamPaperStuRelationENT.CourseExamPaperId = objcc_ExamPaperStuRelationENS.CourseExamPaperId; //考卷流水号
objcc_ExamPaperStuRelationENT.id_CurrEduCls = objcc_ExamPaperStuRelationENS.id_CurrEduCls; //当前教学班流水号
objcc_ExamPaperStuRelationENT.Scores = objcc_ExamPaperStuRelationENS.Scores; //分值
objcc_ExamPaperStuRelationENT.SpecifyCompletionDate = objcc_ExamPaperStuRelationENS.SpecifyCompletionDate; //指定完成日期
objcc_ExamPaperStuRelationENT.id_StudentInfo = objcc_ExamPaperStuRelationENS.id_StudentInfo; //学生流水号
objcc_ExamPaperStuRelationENT.AnswerModeId = objcc_ExamPaperStuRelationENS.AnswerModeId; //答案模式Id
objcc_ExamPaperStuRelationENT.AnswerOptionId = objcc_ExamPaperStuRelationENS.AnswerOptionId; //回答选项Id
objcc_ExamPaperStuRelationENT.AnswerMultiOptions = objcc_ExamPaperStuRelationENS.AnswerMultiOptions; //多选项答案
objcc_ExamPaperStuRelationENT.StuAnswerText = objcc_ExamPaperStuRelationENS.StuAnswerText; //学生回答文本
objcc_ExamPaperStuRelationENT.IsPublish = objcc_ExamPaperStuRelationENS.IsPublish; //是否发布
objcc_ExamPaperStuRelationENT.IsLook = objcc_ExamPaperStuRelationENS.IsLook; //是否查看
objcc_ExamPaperStuRelationENT.IsSave = objcc_ExamPaperStuRelationENS.IsSave; //是否保存
objcc_ExamPaperStuRelationENT.IsSubmit = objcc_ExamPaperStuRelationENS.IsSubmit; //是否提交
objcc_ExamPaperStuRelationENT.ApplySendBackDate = objcc_ExamPaperStuRelationENS.ApplySendBackDate; //申请退回日期
objcc_ExamPaperStuRelationENT.IsApplySendBack = objcc_ExamPaperStuRelationENS.IsApplySendBack; //是否申请退回
objcc_ExamPaperStuRelationENT.RealFinishDate = objcc_ExamPaperStuRelationENS.RealFinishDate; //实际完成日期
objcc_ExamPaperStuRelationENT.OperateTime = objcc_ExamPaperStuRelationENS.OperateTime; //操作时间
objcc_ExamPaperStuRelationENT.Score = objcc_ExamPaperStuRelationENS.Score; //得分
objcc_ExamPaperStuRelationENT.Comment = objcc_ExamPaperStuRelationENS.Comment; //批注
objcc_ExamPaperStuRelationENT.IsMarking = objcc_ExamPaperStuRelationENS.IsMarking; //是否批阅
objcc_ExamPaperStuRelationENT.MarkerId = objcc_ExamPaperStuRelationENS.MarkerId; //打分者
objcc_ExamPaperStuRelationENT.MarkDate = objcc_ExamPaperStuRelationENS.MarkDate; //打分日期
objcc_ExamPaperStuRelationENT.IsSendBack = objcc_ExamPaperStuRelationENS.IsSendBack; //是否退回
objcc_ExamPaperStuRelationENT.IsInErrorQuestion = objcc_ExamPaperStuRelationENS.IsInErrorQuestion; //是否进入错题
objcc_ExamPaperStuRelationENT.WorkTypeId = objcc_ExamPaperStuRelationENS.WorkTypeId; //作业类型Id
objcc_ExamPaperStuRelationENT.AnswerIP = objcc_ExamPaperStuRelationENS.AnswerIP; //回答IP
objcc_ExamPaperStuRelationENT.AnswerDate = objcc_ExamPaperStuRelationENS.AnswerDate; //回答日期
objcc_ExamPaperStuRelationENT.AnswerTime = objcc_ExamPaperStuRelationENS.AnswerTime; //回答时间
objcc_ExamPaperStuRelationENT.IsRight = objcc_ExamPaperStuRelationENS.IsRight; //是否正确
objcc_ExamPaperStuRelationENT.IsAccessKnowledge = objcc_ExamPaperStuRelationENS.IsAccessKnowledge; //是否处理知识点
objcc_ExamPaperStuRelationENT.IsNotProcessTimeout = objcc_ExamPaperStuRelationENS.IsNotProcessTimeout; //是否不处理超时
objcc_ExamPaperStuRelationENT.SchoolYear = objcc_ExamPaperStuRelationENS.SchoolYear; //学年
objcc_ExamPaperStuRelationENT.SchoolTerm = objcc_ExamPaperStuRelationENS.SchoolTerm; //学期
objcc_ExamPaperStuRelationENT.UpdDate = objcc_ExamPaperStuRelationENS.UpdDate; //修改日期
objcc_ExamPaperStuRelationENT.UpdUserId = objcc_ExamPaperStuRelationENS.UpdUserId; //修改用户Id
objcc_ExamPaperStuRelationENT.Memo = objcc_ExamPaperStuRelationENS.Memo; //备注
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
public static DataTable ToDataTable(List<clscc_ExamPaperStuRelationEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clscc_ExamPaperStuRelationEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clscc_ExamPaperStuRelationEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clscc_ExamPaperStuRelationEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clscc_ExamPaperStuRelationEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clscc_ExamPaperStuRelationEN.AttributeName)
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
if (clscc_ExamPaperStuRelationWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamPaperStuRelationWApi没有刷新缓存机制(clscc_ExamPaperStuRelationWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_ExamPaperStuRelation");
//if (arrcc_ExamPaperStuRelationObjLst_Cache == null)
//{
//arrcc_ExamPaperStuRelationObjLst_Cache = await clscc_ExamPaperStuRelationWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strid_CurrEduCls = "")
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clscc_ExamPaperStuRelationEN._CurrTabName_S, strid_CurrEduCls);
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
public static void ReFreshCache(string strid_CurrEduCls)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clscc_ExamPaperStuRelationWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clscc_ExamPaperStuRelationEN._CurrTabName_S, strid_CurrEduCls);
CacheHelper.Remove(strKey);
clscc_ExamPaperStuRelationWApi.objCommFun4BL.ReFreshCache(strid_CurrEduCls);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_ExamPaperStuRelationEN> GetObjLst_Cache(string strid_CurrEduCls)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clscc_ExamPaperStuRelationEN._CurrTabName_S, strid_CurrEduCls);
List<clscc_ExamPaperStuRelationEN> arrcc_ExamPaperStuRelationObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("id_CurrEduCls='{0}'", strid_CurrEduCls)); });
return arrcc_ExamPaperStuRelationObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clscc_ExamPaperStuRelationEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(concc_ExamPaperStuRelation.Id_ExamPaperStuRelation, Type.GetType("System.Int64"));
objDT.Columns.Add(concc_ExamPaperStuRelation.CourseExamPaperId, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuRelation.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuRelation.Scores, Type.GetType("System.Decimal"));
objDT.Columns.Add(concc_ExamPaperStuRelation.SpecifyCompletionDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuRelation.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuRelation.AnswerModeId, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuRelation.AnswerOptionId, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuRelation.AnswerMultiOptions, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuRelation.StuAnswerText, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuRelation.IsPublish, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_ExamPaperStuRelation.IsLook, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_ExamPaperStuRelation.IsSave, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_ExamPaperStuRelation.IsSubmit, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_ExamPaperStuRelation.ApplySendBackDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuRelation.IsApplySendBack, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_ExamPaperStuRelation.RealFinishDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuRelation.OperateTime, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuRelation.Score, Type.GetType("System.Decimal"));
objDT.Columns.Add(concc_ExamPaperStuRelation.Comment, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuRelation.IsMarking, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_ExamPaperStuRelation.MarkerId, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuRelation.MarkDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuRelation.IsSendBack, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_ExamPaperStuRelation.IsInErrorQuestion, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_ExamPaperStuRelation.WorkTypeId, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuRelation.AnswerIP, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuRelation.AnswerDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuRelation.AnswerTime, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuRelation.IsRight, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_ExamPaperStuRelation.IsAccessKnowledge, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_ExamPaperStuRelation.IsNotProcessTimeout, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_ExamPaperStuRelation.SchoolYear, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuRelation.SchoolTerm, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuRelation.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuRelation.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuRelation.Memo, Type.GetType("System.String"));
foreach (clscc_ExamPaperStuRelationEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[concc_ExamPaperStuRelation.Id_ExamPaperStuRelation] = objInFor[concc_ExamPaperStuRelation.Id_ExamPaperStuRelation];
objDR[concc_ExamPaperStuRelation.CourseExamPaperId] = objInFor[concc_ExamPaperStuRelation.CourseExamPaperId];
objDR[concc_ExamPaperStuRelation.id_CurrEduCls] = objInFor[concc_ExamPaperStuRelation.id_CurrEduCls];
objDR[concc_ExamPaperStuRelation.Scores] = objInFor[concc_ExamPaperStuRelation.Scores];
objDR[concc_ExamPaperStuRelation.SpecifyCompletionDate] = objInFor[concc_ExamPaperStuRelation.SpecifyCompletionDate];
objDR[concc_ExamPaperStuRelation.id_StudentInfo] = objInFor[concc_ExamPaperStuRelation.id_StudentInfo];
objDR[concc_ExamPaperStuRelation.AnswerModeId] = objInFor[concc_ExamPaperStuRelation.AnswerModeId];
objDR[concc_ExamPaperStuRelation.AnswerOptionId] = objInFor[concc_ExamPaperStuRelation.AnswerOptionId];
objDR[concc_ExamPaperStuRelation.AnswerMultiOptions] = objInFor[concc_ExamPaperStuRelation.AnswerMultiOptions];
objDR[concc_ExamPaperStuRelation.StuAnswerText] = objInFor[concc_ExamPaperStuRelation.StuAnswerText];
objDR[concc_ExamPaperStuRelation.IsPublish] = objInFor[concc_ExamPaperStuRelation.IsPublish];
objDR[concc_ExamPaperStuRelation.IsLook] = objInFor[concc_ExamPaperStuRelation.IsLook];
objDR[concc_ExamPaperStuRelation.IsSave] = objInFor[concc_ExamPaperStuRelation.IsSave];
objDR[concc_ExamPaperStuRelation.IsSubmit] = objInFor[concc_ExamPaperStuRelation.IsSubmit];
objDR[concc_ExamPaperStuRelation.ApplySendBackDate] = objInFor[concc_ExamPaperStuRelation.ApplySendBackDate];
objDR[concc_ExamPaperStuRelation.IsApplySendBack] = objInFor[concc_ExamPaperStuRelation.IsApplySendBack];
objDR[concc_ExamPaperStuRelation.RealFinishDate] = objInFor[concc_ExamPaperStuRelation.RealFinishDate];
objDR[concc_ExamPaperStuRelation.OperateTime] = objInFor[concc_ExamPaperStuRelation.OperateTime];
objDR[concc_ExamPaperStuRelation.Score] = objInFor[concc_ExamPaperStuRelation.Score];
objDR[concc_ExamPaperStuRelation.Comment] = objInFor[concc_ExamPaperStuRelation.Comment];
objDR[concc_ExamPaperStuRelation.IsMarking] = objInFor[concc_ExamPaperStuRelation.IsMarking];
objDR[concc_ExamPaperStuRelation.MarkerId] = objInFor[concc_ExamPaperStuRelation.MarkerId];
objDR[concc_ExamPaperStuRelation.MarkDate] = objInFor[concc_ExamPaperStuRelation.MarkDate];
objDR[concc_ExamPaperStuRelation.IsSendBack] = objInFor[concc_ExamPaperStuRelation.IsSendBack];
objDR[concc_ExamPaperStuRelation.IsInErrorQuestion] = objInFor[concc_ExamPaperStuRelation.IsInErrorQuestion];
objDR[concc_ExamPaperStuRelation.WorkTypeId] = objInFor[concc_ExamPaperStuRelation.WorkTypeId];
objDR[concc_ExamPaperStuRelation.AnswerIP] = objInFor[concc_ExamPaperStuRelation.AnswerIP];
objDR[concc_ExamPaperStuRelation.AnswerDate] = objInFor[concc_ExamPaperStuRelation.AnswerDate];
objDR[concc_ExamPaperStuRelation.AnswerTime] = objInFor[concc_ExamPaperStuRelation.AnswerTime];
objDR[concc_ExamPaperStuRelation.IsRight] = objInFor[concc_ExamPaperStuRelation.IsRight];
objDR[concc_ExamPaperStuRelation.IsAccessKnowledge] = objInFor[concc_ExamPaperStuRelation.IsAccessKnowledge];
objDR[concc_ExamPaperStuRelation.IsNotProcessTimeout] = objInFor[concc_ExamPaperStuRelation.IsNotProcessTimeout];
objDR[concc_ExamPaperStuRelation.SchoolYear] = objInFor[concc_ExamPaperStuRelation.SchoolYear];
objDR[concc_ExamPaperStuRelation.SchoolTerm] = objInFor[concc_ExamPaperStuRelation.SchoolTerm];
objDR[concc_ExamPaperStuRelation.UpdDate] = objInFor[concc_ExamPaperStuRelation.UpdDate];
objDR[concc_ExamPaperStuRelation.UpdUserId] = objInFor[concc_ExamPaperStuRelation.UpdUserId];
objDR[concc_ExamPaperStuRelation.Memo] = objInFor[concc_ExamPaperStuRelation.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 考卷与学生关系(cc_ExamPaperStuRelation)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4cc_ExamPaperStuRelation : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strid_CurrEduCls)
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
clscc_ExamPaperStuRelationWApi.ReFreshThisCache(strid_CurrEduCls);
clsvcc_ExamPaperStuRelationWApi.ReFreshThisCache(strid_CurrEduCls);
clsvcc_ExamPaperStuRelation4AppWApi.ReFreshThisCache(strid_CurrEduCls);
}
}

}