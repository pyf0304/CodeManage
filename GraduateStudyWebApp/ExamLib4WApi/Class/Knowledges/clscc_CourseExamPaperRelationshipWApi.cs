
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseExamPaperRelationshipWApi
 表名:cc_CourseExamPaperRelationship(01120076)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:50:43
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
public static class clscc_CourseExamPaperRelationshipWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperRelationshipEN SetmId(this clscc_CourseExamPaperRelationshipEN objcc_CourseExamPaperRelationshipEN, long lngmId, string strComparisonOp="")
	{
objcc_CourseExamPaperRelationshipEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperRelationship.mId) == false)
{
objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(concc_CourseExamPaperRelationship.mId, strComparisonOp);
}
else
{
objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[concc_CourseExamPaperRelationship.mId] = strComparisonOp;
}
}
return objcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperRelationshipEN SetCourseExamPaperId(this clscc_CourseExamPaperRelationshipEN objcc_CourseExamPaperRelationshipEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseExamPaperId, concc_CourseExamPaperRelationship.CourseExamPaperId);
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, concc_CourseExamPaperRelationship.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, concc_CourseExamPaperRelationship.CourseExamPaperId);
objcc_CourseExamPaperRelationshipEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperRelationship.CourseExamPaperId) == false)
{
objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(concc_CourseExamPaperRelationship.CourseExamPaperId, strComparisonOp);
}
else
{
objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[concc_CourseExamPaperRelationship.CourseExamPaperId] = strComparisonOp;
}
}
return objcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperRelationshipEN SetCourseId(this clscc_CourseExamPaperRelationshipEN objcc_CourseExamPaperRelationshipEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, concc_CourseExamPaperRelationship.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, concc_CourseExamPaperRelationship.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, concc_CourseExamPaperRelationship.CourseId);
objcc_CourseExamPaperRelationshipEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperRelationship.CourseId) == false)
{
objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(concc_CourseExamPaperRelationship.CourseId, strComparisonOp);
}
else
{
objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[concc_CourseExamPaperRelationship.CourseId] = strComparisonOp;
}
}
return objcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperRelationshipEN SetQuestionID(this clscc_CourseExamPaperRelationshipEN objcc_CourseExamPaperRelationshipEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionID, concc_CourseExamPaperRelationship.QuestionID);
clsCheckSql.CheckFieldLen(strQuestionID, 8, concc_CourseExamPaperRelationship.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, concc_CourseExamPaperRelationship.QuestionID);
objcc_CourseExamPaperRelationshipEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperRelationship.QuestionID) == false)
{
objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(concc_CourseExamPaperRelationship.QuestionID, strComparisonOp);
}
else
{
objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[concc_CourseExamPaperRelationship.QuestionID] = strComparisonOp;
}
}
return objcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperRelationshipEN SetUserId(this clscc_CourseExamPaperRelationshipEN objcc_CourseExamPaperRelationshipEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, concc_CourseExamPaperRelationship.UserId);
objcc_CourseExamPaperRelationshipEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperRelationship.UserId) == false)
{
objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(concc_CourseExamPaperRelationship.UserId, strComparisonOp);
}
else
{
objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[concc_CourseExamPaperRelationship.UserId] = strComparisonOp;
}
}
return objcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperRelationshipEN SetStartTime(this clscc_CourseExamPaperRelationshipEN objcc_CourseExamPaperRelationshipEN, double dblStartTime, string strComparisonOp="")
	{
objcc_CourseExamPaperRelationshipEN.StartTime = dblStartTime; //开始时间(s)
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperRelationship.StartTime) == false)
{
objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(concc_CourseExamPaperRelationship.StartTime, strComparisonOp);
}
else
{
objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[concc_CourseExamPaperRelationship.StartTime] = strComparisonOp;
}
}
return objcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperRelationshipEN SetPapersBigTopicId(this clscc_CourseExamPaperRelationshipEN objcc_CourseExamPaperRelationshipEN, string strPapersBigTopicId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPapersBigTopicId, 8, concc_CourseExamPaperRelationship.PapersBigTopicId);
clsCheckSql.CheckFieldForeignKey(strPapersBigTopicId, 8, concc_CourseExamPaperRelationship.PapersBigTopicId);
objcc_CourseExamPaperRelationshipEN.PapersBigTopicId = strPapersBigTopicId; //试卷大题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperRelationship.PapersBigTopicId) == false)
{
objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(concc_CourseExamPaperRelationship.PapersBigTopicId, strComparisonOp);
}
else
{
objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[concc_CourseExamPaperRelationship.PapersBigTopicId] = strComparisonOp;
}
}
return objcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperRelationshipEN SetTopicOrderNum(this clscc_CourseExamPaperRelationshipEN objcc_CourseExamPaperRelationshipEN, int intTopicOrderNum, string strComparisonOp="")
	{
objcc_CourseExamPaperRelationshipEN.TopicOrderNum = intTopicOrderNum; //TopicOrderNum
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperRelationship.TopicOrderNum) == false)
{
objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(concc_CourseExamPaperRelationship.TopicOrderNum, strComparisonOp);
}
else
{
objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[concc_CourseExamPaperRelationship.TopicOrderNum] = strComparisonOp;
}
}
return objcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperRelationshipEN SetOrderNum(this clscc_CourseExamPaperRelationshipEN objcc_CourseExamPaperRelationshipEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, concc_CourseExamPaperRelationship.OrderNum);
objcc_CourseExamPaperRelationshipEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperRelationship.OrderNum) == false)
{
objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(concc_CourseExamPaperRelationship.OrderNum, strComparisonOp);
}
else
{
objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[concc_CourseExamPaperRelationship.OrderNum] = strComparisonOp;
}
}
return objcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperRelationshipEN SetUpdDate(this clscc_CourseExamPaperRelationshipEN objcc_CourseExamPaperRelationshipEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_CourseExamPaperRelationship.UpdDate);
objcc_CourseExamPaperRelationshipEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperRelationship.UpdDate) == false)
{
objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(concc_CourseExamPaperRelationship.UpdDate, strComparisonOp);
}
else
{
objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[concc_CourseExamPaperRelationship.UpdDate] = strComparisonOp;
}
}
return objcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperRelationshipEN SetUpdUser(this clscc_CourseExamPaperRelationshipEN objcc_CourseExamPaperRelationshipEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, concc_CourseExamPaperRelationship.UpdUser);
objcc_CourseExamPaperRelationshipEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperRelationship.UpdUser) == false)
{
objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(concc_CourseExamPaperRelationship.UpdUser, strComparisonOp);
}
else
{
objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[concc_CourseExamPaperRelationship.UpdUser] = strComparisonOp;
}
}
return objcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperRelationshipEN SetMemo(this clscc_CourseExamPaperRelationshipEN objcc_CourseExamPaperRelationshipEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_CourseExamPaperRelationship.Memo);
objcc_CourseExamPaperRelationshipEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperRelationship.Memo) == false)
{
objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(concc_CourseExamPaperRelationship.Memo, strComparisonOp);
}
else
{
objcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[concc_CourseExamPaperRelationship.Memo] = strComparisonOp;
}
}
return objcc_CourseExamPaperRelationshipEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_CourseExamPaperRelationshipEN objcc_CourseExamPaperRelationship_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_CourseExamPaperRelationship_Cond.IsUpdated(concc_CourseExamPaperRelationship.mId) == true)
{
string strComparisonOp_mId = objcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[concc_CourseExamPaperRelationship.mId];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseExamPaperRelationship.mId, objcc_CourseExamPaperRelationship_Cond.mId, strComparisonOp_mId);
}
if (objcc_CourseExamPaperRelationship_Cond.IsUpdated(concc_CourseExamPaperRelationship.CourseExamPaperId) == true)
{
string strComparisonOp_CourseExamPaperId = objcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[concc_CourseExamPaperRelationship.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaperRelationship.CourseExamPaperId, objcc_CourseExamPaperRelationship_Cond.CourseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (objcc_CourseExamPaperRelationship_Cond.IsUpdated(concc_CourseExamPaperRelationship.CourseId) == true)
{
string strComparisonOp_CourseId = objcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[concc_CourseExamPaperRelationship.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaperRelationship.CourseId, objcc_CourseExamPaperRelationship_Cond.CourseId, strComparisonOp_CourseId);
}
if (objcc_CourseExamPaperRelationship_Cond.IsUpdated(concc_CourseExamPaperRelationship.QuestionID) == true)
{
string strComparisonOp_QuestionID = objcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[concc_CourseExamPaperRelationship.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaperRelationship.QuestionID, objcc_CourseExamPaperRelationship_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objcc_CourseExamPaperRelationship_Cond.IsUpdated(concc_CourseExamPaperRelationship.UserId) == true)
{
string strComparisonOp_UserId = objcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[concc_CourseExamPaperRelationship.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaperRelationship.UserId, objcc_CourseExamPaperRelationship_Cond.UserId, strComparisonOp_UserId);
}
if (objcc_CourseExamPaperRelationship_Cond.IsUpdated(concc_CourseExamPaperRelationship.StartTime) == true)
{
string strComparisonOp_StartTime = objcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[concc_CourseExamPaperRelationship.StartTime];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseExamPaperRelationship.StartTime, objcc_CourseExamPaperRelationship_Cond.StartTime, strComparisonOp_StartTime);
}
if (objcc_CourseExamPaperRelationship_Cond.IsUpdated(concc_CourseExamPaperRelationship.PapersBigTopicId) == true)
{
string strComparisonOp_PapersBigTopicId = objcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[concc_CourseExamPaperRelationship.PapersBigTopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaperRelationship.PapersBigTopicId, objcc_CourseExamPaperRelationship_Cond.PapersBigTopicId, strComparisonOp_PapersBigTopicId);
}
if (objcc_CourseExamPaperRelationship_Cond.IsUpdated(concc_CourseExamPaperRelationship.TopicOrderNum) == true)
{
string strComparisonOp_TopicOrderNum = objcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[concc_CourseExamPaperRelationship.TopicOrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseExamPaperRelationship.TopicOrderNum, objcc_CourseExamPaperRelationship_Cond.TopicOrderNum, strComparisonOp_TopicOrderNum);
}
if (objcc_CourseExamPaperRelationship_Cond.IsUpdated(concc_CourseExamPaperRelationship.OrderNum) == true)
{
string strComparisonOp_OrderNum = objcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[concc_CourseExamPaperRelationship.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseExamPaperRelationship.OrderNum, objcc_CourseExamPaperRelationship_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objcc_CourseExamPaperRelationship_Cond.IsUpdated(concc_CourseExamPaperRelationship.UpdDate) == true)
{
string strComparisonOp_UpdDate = objcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[concc_CourseExamPaperRelationship.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaperRelationship.UpdDate, objcc_CourseExamPaperRelationship_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objcc_CourseExamPaperRelationship_Cond.IsUpdated(concc_CourseExamPaperRelationship.UpdUser) == true)
{
string strComparisonOp_UpdUser = objcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[concc_CourseExamPaperRelationship.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaperRelationship.UpdUser, objcc_CourseExamPaperRelationship_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objcc_CourseExamPaperRelationship_Cond.IsUpdated(concc_CourseExamPaperRelationship.Memo) == true)
{
string strComparisonOp_Memo = objcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[concc_CourseExamPaperRelationship.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaperRelationship.Memo, objcc_CourseExamPaperRelationship_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperRelationshipEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_CourseExamPaperRelationshipEN objcc_CourseExamPaperRelationshipEN)
{
 if (objcc_CourseExamPaperRelationshipEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objcc_CourseExamPaperRelationshipEN.sf_UpdFldSetStr = objcc_CourseExamPaperRelationshipEN.getsf_UpdFldSetStr();
clscc_CourseExamPaperRelationshipWApi.CheckPropertyNew(objcc_CourseExamPaperRelationshipEN); 
bool bolResult = clscc_CourseExamPaperRelationshipWApi.UpdateRecord(objcc_CourseExamPaperRelationshipEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperRelationshipWApi.ReFreshCache(objcc_CourseExamPaperRelationshipEN.CourseId);
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
 /// 检查唯一性(Uniqueness)--cc_CourseExamPaperRelationship(题目与试卷关系), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperRelationshipEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_CourseExamPaperId_QuestionID(this clscc_CourseExamPaperRelationshipEN objcc_CourseExamPaperRelationshipEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_CourseExamPaperRelationshipEN == null) return "";
if (objcc_CourseExamPaperRelationshipEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_CourseExamPaperRelationshipEN.CourseExamPaperId);
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objcc_CourseExamPaperRelationshipEN.QuestionID);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objcc_CourseExamPaperRelationshipEN.mId);
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_CourseExamPaperRelationshipEN.CourseExamPaperId);
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objcc_CourseExamPaperRelationshipEN.QuestionID);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperRelationshipEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_CourseExamPaperRelationshipEN objcc_CourseExamPaperRelationshipEN)
{
try
{
clscc_CourseExamPaperRelationshipWApi.CheckPropertyNew(objcc_CourseExamPaperRelationshipEN); 
bool bolResult = clscc_CourseExamPaperRelationshipWApi.AddNewRecord(objcc_CourseExamPaperRelationshipEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperRelationshipWApi.ReFreshCache(objcc_CourseExamPaperRelationshipEN.CourseId);
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
 /// <param name = "objcc_CourseExamPaperRelationshipEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_CourseExamPaperRelationshipEN objcc_CourseExamPaperRelationshipEN, string strWhereCond)
{
try
{
clscc_CourseExamPaperRelationshipWApi.CheckPropertyNew(objcc_CourseExamPaperRelationshipEN); 
bool bolResult = clscc_CourseExamPaperRelationshipWApi.UpdateWithCondition(objcc_CourseExamPaperRelationshipEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperRelationshipWApi.ReFreshCache(objcc_CourseExamPaperRelationshipEN.CourseId);
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
 /// 题目与试卷关系(cc_CourseExamPaperRelationship)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clscc_CourseExamPaperRelationshipWApi
{
private static readonly string mstrApiControllerName = "cc_CourseExamPaperRelationshipApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 public clscc_CourseExamPaperRelationshipWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscc_CourseExamPaperRelationshipEN objcc_CourseExamPaperRelationshipEN)
{
if (!Object.Equals(null, objcc_CourseExamPaperRelationshipEN.CourseExamPaperId) && GetStrLen(objcc_CourseExamPaperRelationshipEN.CourseExamPaperId) > 8)
{
 throw new Exception("字段[考卷流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_CourseExamPaperRelationshipEN.CourseId) && GetStrLen(objcc_CourseExamPaperRelationshipEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_CourseExamPaperRelationshipEN.QuestionID) && GetStrLen(objcc_CourseExamPaperRelationshipEN.QuestionID) > 8)
{
 throw new Exception("字段[题目ID]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_CourseExamPaperRelationshipEN.UserId) && GetStrLen(objcc_CourseExamPaperRelationshipEN.UserId) > 20)
{
 throw new Exception("字段[用户ID]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_CourseExamPaperRelationshipEN.PapersBigTopicId) && GetStrLen(objcc_CourseExamPaperRelationshipEN.PapersBigTopicId) > 8)
{
 throw new Exception("字段[试卷大题目Id]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_CourseExamPaperRelationshipEN.UpdDate) && GetStrLen(objcc_CourseExamPaperRelationshipEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_CourseExamPaperRelationshipEN.UpdUser) && GetStrLen(objcc_CourseExamPaperRelationshipEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_CourseExamPaperRelationshipEN.Memo) && GetStrLen(objcc_CourseExamPaperRelationshipEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objcc_CourseExamPaperRelationshipEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_CourseExamPaperRelationshipEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clscc_CourseExamPaperRelationshipEN objcc_CourseExamPaperRelationshipEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_CourseExamPaperRelationshipEN = JsonConvert.DeserializeObject<clscc_CourseExamPaperRelationshipEN>((string)jobjReturn["ReturnObj"]);
return objcc_CourseExamPaperRelationshipEN;
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
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_CourseExamPaperRelationshipEN GetObjBymId_WA_Cache(long lngmId, string strCourseId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clscc_CourseExamPaperRelationshipEN objcc_CourseExamPaperRelationshipEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString(),
["CourseId"] = strCourseId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_CourseExamPaperRelationshipEN = JsonConvert.DeserializeObject<clscc_CourseExamPaperRelationshipEN>((string)jobjReturn["ReturnObj"]);
return objcc_CourseExamPaperRelationshipEN;
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
public static clscc_CourseExamPaperRelationshipEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clscc_CourseExamPaperRelationshipEN objcc_CourseExamPaperRelationshipEN = null;
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
objcc_CourseExamPaperRelationshipEN = JsonConvert.DeserializeObject<clscc_CourseExamPaperRelationshipEN>((string)jobjReturn["ReturnObj"]);
return objcc_CourseExamPaperRelationshipEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_CourseExamPaperRelationshipEN GetObjBymId_Cache(long lngmId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperRelationshipEN._CurrTabName_S, strCourseId);
List<clscc_CourseExamPaperRelationshipEN> arrcc_CourseExamPaperRelationshipObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clscc_CourseExamPaperRelationshipEN> arrcc_CourseExamPaperRelationshipObjLst_Sel =
from objcc_CourseExamPaperRelationshipEN in arrcc_CourseExamPaperRelationshipObjLst_Cache
where objcc_CourseExamPaperRelationshipEN.mId == lngmId
select objcc_CourseExamPaperRelationshipEN;
if (arrcc_CourseExamPaperRelationshipObjLst_Sel.Count() == 0)
{
   clscc_CourseExamPaperRelationshipEN obj = clscc_CourseExamPaperRelationshipWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrcc_CourseExamPaperRelationshipObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseExamPaperRelationshipEN> GetObjLst(string strWhereCond)
{
 List<clscc_CourseExamPaperRelationshipEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseExamPaperRelationshipEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_CourseExamPaperRelationshipEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clscc_CourseExamPaperRelationshipEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseExamPaperRelationshipEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clscc_CourseExamPaperRelationshipEN> GetObjLstByMIdLst_Cache(List<long> arrMId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperRelationshipEN._CurrTabName_S, strCourseId);
List<clscc_CourseExamPaperRelationshipEN> arrcc_CourseExamPaperRelationshipObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clscc_CourseExamPaperRelationshipEN> arrcc_CourseExamPaperRelationshipObjLst_Sel =
from objcc_CourseExamPaperRelationshipEN in arrcc_CourseExamPaperRelationshipObjLst_Cache
where arrMId.Contains(objcc_CourseExamPaperRelationshipEN.mId)
select objcc_CourseExamPaperRelationshipEN;
return arrcc_CourseExamPaperRelationshipObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseExamPaperRelationshipEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId, string strCourseId)
{
 List<clscc_CourseExamPaperRelationshipEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseExamPaperRelationshipEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_CourseExamPaperRelationshipEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clscc_CourseExamPaperRelationshipEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseExamPaperRelationshipEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_CourseExamPaperRelationshipEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clscc_CourseExamPaperRelationshipEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseExamPaperRelationshipEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_CourseExamPaperRelationshipEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clscc_CourseExamPaperRelationshipEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseExamPaperRelationshipEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_CourseExamPaperRelationshipEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clscc_CourseExamPaperRelationshipEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseExamPaperRelationshipEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngmId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clscc_CourseExamPaperRelationshipEN objcc_CourseExamPaperRelationshipEN = clscc_CourseExamPaperRelationshipWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_CourseExamPaperRelationshipWApi.ReFreshCache(objcc_CourseExamPaperRelationshipEN.CourseId);
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
public static int Delcc_CourseExamPaperRelationships(List<string> arrmId)
{
string strAction = "Delcc_CourseExamPaperRelationships";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
 clscc_CourseExamPaperRelationshipEN objcc_CourseExamPaperRelationshipEN = clscc_CourseExamPaperRelationshipWApi.GetObjBymId(long.Parse(arrmId[0]));
clscc_CourseExamPaperRelationshipWApi.ReFreshCache(objcc_CourseExamPaperRelationshipEN.CourseId);
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
public static int Delcc_CourseExamPaperRelationshipsByCond(string strWhereCond)
{
string strAction = "Delcc_CourseExamPaperRelationshipsByCond";
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
public static bool AddNewRecord(clscc_CourseExamPaperRelationshipEN objcc_CourseExamPaperRelationshipEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseExamPaperRelationshipEN>(objcc_CourseExamPaperRelationshipEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperRelationshipWApi.ReFreshCache(objcc_CourseExamPaperRelationshipEN.CourseId);
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
 /// <param name = "objcc_CourseExamPaperRelationshipEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clscc_CourseExamPaperRelationshipEN objcc_CourseExamPaperRelationshipEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseExamPaperRelationshipEN>(objcc_CourseExamPaperRelationshipEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperRelationshipWApi.ReFreshCache(objcc_CourseExamPaperRelationshipEN.CourseId);
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
public static bool UpdateRecord(clscc_CourseExamPaperRelationshipEN objcc_CourseExamPaperRelationshipEN)
{
if (string.IsNullOrEmpty(objcc_CourseExamPaperRelationshipEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_CourseExamPaperRelationshipEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseExamPaperRelationshipEN>(objcc_CourseExamPaperRelationshipEN);
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
 /// <param name = "objcc_CourseExamPaperRelationshipEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clscc_CourseExamPaperRelationshipEN objcc_CourseExamPaperRelationshipEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objcc_CourseExamPaperRelationshipEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_CourseExamPaperRelationshipEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_CourseExamPaperRelationshipEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseExamPaperRelationshipEN>(objcc_CourseExamPaperRelationshipEN);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
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
 /// <param name = "objcc_CourseExamPaperRelationshipENS">源对象</param>
 /// <param name = "objcc_CourseExamPaperRelationshipENT">目标对象</param>
 public static void CopyTo(clscc_CourseExamPaperRelationshipEN objcc_CourseExamPaperRelationshipENS, clscc_CourseExamPaperRelationshipEN objcc_CourseExamPaperRelationshipENT)
{
try
{
objcc_CourseExamPaperRelationshipENT.mId = objcc_CourseExamPaperRelationshipENS.mId; //mId
objcc_CourseExamPaperRelationshipENT.CourseExamPaperId = objcc_CourseExamPaperRelationshipENS.CourseExamPaperId; //考卷流水号
objcc_CourseExamPaperRelationshipENT.CourseId = objcc_CourseExamPaperRelationshipENS.CourseId; //课程Id
objcc_CourseExamPaperRelationshipENT.QuestionID = objcc_CourseExamPaperRelationshipENS.QuestionID; //题目ID
objcc_CourseExamPaperRelationshipENT.UserId = objcc_CourseExamPaperRelationshipENS.UserId; //用户ID
objcc_CourseExamPaperRelationshipENT.StartTime = objcc_CourseExamPaperRelationshipENS.StartTime; //开始时间(s)
objcc_CourseExamPaperRelationshipENT.PapersBigTopicId = objcc_CourseExamPaperRelationshipENS.PapersBigTopicId; //试卷大题目Id
objcc_CourseExamPaperRelationshipENT.TopicOrderNum = objcc_CourseExamPaperRelationshipENS.TopicOrderNum; //TopicOrderNum
objcc_CourseExamPaperRelationshipENT.OrderNum = objcc_CourseExamPaperRelationshipENS.OrderNum; //序号
objcc_CourseExamPaperRelationshipENT.UpdDate = objcc_CourseExamPaperRelationshipENS.UpdDate; //修改日期
objcc_CourseExamPaperRelationshipENT.UpdUser = objcc_CourseExamPaperRelationshipENS.UpdUser; //修改人
objcc_CourseExamPaperRelationshipENT.Memo = objcc_CourseExamPaperRelationshipENS.Memo; //备注
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
public static DataTable ToDataTable(List<clscc_CourseExamPaperRelationshipEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clscc_CourseExamPaperRelationshipEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clscc_CourseExamPaperRelationshipEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clscc_CourseExamPaperRelationshipEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clscc_CourseExamPaperRelationshipEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clscc_CourseExamPaperRelationshipEN.AttributeName)
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
if (clscc_CourseExamPaperRelationshipWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseExamPaperRelationshipWApi没有刷新缓存机制(clscc_CourseExamPaperRelationshipWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrcc_CourseExamPaperRelationshipObjLst_Cache == null)
//{
//arrcc_CourseExamPaperRelationshipObjLst_Cache = await clscc_CourseExamPaperRelationshipWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperRelationshipEN._CurrTabName_S, strCourseId);
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
public static void ReFreshCache(string strCourseId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clscc_CourseExamPaperRelationshipWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperRelationshipEN._CurrTabName_S, strCourseId);
CacheHelper.Remove(strKey);
clscc_CourseExamPaperRelationshipWApi.objCommFun4BL.ReFreshCache(strCourseId);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_CourseExamPaperRelationshipEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperRelationshipEN._CurrTabName_S, strCourseId);
List<clscc_CourseExamPaperRelationshipEN> arrcc_CourseExamPaperRelationshipObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrcc_CourseExamPaperRelationshipObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clscc_CourseExamPaperRelationshipEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(concc_CourseExamPaperRelationship.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(concc_CourseExamPaperRelationship.CourseExamPaperId, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseExamPaperRelationship.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseExamPaperRelationship.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseExamPaperRelationship.UserId, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseExamPaperRelationship.StartTime, Type.GetType("System.Decimal"));
objDT.Columns.Add(concc_CourseExamPaperRelationship.PapersBigTopicId, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseExamPaperRelationship.TopicOrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_CourseExamPaperRelationship.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_CourseExamPaperRelationship.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseExamPaperRelationship.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseExamPaperRelationship.Memo, Type.GetType("System.String"));
foreach (clscc_CourseExamPaperRelationshipEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[concc_CourseExamPaperRelationship.mId] = objInFor[concc_CourseExamPaperRelationship.mId];
objDR[concc_CourseExamPaperRelationship.CourseExamPaperId] = objInFor[concc_CourseExamPaperRelationship.CourseExamPaperId];
objDR[concc_CourseExamPaperRelationship.CourseId] = objInFor[concc_CourseExamPaperRelationship.CourseId];
objDR[concc_CourseExamPaperRelationship.QuestionID] = objInFor[concc_CourseExamPaperRelationship.QuestionID];
objDR[concc_CourseExamPaperRelationship.UserId] = objInFor[concc_CourseExamPaperRelationship.UserId];
objDR[concc_CourseExamPaperRelationship.StartTime] = objInFor[concc_CourseExamPaperRelationship.StartTime];
objDR[concc_CourseExamPaperRelationship.PapersBigTopicId] = objInFor[concc_CourseExamPaperRelationship.PapersBigTopicId];
objDR[concc_CourseExamPaperRelationship.TopicOrderNum] = objInFor[concc_CourseExamPaperRelationship.TopicOrderNum];
objDR[concc_CourseExamPaperRelationship.OrderNum] = objInFor[concc_CourseExamPaperRelationship.OrderNum];
objDR[concc_CourseExamPaperRelationship.UpdDate] = objInFor[concc_CourseExamPaperRelationship.UpdDate];
objDR[concc_CourseExamPaperRelationship.UpdUser] = objInFor[concc_CourseExamPaperRelationship.UpdUser];
objDR[concc_CourseExamPaperRelationship.Memo] = objInFor[concc_CourseExamPaperRelationship.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 题目与试卷关系(cc_CourseExamPaperRelationship)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4cc_CourseExamPaperRelationship : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strCourseId)
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
clscc_CourseExamPaperRelationshipWApi.ReFreshThisCache(strCourseId);
clsvcc_CourseExamPaperRelationshipWApi.ReFreshThisCache(strCourseId);
clsvcc_CourseExamPaperRelationship4AppWApi.ReFreshThisCache(strCourseId);
}
}

}