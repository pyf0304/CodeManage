
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_PapersBigTopicWApi
 表名:cc_PapersBigTopic(01120077)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:41:19
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
public static class clscc_PapersBigTopicWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PapersBigTopicEN SetPapersBigTopicId(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN, string strPapersBigTopicId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPapersBigTopicId, 8, concc_PapersBigTopic.PapersBigTopicId);
clsCheckSql.CheckFieldForeignKey(strPapersBigTopicId, 8, concc_PapersBigTopic.PapersBigTopicId);
objcc_PapersBigTopicEN.PapersBigTopicId = strPapersBigTopicId; //试卷大题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopic.PapersBigTopicId) == false)
{
objcc_PapersBigTopicEN.dicFldComparisonOp.Add(concc_PapersBigTopic.PapersBigTopicId, strComparisonOp);
}
else
{
objcc_PapersBigTopicEN.dicFldComparisonOp[concc_PapersBigTopic.PapersBigTopicId] = strComparisonOp;
}
}
return objcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PapersBigTopicEN SetPapersBigTopicName(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN, string strPapersBigTopicName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPapersBigTopicName, concc_PapersBigTopic.PapersBigTopicName);
clsCheckSql.CheckFieldLen(strPapersBigTopicName, 50, concc_PapersBigTopic.PapersBigTopicName);
objcc_PapersBigTopicEN.PapersBigTopicName = strPapersBigTopicName; //试卷大题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopic.PapersBigTopicName) == false)
{
objcc_PapersBigTopicEN.dicFldComparisonOp.Add(concc_PapersBigTopic.PapersBigTopicName, strComparisonOp);
}
else
{
objcc_PapersBigTopicEN.dicFldComparisonOp[concc_PapersBigTopic.PapersBigTopicName] = strComparisonOp;
}
}
return objcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PapersBigTopicEN SetTopicDescription(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN, string strTopicDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTopicDescription, 100, concc_PapersBigTopic.TopicDescription);
objcc_PapersBigTopicEN.TopicDescription = strTopicDescription; //标题描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopic.TopicDescription) == false)
{
objcc_PapersBigTopicEN.dicFldComparisonOp.Add(concc_PapersBigTopic.TopicDescription, strComparisonOp);
}
else
{
objcc_PapersBigTopicEN.dicFldComparisonOp[concc_PapersBigTopic.TopicDescription] = strComparisonOp;
}
}
return objcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PapersBigTopicEN SetTopicScores(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN, int intTopicScores, string strComparisonOp="")
	{
objcc_PapersBigTopicEN.TopicScores = intTopicScores; //大题得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopic.TopicScores) == false)
{
objcc_PapersBigTopicEN.dicFldComparisonOp.Add(concc_PapersBigTopic.TopicScores, strComparisonOp);
}
else
{
objcc_PapersBigTopicEN.dicFldComparisonOp[concc_PapersBigTopic.TopicScores] = strComparisonOp;
}
}
return objcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PapersBigTopicEN SetCourseExamPaperId(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseExamPaperId, concc_PapersBigTopic.CourseExamPaperId);
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, concc_PapersBigTopic.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, concc_PapersBigTopic.CourseExamPaperId);
objcc_PapersBigTopicEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopic.CourseExamPaperId) == false)
{
objcc_PapersBigTopicEN.dicFldComparisonOp.Add(concc_PapersBigTopic.CourseExamPaperId, strComparisonOp);
}
else
{
objcc_PapersBigTopicEN.dicFldComparisonOp[concc_PapersBigTopic.CourseExamPaperId] = strComparisonOp;
}
}
return objcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PapersBigTopicEN SetQuestionTypeId(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, concc_PapersBigTopic.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, concc_PapersBigTopic.QuestionTypeId);
objcc_PapersBigTopicEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopic.QuestionTypeId) == false)
{
objcc_PapersBigTopicEN.dicFldComparisonOp.Add(concc_PapersBigTopic.QuestionTypeId, strComparisonOp);
}
else
{
objcc_PapersBigTopicEN.dicFldComparisonOp[concc_PapersBigTopic.QuestionTypeId] = strComparisonOp;
}
}
return objcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PapersBigTopicEN SetIsShow(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN, bool bolIsShow, string strComparisonOp="")
	{
objcc_PapersBigTopicEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopic.IsShow) == false)
{
objcc_PapersBigTopicEN.dicFldComparisonOp.Add(concc_PapersBigTopic.IsShow, strComparisonOp);
}
else
{
objcc_PapersBigTopicEN.dicFldComparisonOp[concc_PapersBigTopic.IsShow] = strComparisonOp;
}
}
return objcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PapersBigTopicEN SetOrderNum(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN, int intOrderNum, string strComparisonOp="")
	{
objcc_PapersBigTopicEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopic.OrderNum) == false)
{
objcc_PapersBigTopicEN.dicFldComparisonOp.Add(concc_PapersBigTopic.OrderNum, strComparisonOp);
}
else
{
objcc_PapersBigTopicEN.dicFldComparisonOp[concc_PapersBigTopic.OrderNum] = strComparisonOp;
}
}
return objcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PapersBigTopicEN SetUpdDate(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_PapersBigTopic.UpdDate);
objcc_PapersBigTopicEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopic.UpdDate) == false)
{
objcc_PapersBigTopicEN.dicFldComparisonOp.Add(concc_PapersBigTopic.UpdDate, strComparisonOp);
}
else
{
objcc_PapersBigTopicEN.dicFldComparisonOp[concc_PapersBigTopic.UpdDate] = strComparisonOp;
}
}
return objcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PapersBigTopicEN SetUpdUser(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, concc_PapersBigTopic.UpdUser);
objcc_PapersBigTopicEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopic.UpdUser) == false)
{
objcc_PapersBigTopicEN.dicFldComparisonOp.Add(concc_PapersBigTopic.UpdUser, strComparisonOp);
}
else
{
objcc_PapersBigTopicEN.dicFldComparisonOp[concc_PapersBigTopic.UpdUser] = strComparisonOp;
}
}
return objcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PapersBigTopicEN SetMemo(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_PapersBigTopic.Memo);
objcc_PapersBigTopicEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopic.Memo) == false)
{
objcc_PapersBigTopicEN.dicFldComparisonOp.Add(concc_PapersBigTopic.Memo, strComparisonOp);
}
else
{
objcc_PapersBigTopicEN.dicFldComparisonOp[concc_PapersBigTopic.Memo] = strComparisonOp;
}
}
return objcc_PapersBigTopicEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_PapersBigTopicEN objcc_PapersBigTopic_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_PapersBigTopic_Cond.IsUpdated(concc_PapersBigTopic.PapersBigTopicId) == true)
{
string strComparisonOp_PapersBigTopicId = objcc_PapersBigTopic_Cond.dicFldComparisonOp[concc_PapersBigTopic.PapersBigTopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PapersBigTopic.PapersBigTopicId, objcc_PapersBigTopic_Cond.PapersBigTopicId, strComparisonOp_PapersBigTopicId);
}
if (objcc_PapersBigTopic_Cond.IsUpdated(concc_PapersBigTopic.PapersBigTopicName) == true)
{
string strComparisonOp_PapersBigTopicName = objcc_PapersBigTopic_Cond.dicFldComparisonOp[concc_PapersBigTopic.PapersBigTopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PapersBigTopic.PapersBigTopicName, objcc_PapersBigTopic_Cond.PapersBigTopicName, strComparisonOp_PapersBigTopicName);
}
if (objcc_PapersBigTopic_Cond.IsUpdated(concc_PapersBigTopic.TopicDescription) == true)
{
string strComparisonOp_TopicDescription = objcc_PapersBigTopic_Cond.dicFldComparisonOp[concc_PapersBigTopic.TopicDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PapersBigTopic.TopicDescription, objcc_PapersBigTopic_Cond.TopicDescription, strComparisonOp_TopicDescription);
}
if (objcc_PapersBigTopic_Cond.IsUpdated(concc_PapersBigTopic.TopicScores) == true)
{
string strComparisonOp_TopicScores = objcc_PapersBigTopic_Cond.dicFldComparisonOp[concc_PapersBigTopic.TopicScores];
strWhereCond += string.Format(" And {0} {2} {1}", concc_PapersBigTopic.TopicScores, objcc_PapersBigTopic_Cond.TopicScores, strComparisonOp_TopicScores);
}
if (objcc_PapersBigTopic_Cond.IsUpdated(concc_PapersBigTopic.CourseExamPaperId) == true)
{
string strComparisonOp_CourseExamPaperId = objcc_PapersBigTopic_Cond.dicFldComparisonOp[concc_PapersBigTopic.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PapersBigTopic.CourseExamPaperId, objcc_PapersBigTopic_Cond.CourseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (objcc_PapersBigTopic_Cond.IsUpdated(concc_PapersBigTopic.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objcc_PapersBigTopic_Cond.dicFldComparisonOp[concc_PapersBigTopic.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PapersBigTopic.QuestionTypeId, objcc_PapersBigTopic_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objcc_PapersBigTopic_Cond.IsUpdated(concc_PapersBigTopic.IsShow) == true)
{
if (objcc_PapersBigTopic_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_PapersBigTopic.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_PapersBigTopic.IsShow);
}
}
if (objcc_PapersBigTopic_Cond.IsUpdated(concc_PapersBigTopic.OrderNum) == true)
{
string strComparisonOp_OrderNum = objcc_PapersBigTopic_Cond.dicFldComparisonOp[concc_PapersBigTopic.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", concc_PapersBigTopic.OrderNum, objcc_PapersBigTopic_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objcc_PapersBigTopic_Cond.IsUpdated(concc_PapersBigTopic.UpdDate) == true)
{
string strComparisonOp_UpdDate = objcc_PapersBigTopic_Cond.dicFldComparisonOp[concc_PapersBigTopic.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PapersBigTopic.UpdDate, objcc_PapersBigTopic_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objcc_PapersBigTopic_Cond.IsUpdated(concc_PapersBigTopic.UpdUser) == true)
{
string strComparisonOp_UpdUser = objcc_PapersBigTopic_Cond.dicFldComparisonOp[concc_PapersBigTopic.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PapersBigTopic.UpdUser, objcc_PapersBigTopic_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objcc_PapersBigTopic_Cond.IsUpdated(concc_PapersBigTopic.Memo) == true)
{
string strComparisonOp_Memo = objcc_PapersBigTopic_Cond.dicFldComparisonOp[concc_PapersBigTopic.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PapersBigTopic.Memo, objcc_PapersBigTopic_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
 if (string.IsNullOrEmpty(objcc_PapersBigTopicEN.PapersBigTopicId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objcc_PapersBigTopicEN.sf_UpdFldSetStr = objcc_PapersBigTopicEN.getsf_UpdFldSetStr();
clscc_PapersBigTopicWApi.CheckPropertyNew(objcc_PapersBigTopicEN); 
bool bolResult = clscc_PapersBigTopicWApi.UpdateRecord(objcc_PapersBigTopicEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
 if (string.IsNullOrEmpty(objcc_PapersBigTopicEN.PapersBigTopicId) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clscc_PapersBigTopicWApi.IsExist(objcc_PapersBigTopicEN.PapersBigTopicId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objcc_PapersBigTopicEN.PapersBigTopicId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clscc_PapersBigTopicWApi.CheckPropertyNew(objcc_PapersBigTopicEN); 
bool bolResult = clscc_PapersBigTopicWApi.AddNewRecord(objcc_PapersBigTopicEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
try
{
clscc_PapersBigTopicWApi.CheckPropertyNew(objcc_PapersBigTopicEN); 
string strPapersBigTopicId = clscc_PapersBigTopicWApi.AddNewRecordWithMaxId(objcc_PapersBigTopicEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicWApi.ReFreshCache();
return strPapersBigTopicId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
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
 /// <param name = "objcc_PapersBigTopicEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN, string strWhereCond)
{
try
{
clscc_PapersBigTopicWApi.CheckPropertyNew(objcc_PapersBigTopicEN); 
bool bolResult = clscc_PapersBigTopicWApi.UpdateWithCondition(objcc_PapersBigTopicEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicWApi.ReFreshCache();
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
 /// 试卷大题目(cc_PapersBigTopic)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clscc_PapersBigTopicWApi
{
private static readonly string mstrApiControllerName = "cc_PapersBigTopicApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clscc_PapersBigTopicWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_PapersBigTopicId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[试卷大题目]...","0");
List<clscc_PapersBigTopicEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="PapersBigTopicId";
objDDL.DataTextField="PapersBigTopicName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_PapersBigTopicId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", concc_PapersBigTopic.PapersBigTopicId); 
List<clscc_PapersBigTopicEN> arrObjLst = clscc_PapersBigTopicWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clscc_PapersBigTopicEN objcc_PapersBigTopicEN = new clscc_PapersBigTopicEN()
{
PapersBigTopicId = "0",
PapersBigTopicName = "选[试卷大题目]..."
};
arrObjLst.Insert(0, objcc_PapersBigTopicEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = concc_PapersBigTopic.PapersBigTopicId;
objComboBox.DisplayMember = concc_PapersBigTopic.PapersBigTopicName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
if (!Object.Equals(null, objcc_PapersBigTopicEN.PapersBigTopicId) && GetStrLen(objcc_PapersBigTopicEN.PapersBigTopicId) > 8)
{
 throw new Exception("字段[试卷大题目Id]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_PapersBigTopicEN.PapersBigTopicName) && GetStrLen(objcc_PapersBigTopicEN.PapersBigTopicName) > 50)
{
 throw new Exception("字段[试卷大题目名称]的长度不能超过50!");
}
if (!Object.Equals(null, objcc_PapersBigTopicEN.TopicDescription) && GetStrLen(objcc_PapersBigTopicEN.TopicDescription) > 100)
{
 throw new Exception("字段[标题描述]的长度不能超过100!");
}
if (!Object.Equals(null, objcc_PapersBigTopicEN.CourseExamPaperId) && GetStrLen(objcc_PapersBigTopicEN.CourseExamPaperId) > 8)
{
 throw new Exception("字段[考卷流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_PapersBigTopicEN.QuestionTypeId) && GetStrLen(objcc_PapersBigTopicEN.QuestionTypeId) > 2)
{
 throw new Exception("字段[题目类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objcc_PapersBigTopicEN.UpdDate) && GetStrLen(objcc_PapersBigTopicEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_PapersBigTopicEN.UpdUser) && GetStrLen(objcc_PapersBigTopicEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_PapersBigTopicEN.Memo) && GetStrLen(objcc_PapersBigTopicEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objcc_PapersBigTopicEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPapersBigTopicId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_PapersBigTopicEN GetObjByPapersBigTopicId(string strPapersBigTopicId)
{
string strAction = "GetObjByPapersBigTopicId";
string strErrMsg = string.Empty;
string strResult = "";
clscc_PapersBigTopicEN objcc_PapersBigTopicEN = null;
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
objcc_PapersBigTopicEN = JsonConvert.DeserializeObject<clscc_PapersBigTopicEN>((string)jobjReturn["ReturnObj"]);
return objcc_PapersBigTopicEN;
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
public static clscc_PapersBigTopicEN GetObjByPapersBigTopicId_WA_Cache(string strPapersBigTopicId)
{
string strAction = "GetObjByPapersBigTopicId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clscc_PapersBigTopicEN objcc_PapersBigTopicEN = null;
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
objcc_PapersBigTopicEN = JsonConvert.DeserializeObject<clscc_PapersBigTopicEN>((string)jobjReturn["ReturnObj"]);
return objcc_PapersBigTopicEN;
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
public static clscc_PapersBigTopicEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clscc_PapersBigTopicEN objcc_PapersBigTopicEN = null;
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
objcc_PapersBigTopicEN = JsonConvert.DeserializeObject<clscc_PapersBigTopicEN>((string)jobjReturn["ReturnObj"]);
return objcc_PapersBigTopicEN;
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
public static clscc_PapersBigTopicEN GetObjByPapersBigTopicId_Cache(string strPapersBigTopicId)
{
if (string.IsNullOrEmpty(strPapersBigTopicId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clscc_PapersBigTopicEN._CurrTabName_S);
List<clscc_PapersBigTopicEN> arrcc_PapersBigTopicObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_PapersBigTopicEN> arrcc_PapersBigTopicObjLst_Sel =
from objcc_PapersBigTopicEN in arrcc_PapersBigTopicObjLst_Cache
where objcc_PapersBigTopicEN.PapersBigTopicId == strPapersBigTopicId
select objcc_PapersBigTopicEN;
if (arrcc_PapersBigTopicObjLst_Sel.Count() == 0)
{
   clscc_PapersBigTopicEN obj = clscc_PapersBigTopicWApi.GetObjByPapersBigTopicId(strPapersBigTopicId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrcc_PapersBigTopicObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strPapersBigTopicId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetPapersBigTopicNameByPapersBigTopicId_Cache(string strPapersBigTopicId)
{
if (string.IsNullOrEmpty(strPapersBigTopicId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clscc_PapersBigTopicEN._CurrTabName_S);
List<clscc_PapersBigTopicEN> arrcc_PapersBigTopicObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_PapersBigTopicEN> arrcc_PapersBigTopicObjLst_Sel1 =
from objcc_PapersBigTopicEN in arrcc_PapersBigTopicObjLst_Cache
where objcc_PapersBigTopicEN.PapersBigTopicId == strPapersBigTopicId
select objcc_PapersBigTopicEN;
List <clscc_PapersBigTopicEN> arrcc_PapersBigTopicObjLst_Sel = new List<clscc_PapersBigTopicEN>();
foreach (clscc_PapersBigTopicEN obj in arrcc_PapersBigTopicObjLst_Sel1)
{
arrcc_PapersBigTopicObjLst_Sel.Add(obj);
}
if (arrcc_PapersBigTopicObjLst_Sel.Count > 0)
{
return arrcc_PapersBigTopicObjLst_Sel[0].PapersBigTopicName;
}
string strErrMsgForGetObjById = string.Format("在cc_PapersBigTopic对象缓存列表中,找不到记录[PapersBigTopicId = {0}](函数:{1})", strPapersBigTopicId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clscc_PapersBigTopicBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strPapersBigTopicId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByPapersBigTopicId_Cache(string strPapersBigTopicId)
{
if (string.IsNullOrEmpty(strPapersBigTopicId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clscc_PapersBigTopicEN._CurrTabName_S);
List<clscc_PapersBigTopicEN> arrcc_PapersBigTopicObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_PapersBigTopicEN> arrcc_PapersBigTopicObjLst_Sel1 =
from objcc_PapersBigTopicEN in arrcc_PapersBigTopicObjLst_Cache
where objcc_PapersBigTopicEN.PapersBigTopicId == strPapersBigTopicId
select objcc_PapersBigTopicEN;
List <clscc_PapersBigTopicEN> arrcc_PapersBigTopicObjLst_Sel = new List<clscc_PapersBigTopicEN>();
foreach (clscc_PapersBigTopicEN obj in arrcc_PapersBigTopicObjLst_Sel1)
{
arrcc_PapersBigTopicObjLst_Sel.Add(obj);
}
if (arrcc_PapersBigTopicObjLst_Sel.Count > 0)
{
return arrcc_PapersBigTopicObjLst_Sel[0].PapersBigTopicName;
}
string strErrMsgForGetObjById = string.Format("在cc_PapersBigTopic对象缓存列表中,找不到记录的相关名称[PapersBigTopicId = {0}](函数:{1})", strPapersBigTopicId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clscc_PapersBigTopicBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_PapersBigTopicEN> GetObjLst(string strWhereCond)
{
 List<clscc_PapersBigTopicEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_PapersBigTopicEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_PapersBigTopicEN> GetObjLstByPapersBigTopicIdLst(List<string> arrPapersBigTopicId)
{
 List<clscc_PapersBigTopicEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_PapersBigTopicEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clscc_PapersBigTopicEN> GetObjLstByPapersBigTopicIdLst_Cache(List<string> arrPapersBigTopicId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clscc_PapersBigTopicEN._CurrTabName_S);
List<clscc_PapersBigTopicEN> arrcc_PapersBigTopicObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_PapersBigTopicEN> arrcc_PapersBigTopicObjLst_Sel =
from objcc_PapersBigTopicEN in arrcc_PapersBigTopicObjLst_Cache
where arrPapersBigTopicId.Contains(objcc_PapersBigTopicEN.PapersBigTopicId)
select objcc_PapersBigTopicEN;
return arrcc_PapersBigTopicObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_PapersBigTopicEN> GetObjLstByPapersBigTopicIdLst_WA_Cache(List<string> arrPapersBigTopicId)
{
 List<clscc_PapersBigTopicEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_PapersBigTopicEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_PapersBigTopicEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clscc_PapersBigTopicEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_PapersBigTopicEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_PapersBigTopicEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clscc_PapersBigTopicEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_PapersBigTopicEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_PapersBigTopicEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clscc_PapersBigTopicEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_PapersBigTopicEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_PapersBigTopicEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clscc_PapersBigTopicEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_PapersBigTopicEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strPapersBigTopicId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clscc_PapersBigTopicEN objcc_PapersBigTopicEN = clscc_PapersBigTopicWApi.GetObjByPapersBigTopicId(strPapersBigTopicId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strPapersBigTopicId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_PapersBigTopicWApi.ReFreshCache();
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
public static int Delcc_PapersBigTopics(List<string> arrPapersBigTopicId)
{
string strAction = "Delcc_PapersBigTopics";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPapersBigTopicId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_PapersBigTopicWApi.ReFreshCache();
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
public static int Delcc_PapersBigTopicsByCond(string strWhereCond)
{
string strAction = "Delcc_PapersBigTopicsByCond";
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
public static bool AddNewRecord(clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_PapersBigTopicEN>(objcc_PapersBigTopicEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicWApi.ReFreshCache();
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
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>是否成功?</returns>
public static string AddNewRecordWithMaxId(clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_PapersBigTopicEN>(objcc_PapersBigTopicEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicWApi.ReFreshCache();
var strPapersBigTopicId = (string)jobjReturn["ReturnStr"];
return strPapersBigTopicId;
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
public static bool UpdateRecord(clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
if (string.IsNullOrEmpty(objcc_PapersBigTopicEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_PapersBigTopicEN.PapersBigTopicId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_PapersBigTopicEN>(objcc_PapersBigTopicEN);
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
 /// <param name = "objcc_PapersBigTopicEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clscc_PapersBigTopicEN objcc_PapersBigTopicEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objcc_PapersBigTopicEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_PapersBigTopicEN.PapersBigTopicId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_PapersBigTopicEN.PapersBigTopicId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_PapersBigTopicEN>(objcc_PapersBigTopicEN);
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
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrefix", strPrefix);
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objcc_PapersBigTopicENS">源对象</param>
 /// <param name = "objcc_PapersBigTopicENT">目标对象</param>
 public static void CopyTo(clscc_PapersBigTopicEN objcc_PapersBigTopicENS, clscc_PapersBigTopicEN objcc_PapersBigTopicENT)
{
try
{
objcc_PapersBigTopicENT.PapersBigTopicId = objcc_PapersBigTopicENS.PapersBigTopicId; //试卷大题目Id
objcc_PapersBigTopicENT.PapersBigTopicName = objcc_PapersBigTopicENS.PapersBigTopicName; //试卷大题目名称
objcc_PapersBigTopicENT.TopicDescription = objcc_PapersBigTopicENS.TopicDescription; //标题描述
objcc_PapersBigTopicENT.TopicScores = objcc_PapersBigTopicENS.TopicScores; //大题得分
objcc_PapersBigTopicENT.CourseExamPaperId = objcc_PapersBigTopicENS.CourseExamPaperId; //考卷流水号
objcc_PapersBigTopicENT.QuestionTypeId = objcc_PapersBigTopicENS.QuestionTypeId; //题目类型Id
objcc_PapersBigTopicENT.IsShow = objcc_PapersBigTopicENS.IsShow; //是否启用
objcc_PapersBigTopicENT.OrderNum = objcc_PapersBigTopicENS.OrderNum; //序号
objcc_PapersBigTopicENT.UpdDate = objcc_PapersBigTopicENS.UpdDate; //修改日期
objcc_PapersBigTopicENT.UpdUser = objcc_PapersBigTopicENS.UpdUser; //修改人
objcc_PapersBigTopicENT.Memo = objcc_PapersBigTopicENS.Memo; //备注
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
public static DataTable ToDataTable(List<clscc_PapersBigTopicEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clscc_PapersBigTopicEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clscc_PapersBigTopicEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clscc_PapersBigTopicEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clscc_PapersBigTopicEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clscc_PapersBigTopicEN.AttributeName)
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
if (clscc_PapersBigTopicWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_PapersBigTopicWApi没有刷新缓存机制(clscc_PapersBigTopicWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PapersBigTopicId");
//if (arrcc_PapersBigTopicObjLst_Cache == null)
//{
//arrcc_PapersBigTopicObjLst_Cache = await clscc_PapersBigTopicWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clscc_PapersBigTopicEN._CurrTabName_S);
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
if (clscc_PapersBigTopicWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscc_PapersBigTopicEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clscc_PapersBigTopicWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_PapersBigTopicEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clscc_PapersBigTopicEN._CurrTabName_S);
List<clscc_PapersBigTopicEN> arrcc_PapersBigTopicObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcc_PapersBigTopicObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clscc_PapersBigTopicEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(concc_PapersBigTopic.PapersBigTopicId, Type.GetType("System.String"));
objDT.Columns.Add(concc_PapersBigTopic.PapersBigTopicName, Type.GetType("System.String"));
objDT.Columns.Add(concc_PapersBigTopic.TopicDescription, Type.GetType("System.String"));
objDT.Columns.Add(concc_PapersBigTopic.TopicScores, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_PapersBigTopic.CourseExamPaperId, Type.GetType("System.String"));
objDT.Columns.Add(concc_PapersBigTopic.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(concc_PapersBigTopic.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_PapersBigTopic.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_PapersBigTopic.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_PapersBigTopic.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(concc_PapersBigTopic.Memo, Type.GetType("System.String"));
foreach (clscc_PapersBigTopicEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[concc_PapersBigTopic.PapersBigTopicId] = objInFor[concc_PapersBigTopic.PapersBigTopicId];
objDR[concc_PapersBigTopic.PapersBigTopicName] = objInFor[concc_PapersBigTopic.PapersBigTopicName];
objDR[concc_PapersBigTopic.TopicDescription] = objInFor[concc_PapersBigTopic.TopicDescription];
objDR[concc_PapersBigTopic.TopicScores] = objInFor[concc_PapersBigTopic.TopicScores];
objDR[concc_PapersBigTopic.CourseExamPaperId] = objInFor[concc_PapersBigTopic.CourseExamPaperId];
objDR[concc_PapersBigTopic.QuestionTypeId] = objInFor[concc_PapersBigTopic.QuestionTypeId];
objDR[concc_PapersBigTopic.IsShow] = objInFor[concc_PapersBigTopic.IsShow];
objDR[concc_PapersBigTopic.OrderNum] = objInFor[concc_PapersBigTopic.OrderNum];
objDR[concc_PapersBigTopic.UpdDate] = objInFor[concc_PapersBigTopic.UpdDate];
objDR[concc_PapersBigTopic.UpdUser] = objInFor[concc_PapersBigTopic.UpdUser];
objDR[concc_PapersBigTopic.Memo] = objInFor[concc_PapersBigTopic.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 试卷大题目(cc_PapersBigTopic)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4cc_PapersBigTopic : clsCommFun4BL
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
clscc_PapersBigTopicWApi.ReFreshThisCache();
clsvcc_PapersBigTopicWApi.ReFreshThisCache();
}
}

}