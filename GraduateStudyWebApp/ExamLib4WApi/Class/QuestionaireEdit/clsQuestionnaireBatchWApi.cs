
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionnaireBatchWApi
 表名:QuestionnaireBatch(01120006)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:40:32
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护
 模块英文名:QuestionaireEdit
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
public static class clsQuestionnaireBatchWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireBatchEN SetBatchId(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, string strBatchId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBatchId, 4, conQuestionnaireBatch.BatchId);
clsCheckSql.CheckFieldForeignKey(strBatchId, 4, conQuestionnaireBatch.BatchId);
objQuestionnaireBatchEN.BatchId = strBatchId; //批次ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(conQuestionnaireBatch.BatchId) == false)
{
objQuestionnaireBatchEN.dicFldComparisonOp.Add(conQuestionnaireBatch.BatchId, strComparisonOp);
}
else
{
objQuestionnaireBatchEN.dicFldComparisonOp[conQuestionnaireBatch.BatchId] = strComparisonOp;
}
}
return objQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireBatchEN SetBatchName(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, string strBatchName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strBatchName, conQuestionnaireBatch.BatchName);
clsCheckSql.CheckFieldLen(strBatchName, 50, conQuestionnaireBatch.BatchName);
objQuestionnaireBatchEN.BatchName = strBatchName; //批次名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(conQuestionnaireBatch.BatchName) == false)
{
objQuestionnaireBatchEN.dicFldComparisonOp.Add(conQuestionnaireBatch.BatchName, strComparisonOp);
}
else
{
objQuestionnaireBatchEN.dicFldComparisonOp[conQuestionnaireBatch.BatchName] = strComparisonOp;
}
}
return objQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireBatchEN SetRoleId(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleId, 8, conQuestionnaireBatch.RoleId);
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, conQuestionnaireBatch.RoleId);
objQuestionnaireBatchEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(conQuestionnaireBatch.RoleId) == false)
{
objQuestionnaireBatchEN.dicFldComparisonOp.Add(conQuestionnaireBatch.RoleId, strComparisonOp);
}
else
{
objQuestionnaireBatchEN.dicFldComparisonOp[conQuestionnaireBatch.RoleId] = strComparisonOp;
}
}
return objQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireBatchEN SetQuestionnaireSetId(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, string strQuestionnaireSetId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionnaireSetId, 4, conQuestionnaireBatch.QuestionnaireSetId);
clsCheckSql.CheckFieldForeignKey(strQuestionnaireSetId, 4, conQuestionnaireBatch.QuestionnaireSetId);
objQuestionnaireBatchEN.QuestionnaireSetId = strQuestionnaireSetId; //问卷集ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(conQuestionnaireBatch.QuestionnaireSetId) == false)
{
objQuestionnaireBatchEN.dicFldComparisonOp.Add(conQuestionnaireBatch.QuestionnaireSetId, strComparisonOp);
}
else
{
objQuestionnaireBatchEN.dicFldComparisonOp[conQuestionnaireBatch.QuestionnaireSetId] = strComparisonOp;
}
}
return objQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireBatchEN SetIsDefault(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, bool bolIsDefault, string strComparisonOp="")
	{
objQuestionnaireBatchEN.IsDefault = bolIsDefault; //是否默认
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(conQuestionnaireBatch.IsDefault) == false)
{
objQuestionnaireBatchEN.dicFldComparisonOp.Add(conQuestionnaireBatch.IsDefault, strComparisonOp);
}
else
{
objQuestionnaireBatchEN.dicFldComparisonOp[conQuestionnaireBatch.IsDefault] = strComparisonOp;
}
}
return objQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireBatchEN SetIsDefaultUser(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, bool bolIsDefaultUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDefaultUser, conQuestionnaireBatch.IsDefaultUser);
objQuestionnaireBatchEN.IsDefaultUser = bolIsDefaultUser; //是否默认用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(conQuestionnaireBatch.IsDefaultUser) == false)
{
objQuestionnaireBatchEN.dicFldComparisonOp.Add(conQuestionnaireBatch.IsDefaultUser, strComparisonOp);
}
else
{
objQuestionnaireBatchEN.dicFldComparisonOp[conQuestionnaireBatch.IsDefaultUser] = strComparisonOp;
}
}
return objQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireBatchEN SetCreateDate(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, string strCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCreateDate, conQuestionnaireBatch.CreateDate);
clsCheckSql.CheckFieldLen(strCreateDate, 20, conQuestionnaireBatch.CreateDate);
objQuestionnaireBatchEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(conQuestionnaireBatch.CreateDate) == false)
{
objQuestionnaireBatchEN.dicFldComparisonOp.Add(conQuestionnaireBatch.CreateDate, strComparisonOp);
}
else
{
objQuestionnaireBatchEN.dicFldComparisonOp[conQuestionnaireBatch.CreateDate] = strComparisonOp;
}
}
return objQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireBatchEN SetCreateUser(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, string strCreateUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCreateUser, conQuestionnaireBatch.CreateUser);
clsCheckSql.CheckFieldLen(strCreateUser, 50, conQuestionnaireBatch.CreateUser);
objQuestionnaireBatchEN.CreateUser = strCreateUser; //建立用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(conQuestionnaireBatch.CreateUser) == false)
{
objQuestionnaireBatchEN.dicFldComparisonOp.Add(conQuestionnaireBatch.CreateUser, strComparisonOp);
}
else
{
objQuestionnaireBatchEN.dicFldComparisonOp[conQuestionnaireBatch.CreateUser] = strComparisonOp;
}
}
return objQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireBatchEN SetPageName(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, string strPageName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPageName, 100, conQuestionnaireBatch.PageName);
objQuestionnaireBatchEN.PageName = strPageName; //页面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(conQuestionnaireBatch.PageName) == false)
{
objQuestionnaireBatchEN.dicFldComparisonOp.Add(conQuestionnaireBatch.PageName, strComparisonOp);
}
else
{
objQuestionnaireBatchEN.dicFldComparisonOp[conQuestionnaireBatch.PageName] = strComparisonOp;
}
}
return objQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireBatchEN SetIsRandomSelSet(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, bool bolIsRandomSelSet, string strComparisonOp="")
	{
objQuestionnaireBatchEN.IsRandomSelSet = bolIsRandomSelSet; //是否随机选问卷集
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(conQuestionnaireBatch.IsRandomSelSet) == false)
{
objQuestionnaireBatchEN.dicFldComparisonOp.Add(conQuestionnaireBatch.IsRandomSelSet, strComparisonOp);
}
else
{
objQuestionnaireBatchEN.dicFldComparisonOp[conQuestionnaireBatch.IsRandomSelSet] = strComparisonOp;
}
}
return objQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireBatchEN SetUpdDate(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conQuestionnaireBatch.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQuestionnaireBatch.UpdDate);
objQuestionnaireBatchEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(conQuestionnaireBatch.UpdDate) == false)
{
objQuestionnaireBatchEN.dicFldComparisonOp.Add(conQuestionnaireBatch.UpdDate, strComparisonOp);
}
else
{
objQuestionnaireBatchEN.dicFldComparisonOp[conQuestionnaireBatch.UpdDate] = strComparisonOp;
}
}
return objQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireBatchEN SetUpdUser(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conQuestionnaireBatch.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQuestionnaireBatch.UpdUser);
objQuestionnaireBatchEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(conQuestionnaireBatch.UpdUser) == false)
{
objQuestionnaireBatchEN.dicFldComparisonOp.Add(conQuestionnaireBatch.UpdUser, strComparisonOp);
}
else
{
objQuestionnaireBatchEN.dicFldComparisonOp[conQuestionnaireBatch.UpdUser] = strComparisonOp;
}
}
return objQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireBatchEN SetMemo(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQuestionnaireBatch.Memo);
objQuestionnaireBatchEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(conQuestionnaireBatch.Memo) == false)
{
objQuestionnaireBatchEN.dicFldComparisonOp.Add(conQuestionnaireBatch.Memo, strComparisonOp);
}
else
{
objQuestionnaireBatchEN.dicFldComparisonOp[conQuestionnaireBatch.Memo] = strComparisonOp;
}
}
return objQuestionnaireBatchEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQuestionnaireBatchEN objQuestionnaireBatch_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQuestionnaireBatch_Cond.IsUpdated(conQuestionnaireBatch.BatchId) == true)
{
string strComparisonOp_BatchId = objQuestionnaireBatch_Cond.dicFldComparisonOp[conQuestionnaireBatch.BatchId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireBatch.BatchId, objQuestionnaireBatch_Cond.BatchId, strComparisonOp_BatchId);
}
if (objQuestionnaireBatch_Cond.IsUpdated(conQuestionnaireBatch.BatchName) == true)
{
string strComparisonOp_BatchName = objQuestionnaireBatch_Cond.dicFldComparisonOp[conQuestionnaireBatch.BatchName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireBatch.BatchName, objQuestionnaireBatch_Cond.BatchName, strComparisonOp_BatchName);
}
if (objQuestionnaireBatch_Cond.IsUpdated(conQuestionnaireBatch.RoleId) == true)
{
string strComparisonOp_RoleId = objQuestionnaireBatch_Cond.dicFldComparisonOp[conQuestionnaireBatch.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireBatch.RoleId, objQuestionnaireBatch_Cond.RoleId, strComparisonOp_RoleId);
}
if (objQuestionnaireBatch_Cond.IsUpdated(conQuestionnaireBatch.QuestionnaireSetId) == true)
{
string strComparisonOp_QuestionnaireSetId = objQuestionnaireBatch_Cond.dicFldComparisonOp[conQuestionnaireBatch.QuestionnaireSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireBatch.QuestionnaireSetId, objQuestionnaireBatch_Cond.QuestionnaireSetId, strComparisonOp_QuestionnaireSetId);
}
if (objQuestionnaireBatch_Cond.IsUpdated(conQuestionnaireBatch.IsDefault) == true)
{
if (objQuestionnaireBatch_Cond.IsDefault == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaireBatch.IsDefault);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaireBatch.IsDefault);
}
}
if (objQuestionnaireBatch_Cond.IsUpdated(conQuestionnaireBatch.IsDefaultUser) == true)
{
if (objQuestionnaireBatch_Cond.IsDefaultUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaireBatch.IsDefaultUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaireBatch.IsDefaultUser);
}
}
if (objQuestionnaireBatch_Cond.IsUpdated(conQuestionnaireBatch.CreateDate) == true)
{
string strComparisonOp_CreateDate = objQuestionnaireBatch_Cond.dicFldComparisonOp[conQuestionnaireBatch.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireBatch.CreateDate, objQuestionnaireBatch_Cond.CreateDate, strComparisonOp_CreateDate);
}
if (objQuestionnaireBatch_Cond.IsUpdated(conQuestionnaireBatch.CreateUser) == true)
{
string strComparisonOp_CreateUser = objQuestionnaireBatch_Cond.dicFldComparisonOp[conQuestionnaireBatch.CreateUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireBatch.CreateUser, objQuestionnaireBatch_Cond.CreateUser, strComparisonOp_CreateUser);
}
if (objQuestionnaireBatch_Cond.IsUpdated(conQuestionnaireBatch.PageName) == true)
{
string strComparisonOp_PageName = objQuestionnaireBatch_Cond.dicFldComparisonOp[conQuestionnaireBatch.PageName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireBatch.PageName, objQuestionnaireBatch_Cond.PageName, strComparisonOp_PageName);
}
if (objQuestionnaireBatch_Cond.IsUpdated(conQuestionnaireBatch.IsRandomSelSet) == true)
{
if (objQuestionnaireBatch_Cond.IsRandomSelSet == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaireBatch.IsRandomSelSet);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaireBatch.IsRandomSelSet);
}
}
if (objQuestionnaireBatch_Cond.IsUpdated(conQuestionnaireBatch.UpdDate) == true)
{
string strComparisonOp_UpdDate = objQuestionnaireBatch_Cond.dicFldComparisonOp[conQuestionnaireBatch.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireBatch.UpdDate, objQuestionnaireBatch_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objQuestionnaireBatch_Cond.IsUpdated(conQuestionnaireBatch.UpdUser) == true)
{
string strComparisonOp_UpdUser = objQuestionnaireBatch_Cond.dicFldComparisonOp[conQuestionnaireBatch.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireBatch.UpdUser, objQuestionnaireBatch_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objQuestionnaireBatch_Cond.IsUpdated(conQuestionnaireBatch.Memo) == true)
{
string strComparisonOp_Memo = objQuestionnaireBatch_Cond.dicFldComparisonOp[conQuestionnaireBatch.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireBatch.Memo, objQuestionnaireBatch_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
 if (string.IsNullOrEmpty(objQuestionnaireBatchEN.BatchId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objQuestionnaireBatchEN.sf_UpdFldSetStr = objQuestionnaireBatchEN.getsf_UpdFldSetStr();
clsQuestionnaireBatchWApi.CheckPropertyNew(objQuestionnaireBatchEN); 
bool bolResult = clsQuestionnaireBatchWApi.UpdateRecord(objQuestionnaireBatchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireBatchWApi.ReFreshCache();
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
 /// <param name = "objQuestionnaireBatchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
 if (string.IsNullOrEmpty(objQuestionnaireBatchEN.BatchId) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQuestionnaireBatchWApi.IsExist(objQuestionnaireBatchEN.BatchId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objQuestionnaireBatchEN.BatchId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsQuestionnaireBatchWApi.CheckPropertyNew(objQuestionnaireBatchEN); 
bool bolResult = clsQuestionnaireBatchWApi.AddNewRecord(objQuestionnaireBatchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireBatchWApi.ReFreshCache();
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
 /// <param name = "objQuestionnaireBatchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
try
{
clsQuestionnaireBatchWApi.CheckPropertyNew(objQuestionnaireBatchEN); 
string strBatchId = clsQuestionnaireBatchWApi.AddNewRecordWithMaxId(objQuestionnaireBatchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireBatchWApi.ReFreshCache();
return strBatchId;
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
 /// <param name = "objQuestionnaireBatchEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, string strWhereCond)
{
try
{
clsQuestionnaireBatchWApi.CheckPropertyNew(objQuestionnaireBatchEN); 
bool bolResult = clsQuestionnaireBatchWApi.UpdateWithCondition(objQuestionnaireBatchEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireBatchWApi.ReFreshCache();
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
 /// 问卷批次(QuestionnaireBatch)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsQuestionnaireBatchWApi
{
private static readonly string mstrApiControllerName = "QuestionnaireBatchApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsQuestionnaireBatchWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_BatchId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[问卷批次]...","0");
List<clsQuestionnaireBatchEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="BatchId";
objDDL.DataTextField="BatchName";
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
public static void BindCbo_BatchId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQuestionnaireBatch.BatchId); 
List<clsQuestionnaireBatchEN> arrObjLst = clsQuestionnaireBatchWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQuestionnaireBatchEN objQuestionnaireBatchEN = new clsQuestionnaireBatchEN()
{
BatchId = "0",
BatchName = "选[问卷批次]..."
};
arrObjLst.Insert(0, objQuestionnaireBatchEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQuestionnaireBatch.BatchId;
objComboBox.DisplayMember = conQuestionnaireBatch.BatchName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
if (!Object.Equals(null, objQuestionnaireBatchEN.BatchId) && GetStrLen(objQuestionnaireBatchEN.BatchId) > 4)
{
 throw new Exception("字段[批次ID]的长度不能超过4!");
}
if (!Object.Equals(null, objQuestionnaireBatchEN.BatchName) && GetStrLen(objQuestionnaireBatchEN.BatchName) > 50)
{
 throw new Exception("字段[批次名称]的长度不能超过50!");
}
if (!Object.Equals(null, objQuestionnaireBatchEN.RoleId) && GetStrLen(objQuestionnaireBatchEN.RoleId) > 8)
{
 throw new Exception("字段[角色Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQuestionnaireBatchEN.QuestionnaireSetId) && GetStrLen(objQuestionnaireBatchEN.QuestionnaireSetId) > 4)
{
 throw new Exception("字段[问卷集ID]的长度不能超过4!");
}
if (!Object.Equals(null, objQuestionnaireBatchEN.CreateDate) && GetStrLen(objQuestionnaireBatchEN.CreateDate) > 20)
{
 throw new Exception("字段[建立日期]的长度不能超过20!");
}
if (!Object.Equals(null, objQuestionnaireBatchEN.CreateUser) && GetStrLen(objQuestionnaireBatchEN.CreateUser) > 50)
{
 throw new Exception("字段[建立用户]的长度不能超过50!");
}
if (!Object.Equals(null, objQuestionnaireBatchEN.PageName) && GetStrLen(objQuestionnaireBatchEN.PageName) > 100)
{
 throw new Exception("字段[页面名称]的长度不能超过100!");
}
if (!Object.Equals(null, objQuestionnaireBatchEN.UpdDate) && GetStrLen(objQuestionnaireBatchEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objQuestionnaireBatchEN.UpdUser) && GetStrLen(objQuestionnaireBatchEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objQuestionnaireBatchEN.Memo) && GetStrLen(objQuestionnaireBatchEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objQuestionnaireBatchEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strBatchId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQuestionnaireBatchEN GetObjByBatchId(string strBatchId)
{
string strAction = "GetObjByBatchId";
string strErrMsg = string.Empty;
string strResult = "";
clsQuestionnaireBatchEN objQuestionnaireBatchEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["BatchId"] = strBatchId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objQuestionnaireBatchEN = JsonConvert.DeserializeObject<clsQuestionnaireBatchEN>((string)jobjReturn["ReturnObj"]);
return objQuestionnaireBatchEN;
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
 /// <param name = "strBatchId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQuestionnaireBatchEN GetObjByBatchId_WA_Cache(string strBatchId)
{
string strAction = "GetObjByBatchId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsQuestionnaireBatchEN objQuestionnaireBatchEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["BatchId"] = strBatchId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objQuestionnaireBatchEN = JsonConvert.DeserializeObject<clsQuestionnaireBatchEN>((string)jobjReturn["ReturnObj"]);
return objQuestionnaireBatchEN;
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
public static clsQuestionnaireBatchEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsQuestionnaireBatchEN objQuestionnaireBatchEN = null;
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
objQuestionnaireBatchEN = JsonConvert.DeserializeObject<clsQuestionnaireBatchEN>((string)jobjReturn["ReturnObj"]);
return objQuestionnaireBatchEN;
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
 /// <param name = "strBatchId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQuestionnaireBatchEN GetObjByBatchId_Cache(string strBatchId)
{
if (string.IsNullOrEmpty(strBatchId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsQuestionnaireBatchEN._CurrTabName_S);
List<clsQuestionnaireBatchEN> arrQuestionnaireBatchObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsQuestionnaireBatchEN> arrQuestionnaireBatchObjLst_Sel =
from objQuestionnaireBatchEN in arrQuestionnaireBatchObjLst_Cache
where objQuestionnaireBatchEN.BatchId == strBatchId
select objQuestionnaireBatchEN;
if (arrQuestionnaireBatchObjLst_Sel.Count() == 0)
{
   clsQuestionnaireBatchEN obj = clsQuestionnaireBatchWApi.GetObjByBatchId(strBatchId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrQuestionnaireBatchObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strBatchId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetBatchNameByBatchId_Cache(string strBatchId)
{
if (string.IsNullOrEmpty(strBatchId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsQuestionnaireBatchEN._CurrTabName_S);
List<clsQuestionnaireBatchEN> arrQuestionnaireBatchObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsQuestionnaireBatchEN> arrQuestionnaireBatchObjLst_Sel1 =
from objQuestionnaireBatchEN in arrQuestionnaireBatchObjLst_Cache
where objQuestionnaireBatchEN.BatchId == strBatchId
select objQuestionnaireBatchEN;
List <clsQuestionnaireBatchEN> arrQuestionnaireBatchObjLst_Sel = new List<clsQuestionnaireBatchEN>();
foreach (clsQuestionnaireBatchEN obj in arrQuestionnaireBatchObjLst_Sel1)
{
arrQuestionnaireBatchObjLst_Sel.Add(obj);
}
if (arrQuestionnaireBatchObjLst_Sel.Count > 0)
{
return arrQuestionnaireBatchObjLst_Sel[0].BatchName;
}
string strErrMsgForGetObjById = string.Format("在QuestionnaireBatch对象缓存列表中,找不到记录[BatchId = {0}](函数:{1})", strBatchId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsQuestionnaireBatchBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strBatchId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByBatchId_Cache(string strBatchId)
{
if (string.IsNullOrEmpty(strBatchId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsQuestionnaireBatchEN._CurrTabName_S);
List<clsQuestionnaireBatchEN> arrQuestionnaireBatchObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsQuestionnaireBatchEN> arrQuestionnaireBatchObjLst_Sel1 =
from objQuestionnaireBatchEN in arrQuestionnaireBatchObjLst_Cache
where objQuestionnaireBatchEN.BatchId == strBatchId
select objQuestionnaireBatchEN;
List <clsQuestionnaireBatchEN> arrQuestionnaireBatchObjLst_Sel = new List<clsQuestionnaireBatchEN>();
foreach (clsQuestionnaireBatchEN obj in arrQuestionnaireBatchObjLst_Sel1)
{
arrQuestionnaireBatchObjLst_Sel.Add(obj);
}
if (arrQuestionnaireBatchObjLst_Sel.Count > 0)
{
return arrQuestionnaireBatchObjLst_Sel[0].BatchName;
}
string strErrMsgForGetObjById = string.Format("在QuestionnaireBatch对象缓存列表中,找不到记录的相关名称[BatchId = {0}](函数:{1})", strBatchId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsQuestionnaireBatchBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionnaireBatchEN> GetObjLst(string strWhereCond)
{
 List<clsQuestionnaireBatchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionnaireBatchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionnaireBatchEN> GetObjLstByBatchIdLst(List<string> arrBatchId)
{
 List<clsQuestionnaireBatchEN> arrObjLst = null; 
string strAction = "GetObjLstByBatchIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrBatchId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionnaireBatchEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strBatchId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsQuestionnaireBatchEN> GetObjLstByBatchIdLst_Cache(List<string> arrBatchId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsQuestionnaireBatchEN._CurrTabName_S);
List<clsQuestionnaireBatchEN> arrQuestionnaireBatchObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsQuestionnaireBatchEN> arrQuestionnaireBatchObjLst_Sel =
from objQuestionnaireBatchEN in arrQuestionnaireBatchObjLst_Cache
where arrBatchId.Contains(objQuestionnaireBatchEN.BatchId)
select objQuestionnaireBatchEN;
return arrQuestionnaireBatchObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionnaireBatchEN> GetObjLstByBatchIdLst_WA_Cache(List<string> arrBatchId)
{
 List<clsQuestionnaireBatchEN> arrObjLst = null; 
string strAction = "GetObjLstByBatchIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrBatchId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionnaireBatchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionnaireBatchEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsQuestionnaireBatchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionnaireBatchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionnaireBatchEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsQuestionnaireBatchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionnaireBatchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionnaireBatchEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsQuestionnaireBatchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionnaireBatchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionnaireBatchEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsQuestionnaireBatchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionnaireBatchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strBatchId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsQuestionnaireBatchEN objQuestionnaireBatchEN = clsQuestionnaireBatchWApi.GetObjByBatchId(strBatchId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strBatchId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsQuestionnaireBatchWApi.ReFreshCache();
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
public static int DelQuestionnaireBatchs(List<string> arrBatchId)
{
string strAction = "DelQuestionnaireBatchs";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrBatchId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsQuestionnaireBatchWApi.ReFreshCache();
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
public static int DelQuestionnaireBatchsByCond(string strWhereCond)
{
string strAction = "DelQuestionnaireBatchsByCond";
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
public static bool AddNewRecord(clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionnaireBatchEN>(objQuestionnaireBatchEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireBatchWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionnaireBatchEN>(objQuestionnaireBatchEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireBatchWApi.ReFreshCache();
var strBatchId = (string)jobjReturn["ReturnStr"];
return strBatchId;
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
public static bool UpdateRecord(clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
if (string.IsNullOrEmpty(objQuestionnaireBatchEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQuestionnaireBatchEN.BatchId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionnaireBatchEN>(objQuestionnaireBatchEN);
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
 /// <param name = "objQuestionnaireBatchEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsQuestionnaireBatchEN objQuestionnaireBatchEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objQuestionnaireBatchEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQuestionnaireBatchEN.BatchId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQuestionnaireBatchEN.BatchId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionnaireBatchEN>(objQuestionnaireBatchEN);
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
public static bool IsExist(string strBatchId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["BatchId"] = strBatchId
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
 /// <param name = "objQuestionnaireBatchENS">源对象</param>
 /// <param name = "objQuestionnaireBatchENT">目标对象</param>
 public static void CopyTo(clsQuestionnaireBatchEN objQuestionnaireBatchENS, clsQuestionnaireBatchEN objQuestionnaireBatchENT)
{
try
{
objQuestionnaireBatchENT.BatchId = objQuestionnaireBatchENS.BatchId; //批次ID
objQuestionnaireBatchENT.BatchName = objQuestionnaireBatchENS.BatchName; //批次名称
objQuestionnaireBatchENT.RoleId = objQuestionnaireBatchENS.RoleId; //角色Id
objQuestionnaireBatchENT.QuestionnaireSetId = objQuestionnaireBatchENS.QuestionnaireSetId; //问卷集ID
objQuestionnaireBatchENT.IsDefault = objQuestionnaireBatchENS.IsDefault; //是否默认
objQuestionnaireBatchENT.IsDefaultUser = objQuestionnaireBatchENS.IsDefaultUser; //是否默认用户
objQuestionnaireBatchENT.CreateDate = objQuestionnaireBatchENS.CreateDate; //建立日期
objQuestionnaireBatchENT.CreateUser = objQuestionnaireBatchENS.CreateUser; //建立用户
objQuestionnaireBatchENT.PageName = objQuestionnaireBatchENS.PageName; //页面名称
objQuestionnaireBatchENT.IsRandomSelSet = objQuestionnaireBatchENS.IsRandomSelSet; //是否随机选问卷集
objQuestionnaireBatchENT.UpdDate = objQuestionnaireBatchENS.UpdDate; //修改日期
objQuestionnaireBatchENT.UpdUser = objQuestionnaireBatchENS.UpdUser; //修改人
objQuestionnaireBatchENT.Memo = objQuestionnaireBatchENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsQuestionnaireBatchEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsQuestionnaireBatchEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsQuestionnaireBatchEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsQuestionnaireBatchEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsQuestionnaireBatchEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsQuestionnaireBatchEN.AttributeName)
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
if (clsQuestionnaireBatchWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireBatchWApi没有刷新缓存机制(clsQuestionnaireBatchWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by BatchId");
//if (arrQuestionnaireBatchObjLst_Cache == null)
//{
//arrQuestionnaireBatchObjLst_Cache = await clsQuestionnaireBatchWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsQuestionnaireBatchEN._CurrTabName_S);
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
if (clsQuestionnaireBatchWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQuestionnaireBatchEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsQuestionnaireBatchWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQuestionnaireBatchEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsQuestionnaireBatchEN._CurrTabName_S);
List<clsQuestionnaireBatchEN> arrQuestionnaireBatchObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQuestionnaireBatchObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsQuestionnaireBatchEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conQuestionnaireBatch.BatchId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireBatch.BatchName, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireBatch.RoleId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireBatch.QuestionnaireSetId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireBatch.IsDefault, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQuestionnaireBatch.IsDefaultUser, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQuestionnaireBatch.CreateDate, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireBatch.CreateUser, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireBatch.PageName, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireBatch.IsRandomSelSet, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQuestionnaireBatch.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireBatch.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireBatch.Memo, Type.GetType("System.String"));
foreach (clsQuestionnaireBatchEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conQuestionnaireBatch.BatchId] = objInFor[conQuestionnaireBatch.BatchId];
objDR[conQuestionnaireBatch.BatchName] = objInFor[conQuestionnaireBatch.BatchName];
objDR[conQuestionnaireBatch.RoleId] = objInFor[conQuestionnaireBatch.RoleId];
objDR[conQuestionnaireBatch.QuestionnaireSetId] = objInFor[conQuestionnaireBatch.QuestionnaireSetId];
objDR[conQuestionnaireBatch.IsDefault] = objInFor[conQuestionnaireBatch.IsDefault];
objDR[conQuestionnaireBatch.IsDefaultUser] = objInFor[conQuestionnaireBatch.IsDefaultUser];
objDR[conQuestionnaireBatch.CreateDate] = objInFor[conQuestionnaireBatch.CreateDate];
objDR[conQuestionnaireBatch.CreateUser] = objInFor[conQuestionnaireBatch.CreateUser];
objDR[conQuestionnaireBatch.PageName] = objInFor[conQuestionnaireBatch.PageName];
objDR[conQuestionnaireBatch.IsRandomSelSet] = objInFor[conQuestionnaireBatch.IsRandomSelSet];
objDR[conQuestionnaireBatch.UpdDate] = objInFor[conQuestionnaireBatch.UpdDate];
objDR[conQuestionnaireBatch.UpdUser] = objInFor[conQuestionnaireBatch.UpdUser];
objDR[conQuestionnaireBatch.Memo] = objInFor[conQuestionnaireBatch.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 问卷批次(QuestionnaireBatch)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4QuestionnaireBatch : clsCommFun4BL
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
clsQuestionnaireBatchWApi.ReFreshThisCache();
clsvQuestionnaireBatchWApi.ReFreshThisCache();
}
}

}