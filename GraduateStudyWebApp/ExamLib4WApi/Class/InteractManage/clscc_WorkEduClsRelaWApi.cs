
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_WorkEduClsRelaWApi
 表名:cc_WorkEduClsRela(01120164)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:39:14
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
public static class clscc_WorkEduClsRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkEduClsRelaEN SetId_WorkEduClsRela(this clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN, long lngId_WorkEduClsRela, string strComparisonOp="")
	{
objcc_WorkEduClsRelaEN.Id_WorkEduClsRela = lngId_WorkEduClsRela; //作业教学班关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_WorkEduClsRela.Id_WorkEduClsRela) == false)
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(concc_WorkEduClsRela.Id_WorkEduClsRela, strComparisonOp);
}
else
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp[concc_WorkEduClsRela.Id_WorkEduClsRela] = strComparisonOp;
}
}
return objcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkEduClsRelaEN SetQuestionID(this clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionID, concc_WorkEduClsRela.QuestionID);
clsCheckSql.CheckFieldLen(strQuestionID, 8, concc_WorkEduClsRela.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, concc_WorkEduClsRela.QuestionID);
objcc_WorkEduClsRelaEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_WorkEduClsRela.QuestionID) == false)
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(concc_WorkEduClsRela.QuestionID, strComparisonOp);
}
else
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp[concc_WorkEduClsRela.QuestionID] = strComparisonOp;
}
}
return objcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkEduClsRelaEN Setid_CurrEduCls(this clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CurrEduCls, concc_WorkEduClsRela.id_CurrEduCls);
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, concc_WorkEduClsRela.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, concc_WorkEduClsRela.id_CurrEduCls);
objcc_WorkEduClsRelaEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_WorkEduClsRela.id_CurrEduCls) == false)
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(concc_WorkEduClsRela.id_CurrEduCls, strComparisonOp);
}
else
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp[concc_WorkEduClsRela.id_CurrEduCls] = strComparisonOp;
}
}
return objcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkEduClsRelaEN SetScores(this clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN, double dblScores, string strComparisonOp="")
	{
objcc_WorkEduClsRelaEN.Scores = dblScores; //分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_WorkEduClsRela.Scores) == false)
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(concc_WorkEduClsRela.Scores, strComparisonOp);
}
else
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp[concc_WorkEduClsRela.Scores] = strComparisonOp;
}
}
return objcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkEduClsRelaEN SetTeacherID(this clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN, string strTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherID, concc_WorkEduClsRela.TeacherID);
clsCheckSql.CheckFieldLen(strTeacherID, 12, concc_WorkEduClsRela.TeacherID);
objcc_WorkEduClsRelaEN.TeacherID = strTeacherID; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_WorkEduClsRela.TeacherID) == false)
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(concc_WorkEduClsRela.TeacherID, strComparisonOp);
}
else
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp[concc_WorkEduClsRela.TeacherID] = strComparisonOp;
}
}
return objcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkEduClsRelaEN SetIsPublish(this clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN, bool bolIsPublish, string strComparisonOp="")
	{
objcc_WorkEduClsRelaEN.IsPublish = bolIsPublish; //是否发布
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_WorkEduClsRela.IsPublish) == false)
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(concc_WorkEduClsRela.IsPublish, strComparisonOp);
}
else
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp[concc_WorkEduClsRela.IsPublish] = strComparisonOp;
}
}
return objcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkEduClsRelaEN SetPubDate(this clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN, string strPubDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubDate, 14, concc_WorkEduClsRela.PubDate);
objcc_WorkEduClsRelaEN.PubDate = strPubDate; //发布日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_WorkEduClsRela.PubDate) == false)
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(concc_WorkEduClsRela.PubDate, strComparisonOp);
}
else
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp[concc_WorkEduClsRela.PubDate] = strComparisonOp;
}
}
return objcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkEduClsRelaEN Setpublisher(this clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN, string strpublisher, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strpublisher, 20, concc_WorkEduClsRela.publisher);
objcc_WorkEduClsRelaEN.publisher = strpublisher; //发布者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_WorkEduClsRela.publisher) == false)
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(concc_WorkEduClsRela.publisher, strComparisonOp);
}
else
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp[concc_WorkEduClsRela.publisher] = strComparisonOp;
}
}
return objcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkEduClsRelaEN SetSpecifyCompletionDate(this clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN, string strSpecifyCompletionDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSpecifyCompletionDate, 14, concc_WorkEduClsRela.SpecifyCompletionDate);
objcc_WorkEduClsRelaEN.SpecifyCompletionDate = strSpecifyCompletionDate; //指定完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_WorkEduClsRela.SpecifyCompletionDate) == false)
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(concc_WorkEduClsRela.SpecifyCompletionDate, strComparisonOp);
}
else
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp[concc_WorkEduClsRela.SpecifyCompletionDate] = strComparisonOp;
}
}
return objcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkEduClsRelaEN SetIsCurrEduCls(this clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN, bool bolIsCurrEduCls, string strComparisonOp="")
	{
objcc_WorkEduClsRelaEN.IsCurrEduCls = bolIsCurrEduCls; //是否为教学班作业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_WorkEduClsRela.IsCurrEduCls) == false)
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(concc_WorkEduClsRela.IsCurrEduCls, strComparisonOp);
}
else
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp[concc_WorkEduClsRela.IsCurrEduCls] = strComparisonOp;
}
}
return objcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkEduClsRelaEN SetIsGroupWork(this clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN, bool bolIsGroupWork, string strComparisonOp="")
	{
objcc_WorkEduClsRelaEN.IsGroupWork = bolIsGroupWork; //是否为小组作业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_WorkEduClsRela.IsGroupWork) == false)
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(concc_WorkEduClsRela.IsGroupWork, strComparisonOp);
}
else
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp[concc_WorkEduClsRela.IsGroupWork] = strComparisonOp;
}
}
return objcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkEduClsRelaEN SetCourseStudentGroupId(this clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN, long lngCourseStudentGroupId, string strComparisonOp="")
	{
objcc_WorkEduClsRelaEN.CourseStudentGroupId = lngCourseStudentGroupId; //学生分组表流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_WorkEduClsRela.CourseStudentGroupId) == false)
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(concc_WorkEduClsRela.CourseStudentGroupId, strComparisonOp);
}
else
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp[concc_WorkEduClsRela.CourseStudentGroupId] = strComparisonOp;
}
}
return objcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkEduClsRelaEN SetWorkTypeId(this clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN, string strWorkTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkTypeId, concc_WorkEduClsRela.WorkTypeId);
clsCheckSql.CheckFieldLen(strWorkTypeId, 2, concc_WorkEduClsRela.WorkTypeId);
clsCheckSql.CheckFieldForeignKey(strWorkTypeId, 2, concc_WorkEduClsRela.WorkTypeId);
objcc_WorkEduClsRelaEN.WorkTypeId = strWorkTypeId; //作业类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_WorkEduClsRela.WorkTypeId) == false)
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(concc_WorkEduClsRela.WorkTypeId, strComparisonOp);
}
else
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp[concc_WorkEduClsRela.WorkTypeId] = strComparisonOp;
}
}
return objcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkEduClsRelaEN SetUpdDate(this clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, concc_WorkEduClsRela.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_WorkEduClsRela.UpdDate);
objcc_WorkEduClsRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_WorkEduClsRela.UpdDate) == false)
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(concc_WorkEduClsRela.UpdDate, strComparisonOp);
}
else
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp[concc_WorkEduClsRela.UpdDate] = strComparisonOp;
}
}
return objcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkEduClsRelaEN SetUpdUserId(this clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, concc_WorkEduClsRela.UpdUserId);
objcc_WorkEduClsRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_WorkEduClsRela.UpdUserId) == false)
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(concc_WorkEduClsRela.UpdUserId, strComparisonOp);
}
else
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp[concc_WorkEduClsRela.UpdUserId] = strComparisonOp;
}
}
return objcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkEduClsRelaEN SetMemo(this clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_WorkEduClsRela.Memo);
objcc_WorkEduClsRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_WorkEduClsRela.Memo) == false)
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(concc_WorkEduClsRela.Memo, strComparisonOp);
}
else
{
objcc_WorkEduClsRelaEN.dicFldComparisonOp[concc_WorkEduClsRela.Memo] = strComparisonOp;
}
}
return objcc_WorkEduClsRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_WorkEduClsRelaEN objcc_WorkEduClsRela_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_WorkEduClsRela_Cond.IsUpdated(concc_WorkEduClsRela.Id_WorkEduClsRela) == true)
{
string strComparisonOp_Id_WorkEduClsRela = objcc_WorkEduClsRela_Cond.dicFldComparisonOp[concc_WorkEduClsRela.Id_WorkEduClsRela];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkEduClsRela.Id_WorkEduClsRela, objcc_WorkEduClsRela_Cond.Id_WorkEduClsRela, strComparisonOp_Id_WorkEduClsRela);
}
if (objcc_WorkEduClsRela_Cond.IsUpdated(concc_WorkEduClsRela.QuestionID) == true)
{
string strComparisonOp_QuestionID = objcc_WorkEduClsRela_Cond.dicFldComparisonOp[concc_WorkEduClsRela.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkEduClsRela.QuestionID, objcc_WorkEduClsRela_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objcc_WorkEduClsRela_Cond.IsUpdated(concc_WorkEduClsRela.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objcc_WorkEduClsRela_Cond.dicFldComparisonOp[concc_WorkEduClsRela.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkEduClsRela.id_CurrEduCls, objcc_WorkEduClsRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objcc_WorkEduClsRela_Cond.IsUpdated(concc_WorkEduClsRela.Scores) == true)
{
string strComparisonOp_Scores = objcc_WorkEduClsRela_Cond.dicFldComparisonOp[concc_WorkEduClsRela.Scores];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkEduClsRela.Scores, objcc_WorkEduClsRela_Cond.Scores, strComparisonOp_Scores);
}
if (objcc_WorkEduClsRela_Cond.IsUpdated(concc_WorkEduClsRela.TeacherID) == true)
{
string strComparisonOp_TeacherID = objcc_WorkEduClsRela_Cond.dicFldComparisonOp[concc_WorkEduClsRela.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkEduClsRela.TeacherID, objcc_WorkEduClsRela_Cond.TeacherID, strComparisonOp_TeacherID);
}
if (objcc_WorkEduClsRela_Cond.IsUpdated(concc_WorkEduClsRela.IsPublish) == true)
{
if (objcc_WorkEduClsRela_Cond.IsPublish == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkEduClsRela.IsPublish);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkEduClsRela.IsPublish);
}
}
if (objcc_WorkEduClsRela_Cond.IsUpdated(concc_WorkEduClsRela.PubDate) == true)
{
string strComparisonOp_PubDate = objcc_WorkEduClsRela_Cond.dicFldComparisonOp[concc_WorkEduClsRela.PubDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkEduClsRela.PubDate, objcc_WorkEduClsRela_Cond.PubDate, strComparisonOp_PubDate);
}
if (objcc_WorkEduClsRela_Cond.IsUpdated(concc_WorkEduClsRela.publisher) == true)
{
string strComparisonOp_publisher = objcc_WorkEduClsRela_Cond.dicFldComparisonOp[concc_WorkEduClsRela.publisher];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkEduClsRela.publisher, objcc_WorkEduClsRela_Cond.publisher, strComparisonOp_publisher);
}
if (objcc_WorkEduClsRela_Cond.IsUpdated(concc_WorkEduClsRela.SpecifyCompletionDate) == true)
{
string strComparisonOp_SpecifyCompletionDate = objcc_WorkEduClsRela_Cond.dicFldComparisonOp[concc_WorkEduClsRela.SpecifyCompletionDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkEduClsRela.SpecifyCompletionDate, objcc_WorkEduClsRela_Cond.SpecifyCompletionDate, strComparisonOp_SpecifyCompletionDate);
}
if (objcc_WorkEduClsRela_Cond.IsUpdated(concc_WorkEduClsRela.IsCurrEduCls) == true)
{
if (objcc_WorkEduClsRela_Cond.IsCurrEduCls == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkEduClsRela.IsCurrEduCls);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkEduClsRela.IsCurrEduCls);
}
}
if (objcc_WorkEduClsRela_Cond.IsUpdated(concc_WorkEduClsRela.IsGroupWork) == true)
{
if (objcc_WorkEduClsRela_Cond.IsGroupWork == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkEduClsRela.IsGroupWork);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkEduClsRela.IsGroupWork);
}
}
if (objcc_WorkEduClsRela_Cond.IsUpdated(concc_WorkEduClsRela.CourseStudentGroupId) == true)
{
string strComparisonOp_CourseStudentGroupId = objcc_WorkEduClsRela_Cond.dicFldComparisonOp[concc_WorkEduClsRela.CourseStudentGroupId];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkEduClsRela.CourseStudentGroupId, objcc_WorkEduClsRela_Cond.CourseStudentGroupId, strComparisonOp_CourseStudentGroupId);
}
if (objcc_WorkEduClsRela_Cond.IsUpdated(concc_WorkEduClsRela.WorkTypeId) == true)
{
string strComparisonOp_WorkTypeId = objcc_WorkEduClsRela_Cond.dicFldComparisonOp[concc_WorkEduClsRela.WorkTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkEduClsRela.WorkTypeId, objcc_WorkEduClsRela_Cond.WorkTypeId, strComparisonOp_WorkTypeId);
}
if (objcc_WorkEduClsRela_Cond.IsUpdated(concc_WorkEduClsRela.UpdDate) == true)
{
string strComparisonOp_UpdDate = objcc_WorkEduClsRela_Cond.dicFldComparisonOp[concc_WorkEduClsRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkEduClsRela.UpdDate, objcc_WorkEduClsRela_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objcc_WorkEduClsRela_Cond.IsUpdated(concc_WorkEduClsRela.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objcc_WorkEduClsRela_Cond.dicFldComparisonOp[concc_WorkEduClsRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkEduClsRela.UpdUserId, objcc_WorkEduClsRela_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objcc_WorkEduClsRela_Cond.IsUpdated(concc_WorkEduClsRela.Memo) == true)
{
string strComparisonOp_Memo = objcc_WorkEduClsRela_Cond.dicFldComparisonOp[concc_WorkEduClsRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkEduClsRela.Memo, objcc_WorkEduClsRela_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objcc_WorkEduClsRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN)
{
 if (objcc_WorkEduClsRelaEN.Id_WorkEduClsRela == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objcc_WorkEduClsRelaEN.sf_UpdFldSetStr = objcc_WorkEduClsRelaEN.getsf_UpdFldSetStr();
clscc_WorkEduClsRelaWApi.CheckPropertyNew(objcc_WorkEduClsRelaEN); 
bool bolResult = clscc_WorkEduClsRelaWApi.UpdateRecord(objcc_WorkEduClsRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkEduClsRelaWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--cc_WorkEduClsRela(作业教学班关系), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_WorkEduClsRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_QuestionID_id_CurrEduCls(this clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_WorkEduClsRelaEN == null) return "";
if (objcc_WorkEduClsRelaEN.Id_WorkEduClsRela == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objcc_WorkEduClsRelaEN.QuestionID);
 sbCondition.AppendFormat(" and id_CurrEduCls = '{0}'", objcc_WorkEduClsRelaEN.id_CurrEduCls);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("Id_WorkEduClsRela !=  {0}", objcc_WorkEduClsRelaEN.Id_WorkEduClsRela);
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objcc_WorkEduClsRelaEN.QuestionID);
 sbCondition.AppendFormat(" and id_CurrEduCls = '{0}'", objcc_WorkEduClsRelaEN.id_CurrEduCls);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_WorkEduClsRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN)
{
try
{
clscc_WorkEduClsRelaWApi.CheckPropertyNew(objcc_WorkEduClsRelaEN); 
bool bolResult = clscc_WorkEduClsRelaWApi.AddNewRecord(objcc_WorkEduClsRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkEduClsRelaWApi.ReFreshCache();
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
 /// <param name = "objcc_WorkEduClsRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN, string strWhereCond)
{
try
{
clscc_WorkEduClsRelaWApi.CheckPropertyNew(objcc_WorkEduClsRelaEN); 
bool bolResult = clscc_WorkEduClsRelaWApi.UpdateWithCondition(objcc_WorkEduClsRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkEduClsRelaWApi.ReFreshCache();
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
 /// 作业教学班关系(cc_WorkEduClsRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clscc_WorkEduClsRelaWApi
{
private static readonly string mstrApiControllerName = "cc_WorkEduClsRelaApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clscc_WorkEduClsRelaWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN)
{
if (!Object.Equals(null, objcc_WorkEduClsRelaEN.QuestionID) && GetStrLen(objcc_WorkEduClsRelaEN.QuestionID) > 8)
{
 throw new Exception("字段[题目ID]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_WorkEduClsRelaEN.id_CurrEduCls) && GetStrLen(objcc_WorkEduClsRelaEN.id_CurrEduCls) > 8)
{
 throw new Exception("字段[当前教学班流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_WorkEduClsRelaEN.TeacherID) && GetStrLen(objcc_WorkEduClsRelaEN.TeacherID) > 12)
{
 throw new Exception("字段[教师工号]的长度不能超过12!");
}
if (!Object.Equals(null, objcc_WorkEduClsRelaEN.PubDate) && GetStrLen(objcc_WorkEduClsRelaEN.PubDate) > 14)
{
 throw new Exception("字段[发布日期]的长度不能超过14!");
}
if (!Object.Equals(null, objcc_WorkEduClsRelaEN.publisher) && GetStrLen(objcc_WorkEduClsRelaEN.publisher) > 20)
{
 throw new Exception("字段[发布者Id]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_WorkEduClsRelaEN.SpecifyCompletionDate) && GetStrLen(objcc_WorkEduClsRelaEN.SpecifyCompletionDate) > 14)
{
 throw new Exception("字段[指定完成日期]的长度不能超过14!");
}
if (!Object.Equals(null, objcc_WorkEduClsRelaEN.WorkTypeId) && GetStrLen(objcc_WorkEduClsRelaEN.WorkTypeId) > 2)
{
 throw new Exception("字段[作业类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objcc_WorkEduClsRelaEN.UpdDate) && GetStrLen(objcc_WorkEduClsRelaEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_WorkEduClsRelaEN.UpdUserId) && GetStrLen(objcc_WorkEduClsRelaEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_WorkEduClsRelaEN.Memo) && GetStrLen(objcc_WorkEduClsRelaEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objcc_WorkEduClsRelaEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_WorkEduClsRela">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_WorkEduClsRelaEN GetObjById_WorkEduClsRela(long lngId_WorkEduClsRela)
{
string strAction = "GetObjById_WorkEduClsRela";
string strErrMsg = string.Empty;
string strResult = "";
clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_WorkEduClsRela"] = lngId_WorkEduClsRela.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_WorkEduClsRelaEN = JsonConvert.DeserializeObject<clscc_WorkEduClsRelaEN>((string)jobjReturn["ReturnObj"]);
return objcc_WorkEduClsRelaEN;
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
 /// <param name = "lngId_WorkEduClsRela">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_WorkEduClsRelaEN GetObjById_WorkEduClsRela_WA_Cache(long lngId_WorkEduClsRela)
{
string strAction = "GetObjById_WorkEduClsRela_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_WorkEduClsRela"] = lngId_WorkEduClsRela.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_WorkEduClsRelaEN = JsonConvert.DeserializeObject<clscc_WorkEduClsRelaEN>((string)jobjReturn["ReturnObj"]);
return objcc_WorkEduClsRelaEN;
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
public static clscc_WorkEduClsRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN = null;
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
objcc_WorkEduClsRelaEN = JsonConvert.DeserializeObject<clscc_WorkEduClsRelaEN>((string)jobjReturn["ReturnObj"]);
return objcc_WorkEduClsRelaEN;
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
 /// <param name = "lngId_WorkEduClsRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_WorkEduClsRelaEN GetObjById_WorkEduClsRela_Cache(long lngId_WorkEduClsRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clscc_WorkEduClsRelaEN._CurrTabName_S);
List<clscc_WorkEduClsRelaEN> arrcc_WorkEduClsRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_WorkEduClsRelaEN> arrcc_WorkEduClsRelaObjLst_Sel =
from objcc_WorkEduClsRelaEN in arrcc_WorkEduClsRelaObjLst_Cache
where objcc_WorkEduClsRelaEN.Id_WorkEduClsRela == lngId_WorkEduClsRela
select objcc_WorkEduClsRelaEN;
if (arrcc_WorkEduClsRelaObjLst_Sel.Count() == 0)
{
   clscc_WorkEduClsRelaEN obj = clscc_WorkEduClsRelaWApi.GetObjById_WorkEduClsRela(lngId_WorkEduClsRela);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrcc_WorkEduClsRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_WorkEduClsRelaEN> GetObjLst(string strWhereCond)
{
 List<clscc_WorkEduClsRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkEduClsRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkEduClsRelaEN> GetObjLstById_WorkEduClsRelaLst(List<long> arrId_WorkEduClsRela)
{
 List<clscc_WorkEduClsRelaEN> arrObjLst = null; 
string strAction = "GetObjLstById_WorkEduClsRelaLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_WorkEduClsRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkEduClsRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngId_WorkEduClsRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clscc_WorkEduClsRelaEN> GetObjLstById_WorkEduClsRelaLst_Cache(List<long> arrId_WorkEduClsRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clscc_WorkEduClsRelaEN._CurrTabName_S);
List<clscc_WorkEduClsRelaEN> arrcc_WorkEduClsRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_WorkEduClsRelaEN> arrcc_WorkEduClsRelaObjLst_Sel =
from objcc_WorkEduClsRelaEN in arrcc_WorkEduClsRelaObjLst_Cache
where arrId_WorkEduClsRela.Contains(objcc_WorkEduClsRelaEN.Id_WorkEduClsRela)
select objcc_WorkEduClsRelaEN;
return arrcc_WorkEduClsRelaObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_WorkEduClsRelaEN> GetObjLstById_WorkEduClsRelaLst_WA_Cache(List<long> arrId_WorkEduClsRela)
{
 List<clscc_WorkEduClsRelaEN> arrObjLst = null; 
string strAction = "GetObjLstById_WorkEduClsRelaLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_WorkEduClsRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkEduClsRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkEduClsRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clscc_WorkEduClsRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkEduClsRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkEduClsRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clscc_WorkEduClsRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkEduClsRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkEduClsRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clscc_WorkEduClsRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkEduClsRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkEduClsRelaEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clscc_WorkEduClsRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkEduClsRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngId_WorkEduClsRela)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN = clscc_WorkEduClsRelaWApi.GetObjById_WorkEduClsRela(lngId_WorkEduClsRela);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngId_WorkEduClsRela.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_WorkEduClsRelaWApi.ReFreshCache();
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
public static int Delcc_WorkEduClsRelas(List<string> arrId_WorkEduClsRela)
{
string strAction = "Delcc_WorkEduClsRelas";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_WorkEduClsRela);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_WorkEduClsRelaWApi.ReFreshCache();
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
public static int Delcc_WorkEduClsRelasByCond(string strWhereCond)
{
string strAction = "Delcc_WorkEduClsRelasByCond";
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
public static bool AddNewRecord(clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_WorkEduClsRelaEN>(objcc_WorkEduClsRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkEduClsRelaWApi.ReFreshCache();
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
 /// <param name = "objcc_WorkEduClsRelaEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_WorkEduClsRelaEN>(objcc_WorkEduClsRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkEduClsRelaWApi.ReFreshCache();
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
public static bool UpdateRecord(clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN)
{
if (string.IsNullOrEmpty(objcc_WorkEduClsRelaEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_WorkEduClsRelaEN.Id_WorkEduClsRela, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_WorkEduClsRelaEN>(objcc_WorkEduClsRelaEN);
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
 /// <param name = "objcc_WorkEduClsRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objcc_WorkEduClsRelaEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_WorkEduClsRelaEN.Id_WorkEduClsRela, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_WorkEduClsRelaEN.Id_WorkEduClsRela, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_WorkEduClsRelaEN>(objcc_WorkEduClsRelaEN);
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
public static bool IsExist(long lngId_WorkEduClsRela)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_WorkEduClsRela"] = lngId_WorkEduClsRela.ToString()
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
 /// <param name = "objcc_WorkEduClsRelaENS">源对象</param>
 /// <param name = "objcc_WorkEduClsRelaENT">目标对象</param>
 public static void CopyTo(clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaENS, clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaENT)
{
try
{
objcc_WorkEduClsRelaENT.Id_WorkEduClsRela = objcc_WorkEduClsRelaENS.Id_WorkEduClsRela; //作业教学班关系流水号
objcc_WorkEduClsRelaENT.QuestionID = objcc_WorkEduClsRelaENS.QuestionID; //题目ID
objcc_WorkEduClsRelaENT.id_CurrEduCls = objcc_WorkEduClsRelaENS.id_CurrEduCls; //当前教学班流水号
objcc_WorkEduClsRelaENT.Scores = objcc_WorkEduClsRelaENS.Scores; //分值
objcc_WorkEduClsRelaENT.TeacherID = objcc_WorkEduClsRelaENS.TeacherID; //教师工号
objcc_WorkEduClsRelaENT.IsPublish = objcc_WorkEduClsRelaENS.IsPublish; //是否发布
objcc_WorkEduClsRelaENT.PubDate = objcc_WorkEduClsRelaENS.PubDate; //发布日期
objcc_WorkEduClsRelaENT.publisher = objcc_WorkEduClsRelaENS.publisher; //发布者Id
objcc_WorkEduClsRelaENT.SpecifyCompletionDate = objcc_WorkEduClsRelaENS.SpecifyCompletionDate; //指定完成日期
objcc_WorkEduClsRelaENT.IsCurrEduCls = objcc_WorkEduClsRelaENS.IsCurrEduCls; //是否为教学班作业
objcc_WorkEduClsRelaENT.IsGroupWork = objcc_WorkEduClsRelaENS.IsGroupWork; //是否为小组作业
objcc_WorkEduClsRelaENT.CourseStudentGroupId = objcc_WorkEduClsRelaENS.CourseStudentGroupId; //学生分组表流水号
objcc_WorkEduClsRelaENT.WorkTypeId = objcc_WorkEduClsRelaENS.WorkTypeId; //作业类型Id
objcc_WorkEduClsRelaENT.UpdDate = objcc_WorkEduClsRelaENS.UpdDate; //修改日期
objcc_WorkEduClsRelaENT.UpdUserId = objcc_WorkEduClsRelaENS.UpdUserId; //修改用户Id
objcc_WorkEduClsRelaENT.Memo = objcc_WorkEduClsRelaENS.Memo; //备注
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
public static DataTable ToDataTable(List<clscc_WorkEduClsRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clscc_WorkEduClsRelaEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clscc_WorkEduClsRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clscc_WorkEduClsRelaEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clscc_WorkEduClsRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clscc_WorkEduClsRelaEN.AttributeName)
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
if (clscc_WorkEduClsRelaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkEduClsRelaWApi没有刷新缓存机制(clscc_WorkEduClsRelaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_WorkEduClsRela");
//if (arrcc_WorkEduClsRelaObjLst_Cache == null)
//{
//arrcc_WorkEduClsRelaObjLst_Cache = await clscc_WorkEduClsRelaWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clscc_WorkEduClsRelaEN._CurrTabName_S);
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
if (clscc_WorkEduClsRelaWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscc_WorkEduClsRelaEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clscc_WorkEduClsRelaWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_WorkEduClsRelaEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clscc_WorkEduClsRelaEN._CurrTabName_S);
List<clscc_WorkEduClsRelaEN> arrcc_WorkEduClsRelaObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcc_WorkEduClsRelaObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clscc_WorkEduClsRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(concc_WorkEduClsRela.Id_WorkEduClsRela, Type.GetType("System.Int64"));
objDT.Columns.Add(concc_WorkEduClsRela.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkEduClsRela.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkEduClsRela.Scores, Type.GetType("System.Decimal"));
objDT.Columns.Add(concc_WorkEduClsRela.TeacherID, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkEduClsRela.IsPublish, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_WorkEduClsRela.PubDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkEduClsRela.publisher, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkEduClsRela.SpecifyCompletionDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkEduClsRela.IsCurrEduCls, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_WorkEduClsRela.IsGroupWork, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_WorkEduClsRela.CourseStudentGroupId, Type.GetType("System.Int64"));
objDT.Columns.Add(concc_WorkEduClsRela.WorkTypeId, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkEduClsRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkEduClsRela.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkEduClsRela.Memo, Type.GetType("System.String"));
foreach (clscc_WorkEduClsRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[concc_WorkEduClsRela.Id_WorkEduClsRela] = objInFor[concc_WorkEduClsRela.Id_WorkEduClsRela];
objDR[concc_WorkEduClsRela.QuestionID] = objInFor[concc_WorkEduClsRela.QuestionID];
objDR[concc_WorkEduClsRela.id_CurrEduCls] = objInFor[concc_WorkEduClsRela.id_CurrEduCls];
objDR[concc_WorkEduClsRela.Scores] = objInFor[concc_WorkEduClsRela.Scores];
objDR[concc_WorkEduClsRela.TeacherID] = objInFor[concc_WorkEduClsRela.TeacherID];
objDR[concc_WorkEduClsRela.IsPublish] = objInFor[concc_WorkEduClsRela.IsPublish];
objDR[concc_WorkEduClsRela.PubDate] = objInFor[concc_WorkEduClsRela.PubDate];
objDR[concc_WorkEduClsRela.publisher] = objInFor[concc_WorkEduClsRela.publisher];
objDR[concc_WorkEduClsRela.SpecifyCompletionDate] = objInFor[concc_WorkEduClsRela.SpecifyCompletionDate];
objDR[concc_WorkEduClsRela.IsCurrEduCls] = objInFor[concc_WorkEduClsRela.IsCurrEduCls];
objDR[concc_WorkEduClsRela.IsGroupWork] = objInFor[concc_WorkEduClsRela.IsGroupWork];
objDR[concc_WorkEduClsRela.CourseStudentGroupId] = objInFor[concc_WorkEduClsRela.CourseStudentGroupId];
objDR[concc_WorkEduClsRela.WorkTypeId] = objInFor[concc_WorkEduClsRela.WorkTypeId];
objDR[concc_WorkEduClsRela.UpdDate] = objInFor[concc_WorkEduClsRela.UpdDate];
objDR[concc_WorkEduClsRela.UpdUserId] = objInFor[concc_WorkEduClsRela.UpdUserId];
objDR[concc_WorkEduClsRela.Memo] = objInFor[concc_WorkEduClsRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 作业教学班关系(cc_WorkEduClsRela)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4cc_WorkEduClsRela : clsCommFun4BL
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
clscc_WorkEduClsRelaWApi.ReFreshThisCache();
clsvcc_WorkEduClsRelaWApi.ReFreshThisCache();
clsvcc_WorkEduClsRela4AppWApi.ReFreshThisCache();
}
}

}