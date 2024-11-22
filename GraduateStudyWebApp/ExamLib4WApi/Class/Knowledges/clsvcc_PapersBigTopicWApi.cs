
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_PapersBigTopicWApi
 表名:vcc_PapersBigTopic(01120078)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:44:29
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关
 模块英文名:Knowledges
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
public static class clsvcc_PapersBigTopicWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PapersBigTopicEN SetPapersBigTopicId(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN, string strPapersBigTopicId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPapersBigTopicId, 8, convcc_PapersBigTopic.PapersBigTopicId);
clsCheckSql.CheckFieldForeignKey(strPapersBigTopicId, 8, convcc_PapersBigTopic.PapersBigTopicId);
objvcc_PapersBigTopicEN.PapersBigTopicId = strPapersBigTopicId; //试卷大题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopic.PapersBigTopicId) == false)
{
objvcc_PapersBigTopicEN.dicFldComparisonOp.Add(convcc_PapersBigTopic.PapersBigTopicId, strComparisonOp);
}
else
{
objvcc_PapersBigTopicEN.dicFldComparisonOp[convcc_PapersBigTopic.PapersBigTopicId] = strComparisonOp;
}
}
return objvcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PapersBigTopicEN SetPapersBigTopicName(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN, string strPapersBigTopicName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPapersBigTopicName, convcc_PapersBigTopic.PapersBigTopicName);
clsCheckSql.CheckFieldLen(strPapersBigTopicName, 50, convcc_PapersBigTopic.PapersBigTopicName);
objvcc_PapersBigTopicEN.PapersBigTopicName = strPapersBigTopicName; //试卷大题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopic.PapersBigTopicName) == false)
{
objvcc_PapersBigTopicEN.dicFldComparisonOp.Add(convcc_PapersBigTopic.PapersBigTopicName, strComparisonOp);
}
else
{
objvcc_PapersBigTopicEN.dicFldComparisonOp[convcc_PapersBigTopic.PapersBigTopicName] = strComparisonOp;
}
}
return objvcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PapersBigTopicEN SetTopicDescription(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN, string strTopicDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTopicDescription, 100, convcc_PapersBigTopic.TopicDescription);
objvcc_PapersBigTopicEN.TopicDescription = strTopicDescription; //标题描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopic.TopicDescription) == false)
{
objvcc_PapersBigTopicEN.dicFldComparisonOp.Add(convcc_PapersBigTopic.TopicDescription, strComparisonOp);
}
else
{
objvcc_PapersBigTopicEN.dicFldComparisonOp[convcc_PapersBigTopic.TopicDescription] = strComparisonOp;
}
}
return objvcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PapersBigTopicEN SetTopicScores(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN, int intTopicScores, string strComparisonOp="")
	{
objvcc_PapersBigTopicEN.TopicScores = intTopicScores; //大题得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopic.TopicScores) == false)
{
objvcc_PapersBigTopicEN.dicFldComparisonOp.Add(convcc_PapersBigTopic.TopicScores, strComparisonOp);
}
else
{
objvcc_PapersBigTopicEN.dicFldComparisonOp[convcc_PapersBigTopic.TopicScores] = strComparisonOp;
}
}
return objvcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PapersBigTopicEN SetCourseExamPaperId(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseExamPaperId, convcc_PapersBigTopic.CourseExamPaperId);
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, convcc_PapersBigTopic.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, convcc_PapersBigTopic.CourseExamPaperId);
objvcc_PapersBigTopicEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopic.CourseExamPaperId) == false)
{
objvcc_PapersBigTopicEN.dicFldComparisonOp.Add(convcc_PapersBigTopic.CourseExamPaperId, strComparisonOp);
}
else
{
objvcc_PapersBigTopicEN.dicFldComparisonOp[convcc_PapersBigTopic.CourseExamPaperId] = strComparisonOp;
}
}
return objvcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PapersBigTopicEN SetExamPaperName(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN, string strExamPaperName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamPaperName, 500, convcc_PapersBigTopic.ExamPaperName);
objvcc_PapersBigTopicEN.ExamPaperName = strExamPaperName; //考卷名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopic.ExamPaperName) == false)
{
objvcc_PapersBigTopicEN.dicFldComparisonOp.Add(convcc_PapersBigTopic.ExamPaperName, strComparisonOp);
}
else
{
objvcc_PapersBigTopicEN.dicFldComparisonOp[convcc_PapersBigTopic.ExamPaperName] = strComparisonOp;
}
}
return objvcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PapersBigTopicEN SetQuestionTypeId(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionTypeId, convcc_PapersBigTopic.QuestionTypeId);
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convcc_PapersBigTopic.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convcc_PapersBigTopic.QuestionTypeId);
objvcc_PapersBigTopicEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopic.QuestionTypeId) == false)
{
objvcc_PapersBigTopicEN.dicFldComparisonOp.Add(convcc_PapersBigTopic.QuestionTypeId, strComparisonOp);
}
else
{
objvcc_PapersBigTopicEN.dicFldComparisonOp[convcc_PapersBigTopic.QuestionTypeId] = strComparisonOp;
}
}
return objvcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PapersBigTopicEN SetIsShow(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN, bool bolIsShow, string strComparisonOp="")
	{
objvcc_PapersBigTopicEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopic.IsShow) == false)
{
objvcc_PapersBigTopicEN.dicFldComparisonOp.Add(convcc_PapersBigTopic.IsShow, strComparisonOp);
}
else
{
objvcc_PapersBigTopicEN.dicFldComparisonOp[convcc_PapersBigTopic.IsShow] = strComparisonOp;
}
}
return objvcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PapersBigTopicEN SetOrderNum(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN, int intOrderNum, string strComparisonOp="")
	{
objvcc_PapersBigTopicEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopic.OrderNum) == false)
{
objvcc_PapersBigTopicEN.dicFldComparisonOp.Add(convcc_PapersBigTopic.OrderNum, strComparisonOp);
}
else
{
objvcc_PapersBigTopicEN.dicFldComparisonOp[convcc_PapersBigTopic.OrderNum] = strComparisonOp;
}
}
return objvcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PapersBigTopicEN SetUpdDate(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_PapersBigTopic.UpdDate);
objvcc_PapersBigTopicEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopic.UpdDate) == false)
{
objvcc_PapersBigTopicEN.dicFldComparisonOp.Add(convcc_PapersBigTopic.UpdDate, strComparisonOp);
}
else
{
objvcc_PapersBigTopicEN.dicFldComparisonOp[convcc_PapersBigTopic.UpdDate] = strComparisonOp;
}
}
return objvcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PapersBigTopicEN SetUpdUser(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convcc_PapersBigTopic.UpdUser);
objvcc_PapersBigTopicEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopic.UpdUser) == false)
{
objvcc_PapersBigTopicEN.dicFldComparisonOp.Add(convcc_PapersBigTopic.UpdUser, strComparisonOp);
}
else
{
objvcc_PapersBigTopicEN.dicFldComparisonOp[convcc_PapersBigTopic.UpdUser] = strComparisonOp;
}
}
return objvcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PapersBigTopicEN SetMemo(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_PapersBigTopic.Memo);
objvcc_PapersBigTopicEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopic.Memo) == false)
{
objvcc_PapersBigTopicEN.dicFldComparisonOp.Add(convcc_PapersBigTopic.Memo, strComparisonOp);
}
else
{
objvcc_PapersBigTopicEN.dicFldComparisonOp[convcc_PapersBigTopic.Memo] = strComparisonOp;
}
}
return objvcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PapersBigTopicEN SetQuestionTypeName(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN, string strQuestionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convcc_PapersBigTopic.QuestionTypeName);
objvcc_PapersBigTopicEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopic.QuestionTypeName) == false)
{
objvcc_PapersBigTopicEN.dicFldComparisonOp.Add(convcc_PapersBigTopic.QuestionTypeName, strComparisonOp);
}
else
{
objvcc_PapersBigTopicEN.dicFldComparisonOp[convcc_PapersBigTopic.QuestionTypeName] = strComparisonOp;
}
}
return objvcc_PapersBigTopicEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopic_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_PapersBigTopic_Cond.IsUpdated(convcc_PapersBigTopic.PapersBigTopicId) == true)
{
string strComparisonOp_PapersBigTopicId = objvcc_PapersBigTopic_Cond.dicFldComparisonOp[convcc_PapersBigTopic.PapersBigTopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopic.PapersBigTopicId, objvcc_PapersBigTopic_Cond.PapersBigTopicId, strComparisonOp_PapersBigTopicId);
}
if (objvcc_PapersBigTopic_Cond.IsUpdated(convcc_PapersBigTopic.PapersBigTopicName) == true)
{
string strComparisonOp_PapersBigTopicName = objvcc_PapersBigTopic_Cond.dicFldComparisonOp[convcc_PapersBigTopic.PapersBigTopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopic.PapersBigTopicName, objvcc_PapersBigTopic_Cond.PapersBigTopicName, strComparisonOp_PapersBigTopicName);
}
if (objvcc_PapersBigTopic_Cond.IsUpdated(convcc_PapersBigTopic.TopicDescription) == true)
{
string strComparisonOp_TopicDescription = objvcc_PapersBigTopic_Cond.dicFldComparisonOp[convcc_PapersBigTopic.TopicDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopic.TopicDescription, objvcc_PapersBigTopic_Cond.TopicDescription, strComparisonOp_TopicDescription);
}
if (objvcc_PapersBigTopic_Cond.IsUpdated(convcc_PapersBigTopic.TopicScores) == true)
{
string strComparisonOp_TopicScores = objvcc_PapersBigTopic_Cond.dicFldComparisonOp[convcc_PapersBigTopic.TopicScores];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PapersBigTopic.TopicScores, objvcc_PapersBigTopic_Cond.TopicScores, strComparisonOp_TopicScores);
}
if (objvcc_PapersBigTopic_Cond.IsUpdated(convcc_PapersBigTopic.CourseExamPaperId) == true)
{
string strComparisonOp_CourseExamPaperId = objvcc_PapersBigTopic_Cond.dicFldComparisonOp[convcc_PapersBigTopic.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopic.CourseExamPaperId, objvcc_PapersBigTopic_Cond.CourseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (objvcc_PapersBigTopic_Cond.IsUpdated(convcc_PapersBigTopic.ExamPaperName) == true)
{
string strComparisonOp_ExamPaperName = objvcc_PapersBigTopic_Cond.dicFldComparisonOp[convcc_PapersBigTopic.ExamPaperName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopic.ExamPaperName, objvcc_PapersBigTopic_Cond.ExamPaperName, strComparisonOp_ExamPaperName);
}
if (objvcc_PapersBigTopic_Cond.IsUpdated(convcc_PapersBigTopic.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objvcc_PapersBigTopic_Cond.dicFldComparisonOp[convcc_PapersBigTopic.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopic.QuestionTypeId, objvcc_PapersBigTopic_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objvcc_PapersBigTopic_Cond.IsUpdated(convcc_PapersBigTopic.IsShow) == true)
{
if (objvcc_PapersBigTopic_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_PapersBigTopic.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_PapersBigTopic.IsShow);
}
}
if (objvcc_PapersBigTopic_Cond.IsUpdated(convcc_PapersBigTopic.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvcc_PapersBigTopic_Cond.dicFldComparisonOp[convcc_PapersBigTopic.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PapersBigTopic.OrderNum, objvcc_PapersBigTopic_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvcc_PapersBigTopic_Cond.IsUpdated(convcc_PapersBigTopic.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_PapersBigTopic_Cond.dicFldComparisonOp[convcc_PapersBigTopic.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopic.UpdDate, objvcc_PapersBigTopic_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_PapersBigTopic_Cond.IsUpdated(convcc_PapersBigTopic.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvcc_PapersBigTopic_Cond.dicFldComparisonOp[convcc_PapersBigTopic.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopic.UpdUser, objvcc_PapersBigTopic_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvcc_PapersBigTopic_Cond.IsUpdated(convcc_PapersBigTopic.Memo) == true)
{
string strComparisonOp_Memo = objvcc_PapersBigTopic_Cond.dicFldComparisonOp[convcc_PapersBigTopic.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopic.Memo, objvcc_PapersBigTopic_Cond.Memo, strComparisonOp_Memo);
}
if (objvcc_PapersBigTopic_Cond.IsUpdated(convcc_PapersBigTopic.QuestionTypeName) == true)
{
string strComparisonOp_QuestionTypeName = objvcc_PapersBigTopic_Cond.dicFldComparisonOp[convcc_PapersBigTopic.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopic.QuestionTypeName, objvcc_PapersBigTopic_Cond.QuestionTypeName, strComparisonOp_QuestionTypeName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// 试卷大标题(vcc_PapersBigTopic)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_PapersBigTopicWApi
{
private static readonly string mstrApiControllerName = "vcc_PapersBigTopicApi";

 public clsvcc_PapersBigTopicWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPapersBigTopicId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_PapersBigTopicEN GetObjByPapersBigTopicId(string strPapersBigTopicId)
{
string strAction = "GetObjByPapersBigTopicId";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PapersBigTopicId"] = strPapersBigTopicId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_PapersBigTopicEN = JsonConvert.DeserializeObject<clsvcc_PapersBigTopicEN>((string)jobjReturn["ReturnObj"]);
return objvcc_PapersBigTopicEN;
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
 /// <param name = "strPapersBigTopicId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_PapersBigTopicEN GetObjByPapersBigTopicId_WA_Cache(string strPapersBigTopicId)
{
string strAction = "GetObjByPapersBigTopicId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PapersBigTopicId"] = strPapersBigTopicId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_PapersBigTopicEN = JsonConvert.DeserializeObject<clsvcc_PapersBigTopicEN>((string)jobjReturn["ReturnObj"]);
return objvcc_PapersBigTopicEN;
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
public static clsvcc_PapersBigTopicEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN = null;
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
objvcc_PapersBigTopicEN = JsonConvert.DeserializeObject<clsvcc_PapersBigTopicEN>((string)jobjReturn["ReturnObj"]);
return objvcc_PapersBigTopicEN;
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
 /// <param name = "strPapersBigTopicId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_PapersBigTopicEN GetObjByPapersBigTopicId_Cache(string strPapersBigTopicId)
{
if (string.IsNullOrEmpty(strPapersBigTopicId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_PapersBigTopicEN._CurrTabName_S);
List<clsvcc_PapersBigTopicEN> arrvcc_PapersBigTopicObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_PapersBigTopicEN> arrvcc_PapersBigTopicObjLst_Sel =
from objvcc_PapersBigTopicEN in arrvcc_PapersBigTopicObjLst_Cache
where objvcc_PapersBigTopicEN.PapersBigTopicId == strPapersBigTopicId
select objvcc_PapersBigTopicEN;
if (arrvcc_PapersBigTopicObjLst_Sel.Count() == 0)
{
   clsvcc_PapersBigTopicEN obj = clsvcc_PapersBigTopicWApi.GetObjByPapersBigTopicId(strPapersBigTopicId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_PapersBigTopicObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_PapersBigTopicEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_PapersBigTopicEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PapersBigTopicEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_PapersBigTopicEN> GetObjLstByPapersBigTopicIdLst(List<string> arrPapersBigTopicId)
{
 List<clsvcc_PapersBigTopicEN> arrObjLst = null; 
string strAction = "GetObjLstByPapersBigTopicIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPapersBigTopicId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PapersBigTopicEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strPapersBigTopicId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvcc_PapersBigTopicEN> GetObjLstByPapersBigTopicIdLst_Cache(List<string> arrPapersBigTopicId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_PapersBigTopicEN._CurrTabName_S);
List<clsvcc_PapersBigTopicEN> arrvcc_PapersBigTopicObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_PapersBigTopicEN> arrvcc_PapersBigTopicObjLst_Sel =
from objvcc_PapersBigTopicEN in arrvcc_PapersBigTopicObjLst_Cache
where arrPapersBigTopicId.Contains(objvcc_PapersBigTopicEN.PapersBigTopicId)
select objvcc_PapersBigTopicEN;
return arrvcc_PapersBigTopicObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_PapersBigTopicEN> GetObjLstByPapersBigTopicIdLst_WA_Cache(List<string> arrPapersBigTopicId)
{
 List<clsvcc_PapersBigTopicEN> arrObjLst = null; 
string strAction = "GetObjLstByPapersBigTopicIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPapersBigTopicId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PapersBigTopicEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_PapersBigTopicEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_PapersBigTopicEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PapersBigTopicEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_PapersBigTopicEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_PapersBigTopicEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PapersBigTopicEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_PapersBigTopicEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_PapersBigTopicEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PapersBigTopicEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_PapersBigTopicEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_PapersBigTopicEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PapersBigTopicEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strPapersBigTopicId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PapersBigTopicId"] = strPapersBigTopicId
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
 /// <param name = "objvcc_PapersBigTopicENS">源对象</param>
 /// <param name = "objvcc_PapersBigTopicENT">目标对象</param>
 public static void CopyTo(clsvcc_PapersBigTopicEN objvcc_PapersBigTopicENS, clsvcc_PapersBigTopicEN objvcc_PapersBigTopicENT)
{
try
{
objvcc_PapersBigTopicENT.PapersBigTopicId = objvcc_PapersBigTopicENS.PapersBigTopicId; //试卷大题目Id
objvcc_PapersBigTopicENT.PapersBigTopicName = objvcc_PapersBigTopicENS.PapersBigTopicName; //试卷大题目名称
objvcc_PapersBigTopicENT.TopicDescription = objvcc_PapersBigTopicENS.TopicDescription; //标题描述
objvcc_PapersBigTopicENT.TopicScores = objvcc_PapersBigTopicENS.TopicScores; //大题得分
objvcc_PapersBigTopicENT.CourseExamPaperId = objvcc_PapersBigTopicENS.CourseExamPaperId; //考卷流水号
objvcc_PapersBigTopicENT.ExamPaperName = objvcc_PapersBigTopicENS.ExamPaperName; //考卷名称
objvcc_PapersBigTopicENT.QuestionTypeId = objvcc_PapersBigTopicENS.QuestionTypeId; //题目类型Id
objvcc_PapersBigTopicENT.IsShow = objvcc_PapersBigTopicENS.IsShow; //是否启用
objvcc_PapersBigTopicENT.OrderNum = objvcc_PapersBigTopicENS.OrderNum; //序号
objvcc_PapersBigTopicENT.UpdDate = objvcc_PapersBigTopicENS.UpdDate; //修改日期
objvcc_PapersBigTopicENT.UpdUser = objvcc_PapersBigTopicENS.UpdUser; //修改人
objvcc_PapersBigTopicENT.Memo = objvcc_PapersBigTopicENS.Memo; //备注
objvcc_PapersBigTopicENT.QuestionTypeName = objvcc_PapersBigTopicENS.QuestionTypeName; //题目类型名
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
public static DataTable ToDataTable(List<clsvcc_PapersBigTopicEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_PapersBigTopicEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_PapersBigTopicEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_PapersBigTopicEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_PapersBigTopicEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_PapersBigTopicEN.AttributeName)
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
if (clsQuestionTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeWApi没有刷新缓存机制(clsQuestionTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseExamPaperWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseExamPaperWApi没有刷新缓存机制(clscc_CourseExamPaperWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_PapersBigTopicWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_PapersBigTopicWApi没有刷新缓存机制(clscc_PapersBigTopicWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PapersBigTopicId");
//if (arrvcc_PapersBigTopicObjLst_Cache == null)
//{
//arrvcc_PapersBigTopicObjLst_Cache = await clsvcc_PapersBigTopicWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvcc_PapersBigTopicEN._CurrTabName_S);
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
public static List<clsvcc_PapersBigTopicEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvcc_PapersBigTopicEN._CurrTabName_S);
List<clsvcc_PapersBigTopicEN> arrvcc_PapersBigTopicObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_PapersBigTopicObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_PapersBigTopicEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_PapersBigTopic.PapersBigTopicId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PapersBigTopic.PapersBigTopicName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PapersBigTopic.TopicDescription, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PapersBigTopic.TopicScores, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_PapersBigTopic.CourseExamPaperId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PapersBigTopic.ExamPaperName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PapersBigTopic.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PapersBigTopic.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_PapersBigTopic.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_PapersBigTopic.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PapersBigTopic.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PapersBigTopic.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PapersBigTopic.QuestionTypeName, Type.GetType("System.String"));
foreach (clsvcc_PapersBigTopicEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_PapersBigTopic.PapersBigTopicId] = objInFor[convcc_PapersBigTopic.PapersBigTopicId];
objDR[convcc_PapersBigTopic.PapersBigTopicName] = objInFor[convcc_PapersBigTopic.PapersBigTopicName];
objDR[convcc_PapersBigTopic.TopicDescription] = objInFor[convcc_PapersBigTopic.TopicDescription];
objDR[convcc_PapersBigTopic.TopicScores] = objInFor[convcc_PapersBigTopic.TopicScores];
objDR[convcc_PapersBigTopic.CourseExamPaperId] = objInFor[convcc_PapersBigTopic.CourseExamPaperId];
objDR[convcc_PapersBigTopic.ExamPaperName] = objInFor[convcc_PapersBigTopic.ExamPaperName];
objDR[convcc_PapersBigTopic.QuestionTypeId] = objInFor[convcc_PapersBigTopic.QuestionTypeId];
objDR[convcc_PapersBigTopic.IsShow] = objInFor[convcc_PapersBigTopic.IsShow];
objDR[convcc_PapersBigTopic.OrderNum] = objInFor[convcc_PapersBigTopic.OrderNum];
objDR[convcc_PapersBigTopic.UpdDate] = objInFor[convcc_PapersBigTopic.UpdDate];
objDR[convcc_PapersBigTopic.UpdUser] = objInFor[convcc_PapersBigTopic.UpdUser];
objDR[convcc_PapersBigTopic.Memo] = objInFor[convcc_PapersBigTopic.Memo];
objDR[convcc_PapersBigTopic.QuestionTypeName] = objInFor[convcc_PapersBigTopic.QuestionTypeName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}