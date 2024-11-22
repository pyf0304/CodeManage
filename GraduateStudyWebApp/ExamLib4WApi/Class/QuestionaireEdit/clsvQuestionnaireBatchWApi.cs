
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaireBatchWApi
 表名:vQuestionnaireBatch(01120021)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:49:05
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
public static class clsvQuestionnaireBatchWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireBatchEN SetBatchId(this clsvQuestionnaireBatchEN objvQuestionnaireBatchEN, string strBatchId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBatchId, 4, convQuestionnaireBatch.BatchId);
clsCheckSql.CheckFieldForeignKey(strBatchId, 4, convQuestionnaireBatch.BatchId);
objvQuestionnaireBatchEN.BatchId = strBatchId; //批次ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(convQuestionnaireBatch.BatchId) == false)
{
objvQuestionnaireBatchEN.dicFldComparisonOp.Add(convQuestionnaireBatch.BatchId, strComparisonOp);
}
else
{
objvQuestionnaireBatchEN.dicFldComparisonOp[convQuestionnaireBatch.BatchId] = strComparisonOp;
}
}
return objvQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireBatchEN SetBatchName(this clsvQuestionnaireBatchEN objvQuestionnaireBatchEN, string strBatchName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strBatchName, convQuestionnaireBatch.BatchName);
clsCheckSql.CheckFieldLen(strBatchName, 50, convQuestionnaireBatch.BatchName);
objvQuestionnaireBatchEN.BatchName = strBatchName; //批次名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(convQuestionnaireBatch.BatchName) == false)
{
objvQuestionnaireBatchEN.dicFldComparisonOp.Add(convQuestionnaireBatch.BatchName, strComparisonOp);
}
else
{
objvQuestionnaireBatchEN.dicFldComparisonOp[convQuestionnaireBatch.BatchName] = strComparisonOp;
}
}
return objvQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireBatchEN SetIsDefault(this clsvQuestionnaireBatchEN objvQuestionnaireBatchEN, bool bolIsDefault, string strComparisonOp="")
	{
objvQuestionnaireBatchEN.IsDefault = bolIsDefault; //是否默认
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(convQuestionnaireBatch.IsDefault) == false)
{
objvQuestionnaireBatchEN.dicFldComparisonOp.Add(convQuestionnaireBatch.IsDefault, strComparisonOp);
}
else
{
objvQuestionnaireBatchEN.dicFldComparisonOp[convQuestionnaireBatch.IsDefault] = strComparisonOp;
}
}
return objvQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireBatchEN SetCreateDate(this clsvQuestionnaireBatchEN objvQuestionnaireBatchEN, string strCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convQuestionnaireBatch.CreateDate);
objvQuestionnaireBatchEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(convQuestionnaireBatch.CreateDate) == false)
{
objvQuestionnaireBatchEN.dicFldComparisonOp.Add(convQuestionnaireBatch.CreateDate, strComparisonOp);
}
else
{
objvQuestionnaireBatchEN.dicFldComparisonOp[convQuestionnaireBatch.CreateDate] = strComparisonOp;
}
}
return objvQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireBatchEN SetCreateUser(this clsvQuestionnaireBatchEN objvQuestionnaireBatchEN, string strCreateUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateUser, 50, convQuestionnaireBatch.CreateUser);
objvQuestionnaireBatchEN.CreateUser = strCreateUser; //建立用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(convQuestionnaireBatch.CreateUser) == false)
{
objvQuestionnaireBatchEN.dicFldComparisonOp.Add(convQuestionnaireBatch.CreateUser, strComparisonOp);
}
else
{
objvQuestionnaireBatchEN.dicFldComparisonOp[convQuestionnaireBatch.CreateUser] = strComparisonOp;
}
}
return objvQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireBatchEN SetPageName(this clsvQuestionnaireBatchEN objvQuestionnaireBatchEN, string strPageName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPageName, 100, convQuestionnaireBatch.PageName);
objvQuestionnaireBatchEN.PageName = strPageName; //页面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(convQuestionnaireBatch.PageName) == false)
{
objvQuestionnaireBatchEN.dicFldComparisonOp.Add(convQuestionnaireBatch.PageName, strComparisonOp);
}
else
{
objvQuestionnaireBatchEN.dicFldComparisonOp[convQuestionnaireBatch.PageName] = strComparisonOp;
}
}
return objvQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireBatchEN SetIsRandomSelSet(this clsvQuestionnaireBatchEN objvQuestionnaireBatchEN, bool bolIsRandomSelSet, string strComparisonOp="")
	{
objvQuestionnaireBatchEN.IsRandomSelSet = bolIsRandomSelSet; //是否随机选问卷集
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(convQuestionnaireBatch.IsRandomSelSet) == false)
{
objvQuestionnaireBatchEN.dicFldComparisonOp.Add(convQuestionnaireBatch.IsRandomSelSet, strComparisonOp);
}
else
{
objvQuestionnaireBatchEN.dicFldComparisonOp[convQuestionnaireBatch.IsRandomSelSet] = strComparisonOp;
}
}
return objvQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireBatchEN SetQuestionnaireSetName(this clsvQuestionnaireBatchEN objvQuestionnaireBatchEN, string strQuestionnaireSetName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionnaireSetName, 50, convQuestionnaireBatch.QuestionnaireSetName);
objvQuestionnaireBatchEN.QuestionnaireSetName = strQuestionnaireSetName; //问卷集名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(convQuestionnaireBatch.QuestionnaireSetName) == false)
{
objvQuestionnaireBatchEN.dicFldComparisonOp.Add(convQuestionnaireBatch.QuestionnaireSetName, strComparisonOp);
}
else
{
objvQuestionnaireBatchEN.dicFldComparisonOp[convQuestionnaireBatch.QuestionnaireSetName] = strComparisonOp;
}
}
return objvQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireBatchEN SetRoleName(this clsvQuestionnaireBatchEN objvQuestionnaireBatchEN, string strRoleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleName, 100, convQuestionnaireBatch.RoleName);
objvQuestionnaireBatchEN.RoleName = strRoleName; //角色名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(convQuestionnaireBatch.RoleName) == false)
{
objvQuestionnaireBatchEN.dicFldComparisonOp.Add(convQuestionnaireBatch.RoleName, strComparisonOp);
}
else
{
objvQuestionnaireBatchEN.dicFldComparisonOp[convQuestionnaireBatch.RoleName] = strComparisonOp;
}
}
return objvQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireBatchEN SetRoleId(this clsvQuestionnaireBatchEN objvQuestionnaireBatchEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleId, 8, convQuestionnaireBatch.RoleId);
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convQuestionnaireBatch.RoleId);
objvQuestionnaireBatchEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(convQuestionnaireBatch.RoleId) == false)
{
objvQuestionnaireBatchEN.dicFldComparisonOp.Add(convQuestionnaireBatch.RoleId, strComparisonOp);
}
else
{
objvQuestionnaireBatchEN.dicFldComparisonOp[convQuestionnaireBatch.RoleId] = strComparisonOp;
}
}
return objvQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireBatchEN SetQuestionnaireSetId(this clsvQuestionnaireBatchEN objvQuestionnaireBatchEN, string strQuestionnaireSetId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionnaireSetId, 4, convQuestionnaireBatch.QuestionnaireSetId);
clsCheckSql.CheckFieldForeignKey(strQuestionnaireSetId, 4, convQuestionnaireBatch.QuestionnaireSetId);
objvQuestionnaireBatchEN.QuestionnaireSetId = strQuestionnaireSetId; //问卷集ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(convQuestionnaireBatch.QuestionnaireSetId) == false)
{
objvQuestionnaireBatchEN.dicFldComparisonOp.Add(convQuestionnaireBatch.QuestionnaireSetId, strComparisonOp);
}
else
{
objvQuestionnaireBatchEN.dicFldComparisonOp[convQuestionnaireBatch.QuestionnaireSetId] = strComparisonOp;
}
}
return objvQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireBatchEN SetMemo(this clsvQuestionnaireBatchEN objvQuestionnaireBatchEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQuestionnaireBatch.Memo);
objvQuestionnaireBatchEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(convQuestionnaireBatch.Memo) == false)
{
objvQuestionnaireBatchEN.dicFldComparisonOp.Add(convQuestionnaireBatch.Memo, strComparisonOp);
}
else
{
objvQuestionnaireBatchEN.dicFldComparisonOp[convQuestionnaireBatch.Memo] = strComparisonOp;
}
}
return objvQuestionnaireBatchEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQuestionnaireBatchEN objvQuestionnaireBatch_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQuestionnaireBatch_Cond.IsUpdated(convQuestionnaireBatch.BatchId) == true)
{
string strComparisonOp_BatchId = objvQuestionnaireBatch_Cond.dicFldComparisonOp[convQuestionnaireBatch.BatchId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaireBatch.BatchId, objvQuestionnaireBatch_Cond.BatchId, strComparisonOp_BatchId);
}
if (objvQuestionnaireBatch_Cond.IsUpdated(convQuestionnaireBatch.BatchName) == true)
{
string strComparisonOp_BatchName = objvQuestionnaireBatch_Cond.dicFldComparisonOp[convQuestionnaireBatch.BatchName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaireBatch.BatchName, objvQuestionnaireBatch_Cond.BatchName, strComparisonOp_BatchName);
}
if (objvQuestionnaireBatch_Cond.IsUpdated(convQuestionnaireBatch.IsDefault) == true)
{
if (objvQuestionnaireBatch_Cond.IsDefault == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaireBatch.IsDefault);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaireBatch.IsDefault);
}
}
if (objvQuestionnaireBatch_Cond.IsUpdated(convQuestionnaireBatch.CreateDate) == true)
{
string strComparisonOp_CreateDate = objvQuestionnaireBatch_Cond.dicFldComparisonOp[convQuestionnaireBatch.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaireBatch.CreateDate, objvQuestionnaireBatch_Cond.CreateDate, strComparisonOp_CreateDate);
}
if (objvQuestionnaireBatch_Cond.IsUpdated(convQuestionnaireBatch.CreateUser) == true)
{
string strComparisonOp_CreateUser = objvQuestionnaireBatch_Cond.dicFldComparisonOp[convQuestionnaireBatch.CreateUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaireBatch.CreateUser, objvQuestionnaireBatch_Cond.CreateUser, strComparisonOp_CreateUser);
}
if (objvQuestionnaireBatch_Cond.IsUpdated(convQuestionnaireBatch.PageName) == true)
{
string strComparisonOp_PageName = objvQuestionnaireBatch_Cond.dicFldComparisonOp[convQuestionnaireBatch.PageName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaireBatch.PageName, objvQuestionnaireBatch_Cond.PageName, strComparisonOp_PageName);
}
if (objvQuestionnaireBatch_Cond.IsUpdated(convQuestionnaireBatch.IsRandomSelSet) == true)
{
if (objvQuestionnaireBatch_Cond.IsRandomSelSet == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaireBatch.IsRandomSelSet);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaireBatch.IsRandomSelSet);
}
}
if (objvQuestionnaireBatch_Cond.IsUpdated(convQuestionnaireBatch.QuestionnaireSetName) == true)
{
string strComparisonOp_QuestionnaireSetName = objvQuestionnaireBatch_Cond.dicFldComparisonOp[convQuestionnaireBatch.QuestionnaireSetName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaireBatch.QuestionnaireSetName, objvQuestionnaireBatch_Cond.QuestionnaireSetName, strComparisonOp_QuestionnaireSetName);
}
if (objvQuestionnaireBatch_Cond.IsUpdated(convQuestionnaireBatch.RoleName) == true)
{
string strComparisonOp_RoleName = objvQuestionnaireBatch_Cond.dicFldComparisonOp[convQuestionnaireBatch.RoleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaireBatch.RoleName, objvQuestionnaireBatch_Cond.RoleName, strComparisonOp_RoleName);
}
if (objvQuestionnaireBatch_Cond.IsUpdated(convQuestionnaireBatch.RoleId) == true)
{
string strComparisonOp_RoleId = objvQuestionnaireBatch_Cond.dicFldComparisonOp[convQuestionnaireBatch.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaireBatch.RoleId, objvQuestionnaireBatch_Cond.RoleId, strComparisonOp_RoleId);
}
if (objvQuestionnaireBatch_Cond.IsUpdated(convQuestionnaireBatch.QuestionnaireSetId) == true)
{
string strComparisonOp_QuestionnaireSetId = objvQuestionnaireBatch_Cond.dicFldComparisonOp[convQuestionnaireBatch.QuestionnaireSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaireBatch.QuestionnaireSetId, objvQuestionnaireBatch_Cond.QuestionnaireSetId, strComparisonOp_QuestionnaireSetId);
}
if (objvQuestionnaireBatch_Cond.IsUpdated(convQuestionnaireBatch.Memo) == true)
{
string strComparisonOp_Memo = objvQuestionnaireBatch_Cond.dicFldComparisonOp[convQuestionnaireBatch.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaireBatch.Memo, objvQuestionnaireBatch_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v问卷批次(vQuestionnaireBatch)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQuestionnaireBatchWApi
{
private static readonly string mstrApiControllerName = "vQuestionnaireBatchApi";

 public clsvQuestionnaireBatchWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v问卷批次]...","0");
List<clsvQuestionnaireBatchEN> arrObjLst = GetObjLst("1=1");
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
string strCondition = string.Format("1 =1 Order By {0}", convQuestionnaireBatch.BatchId); 
List<clsvQuestionnaireBatchEN> arrObjLst = clsvQuestionnaireBatchWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQuestionnaireBatchEN objvQuestionnaireBatchEN = new clsvQuestionnaireBatchEN()
{
BatchId = "0",
BatchName = "选[v问卷批次]..."
};
arrObjLst.Insert(0, objvQuestionnaireBatchEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQuestionnaireBatch.BatchId;
objComboBox.DisplayMember = convQuestionnaireBatch.BatchName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strBatchId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionnaireBatchEN GetObjByBatchId(string strBatchId)
{
string strAction = "GetObjByBatchId";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionnaireBatchEN objvQuestionnaireBatchEN = null;
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
objvQuestionnaireBatchEN = JsonConvert.DeserializeObject<clsvQuestionnaireBatchEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionnaireBatchEN;
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
public static clsvQuestionnaireBatchEN GetObjByBatchId_WA_Cache(string strBatchId)
{
string strAction = "GetObjByBatchId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionnaireBatchEN objvQuestionnaireBatchEN = null;
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
objvQuestionnaireBatchEN = JsonConvert.DeserializeObject<clsvQuestionnaireBatchEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionnaireBatchEN;
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
public static clsvQuestionnaireBatchEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionnaireBatchEN objvQuestionnaireBatchEN = null;
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
objvQuestionnaireBatchEN = JsonConvert.DeserializeObject<clsvQuestionnaireBatchEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionnaireBatchEN;
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
public static clsvQuestionnaireBatchEN GetObjByBatchId_Cache(string strBatchId)
{
if (string.IsNullOrEmpty(strBatchId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvQuestionnaireBatchEN._CurrTabName_S);
List<clsvQuestionnaireBatchEN> arrvQuestionnaireBatchObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQuestionnaireBatchEN> arrvQuestionnaireBatchObjLst_Sel =
from objvQuestionnaireBatchEN in arrvQuestionnaireBatchObjLst_Cache
where objvQuestionnaireBatchEN.BatchId == strBatchId
select objvQuestionnaireBatchEN;
if (arrvQuestionnaireBatchObjLst_Sel.Count() == 0)
{
   clsvQuestionnaireBatchEN obj = clsvQuestionnaireBatchWApi.GetObjByBatchId(strBatchId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvQuestionnaireBatchObjLst_Sel.First();
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
string strKey = string.Format("{0}", clsvQuestionnaireBatchEN._CurrTabName_S);
List<clsvQuestionnaireBatchEN> arrvQuestionnaireBatchObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQuestionnaireBatchEN> arrvQuestionnaireBatchObjLst_Sel1 =
from objvQuestionnaireBatchEN in arrvQuestionnaireBatchObjLst_Cache
where objvQuestionnaireBatchEN.BatchId == strBatchId
select objvQuestionnaireBatchEN;
List <clsvQuestionnaireBatchEN> arrvQuestionnaireBatchObjLst_Sel = new List<clsvQuestionnaireBatchEN>();
foreach (clsvQuestionnaireBatchEN obj in arrvQuestionnaireBatchObjLst_Sel1)
{
arrvQuestionnaireBatchObjLst_Sel.Add(obj);
}
if (arrvQuestionnaireBatchObjLst_Sel.Count > 0)
{
return arrvQuestionnaireBatchObjLst_Sel[0].BatchName;
}
string strErrMsgForGetObjById = string.Format("在vQuestionnaireBatch对象缓存列表中,找不到记录[BatchId = {0}](函数:{1})", strBatchId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvQuestionnaireBatchBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
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
string strKey = string.Format("{0}", clsvQuestionnaireBatchEN._CurrTabName_S);
List<clsvQuestionnaireBatchEN> arrvQuestionnaireBatchObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQuestionnaireBatchEN> arrvQuestionnaireBatchObjLst_Sel1 =
from objvQuestionnaireBatchEN in arrvQuestionnaireBatchObjLst_Cache
where objvQuestionnaireBatchEN.BatchId == strBatchId
select objvQuestionnaireBatchEN;
List <clsvQuestionnaireBatchEN> arrvQuestionnaireBatchObjLst_Sel = new List<clsvQuestionnaireBatchEN>();
foreach (clsvQuestionnaireBatchEN obj in arrvQuestionnaireBatchObjLst_Sel1)
{
arrvQuestionnaireBatchObjLst_Sel.Add(obj);
}
if (arrvQuestionnaireBatchObjLst_Sel.Count > 0)
{
return arrvQuestionnaireBatchObjLst_Sel[0].BatchName;
}
string strErrMsgForGetObjById = string.Format("在vQuestionnaireBatch对象缓存列表中,找不到记录的相关名称[BatchId = {0}](函数:{1})", strBatchId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvQuestionnaireBatchBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaireBatchEN> GetObjLst(string strWhereCond)
{
 List<clsvQuestionnaireBatchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaireBatchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaireBatchEN> GetObjLstByBatchIdLst(List<string> arrBatchId)
{
 List<clsvQuestionnaireBatchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaireBatchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvQuestionnaireBatchEN> GetObjLstByBatchIdLst_Cache(List<string> arrBatchId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvQuestionnaireBatchEN._CurrTabName_S);
List<clsvQuestionnaireBatchEN> arrvQuestionnaireBatchObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQuestionnaireBatchEN> arrvQuestionnaireBatchObjLst_Sel =
from objvQuestionnaireBatchEN in arrvQuestionnaireBatchObjLst_Cache
where arrBatchId.Contains(objvQuestionnaireBatchEN.BatchId)
select objvQuestionnaireBatchEN;
return arrvQuestionnaireBatchObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaireBatchEN> GetObjLstByBatchIdLst_WA_Cache(List<string> arrBatchId)
{
 List<clsvQuestionnaireBatchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaireBatchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaireBatchEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQuestionnaireBatchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaireBatchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaireBatchEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQuestionnaireBatchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaireBatchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaireBatchEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQuestionnaireBatchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaireBatchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaireBatchEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvQuestionnaireBatchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaireBatchEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvQuestionnaireBatchENS">源对象</param>
 /// <param name = "objvQuestionnaireBatchENT">目标对象</param>
 public static void CopyTo(clsvQuestionnaireBatchEN objvQuestionnaireBatchENS, clsvQuestionnaireBatchEN objvQuestionnaireBatchENT)
{
try
{
objvQuestionnaireBatchENT.BatchId = objvQuestionnaireBatchENS.BatchId; //批次ID
objvQuestionnaireBatchENT.BatchName = objvQuestionnaireBatchENS.BatchName; //批次名称
objvQuestionnaireBatchENT.IsDefault = objvQuestionnaireBatchENS.IsDefault; //是否默认
objvQuestionnaireBatchENT.CreateDate = objvQuestionnaireBatchENS.CreateDate; //建立日期
objvQuestionnaireBatchENT.CreateUser = objvQuestionnaireBatchENS.CreateUser; //建立用户
objvQuestionnaireBatchENT.PageName = objvQuestionnaireBatchENS.PageName; //页面名称
objvQuestionnaireBatchENT.IsRandomSelSet = objvQuestionnaireBatchENS.IsRandomSelSet; //是否随机选问卷集
objvQuestionnaireBatchENT.QuestionnaireSetName = objvQuestionnaireBatchENS.QuestionnaireSetName; //问卷集名
objvQuestionnaireBatchENT.RoleName = objvQuestionnaireBatchENS.RoleName; //角色名
objvQuestionnaireBatchENT.RoleId = objvQuestionnaireBatchENS.RoleId; //角色Id
objvQuestionnaireBatchENT.QuestionnaireSetId = objvQuestionnaireBatchENS.QuestionnaireSetId; //问卷集ID
objvQuestionnaireBatchENT.Memo = objvQuestionnaireBatchENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvQuestionnaireBatchEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQuestionnaireBatchEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQuestionnaireBatchEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQuestionnaireBatchEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQuestionnaireBatchEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQuestionnaireBatchEN.AttributeName)
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
if (clsQuestionnaireSetWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireSetWApi没有刷新缓存机制(clsQuestionnaireSetWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserRolesWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserRolesWApi没有刷新缓存机制(clsUserRolesWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by BatchId");
//if (arrvQuestionnaireBatchObjLst_Cache == null)
//{
//arrvQuestionnaireBatchObjLst_Cache = await clsvQuestionnaireBatchWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvQuestionnaireBatchEN._CurrTabName_S);
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
public static List<clsvQuestionnaireBatchEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvQuestionnaireBatchEN._CurrTabName_S);
List<clsvQuestionnaireBatchEN> arrvQuestionnaireBatchObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQuestionnaireBatchObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvQuestionnaireBatchEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQuestionnaireBatch.BatchId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaireBatch.BatchName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaireBatch.IsDefault, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQuestionnaireBatch.CreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaireBatch.CreateUser, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaireBatch.PageName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaireBatch.IsRandomSelSet, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQuestionnaireBatch.QuestionnaireSetName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaireBatch.RoleName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaireBatch.RoleId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaireBatch.QuestionnaireSetId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaireBatch.Memo, Type.GetType("System.String"));
foreach (clsvQuestionnaireBatchEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQuestionnaireBatch.BatchId] = objInFor[convQuestionnaireBatch.BatchId];
objDR[convQuestionnaireBatch.BatchName] = objInFor[convQuestionnaireBatch.BatchName];
objDR[convQuestionnaireBatch.IsDefault] = objInFor[convQuestionnaireBatch.IsDefault];
objDR[convQuestionnaireBatch.CreateDate] = objInFor[convQuestionnaireBatch.CreateDate];
objDR[convQuestionnaireBatch.CreateUser] = objInFor[convQuestionnaireBatch.CreateUser];
objDR[convQuestionnaireBatch.PageName] = objInFor[convQuestionnaireBatch.PageName];
objDR[convQuestionnaireBatch.IsRandomSelSet] = objInFor[convQuestionnaireBatch.IsRandomSelSet];
objDR[convQuestionnaireBatch.QuestionnaireSetName] = objInFor[convQuestionnaireBatch.QuestionnaireSetName];
objDR[convQuestionnaireBatch.RoleName] = objInFor[convQuestionnaireBatch.RoleName];
objDR[convQuestionnaireBatch.RoleId] = objInFor[convQuestionnaireBatch.RoleId];
objDR[convQuestionnaireBatch.QuestionnaireSetId] = objInFor[convQuestionnaireBatch.QuestionnaireSetId];
objDR[convQuestionnaireBatch.Memo] = objInFor[convQuestionnaireBatch.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}