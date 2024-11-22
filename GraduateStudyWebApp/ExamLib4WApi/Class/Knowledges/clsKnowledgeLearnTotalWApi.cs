
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsKnowledgeLearnTotalWApi
 表名:KnowledgeLearnTotal(01120155)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:48:55
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
public static class clsKnowledgeLearnTotalWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnTotalEN SetmId(this clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN, long lngmId, string strComparisonOp="")
	{
objKnowledgeLearnTotalEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnTotal.mId) == false)
{
objKnowledgeLearnTotalEN.dicFldComparisonOp.Add(conKnowledgeLearnTotal.mId, strComparisonOp);
}
else
{
objKnowledgeLearnTotalEN.dicFldComparisonOp[conKnowledgeLearnTotal.mId] = strComparisonOp;
}
}
return objKnowledgeLearnTotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnTotalEN SetUserId(this clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, conKnowledgeLearnTotal.UserId);
objKnowledgeLearnTotalEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnTotal.UserId) == false)
{
objKnowledgeLearnTotalEN.dicFldComparisonOp.Add(conKnowledgeLearnTotal.UserId, strComparisonOp);
}
else
{
objKnowledgeLearnTotalEN.dicFldComparisonOp[conKnowledgeLearnTotal.UserId] = strComparisonOp;
}
}
return objKnowledgeLearnTotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnTotalEN SetMasterDegree(this clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN, int intMasterDegree, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intMasterDegree, conKnowledgeLearnTotal.MasterDegree);
objKnowledgeLearnTotalEN.MasterDegree = intMasterDegree; //掌握程度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnTotal.MasterDegree) == false)
{
objKnowledgeLearnTotalEN.dicFldComparisonOp.Add(conKnowledgeLearnTotal.MasterDegree, strComparisonOp);
}
else
{
objKnowledgeLearnTotalEN.dicFldComparisonOp[conKnowledgeLearnTotal.MasterDegree] = strComparisonOp;
}
}
return objKnowledgeLearnTotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnTotalEN SetLearnCount(this clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN, int intLearnCount, string strComparisonOp="")
	{
objKnowledgeLearnTotalEN.LearnCount = intLearnCount; //学习次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnTotal.LearnCount) == false)
{
objKnowledgeLearnTotalEN.dicFldComparisonOp.Add(conKnowledgeLearnTotal.LearnCount, strComparisonOp);
}
else
{
objKnowledgeLearnTotalEN.dicFldComparisonOp[conKnowledgeLearnTotal.LearnCount] = strComparisonOp;
}
}
return objKnowledgeLearnTotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnTotalEN SetCourseKnowledgeId(this clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN, string strCourseKnowledgeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseKnowledgeId, 8, conKnowledgeLearnTotal.CourseKnowledgeId);
clsCheckSql.CheckFieldForeignKey(strCourseKnowledgeId, 8, conKnowledgeLearnTotal.CourseKnowledgeId);
objKnowledgeLearnTotalEN.CourseKnowledgeId = strCourseKnowledgeId; //知识点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnTotal.CourseKnowledgeId) == false)
{
objKnowledgeLearnTotalEN.dicFldComparisonOp.Add(conKnowledgeLearnTotal.CourseKnowledgeId, strComparisonOp);
}
else
{
objKnowledgeLearnTotalEN.dicFldComparisonOp[conKnowledgeLearnTotal.CourseKnowledgeId] = strComparisonOp;
}
}
return objKnowledgeLearnTotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnTotalEN SetSuccessCount(this clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN, int intSuccessCount, string strComparisonOp="")
	{
objKnowledgeLearnTotalEN.SuccessCount = intSuccessCount; //成功次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnTotal.SuccessCount) == false)
{
objKnowledgeLearnTotalEN.dicFldComparisonOp.Add(conKnowledgeLearnTotal.SuccessCount, strComparisonOp);
}
else
{
objKnowledgeLearnTotalEN.dicFldComparisonOp[conKnowledgeLearnTotal.SuccessCount] = strComparisonOp;
}
}
return objKnowledgeLearnTotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnTotalEN SetFailCount(this clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN, int intFailCount, string strComparisonOp="")
	{
objKnowledgeLearnTotalEN.FailCount = intFailCount; //失败次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnTotal.FailCount) == false)
{
objKnowledgeLearnTotalEN.dicFldComparisonOp.Add(conKnowledgeLearnTotal.FailCount, strComparisonOp);
}
else
{
objKnowledgeLearnTotalEN.dicFldComparisonOp[conKnowledgeLearnTotal.FailCount] = strComparisonOp;
}
}
return objKnowledgeLearnTotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnTotalEN SetContinuousSuccessCount(this clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN, int intContinuousSuccessCount, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intContinuousSuccessCount, conKnowledgeLearnTotal.ContinuousSuccessCount);
objKnowledgeLearnTotalEN.ContinuousSuccessCount = intContinuousSuccessCount; //连续成功次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnTotal.ContinuousSuccessCount) == false)
{
objKnowledgeLearnTotalEN.dicFldComparisonOp.Add(conKnowledgeLearnTotal.ContinuousSuccessCount, strComparisonOp);
}
else
{
objKnowledgeLearnTotalEN.dicFldComparisonOp[conKnowledgeLearnTotal.ContinuousSuccessCount] = strComparisonOp;
}
}
return objKnowledgeLearnTotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnTotalEN SetContinuousFailCount(this clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN, int intContinuousFailCount, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intContinuousFailCount, conKnowledgeLearnTotal.ContinuousFailCount);
objKnowledgeLearnTotalEN.ContinuousFailCount = intContinuousFailCount; //连续失败次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnTotal.ContinuousFailCount) == false)
{
objKnowledgeLearnTotalEN.dicFldComparisonOp.Add(conKnowledgeLearnTotal.ContinuousFailCount, strComparisonOp);
}
else
{
objKnowledgeLearnTotalEN.dicFldComparisonOp[conKnowledgeLearnTotal.ContinuousFailCount] = strComparisonOp;
}
}
return objKnowledgeLearnTotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnTotalEN SetLastLearnDate(this clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN, string strLastLearnDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLastLearnDate, 14, conKnowledgeLearnTotal.LastLearnDate);
objKnowledgeLearnTotalEN.LastLearnDate = strLastLearnDate; //最后学习日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnTotal.LastLearnDate) == false)
{
objKnowledgeLearnTotalEN.dicFldComparisonOp.Add(conKnowledgeLearnTotal.LastLearnDate, strComparisonOp);
}
else
{
objKnowledgeLearnTotalEN.dicFldComparisonOp[conKnowledgeLearnTotal.LastLearnDate] = strComparisonOp;
}
}
return objKnowledgeLearnTotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnTotalEN SetRecommendedNextReviewDate(this clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN, string strRecommendedNextReviewDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedNextReviewDate, 14, conKnowledgeLearnTotal.RecommendedNextReviewDate);
objKnowledgeLearnTotalEN.RecommendedNextReviewDate = strRecommendedNextReviewDate; //推荐下次复习日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnTotal.RecommendedNextReviewDate) == false)
{
objKnowledgeLearnTotalEN.dicFldComparisonOp.Add(conKnowledgeLearnTotal.RecommendedNextReviewDate, strComparisonOp);
}
else
{
objKnowledgeLearnTotalEN.dicFldComparisonOp[conKnowledgeLearnTotal.RecommendedNextReviewDate] = strComparisonOp;
}
}
return objKnowledgeLearnTotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnTotalEN SetCourseId(this clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conKnowledgeLearnTotal.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, conKnowledgeLearnTotal.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conKnowledgeLearnTotal.CourseId);
objKnowledgeLearnTotalEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnTotal.CourseId) == false)
{
objKnowledgeLearnTotalEN.dicFldComparisonOp.Add(conKnowledgeLearnTotal.CourseId, strComparisonOp);
}
else
{
objKnowledgeLearnTotalEN.dicFldComparisonOp[conKnowledgeLearnTotal.CourseId] = strComparisonOp;
}
}
return objKnowledgeLearnTotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnTotalEN SetUpdDate(this clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conKnowledgeLearnTotal.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, conKnowledgeLearnTotal.UpdDate);
objKnowledgeLearnTotalEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnTotal.UpdDate) == false)
{
objKnowledgeLearnTotalEN.dicFldComparisonOp.Add(conKnowledgeLearnTotal.UpdDate, strComparisonOp);
}
else
{
objKnowledgeLearnTotalEN.dicFldComparisonOp[conKnowledgeLearnTotal.UpdDate] = strComparisonOp;
}
}
return objKnowledgeLearnTotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnTotalEN SetUpdUser(this clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conKnowledgeLearnTotal.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, conKnowledgeLearnTotal.UpdUser);
objKnowledgeLearnTotalEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnTotal.UpdUser) == false)
{
objKnowledgeLearnTotalEN.dicFldComparisonOp.Add(conKnowledgeLearnTotal.UpdUser, strComparisonOp);
}
else
{
objKnowledgeLearnTotalEN.dicFldComparisonOp[conKnowledgeLearnTotal.UpdUser] = strComparisonOp;
}
}
return objKnowledgeLearnTotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnTotalEN SetMemo(this clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conKnowledgeLearnTotal.Memo);
objKnowledgeLearnTotalEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnTotal.Memo) == false)
{
objKnowledgeLearnTotalEN.dicFldComparisonOp.Add(conKnowledgeLearnTotal.Memo, strComparisonOp);
}
else
{
objKnowledgeLearnTotalEN.dicFldComparisonOp[conKnowledgeLearnTotal.Memo] = strComparisonOp;
}
}
return objKnowledgeLearnTotalEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsKnowledgeLearnTotalEN objKnowledgeLearnTotal_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objKnowledgeLearnTotal_Cond.IsUpdated(conKnowledgeLearnTotal.mId) == true)
{
string strComparisonOp_mId = objKnowledgeLearnTotal_Cond.dicFldComparisonOp[conKnowledgeLearnTotal.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conKnowledgeLearnTotal.mId, objKnowledgeLearnTotal_Cond.mId, strComparisonOp_mId);
}
if (objKnowledgeLearnTotal_Cond.IsUpdated(conKnowledgeLearnTotal.UserId) == true)
{
string strComparisonOp_UserId = objKnowledgeLearnTotal_Cond.dicFldComparisonOp[conKnowledgeLearnTotal.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnTotal.UserId, objKnowledgeLearnTotal_Cond.UserId, strComparisonOp_UserId);
}
if (objKnowledgeLearnTotal_Cond.IsUpdated(conKnowledgeLearnTotal.MasterDegree) == true)
{
string strComparisonOp_MasterDegree = objKnowledgeLearnTotal_Cond.dicFldComparisonOp[conKnowledgeLearnTotal.MasterDegree];
strWhereCond += string.Format(" And {0} {2} {1}", conKnowledgeLearnTotal.MasterDegree, objKnowledgeLearnTotal_Cond.MasterDegree, strComparisonOp_MasterDegree);
}
if (objKnowledgeLearnTotal_Cond.IsUpdated(conKnowledgeLearnTotal.LearnCount) == true)
{
string strComparisonOp_LearnCount = objKnowledgeLearnTotal_Cond.dicFldComparisonOp[conKnowledgeLearnTotal.LearnCount];
strWhereCond += string.Format(" And {0} {2} {1}", conKnowledgeLearnTotal.LearnCount, objKnowledgeLearnTotal_Cond.LearnCount, strComparisonOp_LearnCount);
}
if (objKnowledgeLearnTotal_Cond.IsUpdated(conKnowledgeLearnTotal.CourseKnowledgeId) == true)
{
string strComparisonOp_CourseKnowledgeId = objKnowledgeLearnTotal_Cond.dicFldComparisonOp[conKnowledgeLearnTotal.CourseKnowledgeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnTotal.CourseKnowledgeId, objKnowledgeLearnTotal_Cond.CourseKnowledgeId, strComparisonOp_CourseKnowledgeId);
}
if (objKnowledgeLearnTotal_Cond.IsUpdated(conKnowledgeLearnTotal.SuccessCount) == true)
{
string strComparisonOp_SuccessCount = objKnowledgeLearnTotal_Cond.dicFldComparisonOp[conKnowledgeLearnTotal.SuccessCount];
strWhereCond += string.Format(" And {0} {2} {1}", conKnowledgeLearnTotal.SuccessCount, objKnowledgeLearnTotal_Cond.SuccessCount, strComparisonOp_SuccessCount);
}
if (objKnowledgeLearnTotal_Cond.IsUpdated(conKnowledgeLearnTotal.FailCount) == true)
{
string strComparisonOp_FailCount = objKnowledgeLearnTotal_Cond.dicFldComparisonOp[conKnowledgeLearnTotal.FailCount];
strWhereCond += string.Format(" And {0} {2} {1}", conKnowledgeLearnTotal.FailCount, objKnowledgeLearnTotal_Cond.FailCount, strComparisonOp_FailCount);
}
if (objKnowledgeLearnTotal_Cond.IsUpdated(conKnowledgeLearnTotal.ContinuousSuccessCount) == true)
{
string strComparisonOp_ContinuousSuccessCount = objKnowledgeLearnTotal_Cond.dicFldComparisonOp[conKnowledgeLearnTotal.ContinuousSuccessCount];
strWhereCond += string.Format(" And {0} {2} {1}", conKnowledgeLearnTotal.ContinuousSuccessCount, objKnowledgeLearnTotal_Cond.ContinuousSuccessCount, strComparisonOp_ContinuousSuccessCount);
}
if (objKnowledgeLearnTotal_Cond.IsUpdated(conKnowledgeLearnTotal.ContinuousFailCount) == true)
{
string strComparisonOp_ContinuousFailCount = objKnowledgeLearnTotal_Cond.dicFldComparisonOp[conKnowledgeLearnTotal.ContinuousFailCount];
strWhereCond += string.Format(" And {0} {2} {1}", conKnowledgeLearnTotal.ContinuousFailCount, objKnowledgeLearnTotal_Cond.ContinuousFailCount, strComparisonOp_ContinuousFailCount);
}
if (objKnowledgeLearnTotal_Cond.IsUpdated(conKnowledgeLearnTotal.LastLearnDate) == true)
{
string strComparisonOp_LastLearnDate = objKnowledgeLearnTotal_Cond.dicFldComparisonOp[conKnowledgeLearnTotal.LastLearnDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnTotal.LastLearnDate, objKnowledgeLearnTotal_Cond.LastLearnDate, strComparisonOp_LastLearnDate);
}
if (objKnowledgeLearnTotal_Cond.IsUpdated(conKnowledgeLearnTotal.RecommendedNextReviewDate) == true)
{
string strComparisonOp_RecommendedNextReviewDate = objKnowledgeLearnTotal_Cond.dicFldComparisonOp[conKnowledgeLearnTotal.RecommendedNextReviewDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnTotal.RecommendedNextReviewDate, objKnowledgeLearnTotal_Cond.RecommendedNextReviewDate, strComparisonOp_RecommendedNextReviewDate);
}
if (objKnowledgeLearnTotal_Cond.IsUpdated(conKnowledgeLearnTotal.CourseId) == true)
{
string strComparisonOp_CourseId = objKnowledgeLearnTotal_Cond.dicFldComparisonOp[conKnowledgeLearnTotal.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnTotal.CourseId, objKnowledgeLearnTotal_Cond.CourseId, strComparisonOp_CourseId);
}
if (objKnowledgeLearnTotal_Cond.IsUpdated(conKnowledgeLearnTotal.UpdDate) == true)
{
string strComparisonOp_UpdDate = objKnowledgeLearnTotal_Cond.dicFldComparisonOp[conKnowledgeLearnTotal.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnTotal.UpdDate, objKnowledgeLearnTotal_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objKnowledgeLearnTotal_Cond.IsUpdated(conKnowledgeLearnTotal.UpdUser) == true)
{
string strComparisonOp_UpdUser = objKnowledgeLearnTotal_Cond.dicFldComparisonOp[conKnowledgeLearnTotal.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnTotal.UpdUser, objKnowledgeLearnTotal_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objKnowledgeLearnTotal_Cond.IsUpdated(conKnowledgeLearnTotal.Memo) == true)
{
string strComparisonOp_Memo = objKnowledgeLearnTotal_Cond.dicFldComparisonOp[conKnowledgeLearnTotal.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnTotal.Memo, objKnowledgeLearnTotal_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objKnowledgeLearnTotalEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN)
{
 if (objKnowledgeLearnTotalEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objKnowledgeLearnTotalEN.sf_UpdFldSetStr = objKnowledgeLearnTotalEN.getsf_UpdFldSetStr();
clsKnowledgeLearnTotalWApi.CheckPropertyNew(objKnowledgeLearnTotalEN); 
bool bolResult = clsKnowledgeLearnTotalWApi.UpdateRecord(objKnowledgeLearnTotalEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeLearnTotalWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--KnowledgeLearnTotal(知识点学习汇总表), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objKnowledgeLearnTotalEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_CourseKnowledgeId_UserId(this clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objKnowledgeLearnTotalEN == null) return "";
if (objKnowledgeLearnTotalEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and UserId = '{0}'", objKnowledgeLearnTotalEN.UserId);
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objKnowledgeLearnTotalEN.CourseKnowledgeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objKnowledgeLearnTotalEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objKnowledgeLearnTotalEN.UserId);
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objKnowledgeLearnTotalEN.CourseKnowledgeId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objKnowledgeLearnTotalEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN)
{
try
{
clsKnowledgeLearnTotalWApi.CheckPropertyNew(objKnowledgeLearnTotalEN); 
bool bolResult = clsKnowledgeLearnTotalWApi.AddNewRecord(objKnowledgeLearnTotalEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeLearnTotalWApi.ReFreshCache();
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
 /// <param name = "objKnowledgeLearnTotalEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN, string strWhereCond)
{
try
{
clsKnowledgeLearnTotalWApi.CheckPropertyNew(objKnowledgeLearnTotalEN); 
bool bolResult = clsKnowledgeLearnTotalWApi.UpdateWithCondition(objKnowledgeLearnTotalEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeLearnTotalWApi.ReFreshCache();
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
 /// 知识点学习汇总表(KnowledgeLearnTotal)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsKnowledgeLearnTotalWApi
{
private static readonly string mstrApiControllerName = "KnowledgeLearnTotalApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsKnowledgeLearnTotalWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN)
{
if (!Object.Equals(null, objKnowledgeLearnTotalEN.UserId) && GetStrLen(objKnowledgeLearnTotalEN.UserId) > 20)
{
 throw new Exception("字段[用户ID]的长度不能超过20!");
}
if (!Object.Equals(null, objKnowledgeLearnTotalEN.CourseKnowledgeId) && GetStrLen(objKnowledgeLearnTotalEN.CourseKnowledgeId) > 8)
{
 throw new Exception("字段[知识点Id]的长度不能超过8!");
}
if (!Object.Equals(null, objKnowledgeLearnTotalEN.LastLearnDate) && GetStrLen(objKnowledgeLearnTotalEN.LastLearnDate) > 14)
{
 throw new Exception("字段[最后学习日期]的长度不能超过14!");
}
if (!Object.Equals(null, objKnowledgeLearnTotalEN.RecommendedNextReviewDate) && GetStrLen(objKnowledgeLearnTotalEN.RecommendedNextReviewDate) > 14)
{
 throw new Exception("字段[推荐下次复习日期]的长度不能超过14!");
}
if (!Object.Equals(null, objKnowledgeLearnTotalEN.CourseId) && GetStrLen(objKnowledgeLearnTotalEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objKnowledgeLearnTotalEN.UpdDate) && GetStrLen(objKnowledgeLearnTotalEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objKnowledgeLearnTotalEN.UpdUser) && GetStrLen(objKnowledgeLearnTotalEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objKnowledgeLearnTotalEN.Memo) && GetStrLen(objKnowledgeLearnTotalEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objKnowledgeLearnTotalEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsKnowledgeLearnTotalEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN = null;
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
objKnowledgeLearnTotalEN = JsonConvert.DeserializeObject<clsKnowledgeLearnTotalEN>((string)jobjReturn["ReturnObj"]);
return objKnowledgeLearnTotalEN;
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
public static clsKnowledgeLearnTotalEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN = null;
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
objKnowledgeLearnTotalEN = JsonConvert.DeserializeObject<clsKnowledgeLearnTotalEN>((string)jobjReturn["ReturnObj"]);
return objKnowledgeLearnTotalEN;
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
public static clsKnowledgeLearnTotalEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN = null;
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
objKnowledgeLearnTotalEN = JsonConvert.DeserializeObject<clsKnowledgeLearnTotalEN>((string)jobjReturn["ReturnObj"]);
return objKnowledgeLearnTotalEN;
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
public static clsKnowledgeLearnTotalEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsKnowledgeLearnTotalEN._CurrTabName_S);
List<clsKnowledgeLearnTotalEN> arrKnowledgeLearnTotalObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsKnowledgeLearnTotalEN> arrKnowledgeLearnTotalObjLst_Sel =
from objKnowledgeLearnTotalEN in arrKnowledgeLearnTotalObjLst_Cache
where objKnowledgeLearnTotalEN.mId == lngmId
select objKnowledgeLearnTotalEN;
if (arrKnowledgeLearnTotalObjLst_Sel.Count() == 0)
{
   clsKnowledgeLearnTotalEN obj = clsKnowledgeLearnTotalWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrKnowledgeLearnTotalObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsKnowledgeLearnTotalEN> GetObjLst(string strWhereCond)
{
 List<clsKnowledgeLearnTotalEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsKnowledgeLearnTotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsKnowledgeLearnTotalEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsKnowledgeLearnTotalEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsKnowledgeLearnTotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsKnowledgeLearnTotalEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsKnowledgeLearnTotalEN._CurrTabName_S);
List<clsKnowledgeLearnTotalEN> arrKnowledgeLearnTotalObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsKnowledgeLearnTotalEN> arrKnowledgeLearnTotalObjLst_Sel =
from objKnowledgeLearnTotalEN in arrKnowledgeLearnTotalObjLst_Cache
where arrMId.Contains(objKnowledgeLearnTotalEN.mId)
select objKnowledgeLearnTotalEN;
return arrKnowledgeLearnTotalObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsKnowledgeLearnTotalEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsKnowledgeLearnTotalEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsKnowledgeLearnTotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsKnowledgeLearnTotalEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsKnowledgeLearnTotalEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsKnowledgeLearnTotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsKnowledgeLearnTotalEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsKnowledgeLearnTotalEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsKnowledgeLearnTotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsKnowledgeLearnTotalEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsKnowledgeLearnTotalEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsKnowledgeLearnTotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsKnowledgeLearnTotalEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsKnowledgeLearnTotalEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsKnowledgeLearnTotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
 clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN = clsKnowledgeLearnTotalWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsKnowledgeLearnTotalWApi.ReFreshCache();
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
public static int DelKnowledgeLearnTotals(List<string> arrmId)
{
string strAction = "DelKnowledgeLearnTotals";
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
clsKnowledgeLearnTotalWApi.ReFreshCache();
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
public static int DelKnowledgeLearnTotalsByCond(string strWhereCond)
{
string strAction = "DelKnowledgeLearnTotalsByCond";
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
public static bool AddNewRecord(clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsKnowledgeLearnTotalEN>(objKnowledgeLearnTotalEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeLearnTotalWApi.ReFreshCache();
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
 /// <param name = "objKnowledgeLearnTotalEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsKnowledgeLearnTotalEN>(objKnowledgeLearnTotalEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeLearnTotalWApi.ReFreshCache();
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
public static bool UpdateRecord(clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN)
{
if (string.IsNullOrEmpty(objKnowledgeLearnTotalEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objKnowledgeLearnTotalEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsKnowledgeLearnTotalEN>(objKnowledgeLearnTotalEN);
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
 /// <param name = "objKnowledgeLearnTotalEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objKnowledgeLearnTotalEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objKnowledgeLearnTotalEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objKnowledgeLearnTotalEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsKnowledgeLearnTotalEN>(objKnowledgeLearnTotalEN);
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
 /// <param name = "objKnowledgeLearnTotalENS">源对象</param>
 /// <param name = "objKnowledgeLearnTotalENT">目标对象</param>
 public static void CopyTo(clsKnowledgeLearnTotalEN objKnowledgeLearnTotalENS, clsKnowledgeLearnTotalEN objKnowledgeLearnTotalENT)
{
try
{
objKnowledgeLearnTotalENT.mId = objKnowledgeLearnTotalENS.mId; //mId
objKnowledgeLearnTotalENT.UserId = objKnowledgeLearnTotalENS.UserId; //用户ID
objKnowledgeLearnTotalENT.MasterDegree = objKnowledgeLearnTotalENS.MasterDegree; //掌握程度
objKnowledgeLearnTotalENT.LearnCount = objKnowledgeLearnTotalENS.LearnCount; //学习次数
objKnowledgeLearnTotalENT.CourseKnowledgeId = objKnowledgeLearnTotalENS.CourseKnowledgeId; //知识点Id
objKnowledgeLearnTotalENT.SuccessCount = objKnowledgeLearnTotalENS.SuccessCount; //成功次数
objKnowledgeLearnTotalENT.FailCount = objKnowledgeLearnTotalENS.FailCount; //失败次数
objKnowledgeLearnTotalENT.ContinuousSuccessCount = objKnowledgeLearnTotalENS.ContinuousSuccessCount; //连续成功次数
objKnowledgeLearnTotalENT.ContinuousFailCount = objKnowledgeLearnTotalENS.ContinuousFailCount; //连续失败次数
objKnowledgeLearnTotalENT.LastLearnDate = objKnowledgeLearnTotalENS.LastLearnDate; //最后学习日期
objKnowledgeLearnTotalENT.RecommendedNextReviewDate = objKnowledgeLearnTotalENS.RecommendedNextReviewDate; //推荐下次复习日期
objKnowledgeLearnTotalENT.CourseId = objKnowledgeLearnTotalENS.CourseId; //课程Id
objKnowledgeLearnTotalENT.UpdDate = objKnowledgeLearnTotalENS.UpdDate; //修改日期
objKnowledgeLearnTotalENT.UpdUser = objKnowledgeLearnTotalENS.UpdUser; //修改人
objKnowledgeLearnTotalENT.Memo = objKnowledgeLearnTotalENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsKnowledgeLearnTotalEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsKnowledgeLearnTotalEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsKnowledgeLearnTotalEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsKnowledgeLearnTotalEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsKnowledgeLearnTotalEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsKnowledgeLearnTotalEN.AttributeName)
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
if (clsKnowledgeLearnTotalWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsKnowledgeLearnTotalWApi没有刷新缓存机制(clsKnowledgeLearnTotalWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrKnowledgeLearnTotalObjLst_Cache == null)
//{
//arrKnowledgeLearnTotalObjLst_Cache = await clsKnowledgeLearnTotalWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsKnowledgeLearnTotalEN._CurrTabName_S);
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
if (clsKnowledgeLearnTotalWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsKnowledgeLearnTotalEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsKnowledgeLearnTotalWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsKnowledgeLearnTotalEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsKnowledgeLearnTotalEN._CurrTabName_S);
List<clsKnowledgeLearnTotalEN> arrKnowledgeLearnTotalObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrKnowledgeLearnTotalObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsKnowledgeLearnTotalEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conKnowledgeLearnTotal.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conKnowledgeLearnTotal.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conKnowledgeLearnTotal.MasterDegree, Type.GetType("System.Int32"));
objDT.Columns.Add(conKnowledgeLearnTotal.LearnCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conKnowledgeLearnTotal.CourseKnowledgeId, Type.GetType("System.String"));
objDT.Columns.Add(conKnowledgeLearnTotal.SuccessCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conKnowledgeLearnTotal.FailCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conKnowledgeLearnTotal.ContinuousSuccessCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conKnowledgeLearnTotal.ContinuousFailCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conKnowledgeLearnTotal.LastLearnDate, Type.GetType("System.String"));
objDT.Columns.Add(conKnowledgeLearnTotal.RecommendedNextReviewDate, Type.GetType("System.String"));
objDT.Columns.Add(conKnowledgeLearnTotal.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(conKnowledgeLearnTotal.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conKnowledgeLearnTotal.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conKnowledgeLearnTotal.Memo, Type.GetType("System.String"));
foreach (clsKnowledgeLearnTotalEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conKnowledgeLearnTotal.mId] = objInFor[conKnowledgeLearnTotal.mId];
objDR[conKnowledgeLearnTotal.UserId] = objInFor[conKnowledgeLearnTotal.UserId];
objDR[conKnowledgeLearnTotal.MasterDegree] = objInFor[conKnowledgeLearnTotal.MasterDegree];
objDR[conKnowledgeLearnTotal.LearnCount] = objInFor[conKnowledgeLearnTotal.LearnCount];
objDR[conKnowledgeLearnTotal.CourseKnowledgeId] = objInFor[conKnowledgeLearnTotal.CourseKnowledgeId];
objDR[conKnowledgeLearnTotal.SuccessCount] = objInFor[conKnowledgeLearnTotal.SuccessCount];
objDR[conKnowledgeLearnTotal.FailCount] = objInFor[conKnowledgeLearnTotal.FailCount];
objDR[conKnowledgeLearnTotal.ContinuousSuccessCount] = objInFor[conKnowledgeLearnTotal.ContinuousSuccessCount];
objDR[conKnowledgeLearnTotal.ContinuousFailCount] = objInFor[conKnowledgeLearnTotal.ContinuousFailCount];
objDR[conKnowledgeLearnTotal.LastLearnDate] = objInFor[conKnowledgeLearnTotal.LastLearnDate];
objDR[conKnowledgeLearnTotal.RecommendedNextReviewDate] = objInFor[conKnowledgeLearnTotal.RecommendedNextReviewDate];
objDR[conKnowledgeLearnTotal.CourseId] = objInFor[conKnowledgeLearnTotal.CourseId];
objDR[conKnowledgeLearnTotal.UpdDate] = objInFor[conKnowledgeLearnTotal.UpdDate];
objDR[conKnowledgeLearnTotal.UpdUser] = objInFor[conKnowledgeLearnTotal.UpdUser];
objDR[conKnowledgeLearnTotal.Memo] = objInFor[conKnowledgeLearnTotal.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 知识点学习汇总表(KnowledgeLearnTotal)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4KnowledgeLearnTotal : clsCommFun4BL
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
clsKnowledgeLearnTotalWApi.ReFreshThisCache();
clsvKnowledgeLearnTotalWApi.ReFreshThisCache();
}
}

}